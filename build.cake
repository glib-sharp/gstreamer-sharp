#load CakeScripts\GAssembly.cs
#load CakeScripts\Settings.cs
#addin "Cake.FileHelpers"
#addin "Cake.Incubator"

// VARS

Settings.Cake = Context;
Settings.Version = "1.13.0";
Settings.BuildTarget = Argument("BuildTarget", "Default");
Settings.Assembly = Argument("Assembly", "");
var configuration = Argument("Configuration", "Release");

var msbuildsettings = new DotNetCoreMSBuildSettings();
var list = new List<GAssembly>();

// TASKS

Task("Init")
    .Does(() =>
{
    // Assign some common properties
    msbuildsettings = msbuildsettings.WithProperty("Version", Settings.Version);
    msbuildsettings = msbuildsettings.WithProperty("Authors", "'GstSharp Contributors'");
    msbuildsettings = msbuildsettings.WithProperty("PackageLicenseUrl", "'https://cgit.freedesktop.org/gstreamer/gstreamer-sharp/tree/COPYING'");

    // Add stuff to list
    Settings.Init();
    foreach(var gassembly in Settings.AssemblyList)
        if(string.IsNullOrEmpty(Settings.Assembly) || Settings.Assembly == gassembly.Name)
            list.Add(gassembly);
});

Task("Clean")
    .IsDependentOn("Init")
    .Does(() =>
{
    foreach(var gassembly in list)
        gassembly.Clean();
});

Task("FullClean")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DeleteDirectory("BuildOutput", true);
});

Task("Prepare")
    .IsDependentOn("Clean")
    .Does(() =>
{
    // Build tools
    DotNetCoreRestore("Source/Tools/gapi/Gapi.sln");
    DotNetCoreBuild("Source/Tools/gapi/Gapi.sln", new DotNetCoreBuildSettings {
        Verbosity = DotNetCoreVerbosity.Minimal,
        Configuration = configuration,
        OutputDirectory = "BuildOutput/Tools"
    });

    // Generate code and prepare libs projects
    foreach(var gassembly in list)
        gassembly.Prepare();
        
    DotNetCoreRestore("Source/Libs/GstSharp.sln");
});

Task("GenerateLinuxStubs")
    .IsDependentOn("Init")
    .Does(() => 
{
    CreateDirectory("BuildOutput/LinuxStubs");
    System.IO.Directory.SetCurrentDirectory("BuildOutput/LinuxStubs");
    FileWriteText("empty.c", "");
    foreach(var gassembly in list)
        gassembly.GenerateLinuxStubs();
    System.IO.Directory.SetCurrentDirectory("../..");
    DeleteDirectory("BuildOutput/LinuxStubs", new DeleteDirectorySettings { Recursive = true, Force = true });
});

Task("Build")
    .IsDependentOn("Prepare")
    .Does(() =>
{
    var settings = new DotNetCoreBuildSettings
    {
        Configuration = configuration,
        MSBuildSettings = msbuildsettings
    };

    if (list.Count == Settings.AssemblyList.Count)
        DotNetCoreBuild("Source/Libs/GstSharp.sln", settings);
    else
    {
        foreach(var gassembly in list)
            DotNetCoreBuild(gassembly.Csproj, settings);
    }
});

Task("PackageNuGet")
    .IsDependentOn("Build")
    .Does(() =>
{
    var settings = new DotNetCorePackSettings
    {
        MSBuildSettings = msbuildsettings,
        Configuration = configuration,
        OutputDirectory = "BuildOutput/NugetPackages",
        NoBuild = true
    };

    foreach(var gassembly in list)
        DotNetCorePack(gassembly.Csproj, settings);
});

// TASK TARGETS

Task("Default")
    .IsDependentOn("Build");

// EXECUTION

RunTarget(Settings.BuildTarget);
