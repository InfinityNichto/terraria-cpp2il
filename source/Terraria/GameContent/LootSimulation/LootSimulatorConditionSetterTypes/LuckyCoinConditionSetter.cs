using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000863")]
	public class LuckyCoinConditionSetter : ISimulationConditionSetter
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3E34", Offset = "0x7A3E34", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LuckyCoinConditionSetter(int timesToRunMultiplier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4850", Offset = "0x7A4850", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4878", Offset = "0x7A4878", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A487C", Offset = "0x7A487C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008196")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _timesToRun;
	}
}
