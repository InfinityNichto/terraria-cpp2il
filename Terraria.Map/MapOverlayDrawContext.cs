using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.UI;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004AB")]
public struct MapOverlayDrawContext
{
	[Cpp2IlInjected.Token(Token = "0x200093E")]
	public struct DrawResult
	{
		[Cpp2IlInjected.Token(Token = "0x4008AD9")]
		public static readonly DrawResult Culled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008ADA")]
		public readonly bool IsMouseOver;

		[Cpp2IlInjected.Token(Token = "0x6004D03")]
		[Cpp2IlInjected.Address(RVA = "0x39A5A0", Offset = "0x39A5A0", VA = "0x39A5A0")]
		public DrawResult(bool isMouseOver)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400659C")]
	private readonly Vector2 _mapPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400659D")]
	private readonly Vector2 _mapOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400659E")]
	private readonly Rectangle? _clippingRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400659F")]
	private readonly float _mapScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40065A0")]
	private readonly float _drawScale;

	[Cpp2IlInjected.Token(Token = "0x60033F7")]
	[Cpp2IlInjected.Address(RVA = "0x39A468", Offset = "0x39A468", VA = "0x39A468")]
	public MapOverlayDrawContext(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033F8")]
	[Cpp2IlInjected.Address(RVA = "0x39A4BC", Offset = "0x39A4BC", VA = "0x39A4BC")]
	public DrawResult Draw(Texture2D texture, Vector2 position, Alignment alignment)
	{
		return default(DrawResult);
	}

	[Cpp2IlInjected.Token(Token = "0x60033F9")]
	[Cpp2IlInjected.Address(RVA = "0x39A4E4", Offset = "0x39A4E4", VA = "0x39A4E4")]
	public DrawResult Draw(Texture2D texture, Vector2 position, SpriteFrame frame, Alignment alignment)
	{
		return default(DrawResult);
	}

	[Cpp2IlInjected.Token(Token = "0x60033FA")]
	[Cpp2IlInjected.Address(RVA = "0x39A524", Offset = "0x39A524", VA = "0x39A524")]
	public DrawResult Draw(Texture2D texture, Vector2 position, Color color, SpriteFrame frame, float scaleIfNotSelected, float scaleIfSelected, Alignment alignment)
	{
		return default(DrawResult);
	}
}
