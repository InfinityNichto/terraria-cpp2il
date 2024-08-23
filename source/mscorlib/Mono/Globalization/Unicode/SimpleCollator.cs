using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000028 RID: 40
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	internal class SimpleCollator : global::System.Globalization.ISimpleCollator
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00014765 File Offset: 0x00012965
		[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0244", Offset = "0x1AB0244", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetCollator", ReturnType = typeof(global::System.Globalization.ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "SetCJKTable", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetTailoringInfo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TailoringInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(TailoringInfo),
			typeof(ref Contraction[]),
			typeof(ref Level2Map[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public unsafe SimpleCollator(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00014768 File Offset: 0x00012968
		[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0500", Offset = "0x1AB0500", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetNeutralCulture", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref CodePointIndexer),
			typeof(ref byte*),
			typeof(ref byte*),
			typeof(ref CodePointIndexer),
			typeof(ref byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe void SetCJKTable(global::System.Globalization.CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
		{
			throw null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001476B File Offset: 0x0001296B
		[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB05D4", Offset = "0x1AB05D4", Length = "0x5C")]
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
		private unsafe static global::System.Globalization.CultureInfo GetNeutralCulture(global::System.Globalization.CultureInfo info)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0001476E File Offset: 0x0001296E
		[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0630", Offset = "0x1AB0630", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe byte Category(int cp)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00014771 File Offset: 0x00012971
		[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB06C4", Offset = "0x1AB06C4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe byte Level1(int cp)
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00014774 File Offset: 0x00012974
		[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0758", Offset = "0x1AB0758", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level2", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe byte Level2(int cp, SimpleCollator.ExtenderType ext)
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00014777 File Offset: 0x00012977
		[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0870", Offset = "0x1AB0870", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static bool IsHalfKana(int cp, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0001477A File Offset: 0x0001297A
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB08E4", Offset = "0x1AB08E4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Contraction[])
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe Contraction GetContraction(string s, int start, int end)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0001477D File Offset: 0x0001297D
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB099C", Offset = "0x1AB099C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private Contraction GetContraction(string s, int start, int end, Contraction[] clist)
		{
			throw null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00014780 File Offset: 0x00012980
		[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0A8C", Offset = "0x1AB0A8C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Contraction[])
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe Contraction GetTailContraction(string s, int start, int end)
		{
			throw null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00014783 File Offset: 0x00012983
		[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0B44", Offset = "0x1AB0B44", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist)
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00014786 File Offset: 0x00012986
		[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0D00", Offset = "0x1AB0D00", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "ToWidthCompat", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe int FilterOptions(int i, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00014789 File Offset: 0x00012989
		[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0DF0", Offset = "0x1AB0DF0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		private unsafe SimpleCollator.ExtenderType GetExtenderType(int i)
		{
			throw null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0001478C File Offset: 0x0001298C
		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0EF4", Offset = "0x1AB0EF4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001478F File Offset: 0x0001298F
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0F14", Offset = "0x1AB0F14", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe int FilterExtender(int i, SimpleCollator.ExtenderType ext, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00014792 File Offset: 0x00012992
		[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1128", Offset = "0x1AB1128", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static bool IsIgnorable(int i, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00014795 File Offset: 0x00012995
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB11AC", Offset = "0x1AB11AC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsSafe(int i)
		{
			throw null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00014798 File Offset: 0x00012998
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB11EC", Offset = "0x1AB11EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Globalization.SortKey GetSortKey(string s, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0001479B File Offset: 0x0001299B
		[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB11FC", Offset = "0x1AB11FC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CompareOptions),
			typeof(int),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(global::System.Globalization.SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Globalization.SortKey GetSortKey(string s, int start, int length, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001479E File Offset: 0x0001299E
		[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1430", Offset = "0x1AB1430", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(global::System.Globalization.SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SimpleCollator.ExtenderType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000147A1 File Offset: 0x000129A1
		[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB17D4", Offset = "0x1AB17D4", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Globalization.UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendCJKExtension", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FillSurrogateSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SortKeyBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool),
			typeof(byte),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000147A4 File Offset: 0x000129A4
		[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1D14", Offset = "0x1AB1D14", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
		{
			throw null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000147A7 File Offset: 0x000129A7
		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1E44", Offset = "0x1AB1E44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000147AA File Offset: 0x000129AA
		[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1E48", Offset = "0x1AB1E48", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
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
		internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000147AD File Offset: 0x000129AD
		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB179C", Offset = "0x1AB179C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe void ClearBuffer(byte* buffer, int size)
		{
			throw null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000147B0 File Offset: 0x000129B0
		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1EFC", Offset = "0x1AB1EFC", Length = "0x13A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SimpleCollator.ExtenderType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private unsafe int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000147B3 File Offset: 0x000129B3
		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB32AC", Offset = "0x1AB32AC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int CompareFlagPair(bool b1, bool b2)
		{
			throw null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000147B6 File Offset: 0x000129B6
		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB32CC", Offset = "0x1AB32CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsPrefix(string src, string target, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000147B9 File Offset: 0x000129B9
		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB32DC", Offset = "0x1AB32DC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
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
		public bool IsPrefix(string s, string target, int start, int length, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000147BC File Offset: 0x000129BC
		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB33CC", Offset = "0x1AB33CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
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
		private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000147BF File Offset: 0x000129BF
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB342C", Offset = "0x1AB342C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsSuffix(string src, string target, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000147C2 File Offset: 0x000129C2
		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB343C", Offset = "0x1AB343C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		public bool IsSuffix(string s, string target, int start, int length, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000147C5 File Offset: 0x000129C5
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB3648", Offset = "0x1AB3648", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
		{
			throw null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000147C8 File Offset: 0x000129C8
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB379C", Offset = "0x1AB379C", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "QuickIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe int IndexOf(string s, string target, int start, int length, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000147CB File Offset: 0x000129CB
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB3E58", Offset = "0x1AB3E58", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int IndexOfOrdinal(string s, string target, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000147CE File Offset: 0x000129CE
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB3F24", Offset = "0x1AB3F24", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int IndexOfOrdinal(string s, char target, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000147D1 File Offset: 0x000129D1
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB3F8C", Offset = "0x1AB3F8C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		private unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000147D4 File Offset: 0x000129D4
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB398C", Offset = "0x1AB398C", Length = "0x4CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000147D7 File Offset: 0x000129D7
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB34C0", Offset = "0x1AB34C0", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe int LastIndexOf(string s, string target, int start, int length, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000147DA File Offset: 0x000129DA
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB4710", Offset = "0x1AB4710", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000147DD File Offset: 0x000129DD
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB4838", Offset = "0x1AB4838", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		private unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000147E0 File Offset: 0x000129E0
		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB41D8", Offset = "0x1AB41D8", Length = "0x538")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000147E3 File Offset: 0x000129E3
		[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB4028", Offset = "0x1AB4028", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "IndexOfSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(char),
			typeof(int),
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SimpleCollator.ExtenderType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		private unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000147E6 File Offset: 0x000129E6
		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB4A98", Offset = "0x1AB4A98", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CompareOptions),
			typeof(byte*),
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000147E9 File Offset: 0x000129E9
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB4DDC", Offset = "0x1AB4DDC", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
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
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private unsafe bool MatchesPrimitive(global::System.Globalization.CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4)
		{
			throw null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000147EC File Offset: 0x000129EC
		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB48DC", Offset = "0x1AB48DC", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOfSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(bool),
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SimpleCollator.ExtenderType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(SimpleCollator.ExtenderType),
			typeof(ref Contraction),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		private unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000147EF File Offset: 0x000129EF
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5008", Offset = "0x1AB5008", Length = "0x480")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Contraction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "LastIndexOfSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(byte*),
			typeof(int),
			typeof(bool),
			typeof(ref SimpleCollator.Context)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CompareOptions),
			typeof(byte*),
			typeof(int),
			typeof(SimpleCollator.ExtenderType),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx)
		{
			throw null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000147F2 File Offset: 0x000129F2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5488", Offset = "0x1AB5488", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SimpleCollator()
		{
			throw null;
		}

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		private static SimpleCollator invariant;

		// Token: 0x0400006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x4000106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Globalization.TextInfo textInfo;

		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x4000107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly CodePointIndexer cjkIndexer;

		// Token: 0x0400006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x4000108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Contraction[] contractions;

		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Level2Map[] level2Maps;

		// Token: 0x04000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly byte[] unsafeFlags;

		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private unsafe readonly byte* cjkCatTable;

		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private unsafe readonly byte* cjkLv1Table;

		// Token: 0x04000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private unsafe readonly byte* cjkLv2Table;

		// Token: 0x04000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly CodePointIndexer cjkLv2Indexer;

		// Token: 0x04000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly int lcid;

		// Token: 0x04000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private readonly bool frenchSort;

		// Token: 0x02000567 RID: 1383
		[global::Cpp2ILInjected.Token(Token = "0x200003B")]
		internal struct Context
		{
			// Token: 0x06003F2F RID: 16175 RVA: 0x0001F85F File Offset: 0x0001DA5F
			[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB17B8", Offset = "0x1AB17B8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public unsafe Context(global::System.Globalization.CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				throw null;
			}

			// Token: 0x04001740 RID: 5952
			[global::Cpp2ILInjected.Token(Token = "0x4000111")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly global::System.Globalization.CompareOptions Option;

			// Token: 0x04001741 RID: 5953
			[global::Cpp2ILInjected.Token(Token = "0x4000112")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public unsafe readonly byte* NeverMatchFlags;

			// Token: 0x04001742 RID: 5954
			[global::Cpp2ILInjected.Token(Token = "0x4000113")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public unsafe readonly byte* AlwaysMatchFlags;

			// Token: 0x04001743 RID: 5955
			[global::Cpp2ILInjected.Token(Token = "0x4000114")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public unsafe byte* Buffer1;

			// Token: 0x04001744 RID: 5956
			[global::Cpp2ILInjected.Token(Token = "0x4000115")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public unsafe byte* Buffer2;

			// Token: 0x04001745 RID: 5957
			[global::Cpp2ILInjected.Token(Token = "0x4000116")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int PrevCode;

			// Token: 0x04001746 RID: 5958
			[global::Cpp2ILInjected.Token(Token = "0x4000117")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public unsafe byte* PrevSortKey;
		}

		// Token: 0x02000568 RID: 1384
		[global::Cpp2ILInjected.Token(Token = "0x200003C")]
		private struct PreviousInfo
		{
			// Token: 0x06003F30 RID: 16176 RVA: 0x0001F862 File Offset: 0x0001DA62
			[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB329C", Offset = "0x1AB329C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public PreviousInfo(bool dummy)
			{
				throw null;
			}

			// Token: 0x04001747 RID: 5959
			[global::Cpp2ILInjected.Token(Token = "0x4000118")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Code;

			// Token: 0x04001748 RID: 5960
			[global::Cpp2ILInjected.Token(Token = "0x4000119")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public unsafe byte* SortKey;
		}

		// Token: 0x02000569 RID: 1385
		[global::Cpp2ILInjected.Token(Token = "0x200003D")]
		private struct Escape
		{
			// Token: 0x04001749 RID: 5961
			[global::Cpp2ILInjected.Token(Token = "0x400011A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string Source;

			// Token: 0x0400174A RID: 5962
			[global::Cpp2ILInjected.Token(Token = "0x400011B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int Index;

			// Token: 0x0400174B RID: 5963
			[global::Cpp2ILInjected.Token(Token = "0x400011C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int Start;

			// Token: 0x0400174C RID: 5964
			[global::Cpp2ILInjected.Token(Token = "0x400011D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int End;

			// Token: 0x0400174D RID: 5965
			[global::Cpp2ILInjected.Token(Token = "0x400011E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int Optional;
		}

		// Token: 0x0200056A RID: 1386
		[global::Cpp2ILInjected.Token(Token = "0x200003E")]
		private enum ExtenderType
		{
			// Token: 0x0400174F RID: 5967
			[global::Cpp2ILInjected.Token(Token = "0x4000120")]
			None,
			// Token: 0x04001750 RID: 5968
			[global::Cpp2ILInjected.Token(Token = "0x4000121")]
			Simple,
			// Token: 0x04001751 RID: 5969
			[global::Cpp2ILInjected.Token(Token = "0x4000122")]
			Voiced,
			// Token: 0x04001752 RID: 5970
			[global::Cpp2ILInjected.Token(Token = "0x4000123")]
			Conditional,
			// Token: 0x04001753 RID: 5971
			[global::Cpp2ILInjected.Token(Token = "0x4000124")]
			Buggy
		}
	}
}
