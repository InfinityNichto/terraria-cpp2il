using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000F1")]
	internal class BooleanQueryExpression : QueryExpression
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001C3")]
		public List<PathFilter> Path
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23574", Offset = "0x1D23574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2357C", Offset = "0x1D2357C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001C4")]
		public JValue Value
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23584", Offset = "0x1D23584", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2358C", Offset = "0x1D2358C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D23594", Offset = "0x1D23594", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JPath), Member = "Evaluate", MemberParameters = new object[]
		{
			typeof(List<PathFilter>),
			typeof(JToken),
			typeof(bool)
		}, ReturnType = typeof(IEnumerable<JToken>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BooleanQueryExpression), Member = "EqualsWithStringCoercion", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override bool IsMatch(JToken t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D23A00", Offset = "0x1D23A00", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BooleanQueryExpression), Member = "IsMatch", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = "ValuesEquals", MemberParameters = new object[]
		{
			typeof(JValue),
			typeof(JValue)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "CreateStringWriter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTimeOffset),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60009E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D22E0C", Offset = "0x1D22E0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BooleanQueryExpression()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<PathFilter> <Path>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private JValue <Value>k__BackingField;
	}
}
