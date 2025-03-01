using System;
using System.Runtime.InteropServices;
using static Miniaudio.ma_format;

namespace Miniaudio
{
    public enum ma_log_level
    {
        MA_LOG_LEVEL_DEBUG = 4,
        MA_LOG_LEVEL_INFO = 3,
        MA_LOG_LEVEL_WARNING = 2,
        MA_LOG_LEVEL_ERROR = 1,
    }

    public enum _ma_channel_position
    {
        MA_CHANNEL_NONE = 0,
        MA_CHANNEL_MONO = 1,
        MA_CHANNEL_FRONT_LEFT = 2,
        MA_CHANNEL_FRONT_RIGHT = 3,
        MA_CHANNEL_FRONT_CENTER = 4,
        MA_CHANNEL_LFE = 5,
        MA_CHANNEL_BACK_LEFT = 6,
        MA_CHANNEL_BACK_RIGHT = 7,
        MA_CHANNEL_FRONT_LEFT_CENTER = 8,
        MA_CHANNEL_FRONT_RIGHT_CENTER = 9,
        MA_CHANNEL_BACK_CENTER = 10,
        MA_CHANNEL_SIDE_LEFT = 11,
        MA_CHANNEL_SIDE_RIGHT = 12,
        MA_CHANNEL_TOP_CENTER = 13,
        MA_CHANNEL_TOP_FRONT_LEFT = 14,
        MA_CHANNEL_TOP_FRONT_CENTER = 15,
        MA_CHANNEL_TOP_FRONT_RIGHT = 16,
        MA_CHANNEL_TOP_BACK_LEFT = 17,
        MA_CHANNEL_TOP_BACK_CENTER = 18,
        MA_CHANNEL_TOP_BACK_RIGHT = 19,
        MA_CHANNEL_AUX_0 = 20,
        MA_CHANNEL_AUX_1 = 21,
        MA_CHANNEL_AUX_2 = 22,
        MA_CHANNEL_AUX_3 = 23,
        MA_CHANNEL_AUX_4 = 24,
        MA_CHANNEL_AUX_5 = 25,
        MA_CHANNEL_AUX_6 = 26,
        MA_CHANNEL_AUX_7 = 27,
        MA_CHANNEL_AUX_8 = 28,
        MA_CHANNEL_AUX_9 = 29,
        MA_CHANNEL_AUX_10 = 30,
        MA_CHANNEL_AUX_11 = 31,
        MA_CHANNEL_AUX_12 = 32,
        MA_CHANNEL_AUX_13 = 33,
        MA_CHANNEL_AUX_14 = 34,
        MA_CHANNEL_AUX_15 = 35,
        MA_CHANNEL_AUX_16 = 36,
        MA_CHANNEL_AUX_17 = 37,
        MA_CHANNEL_AUX_18 = 38,
        MA_CHANNEL_AUX_19 = 39,
        MA_CHANNEL_AUX_20 = 40,
        MA_CHANNEL_AUX_21 = 41,
        MA_CHANNEL_AUX_22 = 42,
        MA_CHANNEL_AUX_23 = 43,
        MA_CHANNEL_AUX_24 = 44,
        MA_CHANNEL_AUX_25 = 45,
        MA_CHANNEL_AUX_26 = 46,
        MA_CHANNEL_AUX_27 = 47,
        MA_CHANNEL_AUX_28 = 48,
        MA_CHANNEL_AUX_29 = 49,
        MA_CHANNEL_AUX_30 = 50,
        MA_CHANNEL_AUX_31 = 51,
        MA_CHANNEL_LEFT = MA_CHANNEL_FRONT_LEFT,
        MA_CHANNEL_RIGHT = MA_CHANNEL_FRONT_RIGHT,
        MA_CHANNEL_POSITION_COUNT = (MA_CHANNEL_AUX_31 + 1),
    }

    public enum ma_result
    {
        MA_SUCCESS = 0,
        MA_ERROR = -1,
        MA_INVALID_ARGS = -2,
        MA_INVALID_OPERATION = -3,
        MA_OUT_OF_MEMORY = -4,
        MA_OUT_OF_RANGE = -5,
        MA_ACCESS_DENIED = -6,
        MA_DOES_NOT_EXIST = -7,
        MA_ALREADY_EXISTS = -8,
        MA_TOO_MANY_OPEN_FILES = -9,
        MA_INVALID_FILE = -10,
        MA_TOO_BIG = -11,
        MA_PATH_TOO_LONG = -12,
        MA_NAME_TOO_LONG = -13,
        MA_NOT_DIRECTORY = -14,
        MA_IS_DIRECTORY = -15,
        MA_DIRECTORY_NOT_EMPTY = -16,
        MA_AT_END = -17,
        MA_NO_SPACE = -18,
        MA_BUSY = -19,
        MA_IO_ERROR = -20,
        MA_INTERRUPT = -21,
        MA_UNAVAILABLE = -22,
        MA_ALREADY_IN_USE = -23,
        MA_BAD_ADDRESS = -24,
        MA_BAD_SEEK = -25,
        MA_BAD_PIPE = -26,
        MA_DEADLOCK = -27,
        MA_TOO_MANY_LINKS = -28,
        MA_NOT_IMPLEMENTED = -29,
        MA_NO_MESSAGE = -30,
        MA_BAD_MESSAGE = -31,
        MA_NO_DATA_AVAILABLE = -32,
        MA_INVALID_DATA = -33,
        MA_TIMEOUT = -34,
        MA_NO_NETWORK = -35,
        MA_NOT_UNIQUE = -36,
        MA_NOT_SOCKET = -37,
        MA_NO_ADDRESS = -38,
        MA_BAD_PROTOCOL = -39,
        MA_PROTOCOL_UNAVAILABLE = -40,
        MA_PROTOCOL_NOT_SUPPORTED = -41,
        MA_PROTOCOL_FAMILY_NOT_SUPPORTED = -42,
        MA_ADDRESS_FAMILY_NOT_SUPPORTED = -43,
        MA_SOCKET_NOT_SUPPORTED = -44,
        MA_CONNECTION_RESET = -45,
        MA_ALREADY_CONNECTED = -46,
        MA_NOT_CONNECTED = -47,
        MA_CONNECTION_REFUSED = -48,
        MA_NO_HOST = -49,
        MA_IN_PROGRESS = -50,
        MA_CANCELLED = -51,
        MA_MEMORY_ALREADY_MAPPED = -52,
        MA_CRC_MISMATCH = -100,
        MA_FORMAT_NOT_SUPPORTED = -200,
        MA_DEVICE_TYPE_NOT_SUPPORTED = -201,
        MA_SHARE_MODE_NOT_SUPPORTED = -202,
        MA_NO_BACKEND = -203,
        MA_NO_DEVICE = -204,
        MA_API_NOT_FOUND = -205,
        MA_INVALID_DEVICE_CONFIG = -206,
        MA_LOOP = -207,
        MA_BACKEND_NOT_ENABLED = -208,
        MA_DEVICE_NOT_INITIALIZED = -300,
        MA_DEVICE_ALREADY_INITIALIZED = -301,
        MA_DEVICE_NOT_STARTED = -302,
        MA_DEVICE_NOT_STOPPED = -303,
        MA_FAILED_TO_INIT_BACKEND = -400,
        MA_FAILED_TO_OPEN_BACKEND_DEVICE = -401,
        MA_FAILED_TO_START_BACKEND_DEVICE = -402,
        MA_FAILED_TO_STOP_BACKEND_DEVICE = -403,
    }

    public enum ma_stream_format
    {
        ma_stream_format_pcm = 0,
    }

    public enum ma_stream_layout
    {
        ma_stream_layout_interleaved = 0,
        ma_stream_layout_deinterleaved,
    }

    public enum ma_dither_mode
    {
        ma_dither_mode_none = 0,
        ma_dither_mode_rectangle,
        ma_dither_mode_triangle,
    }

    public enum ma_format
    {
        ma_format_unknown = 0,
        ma_format_u8 = 1,
        ma_format_s16 = 2,
        ma_format_s24 = 3,
        ma_format_s32 = 4,
        ma_format_f32 = 5,
        ma_format_count,
    }

    public enum ma_standard_sample_rate
    {
        ma_standard_sample_rate_48000 = 48000,
        ma_standard_sample_rate_44100 = 44100,
        ma_standard_sample_rate_32000 = 32000,
        ma_standard_sample_rate_24000 = 24000,
        ma_standard_sample_rate_22050 = 22050,
        ma_standard_sample_rate_88200 = 88200,
        ma_standard_sample_rate_96000 = 96000,
        ma_standard_sample_rate_176400 = 176400,
        ma_standard_sample_rate_192000 = 192000,
        ma_standard_sample_rate_16000 = 16000,
        ma_standard_sample_rate_11025 = 11025,
        ma_standard_sample_rate_8000 = 8000,
        ma_standard_sample_rate_352800 = 352800,
        ma_standard_sample_rate_384000 = 384000,
        ma_standard_sample_rate_min = ma_standard_sample_rate_8000,
        ma_standard_sample_rate_max = ma_standard_sample_rate_384000,
        ma_standard_sample_rate_count = 14,
    }

    public enum ma_channel_mix_mode
    {
        ma_channel_mix_mode_rectangular = 0,
        ma_channel_mix_mode_simple,
        ma_channel_mix_mode_custom_weights,
        ma_channel_mix_mode_default = ma_channel_mix_mode_rectangular,
    }

    public enum ma_standard_channel_map
    {
        ma_standard_channel_map_microsoft,
        ma_standard_channel_map_alsa,
        ma_standard_channel_map_rfc3551,
        ma_standard_channel_map_flac,
        ma_standard_channel_map_vorbis,
        ma_standard_channel_map_sound4,
        ma_standard_channel_map_sndio,
        ma_standard_channel_map_webaudio = ma_standard_channel_map_flac,
        ma_standard_channel_map_default = ma_standard_channel_map_microsoft,
    }

    public enum ma_performance_profile
    {
        ma_performance_profile_low_latency = 0,
        ma_performance_profile_conservative,
    }

    public unsafe partial struct ma_allocation_callbacks
    {
        public void* pUserData;

        [NativeTypeName("void *(*)(size_t, void *)")]
        public delegate* unmanaged[Cdecl]<nuint, void*, void*> onMalloc;

        [NativeTypeName("void *(*)(void *, size_t, void *)")]
        public delegate* unmanaged[Cdecl]<void*, nuint, void*, void*> onRealloc;

        [NativeTypeName("void (*)(void *, void *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void> onFree;
    }

    public partial struct ma_lcg
    {
        [NativeTypeName("ma_int32")]
        public int state;
    }

    public partial struct ma_atomic_uint32
    {
        [NativeTypeName("ma_uint32")]
        public uint value;
    }

    public partial struct ma_atomic_int32
    {
        [NativeTypeName("ma_int32")]
        public int value;
    }

    public partial struct ma_atomic_uint64
    {
        [NativeTypeName("ma_uint64")]
        public ulong value;
    }

    public partial struct ma_atomic_float
    {
        [NativeTypeName("ma_float")]
        public float value;
    }

    public partial struct ma_atomic_bool32
    {
        [NativeTypeName("ma_bool32")]
        public uint value;
    }

    public enum ma_thread_priority
    {
        ma_thread_priority_idle = -5,
        ma_thread_priority_lowest = -4,
        ma_thread_priority_low = -3,
        ma_thread_priority_normal = -2,
        ma_thread_priority_high = -1,
        ma_thread_priority_highest = 0,
        ma_thread_priority_realtime = 1,
        ma_thread_priority_default = 0,
    }

    public unsafe partial struct ma_log_callback
    {
        [NativeTypeName("ma_log_callback_proc")]
        public delegate* unmanaged[Cdecl]<void*, uint, sbyte*, void> onLog;

        public void* pUserData;
    }

    public unsafe partial struct ma_log
    {
        [NativeTypeName("ma_log_callback[4]")]
        public _callbacks_e__FixedBuffer callbacks;

        [NativeTypeName("ma_uint32")]
        public uint callbackCount;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("ma_mutex")]
        public void* @lock;

        public partial struct _callbacks_e__FixedBuffer
        {
            public ma_log_callback e0;
            public ma_log_callback e1;
            public ma_log_callback e2;
            public ma_log_callback e3;

            public ref ma_log_callback this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<ma_log_callback> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct ma_biquad_coefficient
    {
        [FieldOffset(0)]
        public float f32;

        [FieldOffset(0)]
        [NativeTypeName("ma_int32")]
        public int s32;
    }

    public partial struct ma_biquad_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public double b0;

        public double b1;

        public double b2;

        public double a0;

        public double a1;

        public double a2;
    }

    public unsafe partial struct ma_biquad
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_biquad_coefficient b0;

        public ma_biquad_coefficient b1;

        public ma_biquad_coefficient b2;

        public ma_biquad_coefficient a1;

        public ma_biquad_coefficient a2;

        public ma_biquad_coefficient* pR1;

        public ma_biquad_coefficient* pR2;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_lpf1_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double cutoffFrequency;

        public double q;
    }

    public unsafe partial struct ma_lpf1
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_biquad_coefficient a;

        public ma_biquad_coefficient* pR1;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_lpf2
    {
        public ma_biquad bq;
    }

    public partial struct ma_lpf_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double cutoffFrequency;

        [NativeTypeName("ma_uint32")]
        public uint order;
    }

    public unsafe partial struct ma_lpf
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint lpf1Count;

        [NativeTypeName("ma_uint32")]
        public uint lpf2Count;

        public ma_lpf1* pLPF1;

        public ma_lpf2* pLPF2;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_hpf1_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double cutoffFrequency;

