using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B4 RID: 180
	[global::Cpp2ILInjected.Token(Token = "0x2000112")]
	internal abstract class X509ChainImpl : IDisposable
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005A3 RID: 1443
		[global::Cpp2ILInjected.Token(Token = "0x17000158")]
		public abstract bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064E")]
			get;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00003E4E File Offset: 0x0000204E
		[global::Cpp2ILInjected.Token(Token = "0x600064F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8E58", Offset = "0x1ED8E58", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void ThrowIfContextInvalid()
		{
			throw null;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005A5 RID: 1445
		[global::Cpp2ILInjected.Token(Token = "0x17000159")]
		public abstract X509ChainElementCollection ChainElements
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000650")]
			get;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005A6 RID: 1446
		[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
		public abstract X509ChainPolicy ChainPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000651")]
			get;
		}

		// Token: 0x060005A7 RID: 1447
		[global::Cpp2ILInjected.Token(Token = "0x6000652")]
		public abstract bool Build(X509Certificate2 certificate);

		// Token: 0x060005A8 RID: 1448
		[global::Cpp2ILInjected.Token(Token = "0x6000653")]
		public abstract void AddStatus(X509ChainStatusFlags errorCode);

		// Token: 0x060005A9 RID: 1449
		[global::Cpp2ILInjected.Token(Token = "0x6000654")]
		public abstract void Reset();

		// Token: 0x060005AA RID: 1450 RVA: 0x00003E51 File Offset: 0x00002051
		[global::Cpp2ILInjected.Token(Token = "0x6000655")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7F80", Offset = "0x1ED7F80", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Chain), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00003E54 File Offset: 0x00002054
		[global::Cpp2ILInjected.Token(Token = "0x6000656")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8E98", Offset = "0x1ED8E98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00003E57 File Offset: 0x00002057
		[global::Cpp2ILInjected.Token(Token = "0x6000657")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8E9C", Offset = "0x1ED8E9C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003E5A File Offset: 0x0000205A
		[global::Cpp2ILInjected.Token(Token = "0x6000658")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8F3C", Offset = "0x1ED8F3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected X509ChainImpl()
		{
			throw null;
		}
	}
}
