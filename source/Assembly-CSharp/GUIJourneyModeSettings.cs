using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020000EB RID: 235
[global::Cpp2ILInjected.Token(Token = "0x2000151")]
public class GUIJourneyModeSettings
{
	// Token: 0x0600083B RID: 2107 RVA: 0x000233F6 File Offset: 0x000215F6
	[global::Cpp2ILInjected.Token(Token = "0x6000935")]
	[global::Cpp2ILInjected.Address(RVA = "0x920C04", Offset = "0x920C04", Length = "0x73C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIJourneyModeSettings.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyToggleSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyButtonSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneySliderSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyPulldownSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x000233F9 File Offset: 0x000215F9
	[global::Cpp2ILInjected.Token(Token = "0x6000936")]
	[global::Cpp2ILInjected.Address(RVA = "0x921340", Offset = "0x921340", Length = "0x398")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyButtonSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyToggleSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	public static Microsoft.Xna.Framework.Graphics.Texture2D GetIconTexture(GUISettingID id, out Rectangle frame)
	{
		throw null;
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x000233FC File Offset: 0x000215FC
	[global::Cpp2ILInjected.Token(Token = "0x6000937")]
	[global::Cpp2ILInjected.Address(RVA = "0x9216D8", Offset = "0x9216D8", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyPulldownSetting), Member = "RegisterOverlayJM", MemberParameters = new object[]
	{
		typeof(GUIPulldownSetting),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void RegisterOverlay(GUISettingEntry entry, Rectangle region)
	{
		throw null;
	}

	// Token: 0x0600083E RID: 2110 RVA: 0x000233FF File Offset: 0x000215FF
	[global::Cpp2ILInjected.Token(Token = "0x6000938")]
	[global::Cpp2ILInjected.Address(RVA = "0x9216E4", Offset = "0x9216E4", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIJourneyModeSettings.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void DrawButton()
	{
		throw null;
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x00023402 File Offset: 0x00021602
	[global::Cpp2ILInjected.Token(Token = "0x6000939")]
	[global::Cpp2ILInjected.Address(RVA = "0x9219BC", Offset = "0x9219BC", Length = "0x2A4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "GainFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategoryOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "DrawTitle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x00023405 File Offset: 0x00021605
	[global::Cpp2ILInjected.Token(Token = "0x600093A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9225B4", Offset = "0x9225B4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float SettingScale(int index)
	{
		throw null;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00023408 File Offset: 0x00021608
	[global::Cpp2ILInjected.Token(Token = "0x600093B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9225BC", Offset = "0x9225BC", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerJourneyModeSettings), Member = "SelectedSetting", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void SettingOver(int index)
	{
		throw null;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0002340B File Offset: 0x0002160B
	[global::Cpp2ILInjected.Token(Token = "0x600093C")]
	[global::Cpp2ILInjected.Address(RVA = "0x92266C", Offset = "0x92266C", Length = "0x124")]
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

	// Token: 0x06000843 RID: 2115 RVA: 0x0002340E File Offset: 0x0002160E
	[global::Cpp2ILInjected.Token(Token = "0x600093D")]
	[global::Cpp2ILInjected.Address(RVA = "0x922790", Offset = "0x922790", Length = "0xB4")]
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

	// Token: 0x06000844 RID: 2116 RVA: 0x00023411 File Offset: 0x00021611
	[global::Cpp2ILInjected.Token(Token = "0x600093E")]
	[global::Cpp2ILInjected.Address(RVA = "0x921DAC", Offset = "0x921DAC", Length = "0x208")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
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
	private void DrawCategoryOptions()
	{
		throw null;
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x00023414 File Offset: 0x00021614
	[global::Cpp2ILInjected.Token(Token = "0x600093F")]
	[global::Cpp2ILInjected.Address(RVA = "0x921FB4", Offset = "0x921FB4", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void DrawTitle()
	{
		throw null;
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x00023417 File Offset: 0x00021617
	[global::Cpp2ILInjected.Token(Token = "0x6000940")]
	[global::Cpp2ILInjected.Address(RVA = "0x921D14", Offset = "0x921D14", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
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
	public void DrawBacking()
	{
		throw null;
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0002341A File Offset: 0x0002161A
	[global::Cpp2ILInjected.Token(Token = "0x6000941")]
	[global::Cpp2ILInjected.Address(RVA = "0x92186C", Offset = "0x92186C", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void SetCategory(GUIJourneyModeSettings.Category category)
	{
		throw null;
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0002341D File Offset: 0x0002161D
	[global::Cpp2ILInjected.Token(Token = "0x6000942")]
	[global::Cpp2ILInjected.Address(RVA = "0x922044", Offset = "0x922044", Length = "0x570")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIJourneyModeSettings.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerJourneyModeSettings), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PreviousPagePressed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void DrawCategories()
	{
		throw null;
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00023420 File Offset: 0x00021620
	[global::Cpp2ILInjected.Token(Token = "0x6000943")]
	[global::Cpp2ILInjected.Address(RVA = "0x922844", Offset = "0x922844", Length = "0x20C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void DrawMainButtons()
	{
		throw null;
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00023423 File Offset: 0x00021623
	[global::Cpp2ILInjected.Token(Token = "0x6000944")]
	[global::Cpp2ILInjected.Address(RVA = "0x9218EC", Offset = "0x9218EC", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void Close()
	{
		throw null;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00023426 File Offset: 0x00021626
	[global::Cpp2ILInjected.Token(Token = "0x6000945")]
	[global::Cpp2ILInjected.Address(RVA = "0x922A50", Offset = "0x922A50", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "IsOverCategories", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void LooseFocus()
	{
		throw null;
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00023429 File Offset: 0x00021629
	[global::Cpp2ILInjected.Token(Token = "0x6000946")]
	[global::Cpp2ILInjected.Address(RVA = "0x921C60", Offset = "0x921C60", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x0600084D RID: 2125 RVA: 0x0002342C File Offset: 0x0002162C
	[global::Cpp2ILInjected.Token(Token = "0x6000947")]
	[global::Cpp2ILInjected.Address(RVA = "0x922ABC", Offset = "0x922ABC", Length = "0x11C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "LooseFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0002342F File Offset: 0x0002162F
	[global::Cpp2ILInjected.Token(Token = "0x6000948")]
	[global::Cpp2ILInjected.Address(RVA = "0x916108", Offset = "0x916108", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerJourneyModeSettings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public GUIJourneyModeSettings()
	{
		throw null;
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00023432 File Offset: 0x00021632
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000949")]
	[global::Cpp2ILInjected.Address(RVA = "0x922BD8", Offset = "0x922BD8", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static GUIJourneyModeSettings()
	{
		throw null;
	}

	// Token: 0x0400066A RID: 1642
	[global::Cpp2ILInjected.Token(Token = "0x40008D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool Enabled;

	// Token: 0x0400066B RID: 1643
	[global::Cpp2ILInjected.Token(Token = "0x40008D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool OpenedFromInv;

	// Token: 0x0400066C RID: 1644
	[global::Cpp2ILInjected.Token(Token = "0x40008D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float jwButtonScale;

	// Token: 0x0400066D RID: 1645
	[global::Cpp2ILInjected.Token(Token = "0x40008D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public List<GUISettingEntry> _categorySettings;

	// Token: 0x0400066E RID: 1646
	[global::Cpp2ILInjected.Token(Token = "0x40008D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public List<GUISettingEntry> _timeSettings;

	// Token: 0x0400066F RID: 1647
	[global::Cpp2ILInjected.Token(Token = "0x40008D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public List<GUISettingEntry> _weatherSettings;

	// Token: 0x04000670 RID: 1648
	[global::Cpp2ILInjected.Token(Token = "0x40008D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public List<GUISettingEntry> _powerSettings;

	// Token: 0x04000671 RID: 1649
	[global::Cpp2ILInjected.Token(Token = "0x40008DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float TimeSinceItemChange;

	// Token: 0x04000672 RID: 1650
	[global::Cpp2ILInjected.Token(Token = "0x40008DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIControllerJourneyModeSettings _controllerInput;

	// Token: 0x04000673 RID: 1651
	[global::Cpp2ILInjected.Token(Token = "0x40008DC")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D infinitePowersMenu;

	// Token: 0x04000674 RID: 1652
	[global::Cpp2ILInjected.Token(Token = "0x40008DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private GUISettingEntry overlayEntry;

	// Token: 0x04000675 RID: 1653
	[global::Cpp2ILInjected.Token(Token = "0x40008DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private Rectangle overlayRegion;

	// Token: 0x04000676 RID: 1654
	[global::Cpp2ILInjected.Token(Token = "0x40008DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float ScrollOffset;

	// Token: 0x04000677 RID: 1655
	[global::Cpp2ILInjected.Token(Token = "0x40008E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float ScrollMomentum;

	// Token: 0x04000678 RID: 1656
	[global::Cpp2ILInjected.Token(Token = "0x40008E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private int ScrollDragging;

	// Token: 0x04000679 RID: 1657
	[global::Cpp2ILInjected.Token(Token = "0x40008E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x0400067A RID: 1658
	[global::Cpp2ILInjected.Token(Token = "0x40008E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private float titleScale;

	// Token: 0x0400067B RID: 1659
	[global::Cpp2ILInjected.Token(Token = "0x40008E4")]
	private static GUIJourneyModeSettings.Category[] TabOrder;

	// Token: 0x0400067C RID: 1660
	[global::Cpp2ILInjected.Token(Token = "0x40008E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private GUIJourneyModeSettings.Category Selected;

	// Token: 0x0400067D RID: 1661
	[global::Cpp2ILInjected.Token(Token = "0x40008E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float PowerButtonScale;

	// Token: 0x0400067E RID: 1662
	[global::Cpp2ILInjected.Token(Token = "0x40008E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float TimeButtonScale;

	// Token: 0x0400067F RID: 1663
	[global::Cpp2ILInjected.Token(Token = "0x40008E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private float WeatherButtonScale;

	// Token: 0x04000680 RID: 1664
	[global::Cpp2ILInjected.Token(Token = "0x40008E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private float CloseButtonScale;

	// Token: 0x04000681 RID: 1665
	[global::Cpp2ILInjected.Token(Token = "0x40008EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private bool hasFocus;

	// Token: 0x04000682 RID: 1666
	[global::Cpp2ILInjected.Token(Token = "0x40008EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x020007C7 RID: 1991
	[global::Cpp2ILInjected.Token(Token = "0x2000152")]
	public enum Category
	{
		// Token: 0x04007A34 RID: 31284
		[global::Cpp2ILInjected.Token(Token = "0x40008ED")]
		Time,
		// Token: 0x04007A35 RID: 31285
		[global::Cpp2ILInjected.Token(Token = "0x40008EE")]
		Weather,
		// Token: 0x04007A36 RID: 31286
		[global::Cpp2ILInjected.Token(Token = "0x40008EF")]
		Powers
	}
}
