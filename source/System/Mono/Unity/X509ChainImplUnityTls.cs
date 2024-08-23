using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace Mono.Unity
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	internal class X509ChainImplUnityTls : X509ChainImpl
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002F27 File Offset: 0x00001127
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D46008", Offset = "0x1D46008", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(ChainValidationHelper),
			typeof(string),
			typeof(bool),
			typeof(X509CertificateCollection),
			typeof(bool),
			typeof(ref X509Chain),
			typeof(ref SslPolicyErrors),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImpl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe X509ChainImplUnityTls(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false)
		{
			throw null;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002F2A File Offset: 0x0000112A
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public override bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D473A8", Offset = "0x1D473A8", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002F2D File Offset: 0x0000112D
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		internal UnityTls.unitytls_x509list_ref NativeCertificateChain
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D473C8", Offset = "0x1D473C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002F30 File Offset: 0x00001130
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public override X509ChainElementCollection ChainElements
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D473D0", Offset = "0x1D473D0", Length = "0x2AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImpl), Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002F33 File Offset: 0x00001133
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4767C", Offset = "0x1D4767C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<X509ChainStatus>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainStatus), Member = ".ctor", MemberParameters = new object[] { typeof(X509ChainStatusFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void AddStatus(X509ChainStatusFlags error)
		{
			throw null;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002F36 File Offset: 0x00001136
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public override X509ChainPolicy ChainPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47780", Offset = "0x1D47780", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002F39 File Offset: 0x00001139
		[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47788", Offset = "0x1D47788", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Build(X509Certificate2 certificate)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002F3C File Offset: 0x0000113C
		[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47790", Offset = "0x1D47790", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(UnityTls.unitytls_interface_struct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "Clear", ReturnType = typeof(void))]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002F3F File Offset: 0x0000113F
		[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D477C4", Offset = "0x1D477C4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainImpl), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509ChainElementCollection elements;

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private UnityTls.unitytls_x509list_ref nativeCertificateChain;

		// Token: 0x0400001C RID: 28
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509ChainPolicy policy;

		// Token: 0x0400001D RID: 29
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<X509ChainStatus> chainStatusList;

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool reverseOrder;
	}
}
