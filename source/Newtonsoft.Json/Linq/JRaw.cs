using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000094 RID: 148
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
	public class JRaw : JValue
	{
		// Token: 0x06000676 RID: 1654 RVA: 0x00003371 File Offset: 0x00001571
		[global::Cpp2ILInjected.Token(Token = "0x60006ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D045BC", Offset = "0x1D045BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(JValue) }, ReturnType = typeof(void))]
		public JRaw(JRaw other)
		{
			throw null;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00003374 File Offset: 0x00001574
		[global::Cpp2ILInjected.Token(Token = "0x60006EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D045C4", Offset = "0x1D045C4", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		public JRaw(object rawJson)
		{
			throw null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00003377 File Offset: 0x00001577
		[global::Cpp2ILInjected.Token(Token = "0x60006EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D045D0", Offset = "0x1D045D0", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JTokenType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static JRaw Create(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0000337A File Offset: 0x0000157A
		[global::Cpp2ILInjected.Token(Token = "0x60006F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D04944", Offset = "0x1D04944", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JValue), Member = ".ctor", MemberParameters = new object[] { typeof(JValue) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override JToken CloneToken()
		{
			throw null;
		}
	}
}
