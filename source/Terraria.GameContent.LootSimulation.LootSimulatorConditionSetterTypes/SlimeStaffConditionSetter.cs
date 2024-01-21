using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

[Cpp2IlInjected.Token(Token = "0x20005BE")]
public class SlimeStaffConditionSetter : ISimulationConditionSetter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B7A")]
	private int _timesToRun;

	[Cpp2IlInjected.Token(Token = "0x6003C7C")]
	[Cpp2IlInjected.Address(RVA = "0x10569BC", Offset = "0x10569BC", VA = "0x10569BC")]
	public SlimeStaffConditionSetter(int timesToRunMultiplier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C7D")]
	[Cpp2IlInjected.Address(RVA = "0x10569DC", Offset = "0x10569DC", VA = "0x10569DC", Slot = "4")]
	public int GetTimesToRunMultiplier(SimulatorInfo info)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C7E")]
	[Cpp2IlInjected.Address(RVA = "0x1056AE8", Offset = "0x1056AE8", VA = "0x1056AE8", Slot = "5")]
	public void Setup(SimulatorInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C7F")]
	[Cpp2IlInjected.Address(RVA = "0x1056AEC", Offset = "0x1056AEC", VA = "0x1056AEC", Slot = "6")]
	public void TearDown(SimulatorInfo info)
	{
	}
}
