using System;
using System.Collections.Generic;
using System.Xml;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200003E RID: 62
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000041")]
	internal static class JsonTokenUtils
	{
		// Token: 0x060002BA RID: 698 RVA: 0x000028CD File Offset: 0x00000ACD
		[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC4B4", Offset = "0x1CCC4B4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsEndToken(JsonToken token)
		{
			throw null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000028D0 File Offset: 0x00000AD0
		[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC2C8", Offset = "0x1CCC2C8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "get_Depth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "Skip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static bool IsStartToken(JsonToken token)
		{
			throw null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000028D3 File Offset: 0x00000AD3
		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCFDE8", Offset = "0x1CCFDE8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsString", ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNodeConverter), Member = "ReadAttributeElements", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(XmlNamespaceManager)
		}, ReturnType = typeof(Dictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal static bool IsPrimitiveToken(JsonToken token)
		{
			throw null;
		}
	}
}
