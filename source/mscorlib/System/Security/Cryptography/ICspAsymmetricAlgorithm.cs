using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x20002B3")]
	public interface ICspAsymmetricAlgorithm
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000265")]
		CspKeyContainerInfo CspKeyContainerInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600177F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001780")]
		byte[] ExportCspBlob(bool includePrivateParameters);

		[global::Cpp2ILInjected.Token(Token = "0x6001781")]
		void ImportCspBlob(byte[] rawData);
	}
}
