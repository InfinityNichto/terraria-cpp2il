using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000632")]
	public class RecipeItemCreationContext : ItemCreationContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003628")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCB74", Offset = "0x13DCB74", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RecipeItemCreationContext(Recipe recipe)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Recipe Recipe;
	}
}
