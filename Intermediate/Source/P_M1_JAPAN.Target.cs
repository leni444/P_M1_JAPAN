using UnrealBuildTool;

public class P_M1_JAPANTarget : TargetRules
{
	public P_M1_JAPANTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("P_M1_JAPAN");
	}
}
