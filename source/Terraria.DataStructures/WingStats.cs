using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000482")]
public struct WingStats
{
	[Cpp2IlInjected.Token(Token = "0x400649F")]
	public static readonly WingStats Default;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40064A0")]
	public int FlyTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40064A1")]
	public float AccRunSpeedOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40064A2")]
	public float AccRunAccelerationMult;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40064A3")]
	public bool HasDownHoverStats;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40064A4")]
	public float DownHoverSpeedOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40064A5")]
	public float DownHoverAccelerationMult;

	[Cpp2IlInjected.Token(Token = "0x60032B9")]
	[Cpp2IlInjected.Address(RVA = "0x39DE48", Offset = "0x39DE48", VA = "0x39DE48")]
	public WingStats(int flyTime = 100, float flySpeedOverride = -1f, float accelerationMultiplier = 1f, bool hasHoldDownHoverFeatures = false, float hoverFlySpeedOverride = -1f, float hoverAccelerationMultiplier = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60032BA")]
	[Cpp2IlInjected.Address(RVA = "0x39DE70", Offset = "0x39DE70", VA = "0x39DE70")]
	public WingStats WithSpeedBoost(float multiplier)
	{
		return default(WingStats);
	}
}
