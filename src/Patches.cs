using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace RerollBurntBuildings
{
    class Patches
    {
        [HarmonyPatch(typeof(RandomSpawnObject), "ActivateRandomObject")]
        private static class RandomiseInterloper
        {
            private static void Prefix(RandomSpawnObject __instance)
            {
                if (ExperienceModeManager.GetCurrentExperienceModeType() != ExperienceModeType.Interloper || UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "CoastalRegion") return;

                if (__instance.m_RerollAfterGameHours == 0f)
                {
                    if (Settings.settings.randomiseInterloper)
                    {
                        if (Implementation.interloperSpawner == __instance.gameObject.name) __instance.m_NumObjectsToEnableInterloper = 0;
                        else if (Implementation.coastalSpawners.Contains<string>(__instance.gameObject.name)) __instance.m_NumObjectsToEnableInterloper = 1;
                    }
                    else
                    {
                        if (Implementation.interloperSpawner == __instance.gameObject.name) __instance.m_NumObjectsToEnableInterloper = 1;
                        else if (Implementation.coastalSpawners.Contains<string>(__instance.gameObject.name)) __instance.m_NumObjectsToEnableInterloper = 0;
                    }
                }
            }
        }

        [HarmonyPatch(typeof(GameManager), "Awake")]
        internal class SetFishingCabin
        {
            private static void Postfix()
            {
                if (ExperienceModeManager.GetCurrentExperienceModeType() != ExperienceModeType.Interloper || UnityEngine.SceneManagement.SceneManager.GetActiveScene().name != "CoastalRegion") return;

                GameObject fishingCabin = GameObject.Find(Implementation.fishingCabin);

                if (fishingCabin is null)
                {
                    MelonLoader.MelonLogger.Error("Could not find fishing cabin");
                    return;
                }
                if (Settings.settings.randomiseInterloper)
                {
                    GameObject.Destroy(fishingCabin.GetComponent<DisableObjectForXPMode>());
                    fishingCabin.SetActive(true);
                }
                else
                {
                    fishingCabin.SetActive(false);
                }
            }
        }
    }
}