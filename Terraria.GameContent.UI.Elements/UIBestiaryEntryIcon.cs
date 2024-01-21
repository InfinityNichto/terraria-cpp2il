using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006C2")]
public class UIBestiaryEntryIcon : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006FD1")]
	private BestiaryEntry _entry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FD2")]
	private Asset<Texture2D> _notUnlockedTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FD3")]
	private bool _isPortrait;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
	[Cpp2IlInjected.Token(Token = "0x4006FD4")]
	public bool ForceHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006FD5")]
	private BestiaryUICollectionInfo _collectionInfo;

	[Cpp2IlInjected.Token(Token = "0x6004429")]
	[Cpp2IlInjected.Address(RVA = "0x147D7AC", Offset = "0x147D7AC", VA = "0x147D7AC")]
	public UIBestiaryEntryIcon(BestiaryEntry entry, bool isPortrait)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600442A")]
	[Cpp2IlInjected.Address(RVA = "0x147D9F4", Offset = "0x147D9F4", VA = "0x147D9F4", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600442B")]
	[Cpp2IlInjected.Address(RVA = "0x147DC58", Offset = "0x147DC58", VA = "0x147DC58", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600442C")]
	[Cpp2IlInjected.Address(RVA = "0x147DFA8", Offset = "0x147DFA8", VA = "0x147DFA8")]
	public string GetHoverText()
	{
		return null;
	}
}
