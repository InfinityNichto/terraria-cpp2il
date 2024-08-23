using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000282 RID: 642
	[global::Cpp2ILInjected.Token(Token = "0x200031F")]
	public sealed class PbeParameters
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00018B3C File Offset: 0x00016D3C
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00018B3F File Offset: 0x00016D3F
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00018B42 File Offset: 0x00016D42
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

		// Token: 0x060018EF RID: 6383 RVA: 0x00018B45 File Offset: 0x00016D45
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

		// Token: 0x04000AE7 RID: 2791
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly PbeEncryptionAlgorithm <EncryptionAlgorithm>k__BackingField;

		// Token: 0x04000AE8 RID: 2792
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly HashAlgorithmName <HashAlgorithm>k__BackingField;

		// Token: 0x04000AE9 RID: 2793
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000DC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int <IterationCount>k__BackingField;
	}
}
