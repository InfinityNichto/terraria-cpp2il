using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000452 RID: 1106
	[global::Cpp2ILInjected.Token(Token = "0x200064E")]
	public class EntitySource_ItemUse : IEntitySource
	{
		// Token: 0x060031CF RID: 12751 RVA: 0x0002AE9F File Offset: 0x0002909F
		[global::Cpp2ILInjected.Token(Token = "0x60036EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D3A4", Offset = "0x141D3A4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_Item", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_Accessory", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SpawnHallucination", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PlaceThing_PaintScrapper_LongMoss", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "PutItemInInventoryFromItemUsage", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_CutTiles", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(bool[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_ItemUse(Entity entity, Item item)
		{
			throw null;
		}

		// Token: 0x0400640B RID: 25611
		[global::Cpp2ILInjected.Token(Token = "0x40077FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		// Token: 0x0400640C RID: 25612
		[global::Cpp2ILInjected.Token(Token = "0x40077FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Item Item;
	}
}
