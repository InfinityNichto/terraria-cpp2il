using System;
using System.Globalization;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000160 RID: 352
	[global::Cpp2ILInjected.Token(Token = "0x20001F4")]
	internal class NetRes
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x00004DEA File Offset: 0x00002FEA
		[global::Cpp2ILInjected.Token(Token = "0x6000C57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26FE8", Offset = "0x1F26FE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private NetRes()
		{
			throw null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00004DED File Offset: 0x00002FED
		[global::Cpp2ILInjected.Token(Token = "0x6000C58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26FF0", Offset = "0x1F26FF0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_IsolatedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_CacheEntryNotFoundException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExceptionHelper), Member = "get_RequestProhibitedByCachePolicyException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new object[] { typeof(WebExceptionStatus) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GetWebStatusString(string Res, WebExceptionStatus Status)
		{
			throw null;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00004DF0 File Offset: 0x00002FF0
		[global::Cpp2ILInjected.Token(Token = "0x6000C59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F270B0", Offset = "0x1F270B0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebExceptionMapping), Member = "GetWebStatusString", MemberParameters = new object[] { typeof(WebExceptionStatus) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetWebStatusString(WebExceptionStatus Status)
		{
			throw null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00004DF3 File Offset: 0x00002FF3
		[global::Cpp2ILInjected.Token(Token = "0x6000C5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F27110", Offset = "0x1F27110", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static string GetWebStatusCodeString(HttpStatusCode statusCode, string statusDescription)
		{
			throw null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00004DF6 File Offset: 0x00002FF6
		[global::Cpp2ILInjected.Token(Token = "0x6000C5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F272EC", Offset = "0x1F272EC", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(FtpStatusCode),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription)
		{
			throw null;
		}
	}
}
