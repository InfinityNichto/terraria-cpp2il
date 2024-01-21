using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D5")]
public class SignInfo_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x6002FEA")]
	[Cpp2IlInjected.Address(RVA = "0xE483EC", Offset = "0xE483EC", VA = "0xE483EC")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FEB")]
	[Cpp2IlInjected.Address(RVA = "0xE4863C", Offset = "0xE4863C", VA = "0xE4863C")]
	private string UserString(BinaryReader reader, int release)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002FEC")]
	[Cpp2IlInjected.Address(RVA = "0xE486C4", Offset = "0xE486C4", VA = "0xE486C4")]
	public SignInfo_OldMobile()
	{
	}
}
