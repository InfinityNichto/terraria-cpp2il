using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
	internal readonly struct RegexPrefix
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000461")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB81B0", Offset = "0x1EB81B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal RegexPrefix(string prefix, bool ci)
		{
			throw null;
		}

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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2334", Offset = "0x1EC2334", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static RegexPrefix()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000360")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly bool <CaseInsensitive>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000361")]
		private static readonly RegexPrefix <Empty>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000362")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly string <Prefix>k__BackingField;
	}
}
