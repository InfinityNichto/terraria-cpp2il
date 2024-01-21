using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000224")]
public class SaveSynchronisationState
{
	[Cpp2IlInjected.Token(Token = "0x4001A3D")]
	private static byte[] emptyMessageData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A3E")]
	public bool IsSynchronised;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A3F")]
	public List<PlayerFileData> playerFiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A40")]
	public List<WorldFileData> worldFiles;

	[Cpp2IlInjected.Token(Token = "0x6000F7D")]
	[Cpp2IlInjected.Address(RVA = "0xFA01F4", Offset = "0xFA01F4", VA = "0xFA01F4")]
	public void RefreshFromFileSystem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F7E")]
	[Cpp2IlInjected.Address(RVA = "0xFA0084", Offset = "0xFA0084", VA = "0xFA0084")]
	public void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F7F")]
	[Cpp2IlInjected.Address(RVA = "0xFA3AB0", Offset = "0xFA3AB0", VA = "0xFA3AB0")]
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F80")]
	[Cpp2IlInjected.Address(RVA = "0xFA00D0", Offset = "0xFA00D0", VA = "0xFA00D0")]
	public void ProcessMessageResponse(SaveSynchronisationOperation.MessageId messageId, SaveSynchronisationOperation.SendDataFunction sendDataFunction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F81")]
	[Cpp2IlInjected.Address(RVA = "0xFA33CC", Offset = "0xFA33CC", VA = "0xFA33CC")]
	private void ReadPlayerFileData(byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F82")]
	[Cpp2IlInjected.Address(RVA = "0xFA3B74", Offset = "0xFA3B74", VA = "0xFA3B74")]
	private void ReadPlayerData(BinaryReader reader, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F83")]
	[Cpp2IlInjected.Address(RVA = "0xFA36F0", Offset = "0xFA36F0", VA = "0xFA36F0")]
	private void ReadWorldFileData(byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F84")]
	[Cpp2IlInjected.Address(RVA = "0xFA02E0", Offset = "0xFA02E0", VA = "0xFA02E0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F85")]
	[Cpp2IlInjected.Address(RVA = "0xFA05F4", Offset = "0xFA05F4", VA = "0xFA05F4")]
	public SaveSynchronisationState()
	{
	}
}
