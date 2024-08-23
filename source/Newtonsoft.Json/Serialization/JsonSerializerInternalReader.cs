using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000083 RID: 131
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x000030F5 File Offset: 0x000012F5
		[global::Cpp2ILInjected.Token(Token = "0x6000607")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEFDC0", Offset = "0x1CEFDC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000030F8 File Offset: 0x000012F8
		[global::Cpp2ILInjected.Token(Token = "0x6000608")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEFDC4", Offset = "0x1CEFDC4", Length = "0x518")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = "PopulateInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "MoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public void Populate(JsonReader reader, object target)
		{
			throw null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000030FB File Offset: 0x000012FB
		[global::Cpp2ILInjected.Token(Token = "0x6000609")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF1A54", Offset = "0x1CF1A54", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolveTypeName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ref JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object),
			typeof(ref bool),
			typeof(ref object),
			typeof(ref JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(Type),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private JsonContract GetContractSafe(Type type)
		{
			throw null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000030FE File Offset: 0x000012FE
		[global::Cpp2ILInjected.Token(Token = "0x600060A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF1B0C", Offset = "0x1CF1B0C", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerProxy), Member = "DeserializeInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "ClearErrorContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			throw null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00003101 File Offset: 0x00001301
		[global::Cpp2ILInjected.Token(Token = "0x600060B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF2954", Offset = "0x1CF2954", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerProxy), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializerInternalReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private JsonSerializerProxy GetInternalSerializer()
		{
			throw null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00003104 File Offset: 0x00001304
		[global::Cpp2ILInjected.Token(Token = "0x600060C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF29BC", Offset = "0x1CF29BC", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "get_Token", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JRaw), Member = "Create", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JRaw))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			throw null;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00003107 File Offset: 0x00001307
		[global::Cpp2ILInjected.Token(Token = "0x600060D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF2CA0", Offset = "0x1CF2CA0", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndMoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CheckPropertyName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JTokenWriter), Member = "get_Token", ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private JToken CreateJObject(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000310A File Offset: 0x0000130A
		[global::Cpp2ILInjected.Token(Token = "0x600060E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF2430", Offset = "0x1CF2430", Length = "0x4C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(Type),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadExtensionDataValue", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CoerceEmptyStringToNull", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonContract),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JRaw), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			throw null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000310D File Offset: 0x0000130D
		[global::Cpp2ILInjected.Token(Token = "0x600060F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF44A8", Offset = "0x1CF44A8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyPresence", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonProperty),
			typeof(Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s)
		{
			throw null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00003110 File Offset: 0x00001310
		[global::Cpp2ILInjected.Token(Token = "0x6000610")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF45AC", Offset = "0x1CF45AC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureArrayContract", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract)
		}, ReturnType = typeof(JsonArrayContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal string GetExpectedDescription(JsonContract contract)
		{
			throw null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00003113 File Offset: 0x00001313
		[global::Cpp2ILInjected.Token(Token = "0x6000611")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF1E5C", Offset = "0x1CF1E5C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ref JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object),
			typeof(ref bool),
			typeof(ref object),
			typeof(ref JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(Type),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonConverter))]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			throw null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00003116 File Offset: 0x00001316
		[global::Cpp2ILInjected.Token(Token = "0x6000612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF30E8", Offset = "0x1CF30E8", Length = "0xA18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HasNoDefinedType", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_DateParseHandling", MemberParameters = new object[] { typeof(DateParseHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_DateTimeZoneHandling", MemberParameters = new object[] { typeof(DateTimeZoneHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "set_FloatParseHandling", MemberParameters = new object[] { typeof(FloatParseHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
		{
			typeof(JTokenReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataProperties", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewDictionary", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(ref bool)
		}, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnErrorCallbacks", ReturnType = typeof(IList<SerializationErrorCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "get_ParameterizedCreator", ReturnType = typeof(ObjectConstructor<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetExpectedDescription", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			throw null;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00003119 File Offset: 0x00001319
		[global::Cpp2ILInjected.Token(Token = "0x6000613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF4668", Offset = "0x1CF4668", Length = "0x6F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetReferenceResolver", ReturnType = typeof(IReferenceResolver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ResolveTypeName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "get_Path", ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			throw null;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000311C File Offset: 0x0000131C
		[global::Cpp2ILInjected.Token(Token = "0x6000614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF4D58", Offset = "0x1CF4D58", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ResolveTypeName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetReferenceResolver", ReturnType = typeof(IReferenceResolver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			throw null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000311F File Offset: 0x0000131F
		[global::Cpp2ILInjected.Token(Token = "0x6000615")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF5DEC", Offset = "0x1CF5DEC", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
		{
			typeof(JTokenReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataProperties", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "SplitFullyQualifiedTypeName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
			throw null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00003122 File Offset: 0x00001322
		[global::Cpp2ILInjected.Token(Token = "0x6000616")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF62BC", Offset = "0x1CF62BC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetExpectedDescription", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			throw null;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00003125 File Offset: 0x00001325
		[global::Cpp2ILInjected.Token(Token = "0x6000617")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF3B00", Offset = "0x1CF3B00", Length = "0x628")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataPropertiesToken", MemberParameters = new object[]
		{
			typeof(JTokenReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ReadMetadataProperties", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(ref object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HasNoDefinedType", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EnsureArrayContract", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract)
		}, ReturnType = typeof(JsonArrayContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(ref bool)
		}, ReturnType = typeof(IList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnErrorCallbacks", ReturnType = typeof(IList<SerializationErrorCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "ToMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(Type),
			typeof(int)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = "get_ParameterizedCreator", ReturnType = typeof(ObjectConstructor<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(int)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			throw null;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00003128 File Offset: 0x00001328
		[global::Cpp2ILInjected.Token(Token = "0x6000618")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF53A0", Offset = "0x1CF53A0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool HasNoDefinedType(JsonContract contract)
		{
			throw null;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000312B File Offset: 0x0000132B
		[global::Cpp2ILInjected.Token(Token = "0x6000619")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF4128", Offset = "0x1CF4128", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetObjectType", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "IsInteger", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "ConvertOrCast", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "FormatValueForPrint", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
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
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			throw null;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000312E File Offset: 0x0000132E
		[global::Cpp2ILInjected.Token(Token = "0x600061A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF6D00", Offset = "0x1CF6D00", Length = "0x460")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ref JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object),
			typeof(ref bool),
			typeof(ref object),
			typeof(ref JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ShouldSetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			throw null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00003131 File Offset: 0x00001331
		[global::Cpp2ILInjected.Token(Token = "0x600061B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7160", Offset = "0x1CF7160", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTokenUtils), Member = "IsPrimitiveToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "GetResolvedDefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue)
		{
			throw null;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00003134 File Offset: 0x00001334
		[global::Cpp2ILInjected.Token(Token = "0x600061C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF75A4", Offset = "0x1CF75A4", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetReferenceResolver", ReturnType = typeof(IReferenceResolver))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private void AddReference(JsonReader reader, string id, object value)
		{
			throw null;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00003137 File Offset: 0x00001337
		[global::Cpp2ILInjected.Token(Token = "0x600061D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7598", Offset = "0x1CF7598", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			throw null;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000313A File Offset: 0x0000133A
		[global::Cpp2ILInjected.Token(Token = "0x600061E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7494", Offset = "0x1CF7494", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "GetResolvedDefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ShouldSetPropertyValue(JsonProperty property, object value)
		{
			throw null;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000313D File Offset: 0x0000133D
		[global::Cpp2ILInjected.Token(Token = "0x600061F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF643C", Offset = "0x1CF643C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = "CreateTemporaryCollection", ReturnType = typeof(IList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			throw null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00003140 File Offset: 0x00001340
		[global::Cpp2ILInjected.Token(Token = "0x6000620")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF5610", Offset = "0x1CF5610", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "CreateTemporaryDictionary", ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			throw null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00003143 File Offset: 0x00001343
		[global::Cpp2ILInjected.Token(Token = "0x6000621")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7934", Offset = "0x1CF7934", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "InvokeOnDeserializing", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
			throw null;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00003146 File Offset: 0x00001346
		[global::Cpp2ILInjected.Token(Token = "0x6000622")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7B54", Offset = "0x1CF7B54", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "InvokeOnDeserialized", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
			throw null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00003149 File Offset: 0x00001349
		[global::Cpp2ILInjected.Token(Token = "0x6000623")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF07E0", Offset = "0x1CF07E0", Length = "0x8A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = "set_ItemContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CheckPropertyName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTimeZoneHandling),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(CultureInfo),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
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
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			throw null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000314C File Offset: 0x0000134C
		[global::Cpp2ILInjected.Token(Token = "0x6000624")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF6690", Offset = "0x1CF6690", Length = "0x670")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Push", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Pop", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Peek", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JsonPosition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			throw null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000314F File Offset: 0x0000134F
		[global::Cpp2ILInjected.Token(Token = "0x6000625")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7D74", Offset = "0x1CF7D74", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "ClearErrorContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message)
		{
			throw null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00003152 File Offset: 0x00001352
		[global::Cpp2ILInjected.Token(Token = "0x6000626")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF02DC", Offset = "0x1CF02DC", Length = "0x504")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = "set_ItemContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "GetPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JsonPosition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			throw null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00003155 File Offset: 0x00001355
		[global::Cpp2ILInjected.Token(Token = "0x6000627")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF57FC", Offset = "0x1CF57FC", Length = "0x5F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_FullyTrusted", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonFormatterConverter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(JsonSerializerInternalReader),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(IFormatterConverter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			throw null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00003158 File Offset: 0x00001358
		[global::Cpp2ILInjected.Token(Token = "0x6000628")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE2A78", Offset = "0x1CE2A78", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "CreateReader", ReturnType = typeof(JsonReader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndAssert", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			throw null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000315B File Offset: 0x0000135B
		[global::Cpp2ILInjected.Token(Token = "0x6000629")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF7EA0", Offset = "0x1CF7EA0", Length = "0x1980")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_HasRequiredOrDefaultValueProperties", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader.<>c__DisplayClass36_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "All", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader.CreatorPropertyContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CoerceEmptyStringToNull", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonContract),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "GetResolvedDefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "IndexOf", MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "ForgivingCaseSensitiveFind", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<TSource>",
			"System.Func`2<TSource, String>",
			typeof(string)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ShouldSetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 122)]
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id)
		{
			throw null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000315E File Offset: 0x0000135E
		[global::Cpp2ILInjected.Token(Token = "0x600062A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF2044", Offset = "0x1CF2044", Length = "0x3EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializableItem", MemberParameters = new object[]
		{
			typeof(JToken),
			typeof(Type),
			typeof(JsonISerializableContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue)
		{
			throw null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00003161 File Offset: 0x00001361
		[global::Cpp2ILInjected.Token(Token = "0x600062B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF9820", Offset = "0x1CF9820", Length = "0x5E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader.CreatorPropertyContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "GetClosestMatchProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "DeserializeConvertable", MemberParameters = new object[]
		{
			typeof(JsonConverter),
			typeof(JsonReader),
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadExtensionDataValue", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			throw null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00003164 File Offset: 0x00001364
		[global::Cpp2ILInjected.Token(Token = "0x600062C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF1EBC", Offset = "0x1CF1EBC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "ReadAndMoveToContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter)
		{
			throw null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00003167 File Offset: 0x00001367
		[global::Cpp2ILInjected.Token(Token = "0x600062D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF5438", Offset = "0x1CF5438", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator)
		{
			throw null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000316A File Offset: 0x0000136A
		[global::Cpp2ILInjected.Token(Token = "0x600062E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF1084", Offset = "0x1CF1084", Length = "0x9D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_HasRequiredOrDefaultValueProperties", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToDictionary", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object),
			"System.Int32Enum"
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>),
			typeof(Func<object, Int32Enum>)
		}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CheckPropertyName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "GetClosestMatchProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ShouldDeserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadForType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyPresence", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonProperty),
			typeof(Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "SetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "SetExtensionData", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			throw null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000316D File Offset: 0x0000136D
		[global::Cpp2ILInjected.Token(Token = "0x600062F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFA474", Offset = "0x1CFA474", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			throw null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00003170 File Offset: 0x00001370
		[global::Cpp2ILInjected.Token(Token = "0x6000630")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF2FD8", Offset = "0x1CF2FD8", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJObject", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			throw null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00003173 File Offset: 0x00001373
		[global::Cpp2ILInjected.Token(Token = "0x6000631")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFA320", Offset = "0x1CFA320", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "ReadExtensionDataValue", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o)
		{
			throw null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00003176 File Offset: 0x00001376
		[global::Cpp2ILInjected.Token(Token = "0x6000632")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFA26C", Offset = "0x1CFA26C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(Type)
		}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetExtensionData", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken), Member = "ReadFrom", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CreateValueInternal", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader)
		{
			throw null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00003179 File Offset: 0x00001379
		[global::Cpp2ILInjected.Token(Token = "0x6000633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF9E04", Offset = "0x1CF9E04", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "GetContractSafe", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "GetResolvedDefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue)
		{
			throw null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000317C File Offset: 0x0000137C
		[global::Cpp2ILInjected.Token(Token = "0x6000634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CFA6D8", Offset = "0x1CFA6D8", Length = "0x1108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalReader), Member = "CoerceEmptyStringToNull", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(JsonContract),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			"System.Int32Enum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			throw null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000317F File Offset: 0x0000137F
		[global::Cpp2ILInjected.Token(Token = "0x6000635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CF28F0", Offset = "0x1CF28F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "ClearErrorContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
			throw null;
		}

		// Token: 0x02000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
		internal enum PropertyPresence
		{
			// Token: 0x040003C0 RID: 960
			[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
			None,
			// Token: 0x040003C1 RID: 961
			[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
			Null,
			// Token: 0x040003C2 RID: 962
			[global::Cpp2ILInjected.Token(Token = "0x40002C4")]
			Value
		}

		// Token: 0x02000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x20000AA")]
		internal class CreatorPropertyContext
		{
			// Token: 0x06000AE8 RID: 2792 RVA: 0x00004034 File Offset: 0x00002234
			[global::Cpp2ILInjected.Token(Token = "0x6000636")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB7E0", Offset = "0x1CFB7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(ObjectConstructor<object>),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
			{
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(JsonReader),
				typeof(Type)
			}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CreatorPropertyContext()
			{
				throw null;
			}

			// Token: 0x040003C3 RID: 963
			[global::Cpp2ILInjected.Token(Token = "0x40002C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x040003C4 RID: 964
			[global::Cpp2ILInjected.Token(Token = "0x40002C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public JsonProperty Property;

			// Token: 0x040003C5 RID: 965
			[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public JsonProperty ConstructorProperty;

			// Token: 0x040003C6 RID: 966
			[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public JsonSerializerInternalReader.PropertyPresence? Presence;

			// Token: 0x040003C7 RID: 967
			[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public object Value;

			// Token: 0x040003C8 RID: 968
			[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public bool Used;
		}

		// Token: 0x02000118 RID: 280
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x06000AE9 RID: 2793 RVA: 0x00004037 File Offset: 0x00002237
			[global::Cpp2ILInjected.Token(Token = "0x6000637")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB7E8", Offset = "0x1CFB7E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(ObjectConstructor<object>),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass36_0()
			{
				throw null;
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x0000403A File Offset: 0x0000223A
			[global::Cpp2ILInjected.Token(Token = "0x6000638")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB7F0", Offset = "0x1CFB7F0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p)
			{
				throw null;
			}

			// Token: 0x040003C9 RID: 969
			[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public JsonProperty property;
		}

		// Token: 0x02000119 RID: 281
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000AC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AEB RID: 2795 RVA: 0x0000403D File Offset: 0x0000223D
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000639")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB804", Offset = "0x1CFB804", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x00004040 File Offset: 0x00002240
			[global::Cpp2ILInjected.Token(Token = "0x600063A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB860", Offset = "0x1CFB860", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000AED RID: 2797 RVA: 0x00004043 File Offset: 0x00002243
			[global::Cpp2ILInjected.Token(Token = "0x600063B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB868", Offset = "0x1CFB868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p)
			{
				throw null;
			}

			// Token: 0x06000AEE RID: 2798 RVA: 0x00004046 File Offset: 0x00002246
			[global::Cpp2ILInjected.Token(Token = "0x600063C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB870", Offset = "0x1CFB870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p)
			{
				throw null;
			}

			// Token: 0x06000AEF RID: 2799 RVA: 0x00004049 File Offset: 0x00002249
			[global::Cpp2ILInjected.Token(Token = "0x600063D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB878", Offset = "0x1CFB878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal JsonProperty <PopulateObject>b__41_0(JsonProperty m)
			{
				throw null;
			}

			// Token: 0x06000AF0 RID: 2800 RVA: 0x0000404C File Offset: 0x0000224C
			[global::Cpp2ILInjected.Token(Token = "0x600063E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CFB880", Offset = "0x1CFB880", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m)
			{
				throw null;
			}

			// Token: 0x040003CA RID: 970
			[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
			public static readonly JsonSerializerInternalReader.<>c <>9;

			// Token: 0x040003CB RID: 971
			[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
			public static Func<JsonProperty, string> <>9__36_0;

			// Token: 0x040003CC RID: 972
			[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
			public static Func<JsonProperty, string> <>9__36_2;

			// Token: 0x040003CD RID: 973
			[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
			public static Func<JsonProperty, JsonProperty> <>9__41_0;

			// Token: 0x040003CE RID: 974
			[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
			public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__41_1;
		}
	}
}
