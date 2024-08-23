using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000025 RID: 37
	[global::Cpp2ILInjected.Token(Token = "0x2000036")]
	internal class MSCompatUnicodeTable
	{
		// Token: 0x06000071 RID: 113 RVA: 0x0001471A File Offset: 0x0001291A
		[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADD08", Offset = "0x1AADD08", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static TailoringInfo GetTailoringInfo(int lcid)
		{
			throw null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0001471D File Offset: 0x0001291D
		[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADDD0", Offset = "0x1AADDD0", Length = "0x6F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Sort", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Sort", MemberParameters = new object[] { typeof(global::System.Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public unsafe static void BuildTailoringTables(global::System.Globalization.CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals)
		{
			throw null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00014720 File Offset: 0x00012920
		[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAE4C0", Offset = "0x1AAE4C0", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private unsafe static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			throw null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00014723 File Offset: 0x00012923
		[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAE6F8", Offset = "0x1AAE6F8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static byte Category(int cp)
		{
			throw null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00014726 File Offset: 0x00012926
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAE794", Offset = "0x1AAE794", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static byte Level1(int cp)
		{
			throw null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00014729 File Offset: 0x00012929
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAE830", Offset = "0x1AAE830", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType"
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static byte Level2(int cp)
		{
			throw null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0001472C File Offset: 0x0001292C
		[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAE8CC", Offset = "0x1AAE8CC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(bool),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public unsafe static byte Level3(int cp)
		{
			throw null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0001472F File Offset: 0x0001292F
		[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAE968", Offset = "0x1AAE968", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool IsIgnorable(int cp, byte flag)
		{
			throw null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00014732 File Offset: 0x00012932
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEA78", Offset = "0x1AAEA78", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(bool),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsIgnorableNonSpacing(int cp)
		{
			throw null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00014735 File Offset: 0x00012935
		[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEAD0", Offset = "0x1AAEAD0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int ToKanaTypeInsensitive(int i)
		{
			throw null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00014738 File Offset: 0x00012938
		[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEAF0", Offset = "0x1AAEAF0", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int ToWidthCompat(int i)
		{
			throw null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0001473B File Offset: 0x0001293B
		[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEC7C", Offset = "0x1AAEC7C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool HasSpecialWeight(char c)
		{
			throw null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0001473E File Offset: 0x0001293E
		[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAECFC", Offset = "0x1AAECFC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsHalfWidthKana(char c)
		{
			throw null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00014741 File Offset: 0x00012941
		[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAED10", Offset = "0x1AAED10", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsHiragana(char c)
		{
			throw null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00014744 File Offset: 0x00012944
		[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAED28", Offset = "0x1AAED28", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(bool),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CompareOptions),
			typeof(byte*),
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public unsafe static bool IsJapaneseSmallLetter(char c)
		{
			throw null;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00014747 File Offset: 0x00012947
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public static bool IsReady
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAEE10", Offset = "0x1AAEE10", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0001474A File Offset: 0x0001294A
		[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEE68", Offset = "0x1AAEE68", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJKCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetManifestResourceInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref global::System.Reflection.Module)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static global::System.IntPtr GetResource(string name)
		{
			throw null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0001474D File Offset: 0x0001294D
		[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEF1C", Offset = "0x1AAEF1C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static uint UInt32FromBytePtr(byte* raw, uint idx)
		{
			throw null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00014750 File Offset: 0x00012950
		[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAEF4C", Offset = "0x1AAEF4C", Length = "0x440")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static unsafe MSCompatUnicodeTable()
		{
			throw null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00014753 File Offset: 0x00012953
		[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAF38C", Offset = "0x1AAF38C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "SetCJKTable", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJKCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "SetCJKReferences", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			throw null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00014756 File Offset: 0x00012956
		[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAF4F0", Offset = "0x1AAF4F0", Length = "0x4C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private unsafe static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table)
		{
			throw null;
		}

		// Token: 0x0400004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		public static int MaxExpansionLength;

		// Token: 0x0400004E RID: 78
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		private unsafe static readonly byte* ignorableFlags;

		// Token: 0x0400004F RID: 79
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		private unsafe static readonly byte* categories;

		// Token: 0x04000050 RID: 80
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		private unsafe static readonly byte* level1;

		// Token: 0x04000051 RID: 81
		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		private unsafe static readonly byte* level2;

		// Token: 0x04000052 RID: 82
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		private unsafe static readonly byte* level3;

		// Token: 0x04000053 RID: 83
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		private unsafe static byte* cjkCHScategory;

		// Token: 0x04000054 RID: 84
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		private unsafe static byte* cjkCHTcategory;

		// Token: 0x04000055 RID: 85
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		private unsafe static byte* cjkJAcategory;

		// Token: 0x04000056 RID: 86
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		private unsafe static byte* cjkKOcategory;

		// Token: 0x04000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		private unsafe static byte* cjkCHSlv1;

		// Token: 0x04000058 RID: 88
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		private unsafe static byte* cjkCHTlv1;

		// Token: 0x04000059 RID: 89
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		private unsafe static byte* cjkJAlv1;

		// Token: 0x0400005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		private unsafe static byte* cjkKOlv1;

		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		private unsafe static byte* cjkKOlv2;

		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		private static readonly char[] tailoringArr;

		// Token: 0x0400005D RID: 93
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		private static readonly TailoringInfo[] tailoringInfos;

		// Token: 0x0400005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		private static object forLock;

		// Token: 0x0400005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
		public static readonly bool isReady;

		// Token: 0x02000566 RID: 1382
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000037")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06003F2C RID: 16172 RVA: 0x0001F856 File Offset: 0x0001DA56
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAF9B8", Offset = "0x1AAF9B8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06003F2D RID: 16173 RVA: 0x0001F859 File Offset: 0x0001DA59
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAFA14", Offset = "0x1AAFA14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06003F2E RID: 16174 RVA: 0x0001F85C File Offset: 0x0001DA5C
			[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAFA1C", Offset = "0x1AAFA1C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b)
			{
				throw null;
			}

			// Token: 0x0400173E RID: 5950
			[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
			public static readonly MSCompatUnicodeTable.<>c <>9;

			// Token: 0x0400173F RID: 5951
			[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
			public static global::System.Comparison<Level2Map> <>9__17_0;
		}
	}
}
