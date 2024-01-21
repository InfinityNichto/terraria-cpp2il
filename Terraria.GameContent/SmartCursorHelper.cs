using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000568")]
public class SmartCursorHelper
{
	[Cpp2IlInjected.Token(Token = "0x200098C")]
	private class SmartCursorUsageInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C48")]
		public Player player;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C49")]
		public Item item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008C4A")]
		public Vector2 mouse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008C4B")]
		public Vector2 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008C4C")]
		public Vector2 Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008C4D")]
		public int screenTargetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008C4E")]
		public int screenTargetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008C4F")]
		public int reachableStartX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4008C50")]
		public int reachableEndX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4008C51")]
		public int reachableStartY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4008C52")]
		public int reachableEndY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4008C53")]
		public int paintLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4008C54")]
		public int paintCoatingLookup;

		[Cpp2IlInjected.Token(Token = "0x6004DFF")]
		[Cpp2IlInjected.Address(RVA = "0x1275C78", Offset = "0x1275C78", VA = "0x1275C78")]
		public SmartCursorUsageInfo()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006947")]
	private static List<int> _targetsInt;

	[Cpp2IlInjected.Token(Token = "0x4006948")]
	private static List<int> _points;

	[Cpp2IlInjected.Token(Token = "0x4006949")]
	private static List<int> _endpoints;

	[Cpp2IlInjected.Token(Token = "0x400694A")]
	private static List<Tuple<int, int>> _targets;

	[Cpp2IlInjected.Token(Token = "0x400694B")]
	private static List<int> _grappleTargets;

	[Cpp2IlInjected.Token(Token = "0x400694C")]
	private static List<Tuple<int, int>> _toRemove;

	[Cpp2IlInjected.Token(Token = "0x400694D")]
	private static List<Tuple<int, int>> _targets2;

	[Cpp2IlInjected.Token(Token = "0x400694E")]
	private static SmartCursorUsageInfo providedInfo;

	[Cpp2IlInjected.Token(Token = "0x400694F")]
	private static List<int> _torchPositions;

	[Cpp2IlInjected.Token(Token = "0x4006950")]
	private const int rangeToAvoidOtherTorches = 8;

