using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.UI;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000687")]
public static class ItemFilters
{
	[Cpp2IlInjected.Token(Token = "0x2000A69")]
	public class BySearch : IItemEntryFilter, IEntryFilter<Item>, ISearchFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x4008E8B")]
		private const int _tooltipMaxLines = 30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E8C")]
		private string[] _toolTipLines;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008E8D")]
		private bool[] _unusedPrefixLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008E8E")]
		private bool[] _unusedBadPrefixLines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008E8F")]
		private int _unusedYoyoLogo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008E90")]
		private int _unusedResearchLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008E91")]
		private int _unusedSetBonusLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008E92")]
		private int _unusedMaterialsLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008E93")]
		private string _search;

		[Cpp2IlInjected.Token(Token = "0x60050F8")]
		[Cpp2IlInjected.Address(RVA = "0xD731E8", Offset = "0xD731E8", VA = "0xD731E8")]
		public BySearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050F9")]
		[Cpp2IlInjected.Address(RVA = "0xD73280", Offset = "0xD73280", VA = "0xD73280", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60050FA")]
		[Cpp2IlInjected.Address(RVA = "0xD733D4", Offset = "0xD733D4", VA = "0xD733D4", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FB")]
		[Cpp2IlInjected.Address(RVA = "0xD73424", Offset = "0xD73424", VA = "0xD73424", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60050FC")]
		[Cpp2IlInjected.Address(RVA = "0xD735EC", Offset = "0xD735EC", VA = "0xD735EC", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050FD")]
		[Cpp2IlInjected.Address(RVA = "0xD73788", Offset = "0xD73788", VA = "0xD73788", Slot = "8")]
		public void SetSearch(string searchText)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A6A")]
	public class BuildingBlock : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x60050FE")]
		[Cpp2IlInjected.Address(RVA = "0xD72D24", Offset = "0xD72D24", VA = "0xD72D24", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60050FF")]
		[Cpp2IlInjected.Address(RVA = "0xD72DE4", Offset = "0xD72DE4", VA = "0xD72DE4", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005100")]
		[Cpp2IlInjected.Address(RVA = "0xD72E34", Offset = "0xD72E34", VA = "0xD72E34", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005101")]
		[Cpp2IlInjected.Address(RVA = "0xD73020", Offset = "0xD73020", VA = "0xD73020", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005102")]
		[Cpp2IlInjected.Address(RVA = "0xD731E0", Offset = "0xD731E0", VA = "0xD731E0")]
		public BuildingBlock()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A6B")]
	public class Furniture : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x6005103")]
		[Cpp2IlInjected.Address(RVA = "0xD73BF8", Offset = "0xD73BF8", VA = "0xD73BF8", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005104")]
		[Cpp2IlInjected.Address(RVA = "0xD73C98", Offset = "0xD73C98", VA = "0xD73C98", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005105")]
		[Cpp2IlInjected.Address(RVA = "0xD73CE8", Offset = "0xD73CE8", VA = "0xD73CE8", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005106")]
		[Cpp2IlInjected.Address(RVA = "0xD73ED4", Offset = "0xD73ED4", VA = "0xD73ED4", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005107")]
		[Cpp2IlInjected.Address(RVA = "0xD74094", Offset = "0xD74094", VA = "0xD74094")]
		public Furniture()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A6C")]
	public class Tools : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E94")]
		private HashSet<int> _itemIdsThatAreAccepted;

		[Cpp2IlInjected.Token(Token = "0x6005108")]
		[Cpp2IlInjected.Address(RVA = "0xD7544C", Offset = "0xD7544C", VA = "0xD7544C", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005109")]
		[Cpp2IlInjected.Address(RVA = "0xD754EC", Offset = "0xD754EC", VA = "0xD754EC", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600510A")]
		[Cpp2IlInjected.Address(RVA = "0xD7553C", Offset = "0xD7553C", VA = "0xD7553C", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600510B")]
		[Cpp2IlInjected.Address(RVA = "0xD75728", Offset = "0xD75728", VA = "0xD75728", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600510C")]
		[Cpp2IlInjected.Address(RVA = "0xD758E8", Offset = "0xD758E8", VA = "0xD758E8")]
		public Tools()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A6D")]
	public class Weapon : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x600510D")]
		[Cpp2IlInjected.Address(RVA = "0xD76114", Offset = "0xD76114", VA = "0xD76114", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600510E")]
		[Cpp2IlInjected.Address(RVA = "0xD76128", Offset = "0xD76128", VA = "0xD76128", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600510F")]
		[Cpp2IlInjected.Address(RVA = "0xD76178", Offset = "0xD76178", VA = "0xD76178", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005110")]
		[Cpp2IlInjected.Address(RVA = "0xD76364", Offset = "0xD76364", VA = "0xD76364", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005111")]
		[Cpp2IlInjected.Address(RVA = "0xD76524", Offset = "0xD76524", VA = "0xD76524")]
		public Weapon()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A6E")]
	public abstract class AArmor
	{
		[Cpp2IlInjected.Token(Token = "0x6005112")]
		[Cpp2IlInjected.Address(RVA = "0xD72494", Offset = "0xD72494", VA = "0xD72494")]
		public bool IsAnArmorThatMatchesSocialState(Item entry, bool shouldBeSocial)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005113")]
		[Cpp2IlInjected.Address(RVA = "0xD724D0", Offset = "0xD724D0", VA = "0xD724D0")]
		protected AArmor()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A6F")]
	public class Armor : AArmor, IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x6005114")]
		[Cpp2IlInjected.Address(RVA = "0xD728E8", Offset = "0xD728E8", VA = "0xD728E8", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005115")]
		[Cpp2IlInjected.Address(RVA = "0xD72920", Offset = "0xD72920", VA = "0xD72920", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005116")]
		[Cpp2IlInjected.Address(RVA = "0xD72970", Offset = "0xD72970", VA = "0xD72970", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005117")]
		[Cpp2IlInjected.Address(RVA = "0xD72B5C", Offset = "0xD72B5C", VA = "0xD72B5C", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005118")]
		[Cpp2IlInjected.Address(RVA = "0xD72D1C", Offset = "0xD72D1C", VA = "0xD72D1C")]
		public Armor()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A70")]
	public class Vanity : AArmor, IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x6005119")]
		[Cpp2IlInjected.Address(RVA = "0xD75CD8", Offset = "0xD75CD8", VA = "0xD75CD8", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600511A")]
		[Cpp2IlInjected.Address(RVA = "0xD75D10", Offset = "0xD75D10", VA = "0xD75D10", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600511B")]
		[Cpp2IlInjected.Address(RVA = "0xD75D60", Offset = "0xD75D60", VA = "0xD75D60", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600511C")]
		[Cpp2IlInjected.Address(RVA = "0xD75F4C", Offset = "0xD75F4C", VA = "0xD75F4C", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600511D")]
		[Cpp2IlInjected.Address(RVA = "0xD7610C", Offset = "0xD7610C", VA = "0xD7610C")]
		public Vanity()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A71")]
	public abstract class AAccessories
	{
		[Cpp2IlInjected.Token(Token = "0x2000BC7")]
		public enum AccessoriesCategory
		{
			[Cpp2IlInjected.Token(Token = "0x4009147")]
			Misc,
			[Cpp2IlInjected.Token(Token = "0x4009148")]
			NonMisc
		}

		[Cpp2IlInjected.Token(Token = "0x600511E")]
		[Cpp2IlInjected.Address(RVA = "0xD723D4", Offset = "0xD723D4", VA = "0xD723D4")]
		public bool IsAnAccessoryOfType(Item entry, AccessoriesCategory categoryType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600511F")]
		[Cpp2IlInjected.Address(RVA = "0xD7248C", Offset = "0xD7248C", VA = "0xD7248C")]
		protected AAccessories()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A72")]
	public class Accessories : AAccessories, IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x6005120")]
		[Cpp2IlInjected.Address(RVA = "0xD724D8", Offset = "0xD724D8", VA = "0xD724D8", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005121")]
		[Cpp2IlInjected.Address(RVA = "0xD724E0", Offset = "0xD724E0", VA = "0xD724E0", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005122")]
		[Cpp2IlInjected.Address(RVA = "0xD72530", Offset = "0xD72530", VA = "0xD72530", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005123")]
		[Cpp2IlInjected.Address(RVA = "0xD72720", Offset = "0xD72720", VA = "0xD72720", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005124")]
		[Cpp2IlInjected.Address(RVA = "0xD728E0", Offset = "0xD728E0", VA = "0xD728E0")]
		public Accessories()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A73")]
	public class MiscAccessories : AAccessories, IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x6005125")]
		[Cpp2IlInjected.Address(RVA = "0xD74940", Offset = "0xD74940", VA = "0xD74940", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005126")]
		[Cpp2IlInjected.Address(RVA = "0xD74948", Offset = "0xD74948", VA = "0xD74948", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005127")]
		[Cpp2IlInjected.Address(RVA = "0xD74998", Offset = "0xD74998", VA = "0xD74998", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005128")]
		[Cpp2IlInjected.Address(RVA = "0xD74B84", Offset = "0xD74B84", VA = "0xD74B84", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005129")]
		[Cpp2IlInjected.Address(RVA = "0xD74D44", Offset = "0xD74D44", VA = "0xD74D44")]
		public MiscAccessories()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A74")]
	public class Consumables : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x600512A")]
		[Cpp2IlInjected.Address(RVA = "0xD73790", Offset = "0xD73790", VA = "0xD73790", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600512B")]
		[Cpp2IlInjected.Address(RVA = "0xD737F4", Offset = "0xD737F4", VA = "0xD737F4", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600512C")]
		[Cpp2IlInjected.Address(RVA = "0xD73844", Offset = "0xD73844", VA = "0xD73844", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600512D")]
		[Cpp2IlInjected.Address(RVA = "0xD73A30", Offset = "0xD73A30", VA = "0xD73A30", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600512E")]
		[Cpp2IlInjected.Address(RVA = "0xD73BF0", Offset = "0xD73BF0", VA = "0xD73BF0")]
		public Consumables()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A75")]
	public class GameplayItems : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x600512F")]
		[Cpp2IlInjected.Address(RVA = "0xD7409C", Offset = "0xD7409C", VA = "0xD7409C", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005130")]
		[Cpp2IlInjected.Address(RVA = "0xD74130", Offset = "0xD74130", VA = "0xD74130", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005131")]
		[Cpp2IlInjected.Address(RVA = "0xD74180", Offset = "0xD74180", VA = "0xD74180", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005132")]
		[Cpp2IlInjected.Address(RVA = "0xD7436C", Offset = "0xD7436C", VA = "0xD7436C", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005133")]
		[Cpp2IlInjected.Address(RVA = "0xD7452C", Offset = "0xD7452C", VA = "0xD7452C")]
		public GameplayItems()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A76")]
	public class MiscFallback : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E95")]
		private bool[] _fitsFilterByItemType;

		[Cpp2IlInjected.Token(Token = "0x6005134")]
		[Cpp2IlInjected.Address(RVA = "0xD74D4C", Offset = "0xD74D4C", VA = "0xD74D4C")]
		public MiscFallback(List<IItemEntryFilter> otherFiltersToCheckAgainst)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005135")]
		[Cpp2IlInjected.Address(RVA = "0xD74F90", Offset = "0xD74F90", VA = "0xD74F90", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005136")]
		[Cpp2IlInjected.Address(RVA = "0xD75050", Offset = "0xD75050", VA = "0xD75050", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005137")]
		[Cpp2IlInjected.Address(RVA = "0xD750A0", Offset = "0xD750A0", VA = "0xD750A0", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6005138")]
		[Cpp2IlInjected.Address(RVA = "0xD7528C", Offset = "0xD7528C", VA = "0xD7528C", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A77")]
	public class Materials : IItemEntryFilter, IEntryFilter<Item>
	{
		[Cpp2IlInjected.Token(Token = "0x6005139")]
		[Cpp2IlInjected.Address(RVA = "0xD74534", Offset = "0xD74534", VA = "0xD74534", Slot = "4")]
		public bool FitsFilter(Item entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600513A")]
		[Cpp2IlInjected.Address(RVA = "0xD7453C", Offset = "0xD7453C", VA = "0xD7453C", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600513B")]
		[Cpp2IlInjected.Address(RVA = "0xD7458C", Offset = "0xD7458C", VA = "0xD7458C", Slot = "6")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600513C")]
		[Cpp2IlInjected.Address(RVA = "0xD74778", Offset = "0xD74778", VA = "0xD74778", Slot = "7")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600513D")]
		[Cpp2IlInjected.Address(RVA = "0xD74938", Offset = "0xD74938", VA = "0xD74938")]
		public Materials()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006DCE")]
	private const int framesPerRow = 11;

	[Cpp2IlInjected.Token(Token = "0x4006DCF")]
	private const int framesPerColumn = 1;

	[Cpp2IlInjected.Token(Token = "0x4006DD0")]
	private const int frameSizeOffsetX = -2;

	[Cpp2IlInjected.Token(Token = "0x4006DD1")]
	private const int frameSizeOffsetY = 0;
}
