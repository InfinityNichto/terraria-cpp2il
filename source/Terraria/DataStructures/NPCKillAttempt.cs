using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200063A")]
	public struct NPCKillAttempt
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003646")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD8A4", Offset = "0x13DD8A4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyDamageToNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public NPCKillAttempt(NPC target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003647")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD8BC", Offset = "0x13DD8BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyDamageToNPC", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public bool DidNPCDie()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003648")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DD8D0", Offset = "0x13DD8D0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool DidNPCDieOrTransform()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly NPC npc;

		[global::Cpp2ILInjected.Token(Token = "0x40076FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly int netId;

		[global::Cpp2ILInjected.Token(Token = "0x4007700")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public readonly bool active;
	}
}
