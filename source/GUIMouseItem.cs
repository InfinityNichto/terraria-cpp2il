using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.UI;
using UnityEngine;

// Token: 0x020000F0 RID: 240
[global::Cpp2ILInjected.Token(Token = "0x2000159")]
public class GUIMouseItem
{
	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x000234A1 File Offset: 0x000216A1
	[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
	public bool HoldingItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000974")]
		[global::Cpp2ILInjected.Address(RVA = "0x95C73C", Offset = "0x95C73C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000875 RID: 2165 RVA: 0x000234A4 File Offset: 0x000216A4
	[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
	public bool BeingDragged
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000975")]
		[global::Cpp2ILInjected.Address(RVA = "0x95C7C4", Offset = "0x95C7C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000876 RID: 2166 RVA: 0x000234A7 File Offset: 0x000216A7
	[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
	public bool IsItemDropped
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000976")]
		[global::Cpp2ILInjected.Address(RVA = "0x95C7CC", Offset = "0x95C7CC", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIDisplayDoll.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIEquipment.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "ItemOver", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			"GUIHatRack.EquipmentItemType",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITrashCan), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x000234AA File Offset: 0x000216AA
	[global::Cpp2ILInjected.Token(Token = "0x6000977")]
	[global::Cpp2ILInjected.Address(RVA = "0x95C9EC", Offset = "0x95C9EC", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "CraftButtonOver", MemberParameters = new object[] { typeof(GUITransactionButton.InputState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventorySplitStack), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "PurchasePressedAndHeld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int),
		typeof(Player)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void BeginDrag(bool dragging)
	{
		throw null;
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x000234AD File Offset: 0x000216AD
	[global::Cpp2ILInjected.Token(Token = "0x6000978")]
	[global::Cpp2ILInjected.Address(RVA = "0x95CA5C", Offset = "0x95CA5C", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void DisableDrag()
	{
		throw null;
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x000234B0 File Offset: 0x000216B0
	[global::Cpp2ILInjected.Token(Token = "0x6000979")]
	[global::Cpp2ILInjected.Address(RVA = "0x95CAC4", Offset = "0x95CAC4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIMouseItem()
	{
		throw null;
	}

	// Token: 0x040006C2 RID: 1730
	[global::Cpp2ILInjected.Token(Token = "0x4000944")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private int mouseDragStart;

	// Token: 0x040006C3 RID: 1731
	[global::Cpp2ILInjected.Token(Token = "0x4000945")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private bool mouseItemHoldDrag;

	// Token: 0x040006C4 RID: 1732
	[global::Cpp2ILInjected.Token(Token = "0x4000946")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15")]
	private bool disableDrag;

	// Token: 0x040006C5 RID: 1733
	[global::Cpp2ILInjected.Token(Token = "0x4000947")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int disableDragStart;
}
