using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006EE")]
public class UIWorldCreationPreview : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40070D2")]
	private readonly Asset<Texture2D> _BorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40070D3")]
	private readonly Asset<Texture2D> _BackgroundExpertTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40070D4")]
	private readonly Asset<Texture2D> _BackgroundNormalTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40070D5")]
	private readonly Asset<Texture2D> _BackgroundMasterTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40070D6")]
	private readonly Asset<Texture2D> _BunnyExpertTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40070D7")]
	private readonly Asset<Texture2D> _BunnyNormalTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40070D8")]
	private readonly Asset<Texture2D> _BunnyCreativeTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40070D9")]
	private readonly Asset<Texture2D> _BunnyMasterTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40070DA")]
	private readonly Asset<Texture2D> _EvilRandomTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40070DB")]
	private readonly Asset<Texture2D> _EvilCorruptionTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40070DC")]
	private readonly Asset<Texture2D> _EvilCrimsonTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40070DD")]
	private readonly Asset<Texture2D> _SizeSmallTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40070DE")]
	private readonly Asset<Texture2D> _SizeMediumTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40070DF")]
	private readonly Asset<Texture2D> _SizeLargeTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40070E0")]
	private byte _difficulty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x129")]
	[Cpp2IlInjected.Token(Token = "0x40070E1")]
	private byte _evil;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12A")]
	[Cpp2IlInjected.Token(Token = "0x40070E2")]
	private byte _size;

	[Cpp2IlInjected.Token(Token = "0x6004574")]
	[Cpp2IlInjected.Address(RVA = "0x1092034", Offset = "0x1092034", VA = "0x1092034")]
	public UIWorldCreationPreview()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004575")]
	[Cpp2IlInjected.Address(RVA = "0x1092BE8", Offset = "0x1092BE8", VA = "0x1092BE8")]
	public void UpdateOption(byte difficulty, byte evil, byte size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004576")]
	[Cpp2IlInjected.Address(RVA = "0x1092BF8", Offset = "0x1092BF8", VA = "0x1092BF8", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
