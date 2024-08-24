using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000590 RID: 1424
	[global::Cpp2ILInjected.Token(Token = "0x200082E")]
	public class NPCPreferenceTrait : IShopPersonalityTrait
	{
		// Token: 0x06003BC4 RID: 15300 RVA: 0x0002CAE3 File Offset: 0x0002ACE3
		[global::Cpp2ILInjected.Token(Token = "0x60042E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C3C4", Offset = "0x79C3C4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LoveNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "DislikeNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LikeNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "HateNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
			throw null;
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x0002CAE6 File Offset: 0x0002ACE6
		[global::Cpp2ILInjected.Token(Token = "0x60042E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C438", Offset = "0x79C438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCPreferenceTrait()
		{
			throw null;
		}

		// Token: 0x04006B32 RID: 27442
		[global::Cpp2ILInjected.Token(Token = "0x400812F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AffectionLevel Level;

		// Token: 0x04006B33 RID: 27443
		[global::Cpp2ILInjected.Token(Token = "0x4008130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int NpcId;
	}
}
