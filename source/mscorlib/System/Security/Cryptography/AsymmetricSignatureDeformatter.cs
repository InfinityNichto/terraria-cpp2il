using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C7")]
	public abstract class AsymmetricSignatureDeformatter
	{
		[global::Cpp2ILInjected.Token(Token = "0x600181C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9158", Offset = "0x1AF9158", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureDeformatter), Member = ".ctor", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AsymmetricSignatureDeformatter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600181D")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		[global::Cpp2ILInjected.Token(Token = "0x600181E")]
		public abstract void SetHashAlgorithm(string strName);

		[global::Cpp2ILInjected.Token(Token = "0x600181F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9160", Offset = "0x1AF9160", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001820")]
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
	}
}
