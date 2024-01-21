using Cpp2IlInjected;

namespace Terraria.GameContent.LootSimulation;

[Cpp2IlInjected.Token(Token = "0x20005BA")]
public interface ISimulationConditionSetter
{
	[Cpp2IlInjected.Token(Token = "0x6003C6F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetTimesToRunMultiplier(SimulatorInfo info);

	[Cpp2IlInjected.Token(Token = "0x6003C70")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Setup(SimulatorInfo info);

	[Cpp2IlInjected.Token(Token = "0x6003C71")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TearDown(SimulatorInfo info);
}
