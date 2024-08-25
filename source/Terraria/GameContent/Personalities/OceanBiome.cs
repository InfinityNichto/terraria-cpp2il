using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.Personalities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000832")]
	public class OceanBiome : AShoppingBiome
	{
		[global::Cpp2ILInjected.Token(Token = "0x60042F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x79CF90", Offset = "0x79CF90", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersonalityDatabasePopulator), Member = "Populate_BiomePreferences", MemberParameters = new object[] { typeof(PersonalityDatabase) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public OceanBiome()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60042F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x79D250", Offset = "0x79D250", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneBeach", ReturnType = typeof(bool))]
		public override bool IsInBiome(Player player)
		{
			throw null;
		}
	}
}
