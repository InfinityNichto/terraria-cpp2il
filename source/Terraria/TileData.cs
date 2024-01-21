using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200034D")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384EEC", Offset = "0x384EEC")]
[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x384EEC", Offset = "0x384EEC")]
[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x384EEC", Offset = "0x384EEC")]
public class TileData
{
	[Cpp2IlInjected.Token(Token = "0x4002F76")]
	public unsafe static uint* tileLookupPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F77")]
	public unsafe static ushort* tileTypeDataPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F78")]
	public unsafe static short* tileTypeSHeaderPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F79")]
	public unsafe static byte* tileTypeBHeaderPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F7A")]
	public unsafe static byte* tileTypeLiquidPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F7B")]
	public unsafe static short* tileTypeFrameXPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F7C")]
	public unsafe static short* tileTypeFrameYPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F7D")]
	public unsafe static ushort* tileWallDataPtr;

	[Cpp2IlInjected.Token(Token = "0x4002F7E")]
	public static long NPCState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002F7F")]
	private int _width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002F80")]
	private int _height;

	[Cpp2IlInjected.Token(Token = "0x4002F81")]
	private const int TileBufferSize = 200000;

	[Cpp2IlInjected.Token(Token = "0x4002F82")]
	private const uint TileBufferNoEntry = uint.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4002F83")]
	public unsafe static uint* TileLookup;

	[Cpp2IlInjected.Token(Token = "0x4002F84")]
	public unsafe static int* TileReferenceCount;

	[Cpp2IlInjected.Token(Token = "0x4002F85")]
	private static uint FreeTiles;

	[Cpp2IlInjected.Token(Token = "0x4002F86")]
	public unsafe static ushort* TileSeachUID;

	[Cpp2IlInjected.Token(Token = "0x4002F87")]
	private static int TotalTileCount;

	[Cpp2IlInjected.Token(Token = "0x4002F88")]
	private unsafe static uint* TileLists;

	[Cpp2IlInjected.Token(Token = "0x4002F89")]
	private unsafe static uint* TileListNext;

	[Cpp2IlInjected.Token(Token = "0x4002F8A")]
	private unsafe static uint* TileListPrevious;

	[Cpp2IlInjected.Token(Token = "0x4002F8B")]
	public unsafe static ushort* TileType;

	[Cpp2IlInjected.Token(Token = "0x4002F8C")]
	public unsafe static short* TileSHeader;

	[Cpp2IlInjected.Token(Token = "0x4002F8D")]
	public unsafe static short* TileFrameX;

	[Cpp2IlInjected.Token(Token = "0x4002F8E")]
	public unsafe static short* TileFrameY;

	[Cpp2IlInjected.Token(Token = "0x4002F8F")]
	public unsafe static ushort* TileWall;

	[Cpp2IlInjected.Token(Token = "0x4002F90")]
	public unsafe static byte* TileLiquid;

	[Cpp2IlInjected.Token(Token = "0x4002F91")]
	public unsafe static byte* TileBHeader;

	[Cpp2IlInjected.Token(Token = "0x4002F92")]
	public unsafe static byte* TileBHeader2;

	[Cpp2IlInjected.Token(Token = "0x4002F93")]
	public unsafe static byte* TileBHeader3;

	[Cpp2IlInjected.Token(Token = "0x1700058D")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399AE0", Offset = "0x399AE0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x399AE0", Offset = "0x399AE0")]
	public Tile Item
	{
		[Cpp2IlInjected.Token(Token = "0x600283A")]
		[Cpp2IlInjected.Address(RVA = "0x14DE2AC", Offset = "0x14DE2AC", VA = "0x14DE2AC")]
		get
		{
			return default(Tile);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002837")]
	[Cpp2IlInjected.Address(RVA = "0x14EE748", Offset = "0x14EE748", VA = "0x14EE748")]
	public static void ReleasePointers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002838")]
	[Cpp2IlInjected.Address(RVA = "0x14EE800", Offset = "0x14EE800", VA = "0x14EE800")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39120C", Offset = "0x39120C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39120C", Offset = "0x39120C")]
	public Tile Safe(int x, int y)
	{
		return default(Tile);
	}

	[Cpp2IlInjected.Token(Token = "0x6002839")]
	[Cpp2IlInjected.Address(RVA = "0x14EE80C", Offset = "0x14EE80C", VA = "0x14EE80C")]
	public bool ConfirmWidthHeight(int width, int height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600283B")]
	[Cpp2IlInjected.Address(RVA = "0x14EE830", Offset = "0x14EE830", VA = "0x14EE830")]
	public static long CalculateWorldTileSize(int x, int y)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600283C")]
	[Cpp2IlInjected.Address(RVA = "0x14EE870", Offset = "0x14EE870", VA = "0x14EE870")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3912C0", Offset = "0x3912C0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3912C0", Offset = "0x3912C0")]
	public void Allocate(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600283D")]
	[Cpp2IlInjected.Address(RVA = "0x14EB954", Offset = "0x14EB954", VA = "0x14EB954")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391374", Offset = "0x391374")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391374", Offset = "0x391374")]
	public static void ClearEverything(int tileIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600283E")]
	[Cpp2IlInjected.Address(RVA = "0x14EBB30", Offset = "0x14EBB30", VA = "0x14EBB30")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391428", Offset = "0x391428")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391428", Offset = "0x391428")]
	public static void SetEverything(int tileIndex, ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3, byte wall, byte liquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600283F")]
	[Cpp2IlInjected.Address(RVA = "0x14E96E0", Offset = "0x14E96E0", VA = "0x14E96E0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3914DC", Offset = "0x3914DC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3914DC", Offset = "0x3914DC")]
	public static void ReregisterTile(int tileIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002840")]
	[Cpp2IlInjected.Address(RVA = "0x14E9598", Offset = "0x14E9598", VA = "0x14E9598")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391590", Offset = "0x391590")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391590", Offset = "0x391590")]
	public static bool HasBeenLoaded(int tileIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002841")]
	[Cpp2IlInjected.Address(RVA = "0x14EF84C", Offset = "0x14EF84C", VA = "0x14EF84C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391644", Offset = "0x391644")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391644", Offset = "0x391644")]
	public static ushort GetType(int tileIndex)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6002842")]
	[Cpp2IlInjected.Address(RVA = "0x14E9848", Offset = "0x14E9848", VA = "0x14E9848")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3916F8", Offset = "0x3916F8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3916F8", Offset = "0x3916F8")]
	public static void SetType(int tileIndex, ushort newType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002843")]
	[Cpp2IlInjected.Address(RVA = "0x14EF8D8", Offset = "0x14EF8D8", VA = "0x14EF8D8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3917AC", Offset = "0x3917AC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3917AC", Offset = "0x3917AC")]
	public static short GetSHeader(int tileIndex)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6002844")]
	[Cpp2IlInjected.Address(RVA = "0x14EA028", Offset = "0x14EA028", VA = "0x14EA028")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391860", Offset = "0x391860")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391860", Offset = "0x391860")]
	public static void SetSHeader(int tileIndex, short sHeader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002845")]
	[Cpp2IlInjected.Address(RVA = "0x14EF978", Offset = "0x14EF978", VA = "0x14EF978")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391914", Offset = "0x391914")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391914", Offset = "0x391914")]
	public static short GetFrameX(int tileIndex)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6002846")]
	[Cpp2IlInjected.Address(RVA = "0x14EAF7C", Offset = "0x14EAF7C", VA = "0x14EAF7C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3919C8", Offset = "0x3919C8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3919C8", Offset = "0x3919C8")]
	public static void SetFrameXY(int tileIndex, short frameX, short frameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002847")]
	[Cpp2IlInjected.Address(RVA = "0x14EACCC", Offset = "0x14EACCC", VA = "0x14EACCC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391A7C", Offset = "0x391A7C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391A7C", Offset = "0x391A7C")]
	public static void SetFrameX(int tileIndex, short frameX)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002848")]
	[Cpp2IlInjected.Address(RVA = "0x14EFA04", Offset = "0x14EFA04", VA = "0x14EFA04")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391B30", Offset = "0x391B30")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391B30", Offset = "0x391B30")]
	public static short GetFrameY(int tileIndex)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6002849")]
	[Cpp2IlInjected.Address(RVA = "0x14EB278", Offset = "0x14EB278", VA = "0x14EB278")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391BE4", Offset = "0x391BE4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391BE4", Offset = "0x391BE4")]
	public static void SetFrameY(int tileIndex, short frameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600284A")]
	[Cpp2IlInjected.Address(RVA = "0x14EB63C", Offset = "0x14EB63C", VA = "0x14EB63C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391C98", Offset = "0x391C98")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391C98", Offset = "0x391C98")]
	public static ushort GetSearchUID(int tileIndex)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600284B")]
	[Cpp2IlInjected.Address(RVA = "0x14EB748", Offset = "0x14EB748", VA = "0x14EB748")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391D4C", Offset = "0x391D4C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391D4C", Offset = "0x391D4C")]
	public static void SetSearchUID(int tileIndex, ushort value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600284C")]
	[Cpp2IlInjected.Address(RVA = "0x14ECA38", Offset = "0x14ECA38", VA = "0x14ECA38")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391E00", Offset = "0x391E00")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391E00", Offset = "0x391E00")]
	public static bool GetCheckingLiquid(int tileIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600284D")]
	[Cpp2IlInjected.Address(RVA = "0x14ECB4C", Offset = "0x14ECB4C", VA = "0x14ECB4C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391EB4", Offset = "0x391EB4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391EB4", Offset = "0x391EB4")]
	public static void SetCheckingLiquid(int tileIndex, bool checkingLiquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600284E")]
	[Cpp2IlInjected.Address(RVA = "0x14ECC98", Offset = "0x14ECC98", VA = "0x14ECC98")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391F68", Offset = "0x391F68")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x391F68", Offset = "0x391F68")]
	public static bool GetSkipLiquid(int tileIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600284F")]
	[Cpp2IlInjected.Address(RVA = "0x14ECDA4", Offset = "0x14ECDA4", VA = "0x14ECDA4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39201C", Offset = "0x39201C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39201C", Offset = "0x39201C")]
	public static void SetSkipLiquid(int tileIndex, bool skipLiquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002850")]
	[Cpp2IlInjected.Address(RVA = "0x14ECEF4", Offset = "0x14ECEF4", VA = "0x14ECEF4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3920D0", Offset = "0x3920D0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3920D0", Offset = "0x3920D0")]
	public static bool GetTileFramed(int tileIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002851")]
	[Cpp2IlInjected.Address(RVA = "0x14ED000", Offset = "0x14ED000", VA = "0x14ED000")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392184", Offset = "0x392184")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392184", Offset = "0x392184")]
	public static void SetTileFramed(int tileIndex, bool framed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002852")]
	[Cpp2IlInjected.Address(RVA = "0x14EFA90", Offset = "0x14EFA90", VA = "0x14EFA90")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392238", Offset = "0x392238")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392238", Offset = "0x392238")]
	public static ushort GetWall(int tileIndex)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6002853")]
	[Cpp2IlInjected.Address(RVA = "0x14E9BC8", Offset = "0x14E9BC8", VA = "0x14E9BC8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3922EC", Offset = "0x3922EC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3922EC", Offset = "0x3922EC")]
	public static void SetWall(int tileIndex, ushort wall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002854")]
	[Cpp2IlInjected.Address(RVA = "0x14EFB14", Offset = "0x14EFB14", VA = "0x14EFB14")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3923A0", Offset = "0x3923A0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3923A0", Offset = "0x3923A0")]
	public static byte GetLiquid(int tileIndex)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002855")]
	[Cpp2IlInjected.Address(RVA = "0x14E9DF0", Offset = "0x14E9DF0", VA = "0x14E9DF0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392454", Offset = "0x392454")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392454", Offset = "0x392454")]
	public static void SetLiquid(int tileIndex, byte liquid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002856")]
	[Cpp2IlInjected.Address(RVA = "0x14EFB94", Offset = "0x14EFB94", VA = "0x14EFB94")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392508", Offset = "0x392508")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392508", Offset = "0x392508")]
	public static byte GetBHeader(int tileIndex)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002857")]
	[Cpp2IlInjected.Address(RVA = "0x14EA3FC", Offset = "0x14EA3FC", VA = "0x14EA3FC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3925BC", Offset = "0x3925BC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3925BC", Offset = "0x3925BC")]
	public static void SetBHeader(int tileIndex, byte bHeader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002858")]
	[Cpp2IlInjected.Address(RVA = "0x14EFC1C", Offset = "0x14EFC1C", VA = "0x14EFC1C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392670", Offset = "0x392670")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392670", Offset = "0x392670")]
	public static byte GetBHeader2(int tileIndex)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6002859")]
	[Cpp2IlInjected.Address(RVA = "0x14EA720", Offset = "0x14EA720", VA = "0x14EA720")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392724", Offset = "0x392724")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392724", Offset = "0x392724")]
	public static void SetBHeader2(int tileIndex, byte bHeader2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600285A")]
	[Cpp2IlInjected.Address(RVA = "0x14EFCA4", Offset = "0x14EFCA4", VA = "0x14EFCA4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3927D8", Offset = "0x3927D8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3927D8", Offset = "0x3927D8")]
	public static void CopyTileBasic(int tileIndex, int srcTile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600285B")]
	[Cpp2IlInjected.Address(RVA = "0x14EBD6C", Offset = "0x14EBD6C", VA = "0x14EBD6C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39288C", Offset = "0x39288C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39288C", Offset = "0x39288C")]
	public static void CopyTile(int tileIndex, int srcTile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600285C")]
	[Cpp2IlInjected.Address(RVA = "0x14EFD54", Offset = "0x14EFD54", VA = "0x14EFD54")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392940", Offset = "0x392940")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392940", Offset = "0x392940")]
	public static byte GetBHeader3(int tileIndex)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600285D")]
	[Cpp2IlInjected.Address(RVA = "0x14EAA40", Offset = "0x14EAA40", VA = "0x14EAA40")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3929F4", Offset = "0x3929F4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3929F4", Offset = "0x3929F4")]
	public static void SetBHeader3(int tileIndex, byte bHeader3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600285E")]
	[Cpp2IlInjected.Address(RVA = "0x14EFDDC", Offset = "0x14EFDDC", VA = "0x14EFDDC")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392AA8", Offset = "0x392AA8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392AA8", Offset = "0x392AA8")]
	private static uint GetFreeListEntry()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600285F")]
	[Cpp2IlInjected.Address(RVA = "0x14EFE94", Offset = "0x14EFE94", VA = "0x14EFE94")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392B5C", Offset = "0x392B5C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392B5C", Offset = "0x392B5C")]
	private static void AddFreeEntry(uint tileDefinition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002860")]
	[Cpp2IlInjected.Address(RVA = "0x14EF0D0", Offset = "0x14EF0D0", VA = "0x14EF0D0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392C10", Offset = "0x392C10")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392C10", Offset = "0x392C10")]
	public static uint GetTileDefinition(int tileIndex, ushort tileType, short tileSHeader, short frameX, short frameY, byte tileBHeader, byte tileBHeader2, byte tileBHeader3)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6002861")]
	[Cpp2IlInjected.Address(RVA = "0x14EF59C", Offset = "0x14EF59C", VA = "0x14EF59C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392CC4", Offset = "0x392CC4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x392CC4", Offset = "0x392CC4")]
	public static void ReleaseTileDefinition(uint tileDefinition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002862")]
	[Cpp2IlInjected.Address(RVA = "0x14EFF50", Offset = "0x14EFF50", VA = "0x14EFF50")]
	public TileData()
	{
	}
}
