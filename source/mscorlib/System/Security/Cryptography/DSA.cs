﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200023A RID: 570
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D7")]
	public abstract class DSA : AsymmetricAlgorithm
	{
		// Token: 0x0600165B RID: 5723 RVA: 0x000183CB File Offset: 0x000165CB
		[global::Cpp2ILInjected.Token(Token = "0x6001875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB7FC", Offset = "0x1AFB7FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected DSA()
		{
			throw null;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000183CE File Offset: 0x000165CE
		[global::Cpp2ILInjected.Token(Token = "0x6001876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB804", Offset = "0x1AFB804", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPrivateKeyBlobDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPublicKeyBlobDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "Create", MemberParameters = new object[] { typeof(DSAParameters) }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = "DecodeDSA", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(DSAParameters)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static DSA Create()
		{
			throw null;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x000183D1 File Offset: 0x000165D1
		[global::Cpp2ILInjected.Token(Token = "0x6001877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB858", Offset = "0x1AFB858", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static DSA Create(string algName)
		{
			throw null;
		}

		// Token: 0x0600165E RID: 5726
		[global::Cpp2ILInjected.Token(Token = "0x6001878")]
		public abstract byte[] CreateSignature(byte[] rgbHash);

		// Token: 0x0600165F RID: 5727
		[global::Cpp2ILInjected.Token(Token = "0x6001879")]
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

		// Token: 0x06001660 RID: 5728 RVA: 0x000183D4 File Offset: 0x000165D4
		[global::Cpp2ILInjected.Token(Token = "0x600187A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB8FC", Offset = "0x1AFB8FC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000183D7 File Offset: 0x000165D7
		[global::Cpp2ILInjected.Token(Token = "0x600187B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB9A0", Offset = "0x1AFB9A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "DerivedClassMustOverride", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual byte[] HashData(global::System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000183DA File Offset: 0x000165DA
		[global::Cpp2ILInjected.Token(Token = "0x600187C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB9C4", Offset = "0x1AFB9C4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000183DD File Offset: 0x000165DD
		[global::Cpp2ILInjected.Token(Token = "0x600187D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBA34", Offset = "0x1AFBA34", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000183E0 File Offset: 0x000165E0
		[global::Cpp2ILInjected.Token(Token = "0x600187E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBC14", Offset = "0x1AFBC14", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual byte[] SignData(global::System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000183E3 File Offset: 0x000165E3
		[global::Cpp2ILInjected.Token(Token = "0x600187F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBCCC", Offset = "0x1AFBCCC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000183E6 File Offset: 0x000165E6
		[global::Cpp2ILInjected.Token(Token = "0x6001880")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBD40", Offset = "0x1AFBD40", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000183E9 File Offset: 0x000165E9
		[global::Cpp2ILInjected.Token(Token = "0x6001881")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBEB4", Offset = "0x1AFBEB4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual bool VerifyData(global::System.IO.Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000183EC File Offset: 0x000165EC
		[global::Cpp2ILInjected.Token(Token = "0x6001882")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBFA0", Offset = "0x1AFBFA0", Length = "0x6CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Util.Parser), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Util.Parser), Member = "GetTopElement", ReturnType = typeof(SecurityElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DiscardWhiteSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ConvertByteArrayToInt", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 66)]
		public override void FromXmlString(string xmlString)
		{
			throw null;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000183EF File Offset: 0x000165EF
		[global::Cpp2ILInjected.Token(Token = "0x6001883")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFC66C", Offset = "0x1AFC66C", Length = "0x498")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ConvertIntToByteArray", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override string ToXmlString(bool includePrivateParameters)
		{
			throw null;
		}

		// Token: 0x0600166A RID: 5738
		[global::Cpp2ILInjected.Token(Token = "0x6001884")]
		public abstract DSAParameters ExportParameters(bool includePrivateParameters);

		// Token: 0x0600166B RID: 5739
		[global::Cpp2ILInjected.Token(Token = "0x6001885")]
		public abstract void ImportParameters(DSAParameters parameters);

		// Token: 0x0600166C RID: 5740 RVA: 0x000183F2 File Offset: 0x000165F2
		[global::Cpp2ILInjected.Token(Token = "0x6001886")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFB920", Offset = "0x1AFB920", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "HashData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.Exception DerivedClassMustOverride()
		{
			throw null;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000183F5 File Offset: 0x000165F5
		[global::Cpp2ILInjected.Token(Token = "0x6001887")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFBB74", Offset = "0x1AFBB74", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "SignData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(byte[]),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "TrySignData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(HashAlgorithmName),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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

		// Token: 0x0600166E RID: 5742 RVA: 0x000183F8 File Offset: 0x000165F8
		[global::Cpp2ILInjected.Token(Token = "0x6001888")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFCB04", Offset = "0x1AFCB04", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static DSA Create(int keySizeInBits)
		{
			throw null;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000183FB File Offset: 0x000165FB
		[global::Cpp2ILInjected.Token(Token = "0x6001889")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFCBB8", Offset = "0x1AFCBB8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "Create", ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsymmetricAlgorithm), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static DSA Create(DSAParameters parameters)
		{
			throw null;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000183FE File Offset: 0x000165FE
		[global::Cpp2ILInjected.Token(Token = "0x600188A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFCC98", Offset = "0x1AFCC98", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool TryCreateSignature(global::System.ReadOnlySpan<byte> hash, global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00018401 File Offset: 0x00016601
		[global::Cpp2ILInjected.Token(Token = "0x600188B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFCDA8", Offset = "0x1AFCDA8", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected virtual bool TryHashData(global::System.ReadOnlySpan<byte> data, global::System.Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00018404 File Offset: 0x00016604
		[global::Cpp2ILInjected.Token(Token = "0x600188C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD004", Offset = "0x1AFD004", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual bool TrySignData(global::System.ReadOnlySpan<byte> data, global::System.Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00018407 File Offset: 0x00016607
		[global::Cpp2ILInjected.Token(Token = "0x600188D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD168", Offset = "0x1AFD168", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DSA), Member = "HashAlgorithmNameNullOrEmpty", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public virtual bool VerifyData(global::System.ReadOnlySpan<byte> data, global::System.ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0001840A File Offset: 0x0001660A
		[global::Cpp2ILInjected.Token(Token = "0x600188E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFD41C", Offset = "0x1AFD41C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool VerifySignature(global::System.ReadOnlySpan<byte> hash, global::System.ReadOnlySpan<byte> signature)
		{
			throw null;
		}
	}
}