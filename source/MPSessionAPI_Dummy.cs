using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000209 RID: 521
[global::Cpp2ILInjected.Token(Token = "0x20002AE")]
public class MPSessionAPI_Dummy : MPSessionAPI
{
	// Token: 0x06000EA7 RID: 3751 RVA: 0x00024725 File Offset: 0x00022925
	[global::Cpp2ILInjected.Token(Token = "0x6000FD7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B4E0", Offset = "0xA3B4E0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft)
	{
		throw null;
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00024728 File Offset: 0x00022928
	[global::Cpp2ILInjected.Token(Token = "0x6000FD8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B4E4", Offset = "0xA3B4E4", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSession_Dummy), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(string),
		typeof(int),
		typeof(MPSessionManager.LobbyState)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		throw null;
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x0002472B File Offset: 0x0002292B
	[global::Cpp2ILInjected.Token(Token = "0x6000FD9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B620", Offset = "0xA3B620", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSession_Dummy), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(string),
		typeof(int),
		typeof(MPSessionManager.LobbyState)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		throw null;
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x0002472E File Offset: 0x0002292E
	[global::Cpp2ILInjected.Token(Token = "0x6000FDA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B6A8", Offset = "0xA3B6A8", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSession_Dummy), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(string),
		typeof(int),
		typeof(MPSessionManager.LobbyState)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public MPSession[] FindUserSessions(PlatformUser[] users)
	{
		throw null;
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00024731 File Offset: 0x00022931
	[global::Cpp2ILInjected.Token(Token = "0x6000FDB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B8D0", Offset = "0xA3B8D0", Length = "0x298")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionAPI_Dummy), Member = "CreateNewDirectSession", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(MPSessionManager.LobbyState),
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(MPSession))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00024734 File Offset: 0x00022934
	[global::Cpp2ILInjected.Token(Token = "0x6000FDC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BBD8", Offset = "0xA3BBD8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public MPSessionAPI_Dummy()
	{
		throw null;
	}
}
