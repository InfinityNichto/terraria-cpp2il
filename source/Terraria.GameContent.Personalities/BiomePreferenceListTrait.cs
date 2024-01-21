using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000592")]
public class BiomePreferenceListTrait : IShopPersonalityTrait, IEnumerable<BiomePreferenceListTrait.BiomePreference>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200099F")]
	public class BiomePreference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C9D")]
		public AffectionLevel Affection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C9E")]
		public AShoppingBiome Biome;

		[Cpp2IlInjected.Token(Token = "0x6004E2E")]
		[Cpp2IlInjected.Address(RVA = "0x11977E4", Offset = "0x11977E4", VA = "0x11977E4")]
		public BiomePreference(AffectionLevel affection, AShoppingBiome biome)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B32")]
	private List<BiomePreference> _preferences;

	[Cpp2IlInjected.Token(Token = "0x6003BF9")]
	[Cpp2IlInjected.Address(RVA = "0x1197668", Offset = "0x1197668", VA = "0x1197668")]
	public BiomePreferenceListTrait()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BFA")]
	[Cpp2IlInjected.Address(RVA = "0x11976EC", Offset = "0x11976EC", VA = "0x11976EC")]
	public void Add(BiomePreference preference)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BFB")]
	[Cpp2IlInjected.Address(RVA = "0x1197750", Offset = "0x1197750", VA = "0x1197750")]
	public void Add(AffectionLevel level, AShoppingBiome biome)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BFC")]
	[Cpp2IlInjected.Address(RVA = "0x119780C", Offset = "0x119780C", VA = "0x119780C", Slot = "4")]
	public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BFD")]
	[Cpp2IlInjected.Address(RVA = "0x11978F8", Offset = "0x11978F8", VA = "0x11978F8")]
	private void ApplyPreference(BiomePreference preference, HelperInfo info, ShopHelper shopHelperInstance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003BFE")]
	[Cpp2IlInjected.Address(RVA = "0x1197954", Offset = "0x1197954", VA = "0x1197954", Slot = "5")]
	public IEnumerator<BiomePreference> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003BFF")]
	[Cpp2IlInjected.Address(RVA = "0x11979E0", Offset = "0x11979E0", VA = "0x11979E0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
