using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B1A")]
	internal static class StringReaderWrapExtension
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005328")]
		[global::Cpp2ILInjected.Address(RVA = "0x9418A4", Offset = "0x9418A4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Contains", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsCultureSupported(CultureInfo culture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005329")]
		[global::Cpp2ILInjected.Address(RVA = "0x94191C", Offset = "0x94191C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsIgnoredCharacter(char character)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600532A")]
		[global::Cpp2ILInjected.Address(RVA = "0x941938", Offset = "0x941938", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringReaderWrapExtension), Member = "ReadUntilBreakable", MemberParameters = new object[]
		{
			typeof(StringReader),
			typeof(CultureInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<>), Member = "Contains", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static bool CanBreakBetween(char previousChar, char nextChar, CultureInfo culture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600532B")]
		[global::Cpp2ILInjected.Address(RVA = "0x941A48", Offset = "0x941A48", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringReaderWrapExtension), Member = "ReadUntilBreakable", MemberParameters = new object[]
		{
			typeof(StringReader),
			typeof(CultureInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static StringReaderWrapExtension.WrapScanMode GetModeForCharacter(char character)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600532C")]
		[global::Cpp2ILInjected.Address(RVA = "0x94150C", Offset = "0x94150C", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WrappedTextBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReaderWrapExtension), Member = "GetModeForCharacter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringReaderWrapExtension.WrapScanMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReaderWrapExtension), Member = "CanBreakBetween", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(CultureInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static string ReadUntilBreakable(this StringReader reader, CultureInfo culture)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600532D")]
		[global::Cpp2ILInjected.Address(RVA = "0x941AD4", Offset = "0x941AD4", Length = "0x830")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		static StringReaderWrapExtension()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008B00")]
		private static readonly HashSet<char> InvalidCharactersForLineStart;

		[global::Cpp2ILInjected.Token(Token = "0x4008B01")]
		private static readonly HashSet<char> InvalidCharactersForLineEnd;

		[global::Cpp2ILInjected.Token(Token = "0x4008B02")]
		private static readonly CultureInfo[] SupportedCultures;

		[global::Cpp2ILInjected.Token(Token = "0x4008B03")]
		private static readonly CultureInfo SimplifiedChinese;

		[global::Cpp2ILInjected.Token(Token = "0x2000B1B")]
		internal enum WrapScanMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008B05")]
			Space,
			[global::Cpp2ILInjected.Token(Token = "0x4008B06")]
			NewLine,
			[global::Cpp2ILInjected.Token(Token = "0x4008B07")]
			Word,
			[global::Cpp2ILInjected.Token(Token = "0x4008B08")]
			None
		}
	}
}
