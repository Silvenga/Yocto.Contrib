# Yocto.Contrib

Provides .Net Standard packaging for Yoctopuce libraries. This includes the native library and the provided source code to access it (e.g. `YSensor`, `YLightSensor`, etc.). 

[![Build status](https://img.shields.io/nuget/v/Yocto.Contrib.svg?maxAge=2592000&style=flat-square)](https://ci.appveyor.com/project/Silvenga/yocto-contrib)
[![Build status](https://img.shields.io/appveyor/ci/Silvenga/yocto-contrib.svg?maxAge=2592000&style=flat-square)](https://ci.appveyor.com/project/Silvenga/yocto-contrib)
[![License](https://img.shields.io/github/license/Silvenga/Yocto.Contrib.svg?style=flat-square)](https://github.com/Silvenga/Yocto.Contrib/blob/master/LICENSE)

## Supported Native Environments

Yoctopuce's modules depend on the `yapi` native library for direct USB functionalities. This package includes that library for the following runtime platforms:

- win-x64 (`yapi.dll`)
- win-x86 (`yapi.dll`)
- osx (`yapi.dylib`)
- linux-x64 (`yapi.so`)
- linux-x86 (`yapi.so`)

> Note that the non-windows platform library is copied from the python library.