@echo off
ECHO -----------Generation de l'application-----------
CD ServeurApp
call GenerateServeurJar.bat
CD ..\ClientApp
cd
pause