Remove-Item -Path 'reports' -Recurse -ErrorAction SilentlyContinue;
Remove-Item -Path 'TestResults' -Recurse -ErrorAction SilentlyContinue;
Remove-Item -Path 'coverage.json' -ErrorAction SilentlyContinue;
Remove-Item -Path 'Coverage.lnk' -ErrorAction SilentlyContinue;

Write-Host 'Building';

dotnet build > $null;

$dllPath = Get-ChildItem -Path 'bin' -Recurse -Filter 'Restorio.Tests.Apps.Admin.dll';

Write-Host 'Calculating';

coverlet $dllPath.FullName --target 'dotnet' --targetargs 'test --no-build' > $null;

Write-Host 'Collecting';

dotnet test --collect:'XPlat Code Coverage' > $null;

$coberturaPath = Get-ChildItem -Path 'TestResults' -Recurse -Filter 'coverage.cobertura.xml';

Write-Host 'Reporting';

reportgenerator -reports:$coberturaPath.FullName -targetdir:'reports' -reporttypes:'Html' > $null;

#Write-Host 'Reporting (PDF)';

#Start-Process -FilePath 'C:/Program Files/Google/Chrome/Application/chrome.exe' -ArgumentList "--headless --disable-gpu --run-all-compositor-stages-before-draw --no-margins --no-pdf-header-footer --print-to-pdf='E:\Software Development\DFenceGPS\DFenceGPS.App.IoT.Tests.Unit\reports\index.html' 'E:\Software Development\DFenceGPS\DFenceGPS.App.IoT.Tests.Unit\Coverage.pdf'" -PassThru -Wait;

Write-Host 'Shortcutting';

$indexPath = Get-ChildItem -Path 'reports' -Recurse -Filter 'index.html';

$wscriptShell = New-Object -ComObject WScript.Shell;
$shortcut = $wscriptShell.CreateShortcut("$pwd\Coverage.lnk");
$shortcut.TargetPath = $indexPath.FullName;
$shortcut.Save();

Remove-Item -Path 'TestResults' -Recurse -ErrorAction SilentlyContinue;
Remove-item -Path 'coverage.json' -ErrorAction SilentlyContinue;