using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	[global::Cpp2ILInjected.Token(Token = "0x200082E")]
	public class NPCPreferenceTrait : IShopPersonalityTrait
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60042E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C438", Offset = "0x79C438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCPreferenceTrait()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400812F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AffectionLevel Level;

		[global::Cpp2ILInjected.Token(Token = "0x4008130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int NpcId;
	}
}
