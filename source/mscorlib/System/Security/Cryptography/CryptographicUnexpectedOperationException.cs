using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000233 RID: 563
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D0")]
	[global::System.Serializable]
	public class CryptographicUnexpectedOperationException : CryptographicException
	{
		// Token: 0x06001632 RID: 5682 RVA: 0x00018356 File Offset: 0x00016556
		[global::Cpp2ILInjected.Token(Token = "0x600184C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA4D8", Offset = "0x1AFA4D8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public CryptographicUnexpectedOperationException()
		{
			throw null;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00018359 File Offset: 0x00016559
		[global::Cpp2ILInjected.Token(Token = "0x600184D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6D3C", Offset = "0x1AF6D3C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "get_Hash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSASignatureDeformatter), Member = "SetHashAlgorithm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSASignatureDeformatter), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSASignatureFormatter), Member = "SetHashAlgorithm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSASignatureFormatter), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "set_EffectiveKeySize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = "DecryptKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = "DecryptKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RsaPkcs1Padding", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureDeformatter), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureFormatter), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public CryptographicUnexpectedOperationException(string message)
		{
			throw null;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x0001835C File Offset: 0x0001655C
		[global::Cpp2ILInjected.Token(Token = "0x600184E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA4FC", Offset = "0x1AFA4FC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		public CryptographicUnexpectedOperationException(string format, string insert)
		{
			throw null;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x0001835F File Offset: 0x0001655F
		[global::Cpp2ILInjected.Token(Token = "0x600184F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA5AC", Offset = "0x1AFA5AC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "SetErrorCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public CryptographicUnexpectedOperationException(string message, global::System.Exception inner)
		{
			throw null;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00018362 File Offset: 0x00016562
		[global::Cpp2ILInjected.Token(Token = "0x6001850")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFA5F4", Offset = "0x1AFA5F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected CryptographicUnexpectedOperationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
