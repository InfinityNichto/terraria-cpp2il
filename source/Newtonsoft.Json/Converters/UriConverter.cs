using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BD RID: 189
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	public class UriConverter : JsonConverter
	{
		// Token: 0x06000913 RID: 2323 RVA: 0x00003B21 File Offset: 0x00001D21
		[global::Cpp2ILInjected.Token(Token = "0x6000A4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D293B0", Offset = "0x1D293B0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00003B24 File Offset: 0x00001D24
		[global::Cpp2ILInjected.Token(Token = "0x6000A50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D29434", Offset = "0x1D29434", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00003B27 File Offset: 0x00001D27
		[global::Cpp2ILInjected.Token(Token = "0x6000A51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2954C", Offset = "0x1D2954C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00003B2A File Offset: 0x00001D2A
		[global::Cpp2ILInjected.Token(Token = "0x6000A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2966C", Offset = "0x1D2966C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public UriConverter()
		{
			throw null;
		}
	}
}
