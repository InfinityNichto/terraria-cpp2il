using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000634")]
public class RareSpawnBestiaryInfoElement : IBestiaryInfoElement, IProvideSearchFilterString
{
	[Cpp2IlInjected.Token(Token = "0x1700076B")]
	public int RarityLevel
	{
		[Cpp2IlInjected.Token(Token = "0x6003EF4")]
		[Cpp2IlInjected.Address(RVA = "0x11029DC", Offset = "0x11029DC", VA = "0x11029DC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003EF5")]
		[Cpp2IlInjected.Address(RVA = "0x11029E4", Offset = "0x11029E4", VA = "0x11029E4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF6")]
	[Cpp2IlInjected.Address(RVA = "0x10F7EA8", Offset = "0x10F7EA8", VA = "0x10F7EA8")]
	public RareSpawnBestiaryInfoElement(int rarityLevel)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF7")]
	[Cpp2IlInjected.Address(RVA = "0x11029EC", Offset = "0x11029EC", VA = "0x11029EC", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF8")]
	[Cpp2IlInjected.Address(RVA = "0x11029F4", Offset = "0x11029F4", VA = "0x11029F4", Slot = "5")]
	public string GetSearchString(ref BestiaryUICollectionInfo info)
	{
		return null;
	}
}
