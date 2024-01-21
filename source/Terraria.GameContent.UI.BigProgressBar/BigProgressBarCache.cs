using Cpp2IlInjected;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000704")]
public struct BigProgressBarCache
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400711D")]
	public float LifeCurrent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400711E")]
	public float LifeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400711F")]
	public float ShieldCurrent;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007120")]
	public float ShieldMax;

	[Cpp2IlInjected.Token(Token = "0x60045E3")]
	[Cpp2IlInjected.Address(RVA = "0x39CDC0", Offset = "0x39CDC0", VA = "0x39CDC0")]
	public void SetLife(float current, float max)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045E4")]
	[Cpp2IlInjected.Address(RVA = "0x39CDCC", Offset = "0x39CDCC", VA = "0x39CDCC")]
	public void SetShield(float current, float max)
	{
	}
}
