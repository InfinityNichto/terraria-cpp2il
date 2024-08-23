using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Sockets
{
	// Token: 0x02000218 RID: 536
	[global::Cpp2ILInjected.Token(Token = "0x2000307")]
	public class UdpClient : IDisposable
	{
		// Token: 0x060011EE RID: 4590 RVA: 0x00006176 File Offset: 0x00004376
		[global::Cpp2ILInjected.Token(Token = "0x6001427")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34168", Offset = "0x1E34168", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public UdpClient()
		{
			throw null;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00006179 File Offset: 0x00004379
		[global::Cpp2ILInjected.Token(Token = "0x6001428")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34170", Offset = "0x1E34170", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public UdpClient(AddressFamily family)
		{
			throw null;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0000617C File Offset: 0x0000437C
		[global::Cpp2ILInjected.Token(Token = "0x6001429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34308", Offset = "0x1E34308", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = "BroadcastRecieveThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ServerAutoFinder", Member = "BroadcastRecieveThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public UdpClient(int port)
		{
			throw null;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0000617F File Offset: 0x0000437F
		[global::Cpp2ILInjected.Token(Token = "0x600142A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34310", Offset = "0x1E34310", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ValidateTcpPort", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "createClientSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new object[] { typeof(EndPoint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public UdpClient(int port, AddressFamily family)
		{
			throw null;
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00006182 File Offset: 0x00004382
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x00006185 File Offset: 0x00004385
		[global::Cpp2ILInjected.Token(Token = "0x17000490")]
		public Socket Client
		{
			[global::Cpp2ILInjected.Token(Token = "0x600142B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E34504", Offset = "0x1E34504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600142C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3450C", Offset = "0x1E3450C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00006188 File Offset: 0x00004388
		[global::Cpp2ILInjected.Token(Token = "0x17000491")]
		public bool EnableBroadcast
		{
			[global::Cpp2ILInjected.Token(Token = "0x600142D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E34514", Offset = "0x1E34514", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_EnableBroadcast", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000618B File Offset: 0x0000438B
		[global::Cpp2ILInjected.Token(Token = "0x600142E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34524", Offset = "0x1E34524", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "StopBroadCasting", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = "StopSearching", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ServerAutoFinder", Member = "StopSearching", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "StopBroadCasting", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0000618E File Offset: 0x0000438E
		[global::Cpp2ILInjected.Token(Token = "0x600142F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34534", Offset = "0x1E34534", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new object[] { typeof(SocketShutdown) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
		private void FreeResources()
		{
			throw null;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00006191 File Offset: 0x00004391
		[global::Cpp2ILInjected.Token(Token = "0x6001430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34584", Offset = "0x1E34584", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00006194 File Offset: 0x00004394
		[global::Cpp2ILInjected.Token(Token = "0x6001431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34594", Offset = "0x1E34594", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "FreeResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00006197 File Offset: 0x00004397
		[global::Cpp2ILInjected.Token(Token = "0x6001432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3460C", Offset = "0x1E3460C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(IPEndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "IsBroadcast", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new object[]
		{
			typeof(SocketOptionLevel),
			typeof(SocketOptionName),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void CheckForBroadcast(IPAddress ipAddress)
		{
			throw null;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0000619A File Offset: 0x0000439A
		[global::Cpp2ILInjected.Token(Token = "0x6001433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3465C", Offset = "0x1E3465C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsBroadcast(IPAddress address)
		{
			throw null;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000619D File Offset: 0x0000439D
		[global::Cpp2ILInjected.Token(Token = "0x6001434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E346E8", Offset = "0x1E346E8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "SendTo", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "Send", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public int Send(byte[] dgram, int bytes, IPEndPoint endPoint)
		{
			throw null;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000061A0 File Offset: 0x000043A0
		[global::Cpp2ILInjected.Token(Token = "0x6001435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3485C", Offset = "0x1E3485C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "<ReceiveAsync>b__65_0", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "BeginReceiveFrom", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketFlags),
			typeof(ref EndPoint),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public IAsyncResult BeginReceive(AsyncCallback requestCallback, object state)
		{
			throw null;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000061A3 File Offset: 0x000043A3
		[global::Cpp2ILInjected.Token(Token = "0x6001436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3496C", Offset = "0x1E3496C", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "<ReceiveAsync>b__65_1", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(UdpReceiveResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "EndReceiveFrom", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref EndPoint)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public byte[] EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
		{
			throw null;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000061A6 File Offset: 0x000043A6
		[global::Cpp2ILInjected.Token(Token = "0x6001437")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34B38", Offset = "0x1E34B38", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationFinder", Member = "BroadcastRecieveThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ServerAutoFinder", Member = "BroadcastRecieveThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<UdpReceiveResult>), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, UdpReceiveResult>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory<UdpReceiveResult>), Member = "FromAsync", MemberParameters = new object[]
		{
			typeof(Func<AsyncCallback, object, IAsyncResult>),
			typeof(Func<IAsyncResult, UdpReceiveResult>),
			typeof(object)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Task<UdpReceiveResult> ReceiveAsync()
		{
			throw null;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x000061A9 File Offset: 0x000043A9
		[global::Cpp2ILInjected.Token(Token = "0x6001438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E342A0", Offset = "0x1E342A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(AddressFamily)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AddressFamily),
			typeof(SocketType),
			typeof(ProtocolType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void createClientSocket()
		{
			throw null;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000061AC File Offset: 0x000043AC
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34C50", Offset = "0x1E34C50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "BeginReceive", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		private IAsyncResult <ReceiveAsync>b__65_0(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x000061AF File Offset: 0x000043AF
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x600143A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E34C54", Offset = "0x1E34C54", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "EndReceive", MemberParameters = new object[]
		{
			typeof(IAsyncResult),
			typeof(ref IPEndPoint)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpReceiveResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(IPEndPoint)
		}, ReturnType = typeof(void))]
		private UdpReceiveResult <ReceiveAsync>b__65_1(IAsyncResult ar)
		{
			throw null;
		}

		// Token: 0x04000CE0 RID: 3296
		[global::Cpp2ILInjected.Token(Token = "0x40010D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Socket m_ClientSocket;

		// Token: 0x04000CE1 RID: 3297
		[global::Cpp2ILInjected.Token(Token = "0x40010DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_Active;

		// Token: 0x04000CE2 RID: 3298
		[global::Cpp2ILInjected.Token(Token = "0x40010DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] m_Buffer;

		// Token: 0x04000CE3 RID: 3299
		[global::Cpp2ILInjected.Token(Token = "0x40010DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AddressFamily m_Family;

		// Token: 0x04000CE4 RID: 3300
		[global::Cpp2ILInjected.Token(Token = "0x40010DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool m_CleanedUp;

		// Token: 0x04000CE5 RID: 3301
		[global::Cpp2ILInjected.Token(Token = "0x40010DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		private bool m_IsBroadcast;
	}
}
