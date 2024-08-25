using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000320")]
	public enum X509ContentType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000DC5")]
		Unknown,
		[global::Cpp2ILInjected.Token(Token = "0x4000DC6")]
		Cert,
		[global::Cpp2ILInjected.Token(Token = "0x4000DC7")]
		SerializedCert,
		[global::Cpp2ILInjected.Token(Token = "0x4000DC8")]
		Pfx,
		[global::Cpp2ILInjected.Token(Token = "0x4000DC9")]
		Pkcs12 = 3,
		[global::Cpp2ILInjected.Token(Token = "0x4000DCA")]
		SerializedStore,
		[global::Cpp2ILInjected.Token(Token = "0x4000DCB")]
		Pkcs7,
		[global::Cpp2ILInjected.Token(Token = "0x4000DCC")]
		Authenticode
	}
}
