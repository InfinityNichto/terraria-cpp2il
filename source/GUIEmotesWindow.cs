﻿using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using ReLogic.Reflection;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.Initializers;
using Terraria.Localization;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200013C")]
public class GUIEmotesWindow
{
	[global::Cpp2ILInjected.Token(Token = "0x6000860")]
	[global::Cpp2ILInjected.Address(RVA = "0x726A80", Offset = "0x726A80", Length = "0x208")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public static void LoadContent(ContentManager content)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000861")]
	[global::Cpp2ILInjected.Address(RVA = "0x726C88", Offset = "0x726C88", Length = "0x16C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "EmoteOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = "CloseDialoguesAndPopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "CloseChat", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "DrawNotification", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerChat), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OnCategoryClosed", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInstance), Member = "CloseDialoguesAndPopups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void SetDisplayingEmotes(bool value)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000862")]
	[global::Cpp2ILInjected.Address(RVA = "0x726ED4", Offset = "0x726ED4", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Panel_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsOver(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000863")]
	[global::Cpp2ILInjected.Address(RVA = "0x726DF4", Offset = "0x726DF4", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetDisplayingEmotes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerChat), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesGeneral", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesRPS", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesItems", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesBiomesAndEvents", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesTownNPCs", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesCritters", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetEmotesBosses", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void SetCategory(GUIEmotesWindow.Category cat)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000864")]
	[global::Cpp2ILInjected.Address(RVA = "0x726FA8", Offset = "0x726FA8", Length = "0xA4C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void GetEmotesGeneral(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000865")]
	[global::Cpp2ILInjected.Address(RVA = "0x7279F4", Offset = "0x7279F4", Length = "0x254")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void GetEmotesRPS(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000866")]
	[global::Cpp2ILInjected.Address(RVA = "0x727C48", Offset = "0x727C48", Length = "0x840")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void GetEmotesItems(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000867")]
	[global::Cpp2ILInjected.Address(RVA = "0x728488", Offset = "0x728488", Length = "0x840")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void GetEmotesBiomesAndEvents(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000868")]
	[global::Cpp2ILInjected.Address(RVA = "0x728CC8", Offset = "0x728CC8", Length = "0xAA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void GetEmotesTownNPCs(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000869")]
	[global::Cpp2ILInjected.Address(RVA = "0x729770", Offset = "0x729770", Length = "0x5A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void GetEmotesCritters(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600086A")]
	[global::Cpp2ILInjected.Address(RVA = "0x729D18", Offset = "0x729D18", Length = "0xC98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "get_DownedInvasionAnyDifficulty", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	private void GetEmotesBosses(List<int> emotes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600086B")]
	[global::Cpp2ILInjected.Address(RVA = "0x72A9B0", Offset = "0x72A9B0", Length = "0x270")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawPlayerChat", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "DrawEntries", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "DrawCategories", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "SetDisplayingEmotes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void Draw()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600086C")]
	[global::Cpp2ILInjected.Address(RVA = "0x72AC20", Offset = "0x72AC20", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void DrawBacking()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600086D")]
	[global::Cpp2ILInjected.Address(RVA = "0x72ACE8", Offset = "0x72ACE8", Length = "0x1D8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "Draw", ReturnType = typeof(void))]
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
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	private void DrawEntries()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600086E")]
	[global::Cpp2ILInjected.Address(RVA = "0x72AEC0", Offset = "0x72AEC0", Length = "0x714")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "SetCategory", MemberParameters = new object[] { typeof(GUIEmotesWindow.Category) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "LoadButtonRegion", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(float)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	private void DrawCategories()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600086F")]
	[global::Cpp2ILInjected.Address(RVA = "0x72B5D4", Offset = "0x72B5D4", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float EmoteScale(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000870")]
	[global::Cpp2ILInjected.Address(RVA = "0x72B618", Offset = "0x72B618", Length = "0x37C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileChatMonitor), Member = "NewText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte),
		typeof(byte),
		typeof(byte)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldUIAnchor), Member = ".ctor", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "NewBubble", MemberParameters = new object[]
	{
		typeof(int),
		typeof(WorldUIAnchor),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmoteBubble), Member = "CheckForNPCsToReactToEmoteBubble", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Player)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(NetworkText),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "SetDisplayingEmotes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	public void EmoteOver(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000871")]
	[global::Cpp2ILInjected.Address(RVA = "0x72B994", Offset = "0x72B994", Length = "0x84C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "GetFrame", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
	public void EmoteDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000872")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C1E0", Offset = "0x72C1E0", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "EmoteDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
	{
		typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private Rectangle GetFrame(int emoteIndex)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000873")]
	[global::Cpp2ILInjected.Address(RVA = "0x72C2D8", Offset = "0x72C2D8", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public GUIEmotesWindow()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000734")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public List<int> _emoteEntries;

	[global::Cpp2ILInjected.Token(Token = "0x4000735")]
	private static Asset<Microsoft.Xna.Framework.Graphics.Texture2D> _emoteTexture;

	[global::Cpp2ILInjected.Token(Token = "0x4000736")]
	private static Asset<Microsoft.Xna.Framework.Graphics.Texture2D> _emoteTextureBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000737")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int _frameCounter;

	[global::Cpp2ILInjected.Token(Token = "0x4000738")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private GUIEmotesWindow.Category CurrentSelection;

	[global::Cpp2ILInjected.Token(Token = "0x4000739")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float TimeSinceItemChange;

	[global::Cpp2ILInjected.Token(Token = "0x400073A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int emoteOver;

	[global::Cpp2ILInjected.Token(Token = "0x400073B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool DisplayingEmotes;

	[global::Cpp2ILInjected.Token(Token = "0x400073C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIInputRegionExclusive PickingInterceptor;

	[global::Cpp2ILInjected.Token(Token = "0x400073D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float EmotesCloseScale;

	[global::Cpp2ILInjected.Token(Token = "0x400073E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private float emotesGeneralScale;

	[global::Cpp2ILInjected.Token(Token = "0x400073F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float emotesRPSScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000740")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float emotesItemsScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000741")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private float emotesBiomesAndEventsScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000742")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float emotesTownNPCsScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000743")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private float emotesCrittersScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000744")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float emotesBossesScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000745")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float emoteScrollOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000746")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private float emoteScrollMomentum;

	[global::Cpp2ILInjected.Token(Token = "0x4000747")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private int emoteScrollDragging;

	[global::Cpp2ILInjected.Token(Token = "0x4000748")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private Microsoft.Xna.Framework.Vector2 emoteDragOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000749")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private float TitleScale;

	[global::Cpp2ILInjected.Token(Token = "0x200013D")]
	public enum Category
	{
		[global::Cpp2ILInjected.Token(Token = "0x400074B")]
		General,
		[global::Cpp2ILInjected.Token(Token = "0x400074C")]
		RPS,
		[global::Cpp2ILInjected.Token(Token = "0x400074D")]
		Items,
		[global::Cpp2ILInjected.Token(Token = "0x400074E")]
		BiomesAndEvents,
		[global::Cpp2ILInjected.Token(Token = "0x400074F")]
		TownNPCs,
		[global::Cpp2ILInjected.Token(Token = "0x4000750")]
		Critters,
		[global::Cpp2ILInjected.Token(Token = "0x4000751")]
		Bosses
	}
}
