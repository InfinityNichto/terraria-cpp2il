using System;
using Cpp2ILInjected;

// Token: 0x0200020C RID: 524
[global::Cpp2ILInjected.Token(Token = "0x20002B1")]
public interface MPSession
{
	// Token: 0x06000EC8 RID: 3784
	[global::Cpp2ILInjected.Token(Token = "0x6000FF8")]
	PlatformUser GetHost();

	// Token: 0x06000EC9 RID: 3785
	[global::Cpp2ILInjected.Token(Token = "0x6000FF9")]
	MPSessionManager.LobbyState GetState();

	// Token: 0x06000ECA RID: 3786
	[global::Cpp2ILInjected.Token(Token = "0x6000FFA")]
	void GetServerConnection(out string server, out int port);

	// Token: 0x06000ECB RID: 3787
	[global::Cpp2ILInjected.Token(Token = "0x6000FFB")]
	void SetState(MPSessionManager.LobbyState newState);

	// Token: 0x06000ECC RID: 3788
	[global::Cpp2ILInjected.Token(Token = "0x6000FFC")]
	bool ClientInSession();

	// Token: 0x06000ECD RID: 3789
	[global::Cpp2ILInjected.Token(Token = "0x6000FFD")]
	void SetClientInSession(bool activeInSession);

	// Token: 0x06000ECE RID: 3790
	[global::Cpp2ILInjected.Token(Token = "0x6000FFE")]
	MPSessionMetaData GetMetaData();

	// Token: 0x06000ECF RID: 3791
	[global::Cpp2ILInjected.Token(Token = "0x6000FFF")]
	void SetMetaData(MPSessionMetaData data);

	// Token: 0x06000ED0 RID: 3792
	[global::Cpp2ILInjected.Token(Token = "0x6001000")]
	void UpdatePlayerCount();

	// Token: 0x06000ED1 RID: 3793
	[global::Cpp2ILInjected.Token(Token = "0x6001001")]
	bool CanInvite();

	// Token: 0x06000ED2 RID: 3794
	[global::Cpp2ILInjected.Token(Token = "0x6001002")]
	void Leave(PlatformUser localUser);

	// Token: 0x06000ED3 RID: 3795
	[global::Cpp2ILInjected.Token(Token = "0x6001003")]
	void Join(PlatformUser localUser);
}
