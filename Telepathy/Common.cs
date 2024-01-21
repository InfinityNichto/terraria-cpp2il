using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using Cpp2IlInjected;

namespace Telepathy;

[Cpp2IlInjected.Token(Token = "0x2000257")]
public abstract class Common
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001C2F")]
	protected ConcurrentQueue<Message> receiveQueue;

	[Cpp2IlInjected.Token(Token = "0x4001C30")]
	public static int messageQueueSizeWarning;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001C31")]
	public bool NoDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001C32")]
	public int MaxMessageSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001C33")]
	public int SendTimeout;

	[Cpp2IlInjected.Token(Token = "0x4001C34")]
	[ThreadStatic]
	private static byte[] header;

	[Cpp2IlInjected.Token(Token = "0x4001C35")]
	[ThreadStatic]
	private static byte[] payload;

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public int ReceiveQueueCount
	{
		[Cpp2IlInjected.Token(Token = "0x6001144")]
		[Cpp2IlInjected.Address(RVA = "0x1066790", Offset = "0x1066790", VA = "0x1066790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001145")]
	[Cpp2IlInjected.Address(RVA = "0x10667EC", Offset = "0x10667EC", VA = "0x10667EC")]
	public bool GetNextMessage(out Message message)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001146")]
	[Cpp2IlInjected.Address(RVA = "0x1066850", Offset = "0x1066850", VA = "0x1066850")]
	protected static bool SendMessagesBlocking(NetworkStream stream, byte[][] messages)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001147")]
	[Cpp2IlInjected.Address(RVA = "0x1066BF4", Offset = "0x1066BF4", VA = "0x1066BF4")]
	protected static bool ReadMessageBlocking(NetworkStream stream, int MaxMessageSize, out byte[] content)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001148")]
	[Cpp2IlInjected.Address(RVA = "0x1064E48", Offset = "0x1064E48", VA = "0x1064E48")]
	protected static void ReceiveLoop(int connectionId, TcpClient client, ConcurrentQueue<Message> receiveQueue, int MaxMessageSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001149")]
	[Cpp2IlInjected.Address(RVA = "0x10662DC", Offset = "0x10662DC", VA = "0x10662DC")]
	protected static void SendLoop(int connectionId, TcpClient client, SafeQueue<byte[]> sendQueue, ManualResetEvent sendPending)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600114A")]
	[Cpp2IlInjected.Address(RVA = "0x10661A8", Offset = "0x10661A8", VA = "0x10661A8")]
	protected Common()
	{
	}
}
