using System;
using System.Collections.Generic;
using System.IO;
using Cpp2IlInjected;
using Ionic.Zlib;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Map;

[Cpp2IlInjected.Token(Token = "0x20004A8")]
public static class MapHelper
{
	[Cpp2IlInjected.Token(Token = "0x200093A")]
	private class RunLengthEncodingCompressionProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008ACE")]
		public readonly uint BitCountPerValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008ACF")]
		public readonly uint BitCountForRunLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008AD0")]
		public readonly uint MinRepeatsToUseRunLengthEncoding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008AD1")]
		public readonly uint MaxCompressedValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008AD2")]
		public readonly uint MaxRunLengthRepeatValue;

		[Cpp2IlInjected.Token(Token = "0x6004CF6")]
		[Cpp2IlInjected.Address(RVA = "0xE9B044", Offset = "0xE9B044", VA = "0xE9B044")]
		public RunLengthEncodingCompressionProfile(uint numBitsPerValue, uint bitCountForRunLengths)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200093B")]
	private struct OldMapHelper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008AD3")]
		public byte misc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4008AD4")]
		public byte misc2;

		[Cpp2IlInjected.Token(Token = "0x6004CF7")]
		[Cpp2IlInjected.Address(RVA = "0x39A3A4", Offset = "0x39A3A4", VA = "0x39A3A4")]
		public bool active()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CF8")]
		[Cpp2IlInjected.Address(RVA = "0x39A3B0", Offset = "0x39A3B0", VA = "0x39A3B0")]
		public bool water()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CF9")]
		[Cpp2IlInjected.Address(RVA = "0x39A3BC", Offset = "0x39A3BC", VA = "0x39A3BC")]
		public bool lava()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CFA")]
		[Cpp2IlInjected.Address(RVA = "0x39A3C8", Offset = "0x39A3C8", VA = "0x39A3C8")]
		public bool honey()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CFB")]
		[Cpp2IlInjected.Address(RVA = "0x39A3D4", Offset = "0x39A3D4", VA = "0x39A3D4")]
		public bool changed()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CFC")]
		[Cpp2IlInjected.Address(RVA = "0x39A3E0", Offset = "0x39A3E0", VA = "0x39A3E0")]
		public bool wall()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CFD")]
		[Cpp2IlInjected.Address(RVA = "0x39A3EC", Offset = "0x39A3EC", VA = "0x39A3EC")]
		public byte option()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CFE")]
		[Cpp2IlInjected.Address(RVA = "0x39A410", Offset = "0x39A410", VA = "0x39A410")]
		public byte color()
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200093C")]
	public class BitReader
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008AD5")]
		private readonly Stream InnerStream;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008AD6")]
		private byte CurByteOfData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008AD7")]
		private uint CurBit;

