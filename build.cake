#tool "nuget:?package=xunit.runner.console"

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

Task("Restore")
    .Does(() =>
{
    Information("Restoring {0}...", solutionPath);
    NuGetRestore(solutionPath);
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    // Build all solutions.
    Information("Building {0}", solutionPath);
    MSBuild(solutionPath, settings =>
        settings.SetPlatformTarget(PlatformTarget.MSIL)
            .WithProperty("TreatWarningsAsErrors","true")
            .WithTarget("Build")
            .SetConfiguration(configuration));
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