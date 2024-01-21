using System;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200056C")]
public struct TeleportPylonInfo : IEquatable<TeleportPylonInfo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400695A")]
	public Point16 PositionInTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400695B")]
	public TeleportPylonType TypeOfPylon;

	[Cpp2IlInjected.Token(Token = "0x6003ACC")]
	[Cpp2IlInjected.Address(RVA = "0x39E09C", Offset = "0x39E09C", VA = "0x39E09C", Slot = "4")]
	public bool Equals(TeleportPylonInfo other)
	{
		return default(bool);
	}
}
