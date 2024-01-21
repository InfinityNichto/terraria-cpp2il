using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000689")]
public static class SortingSteps
{
	[Cpp2IlInjected.Token(Token = "0x2000A78")]
	public abstract class ACreativeItemSortStep : ICreativeItemSortStep, IEntrySortStep<int>, IComparer<int>, IComparer<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x600513E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract string GetDisplayNameKey();

		[Cpp2IlInjected.Token(Token = "0x600513F")]
		[Cpp2IlInjected.Address(RVA = "0xD76C78", Offset = "0xD76C78", VA = "0xD76C78", Slot = "5")]
		public int Compare(int x, int y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005140")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract int Compare(Item x, Item y);

		[Cpp2IlInjected.Token(Token = "0x6005141")]
		[Cpp2IlInjected.Address(RVA = "0xD76D4C", Offset = "0xD76D4C", VA = "0xD76D4C")]
		protected ACreativeItemSortStep()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A79")]
	public abstract class AStepByFittingFilter : ACreativeItemSortStep
	{
		[Cpp2IlInjected.Token(Token = "0x6005142")]
		[Cpp2IlInjected.Address(RVA = "0xD76D54", Offset = "0xD76D54", VA = "0xD76D54", Slot = "8")]
		public override int Compare(Item x, Item y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract bool FitsFilter(Item item);

		[Cpp2IlInjected.Token(Token = "0x6005144")]
		[Cpp2IlInjected.Address(RVA = "0xD76DB8", Offset = "0xD76DB8", VA = "0xD76DB8", Slot = "10")]
		public virtual int CompareWhenBothFit(Item x, Item y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005145")]
		[Cpp2IlInjected.Address(RVA = "0xD76DF8", Offset = "0xD76DF8", VA = "0xD76DF8")]
		protected AStepByFittingFilter()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A7A")]
	public class Blocks : AStepByFittingFilter
	{
		[Cpp2IlInjected.Token(Token = "0x6005146")]
		[Cpp2IlInjected.Address(RVA = "0xD76E94", Offset = "0xD76E94", VA = "0xD76E94", Slot = "7")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005147")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE4", Offset = "0xD76EE4", VA = "0xD76EE4", Slot = "9")]
		public override bool FitsFilter(Item item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005148")]
		[Cpp2IlInjected.Address(RVA = "0xD76F88", Offset = "0xD76F88", VA = "0xD76F88")]
		public Blocks()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A7B")]
	public class Walls : AStepByFittingFilter
	{
		[Cpp2IlInjected.Token(Token = "0x6005149")]
		[Cpp2IlInjected.Address(RVA = "0xD77240", Offset = "0xD77240", VA = "0xD77240", Slot = "7")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600514A")]
		[Cpp2IlInjected.Address(RVA = "0xD77290", Offset = "0xD77290", VA = "0xD77290", Slot = "9")]
		public override bool FitsFilter(Item item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600514B")]
		[Cpp2IlInjected.Address(RVA = "0xD772A0", Offset = "0xD772A0", VA = "0xD772A0")]
		public Walls()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A7C")]
	public class PlacableObjects : AStepByFittingFilter
	{
		[Cpp2IlInjected.Token(Token = "0x600514C")]
		[Cpp2IlInjected.Address(RVA = "0xD77144", Offset = "0xD77144", VA = "0xD77144", Slot = "7")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600514D")]
		[Cpp2IlInjected.Address(RVA = "0xD77194", Offset = "0xD77194", VA = "0xD77194", Slot = "9")]
		public override bool FitsFilter(Item item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600514E")]
		[Cpp2IlInjected.Address(RVA = "0xD77238", Offset = "0xD77238", VA = "0xD77238")]
		public PlacableObjects()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A7D")]
	public class ByCreativeSortingId : ACreativeItemSortStep
	{
		[Cpp2IlInjected.Token(Token = "0x600514F")]
		[Cpp2IlInjected.Address(RVA = "0xD76F90", Offset = "0xD76F90", VA = "0xD76F90", Slot = "7")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005150")]
		[Cpp2IlInjected.Address(RVA = "0xD76FE0", Offset = "0xD76FE0", VA = "0xD76FE0", Slot = "8")]
		public override int Compare(Item x, Item y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005151")]
		[Cpp2IlInjected.Address(RVA = "0xD7713C", Offset = "0xD7713C", VA = "0xD7713C")]
		public ByCreativeSortingId()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A7E")]
	public class Alphabetical : ACreativeItemSortStep
	{
		[Cpp2IlInjected.Token(Token = "0x6005152")]
		[Cpp2IlInjected.Address(RVA = "0xD76E00", Offset = "0xD76E00", VA = "0xD76E00", Slot = "7")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005153")]
		[Cpp2IlInjected.Address(RVA = "0xD76E50", Offset = "0xD76E50", VA = "0xD76E50", Slot = "8")]
		public override int Compare(Item x, Item y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005154")]
		[Cpp2IlInjected.Address(RVA = "0xD76E8C", Offset = "0xD76E8C", VA = "0xD76E8C")]
		public Alphabetical()
		{
		}
	}
}
