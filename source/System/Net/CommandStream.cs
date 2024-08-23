using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000DC RID: 220
	[global::Cpp2ILInjected.Token(Token = "0x2000143")]
	internal class CommandStream : NetworkStreamWrapper
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x0000429B File Offset: 0x0000249B
		[global::Cpp2ILInjected.Token(Token = "0x60007DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAFF4", Offset = "0x1EEAFF4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal CommandStream(TcpClient client)
		{
			throw null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000429E File Offset: 0x0000249E
		[global::Cpp2ILInjected.Token(Token = "0x60007DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB084", Offset = "0x1EEB084", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal virtual void Abort(Exception e)
		{
			throw null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000042A1 File Offset: 0x000024A1
		[global::Cpp2ILInjected.Token(Token = "0x60007E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB280", Offset = "0x1EEB280", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000042A4 File Offset: 0x000024A4
		[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB314", Offset = "0x1EEB314", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "Abort", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream.<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "SSLHandshakeCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "RequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void InvokeRequestCallback(object obj)
		{
			throw null;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000042A7 File Offset: 0x000024A7
		[global::Cpp2ILInjected.Token(Token = "0x170001A1")]
		internal bool RecoverableFailure
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEB388", Offset = "0x1EEB388", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000042AA File Offset: 0x000024AA
		[global::Cpp2ILInjected.Token(Token = "0x60007E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB390", Offset = "0x1EEB390", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void MarkAsRecoverableFailure()
		{
			throw null;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000042AD File Offset: 0x000024AD
		[global::Cpp2ILInjected.Token(Token = "0x60007E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB3A8", Offset = "0x1EEB3A8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimedSubmitRequestHelper", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InitCommandPipeline", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(CommandStream.PipelineEntry[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect)
		{
			throw null;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000042B0 File Offset: 0x000024B0
		[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB918", Offset = "0x1EEB918", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InitCommandPipeline", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(CommandStream.PipelineEntry[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected virtual void ClearState()
		{
			throw null;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000042B3 File Offset: 0x000024B3
		[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB928", Offset = "0x1EEB928", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request)
		{
			throw null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000042B6 File Offset: 0x000024B6
		[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB930", Offset = "0x1EEB930", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			typeof(ReceiveState),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000042B9 File Offset: 0x000024B9
		[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB9A8", Offset = "0x1EEB9A8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusCodeString", MemberParameters = new object[]
		{
			typeof(FtpStatusCode),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000042BC File Offset: 0x000024BC
		[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB428", Offset = "0x1EEB428", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "SubmitRequest", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ClearState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "ClearState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync)
		{
			throw null;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000042BF File Offset: 0x000024BF
		[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEBA68", Offset = "0x1EEBA68", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "DataStreamClosed", MemberParameters = new object[] { typeof(CloseExState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void CheckContinuePipeline()
		{
			throw null;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000042C2 File Offset: 0x000024C2
		[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEB4B8", Offset = "0x1EEB4B8", Length = "0x460")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "SubmitRequest", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "CheckContinuePipeline", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "WriteCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			typeof(ReceiveState),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream.<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "AcceptCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "ConnectCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "SSLHandshakeCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSource), Member = "IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		protected Stream ContinueCommandPipeline()
		{
			throw null;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000042C5 File Offset: 0x000024C5
		[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEBB2C", Offset = "0x1EEBB2C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "WriteCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private bool PostSendCommandProcessing(ref Stream stream)
		{
			throw null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000042C8 File Offset: 0x000024C8
		[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEBF58", Offset = "0x1EEBF58", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			typeof(ReceiveState),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool PostReadCommandProcessing(ref Stream stream)
		{
			throw null;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000042CB File Offset: 0x000024CB
		[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEC138", Offset = "0x1EEC138", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			throw null;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000042CE File Offset: 0x000024CE
		[global::Cpp2ILInjected.Token(Token = "0x60007EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEC140", Offset = "0x1EEC140", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			typeof(ReceiveState),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static void ReadCallback(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000042D1 File Offset: 0x000024D1
		[global::Cpp2ILInjected.Token(Token = "0x60007F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEC8DC", Offset = "0x1EEC8DC", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void WriteCallback(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x000042D7 File Offset: 0x000024D7
		[global::Cpp2ILInjected.Token(Token = "0x170001A2")]
		protected Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECB70", Offset = "0x1EECB70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECB78", Offset = "0x1EECB78", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000042DA File Offset: 0x000024DA
		[global::Cpp2ILInjected.Token(Token = "0x60007F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECBA8", Offset = "0x1EECBA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			throw null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000042DD File Offset: 0x000024DD
		[global::Cpp2ILInjected.Token(Token = "0x60007F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEBC44", Offset = "0x1EEBC44", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "PostSendCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReceiveState), Member = ".ctor", MemberParameters = new object[] { typeof(CommandStream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ReceiveCommandResponseCallback", MemberParameters = new object[]
		{
			typeof(ReceiveState),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private ResponseDescription ReceiveCommandResponse()
		{
			throw null;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000042E0 File Offset: 0x000024E0
		[global::Cpp2ILInjected.Token(Token = "0x60007F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEC3F4", Offset = "0x1EEC3F4", Length = "0x4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReadCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "PostReadCommandProcessing", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
		{
			throw null;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000042E3 File Offset: 0x000024E3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECC48", Offset = "0x1EECC48", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static CommandStream()
		{
			throw null;
		}

		// Token: 0x040004C8 RID: 1224
		[global::Cpp2ILInjected.Token(Token = "0x400064E")]
		private static readonly AsyncCallback s_writeCallbackDelegate;

		// Token: 0x040004C9 RID: 1225
		[global::Cpp2ILInjected.Token(Token = "0x400064F")]
		private static readonly AsyncCallback s_readCallbackDelegate;

		// Token: 0x040004CA RID: 1226
		[global::Cpp2ILInjected.Token(Token = "0x4000650")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _recoverableFailure;

		// Token: 0x040004CB RID: 1227
		[global::Cpp2ILInjected.Token(Token = "0x4000651")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected WebRequest _request;

		// Token: 0x040004CC RID: 1228
		[global::Cpp2ILInjected.Token(Token = "0x4000652")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected bool _isAsync;

		// Token: 0x040004CD RID: 1229
		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool _aborted;

		// Token: 0x040004CE RID: 1230
		[global::Cpp2ILInjected.Token(Token = "0x4000654")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected CommandStream.PipelineEntry[] _commands;

		// Token: 0x040004CF RID: 1231
		[global::Cpp2ILInjected.Token(Token = "0x4000655")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected int _index;

		// Token: 0x040004D0 RID: 1232
		[global::Cpp2ILInjected.Token(Token = "0x4000656")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private bool _doRead;

		// Token: 0x040004D1 RID: 1233
		[global::Cpp2ILInjected.Token(Token = "0x4000657")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D")]
		private bool _doSend;

		// Token: 0x040004D2 RID: 1234
		[global::Cpp2ILInjected.Token(Token = "0x4000658")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ResponseDescription _currentResponseDescription;

		// Token: 0x040004D3 RID: 1235
		[global::Cpp2ILInjected.Token(Token = "0x4000659")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected string _abortReason;

		// Token: 0x040004D4 RID: 1236
		[global::Cpp2ILInjected.Token(Token = "0x400065A")]
		private const int WaitingForPipeline = 1;

		// Token: 0x040004D5 RID: 1237
		[global::Cpp2ILInjected.Token(Token = "0x400065B")]
		private const int CompletedPipeline = 2;

		// Token: 0x040004D6 RID: 1238
		[global::Cpp2ILInjected.Token(Token = "0x400065C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string _buffer;

		// Token: 0x040004D7 RID: 1239
		[global::Cpp2ILInjected.Token(Token = "0x400065D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Encoding _encoding;

		// Token: 0x040004D8 RID: 1240
		[global::Cpp2ILInjected.Token(Token = "0x400065E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Decoder _decoder;

		// Token: 0x020003CF RID: 975
		[global::Cpp2ILInjected.Token(Token = "0x2000144")]
		internal enum PipelineInstruction
		{
			// Token: 0x04001138 RID: 4408
			[global::Cpp2ILInjected.Token(Token = "0x4000660")]
			Abort,
			// Token: 0x04001139 RID: 4409
			[global::Cpp2ILInjected.Token(Token = "0x4000661")]
			Advance,
			// Token: 0x0400113A RID: 4410
			[global::Cpp2ILInjected.Token(Token = "0x4000662")]
			Pause,
			// Token: 0x0400113B RID: 4411
			[global::Cpp2ILInjected.Token(Token = "0x4000663")]
			Reread,
			// Token: 0x0400113C RID: 4412
			[global::Cpp2ILInjected.Token(Token = "0x4000664")]
			GiveStream
		}

		// Token: 0x020003D0 RID: 976
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000145")]
		internal enum PipelineEntryFlags
		{
			// Token: 0x0400113E RID: 4414
			[global::Cpp2ILInjected.Token(Token = "0x4000666")]
			UserCommand = 1,
			// Token: 0x0400113F RID: 4415
			[global::Cpp2ILInjected.Token(Token = "0x4000667")]
			GiveDataStream = 2,
			// Token: 0x04001140 RID: 4416
			[global::Cpp2ILInjected.Token(Token = "0x4000668")]
			CreateDataConnection = 4,
			// Token: 0x04001141 RID: 4417
			[global::Cpp2ILInjected.Token(Token = "0x4000669")]
			DontLogParameter = 8
		}

		// Token: 0x020003D1 RID: 977
		[global::Cpp2ILInjected.Token(Token = "0x2000146")]
		internal class PipelineEntry
		{
			// Token: 0x06001D6A RID: 7530 RVA: 0x00008126 File Offset: 0x00006326
			[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD18", Offset = "0x1EECD18", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal PipelineEntry(string command)
			{
				throw null;
			}

			// Token: 0x06001D6B RID: 7531 RVA: 0x00008129 File Offset: 0x00006329
			[global::Cpp2ILInjected.Token(Token = "0x60007F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECD40", Offset = "0x1EECD40", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal PipelineEntry(string command, CommandStream.PipelineEntryFlags flags)
			{
				throw null;
			}

			// Token: 0x06001D6C RID: 7532 RVA: 0x0000812C File Offset: 0x0000632C
			[global::Cpp2ILInjected.Token(Token = "0x60007F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEBB1C", Offset = "0x1EEBB1C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool HasFlag(CommandStream.PipelineEntryFlags flags)
			{
				throw null;
			}

			// Token: 0x04001142 RID: 4418
			[global::Cpp2ILInjected.Token(Token = "0x400066A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string Command;

			// Token: 0x04001143 RID: 4419
			[global::Cpp2ILInjected.Token(Token = "0x400066B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal CommandStream.PipelineEntryFlags Flags;
		}
	}
}
