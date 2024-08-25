using System;
using Cpp2ILInjected;

[global::Cpp2ILInjected.Token(Token = "0x20002B2")]
public interface MPSessionAPI
{
	[global::Cpp2ILInjected.Token(Token = "0x6001004")]
	void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft);

	[global::Cpp2ILInjected.Token(Token = "0x6001005")]
	MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state);

	[global::Cpp2ILInjected.Token(Token = "0x6001006")]
	MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort);

	[global::Cpp2ILInjected.Token(Token = "0x6001007")]
	MPSession[] FindUserSessions(PlatformUser[] users);

	[global::Cpp2ILInjected.Token(Token = "0x6001008")]
	void Update();
}
