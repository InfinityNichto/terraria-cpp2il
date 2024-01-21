using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x200059F")]
public class DungeonBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C1D")]
	[Cpp2IlInjected.Address(RVA = "0x1197BBC", Offset = "0x1197BBC", VA = "0x1197BBC")]
	public DungeonBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C1E")]
	[Cpp2IlInjected.Address(RVA = "0x1197C20", Offset = "0x1197C20", VA = "0x1197C20", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
