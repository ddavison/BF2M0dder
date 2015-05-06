; Installer for BF2 Modder.

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{572FD2E5-0CBA-498D-A814-9813E69FD98F}
AppName=BF2 Modder RC 0.9.1
AppVerName=BF2 Modder RC 0.9.1
AppPublisher=sircapsalot.NET
AppPublisherURL=http://www.sircapsalot.net/
AppSupportURL=http://www.battlefieldsingleplayer.com/forum/index.php?showforum=98
AppUpdatesURL=http://www.battlefieldsingleplayer.com/forum/index.php?showforum=98
DefaultDirName={pf}\BF2 Modder
DefaultGroupName=BF2 Modder
OutputDir=C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\distro
OutputBaseFilename=BF2Modder RC 0.9.1_setup
SetupIconFile=C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\newInstallIcon.ico
UninstallIconFile=C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\newInstallIcon.ico
Compression=lzma
SolidCompression=yes
;InfoAfterFile=C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\BF2 M0dd3r.rtf
WizardImageFile=C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\installerimg.bmp
WizardSmallImageFile=C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\smallinstallerimg.bmp

[Registry]
Root: HKLM; Subkey: "Software\sircapsalot.net"; Flags: uninsdeletekeyifempty
Root: HKLM; Subkey: "Software\sircapsalot.net\BF2Modder"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\sircapsalot.net\BF2Modder"; ValueType: string; ValueName: "installPath"; ValueData: "{app}"

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\BF2 M0dd3r\bin\Release\BF2 Modder RC 0.9.1.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\BF2 M0dd3r\welcome.bik"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\BF2 M0dd3r\bin\Release\ICSharpCode.SharpZipLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\runner\runner\runner\bin\Release\BF2 Modder Runner.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\support_site.htm"; DestDir: "{app}";
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\bf2cursor.ani"; DestDir:"{app}";
Source: "C:\Users\DJ\Documents\sharpdev\BF2 M0dd3r\BF2 M0dd3r\bin\Release\Interop.WMPLib.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\BF2 Modder"; Filename: "{app}\BF2 Modder RC 0.9.1.exe"

Name: "{group}\Submit Support Ticket"; Filename: "{app}\support_site.htm";
Name: "{group}\Uninstall BF2 Modder"; Filename: "{uninstallexe}"
Name: "{commondesktop}\BF2 Modder"; Filename: "{app}\BF2 Modder RC 0.9.1.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\BF2 Modder RC 0.9.1.exe"; Description: "{cm:LaunchProgram,BF2 Modder}"; Flags: nowait postinstall skipifsilent
