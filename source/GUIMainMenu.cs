using System;
using System.Collections.Generic;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Graphics.Effects;
using Terraria.IO;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001CD RID: 461
[global::Cpp2ILInjected.Token(Token = "0x2000266")]
public class GUIMainMenu
{
	// Token: 0x06000C9C RID: 3228 RVA: 0x00024119 File Offset: 0x00022319
	[global::Cpp2ILInjected.Token(Token = "0x6000DB9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E4AA8", Offset = "0x9E4AA8", Length = "0x1278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeft", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(bool),
		typeof(TransactionButton_Layout[]),
		typeof(GUIContollerTransactionButtonList.SetupRegions)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_Quitting", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ClearVisualPostProcessEffects", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderExtensions), Member = "AppendInt", MemberParameters = new object[]
	{
		typeof(StringBuilder),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(StringBuilder)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "SignInController", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ClearPendingPlayerSelectCallbacks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "DiskSpace", ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMainMenu), Member = "SelectMultiplayer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAchievementsMenu), Member = "Open", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TutorialLevel), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_myPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldFile), Member = "GetTutorialMetadata", ReturnType = typeof(WorldFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "playWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMainMenu), Member = "OpenPurchaseGame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "SetCategory", MemberParameters = new object[] { typeof(SettingsOverlayOptionCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Activate", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(object[])
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyDown", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuitConfirm), Member = "Open", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 85)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0002411C File Offset: 0x0002231C
	[global::Cpp2ILInjected.Token(Token = "0x6000DBA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E5FF0", Offset = "0x9E5FF0", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void OpenPurchaseGame()
	{
		throw null;
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0002411F File Offset: 0x0002231F
	[global::Cpp2ILInjected.Token(Token = "0x6000DBB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E5D20", Offset = "0x9E5D20", Length = "0x2D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "UpdateUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Liquid), Member = "ReInit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.User), Member = "get_HasMultiplayerPermissions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPS4MultiplayerChecks), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ClearPendingPlayerSelectCallbacks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "DiskSpace", ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Stadia.User), Member = "ShowMultiplayerRestrictionOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public void SelectMultiplayer()
	{
		throw null;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00024122 File Offset: 0x00022322
	[global::Cpp2ILInjected.Token(Token = "0x6000DBC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E6058", Offset = "0x9E6058", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIMainMenu()
	{
		throw null;
	}

	// Token: 0x04001463 RID: 5219
	[global::Cpp2ILInjected.Token(Token = "0x400195C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x04001464 RID: 5220
	[global::Cpp2ILInjected.Token(Token = "0x400195D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x04001465 RID: 5221
	[global::Cpp2ILInjected.Token(Token = "0x400195E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;

	// Token: 0x04001466 RID: 5222
	[global::Cpp2ILInjected.Token(Token = "0x400195F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float scale3;

	// Token: 0x04001467 RID: 5223
	[global::Cpp2ILInjected.Token(Token = "0x4001960")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float scale4;

	// Token: 0x04001468 RID: 5224
	[global::Cpp2ILInjected.Token(Token = "0x4001961")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float scale5;

	// Token: 0x04001469 RID: 5225
	[global::Cpp2ILInjected.Token(Token = "0x4001962")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIContollerTransactionButtonList _controllerList;

	// Token: 0x0400146A RID: 5226
	[global::Cpp2ILInjected.Token(Token = "0x4001963")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIContollerTransactionButtonList _controllerListTrial;
}
