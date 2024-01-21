using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200044D")]
public struct FishingAttempt
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40063D8")]
	public PlayerFishingConditions playerFishingConditions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40063D9")]
	public int X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40063DA")]
	public int Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40063DB")]
	public int bobberType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40063DC")]
	public bool common;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40063DD")]
	public bool uncommon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40063DE")]
	public bool rare;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
	[Cpp2IlInjected.Token(Token = "0x40063DF")]
	public bool veryrare;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40063E0")]
	public bool legendary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40063E1")]
	public bool crate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x40063E2")]
	public bool inLava;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x40063E3")]
	public bool inHoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40063E4")]
	public int waterTilesCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40063E5")]
	public int waterNeededToFish;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40063E6")]
	public float waterQuality;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40063E7")]
	public int chumsInWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40063E8")]
	public int fishingLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40063E9")]
	public bool CanFishInLava;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40063EA")]
	public float atmo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40063EB")]
	public int questFish;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40063EC")]
	public int heightLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40063ED")]
	public int rolledItemDrop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40063EE")]
	public int rolledEnemySpawn;
}
