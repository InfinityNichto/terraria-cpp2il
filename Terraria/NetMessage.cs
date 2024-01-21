using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.Localization;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200031E")]
public class NetMessage
{
	[Cpp2IlInjected.Token(Token = "0x200083B")]
	public struct NetSoundInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E6B")]
		public Vector2 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E6C")]
		public ushort soundIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E6D")]
		public int style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E6E")]
		public float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007E6F")]
		public float pitchOffset;

		[Cpp2IlInjected.Token(Token = "0x60049CB")]
		[Cpp2IlInjected.Address(RVA = "0x39F178", Offset = "0x39F178", VA = "0x39F178")]
		public NetSoundInfo(Vector2 position, ushort soundIndex, int style = -1, float volume = -1f, float pitchOffset = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049CC")]
		[Cpp2IlInjected.Address(RVA = "0x39F1A0", Offset = "0x39F1A0", VA = "0x39F1A0")]
		public void WriteSelfTo(BinaryWriter writer)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400275F")]
	public static MessageBuffer[] buffer;

	[Cpp2IlInjected.Token(Token = "0x4002760")]
	private static byte[] writeBuffer;

	[Cpp2IlInjected.Token(Token = "0x4002761")]
	private static BinaryWriter streamWriter;

	[Cpp2IlInjected.Token(Token = "0x4002762")]
	private static short[] chestList;

	[Cpp2IlInjected.Token(Token = "0x4002763")]
	private static short[] signList;

	[Cpp2IlInjected.Token(Token = "0x4002764")]
	private static short[] entityList;

	[Cpp2IlInjected.Token(Token = "0x4002765")]
	private static byte[] bytes;

	[Cpp2IlInjected.Token(Token = "0x4002766")]
	private static PlayerDeathReason _currentPlayerDeathReason;

	[Cpp2IlInjected.Token(Token = "0x4002767")]
	private static NetSoundInfo _currentNetSoundInfo;

	[Cpp2IlInjected.Token(Token = "0x4002768")]
	private static CoinLossRevengeSystem.RevengeMarker _currentRevengeMarker;

	[Cpp2IlInjected.Token(Token = "0x60020C2")]
	[Cpp2IlInjected.Address(RVA = "0x142F494", Offset = "0x142F494", VA = "0x142F494")]
	public static bool TrySendData(int msgType, int remoteClient = -1, int ignoreClient = -1, [Optional] NetworkText text, int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0, int number6 = 0, int number7 = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020C3")]
	[Cpp2IlInjected.Address(RVA = "0x142F5EC", Offset = "0x142F5EC", VA = "0x142F5EC")]
	public static void SendData(int msgType, int remoteClient = -1, int ignoreClient = -1, [Optional] NetworkText text, int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0, int number6 = 0, int number7 = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020C4")]
	[Cpp2IlInjected.Address(RVA = "0x143DDA0", Offset = "0x143DDA0", VA = "0x143DDA0")]
	private static void WriteAccessoryVisibility(BinaryWriter writer, bool[] hideVisibleAccessory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020C5")]
	[Cpp2IlInjected.Address(RVA = "0x143DE00", Offset = "0x143DE00", VA = "0x143DE00")]
	public static void CompressTileBlock(int xStart, int yStart, short width, short height, Stream stream)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020C6")]
	[Cpp2IlInjected.Address(RVA = "0x143FB5C", Offset = "0x143FB5C", VA = "0x143FB5C")]
	public static bool DoesPlayerSlotCountAsAHost(int plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60020C7")]
	[Cpp2IlInjected.Address(RVA = "0x143E21C", Offset = "0x143E21C", VA = "0x143E21C")]
	public static void CompressTileBlock_Inner(BinaryWriter writer, int xStart, int yStart, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020C8")]
	[Cpp2IlInjected.Address(RVA = "0x143FC30", Offset = "0x143FC30", VA = "0x143FC30")]
	public static void DecompressTileBlock(Stream stream)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020C9")]
	[Cpp2IlInjected.Address(RVA = "0x143FE44", Offset = "0x143FE44", VA = "0x143FE44")]
	public static void DecompressTileBlock_Inner(BinaryReader reader, int xStart, int yStart, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020CA")]
	[Cpp2IlInjected.Address(RVA = "0x1440A70", Offset = "0x1440A70", VA = "0x1440A70")]
	public static void BootPlayer(int plr, NetworkText msg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020CB")]
	[Cpp2IlInjected.Address(RVA = "0x1440B20", Offset = "0x1440B20", VA = "0x1440B20")]
	public static void SendObjectPlacement(int whoAmi, int x, int y, int type, int style, int alternative, int random, int direction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020CC")]
	[Cpp2IlInjected.Address(RVA = "0x1440C44", Offset = "0x1440C44", VA = "0x1440C44")]
	public static void SendTemporaryAnimation(int whoAmi, int animationType, int tileType, int xCoord, int yCoord)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020CD")]
	[Cpp2IlInjected.Address(RVA = "0x1440D18", Offset = "0x1440D18", VA = "0x1440D18")]
	public static void SendPlayerHurt(int playerTargetIndex, PlayerDeathReason reason, int damage, int direction, bool critical, bool pvp, int hitContext, int remoteClient = -1, int ignoreClient = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020CE")]
	[Cpp2IlInjected.Address(RVA = "0x1440E40", Offset = "0x1440E40", VA = "0x1440E40")]
	public static void SendPlayerDeath(int playerTargetIndex, PlayerDeathReason reason, int damage, int direction, bool pvp, int remoteClient = -1, int ignoreClient = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020CF")]
	[Cpp2IlInjected.Address(RVA = "0x1440F4C", Offset = "0x1440F4C", VA = "0x1440F4C")]
	public static void PlayNetSound(NetSoundInfo info, int remoteClient = -1, int ignoreClient = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D0")]
	[Cpp2IlInjected.Address(RVA = "0x1441034", Offset = "0x1441034", VA = "0x1441034")]
	public static void SendCoinLossRevengeMarker(CoinLossRevengeSystem.RevengeMarker marker, int remoteClient = -1, int ignoreClient = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D1")]
	[Cpp2IlInjected.Address(RVA = "0x14410F4", Offset = "0x14410F4", VA = "0x14410F4")]
	public static void SendTileSquare(int whoAmi, int tileX, int tileY, int xSize, int ySize, TileChangeType changeType = TileChangeType.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D2")]
	[Cpp2IlInjected.Address(RVA = "0x1441210", Offset = "0x1441210", VA = "0x1441210")]
	public static void SendTileSquare(int whoAmi, int tileX, int tileY, int centeredSquareSize, TileChangeType changeType = TileChangeType.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D3")]
	[Cpp2IlInjected.Address(RVA = "0x14412BC", Offset = "0x14412BC", VA = "0x14412BC")]
	public static void SendTileSquare(int whoAmi, int tileX, int tileY, TileChangeType changeType = TileChangeType.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D4")]
	[Cpp2IlInjected.Address(RVA = "0x144135C", Offset = "0x144135C", VA = "0x144135C")]
	public static void SendTravelShop(int remoteClient)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D5")]
	[Cpp2IlInjected.Address(RVA = "0x1441444", Offset = "0x1441444", VA = "0x1441444")]
	public static void SendAnglerQuest(int remoteClient)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D6")]
	[Cpp2IlInjected.Address(RVA = "0x1441740", Offset = "0x1441740", VA = "0x1441740")]
	public static void SendSection(int whoAmi, int sectionX, int sectionY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D7")]
	[Cpp2IlInjected.Address(RVA = "0x1441F90", Offset = "0x1441F90", VA = "0x1441F90")]
	public static void greetPlayer(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D8")]
	[Cpp2IlInjected.Address(RVA = "0x14424DC", Offset = "0x14424DC", VA = "0x14424DC")]
	public static void sendWater(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020D9")]
	[Cpp2IlInjected.Address(RVA = "0x144279C", Offset = "0x144279C", VA = "0x144279C")]
	public static void SyncDisconnectedPlayer(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020DA")]
	[Cpp2IlInjected.Address(RVA = "0x1443B74", Offset = "0x1443B74", VA = "0x1443B74")]
	public static void SyncConnectedPlayer(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020DB")]
	[Cpp2IlInjected.Address(RVA = "0x1443DAC", Offset = "0x1443DAC", VA = "0x1443DAC")]
	private static void SendNPCHousesAndTravelShop(int plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020DC")]
	[Cpp2IlInjected.Address(RVA = "0x1443918", Offset = "0x1443918", VA = "0x1443918")]
	public static void EnsureLocalPlayerIsPresent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020DD")]
	[Cpp2IlInjected.Address(RVA = "0x1442820", Offset = "0x1442820", VA = "0x1442820")]
	private static void SyncOnePlayer(int plr, int toWho, int fromWho)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020DE")]
	[Cpp2IlInjected.Address(RVA = "0x1443FFC", Offset = "0x1443FFC", VA = "0x1443FFC")]
	private static void SyncOnePlayer_ItemArray(int plr, int toWho, int fromWho, Item[] arr, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60020DF")]
	[Cpp2IlInjected.Address(RVA = "0x14440F8", Offset = "0x14440F8", VA = "0x14440F8")]
	public NetMessage()
	{
	}
}
