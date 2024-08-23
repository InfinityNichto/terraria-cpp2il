using System;
using System.Collections;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AE RID: 174
	[global::Cpp2ILInjected.Token(Token = "0x200010B")]
	[Serializable]
	public class X509CertificateCollection : CollectionBase
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x00003DB2 File Offset: 0x00001FB2
		[global::Cpp2ILInjected.Token(Token = "0x6000614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED3F1C", Offset = "0x1ED3F1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<>c", Member = "<get_ClientCertificates>b__114_0", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "get_ClientCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public X509CertificateCollection()
		{
			throw null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00003DB5 File Offset: 0x00001FB5
		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED71E0", Offset = "0x1ED71E0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new object[] { typeof(MonoTlsSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		public X509CertificateCollection(X509CertificateCollection value)
		{
			throw null;
		}

		// Token: 0x17000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public X509Certificate this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000616")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED72E4", Offset = "0x1ED72E4", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "DefaultSelectionCallback", MemberParameters = new object[]
			{
				typeof(string),
				typeof(X509CertificateCollection),
				typeof(X509Certificate),
				typeof(string[])
			}, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00003DBB File Offset: 0x00001FBB
		[global::Cpp2ILInjected.Token(Token = "0x6000617")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED720C", Offset = "0x1ED720C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddRange(X509CertificateCollection value)
		{
			throw null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00003DBE File Offset: 0x00001FBE
		[global::Cpp2ILInjected.Token(Token = "0x6000618")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7374", Offset = "0x1ED7374", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list*),
			typeof(X509CertificateCollection),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainPolicy), Member = "get_ExtraStore", ReturnType = typeof(X509Certificate2Collection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new unsafe X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00003DC1 File Offset: 0x00001FC1
		[global::Cpp2ILInjected.Token(Token = "0x6000619")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7480", Offset = "0x1ED7480", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x020003C5 RID: 965
		[global::Cpp2ILInjected.Token(Token = "0x200010C")]
		public class X509CertificateEnumerator : IEnumerator
		{
			// Token: 0x06001D49 RID: 7497 RVA: 0x000080CF File Offset: 0x000062CF
			[global::Cpp2ILInjected.Token(Token = "0x600061A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED73CC", Offset = "0x1ED73CC", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
				throw null;
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06001D4A RID: 7498 RVA: 0x000080D2 File Offset: 0x000062D2
			[global::Cpp2ILInjected.Token(Token = "0x17000148")]
			public unsafe X509Certificate Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600061B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ED7490", Offset = "0x1ED7490", Length = "0xE8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new object[]
				{
					typeof(UnityTls.unitytls_x509list*),
					typeof(X509CertificateCollection),
					typeof(UnityTls.unitytls_errorstate*)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainPolicy), Member = "get_ExtraStore", ReturnType = typeof(X509Certificate2Collection))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06001D4B RID: 7499 RVA: 0x000080D5 File Offset: 0x000062D5
			[global::Cpp2ILInjected.Token(Token = "0x17000149")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x600061C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1ED7578", Offset = "0x1ED7578", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001D4C RID: 7500 RVA: 0x000080D8 File Offset: 0x000062D8
			[global::Cpp2ILInjected.Token(Token = "0x600061D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7614", Offset = "0x1ED7614", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private bool System.Collections.IEnumerator.MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x000080DB File Offset: 0x000062DB
			[global::Cpp2ILInjected.Token(Token = "0x600061E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED76AC", Offset = "0x1ED76AC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x000080DE File Offset: 0x000062DE
			[global::Cpp2ILInjected.Token(Token = "0x600061F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7748", Offset = "0x1ED7748", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new object[]
			{
				typeof(UnityTls.unitytls_x509list*),
				typeof(X509CertificateCollection),
				typeof(UnityTls.unitytls_errorstate*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainPolicy), Member = "get_ExtraStore", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public unsafe bool MoveNext()
			{
				throw null;
			}

			// Token: 0x0400111A RID: 4378
			[global::Cpp2ILInjected.Token(Token = "0x4000505")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private IEnumerator enumerator;
		}
	}
}
