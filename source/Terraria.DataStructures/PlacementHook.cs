using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000443")]
public struct PlacementHook
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006318")]
	public Func<int, int, int, int, int, int, int> hook;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006319")]
	public int badReturn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400631A")]
	public int badResponse;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400631B")]
	public bool processedCoordinates;

	[Cpp2IlInjected.Token(Token = "0x400631C")]
	public static PlacementHook Empty;

	[Cpp2IlInjected.Token(Token = "0x400631D")]
	public const int Response_AllInvalid = 0;

	[Cpp2IlInjected.Token(Token = "0x6003168")]
	[Cpp2IlInjected.Address(RVA = "0x39B3D8", Offset = "0x39B3D8", VA = "0x39B3D8")]
	public PlacementHook(Func<int, int, int, int, int, int, int> hook, int badReturn, int badResponse, bool processedCoordinates)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003169")]
	[Cpp2IlInjected.Address(RVA = "0x1015164", Offset = "0x1015164", VA = "0x1015164")]
	public static bool operator ==(PlacementHook first, PlacementHook second)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600316A")]
	[Cpp2IlInjected.Address(RVA = "0x10151CC", Offset = "0x10151CC", VA = "0x10151CC")]
	public static bool operator !=(PlacementHook first, PlacementHook second)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600316B")]
	[Cpp2IlInjected.Address(RVA = "0x39B3F0", Offset = "0x39B3F0", VA = "0x39B3F0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600316C")]
	[Cpp2IlInjected.Address(RVA = "0x39B3F8", Offset = "0x39B3F8", VA = "0x39B3F8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
