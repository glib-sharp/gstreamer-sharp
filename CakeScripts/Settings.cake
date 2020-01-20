#load GAssembly.cake

using System.Collections.Generic;

class Settings
{
    public static ICakeContext Cake { get; set; }
    public static string Version { get; set; }
    public static string BuildTarget { get; set; }
    public static string Assembly { get; set; }
    public static List<GAssembly> AssemblyList { get; set; }
    
    public static void Init()
    {
        AssemblyList = new List<GAssembly>()
        {
            new GAssembly("GstSharp")
            {
                Deps = new[] { "GLibSharp", "GioSharp" },
                NativeDeps = new[] {
                    "libgstreamer-1.0.so.0", "libgstreamer-1.0-0.dll",
                    "libgstaudio-1.0.so.0", "libgstaudio-1.0-0.dll",
                    "libgstbase-1.0.so.0", "libgstbase-1.0-0.dll",
                    "libgstvideo-1.0.so.0", "libgstvideo-1.0-0.dll",
                    "libgstpbutils-1.0.so.0", "libgstpbutils-1.0-0.dll",
                    "libgsttag-1.0.so.0", "libgsttag-1.0-0.dll",
                    "libgstapp-1.0.so.0", "libgstapp-1.0-0.dll",
                    "libgstfft-1.0.so.0", "libgstfft-1.0-0.dll",
                    "libgstnet-1.0.so.0", "libgstnet-1.0-0.dll",
                    "libgstrtp-1.0.so.0", "libgstrtp-1.0-0.dll",
                    "libgstrtsp-1.0.so.0", "libgstrtsp-1.0-0.dll",
                    "libgstsdp-1.0.so.0", "libgstsdp-1.0-0.dll",
                    "libgstcontroller-1.0.so.0", "libgstcontroller-1.0-0.dll",
                    "libglib-2.0.so.0", "libglib-2.0-0.dll",
                    "libgobject-2.0.so.0", "libgobject-2.0-0.dll",
                    "libgthread-2.0.so.0", "libgthread-2.0-0.dll",
                }
            }
        };
    }
}
