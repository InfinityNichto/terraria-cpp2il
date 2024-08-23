using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000134 RID: 308
	[global::Cpp2ILInjected.Token(Token = "0x20001BB")]
	internal class HttpProtocolUtils
	{
		// Token: 0x060009A4 RID: 2468 RVA: 0x00004967 File Offset: 0x00002B67
		[global::Cpp2ILInjected.Token(Token = "0x6000AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10378", Offset = "0x1F10378", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private HttpProtocolUtils()
		{
			throw null;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0000496A File Offset: 0x00002B6A
		[global::Cpp2ILInjected.Token(Token = "0x6000AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10380", Offset = "0x1F10380", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpDateParse), Member = "ParseHttpDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static DateTime string2date(string S)
		{
			throw null;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0000496D File Offset: 0x00002B6D
		[global::Cpp2ILInjected.Token(Token = "0x6000AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10400", Offset = "0x1F10400", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SetDateHeaderHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static string date2string(DateTime D)
		{
			throw null;
		}
	}
}
