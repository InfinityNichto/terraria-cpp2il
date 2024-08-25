using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000860")]
	public class FastConditionSetter : ISimulationConditionSetter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004394")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3DB8", Offset = "0x7A3DB8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FastConditionSetter(Action<SimulatorInfo> setup, Action<SimulatorInfo> tearDown)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004395")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A454C", Offset = "0x7A454C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004396")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4568", Offset = "0x7A4568", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004397")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4584", Offset = "0x7A4584", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008192")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Action<SimulatorInfo> _setup;

		[global::Cpp2ILInjected.Token(Token = "0x4008193")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Action<SimulatorInfo> _tearDown;
	}
}
