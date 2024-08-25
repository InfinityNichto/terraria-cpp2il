using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	[global::Cpp2ILInjected.Token(Token = "0x2000864")]
	public class ItemVariant
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A4880", Offset = "0x7A4880", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemVariant(NetworkText description)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A48A8", Offset = "0x7A48A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly NetworkText Description;
	}
}
