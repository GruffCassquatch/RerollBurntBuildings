
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
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
        public static readonly string[] coastalSpawners = new string[] { cabinsSpawner, logsortSpawner, townNorthSpawner, townSouthSpawner, waterfrontSpawner};

        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] version {Info.Version} loaded!");
            uConsole.RegisterCommand("reroll_burntbuildings", new Action(RerollCommand.RerollBurntBuildings));
            Settings.OnLoad();
        }
    }
}