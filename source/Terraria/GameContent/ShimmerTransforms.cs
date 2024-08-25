using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007EB")]
	public static class ShimmerTransforms
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004123")]
		[global::Cpp2ILInjected.Address(RVA = "0x778868", Offset = "0x778868", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "FindDecraftAmount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetShimmered", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShimmerTransforms), Member = "IsItemTransformLocked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int GetDecraftingRecipeIndex(int type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004124")]
		[global::Cpp2ILInjected.Address(RVA = "0x7789D0", Offset = "0x7789D0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "CanShimmer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShimmerTransforms), Member = "GetDecraftingRecipeIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsItemTransformLocked(int type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004125")]
		[global::Cpp2ILInjected.Address(RVA = "0x778AAC", Offset = "0x778AAC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MapArray", MemberTypeParameters = new object[] { "T", "R" }, MemberParameters = new object[] { "T[]", "System.Func`2<T, R>" }, ReturnType = "R[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void UpdateRecipeSets()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007EC")]
		public static class RecipeSets
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007EDA")]
			public static bool[] PostSkeletron;

			[global::Cpp2ILInjected.Token(Token = "0x4007EDB")]
			public static bool[] PostGolem;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007ED")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004126")]
			[global::Cpp2ILInjected.Address(RVA = "0x778CE4", Offset = "0x778CE4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004127")]
			[global::Cpp2ILInjected.Address(RVA = "0x778D40", Offset = "0x778D40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004128")]
			[global::Cpp2ILInjected.Address(RVA = "0x778D48", Offset = "0x778D48", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "ContainsIngredient", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			internal bool <UpdateRecipeSets>b__3_0(Recipe r)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004129")]
			[global::Cpp2ILInjected.Address(RVA = "0x778D58", Offset = "0x778D58", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "ContainsIngredient", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			internal bool <UpdateRecipeSets>b__3_1(Recipe r)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007EDC")]
			public static readonly ShimmerTransforms.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4007EDD")]
			public static Func<Recipe, bool> <>9__3_0;

			[global::Cpp2ILInjected.Token(Token = "0x4007EDE")]
			public static Func<Recipe, bool> <>9__3_1;
		}
	}
}
