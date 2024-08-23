using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200022A RID: 554
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C7")]
	public abstract class AsymmetricSignatureDeformatter
	{
		// Token: 0x06001602 RID: 5634 RVA: 0x000182D8 File Offset: 0x000164D8
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

		// Token: 0x06001603 RID: 5635
		[global::Cpp2ILInjected.Token(Token = "0x600181D")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x06001604 RID: 5636
		[global::Cpp2ILInjected.Token(Token = "0x600181E")]
		public abstract void SetHashAlgorithm(string strName);

		// Token: 0x06001605 RID: 5637 RVA: 0x000182DB File Offset: 0x000164DB
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

		// Token: 0x06001606 RID: 5638
		[global::Cpp2ILInjected.Token(Token = "0x6001820")]
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
	}
}
