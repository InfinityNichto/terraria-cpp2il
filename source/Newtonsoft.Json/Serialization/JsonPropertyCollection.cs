using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007F RID: 127
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x0000308C File Offset: 0x0000128C
		[global::Cpp2ILInjected.Token(Token = "0x60005DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE6648", Offset = "0x1CE6648", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateConstructorParameters", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(JsonPropertyCollection)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberSerialization)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyedCollection<, >), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEqualityComparer`1<TKey>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public JsonPropertyCollection(Type type)
		{
			throw null;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0000308F File Offset: 0x0000128F
		[global::Cpp2ILInjected.Token(Token = "0x60005DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF138", Offset = "0x1CEF138", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override string GetKeyForItem(JsonProperty item)
		{
			throw null;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00003092 File Offset: 0x00001292
		[global::Cpp2ILInjected.Token(Token = "0x60005DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE67E8", Offset = "0x1CE67E8", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateConstructorParameters", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(JsonPropertyCollection)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberSerialization)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyedCollection<, >), Member = "Contains", MemberParameters = new object[] { "TKey" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyedCollection<, >), Member = "get_Item", MemberParameters = new object[] { "TKey" }, ReturnType = "TItem")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsInterface", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "ImplementInterface", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void AddProperty(JsonProperty property)
		{
			throw null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00003095 File Offset: 0x00001295
		[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE67A8", Offset = "0x1CE67A8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateConstructorParameters", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(JsonPropertyCollection)
		}, ReturnType = typeof(IList<JsonProperty>))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(JsonProperty))]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			throw null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00003098 File Offset: 0x00001298
		[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF228", Offset = "0x1CEF228", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPropertyCollection), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private new bool TryGetValue(string key, out JsonProperty item)
		{
			throw null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000309B File Offset: 0x0000129B
		[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF140", Offset = "0x1CEF140", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPropertyCollection), Member = "GetClosestMatchProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x0400024E RID: 590
		[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly Type _type;

		// Token: 0x0400024F RID: 591
		[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly List<JsonProperty> _list;
	}
}
