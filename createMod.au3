#Region ;**** Directives created by AutoIt3Wrapper_GUI ****
#AutoIt3Wrapper_icon=appicon.ico
#AutoIt3Wrapper_outfile=createMod.exe
#AutoIt3Wrapper_Change2CUI=y
#AutoIt3Wrapper_Add_Constants=n
#EndRegion ;**** Directives created by AutoIt3Wrapper_GUI ****
; modCreator.exe
; this program takes parameters then runs the bat file..

	if ( FileExists("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\createMod.bat") ) Then
		RunWait(@ComSpec & " /c " & '"' & "C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\createMod.bat" & '"')

		;FileDelete("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\createMod.bat")
	Else
		Exit
	EndIf


Exit
