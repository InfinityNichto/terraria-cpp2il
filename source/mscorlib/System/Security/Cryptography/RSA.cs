using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000256 RID: 598
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F3")]
	public abstract class RSA : AsymmetricAlgorithm
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x00018638 File Offset: 0x00016838
		[global::Cpp2ILInjected.Token(Token = "0x6001950")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B070B4", Offset = "0x1B070B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RSAManaged", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		protected RSA()
		{
			throw null;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0001863B File Offset: 0x0001683B
		[global::Cpp2ILInjected.Token(Token = "0x6001951")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B070BC", Offset = "0x1B070BC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPublicKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Create", MemberParameters = new object[] { typeof(RSAParameters) }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "FromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = "Common", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static RSA Create()
		{
			throw null;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0001863E File Offset: 0x0001683E
		[global::Cpp2ILInjected.Token(Token = "0x6001952")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07154", Offset = "0x1B07154", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static RSA Create(string algName)
		{
			throw null;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00018641 File Offset: 0x00016841
		[global::Cpp2ILInjected.Token(Token = "0x6001953")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0724C", Offset = "0x1B0724C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			throw null;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00018644 File Offset: 0x00016844
		[global::Cpp2ILInjected.Token(Token = "0x6001954")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B072F0", Offset = "0x1B072F0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			throw null;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00018647 File Offset: 0x00016847
		[global::Cpp2ILInjected.Token(Token = "0x6001955")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07314", Offset = "0x1B07314", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0001864A File Offset: 0x0001684A
		[global::Cpp2ILInjected.Token(Token = "0x6001956")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07338", Offset = "0x1B07338", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0001864D File Offset: 0x0001684D
		[global::Cpp2ILInjected.Token(Token = "0x6001957")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0735C", Offset = "0x1B0735C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x00018650 File Offset: 0x00016850
		[global::Cpp2ILInjected.Token(Token = "0x6001958")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07380", Offset = "0x1B07380", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual byte[] HashData(global::System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00018653 File Offset: 0x00016853
		[global::Cpp2ILInjected.Token(Token = "0x6001959")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B073A4", Offset = "0x1B073A4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00018656 File Offset: 0x00016856
		[global::Cpp2ILInjected.Token(Token = "0x600195A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07418", Offset = "0x1B07418", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00018659 File Offset: 0x00016859
		[global::Cpp2ILInjected.Token(Token = "0x600195B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07678", Offset = "0x1B07678", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual byte[] SignData(global::System.IO.Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0001865C File Offset: 0x0001685C
		[global::Cpp2ILInjected.Token(Token = "0x600195C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B077B0", Offset = "0x1B077B0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0001865F File Offset: 0x0001685F
		[global::Cpp2ILInjected.Token(Token = "0x600195D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07828", Offset = "0x1B07828", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00018662 File Offset: 0x00016862
		[global::Cpp2ILInjected.Token(Token = "0x600195E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07A1C", Offset = "0x1B07A1C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public bool VerifyData(global::System.IO.Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00018665 File Offset: 0x00016865
		[global::Cpp2ILInjected.Token(Token = "0x600195F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07270", Offset = "0x1B07270", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "HashData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.Exception DerivedClassMustOverride()
		{
			throw null;
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00018668 File Offset: 0x00016868
		[global::Cpp2ILInjected.Token(Token = "0x6001960")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B075D8", Offset = "0x1B075D8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "SignData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "TrySignData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(HashAlgorithmName),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static global::System.Exception HashAlgorithmNameNullOrEmpty()
		{
			throw null;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0001866B File Offset: 0x0001686B
		[global::Cpp2ILInjected.Token(Token = "0x6001961")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07B88", Offset = "0x1B07B88", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual byte[] DecryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0001866E File Offset: 0x0001686E
		[global::Cpp2ILInjected.Token(Token = "0x6001962")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07BE0", Offset = "0x1B07BE0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual byte[] EncryptValue(byte[] rgb)
		{
			throw null;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00018671 File Offset: 0x00016871
		[global::Cpp2ILInjected.Token(Token = "0x170002B9")]
		public override string KeyExchangeAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001963")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B07C38", Offset = "0x1B07C38", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00018674 File Offset: 0x00016874
		[global::Cpp2ILInjected.Token(Token = "0x170002BA")]
		public override string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001964")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B07C78", Offset = "0x1B07C78", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00018677 File Offset: 0x00016877
		[global::Cpp2ILInjected.Token(Token = "0x6001965")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07CB8", Offset = "0x1B07CB8", Length = "0x5AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Util.Parser), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Util.Parser), Member = "GetTopElement", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DiscardWhiteSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		public override void FromXmlString(string xmlString)
		{
			throw null;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0001867A File Offset: 0x0001687A
		[global::Cpp2ILInjected.Token(Token = "0x6001966")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B082C4", Offset = "0x1B082C4", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override string ToXmlString(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x0600174D RID: 5965
		[global::Cpp2ILInjected.Token(Token = "0x6001967")]
		public abstract RSAParameters ExportParameters(bool includePrivateParameters);

		// Token: 0x0600174E RID: 5966
		[global::Cpp2ILInjected.Token(Token = "0x6001968")]
		public abstract void ImportParameters(RSAParameters parameters);

		// Token: 0x0600174F RID: 5967 RVA: 0x0001867D File Offset: 0x0001687D
		[global::Cpp2ILInjected.Token(Token = "0x6001969")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B086F8", Offset = "0x1B086F8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static RSA Create(int keySizeInBits)
		{
			throw null;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00018680 File Offset: 0x00016880
		[global::Cpp2ILInjected.Token(Token = "0x600196A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B087B0", Offset = "0x1B087B0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static RSA Create(RSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00018683 File Offset: 0x00016883
		[global::Cpp2ILInjected.Token(Token = "0x600196B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B08894", Offset = "0x1B08894", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryDecrypt(global::System.ReadOnlySpan<byte> data, global::System.Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00018686 File Offset: 0x00016886
		[global::Cpp2ILInjected.Token(Token = "0x600196C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B089AC", Offset = "0x1B089AC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryEncrypt(global::System.ReadOnlySpan<byte> data, global::System.Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x00018689 File Offset: 0x00016889
		[global::Cpp2ILInjected.Token(Token = "0x600196D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B08AC4", Offset = "0x1B08AC4", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected virtual bool TryHashData(global::System.ReadOnlySpan<byte> data, global::System.Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0001868C File Offset: 0x0001688C
		[global::Cpp2ILInjected.Token(Token = "0x600196E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B08D24", Offset = "0x1B08D24", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TrySignHash(global::System.ReadOnlySpan<byte> hash, global::System.Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0001868F File Offset: 0x0001688F
		[global::Cpp2ILInjected.Token(Token = "0x600196F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B08E4C", Offset = "0x1B08E4C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual bool TrySignData(global::System.ReadOnlySpan<byte> data, global::System.Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00018692 File Offset: 0x00016892
		[global::Cpp2ILInjected.Token(Token = "0x6001970")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09034", Offset = "0x1B09034", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSASignaturePadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSASignaturePadding),
			typeof(RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public virtual bool VerifyData(global::System.ReadOnlySpan<byte> data, global::System.ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00018695 File Offset: 0x00016895
		[global::Cpp2ILInjected.Token(Token = "0x6001971")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09360", Offset = "0x1B09360", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool VerifyHash(global::System.ReadOnlySpan<byte> hash, global::System.ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			throw null;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00018698 File Offset: 0x00016898
		[global::Cpp2ILInjected.Token(Token = "0x6001972")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09404", Offset = "0x1B09404", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual byte[] ExportRSAPrivateKey()
		{
			throw null;
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0001869B File Offset: 0x0001689B
		[global::Cpp2ILInjected.Token(Token = "0x6001973")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0943C", Offset = "0x1B0943C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual byte[] ExportRSAPublicKey()
		{
			throw null;
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x0001869E File Offset: 0x0001689E
		[global::Cpp2ILInjected.Token(Token = "0x6001974")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B09474", Offset = "0x1B09474", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void ImportRSAPrivateKey(global::System.ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw null;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000186A1 File Offset: 0x000168A1
		[global::Cpp2ILInjected.Token(Token = "0x6001975")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B094AC", Offset = "0x1B094AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void ImportRSAPublicKey(global::System.ReadOnlySpan<byte> source, out int bytesRead)
		{
			throw null;
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000186A4 File Offset: 0x000168A4
		[global::Cpp2ILInjected.Token(Token = "0x6001976")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B094E4", Offset = "0x1B094E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryExportRSAPrivateKey(global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000186A7 File Offset: 0x000168A7
		[global::Cpp2ILInjected.Token(Token = "0x6001977")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0951C", Offset = "0x1B0951C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryExportRSAPublicKey(global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}
	}
}
