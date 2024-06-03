using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace SecretPassageDoors;

[StaticConstructorOnStartup]
public class SecretPassageDoors
{
    public static readonly List<ThingDef> SecretPassageDoorDefs =
    [
        SecretPassageDoorsDefOf.HiddenDoorBricks,
        SecretPassageDoorsDefOf.HiddenDoorPlanks,
        SecretPassageDoorsDefOf.HiddenDoorRock,
        SecretPassageDoorsDefOf.HiddenDoorRocksmooth,
        SecretPassageDoorsDefOf.HiddenDoorSmooth
    ];

    static SecretPassageDoors()
    {
        new Harmony("Mlie.SecretPassageDoors").PatchAll(Assembly.GetExecutingAssembly());
    }
}