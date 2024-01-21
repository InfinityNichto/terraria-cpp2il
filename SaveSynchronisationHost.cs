using Cpp2IlInjected;
using Telepathy;

[Cpp2IlInjected.Token(Token = "0x200021E")]
public class SaveSynchronisationHost
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A1E")]
	public Server Server;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A1F")]
	public SaveSynchronisationOperation CurrentOperation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A20")]
	public int connectedClient;

	[Cpp2IlInjected.Token(Token = "0x6000F4E")]
	[Cpp2IlInjected.Address(RVA = "0xF9F148", Offset = "0xF9F148", VA = "0xF9F148")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F4F")]
	[Cpp2IlInjected.Address(RVA = "0xF9F158", Offset = "0xF9F158", VA = "0xF9F158")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F50")]
	[Cpp2IlInjected.Address(RVA = "0xF9F164", Offset = "0xF9F164", VA = "0xF9F164")]
	private void SendDataFunction(byte[] messageData, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F51")]
	[Cpp2IlInjected.Address(RVA = "0xF9F398", Offset = "0xF9F398", VA = "0xF9F398")]
	public void RequestFile(string filename)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F52")]
	[Cpp2IlInjected.Address(RVA = "0xF9F72C", Offset = "0xF9F72C", VA = "0xF9F72C")]
	public void SendFile(string filename)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F53")]
	[Cpp2IlInjected.Address(RVA = "0xF9F840", Offset = "0xF9F840", VA = "0xF9F840")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F54")]
	[Cpp2IlInjected.Address(RVA = "0xF9FF38", Offset = "0xF9FF38", VA = "0xF9FF38")]
	public SaveSynchronisationHost()
	{
	}
}
