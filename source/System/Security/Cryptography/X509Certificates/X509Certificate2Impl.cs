using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000AB RID: 171
	[global::Cpp2ILInjected.Token(Token = "0x2000108")]
	internal abstract class X509Certificate2Impl : X509CertificateImpl
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600053C RID: 1340
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		public abstract IEnumerable<X509Extension> Extensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
			get;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600053D RID: 1341
		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public abstract X500DistinguishedName IssuerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
			get;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600053E RID: 1342
		// (set) Token: 0x0600053F RID: 1343
		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public abstract AsymmetricAlgorithm PrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
			set;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000540 RID: 1344
		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public abstract string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
			get;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000541 RID: 1345
		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public abstract X500DistinguishedName SubjectName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
			get;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000542 RID: 1346
		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public abstract int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
			get;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000543 RID: 1347
		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		internal abstract X509CertificateImplCollection IntermediateCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
			get;
		}

		// Token: 0x06000544 RID: 1348
		[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
		public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

		// Token: 0x06000545 RID: 1349
		[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
		public abstract bool Verify(X509Certificate2 thisCertificate);

		// Token: 0x06000546 RID: 1350
		[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
		public abstract void AppendPrivateKeyInfo(StringBuilder sb);

		// Token: 0x06000547 RID: 1351 RVA: 0x00003D3D File Offset: 0x00001F3D
		[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED58EC", Offset = "0x1ED58EC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override X509CertificateImpl CopyWithPrivateKey(RSA privateKey)
		{
			throw null;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00003D40 File Offset: 0x00001F40
		[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5998", Offset = "0x1ED5998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		protected X509Certificate2Impl()
		{
			throw null;
		}
	}
}
