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
	// Token: 0x02000194 RID: 404
	[global::Cpp2ILInjected.Token(Token = "0x2000246")]
	internal sealed class HttpConnection
	{
		// Token: 0x06000D2B RID: 3371 RVA: 0x000053C0 File Offset: 0x000035C0
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

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x000053C3 File Offset: 0x000035C3
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

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000053C6 File Offset: 0x000035C6
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

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x000053C9 File Offset: 0x000035C9
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

		// Token: 0x06000D2F RID: 3375 RVA: 0x000053CC File Offset: 0x000035CC
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

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x000053CF File Offset: 0x000035CF
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

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000053D2 File Offset: 0x000035D2
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x000053D5 File Offset: 0x000035D5
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000053D8 File Offset: 0x000035D8
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x000053DB File Offset: 0x000035DB
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000053DE File Offset: 0x000035DE
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x000053E1 File Offset: 0x000035E1
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

		// Token: 0x06000D37 RID: 3383 RVA: 0x000053E4 File Offset: 0x000035E4
		[global::Cpp2ILInjected.Token(Token = "0x6000EB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49A78", Offset = "0x1F49A78", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
		private void OnTimeout(object unused)
		{
			throw null;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000053E7 File Offset: 0x000035E7
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

		// Token: 0x06000D39 RID: 3385 RVA: 0x000053EA File Offset: 0x000035EA
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

		// Token: 0x06000D3A RID: 3386 RVA: 0x000053ED File Offset: 0x000035ED
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

		// Token: 0x06000D3B RID: 3387 RVA: 0x000053F0 File Offset: 0x000035F0
		[global::Cpp2ILInjected.Token(Token = "0x6000EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49E78", Offset = "0x1F49E78", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void OnRead(IAsyncResult ares)
		{
			throw null;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000053F3 File Offset: 0x000035F3
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

		// Token: 0x06000D3D RID: 3389 RVA: 0x000053F6 File Offset: 0x000035F6
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

		// Token: 0x06000D3E RID: 3390 RVA: 0x000053F9 File Offset: 0x000035F9
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

		// Token: 0x06000D3F RID: 3391 RVA: 0x000053FC File Offset: 0x000035FC
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

		// Token: 0x06000D40 RID: 3392 RVA: 0x000053FF File Offset: 0x000035FF
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

		// Token: 0x06000D41 RID: 3393 RVA: 0x00005402 File Offset: 0x00003602
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

		// Token: 0x06000D42 RID: 3394 RVA: 0x00005405 File Offset: 0x00003605
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

		// Token: 0x06000D43 RID: 3395 RVA: 0x00005408 File Offset: 0x00003608
		[global::Cpp2ILInjected.Token(Token = "0x6000EC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4BD14", Offset = "0x1F4BD14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0000540B File Offset: 0x0000360B
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

		// Token: 0x06000D45 RID: 3397 RVA: 0x0000540E File Offset: 0x0000360E
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

		// Token: 0x06000D46 RID: 3398 RVA: 0x00005411 File Offset: 0x00003611
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

		// Token: 0x06000D47 RID: 3399 RVA: 0x00005414 File Offset: 0x00003614
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

		// Token: 0x04000943 RID: 2371
		[global::Cpp2ILInjected.Token(Token = "0x4000BF3")]
		private static AsyncCallback onread_cb;

		// Token: 0x04000944 RID: 2372
		[global::Cpp2ILInjected.Token(Token = "0x4000BF4")]
		private const int BufferSize = 8192;

		// Token: 0x04000945 RID: 2373
		[global::Cpp2ILInjected.Token(Token = "0x4000BF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Socket sock;

		// Token: 0x04000946 RID: 2374
		[global::Cpp2ILInjected.Token(Token = "0x4000BF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stream stream;

		// Token: 0x04000947 RID: 2375
		[global::Cpp2ILInjected.Token(Token = "0x4000BF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EndPointListener epl;

		// Token: 0x04000948 RID: 2376
		[global::Cpp2ILInjected.Token(Token = "0x4000BF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private MemoryStream ms;

		// Token: 0x04000949 RID: 2377
		[global::Cpp2ILInjected.Token(Token = "0x4000BF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		// Token: 0x0400094A RID: 2378
		[global::Cpp2ILInjected.Token(Token = "0x4000BFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private HttpListenerContext context;

		// Token: 0x0400094B RID: 2379
		[global::Cpp2ILInjected.Token(Token = "0x4000BFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private StringBuilder current_line;

		// Token: 0x0400094C RID: 2380
		[global::Cpp2ILInjected.Token(Token = "0x4000BFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ListenerPrefix prefix;

		// Token: 0x0400094D RID: 2381
		[global::Cpp2ILInjected.Token(Token = "0x4000BFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private RequestStream i_stream;

		// Token: 0x0400094E RID: 2382
		[global::Cpp2ILInjected.Token(Token = "0x4000BFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ResponseStream o_stream;

		// Token: 0x0400094F RID: 2383
		[global::Cpp2ILInjected.Token(Token = "0x4000BFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool chunked;

		// Token: 0x04000950 RID: 2384
		[global::Cpp2ILInjected.Token(Token = "0x4000C00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int reuses;

		// Token: 0x04000951 RID: 2385
		[global::Cpp2ILInjected.Token(Token = "0x4000C01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool context_bound;

		// Token: 0x04000952 RID: 2386
		[global::Cpp2ILInjected.Token(Token = "0x4000C02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool secure;

		// Token: 0x04000953 RID: 2387
		[global::Cpp2ILInjected.Token(Token = "0x4000C03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private X509Certificate cert;

		// Token: 0x04000954 RID: 2388
		[global::Cpp2ILInjected.Token(Token = "0x4000C04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int s_timeout;

		// Token: 0x04000955 RID: 2389
		[global::Cpp2ILInjected.Token(Token = "0x4000C05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Timer timer;

		// Token: 0x04000956 RID: 2390
		[global::Cpp2ILInjected.Token(Token = "0x4000C06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private IPEndPoint local_ep;

		// Token: 0x04000957 RID: 2391
		[global::Cpp2ILInjected.Token(Token = "0x4000C07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private HttpListener last_listener;

		// Token: 0x04000958 RID: 2392
		[global::Cpp2ILInjected.Token(Token = "0x4000C08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int[] client_cert_errors;

		// Token: 0x04000959 RID: 2393
		[global::Cpp2ILInjected.Token(Token = "0x4000C09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private X509Certificate2 client_cert;

		// Token: 0x0400095A RID: 2394
		[global::Cpp2ILInjected.Token(Token = "0x4000C0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private SslStream ssl_stream;

		// Token: 0x0400095B RID: 2395
		[global::Cpp2ILInjected.Token(Token = "0x4000C0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private HttpConnection.InputState input_state;

		// Token: 0x0400095C RID: 2396
		[global::Cpp2ILInjected.Token(Token = "0x4000C0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private HttpConnection.LineState line_state;

		// Token: 0x0400095D RID: 2397
		[global::Cpp2ILInjected.Token(Token = "0x4000C0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private int position;

		// Token: 0x02000416 RID: 1046
		[global::Cpp2ILInjected.Token(Token = "0x2000247")]
		private enum InputState
		{
			// Token: 0x0400123A RID: 4666
			[global::Cpp2ILInjected.Token(Token = "0x4000C0F")]
			RequestLine,
			// Token: 0x0400123B RID: 4667
			[global::Cpp2ILInjected.Token(Token = "0x4000C10")]
			Headers
		}

		// Token: 0x02000417 RID: 1047
		[global::Cpp2ILInjected.Token(Token = "0x2000248")]
		private enum LineState
		{
			// Token: 0x0400123D RID: 4669
			[global::Cpp2ILInjected.Token(Token = "0x4000C12")]
			None,
			// Token: 0x0400123E RID: 4670
			[global::Cpp2ILInjected.Token(Token = "0x4000C13")]
			CR,
			// Token: 0x0400123F RID: 4671
			[global::Cpp2ILInjected.Token(Token = "0x4000C14")]
			LF
		}
	}
}
