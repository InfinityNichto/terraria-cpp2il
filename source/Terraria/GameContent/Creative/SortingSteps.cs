using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A29")]
	public static class SortingSteps
	{
		[global::Cpp2ILInjected.Token(Token = "0x2000A2A")]
		public abstract class ACreativeItemSortStep : ICreativeItemSortStep, IEntrySortStep<int>, IComparer<int>, IComparer<Item>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C85")]
			public abstract string GetDisplayNameKey();

			[global::Cpp2ILInjected.Token(Token = "0x6004C86")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBEE4", Offset = "0x8BBEE4", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public int Compare(int x, int y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C87")]
			public abstract int Compare(Item x, Item y);

			[global::Cpp2ILInjected.Token(Token = "0x6004C88")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBFA4", Offset = "0x8BBFA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected ACreativeItemSortStep()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A2B")]
		public abstract class AStepByFittingFilter : SortingSteps.ACreativeItemSortStep
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C89")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBFAC", Offset = "0x8BBFAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			public override int Compare(Item x, Item y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C8A")]
			public abstract bool FitsFilter(Item item);

			[global::Cpp2ILInjected.Token(Token = "0x6004C8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC008", Offset = "0x8BC008", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			public virtual int CompareWhenBothFit(Item x, Item y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC04C", Offset = "0x8BC04C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AStepByFittingFilter()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A2C")]
		public class Blocks : SortingSteps.AStepByFittingFilter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC054", Offset = "0x8BC054", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC094", Offset = "0x8BC094", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool FitsFilter(Item item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC114", Offset = "0x8BC114", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Blocks()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A2D")]
		public class Walls : SortingSteps.AStepByFittingFilter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C90")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC11C", Offset = "0x8BC11C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C91")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC15C", Offset = "0x8BC15C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool FitsFilter(Item item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C92")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC16C", Offset = "0x8BC16C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Walls()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A2E")]
		public class PlacableObjects : SortingSteps.AStepByFittingFilter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C93")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC174", Offset = "0x8BC174", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC1B4", Offset = "0x8BC1B4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool FitsFilter(Item item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C95")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC234", Offset = "0x8BC234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlacableObjects()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A2F")]
		public class ByCreativeSortingId : SortingSteps.ACreativeItemSortStep
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C96")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC23C", Offset = "0x8BC23C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C97")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC27C", Offset = "0x8BC27C", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, ContentSamples.CreativeHelper.ItemGroupAndOrderInGroup>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override int Compare(Item x, Item y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C98")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC3A4", Offset = "0x8BC3A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ByCreativeSortingId()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A30")]
		public class Alphabetical : SortingSteps.ACreativeItemSortStep
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C99")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC3AC", Offset = "0x8BC3AC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC3EC", Offset = "0x8BC3EC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			public override int Compare(Item x, Item y)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004C9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC42C", Offset = "0x8BC42C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Alphabetical()
			{
				throw null;
			}
		}
	}
}
