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
	// Token: 0x0200071F RID: 1823
	[global::Cpp2ILInjected.Token(Token = "0x2000B1A")]
	internal static class StringReaderWrapExtension
	{
		// Token: 0x0600467D RID: 18045 RVA: 0x0002E9D6 File Offset: 0x0002CBD6
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

		// Token: 0x0600467E RID: 18046 RVA: 0x0002E9D9 File Offset: 0x0002CBD9
		[global::Cpp2ILInjected.Token(Token = "0x6005329")]
		[global::Cpp2ILInjected.Address(RVA = "0x94191C", Offset = "0x94191C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsIgnoredCharacter(char character)
		{
			throw null;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x0002E9DC File Offset: 0x0002CBDC
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

		// Token: 0x06004680 RID: 18048 RVA: 0x0002E9DF File Offset: 0x0002CBDF
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

		// Token: 0x06004681 RID: 18049 RVA: 0x0002E9E2 File Offset: 0x0002CBE2
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

		// Token: 0x06004682 RID: 18050 RVA: 0x0002E9E5 File Offset: 0x0002CBE5
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

		// Token: 0x04007170 RID: 29040
		[global::Cpp2ILInjected.Token(Token = "0x4008B00")]
		private static readonly HashSet<char> InvalidCharactersForLineStart;

		// Token: 0x04007171 RID: 29041
		[global::Cpp2ILInjected.Token(Token = "0x4008B01")]
		private static readonly HashSet<char> InvalidCharactersForLineEnd;

		// Token: 0x04007172 RID: 29042
		[global::Cpp2ILInjected.Token(Token = "0x4008B02")]
		private static readonly CultureInfo[] SupportedCultures;

		// Token: 0x04007173 RID: 29043
		[global::Cpp2ILInjected.Token(Token = "0x4008B03")]
		private static readonly CultureInfo SimplifiedChinese;

		// Token: 0x02000AD7 RID: 2775
		[global::Cpp2ILInjected.Token(Token = "0x2000B1B")]
		internal enum WrapScanMode
		{
			// Token: 0x04008F9D RID: 36765
			[global::Cpp2ILInjected.Token(Token = "0x4008B05")]
			Space,
			// Token: 0x04008F9E RID: 36766
			[global::Cpp2ILInjected.Token(Token = "0x4008B06")]
			NewLine,
			// Token: 0x04008F9F RID: 36767
			[global::Cpp2ILInjected.Token(Token = "0x4008B07")]
			Word,
			// Token: 0x04008FA0 RID: 36768
			[global::Cpp2ILInjected.Token(Token = "0x4008B08")]
			None
		}
	}
}
