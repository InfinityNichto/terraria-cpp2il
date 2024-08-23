using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	// Token: 0x02000563 RID: 1379
	[global::Cpp2ILInjected.Token(Token = "0x20007EB")]
	public static class ShimmerTransforms
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x0002C63F File Offset: 0x0002A83F
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

		// Token: 0x06003A35 RID: 14901 RVA: 0x0002C642 File Offset: 0x0002A842
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

		// Token: 0x06003A36 RID: 14902 RVA: 0x0002C645 File Offset: 0x0002A845
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

		// Token: 0x02000993 RID: 2451
		[global::Cpp2ILInjected.Token(Token = "0x20007EC")]
		public static class RecipeSets
		{
			// Token: 0x04008C56 RID: 35926
			[global::Cpp2ILInjected.Token(Token = "0x4007EDA")]
			public static bool[] PostSkeletron;

			// Token: 0x04008C57 RID: 35927
			[global::Cpp2ILInjected.Token(Token = "0x4007EDB")]
			public static bool[] PostGolem;
		}

		// Token: 0x02000994 RID: 2452
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20007ED")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004DC4 RID: 19908 RVA: 0x0002FB94 File Offset: 0x0002DD94
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

			// Token: 0x06004DC5 RID: 19909 RVA: 0x0002FB97 File Offset: 0x0002DD97
			[global::Cpp2ILInjected.Token(Token = "0x6004127")]
			[global::Cpp2ILInjected.Address(RVA = "0x778D40", Offset = "0x778D40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004DC6 RID: 19910 RVA: 0x0002FB9A File Offset: 0x0002DD9A
			[global::Cpp2ILInjected.Token(Token = "0x6004128")]
			[global::Cpp2ILInjected.Address(RVA = "0x778D48", Offset = "0x778D48", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "ContainsIngredient", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			internal bool <UpdateRecipeSets>b__3_0(Recipe r)
			{
				throw null;
			}

			// Token: 0x06004DC7 RID: 19911 RVA: 0x0002FB9D File Offset: 0x0002DD9D
			[global::Cpp2ILInjected.Token(Token = "0x6004129")]
			[global::Cpp2ILInjected.Address(RVA = "0x778D58", Offset = "0x778D58", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "ContainsIngredient", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			internal bool <UpdateRecipeSets>b__3_1(Recipe r)
			{
				throw null;
			}

			// Token: 0x04008C58 RID: 35928
			[global::Cpp2ILInjected.Token(Token = "0x4007EDC")]
			public static readonly ShimmerTransforms.<>c <>9;

			// Token: 0x04008C59 RID: 35929
			[global::Cpp2ILInjected.Token(Token = "0x4007EDD")]
			public static Func<Recipe, bool> <>9__3_0;

			// Token: 0x04008C5A RID: 35930
			[global::Cpp2ILInjected.Token(Token = "0x4007EDE")]
			public static Func<Recipe, bool> <>9__3_1;
		}
	}
}
