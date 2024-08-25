using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000301")]
	public class SignatureDescription
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B105C8", Offset = "0x1B105C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SignatureDescription()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B105D0", Offset = "0x1B105D0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public SignatureDescription(SecurityElement el)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CE")]
		public string KeyAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10700", Offset = "0x1B10700", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10708", Offset = "0x1B10708", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CF")]
		public string DigestAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10710", Offset = "0x1B10710", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10718", Offset = "0x1B10718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D0")]
		public string FormatterAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A18")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10720", Offset = "0x1B10720", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10728", Offset = "0x1B10728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D1")]
		public string DeformatterAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10730", Offset = "0x1B10730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B10738", Offset = "0x1B10738", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10740", Offset = "0x1B10740", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureDescription), Member = "CreateDeformatter", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(AsymmetricSignatureDeformatter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10808", Offset = "0x1B10808", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1SignatureDescription), Member = "CreateFormatter", MemberParameters = new object[] { typeof(AsymmetricAlgorithm) }, ReturnType = typeof(AsymmetricSignatureFormatter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B108D0", Offset = "0x1B108D0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual HashAlgorithm CreateDigest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _strKey;

		[global::Cpp2ILInjected.Token(Token = "0x4000D27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _strDigest;

		[global::Cpp2ILInjected.Token(Token = "0x4000D28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _strFormatter;

		[global::Cpp2ILInjected.Token(Token = "0x4000D29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _strDeformatter;
	}
}
