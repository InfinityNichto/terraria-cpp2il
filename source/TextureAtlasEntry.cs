using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20002E9")]
public class TextureAtlasEntry
{
	[global::Cpp2ILInjected.Token(Token = "0x6001148")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6940C", Offset = "0xA6940C", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TextureAtlasEntry(int textureId)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001149")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6AB60", Offset = "0xA6AB60", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public TextureAtlasEntry(int textureId, int atlasIndex, short textureWidth, short textureHeight, short textureOffsetX, short textureOffsetY, short textureScale)
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x4002114")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int TextureId;

	[global::Cpp2ILInjected.Token(Token = "0x4002115")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int AtlasIndex;

	[global::Cpp2ILInjected.Token(Token = "0x4002116")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public short TextureOffsetX;

	[global::Cpp2ILInjected.Token(Token = "0x4002117")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
	public short TextureOffsetY;

	[global::Cpp2ILInjected.Token(Token = "0x4002118")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public short TextureWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4002119")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
	public short TextureHeight;

	[global::Cpp2ILInjected.Token(Token = "0x400211A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public short TileWidth;

	[global::Cpp2ILInjected.Token(Token = "0x400211B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
	public short TileHeight;

	[global::Cpp2ILInjected.Token(Token = "0x400211C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool TileTrimming;

	[global::Cpp2ILInjected.Token(Token = "0x400211D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
	public short TextureScale;

	[global::Cpp2ILInjected.Token(Token = "0x400211E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int TileDataOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400211F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture2D AttachedTexture;

	[global::Cpp2ILInjected.Token(Token = "0x20002EA")]
	public static class TextureAtlasEntryTiles
	{
		[global::Cpp2ILInjected.Token(Token = "0x600114D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6ADD8", Offset = "0xA6ADD8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reset()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001150")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6AEC8", Offset = "0xA6AEC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int CalculateFrameCount(TextureAtlasEntry entry)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4002120")]
		public static short[] TileOffsetData;

		[global::Cpp2ILInjected.Token(Token = "0x4002121")]
		private static int TileDataOffset;
	}
}
