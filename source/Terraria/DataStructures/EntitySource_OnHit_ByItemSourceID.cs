using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000666")]
	public class EntitySource_OnHit_ByItemSourceID : AEntitySource_OnHit
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003704")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D804", Offset = "0x141D804", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_OnHit", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetItemSource_OnHit", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_OnHit_ByItemSourceID(Entity entityStriking, Entity entityStruck, int itemSourceId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007810")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int SourceId;
	}
}
