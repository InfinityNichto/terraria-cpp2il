using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200020D")]
public interface MPSession
{
	[Cpp2IlInjected.Token(Token = "0x6000EDB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PlatformUser GetHost();

	[Cpp2IlInjected.Token(Token = "0x6000EDC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPSessionManager.LobbyState GetState();

	[Cpp2IlInjected.Token(Token = "0x6000EDD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GetServerConnection(out string server, out int port);

	[Cpp2IlInjected.Token(Token = "0x6000EDE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void SetState(MPSessionManager.LobbyState newState);

	[Cpp2IlInjected.Token(Token = "0x6000EDF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ClientInSession();

	[Cpp2IlInjected.Token(Token = "0x6000EE0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetClientInSession(bool activeInSession);

	[Cpp2IlInjected.Token(Token = "0x6000EE1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MPSessionMetaData GetMetaData();

	[Cpp2IlInjected.Token(Token = "0x6000EE2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void SetMetaData(MPSessionMetaData data);

	[Cpp2IlInjected.Token(Token = "0x6000EE3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void UpdatePlayerCount();

	[Cpp2IlInjected.Token(Token = "0x6000EE4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CanInvite();

	[Cpp2IlInjected.Token(Token = "0x6000EE5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void Leave(PlatformUser localUser);

	[Cpp2IlInjected.Token(Token = "0x6000EE6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void Join(PlatformUser localUser);
}