	[Cpp2IlInjected.Token(Token = "0x6003A8A")]
	[Cpp2IlInjected.Address(RVA = "0x13CE334", Offset = "0x13CE334", VA = "0x13CE334")]
	public static void SmartCursorLookup(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A8B")]
	[Cpp2IlInjected.Address(RVA = "0x13CF2CC", Offset = "0x13CF2CC", VA = "0x13CF2CC")]
	private static void TryFindingPaintInplayerInventory(SmartCursorUsageInfo providedInfo, out int paintLookup, out int coatingLookup)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A8C")]
	[Cpp2IlInjected.Address(RVA = "0x13CEF20", Offset = "0x13CEF20", VA = "0x13CEF20")]
	private static bool IsHoveringOverAnInteractibleTileThatBlocksSmartCursor(SmartCursorUsageInfo providedInfo)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A8D")]
	[Cpp2IlInjected.Address(RVA = "0x13E79A4", Offset = "0x13E79A4", VA = "0x13E79A4")]
	private static void Step_StaffOfRegrowth(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A8E")]
	[Cpp2IlInjected.Address(RVA = "0x13DBFF8", Offset = "0x13DBFF8", VA = "0x13DBFF8")]
	private static void Step_GrassSeeds(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A8F")]
	[Cpp2IlInjected.Address(RVA = "0x13E7098", Offset = "0x13E7098", VA = "0x13E7098")]
	private static void Step_ClayPots(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A90")]
	[Cpp2IlInjected.Address(RVA = "0x13E6600", Offset = "0x13E6600", VA = "0x13E6600")]
	private static void Step_PlanterBox(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A91")]
	[Cpp2IlInjected.Address(RVA = "0x13E5A70", Offset = "0x13E5A70", VA = "0x13E5A70")]
	private static void Step_AlchemySeeds(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A92")]
	[Cpp2IlInjected.Address(RVA = "0x13E53AC", Offset = "0x13E53AC", VA = "0x13E53AC")]
	private static void Step_Actuators(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A93")]
	[Cpp2IlInjected.Address(RVA = "0x13E4BFC", Offset = "0x13E4BFC", VA = "0x13E4BFC")]
	private static void Step_EmptyBuckets(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A94")]
	[Cpp2IlInjected.Address(RVA = "0x13E218C", Offset = "0x13E218C", VA = "0x13E218C")]
	private static void Step_PaintScrapper(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A95")]
	[Cpp2IlInjected.Address(RVA = "0x13E1A64", Offset = "0x13E1A64", VA = "0x13E1A64")]
	private static void Step_PaintBrush(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A96")]
	[Cpp2IlInjected.Address(RVA = "0x13E1278", Offset = "0x13E1278", VA = "0x13E1278")]
	private static void Step_PaintRoller(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A97")]
	[Cpp2IlInjected.Address(RVA = "0x13E02E8", Offset = "0x13E02E8", VA = "0x13E02E8")]
	private static void Step_BlocksLines(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A98")]
	[Cpp2IlInjected.Address(RVA = "0x13DD248", Offset = "0x13DD248", VA = "0x13DD248")]
	private static void Step_Boulders(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A99")]
	[Cpp2IlInjected.Address(RVA = "0x13DCA64", Offset = "0x13DCA64", VA = "0x13DCA64")]
	private static void Step_Pigronata(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A9A")]
	[Cpp2IlInjected.Address(RVA = "0x13DB698", Offset = "0x13DB698", VA = "0x13DB698")]
	private static void Step_PumpkinSeeds(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A9B")]
	[Cpp2IlInjected.Address(RVA = "0x13E8354", Offset = "0x13E8354", VA = "0x13E8354")]
	private static void Step_WallsCell(int x, int y, int cx, int cy, int minX, int minY, int maxX, int maxY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A9C")]
	[Cpp2IlInjected.Address(RVA = "0x13DAFCC", Offset = "0x13DAFCC", VA = "0x13DAFCC")]
	private static void Step_Walls(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A9D")]
	[Cpp2IlInjected.Address(RVA = "0x13D8314", Offset = "0x13D8314", VA = "0x13D8314")]
	private static void Step_MinecartTracks(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A9E")]
	[Cpp2IlInjected.Address(RVA = "0x13D71C8", Offset = "0x13D71C8", VA = "0x13D71C8")]
	private static void Step_Platforms(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A9F")]
	[Cpp2IlInjected.Address(RVA = "0x13D6B00", Offset = "0x13D6B00", VA = "0x13D6B00")]
	private static void Step_WireCutter(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA0")]
	[Cpp2IlInjected.Address(RVA = "0x13D644C", Offset = "0x13D644C", VA = "0x13D644C")]
	private static void Step_ActuationRod(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA1")]
	[Cpp2IlInjected.Address(RVA = "0x13D4CD8", Offset = "0x13D4CD8", VA = "0x13D4CD8")]
	private static void Step_Hammers(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA2")]
	[Cpp2IlInjected.Address(RVA = "0x13D3558", Offset = "0x13D3558", VA = "0x13D3558")]
	private static void Step_MulticolorWrench(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA3")]
	[Cpp2IlInjected.Address(RVA = "0x13D201C", Offset = "0x13D201C", VA = "0x13D201C")]
	private static void Step_ColoredWrenches(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA4")]
	[Cpp2IlInjected.Address(RVA = "0x13E2908", Offset = "0x13E2908", VA = "0x13E2908")]
	private static void Step_Acorns(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA5")]
	[Cpp2IlInjected.Address(RVA = "0x13E3AF8", Offset = "0x13E3AF8", VA = "0x13E3AF8")]
	private static void Step_GemCorns(SmartCursorUsageInfo providedInfo, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA6")]
	[Cpp2IlInjected.Address(RVA = "0x13CFDE4", Offset = "0x13CFDE4", VA = "0x13CFDE4")]
	private static void Step_ForceCursorToAnyMinableThing(SmartCursorUsageInfo providedInfo, ref int fX, ref int fY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA7")]
	[Cpp2IlInjected.Address(RVA = "0x13D01D0", Offset = "0x13D01D0", VA = "0x13D01D0")]
	private static void Step_Pickaxe_MineShinies(SmartCursorUsageInfo providedInfo, ref int fX, ref int fY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA8")]
	[Cpp2IlInjected.Address(RVA = "0x13D0910", Offset = "0x13D0910", VA = "0x13D0910")]
	private static void Step_Pickaxe_MineSolids(Player player, SmartCursorUsageInfo providedInfo, List<int> grappleTargets, ref int focusedX, ref int focusedY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AA9")]
	[Cpp2IlInjected.Address(RVA = "0x13CF330", Offset = "0x13CF330", VA = "0x13CF330")]
	private static void Step_Axe(SmartCursorUsageInfo providedInfo, ref int fX, ref int fY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AAA")]
	[Cpp2IlInjected.Address(RVA = "0x13DF318", Offset = "0x13DF318", VA = "0x13DF318")]
	private static void Step_BlocksFilling(SmartCursorUsageInfo providedInfo, ref int fX, ref int fY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AAB")]
	[Cpp2IlInjected.Address(RVA = "0x13E95EC", Offset = "0x13E95EC", VA = "0x13E95EC")]
	private static void UpdateTorchLocations(int LX, int LY, int HX, int HY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AAC")]
	[Cpp2IlInjected.Address(RVA = "0x13E97B4", Offset = "0x13E97B4", VA = "0x13E97B4")]
	private static bool IsNearExistingTorch(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AAD")]
	[Cpp2IlInjected.Address(RVA = "0x13DDD78", Offset = "0x13DDD78", VA = "0x13DDD78")]
	private static void Step_Torch(SmartCursorUsageInfo providedInfo, ref int fX, ref int fY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AAE")]
	[Cpp2IlInjected.Address(RVA = "0x13DEC84", Offset = "0x13DEC84", VA = "0x13DEC84")]
	private static void Step_LawnMower(SmartCursorUsageInfo providedInfo, ref int fX, ref int fY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AAF")]
	[Cpp2IlInjected.Address(RVA = "0x13E991C", Offset = "0x13E991C", VA = "0x13E991C")]
	public SmartCursorHelper()
	{
	}
}
