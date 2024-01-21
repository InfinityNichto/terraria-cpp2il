using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200043A")]
public class RecipeItemCreationContext : ItemCreationContext
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006300")]
	public readonly Recipe Recipe;

	[Cpp2IlInjected.Token(Token = "0x6003147")]
	[Cpp2IlInjected.Address(RVA = "0x122E4F4", Offset = "0x122E4F4", VA = "0x122E4F4")]
	public RecipeItemCreationContext(Recipe recipe)
	{
	}
}
