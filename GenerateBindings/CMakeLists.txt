cmake_minimum_required(VERSION 3.10)
add_compile_definitions(MA_DLL)
add_library(miniaudio SHARED miniaudio/miniaudio.c)