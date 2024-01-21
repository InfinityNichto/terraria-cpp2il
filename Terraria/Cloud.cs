using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000327")]
public class Cloud
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002C83")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002C84")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002C85")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002C86")]
	public float rSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002C87")]
	public float sSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002C88")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002C89")]
	public SpriteEffects spriteDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002C8A")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002C8B")]
	public int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002C8C")]
	public int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002C8D")]
	public float Alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002C8E")]
	public bool kill;

	[Cpp2IlInjected.Token(Token = "0x4002C8F")]
	private static UnifiedRandom rand;

	[Cpp2IlInjected.Token(Token = "0x600259B")]
	[Cpp2IlInjected.Address(RVA = "0x11AFB1C", Offset = "0x11AFB1C", VA = "0x11AFB1C")]
	public static void resetClouds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600259C")]
	[Cpp2IlInjected.Address(RVA = "0x11AFCF8", Offset = "0x11AFCF8", VA = "0x11AFCF8")]
	public static void addCloud()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600259D")]
	[Cpp2IlInjected.Address(RVA = "0x11B11E4", Offset = "0x11B11E4", VA = "0x11B11E4")]
	private static int RollRareCloud()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600259E")]
	[Cpp2IlInjected.Address(RVA = "0x11B14A8", Offset = "0x11B14A8", VA = "0x11B14A8")]
	public Color cloudColor(Color bgColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600259F")]
	[Cpp2IlInjected.Address(RVA = "0x11B15AC", Offset = "0x11B15AC", VA = "0x11B15AC")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60025A0")]
	[Cpp2IlInjected.Address(RVA = "0x11B15B8", Offset = "0x11B15B8", VA = "0x11B15B8")]
	public static void UpdateClouds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025A1")]
	[Cpp2IlInjected.Address(RVA = "0x11B1B88", Offset = "0x11B1B88", VA = "0x11B1B88")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025A2")]
	[Cpp2IlInjected.Address(RVA = "0x11B2254", Offset = "0x11B2254", VA = "0x11B2254")]
	public Cloud()
	{
	}
}
