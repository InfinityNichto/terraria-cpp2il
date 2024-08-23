using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000E0 RID: 224
	[global::Cpp2ILInjected.Token(Token = "0x200014A")]
	internal class FtpControlStream : CommandStream
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000042FB File Offset: 0x000024FB
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x000042FE File Offset: 0x000024FE
		[global::Cpp2ILInjected.Token(Token = "0x170001A8")]
		internal NetworkCredential Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000801")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECE3C", Offset = "0x1EECE3C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000802")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EECEDC", Offset = "0x1EECEDC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00004301 File Offset: 0x00002501
		[global::Cpp2ILInjected.Token(Token = "0x6000803")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECF54", Offset = "0x1EECF54", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal FtpControlStream(TcpClient client)
		{
			throw null;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00004304 File Offset: 0x00002504
		[global::Cpp2ILInjected.Token(Token = "0x6000804")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECFE0", Offset = "0x1EECFE0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "TimerCallback", MemberParameters = new object[]
		{
			typeof(TimerThread.Timer),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void AbortConnect()
		{
			throw null;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00004307 File Offset: 0x00002507
		[global::Cpp2ILInjected.Token(Token = "0x6000805")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EED06C", Offset = "0x1EED06C", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndAccept", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static void AcceptCallback(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000430A File Offset: 0x0000250A
		[global::Cpp2ILInjected.Token(Token = "0x6000806")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EED384", Offset = "0x1EED384", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void ConnectCallback(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0000430D File Offset: 0x0000250D
		[global::Cpp2ILInjected.Token(Token = "0x6000807")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EED51C", Offset = "0x1EED51C", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void SSLHandshakeCallback(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00004310 File Offset: 0x00002510
		[global::Cpp2ILInjected.Token(Token = "0x6000808")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EED6C0", Offset = "0x1EED6C0", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "IsFtpDataStreamWriteable", ReturnType = typeof(TriState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpDataStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(FtpWebRequest),
			typeof(TriState)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_UsingSecureStream", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "get_ClientCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(Socket),
			typeof(string),
			typeof(X509CertificateCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = "BeginAuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = "AuthenticateAsClient", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream)
		{
			throw null;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00004313 File Offset: 0x00002513
		[global::Cpp2ILInjected.Token(Token = "0x6000809")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EED9D8", Offset = "0x1EED9D8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InitCommandPipeline", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(CommandStream.PipelineEntry[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void ClearState()
		{
			throw null;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00004316 File Offset: 0x00002516
		[global::Cpp2ILInjected.Token(Token = "0x600080A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEDA68", Offset = "0x1EEDA68", Length = "0x7D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream.<>c__DisplayClass31_0), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_UsingSecureStream", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "TryUpdateContentLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "get_ShouldParseForResponseUri", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FtpWebRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_Socket", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpWebRequest), Member = "get_ClientCertificates", ReturnType = typeof(X509CertificateCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(Socket),
			typeof(string),
			typeof(X509CertificateCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = "BeginAuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetLoginDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetContentLengthFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetLastModifiedFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = "AuthenticateAsClient", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(FtpStatusCode),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			throw null;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00004319 File Offset: 0x00002519
		[global::Cpp2ILInjected.Token(Token = "0x600080B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEF130", Offset = "0x1EEF130", Length = "0xE04")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_UsingSecureStream", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "FormatFtpCommand", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "set_Credentials", MemberParameters = new object[] { typeof(NetworkCredential) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "get_Credentials", ReturnType = typeof(NetworkCredential))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Domain", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "HasFlag", MemberParameters = new object[] { typeof(FtpMethodFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetPathInfo", MemberParameters = new object[]
		{
			typeof(FtpControlStream.GetPathOption),
			typeof(Uri),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "get_IsCommandOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 75)]
		protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req)
		{
			throw null;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0000431C File Offset: 0x0000251C
		[global::Cpp2ILInjected.Token(Token = "0x600080C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEE23C", Offset = "0x1EEE23C", Length = "0x5FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetPortV4", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "GetPortV6", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_Socket", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "CreateFtpDataSocket", MemberParameters = new object[]
		{
			typeof(FtpWebRequest),
			typeof(Socket)
		}, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginAccept", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Accept", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady)
		{
			throw null;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0000431F File Offset: 0x0000251F
		[global::Cpp2ILInjected.Token(Token = "0x600080D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0028", Offset = "0x1EF0028", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename)
		{
			throw null;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00004322 File Offset: 0x00002522
		[global::Cpp2ILInjected.Token(Token = "0x600080E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0880", Offset = "0x1EF0880", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string FormatAddress(IPAddress address, int Port)
		{
			throw null;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00004325 File Offset: 0x00002525
		[global::Cpp2ILInjected.Token(Token = "0x600080F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0984", Offset = "0x1EF0984", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "GetPortCommandLine", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string FormatAddressV6(IPAddress address, int port)
		{
			throw null;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00004328 File Offset: 0x00002528
		[global::Cpp2ILInjected.Token(Token = "0x170001A9")]
		internal long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000810")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0A88", Offset = "0x1EF0A88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0000432B File Offset: 0x0000252B
		[global::Cpp2ILInjected.Token(Token = "0x170001AA")]
		internal DateTime LastModified
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000811")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0A90", Offset = "0x1EF0A90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0000432E File Offset: 0x0000252E
		[global::Cpp2ILInjected.Token(Token = "0x170001AB")]
		internal Uri ResponseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000812")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0A98", Offset = "0x1EF0A98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00004331 File Offset: 0x00002531
		[global::Cpp2ILInjected.Token(Token = "0x170001AC")]
		internal string BannerMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000813")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0AA0", Offset = "0x1EF0AA0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00004334 File Offset: 0x00002534
		[global::Cpp2ILInjected.Token(Token = "0x170001AD")]
		internal string WelcomeMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000814")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0AB8", Offset = "0x1EF0AB8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00004337 File Offset: 0x00002537
		[global::Cpp2ILInjected.Token(Token = "0x170001AE")]
		internal string ExitMessage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000815")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0AD0", Offset = "0x1EF0AD0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "SyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "EnsureFtpWebResponse", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0000433A File Offset: 0x0000253A
		[global::Cpp2ILInjected.Token(Token = "0x6000816")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEEC4C", Offset = "0x1EEEC4C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private long GetContentLengthFrom213Response(string responseString)
		{
			throw null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000433D File Offset: 0x0000253D
		[global::Cpp2ILInjected.Token(Token = "0x6000817")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEED54", Offset = "0x1EEED54", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private DateTime GetLastModifiedFrom213Response(string str)
		{
			throw null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00004340 File Offset: 0x00002540
		[global::Cpp2ILInjected.Token(Token = "0x6000818")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEE91C", Offset = "0x1EEE91C", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "set_Path", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Segments", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void TryUpdateResponseUri(string str, FtpWebRequest request)
		{
			throw null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00004343 File Offset: 0x00002543
		[global::Cpp2ILInjected.Token(Token = "0x6000819")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEE838", Offset = "0x1EEE838", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void TryUpdateContentLength(string str)
		{
			throw null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004346 File Offset: 0x00002546
		[global::Cpp2ILInjected.Token(Token = "0x600081A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEF088", Offset = "0x1EEF088", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string GetLoginDirectory(string str)
		{
			throw null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00004349 File Offset: 0x00002549
		[global::Cpp2ILInjected.Token(Token = "0x600081B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF04BC", Offset = "0x1EF04BC", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsNumber", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private int GetPortV4(string responseString)
		{
			throw null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0000434C File Offset: 0x0000254C
		[global::Cpp2ILInjected.Token(Token = "0x600081C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0680", Offset = "0x1EF0680", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private int GetPortV6(string responseString)
		{
			throw null;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000434F File Offset: 0x0000254F
		[global::Cpp2ILInjected.Token(Token = "0x600081D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0198", Offset = "0x1EF0198", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_Socket", ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "CreateFtpDataSocket", MemberParameters = new object[]
		{
			typeof(FtpWebRequest),
			typeof(Socket)
		}, ReturnType = typeof(Socket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_RequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void CreateFtpListenerSocket(FtpWebRequest request)
		{
			throw null;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00004352 File Offset: 0x00002552
		[global::Cpp2ILInjected.Token(Token = "0x600081E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0300", Offset = "0x1EF0300", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamWrapper), Member = "get_ServerAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "FormatAddressV6", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpControlStream), Member = "FormatAddress", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "GenerateException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(Exception)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private string GetPortCommandLine(FtpWebRequest request)
		{
			throw null;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00004355 File Offset: 0x00002555
		[global::Cpp2ILInjected.Token(Token = "0x600081F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEFF34", Offset = "0x1EEFF34", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private string FormatFtpCommand(string command, string parameter)
		{
			throw null;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00004358 File Offset: 0x00002558
		[global::Cpp2ILInjected.Token(Token = "0x6000820")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF080C", Offset = "0x1EF080C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket)
		{
			throw null;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000435B File Offset: 0x0000255B
		[global::Cpp2ILInjected.Token(Token = "0x6000821")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0AE8", Offset = "0x1EF0AE8", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			throw null;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000435E File Offset: 0x0000255E
		[global::Cpp2ILInjected.Token(Token = "0x6000822")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EED94C", Offset = "0x1EED94C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateFtpDataStream", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "get_IsUpload", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FtpMethodInfo), Member = "get_IsDownload", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private TriState IsFtpDataStreamWriteable()
		{
			throw null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00004361 File Offset: 0x00002561
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000823")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EF0E6C", Offset = "0x1EF0E6C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static FtpControlStream()
		{
			throw null;
		}

		// Token: 0x040004E9 RID: 1257
		[global::Cpp2ILInjected.Token(Token = "0x400067C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Socket _dataSocket;

		// Token: 0x040004EA RID: 1258
		[global::Cpp2ILInjected.Token(Token = "0x400067D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private IPEndPoint _passiveEndPoint;

		// Token: 0x040004EB RID: 1259
		[global::Cpp2ILInjected.Token(Token = "0x400067E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private TlsStream _tlsStream;

		// Token: 0x040004EC RID: 1260
		[global::Cpp2ILInjected.Token(Token = "0x400067F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private StringBuilder _bannerMessage;

		// Token: 0x040004ED RID: 1261
		[global::Cpp2ILInjected.Token(Token = "0x4000680")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private StringBuilder _welcomeMessage;

		// Token: 0x040004EE RID: 1262
		[global::Cpp2ILInjected.Token(Token = "0x4000681")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private StringBuilder _exitMessage;

		// Token: 0x040004EF RID: 1263
		[global::Cpp2ILInjected.Token(Token = "0x4000682")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private WeakReference _credentials;

		// Token: 0x040004F0 RID: 1264
		[global::Cpp2ILInjected.Token(Token = "0x4000683")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string _currentTypeSetting;

		// Token: 0x040004F1 RID: 1265
		[global::Cpp2ILInjected.Token(Token = "0x4000684")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private long _contentLength;

		// Token: 0x040004F2 RID: 1266
		[global::Cpp2ILInjected.Token(Token = "0x4000685")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private DateTime _lastModified;

		// Token: 0x040004F3 RID: 1267
		[global::Cpp2ILInjected.Token(Token = "0x4000686")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool _dataHandshakeStarted;

		// Token: 0x040004F4 RID: 1268
		[global::Cpp2ILInjected.Token(Token = "0x4000687")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private string _loginDirectory;

		// Token: 0x040004F5 RID: 1269
		[global::Cpp2ILInjected.Token(Token = "0x4000688")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private string _establishedServerDirectory;

		// Token: 0x040004F6 RID: 1270
		[global::Cpp2ILInjected.Token(Token = "0x4000689")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private string _requestedServerDirectory;

		// Token: 0x040004F7 RID: 1271
		[global::Cpp2ILInjected.Token(Token = "0x400068A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private Uri _responseUri;

		// Token: 0x040004F8 RID: 1272
		[global::Cpp2ILInjected.Token(Token = "0x400068B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private FtpLoginState _loginState;

		// Token: 0x040004F9 RID: 1273
		[global::Cpp2ILInjected.Token(Token = "0x400068C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		internal FtpStatusCode StatusCode;

		// Token: 0x040004FA RID: 1274
		[global::Cpp2ILInjected.Token(Token = "0x400068D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal string StatusLine;

		// Token: 0x040004FB RID: 1275
		[global::Cpp2ILInjected.Token(Token = "0x400068E")]
		private static readonly AsyncCallback s_acceptCallbackDelegate;

		// Token: 0x040004FC RID: 1276
		[global::Cpp2ILInjected.Token(Token = "0x400068F")]
		private static readonly AsyncCallback s_connectCallbackDelegate;

		// Token: 0x040004FD RID: 1277
		[global::Cpp2ILInjected.Token(Token = "0x4000690")]
		private static readonly AsyncCallback s_SSLHandshakeCallback;

		// Token: 0x020003D2 RID: 978
		[global::Cpp2ILInjected.Token(Token = "0x200014B")]
		private enum GetPathOption
		{
			// Token: 0x04001145 RID: 4421
			[global::Cpp2ILInjected.Token(Token = "0x4000692")]
			Normal,
			// Token: 0x04001146 RID: 4422
			[global::Cpp2ILInjected.Token(Token = "0x4000693")]
			AssumeFilename,
			// Token: 0x04001147 RID: 4423
			[global::Cpp2ILInjected.Token(Token = "0x4000694")]
			AssumeNoFilename
		}

		// Token: 0x020003D3 RID: 979
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200014C")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06001D6D RID: 7533 RVA: 0x0000812F File Offset: 0x0000632F
			[global::Cpp2ILInjected.Token(Token = "0x6000824")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0F80", Offset = "0x1EF0F80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "PipelineCallback", MemberParameters = new object[]
			{
				typeof(CommandStream.PipelineEntry),
				typeof(ResponseDescription),
				typeof(bool),
				typeof(ref Stream)
			}, ReturnType = typeof(CommandStream.PipelineInstruction))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass31_0()
			{
				throw null;
			}

			// Token: 0x06001D6E RID: 7534 RVA: 0x00008132 File Offset: 0x00006332
			[global::Cpp2ILInjected.Token(Token = "0x6000825")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EF0F88", Offset = "0x1EF0F88", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsStream), Member = "EndAuthenticateAsClient", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "ContinueCommandPipeline", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommandStream), Member = "InvokeRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal void <PipelineCallback>b__0(IAsyncResult ar)
			{
				throw null;
			}

			// Token: 0x04001148 RID: 4424
			[global::Cpp2ILInjected.Token(Token = "0x4000695")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public FtpControlStream <>4__this;

			// Token: 0x04001149 RID: 4425
			[global::Cpp2ILInjected.Token(Token = "0x4000696")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TlsStream tlsStream;
		}
	}
}
