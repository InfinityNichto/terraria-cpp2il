using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000233 RID: 563
[global::Cpp2ILInjected.Token(Token = "0x20002E9")]
public class TextureAtlasEntry
{
	// Token: 0x06000FFF RID: 4095 RVA: 0x00024ADF File Offset: 0x00022CDF
	[global::Cpp2ILInjected.Token(Token = "0x6001148")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6940C", Offset = "0xA6940C", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TextureAtlasEntry(int textureId)
	{
		throw null;
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00024AE2 File Offset: 0x00022CE2
	[global::Cpp2ILInjected.Token(Token = "0x6001149")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6AB60", Offset = "0xA6AB60", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TextureAtlasEntry(int textureId, int atlasIndex, short textureWidth, short textureHeight, short textureOffsetX, short textureOffsetY, short textureScale)
	{
		throw null;
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00024AE5 File Offset: 0x00022CE5
	[global::Cpp2ILInjected.Token(Token = "0x600114A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6999C", Offset = "0xA6999C", Length = "0x16C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Save", ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry.TextureAtlasEntryTiles), Member = "SaveTileData", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(TextureAtlasEntry)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Save(BinaryWriter writer)
	{
		throw null;
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00024AE8 File Offset: 0x00022CE8
	[global::Cpp2ILInjected.Token(Token = "0x600114B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA691D4", Offset = "0xA691D4", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry), Member = "LoadData", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(short)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static TextureAtlasEntry Load(BinaryReader loader, short version)
	{
		throw null;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00024AEB File Offset: 0x00022CEB
	[global::Cpp2ILInjected.Token(Token = "0x600114C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA69274", Offset = "0xA69274", Length = "0x198")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "Load", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasEntry), Member = "Load", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(short)
	}, ReturnType = typeof(TextureAtlasEntry))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry.TextureAtlasEntryTiles), Member = "LoadTileData", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(TextureAtlasEntry)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "ResetLoaded", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void LoadData(BinaryReader loader, short version)
	{
		throw null;
	}

	// Token: 0x04001B6C RID: 7020
	[global::Cpp2ILInjected.Token(Token = "0x4002114")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int TextureId;

	// Token: 0x04001B6D RID: 7021
	[global::Cpp2ILInjected.Token(Token = "0x4002115")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int AtlasIndex;

	// Token: 0x04001B6E RID: 7022
	[global::Cpp2ILInjected.Token(Token = "0x4002116")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public short TextureOffsetX;

	// Token: 0x04001B6F RID: 7023
	[global::Cpp2ILInjected.Token(Token = "0x4002117")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
	public short TextureOffsetY;

	// Token: 0x04001B70 RID: 7024
	[global::Cpp2ILInjected.Token(Token = "0x4002118")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public short TextureWidth;

	// Token: 0x04001B71 RID: 7025
	[global::Cpp2ILInjected.Token(Token = "0x4002119")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
	public short TextureHeight;

	// Token: 0x04001B72 RID: 7026
	[global::Cpp2ILInjected.Token(Token = "0x400211A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public short TileWidth;

	// Token: 0x04001B73 RID: 7027
	[global::Cpp2ILInjected.Token(Token = "0x400211B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
	public short TileHeight;

	// Token: 0x04001B74 RID: 7028
	[global::Cpp2ILInjected.Token(Token = "0x400211C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool TileTrimming;

	// Token: 0x04001B75 RID: 7029
	[global::Cpp2ILInjected.Token(Token = "0x400211D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
	public short TextureScale;

	// Token: 0x04001B76 RID: 7030
	[global::Cpp2ILInjected.Token(Token = "0x400211E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int TileDataOffset;

	// Token: 0x04001B77 RID: 7031
	[global::Cpp2ILInjected.Token(Token = "0x400211F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture2D AttachedTexture;

	// Token: 0x02000815 RID: 2069
	[global::Cpp2ILInjected.Token(Token = "0x20002EA")]
	public static class TextureAtlasEntryTiles
	{
		// Token: 0x0600491C RID: 18716 RVA: 0x0002EF6D File Offset: 0x0002D16D
		[global::Cpp2ILInjected.Token(Token = "0x600114D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6ADD8", Offset = "0xA6ADD8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reset()
		{
			throw null;
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x0002EF70 File Offset: 0x0002D170
		[global::Cpp2ILInjected.Token(Token = "0x600114E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6ACCC", Offset = "0xA6ACCC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasEntry), Member = "LoadData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasEntry.TextureAtlasEntryTiles), Member = "ReserveData", MemberParameters = new object[] { typeof(TextureAtlasEntry) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void LoadTileData(BinaryReader loader, TextureAtlasEntry entry)
		{
			throw null;
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x0002EF73 File Offset: 0x0002D173
		[global::Cpp2ILInjected.Token(Token = "0x600114F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6ABD8", Offset = "0xA6ABD8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasEntry), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SaveTileData(BinaryWriter writer, TextureAtlasEntry entry)
		{
			throw null;
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x0002EF76 File Offset: 0x0002D176
		[global::Cpp2ILInjected.Token(Token = "0x6001150")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6AEC8", Offset = "0xA6AEC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int CalculateFrameCount(TextureAtlasEntry entry)
		{
			throw null;
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x0002EF79 File Offset: 0x0002D179
		[global::Cpp2ILInjected.Token(Token = "0x6001151")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6AE30", Offset = "0xA6AE30", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasEntry.TextureAtlasEntryTiles), Member = "LoadTileData", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(TextureAtlasEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ReserveData(TextureAtlasEntry entry)
		{
			throw null;
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x0002EF7C File Offset: 0x0002D17C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001152")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6AEF8", Offset = "0xA6AEF8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static TextureAtlasEntryTiles()
		{
			throw null;
		}

		// Token: 0x04007D66 RID: 32102
		[global::Cpp2ILInjected.Token(Token = "0x4002120")]
		public static short[] TileOffsetData;

		// Token: 0x04007D67 RID: 32103
		[global::Cpp2ILInjected.Token(Token = "0x4002121")]
		private static int TileDataOffset;
	}
}
