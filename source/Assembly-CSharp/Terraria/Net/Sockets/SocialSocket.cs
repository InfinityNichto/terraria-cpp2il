using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Net.Sockets
{
	// Token: 0x020004A3 RID: 1187
	[global::Cpp2ILInjected.Token(Token = "0x20006B0")]
	public class SocialSocket : ISocket
	{
		// Token: 0x06003385 RID: 13189 RVA: 0x0002B319 File Offset: 0x00029519
		[global::Cpp2ILInjected.Token(Token = "0x60038CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E0C8", Offset = "0x143E0C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SocialSocket()
		{
			throw null;
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x0002B31C File Offset: 0x0002951C
		[global::Cpp2ILInjected.Token(Token = "0x60038CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E0D0", Offset = "0x143E0D0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SocialSocket(RemoteAddress remoteAddress)
		{
			throw null;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x0002B31F File Offset: 0x0002951F
		[global::Cpp2ILInjected.Token(Token = "0x60038CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E0F8", Offset = "0x143E0F8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Terraria.Net.Sockets.ISocket.Close()
		{
			throw null;
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x0002B322 File Offset: 0x00029522
		[global::Cpp2ILInjected.Token(Token = "0x60038CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E15C", Offset = "0x143E15C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool Terraria.Net.Sockets.ISocket.IsConnected()
		{
			throw null;
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x0002B325 File Offset: 0x00029525
		[global::Cpp2ILInjected.Token(Token = "0x60038CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E1B4", Offset = "0x143E1B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Terraria.Net.Sockets.ISocket.Connect(RemoteAddress address)
		{
			throw null;
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x0002B328 File Offset: 0x00029528
		[global::Cpp2ILInjected.Token(Token = "0x60038D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E21C", Offset = "0x143E21C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Terraria.Net.Sockets.ISocket.AsyncSend(byte[] data, int offset, int size, SocketSendCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x0002B32B File Offset: 0x0002952B
		[global::Cpp2ILInjected.Token(Token = "0x60038D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E2C0", Offset = "0x143E2C0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x0002B32E File Offset: 0x0002952E
		[global::Cpp2ILInjected.Token(Token = "0x60038D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E37C", Offset = "0x143E37C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocialSocket.InternalReadCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocialSocket.InternalReadCallback), Member = "BeginInvoke", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(SocketReceiveCallback),
			typeof(object),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Terraria.Net.Sockets.ISocket.AsyncReceive(byte[] data, int offset, int size, SocketReceiveCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x0002B331 File Offset: 0x00029531
		[global::Cpp2ILInjected.Token(Token = "0x60038D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E5D4", Offset = "0x143E5D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void Terraria.Net.Sockets.ISocket.SendQueuedPackets()
		{
			throw null;
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x0002B334 File Offset: 0x00029534
		[global::Cpp2ILInjected.Token(Token = "0x60038D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E5D8", Offset = "0x143E5D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool Terraria.Net.Sockets.ISocket.IsDataAvailable()
		{
			throw null;
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x0002B337 File Offset: 0x00029537
		[global::Cpp2ILInjected.Token(Token = "0x60038D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E634", Offset = "0x143E634", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private RemoteAddress Terraria.Net.Sockets.ISocket.GetRemoteAddress()
		{
			throw null;
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x0002B33A File Offset: 0x0002953A
		[global::Cpp2ILInjected.Token(Token = "0x60038D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E63C", Offset = "0x143E63C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool Terraria.Net.Sockets.ISocket.StartListening(SocketConnectionAccepted callback)
		{
			throw null;
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x0002B33D File Offset: 0x0002953D
		[global::Cpp2ILInjected.Token(Token = "0x60038D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x143E698", Offset = "0x143E698", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Terraria.Net.Sockets.ISocket.StopListening()
		{
			throw null;
		}

		// Token: 0x0400655D RID: 25949
		[global::Cpp2ILInjected.Token(Token = "0x400795F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RemoteAddress _remoteAddress;

		// Token: 0x02000942 RID: 2370
		// (Invoke) Token: 0x06004CBC RID: 19644
		[global::Cpp2ILInjected.Token(Token = "0x20006B1")]
		private delegate void InternalReadCallback(byte[] data, int offset, int size, SocketReceiveCallback callback, object state);
	}
}
