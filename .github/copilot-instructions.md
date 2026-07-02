# GitHub Copilot Instructions for Secret Passage Doors (Continued)

## Mod Overview and Purpose
**Mod Name:** Secret Passage Doors (Continued)  
**Mod Description:** This mod is a continuation of Blake's Secret Passage Doors mod, introducing hidden doors that blend seamlessly with walls for secret passages, maintenance accesses, and more. With this mod, players gain the ability to create secret passageways using doors that aesthetically match metallic, brick, wooden plank, smoothed rock, and natural rock walls.

The mod has been updated to reflect changes in RimWorld 1.0 and 1.1, including updated wall graphics and changes in resource requirements for building these doors.

## Key Features and Systems
- **Hidden Doors:** The mod provides doors that appear as natural parts of walls, enhancing stealth and strategic layouts.
- **Wall Connector:** Utilized for connecting walls and placements such as vents or nutrient paste dispensers, beyond the secret door functionality.
- **Updated Graphics:** Visual components were updated to match the aesthetics of RimWorld versions 1.0 and 1.1.
- **Selective Access:** Configurations allow the limitation of door usage to player-controlled colonists.

## Coding Patterns and Conventions
- **Naming Conventions:** Classes and methods use PascalCase, whereas variables and fields use camelCase.
- **Project Structure:** C# code is organized within a `Source` directory, maintaining separation between XML and C# assets.
- **DefOf Usage:** Utilizes the `DefOf` class pattern to manage mod-specific definitions efficiently.
- **Settings Management:** Through custom settings stored and exposed using the `ExposeData` method in `SecretPassageDoorsSettings.cs`.

## XML Integration
- **ThingDefs:** Defined in `Buildings_Misc.xml`. Customize door properties to match visuals and behaviors in-game.
- **Update Information:** Managed via `UpdateInfo.xml` to ensure users are informed of mod changes.
- **Localization:** XML files in the `TranslationTemplate` folder assist in maintaining consistent translations and mod descriptions.

## Harmony Patching
- **Harmony Integration:** This mod employs Harmony (brrainz.harmony) to patch game methods, allowing for the customization of door interactions, such as selectively enabling access.
- **Example Patch:** Within `Building_Door_PawnCanOpen.cs`, a postfix is applied using Harmony to determine who can open doors, adding a layer of gameplay depth.

## Suggestions for Copilot
1. **Automatic Patch Suggestions:** Use Copilot to suggest patches for extending access restrictions or altering specific door behaviors.
2. **XML Definitions Assistance:** Utilize Copilot for automatic generation and validation of XML defs to prevent errors and ensure compliance with mod operation.
3. **Refactoring Support:** Leverage Copilot's ability to recommend refactoring of complex functions to improve code readability and maintainability.
4. **Localization and UI Enhancements:** Get Copilot's help in identifying gaps in language and UI, suggesting areas for support across different languages.

By leveraging GitHub Copilot, mod developers can efficiently manage updates, maintain consistency across codebases, and enhance modular capabilities while keeping player experience central.


This completes the requested GitHub Copilot instruction file. If further adjustments or specific aspects of the project need more detailed explanations, feel free to ask!

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).

