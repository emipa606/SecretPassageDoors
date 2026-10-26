# GitHub Copilot Instructions for Secret Passage Doors (Continued)

## Mod Overview and Purpose

Secret Passage Doors (Continued) is an update to the original Secret Passage Doors mod for RimWorld. The mod adds doors that look like and blend in with walls, for secret passages, maintenance hatches, etc. It includes a setting to only let player-controlled colonists use the doors. The mod has been updated for RimWorld 1.0 and 1.1, with new wall graphics and updated costs.

## Key Features and Systems

- **Secret Passage Doors**: The mod adds doors that look like and blend in with walls for secret passages, maintenance hatches, etc. These doors come in various materials, including metallic, brick, plank, smoothed rock, and rock surfaces.

- **Wall Connector**: The wall connector can be used to connect walls to vents, nutrient paste dispensers, and other objects in addition to connecting walls and secret doors.

- **Settings**: The mod includes a setting to only let player-controlled colonists use the doors.

## Coding Patterns and Conventions

- **Coding Style**: The code follows standard C# conventions and uses camelCase for variable and method names.

- **Class Structure**: The C# files are structured into classes, each with its own responsibility. For example, `SecretPassageDoorsMod` handles the mod settings, `SecretPassageDoors` handles the mod logic, and `Building_Door_PawnCanOpen` handles the pawn-based door logic.

- **XML Integration**: The mod uses XML files to define new game objects, such as doors and wall connectors. These XML files are located in the `Defs` folder of the mod.

- **Harmony Patching**: The mod uses Harmony patching to modify existing game behavior. For example, the `Building_Door_PawnCanOpen` class uses a Harmony postfix patch to modify the behavior of the `Open` method for the door.

## XML Integration

The mod uses XML files to define new game objects, such as doors and wall connectors. These XML files are located in the `Defs` folder of the mod and use the following conventions:

- **ThingDef**: Each new game object is defined using a `ThingDef` element, which includes attributes such as `defName`, `label`, and `description`.

- **StatDef**: Each new game object can have multiple `StatDef` elements, which define the object's statistics, such as its cost and build time.

- **DefOf**: The `DefOf` class is used to store references to the mod's game objects. This class is generated using the `DefGenerator` class, which reads the XML files and generates the necessary code.

## Harmony Patching

The mod uses Harmony patching to modify existing game behavior. The following conventions are used for Harmony patches:

- **Prefix**: A prefix patch is used to modify the behavior of a method before it is executed. Prefix patches return a boolean value that determines whether the original method should be executed.

- **Postfix**: A postfix patch is used to modify the behavior of a method after it is executed. Postfix patches can modify the return value of the method or access its parameters.

- **TargetMethod**: The `TargetMethod` attribute is used to specify the method that the patch should target. This attribute takes the form of a `MethodInfo` object, which can be obtained using reflection.

## Suggestions for Copilot

Here are some suggestions for using GitHub Copilot with the Secret Passage Doors (Continued) mod:

- **Use XML Templates**: Copilot can be used to generate XML templates for new game objects. For example, Copilot can generate a template for a new `ThingDef` element that includes all the necessary attributes and elements.

- **Generate Harmony Patches**: Copilot can be used to generate Harmony patches for modifying existing game behavior. For example, Copilot can generate a prefix patch for a method that returns a boolean value, which can be used to modify the behavior of the method.

- **Auto-complete C# Code**: Copilot can be used to auto-complete C# code for new classes and methods. For example, Copilot can generate a class that inherits from `Building_Door` and includes the necessary fields and methods.

- **Generate XML Documentation**: Copilot can be used to generate XML documentation for new game objects. For example, Copilot can generate documentation for a new `ThingDef` element, which includes the object's attributes and elements.

- **Code Review**: Copilot can be used to review code for errors and bugs. For example, Copilot can identify unused variables, missing semicolons, and other common mistakes.

By following these conventions and suggestions, you can use GitHub Copilot to streamline your mod development process and create high-quality mods for RimWorld.

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
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

