using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000235")]
public class TextureAtlasEntry
{
	[Cpp2IlInjected.Token(Token = "0x200080C")]
	public static class TextureAtlasEntryTiles
	{
		[Cpp2IlInjected.Token(Token = "0x4007D53")]
		public static short[] TileOffsetData;

		[Cpp2IlInjected.Token(Token = "0x4007D54")]
		private static int TileDataOffset;

		[Cpp2IlInjected.Token(Token = "0x6004952")]
		[Cpp2IlInjected.Address(RVA = "0x10CCBC8", Offset = "0x10CCBC8", VA = "0x10CCBC8")]
		public static void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004953")]
		[Cpp2IlInjected.Address(RVA = "0x10CCA70", Offset = "0x10CCA70", VA = "0x10CCA70")]
		public static void LoadTileData(BinaryReader loader, TextureAtlasEntry entry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004954")]
		[Cpp2IlInjected.Address(RVA = "0x10CC94C", Offset = "0x10CC94C", VA = "0x10CC94C")]
		public static void SaveTileData(BinaryWriter writer, TextureAtlasEntry entry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004955")]
		[Cpp2IlInjected.Address(RVA = "0x10CCD0C", Offset = "0x10CCD0C", VA = "0x10CCD0C")]
		public static int CalculateFrameCount(TextureAtlasEntry entry)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004956")]
		[Cpp2IlInjected.Address(RVA = "0x10CCC44", Offset = "0x10CCC44", VA = "0x10CCC44")]
		public static int ReserveData(TextureAtlasEntry entry)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B75")]
	public int TextureId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001B76")]
	public int AtlasIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001B77")]
	public short TextureOffsetX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4001B78")]
	public short TextureOffsetY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001B79")]
	public short TextureWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4001B7A")]
	public short TextureHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001B7B")]
	public short TileWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4001B7C")]
	public short TileHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001B7D")]
	public bool TileTrimming;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x4001B7E")]
	public short TextureScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001B7F")]
	public int TileDataOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001B80")]
	public Texture2D AttachedTexture;

	[Cpp2IlInjected.Token(Token = "0x6001018")]
	[Cpp2IlInjected.Address(RVA = "0x10CAF14", Offset = "0x10CAF14", VA = "0x10CAF14")]
	public TextureAtlasEntry(int textureId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001019")]
	[Cpp2IlInjected.Address(RVA = "0x10CC8F0", Offset = "0x10CC8F0", VA = "0x10CC8F0")]
	public TextureAtlasEntry(int textureId, int atlasIndex, short textureWidth, short textureHeight, short textureOffsetX, short textureOffsetY, short textureScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600101A")]
	[Cpp2IlInjected.Address(RVA = "0x10CB3A0", Offset = "0x10CB3A0", VA = "0x10CB3A0")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600101B")]
	[Cpp2IlInjected.Address(RVA = "0x10CACC8", Offset = "0x10CACC8", VA = "0x10CACC8")]
	public static TextureAtlasEntry Load(BinaryReader loader, short version)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600101C")]
	[Cpp2IlInjected.Address(RVA = "0x10CAD70", Offset = "0x10CAD70", VA = "0x10CAD70")]
	public void LoadData(BinaryReader loader, short version)
	{
	}
}
