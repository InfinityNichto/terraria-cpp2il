using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography.Pal;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AD RID: 173
	[global::Cpp2ILInjected.Token(Token = "0x200010A")]
	internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x00003D79 File Offset: 0x00001F79
		[global::Cpp2ILInjected.Token(Token = "0x6000600")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED6DAC", Offset = "0x1ED6DAC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_KeyAlgorithm", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_KeyAlgorithmParameters", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_PublicKeyValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SignatureAlgorithm", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Version", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_RawData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Thumbprint", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "GetNameInfo", MemberParameters = new object[]
		{
			typeof(X509NameType),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Extensions", ReturnType = typeof(IEnumerable<X509Extension>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_NotAfter", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_NotBefore", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureCertData()
		{
			throw null;
		}

		// Token: 0x0600055C RID: 1372
		[global::Cpp2ILInjected.Token(Token = "0x6000601")]
		protected abstract byte[] GetRawCertData();

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00003D7C File Offset: 0x00001F7C
		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public sealed override string KeyAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000602")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6E2C", Offset = "0x1ED6E2C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00003D7F File Offset: 0x00001F7F
		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public sealed override byte[] KeyAlgorithmParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000603")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6E44", Offset = "0x1ED6E44", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00003D82 File Offset: 0x00001F82
		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public sealed override byte[] PublicKeyValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000604")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6E5C", Offset = "0x1ED6E5C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00003D85 File Offset: 0x00001F85
		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public sealed override byte[] SerialNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000605")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6E74", Offset = "0x1ED6E74", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00003D88 File Offset: 0x00001F88
		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public sealed override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000606")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6E8C", Offset = "0x1ED6E8C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00003D8B File Offset: 0x00001F8B
		[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
		public sealed override int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000607")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6EA4", Offset = "0x1ED6EA4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00003D8E File Offset: 0x00001F8E
		[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
		public sealed override X500DistinguishedName SubjectName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000608")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6EC0", Offset = "0x1ED6EC0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00003D91 File Offset: 0x00001F91
		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		public sealed override X500DistinguishedName IssuerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000609")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6ED8", Offset = "0x1ED6ED8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00003D94 File Offset: 0x00001F94
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		public sealed override string Subject
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6EF0", Offset = "0x1ED6EF0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00003D97 File Offset: 0x00001F97
		[global::Cpp2ILInjected.Token(Token = "0x17000141")]
		public sealed override string Issuer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6F10", Offset = "0x1ED6F10", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00003D9A File Offset: 0x00001F9A
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public sealed override byte[] RawData
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6F30", Offset = "0x1ED6F30", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00003D9D File Offset: 0x00001F9D
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public sealed override byte[] Thumbprint
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED6F48", Offset = "0x1ED6F48", Length = "0x188")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00003DA0 File Offset: 0x00001FA0
		[global::Cpp2ILInjected.Token(Token = "0x600060E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED70D0", Offset = "0x1ED70D0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new object[]
		{
			typeof(X509NameType),
			typeof(bool)
		}, ReturnType = typeof(string))]
		public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			throw null;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00003DA3 File Offset: 0x00001FA3
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public sealed override IEnumerable<X509Extension> Extensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x600060F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7104", Offset = "0x1ED7104", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00003DA6 File Offset: 0x00001FA6
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public sealed override DateTime NotAfter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000610")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED711C", Offset = "0x1ED711C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00003DA9 File Offset: 0x00001FA9
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		public sealed override DateTime NotBefore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000611")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED7138", Offset = "0x1ED7138", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00003DAC File Offset: 0x00001FAC
		[global::Cpp2ILInjected.Token(Token = "0x6000612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED7154", Offset = "0x1ED7154", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public sealed override void AppendPrivateKeyInfo(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00003DAF File Offset: 0x00001FAF
		[global::Cpp2ILInjected.Token(Token = "0x6000613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED59D8", Offset = "0x1ED59D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		protected X509Certificate2ImplUnix()
		{
			throw null;
		}

		// Token: 0x0400039A RID: 922
		[global::Cpp2ILInjected.Token(Token = "0x4000503")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool readCertData;

		// Token: 0x0400039B RID: 923
		[global::Cpp2ILInjected.Token(Token = "0x4000504")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CertificateData certData;
	}
}
