# Survivotron Kit

The Survivotron Kit is a Windows application to be used as a companion of the Survivotron GPS - an in-game 
gadget of the Miscreated survival videogame [http://miscreatedgame.com]. 
With this tool a Miscreated player can enter his/her Survivotron GPS data and find his/her location on the map. 
Also a Miscreated server's administrator can enter a (X,Y) location from the damagelog server files and mark that 
location on the map.

## Binaries download

See the [[Wiki's download page|downloads]]. 


## How to build the executable file

If you do not have Visual Studio 2017 you need to get the latest msbuild, 
which are part of the Visual Studio Build Tools 2017. You can get those 
Build Tools from the Visual Studio 2017 download page:

https://www.visualstudio.com/downloads/ 

On the bottom, click “Other Tools and Frameworks”, then choose “Build Tools 
for Visual Studio 2017”. The direct download link is:

https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=BuildTools&rel=15

Start the downloaded setup file (vs_buildtools_xxx.exe), and in the Visual Studio Installer 
choose the component “.NET desktop build tools”. It will download and install the 
build tools in the default location (but you can choose other location): 

C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools

After installing, you will get a new command prompt in the Windows Start menu, 
called “Developer Command Prompt for VS 2017”.  Use it to start your command prompt, 
as it will add to path all required folders to run msbuild from anywhere.

In the command prompt go to your folder with the solution .sln file (SurvivotronKit.sln), 
and just type msbuild. It will automatically start building the sln files. 
When the build is finished  will have an executable file 'MiscreatedGeolocationKit.exe' 
in the folder 'SurvivotronKit\SurvivotronKit\bin\Debug'.

## Contact

* Visit the [issues page](https://github.com/uyke/survivotronkit/issues) to report a bug, request a feature or send other kind of feedback.
* Or send email to: uykemakana@gmail.com



