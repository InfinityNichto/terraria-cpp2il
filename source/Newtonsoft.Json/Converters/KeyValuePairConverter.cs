using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000B6 RID: 182
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	public class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x060008E8 RID: 2280 RVA: 0x00003AA0 File Offset: 0x00001CA0
		[global::Cpp2ILInjected.Token(Token = "0x6000A1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D25F04", Offset = "0x1D25F04", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			throw null;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00003AA3 File Offset: 0x00001CA3
		[global::Cpp2ILInjected.Token(Token = "0x6000A1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D26148", Offset = "0x1D26148", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetResolvedPropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = "GetType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00003AA6 File Offset: 0x00001CA6
		[global::Cpp2ILInjected.Token(Token = "0x6000A1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2636C", Offset = "0x1D2636C", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = "GetType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00003AA9 File Offset: 0x00001CA9
		[global::Cpp2ILInjected.Token(Token = "0x6000A20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D266A4", Offset = "0x1D266A4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool CanConvert(Type objectType)
		{
			throw null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00003AAC File Offset: 0x00001CAC
		[global::Cpp2ILInjected.Token(Token = "0x6000A21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D267A8", Offset = "0x1D267A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		public KeyValuePairConverter()
		{
			throw null;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00003AAF File Offset: 0x00001CAF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D267B0", Offset = "0x1D267B0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = ".ctor", MemberParameters = new object[] { "System.Func`2<TKey, TValue>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static KeyValuePairConverter()
		{
			throw null;
		}

		// Token: 0x040002E2 RID: 738
		[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
		private const string KeyName = "Key";

		// Token: 0x040002E3 RID: 739
		[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
		private const string ValueName = "Value";

		// Token: 0x040002E4 RID: 740
		[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;
	}
}
