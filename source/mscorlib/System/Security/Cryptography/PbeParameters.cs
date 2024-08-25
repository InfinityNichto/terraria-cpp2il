using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x200031F")]
	public sealed class PbeParameters
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002FB")]
		public PbeEncryptionAlgorithm EncryptionAlgorithm
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CF3C", Offset = "0x1B1CF3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FC")]
		public HashAlgorithmName HashAlgorithm
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CF44", Offset = "0x1B1CF44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FD")]
		public int IterationCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1CF4C", Offset = "0x1B1CF4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1CF54", Offset = "0x1B1CF54", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public PbeParameters(PbeEncryptionAlgorithm encryptionAlgorithm, HashAlgorithmName hashAlgorithm, int iterationCount)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly PbeEncryptionAlgorithm <EncryptionAlgorithm>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly HashAlgorithmName <HashAlgorithm>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int <IterationCount>k__BackingField;
	}
}
