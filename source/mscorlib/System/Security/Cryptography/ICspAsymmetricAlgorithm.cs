using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	// Token: 0x0200021B RID: 539
	[global::Cpp2ILInjected.Token(Token = "0x20002B3")]
	public interface ICspAsymmetricAlgorithm
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001570 RID: 5488
		[global::Cpp2ILInjected.Token(Token = "0x17000265")]
		CspKeyContainerInfo CspKeyContainerInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600177F")]
			get;
		}

		// Token: 0x06001571 RID: 5489
		[global::Cpp2ILInjected.Token(Token = "0x6001780")]
		byte[] ExportCspBlob(bool includePrivateParameters);

		// Token: 0x06001572 RID: 5490
		[global::Cpp2ILInjected.Token(Token = "0x6001781")]
		void ImportCspBlob(byte[] rawData);
	}
}
