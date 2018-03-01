@ECHO OFF
pushd "%~dp0"
ECHO.
ECHO.
ECHO.
ECHO This script deletes all temporary build files in the .vs folder and the
ECHO BIN and OBJ folders contained in the following projects
ECHO.
ECHO HistoryControlLib
ECHO BrowseHistoryDemo
ECHO BrowserHistoryDemoLib
ECHO BrowseHistoryThemesDemo
ECHO BrowseHistoryDemo
ECHO.
ECHO Components\ServiceLocator
ECHO Components\Settings\Settings
ECHO Components\Settings\SettingsModel
ECHO.
REM Ask the user if hes really sure to continue beyond this point XXXXXXXX
set /p choice=Are you sure to continue (Y/N)?
if not '%choice%'=='Y' Goto EndOfBatch
REM Script does not continue unless user types 'Y' in upper case letter
ECHO.
ECHO XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
ECHO.
ECHO XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
ECHO.
ECHO Removing vs settings folder with *.sou file
ECHO.
RMDIR /S /Q .vs

ECHO.
ECHO Deleting BIN and OBJ Folders in HistoryControlLib
ECHO.
RMDIR /S /Q "HistoryControlLib\bin"
RMDIR /S /Q "HistoryControlLib\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in BrowseHistoryDemo
ECHO.
RMDIR /S /Q "BrowseHistoryDemo\bin"
RMDIR /S /Q "BrowseHistoryDemo\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in BrowserHistoryDemoLib
ECHO.
RMDIR /S /Q "BrowserHistoryDemoLib\bin"
RMDIR /S /Q "BrowserHistoryDemoLib\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in BrowseHistoryThemesDemo
ECHO.
RMDIR /S /Q "BrowseHistoryThemesDemo\bin"
RMDIR /S /Q "BrowseHistoryThemesDemo\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in BrowseHistoryDemo
ECHO.
RMDIR /S /Q "BrowseHistoryDemo\bin"
RMDIR /S /Q "BrowseHistoryDemo\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in Components\ServiceLocator
ECHO.
RMDIR /S /Q "Components\ServiceLocator\bin"
RMDIR /S /Q "Components\ServiceLocator\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in Components\Settings\Settings
ECHO.
RMDIR /S /Q "Components\Settings\Settings\bin"
RMDIR /S /Q "Components\Settings\Settings\obj"

ECHO.
ECHO Deleting BIN and OBJ Folders in Components\Settings\SettingsModel
ECHO.
RMDIR /S /Q "Components\Settings\SettingsModel\bin"
RMDIR /S /Q "Components\Settings\SettingsModel\obj"

PAUSE

:EndOfBatch
