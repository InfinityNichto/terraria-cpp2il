using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006BD")]
public class UIBestiaryEntryButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FB7")]
	private UIImage _bordersGlow;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FB8")]
	private UIImage _bordersOverlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006FB9")]
	private UIImage _borders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006FBA")]
	private UIBestiaryEntryIcon _icon;

	[Cpp2IlInjected.Token(Token = "0x170007BC")]
	public BestiaryEntry Entry
	{
		[Cpp2IlInjected.Token(Token = "0x60043FA")]
		[Cpp2IlInjected.Address(RVA = "0x1191714", Offset = "0x1191714", VA = "0x1191714")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60043FB")]
		[Cpp2IlInjected.Address(RVA = "0x119171C", Offset = "0x119171C", VA = "0x119171C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60043FC")]
	[Cpp2IlInjected.Address(RVA = "0x1191724", Offset = "0x1191724", VA = "0x1191724")]
	public UIBestiaryEntryButton(BestiaryEntry entry, bool isAPrettyPortrait)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043FD")]
	[Cpp2IlInjected.Address(RVA = "0x11920CC", Offset = "0x11920CC", VA = "0x11920CC")]
	private Asset<Texture2D> TryGettingBackgroundImageProvider(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60043FE")]
	[Cpp2IlInjected.Address(RVA = "0x11929C0", Offset = "0x11929C0", VA = "0x11929C0")]
	private int? TryGettingDisplayIndex(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60043FF")]
	[Cpp2IlInjected.Address(RVA = "0x1192BCC", Offset = "0x1192BCC", VA = "0x1192BCC", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004400")]
	[Cpp2IlInjected.Address(RVA = "0x1192C9C", Offset = "0x1192C9C", VA = "0x1192C9C")]
	private void MouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004401")]
	[Cpp2IlInjected.Address(RVA = "0x1192D38", Offset = "0x1192D38", VA = "0x1192D38")]
	private void MouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}
}
