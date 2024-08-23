using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000032 RID: 50
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00002651 File Offset: 0x00000851
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC77C4", Offset = "0x1CC77C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", ReturnType = typeof(void))]
		public JsonSerializationException()
		{
			throw null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002654 File Offset: 0x00000854
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC6F4C", Offset = "0x1CC6F4C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c__DisplayClass34_1", Member = "<SetExtensionDataDelegates>b__0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberSerialization)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultSerializationBinder), Member = "GetTypeFromTypeNameKey", MemberParameters = new object[] { typeof(DefaultSerializationBinder.TypeNameKey) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new object[] { typeof(JsonProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetByteArray", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCreationConverter<>), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonObjectIdConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IsoDateTimeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public JsonSerializationException(string message)
		{
			throw null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002657 File Offset: 0x00000857
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC77C8", Offset = "0x1CC77C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionValueProvider), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionValueProvider), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public JsonSerializationException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000265A File Offset: 0x0000085A
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC77CC", Offset = "0x1CC77CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000265D File Offset: 0x0000085D
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC437C", Offset = "0x1CC437C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonSerializationException))]
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			throw null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002660 File Offset: 0x00000860
		[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC77D0", Offset = "0x1CC77D0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "SetExtensionData", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			throw null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002663 File Offset: 0x00000863
		[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CC784C", Offset = "0x1CC784C", Length = "0xB4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonProperty),
			typeof(JsonContract),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(ISerializable),
			typeof(JsonISerializableContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			throw null;
		}
	}
}
