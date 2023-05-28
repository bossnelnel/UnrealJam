using UnrealBuildTool;

public class UnrealQuest5JamTarget : TargetRules
{
	public UnrealQuest5JamTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("UnrealQuest5Jam");
	}
}
