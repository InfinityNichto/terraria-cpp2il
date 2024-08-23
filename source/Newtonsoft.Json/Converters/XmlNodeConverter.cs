using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000D6 RID: 214
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	public class XmlNodeConverter : JsonConverter
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00003D04 File Offset: 0x00001F04
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00003D07 File Offset: 0x00001F07
		[global::Cpp2ILInjected.Token(Token = "0x17000229")]
		public string DeserializeRootElementName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE4C", Offset = "0x1D2EE4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE54", Offset = "0x1D2EE54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00003D0A File Offset: 0x00001F0A
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00003D0D File Offset: 0x00001F0D
		[global::Cpp2ILInjected.Token(Token = "0x1700022A")]
		public bool WriteArrayAttribute
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE5C", Offset = "0x1D2EE5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE64", Offset = "0x1D2EE64", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00003D10 File Offset: 0x00001F10
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00003D13 File Offset: 0x00001F13
		[global::Cpp2ILInjected.Token(Token = "0x1700022B")]
		public bool OmitRootObject
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE70", Offset = "0x1D2EE70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B18")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2EE78", Offset = "0x1D2EE78", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00003D16 File Offset: 0x00001F16
		[global::Cpp2ILInjected.Token(Token = "0x6000B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2EE84", Offset = "0x1D2EE84", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "WrapXml", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "PushParentNamespaces", MemberParameters = new object[]
		{
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00003D19 File Offset: 0x00001F19
		[global::Cpp2ILInjected.Token(Token = "0x6000B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2EFA0", Offset = "0x1D2EFA0", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = "WrapNode", MemberParameters = new object[] { typeof(XObject) }, ReturnType = typeof(IXmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private IXmlNode WrapXml(object value)
		{
			throw null;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00003D1C File Offset: 0x00001F1C
		[global::Cpp2ILInjected.Token(Token = "0x6000B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2F0B8", Offset = "0x1D2F0B8", Length = "0x624")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Reverse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00003D1F File Offset: 0x00001F1F
		[global::Cpp2ILInjected.Token(Token = "0x6000B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D30D68", Offset = "0x1D30D68", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00003D22 File Offset: 0x00001F22
		[global::Cpp2ILInjected.Token(Token = "0x6000B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D31078", Offset = "0x1D31078", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ResolveFullName", MemberParameters = new object[]
		{
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00003D25 File Offset: 0x00001F25
		[global::Cpp2ILInjected.Token(Token = "0x6000B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3148C", Offset = "0x1D3148C", Length = "0x3DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private bool IsArray(IXmlNode node)
		{
			throw null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00003D28 File Offset: 0x00001F28
		[global::Cpp2ILInjected.Token(Token = "0x6000B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D31868", Offset = "0x1D31868", Length = "0x4F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "IsArray", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			throw null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00003D2B File Offset: 0x00001F2B
		[global::Cpp2ILInjected.Token(Token = "0x6000B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D2F6DC", Offset = "0x1D2F6DC", Length = "0x168C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "SerializeGroupedNodes", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "IsArray", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "AllSameName", MemberParameters = new object[] { typeof(IXmlNode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "GetPropertyName", MemberParameters = new object[]
		{
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ValueAttributes", MemberParameters = new object[] { typeof(List<IXmlNode>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IsNullOrEmpty", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.ICollection`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 84)]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
			throw null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00003D2E File Offset: 0x00001F2E
		[global::Cpp2ILInjected.Token(Token = "0x6000B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D31D60", Offset = "0x1D31D60", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static bool AllSameName(IXmlNode node)
		{
			throw null;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00003D31 File Offset: 0x00001F31
		[global::Cpp2ILInjected.Token(Token = "0x6000B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D321E8", Offset = "0x1D321E8", Length = "0x610")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XDocument), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainerWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNode), Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00003D34 File Offset: 0x00001F34
		[global::Cpp2ILInjected.Token(Token = "0x6000B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D33150", Offset = "0x1D33150", Length = "0x544")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(string),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "CreateDocumentType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(string),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
			throw null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00003D37 File Offset: 0x00001F37
		[global::Cpp2ILInjected.Token(Token = "0x6000B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D327F8", Offset = "0x1D327F8", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(Dictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(Dictionary<string, string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00003D3A File Offset: 0x00001F3A
		[global::Cpp2ILInjected.Token(Token = "0x6000B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D34A08", Offset = "0x1D34A08", Length = "0x62C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlDocument),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(IXmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
			throw null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00003D3D File Offset: 0x00001F3D
		[global::Cpp2ILInjected.Token(Token = "0x6000B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D34798", Offset = "0x1D34798", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
			throw null;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00003D40 File Offset: 0x00001F40
		[global::Cpp2ILInjected.Token(Token = "0x6000B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D351D0", Offset = "0x1D351D0", Length = "0x5B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(Dictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ToSerializationMode", MemberParameters = new object[] { typeof(DateTimeKind) }, ReturnType = typeof(XmlDateTimeSerializationMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(XmlDateTimeSerializationMode)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00003D43 File Offset: 0x00001F43
		[global::Cpp2ILInjected.Token(Token = "0x6000B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D33E4C", Offset = "0x1D33E4C", Length = "0x378")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "GetPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlDocument),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(IXmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "AddJsonArrayAttribute", MemberParameters = new object[]
		{
			typeof(IXmlElement),
			typeof(IXmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00003D46 File Offset: 0x00001F46
		[global::Cpp2ILInjected.Token(Token = "0x6000B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D35788", Offset = "0x1D35788", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadArrayElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(string),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeNode", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
			throw null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00003D49 File Offset: 0x00001F49
		[global::Cpp2ILInjected.Token(Token = "0x6000B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D341C4", Offset = "0x1D341C4", Length = "0x5D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadElement", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(IXmlNode),
			typeof(string),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "IsNamespaceAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTokenUtils), Member = "IsPrimitiveToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(string)
		}, ReturnType = typeof(JsonSerializationException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00003D4C File Offset: 0x00001F4C
		[global::Cpp2ILInjected.Token(Token = "0x6000B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D33694", Offset = "0x1D33694", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
			throw null;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00003D4F File Offset: 0x00001F4F
		[global::Cpp2ILInjected.Token(Token = "0x6000B2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D33AB8", Offset = "0x1D33AB8", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
			throw null;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00003D52 File Offset: 0x00001F52
		[global::Cpp2ILInjected.Token(Token = "0x6000B2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D35034", Offset = "0x1D35034", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "EncodeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			throw null;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00003D55 File Offset: 0x00001F55
		[global::Cpp2ILInjected.Token(Token = "0x6000B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D32AB8", Offset = "0x1D32AB8", Length = "0x698")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "DeserializeValue", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(IXmlDocument),
			typeof(XmlNamespaceManager),
			typeof(string),
			typeof(IXmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = "AddJsonArrayAttribute", MemberParameters = new object[]
		{
			typeof(IXmlElement),
			typeof(IXmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
			throw null;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00003D58 File Offset: 0x00001F58
		[global::Cpp2ILInjected.Token(Token = "0x6000B2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D35AC0", Offset = "0x1D35AC0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(Dictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			throw null;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00003D5B File Offset: 0x00001F5B
		[global::Cpp2ILInjected.Token(Token = "0x6000B30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D31FF4", Offset = "0x1D31FF4", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "SerializeNode", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IXmlNode),
			typeof(XmlNamespaceManager),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private bool ValueAttributes(List<IXmlNode> c)
		{
			throw null;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00003D5E File Offset: 0x00001F5E
		[global::Cpp2ILInjected.Token(Token = "0x6000B31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D35BA4", Offset = "0x1D35BA4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool CanConvert(Type valueType)
		{
			throw null;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00003D61 File Offset: 0x00001F61
		[global::Cpp2ILInjected.Token(Token = "0x6000B32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D35C90", Offset = "0x1D35C90", Length = "0x1008")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(Formatting)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeXmlNode", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(Formatting),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXmlNode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(XmlDocument))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeXNode", MemberParameters = new object[]
		{
			typeof(XObject),
			typeof(Formatting),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeXNode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(XDocument))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlNodeConverter()
		{
			throw null;
		}

		// Token: 0x04000300 RID: 768
		[global::Cpp2ILInjected.Token(Token = "0x400041A")]
		private const string TextName = "#text";

		// Token: 0x04000301 RID: 769
		[global::Cpp2ILInjected.Token(Token = "0x400041B")]
		private const string CommentName = "#comment";

		// Token: 0x04000302 RID: 770
		[global::Cpp2ILInjected.Token(Token = "0x400041C")]
		private const string CDataName = "#cdata-section";

		// Token: 0x04000303 RID: 771
		[global::Cpp2ILInjected.Token(Token = "0x400041D")]
		private const string WhitespaceName = "#whitespace";

		// Token: 0x04000304 RID: 772
		[global::Cpp2ILInjected.Token(Token = "0x400041E")]
		private const string SignificantWhitespaceName = "#significant-whitespace";

		// Token: 0x04000305 RID: 773
		[global::Cpp2ILInjected.Token(Token = "0x400041F")]
		private const string DeclarationName = "?xml";

		// Token: 0x04000306 RID: 774
		[global::Cpp2ILInjected.Token(Token = "0x4000420")]
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		// Token: 0x04000307 RID: 775
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000421")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <DeserializeRootElementName>k__BackingField;

		// Token: 0x04000308 RID: 776
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000422")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <WriteArrayAttribute>k__BackingField;

		// Token: 0x04000309 RID: 777
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000423")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool <OmitRootObject>k__BackingField;
	}
}
