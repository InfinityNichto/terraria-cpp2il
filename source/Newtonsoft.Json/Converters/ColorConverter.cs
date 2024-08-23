using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B1 RID: 177
	[global::Cpp2ILInjected.Token(Token = "0x20000F7")]
	public class ColorConverter : JsonConverter
	{
		// Token: 0x060008D0 RID: 2256 RVA: 0x00003A5B File Offset: 0x00001C5B
		[global::Cpp2ILInjected.Token(Token = "0x6000A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D255FC", Offset = "0x1D255FC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00003A5E File Offset: 0x00001C5E
		[global::Cpp2ILInjected.Token(Token = "0x6000A06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D257D0", Offset = "0x1D257D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00003A61 File Offset: 0x00001C61
		[global::Cpp2ILInjected.Token(Token = "0x6000A07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25898", Offset = "0x1D25898", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00003A64 File Offset: 0x00001C64
		[global::Cpp2ILInjected.Token(Token = "0x170001CB")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D25B2C", Offset = "0x1D25B2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00003A67 File Offset: 0x00001C67
		[global::Cpp2ILInjected.Token(Token = "0x6000A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25B34", Offset = "0x1D25B34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public ColorConverter()
		{
			throw null;
		}
	}
}
