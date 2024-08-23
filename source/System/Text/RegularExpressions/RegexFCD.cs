using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000061 RID: 97
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	internal ref struct RegexFCD
	{
		// Token: 0x0600031A RID: 794 RVA: 0x000036FE File Offset: 0x000018FE
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB7D1C", Offset = "0x1EB7D1C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexPrefix?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = ".ctor", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private RegexFCD(Span<int> intStack)
		{
			throw null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003701 File Offset: 0x00001901
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB7DF0", Offset = "0x1EB7DF0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = ".ctor", MemberParameters = new object[] { typeof(Span<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexPrefix?), Member = ".ctor", MemberParameters = new object[] { typeof(RegexPrefix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static RegexPrefix? FirstChars(RegexTree t)
		{
			throw null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003704 File Offset: 0x00001904
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB81C0", Offset = "0x1EB81C0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "Child", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "PadRight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static RegexPrefix Prefix(RegexTree tree)
		{
			throw null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003707 File Offset: 0x00001907
		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8464", Offset = "0x1EB8464", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "Child", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int Anchors(RegexTree tree)
		{
			throw null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000370A File Offset: 0x0000190A
		[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8584", Offset = "0x1EB8584", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int AnchorFromType(int type)
		{
			throw null;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000370D File Offset: 0x0000190D
		[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB85F4", Offset = "0x1EB85F4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PushInt(int i)
		{
			throw null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003710 File Offset: 0x00001910
		[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8698", Offset = "0x1EB8698", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool IntIsEmpty()
		{
			throw null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003713 File Offset: 0x00001913
		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB86DC", Offset = "0x1EB86DC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int PopInt()
		{
			throw null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003716 File Offset: 0x00001916
		[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8728", Offset = "0x1EB8728", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PushFC(RegexFC fc)
		{
			throw null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003719 File Offset: 0x00001919
		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB87D0", Offset = "0x1EB87D0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool FCIsEmpty()
		{
			throw null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000371C File Offset: 0x0000191C
		[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8818", Offset = "0x1EB8818", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "TopFC", ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private RegexFC PopFC()
		{
			throw null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000371F File Offset: 0x0000191F
		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8888", Offset = "0x1EB8888", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "PopFC", ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private RegexFC TopFC()
		{
			throw null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003722 File Offset: 0x00001922
		[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB813C", Offset = "0x1EB813C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexPrefix?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003725 File Offset: 0x00001925
		[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB7F68", Offset = "0x1EB7F68", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "FirstChars", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexPrefix?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "CalculateFC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexNode),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "PushInt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "PopFC", ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private RegexFC RegexFCFromRegexTree(RegexTree tree)
		{
			throw null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00003728 File Offset: 0x00001928
		[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB8C70", Offset = "0x1EB8C70", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SkipChild()
		{
			throw null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000372B File Offset: 0x0000192B
		[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB88E4", Offset = "0x1EB88E4", Length = "0x38C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFCD), Member = "RegexFCFromRegexTree", MemberParameters = new object[] { typeof(RegexTree) }, ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "PushFC", MemberParameters = new object[] { typeof(RegexFC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "TopFC", ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFCD), Member = "PopFC", ReturnType = typeof(RegexFC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new object[]
		{
			typeof(RegexFC),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void CalculateFC(int NodeType, RegexNode node, int CurIndex)
		{
			throw null;
		}

		// Token: 0x040001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly List<RegexFC> _fcStack;

		// Token: 0x040001E8 RID: 488
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private ValueListBuilder<int> _intStack;

		// Token: 0x040001E9 RID: 489
		[global::Cpp2ILInjected.Token(Token = "0x400032A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _skipAllChildren;

		// Token: 0x040001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x400032B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _skipchild;

		// Token: 0x040001EB RID: 491
		[global::Cpp2ILInjected.Token(Token = "0x400032C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool _failed;
	}
}
