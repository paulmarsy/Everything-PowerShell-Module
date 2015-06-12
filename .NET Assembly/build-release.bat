@ECHO off

SET AssemblyFile=Voidtools.Everything.SDK.dll

IF EXIST %AssemblyFile% DEL %AssemblyFile%

CALL "%VS120COMNTOOLS%\VsDevCmd.bat"

csc.exe /optimize+ /highentropyva+ /t:library /platform:anycpu /out:%AssemblyFile% /recurse:src\*.cs /define:DEBUG

PAUSE