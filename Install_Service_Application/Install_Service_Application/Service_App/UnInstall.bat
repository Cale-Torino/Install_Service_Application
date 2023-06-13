::Run App With Args
@ECHO OFF
cd /D %~dp0
start Windows_Test_Logger_Service.exe -uninstall
pause