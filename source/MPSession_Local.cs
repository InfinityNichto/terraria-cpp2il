using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200020C")]
public class MPSession_Local : MPSession
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001865")]
	private MPSessionManager.LobbyState state;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001866")]
	private PlatformUser hostUser;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001867")]
	private MPSessionMetaData MetaData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001868")]
	private bool ActiveInSession;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001869")]
	private string serverAddress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400186A")]
	private int serverPort;

	[Cpp2IlInjected.Token(Token = "0x6000ECE")]
	[Cpp2IlInjected.Address(RVA = "0x12DD9C0", Offset = "0x12DD9C0", VA = "0x12DD9C0")]
	public MPSession_Local()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ECF")]
	[Cpp2IlInjected.Address(RVA = "0x12E15E8", Offset = "0x12E15E8", VA = "0x12E15E8", Slot = "6")]
	public void GetServerConnection(out string server, out int port)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED0")]
	[Cpp2IlInjected.Address(RVA = "0x12E1650", Offset = "0x12E1650", VA = "0x12E1650", Slot = "4")]
	public PlatformUser GetHost()
	{
		return default(PlatformUser);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED1")]
	[Cpp2IlInjected.Address(RVA = "0x12E1664", Offset = "0x12E1664", VA = "0x12E1664", Slot = "5")]
	public MPSessionManager.LobbyState GetState()
	{
		return default(MPSessionManager.LobbyState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED2")]
	[Cpp2IlInjected.Address(RVA = "0x12E166C", Offset = "0x12E166C", VA = "0x12E166C", Slot = "7")]
	public void SetState(MPSessionManager.LobbyState newState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED3")]
	[Cpp2IlInjected.Address(RVA = "0x12E167C", Offset = "0x12E167C", VA = "0x12E167C", Slot = "12")]
	public void UpdatePlayerCount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED4")]
	[Cpp2IlInjected.Address(RVA = "0x12E1680", Offset = "0x12E1680", VA = "0x12E1680", Slot = "13")]
	public bool CanInvite()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED5")]
	[Cpp2IlInjected.Address(RVA = "0x12E1688", Offset = "0x12E1688", VA = "0x12E1688", Slot = "10")]
	public MPSessionMetaData GetMetaData()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED6")]
	[Cpp2IlInjected.Address(RVA = "0x12E1690", Offset = "0x12E1690", VA = "0x12E1690", Slot = "11")]
	public void SetMetaData(MPSessionMetaData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED7")]
	[Cpp2IlInjected.Address(RVA = "0x12E1698", Offset = "0x12E1698", VA = "0x12E1698", Slot = "9")]
	public void SetClientInSession(bool activeInSession)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED8")]
	[Cpp2IlInjected.Address(RVA = "0x12E16B0", Offset = "0x12E16B0", VA = "0x12E16B0", Slot = "8")]
	public bool ClientInSession()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ED9")]
	[Cpp2IlInjected.Address(RVA = "0x12E16B8", Offset = "0x12E16B8", VA = "0x12E16B8", Slot = "14")]
	public void Leave(PlatformUser localUser)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EDA")]
	[Cpp2IlInjected.Address(RVA = "0x12E16D4", Offset = "0x12E16D4", VA = "0x12E16D4", Slot = "15")]
	public void Join(PlatformUser localUser)
	{
	}
}
