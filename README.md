# Miniaudio-CS

Auto-generated C# bindings for [miniaudio](https://github.com/mackron/miniaudio)

## Generate Bindings (Miniaudio.cs)

```shell
dotnet tool install --global ClangSharpPInvokeGenerator
git clone https://github.com/cubeww/Miniaudio-CS --recursive
cd Miniaudio-CS/GenerateBindings
ClangSharpPInvokeGenerator @generate.rsp
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

