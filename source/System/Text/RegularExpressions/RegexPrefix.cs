using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000068 RID: 104
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	internal readonly struct RegexPrefix
	{
		// Token: 0x060003C1 RID: 961 RVA: 0x000038F3 File Offset: 0x00001AF3
		[global::Cpp2ILInjected.Token(Token = "0x6000461")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB81B0", Offset = "0x1EB81B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal RegexPrefix(string prefix, bool ci)
		{
			throw null;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000038F6 File Offset: 0x00001AF6
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		internal bool CaseInsensitive
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000462")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC22CC", Offset = "0x1EC22CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000038F9 File Offset: 0x00001AF9
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		internal static RegexPrefix Empty
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000463")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC22D4", Offset = "0x1EC22D4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000038FC File Offset: 0x00001AFC
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		internal string Prefix
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000464")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC232C", Offset = "0x1EC232C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000038FF File Offset: 0x00001AFF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2334", Offset = "0x1EC2334", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static RegexPrefix()
		{
			throw null;
		}

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000360")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool <CaseInsensitive>k__BackingField;

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000361")]
		private static readonly RegexPrefix <Empty>k__BackingField;

		// Token: 0x04000221 RID: 545
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000362")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly string <Prefix>k__BackingField;
	}
}
