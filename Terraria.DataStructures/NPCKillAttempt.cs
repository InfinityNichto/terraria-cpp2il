using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000442")]
public struct NPCKillAttempt
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006315")]
	public readonly NPC npc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006316")]
	public readonly int netId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006317")]
	public readonly bool active;

	[Cpp2IlInjected.Token(Token = "0x6003165")]
	[Cpp2IlInjected.Address(RVA = "0x39B188", Offset = "0x39B188", VA = "0x39B188")]
	public NPCKillAttempt(NPC target)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003166")]
	[Cpp2IlInjected.Address(RVA = "0x39B1A0", Offset = "0x39B1A0", VA = "0x39B1A0")]
	public bool DidNPCDie()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003167")]
	[Cpp2IlInjected.Address(RVA = "0x39B1B4", Offset = "0x39B1B4", VA = "0x39B1B4")]
	public bool DidNPCDieOrTransform()
	{
		return default(bool);
	}
}
