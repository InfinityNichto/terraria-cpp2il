using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using UnityEngine;

// Token: 0x02000102 RID: 258
[global::Cpp2ILInjected.Token(Token = "0x2000171")]
public class GUISettingsPauseMenu
{
	// Token: 0x06000975 RID: 2421 RVA: 0x000237A4 File Offset: 0x000219A4
	[global::Cpp2ILInjected.Token(Token = "0x6000A75")]
	[global::Cpp2ILInjected.Address(RVA = "0x998DCC", Offset = "0x998DCC", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void SetupCreavieModeOffset(bool setup)
	{
		throw null;
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x000237A7 File Offset: 0x000219A7
	[global::Cpp2ILInjected.Token(Token = "0x6000A76")]
	[global::Cpp2ILInjected.Address(RVA = "0x998E74", Offset = "0x998E74", Length = "0xDCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_GameMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList.SetupRegions), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(bool),
		typeof(TransactionButton_Layout[]),
		typeof(GUIContollerTransactionButtonList.SetupRegions)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsPauseMenu), Member = "SetupCreavieModeOffset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ingameOptionsWindow", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SaveAndQuit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "Hide", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "CaptureUICrusorDrag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "Open", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIJourneyModeSettings), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIJourneyModeSettings.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x000237AA File Offset: 0x000219AA
	[global::Cpp2ILInjected.Token(Token = "0x6000A77")]
	[global::Cpp2ILInjected.Address(RVA = "0x999C64", Offset = "0x999C64", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUISettingsPauseMenu()
	{
		throw null;
	}

	// Token: 0x040007AB RID: 1963
	[global::Cpp2ILInjected.Token(Token = "0x4000A5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool Enabled;

	// Token: 0x040007AC RID: 1964
	[global::Cpp2ILInjected.Token(Token = "0x4000A5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private GUIContollerTransactionButtonList _controllerList;

	// Token: 0x040007AD RID: 1965
	[global::Cpp2ILInjected.Token(Token = "0x4000A60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float settingsScale;

	// Token: 0x040007AE RID: 1966
	[global::Cpp2ILInjected.Token(Token = "0x4000A61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float HomeButtonScale;

	// Token: 0x040007AF RID: 1967
	[global::Cpp2ILInjected.Token(Token = "0x4000A62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float AchievementsButtonScale;

	// Token: 0x040007B0 RID: 1968
	[global::Cpp2ILInjected.Token(Token = "0x4000A63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float BestiaryButtonScale;

	// Token: 0x040007B1 RID: 1969
	[global::Cpp2ILInjected.Token(Token = "0x4000A64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float JourneySettingsButtonScale;

	// Token: 0x040007B2 RID: 1970
	[global::Cpp2ILInjected.Token(Token = "0x4000A65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float CloseButtonScale;

	// Token: 0x040007B3 RID: 1971
	[global::Cpp2ILInjected.Token(Token = "0x4000A66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private bool creativeModeActive;
}
