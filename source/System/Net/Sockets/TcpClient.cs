using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000216 RID: 534
	[global::Cpp2ILInjected.Token(Token = "0x2000305")]
	public class TcpClient : IDisposable
	{
		// Token: 0x060011D3 RID: 4563 RVA: 0x00006125 File Offset: 0x00004325
		[global::Cpp2ILInjected.Token(Token = "0x600140C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32A88", Offset = "0x1E32A88", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new object[] { typeof(AddressFamily) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		public TcpClient()
		{
			throw null;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00006128 File Offset: 0x00004328
		[global::Cpp2ILInjected.Token(Token = "0x600140D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32AA8", Offset = "0x1E32AA8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public TcpClient(AddressFamily family)
		{
			throw null;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0000612B File Offset: 0x0000432B
		[global::Cpp2ILInjected.Token(Token = "0x600140E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32C10", Offset = "0x1E32C10", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		internal TcpClient(Socket acceptedSocket)
		{
			throw null;
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0000612E File Offset: 0x0000432E
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00006131 File Offset: 0x00004331
		[global::Cpp2ILInjected.Token(Token = "0x1700048B")]
		public Socket Client
		{
			[global::Cpp2ILInjected.Token(Token = "0x600140F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32C54", Offset = "0x1E32C54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001410")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32C5C", Offset = "0x1E32C5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00006134 File Offset: 0x00004334
		[global::Cpp2ILInjected.Token(Token = "0x1700048C")]
		public bool Connected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001411")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E32C64", Offset = "0x1E32C64", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "SendLoop", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TcpClient),
				"Telepathy.SafeQueue`1<Byte[]>",
				typeof(ManualResetEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.IsConnected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.IsDataAvailable", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00006137 File Offset: 0x00004337
		[global::Cpp2ILInjected.Token(Token = "0x6001412")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32C70", Offset = "0x1E32C70", Length = "0x668")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ValidateTcpPort", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		public void Connect(string hostname, int port)
		{
			throw null;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0000613A File Offset: 0x0000433A
		[global::Cpp2ILInjected.Token(Token = "0x6001413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E333C4", Offset = "0x1E333C4", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.Connect", MemberParameters = new object[] { "Terraria.Net.RemoteAddress" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ValidateTcpPort", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Connect(IPAddress address, int port)
		{
			throw null;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0000613D File Offset: 0x0000433D
		[global::Cpp2ILInjected.Token(Token = "0x6001414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E332D8", Offset = "0x1E332D8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Connect(IPEndPoint remoteEP)
		{
			throw null;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00006140 File Offset: 0x00004340
		[global::Cpp2ILInjected.Token(Token = "0x6001415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3355C", Offset = "0x1E3355C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			throw null;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00006143 File Offset: 0x00004343
		[global::Cpp2ILInjected.Token(Token = "0x6001416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E335C0", Offset = "0x1E335C0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		public void EndConnect(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00006146 File Offset: 0x00004346
		[global::Cpp2ILInjected.Token(Token = "0x6001417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33600", Offset = "0x1E33600", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<, , , , >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory), Member = "FromAsync", MemberTypeParameters = new object[] { "TArg1", "TArg2" }, MemberParameters = new object[]
		{
			"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>",
			typeof(Action<IAsyncResult>),
			"TArg1",
			"TArg2",
			typeof(object)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Task ConnectAsync(string host, int port)
		{
			throw null;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00006149 File Offset: 0x00004349
		[global::Cpp2ILInjected.Token(Token = "0x6001418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33764", Offset = "0x1E33764", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "ReceiveLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TcpClient),
			"System.Collections.Concurrent.ConcurrentQueue`1<Message>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "SendLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TcpClient),
			"Telepathy.SafeQueue`1<Byte[]>",
			typeof(ManualResetEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "ReadCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "SendCallback", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.AsyncSend", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"Terraria.Net.Sockets.SocketSendCallback",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.AsyncReceive", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"Terraria.Net.Sockets.SocketReceiveCallback",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.IsDataAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamWrapper), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public NetworkStream GetStream()
		{
			throw null;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0000614C File Offset: 0x0000434C
		[global::Cpp2ILInjected.Token(Token = "0x6001419")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33888", Offset = "0x1E33888", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Disconnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server", Member = "Disconnect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0000614F File Offset: 0x0000434F
		[global::Cpp2ILInjected.Token(Token = "0x600141A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3392C", Offset = "0x1E3392C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new object[] { typeof(SocketShutdown) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00006152 File Offset: 0x00004352
		[global::Cpp2ILInjected.Token(Token = "0x600141B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33AC0", Offset = "0x1E33AC0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "Disconnect", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream.<>c__DisplayClass31_0", Member = "<PipelineCallback>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AttemptedRecovery", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "AsyncRequestCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamWrapper), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamWrapper), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamWrapper), Member = "Close", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00006155 File Offset: 0x00004355
		[global::Cpp2ILInjected.Token(Token = "0x600141C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E33AD0", Offset = "0x1E33AD0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x17000464 RID: 1124
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x00006158 File Offset: 0x00004358
		[global::Cpp2ILInjected.Token(Token = "0x1700048D")]
		public int SendTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600141D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E33B70", Offset = "0x1E33B70", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0000615B File Offset: 0x0000435B
		[global::Cpp2ILInjected.Token(Token = "0x1700048E")]
		public bool NoDelay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600141E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E33B88", Offset = "0x1E33B88", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
			{
				typeof(SocketOptionLevel),
				typeof(SocketOptionName),
				typeof(int)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0000615E File Offset: 0x0000435E
		[global::Cpp2ILInjected.Token(Token = "0x600141F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E32BA4", Offset = "0x1E32BA4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new object[] { typeof(AddressFamily) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void initialize()
		{
			throw null;
		}

		// Token: 0x04000CD7 RID: 3287
		[global::Cpp2ILInjected.Token(Token = "0x40010D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Socket m_ClientSocket;

		// Token: 0x04000CD8 RID: 3288
		[global::Cpp2ILInjected.Token(Token = "0x40010D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_Active;

		// Token: 0x04000CD9 RID: 3289
		[global::Cpp2ILInjected.Token(Token = "0x40010D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NetworkStream m_DataStream;

		// Token: 0x04000CDA RID: 3290
		[global::Cpp2ILInjected.Token(Token = "0x40010D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AddressFamily m_Family;

		// Token: 0x04000CDB RID: 3291
		[global::Cpp2ILInjected.Token(Token = "0x40010D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool m_CleanedUp;
	}
}
