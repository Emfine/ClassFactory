@echo off
del /F /S /Q bin\Release\*.xml
del /F /S /Q bin\Release\*.pdb
rd /S /Q bin\Release\de
rd /S /Q bin\Release\es
rd /S /Q bin\Release\ja
rd /S /Q bin\Release\ru

del /F /S /Q Publish\*.*
pause

xcopy bin\Release\*.* Publish\ /I/S/Y
pause