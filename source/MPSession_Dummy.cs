using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200020A RID: 522
[global::Cpp2ILInjected.Token(Token = "0x20002AF")]
public class MPSession_Dummy : MPSession
{
	// Token: 0x06000EAD RID: 3757 RVA: 0x00024737 File Offset: 0x00022937
	[global::Cpp2ILInjected.Token(Token = "0x6000FDD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B578", Offset = "0xA3B578", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "CreateNewSession", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(MPSessionManager.LobbyState)
	}, ReturnType = typeof(MPSession))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "CreateNewDirectSession", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(MPSessionManager.LobbyState),
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(MPSession))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "FindUserSessions", MemberParameters = new object[] { typeof(PlatformUser[]) }, ReturnType = typeof(MPSession[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MPSession_Dummy(PlatformUser user, string server, int port, MPSessionManager.LobbyState lobbyState)
	{
		throw null;
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x0002473A File Offset: 0x0002293A
	[global::Cpp2ILInjected.Token(Token = "0x6000FDE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BBE0", Offset = "0xA3BBE0", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MPSession_Dummy(PlatformUser user, MPSessionManager.LobbyState lobbyState)
	{
		throw null;
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x0002473D File Offset: 0x0002293D
	[global::Cpp2ILInjected.Token(Token = "0x6000FDF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC70", Offset = "0xA3BC70", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void GetServerConnection(out string server, out int port)
	{
		throw null;
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00024740 File Offset: 0x00022940
	[global::Cpp2ILInjected.Token(Token = "0x6000FE0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC84", Offset = "0xA3BC84", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public PlatformUser GetHost()
	{
		throw null;
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00024743 File Offset: 0x00022943
	[global::Cpp2ILInjected.Token(Token = "0x6000FE1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC90", Offset = "0xA3BC90", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public MPSessionManager.LobbyState GetState()
	{
		throw null;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00024746 File Offset: 0x00022946
	[global::Cpp2ILInjected.Token(Token = "0x6000FE2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC98", Offset = "0xA3BC98", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetState(MPSessionManager.LobbyState newState)
	{
		throw null;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00024749 File Offset: 0x00022949
	[global::Cpp2ILInjected.Token(Token = "0x6000FE3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BCAC", Offset = "0xA3BCAC", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void UpdatePlayerCount()
	{
		throw null;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x0002474C File Offset: 0x0002294C
	[global::Cpp2ILInjected.Token(Token = "0x6000FE4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD64", Offset = "0xA3BD64", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool CanInvite()
	{
		throw null;
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0002474F File Offset: 0x0002294F
	[global::Cpp2ILInjected.Token(Token = "0x6000FE5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD6C", Offset = "0xA3BD6C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public MPSessionMetaData GetMetaData()
	{
		throw null;
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00024752 File Offset: 0x00022952
	[global::Cpp2ILInjected.Token(Token = "0x6000FE6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD74", Offset = "0xA3BD74", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetMetaData(MPSessionMetaData data)
	{
		throw null;
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00024755 File Offset: 0x00022955
	[global::Cpp2ILInjected.Token(Token = "0x6000FE7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD7C", Offset = "0xA3BD7C", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSession_Dummy), Member = "Leave", MemberParameters = new object[] { typeof(PlatformUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void SetClientInSession(bool activeInSession)
	{
		throw null;
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00024758 File Offset: 0x00022958
	[global::Cpp2ILInjected.Token(Token = "0x6000FE8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BE34", Offset = "0xA3BE34", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool ClientInSession()
	{
		throw null;
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x0002475B File Offset: 0x0002295B
	[global::Cpp2ILInjected.Token(Token = "0x6000FE9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BE3C", Offset = "0xA3BE3C", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSession_Dummy), Member = "SetClientInSession", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public void Leave(PlatformUser localUser)
	{
		throw null;
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x0002475E File Offset: 0x0002295E
	[global::Cpp2ILInjected.Token(Token = "0x6000FEA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BE6C", Offset = "0xA3BE6C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Join(PlatformUser localUser)
	{
		throw null;
	}

	// Token: 0x04001856 RID: 6230
	[global::Cpp2ILInjected.Token(Token = "0x4001D7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private MPSessionManager.LobbyState state;

	// Token: 0x04001857 RID: 6231
	[global::Cpp2ILInjected.Token(Token = "0x4001D7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private PlatformUser hostUser;

	// Token: 0x04001858 RID: 6232
	[global::Cpp2ILInjected.Token(Token = "0x4001D7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private MPSessionMetaData MetaData;

	// Token: 0x04001859 RID: 6233
	[global::Cpp2ILInjected.Token(Token = "0x4001D80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool ActiveInSession;

	// Token: 0x0400185A RID: 6234
	[global::Cpp2ILInjected.Token(Token = "0x4001D81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private string serverAddress;

	// Token: 0x0400185B RID: 6235
	[global::Cpp2ILInjected.Token(Token = "0x4001D82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private int serverPort;
}
