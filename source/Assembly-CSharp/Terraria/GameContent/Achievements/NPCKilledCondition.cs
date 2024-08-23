using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Achievements;
using Terraria.Initializers;

namespace Terraria.GameContent.Achievements
{
	// Token: 0x02000655 RID: 1621
	[global::Cpp2ILInjected.Token(Token = "0x20009AF")]
	public class NPCKilledCondition : AchievementCondition
	{
		// Token: 0x06003F6E RID: 16238 RVA: 0x0002D527 File Offset: 0x0002B727
		[global::Cpp2ILInjected.Token(Token = "0x600495B")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D39C", Offset = "0x82D39C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = "CreateMany", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(NPCKilledCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private NPCKilledCondition(LocalUser user, short npcId)
		{
			throw null;
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x0002D52A File Offset: 0x0002B72A
		[global::Cpp2ILInjected.Token(Token = "0x600495C")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D708", Offset = "0x82D708", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = "Create", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = "ListenForPickup", MemberParameters = new object[] { typeof(NPCKilledCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private NPCKilledCondition(LocalUser user, short[] npcIds)
		{
			throw null;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x0002D52D File Offset: 0x0002B72D
		[global::Cpp2ILInjected.Token(Token = "0x600495D")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D7BC", Offset = "0x82D7BC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "get_Item", MemberParameters = new object[] { typeof(short) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Shutdown()
		{
			throw null;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0002D530 File Offset: 0x0002B730
		[global::Cpp2ILInjected.Token(Token = "0x600495E")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D480", Offset = "0x82D480", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper.NPCKilledEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "add_OnNPCKilled", MemberParameters = new object[] { typeof(AchievementsHelper.NPCKilledEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(short),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = "get_Item", MemberParameters = new object[] { typeof(short) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void ListenForPickup(NPCKilledCondition condition)
		{
			throw null;
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x0002D533 File Offset: 0x0002B733
		[global::Cpp2ILInjected.Token(Token = "0x600495F")]
		[global::Cpp2ILInjected.Address(RVA = "0x82D890", Offset = "0x82D890", Length = "0x1AC")]
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
		private static void NPCKilledListener(Player player, short npcId)
		{
			throw null;
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x0002D536 File Offset: 0x0002B736
		[global::Cpp2ILInjected.Token(Token = "0x6004960")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DA3C", Offset = "0x82DA3C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, params short[] npcIds)
		{
			throw null;
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0002D539 File Offset: 0x0002B739
		[global::Cpp2ILInjected.Token(Token = "0x6004961")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DAA4", Offset = "0x82DAA4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static AchievementCondition Create(LocalUser user, short npcId)
		{
			throw null;
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0002D53C File Offset: 0x0002B73C
		[global::Cpp2ILInjected.Token(Token = "0x6004962")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DB0C", Offset = "0x82DB0C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AchievementInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static AchievementCondition[] CreateMany(LocalUser user, params short[] npcs)
		{
			throw null;
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x0002D53F File Offset: 0x0002B73F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004963")]
		[global::Cpp2ILInjected.Address(RVA = "0x82DBFC", Offset = "0x82DBFC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<short, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static NPCKilledCondition()
		{
			throw null;
		}

		// Token: 0x04006CB4 RID: 27828
		[global::Cpp2ILInjected.Token(Token = "0x4008446")]
		private const string Identifier = "NPC_KILLED";

		// Token: 0x04006CB5 RID: 27829
		[global::Cpp2ILInjected.Token(Token = "0x4008447")]
		private static Dictionary<short, List<NPCKilledCondition>> _listeners;

		// Token: 0x04006CB6 RID: 27830
		[global::Cpp2ILInjected.Token(Token = "0x4008448")]
		private static bool _isListenerHooked;

		// Token: 0x04006CB7 RID: 27831
		[global::Cpp2ILInjected.Token(Token = "0x4008449")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly LocalUser _user;

		// Token: 0x04006CB8 RID: 27832
		[global::Cpp2ILInjected.Token(Token = "0x400844A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private short[] _npcIds;
	}
}
