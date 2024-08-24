using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	// Token: 0x020005B9 RID: 1465
	[global::Cpp2ILInjected.Token(Token = "0x2000860")]
	public class FastConditionSetter : ISimulationConditionSetter
	{
		// Token: 0x06003C38 RID: 15416 RVA: 0x0002CC15 File Offset: 0x0002AE15
		[global::Cpp2ILInjected.Token(Token = "0x6004394")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3DB8", Offset = "0x7A3DB8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FastConditionSetter(Action<SimulatorInfo> setup, Action<SimulatorInfo> tearDown)
		{
			throw null;
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x0002CC18 File Offset: 0x0002AE18
		[global::Cpp2ILInjected.Token(Token = "0x6004395")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A454C", Offset = "0x7A454C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0002CC1B File Offset: 0x0002AE1B
		[global::Cpp2ILInjected.Token(Token = "0x6004396")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4568", Offset = "0x7A4568", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x0002CC1E File Offset: 0x0002AE1E
		[global::Cpp2ILInjected.Token(Token = "0x6004397")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4584", Offset = "0x7A4584", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		// Token: 0x04006B76 RID: 27510
		[global::Cpp2ILInjected.Token(Token = "0x4008192")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Action<SimulatorInfo> _setup;

		// Token: 0x04006B77 RID: 27511
		[global::Cpp2ILInjected.Token(Token = "0x4008193")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Action<SimulatorInfo> _tearDown;
	}
}
