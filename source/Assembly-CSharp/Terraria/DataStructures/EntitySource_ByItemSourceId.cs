using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200045D RID: 1117
	[global::Cpp2ILInjected.Token(Token = "0x2000659")]
	public class EntitySource_ByItemSourceId : IEntitySource
	{
		// Token: 0x060031DA RID: 12762 RVA: 0x0002AEC0 File Offset: 0x000290C0
		[global::Cpp2ILInjected.Token(Token = "0x60036F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D67C", Offset = "0x141D67C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_Death", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItemSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TorchAttack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "MassWireOperationInner", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Point),
			typeof(Point),
			typeof(Vector2),
			typeof(bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_ByItemSourceId(Entity entity, int itemSourceId)
		{
			throw null;
		}

		// Token: 0x04006416 RID: 25622
		[global::Cpp2ILInjected.Token(Token = "0x4007806")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		// Token: 0x04006417 RID: 25623
		[global::Cpp2ILInjected.Token(Token = "0x4007807")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int SourceId;
	}
}
