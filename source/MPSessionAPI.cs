using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200020E")]
public interface MPSessionAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000EE7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft);

	[Cpp2IlInjected.Token(Token = "0x6000EE8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state);

	[Cpp2IlInjected.Token(Token = "0x6000EE9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort);

	[Cpp2IlInjected.Token(Token = "0x6000EEA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MPSession[] FindUserSessions(PlatformUser[] users);

	[Cpp2IlInjected.Token(Token = "0x6000EEB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Update();
}
