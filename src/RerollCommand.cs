using System.Text;
using UnityEngine;

namespace RerollBurntBuildings
{
    class RerollCommand
    {
        internal static void RerollBurntBuildings()
        {
            int numParameters = uConsole.GetNumParameters();

            if (numParameters < 1 || numParameters > 1)
            {
                uConsole.Log("|  This command requires a single argument (e.g. help)");
                PrintUsage();
                return;
            }

            string targetArea = uConsole.GetString().ToLower();

            if (targetArea.Contains("help"))
            {
                PrintUsage();
                return;
            }

            if (targetArea.Contains("interloper"))
            {
                if (ExperienceModeManager.GetCurrentExperienceModeType() != ExperienceModeType.Interloper)
                {
                    uConsole.Log("|  This command can only be used on Interloper");
                    PrintUsage();
                    return;
                }
                if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "CoastalRegion")
                {
                    uConsole.Log("|  This command can only be used outside in Coastal Highway");
                    PrintUsage();
                    return;
                }
                if (Settings.settings.randomiseInterloper)
                {
                    uConsole.Log("|  Randomising Coastal Highway building spawns on Interloper");
                }
                if (!Settings.settings.randomiseInterloper)
                {
                    uConsole.Log("|  Reverting randomisation of Coastal Highway building spawns on Interloper");
                }

                RerollSpawner(FindAllSpawners());
                return;
            }

            RandomSpawnObject spawner = FindSpawner(targetArea);
            if (!spawner)
            {
                uConsole.Log("|  Error: Could not find specified TargetArea in the current scene");
                PrintUsage();
                return;
            }
            else
            {
                RerollSpawner(spawner);
                uConsole.Log("|  Rerolled burnt buildings in TargetArea");
            }
        }

        private static void PrintUsage()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("|  Usage:");
            builder.AppendLine("|   - You must be outdoors in the target region for all commands");
            builder.AppendLine("|   - Command: force_reroll_burnthouses TargetArea");
            builder.AppendLine("|      -> Rerolls a specific area of burnt buildings");
            builder.AppendLine("|      -> The area options are:");
            builder.AppendLine("|         -> Coastal Highway: 'Cabins', 'LogSort', 'TownNorth', 'TownSouth', 'WaterfrontCottages' and 'FishingHutDoors'");
            builder.AppendLine("|         -> Mountain Town: 'Milton'");
            builder.AppendLine("|         -> Mystery Lake: 'LakeCabins' and 'FishingHutDoors'");
            builder.AppendLine("|         -> Pleasant Valley: 'ThomsonsCrossing'");
            builder.AppendLine("|   - Command: force_reroll_burnthouses help");
            builder.AppendLine("|      -> shows this message. Use anywhere.");
            builder.AppendLine("|   - Command: force_reroll_burnthouses Interloper");
            builder.AppendLine("|      -> Execute once after changing Randomise Interloper settings to apply changes");
            builder.AppendLine("|      -> You will also need to change scene (go through a loading screen) to fix fishing cabin");
            builder.AppendLine("|      -> After enabling, can reroll specific Coastal Highway areas with commands above");
            builder.AppendLine("|   - Examples:");
            builder.AppendLine("|      -> force_reroll_burnthouses LogSort");
            builder.AppendLine("|      -> force_reroll_burnthouses logsort");
            builder.AppendLine("|");
            builder.Append("|  Warning: Executing these commands can prevent access to previously discovered houses!");
            uConsole.Log(builder.ToString());
        }

        public static void RerollSpawner(RandomSpawnObject spawner)
        {
            spawner.DisableAll();
            Vector3 oldPos = spawner.transform.localPosition;
            try
            {
                spawner.transform.Translate(UnityEngine.Random.onUnitSphere);
                spawner.ActivateRandomObject();
            }
            finally
            {
                spawner.transform.localPosition = oldPos;
            }
        }

        private static void RerollSpawner(RandomSpawnObject[] spawners)
        {
            foreach (var spawner in spawners)
            {
                if (spawner) RerollSpawner(spawner);
                else uConsole.Log("|  Error: Interloper command returned a null spawner");
            }
            uConsole.Log("|  Executed Interloper command. Change scene to fix fishing cabin");
        }

        internal static RandomSpawnObject FindSpawner(string targetArea)
        {
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "CoastalRegion")
            {
                if (targetArea == "cabins")
                {
                    return GameObject.Find(Implementation.cabinsSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                else if (targetArea == "fishinghutdoors")
                {
                    return GameObject.Find(Implementation.fishingHutDoorsCHSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                else if (targetArea == "logsort")
                {
                    return GameObject.Find(Implementation.logsortSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                else if (targetArea == "townnorth")
                {
                    return GameObject.Find(Implementation.townNorthSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                else if (targetArea == "townsouth")
                {
                    return GameObject.Find(Implementation.townSouthSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                else if (targetArea == "waterfrontcottages")
                {
                    return GameObject.Find(Implementation.waterfrontSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                return null;
            }
            else if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "LakeRegion")
            {
                if (targetArea == "fishinghutdoors")
                {
                    return GameObject.Find(Implementation.fishingHutDoorsMLSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                else if (targetArea == "lakecabins")
                {
                    return GameObject.Find(Implementation.lakeCabinsSpawner)?.GetComponentInChildren<RandomSpawnObject>();
                }
                return null;
            }
            else if (targetArea == "milton" && UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "MountainTownRegion")
            {
                return GameObject.Find(Implementation.miltonSpawner)?.GetComponentInChildren<RandomSpawnObject>();
            }
            else if (targetArea == "thomsonscrossing" && UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "RuralRegion")
            {
                return GameObject.Find(Implementation.thomsonsSpawner)?.GetComponentInChildren<RandomSpawnObject>();
            }
            else 
            {
                return null;
            }
        }
        internal static RandomSpawnObject[] FindAllSpawners()
        {
            return new RandomSpawnObject[]
            {
                GameObject.Find(Implementation.cabinsSpawner)?.GetComponentInChildren<RandomSpawnObject>(),
                GameObject.Find(Implementation.interloperSpawner)?.GetComponentInChildren<RandomSpawnObject>(),
                GameObject.Find(Implementation.logsortSpawner)?.GetComponentInChildren<RandomSpawnObject>(),
                GameObject.Find(Implementation.townNorthSpawner)?.GetComponentInChildren<RandomSpawnObject>(),
                GameObject.Find(Implementation.townSouthSpawner)?.GetComponentInChildren<RandomSpawnObject>(),
                GameObject.Find(Implementation.waterfrontSpawner)?.GetComponentInChildren<RandomSpawnObject>()
            };
        }
    }
}
