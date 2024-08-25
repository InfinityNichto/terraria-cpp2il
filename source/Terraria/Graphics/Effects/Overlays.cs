using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Graphics.Effects
{
	[global::Cpp2ILInjected.Token(Token = "0x200077F")]
	public static class Overlays
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003EDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x74090C", Offset = "0x74090C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverlayManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Overlays()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007D71")]
		public static OverlayManager Scene;
	}
}
