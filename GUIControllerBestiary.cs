using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GUIControllerBestiary : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private int SelectedRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private int SelectedColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private int SelectedIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private int filterSelectedColumn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private int filterSelectedRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private bool onFilterSearchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private bool filtersActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private bool ordersActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private bool dropsActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private int maxItemIndex;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private int maxRowIndex
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xF8E920", Offset = "0xF8E920", VA = "0xF8E920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private int maxRowColumn
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xF8E9F4", Offset = "0xF8E9F4", VA = "0xF8E9F4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xF8E1C8", Offset = "0xF8E1C8", VA = "0xF8E1C8", Slot = "7")]
	public int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xF8E1D0", Offset = "0xF8E1D0", VA = "0xF8E1D0", Slot = "4")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xF8E584", Offset = "0xF8E584", VA = "0xF8E584")]
	public int GetSelectedIndex()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xF8E608", Offset = "0xF8E608", VA = "0xF8E608")]
	public void ActivateFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xF8E62C", Offset = "0xF8E62C", VA = "0xF8E62C")]
	public void DeactivateFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xF8E7A8", Offset = "0xF8E7A8", VA = "0xF8E7A8")]
	public void ActivateOrders(int maxOrders, int selectedOrder)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xF8E7D4", Offset = "0xF8E7D4", VA = "0xF8E7D4")]
	public void DeactivateOrders()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xF8E7E0", Offset = "0xF8E7E0", VA = "0xF8E7E0")]
	public void ActivateDrops(int maxDrops)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xF8E80C", Offset = "0xF8E80C", VA = "0xF8E80C")]
	public void DeactivateDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xF8E6DC", Offset = "0xF8E6DC", VA = "0xF8E6DC")]
	public void SelectEntry(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xF8E818", Offset = "0xF8E818", VA = "0xF8E818")]
	public void SelectNPCEntry(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xF8E898", Offset = "0xF8E898", VA = "0xF8E898")]
	public void SelectFilterEntry(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xF8E918", Offset = "0xF8E918", VA = "0xF8E918")]
	public void SelectDropEntry(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xF8E1E8", Offset = "0xF8E1E8", VA = "0xF8E1E8")]
	private void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xF8EAD8", Offset = "0xF8EAD8", VA = "0xF8EAD8", Slot = "5")]
	public GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xF8EDC4", Offset = "0xF8EDC4", VA = "0xF8EDC4")]
	private void ClampGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xF8EE2C", Offset = "0xF8EE2C", VA = "0xF8EE2C", Slot = "6")]
	public Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xF8F32C", Offset = "0xF8F32C", VA = "0xF8F32C")]
	public GUIControllerBestiary()
	{
	}
}
