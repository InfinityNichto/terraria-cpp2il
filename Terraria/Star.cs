using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000349")]
public class Star
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002F56")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002F57")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002F58")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002F59")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002F5A")]
	public float twinkle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002F5B")]
	public float twinkleSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002F5C")]
	public float rotationSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002F5D")]
	public bool falling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4002F5E")]
	public bool hidden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002F5F")]
	public Vector2 fallSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002F60")]
	public int fallTime;

	[Cpp2IlInjected.Token(Token = "0x4002F61")]
	public static bool dayCheck;

	[Cpp2IlInjected.Token(Token = "0x4002F62")]
	public static float starfallBoost;

	[Cpp2IlInjected.Token(Token = "0x4002F63")]
	public static int starFallCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002F64")]
	public float fadeIn;

	[Cpp2IlInjected.Token(Token = "0x60027B0")]
	[Cpp2IlInjected.Address(RVA = "0x14E6420", Offset = "0x14E6420", VA = "0x14E6420")]
	public static void NightSetup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027B1")]
	[Cpp2IlInjected.Address(RVA = "0x14E6660", Offset = "0x14E6660", VA = "0x14E6660")]
	public static void StarFall(float positionX)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027B2")]
	[Cpp2IlInjected.Address(RVA = "0x14E69BC", Offset = "0x14E69BC", VA = "0x14E69BC")]
	public static void SpawnStars(int s = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027B3")]
	[Cpp2IlInjected.Address(RVA = "0x14E68D0", Offset = "0x14E68D0", VA = "0x14E68D0")]
	public void Fall()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027B4")]
	[Cpp2IlInjected.Address(RVA = "0x14E70F8", Offset = "0x14E70F8", VA = "0x14E70F8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027B5")]
	[Cpp2IlInjected.Address(RVA = "0x14E7460", Offset = "0x14E7460", VA = "0x14E7460")]
	public static void UpdateStars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027B6")]
	[Cpp2IlInjected.Address(RVA = "0x14E70EC", Offset = "0x14E70EC", VA = "0x14E70EC")]
	public Star()
	{
	}
}
