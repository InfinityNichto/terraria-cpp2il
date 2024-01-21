using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200031F")]
public class Netplay
{
	[Cpp2IlInjected.Token(Token = "0x4002769")]
	public static string BanFilePath;

	[Cpp2IlInjected.Token(Token = "0x400276A")]
	public static string ServerPassword;

	[Cpp2IlInjected.Token(Token = "0x400276B")]
	public static RemoteClient[] Clients;

	[Cpp2IlInjected.Token(Token = "0x400276C")]
	public static RemoteConnection Connection;

	[Cpp2IlInjected.Token(Token = "0x400276D")]
	public static RemoteServer Server;

	[Cpp2IlInjected.Token(Token = "0x400276E")]
	public static IPAddress ServerIP;

	[Cpp2IlInjected.Token(Token = "0x400276F")]
	public static string ServerIPText;

	[Cpp2IlInjected.Token(Token = "0x4002770")]
	public static int ListenPort;

	[Cpp2IlInjected.Token(Token = "0x4002771")]
	public static bool IsServerRunning;

	[Cpp2IlInjected.Token(Token = "0x4002772")]
	public static bool IsListening;

	[Cpp2IlInjected.Token(Token = "0x4002773")]
	public static bool UseUPNP;

	[Cpp2IlInjected.Token(Token = "0x4002774")]
	public static bool LostConnection;

	[Cpp2IlInjected.Token(Token = "0x4002775")]
	public static bool Disconnect;

	[Cpp2IlInjected.Token(Token = "0x4002776")]
	public static bool SpamCheck;

	[Cpp2IlInjected.Token(Token = "0x4002777")]
	public static bool HasClients;

	[Cpp2IlInjected.Token(Token = "0x4002778")]
	public static string portForwardIP;

	[Cpp2IlInjected.Token(Token = "0x4002779")]
	public static int portForwardPort;

	[Cpp2IlInjected.Token(Token = "0x400277A")]
	public static bool portForwardOpen;

	[Cpp2IlInjected.Token(Token = "0x400277B")]
	private static int oldState;

	[Cpp2IlInjected.Token(Token = "0x400277C")]
	public static DateTime LastClientUpdateTime;

	[Cpp2IlInjected.Token(Token = "0x400277D")]
	public static bool clientLoopRunning;

	[Cpp2IlInjected.Token(Token = "0x400277E")]
	private static UdpClient BroadcastClient;

	[Cpp2IlInjected.Token(Token = "0x400277F")]
	private static ManagedThread broadcastThread;

	[Cpp2IlInjected.Token(Token = "0x4002780")]
	public const int MaxConnections = 256;

	[Cpp2IlInjected.Token(Token = "0x4002781")]
	public const int NetBufferSize = 32768;

