using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000315")]
public class Dust
{
	[Cpp2IlInjected.Token(Token = "0x4002199")]
	public static int activeDustCount;

	[Cpp2IlInjected.Token(Token = "0x400219A")]
	public static Dust[] freeDust;

	[Cpp2IlInjected.Token(Token = "0x400219B")]
	public static int freeDustCount;

	[Cpp2IlInjected.Token(Token = "0x400219C")]
	public static float dCount;

	[Cpp2IlInjected.Token(Token = "0x400219D")]
	public static int lavaBubbles;

	[Cpp2IlInjected.Token(Token = "0x400219E")]
	public static int SandStormCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400219F")]
	public int dustIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40021A0")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40021A1")]
	public Vector2 velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40021A2")]
	public float fadeIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40021A3")]
	public bool noGravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40021A4")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40021A5")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40021A6")]
	public bool noLight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x40021A7")]
	public bool noLightEmittence;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x40021A8")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40021A9")]
	public int type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40021AA")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40021AB")]
	public int alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40021AC")]
	public Rectangle frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40021AD")]
	public ArmorShaderData shader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40021AE")]
	public object customData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40021AF")]
	public bool firstFrame;

	[Cpp2IlInjected.Token(Token = "0x40021B0")]
	private static bool[] StaticAlpha;

	[Cpp2IlInjected.Token(Token = "0x40021B1")]
	private static Color[] StaticAlphaValue;

	[Cpp2IlInjected.Token(Token = "0x6001978")]
	[Cpp2IlInjected.Address(RVA = "0x131FB0C", Offset = "0x131FB0C", VA = "0x131FB0C")]
	public static void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001979")]
	[Cpp2IlInjected.Address(RVA = "0x131FCD0", Offset = "0x131FCD0", VA = "0x131FCD0")]
	public static Dust NewDustPerfect(Vector2 Position, int Type, [Optional] Vector2? Velocity, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600197A")]
	[Cpp2IlInjected.Address(RVA = "0x1320ED4", Offset = "0x1320ED4", VA = "0x1320ED4")]
	public static Dust NewDustDirect(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600197B")]
	[Cpp2IlInjected.Address(RVA = "0x131FE38", Offset = "0x131FE38", VA = "0x131FE38")]
	public static int NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600197C")]
	[Cpp2IlInjected.Address(RVA = "0x13211D0", Offset = "0x13211D0", VA = "0x13211D0")]
	public static Dust CloneDust(int dustIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600197D")]
	[Cpp2IlInjected.Address(RVA = "0x1321288", Offset = "0x1321288", VA = "0x1321288")]
	public static Dust CloneDust(Dust rf)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600197E")]
	[Cpp2IlInjected.Address(RVA = "0x13210E0", Offset = "0x13210E0", VA = "0x13210E0")]
	public static void SetNotActive(Dust dust)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600197F")]
	[Cpp2IlInjected.Address(RVA = "0x132144C", Offset = "0x132144C", VA = "0x132144C")]
	public static Dust QuickDust(int x, int y, Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001980")]
	[Cpp2IlInjected.Address(RVA = "0x13214F8", Offset = "0x13214F8", VA = "0x13214F8")]
	public static Dust QuickDust(Point tileCoords, Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001981")]
	[Cpp2IlInjected.Address(RVA = "0x1321790", Offset = "0x1321790", VA = "0x1321790")]
	public static void QuickBox(Vector2 topLeft, Vector2 bottomRight, int divisions, Color color, Action<Dust> manipulator)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001982")]
	[Cpp2IlInjected.Address(RVA = "0x1321A6C", Offset = "0x1321A6C", VA = "0x1321A6C")]
	public static void DrawDebugBox(Rectangle itemRectangle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001983")]
	[Cpp2IlInjected.Address(RVA = "0x13215D8", Offset = "0x13215D8", VA = "0x13215D8")]
	public static Dust QuickDust(Vector2 pos, Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001984")]
	[Cpp2IlInjected.Address(RVA = "0x1321CA8", Offset = "0x1321CA8", VA = "0x1321CA8")]
	public static Dust QuickDustSmall(Vector2 pos, Color color, bool floorPositionValues = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001985")]
	[Cpp2IlInjected.Address(RVA = "0x1321DB4", Offset = "0x1321DB4", VA = "0x1321DB4")]
	public static void QuickDustLine(Vector2 start, Vector2 end, float splits, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001986")]
	[Cpp2IlInjected.Address(RVA = "0x1321F3C", Offset = "0x1321F3C", VA = "0x1321F3C")]
	public static int dustWater()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001987")]
	[Cpp2IlInjected.Address(RVA = "0x1321FD8", Offset = "0x1321FD8", VA = "0x1321FD8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FB58", Offset = "0x38FB58")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FB58", Offset = "0x38FB58")]
	public static void UpdateDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001988")]
	[Cpp2IlInjected.Address(RVA = "0x132B0C0", Offset = "0x132B0C0", VA = "0x132B0C0")]
	private static void SetupAlpha(short id, Color value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001989")]
	[Cpp2IlInjected.Address(RVA = "0x132B160", Offset = "0x132B160", VA = "0x132B160")]
	public static void InitAlphaTable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600198A")]
	[Cpp2IlInjected.Address(RVA = "0x132BA4C", Offset = "0x132BA4C", VA = "0x132BA4C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FC0C", Offset = "0x38FC0C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FC0C", Offset = "0x38FC0C")]
	public void GetAlpha(ref Color newColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600198B")]
	[Cpp2IlInjected.Address(RVA = "0x132C54C", Offset = "0x132C54C", VA = "0x132C54C")]
	public Color GetAlpha(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600198C")]
	[Cpp2IlInjected.Address(RVA = "0x132D390", Offset = "0x132D390", VA = "0x132D390")]
	public void GetColor(ref Color newColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600198D")]
	[Cpp2IlInjected.Address(RVA = "0x132D434", Offset = "0x132D434", VA = "0x132D434")]
	public float GetVisualRotation()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600198E")]
	[Cpp2IlInjected.Address(RVA = "0x132D450", Offset = "0x132D450", VA = "0x132D450")]
	public float GetVisualScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600198F")]
	[Cpp2IlInjected.Address(RVA = "0x131FCC8", Offset = "0x131FCC8", VA = "0x131FCC8")]
	public Dust()
	{
	}
}
