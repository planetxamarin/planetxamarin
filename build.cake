#tool "nuget:?package=xunit.runner.console"
#tool "nuget:?package=vswhere"

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target          = Argument<string>("target", "Default");
var configuration   = Argument<string>("configuration", "Release");

///////////////////////////////////////////////////////////////////////////////
// GLOBAL VARIABLES
///////////////////////////////////////////////////////////////////////////////

var solutionPath    = MakeAbsolute(File("./src/Firehose.sln"));


///////////////////////////////////////////////////////////////////////////////
// TASK DEFINITIONS
///////////////////////////////////////////////////////////////////////////////

FilePath msBuildPath;
Task("ResolveBuildTools")
    .WithCriteria(() => IsRunningOnWindows())
    .Does(() => 
{
    var vsLatest = VSWhereLatest();
    msBuildPath = (vsLatest == null)
        ? null
        : vsLatest.CombineWithFilePath("./MSBuild/15.0/Bin/MSBuild.exe");
});

Task("Restore")
    .IsDependentOn("ResolveBuildTools")
    .Does(() => 
{
    Information("Restoring {0}...", solutionPath);

    var settings = GetDefaultBuildSettings()
        .WithTarget("Restore");
    MSBuild(solutionPath, settings);
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    // Build all solutions.
    Information("Building {0}", solutionPath);

    var settings = GetDefaultBuildSettings()
        .WithTarget("Build")
        .WithProperty("TreatWarningsAsErrors","true");

    MSBuild(solutionPath, settings);
});

Task("UnitTest")
    .IsDependentOn("Build")
    .Does(() => 
{
    Information("Running Unit Tests...");
    var testPaths = GetFiles($"./src/UnitTest/bin/{configuration}/**/*UnitTest.dll");
    XUnit2(testPaths,
        new XUnit2Settings {
            XmlReport = true,
            OutputDirectory = "./build"
    });
});

Task("Default")
    .IsDependentOn("Build")
    .IsDependentOn("UnitTest");

///////////////////////////////////////////////////////////////////////////////
// EXECUTION
///////////////////////////////////////////////////////////////////////////////

RunTarget(target);

MSBuildSettings GetDefaultBuildSettings()
{
    var settings = new MSBuildSettings 
    {
        Configuration = configuration,
        ToolPath = msBuildPath,
        ArgumentCustomization = args => args.Append("/m")
    };

    return settings;
}