using HarmonyLib;
using RimWorld;
using Verse;

namespace SecretPassageDoors;

[HarmonyPatch(typeof(Building_Door), nameof(Building_Door.PawnCanOpen))]
[HarmonyBefore("Mlie.PrisonersDontHaveKeys")]
public class Building_Door_PawnCanOpen
{
    [HarmonyPostfix]
    public static void Postfix(Pawn p, ref bool __result, Building_Door __instance)
    {
        if (!__result)
        {
            return;
        }

        if (!SecretPassageDoorsMod.Instance.Settings.OnlyColonists)
        {
            return;
        }

        if (!SecretPassageDoors.SecretPassageDoorDefs.Contains(__instance.def))
        {
            return;
        }

        __result = p.IsPlayerControlled;
    }
}