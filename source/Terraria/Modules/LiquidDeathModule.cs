using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Modules
{
	[global::Cpp2ILInjected.Token(Token = "0x2000548")]
	public class LiquidDeathModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x60032EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x133001C", Offset = "0x133001C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LiquidDeathModule(LiquidDeathModule copyFrom = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003BE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool water;

		[global::Cpp2ILInjected.Token(Token = "0x4003BE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		public bool lava;
	}
}
