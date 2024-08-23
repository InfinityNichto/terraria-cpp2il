using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Net;

// Token: 0x0200021C RID: 540
[global::Cpp2ILInjected.Token(Token = "0x20002C4")]
public static class SaveSynchronisationFinder
{
	// Token: 0x06000F33 RID: 3891 RVA: 0x00024896 File Offset: 0x00022A96
	[global::Cpp2ILInjected.Token(Token = "0x6001066")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4565C", Offset = "0xA4565C", Length = "0x8F0")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "ReceiveAsync", ReturnType = typeof(Task<UdpReceiveResult>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<UdpReceiveResult>), Member = "get_Result", ReturnType = "TResult")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpAddress), Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
	private static void BroadcastRecieveThread()
	{
		throw null;
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00024899 File Offset: 0x00022A99
	[global::Cpp2ILInjected.Token(Token = "0x6001067")]
	[global::Cpp2ILInjected.Address(RVA = "0xA389A4", Offset = "0xA389A4", Length = "0x3D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = "RefreshServers", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public static void UpdateResults()
	{
		throw null;
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x0002489C File Offset: 0x00022A9C
	[global::Cpp2ILInjected.Token(Token = "0x6001068")]
	[global::Cpp2ILInjected.Address(RVA = "0xA45F54", Offset = "0xA45F54", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationFinder), Member = "StopSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static void StartSearching()
	{
		throw null;
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0002489F File Offset: 0x00022A9F
	[global::Cpp2ILInjected.Token(Token = "0x6001069")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4605C", Offset = "0xA4605C", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationFinder), Member = "StartSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Abort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void StopSearching()
	{
		throw null;
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x000248A2 File Offset: 0x00022AA2
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600106A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46120", Offset = "0xA46120", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	static SaveSynchronisationFinder()
	{
		throw null;
	}

	// Token: 0x04001A0F RID: 6671
	[global::Cpp2ILInjected.Token(Token = "0x4001F44")]
	private static List<SaveSynchronisationFinder.SearchServerResult> TempResults;

	// Token: 0x04001A10 RID: 6672
	[global::Cpp2ILInjected.Token(Token = "0x4001F45")]
	private static DateTime LastListUpdate;

	// Token: 0x04001A11 RID: 6673
	[global::Cpp2ILInjected.Token(Token = "0x4001F46")]
	public static List<SaveSynchronisationFinder.SearchServerResult> Results;

	// Token: 0x04001A12 RID: 6674
	[global::Cpp2ILInjected.Token(Token = "0x4001F47")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	// Token: 0x04001A13 RID: 6675
	[global::Cpp2ILInjected.Token(Token = "0x4001F48")]
	private static UdpClient broadcastPort;

	// Token: 0x04001A14 RID: 6676
	[global::Cpp2ILInjected.Token(Token = "0x4001F49")]
	private static Thread broadcastThread;

	// Token: 0x02000809 RID: 2057
	[global::Cpp2ILInjected.Token(Token = "0x20002C5")]
	public class SearchServerResult
	{
		// Token: 0x06004906 RID: 18694 RVA: 0x0002EF43 File Offset: 0x0002D143
		[global::Cpp2ILInjected.Token(Token = "0x600106B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA45F4C", Offset = "0xA45F4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SearchServerResult()
		{
			throw null;
		}

		// Token: 0x04007CFF RID: 31999
		[global::Cpp2ILInjected.Token(Token = "0x4001F4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public IPAddress ServerAddress;

		// Token: 0x04007D00 RID: 32000
		[global::Cpp2ILInjected.Token(Token = "0x4001F4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string HostName;

		// Token: 0x04007D01 RID: 32001
		[global::Cpp2ILInjected.Token(Token = "0x4001F4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public DrPlatform.DrPlatformType Platform;

		// Token: 0x04007D02 RID: 32002
		[global::Cpp2ILInjected.Token(Token = "0x4001F4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int PlayerFileCount;

		// Token: 0x04007D03 RID: 32003
		[global::Cpp2ILInjected.Token(Token = "0x4001F4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int WorldFileCount;

		// Token: 0x04007D04 RID: 32004
		[global::Cpp2ILInjected.Token(Token = "0x4001F4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public DateTime LastRecieved;
	}
}
