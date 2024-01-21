using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000646")]
public class NPCNetIdBestiaryInfoElement : IBestiaryInfoElement, IBestiaryEntryDisplayIndex
{
	[Cpp2IlInjected.Token(Token = "0x17000773")]
	public int NetId
	{
		[Cpp2IlInjected.Token(Token = "0x6003F40")]
		[Cpp2IlInjected.Address(RVA = "0x10FE698", Offset = "0x10FE698", VA = "0x10FE698")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F41")]
		[Cpp2IlInjected.Address(RVA = "0x10FE6A0", Offset = "0x10FE6A0", VA = "0x10FE6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000774")]
	public int BestiaryDisplayIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6003F44")]
		[Cpp2IlInjected.Address(RVA = "0x10FE6B0", Offset = "0x10FE6B0", VA = "0x10FE6B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F42")]
	[Cpp2IlInjected.Address(RVA = "0x10F7C3C", Offset = "0x10F7C3C", VA = "0x10F7C3C")]
	public NPCNetIdBestiaryInfoElement(int npcNetId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F43")]
	[Cpp2IlInjected.Address(RVA = "0x10FE6A8", Offset = "0x10FE6A8", VA = "0x10FE6A8", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
