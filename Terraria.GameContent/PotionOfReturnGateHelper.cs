using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000578")]
public struct PotionOfReturnGateHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000999")]
	public enum GateType
	{
		[Cpp2IlInjected.Token(Token = "0x4008C7E")]
		EntryPoint,
		[Cpp2IlInjected.Token(Token = "0x4008C7F")]
		ExitPoint
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006ACD")]
	private readonly Vector2 _position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006ACE")]
	private readonly float _opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006ACF")]
	private readonly int _frameNumber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006AD0")]
	private readonly GateType _gateType;

	[Cpp2IlInjected.Token(Token = "0x6003B06")]
	[Cpp2IlInjected.Address(RVA = "0x39D1A4", Offset = "0x39D1A4", VA = "0x39D1A4")]
	public PotionOfReturnGateHelper(GateType gateType, Vector2 worldPosition, float opacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B07")]
	[Cpp2IlInjected.Address(RVA = "0x39D1C8", Offset = "0x39D1C8", VA = "0x39D1C8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B08")]
	[Cpp2IlInjected.Address(RVA = "0x39D1D0", Offset = "0x39D1D0", VA = "0x39D1D0")]
	public void SpawnReturnPortalDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003B09")]
	[Cpp2IlInjected.Address(RVA = "0x39D1D8", Offset = "0x39D1D8", VA = "0x39D1D8")]
	public void DrawToDrawData(List<DrawData> drawDataList, int selectionMode)
	{
	}
}
