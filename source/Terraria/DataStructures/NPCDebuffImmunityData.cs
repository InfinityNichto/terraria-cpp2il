using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ID;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000638")]
	public class NPCDebuffImmunityData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003637")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD1B8", Offset = "0x13DD1B8", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ApplyToNPC(NPC npc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003638")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD2B8", Offset = "0x13DD2B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 541)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCDebuffImmunityData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool ImmuneToWhips;

		[global::Cpp2ILInjected.Token(Token = "0x40076F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		public bool ImmuneToAllBuffsThatAreNotWhips;

		[global::Cpp2ILInjected.Token(Token = "0x40076FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int[] SpecificallyImmuneTo;
	}
}
