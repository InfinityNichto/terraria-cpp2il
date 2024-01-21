using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent.UI;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000354")]
public static class Wiring
{
	[Cpp2IlInjected.Token(Token = "0x4002FDD")]
	public static bool blockPlayerTeleportationForOneIteration;

	[Cpp2IlInjected.Token(Token = "0x4002FDE")]
	public static bool running;

	[Cpp2IlInjected.Token(Token = "0x4002FDF")]
	private static Dictionary<Point16, bool> _wireSkip;

	[Cpp2IlInjected.Token(Token = "0x4002FE0")]
	private static DoubleStack<Point16> _wireList;

	[Cpp2IlInjected.Token(Token = "0x4002FE1")]
	private static DoubleStack<byte> _wireDirectionList;

	[Cpp2IlInjected.Token(Token = "0x4002FE2")]
	private static Dictionary<Point16, byte> _toProcess;

	[Cpp2IlInjected.Token(Token = "0x4002FE3")]
	private static Queue<Point16> _GatesCurrent;

	[Cpp2IlInjected.Token(Token = "0x4002FE4")]
	private static Queue<Point16> _LampsToCheck;

	[Cpp2IlInjected.Token(Token = "0x4002FE5")]
	private static Queue<Point16> _GatesNext;

	[Cpp2IlInjected.Token(Token = "0x4002FE6")]
	private static Dictionary<Point16, bool> _GatesDone;

	[Cpp2IlInjected.Token(Token = "0x4002FE7")]
	private static Dictionary<Point16, byte> _PixelBoxTriggers;

	[Cpp2IlInjected.Token(Token = "0x4002FE8")]
	private static Vector2[] _teleport;

	[Cpp2IlInjected.Token(Token = "0x4002FE9")]
	private const int MaxPump = 20;

	[Cpp2IlInjected.Token(Token = "0x4002FEA")]
	private static int[] _inPumpX;

	[Cpp2IlInjected.Token(Token = "0x4002FEB")]
	private static int[] _inPumpY;

	[Cpp2IlInjected.Token(Token = "0x4002FEC")]
	private static int _numInPump;

	[Cpp2IlInjected.Token(Token = "0x4002FED")]
	private static int[] _outPumpX;

	[Cpp2IlInjected.Token(Token = "0x4002FEE")]
	private static int[] _outPumpY;

	[Cpp2IlInjected.Token(Token = "0x4002FEF")]
	private static int _numOutPump;

	[Cpp2IlInjected.Token(Token = "0x4002FF0")]
	private const int MaxMech = 1000;

	[Cpp2IlInjected.Token(Token = "0x4002FF1")]
	private static int[] _mechX;

	[Cpp2IlInjected.Token(Token = "0x4002FF2")]
	private static int[] _mechY;

	[Cpp2IlInjected.Token(Token = "0x4002FF3")]
	private static int _numMechs;

	[Cpp2IlInjected.Token(Token = "0x4002FF4")]
	private static int[] _mechTime;

	[Cpp2IlInjected.Token(Token = "0x4002FF5")]
	private static int _currentWireColor;

	[Cpp2IlInjected.Token(Token = "0x4002FF6")]
	private static int CurrentUser;

