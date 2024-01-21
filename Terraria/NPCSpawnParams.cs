using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000339")]
public struct NPCSpawnParams
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002EB0")]
	public float? sizeScaleOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002EB1")]
	public int? playerCountForMultiplayerDifficultyOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002EB2")]
	public GameModeData gameModeData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002EB3")]
	public float? strengthMultiplierOverride;

	[Cpp2IlInjected.Token(Token = "0x60026FC")]
	[Cpp2IlInjected.Address(RVA = "0x39F0B0", Offset = "0x39F0B0", VA = "0x39F0B0")]
	public NPCSpawnParams WithScale(float scaleOverride)
	{
		return default(NPCSpawnParams);
	}
}