        public double q;
    }

    public unsafe partial struct ma_hpf1
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_biquad_coefficient a;

        public ma_biquad_coefficient* pR1;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_hpf2
    {
        public ma_biquad bq;
    }

    public partial struct ma_hpf_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double cutoffFrequency;

        [NativeTypeName("ma_uint32")]
        public uint order;
    }

    public unsafe partial struct ma_hpf
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint hpf1Count;

        [NativeTypeName("ma_uint32")]
        public uint hpf2Count;

        public ma_hpf1* pHPF1;

        public ma_hpf2* pHPF2;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_bpf2_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double cutoffFrequency;

        public double q;
    }

    public partial struct ma_bpf2
    {
        public ma_biquad bq;
    }

    public partial struct ma_bpf_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double cutoffFrequency;

        [NativeTypeName("ma_uint32")]
        public uint order;
    }

    public unsafe partial struct ma_bpf
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint bpf2Count;

        public ma_bpf2* pBPF2;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_notch2_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double q;

        public double frequency;
    }

    public partial struct ma_notch2
    {
        public ma_biquad bq;
    }

    public partial struct ma_peak2_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double gainDB;

        public double q;

        public double frequency;
    }

    public partial struct ma_peak2
    {
        public ma_biquad bq;
    }

    public partial struct ma_loshelf2_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double gainDB;

        public double shelfSlope;

        public double frequency;
    }

    public partial struct ma_loshelf2
    {
        public ma_biquad bq;
    }

    public partial struct ma_hishelf2_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double gainDB;

        public double shelfSlope;

        public double frequency;
    }

    public partial struct ma_hishelf2
    {
        public ma_biquad bq;
    }

    public partial struct ma_delay_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint delayInFrames;

        [NativeTypeName("ma_bool32")]
        public uint delayStart;

        public float wet;

        public float dry;

        public float decay;
    }

    public unsafe partial struct ma_delay
    {
        public ma_delay_config config;

        [NativeTypeName("ma_uint32")]
        public uint cursor;

        [NativeTypeName("ma_uint32")]
        public uint bufferSizeInFrames;

        public float* pBuffer;
    }

    public partial struct ma_gainer_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint smoothTimeInFrames;
    }

    public unsafe partial struct ma_gainer
    {
        public ma_gainer_config config;

        [NativeTypeName("ma_uint32")]
        public uint t;

        public float masterVolume;

        public float* pOldGains;

        public float* pNewGains;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public enum ma_pan_mode
    {
        ma_pan_mode_balance = 0,
        ma_pan_mode_pan,
    }

    public partial struct ma_panner_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_pan_mode mode;

        public float pan;
    }

    public partial struct ma_panner
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_pan_mode mode;

        public float pan;
    }

    public partial struct ma_fader_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;
    }

    public partial struct ma_fader
    {
        public ma_fader_config config;

        public float volumeBeg;

        public float volumeEnd;

        [NativeTypeName("ma_uint64")]
        public ulong lengthInFrames;

        [NativeTypeName("ma_int64")]
        public long cursorInFrames;
    }

    public partial struct ma_vec3f
    {
        public float x;

        public float y;

        public float z;
    }

    public partial struct ma_atomic_vec3f
    {
        public ma_vec3f v;

        [NativeTypeName("ma_spinlock")]
        public uint @lock;
    }

    public enum ma_attenuation_model
    {
        ma_attenuation_model_none,
        ma_attenuation_model_inverse,
        ma_attenuation_model_linear,
        ma_attenuation_model_exponential,
    }

    public enum ma_positioning
    {
        ma_positioning_absolute,
        ma_positioning_relative,
    }

    public enum ma_handedness
    {
        ma_handedness_right,
        ma_handedness_left,
    }

    public unsafe partial struct ma_spatializer_listener_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapOut;

        public ma_handedness handedness;

        public float coneInnerAngleInRadians;

        public float coneOuterAngleInRadians;

        public float coneOuterGain;

        public float speedOfSound;

        public ma_vec3f worldUp;
    }

    public unsafe partial struct ma_spatializer_listener
    {
        public ma_spatializer_listener_config config;

        public ma_atomic_vec3f position;

        public ma_atomic_vec3f direction;

        public ma_atomic_vec3f velocity;

        [NativeTypeName("ma_bool32")]
        public uint isEnabled;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        public void* _pHeap;
    }

    public unsafe partial struct ma_spatializer_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapIn;

        public ma_attenuation_model attenuationModel;

        public ma_positioning positioning;

        public ma_handedness handedness;

        public float minGain;

        public float maxGain;

        public float minDistance;

        public float maxDistance;

        public float rolloff;

        public float coneInnerAngleInRadians;

        public float coneOuterAngleInRadians;

        public float coneOuterGain;

        public float dopplerFactor;

        public float directionalAttenuationFactor;

        public float minSpatializationChannelGain;

        [NativeTypeName("ma_uint32")]
        public uint gainSmoothTimeInFrames;
    }

    public unsafe partial struct ma_spatializer
    {
        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapIn;

        public ma_attenuation_model attenuationModel;

        public ma_positioning positioning;

        public ma_handedness handedness;

        public float minGain;

        public float maxGain;

        public float minDistance;

        public float maxDistance;

        public float rolloff;

        public float coneInnerAngleInRadians;

        public float coneOuterAngleInRadians;

        public float coneOuterGain;

        public float dopplerFactor;

        public float directionalAttenuationFactor;

        [NativeTypeName("ma_uint32")]
        public uint gainSmoothTimeInFrames;

        public ma_atomic_vec3f position;

        public ma_atomic_vec3f direction;

        public ma_atomic_vec3f velocity;

        public float dopplerPitch;

        public float minSpatializationChannelGain;

        public ma_gainer gainer;

        public float* pNewChannelGainsOut;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public partial struct ma_linear_resampler_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateIn;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateOut;

        [NativeTypeName("ma_uint32")]
        public uint lpfOrder;

        public double lpfNyquistFactor;
    }

    public unsafe partial struct ma_linear_resampler
    {
        public ma_linear_resampler_config config;

        [NativeTypeName("ma_uint32")]
        public uint inAdvanceInt;

        [NativeTypeName("ma_uint32")]
        public uint inAdvanceFrac;

        [NativeTypeName("ma_uint32")]
        public uint inTimeInt;

        [NativeTypeName("ma_uint32")]
        public uint inTimeFrac;

        [NativeTypeName("__AnonymousRecord_miniaudio_L1590_C5")]
        public _x0_e__Union x0;

        [NativeTypeName("__AnonymousRecord_miniaudio_L1595_C5")]
        public _x1_e__Union x1;

        public ma_lpf lpf;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _x0_e__Union
        {
            [FieldOffset(0)]
            public float* f32;

            [FieldOffset(0)]
            [NativeTypeName("ma_int16 *")]
            public short* s16;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _x1_e__Union
        {
            [FieldOffset(0)]
            public float* f32;

            [FieldOffset(0)]
            [NativeTypeName("ma_int16 *")]
            public short* s16;
        }
    }

    public unsafe partial struct ma_resampling_backend_vtable
    {
        [NativeTypeName("ma_result (*)(void *, const ma_resampler_config *, size_t *)")]
        public delegate* unmanaged[Cdecl]<void*, ma_resampler_config*, nuint*, ma_result> onGetHeapSize;

        [NativeTypeName("ma_result (*)(void *, const ma_resampler_config *, void *, ma_resampling_backend **)")]
        public delegate* unmanaged[Cdecl]<void*, ma_resampler_config*, void*, void**, ma_result> onInit;

        [NativeTypeName("void (*)(void *, ma_resampling_backend *, const ma_allocation_callbacks *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ma_allocation_callbacks*, void> onUninit;

        [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *, const void *, ma_uint64 *, void *, ma_uint64 *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void*, ulong*, void*, ulong*, ma_result> onProcess;

        [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *, ma_uint32, ma_uint32)")]
        public delegate* unmanaged[Cdecl]<void*, void*, uint, uint, ma_result> onSetRate;

        [NativeTypeName("ma_uint64 (*)(void *, const ma_resampling_backend *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ulong> onGetInputLatency;

        [NativeTypeName("ma_uint64 (*)(void *, const ma_resampling_backend *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ulong> onGetOutputLatency;

        [NativeTypeName("ma_result (*)(void *, const ma_resampling_backend *, ma_uint64, ma_uint64 *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ulong, ulong*, ma_result> onGetRequiredInputFrameCount;

        [NativeTypeName("ma_result (*)(void *, const ma_resampling_backend *, ma_uint64, ma_uint64 *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ulong, ulong*, ma_result> onGetExpectedOutputFrameCount;

        [NativeTypeName("ma_result (*)(void *, ma_resampling_backend *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ma_result> onReset;
    }

    public enum ma_resample_algorithm
    {
        ma_resample_algorithm_linear = 0,
        ma_resample_algorithm_custom,
    }

    public unsafe partial struct ma_resampler_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateIn;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateOut;

        public ma_resample_algorithm algorithm;

        public ma_resampling_backend_vtable* pBackendVTable;

        public void* pBackendUserData;

        [NativeTypeName("__AnonymousRecord_miniaudio_L1653_C5")]
        public _linear_e__Struct linear;

        public partial struct _linear_e__Struct
        {
            [NativeTypeName("ma_uint32")]
            public uint lpfOrder;
        }
    }

    public unsafe partial struct ma_resampler
    {
        [NativeTypeName("ma_resampling_backend *")]
        public void* pBackend;

        public ma_resampling_backend_vtable* pBackendVTable;

        public void* pBackendUserData;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateIn;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateOut;

        [NativeTypeName("__AnonymousRecord_miniaudio_L1670_C5")]
        public _state_e__Union state;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _state_e__Union
        {
            [FieldOffset(0)]
            public ma_linear_resampler linear;
        }
    }

    public enum ma_channel_conversion_path
    {
        ma_channel_conversion_path_unknown,
        ma_channel_conversion_path_passthrough,
        ma_channel_conversion_path_mono_out,
        ma_channel_conversion_path_mono_in,
        ma_channel_conversion_path_shuffle,
        ma_channel_conversion_path_weights,
    }

    public enum ma_mono_expansion_mode
    {
        ma_mono_expansion_mode_duplicate = 0,
        ma_mono_expansion_mode_average,
        ma_mono_expansion_mode_stereo_only,
        ma_mono_expansion_mode_default = ma_mono_expansion_mode_duplicate,
    }

    public unsafe partial struct ma_channel_converter_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("const ma_channel *")]
        public byte* pChannelMapIn;

        [NativeTypeName("const ma_channel *")]
        public byte* pChannelMapOut;

        public ma_channel_mix_mode mixingMode;

        [NativeTypeName("ma_bool32")]
        public uint calculateLFEFromSpatialChannels;

        public float** ppWeights;
    }

    public unsafe partial struct ma_channel_converter
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        public ma_channel_mix_mode mixingMode;

        public ma_channel_conversion_path conversionPath;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapIn;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapOut;

        [NativeTypeName("ma_uint8 *")]
        public byte* pShuffleTable;

        [NativeTypeName("__AnonymousRecord_miniaudio_L1808_C5")]
        public _weights_e__Union weights;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _weights_e__Union
        {
            [FieldOffset(0)]
            public float** f32;

            [FieldOffset(0)]
            [NativeTypeName("ma_int32 **")]
            public int** s16;
        }
    }

    public unsafe partial struct ma_data_converter_config
    {
        public ma_format formatIn;

        public ma_format formatOut;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateIn;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateOut;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapIn;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMapOut;

        public ma_dither_mode ditherMode;

        public ma_channel_mix_mode channelMixMode;

        [NativeTypeName("ma_bool32")]
        public uint calculateLFEFromSpatialChannels;

        public float** ppChannelWeights;

        [NativeTypeName("ma_bool32")]
        public uint allowDynamicSampleRate;

        public ma_resampler_config resampling;
    }

    public enum ma_data_converter_execution_path
    {
        ma_data_converter_execution_path_passthrough,
        ma_data_converter_execution_path_format_only,
        ma_data_converter_execution_path_channels_only,
        ma_data_converter_execution_path_resample_only,
        ma_data_converter_execution_path_resample_first,
        ma_data_converter_execution_path_channels_first,
    }

    public unsafe partial struct ma_data_converter
    {
        public ma_format formatIn;

        public ma_format formatOut;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateIn;

        [NativeTypeName("ma_uint32")]
        public uint sampleRateOut;

        public ma_dither_mode ditherMode;

        public ma_data_converter_execution_path executionPath;

        public ma_channel_converter channelConverter;

        public ma_resampler resampler;

        [NativeTypeName("ma_bool8")]
        public byte hasPreFormatConversion;

        [NativeTypeName("ma_bool8")]
        public byte hasPostFormatConversion;

        [NativeTypeName("ma_bool8")]
        public byte hasChannelConverter;

        [NativeTypeName("ma_bool8")]
        public byte hasResampler;

        [NativeTypeName("ma_bool8")]
        public byte isPassthrough;

        [NativeTypeName("ma_bool8")]
        public byte _ownsHeap;

        public void* _pHeap;
    }

    public unsafe partial struct ma_data_source_vtable
    {
        [NativeTypeName("ma_result (*)(ma_data_source *, void *, ma_uint64, ma_uint64 *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ulong, ulong*, ma_result> onRead;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64)")]
        public delegate* unmanaged[Cdecl]<void*, ulong, ma_result> onSeek;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_format *, ma_uint32 *, ma_uint32 *, ma_channel *, size_t)")]
        public delegate* unmanaged[Cdecl]<void*, ma_format*, uint*, uint*, byte*, nuint, ma_result> onGetDataFormat;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64 *)")]
        public delegate* unmanaged[Cdecl]<void*, ulong*, ma_result> onGetCursor;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_uint64 *)")]
        public delegate* unmanaged[Cdecl]<void*, ulong*, ma_result> onGetLength;

        [NativeTypeName("ma_result (*)(ma_data_source *, ma_bool32)")]
        public delegate* unmanaged[Cdecl]<void*, uint, ma_result> onSetLooping;

        [NativeTypeName("ma_uint32")]
        public uint flags;
    }

    public unsafe partial struct ma_data_source_config
    {
        [NativeTypeName("const ma_data_source_vtable *")]
        public ma_data_source_vtable* vtable;
    }

    public unsafe partial struct ma_data_source_base
    {
        [NativeTypeName("const ma_data_source_vtable *")]
        public ma_data_source_vtable* vtable;

        [NativeTypeName("ma_uint64")]
        public ulong rangeBegInFrames;

        [NativeTypeName("ma_uint64")]
        public ulong rangeEndInFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopBegInFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopEndInFrames;

        [NativeTypeName("ma_data_source *")]
        public void* pCurrent;

        [NativeTypeName("ma_data_source *")]
        public void* pNext;

        [NativeTypeName("ma_data_source_get_next_proc")]
        public delegate* unmanaged[Cdecl]<void*, void*> onGetNext;

        [NativeTypeName("ma_bool32")]
        public uint isLooping;
    }

    public unsafe partial struct ma_audio_buffer_ref
    {
        public ma_data_source_base ds;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint64")]
        public ulong cursor;

        [NativeTypeName("ma_uint64")]
        public ulong sizeInFrames;

        [NativeTypeName("const void *")]
        public void* pData;
    }

    public unsafe partial struct ma_audio_buffer_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint64")]
        public ulong sizeInFrames;

        [NativeTypeName("const void *")]
        public void* pData;

        public ma_allocation_callbacks allocationCallbacks;
    }

    public unsafe partial struct ma_audio_buffer
    {
        public ma_audio_buffer_ref @ref;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("ma_bool32")]
        public uint ownsData;

        [NativeTypeName("ma_uint8[1]")]
        public fixed byte _pExtraData[1];
    }

    public unsafe partial struct ma_paged_audio_buffer_page
    {
        public ma_paged_audio_buffer_page* pNext;

        [NativeTypeName("ma_uint64")]
        public ulong sizeInFrames;

        [NativeTypeName("ma_uint8[1]")]
        public fixed byte pAudioData[1];
    }

    public unsafe partial struct ma_paged_audio_buffer_data
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_paged_audio_buffer_page head;

        public ma_paged_audio_buffer_page* pTail;
    }

    public unsafe partial struct ma_paged_audio_buffer_config
    {
        public ma_paged_audio_buffer_data* pData;
    }

    public unsafe partial struct ma_paged_audio_buffer
    {
        public ma_data_source_base ds;

        public ma_paged_audio_buffer_data* pData;

        public ma_paged_audio_buffer_page* pCurrent;

        [NativeTypeName("ma_uint64")]
        public ulong relativeCursor;

        [NativeTypeName("ma_uint64")]
        public ulong absoluteCursor;
    }

    public unsafe partial struct ma_rb
    {
        public void* pBuffer;

        [NativeTypeName("ma_uint32")]
        public uint subbufferSizeInBytes;

        [NativeTypeName("ma_uint32")]
        public uint subbufferCount;

        [NativeTypeName("ma_uint32")]
        public uint subbufferStrideInBytes;

        [NativeTypeName("ma_uint32")]
        public uint encodedReadOffset;

        [NativeTypeName("ma_uint32")]
        public uint encodedWriteOffset;

        [NativeTypeName("ma_bool8")]
        public byte ownsBuffer;

        [NativeTypeName("ma_bool8")]
        public byte clearOnWriteAcquire;

        public ma_allocation_callbacks allocationCallbacks;
    }

    public partial struct ma_pcm_rb
    {
        public ma_data_source_base ds;

        public ma_rb rb;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;
    }

    public partial struct ma_duplex_rb
    {
        public ma_pcm_rb rb;
    }

    public unsafe partial struct ma_fence
    {
        [NativeTypeName("ma_event")]
        public void* e;

        [NativeTypeName("ma_uint32")]
        public uint counter;
    }

    public unsafe partial struct ma_async_notification_callbacks
    {
        [NativeTypeName("void (*)(ma_async_notification *)")]
        public delegate* unmanaged[Cdecl]<void*, void> onSignal;
    }

    public partial struct ma_async_notification_poll
    {
        public ma_async_notification_callbacks cb;

        [NativeTypeName("ma_bool32")]
        public uint signalled;
    }

    public unsafe partial struct ma_async_notification_event
    {
        public ma_async_notification_callbacks cb;

        [NativeTypeName("ma_event")]
        public void* e;
    }

    public partial struct ma_slot_allocator_config
    {
        [NativeTypeName("ma_uint32")]
        public uint capacity;
    }

    public partial struct ma_slot_allocator_group
    {
        [NativeTypeName("ma_uint32")]
        public uint bitfield;
    }

    public unsafe partial struct ma_slot_allocator
    {
        public ma_slot_allocator_group* pGroups;

        [NativeTypeName("ma_uint32 *")]
        public uint* pSlots;

        [NativeTypeName("ma_uint32")]
        public uint count;

        [NativeTypeName("ma_uint32")]
        public uint capacity;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        public void* _pHeap;
    }

    public enum ma_job_type
    {
        MA_JOB_TYPE_QUIT = 0,
        MA_JOB_TYPE_CUSTOM,
        MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_BUFFER_NODE,
        MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_BUFFER_NODE,
        MA_JOB_TYPE_RESOURCE_MANAGER_PAGE_DATA_BUFFER_NODE,
        MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_BUFFER,
        MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_BUFFER,
        MA_JOB_TYPE_RESOURCE_MANAGER_LOAD_DATA_STREAM,
        MA_JOB_TYPE_RESOURCE_MANAGER_FREE_DATA_STREAM,
        MA_JOB_TYPE_RESOURCE_MANAGER_PAGE_DATA_STREAM,
        MA_JOB_TYPE_RESOURCE_MANAGER_SEEK_DATA_STREAM,
        MA_JOB_TYPE_DEVICE_AAUDIO_REROUTE,
        MA_JOB_TYPE_COUNT,
    }

    public unsafe partial struct ma_job
    {
        [NativeTypeName("__AnonymousRecord_miniaudio_L2661_C5")]
        public _toc_e__Union toc;

        [NativeTypeName("ma_uint64")]
        public ulong next;

        [NativeTypeName("ma_uint32")]
        public uint order;

        [NativeTypeName("__AnonymousRecord_miniaudio_L2674_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _toc_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L2663_C9")]
            public _breakup_e__Struct breakup;

            [FieldOffset(0)]
            [NativeTypeName("ma_uint64")]
            public ulong allocation;

            public partial struct _breakup_e__Struct
            {
                [NativeTypeName("ma_uint16")]
                public ushort code;

                [NativeTypeName("ma_uint16")]
                public ushort slot;

                [NativeTypeName("ma_uint32")]
                public uint refcount;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L2677_C9")]
            public _custom_e__Struct custom;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L2685_C9")]
            public _resourceManager_e__Union resourceManager;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L2763_C9")]
            public _device_e__Union device;

            public unsafe partial struct _custom_e__Struct
            {
                [NativeTypeName("ma_job_proc")]
                public delegate* unmanaged[Cdecl]<ma_job*, ma_result> proc;

                [NativeTypeName("ma_uintptr")]
                public ulong data0;

                [NativeTypeName("ma_uintptr")]
                public ulong data1;
            }

            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _resourceManager_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2687_C13")]
                public _loadDataBufferNode_e__Struct loadDataBufferNode;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2699_C13")]
                public _freeDataBufferNode_e__Struct freeDataBufferNode;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2706_C13")]
                public _pageDataBufferNode_e__Struct pageDataBufferNode;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2715_C13")]
                public _loadDataBuffer_e__Struct loadDataBuffer;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2728_C13")]
                public _freeDataBuffer_e__Struct freeDataBuffer;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2735_C13")]
                public _loadDataStream_e__Struct loadDataStream;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2744_C13")]
                public _freeDataStream_e__Struct freeDataStream;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2750_C13")]
                public _pageDataStream_e__Struct pageDataStream;

                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2755_C13")]
                public _seekDataStream_e__Struct seekDataStream;

                public unsafe partial struct _loadDataBufferNode_e__Struct
                {
                    public void* pResourceManager;

                    public void* pDataBufferNode;

                    [NativeTypeName("char *")]
                    public sbyte* pFilePath;

                    [NativeTypeName("wchar_t *")]
                    public ushort* pFilePathW;

                    [NativeTypeName("ma_uint32")]
                    public uint flags;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pInitNotification;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pInitFence;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _freeDataBufferNode_e__Struct
                {
                    public void* pResourceManager;

                    public void* pDataBufferNode;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _pageDataBufferNode_e__Struct
                {
                    public void* pResourceManager;

                    public void* pDataBufferNode;

                    public void* pDecoder;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _loadDataBuffer_e__Struct
                {
                    public void* pDataBuffer;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pInitNotification;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pInitFence;

                    public ma_fence* pDoneFence;

                    [NativeTypeName("ma_uint64")]
                    public ulong rangeBegInPCMFrames;

                    [NativeTypeName("ma_uint64")]
                    public ulong rangeEndInPCMFrames;

                    [NativeTypeName("ma_uint64")]
                    public ulong loopPointBegInPCMFrames;

                    [NativeTypeName("ma_uint64")]
                    public ulong loopPointEndInPCMFrames;

                    [NativeTypeName("ma_uint32")]
                    public uint isLooping;
                }

                public unsafe partial struct _freeDataBuffer_e__Struct
                {
                    public void* pDataBuffer;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _loadDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("char *")]
                    public sbyte* pFilePath;

                    [NativeTypeName("wchar_t *")]
                    public ushort* pFilePathW;

                    [NativeTypeName("ma_uint64")]
                    public ulong initialSeekPoint;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pInitNotification;

                    public ma_fence* pInitFence;
                }

                public unsafe partial struct _freeDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("ma_async_notification *")]
                    public void* pDoneNotification;

                    public ma_fence* pDoneFence;
                }

                public unsafe partial struct _pageDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("ma_uint32")]
                    public uint pageIndex;
                }

                public unsafe partial struct _seekDataStream_e__Struct
                {
                    public void* pDataStream;

                    [NativeTypeName("ma_uint64")]
                    public ulong frameIndex;
                }
            }

            [StructLayout(LayoutKind.Explicit)]
            public unsafe partial struct _device_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_miniaudio_L2765_C13")]
                public _aaudio_e__Union aaudio;

                [StructLayout(LayoutKind.Explicit)]
                public unsafe partial struct _aaudio_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("__AnonymousRecord_miniaudio_L2767_C17")]
                    public _reroute_e__Struct reroute;

                    public unsafe partial struct _reroute_e__Struct
                    {
                        public void* pDevice;

                        [NativeTypeName("ma_uint32")]
                        public uint deviceType;
                    }
                }
            }
        }
    }

    public enum ma_job_queue_flags
    {
        MA_JOB_QUEUE_FLAG_NON_BLOCKING = 0x00000001,
    }

    public partial struct ma_job_queue_config
    {
        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint capacity;
    }

    public unsafe partial struct ma_job_queue
    {
        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint capacity;

        [NativeTypeName("ma_uint64")]
        public ulong head;

        [NativeTypeName("ma_uint64")]
        public ulong tail;

        [NativeTypeName("ma_semaphore")]
        public void* sem;

        public ma_slot_allocator allocator;

        public ma_job* pJobs;

        [NativeTypeName("ma_spinlock")]
        public uint @lock;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;
    }

    public enum ma_device_state
    {
        ma_device_state_uninitialized = 0,
        ma_device_state_stopped = 1,
        ma_device_state_started = 2,
        ma_device_state_starting = 3,
        ma_device_state_stopping = 4,
    }

    public partial struct ma_atomic_device_state
    {
        public ma_device_state value;
    }

    public unsafe partial struct ma_IMMNotificationClient
    {
        public void* lpVtbl;

        [NativeTypeName("ma_uint32")]
        public uint counter;

        public ma_device* pDevice;
    }

    public enum ma_backend
    {
        ma_backend_wasapi,
        ma_backend_dsound,
        ma_backend_winmm,
        ma_backend_coreaudio,
        ma_backend_sndio,
        ma_backend_audio4,
        ma_backend_oss,
        ma_backend_pulseaudio,
        ma_backend_alsa,
        ma_backend_jack,
        ma_backend_aaudio,
        ma_backend_opensl,
        ma_backend_webaudio,
        ma_backend_custom,
        ma_backend_null,
    }

    public partial struct ma_device_job_thread_config
    {
        [NativeTypeName("ma_bool32")]
        public uint noThread;

        [NativeTypeName("ma_uint32")]
        public uint jobQueueCapacity;

        [NativeTypeName("ma_uint32")]
        public uint jobQueueFlags;
    }

    public unsafe partial struct ma_device_job_thread
    {
        [NativeTypeName("ma_thread")]
        public void* thread;

        public ma_job_queue jobQueue;

        [NativeTypeName("ma_bool32")]
        public uint _hasThread;
    }

    public enum ma_device_notification_type
    {
        ma_device_notification_type_started,
        ma_device_notification_type_stopped,
        ma_device_notification_type_rerouted,
        ma_device_notification_type_interruption_began,
        ma_device_notification_type_interruption_ended,
        ma_device_notification_type_unlocked,
    }

    public unsafe partial struct ma_device_notification
    {
        public ma_device* pDevice;

        public ma_device_notification_type type;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3031_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3033_C9")]
            public _started_e__Struct started;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3037_C9")]
            public _stopped_e__Struct stopped;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3041_C9")]
            public _rerouted_e__Struct rerouted;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3045_C9")]
            public _interruption_e__Struct interruption;

            public partial struct _started_e__Struct
            {
                public int _unused;
            }

            public partial struct _stopped_e__Struct
            {
                public int _unused;
            }

            public partial struct _rerouted_e__Struct
            {
                public int _unused;
            }

            public partial struct _interruption_e__Struct
            {
                public int _unused;
            }
        }
    }

    public enum ma_device_type
    {
        ma_device_type_playback = 1,
        ma_device_type_capture = 2,
        ma_device_type_duplex = ma_device_type_playback | ma_device_type_capture,
        ma_device_type_loopback = 4,
    }

    public enum ma_share_mode
    {
        ma_share_mode_shared = 0,
        ma_share_mode_exclusive,
    }

    public enum ma_ios_session_category
    {
        ma_ios_session_category_default = 0,
        ma_ios_session_category_none,
        ma_ios_session_category_ambient,
        ma_ios_session_category_solo_ambient,
        ma_ios_session_category_playback,
        ma_ios_session_category_record,
        ma_ios_session_category_play_and_record,
        ma_ios_session_category_multi_route,
    }

    public enum ma_ios_session_category_option
    {
        ma_ios_session_category_option_mix_with_others = 0x01,
        ma_ios_session_category_option_duck_others = 0x02,
        ma_ios_session_category_option_allow_bluetooth = 0x04,
        ma_ios_session_category_option_default_to_speaker = 0x08,
        ma_ios_session_category_option_interrupt_spoken_audio_and_mix_with_others = 0x11,
        ma_ios_session_category_option_allow_bluetooth_a2dp = 0x20,
        ma_ios_session_category_option_allow_air_play = 0x40,
    }

    public enum ma_opensl_stream_type
    {
        ma_opensl_stream_type_default = 0,
        ma_opensl_stream_type_voice,
        ma_opensl_stream_type_system,
        ma_opensl_stream_type_ring,
        ma_opensl_stream_type_media,
        ma_opensl_stream_type_alarm,
        ma_opensl_stream_type_notification,
    }

    public enum ma_opensl_recording_preset
    {
        ma_opensl_recording_preset_default = 0,
        ma_opensl_recording_preset_generic,
        ma_opensl_recording_preset_camcorder,
        ma_opensl_recording_preset_voice_recognition,
        ma_opensl_recording_preset_voice_communication,
        ma_opensl_recording_preset_voice_unprocessed,
    }

    public enum ma_wasapi_usage
    {
        ma_wasapi_usage_default = 0,
        ma_wasapi_usage_games,
        ma_wasapi_usage_pro_audio,
    }

    public enum ma_aaudio_usage
    {
        ma_aaudio_usage_default = 0,
        ma_aaudio_usage_media,
        ma_aaudio_usage_voice_communication,
        ma_aaudio_usage_voice_communication_signalling,
        ma_aaudio_usage_alarm,
        ma_aaudio_usage_notification,
        ma_aaudio_usage_notification_ringtone,
        ma_aaudio_usage_notification_event,
        ma_aaudio_usage_assistance_accessibility,
        ma_aaudio_usage_assistance_navigation_guidance,
        ma_aaudio_usage_assistance_sonification,
        ma_aaudio_usage_game,
        ma_aaudio_usage_assitant,
        ma_aaudio_usage_emergency,
        ma_aaudio_usage_safety,
        ma_aaudio_usage_vehicle_status,
        ma_aaudio_usage_announcement,
    }

    public enum ma_aaudio_content_type
    {
        ma_aaudio_content_type_default = 0,
        ma_aaudio_content_type_speech,
        ma_aaudio_content_type_music,
        ma_aaudio_content_type_movie,
        ma_aaudio_content_type_sonification,
    }

    public enum ma_aaudio_input_preset
    {
        ma_aaudio_input_preset_default = 0,
        ma_aaudio_input_preset_generic,
        ma_aaudio_input_preset_camcorder,
        ma_aaudio_input_preset_voice_recognition,
        ma_aaudio_input_preset_voice_communication,
        ma_aaudio_input_preset_unprocessed,
        ma_aaudio_input_preset_voice_performance,
    }

    public enum ma_aaudio_allowed_capture_policy
    {
        ma_aaudio_allow_capture_default = 0,
        ma_aaudio_allow_capture_by_all,
        ma_aaudio_allow_capture_by_system,
        ma_aaudio_allow_capture_by_none,
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct ma_timer
    {
        [FieldOffset(0)]
        [NativeTypeName("ma_int64")]
        public long counter;

        [FieldOffset(0)]
        public double counterD;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct ma_device_id
    {
        [FieldOffset(0)]
        [NativeTypeName("ma_wchar_win32[64]")]
        public fixed ushort wasapi[64];

        [FieldOffset(0)]
        [NativeTypeName("ma_uint8[16]")]
        public fixed byte dsound[16];

        [FieldOffset(0)]
        [NativeTypeName("ma_uint32")]
        public uint winmm;

        [FieldOffset(0)]
        [NativeTypeName("char[256]")]
        public fixed sbyte alsa[256];

        [FieldOffset(0)]
        [NativeTypeName("char[256]")]
        public fixed sbyte pulse[256];

        [FieldOffset(0)]
        public int jack;

        [FieldOffset(0)]
        [NativeTypeName("char[256]")]
        public fixed sbyte coreaudio[256];

        [FieldOffset(0)]
        [NativeTypeName("char[256]")]
        public fixed sbyte sndio[256];

        [FieldOffset(0)]
        [NativeTypeName("char[256]")]
        public fixed sbyte audio4[256];

        [FieldOffset(0)]
        [NativeTypeName("char[64]")]
        public fixed sbyte oss[64];

        [FieldOffset(0)]
        [NativeTypeName("ma_int32")]
        public int aaudio;

        [FieldOffset(0)]
        [NativeTypeName("ma_uint32")]
        public uint opensl;

        [FieldOffset(0)]
        [NativeTypeName("char[32]")]
        public fixed sbyte webaudio[32];

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_miniaudio_L3304_C5")]
        public _custom_e__Union custom;

        [FieldOffset(0)]
        public int nullbackend;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _custom_e__Union
        {
            [FieldOffset(0)]
            public int i;

            [FieldOffset(0)]
            [NativeTypeName("char[256]")]
            public fixed sbyte s[256];

            [FieldOffset(0)]
            public void* p;
        }
    }

    public unsafe partial struct ma_device_info
    {
        public ma_device_id id;

        [NativeTypeName("char[256]")]
        public fixed sbyte name[256];

        [NativeTypeName("ma_bool32")]
        public uint isDefault;

        [NativeTypeName("ma_uint32")]
        public uint nativeDataFormatCount;

        [NativeTypeName("struct (anonymous struct at miniaudio/extras/miniaudio_split/miniaudio.h:3334:5)[64]")]
        public _nativeDataFormats_e__FixedBuffer nativeDataFormats;

        public partial struct _Anonymous_e__Struct
        {
            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_uint32")]
            public uint sampleRate;

            [NativeTypeName("ma_uint32")]
            public uint flags;
        }

        public partial struct _nativeDataFormats_e__FixedBuffer
        {
            public _Anonymous_e__Struct e0;
            public _Anonymous_e__Struct e1;
            public _Anonymous_e__Struct e2;
            public _Anonymous_e__Struct e3;
            public _Anonymous_e__Struct e4;
            public _Anonymous_e__Struct e5;
            public _Anonymous_e__Struct e6;
            public _Anonymous_e__Struct e7;
            public _Anonymous_e__Struct e8;
            public _Anonymous_e__Struct e9;
            public _Anonymous_e__Struct e10;
            public _Anonymous_e__Struct e11;
            public _Anonymous_e__Struct e12;
            public _Anonymous_e__Struct e13;
            public _Anonymous_e__Struct e14;
            public _Anonymous_e__Struct e15;
            public _Anonymous_e__Struct e16;
            public _Anonymous_e__Struct e17;
            public _Anonymous_e__Struct e18;
            public _Anonymous_e__Struct e19;
            public _Anonymous_e__Struct e20;
            public _Anonymous_e__Struct e21;
            public _Anonymous_e__Struct e22;
            public _Anonymous_e__Struct e23;
            public _Anonymous_e__Struct e24;
            public _Anonymous_e__Struct e25;
            public _Anonymous_e__Struct e26;
            public _Anonymous_e__Struct e27;
            public _Anonymous_e__Struct e28;
            public _Anonymous_e__Struct e29;
            public _Anonymous_e__Struct e30;
            public _Anonymous_e__Struct e31;
            public _Anonymous_e__Struct e32;
            public _Anonymous_e__Struct e33;
            public _Anonymous_e__Struct e34;
            public _Anonymous_e__Struct e35;
            public _Anonymous_e__Struct e36;
            public _Anonymous_e__Struct e37;
            public _Anonymous_e__Struct e38;
            public _Anonymous_e__Struct e39;
            public _Anonymous_e__Struct e40;
            public _Anonymous_e__Struct e41;
            public _Anonymous_e__Struct e42;
            public _Anonymous_e__Struct e43;
            public _Anonymous_e__Struct e44;
            public _Anonymous_e__Struct e45;
            public _Anonymous_e__Struct e46;
            public _Anonymous_e__Struct e47;
            public _Anonymous_e__Struct e48;
            public _Anonymous_e__Struct e49;
            public _Anonymous_e__Struct e50;
            public _Anonymous_e__Struct e51;
            public _Anonymous_e__Struct e52;
            public _Anonymous_e__Struct e53;
            public _Anonymous_e__Struct e54;
            public _Anonymous_e__Struct e55;
            public _Anonymous_e__Struct e56;
            public _Anonymous_e__Struct e57;
            public _Anonymous_e__Struct e58;
            public _Anonymous_e__Struct e59;
            public _Anonymous_e__Struct e60;
            public _Anonymous_e__Struct e61;
            public _Anonymous_e__Struct e62;
            public _Anonymous_e__Struct e63;

            public ref _Anonymous_e__Struct this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<_Anonymous_e__Struct> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 64);
        }
    }

    public unsafe partial struct ma_device_config
    {
        public ma_device_type deviceType;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint periodSizeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint periodSizeInMilliseconds;

        [NativeTypeName("ma_uint32")]
        public uint periods;

        public ma_performance_profile performanceProfile;

        [NativeTypeName("ma_bool8")]
        public byte noPreSilencedOutputBuffer;

        [NativeTypeName("ma_bool8")]
        public byte noClip;

        [NativeTypeName("ma_bool8")]
        public byte noDisableDenormals;

        [NativeTypeName("ma_bool8")]
        public byte noFixedSizedCallback;

        [NativeTypeName("ma_device_data_proc")]
        public delegate* unmanaged[Cdecl]<ma_device*, void*, void*, uint, void> dataCallback;

        [NativeTypeName("ma_device_notification_proc")]
        public delegate* unmanaged[Cdecl]<ma_device_notification*, void> notificationCallback;

        [NativeTypeName("ma_stop_proc")]
        public delegate* unmanaged[Cdecl]<ma_device*, void> stopCallback;

        public void* pUserData;

        public ma_resampler_config resampling;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3360_C5")]
        public _playback_e__Struct playback;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3370_C5")]
        public _capture_e__Struct capture;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3381_C5")]
        public _wasapi_e__Struct wasapi;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3391_C5")]
        public _alsa_e__Struct alsa;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3398_C5")]
        public _pulse_e__Struct pulse;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3404_C5")]
        public _coreaudio_e__Struct coreaudio;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3408_C5")]
        public _opensl_e__Struct opensl;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3414_C5")]
        public _aaudio_e__Struct aaudio;

        public unsafe partial struct _playback_e__Struct
        {
            [NativeTypeName("const ma_device_id *")]
            public ma_device_id* pDeviceID;

            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_channel *")]
            public byte* pChannelMap;

            public ma_channel_mix_mode channelMixMode;

            [NativeTypeName("ma_bool32")]
            public uint calculateLFEFromSpatialChannels;

            public ma_share_mode shareMode;
        }

        public unsafe partial struct _capture_e__Struct
        {
            [NativeTypeName("const ma_device_id *")]
            public ma_device_id* pDeviceID;

            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_channel *")]
            public byte* pChannelMap;

            public ma_channel_mix_mode channelMixMode;

            [NativeTypeName("ma_bool32")]
            public uint calculateLFEFromSpatialChannels;

            public ma_share_mode shareMode;
        }

        public partial struct _wasapi_e__Struct
        {
            public ma_wasapi_usage usage;

            [NativeTypeName("ma_bool8")]
            public byte noAutoConvertSRC;

            [NativeTypeName("ma_bool8")]
            public byte noDefaultQualitySRC;

            [NativeTypeName("ma_bool8")]
            public byte noAutoStreamRouting;

            [NativeTypeName("ma_bool8")]
            public byte noHardwareOffloading;

            [NativeTypeName("ma_uint32")]
            public uint loopbackProcessID;

            [NativeTypeName("ma_bool8")]
            public byte loopbackProcessExclude;
        }

        public partial struct _alsa_e__Struct
        {
            [NativeTypeName("ma_bool32")]
            public uint noMMap;

            [NativeTypeName("ma_bool32")]
            public uint noAutoFormat;

            [NativeTypeName("ma_bool32")]
            public uint noAutoChannels;

            [NativeTypeName("ma_bool32")]
            public uint noAutoResample;
        }

        public unsafe partial struct _pulse_e__Struct
        {
            [NativeTypeName("const char *")]
            public sbyte* pStreamNamePlayback;

            [NativeTypeName("const char *")]
            public sbyte* pStreamNameCapture;

            public int channelMap;
        }

        public partial struct _coreaudio_e__Struct
        {
            [NativeTypeName("ma_bool32")]
            public uint allowNominalSampleRateChange;
        }

        public partial struct _opensl_e__Struct
        {
            public ma_opensl_stream_type streamType;

            public ma_opensl_recording_preset recordingPreset;

            [NativeTypeName("ma_bool32")]
            public uint enableCompatibilityWorkarounds;
        }

        public partial struct _aaudio_e__Struct
        {
            public ma_aaudio_usage usage;

            public ma_aaudio_content_type contentType;

            public ma_aaudio_input_preset inputPreset;

            public ma_aaudio_allowed_capture_policy allowedCapturePolicy;

            [NativeTypeName("ma_bool32")]
            public uint noAutoStartAfterReroute;

            [NativeTypeName("ma_bool32")]
            public uint enableCompatibilityWorkarounds;

            [NativeTypeName("ma_bool32")]
            public uint allowSetBufferCapacity;
        }
    }

    public unsafe partial struct ma_device_descriptor
    {
        [NativeTypeName("const ma_device_id *")]
        public ma_device_id* pDeviceID;

        public ma_share_mode shareMode;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_channel[254]")]
        public fixed byte channelMap[254];

        [NativeTypeName("ma_uint32")]
        public uint periodSizeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint periodSizeInMilliseconds;

        [NativeTypeName("ma_uint32")]
        public uint periodCount;
    }

    public unsafe partial struct ma_backend_callbacks
    {
        [NativeTypeName("ma_result (*)(ma_context *, const ma_context_config *, ma_backend_callbacks *)")]
        public delegate* unmanaged[Cdecl]<ma_context*, ma_context_config*, ma_backend_callbacks*, ma_result> onContextInit;

        [NativeTypeName("ma_result (*)(ma_context *)")]
        public delegate* unmanaged[Cdecl]<ma_context*, ma_result> onContextUninit;

        [NativeTypeName("ma_result (*)(ma_context *, ma_enum_devices_callback_proc, void *)")]
        public delegate* unmanaged[Cdecl]<ma_context*, delegate* unmanaged[Cdecl]<ma_context*, ma_device_type, ma_device_info*, void*, uint>, void*, ma_result> onContextEnumerateDevices;

        [NativeTypeName("ma_result (*)(ma_context *, ma_device_type, const ma_device_id *, ma_device_info *)")]
        public delegate* unmanaged[Cdecl]<ma_context*, ma_device_type, ma_device_id*, ma_device_info*, ma_result> onContextGetDeviceInfo;

        [NativeTypeName("ma_result (*)(ma_device *, const ma_device_config *, ma_device_descriptor *, ma_device_descriptor *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_device_config*, ma_device_descriptor*, ma_device_descriptor*, ma_result> onDeviceInit;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceUninit;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceStart;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceStop;

        [NativeTypeName("ma_result (*)(ma_device *, void *, ma_uint32, ma_uint32 *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, void*, uint, uint*, ma_result> onDeviceRead;

        [NativeTypeName("ma_result (*)(ma_device *, const void *, ma_uint32, ma_uint32 *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, void*, uint, uint*, ma_result> onDeviceWrite;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceDataLoop;

        [NativeTypeName("ma_result (*)(ma_device *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_result> onDeviceDataLoopWakeup;

        [NativeTypeName("ma_result (*)(ma_device *, ma_device_type, ma_device_info *)")]
        public delegate* unmanaged[Cdecl]<ma_device*, ma_device_type, ma_device_info*, ma_result> onDeviceGetInfo;
    }

    public unsafe partial struct ma_context_config
    {
        public ma_log* pLog;

        public ma_thread_priority threadPriority;

        [NativeTypeName("size_t")]
        public nuint threadStackSize;

        public void* pUserData;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3558_C5")]
        public _dsound_e__Struct dsound;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3562_C5")]
        public _alsa_e__Struct alsa;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3566_C5")]
        public _pulse_e__Struct pulse;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3572_C5")]
        public _coreaudio_e__Struct coreaudio;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3579_C5")]
        public _jack_e__Struct jack;

        public ma_backend_callbacks custom;

        public unsafe partial struct _dsound_e__Struct
        {
            [NativeTypeName("ma_handle")]
            public void* hWnd;
        }

        public partial struct _alsa_e__Struct
        {
            [NativeTypeName("ma_bool32")]
            public uint useVerboseDeviceEnumeration;
        }

        public unsafe partial struct _pulse_e__Struct
        {
            [NativeTypeName("const char *")]
            public sbyte* pApplicationName;

            [NativeTypeName("const char *")]
            public sbyte* pServerName;

            [NativeTypeName("ma_bool32")]
            public uint tryAutoSpawn;
        }

        public partial struct _coreaudio_e__Struct
        {
            public ma_ios_session_category sessionCategory;

            [NativeTypeName("ma_uint32")]
            public uint sessionCategoryOptions;

            [NativeTypeName("ma_bool32")]
            public uint noAudioSessionActivate;

            [NativeTypeName("ma_bool32")]
            public uint noAudioSessionDeactivate;
        }

        public unsafe partial struct _jack_e__Struct
        {
            [NativeTypeName("const char *")]
            public sbyte* pClientName;

            [NativeTypeName("ma_bool32")]
            public uint tryStartServer;
        }
    }

    public unsafe partial struct ma_context_command__wasapi
    {
        public int code;

        [NativeTypeName("ma_event *")]
        public void** pEvent;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3592_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3594_C9")]
            public _quit_e__Struct quit;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3598_C9")]
            public _createAudioClient_e__Struct createAudioClient;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3605_C9")]
            public _releaseAudioClient_e__Struct releaseAudioClient;

            public partial struct _quit_e__Struct
            {
                public int _unused;
            }

            public unsafe partial struct _createAudioClient_e__Struct
            {
                public ma_device_type deviceType;

                public void* pAudioClient;

                public void** ppAudioClientService;

                public ma_result* pResult;
            }

            public unsafe partial struct _releaseAudioClient_e__Struct
            {
                public ma_device* pDevice;

                public ma_device_type deviceType;
            }
        }
    }

    public unsafe partial struct ma_context
    {
        public ma_backend_callbacks callbacks;

        public ma_backend backend;

        public ma_log* pLog;

        public ma_log log;

        public ma_thread_priority threadPriority;

        [NativeTypeName("size_t")]
        public nuint threadStackSize;

        public void* pUserData;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("ma_mutex")]
        public void* deviceEnumLock;

        [NativeTypeName("ma_mutex")]
        public void* deviceInfoLock;

        [NativeTypeName("ma_uint32")]
        public uint deviceInfoCapacity;

        [NativeTypeName("ma_uint32")]
        public uint playbackDeviceInfoCount;

        [NativeTypeName("ma_uint32")]
        public uint captureDeviceInfoCount;

        public ma_device_info* pDeviceInfos;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3630_C5")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_miniaudio_L3985_C5")]
        public _Anonymous2_e__Union Anonymous2;

        public ref _Anonymous1_e__Union._wasapi_e__Struct wasapi
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.wasapi, 1));
            }
        }

        public ref _Anonymous1_e__Union._dsound_e__Struct dsound
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dsound, 1));
            }
        }

        public ref _Anonymous1_e__Union._winmm_e__Struct winmm
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.winmm, 1));
            }
        }

        public ref _Anonymous1_e__Union._jack_e__Struct jack
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.jack, 1));
            }
        }

        public ref _Anonymous1_e__Union._null_backend_e__Struct null_backend
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.null_backend, 1));
            }
        }

        public ref _Anonymous2_e__Union._win32_e__Struct win32
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.win32, 1));
            }
        }

        public ref int _unused
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2._unused, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3633_C9")]
            public _wasapi_e__Struct wasapi;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3649_C9")]
            public _dsound_e__Struct dsound;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3660_C9")]
            public _winmm_e__Struct winmm;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3830_C9")]
            public _jack_e__Struct jack;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3978_C9")]
            public _null_backend_e__Struct null_backend;

            public unsafe partial struct _wasapi_e__Struct
            {
                [NativeTypeName("ma_thread")]
                public void* commandThread;

                [NativeTypeName("ma_mutex")]
                public void* commandLock;

                [NativeTypeName("ma_semaphore")]
                public void* commandSem;

                [NativeTypeName("ma_uint32")]
                public uint commandIndex;

                [NativeTypeName("ma_uint32")]
                public uint commandCount;

                [NativeTypeName("ma_context_command__wasapi[4]")]
                public _commands_e__FixedBuffer commands;

                [NativeTypeName("ma_handle")]
                public void* hAvrt;

                [NativeTypeName("ma_proc")]
                public void* AvSetMmThreadCharacteristicsA;

                [NativeTypeName("ma_proc")]
                public void* AvRevertMmThreadcharacteristics;

                [NativeTypeName("ma_handle")]
                public void* hMMDevapi;

                [NativeTypeName("ma_proc")]
                public void* ActivateAudioInterfaceAsync;

                public partial struct _commands_e__FixedBuffer
                {
                    public ma_context_command__wasapi e0;
                    public ma_context_command__wasapi e1;
                    public ma_context_command__wasapi e2;
                    public ma_context_command__wasapi e3;

                    public ref ma_context_command__wasapi this[int index]
                    {
                        get
                        {
                            return ref AsSpan()[index];
                        }
                    }

                    public Span<ma_context_command__wasapi> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
                }
            }

            public unsafe partial struct _dsound_e__Struct
            {
                [NativeTypeName("ma_handle")]
                public void* hWnd;

                [NativeTypeName("ma_handle")]
                public void* hDSoundDLL;

                [NativeTypeName("ma_proc")]
                public void* DirectSoundCreate;

                [NativeTypeName("ma_proc")]
                public void* DirectSoundEnumerateA;

                [NativeTypeName("ma_proc")]
                public void* DirectSoundCaptureCreate;

                [NativeTypeName("ma_proc")]
                public void* DirectSoundCaptureEnumerateA;
            }

            public unsafe partial struct _winmm_e__Struct
            {
                [NativeTypeName("ma_handle")]
                public void* hWinMM;

                [NativeTypeName("ma_proc")]
                public void* waveOutGetNumDevs;

                [NativeTypeName("ma_proc")]
                public void* waveOutGetDevCapsA;

                [NativeTypeName("ma_proc")]
                public void* waveOutOpen;

                [NativeTypeName("ma_proc")]
                public void* waveOutClose;

                [NativeTypeName("ma_proc")]
                public void* waveOutPrepareHeader;

                [NativeTypeName("ma_proc")]
                public void* waveOutUnprepareHeader;

                [NativeTypeName("ma_proc")]
                public void* waveOutWrite;

                [NativeTypeName("ma_proc")]
                public void* waveOutReset;

                [NativeTypeName("ma_proc")]
                public void* waveInGetNumDevs;

                [NativeTypeName("ma_proc")]
                public void* waveInGetDevCapsA;

                [NativeTypeName("ma_proc")]
                public void* waveInOpen;

                [NativeTypeName("ma_proc")]
                public void* waveInClose;

                [NativeTypeName("ma_proc")]
                public void* waveInPrepareHeader;

                [NativeTypeName("ma_proc")]
                public void* waveInUnprepareHeader;

                [NativeTypeName("ma_proc")]
                public void* waveInAddBuffer;

                [NativeTypeName("ma_proc")]
                public void* waveInStart;

                [NativeTypeName("ma_proc")]
                public void* waveInReset;
            }

            public unsafe partial struct _jack_e__Struct
            {
                [NativeTypeName("ma_handle")]
                public void* jackSO;

                [NativeTypeName("ma_proc")]
                public void* jack_client_open;

                [NativeTypeName("ma_proc")]
                public void* jack_client_close;

                [NativeTypeName("ma_proc")]
                public void* jack_client_name_size;

                [NativeTypeName("ma_proc")]
                public void* jack_set_process_callback;

                [NativeTypeName("ma_proc")]
                public void* jack_set_buffer_size_callback;

                [NativeTypeName("ma_proc")]
                public void* jack_on_shutdown;

                [NativeTypeName("ma_proc")]
                public void* jack_get_sample_rate;

                [NativeTypeName("ma_proc")]
                public void* jack_get_buffer_size;

                [NativeTypeName("ma_proc")]
                public void* jack_get_ports;

                [NativeTypeName("ma_proc")]
                public void* jack_activate;

                [NativeTypeName("ma_proc")]
                public void* jack_deactivate;

                [NativeTypeName("ma_proc")]
                public void* jack_connect;

                [NativeTypeName("ma_proc")]
                public void* jack_port_register;

                [NativeTypeName("ma_proc")]
                public void* jack_port_name;

                [NativeTypeName("ma_proc")]
                public void* jack_port_get_buffer;

                [NativeTypeName("ma_proc")]
                public void* jack_free;

                [NativeTypeName("char *")]
                public sbyte* pClientName;

                [NativeTypeName("ma_bool32")]
                public uint tryStartServer;
            }

            public partial struct _null_backend_e__Struct
            {
                public int _unused;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L3988_C9")]
            public _win32_e__Struct win32;

            [FieldOffset(0)]
            public int _unused;

            public unsafe partial struct _win32_e__Struct
            {
                [NativeTypeName("ma_handle")]
                public void* hOle32DLL;

                [NativeTypeName("ma_proc")]
                public void* CoInitialize;

                [NativeTypeName("ma_proc")]
                public void* CoInitializeEx;

                [NativeTypeName("ma_proc")]
                public void* CoUninitialize;

                [NativeTypeName("ma_proc")]
                public void* CoCreateInstance;

                [NativeTypeName("ma_proc")]
                public void* CoTaskMemFree;

                [NativeTypeName("ma_proc")]
                public void* PropVariantClear;

                [NativeTypeName("ma_proc")]
                public void* StringFromGUID2;

                [NativeTypeName("ma_handle")]
                public void* hUser32DLL;

                [NativeTypeName("ma_proc")]
                public void* GetForegroundWindow;

                [NativeTypeName("ma_proc")]
                public void* GetDesktopWindow;

                [NativeTypeName("ma_handle")]
                public void* hAdvapi32DLL;

                [NativeTypeName("ma_proc")]
                public void* RegOpenKeyExA;

                [NativeTypeName("ma_proc")]
                public void* RegCloseKey;

                [NativeTypeName("ma_proc")]
                public void* RegQueryValueExA;

                [NativeTypeName("long")]
                public int CoInitializeResult;
            }
        }
    }

    public unsafe partial struct ma_device
    {
        public ma_context* pContext;

        public ma_device_type type;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public ma_atomic_device_state state;

        [NativeTypeName("ma_device_data_proc")]
        public delegate* unmanaged[Cdecl]<ma_device*, void*, void*, uint, void> onData;

        [NativeTypeName("ma_device_notification_proc")]
        public delegate* unmanaged[Cdecl]<ma_device_notification*, void> onNotification;

        [NativeTypeName("ma_stop_proc")]
        public delegate* unmanaged[Cdecl]<ma_device*, void> onStop;

        public void* pUserData;

        [NativeTypeName("ma_mutex")]
        public void* startStopLock;

        [NativeTypeName("ma_event")]
        public void* wakeupEvent;

        [NativeTypeName("ma_event")]
        public void* startEvent;

        [NativeTypeName("ma_event")]
        public void* stopEvent;

        [NativeTypeName("ma_thread")]
        public void* thread;

        public ma_result workResult;

        [NativeTypeName("ma_bool8")]
        public byte isOwnerOfContext;

        [NativeTypeName("ma_bool8")]
        public byte noPreSilencedOutputBuffer;

        [NativeTypeName("ma_bool8")]
        public byte noClip;

        [NativeTypeName("ma_bool8")]
        public byte noDisableDenormals;

        [NativeTypeName("ma_bool8")]
        public byte noFixedSizedCallback;

        public ma_atomic_float masterVolumeFactor;

        public ma_duplex_rb duplexRB;

        [NativeTypeName("__AnonymousRecord_miniaudio_L4044_C5")]
        public _resampling_e__Struct resampling;

        [NativeTypeName("__AnonymousRecord_miniaudio_L4054_C5")]
        public _playback_e__Struct playback;

        [NativeTypeName("__AnonymousRecord_miniaudio_L4080_C5")]
        public _capture_e__Struct capture;

        [NativeTypeName("__AnonymousRecord_miniaudio_L4103_C5")]
        public _Anonymous4_e__Union Anonymous4;

        public ref _Anonymous4_e__Union._wasapi_e__Struct wasapi
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.wasapi, 1));
            }
        }

        public ref _Anonymous4_e__Union._dsound_e__Struct dsound
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.dsound, 1));
            }
        }

        public ref _Anonymous4_e__Union._winmm_e__Struct winmm
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.winmm, 1));
            }
        }

        public ref _Anonymous4_e__Union._jack_e__Struct jack
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.jack, 1));
            }
        }

        public ref _Anonymous4_e__Union._null_device_e__Struct null_device
        {
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous4.null_device, 1));
            }
        }

        public unsafe partial struct _resampling_e__Struct
        {
            public ma_resample_algorithm algorithm;

            public ma_resampling_backend_vtable* pBackendVTable;

            public void* pBackendUserData;

            [NativeTypeName("__AnonymousRecord_miniaudio_L4049_C9")]
            public _linear_e__Struct linear;

            public partial struct _linear_e__Struct
            {
                [NativeTypeName("ma_uint32")]
                public uint lpfOrder;
            }
        }

        public unsafe partial struct _playback_e__Struct
        {
            public ma_device_id* pID;

            public ma_device_id id;

            [NativeTypeName("char[256]")]
            public fixed sbyte name[256];

            public ma_share_mode shareMode;

            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_channel[254]")]
            public fixed byte channelMap[254];

            public ma_format internalFormat;

            [NativeTypeName("ma_uint32")]
            public uint internalChannels;

            [NativeTypeName("ma_uint32")]
            public uint internalSampleRate;

            [NativeTypeName("ma_channel[254]")]
            public fixed byte internalChannelMap[254];

            [NativeTypeName("ma_uint32")]
            public uint internalPeriodSizeInFrames;

            [NativeTypeName("ma_uint32")]
            public uint internalPeriods;

            public ma_channel_mix_mode channelMixMode;

            [NativeTypeName("ma_bool32")]
            public uint calculateLFEFromSpatialChannels;

            public ma_data_converter converter;

            public void* pIntermediaryBuffer;

            [NativeTypeName("ma_uint32")]
            public uint intermediaryBufferCap;

            [NativeTypeName("ma_uint32")]
            public uint intermediaryBufferLen;

            public void* pInputCache;

            [NativeTypeName("ma_uint64")]
            public ulong inputCacheCap;

            [NativeTypeName("ma_uint64")]
            public ulong inputCacheConsumed;

            [NativeTypeName("ma_uint64")]
            public ulong inputCacheRemaining;
        }

        public unsafe partial struct _capture_e__Struct
        {
            public ma_device_id* pID;

            public ma_device_id id;

            [NativeTypeName("char[256]")]
            public fixed sbyte name[256];

            public ma_share_mode shareMode;

            public ma_format format;

            [NativeTypeName("ma_uint32")]
            public uint channels;

            [NativeTypeName("ma_channel[254]")]
            public fixed byte channelMap[254];

            public ma_format internalFormat;

            [NativeTypeName("ma_uint32")]
            public uint internalChannels;

            [NativeTypeName("ma_uint32")]
            public uint internalSampleRate;

            [NativeTypeName("ma_channel[254]")]
            public fixed byte internalChannelMap[254];

            [NativeTypeName("ma_uint32")]
            public uint internalPeriodSizeInFrames;

            [NativeTypeName("ma_uint32")]
            public uint internalPeriods;

            public ma_channel_mix_mode channelMixMode;

            [NativeTypeName("ma_bool32")]
            public uint calculateLFEFromSpatialChannels;

            public ma_data_converter converter;

            public void* pIntermediaryBuffer;

            [NativeTypeName("ma_uint32")]
            public uint intermediaryBufferCap;

            [NativeTypeName("ma_uint32")]
            public uint intermediaryBufferLen;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L4106_C9")]
            public _wasapi_e__Struct wasapi;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L4147_C9")]
            public _dsound_e__Struct dsound;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L4157_C9")]
            public _winmm_e__Struct winmm;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L4200_C9")]
            public _jack_e__Struct jack;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L4298_C9")]
            public _null_device_e__Struct null_device;

            public unsafe partial struct _wasapi_e__Struct
            {
                [NativeTypeName("ma_ptr")]
                public void* pAudioClientPlayback;

                [NativeTypeName("ma_ptr")]
                public void* pAudioClientCapture;

                [NativeTypeName("ma_ptr")]
                public void* pRenderClient;

                [NativeTypeName("ma_ptr")]
                public void* pCaptureClient;

                [NativeTypeName("ma_ptr")]
                public void* pDeviceEnumerator;

                public ma_IMMNotificationClient notificationClient;

                [NativeTypeName("ma_handle")]
                public void* hEventPlayback;

                [NativeTypeName("ma_handle")]
                public void* hEventCapture;

                [NativeTypeName("ma_uint32")]
                public uint actualBufferSizeInFramesPlayback;

                [NativeTypeName("ma_uint32")]
                public uint actualBufferSizeInFramesCapture;

                [NativeTypeName("ma_uint32")]
                public uint originalPeriodSizeInFrames;

                [NativeTypeName("ma_uint32")]
                public uint originalPeriodSizeInMilliseconds;

                [NativeTypeName("ma_uint32")]
                public uint originalPeriods;

                public ma_performance_profile originalPerformanceProfile;

                [NativeTypeName("ma_uint32")]
                public uint periodSizeInFramesPlayback;

                [NativeTypeName("ma_uint32")]
                public uint periodSizeInFramesCapture;

                public void* pMappedBufferCapture;

                [NativeTypeName("ma_uint32")]
                public uint mappedBufferCaptureCap;

                [NativeTypeName("ma_uint32")]
                public uint mappedBufferCaptureLen;

                public void* pMappedBufferPlayback;

                [NativeTypeName("ma_uint32")]
                public uint mappedBufferPlaybackCap;

                [NativeTypeName("ma_uint32")]
                public uint mappedBufferPlaybackLen;

                public ma_atomic_bool32 isStartedCapture;

                public ma_atomic_bool32 isStartedPlayback;

                [NativeTypeName("ma_uint32")]
                public uint loopbackProcessID;

                [NativeTypeName("ma_bool8")]
                public byte loopbackProcessExclude;

                [NativeTypeName("ma_bool8")]
                public byte noAutoConvertSRC;

                [NativeTypeName("ma_bool8")]
                public byte noDefaultQualitySRC;

                [NativeTypeName("ma_bool8")]
                public byte noHardwareOffloading;

                [NativeTypeName("ma_bool8")]
                public byte allowCaptureAutoStreamRouting;

                [NativeTypeName("ma_bool8")]
                public byte allowPlaybackAutoStreamRouting;

                [NativeTypeName("ma_bool8")]
                public byte isDetachedPlayback;

                [NativeTypeName("ma_bool8")]
                public byte isDetachedCapture;

                public ma_wasapi_usage usage;

                public void* hAvrtHandle;

                [NativeTypeName("ma_mutex")]
                public void* rerouteLock;
            }

            public unsafe partial struct _dsound_e__Struct
            {
                [NativeTypeName("ma_ptr")]
                public void* pPlayback;

                [NativeTypeName("ma_ptr")]
                public void* pPlaybackPrimaryBuffer;

                [NativeTypeName("ma_ptr")]
                public void* pPlaybackBuffer;

                [NativeTypeName("ma_ptr")]
                public void* pCapture;

                [NativeTypeName("ma_ptr")]
                public void* pCaptureBuffer;
            }

            public unsafe partial struct _winmm_e__Struct
            {
                [NativeTypeName("ma_handle")]
                public void* hDevicePlayback;

                [NativeTypeName("ma_handle")]
                public void* hDeviceCapture;

                [NativeTypeName("ma_handle")]
                public void* hEventPlayback;

                [NativeTypeName("ma_handle")]
                public void* hEventCapture;

                [NativeTypeName("ma_uint32")]
                public uint fragmentSizeInFrames;

                [NativeTypeName("ma_uint32")]
                public uint iNextHeaderPlayback;

                [NativeTypeName("ma_uint32")]
                public uint iNextHeaderCapture;

                [NativeTypeName("ma_uint32")]
                public uint headerFramesConsumedPlayback;

                [NativeTypeName("ma_uint32")]
                public uint headerFramesConsumedCapture;

                [NativeTypeName("ma_uint8 *")]
                public byte* pWAVEHDRPlayback;

                [NativeTypeName("ma_uint8 *")]
                public byte* pWAVEHDRCapture;

                [NativeTypeName("ma_uint8 *")]
                public byte* pIntermediaryBufferPlayback;

                [NativeTypeName("ma_uint8 *")]
                public byte* pIntermediaryBufferCapture;

                [NativeTypeName("ma_uint8 *")]
                public byte* _pHeapData;
            }

            public unsafe partial struct _jack_e__Struct
            {
                [NativeTypeName("ma_ptr")]
                public void* pClient;

                [NativeTypeName("ma_ptr *")]
                public void** ppPortsPlayback;

                [NativeTypeName("ma_ptr *")]
                public void** ppPortsCapture;

                public float* pIntermediaryBufferPlayback;

                public float* pIntermediaryBufferCapture;
            }

            public unsafe partial struct _null_device_e__Struct
            {
                [NativeTypeName("ma_thread")]
                public void* deviceThread;

                [NativeTypeName("ma_event")]
                public void* operationEvent;

                [NativeTypeName("ma_event")]
                public void* operationCompletionEvent;

                [NativeTypeName("ma_semaphore")]
                public void* operationSemaphore;

                [NativeTypeName("ma_uint32")]
                public uint operation;

                public ma_result operationResult;

                public ma_timer timer;

                public double priorRunTime;

                [NativeTypeName("ma_uint32")]
                public uint currentPeriodFramesRemainingPlayback;

                [NativeTypeName("ma_uint32")]
                public uint currentPeriodFramesRemainingCapture;

                [NativeTypeName("ma_uint64")]
                public ulong lastProcessedFramePlayback;

                [NativeTypeName("ma_uint64")]
                public ulong lastProcessedFrameCapture;

                public ma_atomic_bool32 isStarted;
            }
        }
    }

    public enum ma_open_mode_flags
    {
        MA_OPEN_MODE_READ = 0x00000001,
        MA_OPEN_MODE_WRITE = 0x00000002,
    }

    public enum ma_seek_origin
    {
        ma_seek_origin_start,
        ma_seek_origin_current,
        ma_seek_origin_end,
    }

    public partial struct ma_file_info
    {
        [NativeTypeName("ma_uint64")]
        public ulong sizeInBytes;
    }

    public unsafe partial struct ma_vfs_callbacks
    {
        [NativeTypeName("ma_result (*)(ma_vfs *, const char *, ma_uint32, ma_vfs_file *)")]
        public delegate* unmanaged[Cdecl]<void*, sbyte*, uint, void**, ma_result> onOpen;

        [NativeTypeName("ma_result (*)(ma_vfs *, const wchar_t *, ma_uint32, ma_vfs_file *)")]
        public delegate* unmanaged[Cdecl]<void*, ushort*, uint, void**, ma_result> onOpenW;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ma_result> onClose;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, void *, size_t, size_t *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void*, nuint, nuint*, ma_result> onRead;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, const void *, size_t, size_t *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void*, nuint, nuint*, ma_result> onWrite;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_int64, ma_seek_origin)")]
        public delegate* unmanaged[Cdecl]<void*, void*, long, ma_seek_origin, ma_result> onSeek;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_int64 *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, long*, ma_result> onTell;

        [NativeTypeName("ma_result (*)(ma_vfs *, ma_vfs_file, ma_file_info *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ma_file_info*, ma_result> onInfo;
    }

    public partial struct ma_default_vfs
    {
        public ma_vfs_callbacks cb;

        public ma_allocation_callbacks allocationCallbacks;
    }

    public enum ma_encoding_format
    {
        ma_encoding_format_unknown = 0,
        ma_encoding_format_wav,
        ma_encoding_format_flac,
        ma_encoding_format_mp3,
        ma_encoding_format_vorbis,
    }

    public partial struct ma_decoding_backend_config
    {
        public ma_format preferredFormat;

        [NativeTypeName("ma_uint32")]
        public uint seekPointCount;
    }

    public unsafe partial struct ma_decoding_backend_vtable
    {
        [NativeTypeName("ma_result (*)(void *, ma_read_proc, ma_seek_proc, ma_tell_proc, void *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public delegate* unmanaged[Cdecl]<void*, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint*, ma_result>, delegate* unmanaged[Cdecl]<void*, long, ma_seek_origin, ma_result>, delegate* unmanaged[Cdecl]<void*, long*, ma_result>, void*, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInit;

        [NativeTypeName("ma_result (*)(void *, const char *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public delegate* unmanaged[Cdecl]<void*, sbyte*, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInitFile;

        [NativeTypeName("ma_result (*)(void *, const wchar_t *, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public delegate* unmanaged[Cdecl]<void*, ushort*, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInitFileW;

        [NativeTypeName("ma_result (*)(void *, const void *, size_t, const ma_decoding_backend_config *, const ma_allocation_callbacks *, ma_data_source **)")]
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, ma_decoding_backend_config*, ma_allocation_callbacks*, void**, ma_result> onInitMemory;

        [NativeTypeName("void (*)(void *, ma_data_source *, const ma_allocation_callbacks *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, ma_allocation_callbacks*, void> onUninit;
    }

    public unsafe partial struct ma_decoder_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_channel *")]
        public byte* pChannelMap;

        public ma_channel_mix_mode channelMixMode;

        public ma_dither_mode ditherMode;

        public ma_resampler_config resampling;

        public ma_allocation_callbacks allocationCallbacks;

        public ma_encoding_format encodingFormat;

        [NativeTypeName("ma_uint32")]
        public uint seekPointCount;

        public ma_decoding_backend_vtable** ppCustomBackendVTables;

        [NativeTypeName("ma_uint32")]
        public uint customBackendCount;

        public void* pCustomBackendUserData;
    }

    public unsafe partial struct ma_decoder
    {
        public ma_data_source_base ds;

        [NativeTypeName("ma_data_source *")]
        public void* pBackend;

        [NativeTypeName("const ma_decoding_backend_vtable *")]
        public ma_decoding_backend_vtable* pBackendVTable;

        public void* pBackendUserData;

        [NativeTypeName("ma_decoder_read_proc")]
        public delegate* unmanaged[Cdecl]<ma_decoder*, void*, nuint, nuint*, ma_result> onRead;

        [NativeTypeName("ma_decoder_seek_proc")]
        public delegate* unmanaged[Cdecl]<ma_decoder*, long, ma_seek_origin, ma_result> onSeek;

        [NativeTypeName("ma_decoder_tell_proc")]
        public delegate* unmanaged[Cdecl]<ma_decoder*, long*, ma_result> onTell;

        public void* pUserData;

        [NativeTypeName("ma_uint64")]
        public ulong readPointerInPCMFrames;

        public ma_format outputFormat;

        [NativeTypeName("ma_uint32")]
        public uint outputChannels;

        [NativeTypeName("ma_uint32")]
        public uint outputSampleRate;

        public ma_data_converter converter;

        public void* pInputCache;

        [NativeTypeName("ma_uint64")]
        public ulong inputCacheCap;

        [NativeTypeName("ma_uint64")]
        public ulong inputCacheConsumed;

        [NativeTypeName("ma_uint64")]
        public ulong inputCacheRemaining;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("__AnonymousRecord_miniaudio_L6257_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6259_C9")]
            public _vfs_e__Struct vfs;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6264_C9")]
            public _memory_e__Struct memory;

            public unsafe partial struct _vfs_e__Struct
            {
                [NativeTypeName("ma_vfs *")]
                public void* pVFS;

                [NativeTypeName("ma_vfs_file")]
                public void* file;
            }

            public unsafe partial struct _memory_e__Struct
            {
                [NativeTypeName("const ma_uint8 *")]
                public byte* pData;

                [NativeTypeName("size_t")]
                public nuint dataSize;

                [NativeTypeName("size_t")]
                public nuint currentReadPos;
            }
        }
    }

    public partial struct ma_encoder_config
    {
        public ma_encoding_format encodingFormat;

        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public ma_allocation_callbacks allocationCallbacks;
    }

    public unsafe partial struct ma_encoder
    {
        public ma_encoder_config config;

        [NativeTypeName("ma_encoder_write_proc")]
        public delegate* unmanaged[Cdecl]<ma_encoder*, void*, nuint, nuint*, ma_result> onWrite;

        [NativeTypeName("ma_encoder_seek_proc")]
        public delegate* unmanaged[Cdecl]<ma_encoder*, long, ma_seek_origin, ma_result> onSeek;

        [NativeTypeName("ma_encoder_init_proc")]
        public delegate* unmanaged[Cdecl]<ma_encoder*, ma_result> onInit;

        [NativeTypeName("ma_encoder_uninit_proc")]
        public delegate* unmanaged[Cdecl]<ma_encoder*, void> onUninit;

        [NativeTypeName("ma_encoder_write_pcm_frames_proc")]
        public delegate* unmanaged[Cdecl]<ma_encoder*, void*, ulong, ulong*, ma_result> onWritePCMFrames;

        public void* pUserData;

        public void* pInternalEncoder;

        [NativeTypeName("__AnonymousRecord_miniaudio_L6388_C5")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6390_C9")]
            public _vfs_e__Struct vfs;

            public unsafe partial struct _vfs_e__Struct
            {
                [NativeTypeName("ma_vfs *")]
                public void* pVFS;

                [NativeTypeName("ma_vfs_file")]
                public void* file;
            }
        }
    }

    public enum ma_waveform_type
    {
        ma_waveform_type_sine,
        ma_waveform_type_square,
        ma_waveform_type_triangle,
        ma_waveform_type_sawtooth,
    }

    public partial struct ma_waveform_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public ma_waveform_type type;

        public double amplitude;

        public double frequency;
    }

    public partial struct ma_waveform
    {
        public ma_data_source_base ds;

        public ma_waveform_config config;

        public double advance;

        public double time;
    }

    public partial struct ma_pulsewave_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        public double dutyCycle;

        public double amplitude;

        public double frequency;
    }

    public partial struct ma_pulsewave
    {
        public ma_waveform waveform;

        public ma_pulsewave_config config;
    }

    public enum ma_noise_type
    {
        ma_noise_type_white,
        ma_noise_type_pink,
        ma_noise_type_brownian,
    }

    public partial struct ma_noise_config
    {
        public ma_format format;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        public ma_noise_type type;

        [NativeTypeName("ma_int32")]
        public int seed;

        public double amplitude;

        [NativeTypeName("ma_bool32")]
        public uint duplicateChannels;
    }

    public unsafe partial struct ma_noise
    {
        public ma_data_source_base ds;

        public ma_noise_config config;

        public ma_lcg lcg;

        [NativeTypeName("__AnonymousRecord_miniaudio_L6504_C5")]
        public _state_e__Union state;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _state_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6506_C9")]
            public _pink_e__Struct pink;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6512_C9")]
            public _brownian_e__Struct brownian;

            public unsafe partial struct _pink_e__Struct
            {
                public double** bin;

                public double* accumulation;

                [NativeTypeName("ma_uint32 *")]
                public uint* counter;
            }

            public unsafe partial struct _brownian_e__Struct
            {
                public double* accumulation;
            }
        }
    }

    public enum ma_resource_manager_data_source_flags
    {
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_STREAM = 0x00000001,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_DECODE = 0x00000002,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_ASYNC = 0x00000004,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_WAIT_INIT = 0x00000008,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_UNKNOWN_LENGTH = 0x00000010,
        MA_RESOURCE_MANAGER_DATA_SOURCE_FLAG_LOOPING = 0x00000020,
    }

    public unsafe partial struct ma_resource_manager_pipeline_stage_notification
    {
        [NativeTypeName("ma_async_notification *")]
        public void* pNotification;

        public ma_fence* pFence;
    }

    public partial struct ma_resource_manager_pipeline_notifications
    {
        public ma_resource_manager_pipeline_stage_notification init;

        public ma_resource_manager_pipeline_stage_notification done;
    }

    public enum ma_resource_manager_flags
    {
        MA_RESOURCE_MANAGER_FLAG_NON_BLOCKING = 0x00000001,
        MA_RESOURCE_MANAGER_FLAG_NO_THREADING = 0x00000002,
    }

    public unsafe partial struct ma_resource_manager_data_source_config
    {
        [NativeTypeName("const char *")]
        public sbyte* pFilePath;

        [NativeTypeName("const wchar_t *")]
        public ushort* pFilePathW;

        [NativeTypeName("const ma_resource_manager_pipeline_notifications *")]
        public ma_resource_manager_pipeline_notifications* pNotifications;

        [NativeTypeName("ma_uint64")]
        public ulong initialSeekPointInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong rangeBegInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong rangeEndInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopPointBegInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopPointEndInPCMFrames;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_bool32")]
        public uint isLooping;
    }

    public enum ma_resource_manager_data_supply_type
    {
        ma_resource_manager_data_supply_type_unknown = 0,
        ma_resource_manager_data_supply_type_encoded,
        ma_resource_manager_data_supply_type_decoded,
        ma_resource_manager_data_supply_type_decoded_paged,
    }

    public unsafe partial struct ma_resource_manager_data_supply
    {
        public ma_resource_manager_data_supply_type type;

        [NativeTypeName("__AnonymousRecord_miniaudio_L6646_C5")]
        public _backend_e__Union backend;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _backend_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6648_C9")]
            public _encoded_e__Struct encoded;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6653_C9")]
            public _decoded_e__Struct decoded;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_miniaudio_L6662_C9")]
            public _decodedPaged_e__Struct decodedPaged;

            public unsafe partial struct _encoded_e__Struct
            {
                [NativeTypeName("const void *")]
                public void* pData;

                [NativeTypeName("size_t")]
                public nuint sizeInBytes;
            }

            public unsafe partial struct _decoded_e__Struct
            {
                [NativeTypeName("const void *")]
                public void* pData;

                [NativeTypeName("ma_uint64")]
                public ulong totalFrameCount;

                [NativeTypeName("ma_uint64")]
                public ulong decodedFrameCount;

                public ma_format format;

                [NativeTypeName("ma_uint32")]
                public uint channels;

                [NativeTypeName("ma_uint32")]
                public uint sampleRate;
            }

            public partial struct _decodedPaged_e__Struct
            {
                public ma_paged_audio_buffer_data data;

                [NativeTypeName("ma_uint64")]
                public ulong decodedFrameCount;

                [NativeTypeName("ma_uint32")]
                public uint sampleRate;
            }
        }
    }

    public unsafe partial struct ma_resource_manager_data_buffer_node
    {
        [NativeTypeName("ma_uint32")]
        public uint hashedName32;

        [NativeTypeName("ma_uint32")]
        public uint refCount;

        public ma_result result;

        [NativeTypeName("ma_uint32")]
        public uint executionCounter;

        [NativeTypeName("ma_uint32")]
        public uint executionPointer;

        [NativeTypeName("ma_bool32")]
        public uint isDataOwnedByResourceManager;

        public ma_resource_manager_data_supply data;

        public ma_resource_manager_data_buffer_node* pParent;

        public ma_resource_manager_data_buffer_node* pChildLo;

        public ma_resource_manager_data_buffer_node* pChildHi;
    }

    public unsafe partial struct ma_resource_manager_data_buffer
    {
        public ma_data_source_base ds;

        public ma_resource_manager* pResourceManager;

        public ma_resource_manager_data_buffer_node* pNode;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint executionCounter;

        [NativeTypeName("ma_uint32")]
        public uint executionPointer;

        [NativeTypeName("ma_uint64")]
        public ulong seekTargetInPCMFrames;

        [NativeTypeName("ma_bool32")]
        public uint seekToCursorOnNextRead;

        public ma_result result;

        [NativeTypeName("ma_bool32")]
        public uint isLooping;

        public ma_atomic_bool32 isConnectorInitialized;

        [NativeTypeName("__AnonymousRecord_miniaudio_L6698_C5")]
        public _connector_e__Union connector;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _connector_e__Union
        {
            [FieldOffset(0)]
            public ma_decoder decoder;

            [FieldOffset(0)]
            public ma_audio_buffer buffer;

            [FieldOffset(0)]
            public ma_paged_audio_buffer pagedBuffer;
        }
    }

    public unsafe partial struct ma_resource_manager_data_stream
    {
        public ma_data_source_base ds;

        public ma_resource_manager* pResourceManager;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        public ma_decoder decoder;

        [NativeTypeName("ma_bool32")]
        public uint isDecoderInitialized;

        [NativeTypeName("ma_uint64")]
        public ulong totalLengthInPCMFrames;

        [NativeTypeName("ma_uint32")]
        public uint relativeCursor;

        [NativeTypeName("ma_uint64")]
        public ulong absoluteCursor;

        [NativeTypeName("ma_uint32")]
        public uint currentPageIndex;

        [NativeTypeName("ma_uint32")]
        public uint executionCounter;

        [NativeTypeName("ma_uint32")]
        public uint executionPointer;

        [NativeTypeName("ma_bool32")]
        public uint isLooping;

        public void* pPageData;

        [NativeTypeName("ma_uint32[2]")]
        public fixed uint pageFrameCount[2];

        public ma_result result;

        [NativeTypeName("ma_bool32")]
        public uint isDecoderAtEnd;

        [NativeTypeName("ma_bool32[2]")]
        public fixed uint isPageValid[2];

        [NativeTypeName("ma_bool32")]
        public uint seekCounter;
    }

    public partial struct ma_resource_manager_data_source
    {
        [NativeTypeName("__AnonymousRecord_miniaudio_L6736_C5")]
        public _backend_e__Union backend;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint executionCounter;

        [NativeTypeName("ma_uint32")]
        public uint executionPointer;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _backend_e__Union
        {
            [FieldOffset(0)]
            public ma_resource_manager_data_buffer buffer;

            [FieldOffset(0)]
            public ma_resource_manager_data_stream stream;
        }
    }

    public unsafe partial struct ma_resource_manager_config
    {
        public ma_allocation_callbacks allocationCallbacks;

        public ma_log* pLog;

        public ma_format decodedFormat;

        [NativeTypeName("ma_uint32")]
        public uint decodedChannels;

        [NativeTypeName("ma_uint32")]
        public uint decodedSampleRate;

        [NativeTypeName("ma_uint32")]
        public uint jobThreadCount;

        [NativeTypeName("size_t")]
        public nuint jobThreadStackSize;

        [NativeTypeName("ma_uint32")]
        public uint jobQueueCapacity;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_vfs *")]
        public void* pVFS;

        public ma_decoding_backend_vtable** ppCustomDecodingBackendVTables;

        [NativeTypeName("ma_uint32")]
        public uint customDecodingBackendCount;

        public void* pCustomDecodingBackendUserData;
    }

    public unsafe partial struct ma_resource_manager
    {
        public ma_resource_manager_config config;

        public ma_resource_manager_data_buffer_node* pRootDataBufferNode;

        [NativeTypeName("ma_mutex")]
        public void* dataBufferBSTLock;

        [NativeTypeName("ma_thread[64]")]
        public _jobThreads_e__FixedBuffer jobThreads;

        public ma_job_queue jobQueue;

        public ma_default_vfs defaultVFS;

        public ma_log log;

        public unsafe partial struct _jobThreads_e__FixedBuffer
        {
            public void* e0;
            public void* e1;
            public void* e2;
            public void* e3;
            public void* e4;
            public void* e5;
            public void* e6;
            public void* e7;
            public void* e8;
            public void* e9;
            public void* e10;
            public void* e11;
            public void* e12;
            public void* e13;
            public void* e14;
            public void* e15;
            public void* e16;
            public void* e17;
            public void* e18;
            public void* e19;
            public void* e20;
            public void* e21;
            public void* e22;
            public void* e23;
            public void* e24;
            public void* e25;
            public void* e26;
            public void* e27;
            public void* e28;
            public void* e29;
            public void* e30;
            public void* e31;
            public void* e32;
            public void* e33;
            public void* e34;
            public void* e35;
            public void* e36;
            public void* e37;
            public void* e38;
            public void* e39;
            public void* e40;
            public void* e41;
            public void* e42;
            public void* e43;
            public void* e44;
            public void* e45;
            public void* e46;
            public void* e47;
            public void* e48;
            public void* e49;
            public void* e50;
            public void* e51;
            public void* e52;
            public void* e53;
            public void* e54;
            public void* e55;
            public void* e56;
            public void* e57;
            public void* e58;
            public void* e59;
            public void* e60;
            public void* e61;
            public void* e62;
            public void* e63;

            public ref void* this[int index]
            {
                get
                {
                    fixed (void** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public unsafe partial struct ma_stack
    {
        [NativeTypeName("size_t")]
        public nuint offset;

        [NativeTypeName("size_t")]
        public nuint sizeInBytes;

        [NativeTypeName("unsigned char[1]")]
        public fixed byte _data[1];
    }

    public enum ma_node_flags
    {
        MA_NODE_FLAG_PASSTHROUGH = 0x00000001,
        MA_NODE_FLAG_CONTINUOUS_PROCESSING = 0x00000002,
        MA_NODE_FLAG_ALLOW_NULL_INPUT = 0x00000004,
        MA_NODE_FLAG_DIFFERENT_PROCESSING_RATES = 0x00000008,
        MA_NODE_FLAG_SILENT_OUTPUT = 0x00000010,
    }

    public enum ma_node_state
    {
        ma_node_state_started = 0,
        ma_node_state_stopped = 1,
    }

    public unsafe partial struct ma_node_vtable
    {
        [NativeTypeName("void (*)(ma_node *, const float **, ma_uint32 *, float **, ma_uint32 *)")]
        public delegate* unmanaged[Cdecl]<void*, float**, uint*, float**, uint*, void> onProcess;

        [NativeTypeName("ma_result (*)(ma_node *, ma_uint32, ma_uint32 *)")]
        public delegate* unmanaged[Cdecl]<void*, uint, uint*, ma_result> onGetRequiredInputFrameCount;

        [NativeTypeName("ma_uint8")]
        public byte inputBusCount;

        [NativeTypeName("ma_uint8")]
        public byte outputBusCount;

        [NativeTypeName("ma_uint32")]
        public uint flags;
    }

    public unsafe partial struct ma_node_config
    {
        [NativeTypeName("const ma_node_vtable *")]
        public ma_node_vtable* vtable;

        public ma_node_state initialState;

        [NativeTypeName("ma_uint32")]
        public uint inputBusCount;

        [NativeTypeName("ma_uint32")]
        public uint outputBusCount;

        [NativeTypeName("const ma_uint32 *")]
        public uint* pInputChannels;

        [NativeTypeName("const ma_uint32 *")]
        public uint* pOutputChannels;
    }

    public unsafe partial struct ma_node_output_bus
    {
        [NativeTypeName("ma_node *")]
        public void* pNode;

        [NativeTypeName("ma_uint8")]
        public byte outputBusIndex;

        [NativeTypeName("ma_uint8")]
        public byte channels;

        [NativeTypeName("ma_uint8")]
        public byte inputNodeInputBusIndex;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint refCount;

        [NativeTypeName("ma_bool32")]
        public uint isAttached;

        [NativeTypeName("ma_spinlock")]
        public uint @lock;

        public float volume;

        public ma_node_output_bus* pNext;

        public ma_node_output_bus* pPrev;

        [NativeTypeName("ma_node *")]
        public void* pInputNode;
    }

    public partial struct ma_node_input_bus
    {
        public ma_node_output_bus head;

        [NativeTypeName("ma_uint32")]
        public uint nextCounter;

        [NativeTypeName("ma_spinlock")]
        public uint @lock;

        [NativeTypeName("ma_uint8")]
        public byte channels;
    }

    public unsafe partial struct ma_node_base
    {
        public ma_node_graph* pNodeGraph;

        [NativeTypeName("const ma_node_vtable *")]
        public ma_node_vtable* vtable;

        [NativeTypeName("ma_uint32")]
        public uint inputBusCount;

        [NativeTypeName("ma_uint32")]
        public uint outputBusCount;

        public ma_node_input_bus* pInputBuses;

        public ma_node_output_bus* pOutputBuses;

        public float* pCachedData;

        [NativeTypeName("ma_uint16")]
        public ushort cachedDataCapInFramesPerBus;

        [NativeTypeName("ma_uint16")]
        public ushort cachedFrameCountOut;

        [NativeTypeName("ma_uint16")]
        public ushort cachedFrameCountIn;

        [NativeTypeName("ma_uint16")]
        public ushort consumedFrameCountIn;

        public ma_node_state state;

        [NativeTypeName("ma_uint64[2]")]
        public fixed ulong stateTimes[2];

        [NativeTypeName("ma_uint64")]
        public ulong localTime;

        [NativeTypeName("ma_node_input_bus[2]")]
        public __inputBuses_e__FixedBuffer _inputBuses;

        [NativeTypeName("ma_node_output_bus[2]")]
        public __outputBuses_e__FixedBuffer _outputBuses;

        public void* _pHeap;

        [NativeTypeName("ma_bool32")]
        public uint _ownsHeap;

        public partial struct __inputBuses_e__FixedBuffer
        {
            public ma_node_input_bus e0;
            public ma_node_input_bus e1;

            public ref ma_node_input_bus this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<ma_node_input_bus> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }

        public partial struct __outputBuses_e__FixedBuffer
        {
            public ma_node_output_bus e0;
            public ma_node_output_bus e1;

            public ref ma_node_output_bus this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<ma_node_output_bus> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
        }
    }

    public partial struct ma_node_graph_config
    {
        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint processingSizeInFrames;

        [NativeTypeName("size_t")]
        public nuint preMixStackSizeInBytes;
    }

    public unsafe partial struct ma_node_graph
    {
        public ma_node_base @base;

        public ma_node_base endpoint;

        public float* pProcessingCache;

        [NativeTypeName("ma_uint32")]
        public uint processingCacheFramesRemaining;

        [NativeTypeName("ma_uint32")]
        public uint processingSizeInFrames;

        [NativeTypeName("ma_bool32")]
        public uint isReading;

        public ma_stack* pPreMixStack;
    }

    public unsafe partial struct ma_data_source_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_data_source *")]
        public void* pDataSource;
    }

    public unsafe partial struct ma_data_source_node
    {
        public ma_node_base @base;

        [NativeTypeName("ma_data_source *")]
        public void* pDataSource;
    }

    public partial struct ma_splitter_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint outputBusCount;
    }

    public partial struct ma_splitter_node
    {
        public ma_node_base @base;
    }

    public partial struct ma_biquad_node_config
    {
        public ma_node_config nodeConfig;

        public ma_biquad_config biquad;
    }

    public partial struct ma_biquad_node
    {
        public ma_node_base baseNode;

        public ma_biquad biquad;
    }

    public partial struct ma_lpf_node_config
    {
        public ma_node_config nodeConfig;

        public ma_lpf_config lpf;
    }

    public partial struct ma_lpf_node
    {
        public ma_node_base baseNode;

        public ma_lpf lpf;
    }

    public partial struct ma_hpf_node_config
    {
        public ma_node_config nodeConfig;

        public ma_hpf_config hpf;
    }

    public partial struct ma_hpf_node
    {
        public ma_node_base baseNode;

        public ma_hpf hpf;
    }

    public partial struct ma_bpf_node_config
    {
        public ma_node_config nodeConfig;

        public ma_bpf_config bpf;
    }

    public partial struct ma_bpf_node
    {
        public ma_node_base baseNode;

        public ma_bpf bpf;
    }

    public partial struct ma_notch_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_notch_config")]
        public ma_notch2_config notch;
    }

    public partial struct ma_notch_node
    {
        public ma_node_base baseNode;

        public ma_notch2 notch;
    }

    public partial struct ma_peak_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_peak_config")]
        public ma_peak2_config peak;
    }

    public partial struct ma_peak_node
    {
        public ma_node_base baseNode;

        public ma_peak2 peak;
    }

    public partial struct ma_loshelf_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_loshelf_config")]
        public ma_loshelf2_config loshelf;
    }

    public partial struct ma_loshelf_node
    {
        public ma_node_base baseNode;

        public ma_loshelf2 loshelf;
    }

    public partial struct ma_hishelf_node_config
    {
        public ma_node_config nodeConfig;

        [NativeTypeName("ma_hishelf_config")]
        public ma_hishelf2_config hishelf;
    }

    public partial struct ma_hishelf_node
    {
        public ma_node_base baseNode;

        public ma_hishelf2 hishelf;
    }

    public partial struct ma_delay_node_config
    {
        public ma_node_config nodeConfig;

        public ma_delay_config delay;
    }

    public partial struct ma_delay_node
    {
        public ma_node_base baseNode;

        public ma_delay delay;
    }

    public enum ma_sound_flags
    {
        MA_SOUND_FLAG_STREAM = 0x00000001,
        MA_SOUND_FLAG_DECODE = 0x00000002,
        MA_SOUND_FLAG_ASYNC = 0x00000004,
        MA_SOUND_FLAG_WAIT_INIT = 0x00000008,
        MA_SOUND_FLAG_UNKNOWN_LENGTH = 0x00000010,
        MA_SOUND_FLAG_LOOPING = 0x00000020,
        MA_SOUND_FLAG_NO_DEFAULT_ATTACHMENT = 0x00001000,
        MA_SOUND_FLAG_NO_PITCH = 0x00002000,
        MA_SOUND_FLAG_NO_SPATIALIZATION = 0x00004000,
    }

    public enum ma_engine_node_type
    {
        ma_engine_node_type_sound,
        ma_engine_node_type_group,
    }

    public unsafe partial struct ma_engine_node_config
    {
        public ma_engine* pEngine;

        public ma_engine_node_type type;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint volumeSmoothTimeInPCMFrames;

        public ma_mono_expansion_mode monoExpansionMode;

        [NativeTypeName("ma_bool8")]
        public byte isPitchDisabled;

        [NativeTypeName("ma_bool8")]
        public byte isSpatializationDisabled;

        [NativeTypeName("ma_uint8")]
        public byte pinnedListenerIndex;
    }

    public unsafe partial struct ma_engine_node
    {
        public ma_node_base baseNode;

        public ma_engine* pEngine;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint volumeSmoothTimeInPCMFrames;

        public ma_mono_expansion_mode monoExpansionMode;

        public ma_fader fader;

        public ma_linear_resampler resampler;

        public ma_spatializer spatializer;

        public ma_panner panner;

        public ma_gainer volumeGainer;

        public ma_atomic_float volume;

        public float pitch;

        public float oldPitch;

        public float oldDopplerPitch;

        [NativeTypeName("ma_bool32")]
        public uint isPitchDisabled;

        [NativeTypeName("ma_bool32")]
        public uint isSpatializationDisabled;

        [NativeTypeName("ma_uint32")]
        public uint pinnedListenerIndex;

        [NativeTypeName("__AnonymousRecord_miniaudio_L7423_C5")]
        public _fadeSettings_e__Struct fadeSettings;

        [NativeTypeName("ma_bool8")]
        public byte _ownsHeap;

        public void* _pHeap;

        public partial struct _fadeSettings_e__Struct
        {
            public ma_atomic_float volumeBeg;

            public ma_atomic_float volumeEnd;

            public ma_atomic_uint64 fadeLengthInFrames;

            public ma_atomic_uint64 absoluteGlobalTimeInFrames;
        }
    }

    public unsafe partial struct ma_sound_config
    {
        [NativeTypeName("const char *")]
        public sbyte* pFilePath;

        [NativeTypeName("const wchar_t *")]
        public ushort* pFilePathW;

        [NativeTypeName("ma_data_source *")]
        public void* pDataSource;

        [NativeTypeName("ma_node *")]
        public void* pInitialAttachment;

        [NativeTypeName("ma_uint32")]
        public uint initialAttachmentInputBusIndex;

        [NativeTypeName("ma_uint32")]
        public uint channelsIn;

        [NativeTypeName("ma_uint32")]
        public uint channelsOut;

        public ma_mono_expansion_mode monoExpansionMode;

        [NativeTypeName("ma_uint32")]
        public uint flags;

        [NativeTypeName("ma_uint32")]
        public uint volumeSmoothTimeInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong initialSeekPointInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong rangeBegInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong rangeEndInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopPointBegInPCMFrames;

        [NativeTypeName("ma_uint64")]
        public ulong loopPointEndInPCMFrames;

        [NativeTypeName("ma_sound_end_proc")]
        public delegate* unmanaged[Cdecl]<void*, ma_sound*, void> endCallback;

        public void* pEndCallbackUserData;

        public ma_resource_manager_pipeline_notifications initNotifications;

        public ma_fence* pDoneFence;

        [NativeTypeName("ma_bool32")]
        public uint isLooping;
    }

    public unsafe partial struct ma_sound
    {
        public ma_engine_node engineNode;

        [NativeTypeName("ma_data_source *")]
        public void* pDataSource;

        [NativeTypeName("ma_uint64")]
        public ulong seekTarget;

        [NativeTypeName("ma_bool32")]
        public uint atEnd;

        [NativeTypeName("ma_sound_end_proc")]
        public delegate* unmanaged[Cdecl]<void*, ma_sound*, void> endCallback;

        public void* pEndCallbackUserData;

        [NativeTypeName("ma_bool8")]
        public byte ownsDataSource;

        public ma_resource_manager_data_source* pResourceManagerDataSource;
    }

    public unsafe partial struct ma_sound_inlined
    {
        public ma_sound sound;

        public ma_sound_inlined* pNext;

        public ma_sound_inlined* pPrev;
    }

    public unsafe partial struct ma_engine_config
    {
        public ma_resource_manager* pResourceManager;

        public ma_context* pContext;

        public ma_device* pDevice;

        public ma_device_id* pPlaybackDeviceID;

        [NativeTypeName("ma_device_data_proc")]
        public delegate* unmanaged[Cdecl]<ma_device*, void*, void*, uint, void> dataCallback;

        [NativeTypeName("ma_device_notification_proc")]
        public delegate* unmanaged[Cdecl]<ma_device_notification*, void> notificationCallback;

        public ma_log* pLog;

        [NativeTypeName("ma_uint32")]
        public uint listenerCount;

        [NativeTypeName("ma_uint32")]
        public uint channels;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint periodSizeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint periodSizeInMilliseconds;

        [NativeTypeName("ma_uint32")]
        public uint gainSmoothTimeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint gainSmoothTimeInMilliseconds;

        [NativeTypeName("ma_uint32")]
        public uint defaultVolumeSmoothTimeInPCMFrames;

        [NativeTypeName("ma_uint32")]
        public uint preMixStackSizeInBytes;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("ma_bool32")]
        public uint noAutoStart;

        [NativeTypeName("ma_bool32")]
        public uint noDevice;

        public ma_mono_expansion_mode monoExpansionMode;

        [NativeTypeName("ma_vfs *")]
        public void* pResourceManagerVFS;

        [NativeTypeName("ma_engine_process_proc")]
        public delegate* unmanaged[Cdecl]<void*, float*, ulong, void> onProcess;

        public void* pProcessUserData;
    }

    public unsafe partial struct ma_engine
    {
        public ma_node_graph nodeGraph;

        public ma_resource_manager* pResourceManager;

        public ma_device* pDevice;

        public ma_log* pLog;

        [NativeTypeName("ma_uint32")]
        public uint sampleRate;

        [NativeTypeName("ma_uint32")]
        public uint listenerCount;

        [NativeTypeName("ma_spatializer_listener[4]")]
        public _listeners_e__FixedBuffer listeners;

        public ma_allocation_callbacks allocationCallbacks;

        [NativeTypeName("ma_bool8")]
        public byte ownsResourceManager;

        [NativeTypeName("ma_bool8")]
        public byte ownsDevice;

        [NativeTypeName("ma_spinlock")]
        public uint inlinedSoundLock;

        public ma_sound_inlined* pInlinedSoundHead;

        [NativeTypeName("ma_uint32")]
        public uint inlinedSoundCount;

        [NativeTypeName("ma_uint32")]
        public uint gainSmoothTimeInFrames;

        [NativeTypeName("ma_uint32")]
        public uint defaultVolumeSmoothTimeInPCMFrames;

        public ma_mono_expansion_mode monoExpansionMode;

        [NativeTypeName("ma_engine_process_proc")]
        public delegate* unmanaged[Cdecl]<void*, float*, ulong, void> onProcess;

        public void* pProcessUserData;

        public partial struct _listeners_e__FixedBuffer
        {
            public ma_spatializer_listener e0;
            public ma_spatializer_listener e1;
            public ma_spatializer_listener e2;
            public ma_spatializer_listener e3;

            public ref ma_spatializer_listener this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<ma_spatializer_listener> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }

    public static unsafe partial class ma
    {
        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_version", ExactSpelling = true)]
        public static extern void version([NativeTypeName("ma_uint32 *")] uint* pMajor, [NativeTypeName("ma_uint32 *")] uint* pMinor, [NativeTypeName("ma_uint32 *")] uint* pRevision);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_version_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* version_string();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_callback_init", ExactSpelling = true)]
        public static extern ma_log_callback log_callback_init([NativeTypeName("ma_log_callback_proc")] delegate* unmanaged[Cdecl]<void*, uint, sbyte*, void> onLog, void* pUserData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_init", ExactSpelling = true)]
        public static extern ma_result log_init([NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_log* pLog);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_uninit", ExactSpelling = true)]
        public static extern void log_uninit(ma_log* pLog);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_register_callback", ExactSpelling = true)]
        public static extern ma_result log_register_callback(ma_log* pLog, ma_log_callback callback);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_unregister_callback", ExactSpelling = true)]
        public static extern ma_result log_unregister_callback(ma_log* pLog, ma_log_callback callback);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_post", ExactSpelling = true)]
        public static extern ma_result log_post(ma_log* pLog, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pMessage);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_postv", ExactSpelling = true)]
        public static extern ma_result log_postv(ma_log* pLog, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pFormat, [NativeTypeName("va_list")] sbyte* args);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_postf", ExactSpelling = true)]
        public static extern ma_result log_postf(ma_log* pLog, [NativeTypeName("ma_uint32")] uint level, [NativeTypeName("const char *")] sbyte* pFormat, __arglist);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_config_init", ExactSpelling = true)]
        public static extern ma_biquad_config biquad_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, double b0, double b1, double b2, double a0, double a1, double a2);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_get_heap_size", ExactSpelling = true)]
        public static extern ma_result biquad_get_heap_size([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_init_preallocated", ExactSpelling = true)]
        public static extern ma_result biquad_init_preallocated([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, void* pHeap, ma_biquad* pBQ);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_init", ExactSpelling = true)]
        public static extern ma_result biquad_init([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_biquad* pBQ);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_uninit", ExactSpelling = true)]
        public static extern void biquad_uninit(ma_biquad* pBQ, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_reinit", ExactSpelling = true)]
        public static extern ma_result biquad_reinit([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, ma_biquad* pBQ);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_clear_cache", ExactSpelling = true)]
        public static extern ma_result biquad_clear_cache(ma_biquad* pBQ);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result biquad_process_pcm_frames(ma_biquad* pBQ, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint biquad_get_latency([NativeTypeName("const ma_biquad *")] ma_biquad* pBQ);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_config_init", ExactSpelling = true)]
        public static extern ma_lpf1_config lpf1_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_config_init", ExactSpelling = true)]
        [return: NativeTypeName("ma_lpf2_config")]
        public static extern ma_lpf1_config lpf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, double q);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_get_heap_size", ExactSpelling = true)]
        public static extern ma_result lpf1_get_heap_size([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_init_preallocated", ExactSpelling = true)]
        public static extern ma_result lpf1_init_preallocated([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, void* pHeap, ma_lpf1* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_init", ExactSpelling = true)]
        public static extern ma_result lpf1_init([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf1* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_uninit", ExactSpelling = true)]
        public static extern void lpf1_uninit(ma_lpf1* pLPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_reinit", ExactSpelling = true)]
        public static extern ma_result lpf1_reinit([NativeTypeName("const ma_lpf1_config *")] ma_lpf1_config* pConfig, ma_lpf1* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_clear_cache", ExactSpelling = true)]
        public static extern ma_result lpf1_clear_cache(ma_lpf1* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result lpf1_process_pcm_frames(ma_lpf1* pLPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf1_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint lpf1_get_latency([NativeTypeName("const ma_lpf1 *")] ma_lpf1* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result lpf2_get_heap_size([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result lpf2_init_preallocated([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, void* pHeap, ma_lpf2* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_init", ExactSpelling = true)]
        public static extern ma_result lpf2_init([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf2* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_uninit", ExactSpelling = true)]
        public static extern void lpf2_uninit(ma_lpf2* pLPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_reinit", ExactSpelling = true)]
        public static extern ma_result lpf2_reinit([NativeTypeName("const ma_lpf2_config *")] ma_lpf1_config* pConfig, ma_lpf2* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_clear_cache", ExactSpelling = true)]
        public static extern ma_result lpf2_clear_cache(ma_lpf2* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result lpf2_process_pcm_frames(ma_lpf2* pLPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint lpf2_get_latency([NativeTypeName("const ma_lpf2 *")] ma_lpf2* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_config_init", ExactSpelling = true)]
        public static extern ma_lpf_config lpf_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_get_heap_size", ExactSpelling = true)]
        public static extern ma_result lpf_get_heap_size([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_init_preallocated", ExactSpelling = true)]
        public static extern ma_result lpf_init_preallocated([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, void* pHeap, ma_lpf* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_init", ExactSpelling = true)]
        public static extern ma_result lpf_init([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_uninit", ExactSpelling = true)]
        public static extern void lpf_uninit(ma_lpf* pLPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_reinit", ExactSpelling = true)]
        public static extern ma_result lpf_reinit([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, ma_lpf* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_clear_cache", ExactSpelling = true)]
        public static extern ma_result lpf_clear_cache(ma_lpf* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result lpf_process_pcm_frames(ma_lpf* pLPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint lpf_get_latency([NativeTypeName("const ma_lpf *")] ma_lpf* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_config_init", ExactSpelling = true)]
        public static extern ma_hpf1_config hpf1_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_config_init", ExactSpelling = true)]
        [return: NativeTypeName("ma_hpf2_config")]
        public static extern ma_hpf1_config hpf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, double q);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_get_heap_size", ExactSpelling = true)]
        public static extern ma_result hpf1_get_heap_size([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_init_preallocated", ExactSpelling = true)]
        public static extern ma_result hpf1_init_preallocated([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, void* pHeap, ma_hpf1* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_init", ExactSpelling = true)]
        public static extern ma_result hpf1_init([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf1* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_uninit", ExactSpelling = true)]
        public static extern void hpf1_uninit(ma_hpf1* pHPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_reinit", ExactSpelling = true)]
        public static extern ma_result hpf1_reinit([NativeTypeName("const ma_hpf1_config *")] ma_hpf1_config* pConfig, ma_hpf1* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result hpf1_process_pcm_frames(ma_hpf1* pHPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf1_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint hpf1_get_latency([NativeTypeName("const ma_hpf1 *")] ma_hpf1* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result hpf2_get_heap_size([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result hpf2_init_preallocated([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, void* pHeap, ma_hpf2* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_init", ExactSpelling = true)]
        public static extern ma_result hpf2_init([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf2* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_uninit", ExactSpelling = true)]
        public static extern void hpf2_uninit(ma_hpf2* pHPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_reinit", ExactSpelling = true)]
        public static extern ma_result hpf2_reinit([NativeTypeName("const ma_hpf2_config *")] ma_hpf1_config* pConfig, ma_hpf2* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result hpf2_process_pcm_frames(ma_hpf2* pHPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint hpf2_get_latency([NativeTypeName("const ma_hpf2 *")] ma_hpf2* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_config_init", ExactSpelling = true)]
        public static extern ma_hpf_config hpf_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_get_heap_size", ExactSpelling = true)]
        public static extern ma_result hpf_get_heap_size([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_init_preallocated", ExactSpelling = true)]
        public static extern ma_result hpf_init_preallocated([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, void* pHeap, ma_hpf* pLPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_init", ExactSpelling = true)]
        public static extern ma_result hpf_init([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_uninit", ExactSpelling = true)]
        public static extern void hpf_uninit(ma_hpf* pHPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_reinit", ExactSpelling = true)]
        public static extern ma_result hpf_reinit([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, ma_hpf* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result hpf_process_pcm_frames(ma_hpf* pHPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint hpf_get_latency([NativeTypeName("const ma_hpf *")] ma_hpf* pHPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_config_init", ExactSpelling = true)]
        public static extern ma_bpf2_config bpf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, double q);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result bpf2_get_heap_size([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result bpf2_init_preallocated([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, void* pHeap, ma_bpf2* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_init", ExactSpelling = true)]
        public static extern ma_result bpf2_init([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_bpf2* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_uninit", ExactSpelling = true)]
        public static extern void bpf2_uninit(ma_bpf2* pBPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_reinit", ExactSpelling = true)]
        public static extern ma_result bpf2_reinit([NativeTypeName("const ma_bpf2_config *")] ma_bpf2_config* pConfig, ma_bpf2* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result bpf2_process_pcm_frames(ma_bpf2* pBPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint bpf2_get_latency([NativeTypeName("const ma_bpf2 *")] ma_bpf2* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_config_init", ExactSpelling = true)]
        public static extern ma_bpf_config bpf_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_get_heap_size", ExactSpelling = true)]
        public static extern ma_result bpf_get_heap_size([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_init_preallocated", ExactSpelling = true)]
        public static extern ma_result bpf_init_preallocated([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, void* pHeap, ma_bpf* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_init", ExactSpelling = true)]
        public static extern ma_result bpf_init([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_bpf* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_uninit", ExactSpelling = true)]
        public static extern void bpf_uninit(ma_bpf* pBPF, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_reinit", ExactSpelling = true)]
        public static extern ma_result bpf_reinit([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, ma_bpf* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result bpf_process_pcm_frames(ma_bpf* pBPF, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint bpf_get_latency([NativeTypeName("const ma_bpf *")] ma_bpf* pBPF);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_config_init", ExactSpelling = true)]
        public static extern ma_notch2_config notch2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double q, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result notch2_get_heap_size([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result notch2_init_preallocated([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, void* pHeap, ma_notch2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_init", ExactSpelling = true)]
        public static extern ma_result notch2_init([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_notch2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_uninit", ExactSpelling = true)]
        public static extern void notch2_uninit(ma_notch2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_reinit", ExactSpelling = true)]
        public static extern ma_result notch2_reinit([NativeTypeName("const ma_notch2_config *")] ma_notch2_config* pConfig, ma_notch2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result notch2_process_pcm_frames(ma_notch2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint notch2_get_latency([NativeTypeName("const ma_notch2 *")] ma_notch2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_config_init", ExactSpelling = true)]
        public static extern ma_peak2_config peak2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result peak2_get_heap_size([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result peak2_init_preallocated([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, void* pHeap, ma_peak2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_init", ExactSpelling = true)]
        public static extern ma_result peak2_init([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_peak2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_uninit", ExactSpelling = true)]
        public static extern void peak2_uninit(ma_peak2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_reinit", ExactSpelling = true)]
        public static extern ma_result peak2_reinit([NativeTypeName("const ma_peak2_config *")] ma_peak2_config* pConfig, ma_peak2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result peak2_process_pcm_frames(ma_peak2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint peak2_get_latency([NativeTypeName("const ma_peak2 *")] ma_peak2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_config_init", ExactSpelling = true)]
        public static extern ma_loshelf2_config loshelf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double shelfSlope, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result loshelf2_get_heap_size([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result loshelf2_init_preallocated([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, void* pHeap, ma_loshelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_init", ExactSpelling = true)]
        public static extern ma_result loshelf2_init([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_loshelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_uninit", ExactSpelling = true)]
        public static extern void loshelf2_uninit(ma_loshelf2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_reinit", ExactSpelling = true)]
        public static extern ma_result loshelf2_reinit([NativeTypeName("const ma_loshelf2_config *")] ma_loshelf2_config* pConfig, ma_loshelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result loshelf2_process_pcm_frames(ma_loshelf2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint loshelf2_get_latency([NativeTypeName("const ma_loshelf2 *")] ma_loshelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_config_init", ExactSpelling = true)]
        public static extern ma_hishelf2_config hishelf2_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double shelfSlope, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_get_heap_size", ExactSpelling = true)]
        public static extern ma_result hishelf2_get_heap_size([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_init_preallocated", ExactSpelling = true)]
        public static extern ma_result hishelf2_init_preallocated([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, void* pHeap, ma_hishelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_init", ExactSpelling = true)]
        public static extern ma_result hishelf2_init([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hishelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_uninit", ExactSpelling = true)]
        public static extern void hishelf2_uninit(ma_hishelf2* pFilter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_reinit", ExactSpelling = true)]
        public static extern ma_result hishelf2_reinit([NativeTypeName("const ma_hishelf2_config *")] ma_hishelf2_config* pConfig, ma_hishelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result hishelf2_process_pcm_frames(ma_hishelf2* pFilter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf2_get_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint hishelf2_get_latency([NativeTypeName("const ma_hishelf2 *")] ma_hishelf2* pFilter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_config_init", ExactSpelling = true)]
        public static extern ma_delay_config delay_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, [NativeTypeName("ma_uint32")] uint delayInFrames, float decay);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_init", ExactSpelling = true)]
        public static extern ma_result delay_init([NativeTypeName("const ma_delay_config *")] ma_delay_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_delay* pDelay);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_uninit", ExactSpelling = true)]
        public static extern void delay_uninit(ma_delay* pDelay, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result delay_process_pcm_frames(ma_delay* pDelay, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint32")] uint frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_set_wet", ExactSpelling = true)]
        public static extern void delay_set_wet(ma_delay* pDelay, float value);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_get_wet", ExactSpelling = true)]
        public static extern float delay_get_wet([NativeTypeName("const ma_delay *")] ma_delay* pDelay);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_set_dry", ExactSpelling = true)]
        public static extern void delay_set_dry(ma_delay* pDelay, float value);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_get_dry", ExactSpelling = true)]
        public static extern float delay_get_dry([NativeTypeName("const ma_delay *")] ma_delay* pDelay);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_set_decay", ExactSpelling = true)]
        public static extern void delay_set_decay(ma_delay* pDelay, float value);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_get_decay", ExactSpelling = true)]
        public static extern float delay_get_decay([NativeTypeName("const ma_delay *")] ma_delay* pDelay);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_config_init", ExactSpelling = true)]
        public static extern ma_gainer_config gainer_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint smoothTimeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_get_heap_size", ExactSpelling = true)]
        public static extern ma_result gainer_get_heap_size([NativeTypeName("const ma_gainer_config *")] ma_gainer_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_init_preallocated", ExactSpelling = true)]
        public static extern ma_result gainer_init_preallocated([NativeTypeName("const ma_gainer_config *")] ma_gainer_config* pConfig, void* pHeap, ma_gainer* pGainer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_init", ExactSpelling = true)]
        public static extern ma_result gainer_init([NativeTypeName("const ma_gainer_config *")] ma_gainer_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_gainer* pGainer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_uninit", ExactSpelling = true)]
        public static extern void gainer_uninit(ma_gainer* pGainer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result gainer_process_pcm_frames(ma_gainer* pGainer, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_set_gain", ExactSpelling = true)]
        public static extern ma_result gainer_set_gain(ma_gainer* pGainer, float newGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_set_gains", ExactSpelling = true)]
        public static extern ma_result gainer_set_gains(ma_gainer* pGainer, float* pNewGains);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_set_master_volume", ExactSpelling = true)]
        public static extern ma_result gainer_set_master_volume(ma_gainer* pGainer, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_gainer_get_master_volume", ExactSpelling = true)]
        public static extern ma_result gainer_get_master_volume([NativeTypeName("const ma_gainer *")] ma_gainer* pGainer, float* pVolume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_config_init", ExactSpelling = true)]
        public static extern ma_panner_config panner_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_init", ExactSpelling = true)]
        public static extern ma_result panner_init([NativeTypeName("const ma_panner_config *")] ma_panner_config* pConfig, ma_panner* pPanner);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result panner_process_pcm_frames(ma_panner* pPanner, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_set_mode", ExactSpelling = true)]
        public static extern void panner_set_mode(ma_panner* pPanner, ma_pan_mode mode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_get_mode", ExactSpelling = true)]
        public static extern ma_pan_mode panner_get_mode([NativeTypeName("const ma_panner *")] ma_panner* pPanner);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_set_pan", ExactSpelling = true)]
        public static extern void panner_set_pan(ma_panner* pPanner, float pan);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_panner_get_pan", ExactSpelling = true)]
        public static extern float panner_get_pan([NativeTypeName("const ma_panner *")] ma_panner* pPanner);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_config_init", ExactSpelling = true)]
        public static extern ma_fader_config fader_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_init", ExactSpelling = true)]
        public static extern ma_result fader_init([NativeTypeName("const ma_fader_config *")] ma_fader_config* pConfig, ma_fader* pFader);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result fader_process_pcm_frames(ma_fader* pFader, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_get_data_format", ExactSpelling = true)]
        public static extern void fader_get_data_format([NativeTypeName("const ma_fader *")] ma_fader* pFader, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_set_fade", ExactSpelling = true)]
        public static extern void fader_set_fade(ma_fader* pFader, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong lengthInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_set_fade_ex", ExactSpelling = true)]
        public static extern void fader_set_fade_ex(ma_fader* pFader, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong lengthInFrames, [NativeTypeName("ma_int64")] long startOffsetInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fader_get_current_volume", ExactSpelling = true)]
        public static extern float fader_get_current_volume([NativeTypeName("const ma_fader *")] ma_fader* pFader);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_config_init", ExactSpelling = true)]
        public static extern ma_spatializer_listener_config spatializer_listener_config_init([NativeTypeName("ma_uint32")] uint channelsOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_heap_size", ExactSpelling = true)]
        public static extern ma_result spatializer_listener_get_heap_size([NativeTypeName("const ma_spatializer_listener_config *")] ma_spatializer_listener_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_init_preallocated", ExactSpelling = true)]
        public static extern ma_result spatializer_listener_init_preallocated([NativeTypeName("const ma_spatializer_listener_config *")] ma_spatializer_listener_config* pConfig, void* pHeap, ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_init", ExactSpelling = true)]
        public static extern ma_result spatializer_listener_init([NativeTypeName("const ma_spatializer_listener_config *")] ma_spatializer_listener_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_uninit", ExactSpelling = true)]
        public static extern void spatializer_listener_uninit(ma_spatializer_listener* pListener, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_channel_map", ExactSpelling = true)]
        [return: NativeTypeName("ma_channel *")]
        public static extern byte* spatializer_listener_get_channel_map(ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_cone", ExactSpelling = true)]
        public static extern void spatializer_listener_set_cone(ma_spatializer_listener* pListener, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_cone", ExactSpelling = true)]
        public static extern void spatializer_listener_get_cone([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_position", ExactSpelling = true)]
        public static extern void spatializer_listener_set_position(ma_spatializer_listener* pListener, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_position", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_listener_get_position([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_direction", ExactSpelling = true)]
        public static extern void spatializer_listener_set_direction(ma_spatializer_listener* pListener, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_direction", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_listener_get_direction([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_velocity", ExactSpelling = true)]
        public static extern void spatializer_listener_set_velocity(ma_spatializer_listener* pListener, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_velocity", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_listener_get_velocity([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_speed_of_sound", ExactSpelling = true)]
        public static extern void spatializer_listener_set_speed_of_sound(ma_spatializer_listener* pListener, float speedOfSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_speed_of_sound", ExactSpelling = true)]
        public static extern float spatializer_listener_get_speed_of_sound([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_world_up", ExactSpelling = true)]
        public static extern void spatializer_listener_set_world_up(ma_spatializer_listener* pListener, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_get_world_up", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_listener_get_world_up([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_set_enabled", ExactSpelling = true)]
        public static extern void spatializer_listener_set_enabled(ma_spatializer_listener* pListener, [NativeTypeName("ma_bool32")] uint isEnabled);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_listener_is_enabled", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint spatializer_listener_is_enabled([NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_config_init", ExactSpelling = true)]
        public static extern ma_spatializer_config spatializer_config_init([NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("ma_uint32")] uint channelsOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_heap_size", ExactSpelling = true)]
        public static extern ma_result spatializer_get_heap_size([NativeTypeName("const ma_spatializer_config *")] ma_spatializer_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_init_preallocated", ExactSpelling = true)]
        public static extern ma_result spatializer_init_preallocated([NativeTypeName("const ma_spatializer_config *")] ma_spatializer_config* pConfig, void* pHeap, ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_init", ExactSpelling = true)]
        public static extern ma_result spatializer_init([NativeTypeName("const ma_spatializer_config *")] ma_spatializer_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_uninit", ExactSpelling = true)]
        public static extern void spatializer_uninit(ma_spatializer* pSpatializer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result spatializer_process_pcm_frames(ma_spatializer* pSpatializer, ma_spatializer_listener* pListener, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_master_volume", ExactSpelling = true)]
        public static extern ma_result spatializer_set_master_volume(ma_spatializer* pSpatializer, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_master_volume", ExactSpelling = true)]
        public static extern ma_result spatializer_get_master_volume([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer, float* pVolume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_input_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint spatializer_get_input_channels([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_output_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint spatializer_get_output_channels([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_attenuation_model", ExactSpelling = true)]
        public static extern void spatializer_set_attenuation_model(ma_spatializer* pSpatializer, ma_attenuation_model attenuationModel);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_attenuation_model", ExactSpelling = true)]
        public static extern ma_attenuation_model spatializer_get_attenuation_model([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_positioning", ExactSpelling = true)]
        public static extern void spatializer_set_positioning(ma_spatializer* pSpatializer, ma_positioning positioning);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_positioning", ExactSpelling = true)]
        public static extern ma_positioning spatializer_get_positioning([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_rolloff", ExactSpelling = true)]
        public static extern void spatializer_set_rolloff(ma_spatializer* pSpatializer, float rolloff);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_rolloff", ExactSpelling = true)]
        public static extern float spatializer_get_rolloff([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_min_gain", ExactSpelling = true)]
        public static extern void spatializer_set_min_gain(ma_spatializer* pSpatializer, float minGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_min_gain", ExactSpelling = true)]
        public static extern float spatializer_get_min_gain([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_max_gain", ExactSpelling = true)]
        public static extern void spatializer_set_max_gain(ma_spatializer* pSpatializer, float maxGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_max_gain", ExactSpelling = true)]
        public static extern float spatializer_get_max_gain([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_min_distance", ExactSpelling = true)]
        public static extern void spatializer_set_min_distance(ma_spatializer* pSpatializer, float minDistance);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_min_distance", ExactSpelling = true)]
        public static extern float spatializer_get_min_distance([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_max_distance", ExactSpelling = true)]
        public static extern void spatializer_set_max_distance(ma_spatializer* pSpatializer, float maxDistance);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_max_distance", ExactSpelling = true)]
        public static extern float spatializer_get_max_distance([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_cone", ExactSpelling = true)]
        public static extern void spatializer_set_cone(ma_spatializer* pSpatializer, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_cone", ExactSpelling = true)]
        public static extern void spatializer_get_cone([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_doppler_factor", ExactSpelling = true)]
        public static extern void spatializer_set_doppler_factor(ma_spatializer* pSpatializer, float dopplerFactor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_doppler_factor", ExactSpelling = true)]
        public static extern float spatializer_get_doppler_factor([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_directional_attenuation_factor", ExactSpelling = true)]
        public static extern void spatializer_set_directional_attenuation_factor(ma_spatializer* pSpatializer, float directionalAttenuationFactor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_directional_attenuation_factor", ExactSpelling = true)]
        public static extern float spatializer_get_directional_attenuation_factor([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_position", ExactSpelling = true)]
        public static extern void spatializer_set_position(ma_spatializer* pSpatializer, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_position", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_get_position([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_direction", ExactSpelling = true)]
        public static extern void spatializer_set_direction(ma_spatializer* pSpatializer, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_direction", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_get_direction([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_set_velocity", ExactSpelling = true)]
        public static extern void spatializer_set_velocity(ma_spatializer* pSpatializer, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_velocity", ExactSpelling = true)]
        public static extern ma_vec3f spatializer_get_velocity([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spatializer_get_relative_position_and_direction", ExactSpelling = true)]
        public static extern void spatializer_get_relative_position_and_direction([NativeTypeName("const ma_spatializer *")] ma_spatializer* pSpatializer, [NativeTypeName("const ma_spatializer_listener *")] ma_spatializer_listener* pListener, ma_vec3f* pRelativePos, ma_vec3f* pRelativeDir);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_config_init", ExactSpelling = true)]
        public static extern ma_linear_resampler_config linear_resampler_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_get_heap_size", ExactSpelling = true)]
        public static extern ma_result linear_resampler_get_heap_size([NativeTypeName("const ma_linear_resampler_config *")] ma_linear_resampler_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_init_preallocated", ExactSpelling = true)]
        public static extern ma_result linear_resampler_init_preallocated([NativeTypeName("const ma_linear_resampler_config *")] ma_linear_resampler_config* pConfig, void* pHeap, ma_linear_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_init", ExactSpelling = true)]
        public static extern ma_result linear_resampler_init([NativeTypeName("const ma_linear_resampler_config *")] ma_linear_resampler_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_linear_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_uninit", ExactSpelling = true)]
        public static extern void linear_resampler_uninit(ma_linear_resampler* pResampler, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result linear_resampler_process_pcm_frames(ma_linear_resampler* pResampler, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountIn, void* pFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_set_rate", ExactSpelling = true)]
        public static extern ma_result linear_resampler_set_rate(ma_linear_resampler* pResampler, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_set_rate_ratio", ExactSpelling = true)]
        public static extern ma_result linear_resampler_set_rate_ratio(ma_linear_resampler* pResampler, float ratioInOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_get_input_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong linear_resampler_get_input_latency([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_get_output_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong linear_resampler_get_output_latency([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_get_required_input_frame_count", ExactSpelling = true)]
        public static extern ma_result linear_resampler_get_required_input_frame_count([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong outputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pInputFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_get_expected_output_frame_count", ExactSpelling = true)]
        public static extern ma_result linear_resampler_get_expected_output_frame_count([NativeTypeName("const ma_linear_resampler *")] ma_linear_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong inputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pOutputFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_linear_resampler_reset", ExactSpelling = true)]
        public static extern ma_result linear_resampler_reset(ma_linear_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_config_init", ExactSpelling = true)]
        public static extern ma_resampler_config resampler_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut, ma_resample_algorithm algorithm);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_get_heap_size", ExactSpelling = true)]
        public static extern ma_result resampler_get_heap_size([NativeTypeName("const ma_resampler_config *")] ma_resampler_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_init_preallocated", ExactSpelling = true)]
        public static extern ma_result resampler_init_preallocated([NativeTypeName("const ma_resampler_config *")] ma_resampler_config* pConfig, void* pHeap, ma_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_init", ExactSpelling = true)]
        public static extern ma_result resampler_init([NativeTypeName("const ma_resampler_config *")] ma_resampler_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_uninit", ExactSpelling = true)]
        public static extern void resampler_uninit(ma_resampler* pResampler, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resampler_process_pcm_frames(ma_resampler* pResampler, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountIn, void* pFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_set_rate", ExactSpelling = true)]
        public static extern ma_result resampler_set_rate(ma_resampler* pResampler, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_set_rate_ratio", ExactSpelling = true)]
        public static extern ma_result resampler_set_rate_ratio(ma_resampler* pResampler, float ratio);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_get_input_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong resampler_get_input_latency([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_get_output_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong resampler_get_output_latency([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_get_required_input_frame_count", ExactSpelling = true)]
        public static extern ma_result resampler_get_required_input_frame_count([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong outputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pInputFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_get_expected_output_frame_count", ExactSpelling = true)]
        public static extern ma_result resampler_get_expected_output_frame_count([NativeTypeName("const ma_resampler *")] ma_resampler* pResampler, [NativeTypeName("ma_uint64")] ulong inputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pOutputFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resampler_reset", ExactSpelling = true)]
        public static extern ma_result resampler_reset(ma_resampler* pResampler);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_config_init", ExactSpelling = true)]
        public static extern ma_channel_converter_config channel_converter_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("const ma_channel *")] byte* pChannelMapIn, [NativeTypeName("ma_uint32")] uint channelsOut, [NativeTypeName("const ma_channel *")] byte* pChannelMapOut, ma_channel_mix_mode mixingMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_get_heap_size", ExactSpelling = true)]
        public static extern ma_result channel_converter_get_heap_size([NativeTypeName("const ma_channel_converter_config *")] ma_channel_converter_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_init_preallocated", ExactSpelling = true)]
        public static extern ma_result channel_converter_init_preallocated([NativeTypeName("const ma_channel_converter_config *")] ma_channel_converter_config* pConfig, void* pHeap, ma_channel_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_init", ExactSpelling = true)]
        public static extern ma_result channel_converter_init([NativeTypeName("const ma_channel_converter_config *")] ma_channel_converter_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_channel_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_uninit", ExactSpelling = true)]
        public static extern void channel_converter_uninit(ma_channel_converter* pConverter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result channel_converter_process_pcm_frames(ma_channel_converter* pConverter, void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_get_input_channel_map", ExactSpelling = true)]
        public static extern ma_result channel_converter_get_input_channel_map([NativeTypeName("const ma_channel_converter *")] ma_channel_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_converter_get_output_channel_map", ExactSpelling = true)]
        public static extern ma_result channel_converter_get_output_channel_map([NativeTypeName("const ma_channel_converter *")] ma_channel_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_config_init_default", ExactSpelling = true)]
        public static extern ma_data_converter_config data_converter_config_init_default();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_config_init", ExactSpelling = true)]
        public static extern ma_data_converter_config data_converter_config_init(ma_format formatIn, ma_format formatOut, [NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("ma_uint32")] uint channelsOut, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_heap_size", ExactSpelling = true)]
        public static extern ma_result data_converter_get_heap_size([NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_init_preallocated", ExactSpelling = true)]
        public static extern ma_result data_converter_init_preallocated([NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig, void* pHeap, ma_data_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_init", ExactSpelling = true)]
        public static extern ma_result data_converter_init([NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_data_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_uninit", ExactSpelling = true)]
        public static extern void data_converter_uninit(ma_data_converter* pConverter, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_process_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_converter_process_pcm_frames(ma_data_converter* pConverter, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountIn, void* pFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_set_rate", ExactSpelling = true)]
        public static extern ma_result data_converter_set_rate(ma_data_converter* pConverter, [NativeTypeName("ma_uint32")] uint sampleRateIn, [NativeTypeName("ma_uint32")] uint sampleRateOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_set_rate_ratio", ExactSpelling = true)]
        public static extern ma_result data_converter_set_rate_ratio(ma_data_converter* pConverter, float ratioInOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_input_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong data_converter_get_input_latency([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_output_latency", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong data_converter_get_output_latency([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_required_input_frame_count", ExactSpelling = true)]
        public static extern ma_result data_converter_get_required_input_frame_count([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_uint64")] ulong outputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pInputFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_expected_output_frame_count", ExactSpelling = true)]
        public static extern ma_result data_converter_get_expected_output_frame_count([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_uint64")] ulong inputFrameCount, [NativeTypeName("ma_uint64 *")] ulong* pOutputFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_input_channel_map", ExactSpelling = true)]
        public static extern ma_result data_converter_get_input_channel_map([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_get_output_channel_map", ExactSpelling = true)]
        public static extern ma_result data_converter_get_output_channel_map([NativeTypeName("const ma_data_converter *")] ma_data_converter* pConverter, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_converter_reset", ExactSpelling = true)]
        public static extern ma_result data_converter_reset(ma_data_converter* pConverter);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_u8_to_s16", ExactSpelling = true)]
        public static extern void pcm_u8_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_u8_to_s24", ExactSpelling = true)]
        public static extern void pcm_u8_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_u8_to_s32", ExactSpelling = true)]
        public static extern void pcm_u8_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_u8_to_f32", ExactSpelling = true)]
        public static extern void pcm_u8_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s16_to_u8", ExactSpelling = true)]
        public static extern void pcm_s16_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s16_to_s24", ExactSpelling = true)]
        public static extern void pcm_s16_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s16_to_s32", ExactSpelling = true)]
        public static extern void pcm_s16_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s16_to_f32", ExactSpelling = true)]
        public static extern void pcm_s16_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s24_to_u8", ExactSpelling = true)]
        public static extern void pcm_s24_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s24_to_s16", ExactSpelling = true)]
        public static extern void pcm_s24_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s24_to_s32", ExactSpelling = true)]
        public static extern void pcm_s24_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s24_to_f32", ExactSpelling = true)]
        public static extern void pcm_s24_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s32_to_u8", ExactSpelling = true)]
        public static extern void pcm_s32_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s32_to_s16", ExactSpelling = true)]
        public static extern void pcm_s32_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s32_to_s24", ExactSpelling = true)]
        public static extern void pcm_s32_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_s32_to_f32", ExactSpelling = true)]
        public static extern void pcm_s32_to_f32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_f32_to_u8", ExactSpelling = true)]
        public static extern void pcm_f32_to_u8(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_f32_to_s16", ExactSpelling = true)]
        public static extern void pcm_f32_to_s16(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_f32_to_s24", ExactSpelling = true)]
        public static extern void pcm_f32_to_s24(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_f32_to_s32", ExactSpelling = true)]
        public static extern void pcm_f32_to_s32(void* pOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong count, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_convert", ExactSpelling = true)]
        public static extern void pcm_convert(void* pOut, ma_format formatOut, [NativeTypeName("const void *")] void* pIn, ma_format formatIn, [NativeTypeName("ma_uint64")] ulong sampleCount, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_convert_pcm_frames_format", ExactSpelling = true)]
        public static extern void convert_pcm_frames_format(void* pOut, ma_format formatOut, [NativeTypeName("const void *")] void* pIn, ma_format formatIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, ma_dither_mode ditherMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_deinterleave_pcm_frames", ExactSpelling = true)]
        public static extern void deinterleave_pcm_frames(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("const void *")] void* pInterleavedPCMFrames, void** ppDeinterleavedPCMFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_interleave_pcm_frames", ExactSpelling = true)]
        public static extern void interleave_pcm_frames(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("const void **")] void** ppDeinterleavedPCMFrames, void* pInterleavedPCMFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_get_channel", ExactSpelling = true)]
        [return: NativeTypeName("ma_channel")]
        public static extern byte channel_map_get_channel([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channelCount, [NativeTypeName("ma_uint32")] uint channelIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_init_blank", ExactSpelling = true)]
        public static extern void channel_map_init_blank([NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_init_standard", ExactSpelling = true)]
        public static extern void channel_map_init_standard(ma_standard_channel_map standardChannelMap, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_copy", ExactSpelling = true)]
        public static extern void channel_map_copy([NativeTypeName("ma_channel *")] byte* pOut, [NativeTypeName("const ma_channel *")] byte* pIn, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_copy_or_default", ExactSpelling = true)]
        public static extern void channel_map_copy_or_default([NativeTypeName("ma_channel *")] byte* pOut, [NativeTypeName("size_t")] nuint channelMapCapOut, [NativeTypeName("const ma_channel *")] byte* pIn, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_is_valid", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint channel_map_is_valid([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_is_equal", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint channel_map_is_equal([NativeTypeName("const ma_channel *")] byte* pChannelMapA, [NativeTypeName("const ma_channel *")] byte* pChannelMapB, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_is_blank", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint channel_map_is_blank([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_contains_channel_position", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint channel_map_contains_channel_position([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_channel")] byte channelPosition);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_find_channel_position", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint channel_map_find_channel_position([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_channel")] byte channelPosition, [NativeTypeName("ma_uint32 *")] uint* pChannelIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_map_to_string", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint channel_map_to_string([NativeTypeName("const ma_channel *")] byte* pChannelMap, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("char *")] sbyte* pBufferOut, [NativeTypeName("size_t")] nuint bufferCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_channel_position_to_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* channel_position_to_string([NativeTypeName("ma_channel")] byte channel);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_convert_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong convert_frames(void* pOut, [NativeTypeName("ma_uint64")] ulong frameCountOut, ma_format formatOut, [NativeTypeName("ma_uint32")] uint channelsOut, [NativeTypeName("ma_uint32")] uint sampleRateOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong frameCountIn, ma_format formatIn, [NativeTypeName("ma_uint32")] uint channelsIn, [NativeTypeName("ma_uint32")] uint sampleRateIn);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_convert_frames_ex", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong convert_frames_ex(void* pOut, [NativeTypeName("ma_uint64")] ulong frameCountOut, [NativeTypeName("const void *")] void* pIn, [NativeTypeName("ma_uint64")] ulong frameCountIn, [NativeTypeName("const ma_data_converter_config *")] ma_data_converter_config* pConfig);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_config_init", ExactSpelling = true)]
        public static extern ma_data_source_config data_source_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_init", ExactSpelling = true)]
        public static extern ma_result data_source_init([NativeTypeName("const ma_data_source_config *")] ma_data_source_config* pConfig, [NativeTypeName("ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_uninit", ExactSpelling = true)]
        public static extern void data_source_uninit([NativeTypeName("ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_source_read_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_seek_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_source_seek_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesSeeked);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result data_source_seek_to_pcm_frame([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_seek_seconds", ExactSpelling = true)]
        public static extern ma_result data_source_seek_seconds([NativeTypeName("ma_data_source *")] void* pDataSource, float secondCount, float* pSecondsSeeked);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_seek_to_second", ExactSpelling = true)]
        public static extern ma_result data_source_seek_to_second([NativeTypeName("ma_data_source *")] void* pDataSource, float seekPointInSeconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_data_format", ExactSpelling = true)]
        public static extern ma_result data_source_get_data_format([NativeTypeName("ma_data_source *")] void* pDataSource, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_source_get_cursor_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_source_get_length_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_cursor_in_seconds", ExactSpelling = true)]
        public static extern ma_result data_source_get_cursor_in_seconds([NativeTypeName("ma_data_source *")] void* pDataSource, float* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_length_in_seconds", ExactSpelling = true)]
        public static extern ma_result data_source_get_length_in_seconds([NativeTypeName("ma_data_source *")] void* pDataSource, float* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_set_looping", ExactSpelling = true)]
        public static extern ma_result data_source_set_looping([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_bool32")] uint isLooping);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_is_looping", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint data_source_is_looping([NativeTypeName("const ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_set_range_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_source_set_range_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong rangeBegInFrames, [NativeTypeName("ma_uint64")] ulong rangeEndInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_range_in_pcm_frames", ExactSpelling = true)]
        public static extern void data_source_get_range_in_pcm_frames([NativeTypeName("const ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pRangeBegInFrames, [NativeTypeName("ma_uint64 *")] ulong* pRangeEndInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_set_loop_point_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result data_source_set_loop_point_in_pcm_frames([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64")] ulong loopBegInFrames, [NativeTypeName("ma_uint64")] ulong loopEndInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_loop_point_in_pcm_frames", ExactSpelling = true)]
        public static extern void data_source_get_loop_point_in_pcm_frames([NativeTypeName("const ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pLoopBegInFrames, [NativeTypeName("ma_uint64 *")] ulong* pLoopEndInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_set_current", ExactSpelling = true)]
        public static extern ma_result data_source_set_current([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_data_source *")] void* pCurrentDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_current", ExactSpelling = true)]
        [return: NativeTypeName("ma_data_source *")]
        public static extern void* data_source_get_current([NativeTypeName("const ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_set_next", ExactSpelling = true)]
        public static extern ma_result data_source_set_next([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_data_source *")] void* pNextDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_next", ExactSpelling = true)]
        [return: NativeTypeName("ma_data_source *")]
        public static extern void* data_source_get_next([NativeTypeName("const ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_set_next_callback", ExactSpelling = true)]
        public static extern ma_result data_source_set_next_callback([NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_data_source_get_next_proc")] delegate* unmanaged[Cdecl]<void*, void*> onGetNext);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_get_next_callback", ExactSpelling = true)]
        [return: NativeTypeName("ma_data_source_get_next_proc")]
        public static extern delegate* unmanaged[Cdecl]<void*, void*> data_source_get_next_callback([NativeTypeName("const ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_init", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong sizeInFrames, ma_audio_buffer_ref* pAudioBufferRef);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_uninit", ExactSpelling = true)]
        public static extern void audio_buffer_ref_uninit(ma_audio_buffer_ref* pAudioBufferRef);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_set_data", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_set_data(ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong sizeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_read_pcm_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong audio_buffer_ref_read_pcm_frames(ma_audio_buffer_ref* pAudioBufferRef, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_bool32")] uint loop);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_seek_to_pcm_frame(ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_map", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_map(ma_audio_buffer_ref* pAudioBufferRef, void** ppFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_unmap", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_unmap(ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_at_end", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint audio_buffer_ref_at_end([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_get_cursor_in_pcm_frames([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_get_length_in_pcm_frames([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_ref_get_available_frames", ExactSpelling = true)]
        public static extern ma_result audio_buffer_ref_get_available_frames([NativeTypeName("const ma_audio_buffer_ref *")] ma_audio_buffer_ref* pAudioBufferRef, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_config_init", ExactSpelling = true)]
        public static extern ma_audio_buffer_config audio_buffer_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint64")] ulong sizeInFrames, [NativeTypeName("const void *")] void* pData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_init", ExactSpelling = true)]
        public static extern ma_result audio_buffer_init([NativeTypeName("const ma_audio_buffer_config *")] ma_audio_buffer_config* pConfig, ma_audio_buffer* pAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_init_copy", ExactSpelling = true)]
        public static extern ma_result audio_buffer_init_copy([NativeTypeName("const ma_audio_buffer_config *")] ma_audio_buffer_config* pConfig, ma_audio_buffer* pAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_alloc_and_init", ExactSpelling = true)]
        public static extern ma_result audio_buffer_alloc_and_init([NativeTypeName("const ma_audio_buffer_config *")] ma_audio_buffer_config* pConfig, ma_audio_buffer** ppAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_uninit", ExactSpelling = true)]
        public static extern void audio_buffer_uninit(ma_audio_buffer* pAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_uninit_and_free", ExactSpelling = true)]
        public static extern void audio_buffer_uninit_and_free(ma_audio_buffer* pAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_read_pcm_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong audio_buffer_read_pcm_frames(ma_audio_buffer* pAudioBuffer, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_bool32")] uint loop);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result audio_buffer_seek_to_pcm_frame(ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_map", ExactSpelling = true)]
        public static extern ma_result audio_buffer_map(ma_audio_buffer* pAudioBuffer, void** ppFramesOut, [NativeTypeName("ma_uint64 *")] ulong* pFrameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_unmap", ExactSpelling = true)]
        public static extern ma_result audio_buffer_unmap(ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64")] ulong frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_at_end", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint audio_buffer_at_end([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result audio_buffer_get_cursor_in_pcm_frames([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result audio_buffer_get_length_in_pcm_frames([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_audio_buffer_get_available_frames", ExactSpelling = true)]
        public static extern ma_result audio_buffer_get_available_frames([NativeTypeName("const ma_audio_buffer *")] ma_audio_buffer* pAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_init", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_data_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, ma_paged_audio_buffer_data* pData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_uninit", ExactSpelling = true)]
        public static extern void paged_audio_buffer_data_uninit(ma_paged_audio_buffer_data* pData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_get_head", ExactSpelling = true)]
        public static extern ma_paged_audio_buffer_page* paged_audio_buffer_data_get_head(ma_paged_audio_buffer_data* pData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_get_tail", ExactSpelling = true)]
        public static extern ma_paged_audio_buffer_page* paged_audio_buffer_data_get_tail(ma_paged_audio_buffer_data* pData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_data_get_length_in_pcm_frames(ma_paged_audio_buffer_data* pData, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_allocate_page", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_data_allocate_page(ma_paged_audio_buffer_data* pData, [NativeTypeName("ma_uint64")] ulong pageSizeInFrames, [NativeTypeName("const void *")] void* pInitialData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_paged_audio_buffer_page** ppPage);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_free_page", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_data_free_page(ma_paged_audio_buffer_data* pData, ma_paged_audio_buffer_page* pPage, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_append_page", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_data_append_page(ma_paged_audio_buffer_data* pData, ma_paged_audio_buffer_page* pPage);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_data_allocate_and_append_page", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_data_allocate_and_append_page(ma_paged_audio_buffer_data* pData, [NativeTypeName("ma_uint32")] uint pageSizeInFrames, [NativeTypeName("const void *")] void* pInitialData, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_config_init", ExactSpelling = true)]
        public static extern ma_paged_audio_buffer_config paged_audio_buffer_config_init(ma_paged_audio_buffer_data* pData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_init", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_init([NativeTypeName("const ma_paged_audio_buffer_config *")] ma_paged_audio_buffer_config* pConfig, ma_paged_audio_buffer* pPagedAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_uninit", ExactSpelling = true)]
        public static extern void paged_audio_buffer_uninit(ma_paged_audio_buffer* pPagedAudioBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_read_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_seek_to_pcm_frame(ma_paged_audio_buffer* pPagedAudioBuffer, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_get_cursor_in_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_paged_audio_buffer_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result paged_audio_buffer_get_length_in_pcm_frames(ma_paged_audio_buffer* pPagedAudioBuffer, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_init_ex", ExactSpelling = true)]
        public static extern ma_result rb_init_ex([NativeTypeName("size_t")] nuint subbufferSizeInBytes, [NativeTypeName("size_t")] nuint subbufferCount, [NativeTypeName("size_t")] nuint subbufferStrideInBytes, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_init", ExactSpelling = true)]
        public static extern ma_result rb_init([NativeTypeName("size_t")] nuint bufferSizeInBytes, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_uninit", ExactSpelling = true)]
        public static extern void rb_uninit(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_reset", ExactSpelling = true)]
        public static extern void rb_reset(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_acquire_read", ExactSpelling = true)]
        public static extern ma_result rb_acquire_read(ma_rb* pRB, [NativeTypeName("size_t *")] nuint* pSizeInBytes, void** ppBufferOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_commit_read", ExactSpelling = true)]
        public static extern ma_result rb_commit_read(ma_rb* pRB, [NativeTypeName("size_t")] nuint sizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_acquire_write", ExactSpelling = true)]
        public static extern ma_result rb_acquire_write(ma_rb* pRB, [NativeTypeName("size_t *")] nuint* pSizeInBytes, void** ppBufferOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_commit_write", ExactSpelling = true)]
        public static extern ma_result rb_commit_write(ma_rb* pRB, [NativeTypeName("size_t")] nuint sizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_seek_read", ExactSpelling = true)]
        public static extern ma_result rb_seek_read(ma_rb* pRB, [NativeTypeName("size_t")] nuint offsetInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_seek_write", ExactSpelling = true)]
        public static extern ma_result rb_seek_write(ma_rb* pRB, [NativeTypeName("size_t")] nuint offsetInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_pointer_distance", ExactSpelling = true)]
        [return: NativeTypeName("ma_int32")]
        public static extern int rb_pointer_distance(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_available_read", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint rb_available_read(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_available_write", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint rb_available_write(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_get_subbuffer_size", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint rb_get_subbuffer_size(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_get_subbuffer_stride", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint rb_get_subbuffer_stride(ma_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_get_subbuffer_offset", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint rb_get_subbuffer_offset(ma_rb* pRB, [NativeTypeName("size_t")] nuint subbufferIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_rb_get_subbuffer_ptr", ExactSpelling = true)]
        public static extern void* rb_get_subbuffer_ptr(ma_rb* pRB, [NativeTypeName("size_t")] nuint subbufferIndex, void* pBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_init_ex", ExactSpelling = true)]
        public static extern ma_result pcm_rb_init_ex(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint subbufferSizeInFrames, [NativeTypeName("ma_uint32")] uint subbufferCount, [NativeTypeName("ma_uint32")] uint subbufferStrideInFrames, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_init", ExactSpelling = true)]
        public static extern ma_result pcm_rb_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint bufferSizeInFrames, void* pOptionalPreallocatedBuffer, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_uninit", ExactSpelling = true)]
        public static extern void pcm_rb_uninit(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_reset", ExactSpelling = true)]
        public static extern void pcm_rb_reset(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_acquire_read", ExactSpelling = true)]
        public static extern ma_result pcm_rb_acquire_read(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32 *")] uint* pSizeInFrames, void** ppBufferOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_commit_read", ExactSpelling = true)]
        public static extern ma_result pcm_rb_commit_read(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint sizeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_acquire_write", ExactSpelling = true)]
        public static extern ma_result pcm_rb_acquire_write(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32 *")] uint* pSizeInFrames, void** ppBufferOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_commit_write", ExactSpelling = true)]
        public static extern ma_result pcm_rb_commit_write(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint sizeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_seek_read", ExactSpelling = true)]
        public static extern ma_result pcm_rb_seek_read(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint offsetInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_seek_write", ExactSpelling = true)]
        public static extern ma_result pcm_rb_seek_write(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint offsetInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_pointer_distance", ExactSpelling = true)]
        [return: NativeTypeName("ma_int32")]
        public static extern int pcm_rb_pointer_distance(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_available_read", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_available_read(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_available_write", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_available_write(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_subbuffer_size", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_get_subbuffer_size(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_subbuffer_stride", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_get_subbuffer_stride(ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_subbuffer_offset", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_get_subbuffer_offset(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint subbufferIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_subbuffer_ptr", ExactSpelling = true)]
        public static extern void* pcm_rb_get_subbuffer_ptr(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint subbufferIndex, void* pBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_format", ExactSpelling = true)]
        public static extern ma_format pcm_rb_get_format([NativeTypeName("const ma_pcm_rb *")] ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_get_channels([NativeTypeName("const ma_pcm_rb *")] ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_get_sample_rate", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint pcm_rb_get_sample_rate([NativeTypeName("const ma_pcm_rb *")] ma_pcm_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pcm_rb_set_sample_rate", ExactSpelling = true)]
        public static extern void pcm_rb_set_sample_rate(ma_pcm_rb* pRB, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_duplex_rb_init", ExactSpelling = true)]
        public static extern ma_result duplex_rb_init(ma_format captureFormat, [NativeTypeName("ma_uint32")] uint captureChannels, [NativeTypeName("ma_uint32")] uint sampleRate, [NativeTypeName("ma_uint32")] uint captureInternalSampleRate, [NativeTypeName("ma_uint32")] uint captureInternalPeriodSizeInFrames, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_duplex_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_duplex_rb_uninit", ExactSpelling = true)]
        public static extern ma_result duplex_rb_uninit(ma_duplex_rb* pRB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_result_description", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* result_description(ma_result result);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_malloc", ExactSpelling = true)]
        public static extern void* malloc([NativeTypeName("size_t")] nuint sz, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_calloc", ExactSpelling = true)]
        public static extern void* calloc([NativeTypeName("size_t")] nuint sz, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_realloc", ExactSpelling = true)]
        public static extern void* realloc(void* p, [NativeTypeName("size_t")] nuint sz, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_free", ExactSpelling = true)]
        public static extern void free(void* p, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_aligned_malloc", ExactSpelling = true)]
        public static extern void* aligned_malloc([NativeTypeName("size_t")] nuint sz, [NativeTypeName("size_t")] nuint alignment, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_aligned_free", ExactSpelling = true)]
        public static extern void aligned_free(void* p, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_get_format_name", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* get_format_name(ma_format format);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_blend_f32", ExactSpelling = true)]
        public static extern void blend_f32(float* pOut, float* pInA, float* pInB, float factor, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_get_bytes_per_sample", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint get_bytes_per_sample(ma_format format);

        [return: NativeTypeName("ma_uint32")]
        public static uint get_bytes_per_frame(ma_format format, [NativeTypeName("ma_uint32")] uint channels)
        {
            return get_bytes_per_sample(format) * channels;
        }

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_log_level_to_string", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* log_level_to_string([NativeTypeName("ma_uint32")] uint logLevel);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spinlock_lock", ExactSpelling = true)]
        public static extern ma_result spinlock_lock([NativeTypeName("ma_spinlock *")] uint* pSpinlock);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spinlock_lock_noyield", ExactSpelling = true)]
        public static extern ma_result spinlock_lock_noyield([NativeTypeName("ma_spinlock *")] uint* pSpinlock);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_spinlock_unlock", ExactSpelling = true)]
        public static extern ma_result spinlock_unlock([NativeTypeName("ma_spinlock *")] uint* pSpinlock);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_mutex_init", ExactSpelling = true)]
        public static extern ma_result mutex_init([NativeTypeName("ma_mutex *")] void** pMutex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_mutex_uninit", ExactSpelling = true)]
        public static extern void mutex_uninit([NativeTypeName("ma_mutex *")] void** pMutex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_mutex_lock", ExactSpelling = true)]
        public static extern void mutex_lock([NativeTypeName("ma_mutex *")] void** pMutex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_mutex_unlock", ExactSpelling = true)]
        public static extern void mutex_unlock([NativeTypeName("ma_mutex *")] void** pMutex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_event_init", ExactSpelling = true)]
        public static extern ma_result event_init([NativeTypeName("ma_event *")] void** pEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_event_uninit", ExactSpelling = true)]
        public static extern void event_uninit([NativeTypeName("ma_event *")] void** pEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_event_wait", ExactSpelling = true)]
        public static extern ma_result event_wait([NativeTypeName("ma_event *")] void** pEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_event_signal", ExactSpelling = true)]
        public static extern ma_result event_signal([NativeTypeName("ma_event *")] void** pEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_semaphore_init", ExactSpelling = true)]
        public static extern ma_result semaphore_init(int initialValue, [NativeTypeName("ma_semaphore *")] void** pSemaphore);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_semaphore_uninit", ExactSpelling = true)]
        public static extern void semaphore_uninit([NativeTypeName("ma_semaphore *")] void** pSemaphore);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_semaphore_wait", ExactSpelling = true)]
        public static extern ma_result semaphore_wait([NativeTypeName("ma_semaphore *")] void** pSemaphore);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_semaphore_release", ExactSpelling = true)]
        public static extern ma_result semaphore_release([NativeTypeName("ma_semaphore *")] void** pSemaphore);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fence_init", ExactSpelling = true)]
        public static extern ma_result fence_init(ma_fence* pFence);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fence_uninit", ExactSpelling = true)]
        public static extern void fence_uninit(ma_fence* pFence);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fence_acquire", ExactSpelling = true)]
        public static extern ma_result fence_acquire(ma_fence* pFence);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fence_release", ExactSpelling = true)]
        public static extern ma_result fence_release(ma_fence* pFence);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_fence_wait", ExactSpelling = true)]
        public static extern ma_result fence_wait(ma_fence* pFence);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_signal", ExactSpelling = true)]
        public static extern ma_result async_notification_signal([NativeTypeName("ma_async_notification *")] void* pNotification);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_poll_init", ExactSpelling = true)]
        public static extern ma_result async_notification_poll_init(ma_async_notification_poll* pNotificationPoll);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_poll_is_signalled", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint async_notification_poll_is_signalled([NativeTypeName("const ma_async_notification_poll *")] ma_async_notification_poll* pNotificationPoll);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_event_init", ExactSpelling = true)]
        public static extern ma_result async_notification_event_init(ma_async_notification_event* pNotificationEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_event_uninit", ExactSpelling = true)]
        public static extern ma_result async_notification_event_uninit(ma_async_notification_event* pNotificationEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_event_wait", ExactSpelling = true)]
        public static extern ma_result async_notification_event_wait(ma_async_notification_event* pNotificationEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_async_notification_event_signal", ExactSpelling = true)]
        public static extern ma_result async_notification_event_signal(ma_async_notification_event* pNotificationEvent);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_config_init", ExactSpelling = true)]
        public static extern ma_slot_allocator_config slot_allocator_config_init([NativeTypeName("ma_uint32")] uint capacity);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_get_heap_size", ExactSpelling = true)]
        public static extern ma_result slot_allocator_get_heap_size([NativeTypeName("const ma_slot_allocator_config *")] ma_slot_allocator_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_init_preallocated", ExactSpelling = true)]
        public static extern ma_result slot_allocator_init_preallocated([NativeTypeName("const ma_slot_allocator_config *")] ma_slot_allocator_config* pConfig, void* pHeap, ma_slot_allocator* pAllocator);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_init", ExactSpelling = true)]
        public static extern ma_result slot_allocator_init([NativeTypeName("const ma_slot_allocator_config *")] ma_slot_allocator_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_slot_allocator* pAllocator);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_uninit", ExactSpelling = true)]
        public static extern void slot_allocator_uninit(ma_slot_allocator* pAllocator, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_alloc", ExactSpelling = true)]
        public static extern ma_result slot_allocator_alloc(ma_slot_allocator* pAllocator, [NativeTypeName("ma_uint64 *")] ulong* pSlot);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_slot_allocator_free", ExactSpelling = true)]
        public static extern ma_result slot_allocator_free(ma_slot_allocator* pAllocator, [NativeTypeName("ma_uint64")] ulong slot);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_init", ExactSpelling = true)]
        public static extern ma_job job_init([NativeTypeName("ma_uint16")] ushort code);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_process", ExactSpelling = true)]
        public static extern ma_result job_process(ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_config_init", ExactSpelling = true)]
        public static extern ma_job_queue_config job_queue_config_init([NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_uint32")] uint capacity);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_get_heap_size", ExactSpelling = true)]
        public static extern ma_result job_queue_get_heap_size([NativeTypeName("const ma_job_queue_config *")] ma_job_queue_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_init_preallocated", ExactSpelling = true)]
        public static extern ma_result job_queue_init_preallocated([NativeTypeName("const ma_job_queue_config *")] ma_job_queue_config* pConfig, void* pHeap, ma_job_queue* pQueue);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_init", ExactSpelling = true)]
        public static extern ma_result job_queue_init([NativeTypeName("const ma_job_queue_config *")] ma_job_queue_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_job_queue* pQueue);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_uninit", ExactSpelling = true)]
        public static extern void job_queue_uninit(ma_job_queue* pQueue, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_post", ExactSpelling = true)]
        public static extern ma_result job_queue_post(ma_job_queue* pQueue, [NativeTypeName("const ma_job *")] ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_job_queue_next", ExactSpelling = true)]
        public static extern ma_result job_queue_next(ma_job_queue* pQueue, ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_job_thread_config_init", ExactSpelling = true)]
        public static extern ma_device_job_thread_config device_job_thread_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_job_thread_init", ExactSpelling = true)]
        public static extern ma_result device_job_thread_init([NativeTypeName("const ma_device_job_thread_config *")] ma_device_job_thread_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_device_job_thread* pJobThread);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_job_thread_uninit", ExactSpelling = true)]
        public static extern void device_job_thread_uninit(ma_device_job_thread* pJobThread, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_job_thread_post", ExactSpelling = true)]
        public static extern ma_result device_job_thread_post(ma_device_job_thread* pJobThread, [NativeTypeName("const ma_job *")] ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_job_thread_next", ExactSpelling = true)]
        public static extern ma_result device_job_thread_next(ma_device_job_thread* pJobThread, ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_id_equal", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint device_id_equal([NativeTypeName("const ma_device_id *")] ma_device_id* pA, [NativeTypeName("const ma_device_id *")] ma_device_id* pB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_config_init", ExactSpelling = true)]
        public static extern ma_context_config context_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_init", ExactSpelling = true)]
        public static extern ma_result context_init([NativeTypeName("const ma_backend[]")] ma_backend* backends, [NativeTypeName("ma_uint32")] uint backendCount, [NativeTypeName("const ma_context_config *")] ma_context_config* pConfig, ma_context* pContext);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_uninit", ExactSpelling = true)]
        public static extern ma_result context_uninit(ma_context* pContext);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_sizeof", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint context_sizeof();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_get_log", ExactSpelling = true)]
        public static extern ma_log* context_get_log(ma_context* pContext);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_enumerate_devices", ExactSpelling = true)]
        public static extern ma_result context_enumerate_devices(ma_context* pContext, [NativeTypeName("ma_enum_devices_callback_proc")] delegate* unmanaged[Cdecl]<ma_context*, ma_device_type, ma_device_info*, void*, uint> callback, void* pUserData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_get_devices", ExactSpelling = true)]
        public static extern ma_result context_get_devices(ma_context* pContext, ma_device_info** ppPlaybackDeviceInfos, [NativeTypeName("ma_uint32 *")] uint* pPlaybackDeviceCount, ma_device_info** ppCaptureDeviceInfos, [NativeTypeName("ma_uint32 *")] uint* pCaptureDeviceCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_get_device_info", ExactSpelling = true)]
        public static extern ma_result context_get_device_info(ma_context* pContext, ma_device_type deviceType, [NativeTypeName("const ma_device_id *")] ma_device_id* pDeviceID, ma_device_info* pDeviceInfo);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_context_is_loopback_supported", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint context_is_loopback_supported(ma_context* pContext);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_config_init", ExactSpelling = true)]
        public static extern ma_device_config device_config_init(ma_device_type deviceType);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_init", ExactSpelling = true)]
        public static extern ma_result device_init(ma_context* pContext, [NativeTypeName("const ma_device_config *")] ma_device_config* pConfig, ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_init_ex", ExactSpelling = true)]
        public static extern ma_result device_init_ex([NativeTypeName("const ma_backend[]")] ma_backend* backends, [NativeTypeName("ma_uint32")] uint backendCount, [NativeTypeName("const ma_context_config *")] ma_context_config* pContextConfig, [NativeTypeName("const ma_device_config *")] ma_device_config* pConfig, ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_uninit", ExactSpelling = true)]
        public static extern void device_uninit(ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_context", ExactSpelling = true)]
        public static extern ma_context* device_get_context(ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_log", ExactSpelling = true)]
        public static extern ma_log* device_get_log(ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_info", ExactSpelling = true)]
        public static extern ma_result device_get_info(ma_device* pDevice, ma_device_type type, ma_device_info* pDeviceInfo);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_name", ExactSpelling = true)]
        public static extern ma_result device_get_name(ma_device* pDevice, ma_device_type type, [NativeTypeName("char *")] sbyte* pName, [NativeTypeName("size_t")] nuint nameCap, [NativeTypeName("size_t *")] nuint* pLengthNotIncludingNullTerminator);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_start", ExactSpelling = true)]
        public static extern ma_result device_start(ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_stop", ExactSpelling = true)]
        public static extern ma_result device_stop(ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_is_started", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint device_is_started([NativeTypeName("const ma_device *")] ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_state", ExactSpelling = true)]
        public static extern ma_device_state device_get_state([NativeTypeName("const ma_device *")] ma_device* pDevice);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_post_init", ExactSpelling = true)]
        public static extern ma_result device_post_init(ma_device* pDevice, ma_device_type deviceType, [NativeTypeName("const ma_device_descriptor *")] ma_device_descriptor* pPlaybackDescriptor, [NativeTypeName("const ma_device_descriptor *")] ma_device_descriptor* pCaptureDescriptor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_set_master_volume", ExactSpelling = true)]
        public static extern ma_result device_set_master_volume(ma_device* pDevice, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_master_volume", ExactSpelling = true)]
        public static extern ma_result device_get_master_volume(ma_device* pDevice, float* pVolume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_set_master_volume_db", ExactSpelling = true)]
        public static extern ma_result device_set_master_volume_db(ma_device* pDevice, float gainDB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_get_master_volume_db", ExactSpelling = true)]
        public static extern ma_result device_get_master_volume_db(ma_device* pDevice, float* pGainDB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_device_handle_backend_data_callback", ExactSpelling = true)]
        public static extern ma_result device_handle_backend_data_callback(ma_device* pDevice, void* pOutput, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("ma_uint32")] uint frameCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_calculate_buffer_size_in_frames_from_descriptor", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint calculate_buffer_size_in_frames_from_descriptor([NativeTypeName("const ma_device_descriptor *")] ma_device_descriptor* pDescriptor, [NativeTypeName("ma_uint32")] uint nativeSampleRate, ma_performance_profile performanceProfile);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_get_backend_name", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* get_backend_name(ma_backend backend);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_get_backend_from_name", ExactSpelling = true)]
        public static extern ma_result get_backend_from_name([NativeTypeName("const char *")] sbyte* pBackendName, ma_backend* pBackend);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_is_backend_enabled", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint is_backend_enabled(ma_backend backend);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_get_enabled_backends", ExactSpelling = true)]
        public static extern ma_result get_enabled_backends(ma_backend* pBackends, [NativeTypeName("size_t")] nuint backendCap, [NativeTypeName("size_t *")] nuint* pBackendCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_is_loopback_supported", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint is_loopback_supported(ma_backend backend);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_calculate_buffer_size_in_milliseconds_from_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint calculate_buffer_size_in_milliseconds_from_frames([NativeTypeName("ma_uint32")] uint bufferSizeInFrames, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_calculate_buffer_size_in_frames_from_milliseconds", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint calculate_buffer_size_in_frames_from_milliseconds([NativeTypeName("ma_uint32")] uint bufferSizeInMilliseconds, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_pcm_frames", ExactSpelling = true)]
        public static extern void copy_pcm_frames(void* dst, [NativeTypeName("const void *")] void* src, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_silence_pcm_frames", ExactSpelling = true)]
        public static extern void silence_pcm_frames(void* p, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_offset_pcm_frames_ptr", ExactSpelling = true)]
        public static extern void* offset_pcm_frames_ptr(void* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_offset_pcm_frames_const_ptr", ExactSpelling = true)]
        [return: NativeTypeName("const void *")]
        public static extern void* offset_pcm_frames_const_ptr([NativeTypeName("const void *")] void* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

        public static float* offset_pcm_frames_ptr_f32(float* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, [NativeTypeName("ma_uint32")] uint channels)
        {
            return (float*)(offset_pcm_frames_ptr((void*)(p), offsetInFrames, ma_format_f32, channels));
        }

        [return: NativeTypeName("const float *")]
        public static float* offset_pcm_frames_const_ptr_f32([NativeTypeName("const float *")] float* p, [NativeTypeName("ma_uint64")] ulong offsetInFrames, [NativeTypeName("ma_uint32")] uint channels)
        {
            return (float*)(offset_pcm_frames_const_ptr((void*)(p), offsetInFrames, ma_format_f32, channels));
        }

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_clip_samples_u8", ExactSpelling = true)]
        public static extern void clip_samples_u8([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int16 *")] short* pSrc, [NativeTypeName("ma_uint64")] ulong count);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_clip_samples_s16", ExactSpelling = true)]
        public static extern void clip_samples_s16([NativeTypeName("ma_int16 *")] short* pDst, [NativeTypeName("const ma_int32 *")] int* pSrc, [NativeTypeName("ma_uint64")] ulong count);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_clip_samples_s24", ExactSpelling = true)]
        public static extern void clip_samples_s24([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_clip_samples_s32", ExactSpelling = true)]
        public static extern void clip_samples_s32([NativeTypeName("ma_int32 *")] int* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_clip_samples_f32", ExactSpelling = true)]
        public static extern void clip_samples_f32(float* pDst, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("ma_uint64")] ulong count);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_clip_pcm_frames", ExactSpelling = true)]
        public static extern void clip_pcm_frames(void* pDst, [NativeTypeName("const void *")] void* pSrc, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_u8", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_u8([NativeTypeName("ma_uint8 *")] byte* pSamplesOut, [NativeTypeName("const ma_uint8 *")] byte* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_s16", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_s16([NativeTypeName("ma_int16 *")] short* pSamplesOut, [NativeTypeName("const ma_int16 *")] short* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_s24", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_s24(void* pSamplesOut, [NativeTypeName("const void *")] void* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_s32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_s32([NativeTypeName("ma_int32 *")] int* pSamplesOut, [NativeTypeName("const ma_int32 *")] int* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_f32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_f32(float* pSamplesOut, [NativeTypeName("const float *")] float* pSamplesIn, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_u8", ExactSpelling = true)]
        public static extern void apply_volume_factor_u8([NativeTypeName("ma_uint8 *")] byte* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_s16", ExactSpelling = true)]
        public static extern void apply_volume_factor_s16([NativeTypeName("ma_int16 *")] short* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_s24", ExactSpelling = true)]
        public static extern void apply_volume_factor_s24(void* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_s32", ExactSpelling = true)]
        public static extern void apply_volume_factor_s32([NativeTypeName("ma_int32 *")] int* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_f32", ExactSpelling = true)]
        public static extern void apply_volume_factor_f32(float* pSamples, [NativeTypeName("ma_uint64")] ulong sampleCount, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_u8", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_pcm_frames_u8([NativeTypeName("ma_uint8 *")] byte* pFramesOut, [NativeTypeName("const ma_uint8 *")] byte* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s16", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_pcm_frames_s16([NativeTypeName("ma_int16 *")] short* pFramesOut, [NativeTypeName("const ma_int16 *")] short* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s24", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_pcm_frames_s24(void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_s32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_pcm_frames_s32([NativeTypeName("ma_int32 *")] int* pFramesOut, [NativeTypeName("const ma_int32 *")] int* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames_f32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_pcm_frames_f32(float* pFramesOut, [NativeTypeName("const float *")] float* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_pcm_frames", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_pcm_frames(void* pFramesOut, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_pcm_frames_u8", ExactSpelling = true)]
        public static extern void apply_volume_factor_pcm_frames_u8([NativeTypeName("ma_uint8 *")] byte* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_pcm_frames_s16", ExactSpelling = true)]
        public static extern void apply_volume_factor_pcm_frames_s16([NativeTypeName("ma_int16 *")] short* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_pcm_frames_s24", ExactSpelling = true)]
        public static extern void apply_volume_factor_pcm_frames_s24(void* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_pcm_frames_s32", ExactSpelling = true)]
        public static extern void apply_volume_factor_pcm_frames_s32([NativeTypeName("ma_int32 *")] int* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_pcm_frames_f32", ExactSpelling = true)]
        public static extern void apply_volume_factor_pcm_frames_f32(float* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_apply_volume_factor_pcm_frames", ExactSpelling = true)]
        public static extern void apply_volume_factor_pcm_frames(void* pFrames, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_factor_per_channel_f32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_factor_per_channel_f32(float* pFramesOut, [NativeTypeName("const float *")] float* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float* pChannelGains);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_u8", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_and_clip_samples_u8([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int16 *")] short* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s16", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_and_clip_samples_s16([NativeTypeName("ma_int16 *")] short* pDst, [NativeTypeName("const ma_int32 *")] int* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s24", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_and_clip_samples_s24([NativeTypeName("ma_uint8 *")] byte* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_s32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_and_clip_samples_s32([NativeTypeName("ma_int32 *")] int* pDst, [NativeTypeName("const ma_int64 *")] long* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_and_clip_samples_f32", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_and_clip_samples_f32(float* pDst, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("ma_uint64")] ulong count, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_copy_and_apply_volume_and_clip_pcm_frames", ExactSpelling = true)]
        public static extern void copy_and_apply_volume_and_clip_pcm_frames(void* pDst, [NativeTypeName("const void *")] void* pSrc, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_volume_linear_to_db", ExactSpelling = true)]
        public static extern float volume_linear_to_db(float factor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_volume_db_to_linear", ExactSpelling = true)]
        public static extern float volume_db_to_linear(float gain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_mix_pcm_frames_f32", ExactSpelling = true)]
        public static extern ma_result mix_pcm_frames_f32(float* pDst, [NativeTypeName("const float *")] float* pSrc, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint32")] uint channels, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_open", ExactSpelling = true)]
        public static extern ma_result vfs_open([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint openMode, [NativeTypeName("ma_vfs_file *")] void** pFile);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_open_w", ExactSpelling = true)]
        public static extern ma_result vfs_open_w([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint openMode, [NativeTypeName("ma_vfs_file *")] void** pFile);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_close", ExactSpelling = true)]
        public static extern ma_result vfs_close([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_read", ExactSpelling = true)]
        public static extern ma_result vfs_read([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, void* pDst, [NativeTypeName("size_t")] nuint sizeInBytes, [NativeTypeName("size_t *")] nuint* pBytesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_write", ExactSpelling = true)]
        public static extern ma_result vfs_write([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, [NativeTypeName("const void *")] void* pSrc, [NativeTypeName("size_t")] nuint sizeInBytes, [NativeTypeName("size_t *")] nuint* pBytesWritten);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_seek", ExactSpelling = true)]
        public static extern ma_result vfs_seek([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, [NativeTypeName("ma_int64")] long offset, ma_seek_origin origin);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_tell", ExactSpelling = true)]
        public static extern ma_result vfs_tell([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, [NativeTypeName("ma_int64 *")] long* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_info", ExactSpelling = true)]
        public static extern ma_result vfs_info([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("ma_vfs_file")] void* file, ma_file_info* pInfo);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_vfs_open_and_read_file", ExactSpelling = true)]
        public static extern ma_result vfs_open_and_read_file([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, void** ppData, [NativeTypeName("size_t *")] nuint* pSize, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_default_vfs_init", ExactSpelling = true)]
        public static extern ma_result default_vfs_init(ma_default_vfs* pVFS, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoding_backend_config_init", ExactSpelling = true)]
        public static extern ma_decoding_backend_config decoding_backend_config_init(ma_format preferredFormat, [NativeTypeName("ma_uint32")] uint seekPointCount);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_config_init", ExactSpelling = true)]
        public static extern ma_decoder_config decoder_config_init(ma_format outputFormat, [NativeTypeName("ma_uint32")] uint outputChannels, [NativeTypeName("ma_uint32")] uint outputSampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_config_init_default", ExactSpelling = true)]
        public static extern ma_decoder_config decoder_config_init_default();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_init", ExactSpelling = true)]
        public static extern ma_result decoder_init([NativeTypeName("ma_decoder_read_proc")] delegate* unmanaged[Cdecl]<ma_decoder*, void*, nuint, nuint*, ma_result> onRead, [NativeTypeName("ma_decoder_seek_proc")] delegate* unmanaged[Cdecl]<ma_decoder*, long, ma_seek_origin, ma_result> onSeek, void* pUserData, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_init_memory", ExactSpelling = true)]
        public static extern ma_result decoder_init_memory([NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint dataSize, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_init_vfs", ExactSpelling = true)]
        public static extern ma_result decoder_init_vfs([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_init_vfs_w", ExactSpelling = true)]
        public static extern ma_result decoder_init_vfs_w([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_init_file", ExactSpelling = true)]
        public static extern ma_result decoder_init_file([NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_init_file_w", ExactSpelling = true)]
        public static extern ma_result decoder_init_file_w([NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_decoder_config *")] ma_decoder_config* pConfig, ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_uninit", ExactSpelling = true)]
        public static extern ma_result decoder_uninit(ma_decoder* pDecoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result decoder_read_pcm_frames(ma_decoder* pDecoder, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result decoder_seek_to_pcm_frame(ma_decoder* pDecoder, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_get_data_format", ExactSpelling = true)]
        public static extern ma_result decoder_get_data_format(ma_decoder* pDecoder, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result decoder_get_cursor_in_pcm_frames(ma_decoder* pDecoder, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result decoder_get_length_in_pcm_frames(ma_decoder* pDecoder, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decoder_get_available_frames", ExactSpelling = true)]
        public static extern ma_result decoder_get_available_frames(ma_decoder* pDecoder, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decode_from_vfs", ExactSpelling = true)]
        public static extern ma_result decode_from_vfs([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, ma_decoder_config* pConfig, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut, void** ppPCMFramesOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decode_file", ExactSpelling = true)]
        public static extern ma_result decode_file([NativeTypeName("const char *")] sbyte* pFilePath, ma_decoder_config* pConfig, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut, void** ppPCMFramesOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_decode_memory", ExactSpelling = true)]
        public static extern ma_result decode_memory([NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint dataSize, ma_decoder_config* pConfig, [NativeTypeName("ma_uint64 *")] ulong* pFrameCountOut, void** ppPCMFramesOut);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_config_init", ExactSpelling = true)]
        public static extern ma_encoder_config encoder_config_init(ma_encoding_format encodingFormat, ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_init", ExactSpelling = true)]
        public static extern ma_result encoder_init([NativeTypeName("ma_encoder_write_proc")] delegate* unmanaged[Cdecl]<ma_encoder*, void*, nuint, nuint*, ma_result> onWrite, [NativeTypeName("ma_encoder_seek_proc")] delegate* unmanaged[Cdecl]<ma_encoder*, long, ma_seek_origin, ma_result> onSeek, void* pUserData, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_init_vfs", ExactSpelling = true)]
        public static extern ma_result encoder_init_vfs([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_init_vfs_w", ExactSpelling = true)]
        public static extern ma_result encoder_init_vfs_w([NativeTypeName("ma_vfs *")] void* pVFS, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_init_file", ExactSpelling = true)]
        public static extern ma_result encoder_init_file([NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_init_file_w", ExactSpelling = true)]
        public static extern ma_result encoder_init_file_w([NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("const ma_encoder_config *")] ma_encoder_config* pConfig, ma_encoder* pEncoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_uninit", ExactSpelling = true)]
        public static extern void encoder_uninit(ma_encoder* pEncoder);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_encoder_write_pcm_frames", ExactSpelling = true)]
        public static extern ma_result encoder_write_pcm_frames(ma_encoder* pEncoder, [NativeTypeName("const void *")] void* pFramesIn, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesWritten);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_config_init", ExactSpelling = true)]
        public static extern ma_waveform_config waveform_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, ma_waveform_type type, double amplitude, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_init", ExactSpelling = true)]
        public static extern ma_result waveform_init([NativeTypeName("const ma_waveform_config *")] ma_waveform_config* pConfig, ma_waveform* pWaveform);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_uninit", ExactSpelling = true)]
        public static extern void waveform_uninit(ma_waveform* pWaveform);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result waveform_read_pcm_frames(ma_waveform* pWaveform, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result waveform_seek_to_pcm_frame(ma_waveform* pWaveform, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_set_amplitude", ExactSpelling = true)]
        public static extern ma_result waveform_set_amplitude(ma_waveform* pWaveform, double amplitude);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_set_frequency", ExactSpelling = true)]
        public static extern ma_result waveform_set_frequency(ma_waveform* pWaveform, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_set_type", ExactSpelling = true)]
        public static extern ma_result waveform_set_type(ma_waveform* pWaveform, ma_waveform_type type);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_waveform_set_sample_rate", ExactSpelling = true)]
        public static extern ma_result waveform_set_sample_rate(ma_waveform* pWaveform, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_config_init", ExactSpelling = true)]
        public static extern ma_pulsewave_config pulsewave_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double dutyCycle, double amplitude, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_init", ExactSpelling = true)]
        public static extern ma_result pulsewave_init([NativeTypeName("const ma_pulsewave_config *")] ma_pulsewave_config* pConfig, ma_pulsewave* pWaveform);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_uninit", ExactSpelling = true)]
        public static extern void pulsewave_uninit(ma_pulsewave* pWaveform);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result pulsewave_read_pcm_frames(ma_pulsewave* pWaveform, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result pulsewave_seek_to_pcm_frame(ma_pulsewave* pWaveform, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_set_amplitude", ExactSpelling = true)]
        public static extern ma_result pulsewave_set_amplitude(ma_pulsewave* pWaveform, double amplitude);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_set_frequency", ExactSpelling = true)]
        public static extern ma_result pulsewave_set_frequency(ma_pulsewave* pWaveform, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_set_sample_rate", ExactSpelling = true)]
        public static extern ma_result pulsewave_set_sample_rate(ma_pulsewave* pWaveform, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_pulsewave_set_duty_cycle", ExactSpelling = true)]
        public static extern ma_result pulsewave_set_duty_cycle(ma_pulsewave* pWaveform, double dutyCycle);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_config_init", ExactSpelling = true)]
        public static extern ma_noise_config noise_config_init(ma_format format, [NativeTypeName("ma_uint32")] uint channels, ma_noise_type type, [NativeTypeName("ma_int32")] int seed, double amplitude);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_get_heap_size", ExactSpelling = true)]
        public static extern ma_result noise_get_heap_size([NativeTypeName("const ma_noise_config *")] ma_noise_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_init_preallocated", ExactSpelling = true)]
        public static extern ma_result noise_init_preallocated([NativeTypeName("const ma_noise_config *")] ma_noise_config* pConfig, void* pHeap, ma_noise* pNoise);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_init", ExactSpelling = true)]
        public static extern ma_result noise_init([NativeTypeName("const ma_noise_config *")] ma_noise_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_noise* pNoise);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_uninit", ExactSpelling = true)]
        public static extern void noise_uninit(ma_noise* pNoise, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result noise_read_pcm_frames(ma_noise* pNoise, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_set_amplitude", ExactSpelling = true)]
        public static extern ma_result noise_set_amplitude(ma_noise* pNoise, double amplitude);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_set_seed", ExactSpelling = true)]
        public static extern ma_result noise_set_seed(ma_noise* pNoise, [NativeTypeName("ma_int32")] int seed);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_noise_set_type", ExactSpelling = true)]
        public static extern ma_result noise_set_type(ma_noise* pNoise, ma_noise_type type);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_pipeline_notifications_init", ExactSpelling = true)]
        public static extern ma_resource_manager_pipeline_notifications resource_manager_pipeline_notifications_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_config_init", ExactSpelling = true)]
        public static extern ma_resource_manager_data_source_config resource_manager_data_source_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_config_init", ExactSpelling = true)]
        public static extern ma_resource_manager_config resource_manager_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_init", ExactSpelling = true)]
        public static extern ma_result resource_manager_init([NativeTypeName("const ma_resource_manager_config *")] ma_resource_manager_config* pConfig, ma_resource_manager* pResourceManager);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_uninit", ExactSpelling = true)]
        public static extern void resource_manager_uninit(ma_resource_manager* pResourceManager);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_get_log", ExactSpelling = true)]
        public static extern ma_log* resource_manager_get_log(ma_resource_manager* pResourceManager);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_register_file", ExactSpelling = true)]
        public static extern ma_result resource_manager_register_file(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_register_file_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_register_file_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_register_decoded_data", ExactSpelling = true)]
        public static extern ma_result resource_manager_register_decoded_data(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_register_decoded_data_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_register_decoded_data_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("ma_uint64")] ulong frameCount, ma_format format, [NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_register_encoded_data", ExactSpelling = true)]
        public static extern ma_result resource_manager_register_encoded_data(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint sizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_register_encoded_data_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_register_encoded_data_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName, [NativeTypeName("const void *")] void* pData, [NativeTypeName("size_t")] nuint sizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_unregister_file", ExactSpelling = true)]
        public static extern ma_result resource_manager_unregister_file(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_unregister_file_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_unregister_file_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_unregister_data", ExactSpelling = true)]
        public static extern ma_result resource_manager_unregister_data(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_unregister_data_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_unregister_data_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_init_ex", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_init_ex(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source_config *")] ma_resource_manager_data_source_config* pConfig, ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_init", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_init(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_init_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_init_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_init_copy", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_init_copy(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_buffer *")] ma_resource_manager_data_buffer* pExistingDataBuffer, ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_uninit", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_uninit(ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_read_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_seek_to_pcm_frame(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_get_data_format", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_get_data_format(ma_resource_manager_data_buffer* pDataBuffer, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_get_cursor_in_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_get_length_in_pcm_frames(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_result", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_result([NativeTypeName("const ma_resource_manager_data_buffer *")] ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_set_looping", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_set_looping(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_bool32")] uint isLooping);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_is_looping", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint resource_manager_data_buffer_is_looping([NativeTypeName("const ma_resource_manager_data_buffer *")] ma_resource_manager_data_buffer* pDataBuffer);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_buffer_get_available_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_buffer_get_available_frames(ma_resource_manager_data_buffer* pDataBuffer, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_init_ex", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_init_ex(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source_config *")] ma_resource_manager_data_source_config* pConfig, ma_resource_manager_data_stream* pDataStream);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_init", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_init(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_stream* pDataStream);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_init_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_init_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_stream* pDataStream);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_uninit", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_uninit(ma_resource_manager_data_stream* pDataStream);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_read_pcm_frames(ma_resource_manager_data_stream* pDataStream, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_seek_to_pcm_frame(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_get_data_format", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_get_data_format(ma_resource_manager_data_stream* pDataStream, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_get_cursor_in_pcm_frames(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_get_length_in_pcm_frames(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_result", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_result([NativeTypeName("const ma_resource_manager_data_stream *")] ma_resource_manager_data_stream* pDataStream);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_set_looping", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_set_looping(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_bool32")] uint isLooping);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_is_looping", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint resource_manager_data_stream_is_looping([NativeTypeName("const ma_resource_manager_data_stream *")] ma_resource_manager_data_stream* pDataStream);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_stream_get_available_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_stream_get_available_frames(ma_resource_manager_data_stream* pDataStream, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_init_ex", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_init_ex(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source_config *")] ma_resource_manager_data_source_config* pConfig, ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_init", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_init(ma_resource_manager* pResourceManager, [NativeTypeName("const char *")] sbyte* pName, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_init_w", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_init_w(ma_resource_manager* pResourceManager, [NativeTypeName("const wchar_t *")] ushort* pName, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("const ma_resource_manager_pipeline_notifications *")] ma_resource_manager_pipeline_notifications* pNotifications, ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_init_copy", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_init_copy(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_resource_manager_data_source *")] ma_resource_manager_data_source* pExistingDataSource, ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_uninit", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_uninit(ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_read_pcm_frames(ma_resource_manager_data_source* pDataSource, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_seek_to_pcm_frame(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_get_data_format", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_get_data_format(ma_resource_manager_data_source* pDataSource, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_get_cursor_in_pcm_frames(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_get_length_in_pcm_frames(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_result", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_result([NativeTypeName("const ma_resource_manager_data_source *")] ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_set_looping", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_set_looping(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_bool32")] uint isLooping);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_is_looping", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint resource_manager_data_source_is_looping([NativeTypeName("const ma_resource_manager_data_source *")] ma_resource_manager_data_source* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_data_source_get_available_frames", ExactSpelling = true)]
        public static extern ma_result resource_manager_data_source_get_available_frames(ma_resource_manager_data_source* pDataSource, [NativeTypeName("ma_uint64 *")] ulong* pAvailableFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_post_job", ExactSpelling = true)]
        public static extern ma_result resource_manager_post_job(ma_resource_manager* pResourceManager, [NativeTypeName("const ma_job *")] ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_post_job_quit", ExactSpelling = true)]
        public static extern ma_result resource_manager_post_job_quit(ma_resource_manager* pResourceManager);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_next_job", ExactSpelling = true)]
        public static extern ma_result resource_manager_next_job(ma_resource_manager* pResourceManager, ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_process_job", ExactSpelling = true)]
        public static extern ma_result resource_manager_process_job(ma_resource_manager* pResourceManager, ma_job* pJob);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_resource_manager_process_next_job", ExactSpelling = true)]
        public static extern ma_result resource_manager_process_next_job(ma_resource_manager* pResourceManager);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_config_init", ExactSpelling = true)]
        public static extern ma_node_config node_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_heap_size", ExactSpelling = true)]
        public static extern ma_result node_get_heap_size(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_node_config *")] ma_node_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_init_preallocated", ExactSpelling = true)]
        public static extern ma_result node_init_preallocated(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_node_config *")] ma_node_config* pConfig, void* pHeap, [NativeTypeName("ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_init", ExactSpelling = true)]
        public static extern ma_result node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_node_config *")] ma_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, [NativeTypeName("ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_uninit", ExactSpelling = true)]
        public static extern void node_uninit([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_node_graph", ExactSpelling = true)]
        public static extern ma_node_graph* node_get_node_graph([NativeTypeName("const ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_input_bus_count", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint node_get_input_bus_count([NativeTypeName("const ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_output_bus_count", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint node_get_output_bus_count([NativeTypeName("const ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_input_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint node_get_input_channels([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint inputBusIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_output_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint node_get_output_channels([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_attach_output_bus", ExactSpelling = true)]
        public static extern ma_result node_attach_output_bus([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex, [NativeTypeName("ma_node *")] void* pOtherNode, [NativeTypeName("ma_uint32")] uint otherNodeInputBusIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_detach_output_bus", ExactSpelling = true)]
        public static extern ma_result node_detach_output_bus([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_detach_all_output_buses", ExactSpelling = true)]
        public static extern ma_result node_detach_all_output_buses([NativeTypeName("ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_set_output_bus_volume", ExactSpelling = true)]
        public static extern ma_result node_set_output_bus_volume([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_output_bus_volume", ExactSpelling = true)]
        public static extern float node_get_output_bus_volume([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint outputBusIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_set_state", ExactSpelling = true)]
        public static extern ma_result node_set_state([NativeTypeName("ma_node *")] void* pNode, ma_node_state state);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_state", ExactSpelling = true)]
        public static extern ma_node_state node_get_state([NativeTypeName("const ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_set_state_time", ExactSpelling = true)]
        public static extern ma_result node_set_state_time([NativeTypeName("ma_node *")] void* pNode, ma_node_state state, [NativeTypeName("ma_uint64")] ulong globalTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_state_time", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong node_get_state_time([NativeTypeName("const ma_node *")] void* pNode, ma_node_state state);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_state_by_time", ExactSpelling = true)]
        public static extern ma_node_state node_get_state_by_time([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint64")] ulong globalTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_state_by_time_range", ExactSpelling = true)]
        public static extern ma_node_state node_get_state_by_time_range([NativeTypeName("const ma_node *")] void* pNode, [NativeTypeName("ma_uint64")] ulong globalTimeBeg, [NativeTypeName("ma_uint64")] ulong globalTimeEnd);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_get_time", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong node_get_time([NativeTypeName("const ma_node *")] void* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_set_time", ExactSpelling = true)]
        public static extern ma_result node_set_time([NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint64")] ulong localTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_config_init", ExactSpelling = true)]
        public static extern ma_node_graph_config node_graph_config_init([NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_init", ExactSpelling = true)]
        public static extern ma_result node_graph_init([NativeTypeName("const ma_node_graph_config *")] ma_node_graph_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_node_graph* pNodeGraph);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_uninit", ExactSpelling = true)]
        public static extern void node_graph_uninit(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_get_endpoint", ExactSpelling = true)]
        [return: NativeTypeName("ma_node *")]
        public static extern void* node_graph_get_endpoint(ma_node_graph* pNodeGraph);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result node_graph_read_pcm_frames(ma_node_graph* pNodeGraph, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_get_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint node_graph_get_channels([NativeTypeName("const ma_node_graph *")] ma_node_graph* pNodeGraph);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_get_time", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong node_graph_get_time([NativeTypeName("const ma_node_graph *")] ma_node_graph* pNodeGraph);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_node_graph_set_time", ExactSpelling = true)]
        public static extern ma_result node_graph_set_time(ma_node_graph* pNodeGraph, [NativeTypeName("ma_uint64")] ulong globalTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_node_config_init", ExactSpelling = true)]
        public static extern ma_data_source_node_config data_source_node_config_init([NativeTypeName("ma_data_source *")] void* pDataSource);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_node_init", ExactSpelling = true)]
        public static extern ma_result data_source_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_data_source_node_config *")] ma_data_source_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_data_source_node* pDataSourceNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_node_uninit", ExactSpelling = true)]
        public static extern void data_source_node_uninit(ma_data_source_node* pDataSourceNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_node_set_looping", ExactSpelling = true)]
        public static extern ma_result data_source_node_set_looping(ma_data_source_node* pDataSourceNode, [NativeTypeName("ma_bool32")] uint isLooping);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_data_source_node_is_looping", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint data_source_node_is_looping(ma_data_source_node* pDataSourceNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_splitter_node_config_init", ExactSpelling = true)]
        public static extern ma_splitter_node_config splitter_node_config_init([NativeTypeName("ma_uint32")] uint channels);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_splitter_node_init", ExactSpelling = true)]
        public static extern ma_result splitter_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_splitter_node_config *")] ma_splitter_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_splitter_node* pSplitterNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_splitter_node_uninit", ExactSpelling = true)]
        public static extern void splitter_node_uninit(ma_splitter_node* pSplitterNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_node_config_init", ExactSpelling = true)]
        public static extern ma_biquad_node_config biquad_node_config_init([NativeTypeName("ma_uint32")] uint channels, float b0, float b1, float b2, float a0, float a1, float a2);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_node_init", ExactSpelling = true)]
        public static extern ma_result biquad_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_biquad_node_config *")] ma_biquad_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_biquad_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_node_reinit", ExactSpelling = true)]
        public static extern ma_result biquad_node_reinit([NativeTypeName("const ma_biquad_config *")] ma_biquad_config* pConfig, ma_biquad_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_biquad_node_uninit", ExactSpelling = true)]
        public static extern void biquad_node_uninit(ma_biquad_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_node_config_init", ExactSpelling = true)]
        public static extern ma_lpf_node_config lpf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_node_init", ExactSpelling = true)]
        public static extern ma_result lpf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_lpf_node_config *")] ma_lpf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_lpf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_node_reinit", ExactSpelling = true)]
        public static extern ma_result lpf_node_reinit([NativeTypeName("const ma_lpf_config *")] ma_lpf_config* pConfig, ma_lpf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_lpf_node_uninit", ExactSpelling = true)]
        public static extern void lpf_node_uninit(ma_lpf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_node_config_init", ExactSpelling = true)]
        public static extern ma_hpf_node_config hpf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_node_init", ExactSpelling = true)]
        public static extern ma_result hpf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_hpf_node_config *")] ma_hpf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hpf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_node_reinit", ExactSpelling = true)]
        public static extern ma_result hpf_node_reinit([NativeTypeName("const ma_hpf_config *")] ma_hpf_config* pConfig, ma_hpf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hpf_node_uninit", ExactSpelling = true)]
        public static extern void hpf_node_uninit(ma_hpf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_node_config_init", ExactSpelling = true)]
        public static extern ma_bpf_node_config bpf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double cutoffFrequency, [NativeTypeName("ma_uint32")] uint order);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_node_init", ExactSpelling = true)]
        public static extern ma_result bpf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_bpf_node_config *")] ma_bpf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_bpf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_node_reinit", ExactSpelling = true)]
        public static extern ma_result bpf_node_reinit([NativeTypeName("const ma_bpf_config *")] ma_bpf_config* pConfig, ma_bpf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_bpf_node_uninit", ExactSpelling = true)]
        public static extern void bpf_node_uninit(ma_bpf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch_node_config_init", ExactSpelling = true)]
        public static extern ma_notch_node_config notch_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double q, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch_node_init", ExactSpelling = true)]
        public static extern ma_result notch_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_notch_node_config *")] ma_notch_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_notch_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch_node_reinit", ExactSpelling = true)]
        public static extern ma_result notch_node_reinit([NativeTypeName("const ma_notch_config *")] ma_notch2_config* pConfig, ma_notch_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_notch_node_uninit", ExactSpelling = true)]
        public static extern void notch_node_uninit(ma_notch_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak_node_config_init", ExactSpelling = true)]
        public static extern ma_peak_node_config peak_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak_node_init", ExactSpelling = true)]
        public static extern ma_result peak_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_peak_node_config *")] ma_peak_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_peak_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak_node_reinit", ExactSpelling = true)]
        public static extern ma_result peak_node_reinit([NativeTypeName("const ma_peak_config *")] ma_peak2_config* pConfig, ma_peak_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_peak_node_uninit", ExactSpelling = true)]
        public static extern void peak_node_uninit(ma_peak_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf_node_config_init", ExactSpelling = true)]
        public static extern ma_loshelf_node_config loshelf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf_node_init", ExactSpelling = true)]
        public static extern ma_result loshelf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_loshelf_node_config *")] ma_loshelf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_loshelf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf_node_reinit", ExactSpelling = true)]
        public static extern ma_result loshelf_node_reinit([NativeTypeName("const ma_loshelf_config *")] ma_loshelf2_config* pConfig, ma_loshelf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_loshelf_node_uninit", ExactSpelling = true)]
        public static extern void loshelf_node_uninit(ma_loshelf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf_node_config_init", ExactSpelling = true)]
        public static extern ma_hishelf_node_config hishelf_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, double gainDB, double q, double frequency);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf_node_init", ExactSpelling = true)]
        public static extern ma_result hishelf_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_hishelf_node_config *")] ma_hishelf_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_hishelf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf_node_reinit", ExactSpelling = true)]
        public static extern ma_result hishelf_node_reinit([NativeTypeName("const ma_hishelf_config *")] ma_hishelf2_config* pConfig, ma_hishelf_node* pNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_hishelf_node_uninit", ExactSpelling = true)]
        public static extern void hishelf_node_uninit(ma_hishelf_node* pNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_config_init", ExactSpelling = true)]
        public static extern ma_delay_node_config delay_node_config_init([NativeTypeName("ma_uint32")] uint channels, [NativeTypeName("ma_uint32")] uint sampleRate, [NativeTypeName("ma_uint32")] uint delayInFrames, float decay);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_init", ExactSpelling = true)]
        public static extern ma_result delay_node_init(ma_node_graph* pNodeGraph, [NativeTypeName("const ma_delay_node_config *")] ma_delay_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_delay_node* pDelayNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_uninit", ExactSpelling = true)]
        public static extern void delay_node_uninit(ma_delay_node* pDelayNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_set_wet", ExactSpelling = true)]
        public static extern void delay_node_set_wet(ma_delay_node* pDelayNode, float value);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_get_wet", ExactSpelling = true)]
        public static extern float delay_node_get_wet([NativeTypeName("const ma_delay_node *")] ma_delay_node* pDelayNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_set_dry", ExactSpelling = true)]
        public static extern void delay_node_set_dry(ma_delay_node* pDelayNode, float value);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_get_dry", ExactSpelling = true)]
        public static extern float delay_node_get_dry([NativeTypeName("const ma_delay_node *")] ma_delay_node* pDelayNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_set_decay", ExactSpelling = true)]
        public static extern void delay_node_set_decay(ma_delay_node* pDelayNode, float value);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_delay_node_get_decay", ExactSpelling = true)]
        public static extern float delay_node_get_decay([NativeTypeName("const ma_delay_node *")] ma_delay_node* pDelayNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_node_config_init", ExactSpelling = true)]
        public static extern ma_engine_node_config engine_node_config_init(ma_engine* pEngine, ma_engine_node_type type, [NativeTypeName("ma_uint32")] uint flags);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_node_get_heap_size", ExactSpelling = true)]
        public static extern ma_result engine_node_get_heap_size([NativeTypeName("const ma_engine_node_config *")] ma_engine_node_config* pConfig, [NativeTypeName("size_t *")] nuint* pHeapSizeInBytes);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_node_init_preallocated", ExactSpelling = true)]
        public static extern ma_result engine_node_init_preallocated([NativeTypeName("const ma_engine_node_config *")] ma_engine_node_config* pConfig, void* pHeap, ma_engine_node* pEngineNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_node_init", ExactSpelling = true)]
        public static extern ma_result engine_node_init([NativeTypeName("const ma_engine_node_config *")] ma_engine_node_config* pConfig, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks, ma_engine_node* pEngineNode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_node_uninit", ExactSpelling = true)]
        public static extern void engine_node_uninit(ma_engine_node* pEngineNode, [NativeTypeName("const ma_allocation_callbacks *")] ma_allocation_callbacks* pAllocationCallbacks);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_config_init", ExactSpelling = true)]
        public static extern ma_sound_config sound_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_config_init_2", ExactSpelling = true)]
        public static extern ma_sound_config sound_config_init_2(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_config_init", ExactSpelling = true)]
        [return: NativeTypeName("ma_sound_group_config")]
        public static extern ma_sound_config sound_group_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_config_init_2", ExactSpelling = true)]
        [return: NativeTypeName("ma_sound_group_config")]
        public static extern ma_sound_config sound_group_config_init_2(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_config_init", ExactSpelling = true)]
        public static extern ma_engine_config engine_config_init();

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_init", ExactSpelling = true)]
        public static extern ma_result engine_init([NativeTypeName("const ma_engine_config *")] ma_engine_config* pConfig, ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_uninit", ExactSpelling = true)]
        public static extern void engine_uninit(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_read_pcm_frames", ExactSpelling = true)]
        public static extern ma_result engine_read_pcm_frames(ma_engine* pEngine, void* pFramesOut, [NativeTypeName("ma_uint64")] ulong frameCount, [NativeTypeName("ma_uint64 *")] ulong* pFramesRead);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_node_graph", ExactSpelling = true)]
        public static extern ma_node_graph* engine_get_node_graph(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_resource_manager", ExactSpelling = true)]
        public static extern ma_resource_manager* engine_get_resource_manager(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_device", ExactSpelling = true)]
        public static extern ma_device* engine_get_device(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_log", ExactSpelling = true)]
        public static extern ma_log* engine_get_log(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_endpoint", ExactSpelling = true)]
        [return: NativeTypeName("ma_node *")]
        public static extern void* engine_get_endpoint(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_time_in_pcm_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong engine_get_time_in_pcm_frames([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_time_in_milliseconds", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong engine_get_time_in_milliseconds([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_set_time_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result engine_set_time_in_pcm_frames(ma_engine* pEngine, [NativeTypeName("ma_uint64")] ulong globalTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_set_time_in_milliseconds", ExactSpelling = true)]
        public static extern ma_result engine_set_time_in_milliseconds(ma_engine* pEngine, [NativeTypeName("ma_uint64")] ulong globalTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_time", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong engine_get_time([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_set_time", ExactSpelling = true)]
        public static extern ma_result engine_set_time(ma_engine* pEngine, [NativeTypeName("ma_uint64")] ulong globalTime);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_channels", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint engine_get_channels([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_sample_rate", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint engine_get_sample_rate([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_start", ExactSpelling = true)]
        public static extern ma_result engine_start(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_stop", ExactSpelling = true)]
        public static extern ma_result engine_stop(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_set_volume", ExactSpelling = true)]
        public static extern ma_result engine_set_volume(ma_engine* pEngine, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_volume", ExactSpelling = true)]
        public static extern float engine_get_volume(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_set_gain_db", ExactSpelling = true)]
        public static extern ma_result engine_set_gain_db(ma_engine* pEngine, float gainDB);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_gain_db", ExactSpelling = true)]
        public static extern float engine_get_gain_db(ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_get_listener_count", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint engine_get_listener_count([NativeTypeName("const ma_engine *")] ma_engine* pEngine);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_find_closest_listener", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint engine_find_closest_listener([NativeTypeName("const ma_engine *")] ma_engine* pEngine, float absolutePosX, float absolutePosY, float absolutePosZ);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_set_position", ExactSpelling = true)]
        public static extern void engine_listener_set_position(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_get_position", ExactSpelling = true)]
        public static extern ma_vec3f engine_listener_get_position([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_set_direction", ExactSpelling = true)]
        public static extern void engine_listener_set_direction(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_get_direction", ExactSpelling = true)]
        public static extern ma_vec3f engine_listener_get_direction([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_set_velocity", ExactSpelling = true)]
        public static extern void engine_listener_set_velocity(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_get_velocity", ExactSpelling = true)]
        public static extern ma_vec3f engine_listener_get_velocity([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_set_cone", ExactSpelling = true)]
        public static extern void engine_listener_set_cone(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_get_cone", ExactSpelling = true)]
        public static extern void engine_listener_get_cone([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_set_world_up", ExactSpelling = true)]
        public static extern void engine_listener_set_world_up(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_get_world_up", ExactSpelling = true)]
        public static extern ma_vec3f engine_listener_get_world_up([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_set_enabled", ExactSpelling = true)]
        public static extern void engine_listener_set_enabled(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex, [NativeTypeName("ma_bool32")] uint isEnabled);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_listener_is_enabled", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint engine_listener_is_enabled([NativeTypeName("const ma_engine *")] ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_play_sound_ex", ExactSpelling = true)]
        public static extern ma_result engine_play_sound_ex(ma_engine* pEngine, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_node *")] void* pNode, [NativeTypeName("ma_uint32")] uint nodeInputBusIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_engine_play_sound", ExactSpelling = true)]
        public static extern ma_result engine_play_sound(ma_engine* pEngine, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_init_from_file", ExactSpelling = true)]
        public static extern ma_result sound_init_from_file(ma_engine* pEngine, [NativeTypeName("const char *")] sbyte* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_fence* pDoneFence, ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_init_from_file_w", ExactSpelling = true)]
        public static extern ma_result sound_init_from_file_w(ma_engine* pEngine, [NativeTypeName("const wchar_t *")] ushort* pFilePath, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_fence* pDoneFence, ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_init_copy", ExactSpelling = true)]
        public static extern ma_result sound_init_copy(ma_engine* pEngine, [NativeTypeName("const ma_sound *")] ma_sound* pExistingSound, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_init_from_data_source", ExactSpelling = true)]
        public static extern ma_result sound_init_from_data_source(ma_engine* pEngine, [NativeTypeName("ma_data_source *")] void* pDataSource, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_init_ex", ExactSpelling = true)]
        public static extern ma_result sound_init_ex(ma_engine* pEngine, [NativeTypeName("const ma_sound_config *")] ma_sound_config* pConfig, ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_uninit", ExactSpelling = true)]
        public static extern void sound_uninit(ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_engine", ExactSpelling = true)]
        public static extern ma_engine* sound_get_engine([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_data_source", ExactSpelling = true)]
        [return: NativeTypeName("ma_data_source *")]
        public static extern void* sound_get_data_source([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_start", ExactSpelling = true)]
        public static extern ma_result sound_start(ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_stop", ExactSpelling = true)]
        public static extern ma_result sound_stop(ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_stop_with_fade_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result sound_stop_with_fade_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_stop_with_fade_in_milliseconds", ExactSpelling = true)]
        public static extern ma_result sound_stop_with_fade_in_milliseconds(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_volume", ExactSpelling = true)]
        public static extern void sound_set_volume(ma_sound* pSound, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_volume", ExactSpelling = true)]
        public static extern float sound_get_volume([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_pan", ExactSpelling = true)]
        public static extern void sound_set_pan(ma_sound* pSound, float pan);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_pan", ExactSpelling = true)]
        public static extern float sound_get_pan([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_pan_mode", ExactSpelling = true)]
        public static extern void sound_set_pan_mode(ma_sound* pSound, ma_pan_mode panMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_pan_mode", ExactSpelling = true)]
        public static extern ma_pan_mode sound_get_pan_mode([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_pitch", ExactSpelling = true)]
        public static extern void sound_set_pitch(ma_sound* pSound, float pitch);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_pitch", ExactSpelling = true)]
        public static extern float sound_get_pitch([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_spatialization_enabled", ExactSpelling = true)]
        public static extern void sound_set_spatialization_enabled(ma_sound* pSound, [NativeTypeName("ma_bool32")] uint enabled);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_is_spatialization_enabled", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint sound_is_spatialization_enabled([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_pinned_listener_index", ExactSpelling = true)]
        public static extern void sound_set_pinned_listener_index(ma_sound* pSound, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_pinned_listener_index", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint sound_get_pinned_listener_index([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_listener_index", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint sound_get_listener_index([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_direction_to_listener", ExactSpelling = true)]
        public static extern ma_vec3f sound_get_direction_to_listener([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_position", ExactSpelling = true)]
        public static extern void sound_set_position(ma_sound* pSound, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_position", ExactSpelling = true)]
        public static extern ma_vec3f sound_get_position([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_direction", ExactSpelling = true)]
        public static extern void sound_set_direction(ma_sound* pSound, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_direction", ExactSpelling = true)]
        public static extern ma_vec3f sound_get_direction([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_velocity", ExactSpelling = true)]
        public static extern void sound_set_velocity(ma_sound* pSound, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_velocity", ExactSpelling = true)]
        public static extern ma_vec3f sound_get_velocity([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_attenuation_model", ExactSpelling = true)]
        public static extern void sound_set_attenuation_model(ma_sound* pSound, ma_attenuation_model attenuationModel);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_attenuation_model", ExactSpelling = true)]
        public static extern ma_attenuation_model sound_get_attenuation_model([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_positioning", ExactSpelling = true)]
        public static extern void sound_set_positioning(ma_sound* pSound, ma_positioning positioning);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_positioning", ExactSpelling = true)]
        public static extern ma_positioning sound_get_positioning([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_rolloff", ExactSpelling = true)]
        public static extern void sound_set_rolloff(ma_sound* pSound, float rolloff);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_rolloff", ExactSpelling = true)]
        public static extern float sound_get_rolloff([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_min_gain", ExactSpelling = true)]
        public static extern void sound_set_min_gain(ma_sound* pSound, float minGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_min_gain", ExactSpelling = true)]
        public static extern float sound_get_min_gain([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_max_gain", ExactSpelling = true)]
        public static extern void sound_set_max_gain(ma_sound* pSound, float maxGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_max_gain", ExactSpelling = true)]
        public static extern float sound_get_max_gain([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_min_distance", ExactSpelling = true)]
        public static extern void sound_set_min_distance(ma_sound* pSound, float minDistance);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_min_distance", ExactSpelling = true)]
        public static extern float sound_get_min_distance([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_max_distance", ExactSpelling = true)]
        public static extern void sound_set_max_distance(ma_sound* pSound, float maxDistance);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_max_distance", ExactSpelling = true)]
        public static extern float sound_get_max_distance([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_cone", ExactSpelling = true)]
        public static extern void sound_set_cone(ma_sound* pSound, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_cone", ExactSpelling = true)]
        public static extern void sound_get_cone([NativeTypeName("const ma_sound *")] ma_sound* pSound, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_doppler_factor", ExactSpelling = true)]
        public static extern void sound_set_doppler_factor(ma_sound* pSound, float dopplerFactor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_doppler_factor", ExactSpelling = true)]
        public static extern float sound_get_doppler_factor([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_directional_attenuation_factor", ExactSpelling = true)]
        public static extern void sound_set_directional_attenuation_factor(ma_sound* pSound, float directionalAttenuationFactor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_directional_attenuation_factor", ExactSpelling = true)]
        public static extern float sound_get_directional_attenuation_factor([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_fade_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_set_fade_in_pcm_frames(ma_sound* pSound, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_fade_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_set_fade_in_milliseconds(ma_sound* pSound, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_fade_start_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_set_fade_start_in_pcm_frames(ma_sound* pSound, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_fade_start_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_set_fade_start_in_milliseconds(ma_sound* pSound, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInMilliseconds, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_current_fade_volume", ExactSpelling = true)]
        public static extern float sound_get_current_fade_volume([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_start_time_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_set_start_time_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_start_time_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_set_start_time_in_milliseconds(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_stop_time_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_set_stop_time_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_stop_time_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_set_stop_time_in_milliseconds(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_stop_time_with_fade_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_set_stop_time_with_fade_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong stopAbsoluteGlobalTimeInFrames, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_stop_time_with_fade_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_set_stop_time_with_fade_in_milliseconds(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong stopAbsoluteGlobalTimeInMilliseconds, [NativeTypeName("ma_uint64")] ulong fadeLengthInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_is_playing", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint sound_is_playing([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_time_in_pcm_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong sound_get_time_in_pcm_frames([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_time_in_milliseconds", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong sound_get_time_in_milliseconds([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_looping", ExactSpelling = true)]
        public static extern void sound_set_looping(ma_sound* pSound, [NativeTypeName("ma_bool32")] uint isLooping);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_is_looping", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint sound_is_looping([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_at_end", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint sound_at_end([NativeTypeName("const ma_sound *")] ma_sound* pSound);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_seek_to_pcm_frame", ExactSpelling = true)]
        public static extern ma_result sound_seek_to_pcm_frame(ma_sound* pSound, [NativeTypeName("ma_uint64")] ulong frameIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_seek_to_second", ExactSpelling = true)]
        public static extern ma_result sound_seek_to_second(ma_sound* pSound, float seekPointInSeconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_data_format", ExactSpelling = true)]
        public static extern ma_result sound_get_data_format(ma_sound* pSound, ma_format* pFormat, [NativeTypeName("ma_uint32 *")] uint* pChannels, [NativeTypeName("ma_uint32 *")] uint* pSampleRate, [NativeTypeName("ma_channel *")] byte* pChannelMap, [NativeTypeName("size_t")] nuint channelMapCap);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_cursor_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result sound_get_cursor_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64 *")] ulong* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_length_in_pcm_frames", ExactSpelling = true)]
        public static extern ma_result sound_get_length_in_pcm_frames(ma_sound* pSound, [NativeTypeName("ma_uint64 *")] ulong* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_cursor_in_seconds", ExactSpelling = true)]
        public static extern ma_result sound_get_cursor_in_seconds(ma_sound* pSound, float* pCursor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_get_length_in_seconds", ExactSpelling = true)]
        public static extern ma_result sound_get_length_in_seconds(ma_sound* pSound, float* pLength);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_set_end_callback", ExactSpelling = true)]
        public static extern ma_result sound_set_end_callback(ma_sound* pSound, [NativeTypeName("ma_sound_end_proc")] delegate* unmanaged[Cdecl]<void*, ma_sound*, void> callback, void* pUserData);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_init", ExactSpelling = true)]
        public static extern ma_result sound_group_init(ma_engine* pEngine, [NativeTypeName("ma_uint32")] uint flags, [NativeTypeName("ma_sound_group *")] ma_sound* pParentGroup, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_init_ex", ExactSpelling = true)]
        public static extern ma_result sound_group_init_ex(ma_engine* pEngine, [NativeTypeName("const ma_sound_group_config *")] ma_sound_config* pConfig, [NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_uninit", ExactSpelling = true)]
        public static extern void sound_group_uninit([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_engine", ExactSpelling = true)]
        public static extern ma_engine* sound_group_get_engine([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_start", ExactSpelling = true)]
        public static extern ma_result sound_group_start([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_stop", ExactSpelling = true)]
        public static extern ma_result sound_group_stop([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_volume", ExactSpelling = true)]
        public static extern void sound_group_set_volume([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float volume);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_volume", ExactSpelling = true)]
        public static extern float sound_group_get_volume([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_pan", ExactSpelling = true)]
        public static extern void sound_group_set_pan([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float pan);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_pan", ExactSpelling = true)]
        public static extern float sound_group_get_pan([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_pan_mode", ExactSpelling = true)]
        public static extern void sound_group_set_pan_mode([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_pan_mode panMode);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_pan_mode", ExactSpelling = true)]
        public static extern ma_pan_mode sound_group_get_pan_mode([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_pitch", ExactSpelling = true)]
        public static extern void sound_group_set_pitch([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float pitch);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_pitch", ExactSpelling = true)]
        public static extern float sound_group_get_pitch([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_spatialization_enabled", ExactSpelling = true)]
        public static extern void sound_group_set_spatialization_enabled([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_bool32")] uint enabled);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_is_spatialization_enabled", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint sound_group_is_spatialization_enabled([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_pinned_listener_index", ExactSpelling = true)]
        public static extern void sound_group_set_pinned_listener_index([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint32")] uint listenerIndex);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_pinned_listener_index", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint sound_group_get_pinned_listener_index([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_listener_index", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint32")]
        public static extern uint sound_group_get_listener_index([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_direction_to_listener", ExactSpelling = true)]
        public static extern ma_vec3f sound_group_get_direction_to_listener([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_position", ExactSpelling = true)]
        public static extern void sound_group_set_position([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_position", ExactSpelling = true)]
        public static extern ma_vec3f sound_group_get_position([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_direction", ExactSpelling = true)]
        public static extern void sound_group_set_direction([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_direction", ExactSpelling = true)]
        public static extern ma_vec3f sound_group_get_direction([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_velocity", ExactSpelling = true)]
        public static extern void sound_group_set_velocity([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float x, float y, float z);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_velocity", ExactSpelling = true)]
        public static extern ma_vec3f sound_group_get_velocity([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_attenuation_model", ExactSpelling = true)]
        public static extern void sound_group_set_attenuation_model([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_attenuation_model attenuationModel);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_attenuation_model", ExactSpelling = true)]
        public static extern ma_attenuation_model sound_group_get_attenuation_model([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_positioning", ExactSpelling = true)]
        public static extern void sound_group_set_positioning([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, ma_positioning positioning);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_positioning", ExactSpelling = true)]
        public static extern ma_positioning sound_group_get_positioning([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_rolloff", ExactSpelling = true)]
        public static extern void sound_group_set_rolloff([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float rolloff);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_rolloff", ExactSpelling = true)]
        public static extern float sound_group_get_rolloff([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_min_gain", ExactSpelling = true)]
        public static extern void sound_group_set_min_gain([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float minGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_min_gain", ExactSpelling = true)]
        public static extern float sound_group_get_min_gain([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_max_gain", ExactSpelling = true)]
        public static extern void sound_group_set_max_gain([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float maxGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_max_gain", ExactSpelling = true)]
        public static extern float sound_group_get_max_gain([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_min_distance", ExactSpelling = true)]
        public static extern void sound_group_set_min_distance([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float minDistance);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_min_distance", ExactSpelling = true)]
        public static extern float sound_group_get_min_distance([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_max_distance", ExactSpelling = true)]
        public static extern void sound_group_set_max_distance([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float maxDistance);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_max_distance", ExactSpelling = true)]
        public static extern float sound_group_get_max_distance([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_cone", ExactSpelling = true)]
        public static extern void sound_group_set_cone([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float innerAngleInRadians, float outerAngleInRadians, float outerGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_cone", ExactSpelling = true)]
        public static extern void sound_group_get_cone([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup, float* pInnerAngleInRadians, float* pOuterAngleInRadians, float* pOuterGain);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_doppler_factor", ExactSpelling = true)]
        public static extern void sound_group_set_doppler_factor([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float dopplerFactor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_doppler_factor", ExactSpelling = true)]
        public static extern float sound_group_get_doppler_factor([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_directional_attenuation_factor", ExactSpelling = true)]
        public static extern void sound_group_set_directional_attenuation_factor([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float directionalAttenuationFactor);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_directional_attenuation_factor", ExactSpelling = true)]
        public static extern float sound_group_get_directional_attenuation_factor([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_fade_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_group_set_fade_in_pcm_frames([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_fade_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_group_set_fade_in_milliseconds([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, float volumeBeg, float volumeEnd, [NativeTypeName("ma_uint64")] ulong fadeLengthInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_current_fade_volume", ExactSpelling = true)]
        public static extern float sound_group_get_current_fade_volume([NativeTypeName("ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_start_time_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_group_set_start_time_in_pcm_frames([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_start_time_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_group_set_start_time_in_milliseconds([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_stop_time_in_pcm_frames", ExactSpelling = true)]
        public static extern void sound_group_set_stop_time_in_pcm_frames([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInFrames);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_set_stop_time_in_milliseconds", ExactSpelling = true)]
        public static extern void sound_group_set_stop_time_in_milliseconds([NativeTypeName("ma_sound_group *")] ma_sound* pGroup, [NativeTypeName("ma_uint64")] ulong absoluteGlobalTimeInMilliseconds);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_is_playing", ExactSpelling = true)]
        [return: NativeTypeName("ma_bool32")]
        public static extern uint sound_group_is_playing([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);

        [DllImport("miniaudio", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ma_sound_group_get_time_in_pcm_frames", ExactSpelling = true)]
        [return: NativeTypeName("ma_uint64")]
        public static extern ulong sound_group_get_time_in_pcm_frames([NativeTypeName("const ma_sound_group *")] ma_sound* pGroup);
    }
}
