using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.Audio;
using Terraria.IO;

// Token: 0x0200020F RID: 527
[global::Cpp2ILInjected.Token(Token = "0x20002B4")]
public class MPSessionManager
{
	// Token: 0x06000EDA RID: 3802 RVA: 0x0002478B File Offset: 0x0002298B
	[global::Cpp2ILInjected.Token(Token = "0x600100A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C00C", Offset = "0xA3C00C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static MPSessionManager Create()
	{
		throw null;
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x0002478E File Offset: 0x0002298E
	[global::Cpp2ILInjected.Token(Token = "0x600100B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C070", Offset = "0xA3C070", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "Create", ReturnType = typeof(MPSessionManager))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MPSessionManager()
	{
		throw null;
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00024791 File Offset: 0x00022991
	[global::Cpp2ILInjected.Token(Token = "0x600100C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C0D4", Offset = "0xA3C0D4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void SessionInviteJoined(MPSession newSession)
	{
		throw null;
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00024794 File Offset: 0x00022994
	[global::Cpp2ILInjected.Token(Token = "0x600100D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C0DC", Offset = "0xA3C0DC", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerAutoFinder), Member = "LookForFriendPlatformGames", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public MPSession[] FindUserSessions(PlatformUser[] users)
	{
		throw null;
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00024797 File Offset: 0x00022997
	[global::Cpp2ILInjected.Token(Token = "0x600100E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C188", Offset = "0xA3C188", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "HostServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		throw null;
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x0002479A File Offset: 0x0002299A
	[global::Cpp2ILInjected.Token(Token = "0x600100F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C24C", Offset = "0xA3C24C", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "JoinServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		throw null;
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0002479D File Offset: 0x0002299D
	[global::Cpp2ILInjected.Token(Token = "0x6001010")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C328", Offset = "0xA3C328", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetPendingSession(MPSession session)
	{
		throw null;
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x000247A0 File Offset: 0x000229A0
	[global::Cpp2ILInjected.Token(Token = "0x6001011")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C330", Offset = "0xA3C330", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void CheckShutdownSwitchMPMenus()
	{
		throw null;
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x000247A3 File Offset: 0x000229A3
	[global::Cpp2ILInjected.Token(Token = "0x6001012")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C334", Offset = "0xA3C334", Length = "0x500")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_menuMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "IsThreadRunning", MemberParameters = new object[] { typeof(ManagedThread) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "TerminateThread", MemberParameters = new object[] { typeof(ManagedThread) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ingameOptionsWindow", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettings), Member = "ShutdownUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SaveAndQuit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "Hide", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMainMenu), Member = "SelectMultiplayer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINetPlayStatusMenu), Member = "Quit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
	public void UpdateUI()
	{
		throw null;
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x000247A6 File Offset: 0x000229A6
	[global::Cpp2ILInjected.Token(Token = "0x6001013")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C834", Offset = "0xA3C834", Length = "0x258")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SelectPlayer", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "StartNewServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_spawnTileY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "JoinLocalWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public void PlayerSelected()
	{
		throw null;
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x000247A9 File Offset: 0x000229A9
	[global::Cpp2ILInjected.Token(Token = "0x6001014")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3CA8C", Offset = "0xA3CA8C", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerWaitingHost), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CancelPending()
	{
		throw null;
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x000247AC File Offset: 0x000229AC
	[global::Cpp2ILInjected.Token(Token = "0x6001015")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3CB68", Offset = "0xA3CB68", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void OpenInviteOverlay()
	{
		throw null;
	}

	// Token: 0x04001862 RID: 6242
	[global::Cpp2ILInjected.Token(Token = "0x4001D89")]
	public static MPSessionManager Instance;

	// Token: 0x04001863 RID: 6243
	[global::Cpp2ILInjected.Token(Token = "0x4001D8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private MPSession sessionJoining;

	// Token: 0x04001864 RID: 6244
	[global::Cpp2ILInjected.Token(Token = "0x4001D8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public MPSession CurrentSession;

	// Token: 0x04001865 RID: 6245
	[global::Cpp2ILInjected.Token(Token = "0x4001D8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public MPSession PendingSession;

	// Token: 0x04001866 RID: 6246
	[global::Cpp2ILInjected.Token(Token = "0x4001D8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public MPSessionAPI platformAPI;

	// Token: 0x02000806 RID: 2054
	[global::Cpp2ILInjected.Token(Token = "0x20002B5")]
	public enum LobbyState
	{
		// Token: 0x04007CF2 RID: 31986
		[global::Cpp2ILInjected.Token(Token = "0x4001D8F")]
		None,
		// Token: 0x04007CF3 RID: 31987
		[global::Cpp2ILInjected.Token(Token = "0x4001D90")]
		MenuLobby,
		// Token: 0x04007CF4 RID: 31988
		[global::Cpp2ILInjected.Token(Token = "0x4001D91")]
		InProgress,
		// Token: 0x04007CF5 RID: 31989
		[global::Cpp2ILInjected.Token(Token = "0x4001D92")]
		Shutdown
	}
}
