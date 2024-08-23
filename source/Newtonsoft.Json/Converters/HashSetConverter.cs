using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B5 RID: 181
	[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
	public class HashSetConverter : JsonConverter
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x00003A91 File Offset: 0x00001C91
		[global::Cpp2ILInjected.Token(Token = "0x6000A18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25C84", Offset = "0x1D25C84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00003A94 File Offset: 0x00001C94
		[global::Cpp2ILInjected.Token(Token = "0x6000A19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25C88", Offset = "0x1D25C88", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = "Load", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JArray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00003A97 File Offset: 0x00001C97
		[global::Cpp2ILInjected.Token(Token = "0x6000A1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25E44", Offset = "0x1D25E44", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00003A9A File Offset: 0x00001C9A
		[global::Cpp2ILInjected.Token(Token = "0x170001CE")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D25EF4", Offset = "0x1D25EF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00003A9D File Offset: 0x00001C9D
		[global::Cpp2ILInjected.Token(Token = "0x6000A1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25EFC", Offset = "0x1D25EFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public HashSetConverter()
		{
			throw null;
		}
	}
}
