using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.IO;
using Terraria.WorldBuilding;

// Token: 0x02000041 RID: 65
[global::Cpp2ILInjected.Token(Token = "0x2000066")]
public static class ThreadManager
{
	// Token: 0x06000188 RID: 392 RVA: 0x00022010 File Offset: 0x00020210
	[global::Cpp2ILInjected.Token(Token = "0x600021B")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B6D8", Offset = "0x70B6D8", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(FileManager),
		typeof(FileAPI),
		typeof(bool),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "ResyncFiles", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RunDedServ", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartTcpClient", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = "Run", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static ManagedThread Run(ParameterizedThreadStart callBack, object state)
	{
		throw null;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00022013 File Offset: 0x00020213
	[global::Cpp2ILInjected.Token(Token = "0x600021C")]
	[global::Cpp2ILInjected.Address(RVA = "0x7021EC", Offset = "0x7021EC", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationBroadcast), Member = "StartBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "StartSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "serverLoadWorld", ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = "Run", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static ManagedThread Run(ThreadStart callBack)
	{
		throw null;
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00022016 File Offset: 0x00020216
	[global::Cpp2ILInjected.Token(Token = "0x600021D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B7DC", Offset = "0x70B7DC", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "JoinLocalWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "saveAndPlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "saveToonWhilePlaying", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = "Run", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static ManagedThread RunForUser(ParameterizedThreadStart callBack, object state, LocalUser user)
	{
		throw null;
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00022019 File Offset: 0x00020219
	[global::Cpp2ILInjected.Token(Token = "0x600021E")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B920", Offset = "0x70B920", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = "Run", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static ManagedThread RunForUser(ThreadStart callBack, LocalUser user)
	{
		throw null;
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0002201C File Offset: 0x0002021C
	[global::Cpp2ILInjected.Token(Token = "0x600021F")]
	[global::Cpp2ILInjected.Address(RVA = "0x70BA54", Offset = "0x70BA54", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "Quit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "HandleNetworkLost", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CreateNewWorld", MemberParameters = new object[] { typeof(GenerationProgress) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SaveAndQuit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StartHardmode", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "RenameWorldUsingLoadAndSave", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = "RunCritical", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static ManagedThread RunForUserCritical(ParameterizedThreadStart callBack, object state, LocalUser user)
	{
		throw null;
	}

	// Token: 0x0600018D RID: 397 RVA: 0x0002201F File Offset: 0x0002021F
	[global::Cpp2ILInjected.Token(Token = "0x6000220")]
	[global::Cpp2ILInjected.Address(RVA = "0x70BB98", Offset = "0x70BB98", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = "RestartThread", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManagedThread), Member = "RunCritical", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static ManagedThread RunCritical(ThreadStart callBack)
	{
		throw null;
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00022022 File Offset: 0x00020222
	[global::Cpp2ILInjected.Token(Token = "0x6000221")]
	[global::Cpp2ILInjected.Address(RVA = "0x70BC94", Offset = "0x70BC94", Length = "0x278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static void Update()
	{
		throw null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00022025 File Offset: 0x00020225
	[global::Cpp2ILInjected.Token(Token = "0x6000222")]
	[global::Cpp2ILInjected.Address(RVA = "0x70BF0C", Offset = "0x70BF0C", Length = "0x330")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "SwitchPrimaryUser", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UserSignedOut", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "LocalUserQuit", MemberParameters = new object[] { typeof(LocalUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public static void TerminateUserThreads(LocalUser user)
	{
		throw null;
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00022028 File Offset: 0x00020228
	[global::Cpp2ILInjected.Token(Token = "0x6000223")]
	[global::Cpp2ILInjected.Address(RVA = "0x70C23C", Offset = "0x70C23C", Length = "0x210")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CacheFileManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "UpdateUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationBroadcast), Member = "StopBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "StopSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StopBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public static void TerminateThread(ManagedThread thread)
	{
		throw null;
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0002202B File Offset: 0x0002022B
	[global::Cpp2ILInjected.Token(Token = "0x6000224")]
	[global::Cpp2ILInjected.Address(RVA = "0x70C44C", Offset = "0x70C44C", Length = "0x240")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public static void TerminateThreadAndWait(ManagedThread thread)
	{
		throw null;
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0002202E File Offset: 0x0002022E
	[global::Cpp2ILInjected.Token(Token = "0x6000225")]
	[global::Cpp2ILInjected.Address(RVA = "0x70C68C", Offset = "0x70C68C", Length = "0x384")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Abort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public static void TerminateAll()
	{
		throw null;
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00022031 File Offset: 0x00020231
	[global::Cpp2ILInjected.Token(Token = "0x6000226")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CA10", Offset = "0x70CA10", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "UpdateUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static bool IsThreadRunning(ManagedThread thread)
	{
		throw null;
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00022034 File Offset: 0x00020234
	[global::Cpp2ILInjected.Token(Token = "0x6000227")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CA28", Offset = "0x70CA28", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationBroadcast), Member = "BroadcastThread", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "BroadcastRecieveThread", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "LookForFriendPlatformGames", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "BroadcastThread", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "worldGenCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenerator), Member = "GenerateWorld", MemberParameters = new object[] { typeof(GenerationProgress) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static void CheckThreadTerminiate()
	{
		throw null;
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00022037 File Offset: 0x00020237
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000228")]
	[global::Cpp2ILInjected.Address(RVA = "0x70CC08", Offset = "0x70CC08", Length = "0x130")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	static ThreadManager()
	{
		throw null;
	}

	// Token: 0x0400010D RID: 269
	[global::Cpp2ILInjected.Token(Token = "0x4000200")]
	private static object LockObject;

	// Token: 0x0400010E RID: 270
	[global::Cpp2ILInjected.Token(Token = "0x4000201")]
	private static Dictionary<ManagedThread, LocalUser> ThreadUser;

	// Token: 0x0400010F RID: 271
	[global::Cpp2ILInjected.Token(Token = "0x4000202")]
	private static List<ManagedThread> ActiveThreads;

	// Token: 0x04000110 RID: 272
	[global::Cpp2ILInjected.Token(Token = "0x4000203")]
	private static List<ManagedThread> ThreadsToShutdown;
}
