using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C8")]
	public abstract class AsymmetricSignatureFormatter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001821")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9214", Offset = "0x1AF9214", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureFormatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureFormatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AsymmetricSignatureFormatter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001822")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		[global::Cpp2ILInjected.Token(Token = "0x6001823")]
		public abstract void SetHashAlgorithm(string strName);

		[global::Cpp2ILInjected.Token(Token = "0x6001824")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF921C", Offset = "0x1AF921C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual byte[] CreateSignature(HashAlgorithm hash)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001825")]
		public abstract byte[] CreateSignature(byte[] rgbHash);
	}
}
