using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Localization;
using UnityEngine;

namespace Terraria.Net.Sockets
{
	// Token: 0x020004A4 RID: 1188
	[global::Cpp2ILInjected.Token(Token = "0x20006B2")]
	public class TcpSocket : ISocket
	{
		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x0002B340 File Offset: 0x00029540
		[global::Cpp2ILInjected.Token(Token = "0x170006D8")]
		public int MessagesInQueue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60038DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x143E70C", Offset = "0x143E70C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x0002B343 File Offset: 0x00029543
		[global::Cpp2ILInjected.Token(Token = "0x60038DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E714", Offset = "0x143E714", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public TcpSocket()
		{
			throw null;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0002B346 File Offset: 0x00029546
		[global::Cpp2ILInjected.Token(Token = "0x60038DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E7FC", Offset = "0x143E7FC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpSocket), Member = "ListenLoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public TcpSocket(TcpClient tcpClient)
		{
			throw null;
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x0002B349 File Offset: 0x00029549
		[global::Cpp2ILInjected.Token(Token = "0x60038DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E954", Offset = "0x143E954", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		private void Terraria.Net.Sockets.ISocket.Close()
		{
			throw null;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x0002B34C File Offset: 0x0002954C
		[global::Cpp2ILInjected.Token(Token = "0x60038E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E968", Offset = "0x143E968", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
		private bool Terraria.Net.Sockets.ISocket.IsConnected()
		{
			throw null;
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x0002B34F File Offset: 0x0002954F
		[global::Cpp2ILInjected.Token(Token = "0x60038E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E988", Offset = "0x143E988", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Terraria.Net.Sockets.ISocket.Connect(RemoteAddress address)
		{
			throw null;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x0002B352 File Offset: 0x00029552
		[global::Cpp2ILInjected.Token(Token = "0x60038E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EA1C", Offset = "0x143EA1C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void ReadCallback(IAsyncResult result)
		{
			throw null;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0002B355 File Offset: 0x00029555
		[global::Cpp2ILInjected.Token(Token = "0x60038E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EB60", Offset = "0x143EB60", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void SendCallback(IAsyncResult result)
		{
			throw null;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0002B358 File Offset: 0x00029558
		[global::Cpp2ILInjected.Token(Token = "0x60038E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EDB0", Offset = "0x143EDB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Net.Sockets.ISocket.SendQueuedPackets()
		{
			throw null;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x0002B35B File Offset: 0x0002955B
		[global::Cpp2ILInjected.Token(Token = "0x60038E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EDB4", Offset = "0x143EDB4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Terraria.Net.Sockets.ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x0002B35E File Offset: 0x0002955E
		[global::Cpp2ILInjected.Token(Token = "0x60038E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EED0", Offset = "0x143EED0", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Terraria.Net.Sockets.ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x0002B361 File Offset: 0x00029561
		[global::Cpp2ILInjected.Token(Token = "0x60038E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EFF0", Offset = "0x143EFF0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool Terraria.Net.Sockets.ISocket.IsDataAvailable()
		{
			throw null;
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x0002B364 File Offset: 0x00029564
		[global::Cpp2ILInjected.Token(Token = "0x60038E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F034", Offset = "0x143F034", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private RemoteAddress Terraria.Net.Sockets.ISocket.GetRemoteAddress()
		{
			throw null;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x0002B367 File Offset: 0x00029567
		[global::Cpp2ILInjected.Token(Token = "0x60038E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F03C", Offset = "0x143F03C", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private bool Terraria.Net.Sockets.ISocket.StartListening(SocketConnectionAccepted callback)
		{
			throw null;
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x0002B36A File Offset: 0x0002956A
		[global::Cpp2ILInjected.Token(Token = "0x60038EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F328", Offset = "0x143F328", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Net.Sockets.ISocket.StopListening()
		{
			throw null;
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x0002B36D File Offset: 0x0002956D
		[global::Cpp2ILInjected.Token(Token = "0x60038EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F330", Offset = "0x143F330", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpSocket), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void ListenLoop()
		{
			throw null;
		}

		// Token: 0x0400655E RID: 25950
		[global::Cpp2ILInjected.Token(Token = "0x4007960")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] _packetBuffer;

		// Token: 0x0400655F RID: 25951
		[global::Cpp2ILInjected.Token(Token = "0x4007961")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<object> _callbackBuffer;

		// Token: 0x04006560 RID: 25952
		[global::Cpp2ILInjected.Token(Token = "0x4007962")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _messagesInQueue;

		// Token: 0x04006561 RID: 25953
		[global::Cpp2ILInjected.Token(Token = "0x4007963")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TcpClient _connection;

		// Token: 0x04006562 RID: 25954
		[global::Cpp2ILInjected.Token(Token = "0x4007964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private TcpListener _listener;

		// Token: 0x04006563 RID: 25955
		[global::Cpp2ILInjected.Token(Token = "0x4007965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SocketConnectionAccepted _listenerCallback;

		// Token: 0x04006564 RID: 25956
		[global::Cpp2ILInjected.Token(Token = "0x4007966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private RemoteAddress _remoteAddress;

		// Token: 0x04006565 RID: 25957
		[global::Cpp2ILInjected.Token(Token = "0x4007967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _isListening;
	}
}
