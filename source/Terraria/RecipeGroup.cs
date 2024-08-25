using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x2000454")]
	public class RecipeGroup
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002988")]
		[global::Cpp2ILInjected.Address(RVA = "0x115DA7C", Offset = "0x115DA7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetGroupFakeItemId()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40036B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Func<string> GetText;

		[global::Cpp2ILInjected.Token(Token = "0x40036B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public HashSet<int> ValidItems;

		[global::Cpp2ILInjected.Token(Token = "0x40036B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int IconicItemId;

		[global::Cpp2ILInjected.Token(Token = "0x40036B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int RegisteredId;

		[global::Cpp2ILInjected.Token(Token = "0x40036B8")]
		public static Dictionary<int, RecipeGroup> recipeGroups;

		[global::Cpp2ILInjected.Token(Token = "0x40036B9")]
		public static Dictionary<string, int> recipeGroupIDs;

		[global::Cpp2ILInjected.Token(Token = "0x40036BA")]
		public static int nextRecipeGroupIndex;
	}
}
