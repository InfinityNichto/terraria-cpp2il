using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	internal class SimpleCollator : global::System.Globalization.ISimpleCollator
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB0EF4", Offset = "0x1AB0EF4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB11AC", Offset = "0x1AB11AC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsSafe(int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB11EC", Offset = "0x1AB11EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Globalization.SortKey GetSortKey(string s, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1E44", Offset = "0x1AB1E44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB179C", Offset = "0x1AB179C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe void ClearBuffer(byte* buffer, int size)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB32AC", Offset = "0x1AB32AC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int CompareFlagPair(bool b1, bool b2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB32CC", Offset = "0x1AB32CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsPrefix(string src, string target, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB342C", Offset = "0x1AB342C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsSuffix(string src, string target, global::System.Globalization.CompareOptions opt)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB3E58", Offset = "0x1AB3E58", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int IndexOfOrdinal(string s, string target, int start, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB3F24", Offset = "0x1AB3F24", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int IndexOfOrdinal(string s, char target, int start, int length)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB4710", Offset = "0x1AB4710", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private int LastIndexOfOrdinal(string s, string target, int start, int length)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		private static SimpleCollator invariant;

		[global::Cpp2ILInjected.Token(Token = "0x4000106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Globalization.TextInfo textInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly CodePointIndexer cjkIndexer;

		[global::Cpp2ILInjected.Token(Token = "0x4000108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Contraction[] contractions;

		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Level2Map[] level2Maps;

		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly byte[] unsafeFlags;

		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private unsafe readonly byte* cjkCatTable;

		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private unsafe readonly byte* cjkLv1Table;

		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private unsafe readonly byte* cjkLv2Table;

		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly CodePointIndexer cjkLv2Indexer;

		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly int lcid;

		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private readonly bool frenchSort;

		[global::Cpp2ILInjected.Token(Token = "0x200003B")]
		internal struct Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB17B8", Offset = "0x1AB17B8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public unsafe Context(global::System.Globalization.CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000111")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly global::System.Globalization.CompareOptions Option;

			[global::Cpp2ILInjected.Token(Token = "0x4000112")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public unsafe readonly byte* NeverMatchFlags;

			[global::Cpp2ILInjected.Token(Token = "0x4000113")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public unsafe readonly byte* AlwaysMatchFlags;

			[global::Cpp2ILInjected.Token(Token = "0x4000114")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public unsafe byte* Buffer1;

			[global::Cpp2ILInjected.Token(Token = "0x4000115")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public unsafe byte* Buffer2;

			[global::Cpp2ILInjected.Token(Token = "0x4000116")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int PrevCode;

			[global::Cpp2ILInjected.Token(Token = "0x4000117")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public unsafe byte* PrevSortKey;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200003C")]
		private struct PreviousInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AB329C", Offset = "0x1AB329C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public PreviousInfo(bool dummy)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000118")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Code;

			[global::Cpp2ILInjected.Token(Token = "0x4000119")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public unsafe byte* SortKey;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200003D")]
		private struct Escape
		{
			[global::Cpp2ILInjected.Token(Token = "0x400011A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string Source;

			[global::Cpp2ILInjected.Token(Token = "0x400011B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int Index;

			[global::Cpp2ILInjected.Token(Token = "0x400011C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int Start;

			[global::Cpp2ILInjected.Token(Token = "0x400011D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int End;

			[global::Cpp2ILInjected.Token(Token = "0x400011E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int Optional;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200003E")]
		private enum ExtenderType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000120")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000121")]
			Simple,
			[global::Cpp2ILInjected.Token(Token = "0x4000122")]
			Voiced,
			[global::Cpp2ILInjected.Token(Token = "0x4000123")]
			Conditional,
			[global::Cpp2ILInjected.Token(Token = "0x4000124")]
			Buggy
		}
	}
}
