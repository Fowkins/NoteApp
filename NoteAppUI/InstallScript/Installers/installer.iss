; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "NoteApp"
#define MyAppVersion "1.0"
#define MyAppPublisher "Andrey Chernikov �"
#define MyAppURL "chernikov_1999@mail.ru"
#define MyAppExeName "NoteAppUI.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{9C3500F8-0A3D-4C48-8CAD-F4373C5CF04B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=C:\Users\������\source\repos\Fowkins\NoteApp\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\������\Desktop
OutputBaseFilename=NoteAppSetup
SetupIconFile=C:\Users\������\Desktop\LABI\���\������ V1\notepad.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\������\source\repos\Fowkins\NoteApp\NoteAppUI\InstallScript\Release\NoteAppUI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\������\source\repos\Fowkins\NoteApp\NoteAppUI\InstallScript\Release\NoteApp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\������\source\repos\Fowkins\NoteApp\NoteAppUI\InstallScript\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

