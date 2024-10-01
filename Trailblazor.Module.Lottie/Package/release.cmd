del "*.nupkg"
"..\..\oqtane.framework\oqtane.package\nuget.exe" pack Trailblazor.Module.Lottie.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\Packages\" /Y

