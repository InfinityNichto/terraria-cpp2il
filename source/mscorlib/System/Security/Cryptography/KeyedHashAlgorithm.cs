using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E2")]
	public abstract class KeyedHashAlgorithm : HashAlgorithm
	{
		[global::Cpp2ILInjected.Token(Token = "0x60018C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE5DC", Offset = "0x1AFE5DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected KeyedHashAlgorithm()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE440", Offset = "0x1AFE440", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002A4")]
		public virtual byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFEE8C", Offset = "0x1AFEE8C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFEEFC", Offset = "0x1AFEEFC", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFEFF4", Offset = "0x1AFEFF4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static KeyedHashAlgorithm Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF044", Offset = "0x1AFF044", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static KeyedHashAlgorithm Create(string algName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected byte[] KeyValue;
	}
}
