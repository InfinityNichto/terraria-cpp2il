using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x200031B")]
	public sealed class AesCcm : global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CAEC", Offset = "0x1B1CAEC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public AesCcm(byte[] key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CB2C", Offset = "0x1B1CB2C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public AesCcm(global::System.ReadOnlySpan<byte> key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F7")]
		public static KeySizes NonceByteSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CB6C", Offset = "0x1B1CB6C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F8")]
		public static KeySizes TagByteSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CBA4", Offset = "0x1B1CBA4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CBDC", Offset = "0x1B1CBDC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Decrypt(byte[] nonce, byte[] ciphertext, byte[] tag, byte[] plaintext, byte[] associatedData = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CC14", Offset = "0x1B1CC14", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Decrypt(global::System.ReadOnlySpan<byte> nonce, global::System.ReadOnlySpan<byte> ciphertext, global::System.ReadOnlySpan<byte> tag, global::System.Span<byte> plaintext, global::System.ReadOnlySpan<byte> associatedData = default(global::System.ReadOnlySpan<byte>))
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CC4C", Offset = "0x1B1CC4C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CC50", Offset = "0x1B1CC50", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Encrypt(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag, byte[] associatedData = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CC88", Offset = "0x1B1CC88", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Encrypt(global::System.ReadOnlySpan<byte> nonce, global::System.ReadOnlySpan<byte> plaintext, global::System.Span<byte> ciphertext, global::System.Span<byte> tag, global::System.ReadOnlySpan<byte> associatedData = default(global::System.ReadOnlySpan<byte>))
		{
			throw null;
		}
	}
}
