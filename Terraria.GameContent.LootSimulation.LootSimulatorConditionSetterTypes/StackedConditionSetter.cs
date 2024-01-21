using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes;

[Cpp2IlInjected.Token(Token = "0x20005BD")]
public class StackedConditionSetter : ISimulationConditionSetter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B79")]
	private ISimulationConditionSetter[] _setters;

	[Cpp2IlInjected.Token(Token = "0x6003C78")]
	[Cpp2IlInjected.Address(RVA = "0x1056AF0", Offset = "0x1056AF0", VA = "0x1056AF0")]
	public StackedConditionSetter(params ISimulationConditionSetter[] setters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C79")]
	[Cpp2IlInjected.Address(RVA = "0x1056B10", Offset = "0x1056B10", VA = "0x1056B10", Slot = "5")]
	public void Setup(SimulatorInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C7A")]
	[Cpp2IlInjected.Address(RVA = "0x1056C0C", Offset = "0x1056C0C", VA = "0x1056C0C", Slot = "6")]
	public void TearDown(SimulatorInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C7B")]
	[Cpp2IlInjected.Address(RVA = "0x1056D08", Offset = "0x1056D08", VA = "0x1056D08", Slot = "4")]
	public int GetTimesToRunMultiplier(SimulatorInfo info)
	{
		return default(int);
	}
}