	[Cpp2IlInjected.Token(Token = "0x4002783")]
	public static AutoResetEvent disconnectEvent;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public static event Action OnDisconnect
	{
		[Cpp2IlInjected.Token(Token = "0x60020E1")]
		[Cpp2IlInjected.Address(RVA = "0x1444280", Offset = "0x1444280", VA = "0x1444280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60020E2")]
		[Cpp2IlInjected.Address(RVA = "0x1444388", Offset = "0x1444388", VA = "0x1444388")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60020E3")]
	[Cpp2IlInjected.Address(RVA = "0x1444490", Offset = "0x1444490", VA = "0x1444490")]
	private static void OpenPort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020E4")]
	[Cpp2IlInjected.Address(RVA = "0x1444650", Offset = "0x1444650", VA = "0x1444650")]
	public static void closePort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020E5")]
	[Cpp2IlInjected.Address(RVA = "0x1444518", Offset = "0x1444518", VA = "0x1444518")]
	public static string GetLocalIPAddress()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60020E6")]
	[Cpp2IlInjected.Address(RVA = "0x1444654", Offset = "0x1444654", VA = "0x1444654")]
	public static void ResetNetDiag()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020E7")]
	[Cpp2IlInjected.Address(RVA = "0x1444744", Offset = "0x1444744", VA = "0x1444744")]
	public static void ResetSections()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020E8")]
	[Cpp2IlInjected.Address(RVA = "0x1444884", Offset = "0x1444884", VA = "0x1444884")]
	public static void AddBan(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020E9")]
	[Cpp2IlInjected.Address(RVA = "0x1444A94", Offset = "0x1444A94", VA = "0x1444A94")]
	public static bool IsBanned(RemoteAddress address)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020EA")]
	[Cpp2IlInjected.Address(RVA = "0x1444E08", Offset = "0x1444E08", VA = "0x1444E08")]
	public static void AddCurrentServerToRecentList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020EB")]
	[Cpp2IlInjected.Address(RVA = "0x14456D0", Offset = "0x14456D0", VA = "0x14456D0")]
	public static void deleteDedicatedServer(string ip, int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020EC")]
	[Cpp2IlInjected.Address(RVA = "0x1445AAC", Offset = "0x1445AAC", VA = "0x1445AAC")]
	public static void SocialClientLoop(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020ED")]
	[Cpp2IlInjected.Address(RVA = "0x1445AB0", Offset = "0x1445AB0", VA = "0x1445AB0")]
	public static void TcpLocalClientLoop(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020EE")]
	[Cpp2IlInjected.Address(RVA = "0x1446BA8", Offset = "0x1446BA8", VA = "0x1446BA8")]
	public static void TcpClientLoop(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020EF")]
	[Cpp2IlInjected.Address(RVA = "0x14460C0", Offset = "0x14460C0", VA = "0x14460C0")]
	private static void ClientServerLoopSetup(RemoteAddress address)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F0")]
	[Cpp2IlInjected.Address(RVA = "0x1447714", Offset = "0x1447714", VA = "0x1447714")]
	private static void ClientLoopSetup(RemoteAddress address)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F1")]
	[Cpp2IlInjected.Address(RVA = "0x1447B4C", Offset = "0x1447B4C", VA = "0x1447B4C")]
	public static void ClientUpdateFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F2")]
	[Cpp2IlInjected.Address(RVA = "0x1447D9C", Offset = "0x1447D9C", VA = "0x1447D9C")]
	public static void ServerUpdateFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F3")]
	[Cpp2IlInjected.Address(RVA = "0x1448324", Offset = "0x1448324", VA = "0x1448324")]
	public static void UpdateClientNet()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F4")]
	[Cpp2IlInjected.Address(RVA = "0x1448600", Offset = "0x1448600", VA = "0x1448600")]
	public static void ClientLoopFrameUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F5")]
	[Cpp2IlInjected.Address(RVA = "0x144639C", Offset = "0x144639C", VA = "0x144639C")]
	private static void InnerClientLoop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F6")]
	[Cpp2IlInjected.Address(RVA = "0x1449648", Offset = "0x1449648", VA = "0x1449648")]
	private static int FindNextOpenClientSlot()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60020F7")]
	[Cpp2IlInjected.Address(RVA = "0x1448224", Offset = "0x1448224", VA = "0x1448224")]
	private static void OnConnectionAccepted(int clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020F8")]
	[Cpp2IlInjected.Address(RVA = "0x1449650", Offset = "0x1449650", VA = "0x1449650")]
	private static bool StartListening()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020F9")]
	[Cpp2IlInjected.Address(RVA = "0x14496D8", Offset = "0x14496D8", VA = "0x14496D8")]
	private static void StopListening()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020FA")]
	[Cpp2IlInjected.Address(RVA = "0x144975C", Offset = "0x144975C", VA = "0x144975C")]
	private static void BroadcastThread()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020FB")]
	[Cpp2IlInjected.Address(RVA = "0x144A264", Offset = "0x144A264", VA = "0x144A264")]
	public static void StartBroadCasting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020FC")]
	[Cpp2IlInjected.Address(RVA = "0x144A7B4", Offset = "0x144A7B4", VA = "0x144A7B4")]
	public static void StopBroadCasting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020FD")]
	[Cpp2IlInjected.Address(RVA = "0x144A918", Offset = "0x144A918", VA = "0x144A918")]
	public static void ServerLoopUpdateFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020FE")]
	[Cpp2IlInjected.Address(RVA = "0x144BFEC", Offset = "0x144BFEC", VA = "0x144BFEC")]
	public static void ServerLoop(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020FF")]
	[Cpp2IlInjected.Address(RVA = "0x144CE24", Offset = "0x144CE24", VA = "0x144CE24")]
	public static void StartTcpClient(bool connectingToLocalServer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002100")]
	[Cpp2IlInjected.Address(RVA = "0x144CFC0", Offset = "0x144CFC0", VA = "0x144CFC0")]
	public static void StartServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002101")]
	[Cpp2IlInjected.Address(RVA = "0x144D0A0", Offset = "0x144D0A0", VA = "0x144D0A0")]
	public static bool SetRemoteIP(string remoteAddress)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002102")]
	[Cpp2IlInjected.Address(RVA = "0x144D1F8", Offset = "0x144D1F8", VA = "0x144D1F8")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002103")]
	[Cpp2IlInjected.Address(RVA = "0x143E02C", Offset = "0x143E02C", VA = "0x143E02C")]
	public static int GetSectionX(int x)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002104")]
	[Cpp2IlInjected.Address(RVA = "0x143E044", Offset = "0x143E044", VA = "0x143E044")]
	public static int GetSectionY(int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002105")]
	[Cpp2IlInjected.Address(RVA = "0x144D398", Offset = "0x144D398", VA = "0x144D398")]
	public Netplay()
	{
	}
}
