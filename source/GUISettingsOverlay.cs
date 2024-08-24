using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameInput;
using Terraria.Graphics.Light;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;
using UnityEngine;

// Token: 0x020001E2 RID: 482
[global::Cpp2ILInjected.Token(Token = "0x200027F")]
public class GUISettingsOverlay
{
	// Token: 0x06000D53 RID: 3411 RVA: 0x0002433E File Offset: 0x0002253E
	[global::Cpp2ILInjected.Token(Token = "0x6000E72")]
	[global::Cpp2ILInjected.Address(RVA = "0xA018DC", Offset = "0xA018DC", Length = "0x3AB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "SetupState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIToggleSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILinkButtonSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(GUIPulldownSetting.ActivateOverlayCallback),
		typeof(GUIPulldownSetting.DeactivateOverlayCallback),
		typeof(GUIPulldownSetting.RegisterOverlay)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIOpenUIButtonSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 136)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00024341 File Offset: 0x00022541
	[global::Cpp2ILInjected.Token(Token = "0x6000E73")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0538C", Offset = "0xA0538C", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILinkButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void UpdateScroll(GUISettingID _id)
	{
		throw null;
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00024344 File Offset: 0x00022544
	[global::Cpp2ILInjected.Token(Token = "0x6000E74")]
	[global::Cpp2ILInjected.Address(RVA = "0xA055AC", Offset = "0xA055AC", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILinkButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public bool IsFullyVisible(GUISettingID _id)
	{
		throw null;
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00024347 File Offset: 0x00022547
	[global::Cpp2ILInjected.Token(Token = "0x6000E75")]
	[global::Cpp2ILInjected.Address(RVA = "0xA057CC", Offset = "0xA057CC", Length = "0x28C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private bool IsHidden(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0002434A File Offset: 0x0002254A
	[global::Cpp2ILInjected.Token(Token = "0x6000E76")]
	[global::Cpp2ILInjected.Address(RVA = "0xA05A58", Offset = "0xA05A58", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	public bool IsDisabled(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x0002434D File Offset: 0x0002254D
	[global::Cpp2ILInjected.Token(Token = "0x6000E77")]
	[global::Cpp2ILInjected.Address(RVA = "0xA05B10", Offset = "0xA05B10", Length = "0x388")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawCategoryOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SettingsOverlayOptionCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(GUISettingID),
		typeof(ref SettingsOverlayOptionCategories_Layout.Category),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "IsHidden", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public void SetCategory(SettingsOverlayOptionCategories_Layout.Category category)
	{
		throw null;
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00024350 File Offset: 0x00022550
	[global::Cpp2ILInjected.Token(Token = "0x6000E78")]
	[global::Cpp2ILInjected.Address(RVA = "0xA05E98", Offset = "0xA05E98", Length = "0x14")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
		throw null;
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00024353 File Offset: 0x00022553
	[global::Cpp2ILInjected.Token(Token = "0x6000E79")]
	[global::Cpp2ILInjected.Address(RVA = "0xA05EAC", Offset = "0xA05EAC", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "HandleNetworkLost", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopFrameUpdate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenAchievements", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inFancyUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00024356 File Offset: 0x00022556
	[global::Cpp2ILInjected.Token(Token = "0x6000E7A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA06060", Offset = "0xA06060", Length = "0x534")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inFancyUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISaveSynchronisation), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "GainFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSettingsOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "DrawCategoryOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "DrawTitle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00024359 File Offset: 0x00022559
	[global::Cpp2ILInjected.Token(Token = "0x6000E7B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07BD4", Offset = "0xA07BD4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float SettingScale(int index)
	{
		throw null;
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0002435C File Offset: 0x0002255C
	[global::Cpp2ILInjected.Token(Token = "0x6000E7C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07BDC", Offset = "0xA07BDC", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSettingsOverlay), Member = "SelectedSetting", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void SettingOver(int index)
	{
		throw null;
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0002435F File Offset: 0x0002255F
	[global::Cpp2ILInjected.Token(Token = "0x6000E7D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07C8C", Offset = "0xA07C8C", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x00024362 File Offset: 0x00022562
	[global::Cpp2ILInjected.Token(Token = "0x6000E7E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07DB0", Offset = "0xA07DB0", Length = "0x11C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void DummyDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x00024365 File Offset: 0x00022565
	[global::Cpp2ILInjected.Token(Token = "0x6000E7F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07ECC", Offset = "0xA07ECC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void DummyOver(int index)
	{
		throw null;
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x00024368 File Offset: 0x00022568
	[global::Cpp2ILInjected.Token(Token = "0x6000E80")]
	[global::Cpp2ILInjected.Address(RVA = "0xA079C0", Offset = "0xA079C0", Length = "0x214")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemSizeHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public void RefreshInputRegion()
	{
		throw null;
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x0002436B File Offset: 0x0002256B
	[global::Cpp2ILInjected.Token(Token = "0x6000E81")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07ED0", Offset = "0xA07ED0", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		throw null;
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0002436E File Offset: 0x0002256E
	[global::Cpp2ILInjected.Token(Token = "0x6000E82")]
	[global::Cpp2ILInjected.Address(RVA = "0xA067B0", Offset = "0xA067B0", Length = "0x28C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemSizeHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void DrawCategoryOptions()
	{
		throw null;
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00024371 File Offset: 0x00022571
	[global::Cpp2ILInjected.Token(Token = "0x6000E83")]
	[global::Cpp2ILInjected.Address(RVA = "0xA06718", Offset = "0xA06718", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void DrawBacking()
	{
		throw null;
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00024374 File Offset: 0x00022574
	[global::Cpp2ILInjected.Token(Token = "0x6000E84")]
	[global::Cpp2ILInjected.Address(RVA = "0xA075E8", Offset = "0xA075E8", Length = "0x3D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringButton_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
	{
		typeof(SpriteFont),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	private void DrawTitle()
	{
		throw null;
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00024377 File Offset: 0x00022577
	[global::Cpp2ILInjected.Token(Token = "0x6000E85")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07F84", Offset = "0xA07F84", Length = "0xE90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetPageSettings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ControllerBorderColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "rgbToHsl", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_BackgroundTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_UITexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_CharacterTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_ProjectileTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_GoreTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_GlowTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "set_EnvironmentTexturesHigh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ControllerColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MouseBorderColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_soundVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ambientVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_musicVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_autoSave", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "set_HighlightNewItems", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_showItemText", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_placementPreview", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChildSafety), Member = "set_Disabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemoryPopup), Member = "get_DeviceMemory", ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_invasionProgressMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "set_UseMode", MemberParameters = new object[] { typeof(LockOnHelper.LockOnMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryTooltipTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_tooltipTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SettingsEnabled_OpaqueBoxBehindTooltips", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_Setting_Target60FPS", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "set_Enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_showFrameRate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_BackgroundEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_autoPause", MemberParameters = new object[] { typeof(Main.AutoPauseMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_bgScroll", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_HidePassword", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "set_SwapBumpersTriggers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_qaStyle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "set_ActiveFrameStyle", MemberParameters = new object[] { typeof(GUIMap.MinimapFrameStyle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "set_UseLargeMinimap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "set_EscapeOpensInventory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_cSmartCursorModeIsToggleAndNotHold", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.SmartCursorSettings), Member = "set_SmartAxeAfterPickaxe", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player.SmartCursorSettings), Member = "set_SmartBlocksEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MouseShowBuildingGrid", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SettingsEnabled_MinersWobble", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SettingsEnabled_TilesSwayInWind", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot.Options), Member = "set_DisableLeftShiftTrashCan", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "set_MobileTouchLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "get_DefaultTexturesHigh", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "UnloadAssets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_WaveQuality", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
	private void ResetSetting(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x0002437A File Offset: 0x0002257A
	[global::Cpp2ILInjected.Token(Token = "0x6000E86")]
	[global::Cpp2ILInjected.Address(RVA = "0xA08E14", Offset = "0xA08E14", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void ResetPageSettings()
	{
		throw null;
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x0002437D File Offset: 0x0002257D
	[global::Cpp2ILInjected.Token(Token = "0x6000E87")]
	[global::Cpp2ILInjected.Address(RVA = "0xA07304", Offset = "0xA07304", Length = "0x2E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "ResetPageSettings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void DrawMainButtons()
	{
		throw null;
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00024380 File Offset: 0x00022580
	[global::Cpp2ILInjected.Token(Token = "0x6000E88")]
	[global::Cpp2ILInjected.Address(RVA = "0xA06648", Offset = "0xA06648", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Close()
	{
		throw null;
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x00024383 File Offset: 0x00022583
	[global::Cpp2ILInjected.Token(Token = "0x6000E89")]
	[global::Cpp2ILInjected.Address(RVA = "0xA06A3C", Offset = "0xA06A3C", Length = "0x8C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
	{
		typeof(Int32Enum[]),
		"System.Int32Enum"
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "NextPagePressed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSettingsOverlay), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PreviousPagePressed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "CloseOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private void DrawCategories()
	{
		throw null;
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x00024386 File Offset: 0x00022586
	[global::Cpp2ILInjected.Token(Token = "0x6000E8A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA08E9C", Offset = "0xA08E9C", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "ShutdownUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "IsOverCategories", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void LooseFocus()
	{
		throw null;
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x00024389 File Offset: 0x00022589
	[global::Cpp2ILInjected.Token(Token = "0x6000E8B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA06594", Offset = "0xA06594", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void GainFocus()
	{
		throw null;
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x0002438C File Offset: 0x0002258C
	[global::Cpp2ILInjected.Token(Token = "0x6000E8C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA08F08", Offset = "0xA08F08", Length = "0x220")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inFancyUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "LooseFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x0002438F File Offset: 0x0002258F
	[global::Cpp2ILInjected.Token(Token = "0x6000E8D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09128", Offset = "0xA09128", Length = "0x12C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSettingsOverlay), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public GUISettingsOverlay()
	{
		throw null;
	}

	// Token: 0x04001549 RID: 5449
	[global::Cpp2ILInjected.Token(Token = "0x4001A62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private List<GUISettingEntry> _allSettings;

	// Token: 0x0400154A RID: 5450
	[global::Cpp2ILInjected.Token(Token = "0x4001A63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public List<GUISettingEntry> _categorySettings;

	// Token: 0x0400154B RID: 5451
	[global::Cpp2ILInjected.Token(Token = "0x4001A64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerSettingsOverlay _controllerInput;

	// Token: 0x0400154C RID: 5452
	[global::Cpp2ILInjected.Token(Token = "0x4001A65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public SettingsOverlayOptionCategories_Layout.Category Selected;

	// Token: 0x0400154D RID: 5453
	[global::Cpp2ILInjected.Token(Token = "0x4001A66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int PendingSelected;

	// Token: 0x0400154E RID: 5454
	[global::Cpp2ILInjected.Token(Token = "0x4001A67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int disableScroll;

	// Token: 0x0400154F RID: 5455
	[global::Cpp2ILInjected.Token(Token = "0x4001A68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private GUISettingEntry overlayEntry;

	// Token: 0x04001550 RID: 5456
	[global::Cpp2ILInjected.Token(Token = "0x4001A69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Rectangle overlayRegion;

	// Token: 0x04001551 RID: 5457
	[global::Cpp2ILInjected.Token(Token = "0x4001A6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float ScrollOffset;

	// Token: 0x04001552 RID: 5458
	[global::Cpp2ILInjected.Token(Token = "0x4001A6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float ScrollMomentum;

	// Token: 0x04001553 RID: 5459
	[global::Cpp2ILInjected.Token(Token = "0x4001A6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private int ScrollDragging;

	// Token: 0x04001554 RID: 5460
	[global::Cpp2ILInjected.Token(Token = "0x4001A6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04001555 RID: 5461
	[global::Cpp2ILInjected.Token(Token = "0x4001A6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private bool unconfiguredControllerAttached;

	// Token: 0x04001556 RID: 5462
	[global::Cpp2ILInjected.Token(Token = "0x4001A6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float titleScale;

	// Token: 0x04001557 RID: 5463
	[global::Cpp2ILInjected.Token(Token = "0x4001A70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float GeneralButtonScale;

	// Token: 0x04001558 RID: 5464
	[global::Cpp2ILInjected.Token(Token = "0x4001A71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private float CursorButtonScale;

	// Token: 0x04001559 RID: 5465
	[global::Cpp2ILInjected.Token(Token = "0x4001A72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private float VideoButtonScale;

	// Token: 0x0400155A RID: 5466
	[global::Cpp2ILInjected.Token(Token = "0x4001A73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private float LanguageButtonScale;

	// Token: 0x0400155B RID: 5467
	[global::Cpp2ILInjected.Token(Token = "0x4001A74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float SaveAndCloseButtonScale;

	// Token: 0x0400155C RID: 5468
	[global::Cpp2ILInjected.Token(Token = "0x4001A75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float AchievementsButtonScale;

	// Token: 0x0400155D RID: 5469
	[global::Cpp2ILInjected.Token(Token = "0x4001A76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private float InterfaceButtonScale;

	// Token: 0x0400155E RID: 5470
	[global::Cpp2ILInjected.Token(Token = "0x4001A77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private float InfoButtonScale;

	// Token: 0x0400155F RID: 5471
	[global::Cpp2ILInjected.Token(Token = "0x4001A78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private float ResetSettingsButtonScale;

	// Token: 0x04001560 RID: 5472
	[global::Cpp2ILInjected.Token(Token = "0x4001A79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private float KeyboardMouseButtonScale;

	// Token: 0x04001561 RID: 5473
	[global::Cpp2ILInjected.Token(Token = "0x4001A7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private float TimeSinceItemChange;

	// Token: 0x04001562 RID: 5474
	[global::Cpp2ILInjected.Token(Token = "0x4001A7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private SettingsOverlayOptionCategories_Layout.Category[] TabOrder;

	// Token: 0x04001563 RID: 5475
	[global::Cpp2ILInjected.Token(Token = "0x4001A7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private bool hasFocus;

	// Token: 0x04001564 RID: 5476
	[global::Cpp2ILInjected.Token(Token = "0x4001A7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x020007FE RID: 2046
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000280")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060048F2 RID: 18674 RVA: 0x0002EF2B File Offset: 0x0002D12B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E8E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA09254", Offset = "0xA09254", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x0002EF2E File Offset: 0x0002D12E
		[global::Cpp2ILInjected.Token(Token = "0x6000E8F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA092B0", Offset = "0xA092B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0002EF31 File Offset: 0x0002D131
		[global::Cpp2ILInjected.Token(Token = "0x6000E90")]
		[global::Cpp2ILInjected.Address(RVA = "0xA092B8", Offset = "0xA092B8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <SetCategory>b__10_0(GUISettingEntry e1, GUISettingEntry e2)
		{
			throw null;
		}

		// Token: 0x04007CE3 RID: 31971
		[global::Cpp2ILInjected.Token(Token = "0x4001A7E")]
		public static readonly GUISettingsOverlay.<>c <>9;

		// Token: 0x04007CE4 RID: 31972
		[global::Cpp2ILInjected.Token(Token = "0x4001A7F")]
		public static Comparison<GUISettingEntry> <>9__10_0;
	}
}
