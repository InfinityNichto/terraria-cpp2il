using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public class PKCS12 : ICloneable
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002FC4 File Offset: 0x000011C4
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7B8DC", Offset = "0x1A7B8DC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PKCS12()
		{
			throw null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002FC7 File Offset: 0x000011C7
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7B9B4", Offset = "0x1A7B9B4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PKCS12))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public PKCS12(byte[] data)
		{
			throw null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002FCA File Offset: 0x000011CA
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7C220", Offset = "0x1A7C220", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "LoadFromFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(PKCS12))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public PKCS12(byte[] data, string password)
		{
			throw null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002FCD File Offset: 0x000011CD
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7C258", Offset = "0x1A7C258", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public PKCS12(byte[] data, byte[] password)
		{
			throw null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002FD0 File Offset: 0x000011D0
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7BB94", Offset = "0x1A7BB94", Length = "0x68C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "MAC", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.EncryptedData), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[] { typeof(PKCS7.EncryptedData) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private void Decode(byte[] data)
		{
			throw null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002FD3 File Offset: 0x000011D3
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7CB08", Offset = "0x1A7CB08", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002FD6 File Offset: 0x000011D6
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7B9E8", Offset = "0x1A7B9E8", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002FD9 File Offset: 0x000011D9
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002FDC File Offset: 0x000011DC
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public int IterationCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000050")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7CBB4", Offset = "0x1A7CBB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000051")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7CBBC", Offset = "0x1A7CBBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002FDF File Offset: 0x000011DF
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public ArrayList Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000052")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7CBC4", Offset = "0x1A7CBC4", Length = "0x5F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string)
			}, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_EncryptedData", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(int),
				typeof(byte[])
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(DSAParameters)
			}, ReturnType = typeof(DSA))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = "ReadOnly", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002FE2 File Offset: 0x000011E2
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public ArrayList Secrets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000053")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7D348", Offset = "0x1A7D348", Length = "0x36C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = "ReadOnly", MemberParameters = new object[] { typeof(ArrayList) }, ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002FE5 File Offset: 0x000011E5
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public X509CertificateCollection Certificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000054")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7D6B4", Offset = "0x1A7D6B4", Length = "0x3D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(string)
			}, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(DSAParameters))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002FE8 File Offset: 0x000011E8
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		internal RandomNumberGenerator RNG
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000055")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7DA84", Offset = "0x1A7DA84", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002FEB File Offset: 0x000011EB
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7C3C0", Offset = "0x1A7C3C0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Compare(byte[] expected, byte[] actual)
		{
			throw null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002FEE File Offset: 0x000011EE
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7DAA4", Offset = "0x1A7DAA4", Length = "0x57C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "set_Password", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "set_Salt", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "DeriveKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "DeriveIV", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount)
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002FF1 File Offset: 0x000011F1
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7D1B8", Offset = "0x1A7D1B8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[] { typeof(PKCS7.EncryptedData) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemovePkcs8ShroudedKeyBag", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(SymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData)
		{
			throw null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002FF4 File Offset: 0x000011F4
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7CA90", Offset = "0x1A7CA90", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.EncryptedData), Member = "get_EncryptedContent", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		public byte[] Decrypt(PKCS7.EncryptedData ed)
		{
			throw null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002FF7 File Offset: 0x000011F7
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7E26C", Offset = "0x1A7E26C", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string)
		}, ReturnType = typeof(PKCS7.ContentInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(SymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data)
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002FFA File Offset: 0x000011FA
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7E49C", Offset = "0x1A7E49C", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new object[] { typeof(PKCS8.PrivateKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private DSAParameters GetExistingParameters(out bool found)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FFD File Offset: 0x000011FD
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7E990", Offset = "0x1A7E990", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(DSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003000 File Offset: 0x00001200
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7C410", Offset = "0x1A7C410", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new object[] { typeof(PKCS8.PrivateKeyInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_EncryptedData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private void ReadSafeBag(ASN1 safeBag)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003003 File Offset: 0x00001203
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7EBDC", Offset = "0x1A7EBDC", Length = "0xD30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "set_PrivateKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "set_IterationCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "set_EncryptedData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003006 File Offset: 0x00001206
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7F90C", Offset = "0x1A7F90C", Length = "0xC90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddKeyBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "set_PrivateKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 64)]
		private ASN1 KeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003009 File Offset: 0x00001209
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8059C", Offset = "0x1A8059C", Length = "0xACC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddSecretBag", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		private ASN1 SecretBagSafeBag(byte[] secret, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000300C File Offset: 0x0000120C
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A81068", Offset = "0x1A81068", Length = "0xB64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 56)]
		private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000300F File Offset: 0x0000120F
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7C288", Offset = "0x1A7C288", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "set_Password", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "set_Salt", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "Create", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "DeriveMAC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003012 File Offset: 0x00001212
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A81C3C", Offset = "0x1A81C3C", Length = "0x2060")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "SaveToFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string)
		}, ReturnType = typeof(PKCS7.ContentInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "MAC", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 143)]
		public byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003015 File Offset: 0x00001215
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A83CAC", Offset = "0x1A83CAC", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003018 File Offset: 0x00001218
		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A83CA4", Offset = "0x1A83CA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		public void AddCertificate(X509Certificate cert)
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000301B File Offset: 0x0000121B
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A83F88", Offset = "0x1A83F88", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000301E File Offset: 0x0000121E
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A83C9C", Offset = "0x1A83C9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		public void RemoveCertificate(X509Certificate cert)
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003021 File Offset: 0x00001221
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A841EC", Offset = "0x1A841EC", Length = "0x518")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003024 File Offset: 0x00001224
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A84704", Offset = "0x1A84704", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemovePkcs8ShroudedKeyBag", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddKeyBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemoveKeyBag", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003027 File Offset: 0x00001227
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A84794", Offset = "0x1A84794", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000302A File Offset: 0x0000122A
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8479C", Offset = "0x1A8479C", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_EncryptedData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "CompareAsymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(AsymmetricAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000302D File Offset: 0x0000122D
		[global::Cpp2ILInjected.Token(Token = "0x600006C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A84AD4", Offset = "0x1A84AD4", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_EncryptedData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "CompareAsymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(AsymmetricAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void RemovePkcs8ShroudedKeyBag(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003030 File Offset: 0x00001230
		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A84DC0", Offset = "0x1A84DC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddKeyBag(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003033 File Offset: 0x00001233
		[global::Cpp2ILInjected.Token(Token = "0x600006E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A84DC8", Offset = "0x1A84DC8", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "CompareAsymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(AsymmetricAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void AddKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003036 File Offset: 0x00001236
		[global::Cpp2ILInjected.Token(Token = "0x600006F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8505C", Offset = "0x1A8505C", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "CompareAsymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(AsymmetricAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void RemoveKeyBag(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003039 File Offset: 0x00001239
		[global::Cpp2ILInjected.Token(Token = "0x6000070")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A852A8", Offset = "0x1A852A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddSecretBag(byte[] secret)
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000303C File Offset: 0x0000123C
		[global::Cpp2ILInjected.Token(Token = "0x6000071")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A852B0", Offset = "0x1A852B0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "SecretBagSafeBag", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddSecretBag(byte[] secret, IDictionary attributes)
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000303F File Offset: 0x0000123F
		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A85470", Offset = "0x1A85470", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void RemoveSecretBag(byte[] secret)
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003042 File Offset: 0x00001242
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A855E8", Offset = "0x1A855E8", Length = "0x910")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_EncryptedData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public AsymmetricAlgorithm GetAsymmetricAlgorithm(IDictionary attrs)
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003045 File Offset: 0x00001245
		[global::Cpp2ILInjected.Token(Token = "0x6000074")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A85EF8", Offset = "0x1A85EF8", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public byte[] GetSecret(IDictionary attrs)
		{
			throw null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003048 File Offset: 0x00001248
		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A86578", Offset = "0x1A86578", Length = "0x6F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public X509Certificate GetCertificate(IDictionary attrs)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000304B File Offset: 0x0000124B
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A86C6C", Offset = "0x1A86C6C", Length = "0x790")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "get_PrivateKey", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_Salt", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "get_EncryptedData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "CompareAsymmetricAlgorithm", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(AsymmetricAlgorithm)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public IDictionary GetAttributes(AsymmetricAlgorithm aa)
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000304E File Offset: 0x0000124E
		[global::Cpp2ILInjected.Token(Token = "0x6000077")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A873FC", Offset = "0x1A873FC", Length = "0x5E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS7.ContentInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public IDictionary GetAttributes(X509Certificate cert)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003051 File Offset: 0x00001251
		[global::Cpp2ILInjected.Token(Token = "0x6000078")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A879E4", Offset = "0x1A879E4", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void SaveToFile(string filename)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003054 File Offset: 0x00001254
		[global::Cpp2ILInjected.Token(Token = "0x6000079")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A87BC8", Offset = "0x1A87BC8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003057 File Offset: 0x00001257
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000305A File Offset: 0x0000125A
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public static int MaximumPasswordLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A87C84", Offset = "0x1A87C84", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A87CDC", Offset = "0x1A87CDC", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000305D File Offset: 0x0000125D
		[global::Cpp2ILInjected.Token(Token = "0x600007C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A87DD8", Offset = "0x1A87DD8", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "LoadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PKCS12))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "LoadFromFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(PKCS12))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static byte[] LoadFile(string filename)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003060 File Offset: 0x00001260
		[global::Cpp2ILInjected.Token(Token = "0x600007D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A87FC8", Offset = "0x1A87FC8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "LoadFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static PKCS12 LoadFromFile(string filename)
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003063 File Offset: 0x00001263
		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A8808C", Offset = "0x1A8808C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = "LoadFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static PKCS12 LoadFromFile(string filename, string password)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003066 File Offset: 0x00001266
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A88158", Offset = "0x1A88158", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PKCS12()
		{
			throw null;
		}

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		public const string pbeWithSHAAnd128BitRC4 = "1.2.840.113549.1.12.1.1";

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		public const string pbeWithSHAAnd40BitRC4 = "1.2.840.113549.1.12.1.2";

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		public const string pbeWithSHAAnd3KeyTripleDESCBC = "1.2.840.113549.1.12.1.3";

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		public const string pbeWithSHAAnd2KeyTripleDESCBC = "1.2.840.113549.1.12.1.4";

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		public const string pbeWithSHAAnd128BitRC2CBC = "1.2.840.113549.1.12.1.5";

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		public const string pbeWithSHAAnd40BitRC2CBC = "1.2.840.113549.1.12.1.6";

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		public const string keyBag = "1.2.840.113549.1.12.10.1.1";

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		public const string pkcs8ShroudedKeyBag = "1.2.840.113549.1.12.10.1.2";

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		public const string certBag = "1.2.840.113549.1.12.10.1.3";

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		public const string crlBag = "1.2.840.113549.1.12.10.1.4";

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		public const string secretBag = "1.2.840.113549.1.12.10.1.5";

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		public const string safeContentsBag = "1.2.840.113549.1.12.10.1.6";

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		public const string x509Certificate = "1.2.840.113549.1.9.22.1";

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		public const string sdsiCertificate = "1.2.840.113549.1.9.22.2";

		// Token: 0x0400001C RID: 28
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		public const string x509Crl = "1.2.840.113549.1.9.23.1";

		// Token: 0x0400001D RID: 29
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		private const int recommendedIterationCount = 2000;

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] _password;

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ArrayList _keyBags;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ArrayList _secretBags;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509CertificateCollection _certs;

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _keyBagsChanged;

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool _secretBagsChanged;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool _certsChanged;

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _iterations;

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ArrayList _safeBags;

		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private RandomNumberGenerator _rng;

		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		public const int CryptoApiPasswordLimit = 32;

		// Token: 0x04000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		private static int password_max_length;

		// Token: 0x0200005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x200000F")]
		public class DeriveBytes
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x000036F6 File Offset: 0x000018F6
			[global::Cpp2ILInjected.Token(Token = "0x6000080")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7E020", Offset = "0x1A7E020", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DeriveBytes()
			{
				throw null;
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060002A2 RID: 674 RVA: 0x000036F9 File Offset: 0x000018F9
			// (set) Token: 0x060002A3 RID: 675 RVA: 0x000036FC File Offset: 0x000018FC
			[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
			public string HashName
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000081")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A881A4", Offset = "0x1A881A4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000082")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A881AC", Offset = "0x1A881AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060002A4 RID: 676 RVA: 0x000036FF File Offset: 0x000018FF
			// (set) Token: 0x060002A5 RID: 677 RVA: 0x00003702 File Offset: 0x00001902
			[global::Cpp2ILInjected.Token(Token = "0x17000020")]
			public int IterationCount
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000083")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A881B4", Offset = "0x1A881B4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000084")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A881BC", Offset = "0x1A881BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060002A6 RID: 678 RVA: 0x00003705 File Offset: 0x00001905
			// (set) Token: 0x060002A7 RID: 679 RVA: 0x00003708 File Offset: 0x00001908
			[global::Cpp2ILInjected.Token(Token = "0x17000021")]
			public byte[] Password
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000085")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A881C4", Offset = "0x1A881C4", Length = "0x70")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000086")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7E028", Offset = "0x1A7E028", Length = "0xBC")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
				{
					typeof(string),
					typeof(byte[]),
					typeof(int)
				}, ReturnType = typeof(SymmetricAlgorithm))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "MAC", MemberParameters = new object[]
				{
					typeof(byte[]),
					typeof(byte[]),
					typeof(int),
					typeof(byte[])
				}, ReturnType = typeof(byte[]))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000370B File Offset: 0x0000190B
			// (set) Token: 0x060002A9 RID: 681 RVA: 0x0000370E File Offset: 0x0000190E
			[global::Cpp2ILInjected.Token(Token = "0x17000022")]
			public byte[] Salt
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000087")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A88234", Offset = "0x1A88234", Length = "0x70")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000088")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A7E0E4", Offset = "0x1A7E0E4", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
				{
					typeof(string),
					typeof(byte[]),
					typeof(int)
				}, ReturnType = typeof(SymmetricAlgorithm))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "MAC", MemberParameters = new object[]
				{
					typeof(byte[]),
					typeof(byte[]),
					typeof(int),
					typeof(byte[])
				}, ReturnType = typeof(byte[]))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00003711 File Offset: 0x00001911
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A882A4", Offset = "0x1A882A4", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12.DeriveBytes), Member = "Derive", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			private void Adjust(byte[] a, int aOff, byte[] b)
			{
				throw null;
			}

			// Token: 0x060002AB RID: 683 RVA: 0x00003714 File Offset: 0x00001914
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A8831C", Offset = "0x1A8831C", Length = "0x3B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12.DeriveBytes), Member = "DeriveKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12.DeriveBytes), Member = "DeriveIV", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12.DeriveBytes), Member = "DeriveMAC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "Adjust", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			private byte[] Derive(byte[] diversifier, int n)
			{
				throw null;
			}

			// Token: 0x060002AC RID: 684 RVA: 0x00003717 File Offset: 0x00001917
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7E18C", Offset = "0x1A7E18C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(SymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "Derive", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public byte[] DeriveKey(int size)
			{
				throw null;
			}

			// Token: 0x060002AD RID: 685 RVA: 0x0000371A File Offset: 0x0000191A
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7E1FC", Offset = "0x1A7E1FC", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetSymmetricAlgorithm", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(SymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "Derive", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public byte[] DeriveIV(int size)
			{
				throw null;
			}

			// Token: 0x060002AE RID: 686 RVA: 0x0000371D File Offset: 0x0000191D
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A81BCC", Offset = "0x1A81BCC", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "MAC", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[]),
				typeof(int),
				typeof(byte[])
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS12.DeriveBytes), Member = "Derive", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public byte[] DeriveMAC(int size)
			{
				throw null;
			}

			// Token: 0x060002AF RID: 687 RVA: 0x00003720 File Offset: 0x00001920
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600008E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A886D0", Offset = "0x1A886D0", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			static DeriveBytes()
			{
				throw null;
			}

			// Token: 0x040002AE RID: 686
			[global::Cpp2ILInjected.Token(Token = "0x400003F")]
			private static byte[] keyDiversifier;

			// Token: 0x040002AF RID: 687
			[global::Cpp2ILInjected.Token(Token = "0x4000040")]
			private static byte[] ivDiversifier;

			// Token: 0x040002B0 RID: 688
			[global::Cpp2ILInjected.Token(Token = "0x4000041")]
			private static byte[] macDiversifier;

			// Token: 0x040002B1 RID: 689
			[global::Cpp2ILInjected.Token(Token = "0x4000042")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _hashName;

			// Token: 0x040002B2 RID: 690
			[global::Cpp2ILInjected.Token(Token = "0x4000043")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _iterations;

			// Token: 0x040002B3 RID: 691
			[global::Cpp2ILInjected.Token(Token = "0x4000044")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private byte[] _password;

			// Token: 0x040002B4 RID: 692
			[global::Cpp2ILInjected.Token(Token = "0x4000045")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private byte[] _salt;

			// Token: 0x02000081 RID: 129
			[global::Cpp2ILInjected.Token(Token = "0x2000010")]
			public enum Purpose
			{
				// Token: 0x040002D1 RID: 721
				[global::Cpp2ILInjected.Token(Token = "0x4000047")]
				Key,
				// Token: 0x040002D2 RID: 722
				[global::Cpp2ILInjected.Token(Token = "0x4000048")]
				IV,
				// Token: 0x040002D3 RID: 723
				[global::Cpp2ILInjected.Token(Token = "0x4000049")]
				MAC
			}
		}
	}
}
