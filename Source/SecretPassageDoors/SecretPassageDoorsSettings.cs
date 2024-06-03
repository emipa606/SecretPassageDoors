using Verse;

namespace SecretPassageDoors;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class SecretPassageDoorsSettings : ModSettings
{
    public bool OnlyColonists;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref OnlyColonists, "OnlyColonists");
    }
}