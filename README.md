# DeviceFontSize plug-in for Xamarin.Forms

With this plugin for Xamarin.Forms, you have a cross-platform way to detect if an Android or iOS device has:

- accessibility fonts enabled (from extra small to XX large)
- the current font size

## Target platforms

The plugin supports Android and iOS on Xamarin.Forms

## NuGet Package

The plugin is available as a [NuGet package](https://www.nuget.org/packages/Plugin.DeviceFontSize/) for easy installation in Visual Studio.

![](https://img.shields.io/badge/NuGet-1.0.0.1-brightgreen) 

## API

The library exposes the singleton CrossDeviceFontSize class, which you access via its Current property.

You can detect if accessibility fonts are enabled like this:

    bool isEnabled = CrossDeviceFontSize.Current.HasAccessibilityFontsEnabled;                

The font size is represented via the SystemFontSize enumeration, which you retrieve via the DeviceFontSize property as follows:

    SystemFontSize currentFontSize = CrossDeviceFontSize.Current.DeviceFontSize;

The DeviceFontSize property will return one of the values from the SystemFontSize enumeration:

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
    
 The platform-specific files demonstrate how to retrieve the actual font scale. This is not returned as a cross-platform value, since it is completely platform-specific.
