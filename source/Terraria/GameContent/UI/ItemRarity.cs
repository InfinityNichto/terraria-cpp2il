using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A61")]
	public class ItemRarity
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004E82")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E2F94", Offset = "0x8E2F94", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Color>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Color>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004E83")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E31D4", Offset = "0x8E31D4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.ItemTagHandler.ItemSnippet", Member = ".ctor", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Color>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Color>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Color GetColor(int rarity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004E84")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E32F0", Offset = "0x8E32F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemRarity()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004E85")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E32F8", Offset = "0x8E32F8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, Color>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ItemRarity()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40087A7")]
		private static Dictionary<int, Color> _rarities;
	}
}
