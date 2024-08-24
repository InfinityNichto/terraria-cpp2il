using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.BigProgressBar;

// Token: 0x0200013A RID: 314
[global::Cpp2ILInjected.Token(Token = "0x20001B9")]
public static class RightSideHUDAnchorUpdator
{
	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00023B64 File Offset: 0x00021D64
	// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00023B67 File Offset: 0x00021D67
	[global::Cpp2ILInjected.Token(Token = "0x17000140")]
	public static bool UseCollpasedCoinsAmmo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B2FC4", Offset = "0x9B2FC4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "SetupLayout", ReturnType = typeof(TransactionButton_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "FinaliseLayout", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemScale", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawInventoryResearchButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "CalculateMaterialRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
		{
			typeof(GUIPageIconGrouping),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawQuickStack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawSort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000BC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B30C8", Offset = "0x9B30C8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00023B6A File Offset: 0x00021D6A
	// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00023B6D File Offset: 0x00021D6D
	[global::Cpp2ILInjected.Token(Token = "0x17000141")]
	public static bool AllowSecondRow
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B3118", Offset = "0x9B3118", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000BC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B3164", Offset = "0x9B3164", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00023B70 File Offset: 0x00021D70
	// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00023B73 File Offset: 0x00021D73
	[global::Cpp2ILInjected.Token(Token = "0x17000142")]
	public static int AllowRowHeight
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B31B4", Offset = "0x9B31B4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000BC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B3200", Offset = "0x9B3200", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00023B76 File Offset: 0x00021D76
	// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00023B79 File Offset: 0x00021D79
	[global::Cpp2ILInjected.Token(Token = "0x17000143")]
	public static bool AllowDraw
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B3250", Offset = "0x9B3250", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawPlayerChat", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000BCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B329C", Offset = "0x9B329C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00023B7C File Offset: 0x00021D7C
	// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00023B7F File Offset: 0x00021D7F
	[global::Cpp2ILInjected.Token(Token = "0x17000144")]
	private static int currentFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000BCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B307C", Offset = "0x9B307C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000BCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B32EC", Offset = "0x9B32EC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00023B82 File Offset: 0x00021D82
	[global::Cpp2ILInjected.Token(Token = "0x6000BCE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B0D98", Offset = "0x9B0D98", Length = "0x1608")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
	{
		typeof(GUIPageIconGrouping),
		typeof(Point)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_UseCollpasedCoinsAmmo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "AnyOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_SelectedCategory", ReturnType = typeof(GUIPageIcons.Category))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_Right_Root", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_UseLargeMinimap", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "AnyPageSelected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_BigBossProgressBar", ReturnType = typeof(BigProgressBarSystem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigProgressBarSystem), Member = "IsTracking", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
	public static void Update()
	{
		throw null;
	}

	// Token: 0x04000AB8 RID: 2744
	[global::Cpp2ILInjected.Token(Token = "0x4000EA2")]
	public const int HUD_Height = 246;

	// Token: 0x04000AB9 RID: 2745
	[global::Cpp2ILInjected.Token(Token = "0x4000EA3")]
	public const int HUD_Width = 220;

	// Token: 0x04000ABA RID: 2746
	[global::Cpp2ILInjected.Token(Token = "0x4000EA4")]
	public const int HUD_Width2 = 178;
}
