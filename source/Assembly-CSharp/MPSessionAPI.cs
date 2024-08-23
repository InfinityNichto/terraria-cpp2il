using System;
using Cpp2ILInjected;

// Token: 0x0200020D RID: 525
[global::Cpp2ILInjected.Token(Token = "0x20002B2")]
public interface MPSessionAPI
{
	// Token: 0x06000ED4 RID: 3796
	[global::Cpp2ILInjected.Token(Token = "0x6001004")]
	void OpenInviteOverlay(MPSession session, PlatformUser user, int numSlotsLeft);

	// Token: 0x06000ED5 RID: 3797
	[global::Cpp2ILInjected.Token(Token = "0x6001005")]
	MPSession CreateNewSession(PlatformUser hostUser, MPSessionManager.LobbyState state);

	// Token: 0x06000ED6 RID: 3798
	[global::Cpp2ILInjected.Token(Token = "0x6001006")]
	MPSession CreateNewDirectSession(PlatformUser hostUser, MPSessionManager.LobbyState state, string serverAddress, int serverPort);

	// Token: 0x06000ED7 RID: 3799
	[global::Cpp2ILInjected.Token(Token = "0x6001007")]
	MPSession[] FindUserSessions(PlatformUser[] users);

	// Token: 0x06000ED8 RID: 3800
	[global::Cpp2ILInjected.Token(Token = "0x6001008")]
	void Update();
}
