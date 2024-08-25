using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000F6")]
	public enum OpenFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000475")]
		ReadOnly = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000476")]
		ReadWrite = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000477")]
		MaxAllowed = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000478")]
		OpenExistingOnly = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000479")]
		IncludeArchived = 8
	}
}
