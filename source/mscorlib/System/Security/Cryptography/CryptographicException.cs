using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000232 RID: 562
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002CF")]
	[global::System.Serializable]
	public class CryptographicException : global::System.SystemException
	{
		// Token: 0x0600162B RID: 5675 RVA: 0x00018341 File Offset: 0x00016541
		[global::Cpp2ILInjected.Token(Token = "0x6001845")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA300", Offset = "0x1AFA300", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Internal.Cryptography.Pal.CertificateData", Member = ".ctor", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CryptographicException()
		{
			throw null;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00018344 File Offset: 0x00016544
		[global::Cpp2ILInjected.Token(Token = "0x6001846")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8C38", Offset = "0x1AF8C38", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 146)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public CryptographicException(string message)
		{
			throw null;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00018347 File Offset: 0x00016547
		[global::Cpp2ILInjected.Token(Token = "0x6001847")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA36C", Offset = "0x1AFA36C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.SymmetricTransform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "CreateDecryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(global::System.Collections.IDictionary)
		}, ReturnType = "Mono.Security.ASN1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "KeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(global::System.Collections.IDictionary)
		}, ReturnType = "Mono.Security.ASN1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.PKCS8.PrivateKeyInfo", Member = "Encode", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CryptographicException(string format, string insert)
		{
			throw null;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0001834A File Offset: 0x0001654A
		[global::Cpp2ILInjected.Token(Token = "0x6001848")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA404", Offset = "0x1AFA404", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "GetParametersFromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPrivateKeyBlobDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPublicKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "GetParametersFromCapiPublicKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPublicKeyBlobDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeDSA", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = typeof(DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.PublicKey", Member = "DecodeRSA", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "Parse", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = ".ctor", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "GetParametersFromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public CryptographicException(string message, global::System.Exception inner)
		{
			throw null;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0001834D File Offset: 0x0001654D
		[global::Cpp2ILInjected.Token(Token = "0x6001849")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA42C", Offset = "0x1AFA42C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptographicException), Member = "ThrowCryptographicException", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Win32.Win32Native), Member = "GetMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public CryptographicException(int hr)
		{
			throw null;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00018350 File Offset: 0x00016550
		[global::Cpp2ILInjected.Token(Token = "0x600184A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA490", Offset = "0x1AFA490", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected CryptographicException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00018353 File Offset: 0x00016553
		[global::Cpp2ILInjected.Token(Token = "0x600184B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA498", Offset = "0x1AFA498", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ThrowCryptographicException(int hr)
		{
			throw null;
		}

		// Token: 0x040009B4 RID: 2484
		[global::Cpp2ILInjected.Token(Token = "0x4000C8E")]
		private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

		// Token: 0x040009B5 RID: 2485
		[global::Cpp2ILInjected.Token(Token = "0x4000C8F")]
		private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

		// Token: 0x040009B6 RID: 2486
		[global::Cpp2ILInjected.Token(Token = "0x4000C90")]
		private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;
	}
}
