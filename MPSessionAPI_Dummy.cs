using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200020A")]
public class MPSessionAPI_Dummy : MPSessionAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000EBA")]
	[Cpp2IlInjected.Address(RVA = "0x12DFB6C", Offset = "0x12DFB6C", VA = "0x12DFB6C", Slot = "4")]
	public void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EBB")]
	[Cpp2IlInjected.Address(RVA = "0x12DFB70", Offset = "0x12DFB70", VA = "0x12DFB70", Slot = "5")]
	public MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EBC")]
	[Cpp2IlInjected.Address(RVA = "0x12DFCB8", Offset = "0x12DFCB8", VA = "0x12DFCB8", Slot = "6")]
	public MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EBD")]
	[Cpp2IlInjected.Address(RVA = "0x12DFD48", Offset = "0x12DFD48", VA = "0x12DFD48", Slot = "7")]
	public MPSession[] FindUserSessions(PlatformUser[] users)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EBE")]
	[Cpp2IlInjected.Address(RVA = "0x12DFFA4", Offset = "0x12DFFA4", VA = "0x12DFFA4", Slot = "8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EBF")]
	[Cpp2IlInjected.Address(RVA = "0x12E035C", Offset = "0x12E035C", VA = "0x12E035C")]
	public MPSessionAPI_Dummy()
	{
	}
}
