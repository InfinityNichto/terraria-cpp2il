using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002EC")]
	public abstract class Rijndael : SymmetricAlgorithm
	{
		[global::Cpp2ILInjected.Token(Token = "0x600191E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B02644", Offset = "0x1B02644", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Rijndael()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600191F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B026C0", Offset = "0x1B026C0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static Rijndael Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001920")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B027E8", Offset = "0x1B027E8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static Rijndael Create(string algName)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001921")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0288C", Offset = "0x1B0288C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static Rijndael()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CD4")]
		private static KeySizes[] s_legalBlockSizes;

		[global::Cpp2ILInjected.Token(Token = "0x4000CD5")]
		private static KeySizes[] s_legalKeySizes;
	}
}
