using System;
using Cpp2ILInjected;

[global::Cpp2ILInjected.Token(Token = "0x20002B1")]
public interface MPSession
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FF8")]
	PlatformUser GetHost();

	[global::Cpp2ILInjected.Token(Token = "0x6000FF9")]
	MPSessionManager.LobbyState GetState();

	[global::Cpp2ILInjected.Token(Token = "0x6000FFA")]
	void GetServerConnection(out string server, out int port);

	[global::Cpp2ILInjected.Token(Token = "0x6000FFB")]
	void SetState(MPSessionManager.LobbyState newState);

	[global::Cpp2ILInjected.Token(Token = "0x6000FFC")]
	bool ClientInSession();

	[global::Cpp2ILInjected.Token(Token = "0x6000FFD")]
	void SetClientInSession(bool activeInSession);

	[global::Cpp2ILInjected.Token(Token = "0x6000FFE")]
	MPSessionMetaData GetMetaData();

	[global::Cpp2ILInjected.Token(Token = "0x6000FFF")]
	void SetMetaData(MPSessionMetaData data);

	[global::Cpp2ILInjected.Token(Token = "0x6001000")]
	void UpdatePlayerCount();

	[global::Cpp2ILInjected.Token(Token = "0x6001001")]
	bool CanInvite();

	[global::Cpp2ILInjected.Token(Token = "0x6001002")]
	void Leave(PlatformUser localUser);

	[global::Cpp2ILInjected.Token(Token = "0x6001003")]
	void Join(PlatformUser localUser);
}
