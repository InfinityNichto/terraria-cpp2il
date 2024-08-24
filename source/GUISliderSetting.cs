using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001F1 RID: 497
[global::Cpp2ILInjected.Token(Token = "0x2000295")]
public class GUISliderSetting : GUISettingEntry
{
	// Token: 0x06000E3A RID: 3642 RVA: 0x000245F3 File Offset: 0x000227F3
	[global::Cpp2ILInjected.Token(Token = "0x6000F6A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E630", Offset = "0xA2E630", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSliderEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Init", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider.DragState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUISliderSetting(GUISettingID id)
	{
		throw null;
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x000245F6 File Offset: 0x000227F6
	[global::Cpp2ILInjected.Token(Token = "0x6000F6B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E6AC", Offset = "0xA2E6AC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	protected virtual SettingsOverlaySlider_Layout GetLayout()
	{
		throw null;
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x000245F9 File Offset: 0x000227F9
	[global::Cpp2ILInjected.Token(Token = "0x6000F6C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E6F8", Offset = "0xA2E6F8", Length = "0x2D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "GetValue", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "rgbToHsl", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private Microsoft.Xna.Framework.Vector3 GetHSL()
	{
		throw null;
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x000245FC File Offset: 0x000227FC
	[global::Cpp2ILInjected.Token(Token = "0x6000F6D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E9D0", Offset = "0xA2E9D0", Length = "0x248")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector3) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ControllerColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ControllerBorderColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MouseBorderColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void SetHSL(Microsoft.Xna.Framework.Vector3 hsl)
	{
		throw null;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x000245FF File Offset: 0x000227FF
	[global::Cpp2ILInjected.Token(Token = "0x6000F6E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2EC18", Offset = "0xA2EC18", Length = "0x5CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneySliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get__gridItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "IsOverExclusiveRegion", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetValue", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "IsDisabled", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetTitle", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerSettingsOverlay), Member = "OverlayActive", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "UpdateScroll", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetHSL", ReturnType = typeof(Microsoft.Xna.Framework.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_hBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_sBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "DrawLightness", MemberParameters = new object[]
	{
		typeof(Slider_Layout),
		typeof(bool),
		typeof(ref float),
		typeof(GUISlider.DragState),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "Draw", MemberParameters = new object[]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "DrawSaturation", MemberParameters = new object[]
	{
		typeof(Slider_Layout),
		typeof(bool),
		typeof(ref float),
		typeof(GUISlider.DragState),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetMaxValue", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "QuantiseValue", MemberParameters = new object[]
	{
		typeof(float),
		typeof(int)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetStringValue", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00024602 File Offset: 0x00022802
	[global::Cpp2ILInjected.Token(Token = "0x6000F6F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA306D0", Offset = "0xA306D0", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00024605 File Offset: 0x00022805
	[global::Cpp2ILInjected.Token(Token = "0x6000F70")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2F1E4", Offset = "0xA2F1E4", Length = "0x45C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetHSL", ReturnType = typeof(Microsoft.Xna.Framework.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_tooltipTime", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ambientVolume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgScroll", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_musicVolume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryTooltipTime", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_soundVolume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	private float GetValue()
	{
		throw null;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00024608 File Offset: 0x00022808
	[global::Cpp2ILInjected.Token(Token = "0x6000F71")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2FA04", Offset = "0xA2FA04", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	private int GetMaxValue()
	{
		throw null;
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x0002460B File Offset: 0x0002280B
	[global::Cpp2ILInjected.Token(Token = "0x6000F72")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2FACC", Offset = "0xA2FACC", Length = "0x590")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "GetHSL", ReturnType = typeof(Microsoft.Xna.Framework.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider), Member = "ScaleValue", MemberParameters = new object[]
	{
		typeof(float),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_tooltipTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ambientVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_bgScroll", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgScroll", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_caveParallax", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISliderSetting), Member = "SetHSL", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector3) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedSliderPower), Member = "AttemptPushingChange", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "AttemptPushingChange", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_musicVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_inventoryTooltipTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_soundVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ControllerBorderColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_MouseBorderColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void SetValue(float value)
	{
		throw null;
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x0002460E File Offset: 0x0002280E
	[global::Cpp2ILInjected.Token(Token = "0x6000F73")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3005C", Offset = "0xA3005C", Length = "0x674")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_tooltipTime", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ambientVolume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_bgScroll", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetSliderValue", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "GetShouldDisableSpawnsFor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_musicVolume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryTooltipTime", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_soundVolume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
	private string GetStringValue()
	{
		throw null;
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00024611 File Offset: 0x00022811
	[global::Cpp2ILInjected.Token(Token = "0x6000F74")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2F640", Offset = "0xA2F640", Length = "0x3C4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISliderSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	private string GetTitle()
	{
		throw null;
	}

	// Token: 0x040016FC RID: 5884
	[global::Cpp2ILInjected.Token(Token = "0x4001C1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float scale;

	// Token: 0x040016FD RID: 5885
	[global::Cpp2ILInjected.Token(Token = "0x4001C1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	protected float sliderValue;

	// Token: 0x040016FE RID: 5886
	[global::Cpp2ILInjected.Token(Token = "0x4001C20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float TimeSinceModified;

	// Token: 0x040016FF RID: 5887
	[global::Cpp2ILInjected.Token(Token = "0x4001C21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	protected GUISlider.DragState dragState;

	// Token: 0x04001700 RID: 5888
	[global::Cpp2ILInjected.Token(Token = "0x4001C22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	protected GUISlider.DrawBackingHandler backingHandler;
}
