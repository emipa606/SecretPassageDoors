# GitHub Copilot Instructions for RimWorld Mod: Secret Passage Doors (Continued)

## Mod Overview and Purpose
The Secret Passage Doors (Continued) mod updates and extends Blake's original mod, adding doors that blend seamlessly with different wall types. It is designed to provide players with the ability to create hidden passages and maintenance hatches that appear as part of the wall, enhancing player strategies and aesthetics within their RimWorld colonies. The mod features various door types to match metallic, brick, plank, smoothed rock, and rock surfaces, as well as a versatile wall connector for creating hidden transitions in base architecture.

## Key Features and Systems
- **Secret Doors:** Introduces hidden doors for various wall materials, allowing players to secretly traverse and maintain different areas of their colony.
- **Wall Connector:** A flexible component that can connect walls not just to secret doors, but also to vents, nutrient paste dispensers, and more.
- **Player Control Setting:** Includes a customizable setting that allows only player-controlled colonists to use these secret passage doors.
- **Material Updates:** Updated to match RimWorld's 1.0 and 1.1 assets, including changes to material requirements (e.g., 5 steel instead of components).

## Coding Patterns and Conventions
- **Class Structure:** The mod is organized with clear class definitions for each significant component, such as `Building_Door_PawnCanOpen`, `SecretPassageDoors`, and `SecretPassageDoorsSettings`.
- **Namespace Organization:** Ensure consistency in namespace use across files to avoid conflicts and support clear code navigation.
- **Access Modifiers:** Utilize appropriate access modifiers (`public`, `internal`, `private`) to encapsulate functionality and data.

## XML Integration
- **Defining Defs:** XML is used to define new building and thing defs, aligning with RimWorld's data-driven design. Ensure XML files are well-structured and named according to their content.
- **Patch Operations:** When integrating with existing definitions, use XPath patch operations to safely inject changes without overwriting base game content.

## Harmony Patching
- **Method Hooking:** Use Harmony to hook into RimWorld's methods, such as overriding door interaction mechanics with `Building_Door_PawnCanOpen`.
- **Patch Safety:** Perform checks to maintain mod compatibility with other mods by using conditional patches where applicable.
- **Version Updates:** Regularly review RimWorld updates to ensure Harmony patches are still relevant and functional.

## Suggestions for Copilot
- **Code Completion in C#:** Leverage Copilot to aid in writing boilerplate code and filling out the repetitive parts of class and method definitions.
- **XML Patterns:** Use Copilot to suggest XML keys and structures when defining new defs, ensuring adherence to RimWorld's expected formatting.
- **Harmony Assistance:** Allow Copilot to propose template Harmony patches, including commonly used prefixes and postfixes for method modification.
- **Refactoring Support:** Utilize Copilot's ability to suggest refactoring opportunities, enhancing the maintainability and readability of the codebase.

For further queries or troubleshooting, it is recommended to utilize community resources like Discord channels for real-time support and to contribute potential solutions directly to the GitHub repository whenever applicable.
