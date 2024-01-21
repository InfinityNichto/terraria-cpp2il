using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000329")]
public class CombatText
{
	[Cpp2IlInjected.Token(Token = "0x4002CA3")]
	public static readonly Color DamagedFriendly;

	[Cpp2IlInjected.Token(Token = "0x4002CA4")]
	public static readonly Color DamagedFriendlyCrit;

	[Cpp2IlInjected.Token(Token = "0x4002CA5")]
	public static readonly Color DamagedHostile;

	[Cpp2IlInjected.Token(Token = "0x4002CA6")]
	public static readonly Color DamagedHostileCrit;

	[Cpp2IlInjected.Token(Token = "0x4002CA7")]
	public static readonly Color OthersDamagedHostile;

	[Cpp2IlInjected.Token(Token = "0x4002CA8")]
	public static readonly Color OthersDamagedHostileCrit;

	[Cpp2IlInjected.Token(Token = "0x4002CA9")]
	public static readonly Color HealLife;

	[Cpp2IlInjected.Token(Token = "0x4002CAA")]
	public static readonly Color HealMana;

	[Cpp2IlInjected.Token(Token = "0x4002CAB")]
	public static readonly Color LifeRegen;

	[Cpp2IlInjected.Token(Token = "0x4002CAC")]
	public static readonly Color LifeRegenNegative;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002CAD")]
	public Vector2 position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002CAE")]
	public Vector2 velocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002CAF")]
	public float alpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002CB0")]
	public int alphaDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002CB1")]
	public string text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002CB2")]
	public float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002CB3")]
	public float rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002CB4")]
	public Color color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002CB5")]
	public bool active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002CB6")]
	public int lifeTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002CB7")]
	public bool crit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4002CB8")]
	public bool dot;

	[Cpp2IlInjected.Token(Token = "0x1700052A")]
	public static float TargetScale
	{
		[Cpp2IlInjected.Token(Token = "0x60025EB")]
		[Cpp2IlInjected.Address(RVA = "0x1010CCC", Offset = "0x1010CCC", VA = "0x1010CCC")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60025E8")]
	[Cpp2IlInjected.Address(RVA = "0x1010550", Offset = "0x1010550", VA = "0x1010550")]
	public static int NewText(Rectangle location, Color color, int amount, bool dramatic = false, bool dot = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60025E9")]
	[Cpp2IlInjected.Address(RVA = "0x1010610", Offset = "0x1010610", VA = "0x1010610")]
	public static int NewText(Rectangle location, Color color, string text, bool dramatic = false, bool dot = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60025EA")]
	[Cpp2IlInjected.Address(RVA = "0x1010C38", Offset = "0x1010C38", VA = "0x1010C38")]
	public static void clearAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025EC")]
	[Cpp2IlInjected.Address(RVA = "0x1010CD8", Offset = "0x1010CD8", VA = "0x1010CD8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025ED")]
	[Cpp2IlInjected.Address(RVA = "0x1010FBC", Offset = "0x1010FBC", VA = "0x1010FBC")]
	public static void UpdateCombatText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60025EE")]
	[Cpp2IlInjected.Address(RVA = "0x1011088", Offset = "0x1011088", VA = "0x1011088")]
	public CombatText()
	{
	}
}
