using Miniaudio;

var expected = new Version(MA.MA_VERSION_MAJOR, MA.MA_VERSION_MINOR, MA.MA_VERSION_REVISION);
var actual = MiniaudioInfo.NativeVersion;

if (actual != expected)
{
    Console.Error.WriteLine($"Managed bindings target {expected}, but the native library is {actual}.");
    return 1;
}

unsafe
{
    var config = MA.ma_engine_config_init();
    config.channels = 2;
    config.sampleRate = 48_000;
    config.noDevice = 1;

    ma_engine engine = default;
    var result = MA.ma_engine_init(&config, &engine);
    if (result != ma_result.MA_SUCCESS)
    {
        Console.Error.WriteLine($"ma_engine_init failed: {result}");
        return 2;
    }

    try
    {
        if (MA.ma_engine_get_sample_rate(&engine) == 0)
        {
            Console.Error.WriteLine("The no-device engine reported an invalid sample rate.");
            return 3;
        }
    }
    finally
    {
        MA.ma_engine_uninit(&engine);
    }
}

Console.WriteLine($"miniaudio {MiniaudioInfo.NativeVersionString}: direct binding smoke test passed.");
return 0;
