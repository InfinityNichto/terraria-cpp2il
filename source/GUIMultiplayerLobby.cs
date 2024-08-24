using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Graphics;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001D1 RID: 465
[global::Cpp2ILInjected.Token(Token = "0x200026A")]
public class GUIMultiplayerLobby
{
	// Token: 0x06000CC1 RID: 3265 RVA: 0x00024188 File Offset: 0x00022388
	[global::Cpp2ILInjected.Token(Token = "0x6000DDE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EB660", Offset = "0x9EB660", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0002418B File Offset: 0x0002238B
	[global::Cpp2ILInjected.Token(Token = "0x17000179")]
	private GUIContollerTransactionButtonList MultiplayerLobbyOptionsController
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000DDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9EB724", Offset = "0x9EB724", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContollerTransactionButtonList), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(TransactionButton_Layout[]),
			typeof(GUIContollerTransactionButtonList.SetupRegions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0002418E File Offset: 0x0002238E
	[global::Cpp2ILInjected.Token(Token = "0x6000DE0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EB83C", Offset = "0x9EB83C", Length = "0x314")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawPlatformFriends", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawCategoryButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawDedicated", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawLocal", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_menuMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00024191 File Offset: 0x00022391
	[global::Cpp2ILInjected.Token(Token = "0x6000DE1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EBC0C", Offset = "0x9EBC0C", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
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
	private void DrawPlatformFriends()
	{
		throw null;
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00024194 File Offset: 0x00022394
	[global::Cpp2ILInjected.Token(Token = "0x6000DE2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EBC84", Offset = "0x9EBC84", Length = "0x320")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PreviousPagePressed", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMultiplayerLobby), Member = "Activate", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void DrawCategoryButtons()
	{
		throw null;
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00024197 File Offset: 0x00022397
	[global::Cpp2ILInjected.Token(Token = "0x6000DE3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EB574", Offset = "0x9EB574", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteDedicatedServer), Member = "Delete", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteDedicatedServer), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "QuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SelectPlayer", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerAutoFinder), Member = "StartSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Startup()
	{
		throw null;
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0002419A File Offset: 0x0002239A
	[global::Cpp2ILInjected.Token(Token = "0x6000DE4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ED4C0", Offset = "0x9ED4C0", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "JoinServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "StartNewServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "AddDedicatedServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "PlayerSelected", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerAutoFinder), Member = "StopSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0002419D File Offset: 0x0002239D
	[global::Cpp2ILInjected.Token(Token = "0x6000DE5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EBFA4", Offset = "0x9EBFA4", Length = "0x9B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "RefreshLocalServers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "CheckDiskSpace", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "DisabledClipping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "StartNewServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
	private void DrawLocal()
	{
		throw null;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x000241A0 File Offset: 0x000223A0
	[global::Cpp2ILInjected.Token(Token = "0x6000DE6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ED0C4", Offset = "0x9ED0C4", Length = "0x3FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "SaveRecent", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "RefreshDedicatedServers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "DisabledClipping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void DrawOptions()
	{
		throw null;
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x000241A3 File Offset: 0x000223A3
	[global::Cpp2ILInjected.Token(Token = "0x6000DE7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EC954", Offset = "0x9EC954", Length = "0x594")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "RefreshDedicatedServers", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "CheckDiskSpace", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "DisabledClipping", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "AddDedicatedServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	private void DrawDedicated()
	{
		throw null;
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x000241A6 File Offset: 0x000223A6
	[global::Cpp2ILInjected.Token(Token = "0x6000DE8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ED510", Offset = "0x9ED510", Length = "0x37C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawLocal", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerAutoFinder), Member = "UpdateResults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void RefreshLocalServers()
	{
		throw null;
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x000241A9 File Offset: 0x000223A9
	[global::Cpp2ILInjected.Token(Token = "0x6000DE9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ED9D0", Offset = "0x9ED9D0", Length = "0x400")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawDedicated", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<GUIMultiplayerLobby.ServerInformation>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<GUIMultiplayerLobby.ServerInformation>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void RefreshDedicatedServers()
	{
		throw null;
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x000241AC File Offset: 0x000223AC
	[global::Cpp2ILInjected.Token(Token = "0x6000DEA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EDE8C", Offset = "0x9EDE8C", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawServer", MemberParameters = new object[] { typeof(GUIMultiplayerLobby.ServerInformation) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureManager), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private Microsoft.Xna.Framework.Graphics.Texture2D GetIcon(GUIMultiplayerLobby.ServerInformation serverData)
	{
		throw null;
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x000241AF File Offset: 0x000223AF
	[global::Cpp2ILInjected.Token(Token = "0x6000DEB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EDF94", Offset = "0x9EDF94", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "ServerDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "GetIcon", MemberParameters = new object[] { typeof(GUIMultiplayerLobby.ServerInformation) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawBacking", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Rectangle?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void DrawServer(GUIMultiplayerLobby.ServerInformation serverData)
	{
		throw null;
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x000241B2 File Offset: 0x000223B2
	[global::Cpp2ILInjected.Token(Token = "0x6000DEC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EE124", Offset = "0x9EE124", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowMemoryPopup), Member = "CheckMemoryAction", MemberParameters = new object[]
	{
		typeof(GUILowMemoryPopup.MemoryAction),
		typeof(Action)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "JoinServer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void JoinServerCheck()
	{
		throw null;
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x000241B5 File Offset: 0x000223B5
	[global::Cpp2ILInjected.Token(Token = "0x6000DED")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EE56C", Offset = "0x9EE56C", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Microsoft.Xna.Framework.Vector2 ServerItemSize(int index)
	{
		throw null;
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x000241B8 File Offset: 0x000223B8
	[global::Cpp2ILInjected.Token(Token = "0x6000DEE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EE5E0", Offset = "0x9EE5E0", Length = "0x9D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(float?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "DrawServer", MemberParameters = new object[] { typeof(GUIMultiplayerLobby.ServerInformation) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby.ServerInformation), Member = "get_WorldSize", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "CheckDiskSpace", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
	private void ServerDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x000241BB File Offset: 0x000223BB
	[global::Cpp2ILInjected.Token(Token = "0x6000DEF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF098", Offset = "0x9EF098", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void OpenPlatformInvite()
	{
		throw null;
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x000241BE File Offset: 0x000223BE
	[global::Cpp2ILInjected.Token(Token = "0x6000DF0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ECEE8", Offset = "0x9ECEE8", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Back", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void DrawMainButtons()
	{
		throw null;
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x000241C1 File Offset: 0x000223C1
	[global::Cpp2ILInjected.Token(Token = "0x6000DF1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EBB50", Offset = "0x9EBB50", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
	private void Back()
	{
		throw null;
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x000241C4 File Offset: 0x000223C4
	[global::Cpp2ILInjected.Token(Token = "0x6000DF2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF09C", Offset = "0x9EF09C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float ServerScale(int index)
	{
		throw null;
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x000241C7 File Offset: 0x000223C7
	[global::Cpp2ILInjected.Token(Token = "0x6000DF3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF0A4", Offset = "0x9EF0A4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void ServerOver(int index)
	{
		throw null;
	}

	// Token: 0x06000CD7 RID: 3287 RVA: 0x000241CA File Offset: 0x000223CA
	[global::Cpp2ILInjected.Token(Token = "0x6000DF4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF0AC", Offset = "0x9EF0AC", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteDedicatedServer), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteDedicatedServer), Member = "Delete", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIMultiplayerLobby.ServerInformation ActiveServer()
	{
		throw null;
	}

	// Token: 0x06000CD8 RID: 3288 RVA: 0x000241CD File Offset: 0x000223CD
	[global::Cpp2ILInjected.Token(Token = "0x6000DF5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EE218", Offset = "0x9EE218", Length = "0x354")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "JoinServerCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "SetRemoteIP", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MPSessionManager), Member = "CreateNewDirectSession", MemberParameters = new object[]
	{
		typeof(PlatformUser),
		typeof(MPSessionManager.LobbyState),
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(MPSession))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "StartTcpClient", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void JoinServer()
	{
		throw null;
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x000241D0 File Offset: 0x000223D0
	[global::Cpp2ILInjected.Token(Token = "0x6000DF6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ED88C", Offset = "0x9ED88C", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawLocal", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "PlayerSelected", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILowDiskSpacePopup), Member = "CheckDiskSpace", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void StartNewServer()
	{
		throw null;
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x000241D3 File Offset: 0x000223D3
	[global::Cpp2ILInjected.Token(Token = "0x6000DF7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EDDD0", Offset = "0x9EDDD0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawDedicated", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void AddDedicatedServer()
	{
		throw null;
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x000241D6 File Offset: 0x000223D6
	[global::Cpp2ILInjected.Token(Token = "0x6000DF8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF124", Offset = "0x9EF124", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	private int SortEntry(GUIMultiplayerLobby.ServerInformation a, GUIMultiplayerLobby.ServerInformation b)
	{
		throw null;
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x000241D9 File Offset: 0x000223D9
	[global::Cpp2ILInjected.Token(Token = "0x6000DF9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF15C", Offset = "0x9EF15C", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public int CompareNatural(string strA, string strB)
	{
		throw null;
	}

	// Token: 0x06000CDD RID: 3293 RVA: 0x000241DC File Offset: 0x000223DC
	[global::Cpp2ILInjected.Token(Token = "0x6000DFA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF1D0", Offset = "0x9EF1D0", Length = "0x794")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "GetNumericValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		throw null;
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x000241DF File Offset: 0x000223DF
	[global::Cpp2ILInjected.Token(Token = "0x6000DFB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9EF964", Offset = "0x9EF964", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMultiplayerLobby), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIMultiplayerLobby.ServerInformation>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public GUIMultiplayerLobby()
	{
		throw null;
	}

	// Token: 0x04001485 RID: 5253
	[global::Cpp2ILInjected.Token(Token = "0x400197E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIMultiplayerLobby.ItemSelection CurrentSelection;

	// Token: 0x04001486 RID: 5254
	[global::Cpp2ILInjected.Token(Token = "0x400197F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public bool NoPlatformFriends;

	// Token: 0x04001487 RID: 5255
	[global::Cpp2ILInjected.Token(Token = "0x4001980")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float localScale;

	// Token: 0x04001488 RID: 5256
	[global::Cpp2ILInjected.Token(Token = "0x4001981")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float dedicatedScale;

	// Token: 0x04001489 RID: 5257
	[global::Cpp2ILInjected.Token(Token = "0x4001982")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float joinButtonScale;

	// Token: 0x0400148A RID: 5258
	[global::Cpp2ILInjected.Token(Token = "0x4001983")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float backButtonScale;

	// Token: 0x0400148B RID: 5259
	[global::Cpp2ILInjected.Token(Token = "0x4001984")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float NewScale;

	// Token: 0x0400148C RID: 5260
	[global::Cpp2ILInjected.Token(Token = "0x4001985")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float TitleScale;

	// Token: 0x0400148D RID: 5261
	[global::Cpp2ILInjected.Token(Token = "0x4001986")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float DeleteScale;

	// Token: 0x0400148E RID: 5262
	[global::Cpp2ILInjected.Token(Token = "0x4001987")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int previousMenu;

	// Token: 0x0400148F RID: 5263
	[global::Cpp2ILInjected.Token(Token = "0x4001988")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private DateTime LastSelectTime;

	// Token: 0x04001490 RID: 5264
	[global::Cpp2ILInjected.Token(Token = "0x4001989")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04001491 RID: 5265
	[global::Cpp2ILInjected.Token(Token = "0x400198A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float ScrollOffset;

	// Token: 0x04001492 RID: 5266
	[global::Cpp2ILInjected.Token(Token = "0x400198B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float ScrollMomentum;

	// Token: 0x04001493 RID: 5267
	[global::Cpp2ILInjected.Token(Token = "0x400198C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private int ScrollDragging;

	// Token: 0x04001494 RID: 5268
	[global::Cpp2ILInjected.Token(Token = "0x400198D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04001495 RID: 5269
	[global::Cpp2ILInjected.Token(Token = "0x400198E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private Rectangle SelectedItemRegion;

	// Token: 0x04001496 RID: 5270
	[global::Cpp2ILInjected.Token(Token = "0x400198F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private bool serverJoinAvailable;

	// Token: 0x04001497 RID: 5271
	[global::Cpp2ILInjected.Token(Token = "0x4001990")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int SelectedServerRealID;

	// Token: 0x04001498 RID: 5272
	[global::Cpp2ILInjected.Token(Token = "0x4001991")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x04001499 RID: 5273
	[global::Cpp2ILInjected.Token(Token = "0x4001992")]
	private static Microsoft.Xna.Framework.Graphics.Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x0400149A RID: 5274
	[global::Cpp2ILInjected.Token(Token = "0x4001993")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private GUIControllerMultiplayerLobby _controllerInput;

	// Token: 0x0400149B RID: 5275
	[global::Cpp2ILInjected.Token(Token = "0x4001994")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private GUIContollerTransactionButtonList _multiplayerLobbyOptionsController;

	// Token: 0x0400149C RID: 5276
	[global::Cpp2ILInjected.Token(Token = "0x4001995")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int selectedServer;

	// Token: 0x0400149D RID: 5277
	[global::Cpp2ILInjected.Token(Token = "0x4001996")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public List<GUIMultiplayerLobby.ServerInformation> serverList;

	// Token: 0x0400149E RID: 5278
	[global::Cpp2ILInjected.Token(Token = "0x4001997")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private Rectangle fullClipRegion;

	// Token: 0x0400149F RID: 5279
	[global::Cpp2ILInjected.Token(Token = "0x4001998")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private Rectangle dragClipRegion;

	// Token: 0x040014A0 RID: 5280
	[global::Cpp2ILInjected.Token(Token = "0x4001999")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private int serverOver;

	// Token: 0x020007FA RID: 2042
	[global::Cpp2ILInjected.Token(Token = "0x200026B")]
	public enum ItemSelection
	{
		// Token: 0x04007CC4 RID: 31940
		[global::Cpp2ILInjected.Token(Token = "0x400199B")]
		Local,
		// Token: 0x04007CC5 RID: 31941
		[global::Cpp2ILInjected.Token(Token = "0x400199C")]
		Dedicated
	}

	// Token: 0x020007FB RID: 2043
	[global::Cpp2ILInjected.Token(Token = "0x200026C")]
	public struct ServerInformation
	{
		// Token: 0x060048F0 RID: 18672 RVA: 0x0002EF25 File Offset: 0x0002D125
		[global::Cpp2ILInjected.Token(Token = "0x6000DFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9EDE28", Offset = "0x9EDE28", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ServerInformation(string worldName, string hostName, string serverIPText, int port, int players, int maxPlayers, int worldWidth, bool corruption, short gameMode, bool hardMode, bool active = true, bool favorite = false, int realID = 0, MPSession existingSession = null)
		{
			throw null;
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060048F1 RID: 18673 RVA: 0x0002EF28 File Offset: 0x0002D128
		[global::Cpp2ILInjected.Token(Token = "0x1700017A")]
		public string WorldSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x9EEFB8", Offset = "0x9EEFB8", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "ServerDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Microsoft.Xna.Framework.Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04007CC6 RID: 31942
		[global::Cpp2ILInjected.Token(Token = "0x400199D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int RealID;

		// Token: 0x04007CC7 RID: 31943
		[global::Cpp2ILInjected.Token(Token = "0x400199E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string WorldName;

		// Token: 0x04007CC8 RID: 31944
		[global::Cpp2ILInjected.Token(Token = "0x400199F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int CurrentPlayers;

		// Token: 0x04007CC9 RID: 31945
		[global::Cpp2ILInjected.Token(Token = "0x40019A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int MaxPlayers;

		// Token: 0x04007CCA RID: 31946
		[global::Cpp2ILInjected.Token(Token = "0x40019A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int WorldWidth;

		// Token: 0x04007CCB RID: 31947
		[global::Cpp2ILInjected.Token(Token = "0x40019A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public bool HasCorruption;

		// Token: 0x04007CCC RID: 31948
		[global::Cpp2ILInjected.Token(Token = "0x40019A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E")]
		public short GameMode;

		// Token: 0x04007CCD RID: 31949
		[global::Cpp2ILInjected.Token(Token = "0x40019A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool IsHardMode;

		// Token: 0x04007CCE RID: 31950
		[global::Cpp2ILInjected.Token(Token = "0x40019A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string ServerIPText;

		// Token: 0x04007CCF RID: 31951
		[global::Cpp2ILInjected.Token(Token = "0x40019A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int ServerPort;

		// Token: 0x04007CD0 RID: 31952
		[global::Cpp2ILInjected.Token(Token = "0x40019A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public string HostName;

		// Token: 0x04007CD1 RID: 31953
		[global::Cpp2ILInjected.Token(Token = "0x40019A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool Active;

		// Token: 0x04007CD2 RID: 31954
		[global::Cpp2ILInjected.Token(Token = "0x40019A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool Favorite;

		// Token: 0x04007CD3 RID: 31955
		[global::Cpp2ILInjected.Token(Token = "0x40019AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public MPSession ExistingSession;
	}
}
