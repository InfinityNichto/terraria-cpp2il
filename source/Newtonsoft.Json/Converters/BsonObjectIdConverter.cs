﻿using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B7 RID: 183
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000FD")]
	public class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x060008EE RID: 2286 RVA: 0x00003AB2 File Offset: 0x00001CB2
		[global::Cpp2ILInjected.Token(Token = "0x6000A23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2688C", Offset = "0x1D2688C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonWriter), Member = "WriteObjectId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00003AB5 File Offset: 0x00001CB5
		[global::Cpp2ILInjected.Token(Token = "0x6000A24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D26970", Offset = "0x1D26970", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObjectId), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[global::Cpp2ILInjected.Token(Token = "0x6000A25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D26AE4", Offset = "0x1D26AE4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00003ABB File Offset: 0x00001CBB
		[global::Cpp2ILInjected.Token(Token = "0x6000A26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D26B68", Offset = "0x1D26B68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public BsonObjectIdConverter()
		{
			throw null;
		}
	}
}