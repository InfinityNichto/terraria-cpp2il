using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200006D RID: 109
	[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
	internal ref struct RegexWriter
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00003959 File Offset: 0x00001B59
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3390", Offset = "0x1EC3390", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = ".ctor", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000395C File Offset: 0x00001B5C
		[global::Cpp2ILInjected.Token(Token = "0x6000488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC34D4", Offset = "0x1EC34D4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Span<int>),
			typeof(Span<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static RegexCode Write(RegexTree tree)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000395F File Offset: 0x00001B5F
		[global::Cpp2ILInjected.Token(Token = "0x6000489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC39E0", Offset = "0x1EC39E0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003962 File Offset: 0x00001B62
		[global::Cpp2ILInjected.Token(Token = "0x600048A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC35D8", Offset = "0x1EC35D8", Length = "0x408")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "Write", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexPrefix?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexPrefix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexBoyerMoore), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "Anchors", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "AsSpan", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<int>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCode), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(List<string>),
			typeof(int),
			typeof(Hashtable),
			typeof(int),
			typeof(RegexBoyerMoore),
			typeof(RegexPrefix?),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00003965 File Offset: 0x00001B65
		[global::Cpp2ILInjected.Token(Token = "0x600048B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC444C", Offset = "0x1EC444C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PatchJump(int offset, int jumpDest)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003968 File Offset: 0x00001B68
		[global::Cpp2ILInjected.Token(Token = "0x600048C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC44B0", Offset = "0x1EC44B0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Emit(int op)
		{
			throw null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000396B File Offset: 0x00001B6B
		[global::Cpp2ILInjected.Token(Token = "0x600048D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3A34", Offset = "0x1EC3A34", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Emit(int op, int opd1)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000396E File Offset: 0x00001B6E
		[global::Cpp2ILInjected.Token(Token = "0x600048E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC4584", Offset = "0x1EC4584", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Emit(int op, int opd1, int opd2)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003971 File Offset: 0x00001B71
		[global::Cpp2ILInjected.Token(Token = "0x600048F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC4708", Offset = "0x1EC4708", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int StringCode(string str)
		{
			throw null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003974 File Offset: 0x00001B74
		[global::Cpp2ILInjected.Token(Token = "0x6000490")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC4838", Offset = "0x1EC4838", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int MapCapnum(int capnum)
		{
			throw null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003977 File Offset: 0x00001B77
		[global::Cpp2ILInjected.Token(Token = "0x6000491")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC3B64", Offset = "0x1EC3B64", Length = "0x8E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "StringCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "Emit", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "MapCapnum", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void EmitFragment(int nodetype, RegexNode node, int curIndex)
		{
			throw null;
		}

		// Token: 0x04000244 RID: 580
		[global::Cpp2ILInjected.Token(Token = "0x4000385")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ValueListBuilder<int> _emitted;

		// Token: 0x04000245 RID: 581
		[global::Cpp2ILInjected.Token(Token = "0x4000386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ValueListBuilder<int> _intStack;

		// Token: 0x04000246 RID: 582
		[global::Cpp2ILInjected.Token(Token = "0x4000387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, int> _stringHash;

		// Token: 0x04000247 RID: 583
		[global::Cpp2ILInjected.Token(Token = "0x4000388")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly List<string> _stringTable;

		// Token: 0x04000248 RID: 584
		[global::Cpp2ILInjected.Token(Token = "0x4000389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Hashtable _caps;

		// Token: 0x04000249 RID: 585
		[global::Cpp2ILInjected.Token(Token = "0x400038A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int _trackCount;
	}
}
