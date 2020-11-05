using UnrealBuildTool;

public class BloodAscentTarget : TargetRules
{
	public BloodAscentTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("BloodAscent");
	}
}
