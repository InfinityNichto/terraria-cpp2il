using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B2 RID: 178
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000F8")]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x00003A6A File Offset: 0x00001C6A
		[global::Cpp2ILInjected.Token(Token = "0x6000A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19230E4", Offset = "0x19230E4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00003A6D File Offset: 0x00001C6D
		[global::Cpp2ILInjected.Token(Token = "0x6000A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1923130", Offset = "0x1923130", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008D7 RID: 2263
		[global::Cpp2ILInjected.Token(Token = "0x6000A0C")]
		public abstract T Create(Type objectType);

		// Token: 0x060008D8 RID: 2264 RVA: 0x00003A70 File Offset: 0x00001C70
		[global::Cpp2ILInjected.Token(Token = "0x6000A0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19231F8", Offset = "0x19231F8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00003A73 File Offset: 0x00001C73
		[global::Cpp2ILInjected.Token(Token = "0x170001CC")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x192327C", Offset = "0x192327C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00003A76 File Offset: 0x00001C76
		[global::Cpp2ILInjected.Token(Token = "0x6000A0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1923284", Offset = "0x1923284", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomCreationConverter()
		{
			throw null;
		}
	}
}
