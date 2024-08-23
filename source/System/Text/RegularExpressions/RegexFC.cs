using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000062 RID: 98
	[global::Cpp2ILInjected.Token(Token = "0x20000BA")]
	internal sealed class RegexFC
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0000372E File Offset: 0x0000192E
		[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8C7C", Offset = "0x1EB8C7C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RegexFC(bool nullable)
		{
			throw null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003731 File Offset: 0x00001931
		[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8D88", Offset = "0x1EB8D88", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
		{
			throw null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003734 File Offset: 0x00001934
		[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8E6C", Offset = "0x1EB8E6C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RegexFC(string charClass, bool nullable, bool caseInsensitive)
		{
			throw null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003737 File Offset: 0x00001937
		[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8CF0", Offset = "0x1EB8CF0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "get_CanMerge", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new object[] { typeof(RegexCharClass) }, ReturnType = typeof(void))]
		public bool AddFC(RegexFC fc, bool concatenate)
		{
			throw null;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000373A File Offset: 0x0000193A
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000373D File Offset: 0x0000193D
		[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
		public bool CaseInsensitive
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB8F00", Offset = "0x1EB8F00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB8F08", Offset = "0x1EB8F08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003740 File Offset: 0x00001940
		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8184", Offset = "0x1EB8184", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexPrefix?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
		public string GetFirstChars(CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x400032D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RegexCharClass _cc;

		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x400032E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool _nullable;

		// Token: 0x040001EE RID: 494
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400032F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool <CaseInsensitive>k__BackingField;
	}
}
