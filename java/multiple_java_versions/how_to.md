# Simple change java version on Windows

## Short info
1. In location `C:\Program Files\Java\scripts` unpack scripts.zip
The ZIP file includes scripts with names such as java21.bat, java20.bat, java19.bat, and so on, covering all Java versions. 
Additionally, it contains corresponding files like java21.ps1, java20.ps1, and so forth, tailored for use with PowerShell. 
Furthermore, you'll find two universal scripts named javaX.bat and javaX.ps1.
2. In `javaX.bat` / `javaX.ps1` fix path to java versions on your pc.
3. In Environment variables PATH add path to `C:\Program Files\Java\scripts`
4. Add another variable in path `%JAVA_HOME%\bin`
5. In cmd / ps use command e.g. java11 or java20

## Full article
```url
https://www.happycoders.eu/java/how-to-switch-multiple-java-versions-windows
```