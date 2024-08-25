using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Enums;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000549")]
	public class LiquidPlacementModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13302A8", Offset = "0x13302A8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LiquidPlacementModule(LiquidPlacementModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public LiquidPlacement water;

		[global::Cpp2ILInjected.Token(Token = "0x4003BE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public LiquidPlacement lava;
	}
}
