using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Initializers;
using Terraria.UI;
using UnityEngine;

// Token: 0x020000C0 RID: 192
[global::Cpp2ILInjected.Token(Token = "0x2000114")]
public static class GUIQuickActionButton
{
	// Token: 0x060005FF RID: 1535 RVA: 0x00022D42 File Offset: 0x00020F42
	[global::Cpp2ILInjected.Token(Token = "0x60006E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xF68620", Offset = "0xF68620", Length = "0x834")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00022D45 File Offset: 0x00020F45
	[global::Cpp2ILInjected.Token(Token = "0x60006EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xF68E54", Offset = "0xF68E54", Length = "0x6FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle),
		typeof(ref bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "CanInteract", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "AddInteractBanner", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "CanInteract", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "CanInteract", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustScreenPositionForWorld", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractShowingGenuine", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractNPC", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
	public static NPC GetMouseNPC()
	{
		throw null;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00022D48 File Offset: 0x00020F48
	[global::Cpp2ILInjected.Token(Token = "0x60006EB")]
	[global::Cpp2ILInjected.Address(RVA = "0xF69550", Offset = "0xF69550", Length = "0x478")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentred", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredCirclePickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public static void DrawAtPosition(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, GUIQuickActionButton.InteractionState state, ref float scale)
	{
		throw null;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00022D4B File Offset: 0x00020F4B
	[global::Cpp2ILInjected.Token(Token = "0x60006EC")]
	[global::Cpp2ILInjected.Address(RVA = "0xF699C8", Offset = "0xF699C8", Length = "0x6B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ControlsTouchTagHandler.ControlsTouchSnippet", Member = "Draw", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ControlsTouchTagHandler.ControlsTouchSnippet", Member = "GetSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "ClampPositionToScreen", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetControlTextureFrame", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "GetCategoryTexture", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Settings_Layout), Member = "get_Instance", ReturnType = typeof(Settings_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
	public static void GetIconFrame(QuickActionButton_Layout.QuickActionControl actionType, out Microsoft.Xna.Framework.Graphics.Texture2D iconTexture, out Rectangle frame)
	{
		throw null;
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x00022D4E File Offset: 0x00020F4E
	[global::Cpp2ILInjected.Token(Token = "0x60006ED")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6A078", Offset = "0xF6A078", Length = "0x15BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawMapControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickGrapple_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickMount_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UseQuickMineCartSnapHook", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_Cart", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHasAvailableBuff", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_SmartDigEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_AimAndUseEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "GetCategoryTexture", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "SmartItem", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Settings_Layout), Member = "get_Instance", ReturnType = typeof(Settings_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickHeal_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickMana_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UseQuickMineCartHook", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_Enabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle),
		typeof(ref bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_ToolMode", ReturnType = typeof(WiresUI.Settings.MultiToolMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
	{
		typeof(ref Microsoft.Xna.Framework.Graphics.Color),
		typeof(ref float),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 96)]
	public static void Draw(QuickActionButton_Layout.QuickActionControl actionType, QuickActionButton_Layout layout, bool pressed, ref float scale)
	{
		throw null;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00022D51 File Offset: 0x00020F51
	[global::Cpp2ILInjected.Token(Token = "0x60006EE")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D13C", Offset = "0xF6D13C", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void DrawFrame(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, Rectangle srcRect, GUIQuickActionButton.InteractionState state, ref float scale)
	{
		throw null;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00022D54 File Offset: 0x00020F54
	[global::Cpp2ILInjected.Token(Token = "0x60006EF")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6CB08", Offset = "0xF6CB08", Length = "0x634")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentred", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredCirclePickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public static void DrawFrame(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, Rectangle srcRect, GUIQuickActionButton.InteractionState state, ref float scale, int itemType, Microsoft.Xna.Framework.Graphics.Color itemColour)
	{
		throw null;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00022D57 File Offset: 0x00020F57
	[global::Cpp2ILInjected.Token(Token = "0x60006F0")]
	[global::Cpp2ILInjected.Address(RVA = "0xF67B00", Offset = "0xF67B00", Length = "0x560")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "Draw", MemberParameters = new object[]
	{
		typeof(PopoutMenu_Layout),
		typeof(string[]),
		typeof(ref bool),
		typeof(ref float),
		typeof(ref Rectangle)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawSlotsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentred", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredCirclePickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "DrawCentredPickingRegion", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public static void Draw(QuickActionButton_Layout layout, Microsoft.Xna.Framework.Graphics.Texture2D buttonTexture, GUIQuickActionButton.InteractionState state, ref float scale)
	{
		throw null;
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00022D5A File Offset: 0x00020F5A
	[global::Cpp2ILInjected.Token(Token = "0x60006F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6B668", Offset = "0xF6B668", Length = "0x13F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "GetMouseNPC", ReturnType = typeof(NPC))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsRightClickItemActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEWeaponsRack), Member = "Find", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_signHover", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "CanSwitchTrack", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TEItemFrame), Member = "Find", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref ITownNPCProfile)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TypeToDefaultHeadIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetAlpha", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "GetColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "GetItemLight", MemberParameters = new object[]
	{
		typeof(ref Microsoft.Xna.Framework.Graphics.Color),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_ToolMode", ReturnType = typeof(WiresUI.Settings.MultiToolMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetItemCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(VirtualControllerInputState.Category))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 90)]
	private static bool CanInteract(Player player, Item item, ref Microsoft.Xna.Framework.Graphics.Texture2D iconTexture, ref Rectangle frame, ref bool useFrame)
	{
		throw null;
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00022D5D File Offset: 0x00020F5D
	[global::Cpp2ILInjected.Token(Token = "0x60006F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6CA5C", Offset = "0xF6CA5C", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static bool CanFire(Player player, Item selectedItem)
	{
		throw null;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00022D60 File Offset: 0x00020F60
	[global::Cpp2ILInjected.Token(Token = "0x60006F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6CA78", Offset = "0xF6CA78", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public static bool CanHeal(Player player, Item bestHealItem)
	{
		throw null;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00022D63 File Offset: 0x00020F63
	[global::Cpp2ILInjected.Token(Token = "0x60006F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6CAA4", Offset = "0xF6CAA4", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public static bool CanMana(Player player, Item bestManaItem)
	{
		throw null;
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00022D66 File Offset: 0x00020F66
	[global::Cpp2ILInjected.Token(Token = "0x60006F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6B640", Offset = "0xF6B640", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetHasAvailableBuff", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(bool))]
	public static bool CanBuff(Player player)
	{
		throw null;
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00022D69 File Offset: 0x00020F69
	[global::Cpp2ILInjected.Token(Token = "0x60006F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6CAE0", Offset = "0xF6CAE0", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mount), Member = "get_Cart", ReturnType = typeof(bool))]
	public static bool CanMount(Player player, Item quickMountItem)
	{
		throw null;
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00022D6C File Offset: 0x00020F6C
	[global::Cpp2ILInjected.Token(Token = "0x60006F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D218", Offset = "0xF6D218", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public static bool IsMounted(Player player)
	{
		throw null;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x00022D6F File Offset: 0x00020F6F
	[global::Cpp2ILInjected.Token(Token = "0x60006F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6B634", Offset = "0xF6B634", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static bool CanGrappleSelect(Player player, Item grappleItem)
	{
		throw null;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00022D72 File Offset: 0x00020F72
	[global::Cpp2ILInjected.Token(Token = "0x60006F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D238", Offset = "0xF6D238", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "IsCursorOverExpanded", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static bool IsCursorOverExpanded(Microsoft.Xna.Framework.Vector2 position, QuickActionButton_Layout layout, ref float expanded)
	{
		throw null;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x00022D75 File Offset: 0x00020F75
	[global::Cpp2ILInjected.Token(Token = "0x60006FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D2D0", Offset = "0xF6D2D0", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetSlotOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static bool IsCursorOver(Microsoft.Xna.Framework.Vector2 position, QuickActionButton_Layout layout)
	{
		throw null;
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x00022D78 File Offset: 0x00020F78
	[global::Cpp2ILInjected.Token(Token = "0x60006FB")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D358", Offset = "0xF6D358", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "IsCursorOverAtPosition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static bool IsCursorOverAtPosition(Microsoft.Xna.Framework.Vector2 position, QuickActionButton_Layout layout, Microsoft.Xna.Framework.Vector2 controlPosition)
	{
		throw null;
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00022D7B File Offset: 0x00020F7B
	[global::Cpp2ILInjected.Token(Token = "0x60006FC")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D3F8", Offset = "0xF6D3F8", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawSlotsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "RegisterPickingRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static bool RegisterPickingRegion(QuickActionButton_Layout layout)
	{
		throw null;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00022D7E File Offset: 0x00020F7E
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60006FD")]
	[global::Cpp2ILInjected.Address(RVA = "0xF6D468", Offset = "0xF6D468", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static GUIQuickActionButton()
	{
		throw null;
	}

	// Token: 0x04000384 RID: 900
	[global::Cpp2ILInjected.Token(Token = "0x400056A")]
	public static bool ForceOverrideState;

	// Token: 0x04000385 RID: 901
	[global::Cpp2ILInjected.Token(Token = "0x400056B")]
	public static GUIQuickActionButton.InteractionState ForcedState;

	// Token: 0x04000386 RID: 902
	[global::Cpp2ILInjected.Token(Token = "0x400056C")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _smallAxisOuter;

	// Token: 0x04000387 RID: 903
	[global::Cpp2ILInjected.Token(Token = "0x400056D")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _axisInner;

	// Token: 0x04000388 RID: 904
	[global::Cpp2ILInjected.Token(Token = "0x400056E")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _jump;

	// Token: 0x04000389 RID: 905
	[global::Cpp2ILInjected.Token(Token = "0x400056F")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _grappleAxis;

	// Token: 0x0400038A RID: 906
	[global::Cpp2ILInjected.Token(Token = "0x4000570")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _grappleFire;

	// Token: 0x0400038B RID: 907
	[global::Cpp2ILInjected.Token(Token = "0x4000571")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _unbound;

	// Token: 0x0400038C RID: 908
	[global::Cpp2ILInjected.Token(Token = "0x4000572")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _zoomIn;

	// Token: 0x0400038D RID: 909
	[global::Cpp2ILInjected.Token(Token = "0x4000573")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _zoomOut;

	// Token: 0x0400038E RID: 910
	[global::Cpp2ILInjected.Token(Token = "0x4000574")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _zoomDefault;

	// Token: 0x0400038F RID: 911
	[global::Cpp2ILInjected.Token(Token = "0x4000575")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapZoomIn;

	// Token: 0x04000390 RID: 912
	[global::Cpp2ILInjected.Token(Token = "0x4000576")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapZoomOut;

	// Token: 0x04000391 RID: 913
	[global::Cpp2ILInjected.Token(Token = "0x4000577")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapZoomDefault;

	// Token: 0x04000392 RID: 914
	[global::Cpp2ILInjected.Token(Token = "0x4000578")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _minimapZoomIn;

	// Token: 0x04000393 RID: 915
	[global::Cpp2ILInjected.Token(Token = "0x4000579")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _minimapZoomOut;

	// Token: 0x04000394 RID: 916
	[global::Cpp2ILInjected.Token(Token = "0x400057A")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _minimapZoomDefault;

	// Token: 0x04000395 RID: 917
	[global::Cpp2ILInjected.Token(Token = "0x400057B")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _smartCursorOn;

	// Token: 0x04000396 RID: 918
	[global::Cpp2ILInjected.Token(Token = "0x400057C")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _smartCursorOff;

	// Token: 0x04000397 RID: 919
	[global::Cpp2ILInjected.Token(Token = "0x400057D")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _autoFireOn;

	// Token: 0x04000398 RID: 920
	[global::Cpp2ILInjected.Token(Token = "0x400057E")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _autoFireOff;

	// Token: 0x04000399 RID: 921
	[global::Cpp2ILInjected.Token(Token = "0x400057F")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _autoSelect;

	// Token: 0x0400039A RID: 922
	[global::Cpp2ILInjected.Token(Token = "0x4000580")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _interact;

	// Token: 0x0400039B RID: 923
	[global::Cpp2ILInjected.Token(Token = "0x4000581")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _fire;

	// Token: 0x0400039C RID: 924
	[global::Cpp2ILInjected.Token(Token = "0x4000582")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _map;

	// Token: 0x0400039D RID: 925
	[global::Cpp2ILInjected.Token(Token = "0x4000583")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _mapOpen;

	// Token: 0x0400039E RID: 926
	[global::Cpp2ILInjected.Token(Token = "0x4000584")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _combatTargetLockOn;

	// Token: 0x0400039F RID: 927
	[global::Cpp2ILInjected.Token(Token = "0x4000585")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _combatTargetIndicator;

	// Token: 0x040003A0 RID: 928
	[global::Cpp2ILInjected.Token(Token = "0x4000586")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _inventory;

	// Token: 0x040003A1 RID: 929
	[global::Cpp2ILInjected.Token(Token = "0x4000587")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _inventoryOpen;

	// Token: 0x040003A2 RID: 930
	[global::Cpp2ILInjected.Token(Token = "0x4000588")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _controlsProfile;

	// Token: 0x040003A3 RID: 931
	[global::Cpp2ILInjected.Token(Token = "0x4000589")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D[] _uncollecedHeads;

	// Token: 0x020007B6 RID: 1974
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	public enum InteractionState
	{
		// Token: 0x040079CC RID: 31180
		[global::Cpp2ILInjected.Token(Token = "0x400058B")]
		Disabled,
		// Token: 0x040079CD RID: 31181
		[global::Cpp2ILInjected.Token(Token = "0x400058C")]
		Pressed,
		// Token: 0x040079CE RID: 31182
		[global::Cpp2ILInjected.Token(Token = "0x400058D")]
		Normal
	}
}
