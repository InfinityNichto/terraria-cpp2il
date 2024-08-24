using System;
using System.Collections.Generic;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.Golf;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Initializers;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000106 RID: 262
[global::Cpp2ILInjected.Token(Token = "0x2000175")]
public class GUIVirtualInputController
{
	// Token: 0x06000990 RID: 2448 RVA: 0x000237F5 File Offset: 0x000219F5
	[global::Cpp2ILInjected.Token(Token = "0x6000A90")]
	[global::Cpp2ILInjected.Address(RVA = "0x98B704", Offset = "0x98B704", Length = "0x1FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer.CursorUpdater), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = "set_Priority", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public GUIVirtualInputController()
	{
		throw null;
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x000237F8 File Offset: 0x000219F8
	[global::Cpp2ILInjected.Token(Token = "0x6000A91")]
	[global::Cpp2ILInjected.Address(RVA = "0x98B900", Offset = "0x98B900", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06000992 RID: 2450 RVA: 0x000237FB File Offset: 0x000219FB
	[global::Cpp2ILInjected.Token(Token = "0x17000112")]
	private bool HasGrapple
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x98BA0C", Offset = "0x98BA0C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickGrapple_GetItemToUse", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000993 RID: 2451 RVA: 0x000237FE File Offset: 0x000219FE
	[global::Cpp2ILInjected.Token(Token = "0x17000113")]
	public bool JumpTapPressed
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x98BA84", Offset = "0x98BA84", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000994 RID: 2452 RVA: 0x00023801 File Offset: 0x00021A01
	[global::Cpp2ILInjected.Token(Token = "0x17000114")]
	public bool WasJumpTapPressed
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x98BA9C", Offset = "0x98BA9C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00023804 File Offset: 0x00021A04
	[global::Cpp2ILInjected.Token(Token = "0x6000A95")]
	[global::Cpp2ILInjected.Address(RVA = "0x98BB40", Offset = "0x98BB40", Length = "0x324")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SafeNormalize", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Dot", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void UpdateMovementAxis(Microsoft.Xna.Framework.Vector2 rawAxis)
	{
		throw null;
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00023807 File Offset: 0x00021A07
	[global::Cpp2ILInjected.Token(Token = "0x6000A96")]
	[global::Cpp2ILInjected.Address(RVA = "0x98BE64", Offset = "0x98BE64", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_AimAndUseEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void UpdateFireAxis(Microsoft.Xna.Framework.Vector2 rawAxis)
	{
		throw null;
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0002380A File Offset: 0x00021A0A
	[global::Cpp2ILInjected.Token(Token = "0x6000A97")]
	[global::Cpp2ILInjected.Address(RVA = "0x98BF50", Offset = "0x98BF50", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void HideNotifications()
	{
		throw null;
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0002380D File Offset: 0x00021A0D
	[global::Cpp2ILInjected.Token(Token = "0x6000A98")]
	[global::Cpp2ILInjected.Address(RVA = "0x98BF68", Offset = "0x98BF68", Length = "0xA00")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "GetMouseNPC", ReturnType = typeof(NPC))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsRightClickItemActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractShowingGenuine", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "AnyPageSelected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_lastSignHover", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "CanSwitchTrack", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "get_HasFocus", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Tile),
		typeof(Tile)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
	private void AddInteractBanner(Player player, Item item)
	{
		throw null;
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00023810 File Offset: 0x00021A10
	[global::Cpp2ILInjected.Token(Token = "0x6000A99")]
	[global::Cpp2ILInjected.Address(RVA = "0x98C968", Offset = "0x98C968", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void ResetSMCurosrNotification()
	{
		throw null;
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00023813 File Offset: 0x00021A13
	[global::Cpp2ILInjected.Token(Token = "0x6000A9A")]
	[global::Cpp2ILInjected.Address(RVA = "0x98C988", Offset = "0x98C988", Length = "0x454")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "GetMouseNPC", ReturnType = typeof(NPC))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsRightClickItemActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WiresUI.Settings), Member = "get_DrawToolModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "get_DrawRubbleModeUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartInteractShowingGenuine", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_signHover", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Minecart), Member = "CanSwitchTrack", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private static bool CanInteract(Player player, Item item)
	{
		throw null;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00023816 File Offset: 0x00021A16
	[global::Cpp2ILInjected.Token(Token = "0x6000A9B")]
	[global::Cpp2ILInjected.Address(RVA = "0x98CDDC", Offset = "0x98CDDC", Length = "0x2C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "PlayerMenuDisplayToggle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "PlayerMenuDisplayToggle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public Microsoft.Xna.Framework.Vector2 GetPressedControlPosition(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, out VirtualControlsHardwareConfigurationMapping_Layout slotConfiguration)
	{
		throw null;
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00023819 File Offset: 0x00021A19
	[global::Cpp2ILInjected.Token(Token = "0x6000A9C")]
	[global::Cpp2ILInjected.Address(RVA = "0x98D0A4", Offset = "0x98D0A4", Length = "0x4FA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "UpdateState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "SetRMBOverride", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(ButtonState)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "SetVirtualCursorOverride", MemberParameters = new object[]
	{
		typeof(Mouse.OverrideState),
		typeof(ButtonState),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_AimedTarget", ReturnType = typeof(NPC))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsCursorOverExpanded", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(QuickActionButton_Layout),
		typeof(ref float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_AimAndUseEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "set_AimAndUseEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "UpdateMovementAxis", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cSmartCursorModeIsToggleAndNotHold", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_SmartDigEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "UpdateFireAxis", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsRightClickItemActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIProfileSwitch), Member = "CycleNextProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "set_SmartDigEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(QuickActionButton_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "set_KeyboardEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "get_InGameUIOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "AnyPageSelected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = "Evaluate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Normalize", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickGrapple_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "Conflicts", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "CanInteract", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileTargetY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "AddInteractBanner", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickHeal_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "CanHeal", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickMana_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "CanMana", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickMount_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "CanMount", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsMounted", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "CanBuff", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MinPixelScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SettingsSavePending", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "get_HasGrapple", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_LastActiveLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalGolfState", ReturnType = typeof(GolfState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "CancelBallTracking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "UpdatePinchZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 197)]
	public void Update(float elapsedTime)
	{
		throw null;
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x0002381C File Offset: 0x00021A1C
	[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
	[global::Cpp2ILInjected.Address(RVA = "0x993ED8", Offset = "0x993ED8", Length = "0x468")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenYOffset", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void HandleCursorGridSnap(bool tileBoostWholeScreen, int screenCenterX, int screenCenterY, int tB, ref float MouseX, ref float MouseY)
	{
		throw null;
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x0002381F File Offset: 0x00021A1F
	[global::Cpp2ILInjected.Token(Token = "0x6000A9E")]
	[global::Cpp2ILInjected.Address(RVA = "0x994340", Offset = "0x994340", Length = "0x8A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenYOffset", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void HandleGridSnapCursorMovement(Item selectedItem, int screenCenterX, int screenCenterY, int tB, ref float MouseX, ref float MouseY)
	{
		throw null;
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00023822 File Offset: 0x00021A22
	[global::Cpp2ILInjected.Token(Token = "0x6000A9F")]
	[global::Cpp2ILInjected.Address(RVA = "0x994BE8", Offset = "0x994BE8", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	private Microsoft.Xna.Framework.Vector2 FilterFireAxis(Microsoft.Xna.Framework.Vector2 fireAxis)
	{
		throw null;
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00023825 File Offset: 0x00021A25
	[global::Cpp2ILInjected.Token(Token = "0x6000AA0")]
	[global::Cpp2ILInjected.Address(RVA = "0x992128", Offset = "0x992128", Length = "0x1DB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GamepadCursorAlpha", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_SmartDigEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_GamepadCursorAlpha", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "IsPlayerHoldingClub", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenYOffset", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReverseGravitySupport", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Point))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "HandleCursorGridSnap", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(ref float),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "FilterFireAxis", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "ScaleScreenDirectionForWorld", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustWorldForRealScreen", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "SetVirtualCursorOverride", MemberParameters = new object[]
	{
		typeof(Mouse.OverrideState),
		typeof(ButtonState),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "HandleGridSnapCursorMovement", MemberParameters = new object[]
	{
		typeof(Item),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(ref float),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 103)]
	private void UpdateCursorMovement()
	{
		throw null;
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00023828 File Offset: 0x00021A28
	[global::Cpp2ILInjected.Token(Token = "0x17000115")]
	public bool InGameUIOpen
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x992044", Offset = "0x992044", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ingameOptionsWindow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inFancyUI", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_menuMode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x0002382B File Offset: 0x00021A2B
	[global::Cpp2ILInjected.Token(Token = "0x6000AA2")]
	[global::Cpp2ILInjected.Address(RVA = "0x994C44", Offset = "0x994C44", Length = "0xD04")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsCursorOverExpanded", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(QuickActionButton_Layout),
		typeof(ref float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editChest", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIProfileSwitch), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_clothesWindow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClothesWindow), Member = "IsOverPanel", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_hairWindow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHairWindow), Member = "IsOverPanel", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearch), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPVPIcons), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWiresUI), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "AnyOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
	{
		typeof(GUIPageIconGrouping),
		typeof(Point)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuffs), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHotbar), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_AllowDraw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_DisplayMinimap", ReturnType = typeof(Panel_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMiniMapToggle", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMap", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_MiniChatInstance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "get_InGameUIOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "IsCursorOverExpanded", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
	public void SecondaryUpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x0002382E File Offset: 0x00021A2E
	[global::Cpp2ILInjected.Token(Token = "0x6000AA3")]
	[global::Cpp2ILInjected.Address(RVA = "0x995948", Offset = "0x995948", Length = "0xBB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_SelectedCategory", ReturnType = typeof(GUIPageIcons.Category))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "LoadPageAnchor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = "get_Instance", ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetPickRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "GetCategoryGrouping", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(GUIPageIconGrouping))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICrafting), Member = "get_Collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_UseCollpasedCoinsAmmo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Research_Layout), Member = "get_Instance", ReturnType = typeof(Research_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAmmo), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICoins), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BuilderAccToggles_Layout), Member = "get_Instance", ReturnType = typeof(BuilderAccToggles_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEquipment), Member = "get_collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_DisplaySetBonus", ReturnType = typeof(Button_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Equipment_Layout), Member = "get_InfoToggleCollapsed", ReturnType = typeof(TransactionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemDuplication), Member = "get_Collapsed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "SetupLayout", ReturnType = typeof(TransactionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuilderAccToggles), Member = "FinaliseLayout", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	private bool IsOverGroupRegion(GUIPageIconGrouping group, Point mousePoint)
	{
		throw null;
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00023831 File Offset: 0x00021A31
	[global::Cpp2ILInjected.Token(Token = "0x6000AA4")]
	[global::Cpp2ILInjected.Address(RVA = "0x996500", Offset = "0x996500", Length = "0xC3C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(QuickActionButton_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editChest", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIProfileSwitch), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_clothesWindow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClothesWindow), Member = "IsOverPanel", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_hairWindow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHairWindow), Member = "IsOverPanel", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearch), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPVPIcons), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUICraftGuidePopup), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWiresUI), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIRubbleMaker), Member = "IsOver", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "AnyOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
	{
		typeof(GUIPageIconGrouping),
		typeof(Point)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBuffs), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHotbar), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RightSideHUDAnchorUpdator), Member = "get_AllowDraw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_DisplayMinimap", ReturnType = typeof(Panel_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMiniMapToggle", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMap", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiplayerChat_Layout), Member = "get_MiniChatInstance", ReturnType = typeof(MultiplayerChat_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "get_InGameUIOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
	public void UpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00023834 File Offset: 0x00021A34
	[global::Cpp2ILInjected.Token(Token = "0x6000AA5")]
	[global::Cpp2ILInjected.Address(RVA = "0x99713C", Offset = "0x99713C", Length = "0x4B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawVirtualControls", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMagnify), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIZoom), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "DrawMapControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "get_InGameUIOpen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "DrawControlStringNotifications", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIProfileSwitch), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampControls", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFadeString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(FadeString_Layout),
		typeof(StringBuilder),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00023837 File Offset: 0x00021A37
	[global::Cpp2ILInjected.Token(Token = "0x6000AA6")]
	[global::Cpp2ILInjected.Address(RVA = "0x998778", Offset = "0x998778", Length = "0x3F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_AimAndUseEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFadeString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(FadeString_Layout),
		typeof(string),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_SmartDigEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_LockOnAvailable", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_Enabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "GetDisplayName", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private void DrawControlStringNotifications()
	{
		throw null;
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x0002383A File Offset: 0x00021A3A
	[global::Cpp2ILInjected.Token(Token = "0x6000AA7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9975EC", Offset = "0x9975EC", Length = "0x118C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "get_HasGrapple", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickGrapple_GetItemToUse", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetButtonRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref ITownNPCProfile)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TypeToDefaultHeadIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_AimAndUseEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
	private void DrawControls()
	{
		throw null;
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0002383D File Offset: 0x00021A3D
	[global::Cpp2ILInjected.Token(Token = "0x6000AA8")]
	[global::Cpp2ILInjected.Address(RVA = "0x998B6C", Offset = "0x998B6C", Length = "0x1D4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void DrawMapControls()
	{
		throw null;
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00023840 File Offset: 0x00021A40
	[global::Cpp2ILInjected.Token(Token = "0x6000AA9")]
	[global::Cpp2ILInjected.Address(RVA = "0x998D40", Offset = "0x998D40", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Show()
	{
		throw null;
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00023843 File Offset: 0x00021A43
	[global::Cpp2ILInjected.Token(Token = "0x6000AAA")]
	[global::Cpp2ILInjected.Address(RVA = "0x998D4C", Offset = "0x998D4C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "UpdateUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public void Hide()
	{
		throw null;
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00023846 File Offset: 0x00021A46
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000AAB")]
	[global::Cpp2ILInjected.Address(RVA = "0x998D54", Offset = "0x998D54", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static GUIVirtualInputController()
	{
		throw null;
	}

	// Token: 0x040007C8 RID: 1992
	[global::Cpp2ILInjected.Token(Token = "0x4000A7B")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _directionArrow;

	// Token: 0x040007C9 RID: 1993
	[global::Cpp2ILInjected.Token(Token = "0x4000A7C")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _jump;

	// Token: 0x040007CA RID: 1994
	[global::Cpp2ILInjected.Token(Token = "0x4000A7D")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _movement;

	// Token: 0x040007CB RID: 1995
	[global::Cpp2ILInjected.Token(Token = "0x4000A7E")]
	public static Microsoft.Xna.Framework.Graphics.Texture2D _autoFireOff;

	// Token: 0x040007CC RID: 1996
	[global::Cpp2ILInjected.Token(Token = "0x4000A7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool ControllerActive;

	// Token: 0x040007CD RID: 1997
	[global::Cpp2ILInjected.Token(Token = "0x4000A80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool AutoControlEnabled;

	// Token: 0x040007CE RID: 1998
	[global::Cpp2ILInjected.Token(Token = "0x4000A81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public float AutoControlTimer;

	// Token: 0x040007CF RID: 1999
	[global::Cpp2ILInjected.Token(Token = "0x4000A82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool AutoSelectToggleTouch;

	// Token: 0x040007D0 RID: 2000
	[global::Cpp2ILInjected.Token(Token = "0x4000A83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
	public bool AutoSelectToggleTouchValue;

	// Token: 0x040007D1 RID: 2001
	[global::Cpp2ILInjected.Token(Token = "0x4000A84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
	public bool AutoSelectToggleController;

	// Token: 0x040007D2 RID: 2002
	[global::Cpp2ILInjected.Token(Token = "0x4000A85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
	public bool AutoSelectToggleControllerValue;

	// Token: 0x040007D3 RID: 2003
	[global::Cpp2ILInjected.Token(Token = "0x4000A86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public bool AutoSelectToggleKeyboard;

	// Token: 0x040007D4 RID: 2004
	[global::Cpp2ILInjected.Token(Token = "0x4000A87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
	public bool AutoSelectToggleKeyboardValue;

	// Token: 0x040007D5 RID: 2005
	[global::Cpp2ILInjected.Token(Token = "0x4000A88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
	public bool EnableBuildGridSnap;

	// Token: 0x040007D6 RID: 2006
	[global::Cpp2ILInjected.Token(Token = "0x4000A89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F")]
	public bool AimModeFreeMovement;

	// Token: 0x040007D7 RID: 2007
	[global::Cpp2ILInjected.Token(Token = "0x4000A8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool UseButtonPressed;

	// Token: 0x040007D8 RID: 2008
	[global::Cpp2ILInjected.Token(Token = "0x4000A8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	public bool StashCraftedItems;

	// Token: 0x040007D9 RID: 2009
	[global::Cpp2ILInjected.Token(Token = "0x4000A8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private CursorInputLayer _inputLayer;

	// Token: 0x040007DA RID: 2010
	[global::Cpp2ILInjected.Token(Token = "0x4000A8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private CursorInputLayer _inputLayer2;

	// Token: 0x040007DB RID: 2011
	[global::Cpp2ILInjected.Token(Token = "0x4000A8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public VirtualInputController_Layout.ContolType[] Controls;

	// Token: 0x040007DC RID: 2012
	[global::Cpp2ILInjected.Token(Token = "0x4000A8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float VirtualControlScale;

	// Token: 0x040007DD RID: 2013
	[global::Cpp2ILInjected.Token(Token = "0x4000A90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public GUIVirtualInputController.LeftStickJumpMode JumpMode;

	// Token: 0x040007DE RID: 2014
	[global::Cpp2ILInjected.Token(Token = "0x4000A91")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private int previousMovementLastFrame;

	// Token: 0x040007DF RID: 2015
	[global::Cpp2ILInjected.Token(Token = "0x4000A92")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private Microsoft.Xna.Framework.Vector2 lastFireAxisRaw;

	// Token: 0x040007E0 RID: 2016
	[global::Cpp2ILInjected.Token(Token = "0x4000A93")]
	private const float numSteps = 1000f;

	// Token: 0x040007E1 RID: 2017
	[global::Cpp2ILInjected.Token(Token = "0x4000A94")]
	private static Item emptyItem;

	// Token: 0x040007E2 RID: 2018
	[global::Cpp2ILInjected.Token(Token = "0x4000A95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private bool pulseLeft;

	// Token: 0x040007E3 RID: 2019
	[global::Cpp2ILInjected.Token(Token = "0x4000A96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private int pulseLeftTime;

	// Token: 0x040007E4 RID: 2020
	[global::Cpp2ILInjected.Token(Token = "0x4000A97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private bool pulseRight;

	// Token: 0x040007E5 RID: 2021
	[global::Cpp2ILInjected.Token(Token = "0x4000A98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private int pulseRightTime;

	// Token: 0x040007E6 RID: 2022
	[global::Cpp2ILInjected.Token(Token = "0x4000A99")]
	private static int pulseTimer;

	// Token: 0x040007E7 RID: 2023
	[global::Cpp2ILInjected.Token(Token = "0x4000A9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float cursorUpdateTime;

	// Token: 0x040007E8 RID: 2024
	[global::Cpp2ILInjected.Token(Token = "0x4000A9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float LastOffsetX;

	// Token: 0x040007E9 RID: 2025
	[global::Cpp2ILInjected.Token(Token = "0x4000A9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float LastOffsetY;

	// Token: 0x040007EA RID: 2026
	[global::Cpp2ILInjected.Token(Token = "0x4000A9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private int LastFrameUpdate;

	// Token: 0x040007EB RID: 2027
	[global::Cpp2ILInjected.Token(Token = "0x4000A9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private int LastSizeX;

	// Token: 0x040007EC RID: 2028
	[global::Cpp2ILInjected.Token(Token = "0x4000A9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private int LastSizeY;

	// Token: 0x040007ED RID: 2029
	[global::Cpp2ILInjected.Token(Token = "0x4000AA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float AimScale;

	// Token: 0x040007EE RID: 2030
	[global::Cpp2ILInjected.Token(Token = "0x4000AA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float AimAxisActiveTime;

	// Token: 0x040007EF RID: 2031
	[global::Cpp2ILInjected.Token(Token = "0x4000AA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private float AimAxisStartX;

	// Token: 0x040007F0 RID: 2032
	[global::Cpp2ILInjected.Token(Token = "0x4000AA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private float AimAxisStartY;

	// Token: 0x040007F1 RID: 2033
	[global::Cpp2ILInjected.Token(Token = "0x4000AA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private float AimAxisTotalX;

	// Token: 0x040007F2 RID: 2034
	[global::Cpp2ILInjected.Token(Token = "0x4000AA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private float AimAxisTotalY;

	// Token: 0x040007F3 RID: 2035
	[global::Cpp2ILInjected.Token(Token = "0x4000AA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private bool AimAxisSnapStarted;

	// Token: 0x040007F4 RID: 2036
	[global::Cpp2ILInjected.Token(Token = "0x4000AA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x95")]
	public bool LeftStickAiming;

	// Token: 0x040007F5 RID: 2037
	[global::Cpp2ILInjected.Token(Token = "0x4000AA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float ControllerAimSensitivity;

	// Token: 0x040007F6 RID: 2038
	[global::Cpp2ILInjected.Token(Token = "0x4000AA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public float TouchAimSensitivity;

	// Token: 0x040007F7 RID: 2039
	[global::Cpp2ILInjected.Token(Token = "0x4000AAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private int InitialAimNavTick;

	// Token: 0x040007F8 RID: 2040
	[global::Cpp2ILInjected.Token(Token = "0x4000AAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public DateTime LastAimNavTickTime;

	// Token: 0x040007F9 RID: 2041
	[global::Cpp2ILInjected.Token(Token = "0x4000AAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private Microsoft.Xna.Framework.Vector2 LastAimNavTickPosition;

	// Token: 0x040007FA RID: 2042
	[global::Cpp2ILInjected.Token(Token = "0x4000AAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private Microsoft.Xna.Framework.Vector2 LastAimNavTickPositionStart;

	// Token: 0x040007FB RID: 2043
	[global::Cpp2ILInjected.Token(Token = "0x4000AAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private Microsoft.Xna.Framework.Vector2 LastResultPosition;

	// Token: 0x040007FC RID: 2044
	[global::Cpp2ILInjected.Token(Token = "0x4000AAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private Microsoft.Xna.Framework.Vector2 WorldBlendOffset;

	// Token: 0x040007FD RID: 2045
	[global::Cpp2ILInjected.Token(Token = "0x4000AB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private bool lastGridAimMode;

	// Token: 0x040007FE RID: 2046
	[global::Cpp2ILInjected.Token(Token = "0x4000AB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD1")]
	private bool movingX;

	// Token: 0x040007FF RID: 2047
	[global::Cpp2ILInjected.Token(Token = "0x4000AB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD2")]
	private bool movingY;

	// Token: 0x04000800 RID: 2048
	[global::Cpp2ILInjected.Token(Token = "0x4000AB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	private int movingOffsetX;

	// Token: 0x04000801 RID: 2049
	[global::Cpp2ILInjected.Token(Token = "0x4000AB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private int movingOffsetY;

	// Token: 0x04000802 RID: 2050
	[global::Cpp2ILInjected.Token(Token = "0x4000AB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	private int LastWorldPositionX;

	// Token: 0x04000803 RID: 2051
	[global::Cpp2ILInjected.Token(Token = "0x4000AB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private int LastWorldPositionY;

	// Token: 0x04000804 RID: 2052
	[global::Cpp2ILInjected.Token(Token = "0x4000AB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	private int LastCursorPositionX;

	// Token: 0x04000805 RID: 2053
	[global::Cpp2ILInjected.Token(Token = "0x4000AB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private int LastCursorPositionY;

	// Token: 0x04000806 RID: 2054
	[global::Cpp2ILInjected.Token(Token = "0x4000AB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	private int LastScreenCentreX;

	// Token: 0x04000807 RID: 2055
	[global::Cpp2ILInjected.Token(Token = "0x4000ABA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	private int LastScreenCentreY;

	// Token: 0x04000808 RID: 2056
	[global::Cpp2ILInjected.Token(Token = "0x4000ABB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	private float deadZone;

	// Token: 0x04000809 RID: 2057
	[global::Cpp2ILInjected.Token(Token = "0x4000ABC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	private bool wasWorldCursorActive;

	// Token: 0x0400080A RID: 2058
	[global::Cpp2ILInjected.Token(Token = "0x4000ABD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	private int lastWorldCursorPointX;

	// Token: 0x0400080B RID: 2059
	[global::Cpp2ILInjected.Token(Token = "0x4000ABE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	private int lastWorldCursorPointY;

	// Token: 0x0400080C RID: 2060
	[global::Cpp2ILInjected.Token(Token = "0x4000ABF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	public bool wasMovementAxisActive;

	// Token: 0x0400080D RID: 2061
	[global::Cpp2ILInjected.Token(Token = "0x4000AC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x105")]
	public bool movementAxisActive;

	// Token: 0x0400080E RID: 2062
	[global::Cpp2ILInjected.Token(Token = "0x4000AC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x106")]
	public bool grappleAxisActive;

	// Token: 0x0400080F RID: 2063
	[global::Cpp2ILInjected.Token(Token = "0x4000AC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x107")]
	public bool wasGrappleAxisActive;

	// Token: 0x04000810 RID: 2064
	[global::Cpp2ILInjected.Token(Token = "0x4000AC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public bool grappleFired;

	// Token: 0x04000811 RID: 2065
	[global::Cpp2ILInjected.Token(Token = "0x4000AC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x109")]
	public bool fireAxisActive;

	// Token: 0x04000812 RID: 2066
	[global::Cpp2ILInjected.Token(Token = "0x4000AC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10A")]
	public bool grappleAxisPressed;

	// Token: 0x04000813 RID: 2067
	[global::Cpp2ILInjected.Token(Token = "0x4000AC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10B")]
	private bool fireAxisFiring;

	// Token: 0x04000814 RID: 2068
	[global::Cpp2ILInjected.Token(Token = "0x4000AC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public bool fireButtonFiring;

	// Token: 0x04000815 RID: 2069
	[global::Cpp2ILInjected.Token(Token = "0x4000AC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10D")]
	private bool fireFromHousing;

	// Token: 0x04000816 RID: 2070
	[global::Cpp2ILInjected.Token(Token = "0x4000AC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10E")]
	private bool anyActive;

	// Token: 0x04000817 RID: 2071
	[global::Cpp2ILInjected.Token(Token = "0x4000ACA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	private Microsoft.Xna.Framework.Vector2 grappleAxis;

	// Token: 0x04000818 RID: 2072
	[global::Cpp2ILInjected.Token(Token = "0x4000ACB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private Microsoft.Xna.Framework.Vector2 previousGrappleAxis;

	// Token: 0x04000819 RID: 2073
	[global::Cpp2ILInjected.Token(Token = "0x4000ACC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	private Microsoft.Xna.Framework.Vector2 movementAxis;

	// Token: 0x0400081A RID: 2074
	[global::Cpp2ILInjected.Token(Token = "0x4000ACD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	private Microsoft.Xna.Framework.Vector2 previousMovementAxis;

	// Token: 0x0400081B RID: 2075
	[global::Cpp2ILInjected.Token(Token = "0x4000ACE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private Microsoft.Xna.Framework.Vector2 fireAxis;

	// Token: 0x0400081C RID: 2076
	[global::Cpp2ILInjected.Token(Token = "0x4000ACF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private Microsoft.Xna.Framework.Vector2 gridSnapAxis;

	// Token: 0x0400081D RID: 2077
	[global::Cpp2ILInjected.Token(Token = "0x4000AD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	private Microsoft.Xna.Framework.Vector2 previousGridSnapAxis;

	// Token: 0x0400081E RID: 2078
	[global::Cpp2ILInjected.Token(Token = "0x4000AD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	private bool gridSnapUp;

	// Token: 0x0400081F RID: 2079
	[global::Cpp2ILInjected.Token(Token = "0x4000AD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x149")]
	private bool gridSnapDown;

	// Token: 0x04000820 RID: 2080
	[global::Cpp2ILInjected.Token(Token = "0x4000AD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14A")]
	private bool gridSnapLeft;

	// Token: 0x04000821 RID: 2081
	[global::Cpp2ILInjected.Token(Token = "0x4000AD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14B")]
	private bool gridSnapRight;

	// Token: 0x04000822 RID: 2082
	[global::Cpp2ILInjected.Token(Token = "0x4000AD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
	private Microsoft.Xna.Framework.Vector2 movementAxisScreenOffset;

	// Token: 0x04000823 RID: 2083
	[global::Cpp2ILInjected.Token(Token = "0x4000AD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	private Microsoft.Xna.Framework.Vector2 fireAxisScreenOffset;

	// Token: 0x04000824 RID: 2084
	[global::Cpp2ILInjected.Token(Token = "0x4000AD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
	private Microsoft.Xna.Framework.Vector2 grappleAxisScreenOffset;

	// Token: 0x04000825 RID: 2085
	[global::Cpp2ILInjected.Token(Token = "0x4000AD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	private Microsoft.Xna.Framework.Vector2 previousGrappleAxisScreenOffset;

	// Token: 0x04000826 RID: 2086
	[global::Cpp2ILInjected.Token(Token = "0x4000AD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
	private Microsoft.Xna.Framework.Vector2 grappleAxisCentre;

	// Token: 0x04000827 RID: 2087
	[global::Cpp2ILInjected.Token(Token = "0x4000ADA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
	private Microsoft.Xna.Framework.Vector2 movementAxisCentre;

	// Token: 0x04000828 RID: 2088
	[global::Cpp2ILInjected.Token(Token = "0x4000ADB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x17C")]
	private Microsoft.Xna.Framework.Vector2 fireAxisCentre;

	// Token: 0x04000829 RID: 2089
	[global::Cpp2ILInjected.Token(Token = "0x4000ADC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public bool[] Pressed;

	// Token: 0x0400082A RID: 2090
	[global::Cpp2ILInjected.Token(Token = "0x4000ADD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public bool[] WasPressed;

	// Token: 0x0400082B RID: 2091
	[global::Cpp2ILInjected.Token(Token = "0x4000ADE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public float[] Scale;

	// Token: 0x0400082C RID: 2092
	[global::Cpp2ILInjected.Token(Token = "0x4000ADF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	private float TimeSinceToggleSmartCursor;

	// Token: 0x0400082D RID: 2093
	[global::Cpp2ILInjected.Token(Token = "0x4000AE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
	private float TimeSinceToggleAutoFire;

	// Token: 0x0400082E RID: 2094
	[global::Cpp2ILInjected.Token(Token = "0x4000AE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public float TimeSinceModifyZoom;

	// Token: 0x0400082F RID: 2095
	[global::Cpp2ILInjected.Token(Token = "0x4000AE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
	private float TimeSinceCombatTargeting;

	// Token: 0x04000830 RID: 2096
	[global::Cpp2ILInjected.Token(Token = "0x4000AE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private float TimeSinceProfileChanged;

	// Token: 0x04000831 RID: 2097
	[global::Cpp2ILInjected.Token(Token = "0x4000AE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	public bool InventoryToggle;

	// Token: 0x04000832 RID: 2098
	[global::Cpp2ILInjected.Token(Token = "0x4000AE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B5")]
	private bool Shown;

	// Token: 0x020007D0 RID: 2000
	[global::Cpp2ILInjected.Token(Token = "0x2000176")]
	public enum LeftStickJumpMode
	{
		// Token: 0x04007A7E RID: 31358
		[global::Cpp2ILInjected.Token(Token = "0x4000AE7")]
		DoubleTap,
		// Token: 0x04007A7F RID: 31359
		[global::Cpp2ILInjected.Token(Token = "0x4000AE8")]
		SingleTap,
		// Token: 0x04007A80 RID: 31360
		[global::Cpp2ILInjected.Token(Token = "0x4000AE9")]
		Up,
		// Token: 0x04007A81 RID: 31361
		[global::Cpp2ILInjected.Token(Token = "0x4000AEA")]
		Disabled
	}

	// Token: 0x020007D1 RID: 2001
	[global::Cpp2ILInjected.Token(Token = "0x2000177")]
	public enum ControlType
	{
		// Token: 0x04007A83 RID: 31363
		[global::Cpp2ILInjected.Token(Token = "0x4000AEC")]
		Left,
		// Token: 0x04007A84 RID: 31364
		[global::Cpp2ILInjected.Token(Token = "0x4000AED")]
		Right,
		// Token: 0x04007A85 RID: 31365
		[global::Cpp2ILInjected.Token(Token = "0x4000AEE")]
		Jump,
		// Token: 0x04007A86 RID: 31366
		[global::Cpp2ILInjected.Token(Token = "0x4000AEF")]
		Up,
		// Token: 0x04007A87 RID: 31367
		[global::Cpp2ILInjected.Token(Token = "0x4000AF0")]
		Down,
		// Token: 0x04007A88 RID: 31368
		[global::Cpp2ILInjected.Token(Token = "0x4000AF1")]
		Inventory,
		// Token: 0x04007A89 RID: 31369
		[global::Cpp2ILInjected.Token(Token = "0x4000AF2")]
		QuickHeal,
		// Token: 0x04007A8A RID: 31370
		[global::Cpp2ILInjected.Token(Token = "0x4000AF3")]
		QuickMana,
		// Token: 0x04007A8B RID: 31371
		[global::Cpp2ILInjected.Token(Token = "0x4000AF4")]
		QuickMount,
		// Token: 0x04007A8C RID: 31372
		[global::Cpp2ILInjected.Token(Token = "0x4000AF5")]
		QuickBuff,
		// Token: 0x04007A8D RID: 31373
		[global::Cpp2ILInjected.Token(Token = "0x4000AF6")]
		Grapple,
		// Token: 0x04007A8E RID: 31374
		[global::Cpp2ILInjected.Token(Token = "0x4000AF7")]
		Fire,
		// Token: 0x04007A8F RID: 31375
		[global::Cpp2ILInjected.Token(Token = "0x4000AF8")]
		UseTileControl,
		// Token: 0x04007A90 RID: 31376
		[global::Cpp2ILInjected.Token(Token = "0x4000AF9")]
		Interact,
		// Token: 0x04007A91 RID: 31377
		[global::Cpp2ILInjected.Token(Token = "0x4000AFA")]
		ZoomIn,
		// Token: 0x04007A92 RID: 31378
		[global::Cpp2ILInjected.Token(Token = "0x4000AFB")]
		ZoomOut,
		// Token: 0x04007A93 RID: 31379
		[global::Cpp2ILInjected.Token(Token = "0x4000AFC")]
		AutoFire,
		// Token: 0x04007A94 RID: 31380
		[global::Cpp2ILInjected.Token(Token = "0x4000AFD")]
		SmartCursor,
		// Token: 0x04007A95 RID: 31381
		[global::Cpp2ILInjected.Token(Token = "0x4000AFE")]
		InventoryToggle,
		// Token: 0x04007A96 RID: 31382
		[global::Cpp2ILInjected.Token(Token = "0x4000AFF")]
		AutoSelect,
		// Token: 0x04007A97 RID: 31383
		[global::Cpp2ILInjected.Token(Token = "0x4000B00")]
		GrappleSelect,
		// Token: 0x04007A98 RID: 31384
		[global::Cpp2ILInjected.Token(Token = "0x4000B01")]
		TargetLockOn,
		// Token: 0x04007A99 RID: 31385
		[global::Cpp2ILInjected.Token(Token = "0x4000B02")]
		ProfileSwitch,
		// Token: 0x04007A9A RID: 31386
		[global::Cpp2ILInjected.Token(Token = "0x4000B03")]
		UseButton,
		// Token: 0x04007A9B RID: 31387
		[global::Cpp2ILInjected.Token(Token = "0x4000B04")]
		Settings,
		// Token: 0x04007A9C RID: 31388
		[global::Cpp2ILInjected.Token(Token = "0x4000B05")]
		Loadout1,
		// Token: 0x04007A9D RID: 31389
		[global::Cpp2ILInjected.Token(Token = "0x4000B06")]
		Loadout2,
		// Token: 0x04007A9E RID: 31390
		[global::Cpp2ILInjected.Token(Token = "0x4000B07")]
		Loadout3,
		// Token: 0x04007A9F RID: 31391
		[global::Cpp2ILInjected.Token(Token = "0x4000B08")]
		LoadoutCycle,
		// Token: 0x04007AA0 RID: 31392
		[global::Cpp2ILInjected.Token(Token = "0x4000B09")]
		Count
	}
}
