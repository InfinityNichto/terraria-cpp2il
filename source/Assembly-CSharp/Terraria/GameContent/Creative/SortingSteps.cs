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
	// Token: 0x02000686 RID: 1670
	[global::Cpp2ILInjected.Token(Token = "0x2000A29")]
	public static class SortingSteps
	{
		// Token: 0x02000A81 RID: 2689
		[global::Cpp2ILInjected.Token(Token = "0x2000A2A")]
		public abstract class ACreativeItemSortStep : ICreativeItemSortStep, IEntrySortStep<int>, IComparer<int>, IComparer<Item>
		{
			// Token: 0x06005107 RID: 20743
			[global::Cpp2ILInjected.Token(Token = "0x6004C85")]
			public abstract string GetDisplayNameKey();

			// Token: 0x06005108 RID: 20744 RVA: 0x000304B2 File Offset: 0x0002E6B2
			[global::Cpp2ILInjected.Token(Token = "0x6004C86")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBEE4", Offset = "0x8BBEE4", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public int Compare(int x, int y)
			{
				throw null;
			}

			// Token: 0x06005109 RID: 20745
			[global::Cpp2ILInjected.Token(Token = "0x6004C87")]
			public abstract int Compare(Item x, Item y);

			// Token: 0x0600510A RID: 20746 RVA: 0x000304B5 File Offset: 0x0002E6B5
			[global::Cpp2ILInjected.Token(Token = "0x6004C88")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBFA4", Offset = "0x8BBFA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected ACreativeItemSortStep()
			{
				throw null;
			}
		}

		// Token: 0x02000A82 RID: 2690
		[global::Cpp2ILInjected.Token(Token = "0x2000A2B")]
		public abstract class AStepByFittingFilter : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x0600510B RID: 20747 RVA: 0x000304B8 File Offset: 0x0002E6B8
			[global::Cpp2ILInjected.Token(Token = "0x6004C89")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BBFAC", Offset = "0x8BBFAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			public override int Compare(Item x, Item y)
			{
				throw null;
			}

			// Token: 0x0600510C RID: 20748
			[global::Cpp2ILInjected.Token(Token = "0x6004C8A")]
			public abstract bool FitsFilter(Item item);

			// Token: 0x0600510D RID: 20749 RVA: 0x000304BB File Offset: 0x0002E6BB
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

			// Token: 0x0600510E RID: 20750 RVA: 0x000304BE File Offset: 0x0002E6BE
			[global::Cpp2ILInjected.Token(Token = "0x6004C8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC04C", Offset = "0x8BC04C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected AStepByFittingFilter()
			{
				throw null;
			}
		}

		// Token: 0x02000A83 RID: 2691
		[global::Cpp2ILInjected.Token(Token = "0x2000A2C")]
		public class Blocks : SortingSteps.AStepByFittingFilter
		{
			// Token: 0x0600510F RID: 20751 RVA: 0x000304C1 File Offset: 0x0002E6C1
			[global::Cpp2ILInjected.Token(Token = "0x6004C8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC054", Offset = "0x8BC054", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06005110 RID: 20752 RVA: 0x000304C4 File Offset: 0x0002E6C4
			[global::Cpp2ILInjected.Token(Token = "0x6004C8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC094", Offset = "0x8BC094", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool FitsFilter(Item item)
			{
				throw null;
			}

			// Token: 0x06005111 RID: 20753 RVA: 0x000304C7 File Offset: 0x0002E6C7
			[global::Cpp2ILInjected.Token(Token = "0x6004C8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC114", Offset = "0x8BC114", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Blocks()
			{
				throw null;
			}
		}

		// Token: 0x02000A84 RID: 2692
		[global::Cpp2ILInjected.Token(Token = "0x2000A2D")]
		public class Walls : SortingSteps.AStepByFittingFilter
		{
			// Token: 0x06005112 RID: 20754 RVA: 0x000304CA File Offset: 0x0002E6CA
			[global::Cpp2ILInjected.Token(Token = "0x6004C90")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC11C", Offset = "0x8BC11C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06005113 RID: 20755 RVA: 0x000304CD File Offset: 0x0002E6CD
			[global::Cpp2ILInjected.Token(Token = "0x6004C91")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC15C", Offset = "0x8BC15C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool FitsFilter(Item item)
			{
				throw null;
			}

			// Token: 0x06005114 RID: 20756 RVA: 0x000304D0 File Offset: 0x0002E6D0
			[global::Cpp2ILInjected.Token(Token = "0x6004C92")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC16C", Offset = "0x8BC16C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Walls()
			{
				throw null;
			}
		}

		// Token: 0x02000A85 RID: 2693
		[global::Cpp2ILInjected.Token(Token = "0x2000A2E")]
		public class PlacableObjects : SortingSteps.AStepByFittingFilter
		{
			// Token: 0x06005115 RID: 20757 RVA: 0x000304D3 File Offset: 0x0002E6D3
			[global::Cpp2ILInjected.Token(Token = "0x6004C93")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC174", Offset = "0x8BC174", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06005116 RID: 20758 RVA: 0x000304D6 File Offset: 0x0002E6D6
			[global::Cpp2ILInjected.Token(Token = "0x6004C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC1B4", Offset = "0x8BC1B4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool FitsFilter(Item item)
			{
				throw null;
			}

			// Token: 0x06005117 RID: 20759 RVA: 0x000304D9 File Offset: 0x0002E6D9
			[global::Cpp2ILInjected.Token(Token = "0x6004C95")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC234", Offset = "0x8BC234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PlacableObjects()
			{
				throw null;
			}
		}

		// Token: 0x02000A86 RID: 2694
		[global::Cpp2ILInjected.Token(Token = "0x2000A2F")]
		public class ByCreativeSortingId : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x06005118 RID: 20760 RVA: 0x000304DC File Offset: 0x0002E6DC
			[global::Cpp2ILInjected.Token(Token = "0x6004C96")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC23C", Offset = "0x8BC23C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x06005119 RID: 20761 RVA: 0x000304DF File Offset: 0x0002E6DF
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

			// Token: 0x0600511A RID: 20762 RVA: 0x000304E2 File Offset: 0x0002E6E2
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

		// Token: 0x02000A87 RID: 2695
		[global::Cpp2ILInjected.Token(Token = "0x2000A30")]
		public class Alphabetical : SortingSteps.ACreativeItemSortStep
		{
			// Token: 0x0600511B RID: 20763 RVA: 0x000304E5 File Offset: 0x0002E6E5
			[global::Cpp2ILInjected.Token(Token = "0x6004C99")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC3AC", Offset = "0x8BC3AC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string GetDisplayNameKey()
			{
				throw null;
			}

			// Token: 0x0600511C RID: 20764 RVA: 0x000304E8 File Offset: 0x0002E6E8
			[global::Cpp2ILInjected.Token(Token = "0x6004C9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8BC3EC", Offset = "0x8BC3EC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareTo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			public override int Compare(Item x, Item y)
			{
				throw null;
			}

			// Token: 0x0600511D RID: 20765 RVA: 0x000304EB File Offset: 0x0002E6EB
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
