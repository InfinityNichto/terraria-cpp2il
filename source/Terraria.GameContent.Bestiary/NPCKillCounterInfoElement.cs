using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000648")]
public class NPCKillCounterInfoElement : IBestiaryInfoElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C8C")]
	private NPC _instance;

	[Cpp2IlInjected.Token(Token = "0x6003F4A")]
	[Cpp2IlInjected.Address(RVA = "0x10F7CAC", Offset = "0x10F7CAC", VA = "0x10F7CAC")]
	public NPCKillCounterInfoElement(int npcNetId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F4B")]
	[Cpp2IlInjected.Address(RVA = "0x10FDBCC", Offset = "0x10FDBCC", VA = "0x10FDBCC", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F4C")]
	[Cpp2IlInjected.Address(RVA = "0x10FE240", Offset = "0x10FE240", VA = "0x10FE240")]
	private void ShowDescription(UIElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F4D")]
	[Cpp2IlInjected.Address(RVA = "0x10FE17C", Offset = "0x10FE17C", VA = "0x10FE17C")]
	private int? GetKillCount()
	{
		return null;
	}
}
