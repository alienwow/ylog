nuget pack Alienwow.YLog.nuspec -OutputDirectory E:\AlienwowNuGetPackages
nuget setApiKey f6d31c8d-c7d7-412c-9e37-2e1a2c46449f
nuget push E:\AlienwowNuGetPackages\Alienwow.YLog.1.0.2.nupkg
@pause