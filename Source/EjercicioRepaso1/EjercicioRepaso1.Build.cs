// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EjercicioRepaso1 : ModuleRules
{
	public EjercicioRepaso1(ReadOnlyTargetRules Target) : base(Target)
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
			"EjercicioRepaso1",
			"EjercicioRepaso1/Variant_Platforming",
			"EjercicioRepaso1/Variant_Platforming/Animation",
			"EjercicioRepaso1/Variant_Combat",
			"EjercicioRepaso1/Variant_Combat/AI",
			"EjercicioRepaso1/Variant_Combat/Animation",
			"EjercicioRepaso1/Variant_Combat/Gameplay",
			"EjercicioRepaso1/Variant_Combat/Interfaces",
			"EjercicioRepaso1/Variant_Combat/UI",
			"EjercicioRepaso1/Variant_SideScrolling",
			"EjercicioRepaso1/Variant_SideScrolling/AI",
			"EjercicioRepaso1/Variant_SideScrolling/Gameplay",
			"EjercicioRepaso1/Variant_SideScrolling/Interfaces",
			"EjercicioRepaso1/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
