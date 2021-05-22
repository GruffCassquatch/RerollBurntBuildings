# RerollBurntBuildings  
A mod for The Long Dark. Adds console commands that allow you to reroll the random burnt buildings in various locations.  
Also has a setting to enable random burnt buildings in Coastal Highway when playing on Interloper.  

Credit to [ds5678](https://github.com/ds5678) for giving me the base of this mod and [zeobviouslyfakeacc](https://github.com/zeobviouslyfakeacc) for the [CacheControl](https://github.com/zeobviouslyfakeacc/CacheControl) mod which I used as a guide for many things.

## Requirements  
[MelonLoader](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe)  

[ModSettings](https://github.com/zeobviouslyfakeacc/ModSettings/releases)  

[Developer-Console](https://github.com/FINDarkside/TLD-Developer-Console/releases)   


## **Installation:**   
1. Download RerollBurntBuildings.dll from [releases](https://github.com/GruffCassquatch/RerollBurntBuildings/releases/download/1.0/RerollBurntBuildings.dll)  
1. Drop RerollBurntBuildings.dll into your Mods folder  

## **Uninstallation:**  
Delete RerollBurntBuildings.dll and RerollBurntBuildings.json file from your Mods folder  

## **How to use the console commands:**
* **Be aware these commands will randomise building spawns! Use with common sense!**
* You must be **outdoors** in the same region as the buildings you want to reroll
* Commands are not case-sensitive
* Use the command ```reroll_burntbuildings help``` to bring up a guide
* You can reroll over and over
* Each area has a specific set of possible building spawns, some areas have more possibilities than others
  * E.g. Buildings A, B & C might only have the possibile configuration: (1) A & B burnt, C unburnt (2) A & C burnt, B unburnt
  * No matter how many times you reroll, these would be the only two possible outcomes
* Some buildings will never be burnt and some will always be destroyed; you can only reroll for the random ones  

* To reroll a set of burnt buildings, use the appropriate TargetArea argument:
  * For the Lake Cabins at Mystery Lake: ```reroll_burntbuildings LakeCabins```
  * For the houses in Milton: ```reroll_burntbuildings Milton```
  * For the houses at Thomson's Crossing in Pleasant Valley: ```reroll_burntbuildings ThomsonsCrossing```
  * On Coastal Highway:
    * The main area of the town, near Quonset: ```reroll_burntbuildings TownNorth```
    * The houses across the highway from Quonset, near the jetty: ```reroll_burntbuildings TownSouth```
    * The Waterfront Cottages: ```reroll_burntbuildings WaterfrontCottages```
    * LogSort: ```reroll_burntbuildings LogSort```
    * The cabins below the Abandoned Lookout: ```reroll_burntbuildings Cabins```


## **How to enable/disable random burnt buildings on Interloper for Coastal Highway**
**You can reroll the buildings in other regions without these additional steps**
1. Open the Options menu
2. Open the Mod Settings menu
3. Scroll across to the Reroll Burnt Buildings menu
4. Enable or disable random burnt buildings on Interloper for Coastal Highway using YES / NO
5. Click CONFIRM to apply your changes (or BACK to exit without applying changes)
6. While in an **Interloper** game and **outdoors** in **Coastal Highway**, open the console (F1)
7. Use the command ```reroll_burntbuildings interloper```
   1. If you have the setting *enabled*, random burnt buildings will be generated
   2. If you have the setting *disabled*, the random burnt buildings will be reverted to Interloper vanilla state
8. Change scenes (e.g. go inside) to generate the correct version of the Fishing Hut with the workbench behind it at Fishing Camp 
9. After performing these steps to enable randomisation, you can use the other console commands to reroll specific areas in Coastal Highway

