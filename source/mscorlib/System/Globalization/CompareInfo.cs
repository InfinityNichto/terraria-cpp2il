using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Globalization.Unicode;

namespace System.Globalization
{
	// Token: 0x020004A4 RID: 1188
	[global::Cpp2ILInjected.Token(Token = "0x2000582")]
	[global::System.Serializable]
	public class CompareInfo : global::System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x06002732 RID: 10034 RVA: 0x0001B236 File Offset: 0x00019436
		[global::Cpp2ILInjected.Token(Token = "0x6002A62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD52C8", Offset = "0x1BD52C8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "InvariantFindString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0001B239 File Offset: 0x00019439
		[global::Cpp2ILInjected.Token(Token = "0x6002A63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD56B8", Offset = "0x1BD56B8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "InvariantFindString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(char*),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0001B23C File Offset: 0x0001943C
		[global::Cpp2ILInjected.Token(Token = "0x6002A64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD538C", Offset = "0x1BD538C", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "InvariantIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "InvariantLastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
		{
			throw null;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0001B23F File Offset: 0x0001943F
		[global::Cpp2ILInjected.Token(Token = "0x6002A65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5784", Offset = "0x1BD5784", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static char InvariantToUpper(char c)
		{
			throw null;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0001B242 File Offset: 0x00019442
		[global::Cpp2ILInjected.Token(Token = "0x6002A66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD579C", Offset = "0x1BD579C", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CompareOptions),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private unsafe SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0001B245 File Offset: 0x00019445
		[global::Cpp2ILInjected.Token(Token = "0x6002A67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5A28", Offset = "0x1BD5A28", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CompareInfo(CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0001B248 File Offset: 0x00019448
		[global::Cpp2ILInjected.Token(Token = "0x6002A68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5A60", Offset = "0x1BD5A60", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static CompareInfo GetCompareInfo(string name)
		{
			throw null;
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x0001B24B File Offset: 0x0001944B
		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002A69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5B10", Offset = "0x1BD5B10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0001B24E File Offset: 0x0001944E
		[global::Cpp2ILInjected.Token(Token = "0x6002A6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5B18", Offset = "0x1BD5B18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0001B251 File Offset: 0x00019451
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5BB4", Offset = "0x1BD5BB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0001B254 File Offset: 0x00019454
		[global::Cpp2ILInjected.Token(Token = "0x6002A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5B1C", Offset = "0x1BD5B1C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnDeserialized()
		{
			throw null;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0001B257 File Offset: 0x00019457
		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002A6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5BB8", Offset = "0x1BD5BB8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x0001B25A File Offset: 0x0001945A
		[global::Cpp2ILInjected.Token(Token = "0x17000619")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD5C3C", Offset = "0x1BD5C3C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0001B25D File Offset: 0x0001945D
		[global::Cpp2ILInjected.Token(Token = "0x6002A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5CC8", Offset = "0x1BD5CC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual int Compare(string string1, string string2)
		{
			throw null;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0001B260 File Offset: 0x00019460
		[global::Cpp2ILInjected.Token(Token = "0x6002A70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5CD8", Offset = "0x1BD5CD8", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public virtual int Compare(string string1, string string2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0001B263 File Offset: 0x00019463
		[global::Cpp2ILInjected.Token(Token = "0x6002A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6268", Offset = "0x1BD6268", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchWord", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchEraName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchTimeMark", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref global::System.DateTimeParse.TM)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.ParsingInfo),
			typeof(DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWord", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal int Compare(global::System.ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x0001B266 File Offset: 0x00019466
		[global::Cpp2ILInjected.Token(Token = "0x6002A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6658", Offset = "0x1BD6658", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal int CompareOptionIgnoreCase(global::System.ReadOnlySpan<char> string1, global::System.ReadOnlySpan<char> string2)
		{
			throw null;
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0001B269 File Offset: 0x00019469
		[global::Cpp2ILInjected.Token(Token = "0x6002A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6874", Offset = "0x1BD6874", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int Compare(string string1, int offset1, string string2, int offset2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0001B26C File Offset: 0x0001946C
		[global::Cpp2ILInjected.Token(Token = "0x6002A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD68CC", Offset = "0x1BD68CC", Length = "0x54C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0001B26F File Offset: 0x0001946F
		[global::Cpp2ILInjected.Token(Token = "0x6002A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6E18", Offset = "0x1BD6E18", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
		{
			throw null;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0001B272 File Offset: 0x00019472
		[global::Cpp2ILInjected.Token(Token = "0x6002A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5F78", Offset = "0x1BD5F78", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "EqualsOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "EndsWithOrdinalIgnoreCaseHelper", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CompareOptionIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "CompareStringOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal unsafe static int CompareOrdinalIgnoreCase(global::System.ReadOnlySpan<char> strA, global::System.ReadOnlySpan<char> strB)
		{
			throw null;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0001B275 File Offset: 0x00019475
		[global::Cpp2ILInjected.Token(Token = "0x6002A77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD70DC", Offset = "0x1BD70DC", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0001B278 File Offset: 0x00019478
		[global::Cpp2ILInjected.Token(Token = "0x6002A78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7454", Offset = "0x1BD7454", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0001B27B File Offset: 0x0001947B
		[global::Cpp2ILInjected.Token(Token = "0x6002A79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD77C8", Offset = "0x1BD77C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "EndsWithCultureHelper", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(CompareInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "EndsWithCultureIgnoreCaseHelper", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(CompareInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal bool IsSuffix(global::System.ReadOnlySpan<char> source, global::System.ReadOnlySpan<char> suffix, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0001B27E File Offset: 0x0001947E
		[global::Cpp2ILInjected.Token(Token = "0x6002A7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD782C", Offset = "0x1BD782C", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0001B281 File Offset: 0x00019481
		[global::Cpp2ILInjected.Token(Token = "0x6002A7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7ADC", Offset = "0x1BD7ADC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "InvariantIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "IndexOfOrdinalCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x0001B284 File Offset: 0x00019484
		[global::Cpp2ILInjected.Token(Token = "0x6002A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7C44", Offset = "0x1BD7C44", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "InvariantLastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0001B287 File Offset: 0x00019487
		[global::Cpp2ILInjected.Token(Token = "0x6002A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7F8C", Offset = "0x1BD7F8C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "InvariantLastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinalCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0001B28A File Offset: 0x0001948A
		[global::Cpp2ILInjected.Token(Token = "0x6002A7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD80B8", Offset = "0x1BD80B8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x0001B28D File Offset: 0x0001948D
		[global::Cpp2ILInjected.Token(Token = "0x6002A7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8238", Offset = "0x1BD8238", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x0001B290 File Offset: 0x00019490
		[global::Cpp2ILInjected.Token(Token = "0x6002A80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD82F0", Offset = "0x1BD82F0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x0001B293 File Offset: 0x00019493
		[global::Cpp2ILInjected.Token(Token = "0x6002A81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8310", Offset = "0x1BD8310", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalComparer), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalIgnoreCaseComparer), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "GetHashCodeOfString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "GetHashCode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Marvin), Member = "ComputeHash32", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(int),
			typeof(ulong)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		internal static int GetIgnoreCaseHash(string source)
		{
			throw null;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x0001B296 File Offset: 0x00019496
		[global::Cpp2ILInjected.Token(Token = "0x6002A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD877C", Offset = "0x1BD877C", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CultureAwareComparer), Member = "GetHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "GetHashCode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal int GetHashCodeOfString(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x0001B299 File Offset: 0x00019499
		[global::Cpp2ILInjected.Token(Token = "0x6002A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8948", Offset = "0x1BD8948", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetHashCodeOfString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual int GetHashCode(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0001B29C File Offset: 0x0001949C
		[global::Cpp2ILInjected.Token(Token = "0x6002A84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8A48", Offset = "0x1BD8A48", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x0001B29F File Offset: 0x0001949F
		[global::Cpp2ILInjected.Token(Token = "0x1700061A")]
		private static bool UseManagedCollation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD8AA8", Offset = "0x1BD8AA8", Length = "0x144")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKeyCore", MemberParameters = new object[]
			{
				typeof(string),
				typeof(CompareOptions)
			}, ReturnType = typeof(SortKey))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(string),
				typeof(CompareOptions),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(CompareOptions)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "StartsWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(CompareOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "EndsWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(CompareOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0001B2A2 File Offset: 0x000194A2
		[global::Cpp2ILInjected.Token(Token = "0x6002A86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8BEC", Offset = "0x1BD8BEC", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKeyCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_compare_managed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_index_managed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Globalization.Unicode.SimpleCollator), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private ISimpleCollator GetCollator()
		{
			throw null;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x0001B2A5 File Offset: 0x000194A5
		[global::Cpp2ILInjected.Token(Token = "0x6002A87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8EFC", Offset = "0x1BD8EFC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CreateSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0001B2A8 File Offset: 0x000194A8
		[global::Cpp2ILInjected.Token(Token = "0x6002A88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD902C", Offset = "0x1BD902C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "IndexOfCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions),
			typeof(int*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfUnchecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_index_managed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfUnchecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			throw null;
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x0001B2AB File Offset: 0x000194AB
		[global::Cpp2ILInjected.Token(Token = "0x6002A89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD616C", Offset = "0x1BD616C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CompareString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CompareString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_compare_managed", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0001B2AE File Offset: 0x000194AE
		[global::Cpp2ILInjected.Token(Token = "0x6002A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD93EC", Offset = "0x1BD93EC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0001B2B1 File Offset: 0x000194B1
		[global::Cpp2ILInjected.Token(Token = "0x6002A8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9214", Offset = "0x1BD9214", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			throw null;
		}

		// Token: 0x0600275C RID: 10076
		[global::Cpp2ILInjected.Token(Token = "0x6002A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD94EC", Offset = "0x1BD94EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options);

		// Token: 0x0600275D RID: 10077 RVA: 0x0001B2B4 File Offset: 0x000194B4
		[global::Cpp2ILInjected.Token(Token = "0x6002A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9338", Offset = "0x1BD9338", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600275E RID: 10078
		[global::Cpp2ILInjected.Token(Token = "0x6002A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD94F0", Offset = "0x1BD94F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first);

		// Token: 0x0600275F RID: 10079 RVA: 0x0001B2B7 File Offset: 0x000194B7
		[global::Cpp2ILInjected.Token(Token = "0x6002A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9160", Offset = "0x1BD9160", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static int internal_index(string source, int sindex, int count, string value, bool first)
		{
			throw null;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0001B2BA File Offset: 0x000194BA
		[global::Cpp2ILInjected.Token(Token = "0x6002A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5A54", Offset = "0x1BD5A54", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitSort(CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0001B2BD File Offset: 0x000194BD
		[global::Cpp2ILInjected.Token(Token = "0x6002A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6F8C", Offset = "0x1BD6F8C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
		{
			throw null;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0001B2C0 File Offset: 0x000194C0
		[global::Cpp2ILInjected.Token(Token = "0x6002A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7C30", Offset = "0x1BD7C30", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfUncheckedIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfUnchecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0001B2C3 File Offset: 0x000194C3
		[global::Cpp2ILInjected.Token(Token = "0x6002A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD80A4", Offset = "0x1BD80A4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "LastIndexOfOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfUncheckedIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfUnchecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0001B2C6 File Offset: 0x000194C6
		[global::Cpp2ILInjected.Token(Token = "0x6002A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD808C", Offset = "0x1BD808C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0001B2C9 File Offset: 0x000194C9
		[global::Cpp2ILInjected.Token(Token = "0x6002A95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7BDC", Offset = "0x1BD7BDC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			throw null;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0001B2CC File Offset: 0x000194CC
		[global::Cpp2ILInjected.Token(Token = "0x6002A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6600", Offset = "0x1BD6600", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		private int CompareString(global::System.ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0001B2CF File Offset: 0x000194CF
		[global::Cpp2ILInjected.Token(Token = "0x6002A97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD6794", Offset = "0x1BD6794", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "internal_compare_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int CompareString(global::System.ReadOnlySpan<char> string1, global::System.ReadOnlySpan<char> string2, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0001B2D2 File Offset: 0x000194D2
		[global::Cpp2ILInjected.Token(Token = "0x6002A98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8180", Offset = "0x1BD8180", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "CreateSortKeyCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private SortKey CreateSortKey(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x0001B2D5 File Offset: 0x000194D5
		[global::Cpp2ILInjected.Token(Token = "0x6002A99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD72F0", Offset = "0x1BD72F0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool StartsWith(string source, string prefix, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0001B2D8 File Offset: 0x000194D8
		[global::Cpp2ILInjected.Token(Token = "0x6002A9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD7668", Offset = "0x1BD7668", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool EndsWith(string source, string suffix, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0001B2DB File Offset: 0x000194DB
		[global::Cpp2ILInjected.Token(Token = "0x6002A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD77CC", Offset = "0x1BD77CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(bool))]
		private bool EndsWith(global::System.ReadOnlySpan<char> source, global::System.ReadOnlySpan<char> suffix, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0001B2DE File Offset: 0x000194DE
		[global::Cpp2ILInjected.Token(Token = "0x6002A9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD8924", Offset = "0x1BD8924", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal int GetHashCodeOfStringCore(string source, CompareOptions options)
		{
			throw null;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0001B2E1 File Offset: 0x000194E1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD94F8", Offset = "0x1BD94F8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static CompareInfo()
		{
			throw null;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0001B2E4 File Offset: 0x000194E4
		[global::Cpp2ILInjected.Token(Token = "0x6002A9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9578", Offset = "0x1BD9578", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal CompareInfo()
		{
			throw null;
		}

		// Token: 0x0400135B RID: 4955
		[global::Cpp2ILInjected.Token(Token = "0x40016B6")]
		private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x0400135C RID: 4956
		[global::Cpp2ILInjected.Token(Token = "0x40016B7")]
		private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x0400135D RID: 4957
		[global::Cpp2ILInjected.Token(Token = "0x40016B8")]
		private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x0400135E RID: 4958
		[global::Cpp2ILInjected.Token(Token = "0x40016B9")]
		private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x0400135F RID: 4959
		[global::Cpp2ILInjected.Token(Token = "0x40016BA")]
		internal static readonly CompareInfo Invariant;

		// Token: 0x04001360 RID: 4960
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x40016BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_name;

		// Token: 0x04001361 RID: 4961
		[global::Cpp2ILInjected.Token(Token = "0x40016BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		private string _sortName;

		// Token: 0x04001362 RID: 4962
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 3)]
		[global::Cpp2ILInjected.Token(Token = "0x40016BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SortVersion m_SortVersion;

		// Token: 0x04001363 RID: 4963
		[global::Cpp2ILInjected.Token(Token = "0x40016BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int culture;

		// Token: 0x04001364 RID: 4964
		[global::Cpp2ILInjected.Token(Token = "0x40016BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		private ISimpleCollator collator;

		// Token: 0x04001365 RID: 4965
		[global::Cpp2ILInjected.Token(Token = "0x40016C0")]
		private static global::System.Collections.Generic.Dictionary<string, ISimpleCollator> collators;

		// Token: 0x04001366 RID: 4966
		[global::Cpp2ILInjected.Token(Token = "0x40016C1")]
		private static bool managedCollation;

		// Token: 0x04001367 RID: 4967
		[global::Cpp2ILInjected.Token(Token = "0x40016C2")]
		private static bool managedCollationChecked;
	}
}
