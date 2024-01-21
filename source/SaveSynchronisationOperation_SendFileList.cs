using System.IO;
using Cpp2IlInjected;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000223")]
public class SaveSynchronisationOperation_SendFileList : SaveSynchronisationOperation
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A38")]
	private int fileCountPending;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001A39")]
	private int fileOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001A3A")]
	private bool sentPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4001A3B")]
	private bool sentWorlds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4001A3C")]
	private bool sentEndList;

	[Cpp2IlInjected.Token(Token = "0x6000F75")]
	[Cpp2IlInjected.Address(RVA = "0xF9DE80", Offset = "0xF9DE80", VA = "0xF9DE80")]
	public SaveSynchronisationOperation_SendFileList(SendDataFunction sendOperation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F76")]
	[Cpp2IlInjected.Address(RVA = "0xFA1F28", Offset = "0xFA1F28", VA = "0xFA1F28", Slot = "4")]
	public override void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F77")]
	[Cpp2IlInjected.Address(RVA = "0xFA215C", Offset = "0xFA215C", VA = "0xFA215C")]
	private void SendPlayerFile(PlayerFileData playerFileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F78")]
	[Cpp2IlInjected.Address(RVA = "0xFA24F4", Offset = "0xFA24F4", VA = "0xFA24F4")]
	private void WritePlayerData(BinaryWriter writer, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F79")]
	[Cpp2IlInjected.Address(RVA = "0xFA2D94", Offset = "0xFA2D94", VA = "0xFA2D94")]
	private void SendWorldFile(WorldFileData worldFileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F7A")]
	[Cpp2IlInjected.Address(RVA = "0xFA1F54", Offset = "0xFA1F54", VA = "0xFA1F54")]
	private void SendNextFile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F7B")]
	[Cpp2IlInjected.Address(RVA = "0xFA31E4", Offset = "0xFA31E4", VA = "0xFA31E4", Slot = "5")]
	public override void ProcessMessage(MessageId messageId, byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F7C")]
	[Cpp2IlInjected.Address(RVA = "0xFA3220", Offset = "0xFA3220", VA = "0xFA3220", Slot = "7")]
	public override string GetStatus()
	{
		return null;
	}
}
