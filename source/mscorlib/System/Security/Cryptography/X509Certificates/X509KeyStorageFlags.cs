using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000321")]
	public enum X509KeyStorageFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000DCE")]
		DefaultKeySet = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000DCF")]
		UserKeySet = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000DD0")]
		MachineKeySet = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000DD1")]
		Exportable = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000DD2")]
		UserProtected = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000DD3")]
		PersistKeySet = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000DD4")]
		EphemeralKeySet = 32
	}
}
