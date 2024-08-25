using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20002B0")]
public class MPSession_Local : MPSession
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FEB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BE70", Offset = "0xA3BE70", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public MPSession_Local()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FEC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BF24", Offset = "0xA3BF24", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void GetServerConnection(out string server, out int port)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FED")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BF84", Offset = "0xA3BF84", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public PlatformUser GetHost()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FEE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BF90", Offset = "0xA3BF90", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public MPSessionManager.LobbyState GetState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FEF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BF98", Offset = "0xA3BF98", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetState(MPSessionManager.LobbyState newState)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFAC", Offset = "0xA3BFAC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void UpdatePlayerCount()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFB0", Offset = "0xA3BFB0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool CanInvite()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFB8", Offset = "0xA3BFB8", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public MPSessionMetaData GetMetaData()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFC0", Offset = "0xA3BFC0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetMetaData(MPSessionMetaData data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFC8", Offset = "0xA3BFC8", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void SetClientInSession(bool activeInSession)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFE0", Offset = "0xA3BFE0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool ClientInSession()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3BFE8", Offset = "0xA3BFE8", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public void Leave(PlatformUser localUser)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FF7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3C000", Offset = "0xA3C000", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Join(PlatformUser localUser)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001D83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private MPSessionManager.LobbyState state;

	[global::Cpp2ILInjected.Token(Token = "0x4001D84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private PlatformUser hostUser;

	[global::Cpp2ILInjected.Token(Token = "0x4001D85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private MPSessionMetaData MetaData;

	[global::Cpp2ILInjected.Token(Token = "0x4001D86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private bool ActiveInSession;

	[global::Cpp2ILInjected.Token(Token = "0x4001D87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private string serverAddress;

	[global::Cpp2ILInjected.Token(Token = "0x4001D88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private int serverPort;
}
