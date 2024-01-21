using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GUIControllerCraftingGuide : GUIPageContentController
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1293478", Offset = "0x1293478", VA = "0x1293478")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x1293264", Offset = "0x1293264", VA = "0x1293264")]
	public GUIControllerCraftingGuide()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x1293270", Offset = "0x1293270", VA = "0x1293270")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x12932CC", Offset = "0x12932CC", VA = "0x12932CC")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x1293330", Offset = "0x1293330", VA = "0x1293330")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x1293388", Offset = "0x1293388", VA = "0x1293388")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x12933E8", Offset = "0x12933E8", VA = "0x12933E8")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x1293454", Offset = "0x1293454", VA = "0x1293454")]
	public bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x1293690", Offset = "0x1293690", VA = "0x1293690")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1293698", Offset = "0x1293698", VA = "0x1293698")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x12936A0", Offset = "0x12936A0", VA = "0x12936A0", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x12936C4", Offset = "0x12936C4", VA = "0x12936C4", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x12936DC", Offset = "0x12936DC", VA = "0x12936DC")]
	public void RefreshScrollOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x1293700", Offset = "0x1293700", VA = "0x1293700")]
	protected void UpdateScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x1293704", Offset = "0x1293704", VA = "0x1293704", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x1293738", Offset = "0x1293738", VA = "0x1293738")]
	protected void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x129373C", Offset = "0x129373C", VA = "0x129373C", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1293770", Offset = "0x1293770", VA = "0x1293770", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}
}
