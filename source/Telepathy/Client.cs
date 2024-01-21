using System.Net;
using System.Net.Sockets;
using System.Threading;
using Cpp2IlInjected;

namespace Telepathy;

[Cpp2IlInjected.Token(Token = "0x2000256")]
public class Client : Common
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001C29")]
	public TcpClient client;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001C2A")]
	private Thread receiveThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001C2B")]
	private Thread sendThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001C2C")]
	private bool _Connecting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001C2D")]
	private SafeQueue<byte[]> sendQueue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001C2E")]
	private ManualResetEvent sendPending;

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public bool Connected
	{
		[Cpp2IlInjected.Token(Token = "0x600113A")]
		[Cpp2IlInjected.Address(RVA = "0x10641A4", Offset = "0x10641A4", VA = "0x10641A4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public bool Connecting
	{
		[Cpp2IlInjected.Token(Token = "0x600113B")]
		[Cpp2IlInjected.Address(RVA = "0x10641D0", Offset = "0x10641D0", VA = "0x10641D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600113C")]
	[Cpp2IlInjected.Address(RVA = "0x10641E8", Offset = "0x10641E8", VA = "0x10641E8")]
	private bool GetIPV6AddressFromIPV4(string hostname, out string ipv6Address)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600113D")]
	[Cpp2IlInjected.Address(RVA = "0x106456C", Offset = "0x106456C", VA = "0x106456C")]
	private void ReceiveThreadFunction(string ip, int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600113E")]
	[Cpp2IlInjected.Address(RVA = "0x1065594", Offset = "0x1065594", VA = "0x1065594")]
	private IPAddress GetIPAddress()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600113F")]
	[Cpp2IlInjected.Address(RVA = "0x1065A9C", Offset = "0x1065A9C", VA = "0x1065A9C")]
	public void Connect(string ip, int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001140")]
	[Cpp2IlInjected.Address(RVA = "0x1065CA8", Offset = "0x1065CA8", VA = "0x1065CA8")]
	public void Disconnect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001141")]
	[Cpp2IlInjected.Address(RVA = "0x1065DE8", Offset = "0x1065DE8", VA = "0x1065DE8")]
	public bool Send(byte[] data, int length)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001142")]
	[Cpp2IlInjected.Address(RVA = "0x10660D4", Offset = "0x10660D4", VA = "0x10660D4")]
	public Client()
	{
	}
}
