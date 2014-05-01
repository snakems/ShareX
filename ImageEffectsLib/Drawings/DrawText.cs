﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2008-2014 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using HelpersLib;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;

namespace ImageEffectsLib
{
    [Description("Text")]
    public class DrawText : ImageEffect
    {
        [DefaultValue(ContentAlignment.BottomRight)]
        public ContentAlignment Placement { get; set; }

        private Point offset;

        [DefaultValue(typeof(Point), "5, 5")]
        public Point Offset
        {
            get
            {
                return offset;
            }
            set
            {
                offset = new Point(value.X.Min(0), value.Y.Min(0));
            }
        }

        [DefaultValue(false), Description("If watermark size bigger than source image then don't draw it.")]
        public bool AutoHide { get; set; }

        [DefaultValue("getsharex.com")]
        public string Text { get; set; }

        private FontSafe textFontSafe = new FontSafe();

        // Workaround for "System.AccessViolationException: Attempted to read or write protected memory. This is often an indication that other memory is corrupt."
        [DefaultValue(typeof(Font), "Arial, 10pt")]
        public Font TextFont
        {
            get
            {
                return textFontSafe.GetFont();
            }
            set
            {
                using (value)
                {
                    textFontSafe.SetFont(value);
                }
            }
        }

        [DefaultValue(typeof(Color), "White"), Editor(typeof(MyColorEditor), typeof(UITypeEditor)), TypeConverter(typeof(MyColorConverter))]
        public Color TextColor { get; set; }

        [DefaultValue(true)]
        public bool DrawTextShadow { get; set; }

        [DefaultValue(typeof(Color), "Black"), Editor(typeof(MyColorEditor), typeof(UITypeEditor)), TypeConverter(typeof(MyColorConverter))]
        public Color TextShadowColor { get; set; }

        [DefaultValue(typeof(Point), "-1, -1")]
        public Point TextShadowOffset { get; set; }

        [DefaultValue(true)]
        public bool DrawBackground { get; set; }

        [DefaultValue(5)]
        public int BackgroundPadding { get; set; }

        private int cornerRadius;

        [DefaultValue(4)]
        public int CornerRadius
        {
            get
            {
                return cornerRadius;
            }
            set
            {
                cornerRadius = value.Min(0);
            }
        }

        [DefaultValue(typeof(Color), "Black"), Editor(typeof(MyColorEditor), typeof(UITypeEditor)), TypeConverter(typeof(MyColorConverter))]
        public Color BorderColor { get; set; }

        [DefaultValue(typeof(Color), "10, 110, 230"), Editor(typeof(MyColorEditor), typeof(UITypeEditor)), TypeConverter(typeof(MyColorConverter))]
        public Color BackgroundColor { get; set; }

        [DefaultValue(true)]
        public bool UseGradient { get; set; }

        [DefaultValue(typeof(Color), "0, 20, 40"), Editor(typeof(MyColorEditor), typeof(UITypeEditor)), TypeConverter(typeof(MyColorConverter))]
        public Color BackgroundColor2 { get; set; }

        [Browsable(false), DefaultValue(false)]
        public bool UseCustomGradient { get; set; }

        // Need custom editor
        [Browsable(false)]
        public List<GradientStop> CustomGradientList { get; set; }

        [DefaultValue(LinearGradientMode.Vertical)]
        public LinearGradientMode GradientType { get; set; }

        public DrawText()
        {
            this.ApplyDefaultPropertyValues();
        }

        public override Image Apply(Image img)
        {
            if (string.IsNullOrEmpty(Text))
            {
                return img;
            }

            using (Font textFont = TextFont)
            {
                if (textFont == null || textFont.Size < 1)
                {
                    return img;
                }

                NameParser parser = new NameParser(NameParserType.Text) { Picture = img };
                string parsedText = parser.Parse(Text);

                Size textSize = Helpers.MeasureText(parsedText, textFont);
                Size watermarkSize = new Size(textSize.Width + BackgroundPadding * 2, textSize.Height + BackgroundPadding * 2);
                Point watermarkPosition = Helpers.GetPosition(Placement, Offset, img.Size, watermarkSize);
                Rectangle watermarkRectangle = new Rectangle(watermarkPosition, watermarkSize);

                if (AutoHide && !new Rectangle(0, 0, img.Width, img.Height).Contains(watermarkRectangle))
                {
                    return img;
                }

                using (Bitmap bmpWatermark = new Bitmap(watermarkSize.Width, watermarkSize.Height))
                using (Graphics gWatermark = Graphics.FromImage(bmpWatermark))
                {
                    gWatermark.SetHighQuality();

                    if (DrawBackground)
                    {
                        using (GraphicsPath backgroundPath = new GraphicsPath())
                        {
                            Rectangle backgroundRect = new Rectangle(0, 0, watermarkSize.Width, watermarkSize.Height);
                            backgroundPath.AddRoundedRectangle(backgroundRect, CornerRadius);

                            Brush backgroundBrush = null;

                            try
                            {
                                if (UseGradient)
                                {
                                    backgroundBrush = new LinearGradientBrush(backgroundRect, BackgroundColor, BackgroundColor2, GradientType);

                                    if (UseCustomGradient && CustomGradientList != null && CustomGradientList.Count > 1)
                                    {
                                        ColorBlend colorBlend = new ColorBlend();
                                        IEnumerable<GradientStop> gradient = CustomGradientList.OrderBy(x => x.Offset);
                                        colorBlend.Colors = gradient.Select(x => x.Color).ToArray();
                                        colorBlend.Positions = gradient.Select(x => x.Offset).ToArray();
                                        ((LinearGradientBrush)backgroundBrush).InterpolationColors = colorBlend;
                                    }
                                }
                                else
                                {
                                    backgroundBrush = new SolidBrush(BackgroundColor);
                                }

                                gWatermark.FillPath(backgroundBrush, backgroundPath);
                            }
                            finally
                            {
                                if (backgroundBrush != null) backgroundBrush.Dispose();
                            }

                            using (Pen borderPen = new Pen(BorderColor))
                            {
                                gWatermark.DrawPath(borderPen, backgroundPath);
                            }
                        }
                    }

                    gWatermark.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                    using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                    {
                        float centerX = bmpWatermark.Width / 2f;
                        float centerY = bmpWatermark.Height / 2f;

                        if (DrawTextShadow)
                        {
                            using (Brush textShadowBrush = new SolidBrush(TextShadowColor))
                            {
                                gWatermark.DrawString(parsedText, textFont, textShadowBrush,
                                    centerX + TextShadowOffset.X, centerY + TextShadowOffset.Y, sf);
                            }
                        }

                        using (Brush textBrush = new SolidBrush(TextColor))
                        {
                            gWatermark.DrawString(parsedText, textFont, textBrush, centerX, centerY, sf);
                        }
                    }

                    using (Graphics gResult = Graphics.FromImage(img))
                    {
                        gResult.SetHighQuality();
                        gResult.DrawImage(bmpWatermark, watermarkRectangle);
                    }
                }
            }

            return img;
        }
    }
}