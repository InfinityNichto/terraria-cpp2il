using Cpp2IlInjected;
using Telepathy;

[Cpp2IlInjected.Token(Token = "0x200021C")]
public class SaveSynchronisationClient
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A16")]
	public Client Client;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A17")]
	public SaveSynchronisationOperation CurrentOperation;

	[Cpp2IlInjected.Token(Token = "0x6000F42")]
	[Cpp2IlInjected.Address(RVA = "0xF9CD3C", Offset = "0xF9CD3C", VA = "0xF9CD3C")]
	public void Connect(string hostName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F43")]
	[Cpp2IlInjected.Address(RVA = "0xF9CD4C", Offset = "0xF9CD4C", VA = "0xF9CD4C")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F44")]
	[Cpp2IlInjected.Address(RVA = "0xF9CD58", Offset = "0xF9CD58", VA = "0xF9CD58")]
	private void SendDataFunction(byte[] messageData, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F45")]
	[Cpp2IlInjected.Address(RVA = "0xF9CF84", Offset = "0xF9CF84", VA = "0xF9CF84")]
	public void RequestFile(string filename)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F46")]
	[Cpp2IlInjected.Address(RVA = "0xF9D404", Offset = "0xF9D404", VA = "0xF9D404")]
	public void SendFile(string filename)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F47")]
	[Cpp2IlInjected.Address(RVA = "0xF9D84C", Offset = "0xF9D84C", VA = "0xF9D84C")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F48")]
	[Cpp2IlInjected.Address(RVA = "0xF9DFD8", Offset = "0xF9DFD8", VA = "0xF9DFD8")]
	public SaveSynchronisationClient()
	{
	}
}
