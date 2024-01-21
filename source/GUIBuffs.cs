using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class GUIBuffs
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private int buffOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private int buffToRemove;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private int lastDrawBuffText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private float lastdoubleClickTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	public int numActiveBuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private int[] activeBuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	public bool buffTogglePressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	public bool buffActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	public GUIControllerBuff buffController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private DateTime NavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private GUIItemGrid.CursorOver itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x135E6B4", Offset = "0x135E6B4", VA = "0x135E6B4")]
	public GUIBuffs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x135E848", Offset = "0x135E848", VA = "0x135E848")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x135E968", Offset = "0x135E968", VA = "0x135E968")]
	private void ChangeBuffString(int buffType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x135EA9C", Offset = "0x135EA9C", VA = "0x135EA9C")]
	private void NextItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x135EBCC", Offset = "0x135EBCC", VA = "0x135EBCC")]
	private void PreviousItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x135ECFC", Offset = "0x135ECFC", VA = "0x135ECFC")]
	private void RemoveBuff()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x135F170", Offset = "0x135F170", VA = "0x135F170")]
	public void UpdateBuffNavigation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x135F590", Offset = "0x135F590", VA = "0x135F590")]
	private bool CanRemoveBuff()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x135ED20", Offset = "0x135ED20", VA = "0x135ED20")]
	private void RemoveBuff(int buff)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x135F67C", Offset = "0x135F67C", VA = "0x135F67C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x135FCC4", Offset = "0x135FCC4", VA = "0x135FCC4")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x135FCDC", Offset = "0x135FCDC", VA = "0x135FCDC")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x135FFE0", Offset = "0x135FFE0", VA = "0x135FFE0")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}
}
