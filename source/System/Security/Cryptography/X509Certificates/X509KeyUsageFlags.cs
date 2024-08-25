using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	public enum X509KeyUsageFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
		EncipherOnly = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
		CrlSign = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
		KeyCertSign = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
		KeyAgreement = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
		DataEncipherment = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
		KeyEncipherment = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
		NonRepudiation = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
		DigitalSignature = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
		DecipherOnly = 32768
	}
}
