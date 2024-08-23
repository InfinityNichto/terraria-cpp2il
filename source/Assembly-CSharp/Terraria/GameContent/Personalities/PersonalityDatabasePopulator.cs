using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000592 RID: 1426
	[global::Cpp2ILInjected.Token(Token = "0x2000830")]
	public class PersonalityDatabasePopulator
	{
		// Token: 0x06003BCA RID: 15306 RVA: 0x0002CAF5 File Offset: 0x0002ACF5
		[global::Cpp2ILInjected.Token(Token = "0x60042ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C7DC", Offset = "0x79C7DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Populate(PersonalityDatabase database)
		{
			throw null;
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		[global::Cpp2ILInjected.Token(Token = "0x60042EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C7E4", Offset = "0x79C7E4", Length = "0x7AC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OceanBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ForestBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SnowBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesertBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JungleBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UndergroundBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HallowBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MushroomBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BiomePreferenceListTrait), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BiomePreferenceListTrait), Member = "Add", MemberParameters = new object[]
		{
			typeof(AffectionLevel),
			typeof(AShoppingBiome)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersonalityDatabase), Member = "Register", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IShopPersonalityTrait)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private void Populate_BiomePreferences(PersonalityDatabase database)
		{
			throw null;
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0002CAFB File Offset: 0x0002ACFB
		[global::Cpp2ILInjected.Token(Token = "0x60042EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D230", Offset = "0x79D230", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PersonalityDatabasePopulator()
		{
			throw null;
		}

		// Token: 0x04006B36 RID: 27446
		[global::Cpp2ILInjected.Token(Token = "0x4008133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private PersonalityDatabase _currentDatabase;
	}
}
