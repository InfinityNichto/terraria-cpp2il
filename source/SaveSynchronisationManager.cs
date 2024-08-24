using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Telepathy;

// Token: 0x0200021E RID: 542
[global::Cpp2ILInjected.Token(Token = "0x20002C7")]
public class SaveSynchronisationManager
{
	// Token: 0x06000F3F RID: 3903 RVA: 0x000248BA File Offset: 0x00022ABA
	[global::Cpp2ILInjected.Token(Token = "0x6001073")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46930", Offset = "0xA46930", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public bool AttemptHostConnection(bool isLocalHost)
	{
		throw null;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x000248BD File Offset: 0x00022ABD
	[global::Cpp2ILInjected.Token(Token = "0x6001074")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46A24", Offset = "0xA46A24", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ProcessMessageResponse", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	public void ProcessServerMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		throw null;
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x000248C0 File Offset: 0x00022AC0
	[global::Cpp2ILInjected.Token(Token = "0x6001075")]
	[global::Cpp2ILInjected.Address(RVA = "0xA45554", Offset = "0xA45554", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ProcessMessageResponse", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	public void ProcessClientMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
		throw null;
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x000248C3 File Offset: 0x00022AC3
	[global::Cpp2ILInjected.Token(Token = "0x6001076")]
	[global::Cpp2ILInjected.Address(RVA = "0xA33304", Offset = "0xA33304", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x000248C6 File Offset: 0x00022AC6
	[global::Cpp2ILInjected.Token(Token = "0x6001077")]
	[global::Cpp2ILInjected.Address(RVA = "0xA45468", Offset = "0xA45468", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public bool AttemptClientConnection()
	{
		throw null;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x000248C9 File Offset: 0x00022AC9
	[global::Cpp2ILInjected.Token(Token = "0x6001078")]
	[global::Cpp2ILInjected.Address(RVA = "0xA33320", Offset = "0xA33320", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool IsLookingForConnection()
	{
		throw null;
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x000248CC File Offset: 0x00022ACC
	[global::Cpp2ILInjected.Token(Token = "0x6001079")]
	[global::Cpp2ILInjected.Address(RVA = "0xA330AC", Offset = "0xA330AC", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Status), Member = "DrawStatus", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Restart", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "RefreshFromFileSystem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationBroadcast), Member = "StartBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationFinder), Member = "StartSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Startup()
	{
		throw null;
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x000248CF File Offset: 0x00022ACF
	[global::Cpp2ILInjected.Token(Token = "0x600107A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA331A0", Offset = "0xA331A0", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Status), Member = "DrawStatus", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Restart", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationFinder), Member = "StopSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationBroadcast), Member = "StopBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Stop", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x000248D2 File Offset: 0x00022AD2
	[global::Cpp2ILInjected.Token(Token = "0x600107B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA35B04", Offset = "0xA35B04", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	public void Restart()
	{
		throw null;
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x000248D5 File Offset: 0x00022AD5
	[global::Cpp2ILInjected.Token(Token = "0x600107C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3963C", Offset = "0xA3963C", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = "ServerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Connect", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void Connect(string connectionAddress)
	{
		throw null;
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x000248D8 File Offset: 0x00022AD8
	[global::Cpp2ILInjected.Token(Token = "0x600107D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32FA8", Offset = "0xA32FA8", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationClient), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationHost), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public SaveSynchronisationManager()
	{
		throw null;
	}

	// Token: 0x04001A18 RID: 6680
	[global::Cpp2ILInjected.Token(Token = "0x4001F53")]
	public static SaveSynchronisationManager Instance;

	// Token: 0x04001A19 RID: 6681
	[global::Cpp2ILInjected.Token(Token = "0x4001F54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public SaveSynchronisationState LocalState;

	// Token: 0x04001A1A RID: 6682
	[global::Cpp2ILInjected.Token(Token = "0x4001F55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SaveSynchronisationState RemoteState;

	// Token: 0x04001A1B RID: 6683
	[global::Cpp2ILInjected.Token(Token = "0x4001F56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public SaveSynchronisationClient client;

	// Token: 0x04001A1C RID: 6684
	[global::Cpp2ILInjected.Token(Token = "0x4001F57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public SaveSynchronisationHost server;

	// Token: 0x04001A1D RID: 6685
	[global::Cpp2ILInjected.Token(Token = "0x4001F58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public object Lock;

	// Token: 0x04001A1E RID: 6686
	[global::Cpp2ILInjected.Token(Token = "0x4001F59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public SaveSynchronisationManager.ConnectionState ClientState;

	// Token: 0x04001A1F RID: 6687
	[global::Cpp2ILInjected.Token(Token = "0x4001F5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public SaveSynchronisationManager.ConnectionState HostState;

	// Token: 0x04001A20 RID: 6688
	[global::Cpp2ILInjected.Token(Token = "0x4001F5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool HostIsConnectedToLocal;

	// Token: 0x0200080A RID: 2058
	[global::Cpp2ILInjected.Token(Token = "0x20002C8")]
	public enum ConnectionState
	{
		// Token: 0x04007D06 RID: 32006
		[global::Cpp2ILInjected.Token(Token = "0x4001F5D")]
		Waiting,
		// Token: 0x04007D07 RID: 32007
		[global::Cpp2ILInjected.Token(Token = "0x4001F5E")]
		Connecting,
		// Token: 0x04007D08 RID: 32008
		[global::Cpp2ILInjected.Token(Token = "0x4001F5F")]
		Connected
	}
}
