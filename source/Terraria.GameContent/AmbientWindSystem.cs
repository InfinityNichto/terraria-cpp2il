using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000545")]
public class AmbientWindSystem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068C2")]
	private UnifiedRandom _random;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068C3")]
	private List<Point> _spotsForAirboneWind;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068C4")]
	private int _updatesCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40068C5")]
	private int _lastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40068C6")]
	private float _airSpaceTests;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40068C7")]
	private float _floorSpaceTests;

	[Cpp2IlInjected.Token(Token = "0x60039BC")]
	[Cpp2IlInjected.Address(RVA = "0xFB000C", Offset = "0xFB000C", VA = "0xFB000C")]
	public AmbientWindSystem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039BD")]
	[Cpp2IlInjected.Address(RVA = "0xFB00BC", Offset = "0xFB00BC", VA = "0xFB00BC")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039BE")]
	[Cpp2IlInjected.Address(RVA = "0xFB081C", Offset = "0xFB081C", VA = "0xFB081C")]
	private void SpawnAirborneWind()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039BF")]
	[Cpp2IlInjected.Address(RVA = "0xFB03F8", Offset = "0xFB03F8", VA = "0xFB03F8")]
	private Rectangle GetTileWorkSpace()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60039C0")]
	[Cpp2IlInjected.Address(RVA = "0xFB0650", Offset = "0xFB0650", VA = "0xFB0650")]
	private void TrySpawningWind(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039C1")]
	[Cpp2IlInjected.Address(RVA = "0xFB0964", Offset = "0xFB0964", VA = "0xFB0964")]
	private void SpawnAirborneCloud(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039C2")]
	[Cpp2IlInjected.Address(RVA = "0xFB0FA0", Offset = "0xFB0FA0", VA = "0xFB0FA0")]
	private void SpawnFloorCloud(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039C3")]
	[Cpp2IlInjected.Address(RVA = "0xFB04F8", Offset = "0xFB04F8", VA = "0xFB04F8")]
	private void TestAirCloud(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039C4")]
	[Cpp2IlInjected.Address(RVA = "0xFB12A8", Offset = "0xFB12A8", VA = "0xFB12A8")]
	private bool DoesTileAllowWind(Tile t)
	{
		return default(bool);
	}
}
