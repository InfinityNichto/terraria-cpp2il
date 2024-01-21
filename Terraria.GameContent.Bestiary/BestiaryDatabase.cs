using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.GameContent.ItemDropRules;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000615")]
public class BestiaryDatabase
{
	[Cpp2IlInjected.Token(Token = "0x2000A06")]
	public delegate void BestiaryEntriesPass(BestiaryEntry entry);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C36")]
	private List<BestiaryEntry> _entries;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C37")]
	private List<IBestiaryEntryFilter> _filters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C38")]
	private List<IBestiarySortStep> _sortSteps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006C39")]
	private Dictionary<int, BestiaryEntry> _byNpcId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006C3A")]
	private BestiaryEntry _trashEntry;

	[Cpp2IlInjected.Token(Token = "0x17000762")]
	public List<BestiaryEntry> Entries
	{
		[Cpp2IlInjected.Token(Token = "0x6003E6C")]
		[Cpp2IlInjected.Address(RVA = "0xFB7CFC", Offset = "0xFB7CFC", VA = "0xFB7CFC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000763")]
	public List<IBestiaryEntryFilter> Filters
	{
		[Cpp2IlInjected.Token(Token = "0x6003E6D")]
		[Cpp2IlInjected.Address(RVA = "0xFB7D04", Offset = "0xFB7D04", VA = "0xFB7D04")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000764")]
	public List<IBestiarySortStep> SortSteps
	{
		[Cpp2IlInjected.Token(Token = "0x6003E6E")]
		[Cpp2IlInjected.Address(RVA = "0xFB7D0C", Offset = "0xFB7D0C", VA = "0xFB7D0C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003E6F")]
	[Cpp2IlInjected.Address(RVA = "0xFB7D14", Offset = "0xFB7D14", VA = "0xFB7D14")]
	public BestiaryEntry Register(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E70")]
	[Cpp2IlInjected.Address(RVA = "0xFB7E20", Offset = "0xFB7E20", VA = "0xFB7E20")]
	public IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E71")]
	[Cpp2IlInjected.Address(RVA = "0xFB7E88", Offset = "0xFB7E88", VA = "0xFB7E88")]
	public IBestiarySortStep Register(IBestiarySortStep sortStep)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E72")]
	[Cpp2IlInjected.Address(RVA = "0xFB7EF0", Offset = "0xFB7EF0", VA = "0xFB7EF0")]
	public BestiaryEntry FindEntryByNPCID(int npcNetId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E73")]
	[Cpp2IlInjected.Address(RVA = "0xFB7F98", Offset = "0xFB7F98", VA = "0xFB7F98")]
	public void Merge(ItemDropDatabase dropsDatabase)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E74")]
	[Cpp2IlInjected.Address(RVA = "0xFB7FCC", Offset = "0xFB7FCC", VA = "0xFB7FCC")]
	private void ExtractDropsForNPC(ItemDropDatabase dropsDatabase, int npcId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E75")]
	[Cpp2IlInjected.Address(RVA = "0xFB8308", Offset = "0xFB8308", VA = "0xFB8308")]
	public void ApplyPass(BestiaryEntriesPass pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E76")]
	[Cpp2IlInjected.Address(RVA = "0xFB87C0", Offset = "0xFB87C0", VA = "0xFB87C0")]
	public BestiaryDatabase()
	{
	}
}
