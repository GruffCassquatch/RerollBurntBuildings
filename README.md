# RerollBurntBuildings  
A mod for The Long Dark. Adds console commands that allow you to reroll the random burnt buildings in various locations. 

Can also reroll for the random doors on fishing huts in Coastal Highway and Mystery Lake.  

Also has a setting to enable random burnt buildings in Coastal Highway when playing on Interloper.  

Credit to [ds5678](https://github.com/ds5678) for giving me the base of this mod and [zeobviouslyfakeacc](https://github.com/zeobviouslyfakeacc) for the [CacheControl](https://github.com/zeobviouslyfakeacc/CacheControl) mod which I used as a guide for many things.

## Requirements  
[MelonLoader](https://github.com/HerpDerpinstine/MelonLoader/releases/latest/download/MelonLoader.Installer.exe)  

[ModSettings](https://github.com/zeobviouslyfakeacc/ModSettings/releases)  

[Developer-Console](https://github.com/FINDarkside/TLD-Developer-Console/releases)   

## **Installation:**   
1. Download ```RerollBurntBuildings.dll``` from [releases](https://github.com/GruffCassquatch/RerollBurntBuildings/releases)  
1. Drop ```RerollBurntBuildings.dll``` into your Mods folder  

## **Uninstallation:**  
Delete ```RerollBurntBuildings.dll``` and ```RerollBurntBuildings.json``` file from your Mods folder  

## **How to use the console commands:**
* **Be aware these commands will randomise building spawns! Use with common sense!**
* You must be **outdoors** in the same region as the buildings you want to reroll
* Commands are not case-sensitive
* If you are using [Developer-Console](https://github.com/FINDarkside/TLD-Developer-Console/releases) v1.4+ you can use ```TAB``` to autocomplete commands
* Use the command ```reroll_burntbuildings help``` to bring up a guide
* Buildings come in 'groups'; you can only reroll the whole group, not just one building in a group
* Each group has a specific set of possible building spawns, some groups have more possibilities than others
  * E.g. A group of buildings A, B & C might only have the possibile configuration: (1) A & B burnt, C unburnt (2) A & C burnt, B unburnt
  * No matter how many times you reroll, these would be the only two possible outcomes
* Some buildings will never be burnt and some will always be destroyed; you can only reroll for the random ones
* My advice is to use the command at the specific location so you can see the results
* You can reroll over and over  

* To reroll a set of burnt buildings, use the appropriate TargetArea argument:
  * For the Lake Cabins at Mystery Lake: ```reroll_burntbuildings LakeCabins```
    * Buildings: 4, Possibilities: 3 (each with different combo of 2 burnt/2 unburnt)
  * For the houses in Milton: ```reroll_burntbuildings Milton```
    * Buildings: 21, Possibilities: 3 (each with different combo of 6 burnt)
  * For the houses at Thomson's Crossing in Pleasant Valley: ```reroll_burntbuildings ThomsonsCrossing```
    * Buildings: 3, Possibilities: 3 (each with 1 house unburnt)
  * On Coastal Highway:
    * The main area of the town, near Quonset: ```reroll_burntbuildings TownNorth```
      * Buildings: 6, Possibilities: 4 (each with different combo of 3 burnt/3 unburnt)
    * The houses across the highway from Quonset, near the jetty: ```reroll_burntbuildings TownSouth```
      * Buildings: 3, Possibilities: 3 (each with 1 house unburnt)
    * The Waterfront Cottages: ```reroll_burntbuildings WaterfrontCottages```
      * Buildings: 3, Possibilities: 4 (3 with 1 house burnt, 1 with 2 burnt)
    * LogSort: ```reroll_burntbuildings LogSort```
      * Buildings: 1, Possibilities: 2 (burnt or unburnt)
    * The cabins below the Abandoned Lookout: ```reroll_burntbuildings Cabins```
      * Buildings: 2, Possibilities: 3 (2 with 1 burnt, 1 with both burnt)

* To reroll the fishing hut doors: ```reroll_burntbuildings FishingHutDoors```
    * Coastal Highway Fishing Huts: 9, Possibilities: 4 (each with 2 huts with doors)
    * Mystery Lake Fishing Huts: 4, Possibilities: 3 (each with 1 hut with a door)


## How to enable/disable random burnt buildings on Interloper for Coastal Highway
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

## Feedback, Questions & Troubleshooting
* I am active on [The Long Dark Modding](https://discord.gg/QvFE7VV4WZ) Discord server
	* **General questions and feedback:** post in my channel #cass
	* **Troubleshooting:** 
		* Post in my channel #cass or in #troubleshooting 
		* Or create an issue here on GitHub if you're not on Discord
