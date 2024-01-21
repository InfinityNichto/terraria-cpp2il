using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200021F")]
public class SaveSynchronisationManager
{
	[Cpp2IlInjected.Token(Token = "0x2000801")]
	public enum ConnectionState
	{
		[Cpp2IlInjected.Token(Token = "0x4007CF3")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4007CF4")]
		Connecting,
		[Cpp2IlInjected.Token(Token = "0x4007CF5")]
		Connected
	}

	[Cpp2IlInjected.Token(Token = "0x4001A21")]
	public static SaveSynchronisationManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A22")]
	public SaveSynchronisationState LocalState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A23")]
	public SaveSynchronisationState RemoteState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A24")]
	public SaveSynchronisationClient client;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001A25")]
	public SaveSynchronisationHost server;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001A26")]
	public object Lock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001A27")]
	public ConnectionState ClientState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001A28")]
	public ConnectionState HostState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001A29")]
	public bool HostIsConnectedToLocal;

	[Cpp2IlInjected.Token(Token = "0x6000F55")]
	[Cpp2IlInjected.Address(RVA = "0xF9FE0C", Offset = "0xF9FE0C", VA = "0xF9FE0C")]
	public bool AttemptHostConnection(bool isLocalHost)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F56")]
	[Cpp2IlInjected.Address(RVA = "0xF9FEE8", Offset = "0xF9FEE8", VA = "0xF9FEE8")]
	public void ProcessServerMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F57")]
	[Cpp2IlInjected.Address(RVA = "0xF9DF04", Offset = "0xF9DF04", VA = "0xF9DF04")]
	public void ProcessClientMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F58")]
	[Cpp2IlInjected.Address(RVA = "0xFA00E4", Offset = "0xFA00E4", VA = "0xFA00E4")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F59")]
	[Cpp2IlInjected.Address(RVA = "0xF9DDBC", Offset = "0xF9DDBC", VA = "0xF9DDBC")]
	public bool AttemptClientConnection()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F5A")]
	[Cpp2IlInjected.Address(RVA = "0xFA0104", Offset = "0xFA0104", VA = "0xFA0104")]
	public bool IsLookingForConnection()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F5B")]
	[Cpp2IlInjected.Address(RVA = "0xFA0120", Offset = "0xFA0120", VA = "0xFA0120")]
	public void Startup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F5C")]
	[Cpp2IlInjected.Address(RVA = "0xFA0354", Offset = "0xFA0354", VA = "0xFA0354")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F5D")]
	[Cpp2IlInjected.Address(RVA = "0xF9DFBC", Offset = "0xF9DFBC", VA = "0xF9DFBC")]
	public void Restart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F5E")]
	[Cpp2IlInjected.Address(RVA = "0xFA0424", Offset = "0xFA0424", VA = "0xFA0424")]
	public void Connect(string connectionAddress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F5F")]
	[Cpp2IlInjected.Address(RVA = "0xFA050C", Offset = "0xFA050C", VA = "0xFA050C")]
	public SaveSynchronisationManager()
	{
	}
}
