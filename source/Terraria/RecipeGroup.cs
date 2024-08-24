using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	// Token: 0x02000340 RID: 832
	[global::Cpp2ILInjected.Token(Token = "0x2000454")]
	public class RecipeGroup
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x00028EE6 File Offset: 0x000270E6
		[global::Cpp2ILInjected.Token(Token = "0x6002985")]
		[global::Cpp2ILInjected.Address(RVA = "0x115D78C", Offset = "0x115D78C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipeGroups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public RecipeGroup(Func<string> getName, params int[] validItems)
		{
			throw null;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00028EE9 File Offset: 0x000270E9
		[global::Cpp2ILInjected.Token(Token = "0x6002986")]
		[global::Cpp2ILInjected.Address(RVA = "0x115D82C", Offset = "0x115D82C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "SetupRecipeGroups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static int RegisterGroup(string name, RecipeGroup rec)
		{
			throw null;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00028EEC File Offset: 0x000270EC
		[global::Cpp2ILInjected.Token(Token = "0x6002987")]
		[global::Cpp2ILInjected.Address(RVA = "0x115D904", Offset = "0x115D904", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Recipe), Member = "AddFakeCountsForItemGroups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public int CountUsableItems(Dictionary<int, int> itemStacksAvailable)
		{
			throw null;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00028EEF File Offset: 0x000270EF
		[global::Cpp2ILInjected.Token(Token = "0x6002988")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DA7C", Offset = "0x115DA7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetGroupFakeItemId()
		{
			throw null;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00028EF2 File Offset: 0x000270F2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002989")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DA90", Offset = "0x115DA90", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static RecipeGroup()
		{
			throw null;
		}

		// Token: 0x04002EEF RID: 12015
		[global::Cpp2ILInjected.Token(Token = "0x40036B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Func<string> GetText;

		// Token: 0x04002EF0 RID: 12016
		[global::Cpp2ILInjected.Token(Token = "0x40036B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public HashSet<int> ValidItems;

		// Token: 0x04002EF1 RID: 12017
		[global::Cpp2ILInjected.Token(Token = "0x40036B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int IconicItemId;

		// Token: 0x04002EF2 RID: 12018
		[global::Cpp2ILInjected.Token(Token = "0x40036B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int RegisteredId;

		// Token: 0x04002EF3 RID: 12019
		[global::Cpp2ILInjected.Token(Token = "0x40036B8")]
		public static Dictionary<int, RecipeGroup> recipeGroups;

		// Token: 0x04002EF4 RID: 12020
		[global::Cpp2ILInjected.Token(Token = "0x40036B9")]
		public static Dictionary<string, int> recipeGroupIDs;

		// Token: 0x04002EF5 RID: 12021
		[global::Cpp2ILInjected.Token(Token = "0x40036BA")]
		public static int nextRecipeGroupIndex;
	}
}
