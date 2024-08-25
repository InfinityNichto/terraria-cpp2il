using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::System.Flags]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D1")]
	[global::System.Serializable]
	public enum CspProviderFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000C92")]
		NoFlags = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000C93")]
		UseMachineKeyStore = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000C94")]
		UseDefaultKeyContainer = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000C95")]
		UseNonExportableKey = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000C96")]
		UseExistingKey = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000C97")]
		UseArchivableKey = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000C98")]
		UseUserProtectedKey = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000C99")]
		NoPrompt = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000C9A")]
		CreateEphemeralKey = 128
	}
}
