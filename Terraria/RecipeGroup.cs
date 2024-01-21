using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000343")]
public class RecipeGroup
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002EF3")]
	public Func<string> GetText;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002EF4")]
	public HashSet<int> ValidItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002EF5")]
	public int IconicItemId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002EF6")]
	public int RegisteredId;

	[Cpp2IlInjected.Token(Token = "0x4002EF7")]
	public static Dictionary<int, RecipeGroup> recipeGroups;

	[Cpp2IlInjected.Token(Token = "0x4002EF8")]
	public static Dictionary<string, int> recipeGroupIDs;

	[Cpp2IlInjected.Token(Token = "0x4002EF9")]
	public static int nextRecipeGroupIndex;

	[Cpp2IlInjected.Token(Token = "0x600271D")]
	[Cpp2IlInjected.Address(RVA = "0x14DABCC", Offset = "0x14DABCC", VA = "0x14DABCC")]
	public RecipeGroup(Func<string> getName, params int[] validItems)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600271E")]
	[Cpp2IlInjected.Address(RVA = "0x14DAC68", Offset = "0x14DAC68", VA = "0x14DAC68")]
	public static int RegisterGroup(string name, RecipeGroup rec)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600271F")]
	[Cpp2IlInjected.Address(RVA = "0x14DAD44", Offset = "0x14DAD44", VA = "0x14DAD44")]
	public int CountUsableItems(Dictionary<int, int> itemStacksAvailable)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002720")]
	[Cpp2IlInjected.Address(RVA = "0x14DAE8C", Offset = "0x14DAE8C", VA = "0x14DAE8C")]
	public int GetGroupFakeItemId()
	{
		return default(int);
	}
}
