using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000229")]
	internal static class Logging
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002E6")]
		internal static bool On
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBB8", Offset = "0x1F3CBB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingCookedPath", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = "System.Net.HttpListenerRequestUriBuilder.ParsingResult")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "AddPercentEncodedOctetToRawOctetsList", MemberParameters = new object[]
			{
				typeof(Encoding),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "EmptyDecodeAndAppendRawOctetsList", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "LogWarning", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(bool)
			}, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerNode", Member = "Fire", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "ParseProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "CreateInvalidProxyStringException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FormatException))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "Abort", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(AddressFamily),
				typeof(SocketType),
				typeof(ProtocolType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new object[] { typeof(AddressFamily) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new object[] { typeof(Socket) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
			{
				typeof(IPAddress),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "BeginConnect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(IPAddress),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TcpListener))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E7")]
		internal static TraceSource Web
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBC0", Offset = "0x1F3CBC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E8")]
		internal static TraceSource HttpListener
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBC8", Offset = "0x1F3CBC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E9")]
		internal static TraceSource Sockets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CBD0", Offset = "0x1F3CBD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBD8", Offset = "0x1F3CBD8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Enter(TraceSource traceSource, object obj, string method, object paramObject)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBDC", Offset = "0x1F3CBDC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Enter(TraceSource traceSource, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBE0", Offset = "0x1F3CBE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Enter(TraceSource traceSource, string msg, string parameters)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBE4", Offset = "0x1F3CBE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exception(TraceSource traceSource, object obj, string method, Exception e)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBE8", Offset = "0x1F3CBE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exit(TraceSource traceSource, object obj, string method, object retObject)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBEC", Offset = "0x1F3CBEC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exit(TraceSource traceSource, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBF0", Offset = "0x1F3CBF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Exit(TraceSource traceSource, string msg, string parameters)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBF4", Offset = "0x1F3CBF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintInfo(TraceSource traceSource, object obj, string method, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBF8", Offset = "0x1F3CBF8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintInfo(TraceSource traceSource, object obj, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CBFC", Offset = "0x1F3CBFC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintInfo(TraceSource traceSource, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC00", Offset = "0x1F3CC00", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintWarning(TraceSource traceSource, object obj, string method, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC04", Offset = "0x1F3CC04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintWarning(TraceSource traceSource, string msg)
		{
			throw null;
		}

		[Conditional("TRACE")]
		[global::Cpp2ILInjected.Token(Token = "0x6000DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC08", Offset = "0x1F3CC08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void PrintError(TraceSource traceSource, string msg)
		{
			throw null;
		}
	}
}
