using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace Telepathy
{
	// Token: 0x02000254 RID: 596
	[global::Cpp2ILInjected.Token(Token = "0x2000312")]
	public abstract class Common
	{
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00024E09 File Offset: 0x00023009
		[global::Cpp2ILInjected.Token(Token = "0x170001CE")]
		public int ReceiveQueueCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001264")]
			[global::Cpp2ILInjected.Address(RVA = "0xA797B4", Offset = "0xA797B4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopFrameUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00024E0C File Offset: 0x0002300C
		[global::Cpp2ILInjected.Token(Token = "0x6001265")]
		[global::Cpp2ILInjected.Address(RVA = "0xA797FC", Offset = "0xA797FC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopFrameUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = "TryDequeue", MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetNextMessage(out Message message)
		{
			throw null;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00024E0F File Offset: 0x0002300F
		[global::Cpp2ILInjected.Token(Token = "0x6001266")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79854", Offset = "0xA79854", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Common), Member = "SendLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TcpClient),
			typeof(SafeQueue<byte[]>),
			typeof(ManualResetEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		protected static bool SendMessagesBlocking(NetworkStream stream, byte[][] messages)
		{
			throw null;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00024E12 File Offset: 0x00023012
		[global::Cpp2ILInjected.Token(Token = "0x6001267")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79B54", Offset = "0xA79B54", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Common), Member = "ReceiveLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TcpClient),
			typeof(ConcurrentQueue<Message>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamExtensions), Member = "ReadExactly", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected static bool ReadMessageBlocking(NetworkStream stream, int MaxMessageSize, out byte[] content)
		{
			throw null;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00024E15 File Offset: 0x00023015
		[global::Cpp2ILInjected.Token(Token = "0x6001268")]
		[global::Cpp2ILInjected.Address(RVA = "0xA78564", Offset = "0xA78564", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client), Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server.<>c__DisplayClass8_0", Member = "<Listen>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "ReadMessageBlocking", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(int),
			typeof(ref byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		protected static void ReceiveLoop(int connectionId, TcpClient client, ConcurrentQueue<Message> receiveQueue, int MaxMessageSize)
		{
			throw null;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00024E18 File Offset: 0x00023018
		[global::Cpp2ILInjected.Token(Token = "0x6001269")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79454", Offset = "0xA79454", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Server.<>c__DisplayClass8_0", Member = "<Listen>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "get_Connected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeQueue<>), Member = "TryDequeueAll", MemberParameters = new object[] { "T[]&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "SendMessagesBlocking", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(byte[][])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		protected static void SendLoop(int connectionId, TcpClient client, SafeQueue<byte[]> sendQueue, ManualResetEvent sendPending)
		{
			throw null;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00024E1B File Offset: 0x0002301B
		[global::Cpp2ILInjected.Token(Token = "0x600126A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7935C", Offset = "0xA7935C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected Common()
		{
			throw null;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00024E1E File Offset: 0x0002301E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600126B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79D74", Offset = "0xA79D74", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Common()
		{
			throw null;
		}

		// Token: 0x04001C27 RID: 7207
		[global::Cpp2ILInjected.Token(Token = "0x40021F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected ConcurrentQueue<Message> receiveQueue;

		// Token: 0x04001C28 RID: 7208
		[global::Cpp2ILInjected.Token(Token = "0x40021F8")]
		public static int messageQueueSizeWarning;

		// Token: 0x04001C29 RID: 7209
		[global::Cpp2ILInjected.Token(Token = "0x40021F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool NoDelay;

		// Token: 0x04001C2A RID: 7210
		[global::Cpp2ILInjected.Token(Token = "0x40021FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int MaxMessageSize;

		// Token: 0x04001C2B RID: 7211
		[global::Cpp2ILInjected.Token(Token = "0x40021FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int SendTimeout;

		// Token: 0x04001C2C RID: 7212
		[ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40021FC")]
		private static byte[] header;

		// Token: 0x04001C2D RID: 7213
		[ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x40021FD")]
		private static byte[] payload;
	}
}
