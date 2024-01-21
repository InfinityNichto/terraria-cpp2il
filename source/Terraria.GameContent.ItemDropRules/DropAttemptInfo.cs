using Cpp2IlInjected;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005C4")]
public struct DropAttemptInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006B88")]
	public NPC npc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006B89")]
	public Player player;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B8A")]
	public UnifiedRandom rng;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B8B")]
	public bool IsInSimulation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4006B8C")]
	public bool IsExpertMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4006B8D")]
	public bool IsMasterMode;
}
