using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000210")]
public class MPSessionManager
{
	[Cpp2IlInjected.Token(Token = "0x20007FD")]
	public enum LobbyState
	{
		[Cpp2IlInjected.Token(Token = "0x4007CDF")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007CE0")]
		MenuLobby,
		[Cpp2IlInjected.Token(Token = "0x4007CE1")]
		InProgress,
		[Cpp2IlInjected.Token(Token = "0x4007CE2")]
		Shutdown
	}

	[Cpp2IlInjected.Token(Token = "0x400186B")]
	public static MPSessionManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400186C")]
	private MPSession sessionJoining;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400186D")]
	public MPSession CurrentSession;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400186E")]
	public MPSession PendingSession;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400186F")]
	public MPSessionAPI platformAPI;

	[Cpp2IlInjected.Token(Token = "0x6000EED")]
	[Cpp2IlInjected.Address(RVA = "0x12DCA6C", Offset = "0x12DCA6C", VA = "0x12DCA6C")]
	public static MPSessionManager Create()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EEE")]
	[Cpp2IlInjected.Address(RVA = "0x12E036C", Offset = "0x12E036C", VA = "0x12E036C")]
	public MPSessionManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EEF")]
	[Cpp2IlInjected.Address(RVA = "0x12E03E0", Offset = "0x12E03E0", VA = "0x12E03E0")]
	private void SessionInviteJoined(MPSession newSession)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF0")]
	[Cpp2IlInjected.Address(RVA = "0x12E03E8", Offset = "0x12E03E8", VA = "0x12E03E8")]
	public MPSession[] FindUserSessions(PlatformUser[] users)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF1")]
	[Cpp2IlInjected.Address(RVA = "0x12E04B0", Offset = "0x12E04B0", VA = "0x12E04B0")]
	public MPSession CreateNewSession(PlatformUser hostUser, LobbyState state)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF2")]
	[Cpp2IlInjected.Address(RVA = "0x12E0594", Offset = "0x12E0594", VA = "0x12E0594")]
	public MPSession CreateNewDirectSession(PlatformUser hostUser, LobbyState state, string serverAddress, int serverPort)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF3")]
	[Cpp2IlInjected.Address(RVA = "0x12E0698", Offset = "0x12E0698", VA = "0x12E0698")]
	public void SetPendingSession(MPSession session)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF4")]
	[Cpp2IlInjected.Address(RVA = "0x12E06A0", Offset = "0x12E06A0", VA = "0x12E06A0")]
	private void CheckShutdownSwitchMPMenus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF5")]
	[Cpp2IlInjected.Address(RVA = "0x12E06A4", Offset = "0x12E06A4", VA = "0x12E06A4")]
	public void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF6")]
	[Cpp2IlInjected.Address(RVA = "0x12E0D08", Offset = "0x12E0D08", VA = "0x12E0D08")]
	public void PlayerSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF7")]
	[Cpp2IlInjected.Address(RVA = "0x12E1008", Offset = "0x12E1008", VA = "0x12E1008")]
	public void CancelPending()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EF8")]
	[Cpp2IlInjected.Address(RVA = "0x12E1110", Offset = "0x12E1110", VA = "0x12E1110")]
	public void OpenInviteOverlay()
	{
	}
}
