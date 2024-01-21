using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005E3")]
public class ItemDropDatabase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BC7")]
	private List<IItemDropRule> _globalEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BC8")]
	private Dictionary<int, List<IItemDropRule>> _entriesByNpcNetId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BC9")]
	private Dictionary<int, List<int>> _npcNetIdsByType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006BCA")]
	private int _masterModeDropRng;

	[Cpp2IlInjected.Token(Token = "0x6003D1E")]
	[Cpp2IlInjected.Address(RVA = "0xE792D8", Offset = "0xE792D8", VA = "0xE792D8")]
	public void PrepareNPCNetIDsByTypeDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D1F")]
	[Cpp2IlInjected.Address(RVA = "0xE79748", Offset = "0xE79748", VA = "0xE79748")]
	public void TrimDuplicateRulesForNegativeIDs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D20")]
	[Cpp2IlInjected.Address(RVA = "0xE79824", Offset = "0xE79824", VA = "0xE79824")]
	public List<IItemDropRule> GetRulesForNPCID(int npcNetId, bool includeGlobalDrops = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D21")]
	[Cpp2IlInjected.Address(RVA = "0xE7991C", Offset = "0xE7991C", VA = "0xE7991C")]
	public IItemDropRule RegisterToGlobal(IItemDropRule entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D22")]
	[Cpp2IlInjected.Address(RVA = "0xE79984", Offset = "0xE79984", VA = "0xE79984")]
	public IItemDropRule RegisterToNPC(int type, IItemDropRule entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D23")]
	[Cpp2IlInjected.Address(RVA = "0xE79A74", Offset = "0xE79A74", VA = "0xE79A74")]
	private void RegisterToNPCNetId(int npcNetId, IItemDropRule entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D24")]
	[Cpp2IlInjected.Address(RVA = "0xE79B6C", Offset = "0xE79B6C", VA = "0xE79B6C")]
	public IItemDropRule RegisterToMultipleNPCs(IItemDropRule entry, params int[] npcNetIds)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D25")]
	[Cpp2IlInjected.Address(RVA = "0xE79BBC", Offset = "0xE79BBC", VA = "0xE79BBC")]
	public IItemDropRule RegisterToMultipleNPCsNotRemixSeed(IItemDropRule entry, params int[] npcNetIds)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D26")]
	[Cpp2IlInjected.Address(RVA = "0xE79CA4", Offset = "0xE79CA4", VA = "0xE79CA4")]
	public IItemDropRule RegisterToMultipleNPCsRemixSeed(IItemDropRule entry, params int[] npcNetIds)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D27")]
	[Cpp2IlInjected.Address(RVA = "0xE79D8C", Offset = "0xE79D8C", VA = "0xE79D8C")]
	private void RemoveFromNPCNetId(int npcNetId, IItemDropRule entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D28")]
	[Cpp2IlInjected.Address(RVA = "0xE79E30", Offset = "0xE79E30", VA = "0xE79E30")]
	public IItemDropRule RemoveFromNPC(int type, IItemDropRule entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D29")]
	[Cpp2IlInjected.Address(RVA = "0xE79F20", Offset = "0xE79F20", VA = "0xE79F20")]
	public IItemDropRule RemoveFromMultipleNPCs(IItemDropRule entry, params int[] npcNetIds)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003D2A")]
	[Cpp2IlInjected.Address(RVA = "0xE79F70", Offset = "0xE79F70", VA = "0xE79F70")]
	public void Populate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D2B")]
	[Cpp2IlInjected.Address(RVA = "0xE832A4", Offset = "0xE832A4", VA = "0xE832A4")]
	private void RegisterBloodMoonFishing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D2C")]
	[Cpp2IlInjected.Address(RVA = "0xE82BC8", Offset = "0xE82BC8", VA = "0xE82BC8")]
	private void RegisterEclipse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D2D")]
	[Cpp2IlInjected.Address(RVA = "0xE827BC", Offset = "0xE827BC", VA = "0xE827BC")]
	private void RegisterMimic()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D2E")]
	[Cpp2IlInjected.Address(RVA = "0xE82334", Offset = "0xE82334", VA = "0xE82334")]
	private void RegisterHardmodeDungeonDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D2F")]
	[Cpp2IlInjected.Address(RVA = "0xE82278", Offset = "0xE82278", VA = "0xE82278")]
	private void RegisterBosses()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D30")]
	[Cpp2IlInjected.Address(RVA = "0xE87674", Offset = "0xE87674", VA = "0xE87674")]
	private void RegisterBoss_QueenSlime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D31")]
	[Cpp2IlInjected.Address(RVA = "0xE873E0", Offset = "0xE873E0", VA = "0xE873E0")]
	private void RegisterBoss_HallowBoss()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D32")]
	[Cpp2IlInjected.Address(RVA = "0xE869EC", Offset = "0xE869EC", VA = "0xE869EC")]
	private void RegisterBoss_PumpkinMoon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D33")]
	[Cpp2IlInjected.Address(RVA = "0xE864CC", Offset = "0xE864CC", VA = "0xE864CC")]
	private void RegisterBoss_FrostMoon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D34")]
	[Cpp2IlInjected.Address(RVA = "0xE862AC", Offset = "0xE862AC", VA = "0xE862AC")]
	private void RegisterBoss_KingSlime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D35")]
	[Cpp2IlInjected.Address(RVA = "0xE85DCC", Offset = "0xE85DCC", VA = "0xE85DCC")]
	private void RegisterBoss_Plantera()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D36")]
	[Cpp2IlInjected.Address(RVA = "0xE857CC", Offset = "0xE857CC", VA = "0xE857CC")]
	private void RegisterBoss_SkeletronPrime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D37")]
	[Cpp2IlInjected.Address(RVA = "0xE85978", Offset = "0xE85978", VA = "0xE85978")]
	private void RegisterBoss_TheDestroyer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D38")]
	[Cpp2IlInjected.Address(RVA = "0xE85B24", Offset = "0xE85B24", VA = "0xE85B24")]
	private void RegisterBoss_Twins()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D39")]
	[Cpp2IlInjected.Address(RVA = "0xE838D0", Offset = "0xE838D0", VA = "0xE838D0")]
	private void RegisterBoss_EOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D3A")]
	[Cpp2IlInjected.Address(RVA = "0xE83B34", Offset = "0xE83B34", VA = "0xE83B34")]
	private void RegisterBoss_BOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D3B")]
	[Cpp2IlInjected.Address(RVA = "0xE83DF8", Offset = "0xE83DF8", VA = "0xE83DF8")]
	private void RegisterBoss_EOW()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D3C")]
	[Cpp2IlInjected.Address(RVA = "0xE87890", Offset = "0xE87890", VA = "0xE87890")]
	private void RegisterBoss_Deerclops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D3D")]
	[Cpp2IlInjected.Address(RVA = "0xE84234", Offset = "0xE84234", VA = "0xE84234")]
	private void RegisterBoss_QueenBee()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D3E")]
	[Cpp2IlInjected.Address(RVA = "0xE8453C", Offset = "0xE8453C", VA = "0xE8453C")]
	private void RegisterBoss_Skeletron()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D3F")]
	[Cpp2IlInjected.Address(RVA = "0xE846B4", Offset = "0xE846B4", VA = "0xE846B4")]
	private void RegisterBoss_WOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D40")]
	[Cpp2IlInjected.Address(RVA = "0xE848E8", Offset = "0xE848E8", VA = "0xE848E8")]
	private void RegisterBoss_AncientCultist()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D41")]
	[Cpp2IlInjected.Address(RVA = "0xE84990", Offset = "0xE84990", VA = "0xE84990")]
	private void RegisterBoss_MoonLord()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D42")]
	[Cpp2IlInjected.Address(RVA = "0xE84BC0", Offset = "0xE84BC0", VA = "0xE84BC0")]
	private void RegisterBoss_LunarTowers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D43")]
	[Cpp2IlInjected.Address(RVA = "0xE84F10", Offset = "0xE84F10", VA = "0xE84F10")]
	private void RegisterBoss_Betsy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D44")]
	[Cpp2IlInjected.Address(RVA = "0xE850CC", Offset = "0xE850CC", VA = "0xE850CC")]
	private void RegisterBoss_Golem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D45")]
	[Cpp2IlInjected.Address(RVA = "0xE85500", Offset = "0xE85500", VA = "0xE85500")]
	private void RegisterBoss_DukeFishron()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D46")]
	[Cpp2IlInjected.Address(RVA = "0xE7AEC8", Offset = "0xE7AEC8", VA = "0xE7AEC8")]
	private void RegisterWeirdRules()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D47")]
	[Cpp2IlInjected.Address(RVA = "0xE7A014", Offset = "0xE7A014", VA = "0xE7A014")]
	private void RegisterGlobalRules()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D48")]
	[Cpp2IlInjected.Address(RVA = "0xE7A4FC", Offset = "0xE7A4FC", VA = "0xE7A4FC")]
	private void RegisterFoodDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D49")]
	[Cpp2IlInjected.Address(RVA = "0xE7AF7C", Offset = "0xE7AF7C", VA = "0xE7AF7C")]
	private void RegisterTownNPCDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D4A")]
	[Cpp2IlInjected.Address(RVA = "0xE7B2CC", Offset = "0xE7B2CC", VA = "0xE7B2CC")]
	private void RegisterDD2EventDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D4B")]
	[Cpp2IlInjected.Address(RVA = "0xE80190", Offset = "0xE80190", VA = "0xE80190")]
	private void RegisterHardmodeFeathers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D4C")]
	[Cpp2IlInjected.Address(RVA = "0xE80408", Offset = "0xE80408", VA = "0xE80408")]
	private void RegisterYoyos()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D4D")]
	[Cpp2IlInjected.Address(RVA = "0xE805F8", Offset = "0xE805F8", VA = "0xE805F8")]
	private void RegisterStatusImmunityItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D4E")]
	[Cpp2IlInjected.Address(RVA = "0xE80A50", Offset = "0xE80A50", VA = "0xE80A50")]
	private void RegisterPirateDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D4F")]
	[Cpp2IlInjected.Address(RVA = "0xE8180C", Offset = "0xE8180C", VA = "0xE8180C")]
	private void RegisterBloodMoonFishingEnemies()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D50")]
	[Cpp2IlInjected.Address(RVA = "0xE81D04", Offset = "0xE81D04", VA = "0xE81D04")]
	private void RegisterBossTrophies()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D51")]
	[Cpp2IlInjected.Address(RVA = "0xE81810", Offset = "0xE81810", VA = "0xE81810")]
	private void RegisterMartianDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D52")]
	[Cpp2IlInjected.Address(RVA = "0xE7B87C", Offset = "0xE7B87C", VA = "0xE7B87C")]
	private void RegisterMiscDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D53")]
	[Cpp2IlInjected.Address(RVA = "0xE87B54", Offset = "0xE87B54", VA = "0xE87B54")]
	public ItemDropDatabase()
	{
	}
}
