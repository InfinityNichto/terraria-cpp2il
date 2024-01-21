using System;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002BA")]
[DataContract]
public sealed class NoSuitableGraphicsDeviceException : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6001690")]
	[Cpp2IlInjected.Address(RVA = "0x1589BB4", Offset = "0x1589BB4", VA = "0x1589BB4")]
	public NoSuitableGraphicsDeviceException()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001691")]
	[Cpp2IlInjected.Address(RVA = "0x1589C30", Offset = "0x1589C30", VA = "0x1589C30")]
	public NoSuitableGraphicsDeviceException(string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001692")]
	[Cpp2IlInjected.Address(RVA = "0x1589CB4", Offset = "0x1589CB4", VA = "0x1589CB4")]
	public NoSuitableGraphicsDeviceException(string message, Exception inner)
	{
	}
}
