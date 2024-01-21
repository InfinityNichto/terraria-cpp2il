using Cpp2IlInjected;
using Terraria.ID;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000546")]
public class ChildSafety
{
	[Cpp2IlInjected.Token(Token = "0x40068C8")]
	private static SetFactory factoryDust;

	[Cpp2IlInjected.Token(Token = "0x40068C9")]
	private static SetFactory factoryGore;

	[Cpp2IlInjected.Token(Token = "0x40068CA")]
	private static readonly bool[] SafeGore;

	[Cpp2IlInjected.Token(Token = "0x40068CB")]
	private static readonly bool[] SafeDust;

	[Cpp2IlInjected.Token(Token = "0x1700071D")]
	public static bool Disabled
	{
		[Cpp2IlInjected.Token(Token = "0x60039C5")]
		[Cpp2IlInjected.Address(RVA = "0x107D6D8", Offset = "0x107D6D8", VA = "0x107D6D8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60039C6")]
		[Cpp2IlInjected.Address(RVA = "0x107D754", Offset = "0x107D754", VA = "0x107D754")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60039C7")]
	[Cpp2IlInjected.Address(RVA = "0x107D7D4", Offset = "0x107D7D4", VA = "0x107D7D4")]
	public static bool DangerousGore(int id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039C8")]
	[Cpp2IlInjected.Address(RVA = "0x107D860", Offset = "0x107D860", VA = "0x107D860")]
	public static bool DangerousDust(int id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60039C9")]
	[Cpp2IlInjected.Address(RVA = "0x107D8EC", Offset = "0x107D8EC", VA = "0x107D8EC")]
	public ChildSafety()
	{
	}
}
