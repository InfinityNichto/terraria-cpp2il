using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.Tile_Entities;

[Cpp2IlInjected.Token(Token = "0x2000580")]
public class TELogicSensor : TileEntity
{
	[Cpp2IlInjected.Token(Token = "0x200099A")]
	public enum LogicCheckType
	{
		[Cpp2IlInjected.Token(Token = "0x4008C81")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4008C82")]
		Day,
		[Cpp2IlInjected.Token(Token = "0x4008C83")]
		Night,
		[Cpp2IlInjected.Token(Token = "0x4008C84")]
		PlayerAbove,
		[Cpp2IlInjected.Token(Token = "0x4008C85")]
		Water,
		[Cpp2IlInjected.Token(Token = "0x4008C86")]
		Lava,
		[Cpp2IlInjected.Token(Token = "0x4008C87")]
		Honey,
		[Cpp2IlInjected.Token(Token = "0x4008C88")]
		Liquid
	}

	[Cpp2IlInjected.Token(Token = "0x4006AF5")]
	private static byte _myEntityID;

	[Cpp2IlInjected.Token(Token = "0x4006AF6")]
	private static Dictionary<int, Rectangle> playerBox;

	[Cpp2IlInjected.Token(Token = "0x4006AF7")]
	private static List<Tuple<Point16, bool>> tripPoints;

	[Cpp2IlInjected.Token(Token = "0x4006AF8")]
	private static List<int> markedIDsForRemoval;

	[Cpp2IlInjected.Token(Token = "0x4006AF9")]
	private static bool inUpdateLoop;

	[Cpp2IlInjected.Token(Token = "0x4006AFA")]
	private static bool playerBoxFilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006AFB")]
	public LogicCheckType logicCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006AFC")]
	public bool On;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006AFD")]
	public int CountedData;

	[Cpp2IlInjected.Token(Token = "0x6003B73")]
	[Cpp2IlInjected.Address(RVA = "0x1285754", Offset = "0x1285754", VA = "0x1285754", Slot = "13")]
	public override void RegisterTileEntityID(int assignedID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B74")]
	[Cpp2IlInjected.Address(RVA = "0x1285878", Offset = "0x1285878", VA = "0x1285878", Slot = "14")]
	public override void NetPlaceEntityAttempt(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B75")]
	[Cpp2IlInjected.Address(RVA = "0x12858F8", Offset = "0x12858F8", VA = "0x12858F8")]
	public static void NetPlaceEntity(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B76")]
	[Cpp2IlInjected.Address(RVA = "0x1285D6C", Offset = "0x1285D6C", VA = "0x1285D6C", Slot = "15")]
	public override bool IsTileValidForEntity(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B77")]
	[Cpp2IlInjected.Address(RVA = "0x1285FE0", Offset = "0x1285FE0", VA = "0x1285FE0", Slot = "16")]
	public override TileEntity GenerateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003B78")]
	[Cpp2IlInjected.Address(RVA = "0x12860C8", Offset = "0x12860C8", VA = "0x12860C8")]
	private static void UpdateStartInternal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B79")]
	[Cpp2IlInjected.Address(RVA = "0x1286194", Offset = "0x1286194", VA = "0x1286194")]
	private static void FillPlayerHitboxes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B7A")]
	[Cpp2IlInjected.Address(RVA = "0x1286338", Offset = "0x1286338", VA = "0x1286338")]
	private static void UpdateEndInternal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B7B")]
	[Cpp2IlInjected.Address(RVA = "0x1286968", Offset = "0x1286968", VA = "0x1286968", Slot = "4")]
	public override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B7C")]
	[Cpp2IlInjected.Address(RVA = "0x1286EA4", Offset = "0x1286EA4", VA = "0x1286EA4")]
	public void ChangeState(bool onState, bool TripWire)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B7D")]
	[Cpp2IlInjected.Address(RVA = "0x1285DEC", Offset = "0x1285DEC", VA = "0x1285DEC")]
	public static bool ValidTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B7E")]
	[Cpp2IlInjected.Address(RVA = "0x1286040", Offset = "0x1286040", VA = "0x1286040")]
	public TELogicSensor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B7F")]
	[Cpp2IlInjected.Address(RVA = "0x1287254", Offset = "0x1287254", VA = "0x1287254")]
	public static LogicCheckType FigureCheckType(int x, int y, out bool on)
	{
		return default(LogicCheckType);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B80")]
	[Cpp2IlInjected.Address(RVA = "0x1286A98", Offset = "0x1286A98", VA = "0x1286A98")]
	public static bool GetState(int x, int y, LogicCheckType type, [Optional] TELogicSensor instance)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B81")]
	[Cpp2IlInjected.Address(RVA = "0x1285CC0", Offset = "0x1285CC0", VA = "0x1285CC0")]
	public void FigureCheckState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B82")]
	[Cpp2IlInjected.Address(RVA = "0x12873C4", Offset = "0x12873C4", VA = "0x12873C4")]
	public static void GetFrame(int x, int y, LogicCheckType type, bool on)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B83")]
	[Cpp2IlInjected.Address(RVA = "0x1287100", Offset = "0x1287100", VA = "0x1287100")]
	public static bool SanityCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B84")]
	[Cpp2IlInjected.Address(RVA = "0x1285AD0", Offset = "0x1285AD0", VA = "0x1285AD0")]
	public static int Place(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B85")]
	[Cpp2IlInjected.Address(RVA = "0x1287D84", Offset = "0x1287D84", VA = "0x1287D84")]
	public static int Hook_AfterPlacement(int x, int y, int type = 423, int style = 0, int direction = 1, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B86")]
	[Cpp2IlInjected.Address(RVA = "0x1287514", Offset = "0x1287514", VA = "0x1287514")]
	public static void Kill(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B87")]
	[Cpp2IlInjected.Address(RVA = "0x1288114", Offset = "0x1288114", VA = "0x1288114")]
	public static int Find(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003B88")]
	[Cpp2IlInjected.Address(RVA = "0x1288230", Offset = "0x1288230", VA = "0x1288230", Slot = "5")]
	public override void WriteExtraData(BinaryWriter writer, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B89")]
	[Cpp2IlInjected.Address(RVA = "0x128827C", Offset = "0x128827C", VA = "0x128827C", Slot = "6")]
	public override void ReadExtraData(BinaryReader reader, bool networkSend)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B8A")]
	[Cpp2IlInjected.Address(RVA = "0x12882CC", Offset = "0x12882CC", VA = "0x12882CC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
