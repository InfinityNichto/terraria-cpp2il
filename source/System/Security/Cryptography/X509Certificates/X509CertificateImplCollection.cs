using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AF RID: 175
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	internal class X509CertificateImplCollection : IDisposable
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[global::Cpp2ILInjected.Token(Token = "0x6000620")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6A5C", Offset = "0x1ED6A5C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public X509CertificateImplCollection()
		{
			throw null;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00003DC7 File Offset: 0x00001FC7
		[global::Cpp2ILInjected.Token(Token = "0x6000621")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED77E0", Offset = "0x1ED77E0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private X509CertificateImplCollection(X509CertificateImplCollection other)
		{
			throw null;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00003DCA File Offset: 0x00001FCA
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		public unsafe int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000622")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED79E0", Offset = "0x1ED79E0", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new object[]
			{
				typeof(UnityTls.unitytls_x509list*),
				typeof(X509Certificate),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		public unsafe X509CertificateImpl this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000623")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7A20", Offset = "0x1ED7A20", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new object[]
			{
				typeof(UnityTls.unitytls_x509list*),
				typeof(X509Certificate),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00003DD0 File Offset: 0x00001FD0
		[global::Cpp2ILInjected.Token(Token = "0x6000624")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6ADC", Offset = "0x1ED6ADC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(X509CertificateImpl impl, bool takeOwnership)
		{
			throw null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00003DD3 File Offset: 0x00001FD3
		[global::Cpp2ILInjected.Token(Token = "0x6000625")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5A1C", Offset = "0x1ED5A1C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate2ImplMono) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", MemberParameters = new object[] { typeof(X509CertificateImplCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509CertificateImplCollection Clone()
		{
			throw null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00003DD6 File Offset: 0x00001FD6
		[global::Cpp2ILInjected.Token(Token = "0x6000626")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7A78", Offset = "0x1ED7A78", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00003DD9 File Offset: 0x00001FD9
		[global::Cpp2ILInjected.Token(Token = "0x6000627")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7AE4", Offset = "0x1ED7AE4", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00003DDC File Offset: 0x00001FDC
		[global::Cpp2ILInjected.Token(Token = "0x6000628")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7CEC", Offset = "0x1ED7CEC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0400039C RID: 924
		[global::Cpp2ILInjected.Token(Token = "0x4000506")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<X509CertificateImpl> list;
	}
}
