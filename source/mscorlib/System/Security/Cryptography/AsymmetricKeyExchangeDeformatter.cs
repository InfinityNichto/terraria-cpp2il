using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000228 RID: 552
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C5")]
	public abstract class AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x060015F8 RID: 5624 RVA: 0x000182D2 File Offset: 0x000164D2
		[global::Cpp2ILInjected.Token(Token = "0x6001812")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9148", Offset = "0x1AF9148", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AsymmetricKeyExchangeDeformatter()
		{
			throw null;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060015F9 RID: 5625
		// (set) Token: 0x060015FA RID: 5626
		[global::Cpp2ILInjected.Token(Token = "0x17000287")]
		public abstract string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001813")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001814")]
			set;
		}

		// Token: 0x060015FB RID: 5627
		[global::Cpp2ILInjected.Token(Token = "0x6001815")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x060015FC RID: 5628
		[global::Cpp2ILInjected.Token(Token = "0x6001816")]
		public abstract byte[] DecryptKeyExchange(byte[] rgb);
	}
}
