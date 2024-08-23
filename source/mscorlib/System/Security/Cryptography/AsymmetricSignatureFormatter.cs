using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200022B RID: 555
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C8")]
	public abstract class AsymmetricSignatureFormatter
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x000182DE File Offset: 0x000164DE
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

		// Token: 0x06001608 RID: 5640
		[global::Cpp2ILInjected.Token(Token = "0x6001822")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x06001609 RID: 5641
		[global::Cpp2ILInjected.Token(Token = "0x6001823")]
		public abstract void SetHashAlgorithm(string strName);

		// Token: 0x0600160A RID: 5642 RVA: 0x000182E1 File Offset: 0x000164E1
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

		// Token: 0x0600160B RID: 5643
		[global::Cpp2ILInjected.Token(Token = "0x6001825")]
		public abstract byte[] CreateSignature(byte[] rgbHash);
	}
}
