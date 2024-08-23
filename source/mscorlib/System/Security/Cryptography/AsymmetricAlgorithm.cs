using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000227 RID: 551
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002C4")]
	public abstract class AsymmetricAlgorithm : global::System.IDisposable
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x00018287 File Offset: 0x00016487
		[global::Cpp2ILInjected.Token(Token = "0x60017F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8AF4", Offset = "0x1AF8AF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AsymmetricAlgorithm()
		{
			throw null;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0001828A File Offset: 0x0001648A
		[global::Cpp2ILInjected.Token(Token = "0x60017FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8AFC", Offset = "0x1AF8AFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "Create", MemberParameters = new object[] { typeof(DSAParameters) }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Create", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0001828D File Offset: 0x0001648D
		[global::Cpp2ILInjected.Token(Token = "0x60017FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8B00", Offset = "0x1AF8B00", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00018290 File Offset: 0x00016490
		[global::Cpp2ILInjected.Token(Token = "0x60017FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8B6C", Offset = "0x1AF8B6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00018293 File Offset: 0x00016493
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00018296 File Offset: 0x00016496
		[global::Cpp2ILInjected.Token(Token = "0x17000283")]
		public virtual int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8B70", Offset = "0x1AF8B70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60017FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8B78", Offset = "0x1AF8B78", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RSAManaged", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00018299 File Offset: 0x00016499
		[global::Cpp2ILInjected.Token(Token = "0x17000284")]
		public virtual KeySizes[] LegalKeySizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8C60", Offset = "0x1AF8C60", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x0001829C File Offset: 0x0001649C
		[global::Cpp2ILInjected.Token(Token = "0x17000285")]
		public virtual string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001800")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8CD0", Offset = "0x1AF8CD0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0001829F File Offset: 0x0001649F
		[global::Cpp2ILInjected.Token(Token = "0x17000286")]
		public virtual string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001801")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF8D08", Offset = "0x1AF8D08", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000182A2 File Offset: 0x000164A2
		[global::Cpp2ILInjected.Token(Token = "0x6001802")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8D40", Offset = "0x1AF8D40", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AsymmetricAlgorithm Create()
		{
			throw null;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000182A5 File Offset: 0x000164A5
		[global::Cpp2ILInjected.Token(Token = "0x6001803")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8D94", Offset = "0x1AF8D94", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static AsymmetricAlgorithm Create(string algName)
		{
			throw null;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000182A8 File Offset: 0x000164A8
		[global::Cpp2ILInjected.Token(Token = "0x6001804")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8E38", Offset = "0x1AF8E38", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void FromXmlString(string xmlString)
		{
			throw null;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000182AB File Offset: 0x000164AB
		[global::Cpp2ILInjected.Token(Token = "0x6001805")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8E70", Offset = "0x1AF8E70", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual string ToXmlString(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000182AE File Offset: 0x000164AE
		[global::Cpp2ILInjected.Token(Token = "0x6001806")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8EA8", Offset = "0x1AF8EA8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(global::System.ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters)
		{
			throw null;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000182B1 File Offset: 0x000164B1
		[global::Cpp2ILInjected.Token(Token = "0x6001807")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8EE0", Offset = "0x1AF8EE0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(global::System.ReadOnlySpan<char> password, PbeParameters pbeParameters)
		{
			throw null;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000182B4 File Offset: 0x000164B4
		[global::Cpp2ILInjected.Token(Token = "0x6001808")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8F18", Offset = "0x1AF8F18", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual byte[] ExportPkcs8PrivateKey()
		{
			throw null;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000182B7 File Offset: 0x000164B7
		[global::Cpp2ILInjected.Token(Token = "0x6001809")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8F50", Offset = "0x1AF8F50", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual byte[] ExportSubjectPublicKeyInfo()
		{
			throw null;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000182BA File Offset: 0x000164BA
		[global::Cpp2ILInjected.Token(Token = "0x600180A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8F88", Offset = "0x1AF8F88", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void ImportEncryptedPkcs8PrivateKey(global::System.ReadOnlySpan<byte> passwordBytes, global::System.ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw null;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000182BD File Offset: 0x000164BD
		[global::Cpp2ILInjected.Token(Token = "0x600180B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8FC0", Offset = "0x1AF8FC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void ImportEncryptedPkcs8PrivateKey(global::System.ReadOnlySpan<char> password, global::System.ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000182C0 File Offset: 0x000164C0
		[global::Cpp2ILInjected.Token(Token = "0x600180C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8FF8", Offset = "0x1AF8FF8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void ImportPkcs8PrivateKey(global::System.ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw null;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000182C3 File Offset: 0x000164C3
		[global::Cpp2ILInjected.Token(Token = "0x600180D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9030", Offset = "0x1AF9030", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void ImportSubjectPublicKeyInfo(global::System.ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw null;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x000182C6 File Offset: 0x000164C6
		[global::Cpp2ILInjected.Token(Token = "0x600180E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9068", Offset = "0x1AF9068", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryExportEncryptedPkcs8PrivateKey(global::System.ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters, global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x000182C9 File Offset: 0x000164C9
		[global::Cpp2ILInjected.Token(Token = "0x600180F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF90A0", Offset = "0x1AF90A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryExportEncryptedPkcs8PrivateKey(global::System.ReadOnlySpan<char> password, PbeParameters pbeParameters, global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x000182CC File Offset: 0x000164CC
		[global::Cpp2ILInjected.Token(Token = "0x6001810")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF90D8", Offset = "0x1AF90D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryExportPkcs8PrivateKey(global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x000182CF File Offset: 0x000164CF
		[global::Cpp2ILInjected.Token(Token = "0x6001811")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF9110", Offset = "0x1AF9110", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryExportSubjectPublicKeyInfo(global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x0400099D RID: 2461
		[global::Cpp2ILInjected.Token(Token = "0x4000C77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected int KeySizeValue;

		// Token: 0x0400099E RID: 2462
		[global::Cpp2ILInjected.Token(Token = "0x4000C78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected KeySizes[] LegalKeySizesValue;
	}
}
