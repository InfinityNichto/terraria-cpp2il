using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000E8")]
public class GUIInventorySplitStack
{
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	public static Texture2D SplitStackIcon;

	[Cpp2IlInjected.Token(Token = "0x4000628")]
	public static Texture2D SplitStackIconOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	public GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private bool open;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	private float splitSlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	private GUISlider.DragState dragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private Item ItemToSplit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private Item SplitItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private float splitScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private float itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private float mainScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private DateTime lastSplitTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private Vector2 lastSplitPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	public GUITransactionButton.InputState splitButtonState;

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x13663FC", Offset = "0x13663FC", VA = "0x13663FC")]
	public GUIInventorySplitStack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x1366520", Offset = "0x1366520", VA = "0x1366520")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x13665CC", Offset = "0x13665CC", VA = "0x13665CC")]
	public void Open()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x136667C", Offset = "0x136667C", VA = "0x136667C")]
	private void RefreshItemToSplit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x1366740", Offset = "0x1366740", VA = "0x1366740")]
	public bool IsOpen()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x1366748", Offset = "0x1366748", VA = "0x1366748")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x1366754", Offset = "0x1366754", VA = "0x1366754")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x1366988", Offset = "0x1366988", VA = "0x1366988")]
	public void RightClickSplit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x1366A90", Offset = "0x1366A90", VA = "0x1366A90")]
	public bool WasSplit()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x1366C34", Offset = "0x1366C34", VA = "0x1366C34")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x1367A28", Offset = "0x1367A28", VA = "0x1367A28")]
	public void DrawOverlay()
	{
	}
}
