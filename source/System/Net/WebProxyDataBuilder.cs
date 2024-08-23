using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200016A RID: 362
	[global::Cpp2ILInjected.Token(Token = "0x2000209")]
	internal abstract class WebProxyDataBuilder
	{
		// Token: 0x06000B5D RID: 2909 RVA: 0x00004E7A File Offset: 0x0000307A
		[global::Cpp2ILInjected.Token(Token = "0x6000CB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B264", Offset = "0x1F2B264", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebProxyData Build()
		{
			throw null;
		}

		// Token: 0x06000B5E RID: 2910
		[global::Cpp2ILInjected.Token(Token = "0x6000CB2")]
		protected abstract void BuildInternal();

		// Token: 0x06000B5F RID: 2911 RVA: 0x00004E7D File Offset: 0x0000307D
		[global::Cpp2ILInjected.Token(Token = "0x6000CB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B2D8", Offset = "0x1F2B2D8", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "ParseProtocolProxies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "ParseProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "ParseBypassList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void SetProxyAndBypassList(string addressString, string bypassListString)
		{
			throw null;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00004E80 File Offset: 0x00003080
		[global::Cpp2ILInjected.Token(Token = "0x6000CB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B8B4", Offset = "0x1F2B8B4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SetAutoProxyUrl(string autoConfigUrl)
		{
			throw null;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00004E83 File Offset: 0x00003083
		[global::Cpp2ILInjected.Token(Token = "0x6000CB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B94C", Offset = "0x1F2B94C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void SetAutoDetectSettings(bool value)
		{
			throw null;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00004E86 File Offset: 0x00003086
		[global::Cpp2ILInjected.Token(Token = "0x6000CB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B3EC", Offset = "0x1F2B3EC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "SetProxyAndBypassList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "ParseProtocolProxies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "CreateInvalidProxyStringException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static Uri ParseProxyUri(string proxyString)
		{
			throw null;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00004E89 File Offset: 0x00003089
		[global::Cpp2ILInjected.Token(Token = "0x6000CB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B534", Offset = "0x1F2B534", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "SetProxyAndBypassList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "ParseProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "CreateInvalidProxyStringException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static Hashtable ParseProtocolProxies(string proxyListString)
		{
			throw null;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00004E8C File Offset: 0x0000308C
		[global::Cpp2ILInjected.Token(Token = "0x6000CB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B95C", Offset = "0x1F2B95C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "ParseProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "ParseProtocolProxies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static FormatException CreateInvalidProxyStringException(string originalProxyString)
		{
			throw null;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00004E8F File Offset: 0x0000308F
		[global::Cpp2ILInjected.Token(Token = "0x6000CB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BA34", Offset = "0x1F2BA34", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "ParseBypassList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "ConvertRegexReservedChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static string BypassStringEscape(string rawString)
		{
			throw null;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00004E92 File Offset: 0x00003092
		[global::Cpp2ILInjected.Token(Token = "0x6000CBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BD50", Offset = "0x1F2BD50", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "BypassStringEscape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string ConvertRegexReservedChars(string rawString)
		{
			throw null;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00004E95 File Offset: 0x00003095
		[global::Cpp2ILInjected.Token(Token = "0x6000CBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2B75C", Offset = "0x1F2B75C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "SetProxyAndBypassList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxyDataBuilder), Member = "BypassStringEscape", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static ArrayList ParseBypassList(string bypassListString, out bool bypassOnLocal)
		{
			throw null;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00004E98 File Offset: 0x00003098
		[global::Cpp2ILInjected.Token(Token = "0x6000CBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2BE6C", Offset = "0x1F2BE6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected WebProxyDataBuilder()
		{
			throw null;
		}

		// Token: 0x04000879 RID: 2169
		[global::Cpp2ILInjected.Token(Token = "0x4000ADA")]
		private const char addressListDelimiter = ';';

		// Token: 0x0400087A RID: 2170
		[global::Cpp2ILInjected.Token(Token = "0x4000ADB")]
		private const char addressListSchemeValueDelimiter = '=';

		// Token: 0x0400087B RID: 2171
		[global::Cpp2ILInjected.Token(Token = "0x4000ADC")]
		private const char bypassListDelimiter = ';';

		// Token: 0x0400087C RID: 2172
		[global::Cpp2ILInjected.Token(Token = "0x4000ADD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WebProxyData m_Result;

		// Token: 0x0400087D RID: 2173
		[global::Cpp2ILInjected.Token(Token = "0x4000ADE")]
		private const string regexReserved = "#$()+.?[\\^{|";
	}
}
