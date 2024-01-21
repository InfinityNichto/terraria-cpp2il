using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C5")]
public class UIBestiaryInfoItemLine : UIPanel, IManuallyOrderedUIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FDB")]
	private Item _infoDisplayItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FDC")]
	private bool _hideMouseOver;

	[Cpp2IlInjected.Token(Token = "0x170007BD")]
	public int OrderInUIList
	{
		[Cpp2IlInjected.Token(Token = "0x6004438")]
		[Cpp2IlInjected.Address(RVA = "0x1481A28", Offset = "0x1481A28", VA = "0x1481A28", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6004439")]
		[Cpp2IlInjected.Address(RVA = "0x1481A30", Offset = "0x1481A30", VA = "0x1481A30", Slot = "31")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600443A")]
	[Cpp2IlInjected.Address(RVA = "0x1481A38", Offset = "0x1481A38", VA = "0x1481A38")]
	public UIBestiaryInfoItemLine(DropRateInfo info, BestiaryUICollectionInfo uiinfo, float textScale = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600443B")]
	[Cpp2IlInjected.Address(RVA = "0x14821A0", Offset = "0x14821A0", VA = "0x14821A0")]
	public static void GetDropInfo(DropRateInfo dropRateInfo, BestiaryUICollectionInfo uiinfo, out string stackRange, out string droprate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600443C")]
	[Cpp2IlInjected.Address(RVA = "0x148262C", Offset = "0x148262C", VA = "0x148262C", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600443D")]
	[Cpp2IlInjected.Address(RVA = "0x14826F4", Offset = "0x14826F4", VA = "0x14826F4")]
	private void DrawMouseOver()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600443E")]
	[Cpp2IlInjected.Address(RVA = "0x14827D0", Offset = "0x14827D0", VA = "0x14827D0", Slot = "29")]
	public override int CompareTo(object obj)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600443F")]
	[Cpp2IlInjected.Address(RVA = "0x1481F7C", Offset = "0x1481F7C", VA = "0x1481F7C")]
	private void SetBestiaryNotesOnItemCache(DropRateInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004440")]
	[Cpp2IlInjected.Address(RVA = "0x14828E4", Offset = "0x14828E4", VA = "0x14828E4")]
	private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004441")]
	[Cpp2IlInjected.Address(RVA = "0x1482994", Offset = "0x1482994", VA = "0x1482994")]
	private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}
}
