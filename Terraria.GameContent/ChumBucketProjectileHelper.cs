using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000547")]
public class ChumBucketProjectileHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068CC")]
	private Dictionary<Point, int> _chumCountsPendingForThisFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40068CD")]
	private Dictionary<Point, int> _chumCountsFromLastFrame;

	[Cpp2IlInjected.Token(Token = "0x60039CB")]
	[Cpp2IlInjected.Address(RVA = "0x107DAB4", Offset = "0x107DAB4", VA = "0x107DAB4")]
	public void OnPreUpdateAllProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039CC")]
	[Cpp2IlInjected.Address(RVA = "0x107DB60", Offset = "0x107DB60", VA = "0x107DB60")]
	public void AddChumLocation(Vector2 spot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039CD")]
	[Cpp2IlInjected.Address(RVA = "0x107DC5C", Offset = "0x107DC5C", VA = "0x107DC5C")]
	public int GetChumsInLocation(Point tileCoords)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60039CE")]
	[Cpp2IlInjected.Address(RVA = "0x107DCE4", Offset = "0x107DCE4", VA = "0x107DCE4")]
	public ChumBucketProjectileHelper()
	{
	}
}
