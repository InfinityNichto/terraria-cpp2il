using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000342")]
public class Rain
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002EEC")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002EED")]
	public Vector2 velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002EEE")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002EEF")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002EF0")]
	public int alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002EF1")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4002EF2")]
	public byte type;

	[Cpp2IlInjected.Token(Token = "0x6002716")]
	[Cpp2IlInjected.Address(RVA = "0xC92470", Offset = "0xC92470", VA = "0xC92470")]
	public static void ClearRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002717")]
	[Cpp2IlInjected.Address(RVA = "0xC92530", Offset = "0xC92530", VA = "0xC92530")]
	public static void MakeRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002718")]
	[Cpp2IlInjected.Address(RVA = "0xC92DA4", Offset = "0xC92DA4", VA = "0xC92DA4")]
	public static Vector2 GetRainFallVelocity()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002719")]
	[Cpp2IlInjected.Address(RVA = "0xC93354", Offset = "0xC93354", VA = "0xC93354")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600271A")]
	[Cpp2IlInjected.Address(RVA = "0xC93930", Offset = "0xC93930", VA = "0xC93930")]
	public static int NewRainForced(Vector2 Position, Vector2 Velocity)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600271B")]
	[Cpp2IlInjected.Address(RVA = "0xC92E50", Offset = "0xC92E50", VA = "0xC92E50")]
	private static int NewRain(Vector2 Position, Vector2 Velocity)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600271C")]
	[Cpp2IlInjected.Address(RVA = "0xC93C0C", Offset = "0xC93C0C", VA = "0xC93C0C")]
	public Rain()
	{
	}
}
