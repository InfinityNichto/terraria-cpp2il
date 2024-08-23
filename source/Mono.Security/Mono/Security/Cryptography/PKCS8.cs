using System;
using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.X509;
using Mono.Unity;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200003E RID: 62
	[global::Cpp2ILInjected.Token(Token = "0x2000059")]
	public sealed class PKCS8
	{
		// Token: 0x02000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x200005A")]
		public class PrivateKeyInfo
		{
			// Token: 0x060002D9 RID: 729 RVA: 0x0000379E File Offset: 0x0000199E
			[global::Cpp2ILInjected.Token(Token = "0x6000266")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9F0C0", Offset = "0x1A9F0C0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public PrivateKeyInfo()
			{
				throw null;
			}

			// Token: 0x060002DA RID: 730 RVA: 0x000037A1 File Offset: 0x000019A1
			[global::Cpp2ILInjected.Token(Token = "0x6000267")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9F128", Offset = "0x1A9F128", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = ".ctor", ReturnType = typeof(void))]
			public PrivateKeyInfo(byte[] data)
			{
				throw null;
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060002DB RID: 731 RVA: 0x000037A4 File Offset: 0x000019A4
			// (set) Token: 0x060002DC RID: 732 RVA: 0x000037A7 File Offset: 0x000019A7
			[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
			public string Algorithm
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000268")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A9F370", Offset = "0x1A9F370", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000269")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A9F378", Offset = "0x1A9F378", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060002DD RID: 733 RVA: 0x000037AA File Offset: 0x000019AA
			// (set) Token: 0x060002DE RID: 734 RVA: 0x000037AD File Offset: 0x000019AD
			[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
			public byte[] PrivateKey
			{
				[global::Cpp2ILInjected.Token(Token = "0x600026A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A9F380", Offset = "0x1A9F380", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new object[] { typeof(PKCS8.PrivateKeyInfo) }, ReturnType = typeof(void))]
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
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600026B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A9F3F4", Offset = "0x1A9F3F4", Length = "0xF0")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(ASN1))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(ASN1))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060002DF RID: 735 RVA: 0x000037B0 File Offset: 0x000019B0
			[global::Cpp2ILInjected.Token(Token = "0x600026C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9F150", Offset = "0x1A9F150", Length = "0x220")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			private void Decode(byte[] data)
			{
				throw null;
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x000037B3 File Offset: 0x000019B3
			[global::Cpp2ILInjected.Token(Token = "0x600026D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9F4E4", Offset = "0x1A9F4E4", Length = "0x454")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			public byte[] GetBytes()
			{
				throw null;
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x000037B6 File Offset: 0x000019B6
			[global::Cpp2ILInjected.Token(Token = "0x600026E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9F938", Offset = "0x1A9F938", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Normalize", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static byte[] RemoveLeadingZero(byte[] bigInt)
			{
				throw null;
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x000037B9 File Offset: 0x000019B9
			[global::Cpp2ILInjected.Token(Token = "0x600026F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9F9C4", Offset = "0x1A9F9C4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "DecodeDSA", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(DSAParameters)
			}, ReturnType = typeof(DSA))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "RemoveLeadingZero", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static byte[] Normalize(byte[] bigInt, int length)
			{
				throw null;
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x000037BC File Offset: 0x000019BC
			[global::Cpp2ILInjected.Token(Token = "0x6000270")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9FA5C", Offset = "0x1A9FA5C", Length = "0x380")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new object[] { typeof(PKCS8.PrivateKeyInfo) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "RemoveLeadingZero", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Normalize", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
			public static RSA DecodeRSA(byte[] keypair)
			{
				throw null;
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x000037BF File Offset: 0x000019BF
			[global::Cpp2ILInjected.Token(Token = "0x6000271")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9FDDC", Offset = "0x1A9FDDC", Length = "0x1F0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public static byte[] Encode(RSA rsa)
			{
				throw null;
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x000037C2 File Offset: 0x000019C2
			[global::Cpp2ILInjected.Token(Token = "0x6000272")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9FFCC", Offset = "0x1A9FFCC", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPrivateKey", MemberParameters = new object[] { typeof(PKCS8.PrivateKeyInfo) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Normalize", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters)
			{
				throw null;
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x000037C5 File Offset: 0x000019C5
			[global::Cpp2ILInjected.Token(Token = "0x6000273")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA00E8", Offset = "0x1AA00E8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromUnsignedBigInteger", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(ASN1))]
			public static byte[] Encode(DSA dsa)
			{
				throw null;
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x000037C8 File Offset: 0x000019C8
			[global::Cpp2ILInjected.Token(Token = "0x6000274")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA012C", Offset = "0x1AA012C", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new object[]
			{
				typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
				typeof(UnityTls.unitytls_errorstate*),
				typeof(ref UnityTls.unitytls_x509list*),
				typeof(ref UnityTls.unitytls_key*)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public unsafe static byte[] Encode(AsymmetricAlgorithm aa)
			{
				throw null;
			}

			// Token: 0x040002C2 RID: 706
			[global::Cpp2ILInjected.Token(Token = "0x4000263")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _version;

			// Token: 0x040002C3 RID: 707
			[global::Cpp2ILInjected.Token(Token = "0x4000264")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _algorithm;

			// Token: 0x040002C4 RID: 708
			[global::Cpp2ILInjected.Token(Token = "0x4000265")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private byte[] _key;

			// Token: 0x040002C5 RID: 709
			[global::Cpp2ILInjected.Token(Token = "0x4000266")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private ArrayList _list;
		}

		// Token: 0x02000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x200005B")]
		public class EncryptedPrivateKeyInfo
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x000037CB File Offset: 0x000019CB
			[global::Cpp2ILInjected.Token(Token = "0x6000275")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0240", Offset = "0x1AA0240", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EncryptedPrivateKeyInfo()
			{
				throw null;
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x000037CE File Offset: 0x000019CE
			[global::Cpp2ILInjected.Token(Token = "0x6000276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0248", Offset = "0x1AA0248", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemovePkcs8ShroudedKeyBag", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EncryptedPrivateKeyInfo(byte[] data)
			{
				throw null;
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060002EA RID: 746 RVA: 0x000037D1 File Offset: 0x000019D1
			// (set) Token: 0x060002EB RID: 747 RVA: 0x000037D4 File Offset: 0x000019D4
			[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
			public string Algorithm
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000277")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA04E8", Offset = "0x1AA04E8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000278")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA04F0", Offset = "0x1AA04F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060002EC RID: 748 RVA: 0x000037D7 File Offset: 0x000019D7
			// (set) Token: 0x060002ED RID: 749 RVA: 0x000037DA File Offset: 0x000019DA
			[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
			public byte[] EncryptedData
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000279")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA04F8", Offset = "0x1AA04F8", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemovePkcs8ShroudedKeyBag", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600027A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA056C", Offset = "0x1AA056C", Length = "0x80")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(ASN1))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060002EE RID: 750 RVA: 0x000037DD File Offset: 0x000019DD
			[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
			public byte[] Salt
			{
				[global::Cpp2ILInjected.Token(Token = "0x600027B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA05EC", Offset = "0x1AA05EC", Length = "0xA8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(ASN1))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "RemovePkcs8ShroudedKeyBag", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAsymmetricAlgorithm", MemberParameters = new object[] { typeof(IDictionary) }, ReturnType = typeof(AsymmetricAlgorithm))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetAttributes", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(IDictionary))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomNumberGenerator), Member = "Create", ReturnType = typeof(RandomNumberGenerator))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060002EF RID: 751 RVA: 0x000037E0 File Offset: 0x000019E0
			// (set) Token: 0x060002F0 RID: 752 RVA: 0x000037E3 File Offset: 0x000019E3
			[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
			public int IterationCount
			{
				[global::Cpp2ILInjected.Token(Token = "0x600027C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA0694", Offset = "0x1AA0694", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600027D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AA069C", Offset = "0x1AA069C", Length = "0x78")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
				{
					typeof(AsymmetricAlgorithm),
					typeof(IDictionary)
				}, ReturnType = typeof(ASN1))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(string),
					typeof(string)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x000037E6 File Offset: 0x000019E6
			[global::Cpp2ILInjected.Token(Token = "0x600027E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0274", Offset = "0x1AA0274", Length = "0x274")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			private void Decode(byte[] data)
			{
				throw null;
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x000037E9 File Offset: 0x000019E9
			[global::Cpp2ILInjected.Token(Token = "0x600027F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA0714", Offset = "0x1AA0714", Length = "0x1C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
			{
				typeof(AsymmetricAlgorithm),
				typeof(IDictionary)
			}, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public byte[] GetBytes()
			{
				throw null;
			}

			// Token: 0x040002C6 RID: 710
			[global::Cpp2ILInjected.Token(Token = "0x4000267")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _algorithm;

			// Token: 0x040002C7 RID: 711
			[global::Cpp2ILInjected.Token(Token = "0x4000268")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private byte[] _salt;

			// Token: 0x040002C8 RID: 712
			[global::Cpp2ILInjected.Token(Token = "0x4000269")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _iterations;

			// Token: 0x040002C9 RID: 713
			[global::Cpp2ILInjected.Token(Token = "0x400026A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private byte[] _data;
		}
	}
}
