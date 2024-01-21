using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x200066F")]
public class NetLiquidModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x2000A5A")]
	private class ChunkChanges
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E30")]
		public HashSet<int> DirtiedPackedTileCoords;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E31")]
		public int ChunkX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E32")]
		public int ChunkY;

		[Cpp2IlInjected.Token(Token = "0x60050E4")]
		[Cpp2IlInjected.Address(RVA = "0x105D640", Offset = "0x105D640", VA = "0x105D640")]
		public ChunkChanges(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050E5")]
		[Cpp2IlInjected.Address(RVA = "0x105CB48", Offset = "0x105CB48", VA = "0x105CB48")]
		public bool BroadcastingCondition(int clientIndex)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006D82")]
	private static List<int> _changesForPlayerCache;

	[Cpp2IlInjected.Token(Token = "0x4006D83")]
	private static Dictionary<Point, ChunkChanges> _changesByChunkCoords;

	[Cpp2IlInjected.Token(Token = "0x6004116")]
	[Cpp2IlInjected.Address(RVA = "0x105C41C", Offset = "0x105C41C", VA = "0x105C41C")]
	public static NetPacket Serialize(HashSet<int> changes)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004117")]
	[Cpp2IlInjected.Address(RVA = "0x105C6D0", Offset = "0x105C6D0", VA = "0x105C6D0")]
	public static NetPacket SerializeForPlayer(int playerIndex)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004118")]
	[Cpp2IlInjected.Address(RVA = "0x105CBF0", Offset = "0x105CBF0", VA = "0x105CBF0", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004119")]
	[Cpp2IlInjected.Address(RVA = "0x105CD50", Offset = "0x105CD50", VA = "0x105CD50")]
	public static void CreateAndBroadcastByChunk(HashSet<int> dirtiedPackedTileCoords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600411A")]
	[Cpp2IlInjected.Address(RVA = "0x105CF4C", Offset = "0x105CF4C", VA = "0x105CF4C")]
	private static void PrepareAndSendToEachPlayerSeparately()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600411B")]
	[Cpp2IlInjected.Address(RVA = "0x105D080", Offset = "0x105D080", VA = "0x105D080")]
	private static void BroadcastEachChunkSeparately()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600411C")]
	[Cpp2IlInjected.Address(RVA = "0x105CDCC", Offset = "0x105CDCC", VA = "0x105CDCC")]
	private static void PrepareChunks(HashSet<int> dirtiedPackedTileCoords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600411D")]
	[Cpp2IlInjected.Address(RVA = "0x105D560", Offset = "0x105D560", VA = "0x105D560")]
	private static void BroadcastAllChanges(HashSet<int> dirtiedPackedTileCoords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600411E")]
	[Cpp2IlInjected.Address(RVA = "0x105D2AC", Offset = "0x105D2AC", VA = "0x105D2AC")]
	private static void DistributeChangesIntoChunks(HashSet<int> dirtiedPackedTileCoords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600411F")]
	[Cpp2IlInjected.Address(RVA = "0x105D6D4", Offset = "0x105D6D4", VA = "0x105D6D4")]
	public NetLiquidModule()
	{
	}
}
