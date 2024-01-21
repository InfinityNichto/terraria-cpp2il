using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000569")]
public class SpelunkerProjectileHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006951")]
	private HashSet<Vector2> _positionsChecked;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006952")]
	private HashSet<Point> _tilesChecked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006953")]
	private Rectangle _clampBox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006954")]
	private int _frameCounter;

	[Cpp2IlInjected.Token(Token = "0x6003AB1")]
	[Cpp2IlInjected.Address(RVA = "0x1275C80", Offset = "0x1275C80", VA = "0x1275C80")]
	public void OnPreUpdateAllProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AB2")]
	[Cpp2IlInjected.Address(RVA = "0x1275D8C", Offset = "0x1275D8C", VA = "0x1275D8C")]
	public void AddSpotToCheck(Vector2 spot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AB3")]
	[Cpp2IlInjected.Address(RVA = "0x1275E14", Offset = "0x1275E14", VA = "0x1275E14")]
	private void CheckSpot(Vector2 Center)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AB4")]
	[Cpp2IlInjected.Address(RVA = "0x1276264", Offset = "0x1276264", VA = "0x1276264")]
	public SpelunkerProjectileHelper()
	{
	}
}
