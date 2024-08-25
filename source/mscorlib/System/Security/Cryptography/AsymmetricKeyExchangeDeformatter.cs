using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C5")]
	public abstract class AsymmetricKeyExchangeDeformatter
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x17000287")]
		public abstract string Parameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001813")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6001814")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001815")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		[global::Cpp2ILInjected.Token(Token = "0x6001816")]
		public abstract byte[] DecryptKeyExchange(byte[] rgb);
	}
}
