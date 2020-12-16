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
        /// <summary>
        /// Return the currently selected font size on the device as a .NET enum
        /// </summary>
        public SystemFontSize DeviceFontSize
        {
            get
            {
                string sizeCategory = UIKit.UIApplication.SharedApplication.PreferredContentSizeCategory;
                switch(sizeCategory)
                {
                    case "UICTContentSizeCategoryXS":
                        return SystemFontSize.ExtraSmall;
                    case "UICTContentSizeCategoryS":
                        return SystemFontSize.Small;
                    case "UICTContentSizeCategoryM":
                        return SystemFontSize.Medium;
                    case "UICTContentSizeCategoryXL":
                        return SystemFontSize.Large;
                    case "UICTContentSizeCategoryXXL":
                        return SystemFontSize.ExtraLarge;
                    case "UICTContentSizeCategoryXXXL":
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
