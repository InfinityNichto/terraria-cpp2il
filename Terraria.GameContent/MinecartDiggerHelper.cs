using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000542")]
public class MinecartDiggerHelper
{
	[Cpp2IlInjected.Token(Token = "0x40068B2")]
	public static MinecartDiggerHelper Instance;

	[Cpp2IlInjected.Token(Token = "0x600398A")]
	[Cpp2IlInjected.Address(RVA = "0x1059880", Offset = "0x1059880", VA = "0x1059880")]
	public void TryDigging(Player player, Vector2 trackWorldPosition, int digDirectionX, int digDirectionY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600398B")]
	[Cpp2IlInjected.Address(RVA = "0x1059F98", Offset = "0x1059F98", VA = "0x1059F98")]
	private bool CanConsumeATrackItem(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600398C")]
	[Cpp2IlInjected.Address(RVA = "0x105A1AC", Offset = "0x105A1AC", VA = "0x105A1AC")]
	private void ConsumeATrackItem(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600398D")]
	[Cpp2IlInjected.Address(RVA = "0x105A578", Offset = "0x105A578", VA = "0x105A578")]
	private Item FindMinecartTrackItem(Player player)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600398E")]
	[Cpp2IlInjected.Address(RVA = "0x105A5F8", Offset = "0x105A5F8", VA = "0x105A5F8")]
	private void PoundTrack(Point spot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600398F")]
	[Cpp2IlInjected.Address(RVA = "0x1059B20", Offset = "0x1059B20", VA = "0x1059B20")]
	private bool AlreadyLeadsIntoWantedTrack(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003990")]
	[Cpp2IlInjected.Address(RVA = "0x105A7B0", Offset = "0x105A7B0", VA = "0x105A7B0")]
	private static void GetExpectedDirections(Point startCoords, Point endCoords, out int? expectedStartLeft, out int? expectedStartRight, out int? expectedEndLeft, out int? expectedEndRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003991")]
	[Cpp2IlInjected.Address(RVA = "0x105A338", Offset = "0x105A338", VA = "0x105A338")]
	private bool DoTheTracksConnectProperly(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003992")]
	[Cpp2IlInjected.Address(RVA = "0x105A358", Offset = "0x105A358", VA = "0x105A358")]
	private void CorrectTrackConnections(Point startCoords, Point endCoords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003993")]
	[Cpp2IlInjected.Address(RVA = "0x1059F84", Offset = "0x1059F84", VA = "0x1059F84")]
	private bool HasPickPower(Player player, int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003994")]
	[Cpp2IlInjected.Address(RVA = "0x1059D5C", Offset = "0x1059D5C", VA = "0x1059D5C")]
	private bool CanGetPastTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003995")]
	[Cpp2IlInjected.Address(RVA = "0x105A1D8", Offset = "0x105A1D8", VA = "0x105A1D8")]
	private void PlaceATrack(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003996")]
	[Cpp2IlInjected.Address(RVA = "0x1059FB0", Offset = "0x1059FB0", VA = "0x1059FB0")]
	private void MineTheTileIfNecessary(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003997")]
	[Cpp2IlInjected.Address(RVA = "0x105A90C", Offset = "0x105A90C", VA = "0x105A90C")]
	public MinecartDiggerHelper()
	{
	}
}
