using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000084 RID: 132
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00003182 File Offset: 0x00001382
		[global::Cpp2ILInjected.Token(Token = "0x600063F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFB888", Offset = "0x1CFB888", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00003185 File Offset: 0x00001385
		[global::Cpp2ILInjected.Token(Token = "0x6000640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFB90C", Offset = "0x1CFB90C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = "SerializeInternal", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "ClearErrorContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
			throw null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00003188 File Offset: 0x00001388
		[global::Cpp2ILInjected.Token(Token = "0x6000641")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFC658", Offset = "0x1CFC658", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerProxy), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializerInternalWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private JsonSerializerProxy GetInternalSerializer()
		{
			throw null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000318B File Offset: 0x0000138B
		[global::Cpp2ILInjected.Token(Token = "0x6000642")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFBB60", Offset = "0x1CFBB60", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private JsonContract GetContractSafe(object value)
		{
			throw null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000318E File Offset: 0x0000138E
		[global::Cpp2ILInjected.Token(Token = "0x6000643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFC730", Offset = "0x1CFC730", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteType", MemberParameters = new object[]
		{
			typeof(TypeNameHandling),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(PrimitiveTypeCode),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00003191 File Offset: 0x00001391
		[global::Cpp2ILInjected.Token(Token = "0x6000644")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFC024", Offset = "0x1CFC024", Length = "0x5C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializePrimitive", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonPrimitiveContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeString", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonStringContract)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00003194 File Offset: 0x00001394
		[global::Cpp2ILInjected.Token(Token = "0x6000645")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFEDCC", Offset = "0x1CFEDCC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00003197 File Offset: 0x00001397
		[global::Cpp2ILInjected.Token(Token = "0x6000646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFBC28", Offset = "0x1CFBC28", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ResolveIsReference", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetReferenceResolver", ReturnType = typeof(IReferenceResolver))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000319A File Offset: 0x0000139A
		[global::Cpp2ILInjected.Token(Token = "0x6000647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFEE80", Offset = "0x1CFEE80", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "GetResolvedDefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ShouldWriteProperty(object memberValue, JsonProperty property)
		{
			throw null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000319D File Offset: 0x0000139D
		[global::Cpp2ILInjected.Token(Token = "0x6000648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFEF6C", Offset = "0x1CFEF6C", Length = "0x538")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "Contains", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<T>",
			"T",
			typeof(IEqualityComparer)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000031A0 File Offset: 0x000013A0
		[global::Cpp2ILInjected.Token(Token = "0x6000649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFBDAC", Offset = "0x1CFBDAC", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void WriteReference(JsonWriter writer, object value)
		{
			throw null;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000031A3 File Offset: 0x000013A3
		[global::Cpp2ILInjected.Token(Token = "0x600064A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFF4A4", Offset = "0x1CFF4A4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReferenceIdProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetReferenceResolver", ReturnType = typeof(IReferenceResolver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private string GetReference(JsonWriter writer, object value)
		{
			throw null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000031A6 File Offset: 0x000013A6
		[global::Cpp2ILInjected.Token(Token = "0x600064B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFF668", Offset = "0x1CFF668", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeString", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonStringContract)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertTo", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "ConvertToInvariantString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			throw null;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000031A9 File Offset: 0x000013A9
		[global::Cpp2ILInjected.Token(Token = "0x600064C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFE0F4", Offset = "0x1CFE0F4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "TryConvertToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
			throw null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000031AC File Offset: 0x000013AC
		[global::Cpp2ILInjected.Token(Token = "0x600064D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFF83C", Offset = "0x1CFF83C", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeString", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonStringContract)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "InvokeOnSerializing", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
			throw null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000031AF File Offset: 0x000013AF
		[global::Cpp2ILInjected.Token(Token = "0x600064E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFFA38", Offset = "0x1CFFA38", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeString", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonStringContract)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "InvokeOnSerialized", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
			throw null;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000031B2 File Offset: 0x000013B2
		[global::Cpp2ILInjected.Token(Token = "0x600064F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFD18C", Offset = "0x1CFD18C", Length = "0x700")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "WritePropertyName", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000031B5 File Offset: 0x000013B5
		[global::Cpp2ILInjected.Token(Token = "0x6000650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFFD54", Offset = "0x1CFFD54", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldSerialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "IsSpecified", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "WritePropertyName", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue)
		{
			throw null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000031B8 File Offset: 0x000013B8
		[global::Cpp2ILInjected.Token(Token = "0x6000651")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFFC34", Offset = "0x1CFFC34", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ResolveIsReference", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReferenceIdProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteType", MemberParameters = new object[]
		{
			typeof(TypeNameHandling),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000031BB File Offset: 0x000013BB
		[global::Cpp2ILInjected.Token(Token = "0x6000652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D00914", Offset = "0x1D00914", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
			throw null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000031BE File Offset: 0x000013BE
		[global::Cpp2ILInjected.Token(Token = "0x6000653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFCA2C", Offset = "0x1CFCA2C", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializePrimitive", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonPrimitiveContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetTypeName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(FormatterAssemblyStyle),
			typeof(SerializationBinder)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
			throw null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000031C1 File Offset: 0x000013C1
		[global::Cpp2ILInjected.Token(Token = "0x6000654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFEF60", Offset = "0x1CFEF60", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			throw null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000031C4 File Offset: 0x000013C4
		[global::Cpp2ILInjected.Token(Token = "0x6000655")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFEE74", Offset = "0x1CFEE74", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			throw null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000031C7 File Offset: 0x000013C7
		[global::Cpp2ILInjected.Token(Token = "0x6000656")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D00B58", Offset = "0x1D00B58", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			throw null;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000031CA File Offset: 0x000013CA
		[global::Cpp2ILInjected.Token(Token = "0x6000657")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFCCA0", Offset = "0x1CFCCA0", Length = "0x4EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerProxy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000031CD File Offset: 0x000013CD
		[global::Cpp2ILInjected.Token(Token = "0x6000658")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFD88C", Offset = "0x1CFD88C", Length = "0x6C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000031D0 File Offset: 0x000013D0
		[global::Cpp2ILInjected.Token(Token = "0x6000659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFDF4C", Offset = "0x1CFDF4C", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000031D3 File Offset: 0x000013D3
		[global::Cpp2ILInjected.Token(Token = "0x600065A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D00DDC", Offset = "0x1D00DDC", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetUpperBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
			throw null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000031D6 File Offset: 0x000013D6
		[global::Cpp2ILInjected.Token(Token = "0x600065B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D00B64", Offset = "0x1D00B64", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ResolveIsReference", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteType", MemberParameters = new object[]
		{
			typeof(TypeNameHandling),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReferenceIdProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = "set_ItemContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000031D9 File Offset: 0x000013D9
		[global::Cpp2ILInjected.Token(Token = "0x600065C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFE9A4", Offset = "0x1CFE9A4", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_FullyTrusted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(IFormatterConverter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000031DC File Offset: 0x000013DC
		[global::Cpp2ILInjected.Token(Token = "0x600065D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D012BC", Offset = "0x1D012BC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultValue", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			throw null;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000031DF File Offset: 0x000013DF
		[global::Cpp2ILInjected.Token(Token = "0x600065E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFC88C", Offset = "0x1CFC88C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializePrimitive", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonPrimitiveContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000031E2 File Offset: 0x000013E2
		[global::Cpp2ILInjected.Token(Token = "0x600065F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFE168", Offset = "0x1CFE168", Length = "0x83C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteObjectStart", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = "set_ItemContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "GetContractSafe", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_ContainerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000031E5 File Offset: 0x000013E5
		[global::Cpp2ILInjected.Token(Token = "0x6000660")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D00110", Offset = "0x1D00110", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "EnsureDateTime", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTimeZoneHandling)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTime),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalWriter), Member = "TryConvertToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "WriteDateTimeOffsetString", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(DateTimeOffset),
			typeof(DateFormatHandling),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			throw null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000031E8 File Offset: 0x000013E8
		[global::Cpp2ILInjected.Token(Token = "0x6000661")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFC5E8", Offset = "0x1CFC5E8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "ClearErrorContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_WriteState", ReturnType = typeof(WriteState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
			throw null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000031EB File Offset: 0x000013EB
		[global::Cpp2ILInjected.Token(Token = "0x6000662")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D00454", Offset = "0x1D00454", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			throw null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000031EE File Offset: 0x000013EE
		[global::Cpp2ILInjected.Token(Token = "0x6000663")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D006B4", Offset = "0x1D006B4", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Path", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			throw null;
		}

		// Token: 0x04000262 RID: 610
		[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Type _rootType;

		// Token: 0x04000263 RID: 611
		[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _rootLevel;

		// Token: 0x04000264 RID: 612
		[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly List<object> _serializeStack;
	}
}
