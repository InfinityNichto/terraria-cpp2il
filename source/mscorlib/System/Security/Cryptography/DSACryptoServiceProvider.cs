using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000275 RID: 629
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000312")]
	public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
	{
		// Token: 0x06001880 RID: 6272 RVA: 0x00018A04 File Offset: 0x00016C04
		[global::Cpp2ILInjected.Token(Token = "0x6001A9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B14EF4", Offset = "0x1B14EF4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public DSACryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00018A07 File Offset: 0x00016C07
		[global::Cpp2ILInjected.Token(Token = "0x6001A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17234", Offset = "0x1B17234", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public DSACryptoServiceProvider(CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00018A0A File Offset: 0x00016C0A
		[global::Cpp2ILInjected.Token(Token = "0x6001A9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B171FC", Offset = "0x1B171FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeDSA", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_DSA", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public DSACryptoServiceProvider(int dwKeySize)
		{
			throw null;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00018A0D File Offset: 0x00016C0D
		[global::Cpp2ILInjected.Token(Token = "0x6001A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17240", Offset = "0x1B17240", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = "Common", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00018A10 File Offset: 0x00016C10
		[global::Cpp2ILInjected.Token(Token = "0x6001A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1729C", Offset = "0x1B1729C", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeySizes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.DSAManaged.KeyGeneratedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "add_KeyGenerated", MemberParameters = new object[] { typeof(Mono.Security.Cryptography.DSAManaged.KeyGeneratedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void Common(int dwKeySize, bool parameters)
		{
			throw null;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00018A13 File Offset: 0x00016C13
		[global::Cpp2ILInjected.Token(Token = "0x6001A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1749C", Offset = "0x1B1749C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CspParameters)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Common(CspParameters parameters)
		{
			throw null;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00018A16 File Offset: 0x00016C16
		[global::Cpp2ILInjected.Token(Token = "0x6001AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17544", Offset = "0x1B17544", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00018A19 File Offset: 0x00016C19
		[global::Cpp2ILInjected.Token(Token = "0x170002F0")]
		public override string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B175E4", Offset = "0x1B175E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00018A1C File Offset: 0x00016C1C
		[global::Cpp2ILInjected.Token(Token = "0x170002F1")]
		public override int KeySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B175EC", Offset = "0x1B175EC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00018A1F File Offset: 0x00016C1F
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x00018A22 File Offset: 0x00016C22
		[global::Cpp2ILInjected.Token(Token = "0x170002F2")]
		public bool PersistKeyInCsp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B175FC", Offset = "0x1B175FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001AA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B17604", Offset = "0x1B17604", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00018A25 File Offset: 0x00016C25
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170002F3")]
		public bool PublicOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B17610", Offset = "0x1B17610", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00018A28 File Offset: 0x00016C28
		[global::Cpp2ILInjected.Token(Token = "0x170002F4")]
		public override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1761C", Offset = "0x1B1761C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00018A2B File Offset: 0x00016C2B
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x00018A2E File Offset: 0x00016C2E
		[global::Cpp2ILInjected.Token(Token = "0x170002F5")]
		public static bool UseMachineKeyStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1765C", Offset = "0x1B1765C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001AA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B176A4", Offset = "0x1B176A4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00018A31 File Offset: 0x00016C31
		[global::Cpp2ILInjected.Token(Token = "0x6001AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B176F0", Offset = "0x1B176F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00018A34 File Offset: 0x00016C34
		[global::Cpp2ILInjected.Token(Token = "0x6001AAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17798", Offset = "0x1B17798", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void ImportParameters(DSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00018A37 File Offset: 0x00016C37
		[global::Cpp2ILInjected.Token(Token = "0x6001AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B177DC", Offset = "0x1B177DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			throw null;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00018A3A File Offset: 0x00016C3A
		[global::Cpp2ILInjected.Token(Token = "0x6001AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B177F0", Offset = "0x1B177F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public byte[] SignData(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00018A3D File Offset: 0x00016C3D
		[global::Cpp2ILInjected.Token(Token = "0x6001AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17834", Offset = "0x1B17834", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public byte[] SignData(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00018A40 File Offset: 0x00016C40
		[global::Cpp2ILInjected.Token(Token = "0x6001AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17890", Offset = "0x1B17890", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public byte[] SignData(global::System.IO.Stream inputStream)
		{
			throw null;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00018A43 File Offset: 0x00016C43
		[global::Cpp2ILInjected.Token(Token = "0x6001AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B178D4", Offset = "0x1B178D4", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			throw null;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00018A46 File Offset: 0x00016C46
		[global::Cpp2ILInjected.Token(Token = "0x6001AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B179D0", Offset = "0x1B179D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool VerifyData(byte[] rgbData, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00018A49 File Offset: 0x00016C49
		[global::Cpp2ILInjected.Token(Token = "0x6001AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17A1C", Offset = "0x1B17A1C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00018A4C File Offset: 0x00016C4C
		[global::Cpp2ILInjected.Token(Token = "0x6001AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17B34", Offset = "0x1B17B34", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			throw null;
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00018A4F File Offset: 0x00016C4F
		[global::Cpp2ILInjected.Token(Token = "0x6001AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17B48", Offset = "0x1B17B48", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(HashAlgorithmName),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00018A52 File Offset: 0x00016C52
		[global::Cpp2ILInjected.Token(Token = "0x6001AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17C24", Offset = "0x1B17C24", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(HashAlgorithmName),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override byte[] HashData(global::System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00018A55 File Offset: 0x00016C55
		[global::Cpp2ILInjected.Token(Token = "0x6001AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17CE8", Offset = "0x1B17CE8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "Clear", ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00018A58 File Offset: 0x00016C58
		[global::Cpp2ILInjected.Token(Token = "0x6001AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17D34", Offset = "0x1B17D34", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "set_KeyValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
		private void OnKeyGenerated(object sender, global::System.EventArgs e)
		{
			throw null;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00018A5B File Offset: 0x00016C5B
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::System.MonoTODO("call into KeyPairPersistence to get details")]
		[global::Cpp2ILInjected.Token(Token = "0x170002F6")]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B17DA8", Offset = "0x1B17DA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00018A5E File Offset: 0x00016C5E
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17DB0", Offset = "0x1B17DB0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "ToCapiPrivateKeyBlob", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "ToCapiPublicKeyBlob", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00018A61 File Offset: 0x00016C61
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B17DC4", Offset = "0x1B17DC4", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiKeyBlobDSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void ImportCspBlob(byte[] keyBlob)
		{
			throw null;
		}

		// Token: 0x04000AB8 RID: 2744
		[global::Cpp2ILInjected.Token(Token = "0x4000D92")]
		private const int PROV_DSS_DH = 13;

		// Token: 0x04000AB9 RID: 2745
		[global::Cpp2ILInjected.Token(Token = "0x4000D93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Mono.Security.Cryptography.KeyPairPersistence store;

		// Token: 0x04000ABA RID: 2746
		[global::Cpp2ILInjected.Token(Token = "0x4000D94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool persistKey;

		// Token: 0x04000ABB RID: 2747
		[global::Cpp2ILInjected.Token(Token = "0x4000D95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool persisted;

		// Token: 0x04000ABC RID: 2748
		[global::Cpp2ILInjected.Token(Token = "0x4000D96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool privateKeyExportable;

		// Token: 0x04000ABD RID: 2749
		[global::Cpp2ILInjected.Token(Token = "0x4000D97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool m_disposed;

		// Token: 0x04000ABE RID: 2750
		[global::Cpp2ILInjected.Token(Token = "0x4000D98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Mono.Security.Cryptography.DSAManaged dsa;

		// Token: 0x04000ABF RID: 2751
		[global::Cpp2ILInjected.Token(Token = "0x4000D99")]
		private static bool useMachineKeyStore;
	}
}
