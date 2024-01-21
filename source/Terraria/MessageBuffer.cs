using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200031C")]
public class MessageBuffer
{
	[Cpp2IlInjected.Token(Token = "0x400262A")]
	private static byte[] processData;

	[Cpp2IlInjected.Token(Token = "0x400262B")]
	private static MemoryStream readerStream;

	[Cpp2IlInjected.Token(Token = "0x400262C")]
	private static BinaryReader reader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400262D")]
	public bool broadcast;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400262E")]
	public int whoAmI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400262F")]
	public int spamCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002630")]
	public int maxSpam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002632")]
	private float[] _temporaryProjectileAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002633")]
	private float[] _temporaryNPCAI;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public static event TileChangeReceivedEvent OnTileChangeReceived
	{
		[Cpp2IlInjected.Token(Token = "0x6001F37")]
		[Cpp2IlInjected.Address(RVA = "0xE9FD94", Offset = "0xE9FD94", VA = "0xE9FD94")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001F38")]
		[Cpp2IlInjected.Address(RVA = "0xE9FE9C", Offset = "0xE9FE9C", VA = "0xE9FE9C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001F39")]
	[Cpp2IlInjected.Address(RVA = "0xE9FFA4", Offset = "0xE9FFA4", VA = "0xE9FFA4")]
	public void Reset(bool setupActive = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F3A")]
	[Cpp2IlInjected.Address(RVA = "0xE9FFB4", Offset = "0xE9FFB4", VA = "0xE9FFB4")]
	private float[] ReUseTemporaryProjectileAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F3B")]
	[Cpp2IlInjected.Address(RVA = "0xE9FFFC", Offset = "0xE9FFFC", VA = "0xE9FFFC")]
	private float[] ReUseTemporaryNPCAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001F3C")]
	[Cpp2IlInjected.Address(RVA = "0xEA0044", Offset = "0xEA0044", VA = "0xEA0044")]
	public void ProcessData(byte[] messageData, int length, out int messageType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F3D")]
	[Cpp2IlInjected.Address(RVA = "0xEBF3E8", Offset = "0xEBF3E8", VA = "0xEBF3E8")]
	private static void ReadAccessoryVisibility(BinaryReader reader, bool[] hideVisibleAccessory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F3E")]
	[Cpp2IlInjected.Address(RVA = "0xEBF2F0", Offset = "0xEBF2F0", VA = "0xEBF2F0")]
	private static void TrySendingItemArray(int plr, Item[] array, int slotStartIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F3F")]
	[Cpp2IlInjected.Address(RVA = "0xEBF440", Offset = "0xEBF440", VA = "0xEBF440")]
	public MessageBuffer()
	{
	}
}
