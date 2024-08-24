using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x020005A3 RID: 1443
	[global::Cpp2ILInjected.Token(Token = "0x2000841")]
	public class AllPersonalitiesModifier : IShopPersonalityTrait
	{
		// Token: 0x06003BE9 RID: 15337 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		[global::Cpp2ILInjected.Token(Token = "0x600430C")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D3D0", Offset = "0x79D3D0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice_Relationships", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
			throw null;
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x0002CB4F File Offset: 0x0002AD4F
		[global::Cpp2ILInjected.Token(Token = "0x600430D")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D3F8", Offset = "0x79D3F8", Length = "0xC80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AllPersonalitiesModifier), Member = "ModifyShopPrice", MemberParameters = new object[]
		{
			typeof(HelperInfo),
			typeof(ShopHelper)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LoveNPCByTypeName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LikePrincess", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "DislikeNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "HateNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LoveNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LikeNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void ModifyShopPrice_Relationships(HelperInfo info, ShopHelper shopHelperInstance)
		{
			throw null;
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x0002CB52 File Offset: 0x0002AD52
		[global::Cpp2ILInjected.Token(Token = "0x600430E")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E078", Offset = "0x79E078", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "ProcessMood", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AllPersonalitiesModifier()
		{
			throw null;
		}
	}
}
