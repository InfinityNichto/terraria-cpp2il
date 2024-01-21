using System.Net.Sockets;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000254")]
public static class NetworkStreamExtensions
{
	[Cpp2IlInjected.Token(Token = "0x600111B")]
	[Cpp2IlInjected.Address(RVA = "0x10B2CDC", Offset = "0x10B2CDC", VA = "0x10B2CDC")]
	public static int ReadSafely(this NetworkStream stream, byte[] buffer, int offset, int size)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600111C")]
	[Cpp2IlInjected.Address(RVA = "0x10B2DD8", Offset = "0x10B2DD8", VA = "0x10B2DD8")]
	public static bool ReadExactly(this NetworkStream stream, byte[] buffer, int amount)
	{
		return default(bool);
	}
}
