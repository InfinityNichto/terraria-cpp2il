using System.Net;
using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x20004A0")]
public class TcpAddress : RemoteAddress
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006556")]
	public string Host;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006557")]
	public IPAddress Address;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006558")]
	public int Port;

	[Cpp2IlInjected.Token(Token = "0x60033A4")]
	[Cpp2IlInjected.Address(RVA = "0x142E12C", Offset = "0x142E12C", VA = "0x142E12C")]
	public TcpAddress(IPAddress address, int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033A5")]
	[Cpp2IlInjected.Address(RVA = "0x142EDAC", Offset = "0x142EDAC", VA = "0x142EDAC")]
	public TcpAddress(string host, int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033A6")]
	[Cpp2IlInjected.Address(RVA = "0x142EDDC", Offset = "0x142EDDC", VA = "0x142EDDC", Slot = "4")]
	public override string GetIdentifier()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60033A7")]
	[Cpp2IlInjected.Address(RVA = "0x142EDF0", Offset = "0x142EDF0", VA = "0x142EDF0", Slot = "6")]
	public override bool IsLocalHost()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033A8")]
	[Cpp2IlInjected.Address(RVA = "0x142EE84", Offset = "0x142EE84", VA = "0x142EE84", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60033A9")]
	[Cpp2IlInjected.Address(RVA = "0x142EF74", Offset = "0x142EF74", VA = "0x142EF74", Slot = "5")]
	public override string GetFriendlyName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60033AA")]
	[Cpp2IlInjected.Address(RVA = "0x142EF84", Offset = "0x142EF84", VA = "0x142EF84")]
	public static bool IsLocalHost(string addressString)
	{
		return default(bool);
	}
}
