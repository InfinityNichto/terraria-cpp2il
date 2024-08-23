using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000229 RID: 553
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C6")]
	public abstract class AsymmetricKeyExchangeFormatter
	{
		// Token: 0x060015FD RID: 5629 RVA: 0x000182D5 File Offset: 0x000164D5
		[global::Cpp2ILInjected.Token(Token = "0x6001817")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9150", Offset = "0x1AF9150", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AsymmetricKeyExchangeFormatter()
		{
			throw null;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060015FE RID: 5630
		[global::Cpp2ILInjected.Token(Token = "0x17000288")]
		public abstract string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001818")]
			get;
		}

		// Token: 0x060015FF RID: 5631
		[global::Cpp2ILInjected.Token(Token = "0x6001819")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x06001600 RID: 5632
		[global::Cpp2ILInjected.Token(Token = "0x600181A")]
		public abstract byte[] CreateKeyExchange(byte[] data);

		// Token: 0x06001601 RID: 5633
		[global::Cpp2ILInjected.Token(Token = "0x600181B")]
		public abstract byte[] CreateKeyExchange(byte[] data, global::System.Type symAlgType);
	}
}
