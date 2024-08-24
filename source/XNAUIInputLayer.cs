using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.GameContent.Drawing;
using Terraria.GameInput;
using Terraria.UI;
using UnityEngine;

// Token: 0x020001F3 RID: 499
[global::Cpp2ILInjected.Token(Token = "0x2000297")]
public class XNAUIInputLayer
{
	// Token: 0x06000E50 RID: 3664 RVA: 0x00024635 File Offset: 0x00022835
	[global::Cpp2ILInjected.Token(Token = "0x6000F80")]
	[global::Cpp2ILInjected.Address(RVA = "0xA325B4", Offset = "0xA325B4", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer.CursorUpdater), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = "set_Priority", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public XNAUIInputLayer()
	{
		throw null;
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00024638 File Offset: 0x00022838
	[global::Cpp2ILInjected.Token(Token = "0x6000F81")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32744", Offset = "0xA32744", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(GUIPageIcons.Category)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "WindBackingHandler", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Slider_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "RainBackingHandler", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Slider_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "DifficultyBackingHandler", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Slider_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenHairWindow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenClothesWindow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
	public void CaptureUICrusorDrag(int dragFromAxis = -1)
	{
		throw null;
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x0002463B File Offset: 0x0002283B
	[global::Cpp2ILInjected.Token(Token = "0x6000F82")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3275C", Offset = "0xA3275C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void CancelUICrusorDrag()
	{
		throw null;
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x0002463E File Offset: 0x0002283E
	[global::Cpp2ILInjected.Token(Token = "0x6000F83")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32764", Offset = "0xA32764", Length = "0x1BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "SetMousePosition", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "IsOverRegion", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void UpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00024641 File Offset: 0x00022841
	[global::Cpp2ILInjected.Token(Token = "0x6000F84")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32920", Offset = "0xA32920", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "SetMousePosition", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "IsOverRegionExpanded", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void UpdateCursorSecondary(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00024644 File Offset: 0x00022844
	[global::Cpp2ILInjected.Token(Token = "0x6000F85")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32A48", Offset = "0xA32A48", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(global::Cursor))]
	public void CaptureWorldCursor()
	{
		throw null;
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00024647 File Offset: 0x00022847
	[global::Cpp2ILInjected.Token(Token = "0x6000F86")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32B78", Offset = "0xA32B78", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void WorldUpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x0002464A File Offset: 0x0002284A
	[global::Cpp2ILInjected.Token(Token = "0x6000F87")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32B7C", Offset = "0xA32B7C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "NextItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "PreviousItem", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "UpdateBuffNavigation", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "AfterItemSwap", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "UpdateTooltipButton", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "UpdateTooltipContext", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	public void ResetTimeWithoutCursor()
	{
		throw null;
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x0002464D File Offset: 0x0002284D
	[global::Cpp2ILInjected.Token(Token = "0x6000F88")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32B84", Offset = "0xA32B84", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "get_NavigationAxis", ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Update(float elapsedTime)
	{
		throw null;
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00024650 File Offset: 0x00022850
	[global::Cpp2ILInjected.Token(Token = "0x1700018B")]
	public static float UITextAlpha
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F89")]
		[global::Cpp2ILInjected.Address(RVA = "0xA32E30", Offset = "0xA32E30", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "UpdateBuffNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICrafting), Member = "UpdateMaterialNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00024653 File Offset: 0x00022853
	[global::Cpp2ILInjected.Token(Token = "0x6000F8A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32E98", Offset = "0xA32E98", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "DrawLabel", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseTextInner", MemberParameters = new object[]
	{
		typeof(Main.MouseTextCache),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip", MemberParameters = new object[]
	{
		typeof(Main.MouseTextCache),
		typeof(int),
		typeof(byte),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static float UITextAlphaCustom(float _timeForFullUIMouse, float _timeForUIMouseFade = 1f)
	{
		throw null;
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00024656 File Offset: 0x00022856
	[global::Cpp2ILInjected.Token(Token = "0x6000F8B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32D44", Offset = "0xA32D44", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "get_UICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public global::Cursor GetUICursor()
	{
		throw null;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00024659 File Offset: 0x00022859
	[global::Cpp2ILInjected.Token(Token = "0x6000F8C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA32A68", Offset = "0xA32A68", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMagnify), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "ClickedOutOfRegion", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawCursorArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "CaptureWorldCursor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "PlatformGetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_WorldMouseOver", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_6_TileGridOption", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SmartInteractLookup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "Draw", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public global::Cursor GetWorldCursor()
	{
		throw null;
	}

	// Token: 0x04001704 RID: 5892
	[global::Cpp2ILInjected.Token(Token = "0x4001C26")]
	public static XNAUIInputLayer Instance;

	// Token: 0x04001705 RID: 5893
	[global::Cpp2ILInjected.Token(Token = "0x4001C27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public CursorInputLayer _inputLayer;

	// Token: 0x04001706 RID: 5894
	[global::Cpp2ILInjected.Token(Token = "0x4001C28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public CursorInputLayer _inputLayer2;

	// Token: 0x04001707 RID: 5895
	[global::Cpp2ILInjected.Token(Token = "0x4001C29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public CursorInputLayer _worldInputLayer;

	// Token: 0x04001708 RID: 5896
	[global::Cpp2ILInjected.Token(Token = "0x4001C2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int UICrusorDraggingFromAxis;

	// Token: 0x04001709 RID: 5897
	[global::Cpp2ILInjected.Token(Token = "0x4001C2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public bool UICrusorDragging;

	// Token: 0x0400170A RID: 5898
	[global::Cpp2ILInjected.Token(Token = "0x4001C2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
	public bool HadUICursor;

	// Token: 0x0400170B RID: 5899
	[global::Cpp2ILInjected.Token(Token = "0x4001C2D")]
	private const float TimeForUIMouseFade = 1f;

	// Token: 0x0400170C RID: 5900
	[global::Cpp2ILInjected.Token(Token = "0x4001C2E")]
	private const float TimeForFullUIMouse = 1f;

	// Token: 0x0400170D RID: 5901
	[global::Cpp2ILInjected.Token(Token = "0x4001C2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float _timeWithoutUICursor;
}
