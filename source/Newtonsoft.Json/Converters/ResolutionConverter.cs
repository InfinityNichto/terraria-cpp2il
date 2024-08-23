using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000BB RID: 187
	[global::Cpp2ILInjected.Token(Token = "0x2000102")]
	public class ResolutionConverter : JsonConverter
	{
		// Token: 0x06000905 RID: 2309 RVA: 0x00003AF7 File Offset: 0x00001CF7
		[global::Cpp2ILInjected.Token(Token = "0x6000A41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28940", Offset = "0x1D28940", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resolution), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resolution), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resolution), Member = "get_refreshRate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00003AFA File Offset: 0x00001CFA
		[global::Cpp2ILInjected.Token(Token = "0x6000A42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28AE4", Offset = "0x1D28AE4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00003AFD File Offset: 0x00001CFD
		[global::Cpp2ILInjected.Token(Token = "0x6000A43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28B68", Offset = "0x1D28B68", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resolution), Member = "set_height", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resolution), Member = "set_width", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resolution), Member = "set_refreshRate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00003B00 File Offset: 0x00001D00
		[global::Cpp2ILInjected.Token(Token = "0x170001D1")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D28CD4", Offset = "0x1D28CD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00003B03 File Offset: 0x00001D03
		[global::Cpp2ILInjected.Token(Token = "0x6000A45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D28CDC", Offset = "0x1D28CDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ResolutionConverter()
		{
			throw null;
		}
	}
}
