#Region ;**** Directives created by AutoIt3Wrapper_GUI ****
#AutoIt3Wrapper_icon=appicon.ico
#AutoIt3Wrapper_outfile=runner.exe
#EndRegion ;**** Directives created by AutoIt3Wrapper_GUI ****

#include <GuiConstantsEx.au3>

_Main()



Global $isUsingDim, $runButton, $dontRunButton, $instructions, $customX, $customY, $isUsingWindowed, $additionalParameters

Func _Main()
	GUICreate("BF2 M0dd3r Runner", 300, 160, ((@DesktopWidth / 2) - 300), ((@DesktopHeight / 2) - 150))



	TraySetState(2)

	$instructions = GUICTrlCreateLabel("Press Run to run Battlefield 2." & @CRLF & @CRLF & "Press Don't Run, to go back to BF2 M0dd3r.", 4, 4, 230)
	$isUsingDim   = GUICtrlCreateCheckbox("Use Custom Resolution", 4, 100, 200, 20)
	$isUsingWindowed=GUICtrlCreateCheckbox("Windowed Mode", 4, 80, 200, 20)
	$customX      = GUICtrlCreateInput("", 4, 120, 50, 20)
	$customY      = GUICtrlCreateInput("", 58, 120, 50, 20)
	$runButton    = GUICtrlCreateButton  ("Run", (300 - 144), (140 - 17), 70, 25)
	$dontRunButton= GUICtrlCreateButton  ("Don't Run", (300 - 74), (140 - 17), 70, 25)
	$maxRes       = GUICtrlCreateButton  ("My Resolution", 5, (160 - 20), 80, 20)
	GUICtrlSetState($customX, $GUI_DISABLE)
	GUICtrlSetState($customY, $GUI_DISABLE)

	if FileExists("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\custom_dimensions.cfg") Then
		; they have custom dimensions stored...
		$custx = IniRead("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\custom_dimensions.cfg", "dimensions", "x", "1024")
		$custy = IniRead("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\custom_dimensions.cfg", "dimensions", "y", "768")

		GUICtrlSetState($isUsingDim, $GUI_CHECKED)

		GUICtrlSetData($customX, $custx)
		GUICtrlSetData($customY, $custy)
		GUICtrlSetState($maxRes, $GUI_DISABLE)
	EndIf

	GUISetState()

while 1

	$mm = GUIGetMsg()

	Select
		case $mm = $isUsingDim

			; 4 is checked...
			; 1 is not checked...
			if GUICtrlRead($isUsingDim) = $GUI_CHECKED then ;it's checked...
				GUICtrlSetState($customX, $GUI_ENABLE)
				GUICtrlSetState($customY, $GUI_ENABLE)
				GUICtrlSetState($maxRes, $GUI_ENABLE)
			Elseif GUICTrlRead($isUsingDim) = $GUI_UNCHECKED Then
				GUICtrlSetState($customX, $GUI_DISABLE)
				GUICtrlSetState($customY, $GUI_DISABLE)
				FileDelete("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\custom_dimensions.cfg")
			EndIf


		case $mm = $isUsingWindowed
			if GUICtrlRead($isUsingWindowed) = $GUI_UNCHECKED Then
				GUICtrlSetState($isUsingDim, $GUI_ENABLE)
				GUICtrlSetData($customX, "")
				GUICtrlSetData($customY, "")
			Else
				GUICtrlSetState($isUsingDim, $GUI_UNCHECKED)
				GUICtrlSetState($isUsingDim, $GUI_DISABLE)
				GUICtrlSetState($customX, $GUI_DISABLE)
				GUICtrlSetState($customY, $GUI_DISABLE)
				GUICtrlSetData($customX, "")
				GUICtrlSetData($customY, "")
			EndIf

		case $mm = $runButton
			if GUICTrlRead($isUsingWindowed) = $GUI_CHECKED Then

				rn("window", "")


			ElseIf GUiCtrlREad($isUsingDim) = $GUI_CHECKED Then
				if GUICtrlRead($customX) = "" or GUICTrlRead($customY) = "" Then
					rn("", "")
				Else
					rn(GUICtrlRead($customX), GUICtrlREaD($customY))
				EndIf

			ElseIf FileExists("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\reg.ular") Then
				rn("reg", "")
			Else

				rn("", "")
			EndIf
		case $mm = $maxRes
			$maxX = @DesktopWidth
			$maxY = @DesktopHeight
			GUICtrlSetData($customX, $maxX)
			GUICtrlSetData($customY, $maxY)
			;rn($BF2LoginName)
		case $mm = $GUI_EVENT_CLOSE
			FileOpen("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp.min", 2)
			Exit
		case $mm = $dontRunButton
			FileOpen("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp.min", 2)
			Exit
	EndSelect

WEnd

EndFunc

Func rn($resx, $resy)
	GUISetState(@SW_MINIMIZE)

	$additionalParameters = FileRead("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\add_para.cfg")

	$blah = FileReadLine("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\bf2path.cfg")

if $resx = "window" Then
	$p = Run(@ComSpec & " /c " & '"' & $blah & "\BF2.exe" & '"' & " +fullscreen 0 +modPath mods/bf2m0dd3r " & $additionalParameters, $blah)
	if $p = "" Then
		MsgBox(16, "BF2 M0dd3r runner ERROR", "Could not run battlefield 2..." & @CRLF & @CRLF & "Load the archive in BF2 M0dd3r before launching from BF2 M0dd3r")
		FileOpen("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp.min", 2)
		Exit

	Else

		idlic()

	EndIf
Elseif $resx = "reg" Then
	$p = Run(@ComSpec & " /c " & '"' & $blah & "\BF2.exe" & '"', $blah)
	if $p = "" Then
		msgbox(16, "BF2 M0dd3r runner ERROR", "Could not run battlefield 2..." & @CRLF & @CRLF & "Load the archive in BF2 M0dd3r before launching from BF2 M0dd3r")
		FileOpen("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp.min", 2)
		Exit
	Else
		idlic()
	EndIf

Else
	if $resx = "" and $resy = "" Then
		$p = Run(@ComSpec & " /c " & '"' & $blah & "\BF2.exe" & '"' & " +modPath mods/bf2m0dd3r " & $additionalParameters, $blah)
	Else
		;$p = ShellExecute($blah & "\BF2.exe", "szx " & $resx & " szy " & $resy, $blah)

		$iniFile = "C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\custom_dimensions.cfg"

		IniWrite($iniFile, "dimensions", "x", $resx)
		IniWrite($iniFile, "dimensions", "y", $resy)

		$p = Run(@ComSpec & " /c " & '"' & $blah & "\BF2.exe" & '"' & " +szx " & $resx & " +szy " & $resy & " +modPath mods/bf2m0dd3r " & $additionalParameters, $blah)
	EndIf

	if $p = "" Then
		MsgBox(16, "BF2 M0dd3r runner ERROR", "Could not run battlefield 2..." & @CRLF & @CRLF & "Load the archive in BF2 M0dd3r before launching from BF2 M0dd3r")
		FileOpen("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp.min", 2)
		Exit

	Else

		idlic()

	EndIf
EndIf


EndFunc

func idlic()
	$bQuit = false

	while $bQuit = False
		if Not ProcessExists("BF2.exe") Then
			sleep(400)
			ContinueLoop
		Else
			ExitLoop
		EndIf

	WEnd

	ok()

EndFunc

func ok()
	$bQuit = false

	while $bQuit = False

		if ProcessExists("BF2.exe") Then
			sleep(300)
		Else
			FileOpen("C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\tmp.min", 2)
			Exit
		EndIf

	WEnd


EndFunc
