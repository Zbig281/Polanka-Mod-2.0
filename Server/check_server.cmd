@echo off

REM Delay until server process is closed...
<nul (set/p _any_variable=Waiting for server to exit.)
:WAITCLOSE
<nul (set/p _any_variable=.)
ping ::1 -n 3 >NUL 2>NUL
tasklist /FI "imagename eq ddctd_cm_yo_serve.exe" /V | find "world ID %1" >NUL && goto :WAITCLOSE
echo done.
ping ::1 -n 5 >NUL 2>NUL

:LOOP
REM If server is started, exit batch file.
tasklist /FI "imagename eq ddctd_cm_yo_serve.exe" /V | find "world ID %1" >NUL && goto :END

REM If not, try to start it.
echo Launching WorldID %1.
start ddctd_cm_yo_serve.exe -WorldID %1
REM Wait 30 seconds before next check to give server time to initialize titlebar with world ID.
echo Waiting 30 seconds to ensure server has started.
PING ::1 -n 30 >NUL 2>NUL

REM Loop to check if server is initialized.
GOTO :LOOP

:END