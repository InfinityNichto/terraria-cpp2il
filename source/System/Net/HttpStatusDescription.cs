using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C5 RID: 197
	[global::Cpp2ILInjected.Token(Token = "0x2000126")]
	internal static class HttpStatusDescription
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00003FFE File Offset: 0x000021FE
		[global::Cpp2ILInjected.Token(Token = "0x60006E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0C50", Offset = "0x1EE0C50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(HttpStatusCode),
			typeof(WebHeaderCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(WebResponseStream),
			typeof(CookieContainer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static string Get(HttpStatusCode code)
		{
			throw null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00004001 File Offset: 0x00002201
		[global::Cpp2ILInjected.Token(Token = "0x60006E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0C54", Offset = "0x1EE0C54", Length = "0x698")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
		internal static string Get(int code)
		{
			throw null;
		}
	}
}
