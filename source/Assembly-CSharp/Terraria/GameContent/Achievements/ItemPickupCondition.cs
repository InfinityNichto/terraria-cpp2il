using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000654 RID: 1620
	[global::Cpp2ILInjected.Token(Token = "0x20009AE")]
	public class ItemPickupCondition : AchievementCondition
	{
		// Token: 0x06003F65 RID: 16229 RVA: 0x0002D50C File Offset: 0x0002B70C
		[global::Cpp2ILInjected.Token(Token = "0x6004952")]
		[global::Cpp2ILInjected.Address(RVA = "0x82CAB0", Offset = "0x82CAB0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = "CreateMany", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(AchievementCondition[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(ItemPickupCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ItemPickupCondition(LocalUser user, short itemId)
		{
			throw null;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0002D50F File Offset: 0x0002B70F
		[global::Cpp2ILInjected.Token(Token = "0x6004953")]
		[global::Cpp2ILInjected.Address(RVA = "0x82CE1C", Offset = "0x82CE1C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementCondition), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(ItemPickupCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ItemPickupCondition(LocalUser user, short[] itemIds)
		{
			throw null;
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0002D512 File Offset: 0x0002B712
		[global::Cpp2ILInjected.Token(Token = "0x6004954")]
		[global::Cpp2ILInjected.Address(RVA = "0x82CED0", Offset = "0x82CED0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "get_Item", MemberParameters = new object[] { typeof(short) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Shutdown()
		{
			throw null;
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x0002D515 File Offset: 0x0002B715
		[global::Cpp2ILInjected.Token(Token = "0x6004955")]
		[global::Cpp2ILInjected.Address(RVA = "0x82CB94", Offset = "0x82CB94", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper.ItemPickupEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "add_OnItemPickup", MemberParameters = new object[] { typeof(AchievementsHelper.ItemPickupEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(short),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "get_Item", MemberParameters = new object[] { typeof(short) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void ListenForPickup(ItemPickupCondition condition)
		{
			throw null;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x0002D518 File Offset: 0x0002B718
		[global::Cpp2ILInjected.Token(Token = "0x6004956")]
		[global::Cpp2ILInjected.Address(RVA = "0x82CFA4", Offset = "0x82CFA4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(short),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void ItemPickupListener(Player player, short itemId, int count)
		{
			throw null;
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x0002D51B File Offset: 0x0002B71B
		[global::Cpp2ILInjected.Token(Token = "0x6004957")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D150", Offset = "0x82D150", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, params short[] items)
		{
			throw null;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x0002D51E File Offset: 0x0002B71E
		[global::Cpp2ILInjected.Token(Token = "0x6004958")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D1B8", Offset = "0x82D1B8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, short item)
		{
			throw null;
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x0002D521 File Offset: 0x0002B721
		[global::Cpp2ILInjected.Token(Token = "0x6004959")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D220", Offset = "0x82D220", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static AchievementCondition[] CreateMany(LocalUser user, params short[] items)
		{
			throw null;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x0002D524 File Offset: 0x0002B724
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600495A")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D310", Offset = "0x82D310", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ItemPickupCondition()
		{
			throw null;
		}

		// Token: 0x04006CAF RID: 27823
		[global::Cpp2ILInjected.Token(Token = "0x4008441")]
		public const string Identifier = "ITEM_PICKUP";

		// Token: 0x04006CB0 RID: 27824
		[global::Cpp2ILInjected.Token(Token = "0x4008442")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly LocalUser _user;

		// Token: 0x04006CB1 RID: 27825
		[global::Cpp2ILInjected.Token(Token = "0x4008443")]
		private static Dictionary<short, List<ItemPickupCondition>> _listeners;

		// Token: 0x04006CB2 RID: 27826
		[global::Cpp2ILInjected.Token(Token = "0x4008444")]
		private static bool _isListenerHooked;

		// Token: 0x04006CB3 RID: 27827
		[global::Cpp2ILInjected.Token(Token = "0x4008445")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private short[] _itemIds;
	}
}
