using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Net.Sockets;

[Cpp2IlInjected.Token(Token = "0x20004A5")]
public interface ISocket
{
	[Cpp2IlInjected.Token(Token = "0x60033B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Close();

	[Cpp2IlInjected.Token(Token = "0x60033B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IsConnected();

	[Cpp2IlInjected.Token(Token = "0x60033B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void Connect(RemoteAddress address);

	[Cpp2IlInjected.Token(Token = "0x60033BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, [Optional] object state);

	[Cpp2IlInjected.Token(Token = "0x60033BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, [Optional] object state);

	[Cpp2IlInjected.Token(Token = "0x60033BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IsDataAvailable();

	[Cpp2IlInjected.Token(Token = "0x60033BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SendQueuedPackets();

	[Cpp2IlInjected.Token(Token = "0x60033BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool StartListening(SocketConnectionAccepted callback);

	[Cpp2IlInjected.Token(Token = "0x60033BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void StopListening();

	[Cpp2IlInjected.Token(Token = "0x60033C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	RemoteAddress GetRemoteAddress();
}
