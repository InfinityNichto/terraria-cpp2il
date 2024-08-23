﻿using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BA RID: 186
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000101")]
	public class RegexConverter : JsonConverter
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x00003ADC File Offset: 0x00001CDC
		[global::Cpp2ILInjected.Token(Token = "0x6000A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28060", Offset = "0x1D28060", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Regex),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00003ADF File Offset: 0x00001CDF
		[global::Cpp2ILInjected.Token(Token = "0x6000A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2842C", Offset = "0x1D2842C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			throw null;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00003AE2 File Offset: 0x00001CE2
		[global::Cpp2ILInjected.Token(Token = "0x6000A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28158", Offset = "0x1D28158", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "WriteRegex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
			throw null;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00003AE5 File Offset: 0x00001CE5
		[global::Cpp2ILInjected.Token(Token = "0x6000A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28284", Offset = "0x1D28284", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetResolvedPropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00003AE8 File Offset: 0x00001CE8
		[global::Cpp2ILInjected.Token(Token = "0x6000A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28438", Offset = "0x1D28438", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexConverter), Member = "ReadRegexString", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00003AEB File Offset: 0x00001CEB
		[global::Cpp2ILInjected.Token(Token = "0x6000A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28744", Offset = "0x1D28744", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object ReadRegexString(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00003AEE File Offset: 0x00001CEE
		[global::Cpp2ILInjected.Token(Token = "0x6000A3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D284D4", Offset = "0x1D284D4", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00003AF1 File Offset: 0x00001CF1
		[global::Cpp2ILInjected.Token(Token = "0x6000A3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D288B4", Offset = "0x1D288B4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[global::Cpp2ILInjected.Token(Token = "0x6000A40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28938", Offset = "0x1D28938", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public RegexConverter()
		{
			throw null;
		}

		// Token: 0x040002E5 RID: 741
		[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
		private const string PatternName = "Pattern";

		// Token: 0x040002E6 RID: 742
		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		private const string OptionsName = "Options";
	}
}