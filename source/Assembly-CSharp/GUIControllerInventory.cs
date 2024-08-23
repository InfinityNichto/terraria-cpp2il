using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;

// Token: 0x02000092 RID: 146
[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
public class GUIControllerInventory : GUIPageContentController
{
	// Token: 0x0600046C RID: 1132 RVA: 0x00022889 File Offset: 0x00020A89
	[global::Cpp2ILInjected.Token(Token = "0x6000506")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BF8C", Offset = "0xB1BF8C", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerInventory()
	{
		throw null;
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x0002288C File Offset: 0x00020A8C
	[global::Cpp2ILInjected.Token(Token = "0x6000507")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1BFB0", Offset = "0xB1BFB0", Length = "0x120")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0002288F File Offset: 0x00020A8F
	[global::Cpp2ILInjected.Token(Token = "0x6000508")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1C0D0", Offset = "0xB1C0D0", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoLeft", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Ammo", ReturnType = typeof(GUIControllerAmmo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Coins", ReturnType = typeof(GUIControllerCoins))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static GUIControllerItem NavigateIntoCoinsAmmo(int row)
	{
		throw null;
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00022892 File Offset: 0x00020A92
	[global::Cpp2ILInjected.Token(Token = "0x6000509")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1C268", Offset = "0xB1C268", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public virtual void NavigateToItem(int item)
	{
		throw null;
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000470 RID: 1136 RVA: 0x00022895 File Offset: 0x00020A95
	[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
	private static int MaxRowIndex
	{
		[global::Cpp2ILInjected.Token(Token = "0x600050A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1C34C", Offset = "0xB1C34C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_ToggleOptionsGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "get_ItemCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x00022898 File Offset: 0x00020A98
	[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
	private static int MaxColumnIndex
	{
		[global::Cpp2ILInjected.Token(Token = "0x600050B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB1C3C4", Offset = "0xB1C3C4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInventory), Member = "Navigate", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "get_ItemCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_ToggleOptionsGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0002289B File Offset: 0x00020A9B
	[global::Cpp2ILInjected.Token(Token = "0x600050C")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1C438", Offset = "0xB1C438", Length = "0x26C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory), Member = "get_MaxRowIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory), Member = "get_MaxColumnIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "get_ItemCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_ToggleOptionsGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInventory), Member = "NavigateIntoCoinsAmmo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0002289E File Offset: 0x00020A9E
	[global::Cpp2ILInjected.Token(Token = "0x600050D")]
	[global::Cpp2ILInjected.Address(RVA = "0xB1C70C", Offset = "0xB1C70C", Length = "0x44C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_ToggleOptionsGrid", ReturnType = typeof(ItemGrid_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002E6 RID: 742
	[global::Cpp2ILInjected.Token(Token = "0x4000470")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002E7 RID: 743
	[global::Cpp2ILInjected.Token(Token = "0x4000471")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColumn;

	// Token: 0x040002E8 RID: 744
	[global::Cpp2ILInjected.Token(Token = "0x4000472")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int toolRow;

	// Token: 0x040002E9 RID: 745
	[global::Cpp2ILInjected.Token(Token = "0x4000473")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int toolColumn;
}
