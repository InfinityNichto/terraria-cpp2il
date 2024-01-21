using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D8")]
public class UIImage : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400705C")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400705D")]
	public float ImageScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400705E")]
	public float Rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400705F")]
	public bool ScaleToFit;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x4007060")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4007061")]
	public Vector2 NormalizedOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4007062")]
	public bool RemoveFloatingPointsFromDrawPosition;

	[Cpp2IlInjected.Token(Token = "0x60044D0")]
	[Cpp2IlInjected.Address(RVA = "0x1482398", Offset = "0x1482398", VA = "0x1482398")]
	public UIImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D1")]
	[Cpp2IlInjected.Address(RVA = "0x1491B84", Offset = "0x1491B84", VA = "0x1491B84")]
	public void SetImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D2")]
	[Cpp2IlInjected.Address(RVA = "0x1491C50", Offset = "0x1491C50", VA = "0x1491C50", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
