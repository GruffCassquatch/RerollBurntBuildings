using ModSettings;

namespace RerollBurntBuildings
{
    internal class RerollBurntBuildingsSettings : JsonModSettings
    {
        [Section("Randomise Interloper")]
        [Name("Coastal Highway")]
        [Description("Allows randomisation of the burnt building spawns in Coastal Highway on Interloper")]
        public bool randomiseInterloper = false;
    }

    internal static class Settings
    {
        internal static RerollBurntBuildingsSettings settings;
        internal static void OnLoad()
        {
            settings = new RerollBurntBuildingsSettings();
            settings.AddToModSettings("Reroll Burnt Buildings");
        }
    }
}
