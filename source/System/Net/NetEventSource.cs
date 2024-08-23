using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C8 RID: 200
	[global::Cpp2ILInjected.Token(Token = "0x2000129")]
	internal sealed class NetEventSource : EventSource
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x00004016 File Offset: 0x00002216
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE182C", Offset = "0x1EE182C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebResponse), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(FormattableString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Enter(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00004019 File Offset: 0x00002219
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE1D88", Offset = "0x1EE1D88", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(Uri),
			typeof(FtpStatusCode),
			typeof(string),
			typeof(DateTime),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Enter(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000401C File Offset: 0x0000221C
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2234", Offset = "0x1EE2234", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000401F File Offset: 0x0000221F
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2334", Offset = "0x1EE2334", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(NetworkCredential),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(ChannelBinding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStream), Member = "SetSocketTimeoutOption", MemberParameters = new object[]
		{
			typeof(SocketShutdown),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00004022 File Offset: 0x00002222
		[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		[global::Cpp2ILInjected.Token(Token = "0x60006F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE1D0C", Offset = "0x1EE1D0C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Enter(string thisOrContextObject, string memberName, string parameters)
		{
			throw null;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00004025 File Offset: 0x00002225
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2448", Offset = "0x1EE2448", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebResponse), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(FormattableString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Exit(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00004028 File Offset: 0x00002228
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE25AC", Offset = "0x1EE25AC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Exit(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000402B File Offset: 0x0000222B
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2670", Offset = "0x1EE2670", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Exit(object thisOrContextObject, object arg0, object arg1, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000402E File Offset: 0x0000222E
		[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		[global::Cpp2ILInjected.Token(Token = "0x60006F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2530", Offset = "0x1EE2530", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Exit(string thisOrContextObject, string memberName, string result)
		{
			throw null;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00004031 File Offset: 0x00002231
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE039C", Offset = "0x1EE039C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(FormattableString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Info(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00004034 File Offset: 0x00002234
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0484", Offset = "0x1EE0484", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CompleteCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(NetworkCredential),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(ChannelBinding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "Abort", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SubmitRequest", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimerCallback", MemberParameters = new object[]
		{
			typeof(TimerThread.Timer),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Info(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00004037 File Offset: 0x00002237
		[Event(4, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		[global::Cpp2ILInjected.Token(Token = "0x60006FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2770", Offset = "0x1EE2770", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Info(string thisOrContextObject, string memberName, string message)
		{
			throw null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000403A File Offset: 0x0000223A
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE27EC", Offset = "0x1EE27EC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(FormattableString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Error(object thisOrContextObject, FormattableString formattableString, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000403D File Offset: 0x0000223D
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2920", Offset = "0x1EE2920", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "ErrorMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Error(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00004040 File Offset: 0x00002240
		[Event(5, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
		[global::Cpp2ILInjected.Token(Token = "0x60006FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE28A4", Offset = "0x1EE28A4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ErrorMessage(string thisOrContextObject, string memberName, string message)
		{
			throw null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00004043 File Offset: 0x00002243
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x60006FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE29E4", Offset = "0x1EE29E4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(object),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SecurityBufferType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(FormattableString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Fail(object thisOrContextObject, FormattableString formattableString, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00004046 File Offset: 0x00002246
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000700")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDFB78", Offset = "0x1EDFB78", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "get_ContextCopy", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "StartPostingAsyncOp", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContextAwareResult), Member = "CaptureOrComplete", MemberParameters = new object[]
		{
			typeof(ref ExecutionContext),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetContext", MemberParameters = new object[] { typeof(ref SecurityStatusPal) }, ReturnType = typeof(SafeDeleteContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetClientSpecifiedSpn", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(SafeDeleteContext),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SSPIHandleCache), Member = "CacheCredential", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "CriticalFailure", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Fail(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00004049 File Offset: 0x00002249
		[Event(6, Level = EventLevel.Critical, Keywords = (EventKeywords)2L)]
		[global::Cpp2ILInjected.Token(Token = "0x6000701")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2A9C", Offset = "0x1EE2A9C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void CriticalFailure(string thisOrContextObject, string memberName, string message)
		{
			throw null;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000404C File Offset: 0x0000224C
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000702")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2B18", Offset = "0x1EE2B18", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DumpBuffer(object thisOrContextObject, byte[] buffer, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000404F File Offset: 0x0000224F
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000703")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2B8C", Offset = "0x1EE2B8C", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static void DumpBuffer(object thisOrContextObject, byte[] buffer, int offset, int count, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004052 File Offset: 0x00002252
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000704")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2ED8", Offset = "0x1EE2ED8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public unsafe static void DumpBuffer(object thisOrContextObject, IntPtr bufferPtr, int count, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00004055 File Offset: 0x00002255
		[Event(7, Level = EventLevel.Verbose, Keywords = (EventKeywords)2L)]
		[global::Cpp2ILInjected.Token(Token = "0x6000705")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE2E60", Offset = "0x1EE2E60", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void DumpBuffer(string thisOrContextObject, string memberName, byte[] buffer)
		{
			throw null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00004058 File Offset: 0x00002258
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000706")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3250", Offset = "0x1EE3250", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Associate(object first, object second, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000405B File Offset: 0x0000225B
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000707")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3398", Offset = "0x1EE3398", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Associate(object thisOrContextObject, object first, object second, [CallerMemberName] string memberName = null)
		{
			throw null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000405E File Offset: 0x0000225E
		[Event(3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L, Message = "[{2}]<-->[{3}]")]
		[global::Cpp2ILInjected.Token(Token = "0x6000708")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3318", Offset = "0x1EE3318", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "WriteEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Associate(string thisOrContextObject, string memberName, string first, string second)
		{
			throw null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00004061 File Offset: 0x00002261
		[Conditional("DEBUG_NETEVENTSOURCE_MISUSE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000709")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE366C", Offset = "0x1EE366C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void DebugValidateArg(object arg)
		{
			throw null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00004064 File Offset: 0x00002264
		[Conditional("DEBUG_NETEVENTSOURCE_MISUSE")]
		[global::Cpp2ILInjected.Token(Token = "0x600070A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE36B8", Offset = "0x1EE36B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugValidateArg(FormattableString arg)
		{
			throw null;
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00004067 File Offset: 0x00002267
		[global::Cpp2ILInjected.Token(Token = "0x1700017C")]
		public new static bool IsEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x600070B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE0340", Offset = "0x1EE0340", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 103)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000406A File Offset: 0x0000226A
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x600070C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE1914", Offset = "0x1EE1914", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(object),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string IdOf(object value)
		{
			throw null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000406D File Offset: 0x0000226D
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x600070D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE36BC", Offset = "0x1EE36BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int GetHashCode(object value)
		{
			throw null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00004070 File Offset: 0x00002270
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x600070E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE1E68", Offset = "0x1EE1E68", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(FormattableString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "IdOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static object Format(object value)
		{
			throw null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00004073 File Offset: 0x00002273
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x600070F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE19F8", Offset = "0x1EE19F8", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Format", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static string Format(FormattableString s)
		{
			throw null;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00004076 File Offset: 0x00002276
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000710")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3470", Offset = "0x1EE3470", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "Associate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEventCore", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(EventSource.EventData*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
		{
			throw null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00004079 File Offset: 0x00002279
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000711")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE302C", Offset = "0x1EE302C", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetEventSource), Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEventCore", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(EventSource.EventData*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private unsafe void WriteEvent(int eventId, string arg1, string arg2, byte[] arg3)
		{
			throw null;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000407C File Offset: 0x0000227C
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000712")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE36D0", Offset = "0x1EE36D0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEventCore", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(EventSource.EventData*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void WriteEvent(int eventId, string arg1, int arg2, int arg3, int arg4)
		{
			throw null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000407F File Offset: 0x0000227F
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000713")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3834", Offset = "0x1EE3834", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEventCore", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(EventSource.EventData*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void WriteEvent(int eventId, string arg1, int arg2, string arg3)
		{
			throw null;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00004082 File Offset: 0x00002282
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000714")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE39B8", Offset = "0x1EE39B8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEventCore", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(EventSource.EventData*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void WriteEvent(int eventId, string arg1, string arg2, int arg3)
		{
			throw null;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00004085 File Offset: 0x00002285
		[NonEvent]
		[global::Cpp2ILInjected.Token(Token = "0x6000715")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3B3C", Offset = "0x1EE3B3C", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "WriteEventCore", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(EventSource.EventData*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3, int arg4)
		{
			throw null;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00004088 File Offset: 0x00002288
		[global::Cpp2ILInjected.Token(Token = "0x6000716")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3D0C", Offset = "0x1EE3D0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = ".ctor", ReturnType = typeof(void))]
		public NetEventSource()
		{
			throw null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000408B File Offset: 0x0000228B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000717")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3D14", Offset = "0x1EE3D14", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static NetEventSource()
		{
			throw null;
		}

		// Token: 0x040003F5 RID: 1013
		[global::Cpp2ILInjected.Token(Token = "0x400056A")]
		public static readonly NetEventSource Log;

		// Token: 0x040003F6 RID: 1014
		[global::Cpp2ILInjected.Token(Token = "0x400056B")]
		private const string MissingMember = "(?)";

		// Token: 0x040003F7 RID: 1015
		[global::Cpp2ILInjected.Token(Token = "0x400056C")]
		private const string NullInstance = "(null)";

		// Token: 0x040003F8 RID: 1016
		[global::Cpp2ILInjected.Token(Token = "0x400056D")]
		private const string StaticMethodObject = "(static)";

		// Token: 0x040003F9 RID: 1017
		[global::Cpp2ILInjected.Token(Token = "0x400056E")]
		private const string NoParameters = "";

		// Token: 0x040003FA RID: 1018
		[global::Cpp2ILInjected.Token(Token = "0x400056F")]
		private const int MaxDumpSize = 1024;

		// Token: 0x040003FB RID: 1019
		[global::Cpp2ILInjected.Token(Token = "0x4000570")]
		private const int EnterEventId = 1;

		// Token: 0x040003FC RID: 1020
		[global::Cpp2ILInjected.Token(Token = "0x4000571")]
		private const int ExitEventId = 2;

		// Token: 0x040003FD RID: 1021
		[global::Cpp2ILInjected.Token(Token = "0x4000572")]
		private const int AssociateEventId = 3;

		// Token: 0x040003FE RID: 1022
		[global::Cpp2ILInjected.Token(Token = "0x4000573")]
		private const int InfoEventId = 4;

		// Token: 0x040003FF RID: 1023
		[global::Cpp2ILInjected.Token(Token = "0x4000574")]
		private const int ErrorEventId = 5;

		// Token: 0x04000400 RID: 1024
		[global::Cpp2ILInjected.Token(Token = "0x4000575")]
		private const int CriticalFailureEventId = 6;

		// Token: 0x04000401 RID: 1025
		[global::Cpp2ILInjected.Token(Token = "0x4000576")]
		private const int DumpArrayEventId = 7;

		// Token: 0x04000402 RID: 1026
		[global::Cpp2ILInjected.Token(Token = "0x4000577")]
		private const int EnumerateSecurityPackagesId = 8;

		// Token: 0x04000403 RID: 1027
		[global::Cpp2ILInjected.Token(Token = "0x4000578")]
		private const int SspiPackageNotFoundId = 9;

		// Token: 0x04000404 RID: 1028
		[global::Cpp2ILInjected.Token(Token = "0x4000579")]
		private const int AcquireDefaultCredentialId = 10;

		// Token: 0x04000405 RID: 1029
		[global::Cpp2ILInjected.Token(Token = "0x400057A")]
		private const int AcquireCredentialsHandleId = 11;

		// Token: 0x04000406 RID: 1030
		[global::Cpp2ILInjected.Token(Token = "0x400057B")]
		private const int InitializeSecurityContextId = 12;

		// Token: 0x04000407 RID: 1031
		[global::Cpp2ILInjected.Token(Token = "0x400057C")]
		private const int SecurityContextInputBufferId = 13;

		// Token: 0x04000408 RID: 1032
		[global::Cpp2ILInjected.Token(Token = "0x400057D")]
		private const int SecurityContextInputBuffersId = 14;

		// Token: 0x04000409 RID: 1033
		[global::Cpp2ILInjected.Token(Token = "0x400057E")]
		private const int AcceptSecuritContextId = 15;

		// Token: 0x0400040A RID: 1034
		[global::Cpp2ILInjected.Token(Token = "0x400057F")]
		private const int OperationReturnedSomethingId = 16;

		// Token: 0x0400040B RID: 1035
		[global::Cpp2ILInjected.Token(Token = "0x4000580")]
		private const int NextAvailableEventId = 17;

		// Token: 0x020003C9 RID: 969
		[global::Cpp2ILInjected.Token(Token = "0x200012A")]
		public class Keywords
		{
			// Token: 0x06001D53 RID: 7507 RVA: 0x000080ED File Offset: 0x000062ED
			[global::Cpp2ILInjected.Token(Token = "0x6000718")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3D70", Offset = "0x1EE3D70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Keywords()
			{
				throw null;
			}

			// Token: 0x04001126 RID: 4390
			[global::Cpp2ILInjected.Token(Token = "0x4000581")]
			public const EventKeywords Default = (EventKeywords)1L;

			// Token: 0x04001127 RID: 4391
			[global::Cpp2ILInjected.Token(Token = "0x4000582")]
			public const EventKeywords Debug = (EventKeywords)2L;

			// Token: 0x04001128 RID: 4392
			[global::Cpp2ILInjected.Token(Token = "0x4000583")]
			public const EventKeywords EnterExit = (EventKeywords)4L;
		}
	}
}
