using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200005F RID: 95
	[global::Cpp2ILInjected.Token(Token = "0x20000B4")]
	internal sealed class RegexCharClass
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x00003683 File Offset: 0x00001883
		[global::Cpp2ILInjected.Token(Token = "0x600038C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEA54", Offset = "0x1EAEA54", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public RegexCharClass()
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003686 File Offset: 0x00001886
		[global::Cpp2ILInjected.Token(Token = "0x600038D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEB0C", Offset = "0x1EAEB0C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
		{
			throw null;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00003689 File Offset: 0x00001889
		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		public bool CanMerge
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAEB58", Offset = "0x1EAEB58", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new object[]
			{
				typeof(RegexFC),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000368C File Offset: 0x0000188C
		[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
		public bool Negate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EAEB78", Offset = "0x1EAEB78", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000368F File Offset: 0x0000188F
		[global::Cpp2ILInjected.Token(Token = "0x6000390")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEB84", Offset = "0x1EAEB84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void AddChar(char c)
		{
			throw null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003692 File Offset: 0x00001892
		[global::Cpp2ILInjected.Token(Token = "0x6000391")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAECA4", Offset = "0x1EAECA4", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new object[]
		{
			typeof(RegexFC),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "GetRangeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RegexCharClass.SingleRange))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddCharClass(RegexCharClass cc)
		{
			throw null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003695 File Offset: 0x00001895
		[global::Cpp2ILInjected.Token(Token = "0x6000392")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEF00", Offset = "0x1EAEF00", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddWord", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddSpace", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "GetRangeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(RegexCharClass.SingleRange))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass.SingleRange), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddSet(string set)
		{
			throw null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003698 File Offset: 0x00001898
		[global::Cpp2ILInjected.Token(Token = "0x6000393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF148", Offset = "0x1EAF148", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddSubtraction(RegexCharClass sub)
		{
			throw null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000369B File Offset: 0x0000189B
		[global::Cpp2ILInjected.Token(Token = "0x6000394")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEB8C", Offset = "0x1EAEB8C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass.SingleRange), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddRange(char first, char last)
		{
			throw null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000369E File Offset: 0x0000189E
		[global::Cpp2ILInjected.Token(Token = "0x6000395")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF150", Offset = "0x1EAF150", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "SetFromProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "NegateCategory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
			throw null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000036A1 File Offset: 0x000018A1
		[global::Cpp2ILInjected.Token(Token = "0x6000396")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF5D8", Offset = "0x1EAF5D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		private void AddCategory(string category)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000036A4 File Offset: 0x000018A4
		[global::Cpp2ILInjected.Token(Token = "0x6000397")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF5E4", Offset = "0x1EAF5E4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass.SingleRange), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexCharClass.SingleRange)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddLowercase(CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000036A7 File Offset: 0x000018A7
		[global::Cpp2ILInjected.Token(Token = "0x6000398")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF70C", Offset = "0x1EAF70C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000036AA File Offset: 0x000018AA
		[global::Cpp2ILInjected.Token(Token = "0x6000399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF918", Offset = "0x1EAF918", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddWord(bool ecma, bool negate)
		{
			throw null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000036AD File Offset: 0x000018AD
		[global::Cpp2ILInjected.Token(Token = "0x600039A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF9FC", Offset = "0x1EAF9FC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddSpace(bool ecma, bool negate)
		{
			throw null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000036B0 File Offset: 0x000018B0
		[global::Cpp2ILInjected.Token(Token = "0x600039B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFAE0", Offset = "0x1EAFAE0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddDigit(bool ecma, bool negate, string pattern)
		{
			throw null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000036B3 File Offset: 0x000018B3
		[global::Cpp2ILInjected.Token(Token = "0x600039C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFB94", Offset = "0x1EAFB94", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public static char SingletonChar(string set)
		{
			throw null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000036B6 File Offset: 0x000018B6
		[global::Cpp2ILInjected.Token(Token = "0x600039D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFBA0", Offset = "0x1EAFBA0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsSubtraction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool IsMergeable(string charClass)
		{
			throw null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000036B9 File Offset: 0x000018B9
		[global::Cpp2ILInjected.Token(Token = "0x600039E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFCB4", Offset = "0x1EAFCB4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsSubtraction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsEmpty(string charClass)
		{
			throw null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000036BC File Offset: 0x000018BC
		[global::Cpp2ILInjected.Token(Token = "0x600039F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFD6C", Offset = "0x1EAFD6C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsSubtraction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsSingleton(string set)
		{
			throw null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000036BF File Offset: 0x000018BF
		[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFE70", Offset = "0x1EAFE70", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsSubtraction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsSingletonInverse(string set)
		{
			throw null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000036C2 File Offset: 0x000018C2
		[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFC64", Offset = "0x1EAFC64", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "IsMergeable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "IsEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "IsSingletonInverse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool IsSubtraction(string charClass)
		{
			throw null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000036C5 File Offset: 0x000018C5
		[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFC3C", Offset = "0x1EAFC3C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool IsNegated(string set)
		{
			throw null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000036C8 File Offset: 0x000018C8
		[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFF78", Offset = "0x1EAFF78", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "IsECMABoundary", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool IsECMAWordChar(char ch)
		{
			throw null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000036CB File Offset: 0x000018CB
		[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB004C", Offset = "0x1EB004C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexRunner), Member = "IsBoundary", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsWordChar(char ch)
		{
			throw null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000036CE File Offset: 0x000018CE
		[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAFFE4", Offset = "0x1EAFFE4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CharInClass(char ch, string set)
		{
			throw null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000036D1 File Offset: 0x000018D1
		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB00CC", Offset = "0x1EB00CC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInClassInternal", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool CharInClassRecursive(char ch, string set, int start)
		{
			throw null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000036D4 File Offset: 0x000018D4
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB01EC", Offset = "0x1EB01EC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			throw null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000036D7 File Offset: 0x000018D7
		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB02F4", Offset = "0x1EB02F4", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "CharInCategoryGroup", MemberParameters = new object[]
		{
			typeof(char),
			typeof(UnicodeCategory),
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			throw null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000036DA File Offset: 0x000018DA
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB0474", Offset = "0x1EB0474", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "CharInCategory", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
		{
			throw null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000036DD File Offset: 0x000018DD
		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF350", Offset = "0x1EAF350", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		private static string NegateCategory(string category)
		{
			throw null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000036E0 File Offset: 0x000018E0
		[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB053C", Offset = "0x1EB053C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static RegexCharClass Parse(string charClass)
		{
			throw null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000036E3 File Offset: 0x000018E3
		[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB0594", Offset = "0x1EB0594", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass.SingleRange), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static RegexCharClass ParseRecursive(string charClass, int start)
		{
			throw null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000036E6 File Offset: 0x000018E6
		[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEE60", Offset = "0x1EAEE60", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int RangeCount()
		{
			throw null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000036E9 File Offset: 0x000018E9
		[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB0800", Offset = "0x1EB0800", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "Canonicalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string ToStringClass()
		{
			throw null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000036EC File Offset: 0x000018EC
		[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAEEA0", Offset = "0x1EAEEA0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new object[] { typeof(RegexCharClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private RegexCharClass.SingleRange GetRangeAt(int i)
		{
			throw null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000036EF File Offset: 0x000018EF
		[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB0988", Offset = "0x1EB0988", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "Sort", MemberParameters = new object[] { typeof(IComparer<RegexCharClass.SingleRange>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass.SingleRange), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(RegexCharClass.SingleRange)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RegexCharClass.SingleRange>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Canonicalize()
		{
			throw null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000036F2 File Offset: 0x000018F2
		[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EAF3C8", Offset = "0x1EAF3C8", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static string SetFromProperty(string capname, bool invert, string pattern)
		{
			throw null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000036F5 File Offset: 0x000018F5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EB0BBC", Offset = "0x1EB0BBC", Length = "0x6FC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass.LowerCaseMapping), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 767)]
		static RegexCharClass()
		{
			throw null;
		}

		// Token: 0x0400019B RID: 411
		[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
		private static readonly string s_internalRegexIgnoreCase;

		// Token: 0x0400019C RID: 412
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		private static readonly string s_space;

		// Token: 0x0400019D RID: 413
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		private static readonly string s_notSpace;

		// Token: 0x0400019E RID: 414
		[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
		private static readonly string s_word;

		// Token: 0x0400019F RID: 415
		[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
		private static readonly string s_notWord;

		// Token: 0x040001A0 RID: 416
		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		public static readonly string SpaceClass;

		// Token: 0x040001A1 RID: 417
		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		public static readonly string NotSpaceClass;

		// Token: 0x040001A2 RID: 418
		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		public static readonly string WordClass;

		// Token: 0x040001A3 RID: 419
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		public static readonly string NotWordClass;

		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		public static readonly string DigitClass;

		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		public static readonly string NotDigitClass;

		// Token: 0x040001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		private static readonly Dictionary<string, string> s_definedCategories;

		// Token: 0x040001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		private static readonly string[][] s_propTable;

		// Token: 0x040001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable;

		// Token: 0x040001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<RegexCharClass.SingleRange> _rangelist;

		// Token: 0x040001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private StringBuilder _categories;

		// Token: 0x040001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _canonical;

		// Token: 0x040001AC RID: 428
		[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool _negate;

		// Token: 0x040001AD RID: 429
		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private RegexCharClass _subtractor;

		// Token: 0x020003BD RID: 957
		[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
		private readonly struct LowerCaseMapping
		{
			// Token: 0x06001D3F RID: 7487 RVA: 0x000080B1 File Offset: 0x000062B1
			[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB7B7C", Offset = "0x1EB7B7C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 94)]
			internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
				throw null;
			}

			// Token: 0x040010EB RID: 4331
			[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly char ChMin;

			// Token: 0x040010EC RID: 4332
			[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public readonly char ChMax;

			// Token: 0x040010ED RID: 4333
			[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly int LcOp;

			// Token: 0x040010EE RID: 4334
			[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly int Data;
		}

		// Token: 0x020003BE RID: 958
		[global::Cpp2ILInjected.Token(Token = "0x20000B6")]
		private sealed class SingleRangeComparer : IComparer<RegexCharClass.SingleRange>
		{
			// Token: 0x06001D40 RID: 7488 RVA: 0x000080B4 File Offset: 0x000062B4
			[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB7B8C", Offset = "0x1EB7B8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			private SingleRangeComparer()
			{
				throw null;
			}

			// Token: 0x06001D41 RID: 7489 RVA: 0x000080B7 File Offset: 0x000062B7
			[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB7B94", Offset = "0x1EB7B94", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "CompareTo", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				throw null;
			}

			// Token: 0x06001D42 RID: 7490 RVA: 0x000080BA File Offset: 0x000062BA
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB7BB4", Offset = "0x1EB7BB4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static SingleRangeComparer()
			{
				throw null;
			}

			// Token: 0x040010EF RID: 4335
			[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
			public static readonly RegexCharClass.SingleRangeComparer Instance;
		}

		// Token: 0x020003BF RID: 959
		[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
		private readonly struct SingleRange
		{
			// Token: 0x06001D43 RID: 7491 RVA: 0x000080BD File Offset: 0x000062BD
			[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EB7C10", Offset = "0x1EB7C10", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new object[]
			{
				typeof(char),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(RegexCharClass))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexCharClass), Member = "Canonicalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			internal SingleRange(char first, char last)
			{
				throw null;
			}

			// Token: 0x040010F0 RID: 4336
			[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly char First;

			// Token: 0x040010F1 RID: 4337
			[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public readonly char Last;
		}
	}
}
