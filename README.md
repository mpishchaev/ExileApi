# ExileApi
An introduction can be found in the forum thread:
https://www.ownedcore.com/forums/mmo/path-of-exile/poe-bots-programs/940986-exileapi-3-14-release.html#post4300263

# Release
https://github.com/Queuete/ExileApi/releases

# Troubleshooting
1. The Hud wont start.
- Windows 10 is the only supported system
- download and install .NET 4.8 runtime https://dotnet.microsoft.com/downloa...-web-installer
- turn of your firewall and antivirus and try again. (Thanks @bobTheBuilder69)
- make sure the 64x PoE client is already running
- make sure you use the standalone client (NOT Steam, NOT Epic Launcher, NOT Taiwan, NOT Tencent)
- make sure you have VC++ Redistributable Runtime installed (https://support.microsoft.com/en-us/...al-c-downloads) (Thanks @snowhawk)

2. The Hud stopped working and presents an error when trying to start it.
- check if your config/settings.json file got corrupted. If thats the case you can replace the content with the config/dumpSettings.json file or completly delete it (then default settings will be generated).

3. There are visual offsets in rendering minion dots and everything other.
Windows Display options -> Scale and layout -> set to 100%
If that one does not work: Right Click Loader.exe > Properties > Compatibility > Change high DPI settings > Override high DPI scaling behavior > Application
(Thanks @Unknown_B)

4. MinimapIcons wont work.
- The IconBuilder plugin needs to be activated aswell.
- Change the Map Zoom slider in Poe -> Options -> UI -> Map Zoom (Thanks @JustRandomPlayer)

5. AutoQuit wont work.
You need to run the hud as admin for it to work.

6. PickIt and Stashie are very slow.
Check which Windows 10 version you are using. Win10 2004 is slow, reverting back to Win10 1909 solves this. (Thanks @uumas)

7. The Hug laggs, especially MinimapIcons and HealthBars
Probably one of your other plugins is very performance intense. Currently EliteBar is often the problem.

8. The Hud and SlimTrade wont work together
Slimtrade has the option to show a Config Button on the screen for easy configuration. If you disable the config button then the focus does not get stolen. (Thanks @Smartillian)

## Troubleshooting did not solve my issue
Create an issue with a detailed error description. Post the full error log (PoeHelper/Logs/Verbose-[date].log)
-> Posts about problems which dont do this will be ignored by me.

# How To Setup a Developer Version
Please look into the base repository the needed software is described there, including some troubleshooting https://github.com/Qvin0000/ExileApi

To use this version you need .net4.8 and git. 
Git https://git-scm.com/downloads
.NET 4.8 https://dotnet.microsoft.com/download/thank-you/net48

1. Create a PoeHUD (any name) folder
2. Open a git bash inside the folder
3. Run `git clone https://github.com/Queuete/ExileApi`
4. Open the solution file in Visual Studio
5. This should compile already, there could be some reference errors, those are mostly fixed by removing the reference (solution exlporer-plugin_project->references) the ones with warnings need to be readded

-> Adding plugins (example DevTree)

6. Open git bash in "ExileApi/Plugins"
7. Run `git clone https://github.com/Queuete/DevTree`
8. Open Visual Studio, right click the "ExileApi" solution in the "Solution Explorer". -> Add -> New Solution Folder (name it "Plugins")
9. Right click created folder -> Add -> Existing Project -> "ExileApi/Plugins/Devtree/DevTree.csproj"


Tools used for reverse engineering are mostly: ReClass.NET, CheatEngine, Ghidra
When you want to learn something about it, get comfortable with at least the first tool or second tool and try to comprehend already updated offsets. (For 3.10 I advise you to start with the LifeComponent)


# From the forum page
ExileAPI Release
Hello community,

Getting Started

As any other fork you should run poe as a limited user when using this tool. https://www.ownedcore.com/forums/mmo...ited-user.html (Run PoE as a limited user)

If you run into any problems please read the Troubleshooting section in this post, the last point (Nothing worked) tells you what to do if the section did not solve your problem.
Questions which ignore this message will be ignored by me.


Plugins

The Release will come with a default list of plugins. When you first start the Loader.exe those will be downloaded, compiled and loaded in the hud.

In case something wont happen as you expect, please take a look into the Log (F12 -> Core -> Show Log window). There could be some error messages which are useful when you seek help from other community members.

If you want to change the config files of a plugin make sure you do your changes in "Plugins/Compiled/PluginName". Changes in the Source folder will be overwritten on start up.

Add New

1. F12 (open main menu), Go to "PluginAutoUpdate"
2. Change the settings as you desire e.g. Add a new plugin or change the source url of an existing plugin
3. F12 (save settings), Restart Loader.exe

Switch to specific version

1. F12 (open main menu), Go to "PluginAutoUpdate"
2. Deactivate the auto update functionality of the plugin you want to pin to a specific version
3. Enter the Commit Sha (40 characters) of the version you want to use in the textbox below the plugin url (this field is only changeable when you have done step 2)
4. F12 (save settings), Restart Loader.exe


Disclaimer: Due to the nature of a auto plugin functionality this will run code downloaded from repositories on your pc. You should not use repositories from owners you dont trust. Running PoeHelper as admin will increase the risk.


Plugin List

Default
Working:
- HealthBars, https://github.com/Queuete/HealthBars
- MinimapIcons, https://github.com/Queuete/MinimapIcons
- IconsBuilder, https://github.com/Queuete/IconsBuilder
- PreloadAlert, https://github.com/Queuete/PreloadAlert
- SimplePickIt, https://github.com/Queuete/SimplePickIt
- SimpleStashie, https://github.com/Queuete/SimpleStashie
- SimpleHotkeyChain, https://github.com/Queuete/SimpleHotkeyChain
- BasicFlaskRoutine, https://github.com/sychotixdev/BasicFlaskRoutine / https://github.com/IlliumIv/BasicFlaskRoutine

?:
- Stashie, https://github.com/Craere/Stashie

Extras
- DevTree, https://github.com/Queuete/DevTree
- MiscInformation, https://github.com/IlliumIv/MiscInformation
- HighlightedItems https://github.com/ravand1990/HighlightedItems
- CoPilot https://github.com/totalschaden/copilot
- MineDetonator https://github.com/mm3141/MineDetonator
- Terrain https://github.com/mm3141/Terrain
- GemUp https://github.com/ElRatto/GemUp
- PickIt https://github.com/vadash/Pickit
- EliteBar GitHub - https://github.com/Queuete/EliteBar -> if you experience hud lag, disable EliteBar, its most likely the cause

For more plugin ideas you may want to look here: https://github.com/IlliumIv/ExileApi/tree/master/Plugins/Source

Troubleshooting

1. The Hud wont start.
- Windows 10 is the only supported system
- download and install .NET 4.8 runtime https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer
- turn of your firewall and antivirus and try again.
- make sure the 64x PoE client is already running
- make sure you use the standalone client (NOT Steam, NOT Epic Launcher, NOT Taiwan, NOT Tencent)
- make sure you have VC++ Redistributable Runtime installed https://support.microsoft.com/en-us/help/2977003/the-latest-supported-visual-c-downloads

2. The Hud stopped working and presents an error when trying to start it.
- check if your config/settings.json file got corrupted. If thats the case you can replace the content with the config/dumpSettings.json file or completly delete it (then default settings will be generated).

3. There are visual offsets in rendering minion dots and everything other.
Windows Display options -> Scale and layout -> set to 100%
If that one does not work: Right Click Loader.exe > Properties > Compatibility > Change high DPI settings > Override high DPI scaling behavior > Application

4. MinimapIcons wont work.
- The IconBuilder plugin needs to be activated aswell.
- Change the Map Zoom slider in Poe -> Options -> UI -> Map Zoom

5. AutoQuit wont work.
You need to run the hud as admin for it to work.

6. PickIt and Stashie are very slow.
Check which Windows 10 version you are using. Win10 2004 is slow, reverting back to Win10 1909 solves this.

7. The Hug laggs, especially MinimapIcons and HealthBars
Probably one of your other plugins is very performance intense. Currently EliteBar is often the problem.

8. The Hud and SlimTrade wont work together
Slimtrade has the option to show a Config Button on the screen for easy configuration. If you disable the config button then the focus does not get stolen.

Nothing worked
Make a post with a detailed error description. Post the full error log (PoeHelper/Logs/Verbose-[date].log)
-> Posts about problems which dont do this will be ignored by me.

FAQ

1. How can I support this project?
The best way is to contribute as a developer.
Other options are currently not available. My ExileApi fork will stay OpenSource and therefore completly free.

2. Can you add Plugin xyz?
You can do this yourself. Click on "PluginAutoUpdate" in the main menu (F12).
After you added your plugins press close the main menu (press F12 again, thats important to save the changes) and afterwards restart the Hud.

3. I want to learn to change offsets.
The tools used mostly are Cheat Engine, ReClass.NET and potentially Ghidra. Get yourself familiar with at least one of the first 2 tools and try to comprehend some already updated offsets. The easiest example is the current/max life, mana and ES of a character.
There are some tutorials on youtube which may help you understand the basics. Example: https://www.youtube.com/watch?v=YaFlh2pIKAg


Plugin Developer

When you are new you may want to check out the Github repository on "How to set up a developer version". This also describes how to add plugins into your developer version and compile them yourself.
https://github.com/Queuete/ExileApi/blob/master/README.md

1. If you have any external dependencies, which are not included in ExileAPI, put them in a folder called "libs" in your source. This folder needs to be at the same level as your .csproj file.
2. Static files (e.g. config or image files) either need to be generated in code (see Stashie) or placed in a folder which is copied by the updater.
Possible folder names which are copied: Dependencies: "libs", "Libs", "lib", "Lib". Other static files: "settings", "Settings", "config", "Config", "images", "Images", "img", "Img", "static", "Static"

To automate the process of adding your external dependencies you can use "(post) build events"
In your Solution explorer right click the plugin project -> Proeperties -> Tab Build Events -> Post-build event command line.
Example: copy "$(TargetDir)Dependency.dll" "$(ProjectDir)libs\Dependency.dll"

https://docs.microsoft.com/de-de/visualstudio/ide/how-to-specify-build-events-csharp?view=vs-2019

