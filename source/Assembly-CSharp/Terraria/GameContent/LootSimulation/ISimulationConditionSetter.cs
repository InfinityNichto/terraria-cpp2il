using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.LootSimulation
{
	// Token: 0x020005B7 RID: 1463
	[global::Cpp2ILInjected.Token(Token = "0x200085D")]
	public interface ISimulationConditionSetter
	{
		// Token: 0x06003C33 RID: 15411
		[global::Cpp2ILInjected.Token(Token = "0x6004379")]
		int GetTimesToRunMultiplier(SimulatorInfo info);

		// Token: 0x06003C34 RID: 15412
		[global::Cpp2ILInjected.Token(Token = "0x600437A")]
		void Setup(SimulatorInfo info);

		// Token: 0x06003C35 RID: 15413
		[global::Cpp2ILInjected.Token(Token = "0x600437B")]
		void TearDown(SimulatorInfo info);
	}
}
