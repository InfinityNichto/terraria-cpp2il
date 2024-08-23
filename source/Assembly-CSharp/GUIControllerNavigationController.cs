using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI;
using UnityEngine;

// Token: 0x0200006C RID: 108
[global::Cpp2ILInjected.Token(Token = "0x200009C")]
public class GUIControllerNavigationController
{
	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600031A RID: 794 RVA: 0x00022493 File Offset: 0x00020693
	[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
	public global::Cursor UICursor
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C6204", Offset = "0x9C6204", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600031B RID: 795 RVA: 0x00022496 File Offset: 0x00020696
	[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C621C", Offset = "0x9C621C", Length = "0xBB0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateAxisMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(ControllerActionAxis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "MapAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float),
		typeof(ControllerActionButton.RequiredButtonState)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateVectorMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ControllerActionAxis),
		typeof(ControllerActionAxis)
	}, ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "MapButton", MemberParameters = new object[]
	{
		typeof(Buttons),
		typeof(ControllerActionButton.RequiredButtonState),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Buttons),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
	public void SetupMappings()
	{
		throw null;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00022499 File Offset: 0x00020699
	[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C6DCC", Offset = "0x9C6DCC", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600031D RID: 797 RVA: 0x0002249C File Offset: 0x0002069C
	[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
	public ControllerActionVector NavigationAxis
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C6EA4", Offset = "0x9C6EA4", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inFancyUI", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_hairWindow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_clothesWindow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "AnyPageSelected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolModeUI", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_DrawRubbleModeUI", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0002249F File Offset: 0x0002069F
	[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C70D0", Offset = "0x9C70D0", Length = "0xAA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inFancyUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_hairWindow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_clothesWindow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "AnyPageSelected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_DrawRubbleModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIReturnToTouch), Member = "get_Visible", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "get_NavigationAxis", ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Point),
		typeof(Point)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "ResetTimeWithoutCursor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustUIForRealScreen", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
	public void UpdateUINavigation(float elapsedTime)
	{
		throw null;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x000224A2 File Offset: 0x000206A2
	[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C3AF4", Offset = "0x9C3AF4", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 98)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustUIForRealScreen", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void UpdateCursorPosition()
	{
		throw null;
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000320 RID: 800 RVA: 0x000224A5 File Offset: 0x000206A5
	// (set) Token: 0x06000321 RID: 801 RVA: 0x000224A8 File Offset: 0x000206A8
	[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
	public GUIControllerItem CurrentNavigationItem
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C7B88", Offset = "0x9C7B88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9C7B74", Offset = "0x9C7B74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 140)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000322 RID: 802 RVA: 0x000224AB File Offset: 0x000206AB
	[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7B90", Offset = "0x9C7B90", Length = "0x10")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void DisableNavigationFromAxis(int fromAxis = -1)
	{
		throw null;
	}

	// Token: 0x06000323 RID: 803 RVA: 0x000224AE File Offset: 0x000206AE
	[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7BA0", Offset = "0x9C7BA0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUITransactionButton.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public bool Pressed(GUIControllerInputButton.LinkedControlType action)
	{
		throw null;
	}

	// Token: 0x06000324 RID: 804 RVA: 0x000224B1 File Offset: 0x000206B1
	[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7BB0", Offset = "0x9C7BB0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool Pressed(int action)
	{
		throw null;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x000224B4 File Offset: 0x000206B4
	[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7BC0", Offset = "0x9C7BC0", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUITransactionButton.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	public bool PressedTriggered(GUIControllerInputButton.LinkedControlType action)
	{
		throw null;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x000224B7 File Offset: 0x000206B7
	[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7C28", Offset = "0x9C7C28", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeft", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void ClearUIPressed()
	{
		throw null;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x000224BA File Offset: 0x000206BA
	[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7BF4", Offset = "0x9C7BF4", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public bool PressedTriggered(int action)
	{
		throw null;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x000224BD File Offset: 0x000206BD
	[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7D3C", Offset = "0x9C7D3C", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUITransactionButton.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "DrawPassword", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "DrawServerIP", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "DrawServerPort", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawDifficulty", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawHardware", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawName", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawSeed", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
	public bool PressedReleased(GUIControllerInputButton.LinkedControlType action)
	{
		throw null;
	}

	// Token: 0x06000329 RID: 809 RVA: 0x000224C0 File Offset: 0x000206C0
	[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7D70", Offset = "0x9C7D70", Length = "0x34")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public bool PressedReleased(int action)
	{
		throw null;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x000224C3 File Offset: 0x000206C3
	[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7DA4", Offset = "0x9C7DA4", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool NextPagePressed()
	{
		throw null;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x000224C6 File Offset: 0x000206C6
	[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7E08", Offset = "0x9C7E08", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIClothesWindow), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHairWindow), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool PreviousPagePressed()
	{
		throw null;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x000224C9 File Offset: 0x000206C9
	[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7E6C", Offset = "0x9C7E6C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool SettingsPressed()
	{
		throw null;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x000224CC File Offset: 0x000206CC
	[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9C7ED0", Offset = "0x9C7ED0", Length = "0x10DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Cursor), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public GUIControllerNavigationController()
	{
		throw null;
	}

	// Token: 0x04000260 RID: 608
	[global::Cpp2ILInjected.Token(Token = "0x4000394")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private global::Cursor EmulatedCursor;

	// Token: 0x04000261 RID: 609
	[global::Cpp2ILInjected.Token(Token = "0x4000395")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float NavigationRepeatDelay;

	// Token: 0x04000262 RID: 610
	[global::Cpp2ILInjected.Token(Token = "0x4000396")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float NavigationDelay;

	// Token: 0x04000263 RID: 611
	[global::Cpp2ILInjected.Token(Token = "0x4000397")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float NavigationDelayToUse;

	// Token: 0x04000264 RID: 612
	[global::Cpp2ILInjected.Token(Token = "0x4000398")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool InitialNavigationMovement;

	// Token: 0x04000265 RID: 613
	[global::Cpp2ILInjected.Token(Token = "0x4000399")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	public bool previousInteractionDownState;

	// Token: 0x04000266 RID: 614
	[global::Cpp2ILInjected.Token(Token = "0x400039A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private Point lastPoint;

	// Token: 0x04000267 RID: 615
	[global::Cpp2ILInjected.Token(Token = "0x400039B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool DisableNavigation;

	// Token: 0x04000268 RID: 616
	[global::Cpp2ILInjected.Token(Token = "0x400039C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int DisableNavigationAxis;

	// Token: 0x04000269 RID: 617
	[global::Cpp2ILInjected.Token(Token = "0x400039D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DateTime NavigationTick;

	// Token: 0x0400026A RID: 618
	[global::Cpp2ILInjected.Token(Token = "0x400039E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ControllerActionVector UINavigationAxis;

	// Token: 0x0400026B RID: 619
	[global::Cpp2ILInjected.Token(Token = "0x400039F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControllerActionVector UIScrollAxis;

	// Token: 0x0400026C RID: 620
	[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ControllerActionButton[] UIAction;

	// Token: 0x0400026D RID: 621
	[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ControllerActionButton NextPage;

	// Token: 0x0400026E RID: 622
	[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ControllerActionButton PreviousPage;

	// Token: 0x0400026F RID: 623
	[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ControllerActionButton PlayFile;

	// Token: 0x04000270 RID: 624
	[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ControllerActionButton DeleteFile;

	// Token: 0x04000271 RID: 625
	[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ControllerActionButton CloudFile;

	// Token: 0x04000272 RID: 626
	[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ControllerActionButton FavouriteFile;

	// Token: 0x04000273 RID: 627
	[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public ControllerActionButton NewFile;

	// Token: 0x04000274 RID: 628
	[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public ControllerActionButton CloseFileMenu;

	// Token: 0x04000275 RID: 629
	[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public ControllerActionButton Settings;

	// Token: 0x04000276 RID: 630
	[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ControllerActionButton Share;

	// Token: 0x04000277 RID: 631
	[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public ControllerActionButton CycleLeftPage;

	// Token: 0x04000278 RID: 632
	[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public ControllerActionButton CycleRightPage;

	// Token: 0x04000279 RID: 633
	[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ControllerActionButton Debug;

	// Token: 0x0400027A RID: 634
	[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public bool[] UIActionWasPressed;

	// Token: 0x0400027B RID: 635
	[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public bool[] UIActionPressed;

	// Token: 0x0400027C RID: 636
	[global::Cpp2ILInjected.Token(Token = "0x40003B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private GUIControllerItem _currentNavigationItem;

	// Token: 0x02000792 RID: 1938
	[global::Cpp2ILInjected.Token(Token = "0x200009D")]
	public enum InteractionMode
	{

	}
}
