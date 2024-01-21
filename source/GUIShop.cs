using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x2000104")]
public class GUIShop
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007BD")]
	private int cursorOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40007BE")]
	private int itemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007BF")]
	private int itemDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007C0")]
	private DateTime itemPurchaseDelayStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007C1")]
	private int _selectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40007C2")]
	private float buyButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007C3")]
	private bool _pendingPurchase;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	private int _pendingCost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	private int multibuyDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	public float hoverCraftDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	public GUITransactionButton.InputState lastState;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Item SelectedItem
	{
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0xEEE0B8", Offset = "0xEEE0B8", VA = "0xEEE0B8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0xEF08AC", Offset = "0xEF08AC", VA = "0xEF08AC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0xEEDF8C", Offset = "0xEEDF8C", VA = "0xEEDF8C")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0xEEE160", Offset = "0xEEE160", VA = "0xEEE160")]
	private void PurchasePressedAndHeld(bool delayedPurchase = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0xEEE81C", Offset = "0xEEE81C", VA = "0xEEE81C")]
	public void DrawPurchaseButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0xEEF894", Offset = "0xEEF894", VA = "0xEEF894")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0xEF0078", Offset = "0xEF0078", VA = "0xEF0078")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0xEF00D0", Offset = "0xEF00D0", VA = "0xEF00D0")]
	public void PurchasePendingItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0xEF0190", Offset = "0xEF0190", VA = "0xEF0190")]
	public void CancelPendingItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0xEF0248", Offset = "0xEF0248", VA = "0xEF0248")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0xEF0984", Offset = "0xEF0984", VA = "0xEF0984")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0xEEFDD4", Offset = "0xEEFDD4", VA = "0xEEFDD4")]
	private void DrawSlots(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0xEF0CE0", Offset = "0xEF0CE0", VA = "0xEF0CE0")]
	public GUIShop()
	{
	}
}
