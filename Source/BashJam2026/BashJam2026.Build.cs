// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BashJam2026 : ModuleRules
{
	public BashJam2026(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"BashJam2026",
			"BashJam2026/Variant_Platforming",
			"BashJam2026/Variant_Platforming/Animation",
			"BashJam2026/Variant_Combat",
			"BashJam2026/Variant_Combat/AI",
			"BashJam2026/Variant_Combat/Animation",
			"BashJam2026/Variant_Combat/Gameplay",
			"BashJam2026/Variant_Combat/Interfaces",
			"BashJam2026/Variant_Combat/UI",
			"BashJam2026/Variant_SideScrolling",
			"BashJam2026/Variant_SideScrolling/AI",
			"BashJam2026/Variant_SideScrolling/Gameplay",
			"BashJam2026/Variant_SideScrolling/Interfaces",
			"BashJam2026/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
