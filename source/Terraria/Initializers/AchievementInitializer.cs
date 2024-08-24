using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Utilities;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.UI.Chat;
using Terraria.Localization;

namespace Terraria.Initializers
{
	// Token: 0x020003D2 RID: 978
	[global::Cpp2ILInjected.Token(Token = "0x2000581")]
	public class AchievementInitializer
	{
		// Token: 0x06002FF8 RID: 12280 RVA: 0x0002A932 File Offset: 0x00028B32
		[global::Cpp2ILInjected.Token(Token = "0x6003464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1360064", Offset = "0x1360064", Length = "0x4E18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "AddCondition", MemberParameters = new object[] { typeof(AchievementCondition) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Register", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProgressionEventCondition), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ProgressionEventCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDestroyedCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(ushort[])
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomFlagCondition), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemPickupCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemCraftCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCKilledCondition), Member = "CreateMany", MemberParameters = new object[]
		{
			typeof(LocalUser),
			typeof(short[])
		}, ReturnType = typeof(AchievementCondition[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "AddConditions", MemberParameters = new object[] { typeof(AchievementCondition[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "UseConditionsCompletedTracker", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomIntCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement), Member = "UseTrackerFromCondition", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomFloatCondition), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(AchievementCondition))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "RegisterIconIndex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "RegisterAchievementCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(AchievementCategory)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement.AchievementCompleted), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "add_OnAchievementCompleted", MemberParameters = new object[] { typeof(Achievement.AchievementCompleted) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 294)]
		public static void Load()
		{
			throw null;
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0002A935 File Offset: 0x00028B35
		[global::Cpp2ILInjected.Token(Token = "0x6003465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1364E7C", Offset = "0x1364E7C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementTagHandler), Member = "GenerateTag", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "FindActiveSound", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(ActiveSound))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlayTrackedSound", MemberParameters = new object[] { typeof(SoundStyle) }, ReturnType = typeof(SlotId))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void OnAchievementCompleted(Achievement achievement)
		{
			throw null;
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x0002A938 File Offset: 0x00028B38
		[global::Cpp2ILInjected.Token(Token = "0x6003466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1364F94", Offset = "0x1364F94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AchievementInitializer()
		{
			throw null;
		}
	}
}
