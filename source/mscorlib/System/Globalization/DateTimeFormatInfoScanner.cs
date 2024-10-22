﻿using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x200058C")]
	internal class DateTimeFormatInfoScanner
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000653")]
		private static global::System.Collections.Generic.Dictionary<string, string> KnownWords
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDFB68", Offset = "0x1BDFB68", Length = "0x3F8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDFF60", Offset = "0x1BDFF60", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0054", Offset = "0x1BE0054", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddIgnorableSymbols", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "get_KnownWords", ReturnType = typeof(global::System.Collections.Generic.Dictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0420", Offset = "0x1BE0420", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "ScanDateWord", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "SkipWhiteSpacesAndNonLetter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal int AddDateWords(string pattern, int index, string formatPostfix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE05EC", Offset = "0x1BE05EC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE02DC", Offset = "0x1BE02DC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "ScanDateWord", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void AddIgnorableSymbols(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0668", Offset = "0x1BE0668", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddIgnorableSymbols", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void ScanDateWord(string pattern)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0910", Offset = "0x1BE0910", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ScanDateWord", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0B84", Offset = "0x1BE0B84", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "EqualStringArrays", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(bool))]
		internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0C40", Offset = "0x1BE0C40", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ArrayElementsBeginWithDigit", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ArrayElementsHaveSpace", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(bool))]
		internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0F74", Offset = "0x1BE0F74", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ArrayElementsHaveSpace", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(bool))]
		internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0FA4", Offset = "0x1BE0FA4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0BC4", Offset = "0x1BE0BC4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagGenitiveMonth", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[]),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		private static bool EqualStringArrays(string[] array1, string[] array2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0E98", Offset = "0x1BE0E98", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[]),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInDayNames", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool ArrayElementsHaveSpace(string[] array)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0CE4", Offset = "0x1BE0CE4", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[]),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private static bool ArrayElementsBeginWithDigit(string[] array)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE0FB4", Offset = "0x1BE0FB4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public DateTimeFormatInfoScanner()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400175C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.Collections.Generic.List<string> m_dateWords;

		[global::Cpp2ILInjected.Token(Token = "0x400175D")]
		private static global::System.Collections.Generic.Dictionary<string, string> s_knownWords;

		[global::Cpp2ILInjected.Token(Token = "0x400175E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags;

		[global::Cpp2ILInjected.Token(Token = "0x200058D")]
		private enum FoundDatePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001760")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4001761")]
			FoundYearPatternFlag,
			[global::Cpp2ILInjected.Token(Token = "0x4001762")]
			FoundMonthPatternFlag,
			[global::Cpp2ILInjected.Token(Token = "0x4001763")]
			FoundDayPatternFlag = 4,
			[global::Cpp2ILInjected.Token(Token = "0x4001764")]
			FoundYMDPatternFlag = 7
		}
	}
}
