using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x20006A5")]
public class WorldUIAnchor
{
	[Cpp2IlInjected.Token(Token = "0x2000A9C")]
	public enum AnchorType
	{
		[Cpp2IlInjected.Token(Token = "0x4008EED")]
		Entity,
		[Cpp2IlInjected.Token(Token = "0x4008EEE")]
		Tile,
		[Cpp2IlInjected.Token(Token = "0x4008EEF")]
		Pos,
		[Cpp2IlInjected.Token(Token = "0x4008EF0")]
		None
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006ECE")]
	public AnchorType type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006ECF")]
	public Entity entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006ED0")]
	public Vector2 pos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006ED1")]
	public Vector2 size;

	[Cpp2IlInjected.Token(Token = "0x60042D1")]
	[Cpp2IlInjected.Address(RVA = "0xE150F8", Offset = "0xE150F8", VA = "0xE150F8")]
	public WorldUIAnchor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D2")]
	[Cpp2IlInjected.Address(RVA = "0xE15254", Offset = "0xE15254", VA = "0xE15254")]
	public WorldUIAnchor(Entity anchor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D3")]
	[Cpp2IlInjected.Address(RVA = "0xE153B8", Offset = "0xE153B8", VA = "0xE153B8")]
	public WorldUIAnchor(Vector2 anchor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D4")]
	[Cpp2IlInjected.Address(RVA = "0xE15524", Offset = "0xE15524", VA = "0xE15524")]
	public WorldUIAnchor(int topLeftX, int topLeftY, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D5")]
	[Cpp2IlInjected.Address(RVA = "0xE15768", Offset = "0xE15768", VA = "0xE15768")]
	public bool InRange(Vector2 target, float tileRangeX, float tileRangeY)
	{
		return default(bool);
	}
}
