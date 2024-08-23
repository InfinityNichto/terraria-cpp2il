using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000A8 RID: 168
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000EC")]
	internal class JPath
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x000039C8 File Offset: 0x00001BC8
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x000039CB File Offset: 0x00001BCB
		[global::Cpp2ILInjected.Token(Token = "0x170001C0")]
		public List<PathFilter> Filters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20D48", Offset = "0x1D20D48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20D50", Offset = "0x1D20D50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000039CE File Offset: 0x00001BCE
		[global::Cpp2ILInjected.Token(Token = "0x60009C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D20D58", Offset = "0x1D20D58", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "SelectToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "SelectTokens", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public JPath(string expression)
		{
			throw null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000039D1 File Offset: 0x00001BD1
		[global::Cpp2ILInjected.Token(Token = "0x60009C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D20E10", Offset = "0x1D20E10", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EatWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new object[]
		{
			typeof(List<PathFilter>),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ParseMain()
		{
			throw null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000039D4 File Offset: 0x00001BD4
		[global::Cpp2ILInjected.Token(Token = "0x60009C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D20F94", Offset = "0x1D20F94", Length = "0x5C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseMain", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private bool ParsePath(List<PathFilter> filters, int currentPartStartIndex, bool query)
		{
			throw null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000039D7 File Offset: 0x00001BD7
		[global::Cpp2ILInjected.Token(Token = "0x60009C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D21560", Offset = "0x1D21560", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new object[]
		{
			typeof(List<PathFilter>),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EatWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseArrayIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private PathFilter ParseIndexer(char indexerOpenChar)
		{
			throw null;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000039DA File Offset: 0x00001BDA
		[global::Cpp2ILInjected.Token(Token = "0x60009C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D21B4C", Offset = "0x1D21B4C", Length = "0x748")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EatWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		private PathFilter ParseArrayIndexer(char indexerCloseChar)
		{
			throw null;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000039DD File Offset: 0x00001BDD
		[global::Cpp2ILInjected.Token(Token = "0x60009C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D20F48", Offset = "0x1D20F48", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseMain", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseArrayIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private void EatWhitespace()
		{
			throw null;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000039E0 File Offset: 0x00001BE0
		[global::Cpp2ILInjected.Token(Token = "0x60009C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D219CC", Offset = "0x1D219CC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EatWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private PathFilter ParseQuery(char indexerCloseChar)
		{
			throw null;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000039E3 File Offset: 0x00001BE3
		[global::Cpp2ILInjected.Token(Token = "0x60009C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D22294", Offset = "0x1D22294", Length = "0x620")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EatWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParsePath", MemberParameters = new object[]
		{
			typeof(List<PathFilter>),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "GetValueType", MemberParameters = new object[]
		{
			typeof(JTokenType?),
			typeof(object)
		}, ReturnType = typeof(JTokenType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompositeExpression), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseOperator", ReturnType = typeof(QueryOperator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ParseValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private QueryExpression ParseExpression()
		{
			throw null;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000039E6 File Offset: 0x00001BE6
		[global::Cpp2ILInjected.Token(Token = "0x60009C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D22A90", Offset = "0x1D22A90", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ReadQuotedString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private object ParseValue()
		{
			throw null;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000039E9 File Offset: 0x00001BE9
		[global::Cpp2ILInjected.Token(Token = "0x60009CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D22F3C", Offset = "0x1D22F3C", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private string ReadQuotedString()
		{
			throw null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000039EC File Offset: 0x00001BEC
		[global::Cpp2ILInjected.Token(Token = "0x60009CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D22E14", Offset = "0x1D22E14", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseOperator", ReturnType = typeof(QueryOperator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private bool Match(string s)
		{
			throw null;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000039EF File Offset: 0x00001BEF
		[global::Cpp2ILInjected.Token(Token = "0x60009CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D228BC", Offset = "0x1D228BC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private QueryOperator ParseOperator()
		{
			throw null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000039F2 File Offset: 0x00001BF2
		[global::Cpp2ILInjected.Token(Token = "0x60009CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D216AC", Offset = "0x1D216AC", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "ReadQuotedString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EatWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "EnsureLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private PathFilter ParseQuotedField(char indexerCloseChar)
		{
			throw null;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000039F5 File Offset: 0x00001BF5
		[global::Cpp2ILInjected.Token(Token = "0x60009CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D21648", Offset = "0x1D21648", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseArrayIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseQuery", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseExpression", ReturnType = typeof(QueryExpression))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JPath), Member = "ParseQuotedField", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(PathFilter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void EnsureLength(string message)
		{
			throw null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000039F8 File Offset: 0x00001BF8
		[global::Cpp2ILInjected.Token(Token = "0x60009CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D23150", Offset = "0x1D23150", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "SelectToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "SelectTokens", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal IEnumerable<JToken> Evaluate(JToken t, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000039FB File Offset: 0x00001BFB
		[global::Cpp2ILInjected.Token(Token = "0x60009D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2315C", Offset = "0x1D2315C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "IsMatch", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static IEnumerable<JToken> Evaluate(List<PathFilter> filters, JToken t, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x040002CA RID: 714
		[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _expression;

		// Token: 0x040002CB RID: 715
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<PathFilter> <Filters>k__BackingField;

		// Token: 0x040002CC RID: 716
		[global::Cpp2ILInjected.Token(Token = "0x40003CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _currentIndex;
	}
}
