using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20002D0")]
public static class ServerAutoFinder
{
	[global::Cpp2ILInjected.Token(Token = "0x60010A8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4A954", Offset = "0xA4A954", Length = "0xA94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "CheckThreadTerminiate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "ReceiveAsync", ReturnType = typeof(Task<UdpReceiveResult>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<UdpReceiveResult>), Member = "get_Result", ReturnType = "TResult")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
	private static void BroadcastRecieveThread()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010A9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4B3F0", Offset = "0xA4B3F0", Length = "0x404")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "CheckThreadTerminiate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "GetFriends", ReturnType = typeof(PlatformUser[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionManager), Member = "FindUserSessions", MemberParameters = new object[] { typeof(PlatformUser[]) }, ReturnType = typeof(MPSession[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private static void LookForFriendPlatformGames()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010AA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4B7F4", Offset = "0xA4B7F4", Length = "0x4F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "RefreshLocalServers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	public static void UpdateResults()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010AB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4BCE8", Offset = "0xA4BCE8", Length = "0x1A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerAutoFinder), Member = "StopSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public static void StartSearching()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60010AC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4BE90", Offset = "0xA4BE90", Length = "0x1F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "StartSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "TerminateThread", MemberParameters = new object[] { typeof(ManagedThread) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public static void StopSearching()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60010AD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4C084", Offset = "0xA4C084", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static ServerAutoFinder()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001F81")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	[global::Cpp2ILInjected.Token(Token = "0x4001F82")]
	private static UdpClient broadcastPort;

	[global::Cpp2ILInjected.Token(Token = "0x4001F83")]
	private static ManagedThread broadcastThread;

	[global::Cpp2ILInjected.Token(Token = "0x4001F84")]
	private static ManagedThread platformFriendGamesThread;

	[global::Cpp2ILInjected.Token(Token = "0x4001F85")]
	private static List<ServerAutoFinder.SearchServerResult> TempResults;

	[global::Cpp2ILInjected.Token(Token = "0x4001F86")]
	private static List<ServerAutoFinder.SearchServerResult> FriendResults;

	[global::Cpp2ILInjected.Token(Token = "0x4001F87")]
	private static DateTime LastListUpdate;

	[global::Cpp2ILInjected.Token(Token = "0x4001F88")]
	public static List<ServerAutoFinder.SearchServerResult> Results;

	[global::Cpp2ILInjected.Token(Token = "0x20002D1")]
	public class SearchServerResult
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010AE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4B3E8", Offset = "0xA4B3E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SearchServerResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001F89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string WorldName;

		[global::Cpp2ILInjected.Token(Token = "0x4001F8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IPAddress ServerAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4001F8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int ServerPort;

		[global::Cpp2ILInjected.Token(Token = "0x4001F8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public DateTime LastRecieved;

		[global::Cpp2ILInjected.Token(Token = "0x4001F8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public ushort WorldXSize;

		[global::Cpp2ILInjected.Token(Token = "0x4001F8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int NumberOfPlayers;

		[global::Cpp2ILInjected.Token(Token = "0x4001F8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int MaxPlayers;

		[global::Cpp2ILInjected.Token(Token = "0x4001F90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public short GameMode;

		[global::Cpp2ILInjected.Token(Token = "0x4001F91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E")]
		public bool Corruption;

		[global::Cpp2ILInjected.Token(Token = "0x4001F92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F")]
		public bool HardMode;

		[global::Cpp2ILInjected.Token(Token = "0x4001F93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public string HostName;

		[global::Cpp2ILInjected.Token(Token = "0x4001F94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public MPSession SourceSession;
	}
}
