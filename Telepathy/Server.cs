using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Threading;
using Cpp2IlInjected;

namespace Telepathy;

[Cpp2IlInjected.Token(Token = "0x200025C")]
public class Server : Common
{
	[Cpp2IlInjected.Token(Token = "0x2000814")]
	private class ClientToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D7B")]
		public TcpClient client;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007D7C")]
		public SafeQueue<byte[]> sendQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007D7D")]
		public ManualResetEvent sendPending;

		[Cpp2IlInjected.Token(Token = "0x6004960")]
		[Cpp2IlInjected.Address(RVA = "0x1067764", Offset = "0x1067764", VA = "0x1067764")]
		public ClientToken(TcpClient client)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001C41")]
	public TcpListener listener;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001C42")]
	private Thread listenerThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001C43")]
	private ConcurrentDictionary<int, ClientToken> clients;

	[Cpp2IlInjected.Token(Token = "0x4001C44")]
	private static int counter;

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x6001155")]
		[Cpp2IlInjected.Address(RVA = "0x106738C", Offset = "0x106738C", VA = "0x106738C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001154")]
	[Cpp2IlInjected.Address(RVA = "0x1067054", Offset = "0x1067054", VA = "0x1067054")]
	private int NextConnectionId(TcpClient newClient)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001156")]
	[Cpp2IlInjected.Address(RVA = "0x10673A4", Offset = "0x10673A4", VA = "0x10673A4")]
	private void Listen(int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001157")]
	[Cpp2IlInjected.Address(RVA = "0x1067818", Offset = "0x1067818", VA = "0x1067818")]
	public bool Start(int port)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001158")]
	[Cpp2IlInjected.Address(RVA = "0x1067C90", Offset = "0x1067C90", VA = "0x1067C90")]
	private void Cleanup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001159")]
	[Cpp2IlInjected.Address(RVA = "0x1068020", Offset = "0x1068020", VA = "0x1068020")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600115A")]
	[Cpp2IlInjected.Address(RVA = "0x1068178", Offset = "0x1068178", VA = "0x1068178")]
	public bool Send(int connectionId, byte[] data, int length)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600115B")]
	[Cpp2IlInjected.Address(RVA = "0x10684C4", Offset = "0x10684C4", VA = "0x10684C4")]
	public string GetClientAddress(int connectionId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600115C")]
	[Cpp2IlInjected.Address(RVA = "0x1067268", Offset = "0x1067268", VA = "0x1067268")]
	public bool Disconnect(int connectionId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600115D")]
	[Cpp2IlInjected.Address(RVA = "0x10685F8", Offset = "0x10685F8", VA = "0x10685F8")]
	public Server()
	{
	}
}
