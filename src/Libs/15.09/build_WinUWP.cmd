CD ..\..\..\alljoyn\
c:\Python27\python.exe c:\Python27\Scripts\scons.py OS=win10 BINDINGS=c MSVC_VERSION=14.0 BUILD_SERVICES_SAMPLES=off VARIANT=debug CPU=x86
xcopy build\win10\x86\debug\dist\c\lib\alljoyn_c.dll ..\src\Libs\15.09\WinUWP\x86-debug\ /Y /S

c:\Python27\python.exe c:\Python27\Scripts\scons.py OS=win10 BINDINGS=c MSVC_VERSION=14.0 BUILD_SERVICES_SAMPLES=off VARIANT=debug CPU=x86_64
xcopy build\win10\x86_64\debug\dist\c\lib\alljoyn_c.dll ..\src\Libs\15.09\WinUWP\x64-debug\ /Y /S

c:\Python27\python.exe c:\Python27\Scripts\scons.py OS=win10 BINDINGS=c MSVC_VERSION=14.0 BUILD_SERVICES_SAMPLES=off VARIANT=debug CPU=arm
xcopy build\win10\arm\debug\dist\c\lib\alljoyn_c.dll ..\src\Libs\15.09\WinUWP\arm-debug\ /Y /S

c:\Python27\python.exe c:\Python27\Scripts\scons.py OS=win10 BINDINGS=c MSVC_VERSION=14.0 BUILD_SERVICES_SAMPLES=off VARIANT=release CPU=x86
xcopy build\win10\x86\release\dist\c\lib\alljoyn_c.dll ..\src\Libs\15.09\WinUWP\x86\ /Y /S

c:\Python27\python.exe c:\Python27\Scripts\scons.py OS=win10 BINDINGS=c MSVC_VERSION=14.0 BUILD_SERVICES_SAMPLES=off VARIANT=release CPU=x86_64
xcopy build\win10\x86_64\release\dist\c\lib\alljoyn_c.dll ..\src\Libs\15.09\WinUWP\x64\ /Y /S

c:\Python27\python.exe c:\Python27\Scripts\scons.py OS=win10 BINDINGS=c MSVC_VERSION=14.0 BUILD_SERVICES_SAMPLES=off VARIANT=release CPU=arm
xcopy build\win10\arm\release\dist\c\lib\alljoyn_c.dll ..\src\Libs\15.09\WinUWP\arm\ /Y /S
PAUSE