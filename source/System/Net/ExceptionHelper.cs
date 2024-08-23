using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200011D RID: 285
	[global::Cpp2ILInjected.Token(Token = "0x20001A4")]
	internal static class ExceptionHelper
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00004931 File Offset: 0x00002B31
		[global::Cpp2ILInjected.Token(Token = "0x17000220")]
		internal static NotImplementedException MethodNotImplementedException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C28C", Offset = "0x1F0C28C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPoint), Member = "Serialize", ReturnType = typeof(SocketAddress))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPoint), Member = "Create", MemberParameters = new object[] { typeof(SocketAddress) }, ReturnType = typeof(EndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Abort", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00004934 File Offset: 0x00002B34
		[global::Cpp2ILInjected.Token(Token = "0x17000221")]
		internal static NotImplementedException PropertyNotImplementedException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C1E8", Offset = "0x1F0C1E8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00004937 File Offset: 0x00002B37
		[global::Cpp2ILInjected.Token(Token = "0x17000222")]
		internal static WebException TimeoutException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F3B0", Offset = "0x1F0F3B0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0000493A File Offset: 0x00002B3A
		[global::Cpp2ILInjected.Token(Token = "0x17000223")]
		internal static NotSupportedException MethodNotSupportedException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F43C", Offset = "0x1F0F43C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0000493D File Offset: 0x00002B3D
		[global::Cpp2ILInjected.Token(Token = "0x17000224")]
		internal static NotSupportedException PropertyNotSupportedException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F4BC", Offset = "0x1F0F4BC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_ContentType", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "set_ContentType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "set_UseDefaultCredentials", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_PreAuthenticate", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "set_PreAuthenticate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "get_UseDefaultCredentials", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "set_UseDefaultCredentials", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00004940 File Offset: 0x00002B40
		[global::Cpp2ILInjected.Token(Token = "0x17000225")]
		internal static WebException IsolatedException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F53C", Offset = "0x1F0F53C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(Exception),
				typeof(WebExceptionStatus),
				typeof(WebResponse),
				typeof(WebExceptionInternalStatus)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00004943 File Offset: 0x00002B43
		[global::Cpp2ILInjected.Token(Token = "0x17000226")]
		internal static WebException RequestAbortedException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F5EC", Offset = "0x1F0F5EC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream),
				typeof(ref bool)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpDataStream), Member = "CheckError", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new object[] { typeof(CloseExState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(Exception),
				typeof(WebExceptionStatus),
				typeof(WebResponse)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00004946 File Offset: 0x00002B46
		[global::Cpp2ILInjected.Token(Token = "0x17000227")]
		internal static WebException CacheEntryNotFoundException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F690", Offset = "0x1F0F690", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(Exception),
				typeof(WebExceptionStatus),
				typeof(WebResponse)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00004949 File Offset: 0x00002B49
		[global::Cpp2ILInjected.Token(Token = "0x17000228")]
		internal static WebException RequestProhibitedByCachePolicyException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0F720", Offset = "0x1F0F720", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(Exception),
				typeof(WebExceptionStatus),
				typeof(WebResponse)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}
	}
}
