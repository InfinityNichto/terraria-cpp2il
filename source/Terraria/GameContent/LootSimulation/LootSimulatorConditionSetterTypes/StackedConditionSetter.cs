using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.LootSimulation.LootSimulatorConditionSetterTypes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000861")]
	public class StackedConditionSetter : ISimulationConditionSetter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004398")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A3DE4", Offset = "0x7A3DE4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public StackedConditionSetter(params ISimulationConditionSetter[] setters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004399")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A458C", Offset = "0x7A458C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Setup(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600439A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4668", Offset = "0x7A4668", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void TearDown(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600439B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4744", Offset = "0x7A4744", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetTimesToRunMultiplier(SimulatorInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008194")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ISimulationConditionSetter[] _setters;
	}
}
