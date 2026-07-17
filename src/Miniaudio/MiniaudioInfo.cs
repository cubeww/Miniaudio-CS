using System.Runtime.InteropServices;

namespace Miniaudio;

/// <summary>Reports the version of the bundled native miniaudio library.</summary>
public static unsafe class MiniaudioInfo
{
    /// <summary>Gets the native miniaudio version.</summary>
    public static Version NativeVersion
    {
        get
        {
            uint major;
            uint minor;
            uint revision;
            MA.ma_version(&major, &minor, &revision);
            return new Version((int)major, (int)minor, (int)revision);
        }
    }

    /// <summary>Gets the native miniaudio version string.</summary>
    public static string NativeVersionString
        => Marshal.PtrToStringUTF8((nint)MA.ma_version_string()) ?? string.Empty;
}
