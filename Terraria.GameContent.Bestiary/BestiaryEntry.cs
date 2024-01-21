using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000620")]
public class BestiaryEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C4A")]
	public IEntryIcon Icon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C4C")]
	public IBestiaryUICollectionInfoProvider UIInfoProvider;

	[Cpp2IlInjected.Token(Token = "0x17000768")]
	public List<IBestiaryInfoElement> Info
	{
		[Cpp2IlInjected.Token(Token = "0x6003EB6")]
		[Cpp2IlInjected.Address(RVA = "0x10F76B0", Offset = "0x10F76B0", VA = "0x10F76B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003EB7")]
		[Cpp2IlInjected.Address(RVA = "0x10F76B8", Offset = "0x10F76B8", VA = "0x10F76B8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB8")]
	[Cpp2IlInjected.Address(RVA = "0x10F76C0", Offset = "0x10F76C0", VA = "0x10F76C0")]
	public BestiaryEntry()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EB9")]
	[Cpp2IlInjected.Address(RVA = "0x10F7744", Offset = "0x10F7744", VA = "0x10F7744")]
	public static BestiaryEntry Enemy(int npcNetId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EBA")]
	[Cpp2IlInjected.Address(RVA = "0x10F8038", Offset = "0x10F8038", VA = "0x10F8038")]
	public static BestiaryEntry TownNPC(int npcNetId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EBB")]
	[Cpp2IlInjected.Address(RVA = "0x10F83D4", Offset = "0x10F83D4", VA = "0x10F83D4")]
	public static BestiaryEntry Critter(int npcNetId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EBC")]
	[Cpp2IlInjected.Address(RVA = "0x10F8770", Offset = "0x10F8770", VA = "0x10F8770")]
	public static BestiaryEntry Biome(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EBD")]
	[Cpp2IlInjected.Address(RVA = "0x10F8998", Offset = "0x10F8998", VA = "0x10F8998")]
	public void AddTags(params IBestiaryInfoElement[] elements)
	{
	}
}
