using Cpp2IlInjected;

namespace Terraria.Net.Sockets;

[Cpp2IlInjected.Token(Token = "0x20004A6")]
public class SocialSocket : ISocket
{
	[Cpp2IlInjected.Token(Token = "0x2000939")]
	private delegate void InternalReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400655E")]
	private RemoteAddress _remoteAddress;

	[Cpp2IlInjected.Token(Token = "0x60033C1")]
	[Cpp2IlInjected.Address(RVA = "0x142C480", Offset = "0x142C480", VA = "0x142C480")]
	public SocialSocket()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C2")]
	[Cpp2IlInjected.Address(RVA = "0x142C488", Offset = "0x142C488", VA = "0x142C488")]
	public SocialSocket(RemoteAddress remoteAddress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C3")]
	[Cpp2IlInjected.Address(RVA = "0x142C4A8", Offset = "0x142C4A8", VA = "0x142C4A8", Slot = "4")]
	void ISocket.Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C4")]
	[Cpp2IlInjected.Address(RVA = "0x142C54C", Offset = "0x142C54C", VA = "0x142C54C", Slot = "5")]
	bool ISocket.IsConnected()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033C5")]
	[Cpp2IlInjected.Address(RVA = "0x142C5DC", Offset = "0x142C5DC", VA = "0x142C5DC", Slot = "6")]
	void ISocket.Connect(RemoteAddress address)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C6")]
	[Cpp2IlInjected.Address(RVA = "0x142C674", Offset = "0x142C674", VA = "0x142C674", Slot = "7")]
	void ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C7")]
	[Cpp2IlInjected.Address(RVA = "0x142C76C", Offset = "0x142C76C", VA = "0x142C76C")]
	private void ReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C8")]
	[Cpp2IlInjected.Address(RVA = "0x142CD1C", Offset = "0x142CD1C", VA = "0x142CD1C", Slot = "8")]
	void ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033C9")]
	[Cpp2IlInjected.Address(RVA = "0x142CEA4", Offset = "0x142CEA4", VA = "0x142CEA4", Slot = "10")]
	void ISocket.SendQueuedPackets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033CA")]
	[Cpp2IlInjected.Address(RVA = "0x142CEA8", Offset = "0x142CEA8", VA = "0x142CEA8", Slot = "9")]
	bool ISocket.IsDataAvailable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033CB")]
	[Cpp2IlInjected.Address(RVA = "0x142CF38", Offset = "0x142CF38", VA = "0x142CF38", Slot = "13")]
	RemoteAddress ISocket.GetRemoteAddress()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60033CC")]
	[Cpp2IlInjected.Address(RVA = "0x142CF40", Offset = "0x142CF40", VA = "0x142CF40", Slot = "11")]
	bool ISocket.StartListening(SocketConnectionAccepted callback)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033CD")]
	[Cpp2IlInjected.Address(RVA = "0x142CFD0", Offset = "0x142CFD0", VA = "0x142CFD0", Slot = "12")]
	void ISocket.StopListening()
	{
	}
}
