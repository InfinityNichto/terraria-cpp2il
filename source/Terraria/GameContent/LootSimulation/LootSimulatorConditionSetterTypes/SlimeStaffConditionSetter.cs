using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x020005BB RID: 1467
	[global::Cpp2ILInjected.Token(Token = "0x2000862")]
	public class SlimeStaffConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x06003C40 RID: 15424 RVA: 0x0002CC2D File Offset: 0x0002AE2D
		[global::Cpp2ILInjected.Token(Token = "0x600439C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3E0C", Offset = "0x7A3E0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SlimeStaffConditionSetter(int timesToRunMultiplier)
		{
			throw null;
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0002CC30 File Offset: 0x0002AE30
		[global::Cpp2ILInjected.Token(Token = "0x600439D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A474C", Offset = "0x7A474C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x0002CC33 File Offset: 0x0002AE33
		[global::Cpp2ILInjected.Token(Token = "0x600439E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4848", Offset = "0x7A4848", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0002CC36 File Offset: 0x0002AE36
		[global::Cpp2ILInjected.Token(Token = "0x600439F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A484C", Offset = "0x7A484C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x04006B79 RID: 27513
		[global::Cpp2ILInjected.Token(Token = "0x4008195")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _timesToRun;
	}
}
