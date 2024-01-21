using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200020B")]
public class MPSession_Dummy : MPSession
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400185F")]
	private MPSessionManager.LobbyState state;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001860")]
	private PlatformUser hostUser;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001861")]
	private MPSessionMetaData MetaData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001862")]
	private bool ActiveInSession;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001863")]
	private string serverAddress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001864")]
	private int serverPort;

	[Cpp2IlInjected.Token(Token = "0x6000EC0")]
	[Cpp2IlInjected.Address(RVA = "0x12DFC08", Offset = "0x12DFC08", VA = "0x12DFC08")]
	public MPSession_Dummy(PlatformUser user, string server, int port, MPSessionManager.LobbyState lobbyState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC1")]
	[Cpp2IlInjected.Address(RVA = "0x12E1314", Offset = "0x12E1314", VA = "0x12E1314")]
	public MPSession_Dummy(PlatformUser user, MPSessionManager.LobbyState lobbyState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC2")]
	[Cpp2IlInjected.Address(RVA = "0x12E13A8", Offset = "0x12E13A8", VA = "0x12E13A8", Slot = "6")]
	public void GetServerConnection(out string server, out int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC3")]
	[Cpp2IlInjected.Address(RVA = "0x12E13BC", Offset = "0x12E13BC", VA = "0x12E13BC", Slot = "4")]
	public PlatformUser GetHost()
	{
		return default(PlatformUser);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC4")]
	[Cpp2IlInjected.Address(RVA = "0x12E13D0", Offset = "0x12E13D0", VA = "0x12E13D0", Slot = "5")]
	public MPSessionManager.LobbyState GetState()
	{
		return default(MPSessionManager.LobbyState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC5")]
	[Cpp2IlInjected.Address(RVA = "0x12E13D8", Offset = "0x12E13D8", VA = "0x12E13D8", Slot = "7")]
	public void SetState(MPSessionManager.LobbyState newState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC6")]
	[Cpp2IlInjected.Address(RVA = "0x12E13E8", Offset = "0x12E13E8", VA = "0x12E13E8", Slot = "12")]
	public void UpdatePlayerCount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC7")]
	[Cpp2IlInjected.Address(RVA = "0x12E14D0", Offset = "0x12E14D0", VA = "0x12E14D0", Slot = "13")]
	public bool CanInvite()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC8")]
	[Cpp2IlInjected.Address(RVA = "0x12E14D8", Offset = "0x12E14D8", VA = "0x12E14D8", Slot = "10")]
	public MPSessionMetaData GetMetaData()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000EC9")]
	[Cpp2IlInjected.Address(RVA = "0x12E14E0", Offset = "0x12E14E0", VA = "0x12E14E0", Slot = "11")]
	public void SetMetaData(MPSessionMetaData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ECA")]
	[Cpp2IlInjected.Address(RVA = "0x12E14E8", Offset = "0x12E14E8", VA = "0x12E14E8", Slot = "9")]
	public void SetClientInSession(bool activeInSession)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ECB")]
	[Cpp2IlInjected.Address(RVA = "0x12E15B0", Offset = "0x12E15B0", VA = "0x12E15B0", Slot = "8")]
	public bool ClientInSession()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ECC")]
	[Cpp2IlInjected.Address(RVA = "0x12E15B8", Offset = "0x12E15B8", VA = "0x12E15B8", Slot = "14")]
	public void Leave(PlatformUser localUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ECD")]
	[Cpp2IlInjected.Address(RVA = "0x12E15E4", Offset = "0x12E15E4", VA = "0x12E15E4", Slot = "15")]
	public void Join(PlatformUser localUser)
	{
	}
}
