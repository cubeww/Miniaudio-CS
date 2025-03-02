# Miniaudio-CS

Auto-generated C# bindings for [miniaudio](https://github.com/mackron/miniaudio)

## Example

```c#
// It is recommended to allocate native memory for miniaudio structures.
ma_engine* engine = (ma_engine*)NativeMemory.Alloc((nuint)sizeof(ma_engine));
ma.engine_init(null, engine);

// When calling a function that accepts a string of type "sbyte*",
// convert the string to ANSI encoding first.
string filePath1 = "music.mp3";
ma_sound* sound1 = (ma_sound*)NativeMemory.Alloc((nuint)sizeof(ma_sound));
nint filePath1_Ansi = Marshal.StringToHGlobalAnsi(filePath1);
ma.sound_init_from_file(engine, (sbyte*)filePath1_Ansi, 0, null, null, sound1);
Marshal.FreeHGlobal(filePath1_Ansi);
ma.sound_start(sound1);

// Note that ANSI encoding does not support certain characters.
// It is more recommended to use the following methods.

Console.ReadKey();
ma.sound_stop(sound1);

string filePath2 = "😄.wav";
ma_sound* sound2 = (ma_sound*)NativeMemory.Alloc((nuint)sizeof(ma_sound));
fixed (void* p = filePath2) // or Marshal.StringToHGlobalUni(filePath2);
{
    ma.sound_init_from_file_w(engine, (ushort*)p, (uint)ma_sound_flags.MA_SOUND_FLAG_LOOPING, null, null, sound2);
}
ma.sound_start(sound2);

Console.ReadKey();
ma.sound_stop(sound2);

// Clean up
ma.engine_uninit(engine);
NativeMemory.Free(engine);
NativeMemory.Free(sound1);
NativeMemory.Free(sound2);
```



## Generate Bindings (Miniaudio.cs)

```shell
dotnet tool install --global ClangSharpPInvokeGenerator
git clone https://github.com/cubeww/Miniaudio-CS --recursive
cd Miniaudio-CS/GenerateBindings
ClangSharpPInvokeGenerator @generate.gen
```

## Compile Native Library

First

```shell
git clone https://github.com/cubeww/Miniaudio-CS --recursive
cd Miniaudio-CS/GenerateBindings
```

Windows x86

```shell
mkdir "../native/win-x86"
"C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvars32.bat"
cl /LD miniaudio-native.c /Fe:../native/win-x86/miniaudio.dll /O1
```

Windows x64

```shell
mkdir "../native/win-x64"
"C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvars64.bat"
cl /LD miniaudio-native.c /Fe:../native/win-x64/miniaudio.dll /O1
```

Linux x86

```shell
mkdir ../native/linux-x86
sudo apt install gcc-multilib
gcc -shared -o ../native/linux-x86/libminiaudio.so -fPIC miniaudio-native.c -m32 -Os
```

Linux x64

```shell
mkdir ../native/linux-x64
gcc -shared -o ../native/linux-x64/libminiaudio.so -fPIC miniaudio-native.c -m64 -Os
```

