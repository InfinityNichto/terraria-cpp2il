using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000653 RID: 1619
	[global::Cpp2ILInjected.Token(Token = "0x20009AD")]
	public class ItemCraftCondition : AchievementCondition
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x0002D4F1 File Offset: 0x0002B6F1
		[global::Cpp2ILInjected.Token(Token = "0x6004949")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C1C4", Offset = "0x82C1C4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = "CreateMany", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = "ListenForCraft", MemberParameters = new object[] { typeof(ItemCraftCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private ItemCraftCondition(LocalUser user, short itemId)
		{
			throw null;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0002D4F4 File Offset: 0x0002B6F4
		[global::Cpp2ILInjected.Token(Token = "0x600494A")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C530", Offset = "0x82C530", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = "Create", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = "ListenForCraft", MemberParameters = new object[] { typeof(ItemCraftCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private ItemCraftCondition(LocalUser user, short[] itemIds)
		{
			throw null;
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x0002D4F7 File Offset: 0x0002B6F7
		[global::Cpp2ILInjected.Token(Token = "0x600494B")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C5E4", Offset = "0x82C5E4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "get_Item", MemberParameters = new object[] { typeof(short) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Shutdown()
		{
			throw null;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x0002D4FA File Offset: 0x0002B6FA
		[global::Cpp2ILInjected.Token(Token = "0x600494C")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C2A8", Offset = "0x82C2A8", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper.ItemCraftEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "add_OnItemCraft", MemberParameters = new object[] { typeof(AchievementsHelper.ItemCraftEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(short),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "get_Item", MemberParameters = new object[] { typeof(short) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void ListenForCraft(ItemCraftCondition condition)
		{
			throw null;
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x0002D4FD File Offset: 0x0002B6FD
		[global::Cpp2ILInjected.Token(Token = "0x600494D")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C6B8", Offset = "0x82C6B8", Length = "0x1AC")]
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
		private static void ItemCraftListener(Player player, short itemId, int count)
		{
			throw null;
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x0002D500 File Offset: 0x0002B700
		[global::Cpp2ILInjected.Token(Token = "0x600494E")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C864", Offset = "0x82C864", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, params short[] items)
		{
			throw null;
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x0002D503 File Offset: 0x0002B703
		[global::Cpp2ILInjected.Token(Token = "0x600494F")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C8CC", Offset = "0x82C8CC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, short item)
		{
			throw null;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x0002D506 File Offset: 0x0002B706
		[global::Cpp2ILInjected.Token(Token = "0x6004950")]
		[global::Cpp2ILInjected.Address(RVA = "0x82C934", Offset = "0x82C934", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static AchievementCondition[] CreateMany(LocalUser user, params short[] items)
		{
			throw null;
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x0002D509 File Offset: 0x0002B709
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004951")]
		[global::Cpp2ILInjected.Address(RVA = "0x82CA24", Offset = "0x82CA24", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ItemCraftCondition()
		{
			throw null;
		}

		// Token: 0x04006CAA RID: 27818
		[global::Cpp2ILInjected.Token(Token = "0x400843C")]
		public const string Identifier = "ITEM_PICKUP";

		// Token: 0x04006CAB RID: 27819
		[global::Cpp2ILInjected.Token(Token = "0x400843D")]
		private static Dictionary<short, List<ItemCraftCondition>> _listeners;

		// Token: 0x04006CAC RID: 27820
		[global::Cpp2ILInjected.Token(Token = "0x400843E")]
		private static bool _isListenerHooked;

		// Token: 0x04006CAD RID: 27821
		[global::Cpp2ILInjected.Token(Token = "0x400843F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private short[] _itemIds;

		// Token: 0x04006CAE RID: 27822
		[global::Cpp2ILInjected.Token(Token = "0x4008440")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly LocalUser _user;
	}
}
