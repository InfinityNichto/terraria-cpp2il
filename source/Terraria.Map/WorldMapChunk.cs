using System;
using Cpp2IlInjected;
using Ionic.Zlib;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004B1")]
public class WorldMapChunk
{
	[Cpp2IlInjected.Token(Token = "0x40065B4")]
	public const int InitialChunkCompressedSize = 2048;

	[Cpp2IlInjected.Token(Token = "0x40065B5")]
	public const int MapChunkSize = 64;

	[Cpp2IlInjected.Token(Token = "0x40065B6")]
	public static int MapChunkTileSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40065B7")]
	private readonly WorldMap Map;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40065B8")]
	public unsafe MapTile* TileData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40065B9")]
	public byte[] CompressedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40065BA")]
	public long CompressedDataLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40065BB")]
	public DateTime LastUsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40065BC")]
	public int X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40065BD")]
	public int Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40065BE")]
	public bool dirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40065BF")]
	public int frameAge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40065C0")]
	public int referenceCount;

	[Cpp2IlInjected.Token(Token = "0x40065C1")]
	private static byte[] ClearData;

	[Cpp2IlInjected.Token(Token = "0x40065C2")]
	private static byte[] resetData;

	[Cpp2IlInjected.Token(Token = "0x40065C3")]
	private static byte[] CopyBuffer;

	[Cpp2IlInjected.Token(Token = "0x40065C4")]
	private static byte[] CompressBuffer;

	[Cpp2IlInjected.Token(Token = "0x40065C5")]
	private static byte[] BlockBuffer;

	[Cpp2IlInjected.Token(Token = "0x40065C6")]
	private static ZlibCodec zlibCompress;

	[Cpp2IlInjected.Token(Token = "0x40065C7")]
	private static ZlibCodec zlibDecompress;

	[Cpp2IlInjected.Token(Token = "0x40065C8")]
	private static long biggestChunk;

	[Cpp2IlInjected.Token(Token = "0x17000657")]
	public bool Loaded
	{
		[Cpp2IlInjected.Token(Token = "0x6003421")]
		[Cpp2IlInjected.Address(RVA = "0xE9F50C", Offset = "0xE9F50C", VA = "0xE9F50C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003420")]
	[Cpp2IlInjected.Address(RVA = "0xE9E160", Offset = "0xE9E160", VA = "0xE9E160")]
	public unsafe WorldMapChunk(WorldMap map, byte* compressedData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003422")]
	[Cpp2IlInjected.Address(RVA = "0xE9D56C", Offset = "0xE9D56C", VA = "0xE9D56C")]
	public void SaveCompressed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003423")]
	[Cpp2IlInjected.Address(RVA = "0xE9D028", Offset = "0xE9D028", VA = "0xE9D028")]
	public void LoadTiles(bool utilLoad = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003424")]
	[Cpp2IlInjected.Address(RVA = "0xE9F31C", Offset = "0xE9F31C", VA = "0xE9F31C")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003425")]
	[Cpp2IlInjected.Address(RVA = "0xE9F51C", Offset = "0xE9F51C", VA = "0xE9F51C")]
	public unsafe void Compress(byte* srcData, long srcLength, out long resultLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003426")]
	[Cpp2IlInjected.Address(RVA = "0xE9F814", Offset = "0xE9F814", VA = "0xE9F814")]
	public unsafe void Decompress(byte[] srcData, long srcLength, byte* dstData, long dstLength, out long resultLength)
	{
	}
}
