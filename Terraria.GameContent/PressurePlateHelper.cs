using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000544")]
public class PressurePlateHelper
{
	[Cpp2IlInjected.Token(Token = "0x40068BB")]
	public static object EntityCreationLock;

	[Cpp2IlInjected.Token(Token = "0x40068BC")]
	public static Dictionary<Point, bool[]> PressurePlatesPressed;

	[Cpp2IlInjected.Token(Token = "0x40068BD")]
	public static bool NeedsFirstUpdate;

	[Cpp2IlInjected.Token(Token = "0x40068BE")]
	private static Vector2[] PlayerLastPosition;

	[Cpp2IlInjected.Token(Token = "0x40068BF")]
	private static Rectangle pressurePlateBounds;

	[Cpp2IlInjected.Token(Token = "0x40068C0")]
	private static List<Point> tilesOld;

	[Cpp2IlInjected.Token(Token = "0x40068C1")]
	private static List<Point> tilesNew;

	[Cpp2IlInjected.Token(Token = "0x60039B1")]
	[Cpp2IlInjected.Address(RVA = "0x11A2A1C", Offset = "0x11A2A1C", VA = "0x11A2A1C")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B2")]
	[Cpp2IlInjected.Address(RVA = "0x11A2D64", Offset = "0x11A2D64", VA = "0x11A2D64")]
	public static void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B3")]
	[Cpp2IlInjected.Address(RVA = "0x11A2EFC", Offset = "0x11A2EFC", VA = "0x11A2EFC")]
	public static void ResetPlayer(int player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B4")]
	[Cpp2IlInjected.Address(RVA = "0x11A3210", Offset = "0x11A3210", VA = "0x11A3210")]
	public static void UpdatePlayerPosition(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B5")]
	[Cpp2IlInjected.Address(RVA = "0x11A3C68", Offset = "0x11A3C68", VA = "0x11A3C68")]
	public static void DestroyPlate(Point location)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B6")]
	[Cpp2IlInjected.Address(RVA = "0x11A3D78", Offset = "0x11A3D78", VA = "0x11A3D78")]
	private static void UpdatePlatePosition(Point location, int player, bool onIt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B7")]
	[Cpp2IlInjected.Address(RVA = "0x11A3A30", Offset = "0x11A3A30", VA = "0x11A3A30")]
	private static void MoveInto(Point location, int player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B8")]
	[Cpp2IlInjected.Address(RVA = "0x11A3008", Offset = "0x11A3008", VA = "0x11A3008")]
	private static void MoveAwayFrom(Point location, int player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039B9")]
	[Cpp2IlInjected.Address(RVA = "0x11A2C20", Offset = "0x11A2C20", VA = "0x11A2C20")]
	private static void PokeLocation(Point location)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039BA")]
	[Cpp2IlInjected.Address(RVA = "0x11A3E3C", Offset = "0x11A3E3C", VA = "0x11A3E3C")]
	public PressurePlateHelper()
	{
	}
}
