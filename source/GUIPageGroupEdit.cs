using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class GUIPageGroupEdit
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40014C9")]
	private bool LastHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40014CA")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40014CB")]
	private List<GUIPageIcons.Category> PageOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40014CC")]
	private List<GUIPageIconGrouping.SettingCategory> SettingOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40014CD")]
	public Vector2 toggleSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40014CE")]
	private int hoverItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40014CF")]
	private bool CanOptionBeAdded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40014D0")]
	private GUIInputRegionExclusive pickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40014D1")]
	private Rectangle popupRegion;

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x100079C", Offset = "0x100079C", VA = "0x100079C")]
	private int SortSettings(GUIPageIconGrouping.SettingCategory x, GUIPageIconGrouping.SettingCategory y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x1000848", Offset = "0x1000848", VA = "0x1000848")]
	private int SortCategories(GUIPageIcons.Category x, GUIPageIcons.Category y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x10008DC", Offset = "0x10008DC", VA = "0x10008DC")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0E")]
	[Cpp2IlInjected.Address(RVA = "0x1000A40", Offset = "0x1000A40", VA = "0x1000A40")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x10011F0", Offset = "0x10011F0", VA = "0x10011F0")]
	private float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x1001208", Offset = "0x1001208", VA = "0x1001208")]
	private void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x1001210", Offset = "0x1001210", VA = "0x1001210")]
	private void DisableCategory(GUIPageIcons.Category cat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x1001434", Offset = "0x1001434", VA = "0x1001434")]
	private void DisableSetting(GUIPageIconGrouping.SettingCategory cat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x1001658", Offset = "0x1001658", VA = "0x1001658")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x1001168", Offset = "0x1001168", VA = "0x1001168")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x1003690", Offset = "0x1003690", VA = "0x1003690")]
	private bool IsOverGroupOptions(Vector2 position)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x1003760", Offset = "0x1003760", VA = "0x1003760")]
	public GUIPageGroupEdit()
	{
	}
}