	[Cpp2IlInjected.Token(Token = "0x6002983")]
	[Cpp2IlInjected.Address(RVA = "0x12EB294", Offset = "0x12EB294", VA = "0x12EB294")]
	public static void SetCurrentUser(int plr = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002984")]
	[Cpp2IlInjected.Address(RVA = "0x12EB380", Offset = "0x12EB380", VA = "0x12EB380")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002985")]
	[Cpp2IlInjected.Address(RVA = "0x12EB7B8", Offset = "0x12EB7B8", VA = "0x12EB7B8")]
	public static void SkipWire(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002986")]
	[Cpp2IlInjected.Address(RVA = "0x12EB87C", Offset = "0x12EB87C", VA = "0x12EB87C")]
	public static void SkipWire(Point16 point)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002987")]
	[Cpp2IlInjected.Address(RVA = "0x12EB914", Offset = "0x12EB914", VA = "0x12EB914")]
	public static void ClearAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002988")]
	[Cpp2IlInjected.Address(RVA = "0x12EBAA8", Offset = "0x12EBAA8", VA = "0x12EBAA8")]
	public static void UpdateMech()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002989")]
	[Cpp2IlInjected.Address(RVA = "0x12ED288", Offset = "0x12ED288", VA = "0x12ED288")]
	public static void HitSwitch(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600298A")]
	[Cpp2IlInjected.Address(RVA = "0x12EE0E8", Offset = "0x12EE0E8", VA = "0x12EE0E8")]
	public static void PokeLogicGate(int lampX, int lampY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600298B")]
	[Cpp2IlInjected.Address(RVA = "0x12EE5E8", Offset = "0x12EE5E8", VA = "0x12EE5E8")]
	public static bool Actuate(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600298C")]
	[Cpp2IlInjected.Address(RVA = "0x12EEFE4", Offset = "0x12EEFE4", VA = "0x12EEFE4")]
	public static void ActuateForced(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600298D")]
	[Cpp2IlInjected.Address(RVA = "0x12EF104", Offset = "0x12EF104", VA = "0x12EF104")]
	public static void MassWireOperation(Point ps, Point pe, Player master)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600298E")]
	[Cpp2IlInjected.Address(RVA = "0x12EDF18", Offset = "0x12EDF18", VA = "0x12EDF18")]
	private static bool CheckMech(int i, int j, int time)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600298F")]
	[Cpp2IlInjected.Address(RVA = "0x12EF8EC", Offset = "0x12EF8EC", VA = "0x12EF8EC")]
	private static void XferWater()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002990")]
	[Cpp2IlInjected.Address(RVA = "0x12EC320", Offset = "0x12EC320", VA = "0x12EC320")]
	private static void TripWire(int left, int top, int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002991")]
	[Cpp2IlInjected.Address(RVA = "0x12F1394", Offset = "0x12F1394", VA = "0x12F1394")]
	private static void PixelBoxPass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002992")]
	[Cpp2IlInjected.Address(RVA = "0x12EE1E8", Offset = "0x12EE1E8", VA = "0x12EE1E8")]
	private static void LogicGatePass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002993")]
	[Cpp2IlInjected.Address(RVA = "0x12F1618", Offset = "0x12F1618", VA = "0x12F1618")]
	private static void CheckLogicGate(int lampX, int lampY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002994")]
	[Cpp2IlInjected.Address(RVA = "0x12EFEB0", Offset = "0x12EFEB0", VA = "0x12EFEB0")]
	private static void HitWire(DoubleStack<Point16> next, int wireType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002995")]
	[Cpp2IlInjected.Address(RVA = "0x12FB388", Offset = "0x12FB388", VA = "0x12FB388")]
	public static IEntitySource GetProjectileSource(int sourceTileX, int sourceTileY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002996")]
	[Cpp2IlInjected.Address(RVA = "0x12FB3FC", Offset = "0x12FB3FC", VA = "0x12FB3FC")]
	public static IEntitySource GetNPCSource(int sourceTileX, int sourceTileY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002997")]
	[Cpp2IlInjected.Address(RVA = "0x12FB470", Offset = "0x12FB470", VA = "0x12FB470")]
	public static IEntitySource GetItemSource(int sourceTileX, int sourceTileY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002998")]
	[Cpp2IlInjected.Address(RVA = "0x12F1ED8", Offset = "0x12F1ED8", VA = "0x12F1ED8")]
	private static void HitWireSingle(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002999")]
	[Cpp2IlInjected.Address(RVA = "0x12FBC34", Offset = "0x12FBC34", VA = "0x12FBC34")]
	public static void ToggleHolidayLight(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600299A")]
	[Cpp2IlInjected.Address(RVA = "0x12FBD5C", Offset = "0x12FBD5C", VA = "0x12FBD5C")]
	public static void ToggleHangingLantern(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600299B")]
	[Cpp2IlInjected.Address(RVA = "0x12FC2C0", Offset = "0x12FC2C0", VA = "0x12FC2C0")]
	public static void Toggle2x2Light(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600299C")]
	[Cpp2IlInjected.Address(RVA = "0x12FCB24", Offset = "0x12FCB24", VA = "0x12FCB24")]
	public static void ToggleLampPost(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600299D")]
	[Cpp2IlInjected.Address(RVA = "0x12FBB0C", Offset = "0x12FBB0C", VA = "0x12FBB0C")]
	public static void ToggleTorch(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600299E")]
	[Cpp2IlInjected.Address(RVA = "0x12FC9F4", Offset = "0x12FC9F4", VA = "0x12FC9F4")]
	public static void ToggleCandle(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600299F")]
	[Cpp2IlInjected.Address(RVA = "0x12FBFD8", Offset = "0x12FBFD8", VA = "0x12FBFD8")]
	public static void ToggleLamp(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A0")]
	[Cpp2IlInjected.Address(RVA = "0x12FC68C", Offset = "0x12FC68C", VA = "0x12FC68C")]
	public static void ToggleChandelier(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A1")]
	[Cpp2IlInjected.Address(RVA = "0x12FB7F8", Offset = "0x12FB7F8", VA = "0x12FB7F8")]
	public static void ToggleCampFire(int i, int j, Tile tileCache, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A2")]
	[Cpp2IlInjected.Address(RVA = "0x12FB4E4", Offset = "0x12FB4E4", VA = "0x12FB4E4")]
	public static void ToggleFirePlace(int i, int j, Tile theBlock, bool? forcedStateWhereTrueIsOn, bool doSkipWires)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A3")]
	[Cpp2IlInjected.Address(RVA = "0x12EDABC", Offset = "0x12EDABC", VA = "0x12EDABC")]
	private static void GeyserTrap(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A4")]
	[Cpp2IlInjected.Address(RVA = "0x12F0838", Offset = "0x12F0838", VA = "0x12F0838")]
	private static void Teleport()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A5")]
	[Cpp2IlInjected.Address(RVA = "0x12FCD3C", Offset = "0x12FCD3C", VA = "0x12FCD3C")]
	private static bool TeleporterHitboxIntersects(Rectangle teleporter, Rectangle entity)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029A6")]
	[Cpp2IlInjected.Address(RVA = "0x12EE870", Offset = "0x12EE870", VA = "0x12EE870")]
	private static void DeActive(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A7")]
	[Cpp2IlInjected.Address(RVA = "0x12EE724", Offset = "0x12EE724", VA = "0x12EE724")]
	private static void ReActive(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A8")]
	[Cpp2IlInjected.Address(RVA = "0x12EF434", Offset = "0x12EF434", VA = "0x12EF434")]
	private static void MassWireOperationInner(Player user, Point ps, Point pe, Vector2 dropPoint, bool dir, ref int wireCount, ref int actuatorCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029A9")]
	[Cpp2IlInjected.Address(RVA = "0x12FCE34", Offset = "0x12FCE34", VA = "0x12FCE34")]
	private static bool? MassWireOperationStep(Player user, Point pt, WiresUI.Settings.MultiToolMode mode, ref int wiresLeftToConsume, ref int actuatorsLeftToConstume)
	{
		return null;
	}
}
