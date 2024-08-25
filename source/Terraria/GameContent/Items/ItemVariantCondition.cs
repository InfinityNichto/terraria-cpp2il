using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	[global::Cpp2ILInjected.Token(Token = "0x2000865")]
	public class ItemVariantCondition
	{
		[global::Cpp2ILInjected.Token(Token = "0x60043A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A48B8", Offset = "0x7A48B8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemVariantCondition(NetworkText description, ItemVariantCondition.Condition condition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60043A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A48E4", Offset = "0x7A48E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly NetworkText Description;

		[global::Cpp2ILInjected.Token(Token = "0x4008199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly ItemVariantCondition.Condition IsMet;

		[global::Cpp2ILInjected.Token(Token = "0x2000866")]
		public delegate bool Condition();
	}
}
