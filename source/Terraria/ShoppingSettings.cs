using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000423")]
	public struct ShoppingSettings
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4003399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public double PriceAdjustment;

		[global::Cpp2ILInjected.Token(Token = "0x400339A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string HappinessReport;
	}
}
