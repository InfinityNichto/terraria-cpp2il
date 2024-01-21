using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200061B")]
public static class SortingSteps
{
	[Cpp2IlInjected.Token(Token = "0x2000A10")]
	public class ByNetId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008D6")]
		public bool HiddenFromSortOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE0")]
			[Cpp2IlInjected.Address(RVA = "0x1104070", Offset = "0x1104070", VA = "0x1104070", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE1")]
		[Cpp2IlInjected.Address(RVA = "0x1104078", Offset = "0x1104078", VA = "0x1104078", Slot = "6")]
		public int Compare(BestiaryEntry x, BestiaryEntry y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE2")]
		[Cpp2IlInjected.Address(RVA = "0x110432C", Offset = "0x110432C", VA = "0x110432C", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE3")]
		[Cpp2IlInjected.Address(RVA = "0x110437C", Offset = "0x110437C", VA = "0x110437C")]
		public ByNetId()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A11")]
	public class ByUnlockState : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008D7")]
		public bool HiddenFromSortOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE4")]
			[Cpp2IlInjected.Address(RVA = "0x1104784", Offset = "0x1104784", VA = "0x1104784", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE5")]
		[Cpp2IlInjected.Address(RVA = "0x110478C", Offset = "0x110478C", VA = "0x110478C", Slot = "6")]
		public int Compare(BestiaryEntry x, BestiaryEntry y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE6")]
		[Cpp2IlInjected.Address(RVA = "0x1104A04", Offset = "0x1104A04", VA = "0x1104A04", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE7")]
		[Cpp2IlInjected.Address(RVA = "0x1104A54", Offset = "0x1104A54", VA = "0x1104A54")]
		public ByUnlockState()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A12")]
	public class ByBestiarySortingId : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008D8")]
		public bool HiddenFromSortOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6004FE8")]
			[Cpp2IlInjected.Address(RVA = "0x1103A30", Offset = "0x1103A30", VA = "0x1103A30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FE9")]
		[Cpp2IlInjected.Address(RVA = "0x1103A38", Offset = "0x1103A38", VA = "0x1103A38", Slot = "6")]
		public int Compare(BestiaryEntry x, BestiaryEntry y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FEA")]
		[Cpp2IlInjected.Address(RVA = "0x1103D54", Offset = "0x1103D54", VA = "0x1103D54", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FEB")]
		[Cpp2IlInjected.Address(RVA = "0x1103DA4", Offset = "0x1103DA4", VA = "0x1103DA4")]
		public ByBestiarySortingId()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A13")]
	public class ByBestiaryRarity : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008D9")]
		public bool HiddenFromSortOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6004FEC")]
			[Cpp2IlInjected.Address(RVA = "0x1103524", Offset = "0x1103524", VA = "0x1103524", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FED")]
		[Cpp2IlInjected.Address(RVA = "0x110352C", Offset = "0x110352C", VA = "0x110352C", Slot = "6")]
		public int Compare(BestiaryEntry x, BestiaryEntry y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FEE")]
		[Cpp2IlInjected.Address(RVA = "0x110384C", Offset = "0x110384C", VA = "0x110384C", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FEF")]
		[Cpp2IlInjected.Address(RVA = "0x110389C", Offset = "0x110389C", VA = "0x110389C")]
		public ByBestiaryRarity()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A14")]
	public class Alphabetical : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008DA")]
		public bool HiddenFromSortOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6004FF0")]
			[Cpp2IlInjected.Address(RVA = "0x1102F90", Offset = "0x1102F90", VA = "0x1102F90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF1")]
		[Cpp2IlInjected.Address(RVA = "0x1102F98", Offset = "0x1102F98", VA = "0x1102F98", Slot = "6")]
		public int Compare(BestiaryEntry x, BestiaryEntry y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF2")]
		[Cpp2IlInjected.Address(RVA = "0x11032D0", Offset = "0x11032D0", VA = "0x11032D0", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF3")]
		[Cpp2IlInjected.Address(RVA = "0x1103320", Offset = "0x1103320", VA = "0x1103320")]
		public Alphabetical()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A15")]
	public abstract class ByStat : IBestiarySortStep, IEntrySortStep<BestiaryEntry>, IComparer<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008DB")]
		public bool HiddenFromSortOptions
		{
			[Cpp2IlInjected.Token(Token = "0x6004FF4")]
			[Cpp2IlInjected.Address(RVA = "0x1104510", Offset = "0x1104510", VA = "0x1104510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF5")]
		[Cpp2IlInjected.Address(RVA = "0x1104518", Offset = "0x1104518", VA = "0x1104518", Slot = "6")]
		public int Compare(BestiaryEntry x, BestiaryEntry y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY);

		[Cpp2IlInjected.Token(Token = "0x6004FF7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract string GetDisplayNameKey();

		[Cpp2IlInjected.Token(Token = "0x6004FF8")]
		[Cpp2IlInjected.Address(RVA = "0x11046F0", Offset = "0x11046F0", VA = "0x11046F0")]
		private bool IsAStatsCardINeed(IBestiaryInfoElement element)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FF9")]
		[Cpp2IlInjected.Address(RVA = "0x110351C", Offset = "0x110351C", VA = "0x110351C")]
		protected ByStat()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A16")]
	public class ByAttack : ByStat
	{
		[Cpp2IlInjected.Token(Token = "0x6004FFC")]
		[Cpp2IlInjected.Address(RVA = "0x11034B4", Offset = "0x11034B4", VA = "0x11034B4", Slot = "7")]
		public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFD")]
		[Cpp2IlInjected.Address(RVA = "0x11034C4", Offset = "0x11034C4", VA = "0x11034C4", Slot = "8")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FFE")]
		[Cpp2IlInjected.Address(RVA = "0x1103514", Offset = "0x1103514", VA = "0x1103514")]
		public ByAttack()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A17")]
	public class ByDefense : ByStat
	{
		[Cpp2IlInjected.Token(Token = "0x6004FFF")]
		[Cpp2IlInjected.Address(RVA = "0x1103FA0", Offset = "0x1103FA0", VA = "0x1103FA0", Slot = "7")]
		public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005000")]
		[Cpp2IlInjected.Address(RVA = "0x1103FB0", Offset = "0x1103FB0", VA = "0x1103FB0", Slot = "8")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005001")]
		[Cpp2IlInjected.Address(RVA = "0x1104000", Offset = "0x1104000", VA = "0x1104000")]
		public ByDefense()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A18")]
	public class ByCoins : ByStat
	{
		[Cpp2IlInjected.Token(Token = "0x6005002")]
		[Cpp2IlInjected.Address(RVA = "0x1103F38", Offset = "0x1103F38", VA = "0x1103F38", Slot = "7")]
		public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005003")]
		[Cpp2IlInjected.Address(RVA = "0x1103F48", Offset = "0x1103F48", VA = "0x1103F48", Slot = "8")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005004")]
		[Cpp2IlInjected.Address(RVA = "0x1103F98", Offset = "0x1103F98", VA = "0x1103F98")]
		public ByCoins()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A19")]
	public class ByHP : ByStat
	{
		[Cpp2IlInjected.Token(Token = "0x6005005")]
		[Cpp2IlInjected.Address(RVA = "0x1104008", Offset = "0x1104008", VA = "0x1104008", Slot = "7")]
		public override int Compare(NPCStatsReportInfoElement cardX, NPCStatsReportInfoElement cardY)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6005006")]
		[Cpp2IlInjected.Address(RVA = "0x1104018", Offset = "0x1104018", VA = "0x1104018", Slot = "8")]
		public override string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005007")]
		[Cpp2IlInjected.Address(RVA = "0x1104068", Offset = "0x1104068", VA = "0x1104068")]
		public ByHP()
		{
		}
	}
}
