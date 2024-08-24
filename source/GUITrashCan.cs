using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.UI;

// Token: 0x02000105 RID: 261
[global::Cpp2ILInjected.Token(Token = "0x2000174")]
public class GUITrashCan
{
	// Token: 0x0600098B RID: 2443 RVA: 0x000237E6 File Offset: 0x000219E6
	[global::Cpp2ILInjected.Token(Token = "0x6000A8B")]
	[global::Cpp2ILInjected.Address(RVA = "0x99CA1C", Offset = "0x99CA1C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ItemScale(int index)
	{
		throw null;
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x000237E9 File Offset: 0x000219E9
	[global::Cpp2ILInjected.Token(Token = "0x6000A8C")]
	[global::Cpp2ILInjected.Address(RVA = "0x99CA64", Offset = "0x99CA64", Length = "0x2A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_HoldingItem", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMouseItem), Member = "get_IsItemDropped", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "WasSplit", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIChestSplitStack), Member = "WasSplit", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(ref Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "MouseHover", MemberParameters = new object[]
	{
		typeof(ref Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void ItemOver(int index)
	{
		throw null;
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x000237EC File Offset: 0x000219EC
	[global::Cpp2ILInjected.Token(Token = "0x6000A8D")]
	[global::Cpp2ILInjected.Address(RVA = "0x99CD0C", Offset = "0x99CD0C", Length = "0x280")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventory), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "SetSelectHighlight", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ref Item),
		typeof(int),
		typeof(Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void ItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x000237EF File Offset: 0x000219EF
	[global::Cpp2ILInjected.Token(Token = "0x6000A8E")]
	[global::Cpp2ILInjected.Address(RVA = "0x99CF8C", Offset = "0x99CF8C", Length = "0x2E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawInventoryPage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
	{
		typeof(ref Item),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x000237F2 File Offset: 0x000219F2
	[global::Cpp2ILInjected.Token(Token = "0x6000A8F")]
	[global::Cpp2ILInjected.Address(RVA = "0x99D274", Offset = "0x99D274", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUITrashCan()
	{
		throw null;
	}

	// Token: 0x040007C5 RID: 1989
	[global::Cpp2ILInjected.Token(Token = "0x4000A78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool itemDragStart;

	// Token: 0x040007C6 RID: 1990
	[global::Cpp2ILInjected.Token(Token = "0x4000A79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	private bool overTrashCan;

	// Token: 0x040007C7 RID: 1991
	[global::Cpp2ILInjected.Token(Token = "0x4000A7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
	private bool cursorOverTrashCan;
}
