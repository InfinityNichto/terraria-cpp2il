﻿using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using Terraria.UI;
using UnityEngine;

// Token: 0x0200004D RID: 77
[global::Cpp2ILInjected.Token(Token = "0x2000073")]
public class GUIControllerMappingEntry : GUIControllerMappingEntryBase
{
	// Token: 0x060001E7 RID: 487 RVA: 0x00022106 File Offset: 0x00020306
	[global::Cpp2ILInjected.Token(Token = "0x600027A")]
	[global::Cpp2ILInjected.Address(RVA = "0x711918", Offset = "0x711918", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetCategory", MemberParameters = new object[] { typeof(ControllerMappingsCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref ControllerMappingsCategories_Layout.Category),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerMappingEntry(ControllerActionVector action, GUIControllerMappingStateTable table)
	{
		throw null;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00022109 File Offset: 0x00020309
	[global::Cpp2ILInjected.Token(Token = "0x600027B")]
	[global::Cpp2ILInjected.Address(RVA = "0x7119A4", Offset = "0x7119A4", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetCategory", MemberParameters = new object[] { typeof(ControllerMappingsCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref ControllerMappingsCategories_Layout.Category),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerMappingEntry(ControllerActionButton buttonMapping, GUIControllerMappingStateTable table)
	{
		throw null;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x0002210C File Offset: 0x0002030C
	[global::Cpp2ILInjected.Token(Token = "0x17000075")]
	public bool HasMapping
	{
		[global::Cpp2ILInjected.Token(Token = "0x600027C")]
		[global::Cpp2ILInjected.Address(RVA = "0x711A2C", Offset = "0x711A2C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMapping", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
		get
		{
			throw null;
		}
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0002210F File Offset: 0x0002030F
	[global::Cpp2ILInjected.Token(Token = "0x600027D")]
	[global::Cpp2ILInjected.Address(RVA = "0x711A54", Offset = "0x711A54", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00022112 File Offset: 0x00020312
	[global::Cpp2ILInjected.Token(Token = "0x600027E")]
	[global::Cpp2ILInjected.Address(RVA = "0x711A7C", Offset = "0x711A7C", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearMapping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "RemoveAxisBindings", MemberParameters = new object[] { typeof(ControllerActionVector) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "RemoveButtonBindings", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	public void RemoveBinding()
	{
		throw null;
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00022115 File Offset: 0x00020315
	[global::Cpp2ILInjected.Token(Token = "0x600027F")]
	[global::Cpp2ILInjected.Address(RVA = "0x711AB4", Offset = "0x711AB4", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindAxis", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(Axis),
		typeof(Axis),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	private void RemoveAxisBindings(ControllerActionVector actionAxis)
	{
		throw null;
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00022118 File Offset: 0x00020318
	[global::Cpp2ILInjected.Token(Token = "0x6000280")]
	[global::Cpp2ILInjected.Address(RVA = "0x711B4C", Offset = "0x711B4C", Length = "0x16C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "RemoveAxisBindings", MemberParameters = new object[] { typeof(ControllerActionVector) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "ClearLinkedAxisBindings", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Axis),
		typeof(Axis),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "GetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerMappingState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void RebindAxis(ControllerActionVector actionAxis, Axis x, Axis y, int stateIndex)
	{
		throw null;
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0002211B File Offset: 0x0002031B
	[global::Cpp2ILInjected.Token(Token = "0x6000281")]
	[global::Cpp2ILInjected.Address(RVA = "0x711CB8", Offset = "0x711CB8", Length = "0x6FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "RemoveButtonBindings", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "ClearLinkedButtonBindings", MemberParameters = new object[]
	{
		typeof(int),
		typeof(AxisButtons),
		typeof(List<ControllerActionButton>),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "GetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerMappingState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private void RebindButton(ControllerActionButton actionButton, AxisButtons axisButton, int stateIndex)
	{
		throw null;
	}

	// Token: 0x060001EF RID: 495 RVA: 0x0002211E File Offset: 0x0002031E
	[global::Cpp2ILInjected.Token(Token = "0x6000282")]
	[global::Cpp2ILInjected.Address(RVA = "0x7123B4", Offset = "0x7123B4", Length = "0x6DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "RemoveButtonBindings", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "ClearLinkedButtonBindings", MemberParameters = new object[]
	{
		typeof(int),
		typeof(Buttons),
		typeof(List<ControllerActionButton>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "GetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GUIControllerMappingState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private void RebindButton(ControllerActionButton actionButton, Buttons axisButton, int stateIndex)
	{
		throw null;
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00022121 File Offset: 0x00020321
	[global::Cpp2ILInjected.Token(Token = "0x6000283")]
	[global::Cpp2ILInjected.Address(RVA = "0x712A90", Offset = "0x712A90", Length = "0xCB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get__gridItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingEntryBase),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "GetTitle", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxis", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_HasMappingExcludeLinked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "get_RequiredStateExcludeLinked", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromButton", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(GUIControllerInputButton.LinkedControlType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "FromAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float)
	}, ReturnType = typeof(GUIControllerInputButton.AxisControl))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetAxisTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonState", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "RebindAxis", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(Axis),
		typeof(Axis),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "InvalidateTooltips", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "RefreshConfigurationState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetAxisThreshold", MemberParameters = new object[]
	{
		typeof(AxisButtons),
		typeof(ref float)
	}, ReturnType = typeof(Axis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonUp", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "ButtonTime", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(AxisButtons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(Buttons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00022124 File Offset: 0x00020324
	[global::Cpp2ILInjected.Token(Token = "0x6000284")]
	[global::Cpp2ILInjected.Address(RVA = "0x713BF0", Offset = "0x713BF0", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00022127 File Offset: 0x00020327
	[global::Cpp2ILInjected.Token(Token = "0x6000285")]
	[global::Cpp2ILInjected.Address(RVA = "0x713C40", Offset = "0x713C40", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x0002212A File Offset: 0x0002032A
	[global::Cpp2ILInjected.Token(Token = "0x6000286")]
	[global::Cpp2ILInjected.Address(RVA = "0x7137F4", Offset = "0x7137F4", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private string GetTitle()
	{
		throw null;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0002212D File Offset: 0x0002032D
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000287")]
	[global::Cpp2ILInjected.Address(RVA = "0x713D04", Offset = "0x713D04", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static GUIControllerMappingEntry()
	{
		throw null;
	}

	// Token: 0x04000140 RID: 320
	[global::Cpp2ILInjected.Token(Token = "0x4000237")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private GUIControllerMappingStateTable Table;

	// Token: 0x04000141 RID: 321
	[global::Cpp2ILInjected.Token(Token = "0x4000238")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private ControllerActionVector vector;

	// Token: 0x04000142 RID: 322
	[global::Cpp2ILInjected.Token(Token = "0x4000239")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private ControllerActionButton button;

	// Token: 0x04000143 RID: 323
	[global::Cpp2ILInjected.Token(Token = "0x400023A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private GUIControllerMappingState _state;

	// Token: 0x04000144 RID: 324
	[global::Cpp2ILInjected.Token(Token = "0x400023B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private float buttonScale;

	// Token: 0x04000145 RID: 325
	[global::Cpp2ILInjected.Token(Token = "0x400023C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float scale;

	// Token: 0x04000146 RID: 326
	[global::Cpp2ILInjected.Token(Token = "0x400023D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool drawingOverlay;

	// Token: 0x04000147 RID: 327
	[global::Cpp2ILInjected.Token(Token = "0x400023E")]
	private static int LastButtonMapped;

	// Token: 0x04000148 RID: 328
	[global::Cpp2ILInjected.Token(Token = "0x400023F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
	public bool displayOptions;

	// Token: 0x04000149 RID: 329
	[global::Cpp2ILInjected.Token(Token = "0x4000240")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private GUIInputRegionExclusive _optionsBlocker;
}