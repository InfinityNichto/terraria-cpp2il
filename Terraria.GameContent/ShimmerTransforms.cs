using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000566")]
public static class ShimmerTransforms
{
	[Cpp2IlInjected.Token(Token = "0x200098A")]
	public static class RecipeSets
	{
		[Cpp2IlInjected.Token(Token = "0x4008C43")]
		public static bool[] PostSkeletron;

		[Cpp2IlInjected.Token(Token = "0x4008C44")]
		public static bool[] PostGolem;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A70")]
	[Cpp2IlInjected.Address(RVA = "0x110F1FC", Offset = "0x110F1FC", VA = "0x110F1FC")]
	public static int GetDecraftingRecipeIndex(int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A71")]
	[Cpp2IlInjected.Address(RVA = "0x110F3EC", Offset = "0x110F3EC", VA = "0x110F3EC")]
	public static bool IsItemTransformLocked(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A72")]
	[Cpp2IlInjected.Address(RVA = "0x110F520", Offset = "0x110F520", VA = "0x110F520")]
	public static void UpdateRecipeSets()
	{
	}
}
