using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Reflection;
using Terraria.GameContent.Personalities;
using Terraria.Localization;

namespace Terraria.GameContent
{
	// Token: 0x02000564 RID: 1380
	[global::Cpp2ILInjected.Token(Token = "0x20007EE")]
	public class ShopHelper
	{
		// Token: 0x06003A37 RID: 14903 RVA: 0x0002C648 File Offset: 0x0002A848
		[global::Cpp2ILInjected.Token(Token = "0x600412A")]
		[global::Cpp2ILInjected.Address(RVA = "0x778D68", Offset = "0x778D68", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CorruptionBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrimsonBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DungeonBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityDatabase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityDatabasePopulator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityDatabasePopulator), Member = "Populate", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public ShopHelper()
		{
			throw null;
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x0002C64B File Offset: 0x0002A84B
		[global::Cpp2ILInjected.Token(Token = "0x600412B")]
		[global::Cpp2ILInjected.Address(RVA = "0x778F0C", Offset = "0x778F0C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetTalkNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ShoppingSettings GetShoppingSettings(Player player, NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x0002C64E File Offset: 0x0002A84E
		[global::Cpp2ILInjected.Token(Token = "0x600412C")]
		[global::Cpp2ILInjected.Address(RVA = "0x779568", Offset = "0x779568", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private float GetSkeletonMerchantPrices(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x0002C651 File Offset: 0x0002A851
		[global::Cpp2ILInjected.Token(Token = "0x600412D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7796E4", Offset = "0x7796E4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_spawnTileX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_spawnTileY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private float GetTravelingMerchantPrices(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x0002C654 File Offset: 0x0002A854
		[global::Cpp2ILInjected.Token(Token = "0x600412E")]
		[global::Cpp2ILInjected.Address(RVA = "0x778F78", Offset = "0x778F78", Length = "0x5F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "GetShoppingSettings", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(ShoppingSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "RuinMoodIfHomeless", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "IsFarFromHome", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "IsPlayerInEvilBiomes", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "GetNearbyResidentNPCs", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(List<NPC>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityDatabase), Member = "GetByNPCID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PersonalityProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AllPersonalitiesModifier), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LimitAndRoundMultiplier", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private void ProcessMood(Player player, NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x0002C657 File Offset: 0x0002A857
		[global::Cpp2ILInjected.Token(Token = "0x600412F")]
		[global::Cpp2ILInjected.Address(RVA = "0x779F4C", Offset = "0x779F4C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private float LimitAndRoundMultiplier(float priceAdjustment)
		{
			throw null;
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x0002C65A File Offset: 0x0002A85A
		[global::Cpp2ILInjected.Token(Token = "0x6004130")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A044", Offset = "0x77A044", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LikeBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LoveBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "DislikeBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "HateBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "IsPlayerInEvilBiomes", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string BiomeNameByKey(string biomeNameKey)
		{
			throw null;
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x0002C65D File Offset: 0x0002A85D
		[global::Cpp2ILInjected.Token(Token = "0x6004131")]
		[global::Cpp2ILInjected.Address(RVA = "0x779E04", Offset = "0x779E04", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LikeBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LoveBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "DislikeBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "HateBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LikeNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LoveNPCByTypeName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LikePrincess", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LoveNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "DislikeNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "HateNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "RuinMoodIfHomeless", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "IsFarFromHome", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "IsPlayerInEvilBiomes", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void AddHappinessReportText(string textKeyInCategory, object substitutes = null)
		{
			throw null;
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x0002C660 File Offset: 0x0002A860
		[global::Cpp2ILInjected.Token(Token = "0x6004132")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A098", Offset = "0x77A098", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BiomePreferenceListTrait), Member = "ApplyPreference", MemberParameters = new object[]
		{
			typeof(BiomePreferenceListTrait.BiomePreference),
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "BiomeNameByKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType4<>), Member = ".ctor", MemberParameters = new object[] { "<BiomeName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void LikeBiome(string nameKey)
		{
			throw null;
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x0002C663 File Offset: 0x0002A863
		[global::Cpp2ILInjected.Token(Token = "0x6004133")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A160", Offset = "0x77A160", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BiomePreferenceListTrait), Member = "ApplyPreference", MemberParameters = new object[]
		{
			typeof(BiomePreferenceListTrait.BiomePreference),
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "BiomeNameByKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType4<>), Member = ".ctor", MemberParameters = new object[] { "<BiomeName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void LoveBiome(string nameKey)
		{
			throw null;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x0002C666 File Offset: 0x0002A866
		[global::Cpp2ILInjected.Token(Token = "0x6004134")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A228", Offset = "0x77A228", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BiomePreferenceListTrait), Member = "ApplyPreference", MemberParameters = new object[]
		{
			typeof(BiomePreferenceListTrait.BiomePreference),
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "BiomeNameByKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType4<>), Member = ".ctor", MemberParameters = new object[] { "<BiomeName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DislikeBiome(string nameKey)
		{
			throw null;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x0002C669 File Offset: 0x0002A869
		[global::Cpp2ILInjected.Token(Token = "0x6004135")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A2F0", Offset = "0x77A2F0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BiomePreferenceListTrait), Member = "ApplyPreference", MemberParameters = new object[]
		{
			typeof(BiomePreferenceListTrait.BiomePreference),
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "BiomeNameByKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType4<>), Member = ".ctor", MemberParameters = new object[] { "<BiomeName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void HateBiome(string nameKey)
		{
			throw null;
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x0002C66C File Offset: 0x0002A86C
		[global::Cpp2ILInjected.Token(Token = "0x6004136")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A3B8", Offset = "0x77A3B8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPreferenceTrait), Member = "ModifyShopPrice", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType5<>), Member = ".ctor", MemberParameters = new object[] { "<NPCName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void LikeNPC(int npcType)
		{
			throw null;
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x0002C66F File Offset: 0x0002A86F
		[global::Cpp2ILInjected.Token(Token = "0x6004137")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A4A0", Offset = "0x77A4A0", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType5<>), Member = ".ctor", MemberParameters = new object[] { "<NPCName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void LoveNPCByTypeName(int npcType)
		{
			throw null;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x0002C672 File Offset: 0x0002A872
		[global::Cpp2ILInjected.Token(Token = "0x6004138")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A5E8", Offset = "0x77A5E8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType5<>), Member = ".ctor", MemberParameters = new object[] { "<NPCName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void LikePrincess()
		{
			throw null;
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x0002C675 File Offset: 0x0002A875
		[global::Cpp2ILInjected.Token(Token = "0x6004139")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A6CC", Offset = "0x77A6CC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPreferenceTrait), Member = "ModifyShopPrice", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType5<>), Member = ".ctor", MemberParameters = new object[] { "<NPCName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void LoveNPC(int npcType)
		{
			throw null;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x0002C678 File Offset: 0x0002A878
		[global::Cpp2ILInjected.Token(Token = "0x600413A")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A7B4", Offset = "0x77A7B4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPreferenceTrait), Member = "ModifyShopPrice", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType5<>), Member = ".ctor", MemberParameters = new object[] { "<NPCName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void DislikeNPC(int npcType)
		{
			throw null;
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x0002C67B File Offset: 0x0002A87B
		[global::Cpp2ILInjected.Token(Token = "0x600413B")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A89C", Offset = "0x77A89C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCPreferenceTrait), Member = "ModifyShopPrice", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetFullnameByID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType5<>), Member = ".ctor", MemberParameters = new object[] { "<NPCName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void HateNPC(int npcType)
		{
			throw null;
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x0002C67E File Offset: 0x0002A87E
		[global::Cpp2ILInjected.Token(Token = "0x600413C")]
		[global::Cpp2ILInjected.Address(RVA = "0x779AD0", Offset = "0x779AD0", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownRoomManager), Member = "CanNPCsLiveWithEachOther_ShopHelper", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(NPC)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private List<NPC> GetNearbyResidentNPCs(NPC npc, out int npcsWithinHouse, out int npcsWithinVillage)
		{
			throw null;
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x0002C681 File Offset: 0x0002A881
		[global::Cpp2ILInjected.Token(Token = "0x600413D")]
		[global::Cpp2ILInjected.Address(RVA = "0x779838", Offset = "0x779838", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool RuinMoodIfHomeless(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x0002C684 File Offset: 0x0002A884
		[global::Cpp2ILInjected.Token(Token = "0x600413E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7798A8", Offset = "0x7798A8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool IsFarFromHome(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x0002C687 File Offset: 0x0002A887
		[global::Cpp2ILInjected.Token(Token = "0x600413F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7799C8", Offset = "0x7799C8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "BiomeNameByKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType4<>), Member = ".ctor", MemberParameters = new object[] { "<BiomeName>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool IsPlayerInEvilBiomes(Player player)
		{
			throw null;
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x0002C68A File Offset: 0x0002A88A
		[global::Cpp2ILInjected.Token(Token = "0x6004140")]
		[global::Cpp2ILInjected.Address(RVA = "0x779810", Offset = "0x779810", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsNotReallyTownNPC(NPC npc)
		{
			throw null;
		}

		// Token: 0x04006939 RID: 26937
		[global::Cpp2ILInjected.Token(Token = "0x4007EDF")]
		public const float LowestPossiblePriceMultiplier = 0.75f;

		// Token: 0x0400693A RID: 26938
		[global::Cpp2ILInjected.Token(Token = "0x4007EE0")]
		public const float MaxHappinessAchievementPriceMultiplier = 0.82f;

		// Token: 0x0400693B RID: 26939
		[global::Cpp2ILInjected.Token(Token = "0x4007EE1")]
		public const float HighestPossiblePriceMultiplier = 1.5f;

		// Token: 0x0400693C RID: 26940
		[global::Cpp2ILInjected.Token(Token = "0x4007EE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _currentHappiness;

		// Token: 0x0400693D RID: 26941
		[global::Cpp2ILInjected.Token(Token = "0x4007EE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private float _currentPriceAdjustment;

		// Token: 0x0400693E RID: 26942
		[global::Cpp2ILInjected.Token(Token = "0x4007EE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NPC _currentNPCBeingTalkedTo;

		// Token: 0x0400693F RID: 26943
		[global::Cpp2ILInjected.Token(Token = "0x4007EE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Player _currentPlayerTalking;

		// Token: 0x04006940 RID: 26944
		[global::Cpp2ILInjected.Token(Token = "0x4007EE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private PersonalityDatabase _database;

		// Token: 0x04006941 RID: 26945
		[global::Cpp2ILInjected.Token(Token = "0x4007EE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private AShoppingBiome[] _dangerousBiomes;

		// Token: 0x04006942 RID: 26946
		[global::Cpp2ILInjected.Token(Token = "0x4007EE8")]
		private const float likeValue = 0.94f;

		// Token: 0x04006943 RID: 26947
		[global::Cpp2ILInjected.Token(Token = "0x4007EE9")]
		private const float dislikeValue = 1.06f;

		// Token: 0x04006944 RID: 26948
		[global::Cpp2ILInjected.Token(Token = "0x4007EEA")]
		private const float loveValue = 0.88f;

		// Token: 0x04006945 RID: 26949
		[global::Cpp2ILInjected.Token(Token = "0x4007EEB")]
		private const float hateValue = 1.12f;
	}
}
