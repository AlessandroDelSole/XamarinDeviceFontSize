using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.DeviceFontSize
{
    /// <summary>
    /// Core service to return font information
    /// </summary>
    public interface IDeviceFontSize
    {
        /// <summary>
        /// Return the currently selected font size on the device as a .NET enum
        /// </summary>
        SystemFontSize DeviceFontSize { get; }

        /// <summary>
        /// Return true if the user has set either smaller or larger fonts than Normal on the device.
        /// </summary>
        bool HasAccessibilityFontsEnabled { get; }
    }

    /// <summary>
    /// Represents the device font size
    /// </summary>
    public enum SystemFontSize
    {
        ExtraSmall,
        Small,
        Medium,
        Normal,
        Large,
        ExtraLarge,
        Huge
    }
}
