using System;
using System.IO;

public class GAssembly
{
    private ICakeContext Cake;

    public bool Init { get; private set; }
    public string Name { get; private set; }
    public string Dir { get; private set; }
    public string GDir { get; private set; }
    public string Csproj { get; private set; }
    public string RawApi { get; private set; }
    public string Metadata { get; private set; }

    public string[] Deps { get; set; }
    public string[] NativeDeps { get; set; }
    public string ExtraArgs { get; set; }

    public GAssembly(string name)
    {
        Cake = Settings.Cake;
        Deps = new string[0];

        Name = name;
        Dir = Path.Combine("Source", "Libs", name);
        GDir = Path.Combine(Dir, "Generated");

        var temppath = Path.Combine(Dir, name);
        Csproj = temppath + ".csproj";
        RawApi = temppath + "-api.raw";
        Metadata = temppath + ".metadata";
    }

    public void Prepare()
    {
        Cake.CreateDirectory(GDir);

        // Raw API file found, time to generate some stuff!!!
        if (Cake.FileExists(RawApi))
        {
            // Fixup API file
            var tempapi = Path.Combine(GDir, Name + "-api.xml");
            var symfile = Path.Combine(Dir, Name + "-symbols.xml");
            Cake.CopyFile(RawApi, tempapi);
            Cake.DotNetCoreExecute("BuildOutput/Tools/GapiFixup.dll", 
                "--metadata=" + Metadata + " " + "--api=" + tempapi + 
                (Cake.FileExists(symfile) ? " --symbols=" + symfile : string.Empty)
            );

            var extraargs = ExtraArgs + " ";

            // Locate APIs to include
            foreach(var dep in Deps)
            {
                var ipath = Path.Combine("Source", "Libs", dep, dep + "-api.xml");

                if (!Cake.FileExists(ipath))
                    ipath = Path.Combine("Source", "Libs", dep, "Generated", dep + "-api.xml");

                if (Cake.FileExists(ipath))
                    extraargs += " --include=" + ipath + " ";
            }

            // Generate code
            Cake.DotNetCoreExecute("BuildOutput/Tools/GapiCodegen.dll", 
                "--outdir=" + GDir + " " +
                "--schema=Source/Libs/Gapi.xsd " +
                extraargs + " " +
                "--assembly-name=" + Name + " " +
                "--generate=" + tempapi
            );
        }

        Init = true;
    }

    public void Clean()
    {
        if (Cake.DirectoryExists(GDir))
            Cake.DeleteDirectory(GDir, new DeleteDirectorySettings { Recursive = true, Force = true });
    }

    public void GenerateLinuxStubs()
    {
        var basedir = Path.Combine("..", "..", Dir);

        if (Cake.DirectoryExists(Path.Combine(basedir, "linux-x86")))
            Cake.DeleteDirectory(Path.Combine(basedir, "linux-x86"), new DeleteDirectorySettings { Recursive = true, Force = true });
        Cake.CreateDirectory(Path.Combine(basedir, "linux-x86"));

        if (Cake.DirectoryExists(Path.Combine(basedir, "linux-x64")))
            Cake.DeleteDirectory(Path.Combine(basedir, "linux-x64"), new DeleteDirectorySettings { Recursive = true, Force = true });
        Cake.CreateDirectory(Path.Combine(basedir, "linux-x64"));

        if (Cake.DirectoryExists(Path.Combine(basedir, "linux-arm")))
            Cake.DeleteDirectory(Path.Combine(basedir, "linux-arm"), new DeleteDirectorySettings { Recursive = true, Force = true });
        Cake.CreateDirectory(Path.Combine(basedir, "linux-arm"));

        for (int i = 0; i < NativeDeps.Length; i += 2)
        {
            // Generate x86 stubs
            Cake.StartProcess("gcc", "-m32 -shared -o " + NativeDeps[i] + " empty.c");
            Cake.StartProcess("gcc", "-m32 -Wl,--no-as-needed -shared -o " + Path.Combine(basedir, "linux-x86", NativeDeps[i + 1] + ".so") + " -fPIC -L. -l:" + NativeDeps[i] + "");

            // Generate x64 stubs
            Cake.StartProcess("gcc", "-shared -o " + NativeDeps[i] + " empty.c");
            Cake.StartProcess("gcc", "-Wl,--no-as-needed -shared -o " + Path.Combine(basedir, "linux-x64", NativeDeps[i + 1] + ".so") + " -fPIC -L. -l:" + NativeDeps[i] + "");

            // Generate arm stubs
            Cake.StartProcess("arm-none-eabi-gcc", "-shared -o " + NativeDeps[i] + " empty.c");
            Cake.StartProcess("arm-none-eabi-gcc", "-Wl,--no-as-needed -shared -o " + Path.Combine(basedir, "linux-arm", NativeDeps[i + 1] + ".so") + " -fPIC -L. -l:" + NativeDeps[i] + "");
        }
    }
}
