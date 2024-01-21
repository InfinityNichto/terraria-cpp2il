using Cpp2IlInjected;
using Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

namespace Terraria.GameContent.LootSimulation;

[Cpp2IlInjected.Token(Token = "0x20005BB")]
public class SimulationConditionSetters
{
	[Cpp2IlInjected.Token(Token = "0x4006B68")]
	public static FastConditionSetter HardMode;

	[Cpp2IlInjected.Token(Token = "0x4006B69")]
	public static FastConditionSetter ExpertMode;

	[Cpp2IlInjected.Token(Token = "0x4006B6A")]
	public static FastConditionSetter Eclipse;

	[Cpp2IlInjected.Token(Token = "0x4006B6B")]
	public static FastConditionSetter BloodMoon;

	[Cpp2IlInjected.Token(Token = "0x4006B6C")]
	public static FastConditionSetter SlainMechBosses;

	[Cpp2IlInjected.Token(Token = "0x4006B6D")]
	public static FastConditionSetter SlainPlantera;

	[Cpp2IlInjected.Token(Token = "0x4006B6E")]
	public static StackedConditionSetter ExpertAndHardMode;

	[Cpp2IlInjected.Token(Token = "0x4006B6F")]
	public static FastConditionSetter WindyWeather;

	[Cpp2IlInjected.Token(Token = "0x4006B70")]
	public static FastConditionSetter MidDay;

	[Cpp2IlInjected.Token(Token = "0x4006B71")]
	public static FastConditionSetter MidNight;

	[Cpp2IlInjected.Token(Token = "0x4006B72")]
	public static FastConditionSetter SlimeRain;

	[Cpp2IlInjected.Token(Token = "0x4006B73")]
	public static StackedConditionSetter WindyExpertHardmodeEndgameEclipseMorning;

	[Cpp2IlInjected.Token(Token = "0x4006B74")]
	public static StackedConditionSetter WindyExpertHardmodeEndgameBloodMoonNight;

	[Cpp2IlInjected.Token(Token = "0x4006B75")]
	public static SlimeStaffConditionSetter SlimeStaffTest;

	[Cpp2IlInjected.Token(Token = "0x4006B76")]
	public static LuckyCoinConditionSetter LuckyCoinTest;

	[Cpp2IlInjected.Token(Token = "0x6003C72")]
	[Cpp2IlInjected.Address(RVA = "0x1056D10", Offset = "0x1056D10", VA = "0x1056D10")]
	public SimulationConditionSetters()
	{
	}
}
