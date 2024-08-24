using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x020005BA RID: 1466
	[global::Cpp2ILInjected.Token(Token = "0x2000861")]
	public class StackedConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x06003C3C RID: 15420 RVA: 0x0002CC21 File Offset: 0x0002AE21
		[global::Cpp2ILInjected.Token(Token = "0x6004398")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3DE4", Offset = "0x7A3DE4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StackedConditionSetter(params ISimulationConditionSetter[] setters)
		{
			throw null;
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0002CC24 File Offset: 0x0002AE24
		[global::Cpp2ILInjected.Token(Token = "0x6004399")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A458C", Offset = "0x7A458C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0002CC27 File Offset: 0x0002AE27
		[global::Cpp2ILInjected.Token(Token = "0x600439A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4668", Offset = "0x7A4668", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x0002CC2A File Offset: 0x0002AE2A
		[global::Cpp2ILInjected.Token(Token = "0x600439B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4744", Offset = "0x7A4744", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x04006B78 RID: 27512
		[global::Cpp2ILInjected.Token(Token = "0x4008194")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ISimulationConditionSetter[] _setters;
	}
}
