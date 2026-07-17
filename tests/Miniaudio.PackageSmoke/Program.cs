using Miniaudio;

var expected = new Version(MA.MA_VERSION_MAJOR, MA.MA_VERSION_MINOR, MA.MA_VERSION_REVISION);
if (MiniaudioInfo.NativeVersion != expected)
{
    Console.Error.WriteLine("The NuGet runtime assets do not match the generated binding.");
    return 1;
}

Console.WriteLine($"NuGet runtime selection loaded miniaudio {MiniaudioInfo.NativeVersionString}.");
return 0;
