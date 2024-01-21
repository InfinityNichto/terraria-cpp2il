using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000564")]
public struct ShimmerUnstuckHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006938")]
	public int TimeLeftUnstuck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006939")]
	public bool IndefiniteProtectionActive;

	[Cpp2IlInjected.Token(Token = "0x17000722")]
	public bool ShouldUnstuck
	{
		[Cpp2IlInjected.Token(Token = "0x6003A69")]
		[Cpp2IlInjected.Address(RVA = "0x39CD44", Offset = "0x39CD44", VA = "0x39CD44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003A6A")]
	[Cpp2IlInjected.Address(RVA = "0x39CD6C", Offset = "0x39CD6C", VA = "0x39CD6C")]
	public void Update(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A6B")]
	[Cpp2IlInjected.Address(RVA = "0x39CD74", Offset = "0x39CD74", VA = "0x39CD74")]
	public void StartUnstuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A6C")]
	[Cpp2IlInjected.Address(RVA = "0x39CD88", Offset = "0x39CD88", VA = "0x39CD88")]
	public void Clear()
	{
	}
}
