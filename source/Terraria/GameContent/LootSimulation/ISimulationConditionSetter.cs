using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.LootSimulation
{
	[global::Cpp2ILInjected.Token(Token = "0x200085D")]
	public interface ISimulationConditionSetter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004379")]
		int GetTimesToRunMultiplier(SimulatorInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x600437A")]
		void Setup(SimulatorInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x600437B")]
		void TearDown(SimulatorInfo info);
	}
}
