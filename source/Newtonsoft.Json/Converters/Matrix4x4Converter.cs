using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B8 RID: 184
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	public class Matrix4x4Converter : JsonConverter
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x00003ABE File Offset: 0x00001CBE
		[global::Cpp2ILInjected.Token(Token = "0x6000A27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D26B70", Offset = "0x1D26B70", Length = "0x56C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00003AC1 File Offset: 0x00001CC1
		[global::Cpp2ILInjected.Token(Token = "0x6000A28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D270DC", Offset = "0x1D270DC", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[global::Cpp2ILInjected.Token(Token = "0x170001CF")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A29")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D27450", Offset = "0x1D27450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00003AC7 File Offset: 0x00001CC7
		[global::Cpp2ILInjected.Token(Token = "0x6000A2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D27458", Offset = "0x1D27458", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00003ACA File Offset: 0x00001CCA
		[global::Cpp2ILInjected.Token(Token = "0x6000A2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D274DC", Offset = "0x1D274DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public Matrix4x4Converter()
		{
			throw null;
		}
	}
}
