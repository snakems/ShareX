﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2014 Thomas Braun, Jens Klingen, Robin Krom
 *
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on Sourceforge: http://sourceforge.net/projects/greenshot/
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Greenshot.Core;
using GreenshotPlugin.Core;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Greenshot.Forms
{
    public partial class TornEdgeSettingsForm : BaseForm
    {
        private TornEdgeEffect effect;

        public TornEdgeSettingsForm(TornEdgeEffect effect)
        {
            this.effect = effect;
            InitializeComponent();
            this.Icon = GreenshotResources.getGreenshotIcon();
            shadowCheckbox.Checked = effect.GenerateShadow;
            shadowDarkness.Value = (int)(effect.Darkness * 40);
            offsetX.Value = effect.ShadowOffset.X;
            offsetY.Value = effect.ShadowOffset.Y;
            toothsize.Value = effect.ToothHeight;
            verticaltoothrange.Value = effect.VerticalToothRange;
            horizontaltoothrange.Value = effect.HorizontalToothRange;
            top.Checked = effect.Edges[0];
            right.Checked = effect.Edges[1];
            bottom.Checked = effect.Edges[2];
            left.Checked = effect.Edges[3];
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            effect.Darkness = (float)shadowDarkness.Value / (float)40;
            effect.ShadowOffset = new Point((int)offsetX.Value, (int)offsetY.Value);
            effect.ShadowSize = (int)thickness.Value;
            effect.ToothHeight = (int)toothsize.Value;
            effect.VerticalToothRange = (int)verticaltoothrange.Value;
            effect.HorizontalToothRange = (int)horizontaltoothrange.Value;
            effect.Edges = new bool[] { top.Checked, right.Checked, bottom.Checked, left.Checked };
            effect.GenerateShadow = shadowCheckbox.Checked;
            DialogResult = DialogResult.OK;
        }

        private void shadowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            thickness.Enabled = shadowCheckbox.Checked;
            offsetX.Enabled = shadowCheckbox.Checked;
            offsetY.Enabled = shadowCheckbox.Checked;
            shadowDarkness.Enabled = shadowCheckbox.Checked;
        }
    }
}