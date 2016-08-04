rem @echo off


set CONFIG=%2
set INSTALLDIR=.\Applications\ACATApp\bin\%CONFIG%

cd %1

rem ------------------------------------------------
@echo Deploying Core Resources dlls
rem ------------------------------------------------

set SOURCEDIR=.\Libraries\ACATCore\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%


rem ------------------------------------------------
@echo Deploying Extensions Resources dlls
rem ------------------------------------------------

set SOURCEDIR=.\Libraries\ACATExtension\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%



rem ------------------------------------------------
@echo Deploying Assets
rem ------------------------------------------------
set SOURCEDIR=Assets
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
xcopy /s /y /e /i %SOURCEDIR%\*.* %TARGETDIR% 

rem ------------------------------------------------
@echo Deploying UI dlls
rem ------------------------------------------------

set SOURCEDIR=Extensions\Default\UI\Dialogs
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\Dialogs.dll %TARGETDIR%
copy .\%SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=Extensions\Default\UI\Dialogs\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\Extensions\Default\UI\Dialogs\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%


set SOURCEDIR=Extensions\Default\UI\Menus
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\Menus.dll %TARGETDIR%
copy .\%SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=Extensions\Default\UI\Menus\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\Extensions\Default\UI\Menus\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set SOURCEDIR=Extensions\Default\UI\Scanners
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\*.dll %TARGETDIR%
copy .\%SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=Extensions\Default\UI\Scanners\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\Extensions\Default\UI\Scanners\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

rem ------------------------------------------------
@echo Deploying Actuator dlls
rem ------------------------------------------------

set SOURCEDIR=Extensions\Default\Actuators\CameraActuator
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\CameraActuator.dll %TARGETDIR%

rem ------------------------------------------------
@echo Deploying TTSEngine dlls
rem ------------------------------------------------

set SOURCEDIR=Extensions\Default\TTSEngines\SAPIEngine
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\SAPIEngine.dll %TARGETDIR%

rem ------------------------------------------------
@echo Deploying SpellChecker dlls
rem ------------------------------------------------

set SOURCEDIR=Extensions\Default\SpellCheckers\SpellCheck
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\SpellCheck.dll %TARGETDIR%
set SOURCEDIR=Extensions\Default\SpellCheckers\SpellCheck\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\Extensions\Default\SpellCheckers\SpellCheck\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

rem ------------------------------------------------
@echo Deploying AppAgents dlls
rem ------------------------------------------------

set AGENT=AcrobatReaderAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=ACATAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=DialogControlAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=FoxitReaderAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=MenuControlAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=DLLHostAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=FireFoxAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=ChromeBrowserAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=UnsupportedAppAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=InternetExplorerAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=MSWordAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=NotepadAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=WordpadAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=OutlookAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=TalkWindowAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=MediaPlayerAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%

set AGENT=WindowsExplorerAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\AppAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\AppAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
echo copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%


rem ------------------------------------------------
@echo Deploying Functional Agent dlls
rem ------------------------------------------------

set AGENT=FileBrowserAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=NewFileAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=AbbreviationsAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=PhraseSpeakAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=VolumeSettingsAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=SwitchWindowsAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=LaunchAppAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

set AGENT=LectureManagerAgent
set EXTENSIONSBASE=Extensions\Default
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%
if not exist %TARGETDIR% mkdir %TARGETDIR%
@echo Copying .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll to %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\%AGENT%.dll %TARGETDIR%\%AGENT%.dll
if exist %SOURCEDIR%\Config\*.xml copy %SOURCEDIR%\Config\*.xml %TARGETDIR%
set SOURCEDIR=%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\bin\%CONFIG%\pt-BR
set TARGETDIR=%INSTALLDIR%\%EXTENSIONSBASE%\FunctionalAgents\%AGENT%\pt-BR
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

rem ------------------------------------------------
@echo Deploying ACAT WordPredictor dlls
rem ------------------------------------------------

set SOURCEDIR=Extensions\Default\WordPredictors\Presage
set TARGETDIR=%INSTALLDIR%\%SOURCEDIR%
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\bin\%CONFIG%\PresageWordPredictor.dll %TARGETDIR%
set SOURCEDIR=Extensions\Default\WordPredictors\Presage\bin\%CONFIG%\pt
set TARGETDIR=%INSTALLDIR%\Extensions\Default\WordPredictors\Presage\pt
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%
set SOURCEDIR=Extensions\Default\WordPredictors\Presage\bin\%CONFIG%\es
set TARGETDIR=%INSTALLDIR%\Extensions\Default\WordPredictors\Presage\es
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%
set SOURCEDIR=Extensions\Default\WordPredictors\Presage\bin\%CONFIG%\it
set TARGETDIR=%INSTALLDIR%\Extensions\Default\WordPredictors\Presage\it
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%
set SOURCEDIR=Extensions\Default\WordPredictors\Presage\bin\%CONFIG%\fr
set TARGETDIR=%INSTALLDIR%\Extensions\Default\WordPredictors\Presage\fr
if not exist %TARGETDIR% mkdir %TARGETDIR%
copy .\%SOURCEDIR%\*.resources.dll %TARGETDIR%

:end
