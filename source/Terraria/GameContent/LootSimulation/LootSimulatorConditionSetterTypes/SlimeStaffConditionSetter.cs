using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000862")]
	public class SlimeStaffConditionSetter : ISimulationConditionSetter
	{
		[global::Cpp2ILInjected.Token(Token = "0x600439C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3E0C", Offset = "0x7A3E0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SlimeStaffConditionSetter(int timesToRunMultiplier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600439D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A474C", Offset = "0x7A474C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600439E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4848", Offset = "0x7A4848", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600439F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A484C", Offset = "0x7A484C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008195")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _timesToRun;
	}
}
