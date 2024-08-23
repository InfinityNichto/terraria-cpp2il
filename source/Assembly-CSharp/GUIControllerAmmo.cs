using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x0200007D RID: 125
[global::Cpp2ILInjected.Token(Token = "0x20000B4")]
public class GUIControllerAmmo : GUIPageContentController
{
	// Token: 0x060003AD RID: 941 RVA: 0x0002264C File Offset: 0x0002084C
	[global::Cpp2ILInjected.Token(Token = "0x6000447")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C10", Offset = "0xA87C10", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPageRedirect), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageContentController), Member = ".ctor", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	public GUIControllerAmmo()
	{
		throw null;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x0002264F File Offset: 0x0002084F
	[global::Cpp2ILInjected.Token(Token = "0x6000448")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C1C", Offset = "0xA87C1C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Activate()
	{
		throw null;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00022652 File Offset: 0x00020852
	[global::Cpp2ILInjected.Token(Token = "0x6000449")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C20", Offset = "0xA87C20", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void NavigateFromInventoryRow(int row)
	{
		throw null;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00022655 File Offset: 0x00020855
	[global::Cpp2ILInjected.Token(Token = "0x600044A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C44", Offset = "0xA87C44", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual int GetInventoryRow()
	{
		throw null;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00022658 File Offset: 0x00020858
	[global::Cpp2ILInjected.Token(Token = "0x600044B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87C6C", Offset = "0xA87C6C", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Inventory", ReturnType = typeof(GUIControllerInventory))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "NavigateIntoRight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerItem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerPageRedirect), Member = "get_Coins", ReturnType = typeof(GUIControllerCoins))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override GUIControllerItem Navigate(Vector2 navigationVector)
	{
		throw null;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x0002265B File Offset: 0x0002085B
	[global::Cpp2ILInjected.Token(Token = "0x600044C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87DF4", Offset = "0xA87DF4", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public override Rectangle GetSelectedItemRegion()
	{
		throw null;
	}

	// Token: 0x040002C3 RID: 707
	[global::Cpp2ILInjected.Token(Token = "0x4000439")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int itemRow;

	// Token: 0x040002C4 RID: 708
	[global::Cpp2ILInjected.Token(Token = "0x400043A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int itemColmun;
}
