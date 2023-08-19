@echo off

REM Set the URL for the Chrome WebDriver download
set "chromeDriverUrl=https://chromedriver.storage.googleapis.com/114.0.5735.90/chromedriver_win32.zip"

REM Set the target directory where you want to save the WebDriver
set "driverDirectory=C:\Driver"
set "targetDirectory=%CD%"

REM Create the driver directory if it doesn't exist
if not exist "%driverDirectory%" mkdir "%driverDirectory%"

REM Construct the full path for the downloaded zip file
set "zipFilePath=%driverDirectory%\chromedriver.zip"

REM Remove the existing chromedriver.exe if it exists
set "existingFilePath=%driverDirectory%\chromedriver.exe"
if exist "%existingFilePath%" (
    del "%existingFilePath%"
)

REM Download the Chrome WebDriver zip file
curl -o "%zipFilePath%" "%chromeDriverUrl%"

REM Wait until the download is completed
:wait_loop
if not exist "%zipFilePath%" (
    timeout /t 1 >nul
    goto wait_loop
)

REM Extract the contents of the zip file to the target directory
powershell -Command "Expand-Archive -Path \"%zipFilePath%\" -DestinationPath \"%driverDirectory%\" -Force"

REM Clean up: Remove the downloaded zip file
del "%zipFilePath%"
del "%driverDirectory%\LICENSE.chromedriver"
