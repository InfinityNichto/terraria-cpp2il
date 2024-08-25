using System;
using Cpp2ILInjected;

namespace Terraria.Net.Sockets
{
	[global::Cpp2ILInjected.Token(Token = "0x20006AF")]
	public interface ISocket
	{
		[global::Cpp2ILInjected.Token(Token = "0x60038C1")]
		void Close();

		[global::Cpp2ILInjected.Token(Token = "0x60038C2")]
		bool IsConnected();

		[global::Cpp2ILInjected.Token(Token = "0x60038C3")]
		void Connect(RemoteAddress address);

		[global::Cpp2ILInjected.Token(Token = "0x60038C4")]
		void AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state = null);

		[global::Cpp2ILInjected.Token(Token = "0x60038C5")]
		void AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state = null);

		[global::Cpp2ILInjected.Token(Token = "0x60038C6")]
		bool IsDataAvailable();

		[global::Cpp2ILInjected.Token(Token = "0x60038C7")]
		void SendQueuedPackets();

		[global::Cpp2ILInjected.Token(Token = "0x60038C8")]
		bool StartListening(SocketConnectionAccepted callback);

		[global::Cpp2ILInjected.Token(Token = "0x60038C9")]
		void StopListening();

		[global::Cpp2ILInjected.Token(Token = "0x60038CA")]
		RemoteAddress GetRemoteAddress();
	}
}
