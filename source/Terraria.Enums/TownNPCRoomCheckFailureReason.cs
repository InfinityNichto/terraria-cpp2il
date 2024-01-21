using Cpp2IlInjected;

namespace Terraria.Enums;

[Cpp2IlInjected.Token(Token = "0x200041E")]
public enum TownNPCRoomCheckFailureReason
{
	[Cpp2IlInjected.Token(Token = "0x4006291")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4006292")]
	TooCloseToWorldEdge,
	[Cpp2IlInjected.Token(Token = "0x4006293")]
	RoomIsTooBig,
	[Cpp2IlInjected.Token(Token = "0x4006294")]
	RoomIsTooSmall,
	[Cpp2IlInjected.Token(Token = "0x4006295")]
	HoleInWallIsTooBig,
	[Cpp2IlInjected.Token(Token = "0x4006296")]
	RoomCheckStartedInASolidTile
}
