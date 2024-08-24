using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000466 RID: 1126
	[global::Cpp2ILInjected.Token(Token = "0x2000662")]
	public class EntitySource_Gift : IEntitySource
	{
		// Token: 0x060031E3 RID: 12771 RVA: 0x0002AEDB File Offset: 0x000290DB
		[global::Cpp2ILInjected.Token(Token = "0x6003700")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D74C", Offset = "0x141D74C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option1Clicked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetAnglerReward", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetDyeTraderReward", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_192_JuminoAnimation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderHelpText", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Gift(Entity entity)
		{
			throw null;
		}

		// Token: 0x0400641B RID: 25627
		[global::Cpp2ILInjected.Token(Token = "0x400780B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;
	}
}
