# Nothing to see here!
This is just a development repo that me and my buddy are using to play around with and potentially develop a valheim mod.

# .dll list
The following list of .DLLs need to be copied to the "ValheimMods/Libs" folder in the root solution directory before you can build the project.

- <game_root>/BeInEx/core/BepInEx.dll
- <game_root>/valheim_Data/Managed/UnityEngine.dll
- <game_root>/valheim_Data/Managed/UnityEngine.CoreModule.dll

# You need to add the references to the DLLs manually to the project in Visual Studio
Follow the section of this guide page named 'Gathering DLL dependencies' for instructions on how to add references to the .dlls copied into the '/Libs/' folder.

https://bepinex.github.io/bepinex_docs/master/articles/dev_guide/plugin_tutorial/1_setup.html