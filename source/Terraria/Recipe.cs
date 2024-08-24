using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000341 RID: 833
	[global::Cpp2ILInjected.Token(Token = "0x2000455")]
	public class Recipe
	{
		// Token: 0x060026EA RID: 9962 RVA: 0x00028EF5 File Offset: 0x000270F5
		[global::Cpp2ILInjected.Token(Token = "0x600298A")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DB6C", Offset = "0x115DB6C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void RequireGroup(string name)
		{
			throw null;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00028EF8 File Offset: 0x000270F8
		[global::Cpp2ILInjected.Token(Token = "0x600298B")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DC34", Offset = "0x115DC34", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public void RequireGroup(int id)
		{
			throw null;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00028EFB File Offset: 0x000270FB
		[global::Cpp2ILInjected.Token(Token = "0x600298C")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DC68", Offset = "0x115DC68", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool ProcessGroupsForText(int type, out string theText)
		{
			throw null;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x00028EFE File Offset: 0x000270FE
		[global::Cpp2ILInjected.Token(Token = "0x600298D")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DDB4", Offset = "0x115DDB4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool AcceptsGroup(int groupId)
		{
			throw null;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00028F01 File Offset: 0x00027101
		[global::Cpp2ILInjected.Token(Token = "0x600298E")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DDF0", Offset = "0x115DDF0", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectedEnoughItemsToCraftRecipeOld", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectGuideRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool AcceptedByItemGroups(int invType, int reqType)
		{
			throw null;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00028F04 File Offset: 0x00027104
		[global::Cpp2ILInjected.Token(Token = "0x600298F")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DF1C", Offset = "0x115DF1C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Item AddCustomShimmerResult(int itemType, int itemStack = 1)
		{
			throw null;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00028F07 File Offset: 0x00027107
		[global::Cpp2ILInjected.Token(Token = "0x6002990")]
		[global::Cpp2ILInjected.Address(RVA = "0x115E050", Offset = "0x115E050", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public Recipe()
		{
			throw null;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00028F0A File Offset: 0x0002710A
		[global::Cpp2ILInjected.Token(Token = "0x6002991")]
		[global::Cpp2ILInjected.Address(RVA = "0x115E1B0", Offset = "0x115E1B0", Length = "0xB24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftButtonOver", MemberParameters = new object[] { typeof(GUITransactionButton.InputState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "useWood", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "useSand", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "usePressurePlate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AcceptedByItemGroups", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "useVoidBag", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyItemCraft", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyItemPickup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		public void Create()
		{
			throw null;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00028F0D File Offset: 0x0002710D
		[global::Cpp2ILInjected.Token(Token = "0x6002992")]
		[global::Cpp2ILInjected.Address(RVA = "0x115ECD4", Offset = "0x115ECD4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectedEnoughItemsToCraftRecipeOld", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectGuideRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public bool useWood(int invType, int reqType)
		{
			throw null;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00028F10 File Offset: 0x00027110
		[global::Cpp2ILInjected.Token(Token = "0x6002993")]
		[global::Cpp2ILInjected.Address(RVA = "0x115EE60", Offset = "0x115EE60", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool useIronBar(int invType, int reqType)
		{
			throw null;
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00028F13 File Offset: 0x00027113
		[global::Cpp2ILInjected.Token(Token = "0x6002994")]
		[global::Cpp2ILInjected.Address(RVA = "0x115ED7C", Offset = "0x115ED7C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectedEnoughItemsToCraftRecipeOld", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectGuideRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public bool useSand(int invType, int reqType)
		{
			throw null;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00028F16 File Offset: 0x00027116
		[global::Cpp2ILInjected.Token(Token = "0x6002995")]
		[global::Cpp2ILInjected.Address(RVA = "0x115EE2C", Offset = "0x115EE2C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool useFragment(int invType, int reqType)
		{
			throw null;
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00028F19 File Offset: 0x00027119
		[global::Cpp2ILInjected.Token(Token = "0x6002996")]
		[global::Cpp2ILInjected.Address(RVA = "0x115EE98", Offset = "0x115EE98", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "FindRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "Create", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectedEnoughItemsToCraftRecipeOld", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectGuideRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public bool usePressurePlate(int invType, int reqType)
		{
			throw null;
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00028F1C File Offset: 0x0002711C
		[global::Cpp2ILInjected.Token(Token = "0x6002997")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F160", Offset = "0x115F160", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_WhilePaused", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void GetThroughDelayedFindRecipes()
		{
			throw null;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00028F1F File Offset: 0x0002711F
		[global::Cpp2ILInjected.Token(Token = "0x6002998")]
		[global::Cpp2ILInjected.Address(RVA = "0x115EF44", Offset = "0x115EF44", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 128)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_availableRecipe", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_focusRecipe", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_lastRecipeUpdateId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lastRecipeUpdateId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "ClearAvailableRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "CollectItemsToCraftWithFrom", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "PlayerMeetsEnvironmentConditions", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Recipe)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "CollectedEnoughItemsToCraftRecipeNew", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddToAvailableRecipes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "TryRefocusingRecipe", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "VisuallyRepositionRecipes", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void FindRecipes(bool canDelayCheck = false)
		{
			throw null;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00028F22 File Offset: 0x00027122
		[global::Cpp2ILInjected.Token(Token = "0x6002999")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F650", Offset = "0x115F650", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_availableRecipe", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_numAvailableRecipes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_numAvailableRecipes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void AddToAvailableRecipes(int recipeIndex)
		{
			throw null;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00028F25 File Offset: 0x00027125
		[global::Cpp2ILInjected.Token(Token = "0x600299A")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F8E4", Offset = "0x115F8E4", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.KeyCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "useWood", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "useSand", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "usePressurePlate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AcceptedByItemGroups", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>.KeyCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static bool CollectedEnoughItemsToCraftRecipeOld(Recipe tempRec)
		{
			throw null;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00028F28 File Offset: 0x00027128
		[global::Cpp2ILInjected.Token(Token = "0x600299B")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F57C", Offset = "0x115F57C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool CollectedEnoughItemsToCraftRecipeNew(Recipe tempRec)
		{
			throw null;
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00028F2B File Offset: 0x0002712B
		[global::Cpp2ILInjected.Token(Token = "0x600299C")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F42C", Offset = "0x115F42C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGraveyard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool PlayerMeetsEnvironmentConditions(Player player, Recipe tempRec)
		{
			throw null;
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00028F2E File Offset: 0x0002712E
		[global::Cpp2ILInjected.Token(Token = "0x600299D")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F3E8", Offset = "0x115F3E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool PlayerMeetsTileRequirements(Player player, Recipe tempRec)
		{
			throw null;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00028F31 File Offset: 0x00027131
		[global::Cpp2ILInjected.Token(Token = "0x600299E")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F258", Offset = "0x115F258", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "CollectItems", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "useVoidBag", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddFakeCountsForItemGroups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void CollectItemsToCraftWithFrom(Player player)
		{
			throw null;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00028F34 File Offset: 0x00027134
		[global::Cpp2ILInjected.Token(Token = "0x600299F")]
		[global::Cpp2ILInjected.Address(RVA = "0x115FD48", Offset = "0x115FD48", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectItemsToCraftWithFrom", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RecipeGroup), Member = "CountUsableItems", MemberParameters = new object[] { typeof(Dictionary<int, int>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void AddFakeCountsForItemGroups()
		{
			throw null;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x00028F37 File Offset: 0x00027137
		[global::Cpp2ILInjected.Token(Token = "0x60029A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x115FC28", Offset = "0x115FC28", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CollectItemsToCraftWithFrom", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void CollectItems(Item[] currentInventory, int slotCap)
		{
			throw null;
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00028F3A File Offset: 0x0002713A
		[global::Cpp2ILInjected.Token(Token = "0x60029A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x115FF38", Offset = "0x115FF38", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_guideItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "IsTheSameAs", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "useWood", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "useSand", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AcceptedByItemGroups", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "usePressurePlate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_availableRecipe", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_numAvailableRecipes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_numAvailableRecipes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void CollectGuideRecipes()
		{
			throw null;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00028F3D File Offset: 0x0002713D
		[global::Cpp2ILInjected.Token(Token = "0x60029A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F1E4", Offset = "0x115F1E4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_availableRecipe", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_numAvailableRecipes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ClearAvailableRecipes()
		{
			throw null;
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00028F40 File Offset: 0x00027140
		[global::Cpp2ILInjected.Token(Token = "0x60029A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F834", Offset = "0x115F834", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_focusRecipe", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void VisuallyRepositionRecipes(float focusY)
		{
			throw null;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00028F43 File Offset: 0x00027143
		[global::Cpp2ILInjected.Token(Token = "0x60029A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x115F6CC", Offset = "0x115F6CC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_numAvailableRecipes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_availableRecipe", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_focusRecipe", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_focusRecipe", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "RefreshGridNav", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void TryRefocusingRecipe(int oldRecipe)
		{
			throw null;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00028F46 File Offset: 0x00027146
		[global::Cpp2ILInjected.Token(Token = "0x60029A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1160110", Offset = "0x1160110", Length = "0x190C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RecipeGroup), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Func<string>),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RecipeGroup), Member = "RegisterGroup", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RecipeGroup)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 231)]
		public static void SetupRecipeGroups()
		{
			throw null;
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00028F49 File Offset: 0x00027149
		[global::Cpp2ILInjected.Token(Token = "0x60029A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1161A1C", Offset = "0x1161A1C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "RefreshItems", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Refresh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void UpdateItemVariants()
		{
			throw null;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00028F4C File Offset: 0x0002714C
		[global::Cpp2ILInjected.Token(Token = "0x60029A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x110BED4", Offset = "0x110BED4", Length = "0x48114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetupRecipeGroups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetCraftingStation", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "RequireGroup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddCustomShimmerResult", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddAshWoodFurnitureArmorAndItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddSpiderFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddLesionFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddSolarFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddVortexFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddNebulaFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddStardustFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddSandstoneFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddBambooFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddCoralFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddBalloonFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "CreateReverseWallRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "CreateReversePlatformRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "UpdateWhichItemsAreMaterials", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "UpdateWhichItemsAreCrafted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "UpdateMaterialFieldForAllRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "ReplaceItemUseFlagsWithRecipeGroups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "CreateRequiredItemQuickLookups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShimmerTransforms), Member = "UpdateRecipeSets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 508)]
		public static void SetupRecipes()
		{
			throw null;
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00028F4F File Offset: 0x0002714F
		[global::Cpp2ILInjected.Token(Token = "0x60029A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1161B68", Offset = "0x1161B68", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void ReplaceItemUseFlagsWithRecipeGroups()
		{
			throw null;
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00028F52 File Offset: 0x00027152
		[global::Cpp2ILInjected.Token(Token = "0x60029A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1161D58", Offset = "0x1161D58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ReplaceItemUseFlagWithGroup(ref bool flag, int groupId)
		{
			throw null;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00028F55 File Offset: 0x00027155
		[global::Cpp2ILInjected.Token(Token = "0x60029AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1161D90", Offset = "0x1161D90", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void CreateRequiredItemQuickLookups()
		{
			throw null;
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00028F58 File Offset: 0x00027158
		[global::Cpp2ILInjected.Token(Token = "0x60029AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1161F80", Offset = "0x1161F80", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void UpdateMaterialFieldForAllRecipes()
		{
			throw null;
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00028F5B File Offset: 0x0002715B
		[global::Cpp2ILInjected.Token(Token = "0x60029AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1162138", Offset = "0x1162138", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void UpdateWhichItemsAreMaterials()
		{
			throw null;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00028F5E File Offset: 0x0002715E
		[global::Cpp2ILInjected.Token(Token = "0x60029AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x116213C", Offset = "0x116213C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void UpdateWhichItemsAreCrafted()
		{
			throw null;
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00028F61 File Offset: 0x00027161
		[global::Cpp2ILInjected.Token(Token = "0x60029AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1162348", Offset = "0x1162348", Length = "0xE8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		private static void AddSolarFurniture()
		{
			throw null;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00028F64 File Offset: 0x00027164
		[global::Cpp2ILInjected.Token(Token = "0x60029AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x11634E4", Offset = "0x11634E4", Length = "0xE8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		private static void AddVortexFurniture()
		{
			throw null;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00028F67 File Offset: 0x00027167
		[global::Cpp2ILInjected.Token(Token = "0x60029B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1164370", Offset = "0x1164370", Length = "0xE8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		private static void AddNebulaFurniture()
		{
			throw null;
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00028F6A File Offset: 0x0002716A
		[global::Cpp2ILInjected.Token(Token = "0x60029B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x11651FC", Offset = "0x11651FC", Length = "0xE8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		private static void AddStardustFurniture()
		{
			throw null;
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00028F6D File Offset: 0x0002716D
		[global::Cpp2ILInjected.Token(Token = "0x60029B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1166088", Offset = "0x1166088", Length = "0xE50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		private static void AddSpiderFurniture()
		{
			throw null;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00028F70 File Offset: 0x00027170
		[global::Cpp2ILInjected.Token(Token = "0x60029B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1166ED8", Offset = "0x1166ED8", Length = "0xF10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		private static void AddLesionFurniture()
		{
			throw null;
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00028F73 File Offset: 0x00027173
		[global::Cpp2ILInjected.Token(Token = "0x60029B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1167DE8", Offset = "0x1167DE8", Length = "0xD94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		private static void AddSandstoneFurniture()
		{
			throw null;
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00028F76 File Offset: 0x00027176
		[global::Cpp2ILInjected.Token(Token = "0x60029B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1168B7C", Offset = "0x1168B7C", Length = "0xCEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		private static void AddBambooFurniture()
		{
			throw null;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00028F79 File Offset: 0x00027179
		[global::Cpp2ILInjected.Token(Token = "0x60029B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1169868", Offset = "0x1169868", Length = "0xCEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		private static void AddCoralFurniture()
		{
			throw null;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00028F7C File Offset: 0x0002717C
		[global::Cpp2ILInjected.Token(Token = "0x60029B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x116A554", Offset = "0x116A554", Length = "0x1170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		private static void AddBalloonFurniture()
		{
			throw null;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00028F7F File Offset: 0x0002717F
		[global::Cpp2ILInjected.Token(Token = "0x60029B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x116B6C4", Offset = "0x116B6C4", Length = "0x1080")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "SetIngredients", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 64)]
		private static void AddAshWoodFurnitureArmorAndItems()
		{
			throw null;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00028F82 File Offset: 0x00027182
		[global::Cpp2ILInjected.Token(Token = "0x60029B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x116C744", Offset = "0x116C744", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void CreateReversePlatformRecipes()
		{
			throw null;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00028F85 File Offset: 0x00027185
		[global::Cpp2ILInjected.Token(Token = "0x60029BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x116CB14", Offset = "0x116CB14", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "AddRecipe", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void CreateReverseWallRecipes()
		{
			throw null;
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x00028F88 File Offset: 0x00027188
		[global::Cpp2ILInjected.Token(Token = "0x60029BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x11631D4", Offset = "0x11631D4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddSolarFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddVortexFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddNebulaFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddStardustFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddSpiderFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddLesionFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddSandstoneFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddBambooFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddCoralFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddBalloonFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddAshWoodFurnitureArmorAndItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 429)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void SetIngredients(params int[] ingredients)
		{
			throw null;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00028F8B File Offset: 0x0002718B
		[global::Cpp2ILInjected.Token(Token = "0x60029BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x11632F4", Offset = "0x11632F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 219)]
		public void SetCraftingStation(params int[] tileIDs)
		{
			throw null;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00028F8E File Offset: 0x0002718E
		[global::Cpp2ILInjected.Token(Token = "0x60029BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x116332C", Offset = "0x116332C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddSolarFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddVortexFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddNebulaFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddStardustFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddSpiderFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddLesionFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddSandstoneFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddBambooFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddCoralFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddBalloonFurniture", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddAshWoodFurnitureArmorAndItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CreateReversePlatformRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "CreateReverseWallRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2541)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void AddRecipe()
		{
			throw null;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00028F91 File Offset: 0x00027191
		[global::Cpp2ILInjected.Token(Token = "0x60029BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x116CEB0", Offset = "0x116CEB0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICraftGuidePopup), Member = "UpdateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int GetRequiredTileStyle(int tileID)
		{
			throw null;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00028F94 File Offset: 0x00027194
		[global::Cpp2ILInjected.Token(Token = "0x60029BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x116CF1C", Offset = "0x116CF1C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.ShimmerTransforms.<>c", Member = "<UpdateRecipeSets>b__3_0", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.ShimmerTransforms.<>c", Member = "<UpdateRecipeSets>b__3_1", MemberParameters = new object[] { typeof(Recipe) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool ContainsIngredient(int itemType)
		{
			throw null;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00028F97 File Offset: 0x00027197
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60029C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x116CF60", Offset = "0x116CF60", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static Recipe()
		{
			throw null;
		}

		// Token: 0x04002EF6 RID: 12022
		[global::Cpp2ILInjected.Token(Token = "0x40036BB")]
		public const int maxRequirements = 15;

		// Token: 0x04002EF7 RID: 12023
		[global::Cpp2ILInjected.Token(Token = "0x40036BC")]
		public const int maxRecipes = 3000;

		// Token: 0x04002EF8 RID: 12024
		[global::Cpp2ILInjected.Token(Token = "0x40036BD")]
		public static int numRecipes;

		// Token: 0x04002EF9 RID: 12025
		[global::Cpp2ILInjected.Token(Token = "0x40036BE")]
		private static Recipe currentRecipe;

		// Token: 0x04002EFA RID: 12026
		[global::Cpp2ILInjected.Token(Token = "0x40036BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Item createItem;

		// Token: 0x04002EFB RID: 12027
		[global::Cpp2ILInjected.Token(Token = "0x40036C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Item[] requiredItem;

		// Token: 0x04002EFC RID: 12028
		[global::Cpp2ILInjected.Token(Token = "0x40036C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int[] requiredTile;

		// Token: 0x04002EFD RID: 12029
		[global::Cpp2ILInjected.Token(Token = "0x40036C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int[] acceptedGroups;

		// Token: 0x04002EFE RID: 12030
		[global::Cpp2ILInjected.Token(Token = "0x40036C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Recipe.RequiredItemEntry[] requiredItemQuickLookup;

		// Token: 0x04002EFF RID: 12031
		[global::Cpp2ILInjected.Token(Token = "0x40036C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public List<Item> customShimmerResults;

		// Token: 0x04002F00 RID: 12032
		[global::Cpp2ILInjected.Token(Token = "0x40036C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool needHoney;

		// Token: 0x04002F01 RID: 12033
		[global::Cpp2ILInjected.Token(Token = "0x40036C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool needWater;

		// Token: 0x04002F02 RID: 12034
		[global::Cpp2ILInjected.Token(Token = "0x40036C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		public bool needLava;

		// Token: 0x04002F03 RID: 12035
		[global::Cpp2ILInjected.Token(Token = "0x40036C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
		public bool anyWood;

		// Token: 0x04002F04 RID: 12036
		[global::Cpp2ILInjected.Token(Token = "0x40036C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool anyIronBar;

		// Token: 0x04002F05 RID: 12037
		[global::Cpp2ILInjected.Token(Token = "0x40036CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
		public bool anyPressurePlate;

		// Token: 0x04002F06 RID: 12038
		[global::Cpp2ILInjected.Token(Token = "0x40036CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
		public bool anySand;

		// Token: 0x04002F07 RID: 12039
		[global::Cpp2ILInjected.Token(Token = "0x40036CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x47")]
		public bool anyFragment;

		// Token: 0x04002F08 RID: 12040
		[global::Cpp2ILInjected.Token(Token = "0x40036CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public bool alchemy;

		// Token: 0x04002F09 RID: 12041
		[global::Cpp2ILInjected.Token(Token = "0x40036CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		public bool needSnowBiome;

		// Token: 0x04002F0A RID: 12042
		[global::Cpp2ILInjected.Token(Token = "0x40036CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		public bool needGraveyardBiome;

		// Token: 0x04002F0B RID: 12043
		[global::Cpp2ILInjected.Token(Token = "0x40036D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		public bool needEverythingSeed;

		// Token: 0x04002F0C RID: 12044
		[global::Cpp2ILInjected.Token(Token = "0x40036D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public bool notDecraftable;

		// Token: 0x04002F0D RID: 12045
		[global::Cpp2ILInjected.Token(Token = "0x40036D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		public bool crimson;

		// Token: 0x04002F0E RID: 12046
		[global::Cpp2ILInjected.Token(Token = "0x40036D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E")]
		public bool corruption;

		// Token: 0x04002F0F RID: 12047
		[global::Cpp2ILInjected.Token(Token = "0x40036D4")]
		private static Item defaultRecipeItem;

		// Token: 0x04002F10 RID: 12048
		[global::Cpp2ILInjected.Token(Token = "0x40036D5")]
		private static bool _hasDelayedFindRecipes;

		// Token: 0x04002F11 RID: 12049
		[global::Cpp2ILInjected.Token(Token = "0x40036D6")]
		private static Dictionary<int, int> _ownedItems;

		// Token: 0x0200086D RID: 2157
		[global::Cpp2ILInjected.Token(Token = "0x2000456")]
		private struct RequiredItemEntry
		{
			// Token: 0x04007F7B RID: 32635
			[global::Cpp2ILInjected.Token(Token = "0x40036D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int itemIdOrRecipeGroup;

			// Token: 0x04007F7C RID: 32636
			[global::Cpp2ILInjected.Token(Token = "0x40036D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int stack;
		}

		// Token: 0x0200086E RID: 2158
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000457")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004A67 RID: 19047 RVA: 0x0002F306 File Offset: 0x0002D506
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60029C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D03C", Offset = "0x116D03C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004A68 RID: 19048 RVA: 0x0002F309 File Offset: 0x0002D509
			[global::Cpp2ILInjected.Token(Token = "0x60029C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D098", Offset = "0x116D098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004A69 RID: 19049 RVA: 0x0002F30C File Offset: 0x0002D50C
			[global::Cpp2ILInjected.Token(Token = "0x60029C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D0A0", Offset = "0x116D0A0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_0()
			{
				throw null;
			}

			// Token: 0x06004A6A RID: 19050 RVA: 0x0002F30F File Offset: 0x0002D50F
			[global::Cpp2ILInjected.Token(Token = "0x60029C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D130", Offset = "0x116D130", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_1()
			{
				throw null;
			}

			// Token: 0x06004A6B RID: 19051 RVA: 0x0002F312 File Offset: 0x0002D512
			[global::Cpp2ILInjected.Token(Token = "0x60029C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D1C0", Offset = "0x116D1C0", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_2()
			{
				throw null;
			}

			// Token: 0x06004A6C RID: 19052 RVA: 0x0002F315 File Offset: 0x0002D515
			[global::Cpp2ILInjected.Token(Token = "0x60029C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D250", Offset = "0x116D250", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_3()
			{
				throw null;
			}

			// Token: 0x06004A6D RID: 19053 RVA: 0x0002F318 File Offset: 0x0002D518
			[global::Cpp2ILInjected.Token(Token = "0x60029C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D2D4", Offset = "0x116D2D4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_4()
			{
				throw null;
			}

			// Token: 0x06004A6E RID: 19054 RVA: 0x0002F31B File Offset: 0x0002D51B
			[global::Cpp2ILInjected.Token(Token = "0x60029C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D358", Offset = "0x116D358", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_5()
			{
				throw null;
			}

			// Token: 0x06004A6F RID: 19055 RVA: 0x0002F31E File Offset: 0x0002D51E
			[global::Cpp2ILInjected.Token(Token = "0x60029C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D3DC", Offset = "0x116D3DC", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_6()
			{
				throw null;
			}

			// Token: 0x06004A70 RID: 19056 RVA: 0x0002F321 File Offset: 0x0002D521
			[global::Cpp2ILInjected.Token(Token = "0x60029CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D460", Offset = "0x116D460", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_7()
			{
				throw null;
			}

			// Token: 0x06004A71 RID: 19057 RVA: 0x0002F324 File Offset: 0x0002D524
			[global::Cpp2ILInjected.Token(Token = "0x60029CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D4E4", Offset = "0x116D4E4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_8()
			{
				throw null;
			}

			// Token: 0x06004A72 RID: 19058 RVA: 0x0002F327 File Offset: 0x0002D527
			[global::Cpp2ILInjected.Token(Token = "0x60029CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D568", Offset = "0x116D568", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetNPCNameValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal string <SetupRecipeGroups>b__56_9()
			{
				throw null;
			}

			// Token: 0x06004A73 RID: 19059 RVA: 0x0002F32A File Offset: 0x0002D52A
			[global::Cpp2ILInjected.Token(Token = "0x60029CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D5F8", Offset = "0x116D5F8", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_10()
			{
				throw null;
			}

			// Token: 0x06004A74 RID: 19060 RVA: 0x0002F32D File Offset: 0x0002D52D
			[global::Cpp2ILInjected.Token(Token = "0x60029CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D69C", Offset = "0x116D69C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_11()
			{
				throw null;
			}

			// Token: 0x06004A75 RID: 19061 RVA: 0x0002F330 File Offset: 0x0002D530
			[global::Cpp2ILInjected.Token(Token = "0x60029CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D740", Offset = "0x116D740", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_12()
			{
				throw null;
			}

			// Token: 0x06004A76 RID: 19062 RVA: 0x0002F333 File Offset: 0x0002D533
			[global::Cpp2ILInjected.Token(Token = "0x60029D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D7E4", Offset = "0x116D7E4", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_13()
			{
				throw null;
			}

			// Token: 0x06004A77 RID: 19063 RVA: 0x0002F336 File Offset: 0x0002D536
			[global::Cpp2ILInjected.Token(Token = "0x60029D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D888", Offset = "0x116D888", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_14()
			{
				throw null;
			}

			// Token: 0x06004A78 RID: 19064 RVA: 0x0002F339 File Offset: 0x0002D539
			[global::Cpp2ILInjected.Token(Token = "0x60029D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D92C", Offset = "0x116D92C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_15()
			{
				throw null;
			}

			// Token: 0x06004A79 RID: 19065 RVA: 0x0002F33C File Offset: 0x0002D53C
			[global::Cpp2ILInjected.Token(Token = "0x60029D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x116D9D0", Offset = "0x116D9D0", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_16()
			{
				throw null;
			}

			// Token: 0x06004A7A RID: 19066 RVA: 0x0002F33F File Offset: 0x0002D53F
			[global::Cpp2ILInjected.Token(Token = "0x60029D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DA74", Offset = "0x116DA74", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_17()
			{
				throw null;
			}

			// Token: 0x06004A7B RID: 19067 RVA: 0x0002F342 File Offset: 0x0002D542
			[global::Cpp2ILInjected.Token(Token = "0x60029D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DB18", Offset = "0x116DB18", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal string <SetupRecipeGroups>b__56_18()
			{
				throw null;
			}

			// Token: 0x06004A7C RID: 19068 RVA: 0x0002F345 File Offset: 0x0002D545
			[global::Cpp2ILInjected.Token(Token = "0x60029D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DBBC", Offset = "0x116DBBC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <SetupRecipeGroups>b__56_19()
			{
				throw null;
			}

			// Token: 0x06004A7D RID: 19069 RVA: 0x0002F348 File Offset: 0x0002D548
			[global::Cpp2ILInjected.Token(Token = "0x60029D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DBFC", Offset = "0x116DBFC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <SetupRecipeGroups>b__56_20()
			{
				throw null;
			}

			// Token: 0x06004A7E RID: 19070 RVA: 0x0002F34B File Offset: 0x0002D54B
			[global::Cpp2ILInjected.Token(Token = "0x60029D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DC3C", Offset = "0x116DC3C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <SetupRecipeGroups>b__56_21()
			{
				throw null;
			}

			// Token: 0x06004A7F RID: 19071 RVA: 0x0002F34E File Offset: 0x0002D54E
			[global::Cpp2ILInjected.Token(Token = "0x60029D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DC7C", Offset = "0x116DC7C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <SetupRecipeGroups>b__56_22()
			{
				throw null;
			}

			// Token: 0x06004A80 RID: 19072 RVA: 0x0002F351 File Offset: 0x0002D551
			[global::Cpp2ILInjected.Token(Token = "0x60029DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x116DCBC", Offset = "0x116DCBC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <SetupRecipeGroups>b__56_23()
			{
				throw null;
			}

			// Token: 0x04007F7D RID: 32637
			[global::Cpp2ILInjected.Token(Token = "0x40036D9")]
			public static readonly Recipe.<>c <>9;

			// Token: 0x04007F7E RID: 32638
			[global::Cpp2ILInjected.Token(Token = "0x40036DA")]
			public static Func<string> <>9__56_0;

			// Token: 0x04007F7F RID: 32639
			[global::Cpp2ILInjected.Token(Token = "0x40036DB")]
			public static Func<string> <>9__56_1;

			// Token: 0x04007F80 RID: 32640
			[global::Cpp2ILInjected.Token(Token = "0x40036DC")]
			public static Func<string> <>9__56_2;

			// Token: 0x04007F81 RID: 32641
			[global::Cpp2ILInjected.Token(Token = "0x40036DD")]
			public static Func<string> <>9__56_3;

			// Token: 0x04007F82 RID: 32642
			[global::Cpp2ILInjected.Token(Token = "0x40036DE")]
			public static Func<string> <>9__56_4;

			// Token: 0x04007F83 RID: 32643
			[global::Cpp2ILInjected.Token(Token = "0x40036DF")]
			public static Func<string> <>9__56_5;

			// Token: 0x04007F84 RID: 32644
			[global::Cpp2ILInjected.Token(Token = "0x40036E0")]
			public static Func<string> <>9__56_6;

			// Token: 0x04007F85 RID: 32645
			[global::Cpp2ILInjected.Token(Token = "0x40036E1")]
			public static Func<string> <>9__56_7;

			// Token: 0x04007F86 RID: 32646
			[global::Cpp2ILInjected.Token(Token = "0x40036E2")]
			public static Func<string> <>9__56_8;

			// Token: 0x04007F87 RID: 32647
			[global::Cpp2ILInjected.Token(Token = "0x40036E3")]
			public static Func<string> <>9__56_9;

			// Token: 0x04007F88 RID: 32648
			[global::Cpp2ILInjected.Token(Token = "0x40036E4")]
			public static Func<string> <>9__56_10;

			// Token: 0x04007F89 RID: 32649
			[global::Cpp2ILInjected.Token(Token = "0x40036E5")]
			public static Func<string> <>9__56_11;

			// Token: 0x04007F8A RID: 32650
			[global::Cpp2ILInjected.Token(Token = "0x40036E6")]
			public static Func<string> <>9__56_12;

			// Token: 0x04007F8B RID: 32651
			[global::Cpp2ILInjected.Token(Token = "0x40036E7")]
			public static Func<string> <>9__56_13;

			// Token: 0x04007F8C RID: 32652
			[global::Cpp2ILInjected.Token(Token = "0x40036E8")]
			public static Func<string> <>9__56_14;

			// Token: 0x04007F8D RID: 32653
			[global::Cpp2ILInjected.Token(Token = "0x40036E9")]
			public static Func<string> <>9__56_15;

			// Token: 0x04007F8E RID: 32654
			[global::Cpp2ILInjected.Token(Token = "0x40036EA")]
			public static Func<string> <>9__56_16;

			// Token: 0x04007F8F RID: 32655
			[global::Cpp2ILInjected.Token(Token = "0x40036EB")]
			public static Func<string> <>9__56_17;

			// Token: 0x04007F90 RID: 32656
			[global::Cpp2ILInjected.Token(Token = "0x40036EC")]
			public static Func<string> <>9__56_18;

			// Token: 0x04007F91 RID: 32657
			[global::Cpp2ILInjected.Token(Token = "0x40036ED")]
			public static Func<string> <>9__56_19;

			// Token: 0x04007F92 RID: 32658
			[global::Cpp2ILInjected.Token(Token = "0x40036EE")]
			public static Func<string> <>9__56_20;

			// Token: 0x04007F93 RID: 32659
			[global::Cpp2ILInjected.Token(Token = "0x40036EF")]
			public static Func<string> <>9__56_21;

			// Token: 0x04007F94 RID: 32660
			[global::Cpp2ILInjected.Token(Token = "0x40036F0")]
			public static Func<string> <>9__56_22;

			// Token: 0x04007F95 RID: 32661
			[global::Cpp2ILInjected.Token(Token = "0x40036F1")]
			public static Func<string> <>9__56_23;
		}
	}
}
