using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000577")]
public struct VoidLensHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006ACA")]
	private readonly Vector2 _position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006ACB")]
	private readonly float _opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006ACC")]
	private readonly int _frameNumber;

	[Cpp2IlInjected.Token(Token = "0x6003B01")]
	[Cpp2IlInjected.Address(RVA = "0x399F08", Offset = "0x399F08", VA = "0x399F08")]
	public VoidLensHelper(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B02")]
	[Cpp2IlInjected.Address(RVA = "0x399F10", Offset = "0x399F10", VA = "0x399F10")]
	public VoidLensHelper(Vector2 worldPosition, float opacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B03")]
	[Cpp2IlInjected.Address(RVA = "0x399F2C", Offset = "0x399F2C", VA = "0x399F2C")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B04")]
	[Cpp2IlInjected.Address(RVA = "0x399F34", Offset = "0x399F34", VA = "0x399F34")]
	public void SpawnVoidLensDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B05")]
	[Cpp2IlInjected.Address(RVA = "0x399F3C", Offset = "0x399F3C", VA = "0x399F3C")]
	public void DrawToDrawData(List<DrawData> drawDataList, int selectionMode)
	{
	}
}
