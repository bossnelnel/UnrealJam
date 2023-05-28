using UnrealBuildTool;

public class UnrealQuest5Jam : ModuleRules
{
	public UnrealQuest5Jam(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
