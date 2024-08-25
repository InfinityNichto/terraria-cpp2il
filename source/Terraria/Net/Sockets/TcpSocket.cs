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
	[global::Cpp2ILInjected.Token(Token = "0x20006B2")]
	public class TcpSocket : ISocket
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60038DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E954", Offset = "0x143E954", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		private void Terraria.Net.Sockets.ISocket.Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60038E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E968", Offset = "0x143E968", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
		private bool Terraria.Net.Sockets.ISocket.IsConnected()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60038E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x143EDB0", Offset = "0x143EDB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Net.Sockets.ISocket.SendQueuedPackets()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60038E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F034", Offset = "0x143F034", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private RemoteAddress Terraria.Net.Sockets.ISocket.GetRemoteAddress()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60038EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x143F328", Offset = "0x143F328", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Net.Sockets.ISocket.StopListening()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007960")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] _packetBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4007961")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<object> _callbackBuffer;

		[global::Cpp2ILInjected.Token(Token = "0x4007962")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _messagesInQueue;

		[global::Cpp2ILInjected.Token(Token = "0x4007963")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TcpClient _connection;

		[global::Cpp2ILInjected.Token(Token = "0x4007964")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private TcpListener _listener;

		[global::Cpp2ILInjected.Token(Token = "0x4007965")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SocketConnectionAccepted _listenerCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4007966")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private RemoteAddress _remoteAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4007967")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _isListening;
	}
}
