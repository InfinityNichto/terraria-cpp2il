using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000224 RID: 548
[global::Cpp2ILInjected.Token(Token = "0x20002D0")]
public static class ServerAutoFinder
{
	// Token: 0x06000F70 RID: 3952 RVA: 0x0002494D File Offset: 0x00022B4D
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

	// Token: 0x06000F71 RID: 3953 RVA: 0x00024950 File Offset: 0x00022B50
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

	// Token: 0x06000F72 RID: 3954 RVA: 0x00024953 File Offset: 0x00022B53
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

	// Token: 0x06000F73 RID: 3955 RVA: 0x00024956 File Offset: 0x00022B56
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

	// Token: 0x06000F74 RID: 3956 RVA: 0x00024959 File Offset: 0x00022B59
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

	// Token: 0x06000F75 RID: 3957 RVA: 0x0002495C File Offset: 0x00022B5C
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

	// Token: 0x04001A38 RID: 6712
	[global::Cpp2ILInjected.Token(Token = "0x4001F81")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x04001A39 RID: 6713
	[global::Cpp2ILInjected.Token(Token = "0x4001F82")]
	private static UdpClient broadcastPort;

	// Token: 0x04001A3A RID: 6714
	[global::Cpp2ILInjected.Token(Token = "0x4001F83")]
	private static ManagedThread broadcastThread;

	// Token: 0x04001A3B RID: 6715
	[global::Cpp2ILInjected.Token(Token = "0x4001F84")]
	private static ManagedThread platformFriendGamesThread;

	// Token: 0x04001A3C RID: 6716
	[global::Cpp2ILInjected.Token(Token = "0x4001F85")]
	private static List<ServerAutoFinder.SearchServerResult> TempResults;

	// Token: 0x04001A3D RID: 6717
	[global::Cpp2ILInjected.Token(Token = "0x4001F86")]
	private static List<ServerAutoFinder.SearchServerResult> FriendResults;

	// Token: 0x04001A3E RID: 6718
	[global::Cpp2ILInjected.Token(Token = "0x4001F87")]
	private static DateTime LastListUpdate;

	// Token: 0x04001A3F RID: 6719
	[global::Cpp2ILInjected.Token(Token = "0x4001F88")]
	public static List<ServerAutoFinder.SearchServerResult> Results;

	// Token: 0x0200080D RID: 2061
	[global::Cpp2ILInjected.Token(Token = "0x20002D1")]
	public class SearchServerResult
	{
		// Token: 0x0600490B RID: 18699 RVA: 0x0002EF46 File Offset: 0x0002D146
		[global::Cpp2ILInjected.Token(Token = "0x60010AE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4B3E8", Offset = "0xA4B3E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SearchServerResult()
		{
			throw null;
		}

		// Token: 0x04007D13 RID: 32019
		[global::Cpp2ILInjected.Token(Token = "0x4001F89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string WorldName;

		// Token: 0x04007D14 RID: 32020
		[global::Cpp2ILInjected.Token(Token = "0x4001F8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public IPAddress ServerAddress;

		// Token: 0x04007D15 RID: 32021
		[global::Cpp2ILInjected.Token(Token = "0x4001F8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int ServerPort;

		// Token: 0x04007D16 RID: 32022
		[global::Cpp2ILInjected.Token(Token = "0x4001F8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public DateTime LastRecieved;

		// Token: 0x04007D17 RID: 32023
		[global::Cpp2ILInjected.Token(Token = "0x4001F8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public ushort WorldXSize;

		// Token: 0x04007D18 RID: 32024
		[global::Cpp2ILInjected.Token(Token = "0x4001F8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int NumberOfPlayers;

		// Token: 0x04007D19 RID: 32025
		[global::Cpp2ILInjected.Token(Token = "0x4001F8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int MaxPlayers;

		// Token: 0x04007D1A RID: 32026
		[global::Cpp2ILInjected.Token(Token = "0x4001F90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public short GameMode;

		// Token: 0x04007D1B RID: 32027
		[global::Cpp2ILInjected.Token(Token = "0x4001F91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E")]
		public bool Corruption;

		// Token: 0x04007D1C RID: 32028
		[global::Cpp2ILInjected.Token(Token = "0x4001F92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F")]
		public bool HardMode;

		// Token: 0x04007D1D RID: 32029
		[global::Cpp2ILInjected.Token(Token = "0x4001F93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public string HostName;

		// Token: 0x04007D1E RID: 32030
		[global::Cpp2ILInjected.Token(Token = "0x4001F94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public MPSession SourceSession;
	}
}
