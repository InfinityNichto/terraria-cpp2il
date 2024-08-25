using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20002AF")]
public class MPSession_Dummy : MPSession
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000FDE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BBE0", Offset = "0xA3BBE0", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MPSession_Dummy(PlatformUser user, MPSessionManager.LobbyState lobbyState)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FDF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC70", Offset = "0xA3BC70", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void GetServerConnection(out string server, out int port)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC84", Offset = "0xA3BC84", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public PlatformUser GetHost()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC90", Offset = "0xA3BC90", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public MPSessionManager.LobbyState GetState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BC98", Offset = "0xA3BC98", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetState(MPSessionManager.LobbyState newState)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BCAC", Offset = "0xA3BCAC", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void UpdatePlayerCount()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD64", Offset = "0xA3BD64", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool CanInvite()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD6C", Offset = "0xA3BD6C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public MPSessionMetaData GetMetaData()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FE6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BD74", Offset = "0xA3BD74", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetMetaData(MPSessionMetaData data)
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6000FE8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BE34", Offset = "0xA3BE34", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool ClientInSession()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6000FEA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BE6C", Offset = "0xA3BE6C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Join(PlatformUser localUser)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001D7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private MPSessionManager.LobbyState state;

	[global::Cpp2ILInjected.Token(Token = "0x4001D7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private PlatformUser hostUser;

	[global::Cpp2ILInjected.Token(Token = "0x4001D7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private MPSessionMetaData MetaData;

	[global::Cpp2ILInjected.Token(Token = "0x4001D80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool ActiveInSession;

	[global::Cpp2ILInjected.Token(Token = "0x4001D81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private string serverAddress;

	[global::Cpp2ILInjected.Token(Token = "0x4001D82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private int serverPort;
}
