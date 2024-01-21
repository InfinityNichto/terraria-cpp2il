using System;
using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

[Cpp2IlInjected.Token(Token = "0x20005BC")]
public class FastConditionSetter : ISimulationConditionSetter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B77")]
	private Action<SimulatorInfo> _setup;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B78")]
	private Action<SimulatorInfo> _tearDown;

	[Cpp2IlInjected.Token(Token = "0x6003C74")]
	[Cpp2IlInjected.Address(RVA = "0x1056860", Offset = "0x1056860", VA = "0x1056860")]
	public FastConditionSetter(Action<SimulatorInfo> setup, Action<SimulatorInfo> tearDown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C75")]
	[Cpp2IlInjected.Address(RVA = "0x1056888", Offset = "0x1056888", VA = "0x1056888", Slot = "5")]
	public void Setup(SimulatorInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C76")]
	[Cpp2IlInjected.Address(RVA = "0x10568F8", Offset = "0x10568F8", VA = "0x10568F8", Slot = "6")]
	public void TearDown(SimulatorInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C77")]
	[Cpp2IlInjected.Address(RVA = "0x1056968", Offset = "0x1056968", VA = "0x1056968", Slot = "4")]
	public int GetTimesToRunMultiplier(SimulatorInfo info)
	{
		return default(int);
	}
}
