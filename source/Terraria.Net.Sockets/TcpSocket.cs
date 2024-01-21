using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Cpp2IlInjected;

namespace Terraria.Net.Sockets;

[Cpp2IlInjected.Token(Token = "0x20004A7")]
public class TcpSocket : ISocket
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400655F")]
	private byte[] _packetBuffer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006560")]
	private List<object> _callbackBuffer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006561")]
	private int _messagesInQueue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006562")]
	private TcpClient _connection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006563")]
	private TcpListener _listener;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006564")]
	private SocketConnectionAccepted _listenerCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006565")]
	private RemoteAddress _remoteAddress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006566")]
	private bool _isListening;

	[Cpp2IlInjected.Token(Token = "0x17000652")]
	public int MessagesInQueue
	{
		[Cpp2IlInjected.Token(Token = "0x60033CE")]
		[Cpp2IlInjected.Address(RVA = "0x142DF10", Offset = "0x142DF10", VA = "0x142DF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60033CF")]
	[Cpp2IlInjected.Address(RVA = "0x142DF18", Offset = "0x142DF18", VA = "0x142DF18")]
	public TcpSocket()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D0")]
	[Cpp2IlInjected.Address(RVA = "0x142DFEC", Offset = "0x142DFEC", VA = "0x142DFEC")]
	public TcpSocket(TcpClient tcpClient)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D1")]
	[Cpp2IlInjected.Address(RVA = "0x142E15C", Offset = "0x142E15C", VA = "0x142E15C", Slot = "4")]
	void ISocket.Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D2")]
	[Cpp2IlInjected.Address(RVA = "0x142E174", Offset = "0x142E174", VA = "0x142E174", Slot = "5")]
	bool ISocket.IsConnected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033D3")]
	[Cpp2IlInjected.Address(RVA = "0x142E198", Offset = "0x142E198", VA = "0x142E198", Slot = "6")]
	void ISocket.Connect(RemoteAddress address)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D4")]
	[Cpp2IlInjected.Address(RVA = "0x142E238", Offset = "0x142E238", VA = "0x142E238")]
	private void ReadCallback(IAsyncResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D5")]
	[Cpp2IlInjected.Address(RVA = "0x142E36C", Offset = "0x142E36C", VA = "0x142E36C")]
	private void SendCallback(IAsyncResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D6")]
	[Cpp2IlInjected.Address(RVA = "0x142E5DC", Offset = "0x142E5DC", VA = "0x142E5DC", Slot = "10")]
	void ISocket.SendQueuedPackets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D7")]
	[Cpp2IlInjected.Address(RVA = "0x142E5E0", Offset = "0x142E5E0", VA = "0x142E5E0", Slot = "7")]
	void ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D8")]
	[Cpp2IlInjected.Address(RVA = "0x142E6E4", Offset = "0x142E6E4", VA = "0x142E6E4", Slot = "8")]
	void ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033D9")]
	[Cpp2IlInjected.Address(RVA = "0x142E7EC", Offset = "0x142E7EC", VA = "0x142E7EC", Slot = "9")]
	bool ISocket.IsDataAvailable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033DA")]
	[Cpp2IlInjected.Address(RVA = "0x142E834", Offset = "0x142E834", VA = "0x142E834", Slot = "13")]
	RemoteAddress ISocket.GetRemoteAddress()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60033DB")]
	[Cpp2IlInjected.Address(RVA = "0x142E83C", Offset = "0x142E83C", VA = "0x142E83C", Slot = "11")]
	bool ISocket.StartListening(SocketConnectionAccepted callback)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033DC")]
	[Cpp2IlInjected.Address(RVA = "0x142EB50", Offset = "0x142EB50", VA = "0x142EB50", Slot = "12")]
	void ISocket.StopListening()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033DD")]
	[Cpp2IlInjected.Address(RVA = "0x142EB5C", Offset = "0x142EB5C", VA = "0x142EB5C")]
	private void ListenLoop()
	{
	}
}
