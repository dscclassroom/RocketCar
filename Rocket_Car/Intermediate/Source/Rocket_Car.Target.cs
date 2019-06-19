using UnrealBuildTool;

public class Rocket_CarTarget : TargetRules
{
	public Rocket_CarTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Rocket_Car");
	}
}
