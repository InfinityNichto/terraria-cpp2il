using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x020005BC RID: 1468
	[global::Cpp2ILInjected.Token(Token = "0x2000863")]
	public class LuckyCoinConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x06003C44 RID: 15428 RVA: 0x0002CC39 File Offset: 0x0002AE39
		[global::Cpp2ILInjected.Token(Token = "0x60043A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3E34", Offset = "0x7A3E34", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LuckyCoinConditionSetter(int timesToRunMultiplier)
		{
			throw null;
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		[global::Cpp2ILInjected.Token(Token = "0x60043A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4850", Offset = "0x7A4850", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x0002CC3F File Offset: 0x0002AE3F
		[global::Cpp2ILInjected.Token(Token = "0x60043A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4878", Offset = "0x7A4878", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x0002CC42 File Offset: 0x0002AE42
		[global::Cpp2ILInjected.Token(Token = "0x60043A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A487C", Offset = "0x7A487C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x04006B7A RID: 27514
		[global::Cpp2ILInjected.Token(Token = "0x4008196")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _timesToRun;
	}
}
