

# Valheim Server Settings
A simple HarmonyX Mod aimed at providing the option to change hardcoded server settings in Valheim

# Origin
This is originally from https://github.com/nxPublic/ValheimPlus

```INI
[Server]
enabled=false
; enable/disable Server changes

maxPlayers=10
; (int) default is 10

disableServerPassword=false
; (boolean) default is false
```


# Valheim Server Settings Compiler Requirements

How to setup the development enviroment to compile ValheimPlus yourself.

1. Download this package:
https://mega.nz/file/0UAlxQwK#47InGOb8ViI6GyBDArpbhkbMTBklXdyRSmAc4-BZpJY

2. Unpack into your Valheim root folder and overwrite every file when asked.

3. Download this this repositories executable version.
Repo: https://github.com/MrPurple6411/Bepinex-Tools/releases/tag/1.0.0-Publicizer
Exec: https://mega.nz/file/oQxEjCJI#_XPXEjwLfv9zpcF2HRakYzepMwaUXflA9txxhx4tACA

4. Drag and drop all assembly_.dll files onto "AssemblyPublicizer.exe"

5. Add all dll's of "\Valheim\valheim_Data\Managed" and "publicized_assemblies" folder as references to the project.

(Except : "mscorlib.dll", "System.Configuration.dll", "System.Core.dll", "System.dll", "System.Xml.dll")

6. Add all BepInEx dll's ("Valheim\BepInEx\core") as refernces to the project.

(Except : "0Harmony.dll", "0Harmony20.dll")

7. Add Ini-parser and HarmonyX via nu-get

# Credits

nx#8830 - All (as of now)