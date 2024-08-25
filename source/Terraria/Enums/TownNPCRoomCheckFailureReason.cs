using System;
using Cpp2ILInjected;

namespace Terraria.Enums
{
	[global::Cpp2ILInjected.Token(Token = "0x2000616")]
	public enum TownNPCRoomCheckFailureReason
	{
		[global::Cpp2ILInjected.Token(Token = "0x400767A")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x400767B")]
		TooCloseToWorldEdge,
		[global::Cpp2ILInjected.Token(Token = "0x400767C")]
		RoomIsTooBig,
		[global::Cpp2ILInjected.Token(Token = "0x400767D")]
		RoomIsTooSmall,
		[global::Cpp2ILInjected.Token(Token = "0x400767E")]
		HoleInWallIsTooBig,
		[global::Cpp2ILInjected.Token(Token = "0x400767F")]
		RoomCheckStartedInASolidTile
	}
}
