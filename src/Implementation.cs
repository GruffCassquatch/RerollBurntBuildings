using System;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace RerollBurntBuildings
{
    public class Implementation : MelonMod
    {
        public const string cabinsSpawner = "RandomSpawnObjectBase_cabins";
        public const string fishingCabin = "Art/Structure_Group/LakeCabins_with_Fishing_interiors/STRSPAWN_LakeCabinD_Prefab";
        public const string interloperSpawner = "RandomSpawnObjectBase_burnt_nightmare";
        public const string lakeCabinsSpawner = "RandomSpawnObjectBase_lakeCabins";
        public const string logsortSpawner = "RandomSpawnObjectBase_logsort";
        public const string miltonSpawner = "Houses_Random/RandomSpawnObjectBase";
        public const string thomsonsSpawner = "RandomSpawnStructures/Town/RandomSpawnObjectBase";
        public const string townNorthSpawner = "RandomSpawnObjectBase_townNorth";
        public const string townSouthSpawner = "RandomSpawnObjectBase_townSouth";
        public const string waterfrontSpawner = "RandomSpawnObjectBase_waterfront";
        public const string fishingHutDoorsCHSpawner = "Design/RandomSpawnStructures/RandomFishHuts";
        public const string fishingHutDoorsMLSpawner = "Design/RandomSpawnStructures/RanomFishHuts";

        public static readonly string[] coastalSpawners = new string[] { cabinsSpawner, logsortSpawner, townNorthSpawner, townSouthSpawner, waterfrontSpawner};
        
        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] version {Info.Version} loaded!");
            Il2CppSystem.Collections.Generic.List<string> listOfPossibleParameters = new Il2CppSystem.Collections.Generic.List<string>();
            listOfPossibleParameters.Add("Cabins");
            listOfPossibleParameters.Add("cabins");
            listOfPossibleParameters.Add("FishingHutDoors");
            listOfPossibleParameters.Add("fishinghutdoors");
            listOfPossibleParameters.Add("Help");
            listOfPossibleParameters.Add("help");
            listOfPossibleParameters.Add("Interloper");
            listOfPossibleParameters.Add("interloper");
            listOfPossibleParameters.Add("LakeCabins");
            listOfPossibleParameters.Add("lakecabins");
            listOfPossibleParameters.Add("LogSort");
            listOfPossibleParameters.Add("logsort");
            listOfPossibleParameters.Add("Milton");
            listOfPossibleParameters.Add("milton");
            listOfPossibleParameters.Add("ThomsonsCrossing");
            listOfPossibleParameters.Add("thomsonscrossing");
            listOfPossibleParameters.Add("TownNorth");
            listOfPossibleParameters.Add("townnorth");
            listOfPossibleParameters.Add("TownSouth");
            listOfPossibleParameters.Add("townsouth");
            listOfPossibleParameters.Add("WaterfrontCottages");
            listOfPossibleParameters.Add("waterfrontcottages");

            uConsole.RegisterCommand("reroll_burntbuildings", new Action(RerollCommand.RerollBurntBuildings));
            uConsoleAutoComplete.CreateCommandParameterSet("reroll_burntbuildings", listOfPossibleParameters);
            Settings.OnLoad();
        }
    }
}