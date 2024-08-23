using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200021A RID: 538
[global::Cpp2ILInjected.Token(Token = "0x20002C2")]
public static class SaveSynchronisationBroadcast
{
	// Token: 0x06000F29 RID: 3881 RVA: 0x00024878 File Offset: 0x00022A78
	[global::Cpp2ILInjected.Token(Token = "0x600105C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44098", Offset = "0xA44098", Length = "0x6F8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(IPAddress),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "set_EnableBroadcast", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "CheckThreadTerminiate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "Send", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int),
		typeof(IPEndPoint)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
	private static void BroadcastThread()
	{
		throw null;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0002487B File Offset: 0x00022A7B
	[global::Cpp2ILInjected.Token(Token = "0x600105D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44790", Offset = "0xA44790", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationBroadcast), Member = "StopBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "Run", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void StartBroadCasting()
	{
		throw null;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x0002487E File Offset: 0x00022A7E
	[global::Cpp2ILInjected.Token(Token = "0x600105E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44868", Offset = "0xA44868", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationBroadcast), Member = "StartBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "TerminateThread", MemberParameters = new object[] { typeof(ManagedThread) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UdpClient), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void StopBroadCasting()
	{
		throw null;
	}

	// Token: 0x04001A0B RID: 6667
	[global::Cpp2ILInjected.Token(Token = "0x4001F40")]
	private static UdpClient BroadcastClient;

	// Token: 0x04001A0C RID: 6668
	[global::Cpp2ILInjected.Token(Token = "0x4001F41")]
	private static ManagedThread broadcastThread;
}
