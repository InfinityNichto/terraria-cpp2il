using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005A RID: 90
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	internal static class MiscellaneousUtils
	{
		// Token: 0x060003B1 RID: 945 RVA: 0x00002B7F File Offset: 0x00000D7F
		[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDAF38", Offset = "0x1CDAF38", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ShouldSetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteDynamicProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "IsInteger", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Equals", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathUtils), Member = "ApproxEquals", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static bool ValueEquals(object objA, object objB)
		{
			throw null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002B82 File Offset: 0x00000D82
		[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC014", Offset = "0x1CCC014", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "ToSerializationMode", MemberParameters = new object[] { typeof(DateTimeKind) }, ReturnType = typeof(XmlDateTimeSerializationMode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "GetEndToken", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(JsonToken?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenReader), Member = "SetToken", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "WriteTo", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonConverter[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
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
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			throw null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002B85 File Offset: 0x00000D85
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB1E8", Offset = "0x1CDB1E8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JConstructor), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string ToString(object value)
		{
			throw null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002B88 File Offset: 0x00000D88
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB294", Offset = "0x1CDB294", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JValue), Member = "Compare", MemberParameters = new object[]
		{
			typeof(JTokenType),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			throw null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002B8B File Offset: 0x00000D8B
		[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB314", Offset = "0x1CDB314", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(Dictionary<string, string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(string),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetQualifiedNameParts", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		public static string GetPrefix(string qualifiedName)
		{
			throw null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002B8E File Offset: 0x00000D8E
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB3C4", Offset = "0x1CDB3C4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XDocumentWrapper), Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetQualifiedNameParts", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		public static string GetLocalName(string qualifiedName)
		{
			throw null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002B91 File Offset: 0x00000D91
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB338", Offset = "0x1CDB338", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscellaneousUtils), Member = "GetLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
			throw null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002B94 File Offset: 0x00000D94
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB3E8", Offset = "0x1CDB3E8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static string FormatValueForPrint(object value)
		{
			throw null;
		}
	}
}