		[Cpp2IlInjected.Token(Token = "0x6004CFF")]
		[Cpp2IlInjected.Address(RVA = "0xE9AE3C", Offset = "0xE9AE3C", VA = "0xE9AE3C")]
		public BitReader(Stream input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D00")]
		[Cpp2IlInjected.Address(RVA = "0xE9AE64", Offset = "0xE9AE64", VA = "0xE9AE64")]
		public uint Read(uint bitCount)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006567")]
	public static int maxUpdateTile;

	[Cpp2IlInjected.Token(Token = "0x4006568")]
	public static int numUpdateTile;

	[Cpp2IlInjected.Token(Token = "0x4006569")]
	public static short[] updateTileX;

	[Cpp2IlInjected.Token(Token = "0x400656A")]
	public static short[] updateTileY;

	[Cpp2IlInjected.Token(Token = "0x400656B")]
	public static bool noStatusText;

	[Cpp2IlInjected.Token(Token = "0x400656C")]
	public const int drawLoopMilliseconds = 5;

	[Cpp2IlInjected.Token(Token = "0x400656D")]
	public const int drawMapLoadingLoopMilliseconds = 30;

	[Cpp2IlInjected.Token(Token = "0x400656E")]
	private const int HeaderEmpty = 0;

	[Cpp2IlInjected.Token(Token = "0x400656F")]
	private const int HeaderTile = 1;

	[Cpp2IlInjected.Token(Token = "0x4006570")]
	private const int HeaderWall = 2;

	[Cpp2IlInjected.Token(Token = "0x4006571")]
	private const int HeaderWater = 3;

	[Cpp2IlInjected.Token(Token = "0x4006572")]
	private const int HeaderLava = 4;

	[Cpp2IlInjected.Token(Token = "0x4006573")]
	private const int HeaderHoney = 5;

	[Cpp2IlInjected.Token(Token = "0x4006574")]
	private const int HeaderHeavenAndHell = 6;

	[Cpp2IlInjected.Token(Token = "0x4006575")]
	private const int HeaderBackground = 7;

	[Cpp2IlInjected.Token(Token = "0x4006576")]
	private const int Header2_ReadHeader3Bit = 1;

	[Cpp2IlInjected.Token(Token = "0x4006577")]
	private const int Header2Color1 = 2;

	[Cpp2IlInjected.Token(Token = "0x4006578")]
	private const int Header2Color2 = 4;

	[Cpp2IlInjected.Token(Token = "0x4006579")]
	private const int Header2Color3 = 8;

	[Cpp2IlInjected.Token(Token = "0x400657A")]
	private const int Header2Color4 = 16;

	[Cpp2IlInjected.Token(Token = "0x400657B")]
	private const int Header2Color5 = 32;

	[Cpp2IlInjected.Token(Token = "0x400657C")]
	private const int Header2ShimmerBit = 64;

	[Cpp2IlInjected.Token(Token = "0x400657D")]
	private const int Header2_UnusedBit8 = 128;

	[Cpp2IlInjected.Token(Token = "0x400657E")]
	private const int Header3_ReservedForHeader4Bit = 1;

	[Cpp2IlInjected.Token(Token = "0x400657F")]
	private const int Header3_UnusudBit2 = 2;

	[Cpp2IlInjected.Token(Token = "0x4006580")]
	private const int Header3_UnusudBit3 = 4;

	[Cpp2IlInjected.Token(Token = "0x4006581")]
	private const int Header3_UnusudBit4 = 8;

	[Cpp2IlInjected.Token(Token = "0x4006582")]
	private const int Header3_UnusudBit5 = 16;

	[Cpp2IlInjected.Token(Token = "0x4006583")]
	private const int Header3_UnusudBit6 = 32;

	[Cpp2IlInjected.Token(Token = "0x4006584")]
	private const int Header3_UnusudBit7 = 64;

	[Cpp2IlInjected.Token(Token = "0x4006585")]
	private const int Header3_UnusudBit8 = 128;

	[Cpp2IlInjected.Token(Token = "0x4006586")]
	public const int maxTileOptions = 12;

	[Cpp2IlInjected.Token(Token = "0x4006587")]
	public const int maxWallOptions = 2;

	[Cpp2IlInjected.Token(Token = "0x4006588")]
	public const int maxLiquidTypes = 4;

	[Cpp2IlInjected.Token(Token = "0x4006589")]
	public const int maxSkyGradients = 256;

	[Cpp2IlInjected.Token(Token = "0x400658A")]
	public const int maxDirtGradients = 256;

	[Cpp2IlInjected.Token(Token = "0x400658B")]
	public const int maxRockGradients = 256;

	[Cpp2IlInjected.Token(Token = "0x400658C")]
	public static int[] tileOptionCounts;

	[Cpp2IlInjected.Token(Token = "0x400658D")]
	public static int[] wallOptionCounts;

	[Cpp2IlInjected.Token(Token = "0x400658E")]
	public static ushort[] tileLookup;

	[Cpp2IlInjected.Token(Token = "0x400658F")]
	public static ushort[] wallLookup;

	[Cpp2IlInjected.Token(Token = "0x4006590")]
	private static ushort tilePosition;

	[Cpp2IlInjected.Token(Token = "0x4006591")]
	public static ushort wallPosition;

	[Cpp2IlInjected.Token(Token = "0x4006592")]
	public static ushort liquidPosition;

	[Cpp2IlInjected.Token(Token = "0x4006593")]
	public static ushort skyPosition;

	[Cpp2IlInjected.Token(Token = "0x4006594")]
	public static ushort dirtPosition;

	[Cpp2IlInjected.Token(Token = "0x4006595")]
	public static ushort rockPosition;

	[Cpp2IlInjected.Token(Token = "0x4006596")]
	public static ushort hellPosition;

	[Cpp2IlInjected.Token(Token = "0x4006597")]
	public static Color[] colorLookup;

	[Cpp2IlInjected.Token(Token = "0x4006598")]
	public static Dictionary<ushort, bool> snowLookup;

	[Cpp2IlInjected.Token(Token = "0x4006599")]
	private static ushort wallRangeStart;

	[Cpp2IlInjected.Token(Token = "0x400659A")]
	private static ushort wallRangeEnd;

	[Cpp2IlInjected.Token(Token = "0x17000653")]
	private static object IOLock
	{
		[Cpp2IlInjected.Token(Token = "0x60033DE")]
		[Cpp2IlInjected.Address(RVA = "0x14C4F9C", Offset = "0x14C4F9C", VA = "0x14C4F9C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60033DF")]
	[Cpp2IlInjected.Address(RVA = "0x14C5018", Offset = "0x14C5018", VA = "0x14C5018")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033E0")]
	[Cpp2IlInjected.Address(RVA = "0x14D02D0", Offset = "0x14D02D0", VA = "0x14D02D0")]
	public static void ResetMapData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033E1")]
	[Cpp2IlInjected.Address(RVA = "0x14D034C", Offset = "0x14D034C", VA = "0x14D034C")]
	public static bool HasOption(int tileType, int option)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60033E2")]
	[Cpp2IlInjected.Address(RVA = "0x14D03E0", Offset = "0x14D03E0", VA = "0x14D03E0")]
	public static int TileToLookup(int tileType, int option)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60033E3")]
	[Cpp2IlInjected.Address(RVA = "0x14D046C", Offset = "0x14D046C", VA = "0x14D046C")]
	public static int LookupCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60033E4")]
	[Cpp2IlInjected.Address(RVA = "0x14D04E8", Offset = "0x14D04E8", VA = "0x14D04E8")]
	public static void MapColor(ushort type, ref Color oldColor, byte colorType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033E5")]
	[Cpp2IlInjected.Address(RVA = "0x14D0784", Offset = "0x14D0784", VA = "0x14D0784")]
	public static Color GetMapTileXnaColor(ref MapTile tile)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60033E6")]
	[Cpp2IlInjected.Address(RVA = "0x14D0960", Offset = "0x14D0960", VA = "0x14D0960")]
	public static MapTile CreateMapTile(int i, int j, byte Light)
	{
		return default(MapTile);
	}

	[Cpp2IlInjected.Token(Token = "0x60033E7")]
	[Cpp2IlInjected.Address(RVA = "0x14D1474", Offset = "0x14D1474", VA = "0x14D1474")]
	public static void GetTileBaseOption(int x, int y, int tileType, Tile tileCache, ref int baseOption)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033E8")]
	[Cpp2IlInjected.Address(RVA = "0x14D2A18", Offset = "0x14D2A18", VA = "0x14D2A18")]
	public static void GetTileBaseOption(int y, ushort tileType, int frameX, int frameY, ref int baseOption)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033E9")]
	[Cpp2IlInjected.Address(RVA = "0x14D34E8", Offset = "0x14D34E8", VA = "0x14D34E8")]
	public static void SaveMap(bool forceSave = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033EA")]
	[Cpp2IlInjected.Address(RVA = "0x14D38EC", Offset = "0x14D38EC", VA = "0x14D38EC")]
	private static void InternalSaveMapCompressed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033EB")]
	[Cpp2IlInjected.Address(RVA = "0x14D49E0", Offset = "0x14D49E0", VA = "0x14D49E0")]
	private static void InternalSaveMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033EC")]
	[Cpp2IlInjected.Address(RVA = "0x14D634C", Offset = "0x14D634C", VA = "0x14D634C")]
	private static void LoadMapHeader(BinaryReader fileIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033ED")]
	[Cpp2IlInjected.Address(RVA = "0x14D653C", Offset = "0x14D653C", VA = "0x14D653C")]
	private static void ReadRunLengthEncodingData(RunLengthEncodingCompressionProfile compressionProfile, DeflateStream deflateStream, Action<int, int, uint> dataRead)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033EE")]
	[Cpp2IlInjected.Address(RVA = "0x14D69B0", Offset = "0x14D69B0", VA = "0x14D69B0")]
	public static void LoadMapWithUltraCompression(MemoryStream wholeStream, bool isLocalMap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033EF")]
	[Cpp2IlInjected.Address(RVA = "0x14D6CD0", Offset = "0x14D6CD0", VA = "0x14D6CD0")]
	public static void LoadMapVersion1(BinaryReader fileIO, int release)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033F0")]
	[Cpp2IlInjected.Address(RVA = "0x14D7C24", Offset = "0x14D7C24", VA = "0x14D7C24")]
	public static void LoadMapVersion2(BinaryReader fileIO, int release)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60033F1")]
	[Cpp2IlInjected.Address(RVA = "0x14D8DA4", Offset = "0x14D8DA4", VA = "0x14D8DA4")]
	public static void LoadMapVersionCompressed(BinaryReader fileIO, int release)
	{
	}
}
