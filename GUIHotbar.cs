using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000E4")]
public class GUIHotbar
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	private string LastItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	public bool menuTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	public bool hotbarActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	public GUIControllerHotbarRadial hotbarController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private DateTime NavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private float ScrollAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private GUIItemGrid.CursorOver itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0xDD53A8", Offset = "0xDD53A8", VA = "0xDD53A8")]
	public GUIHotbar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0xDD5500", Offset = "0xDD5500", VA = "0xDD5500")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0xDD5864", Offset = "0xDD5864", VA = "0xDD5864")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xDD5AF4", Offset = "0xDD5AF4", VA = "0xDD5AF4")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0xDD82C4", Offset = "0xDD82C4", VA = "0xDD82C4")]
	public void UpdateHotbarKeybinds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0xDD8BD8", Offset = "0xDD8BD8", VA = "0xDD8BD8")]
	private void UpdateHotbarScroll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0xDD99B4", Offset = "0xDD99B4", VA = "0xDD99B4")]
	public void UpdateHotbarNavigation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0xDD9E00", Offset = "0xDD9E00", VA = "0xDD9E00")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0xDDA020", Offset = "0xDDA020", VA = "0xDDA020")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0xDD60C4", Offset = "0xDD60C4", VA = "0xDD60C4")]
	public void DrawHotbarItem(SpriteBatch spriteBatch, ItemGrid_Layout layout, Item[] inv, int slot, Vector2 position, Color lightColor, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0xDD8A50", Offset = "0xDD8A50", VA = "0xDD8A50")]
	public void SetItem(int item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0xDD93C4", Offset = "0xDD93C4", VA = "0xDD93C4")]
	public void NextItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0xDDA8E8", Offset = "0xDDA8E8", VA = "0xDDA8E8")]
	private void RefreshInvCursorPosition(int itemOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0xDD8DC4", Offset = "0xDD8DC4", VA = "0xDD8DC4")]
	public void PreviousItem()
	{
	}
}
