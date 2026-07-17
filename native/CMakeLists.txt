cmake_minimum_required(VERSION 3.20)

project(miniaudio_cs VERSION 0.1.0 LANGUAGES C)

option(MINIAUDIO_CS_BUILD_SHARED "Build a shared library" ON)
option(MINIAUDIO_CS_WARNINGS_AS_ERRORS "Treat native compiler warnings as errors" OFF)
option(MINIAUDIO_CS_NO_PTHREAD_IN_HEADER "Use miniaudio's fixed-size POSIX threading types" OFF)
set(MINIAUDIO_SOURCE_DIR "${CMAKE_CURRENT_SOURCE_DIR}/../external/miniaudio" CACHE PATH "Path to the miniaudio submodule")

if(NOT EXISTS "${MINIAUDIO_SOURCE_DIR}/miniaudio.c")
    message(FATAL_ERROR "miniaudio submodule is missing. Run: git submodule update --init --recursive")
endif()

if(APPLE AND CMAKE_SYSTEM_NAME MATCHES "^(iOS|tvOS|watchOS)$")
    enable_language(OBJC)
    set_source_files_properties("${MINIAUDIO_SOURCE_DIR}/miniaudio.c" PROPERTIES LANGUAGE OBJC)
endif()

if(MINIAUDIO_CS_BUILD_SHARED)
    set(MINIAUDIO_CS_LIBRARY_TYPE SHARED)
else()
    set(MINIAUDIO_CS_LIBRARY_TYPE STATIC)
endif()

add_library(miniaudio ${MINIAUDIO_CS_LIBRARY_TYPE}
    "${MINIAUDIO_SOURCE_DIR}/miniaudio.c"
    "${MINIAUDIO_SOURCE_DIR}/miniaudio.h"
)

if(MINIAUDIO_CS_NO_PTHREAD_IN_HEADER)
    target_compile_definitions(miniaudio PRIVATE MA_NO_PTHREAD_IN_HEADER)
endif()

if(APPLE AND CMAKE_SYSTEM_NAME MATCHES "^(iOS|tvOS|watchOS)$")
    target_compile_definitions(miniaudio PRIVATE MA_NO_RUNTIME_LINKING)
endif()

target_compile_features(miniaudio PRIVATE c_std_99)
target_include_directories(miniaudio
    PUBLIC
        "$<BUILD_INTERFACE:${MINIAUDIO_SOURCE_DIR}>"
        "$<INSTALL_INTERFACE:include>"
)

if(MINIAUDIO_CS_BUILD_SHARED)
    # Makes every upstream MA_API declaration part of the shared library ABI.
    target_compile_definitions(miniaudio PRIVATE MA_DLL)
endif()

set_target_properties(miniaudio PROPERTIES
    C_VISIBILITY_PRESET hidden
    VISIBILITY_INLINES_HIDDEN YES
    POSITION_INDEPENDENT_CODE YES
    OUTPUT_NAME miniaudio
)

if(MSVC)
    target_compile_options(miniaudio PRIVATE /W4 /wd4100 /wd4127 /wd4242 /wd4244 /wd4267 /wd4706)
    if(MINIAUDIO_CS_WARNINGS_AS_ERRORS)
        target_compile_options(miniaudio PRIVATE /WX)
    endif()
else()
    target_compile_options(miniaudio PRIVATE -Wall -Wextra -Wpedantic)
    if(MINIAUDIO_CS_WARNINGS_AS_ERRORS)
        target_compile_options(miniaudio PRIVATE -Werror)
    endif()
endif()

if(UNIX)
    find_library(MINIAUDIO_DL_LIBRARY NAMES dl)
    find_library(MINIAUDIO_M_LIBRARY NAMES m)
    find_library(MINIAUDIO_PTHREAD_LIBRARY NAMES pthread)
    if(CMAKE_SYSTEM_PROCESSOR MATCHES "^arm" AND NOT CMAKE_SYSTEM_PROCESSOR MATCHES "aarch64|arm64")
        find_library(MINIAUDIO_ATOMIC_LIBRARY NAMES atomic)
    endif()

    if(MINIAUDIO_DL_LIBRARY)
        target_link_libraries(miniaudio PRIVATE "${MINIAUDIO_DL_LIBRARY}")
    endif()
    if(MINIAUDIO_M_LIBRARY)
        target_link_libraries(miniaudio PRIVATE "${MINIAUDIO_M_LIBRARY}")
    endif()
    if(MINIAUDIO_PTHREAD_LIBRARY)
        target_link_libraries(miniaudio PRIVATE "${MINIAUDIO_PTHREAD_LIBRARY}")
    endif()
    if(MINIAUDIO_ATOMIC_LIBRARY)
        target_link_libraries(miniaudio PRIVATE "${MINIAUDIO_ATOMIC_LIBRARY}")
    endif()
endif()

if(ANDROID)
    target_link_libraries(miniaudio PRIVATE log android)
endif()

include(GNUInstallDirs)
install(TARGETS miniaudio
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
    ARCHIVE DESTINATION ${CMAKE_INSTALL_LIBDIR}
)
install(FILES "${MINIAUDIO_SOURCE_DIR}/miniaudio.h" DESTINATION ${CMAKE_INSTALL_INCLUDEDIR}/miniaudio)
