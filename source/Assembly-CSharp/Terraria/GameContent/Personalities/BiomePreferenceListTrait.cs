using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200058F RID: 1423
	[global::Cpp2ILInjected.Token(Token = "0x200082C")]
	public class BiomePreferenceListTrait : IShopPersonalityTrait, IEnumerable<BiomePreferenceListTrait.BiomePreference>, IEnumerable
	{
		// Token: 0x06003BBD RID: 15293 RVA: 0x0002CACE File Offset: 0x0002ACCE
		[global::Cpp2ILInjected.Token(Token = "0x60042DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x79BF08", Offset = "0x79BF08", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public BiomePreferenceListTrait()
		{
			throw null;
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x0002CAD1 File Offset: 0x0002ACD1
		[global::Cpp2ILInjected.Token(Token = "0x60042E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x79BF88", Offset = "0x79BF88", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(BiomePreferenceListTrait.BiomePreference preference)
		{
			throw null;
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x0002CAD4 File Offset: 0x0002ACD4
		[global::Cpp2ILInjected.Token(Token = "0x60042E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C030", Offset = "0x79C030", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Add(AffectionLevel level, AShoppingBiome biome)
		{
			throw null;
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x0002CAD7 File Offset: 0x0002ACD7
		[global::Cpp2ILInjected.Token(Token = "0x60042E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C14C", Offset = "0x79C14C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
		{
			throw null;
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x0002CADA File Offset: 0x0002ACDA
		[global::Cpp2ILInjected.Token(Token = "0x60042E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C23C", Offset = "0x79C23C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LoveBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "DislikeBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "LikeBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShopHelper), Member = "HateBiome", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private void ApplyPreference(BiomePreferenceListTrait.BiomePreference preference, HelperInfo info, ShopHelper shopHelperInstance)
		{
			throw null;
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x0002CADD File Offset: 0x0002ACDD
		[global::Cpp2ILInjected.Token(Token = "0x60042E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C2A4", Offset = "0x79C2A4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEnumerator<BiomePreferenceListTrait.BiomePreference> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x0002CAE0 File Offset: 0x0002ACE0
		[global::Cpp2ILInjected.Token(Token = "0x60042E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x79C334", Offset = "0x79C334", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04006B31 RID: 27441
		[global::Cpp2ILInjected.Token(Token = "0x400812C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<BiomePreferenceListTrait.BiomePreference> _preferences;

		// Token: 0x020009A8 RID: 2472
		[global::Cpp2ILInjected.Token(Token = "0x200082D")]
		public class BiomePreference
		{
			// Token: 0x06004DF7 RID: 19959 RVA: 0x0002FC21 File Offset: 0x0002DE21
			[global::Cpp2ILInjected.Token(Token = "0x60042E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x79C11C", Offset = "0x79C11C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public BiomePreference(AffectionLevel affection, AShoppingBiome biome)
			{
				throw null;
			}

			// Token: 0x04008CB0 RID: 36016
			[global::Cpp2ILInjected.Token(Token = "0x400812D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public AffectionLevel Affection;

			// Token: 0x04008CB1 RID: 36017
			[global::Cpp2ILInjected.Token(Token = "0x400812E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public AShoppingBiome Biome;
		}
	}
}
