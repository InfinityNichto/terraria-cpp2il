using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F5")]
public class DeadMansChestBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x20009F3")]
	private class DartTrapPlacementAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CEA")]
		public int directionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CEB")]
		public int xPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008CEC")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008CED")]
		public int y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008CEE")]
		public Point position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008CEF")]
		public Tile t;

		[Cpp2IlInjected.Token(Token = "0x6004F7E")]
		[Cpp2IlInjected.Address(RVA = "0x1456474", Offset = "0x1456474", VA = "0x1456474")]
		public DartTrapPlacementAttempt(Point position, int directionX, int x, int y, int xPush, Tile t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009F4")]
	private class BoulderPlacementAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CF0")]
		public Point position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008CF1")]
		public int yPush;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008CF2")]
		public int requiredHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008CF3")]
		public int bestType;

		[Cpp2IlInjected.Token(Token = "0x6004F7F")]
		[Cpp2IlInjected.Address(RVA = "0x1456124", Offset = "0x1456124", VA = "0x1456124")]
		public BoulderPlacementAttempt(Point position, int yPush, int requiredHeight, int bestType)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009F5")]
	private class WirePlacementAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CF4")]
		public Point position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008CF5")]
		public int dirX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008CF6")]
		public int dirY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008CF7")]
		public int steps;

		[Cpp2IlInjected.Token(Token = "0x6004F80")]
		[Cpp2IlInjected.Address(RVA = "0x1455B68", Offset = "0x1455B68", VA = "0x1455B68")]
		public WirePlacementAttempt(Point position, int dirX, int dirY, int steps)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009F6")]
	private class ExplosivePlacementAttempt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CF8")]
		public Point position;

		[Cpp2IlInjected.Token(Token = "0x6004F81")]
		[Cpp2IlInjected.Address(RVA = "0x14566E8", Offset = "0x14566E8", VA = "0x14566E8")]
		public ExplosivePlacementAttempt(Point position)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BF0")]
	private List<DartTrapPlacementAttempt> _dartTrapPlacementSpots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006BF1")]
	private List<WirePlacementAttempt> _wirePlacementSpots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BF2")]
	private List<BoulderPlacementAttempt> _boulderPlacementSpots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006BF3")]
	private List<ExplosivePlacementAttempt> _explosivePlacementAttempt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BF4")]
	[JsonProperty]
	private IntRange _numberOfDartTraps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BF5")]
	[JsonProperty]
	private IntRange _numberOfBoulderTraps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006BF6")]
	[JsonProperty]
	private IntRange _numberOfStepsBetweenBoulderTraps;

	[Cpp2IlInjected.Token(Token = "0x6003DA4")]
	[Cpp2IlInjected.Address(RVA = "0x1453E3C", Offset = "0x1453E3C", VA = "0x1453E3C", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA5")]
	[Cpp2IlInjected.Address(RVA = "0x14558B0", Offset = "0x14558B0", VA = "0x14558B0")]
	private void PlaceWiresForExplosives(Point origin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA6")]
	[Cpp2IlInjected.Address(RVA = "0x1454EB4", Offset = "0x1454EB4", VA = "0x1454EB4")]
	private bool AreThereEnoughTraps()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA7")]
	[Cpp2IlInjected.Address(RVA = "0x14545A0", Offset = "0x14545A0", VA = "0x14545A0")]
	private void ClearCaches()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA8")]
	[Cpp2IlInjected.Address(RVA = "0x1454644", Offset = "0x1454644", VA = "0x1454644")]
	private void FindBoulderTrapSpots(Point position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA9")]
	[Cpp2IlInjected.Address(RVA = "0x1455A5C", Offset = "0x1455A5C", VA = "0x1455A5C")]
	private void FindBoulderTrapSpot(Point position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DAA")]
	[Cpp2IlInjected.Address(RVA = "0x1455BA8", Offset = "0x1455BA8", VA = "0x1455BA8")]
	private void PlaceBoulderTrapSpot(Point position, int yPush)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DAB")]
	[Cpp2IlInjected.Address(RVA = "0x14548F0", Offset = "0x14548F0", VA = "0x14548F0")]
	private void FindDartTrapSpots(Point position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DAC")]
	[Cpp2IlInjected.Address(RVA = "0x1456164", Offset = "0x1456164", VA = "0x1456164")]
	private bool FindDartTrapSpotSingle(Point position, int directionX)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DAD")]
	[Cpp2IlInjected.Address(RVA = "0x1454A98", Offset = "0x1454A98", VA = "0x1454A98")]
	private void FindExplosiveTrapSpots(Point position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DAE")]
	[Cpp2IlInjected.Address(RVA = "0x14564C0", Offset = "0x14564C0", VA = "0x14564C0")]
	private bool IsGoodSpotsForExplosive(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DAF")]
	[Cpp2IlInjected.Address(RVA = "0x1456710", Offset = "0x1456710", VA = "0x1456710")]
	public List<int> GetPossibleChestsToTrapify(StructureMap structures)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB0")]
	[Cpp2IlInjected.Address(RVA = "0x145431C", Offset = "0x145431C", VA = "0x145431C")]
	private static bool IsAGoodSpot(Point position)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB1")]
	[Cpp2IlInjected.Address(RVA = "0x1454F34", Offset = "0x1454F34", VA = "0x1454F34")]
	private void TurnGoldChestIntoDeadMansChest(Point position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB2")]
	[Cpp2IlInjected.Address(RVA = "0x145522C", Offset = "0x145522C", VA = "0x145522C")]
	private void ActuallyPlaceDartTrap(Point position, int directionX, int x, int y, int xPush, Tile t)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB3")]
	[Cpp2IlInjected.Address(RVA = "0x1455354", Offset = "0x1455354", VA = "0x1455354")]
	private void PlaceWireLine(Point start, int offsetX, int offsetY, int steps)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB4")]
	[Cpp2IlInjected.Address(RVA = "0x1455438", Offset = "0x1455438", VA = "0x1455438")]
	private void ActuallyPlaceBoulderTrap(Point position, int yPush, int requiredHeight, int bestType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB5")]
	[Cpp2IlInjected.Address(RVA = "0x1455770", Offset = "0x1455770", VA = "0x1455770")]
	private void ActuallyPlaceExplosive(Point position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB6")]
	[Cpp2IlInjected.Address(RVA = "0x14569FC", Offset = "0x14569FC", VA = "0x14569FC")]
	public DeadMansChestBiome()
	{
	}
}
