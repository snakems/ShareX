﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2007-2014 ShareX Developers

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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ImageEffectsLib
{
    public static class ImageEffectManager
    {
        public static Image ApplyEffects(Image img, List<ImageEffect> imageEffects)
        {
            Image result = (Image)img.Clone();

            if (imageEffects != null && imageEffects.Count > 0)
            {
                result = imageEffects.Aggregate(result, (current, imageEffect) => imageEffect.Apply(current));
            }

            return result;
        }

        public static string ExportEffects(List<ImageEffect> imageEffects)
        {
            if (imageEffects != null && imageEffects.Count > 0)
            {
                try
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented,
                        TypeNameHandling = TypeNameHandling.Auto
                    };

                    return JsonConvert.SerializeObject(imageEffects, settings);
                }
                catch (Exception e)
                {
                    DebugHelper.WriteException(e);
                }
            }

            return null;
        }

        public static List<ImageEffect> ImportEffects(string json)
        {
            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    };

                    return JsonConvert.DeserializeObject<List<ImageEffect>>(json, settings);
                }
                catch (Exception e)
                {
                    DebugHelper.WriteException(e);
                }
            }

            return null;
        }
    }
}