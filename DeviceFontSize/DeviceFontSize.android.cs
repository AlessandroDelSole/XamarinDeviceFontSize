using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.DeviceFontSize
{
    /// <summary>
    /// Interface for DeviceFontSize
    /// </summary>
    public class DeviceFontSizeImplementation : IDeviceFontSize
    {
        private float FontScale
        {
            get
            {
                return Android.Content.Res.Resources.System.Configuration.FontScale;
            }
        }

        /// <summary>
        /// Return the currently selected font size on the device as a .NET enum
        /// </summary>
        public SystemFontSize DeviceFontSize
        {
            get
            {
                float scale = FontScale;
                switch (scale)
                {
                    case 0.85F:
                        return SystemFontSize.Small;
                    case 1.15F:
                        return SystemFontSize.Large;
                    case 1.3F:
                        return SystemFontSize.ExtraLarge;
                    case 1.30001F:
                        return SystemFontSize.Huge;
                    default:
                        return SystemFontSize.Normal;
                }
            }
        }

        /// <summary>
        /// Return true if the user has set either smaller or larger fonts than Normal on the device.
        /// </summary>
        public bool HasAccessibilityFontsEnabled
        {
            get
            {
                return DeviceFontSize != SystemFontSize.Normal;
            }
        }
    }
}
