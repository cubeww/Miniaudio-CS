namespace Miniaudio;

public static unsafe partial class MA
{
    /// <summary>The number of compiled-in backend identifiers.</summary>
    public const int MA_BACKEND_COUNT = (int)ma_backend.ma_backend_null + 1;

    /// <summary>Compatibility alias used by the resource-manager job queue.</summary>
    public const int MA_JOB_TYPE_RESOURCE_MANAGER_QUEUE_FLAG_NON_BLOCKING
        = (int)ma_job_queue_flags.MA_JOB_QUEUE_FLAG_NON_BLOCKING;
}
