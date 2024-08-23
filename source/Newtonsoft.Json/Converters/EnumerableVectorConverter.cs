using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B4 RID: 180
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	public class EnumerableVectorConverter<T> : JsonConverter
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x00003A7F File Offset: 0x00001C7F
		[global::Cpp2ILInjected.Token(Token = "0x6000A12")]
		[global::Cpp2ILInjected.Address(RVA = "0x16438CC", Offset = "0x16438CC", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00003A82 File Offset: 0x00001C82
		[global::Cpp2ILInjected.Token(Token = "0x6000A13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1643A0C", Offset = "0x1643A0C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00003A85 File Offset: 0x00001C85
		[global::Cpp2ILInjected.Token(Token = "0x6000A14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1643B44", Offset = "0x1643B44", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00003A88 File Offset: 0x00001C88
		[global::Cpp2ILInjected.Token(Token = "0x170001CD")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1643CC8", Offset = "0x1643CC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00003A8B File Offset: 0x00001C8B
		[global::Cpp2ILInjected.Token(Token = "0x6000A16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1643CD0", Offset = "0x1643CD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public EnumerableVectorConverter()
		{
			throw null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00003A8E File Offset: 0x00001C8E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1643CD8", Offset = "0x1643CD8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VectorConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static EnumerableVectorConverter()
		{
			throw null;
		}

		// Token: 0x040002E1 RID: 737
		[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
		private static readonly VectorConverter VectorConverter;
	}
}
