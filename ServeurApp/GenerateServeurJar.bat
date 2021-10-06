@echo off
ECHO [INFO] MIAGE - Generation SCG Serveur
ECHO [INFO] ----------------Generation du Maven----------------
call mvn package
ECHO [INFO] ---------------------------------------------------
ECHO [INFO] -------Creation du dossier de l'application--------
CD target
IF EXIST "ServeurApp\" (
	ECHO [INFO] - %date% %time% : Folder ServeurApp already exists
	ECHO [INFO] - %date% %time% : Suppression de l'ancienne version generee
	rem pause
	rem DEL /s /f /q ServeurApp\*.*
	rem FOR /f %%f IN ('dir /ad /b c:\test\') 
		rem DO RD /s /q ServeurApp\%%f
	rem pause
	CD ..
) ELSE (
	ECHO [INFO] - %date% %time% : Folder ServeurApp does not exist
	ECHO [INFO] - %date% %time% : - Creation of the folder
	MKDIR ServeurApp
	CD ServeurApp
	ECHO [INFO] - %date% %time% : Creation of the sub-folders
	MKDIR lib
	MKDIR data
	CD ../..
)
ECHO [INFO] ---------------------------------------------------------
ECHO [INFO] ---------------Copie des fichiers restants---------------
ECHO [INFO] - %date% %time% : Copying all the other files
ECHO [INFO] - %date% %time% : Copying config file
XCOPY *.config .\target\ServeurApp /I /V /F /Y
ECHO %date% %time% : [INFO] - Copying external libraries
XCOPY lib\*.jar .\target\ServeurApp\lib /I /V /F /Y
ECHO [INFO] ---------------------------------------------------------
PAUSE