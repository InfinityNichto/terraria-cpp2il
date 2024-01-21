using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class GUIControllerShop4Page : GUIControllerShop
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private GUIControllerStaticGridNavigator _gridNav;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GUIControllerStaticGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x121CF4C", Offset = "0x121CF4C", VA = "0x121CF4C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x121CE38", Offset = "0x121CE38", VA = "0x121CE38")]
	private ItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x121CEC4", Offset = "0x121CEC4", VA = "0x121CEC4")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x121CF1C", Offset = "0x121CF1C", VA = "0x121CF1C", Slot = "13")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x121D0D4", Offset = "0x121D0D4", VA = "0x121D0D4")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x121D0DC", Offset = "0x121D0DC", VA = "0x121D0DC")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x121D160", Offset = "0x121D160", VA = "0x121D160", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x121D1E0", Offset = "0x121D1E0", VA = "0x121D1E0", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x121D248", Offset = "0x121D248", VA = "0x121D248", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x121D390", Offset = "0x121D390", VA = "0x121D390", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x121D660", Offset = "0x121D660", VA = "0x121D660", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x1217FA8", Offset = "0x1217FA8", VA = "0x1217FA8")]
	public GUIControllerShop4Page()
	{
	}
}
