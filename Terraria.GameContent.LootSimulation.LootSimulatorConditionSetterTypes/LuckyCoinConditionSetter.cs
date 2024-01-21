using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

[Cpp2IlInjected.Token(Token = "0x20005BF")]
public class LuckyCoinConditionSetter : ISimulationConditionSetter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B7B")]
	private int _timesToRun;

	[Cpp2IlInjected.Token(Token = "0x6003C80")]
	[Cpp2IlInjected.Address(RVA = "0x1056970", Offset = "0x1056970", VA = "0x1056970")]
	public LuckyCoinConditionSetter(int timesToRunMultiplier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C81")]
	[Cpp2IlInjected.Address(RVA = "0x1056990", Offset = "0x1056990", VA = "0x1056990", Slot = "4")]
	public int GetTimesToRunMultiplier(SimulatorInfo info)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C82")]
	[Cpp2IlInjected.Address(RVA = "0x10569B4", Offset = "0x10569B4", VA = "0x10569B4", Slot = "5")]
	public void Setup(SimulatorInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C83")]
	[Cpp2IlInjected.Address(RVA = "0x10569B8", Offset = "0x10569B8", VA = "0x10569B8", Slot = "6")]
	public void TearDown(SimulatorInfo info)
	{
	}
}
