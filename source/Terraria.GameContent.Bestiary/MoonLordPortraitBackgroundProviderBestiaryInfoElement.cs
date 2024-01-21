using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200063B")]
public class MoonLordPortraitBackgroundProviderBestiaryInfoElement : IBestiaryInfoElement, IBestiaryBackgroundImagePathAndColorProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003F14")]
	[Cpp2IlInjected.Address(RVA = "0x10FDA00", Offset = "0x10FDA00", VA = "0x10FDA00")]
	public MoonLordPortraitBackgroundProviderBestiaryInfoElement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F15")]
	[Cpp2IlInjected.Address(RVA = "0x10FDA08", Offset = "0x10FDA08", VA = "0x10FDA08", Slot = "5")]
	public Asset<Texture2D> GetBackgroundImage()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F16")]
	[Cpp2IlInjected.Address(RVA = "0x10FDB24", Offset = "0x10FDB24", VA = "0x10FDB24", Slot = "6")]
	public Color? GetBackgroundColor()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F17")]
	[Cpp2IlInjected.Address(RVA = "0x10FDBC4", Offset = "0x10FDBC4", VA = "0x10FDBC4", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
