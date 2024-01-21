using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class GUIPageContentController : GUIControllerItem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly GUIPageIcons.Category PageCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private readonly GUIPageIconGrouping.SettingCategory SettingCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public int ResearchButton;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public GUIPageIconGrouping ParentGrouping
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x10004E0", Offset = "0x10004E0", VA = "0x10004E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x1000448", Offset = "0x1000448", VA = "0x1000448")]
	protected GUIPageContentController(GUIPageIcons.Category pageCategory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x1000470", Offset = "0x1000470", VA = "0x1000470")]
	protected GUIPageContentController(GUIPageIconGrouping.SettingCategory settingCategory)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x1000498", Offset = "0x1000498", VA = "0x1000498", Slot = "8")]
	public virtual int GetNavigationOutDirs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x10004A0", Offset = "0x10004A0", VA = "0x10004A0")]
	public bool IsPageContoller(GUIControllerItem item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x1000624", Offset = "0x1000624", VA = "0x1000624")]
	public void LoadPageAnchor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x1000784", Offset = "0x1000784", VA = "0x1000784", Slot = "9")]
	public virtual void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x1000788", Offset = "0x1000788", VA = "0x1000788", Slot = "10")]
	public virtual GUIControllerItem Navigate(Vector2 navigationVector)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x100078C", Offset = "0x100078C", VA = "0x100078C", Slot = "11")]
	public virtual Rectangle GetSelectedItemRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x1000798", Offset = "0x1000798", VA = "0x1000798", Slot = "12")]
	public virtual void NavigateInto(int column, int row)
	{
	}
}
