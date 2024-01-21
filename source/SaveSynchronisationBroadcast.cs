using System.Net.Sockets;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200021B")]
public static class SaveSynchronisationBroadcast
{
	[Cpp2IlInjected.Token(Token = "0x4001A14")]
	private static UdpClient BroadcastClient;

	[Cpp2IlInjected.Token(Token = "0x4001A15")]
	private static ManagedThread broadcastThread;

	[Cpp2IlInjected.Token(Token = "0x6000F3E")]
	[Cpp2IlInjected.Address(RVA = "0xF9C310", Offset = "0xF9C310", VA = "0xF9C310")]
	private static void BroadcastThread()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F3F")]
	[Cpp2IlInjected.Address(RVA = "0xF9CA94", Offset = "0xF9CA94", VA = "0xF9CA94")]
	public static void StartBroadCasting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F40")]
	[Cpp2IlInjected.Address(RVA = "0xF9CBD4", Offset = "0xF9CBD4", VA = "0xF9CBD4")]
	public static void StopBroadCasting()
	{
	}
}
