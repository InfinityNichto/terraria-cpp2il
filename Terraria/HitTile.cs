using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000316")]
public class HitTile
{
	[Cpp2IlInjected.Token(Token = "0x40021B2")]
	private static int lastCrack;

	[Cpp2IlInjected.Token(Token = "0x40021B3")]
	public const int xIndex = 0;

	[Cpp2IlInjected.Token(Token = "0x40021B4")]
	public const int yIndex = 1;

	[Cpp2IlInjected.Token(Token = "0x40021B5")]
	public const int damageIndex = 2;

	[Cpp2IlInjected.Token(Token = "0x40021B6")]
	public const int typeIndex = 3;

	[Cpp2IlInjected.Token(Token = "0x40021B7")]
	public const int timeToLiveIndex = 4;

	[Cpp2IlInjected.Token(Token = "0x40021B8")]
	public const int crackStyleIndex = 5;

	[Cpp2IlInjected.Token(Token = "0x40021B9")]
	public const int animationTimeElapsedIndex = 6;

	[Cpp2IlInjected.Token(Token = "0x40021BA")]
	public const int HitTileObjectCount = 7;

	[Cpp2IlInjected.Token(Token = "0x40021BB")]
	internal const int UNUSED = 0;

	[Cpp2IlInjected.Token(Token = "0x40021BC")]
	internal const int TILE = 1;

	[Cpp2IlInjected.Token(Token = "0x40021BD")]
	internal const int WALL = 2;

	[Cpp2IlInjected.Token(Token = "0x40021BE")]
	internal const int MAX_HITTILES = 500;

	[Cpp2IlInjected.Token(Token = "0x40021BF")]
	internal const int TIMETOLIVE = 60;

	[Cpp2IlInjected.Token(Token = "0x40021C0")]
	private static UnifiedRandom rand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40021C1")]
	public readonly int[] HitTileObjectData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40021C2")]
	private readonly int[] order;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40021C3")]
	private int bufferLocation;

	[Cpp2IlInjected.Token(Token = "0x6001991")]
	[Cpp2IlInjected.Address(RVA = "0x124F864", Offset = "0x124F864", VA = "0x124F864")]
	public static void ClearAllTilesAtThisLocation(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001992")]
	[Cpp2IlInjected.Address(RVA = "0x124F9B4", Offset = "0x124F9B4", VA = "0x124F9B4")]
	public void ClearThisTile(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001993")]
	[Cpp2IlInjected.Address(RVA = "0x124FCF0", Offset = "0x124FCF0", VA = "0x124FCF0")]
	public HitTile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001994")]
	[Cpp2IlInjected.Address(RVA = "0x124FDAC", Offset = "0x124FDAC", VA = "0x124FDAC")]
	private int NextCrackStyle()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001995")]
	[Cpp2IlInjected.Address(RVA = "0x124FE74", Offset = "0x124FE74", VA = "0x124FE74")]
	public int TryFinding(int x, int y, int hitType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001996")]
	[Cpp2IlInjected.Address(RVA = "0x124FEE8", Offset = "0x124FEE8", VA = "0x124FEE8")]
	public void TryClearingAndPruning(int x, int y, int hitType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001997")]
	[Cpp2IlInjected.Address(RVA = "0x124FF28", Offset = "0x124FF28", VA = "0x124FF28")]
	public int HitObject(int x, int y, int hitType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001998")]
	[Cpp2IlInjected.Address(RVA = "0x124FFC8", Offset = "0x124FFC8", VA = "0x124FFC8")]
	public void UpdatePosition(int tileId, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001999")]
	[Cpp2IlInjected.Address(RVA = "0x124FFFC", Offset = "0x124FFFC", VA = "0x124FFFC")]
	public int AddDamage(int tileId, int damageAmount, bool updateAmount = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600199A")]
	[Cpp2IlInjected.Address(RVA = "0x1250148", Offset = "0x1250148", VA = "0x1250148")]
	private void ClearEntryData(int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600199B")]
	[Cpp2IlInjected.Address(RVA = "0x125006C", Offset = "0x125006C", VA = "0x125006C")]
	private void SortSlots(int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600199C")]
	[Cpp2IlInjected.Address(RVA = "0x124FA28", Offset = "0x124FA28", VA = "0x124FA28")]
	public void Clear(int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600199D")]
	[Cpp2IlInjected.Address(RVA = "0x124FAA8", Offset = "0x124FAA8", VA = "0x124FAA8")]
	public void Prune()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600199E")]
	[Cpp2IlInjected.Address(RVA = "0x12501B8", Offset = "0x12501B8", VA = "0x12501B8")]
	public void DrawFreshAnimations(SpriteBatch spriteBatch)
	{
	}
}
