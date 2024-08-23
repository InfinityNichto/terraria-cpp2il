using System;
using Cpp2ILInjected;

namespace Terraria.Net.Sockets
{
	// Token: 0x020004A2 RID: 1186
	[global::Cpp2ILInjected.Token(Token = "0x20006AF")]
	public interface ISocket
	{
		// Token: 0x0600337B RID: 13179
		[global::Cpp2ILInjected.Token(Token = "0x60038C1")]
		void Close();

		// Token: 0x0600337C RID: 13180
		[global::Cpp2ILInjected.Token(Token = "0x60038C2")]
		bool IsConnected();

		// Token: 0x0600337D RID: 13181
		[global::Cpp2ILInjected.Token(Token = "0x60038C3")]
		void Connect(RemoteAddress address);

		// Token: 0x0600337E RID: 13182
		[global::Cpp2ILInjected.Token(Token = "0x60038C4")]
		void AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state = null);

		// Token: 0x0600337F RID: 13183
		[global::Cpp2ILInjected.Token(Token = "0x60038C5")]
		void AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state = null);

		// Token: 0x06003380 RID: 13184
		[global::Cpp2ILInjected.Token(Token = "0x60038C6")]
		bool IsDataAvailable();

		// Token: 0x06003381 RID: 13185
		[global::Cpp2ILInjected.Token(Token = "0x60038C7")]
		void SendQueuedPackets();

		// Token: 0x06003382 RID: 13186
		[global::Cpp2ILInjected.Token(Token = "0x60038C8")]
		bool StartListening(SocketConnectionAccepted callback);

		// Token: 0x06003383 RID: 13187
		[global::Cpp2ILInjected.Token(Token = "0x60038C9")]
		void StopListening();

		// Token: 0x06003384 RID: 13188
		[global::Cpp2ILInjected.Token(Token = "0x60038CA")]
		RemoteAddress GetRemoteAddress();
	}
}
