using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000649")]
public class NPCStatsReportInfoElement : IBestiaryInfoElement, IUpdateBeforeSorting
{
	[Cpp2IlInjected.Token(Token = "0x2000A1F")]
	public delegate void StatAdjustmentStep(NPCStatsReportInfoElement element);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C8D")]
	public int NpcId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C8E")]
	public int Damage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C8F")]
	public int LifeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006C90")]
	public float MonetaryValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006C91")]
	public int Defense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006C92")]
	public float KnockbackResist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006C93")]
	public NPC _instance;

	[Cpp2IlInjected.Token(Token = "0x1400004F")]
	public event StatAdjustmentStep OnRefreshStats
	{
		[Cpp2IlInjected.Token(Token = "0x6003F4F")]
		[Cpp2IlInjected.Address(RVA = "0x10FFD34", Offset = "0x10FFD34", VA = "0x10FFD34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003F50")]
		[Cpp2IlInjected.Address(RVA = "0x10FFDE4", Offset = "0x10FFDE4", VA = "0x10FFDE4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F4E")]
	[Cpp2IlInjected.Address(RVA = "0x10F7D94", Offset = "0x10F7D94", VA = "0x10F7D94")]
	public NPCStatsReportInfoElement(int npcNetId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F51")]
	[Cpp2IlInjected.Address(RVA = "0x10FFE94", Offset = "0x10FFE94", VA = "0x10FFE94")]
	public void Refresh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F52")]
	[Cpp2IlInjected.Address(RVA = "0x10FFF70", Offset = "0x10FFF70", VA = "0x10FFF70", Slot = "5")]
	public void UpdateBeforeSorting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F53")]
	[Cpp2IlInjected.Address(RVA = "0x10FFCA4", Offset = "0x10FFCA4", VA = "0x10FFCA4")]
	private void RefreshStats(GameModeData gameModeFound, NPC instance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F54")]
	[Cpp2IlInjected.Address(RVA = "0x1100470", Offset = "0x1100470", VA = "0x1100470", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F55")]
	[Cpp2IlInjected.Address(RVA = "0x1101BDC", Offset = "0x1101BDC", VA = "0x1101BDC")]
	private void ShowStats_Attack(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F56")]
	[Cpp2IlInjected.Address(RVA = "0x1101CB8", Offset = "0x1101CB8", VA = "0x1101CB8")]
	private void ShowStats_Defense(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F57")]
	[Cpp2IlInjected.Address(RVA = "0x1101D94", Offset = "0x1101D94", VA = "0x1101D94")]
	private void ShowStats_Knockback(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F58")]
	[Cpp2IlInjected.Address(RVA = "0x1101E70", Offset = "0x1101E70", VA = "0x1101E70")]
	private void ShowStats_Life(UIElement element)
	{
	}
}
