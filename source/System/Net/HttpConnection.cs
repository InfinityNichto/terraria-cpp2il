using System;
using System.Collections.Specialized;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000246")]
	internal sealed class HttpConnection
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F44E48", Offset = "0x1F44E48", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback)
		}, ReturnType = typeof(SslStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimerCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TimerCallback),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public HttpConnection(Socket sock, EndPointListener epl, bool secure, X509Certificate cert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000307")]
		internal SslStream SslStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49858", Offset = "0x1F49858", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000308")]
		internal int[] ClientCertificateErrors
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49860", Offset = "0x1F49860", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000309")]
		internal X509Certificate2 ClientCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49868", Offset = "0x1F49868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F497B4", Offset = "0x1F497B4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(EndPointListener),
			typeof(bool),
			typeof(X509Certificate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerContext), Member = ".ctor", MemberParameters = new object[] { typeof(HttpConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Init()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030A")]
		public bool IsClosed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49918", Offset = "0x1F49918", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030B")]
		public int Reuses
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49928", Offset = "0x1F49928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030C")]
		public IPEndPoint LocalEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49930", Offset = "0x1F49930", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_IsLocal", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_UserHostAddress", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030D")]
		public IPEndPoint RemoteEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F499E0", Offset = "0x1F499E0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_IsLocal", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_RemoteEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030E")]
		public bool IsSecure
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49A60", Offset = "0x1F49A60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700030F")]
		public ListenerPrefix Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49A68", Offset = "0x1F49A68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49A70", Offset = "0x1F49A70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49A78", Offset = "0x1F49A78", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
		private void OnTimeout(object unused)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45098", Offset = "0x1F45098", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "ProcessAccept", MemberParameters = new object[] { typeof(SocketAsyncEventArgs) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void BeginReadRequest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49BCC", Offset = "0x1F49BCC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "get_InputStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "set_SendChunked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedInputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public RequestStream GetRequestStream(bool chunked, long contentlength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49DC0", Offset = "0x1F49DC0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "get_OutputStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(HttpListenerResponse),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ResponseStream GetResponseStream()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49E78", Offset = "0x1F49E78", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void OnRead(IAsyncResult ares)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49F44", Offset = "0x1F49F44", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "ProcessInput", MemberParameters = new object[] { typeof(MemoryStream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "BindContext", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "RemoveConnection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "RegisterContext", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void OnReadInternal(IAsyncResult ares)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AA98", Offset = "0x1F4AA98", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "RemoveConnection", MemberParameters = new object[] { typeof(HttpConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void RemoveConnection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4A240", Offset = "0x1F4A240", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "ReadLine", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "SetRequestLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private bool ProcessInput(MemoryStream ms)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AE24", Offset = "0x1F4AE24", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "ProcessInput", MemberParameters = new object[] { typeof(MemoryStream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private string ReadLine(byte[] buffer, int offset, int len, ref int used)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3FC88", Offset = "0x1F3FC88", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "SendError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "set_StatusCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "set_ContentType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void SendError(string msg, int status)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4A230", Offset = "0x1F4A230", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void SendError()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49B98", Offset = "0x1F49B98", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnTimeout", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "UnregisterContext", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		private void Unbind()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4BD14", Offset = "0x1F4BD14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49A90", Offset = "0x1F49A90", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnTimeout", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "RemoveConnection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void CloseSocket()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F467BC", Offset = "0x1F467BC", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "Close", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "get_KeepAlive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "FlushInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "BeginReadRequest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Shutdown", MemberParameters = new object[] { typeof(SocketShutdown) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "RemoveConnection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void Close(bool force_close)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C104", Offset = "0x1F4C104", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static HttpConnection()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000EC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C198", Offset = "0x1F4C198", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool <.ctor>b__24_0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BF3")]
		private static AsyncCallback onread_cb;

		[global::Cpp2ILInjected.Token(Token = "0x4000BF4")]
		private const int BufferSize = 8192;

		[global::Cpp2ILInjected.Token(Token = "0x4000BF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Socket sock;

		[global::Cpp2ILInjected.Token(Token = "0x4000BF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stream stream;

		[global::Cpp2ILInjected.Token(Token = "0x4000BF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EndPointListener epl;

		[global::Cpp2ILInjected.Token(Token = "0x4000BF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private MemoryStream ms;

		[global::Cpp2ILInjected.Token(Token = "0x4000BF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private HttpListenerContext context;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private StringBuilder current_line;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ListenerPrefix prefix;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private RequestStream i_stream;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ResponseStream o_stream;

		[global::Cpp2ILInjected.Token(Token = "0x4000BFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool chunked;

		[global::Cpp2ILInjected.Token(Token = "0x4000C00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int reuses;

		[global::Cpp2ILInjected.Token(Token = "0x4000C01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool context_bound;

		[global::Cpp2ILInjected.Token(Token = "0x4000C02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool secure;

		[global::Cpp2ILInjected.Token(Token = "0x4000C03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private X509Certificate cert;

		[global::Cpp2ILInjected.Token(Token = "0x4000C04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int s_timeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000C05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Timer timer;

		[global::Cpp2ILInjected.Token(Token = "0x4000C06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private IPEndPoint local_ep;

		[global::Cpp2ILInjected.Token(Token = "0x4000C07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private HttpListener last_listener;

		[global::Cpp2ILInjected.Token(Token = "0x4000C08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int[] client_cert_errors;

		[global::Cpp2ILInjected.Token(Token = "0x4000C09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private X509Certificate2 client_cert;

		[global::Cpp2ILInjected.Token(Token = "0x4000C0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private SslStream ssl_stream;

		[global::Cpp2ILInjected.Token(Token = "0x4000C0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private HttpConnection.InputState input_state;

		[global::Cpp2ILInjected.Token(Token = "0x4000C0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private HttpConnection.LineState line_state;

		[global::Cpp2ILInjected.Token(Token = "0x4000C0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private int position;

		[global::Cpp2ILInjected.Token(Token = "0x2000247")]
		private enum InputState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000C0F")]
			RequestLine,
			[global::Cpp2ILInjected.Token(Token = "0x4000C10")]
			Headers
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000248")]
		private enum LineState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000C12")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000C13")]
			CR,
			[global::Cpp2ILInjected.Token(Token = "0x4000C14")]
			LF
		}
	}
}
