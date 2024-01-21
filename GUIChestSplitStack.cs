using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class GUIChestSplitStack
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	public GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private int SelectedItemInitial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private bool open;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private float splitSlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private GUISlider.DragState dragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private Item ItemToSplit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private Item SplitItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private float splitScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private float itemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private float mainScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private DateTime lastSplitTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400045D")]
	private Vector2 lastSplitPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	public GUITransactionButton.InputState splitButtonState;

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0xF84424", Offset = "0xF84424", VA = "0xF84424")]
	public GUIChestSplitStack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0xF84548", Offset = "0xF84548", VA = "0xF84548")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0xF84774", Offset = "0xF84774", VA = "0xF84774")]
	public void RightClickSplit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0xF84880", Offset = "0xF84880", VA = "0xF84880")]
	public bool WasSplit()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0xF84A24", Offset = "0xF84A24", VA = "0xF84A24")]
	public bool IsOpen()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0xF84A2C", Offset = "0xF84A2C", VA = "0xF84A2C")]
	public void Open()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0xF84AF8", Offset = "0xF84AF8", VA = "0xF84AF8")]
	private void RefreshItemToSplit(bool SliderConsoleRightDirection = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0xF83E30", Offset = "0xF83E30", VA = "0xF83E30")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0xF84BD8", Offset = "0xF84BD8", VA = "0xF84BD8")]
	public void Draw()
	{
	}
}
