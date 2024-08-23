using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BF RID: 191
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000106")]
	public class VersionConverter : JsonConverter
	{
		// Token: 0x06000927 RID: 2343 RVA: 0x00003B5D File Offset: 0x00001D5D
		[global::Cpp2ILInjected.Token(Token = "0x6000A63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2A1F4", Offset = "0x1D2A1F4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00003B60 File Offset: 0x00001D60
		[global::Cpp2ILInjected.Token(Token = "0x6000A64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2A2D0", Offset = "0x1D2A2D0", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00003B63 File Offset: 0x00001D63
		[global::Cpp2ILInjected.Token(Token = "0x6000A65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2A534", Offset = "0x1D2A534", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00003B66 File Offset: 0x00001D66
		[global::Cpp2ILInjected.Token(Token = "0x6000A66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2A5B8", Offset = "0x1D2A5B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public VersionConverter()
		{
			throw null;
		}
	}
}
