using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003B4")]
public class TilePlacementHooksModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003263")]
	public PlacementHook check;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003264")]
	public PlacementHook postPlaceEveryone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4003265")]
	public PlacementHook postPlaceMyPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4003266")]
	public PlacementHook placeOverride;

	[Cpp2IlInjected.Token(Token = "0x6002ECC")]
	[Cpp2IlInjected.Address(RVA = "0xFDD098", Offset = "0xFDD098", VA = "0xFDD098")]
	public TilePlacementHooksModule([Optional] TilePlacementHooksModule copyFrom)
	{
	}
}
