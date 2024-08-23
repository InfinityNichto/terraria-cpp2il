using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;

namespace Terraria.GameContent.Items
{
	// Token: 0x020005BE RID: 1470
	[global::Cpp2ILInjected.Token(Token = "0x2000865")]
	public class ItemVariantCondition
	{
		// Token: 0x06003C4A RID: 15434 RVA: 0x0002CC4B File Offset: 0x0002AE4B
		[global::Cpp2ILInjected.Token(Token = "0x60043A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A48B8", Offset = "0x7A48B8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemVariantCondition(NetworkText description, ItemVariantCondition.Condition condition)
		{
			throw null;
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x0002CC4E File Offset: 0x0002AE4E
		[global::Cpp2ILInjected.Token(Token = "0x60043A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A48E4", Offset = "0x7A48E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04006B7C RID: 27516
		[global::Cpp2ILInjected.Token(Token = "0x4008198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly NetworkText Description;

		// Token: 0x04006B7D RID: 27517
		[global::Cpp2ILInjected.Token(Token = "0x4008199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly ItemVariantCondition.Condition IsMet;

		// Token: 0x020009B2 RID: 2482
		// (Invoke) Token: 0x06004E32 RID: 20018
		[global::Cpp2ILInjected.Token(Token = "0x2000866")]
		public delegate bool Condition();
	}
}
