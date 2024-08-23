using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000465 RID: 1125
	[global::Cpp2ILInjected.Token(Token = "0x2000661")]
	public class EntitySource_FishedOut : IEntitySource
	{
		// Token: 0x060031E2 RID: 12770 RVA: 0x0002AED8 File Offset: 0x000290D8
		[global::Cpp2ILInjected.Token(Token = "0x60036FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D724", Offset = "0x141D724", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_CheckFishingBobber_PullBobber", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_061_FishingBobber_GiveItemToPlayer", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_FishedOut(Entity entity)
		{
			throw null;
		}

		// Token: 0x0400641A RID: 25626
		[global::Cpp2ILInjected.Token(Token = "0x400780A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;
	}
}
