using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000454 RID: 1108
	[global::Cpp2ILInjected.Token(Token = "0x2000650")]
	public class EntitySource_ItemUse_WithAmmo : EntitySource_ItemUse
	{
		// Token: 0x060031D1 RID: 12753 RVA: 0x0002AEA5 File Offset: 0x000290A5
		[global::Cpp2ILInjected.Token(Token = "0x60036EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D400", Offset = "0x141D400", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_Item_WithPotentialAmmo", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_ItemUse_WithAmmo(Entity entity, Item item, int ammoItemIdUsed)
		{
			throw null;
		}

		// Token: 0x0400640F RID: 25615
		[global::Cpp2ILInjected.Token(Token = "0x40077FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int AmmoItemIdUsed;
	}
}
