using Cpp2IlInjected;
using Terraria.Utilities;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000359")]
public class GenBase
{
	[Cpp2IlInjected.Token(Token = "0x2000899")]
	public delegate bool CustomPerUnitAction(int x, int y, params object[] args);

	[Cpp2IlInjected.Token(Token = "0x17000596")]
	protected static UnifiedRandom _random
	{
		[Cpp2IlInjected.Token(Token = "0x6002C61")]
		[Cpp2IlInjected.Address(RVA = "0x13003C0", Offset = "0x13003C0", VA = "0x13003C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000597")]
	protected static TileData _tiles
	{
		[Cpp2IlInjected.Token(Token = "0x6002C62")]
		[Cpp2IlInjected.Address(RVA = "0x1300434", Offset = "0x1300434", VA = "0x1300434")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000598")]
	protected static int _worldWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6002C63")]
		[Cpp2IlInjected.Address(RVA = "0x13004AC", Offset = "0x13004AC", VA = "0x13004AC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000599")]
	protected static int _worldHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6002C64")]
		[Cpp2IlInjected.Address(RVA = "0x1300524", Offset = "0x1300524", VA = "0x1300524")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002C65")]
	[Cpp2IlInjected.Address(RVA = "0x13003B8", Offset = "0x13003B8", VA = "0x13003B8")]
	public GenBase()
	{
	}
}
