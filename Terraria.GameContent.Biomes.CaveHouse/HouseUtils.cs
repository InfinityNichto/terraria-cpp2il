using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x200060F")]
public static class HouseUtils
{
	[Cpp2IlInjected.Token(Token = "0x4006C34")]
	private static readonly bool[] BlacklistedTiles;

	[Cpp2IlInjected.Token(Token = "0x4006C35")]
	private static readonly bool[] BeelistedTiles;

	[Cpp2IlInjected.Token(Token = "0x6003E57")]
	[Cpp2IlInjected.Address(RVA = "0x144D660", Offset = "0x144D660", VA = "0x144D660")]
	public static HouseBuilder CreateBuilder(Point origin, StructureMap structures)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E58")]
	[Cpp2IlInjected.Address(RVA = "0x144D8D8", Offset = "0x144D8D8", VA = "0x144D8D8")]
	private static List<Rectangle> CreateRooms(Point origin)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E59")]
	[Cpp2IlInjected.Address(RVA = "0x144F1B4", Offset = "0x144F1B4", VA = "0x144F1B4")]
	private static Rectangle FindRoom(Point origin)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E5A")]
	[Cpp2IlInjected.Address(RVA = "0x144F764", Offset = "0x144F764", VA = "0x144F764")]
	private static double GetRoomSolidPrecentage(Rectangle room)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E5B")]
	[Cpp2IlInjected.Address(RVA = "0x144F94C", Offset = "0x144F94C", VA = "0x144F94C")]
	private static int SortBiomeResults(Tuple<HouseType, int> item1, Tuple<HouseType, int> item2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E5C")]
	[Cpp2IlInjected.Address(RVA = "0x144DD64", Offset = "0x144DD64", VA = "0x144DD64")]
	private static bool AreRoomLocationsValid(IEnumerable<Rectangle> rooms)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E5D")]
	[Cpp2IlInjected.Address(RVA = "0x144E080", Offset = "0x144E080", VA = "0x144E080")]
	private static HouseType GetHouseType(IEnumerable<Rectangle> rooms)
	{
		return default(HouseType);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E5E")]
	[Cpp2IlInjected.Address(RVA = "0x144E6C8", Offset = "0x144E6C8", VA = "0x144E6C8")]
	private static bool AreRoomsValid(IEnumerable<Rectangle> rooms, StructureMap structures, HouseType style)
	{
		return default(bool);
	}
}
