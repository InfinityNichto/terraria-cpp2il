using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000105")]
public class GUITalkerList
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private List<string> ActiveTalkers;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private Rectangle lastDrawRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private GUIItemGrid.GetItemScaleHandler itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private GUIItemGrid.CursorOver itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private GUIItemGrid.DrawItemHandler itemDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007CD")]
	private int itemOffset;

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0xEC4450", Offset = "0xEC4450", VA = "0xEC4450")]
	public GUITalkerList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0xEC4588", Offset = "0xEC4588", VA = "0xEC4588")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0xEC4ABC", Offset = "0xEC4ABC", VA = "0xEC4ABC")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0xEC4B18", Offset = "0xEC4B18", VA = "0xEC4B18")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0xEC4B1C", Offset = "0xEC4B1C", VA = "0xEC4B1C")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0xEC4A58", Offset = "0xEC4A58", VA = "0xEC4A58")]
	public void RefreshTalkersList()
	{
	}
}
