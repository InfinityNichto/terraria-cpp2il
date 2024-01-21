using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000372")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384FD8", Offset = "0x384FD8")]
public struct Bits64
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4003183")]
	private ulong v;

	[Cpp2IlInjected.Token(Token = "0x170005A2")]
	public bool Item
	{
		[Cpp2IlInjected.Token(Token = "0x6002CC8")]
		[Cpp2IlInjected.Address(RVA = "0x39C45C", Offset = "0x39C45C", VA = "0x39C45C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002CC9")]
		[Cpp2IlInjected.Address(RVA = "0x39C4A4", Offset = "0x39C4A4", VA = "0x39C4A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005A3")]
	public bool IsEmpty
	{
		[Cpp2IlInjected.Token(Token = "0x6002CCA")]
		[Cpp2IlInjected.Address(RVA = "0x39C500", Offset = "0x39C500", VA = "0x39C500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002CCB")]
	[Cpp2IlInjected.Address(RVA = "0x10D93F4", Offset = "0x10D93F4", VA = "0x10D93F4")]
	public static implicit operator ulong(Bits64 b)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6002CCC")]
	[Cpp2IlInjected.Address(RVA = "0x10D93F8", Offset = "0x10D93F8", VA = "0x10D93F8")]
	public static implicit operator Bits64(ulong v)
	{
		return default(Bits64);
	}
}
