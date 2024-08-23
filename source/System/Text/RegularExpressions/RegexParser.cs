using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text.RegularExpressions
{
	// Token: 0x02000067 RID: 103
	[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
	internal sealed class RegexParser
	{
		// Token: 0x06000374 RID: 884 RVA: 0x0000380C File Offset: 0x00001A0C
		[global::Cpp2ILInjected.Token(Token = "0x6000414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBC838", Offset = "0x1EBC838", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions),
			typeof(TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "Reset", MemberParameters = new object[] { typeof(RegexOptions) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static RegexTree Parse(string re, RegexOptions op)
		{
			throw null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000380F File Offset: 0x00001A0F
		[global::Cpp2ILInjected.Token(Token = "0x6000415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBD694", Offset = "0x1EBD694", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexReplacement), Member = "GetOrCreate", MemberParameters = new object[]
		{
			typeof(WeakReference<RegexReplacement>),
			typeof(string),
			typeof(Hashtable),
			typeof(int),
			typeof(Hashtable),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexReplacement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexReplacement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexNode),
			typeof(Hashtable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003812 File Offset: 0x00001A12
		[global::Cpp2ILInjected.Token(Token = "0x6000416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBDE04", Offset = "0x1EBDE04", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Regex), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsMetachar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string Escape(string input)
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003815 File Offset: 0x00001A15
		[global::Cpp2ILInjected.Token(Token = "0x6000417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBC9C8", Offset = "0x1EBC9C8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexTree))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Hashtable),
			typeof(int),
			typeof(Hashtable),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexReplacement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private RegexParser(CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003818 File Offset: 0x00001A18
		[global::Cpp2ILInjected.Token(Token = "0x6000418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBCA84", Offset = "0x1EBCA84", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetPattern(string Re)
		{
			throw null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000381B File Offset: 0x00001A1B
		[global::Cpp2ILInjected.Token(Token = "0x6000419")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBCE64", Offset = "0x1EBCE64", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexTree))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "RemoveRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Reset(RegexOptions topopts)
		{
			throw null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000381E File Offset: 0x00001A1E
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBCEE8", Offset = "0x1EBCEE8", Length = "0x744")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexTree))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "StartGroup", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsSpecial", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsTrueQuantifier", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsStopperX", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsQuantifier", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddUnitOne", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddAlternate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddUnitType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddUnitNotone", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PushOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PopGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PopOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddUnitSet", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "MakeQuantifier", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PopKeepOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private RegexNode ScanRegex()
		{
			throw null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00003821 File Offset: 0x00001A21
		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBD7E4", Offset = "0x1EBD7E4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ParseReplacement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Hashtable),
			typeof(int),
			typeof(Hashtable),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexReplacement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private RegexNode ScanReplacement()
		{
			throw null;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003824 File Offset: 0x00001A24
		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE9A0", Offset = "0x1EBE9A0", Length = "0x62C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddWord", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddSpace", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			throw null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003827 File Offset: 0x00001A27
		[global::Cpp2ILInjected.Token(Token = "0x600041D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBF0DC", Offset = "0x1EBF0DC", Length = "0x930")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "CaptureSlotFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private RegexNode ScanGroupOpen()
		{
			throw null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000382A File Offset: 0x00001A2A
		[global::Cpp2ILInjected.Token(Token = "0x600041E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE110", Offset = "0x1EBE110", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ScanBlank()
		{
			throw null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000382D File Offset: 0x00001A2D
		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFE40", Offset = "0x1EBFE40", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "TypeFromCode", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private RegexNode ScanBackslash(bool scanOnly)
		{
			throw null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00003830 File Offset: 0x00001A30
		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1090", Offset = "0x1EC1090", Length = "0x588")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "CaptureSlotFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private RegexNode ScanBasicBackslash(bool scanOnly)
		{
			throw null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003833 File Offset: 0x00001A33
		[global::Cpp2ILInjected.Token(Token = "0x6000421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC055C", Offset = "0x1EC055C", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "CaptureSlotFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private RegexNode ScanDollar()
		{
			throw null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00003836 File Offset: 0x00001A36
		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0C58", Offset = "0x1EC0C58", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string ScanCapname()
		{
			throw null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003839 File Offset: 0x00001A39
		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1618", Offset = "0x1EC1618", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private char ScanOctal()
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000383C File Offset: 0x00001A3C
		[global::Cpp2ILInjected.Token(Token = "0x6000424")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0450", Offset = "0x1EC0450", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int ScanDecimal()
		{
			throw null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000383F File Offset: 0x00001A3F
		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC16C8", Offset = "0x1EC16C8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private char ScanHex(int c)
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003842 File Offset: 0x00001A42
		[global::Cpp2ILInjected.Token(Token = "0x6000426")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC17FC", Offset = "0x1EC17FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int HexDigit(char ch)
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00003845 File Offset: 0x00001A45
		[global::Cpp2ILInjected.Token(Token = "0x6000427")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1834", Offset = "0x1EC1834", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private char ScanControl()
		{
			throw null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003848 File Offset: 0x00001A48
		[global::Cpp2ILInjected.Token(Token = "0x6000428")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC18D0", Offset = "0x1EC18D0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsOnlyTopOption(RegexOptions option)
		{
			throw null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000384B File Offset: 0x00001A4B
		[global::Cpp2ILInjected.Token(Token = "0x6000429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0E80", Offset = "0x1EC0E80", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "OptionFromCode", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(RegexOptions))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ScanOptions()
		{
			throw null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000384E File Offset: 0x00001A4E
		[global::Cpp2ILInjected.Token(Token = "0x600042A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0AC8", Offset = "0x1EC0AC8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanOctal", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanControl", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanHex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private char ScanCharEscape()
		{
			throw null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003851 File Offset: 0x00001A51
		[global::Cpp2ILInjected.Token(Token = "0x600042B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0950", Offset = "0x1EC0950", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string ParseProperty()
		{
			throw null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003854 File Offset: 0x00001A54
		[global::Cpp2ILInjected.Token(Token = "0x600042C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1000", Offset = "0x1EC1000", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private int TypeFromCode(char ch)
		{
			throw null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003857 File Offset: 0x00001A57
		[global::Cpp2ILInjected.Token(Token = "0x600042D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC18F8", Offset = "0x1EC18F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static RegexOptions OptionFromCode(char ch)
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000385A File Offset: 0x00001A5A
		[global::Cpp2ILInjected.Token(Token = "0x600042E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBCAE0", Offset = "0x1EBCAE0", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(RegexTree))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "NoteCaptureSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PushOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PopKeepOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "PopOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "NoteCaptureName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "AssignNameSlots", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void CountCaptures()
		{
			throw null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000385D File Offset: 0x00001A5D
		[global::Cpp2ILInjected.Token(Token = "0x600042F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1958", Offset = "0x1EC1958", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "AssignNameSlots", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void NoteCaptureSlot(int i, int pos)
		{
			throw null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00003860 File Offset: 0x00001A60
		[global::Cpp2ILInjected.Token(Token = "0x6000430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1A9C", Offset = "0x1EC1A9C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void NoteCaptureName(string name, int pos)
		{
			throw null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00003863 File Offset: 0x00001A63
		[global::Cpp2ILInjected.Token(Token = "0x6000431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBD7D8", Offset = "0x1EBD7D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
		{
			throw null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00003866 File Offset: 0x00001A66
		[global::Cpp2ILInjected.Token(Token = "0x6000432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1C1C", Offset = "0x1EC1C1C", Length = "0x5FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "IsCaptureSlot", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "NoteCaptureSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer<int>), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "System.Collections.Generic.IComparer`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void AssignNameSlots()
		{
			throw null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00003869 File Offset: 0x00001A69
		[global::Cpp2ILInjected.Token(Token = "0x6000433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0DF8", Offset = "0x1EC0DF8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int CaptureSlotFromName(string capname)
		{
			throw null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000386C File Offset: 0x00001A6C
		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0D40", Offset = "0x1EC0D40", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "AssignNameSlots", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsCaptureSlot(int i)
		{
			throw null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000386F File Offset: 0x00001A6F
		[global::Cpp2ILInjected.Token(Token = "0x6000435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0DDC", Offset = "0x1EC0DDC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool IsCaptureName(string capname)
		{
			throw null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003872 File Offset: 0x00001A72
		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0D34", Offset = "0x1EC0D34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool UseOptionN()
		{
			throw null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003875 File Offset: 0x00001A75
		[global::Cpp2ILInjected.Token(Token = "0x6000437")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE994", Offset = "0x1EBE994", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool UseOptionI()
		{
			throw null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00003878 File Offset: 0x00001A78
		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC02D8", Offset = "0x1EC02D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool UseOptionM()
		{
			throw null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000387B File Offset: 0x00001A7B
		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0354", Offset = "0x1EC0354", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool UseOptionS()
		{
			throw null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000387E File Offset: 0x00001A7E
		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE3F0", Offset = "0x1EBE3F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool UseOptionX()
		{
			throw null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00003881 File Offset: 0x00001A81
		[global::Cpp2ILInjected.Token(Token = "0x600043B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0944", Offset = "0x1EC0944", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool UseOptionE()
		{
			throw null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003884 File Offset: 0x00001A84
		[global::Cpp2ILInjected.Token(Token = "0x600043C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE624", Offset = "0x1EBE624", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsSpecial(char ch)
		{
			throw null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00003887 File Offset: 0x00001A87
		[global::Cpp2ILInjected.Token(Token = "0x600043D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE434", Offset = "0x1EBE434", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsStopperX(char ch)
		{
			throw null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000388A File Offset: 0x00001A8A
		[global::Cpp2ILInjected.Token(Token = "0x600043E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE6A4", Offset = "0x1EBE6A4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsQuantifier(char ch)
		{
			throw null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000388D File Offset: 0x00001A8D
		[global::Cpp2ILInjected.Token(Token = "0x600043F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE4B4", Offset = "0x1EBE4B4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsTrueQuantifier()
		{
			throw null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00003890 File Offset: 0x00001A90
		[global::Cpp2ILInjected.Token(Token = "0x6000440")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0F80", Offset = "0x1EC0F80", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsSpace(char ch)
		{
			throw null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00003893 File Offset: 0x00001A93
		[global::Cpp2ILInjected.Token(Token = "0x6000441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBDFF0", Offset = "0x1EBDFF0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "Escape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsMetachar(char ch)
		{
			throw null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00003896 File Offset: 0x00001A96
		[global::Cpp2ILInjected.Token(Token = "0x6000442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE724", Offset = "0x1EBE724", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddConcatenate(int pos, int cch, bool isReplacement)
		{
			throw null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00003899 File Offset: 0x00001A99
		[global::Cpp2ILInjected.Token(Token = "0x6000443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFA68", Offset = "0x1EBFA68", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void PushGroup()
		{
			throw null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000389C File Offset: 0x00001A9C
		[global::Cpp2ILInjected.Token(Token = "0x6000444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFCF0", Offset = "0x1EBFCF0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PopGroup()
		{
			throw null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000389F File Offset: 0x00001A9F
		[global::Cpp2ILInjected.Token(Token = "0x6000445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFB28", Offset = "0x1EBFB28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool EmptyStack()
		{
			throw null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000038A2 File Offset: 0x00001AA2
		[global::Cpp2ILInjected.Token(Token = "0x6000446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE070", Offset = "0x1EBE070", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void StartGroup(RegexNode openGroup)
		{
			throw null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000038A5 File Offset: 0x00001AA5
		[global::Cpp2ILInjected.Token(Token = "0x6000447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFA88", Offset = "0x1EBFA88", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "ReverseLeft", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddAlternate()
		{
			throw null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000038A8 File Offset: 0x00001AA8
		[global::Cpp2ILInjected.Token(Token = "0x6000448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0414", Offset = "0x1EC0414", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		private void AddConcatenate()
		{
			throw null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000038AB File Offset: 0x00001AAB
		[global::Cpp2ILInjected.Token(Token = "0x6000449")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0528", Offset = "0x1EC0528", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "MakeQuantifier", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		private void AddConcatenate(bool lazy, int min, int max)
		{
			throw null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000038AE File Offset: 0x00001AAE
		[global::Cpp2ILInjected.Token(Token = "0x600044A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2218", Offset = "0x1EC2218", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private RegexNode Unit()
		{
			throw null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000038B1 File Offset: 0x00001AB1
		[global::Cpp2ILInjected.Token(Token = "0x600044B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE8F0", Offset = "0x1EBE8F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddUnitOne(char ch)
		{
			throw null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000038B4 File Offset: 0x00001AB4
		[global::Cpp2ILInjected.Token(Token = "0x600044C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0360", Offset = "0x1EC0360", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddUnitNotone(char ch)
		{
			throw null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000038B7 File Offset: 0x00001AB7
		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBEFCC", Offset = "0x1EBEFCC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddUnitSet(string cc)
		{
			throw null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000038BA File Offset: 0x00001ABA
		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2220", Offset = "0x1EC2220", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddUnitNode(RegexNode node)
		{
			throw null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000038BD File Offset: 0x00001ABD
		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC02E4", Offset = "0x1EC02E4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AddUnitType(int type)
		{
			throw null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000038C0 File Offset: 0x00001AC0
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFBD0", Offset = "0x1EBFBD0", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "ReverseLeft", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new object[] { typeof(RegexNode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexParser), Member = "MakeException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddGroup()
		{
			throw null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000038C3 File Offset: 0x00001AC3
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBF044", Offset = "0x1EBF044", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PushOptions()
		{
			throw null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000038C6 File Offset: 0x00001AC6
		[global::Cpp2ILInjected.Token(Token = "0x6000452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFDAC", Offset = "0x1EBFDAC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PopOptions()
		{
			throw null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000038C9 File Offset: 0x00001AC9
		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC1A54", Offset = "0x1EC1A54", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool EmptyOptionsStack()
		{
			throw null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000038CC File Offset: 0x00001ACC
		[global::Cpp2ILInjected.Token(Token = "0x6000454")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFA0C", Offset = "0x1EBFA0C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PopKeepOptions()
		{
			throw null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000038CF File Offset: 0x00001ACF
		[global::Cpp2ILInjected.Token(Token = "0x6000455")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBFB38", Offset = "0x1EBFB38", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(RegexCharClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBlank", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanDecimal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanHex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanControl", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ScanCharEscape", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "PopGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ArgumentException MakeException(string message)
		{
			throw null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000038D2 File Offset: 0x00001AD2
		[global::Cpp2ILInjected.Token(Token = "0x6000456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2228", Offset = "0x1EC2228", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int Textpos()
		{
			throw null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000038D5 File Offset: 0x00001AD5
		[global::Cpp2ILInjected.Token(Token = "0x6000457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2230", Offset = "0x1EC2230", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Textto(int pos)
		{
			throw null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000038D8 File Offset: 0x00001AD8
		[global::Cpp2ILInjected.Token(Token = "0x6000458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0434", Offset = "0x1EC0434", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private char RightCharMoveRight()
		{
			throw null;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000038DB File Offset: 0x00001ADB
		[global::Cpp2ILInjected.Token(Token = "0x6000459")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE3FC", Offset = "0x1EBE3FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MoveRight()
		{
			throw null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000038DE File Offset: 0x00001ADE
		[global::Cpp2ILInjected.Token(Token = "0x600045A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0D24", Offset = "0x1EC0D24", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MoveRight(int i)
		{
			throw null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000038E1 File Offset: 0x00001AE1
		[global::Cpp2ILInjected.Token(Token = "0x600045B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0404", Offset = "0x1EC0404", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MoveLeft()
		{
			throw null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000038E4 File Offset: 0x00001AE4
		[global::Cpp2ILInjected.Token(Token = "0x600045C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE8E4", Offset = "0x1EBE8E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private char CharAt(int i)
		{
			throw null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000038E7 File Offset: 0x00001AE7
		[global::Cpp2ILInjected.Token(Token = "0x600045D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE420", Offset = "0x1EBE420", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal char RightChar()
		{
			throw null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000038EA File Offset: 0x00001AEA
		[global::Cpp2ILInjected.Token(Token = "0x600045E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC0D10", Offset = "0x1EC0D10", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private char RightChar(int i)
		{
			throw null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000038ED File Offset: 0x00001AED
		[global::Cpp2ILInjected.Token(Token = "0x600045F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EBE40C", Offset = "0x1EBE40C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int CharsRight()
		{
			throw null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000038F0 File Offset: 0x00001AF0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000460")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC2238", Offset = "0x1EC2238", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RegexParser()
		{
			throw null;
		}

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x400034C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RegexNode _stack;

		// Token: 0x0400020C RID: 524
		[global::Cpp2ILInjected.Token(Token = "0x400034D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RegexNode _group;

		// Token: 0x0400020D RID: 525
		[global::Cpp2ILInjected.Token(Token = "0x400034E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RegexNode _alternation;

		// Token: 0x0400020E RID: 526
		[global::Cpp2ILInjected.Token(Token = "0x400034F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private RegexNode _concatenation;

		// Token: 0x0400020F RID: 527
		[global::Cpp2ILInjected.Token(Token = "0x4000350")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private RegexNode _unit;

		// Token: 0x04000210 RID: 528
		[global::Cpp2ILInjected.Token(Token = "0x4000351")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _pattern;

		// Token: 0x04000211 RID: 529
		[global::Cpp2ILInjected.Token(Token = "0x4000352")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _currentPos;

		// Token: 0x04000212 RID: 530
		[global::Cpp2ILInjected.Token(Token = "0x4000353")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private CultureInfo _culture;

		// Token: 0x04000213 RID: 531
		[global::Cpp2ILInjected.Token(Token = "0x4000354")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _autocap;

		// Token: 0x04000214 RID: 532
		[global::Cpp2ILInjected.Token(Token = "0x4000355")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int _capcount;

		// Token: 0x04000215 RID: 533
		[global::Cpp2ILInjected.Token(Token = "0x4000356")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int _captop;

		// Token: 0x04000216 RID: 534
		[global::Cpp2ILInjected.Token(Token = "0x4000357")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int _capsize;

		// Token: 0x04000217 RID: 535
		[global::Cpp2ILInjected.Token(Token = "0x4000358")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Hashtable _caps;

		// Token: 0x04000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x4000359")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Hashtable _capnames;

		// Token: 0x04000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x400035A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int[] _capnumlist;

		// Token: 0x0400021A RID: 538
		[global::Cpp2ILInjected.Token(Token = "0x400035B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private List<string> _capnamelist;

		// Token: 0x0400021B RID: 539
		[global::Cpp2ILInjected.Token(Token = "0x400035C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private RegexOptions _options;

		// Token: 0x0400021C RID: 540
		[global::Cpp2ILInjected.Token(Token = "0x400035D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private List<RegexOptions> _optionsStack;

		// Token: 0x0400021D RID: 541
		[global::Cpp2ILInjected.Token(Token = "0x400035E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool _ignoreNextParen;

		// Token: 0x0400021E RID: 542
		[global::Cpp2ILInjected.Token(Token = "0x400035F")]
		private static readonly byte[] s_category;
	}
}
