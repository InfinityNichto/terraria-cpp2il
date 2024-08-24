using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x0200010C RID: 268
[global::Cpp2ILInjected.Token(Token = "0x200017E")]
public class GUIInputRegionManager
{
	// Token: 0x060009CD RID: 2509 RVA: 0x000238AC File Offset: 0x00021AAC
	[global::Cpp2ILInjected.Token(Token = "0x6000AD1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0FE8", Offset = "0x9A0FE8", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static GUIInputRegionManager Create()
	{
		throw null;
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060009CE RID: 2510 RVA: 0x000238AF File Offset: 0x00021AAF
	[global::Cpp2ILInjected.Token(Token = "0x17000116")]
	public Vector2 MousePosition
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A1138", Offset = "0x9A1138", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "RegisterPickingRegion", MemberParameters = new object[] { typeof(Axis_Layout) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "RegisterPickingRegion", MemberParameters = new object[]
		{
			typeof(Button_Layout),
			typeof(Texture2D)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		get
		{
			throw null;
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x000238B2 File Offset: 0x00021AB2
	[global::Cpp2ILInjected.Token(Token = "0x6000AD3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1164", Offset = "0x9A1164", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public void DisableAllPicking()
	{
		throw null;
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x000238B5 File Offset: 0x00021AB5
	[global::Cpp2ILInjected.Token(Token = "0x6000AD4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1170", Offset = "0x9A1170", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public void RenablePicking()
	{
		throw null;
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x000238B8 File Offset: 0x00021AB8
	[global::Cpp2ILInjected.Token(Token = "0x6000AD5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1178", Offset = "0x9A1178", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "UpdateCursorSecondary", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SetMousePosition(int x, int y, bool inUISpace = false)
	{
		throw null;
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x000238BB File Offset: 0x00021ABB
	[global::Cpp2ILInjected.Token(Token = "0x6000AD6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1244", Offset = "0x9A1244", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	public bool RegisterInputRegion(Rectangle rect)
	{
		throw null;
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x000238BE File Offset: 0x00021ABE
	[global::Cpp2ILInjected.Token(Token = "0x6000AD7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1558", Offset = "0x9A1558", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale)
	{
		throw null;
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x000238C1 File Offset: 0x00021AC1
	[global::Cpp2ILInjected.Token(Token = "0x6000AD8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A15AC", Offset = "0x9A15AC", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale, Vector2 padding)
	{
		throw null;
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x000238C4 File Offset: 0x00021AC4
	[global::Cpp2ILInjected.Token(Token = "0x6000AD9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A12B0", Offset = "0x9A12B0", Length = "0x2A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive), Member = "Over", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RemovePendingRegions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public bool RegisterInputRegion(int xMin, int xMax, int yMin, int yMax)
	{
		throw null;
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x000238C7 File Offset: 0x00021AC7
	[global::Cpp2ILInjected.Token(Token = "0x6000ADA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A16D8", Offset = "0x9A16D8", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawUITweaks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive), Member = "Over", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RemovePendingRegions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsOverExclusiveRegion()
	{
		throw null;
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x000238CA File Offset: 0x00021ACA
	[global::Cpp2ILInjected.Token(Token = "0x6000ADB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1608", Offset = "0x9A1608", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInputRegionManager), Member = "IsOverExclusiveRegion", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void RemovePendingRegions()
	{
		throw null;
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x000238CD File Offset: 0x00021ACD
	[global::Cpp2ILInjected.Token(Token = "0x6000ADC")]
	[global::Cpp2ILInjected.Address(RVA = "0x99D4BC", Offset = "0x99D4BC", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public GUIInputRegionExclusive RegisterPickingInterceptor(GUIInputRegionExclusive.IsOverHandler handler)
	{
		throw null;
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x000238D0 File Offset: 0x00021AD0
	[global::Cpp2ILInjected.Token(Token = "0x6000ADD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1788", Offset = "0x9A1788", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 90)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void UnregisterPickingInterceptor(GUIInputRegionExclusive region)
	{
		throw null;
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x000238D3 File Offset: 0x00021AD3
	[global::Cpp2ILInjected.Token(Token = "0x6000ADE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1858", Offset = "0x9A1858", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAxis), Member = "RegisterPickingRegion", MemberParameters = new object[] { typeof(Axis_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButton), Member = "RegisterPickingRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPanel), Member = "RegisterPickingRegion", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "DrawMenu", MemberParameters = new object[]
	{
		typeof(PopoutMenu_Layout),
		typeof(string[]),
		typeof(ref Rectangle)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISlider), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Slider_Layout),
		typeof(bool),
		typeof(ref float),
		typeof(GUISlider.DragState),
		typeof(GUISlider.DrawBackingHandler),
		typeof(bool),
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStringButton), Member = "IsOver", MemberParameters = new object[] { typeof(StringButton_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringButtonPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(string),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(ref bool),
		typeof(ref Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "GetAnchoredStringButtonPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2),
		typeof(SpriteFont),
		typeof(StringBuilder),
		typeof(float),
		typeof(LayoutCalculator.AnchorType),
		typeof(ref bool),
		typeof(ref Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	public bool RegisterInputRegion(int x, int y, Vector2 size)
	{
		throw null;
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000238D6 File Offset: 0x00021AD6
	[global::Cpp2ILInjected.Token(Token = "0x6000ADF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A188C", Offset = "0x9A188C", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsOverRegion()
	{
		throw null;
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x000238D9 File Offset: 0x00021AD9
	[global::Cpp2ILInjected.Token(Token = "0x6000AE0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1950", Offset = "0x9A1950", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "UpdateCursorSecondary", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegion), Member = "OverExpanded", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public bool IsOverRegionExpanded()
	{
		throw null;
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x000238DC File Offset: 0x00021ADC
	[global::Cpp2ILInjected.Token(Token = "0x6000AE1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1A48", Offset = "0x9A1A48", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsPositionOverUI(Vector2 uiPosition)
	{
		throw null;
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x000238DF File Offset: 0x00021ADF
	[global::Cpp2ILInjected.Token(Token = "0x6000AE2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1B40", Offset = "0x9A1B40", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x000238E2 File Offset: 0x00021AE2
	[global::Cpp2ILInjected.Token(Token = "0x6000AE3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1044", Offset = "0x9A1044", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInputRegionManager), Member = "Create", ReturnType = typeof(GUIInputRegionManager))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public GUIInputRegionManager()
	{
		throw null;
	}

	// Token: 0x04000854 RID: 2132
	[global::Cpp2ILInjected.Token(Token = "0x4000B2B")]
	public static GUIInputRegionManager Instance;

	// Token: 0x04000855 RID: 2133
	[global::Cpp2ILInjected.Token(Token = "0x4000B2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool _disableAllRegions;

	// Token: 0x04000856 RID: 2134
	[global::Cpp2ILInjected.Token(Token = "0x4000B2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int _mouseX;

	// Token: 0x04000857 RID: 2135
	[global::Cpp2ILInjected.Token(Token = "0x4000B2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int _mouseY;

	// Token: 0x04000858 RID: 2136
	[global::Cpp2ILInjected.Token(Token = "0x4000B2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private bool _checkingExclusiveRegions;

	// Token: 0x04000859 RID: 2137
	[global::Cpp2ILInjected.Token(Token = "0x4000B30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private List<GUIInputRegionExclusive> _exclusiveRegion;

	// Token: 0x0400085A RID: 2138
	[global::Cpp2ILInjected.Token(Token = "0x4000B31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private List<GUIInputRegionExclusive> _prendingExclusiveRegionRemoves;

	// Token: 0x0400085B RID: 2139
	[global::Cpp2ILInjected.Token(Token = "0x4000B32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private List<GUIInputRegion> _currentRegion;

	// Token: 0x0400085C RID: 2140
	[global::Cpp2ILInjected.Token(Token = "0x4000B33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private List<GUIInputRegion> _availableRegion;
}
