using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20000CE")]
public class GUIButtonBar
{
	[Cpp2IlInjected.Token(Token = "0x20007B3")]
	public enum Action
	{
		[Cpp2IlInjected.Token(Token = "0x40079CB")]
		ButtonBarToggle,
		[Cpp2IlInjected.Token(Token = "0x40079CC")]
		Chat,
		[Cpp2IlInjected.Token(Token = "0x40079CD")]
		Tutorial,
		[Cpp2IlInjected.Token(Token = "0x40079CE")]
		JourneyModeSettings,
		[Cpp2IlInjected.Token(Token = "0x40079CF")]
		Housing,
		[Cpp2IlInjected.Token(Token = "0x40079D0")]
		PVP,
		[Cpp2IlInjected.Token(Token = "0x40079D1")]
		Bestiary,
		[Cpp2IlInjected.Token(Token = "0x40079D2")]
		MiniMapToggle,
		[Cpp2IlInjected.Token(Token = "0x40079D3")]
		Map,
		[Cpp2IlInjected.Token(Token = "0x40079D4")]
		Duplication,
		[Cpp2IlInjected.Token(Token = "0x40079D5")]
		Count
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private int ItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	public Action[] Items;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	public ControllerActionButton[] ItemsActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	public float[] Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private bool Expanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private GUIItemGrid.CursorOver itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0xF801E4", Offset = "0xF801E4", VA = "0xF801E4")]
	public GUIButtonBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0xF8033C", Offset = "0xF8033C", VA = "0xF8033C")]
	private void AddAction(Action action, ControllerActionButton bannerAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0xF803AC", Offset = "0xF803AC", VA = "0xF803AC")]
	private void RefreshItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0xF80638", Offset = "0xF80638", VA = "0xF80638")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0xF80694", Offset = "0xF80694", VA = "0xF80694")]
	private void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0xF80698", Offset = "0xF80698", VA = "0xF80698")]
	private Texture2D GetButtonSetup(Action action, int entry, out bool disabled, out string actionString, out TransactionButton_Layout buttonLayout)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0xF80A80", Offset = "0xF80A80", VA = "0xF80A80")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0xF80D34", Offset = "0xF80D34", VA = "0xF80D34")]
	private void PerformAction(Action action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xF81020", Offset = "0xF81020", VA = "0xF81020")]
	public void Draw()
	{
	}
}
