using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	// Token: 0x02000323 RID: 803
	[global::Cpp2ILInjected.Token(Token = "0x2000423")]
	public struct ShoppingSettings
	{
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x00028A75 File Offset: 0x00026C75
		[global::Cpp2ILInjected.Token(Token = "0x1700055B")]
		public static ShoppingSettings NotInShop
		{
			[global::Cpp2ILInjected.Token(Token = "0x600275F")]
			[global::Cpp2ILInjected.Address(RVA = "0x10C5F5C", Offset = "0x10C5F5C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetTalkNPC", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04002C7D RID: 11389
		[global::Cpp2ILInjected.Token(Token = "0x4003399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public double PriceAdjustment;

		// Token: 0x04002C7E RID: 11390
		[global::Cpp2ILInjected.Token(Token = "0x400339A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string HappinessReport;
	}
}
