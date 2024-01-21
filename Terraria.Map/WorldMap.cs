using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004B0")]
public class WorldMap
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40065A7")]
	public int MaxWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40065A8")]
	public int MaxHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40065A9")]
	public int MaxChunkWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40065AA")]
	public int MaxChunkHeight;

	[Cpp2IlInjected.Token(Token = "0x40065AB")]
	public const int BlackEdgeWidth = 40;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40065AC")]
	public WorldMapChunk[] _chunks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40065AD")]
	public int MaxChunkMapped;

	[Cpp2IlInjected.Token(Token = "0x40065AE")]
	public const int ReservedForPlayer = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40065AF")]
	private unsafe MapTile* TileData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40065B0")]
	private unsafe byte* TileCompressedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40065B1")]
	public object LockObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40065B2")]
	private List<IntPtr> TileChunksAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40065B3")]
	private List<WorldMapChunk> TileChunksInUse;

	[Cpp2IlInjected.Token(Token = "0x17000656")]
	public int NumChunksAvailable
	{
		[Cpp2IlInjected.Token(Token = "0x600340E")]
		[Cpp2IlInjected.Address(RVA = "0xE9D278", Offset = "0xE9D278", VA = "0xE9D278")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600340C")]
	[Cpp2IlInjected.Address(RVA = "0xE9CF9C", Offset = "0xE9CF9C", VA = "0xE9CF9C")]
	public unsafe MapTile* GetChunkTile(int mapX, int mapY, out WorldMapChunk chunk)
	{
		//IL_0002: Expected I, but got O
		return (MapTile*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x600340D")]
	[Cpp2IlInjected.Address(RVA = "0xE9D1EC", Offset = "0xE9D1EC", VA = "0xE9D1EC")]
	public unsafe MapTile* GetChunkTile(int mapX, int mapY, bool utilLoad, out WorldMapChunk chunk)
	{
		//IL_0002: Expected I, but got O
		return (MapTile*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x600340F")]
	[Cpp2IlInjected.Address(RVA = "0xE9D33C", Offset = "0xE9D33C", VA = "0xE9D33C")]
	public void UnloadChunk()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003410")]
	[Cpp2IlInjected.Address(RVA = "0xE9D624", Offset = "0xE9D624", VA = "0xE9D624")]
	public unsafe MapTile* GetTileStorage(WorldMapChunk chunk, bool utilLoad = false)
	{
		//IL_0002: Expected I, but got O
		return (MapTile*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6003411")]
	[Cpp2IlInjected.Address(RVA = "0xE9DAA8", Offset = "0xE9DAA8", VA = "0xE9DAA8")]
	public void ReleaseTileStorage(WorldMapChunk chunk)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003412")]
	[Cpp2IlInjected.Address(RVA = "0xE9DBB8", Offset = "0xE9DBB8", VA = "0xE9DBB8")]
	public void UpdateChunks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003413")]
	[Cpp2IlInjected.Address(RVA = "0xE9DD80", Offset = "0xE9DD80", VA = "0xE9DD80")]
	public void Allocate(int maxWidth, int maxHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003414")]
	[Cpp2IlInjected.Address(RVA = "0xE9E238", Offset = "0xE9E238", VA = "0xE9E238")]
	public void ConsumeUpdate(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003415")]
	[Cpp2IlInjected.Address(RVA = "0xE9E27C", Offset = "0xE9E27C", VA = "0xE9E27C")]
	public void Update(int x, int y, byte light)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003416")]
	[Cpp2IlInjected.Address(RVA = "0xE9E344", Offset = "0xE9E344", VA = "0xE9E344")]
	public void SetTile(int x, int y, ref MapTile tile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003417")]
	[Cpp2IlInjected.Address(RVA = "0xE9E380", Offset = "0xE9E380", VA = "0xE9E380")]
	public bool IsRevealed(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003418")]
	[Cpp2IlInjected.Address(RVA = "0xE9ACE8", Offset = "0xE9ACE8", VA = "0xE9ACE8")]
	public bool UpdateLighting(int x, int y, byte light)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003419")]
	[Cpp2IlInjected.Address(RVA = "0xE9E3B0", Offset = "0xE9E3B0", VA = "0xE9E3B0")]
	public bool UpdateType(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600341A")]
	[Cpp2IlInjected.Address(RVA = "0xE9E4B4", Offset = "0xE9E4B4", VA = "0xE9E4B4")]
	public void UnlockMapSection(int sectionX, int sectionY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600341B")]
	[Cpp2IlInjected.Address(RVA = "0xE9E4B8", Offset = "0xE9E4B8", VA = "0xE9E4B8")]
	public void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600341C")]
	[Cpp2IlInjected.Address(RVA = "0xE9F25C", Offset = "0xE9F25C", VA = "0xE9F25C")]
	public void Save(bool forceSave = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600341D")]
	[Cpp2IlInjected.Address(RVA = "0xE9E1D4", Offset = "0xE9E1D4", VA = "0xE9E1D4")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600341E")]
	[Cpp2IlInjected.Address(RVA = "0xE9F0A4", Offset = "0xE9F0A4", VA = "0xE9F0A4")]
	public void ClearEdges()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600341F")]
	[Cpp2IlInjected.Address(RVA = "0xE9F428", Offset = "0xE9F428", VA = "0xE9F428")]
	public WorldMap()
	{
	}
}
