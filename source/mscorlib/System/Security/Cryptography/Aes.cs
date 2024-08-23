using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000226 RID: 550
	[global::System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[global::Cpp2ILInjected.Token(Token = "0x20002C3")]
	public abstract class Aes : SymmetricAlgorithm
	{
		// Token: 0x060015DB RID: 5595 RVA: 0x0001827B File Offset: 0x0001647B
		[global::Cpp2ILInjected.Token(Token = "0x60017F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF87A4", Offset = "0x1AF87A4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesManaged", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesCryptoServiceProvider", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Aes()
		{
			throw null;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0001827E File Offset: 0x0001647E
		[global::Cpp2ILInjected.Token(Token = "0x60017F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8828", Offset = "0x1AF8828", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public new static Aes Create()
		{
			throw null;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00018281 File Offset: 0x00016481
		[global::Cpp2ILInjected.Token(Token = "0x60017F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF888C", Offset = "0x1AF888C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public new static Aes Create(string algorithmName)
		{
			throw null;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00018284 File Offset: 0x00016484
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8980", Offset = "0x1AF8980", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static Aes()
		{
			throw null;
		}

		// Token: 0x0400099B RID: 2459
		[global::Cpp2ILInjected.Token(Token = "0x4000C75")]
		private static KeySizes[] s_legalBlockSizes;

		// Token: 0x0400099C RID: 2460
		[global::Cpp2ILInjected.Token(Token = "0x4000C76")]
		private static KeySizes[] s_legalKeySizes;
	}
}
