using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200009A")]
public class GUIControllerPVP4Page : GUIControllerPVP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private GUIControllerDynamicGridNavigator _gridNav;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private int selectedButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private GUIControllerPageMenuPopupGridNavigator _teamNav;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GUIControllerDynamicGridNavigator GridNav
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x1214D3C", Offset = "0x1214D3C", VA = "0x1214D3C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private GUIControllerPageMenuPopupGridNavigator TeamNav
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x1215270", Offset = "0x1215270", VA = "0x1215270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x1214CB8", Offset = "0x1214CB8", VA = "0x1214CB8")]
	private DraggableItemGrid_Layout GetGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x1214D14", Offset = "0x1214D14", VA = "0x1214D14", Slot = "8")]
	public override int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1214F40", Offset = "0x1214F40", VA = "0x1214F40")]
	private int GetCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x1214FA0", Offset = "0x1214FA0", VA = "0x1214FA0")]
	private float GetItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x1214FF8", Offset = "0x1214FF8", VA = "0x1214FF8")]
	private float GetScrollOffset()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x1215058", Offset = "0x1215058", VA = "0x1215058")]
	private void SetScrollOffset(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x12150C4", Offset = "0x12150C4", VA = "0x12150C4", Slot = "13")]
	public override bool IsInMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x12150DC", Offset = "0x12150DC", VA = "0x12150DC")]
	private int GetMenuItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x12151AC", Offset = "0x12151AC", VA = "0x12151AC")]
	private int GetDisplayItemCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x12151B4", Offset = "0x12151B4", VA = "0x12151B4")]
	private ItemGrid_Layout GetTeamGrid()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x1215210", Offset = "0x1215210", VA = "0x1215210")]
	private int GetTeamCollectionCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x1215218", Offset = "0x1215218", VA = "0x1215218")]
	private float GetTeamItemScale()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x1215414", Offset = "0x1215414", VA = "0x1215414", Slot = "9")]
	public override void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x1215528", Offset = "0x1215528", VA = "0x1215528", Slot = "10")]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x121575C", Offset = "0x121575C", VA = "0x121575C", Slot = "14")]
	protected override void ClampPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x1215760", Offset = "0x1215760", VA = "0x1215760", Slot = "11")]
	public override Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x1215BD0", Offset = "0x1215BD0", VA = "0x1215BD0", Slot = "12")]
	public override void NavigateInto(int column, int row)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x1215BF8", Offset = "0x1215BF8", VA = "0x1215BF8")]
	public GUIControllerPVP4Page()
	{
	}
}
