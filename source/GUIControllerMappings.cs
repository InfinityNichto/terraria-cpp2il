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
using Terraria.IO;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200004F RID: 79
[global::Cpp2ILInjected.Token(Token = "0x2000075")]
public class GUIControllerMappings
{
	// Token: 0x060001F6 RID: 502 RVA: 0x00022133 File Offset: 0x00020333
	[global::Cpp2ILInjected.Token(Token = "0x6000289")]
	[global::Cpp2ILInjected.Address(RVA = "0x713D50", Offset = "0x713D50", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "ClearMappings", ReturnType = typeof(void))]
	public void ClearMappingStates()
	{
		throw null;
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00022136 File Offset: 0x00020336
	[global::Cpp2ILInjected.Token(Token = "0x600028A")]
	[global::Cpp2ILInjected.Address(RVA = "0x713D74", Offset = "0x713D74", Length = "0x2D0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "Clear", ReturnType = typeof(void))]
	private void ClearWorldMappings()
	{
		throw null;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00022139 File Offset: 0x00020339
	[global::Cpp2ILInjected.Token(Token = "0x600028B")]
	[global::Cpp2ILInjected.Address(RVA = "0x714044", Offset = "0x714044", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "Clear", ReturnType = typeof(void))]
	private void ClearInventoryMappings()
	{
		throw null;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0002213C File Offset: 0x0002033C
	[global::Cpp2ILInjected.Token(Token = "0x600028C")]
	[global::Cpp2ILInjected.Address(RVA = "0x714224", Offset = "0x714224", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "Backup", ReturnType = typeof(void))]
	public void Backup()
	{
		throw null;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0002213F File Offset: 0x0002033F
	[global::Cpp2ILInjected.Token(Token = "0x600028D")]
	[global::Cpp2ILInjected.Address(RVA = "0x715304", Offset = "0x715304", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "ShutdownUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	public void RestoreBackup()
	{
		throw null;
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00022142 File Offset: 0x00020342
	[global::Cpp2ILInjected.Token(Token = "0x600028E")]
	[global::Cpp2ILInjected.Address(RVA = "0x7153E4", Offset = "0x7153E4", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void ClearMapping()
	{
		throw null;
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00022145 File Offset: 0x00020345
	[global::Cpp2ILInjected.Token(Token = "0x600028F")]
	[global::Cpp2ILInjected.Address(RVA = "0x713748", Offset = "0x713748", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPulldownEntry), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUIPulldownSetting),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
		throw null;
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00022148 File Offset: 0x00020348
	[global::Cpp2ILInjected.Token(Token = "0x6000290")]
	[global::Cpp2ILInjected.Address(RVA = "0x7154A8", Offset = "0x7154A8", Length = "0x2CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "GainFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "DrawCategoryOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "DrawTitle", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0002214B File Offset: 0x0002034B
	[global::Cpp2ILInjected.Token(Token = "0x6000291")]
	[global::Cpp2ILInjected.Address(RVA = "0x716B20", Offset = "0x716B20", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "IsOverCategories", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void LooseFocus()
	{
		throw null;
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0002214E File Offset: 0x0002034E
	[global::Cpp2ILInjected.Token(Token = "0x6000292")]
	[global::Cpp2ILInjected.Address(RVA = "0x715780", Offset = "0x715780", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x06000200 RID: 512 RVA: 0x00022151 File Offset: 0x00020351
	[global::Cpp2ILInjected.Token(Token = "0x6000293")]
	[global::Cpp2ILInjected.Address(RVA = "0x716B8C", Offset = "0x716B8C", Length = "0x150")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LooseFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00022154 File Offset: 0x00020354
	[global::Cpp2ILInjected.Token(Token = "0x6000294")]
	[global::Cpp2ILInjected.Address(RVA = "0x715EA0", Offset = "0x715EA0", Length = "0x7A0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "SetCategory", MemberParameters = new object[] { typeof(ControllerMappingsCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void DrawCategories()
	{
		throw null;
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00022157 File Offset: 0x00020357
	[global::Cpp2ILInjected.Token(Token = "0x6000295")]
	[global::Cpp2ILInjected.Address(RVA = "0x715774", Offset = "0x715774", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Close()
	{
		throw null;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0002215A File Offset: 0x0002035A
	[global::Cpp2ILInjected.Token(Token = "0x6000296")]
	[global::Cpp2ILInjected.Address(RVA = "0x716640", Offset = "0x716640", Length = "0x4E0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "ClearMapping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "RefreshConfigurationState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	private void DrawMainButtons()
	{
		throw null;
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0002215D File Offset: 0x0002035D
	[global::Cpp2ILInjected.Token(Token = "0x6000297")]
	[global::Cpp2ILInjected.Address(RVA = "0x715AE0", Offset = "0x715AE0", Length = "0x3C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private void DrawTitle()
	{
		throw null;
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00022160 File Offset: 0x00020360
	[global::Cpp2ILInjected.Token(Token = "0x6000298")]
	[global::Cpp2ILInjected.Address(RVA = "0x715834", Offset = "0x715834", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x06000206 RID: 518 RVA: 0x00022163 File Offset: 0x00020363
	[global::Cpp2ILInjected.Token(Token = "0x6000299")]
	[global::Cpp2ILInjected.Address(RVA = "0x7158CC", Offset = "0x7158CC", Length = "0x214")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
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

	// Token: 0x06000207 RID: 519 RVA: 0x00022166 File Offset: 0x00020366
	[global::Cpp2ILInjected.Token(Token = "0x600029A")]
	[global::Cpp2ILInjected.Address(RVA = "0x716CE4", Offset = "0x716CE4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float SettingScale(int index)
	{
		throw null;
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00022169 File Offset: 0x00020369
	[global::Cpp2ILInjected.Token(Token = "0x600029B")]
	[global::Cpp2ILInjected.Address(RVA = "0x716CEC", Offset = "0x716CEC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void SettingOver(int index)
	{
		throw null;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0002216C File Offset: 0x0002036C
	[global::Cpp2ILInjected.Token(Token = "0x600029C")]
	[global::Cpp2ILInjected.Address(RVA = "0x716CF0", Offset = "0x716CF0", Length = "0x124")]
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

	// Token: 0x0600020A RID: 522 RVA: 0x0002216F File Offset: 0x0002036F
	[global::Cpp2ILInjected.Token(Token = "0x600029D")]
	[global::Cpp2ILInjected.Address(RVA = "0x716E14", Offset = "0x716E14", Length = "0xB4")]
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

	// Token: 0x0600020B RID: 523 RVA: 0x00022172 File Offset: 0x00020372
	[global::Cpp2ILInjected.Token(Token = "0x600029E")]
	[global::Cpp2ILInjected.Address(RVA = "0x714308", Offset = "0x714308", Length = "0xFFC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
	public void SetCategory(ControllerMappingsCategories_Layout.Category category)
	{
		throw null;
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00022175 File Offset: 0x00020375
	[global::Cpp2ILInjected.Token(Token = "0x600029F")]
	[global::Cpp2ILInjected.Address(RVA = "0x7138D8", Offset = "0x7138D8", Length = "0x318")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsSame", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void RefreshConfigurationState()
	{
		throw null;
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00022178 File Offset: 0x00020378
	[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
	[global::Cpp2ILInjected.Address(RVA = "0x716EC8", Offset = "0x716EC8", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public VirtualControllerInputState.CursorInputMode GetMode(Preferences preferences, string id, VirtualControllerInputState.CursorInputMode defaultValue)
	{
		throw null;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0002217B File Offset: 0x0002037B
	[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
	[global::Cpp2ILInjected.Address(RVA = "0x716F40", Offset = "0x716F40", Length = "0x5C8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(float)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "GetMode", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(string),
		typeof(VirtualControllerInputState.CursorInputMode)
	}, ReturnType = typeof(VirtualControllerInputState.CursorInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
	{
		typeof(string),
		"T"
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "set_SwapBumpersTriggers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences),
		typeof(ref bool),
		typeof(List<ControllerActionButton>),
		typeof(List<ControllerActionAxis>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "TransferMapping", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "RefreshConfigurationState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "SetMapping", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
	public void LoadConfiguration(Preferences preferences, bool existingConfiguration)
	{
		throw null;
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0002217E File Offset: 0x0002037E
	[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
	[global::Cpp2ILInjected.Address(RVA = "0x717668", Offset = "0x717668", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetMapping", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIControllerMappingScheme GetDefaultScheme(GUIControllerMappings.MappingType mappingType)
	{
		throw null;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00022181 File Offset: 0x00020381
	[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x717508", Offset = "0x717508", Length = "0x160")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "GetDefaultScheme", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(GUIControllerMappingScheme))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "ClearMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "Copy", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	public void SetMapping(GUIControllerMappings.MappingType mappingType)
	{
		throw null;
	}

	// Token: 0x06000211 RID: 529 RVA: 0x00022184 File Offset: 0x00020384
	[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x717720", Offset = "0x717720", Length = "0xFC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	private void SetupUIMappingState(ControllerActionButton buttonMapping)
	{
		throw null;
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00022187 File Offset: 0x00020387
	[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x71781C", Offset = "0x71781C", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	private void SetupWorldUIMappingState(ControllerActionButton buttonMapping)
	{
		throw null;
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0002218A File Offset: 0x0002038A
	[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x717934", Offset = "0x717934", Length = "0x610")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIButtonBar), Member = "PerformAction", MemberParameters = new object[] { typeof(GUIButtonBar.Action) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIconGrouping), Member = "PageOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "OpenUI", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(GUIPageIcons.Category)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "DrawSelectedPlayerTeamOnlyElements", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "DrawHUD", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HoverOverNPCs", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenHairWindow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenClothesWindow", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryOpeningFullscreenMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "DisableConflictingActions", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingStateTable),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "ClearUIPressed", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "SetupUIMappingState", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public void UpdateUIInteractionOverloads(GUIControllerMappings.InteractionOverloadState newInteractionOverloadState)
	{
		throw null;
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0002218D File Offset: 0x0002038D
	[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
	[global::Cpp2ILInjected.Address(RVA = "0x718400", Offset = "0x718400", Length = "0x3D44")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateAxisMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(ControllerActionAxis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateVectorMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ControllerActionAxis),
		typeof(ControllerActionAxis)
	}, ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "SetChildState", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingScheme), Member = "LoadDefaultSchemes", MemberParameters = new object[] { typeof(List<GUIControllerMappingScheme>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "SetMapping", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 122)]
	public void SetupMappings()
	{
		throw null;
	}

	// Token: 0x06000215 RID: 533 RVA: 0x00022190 File Offset: 0x00020390
	[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
	[global::Cpp2ILInjected.Address(RVA = "0x7138A8", Offset = "0x7138A8", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearMapping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetMapping", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "ClearWorldMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "ClearInventoryMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "LoadMappingValues", ReturnType = typeof(void))]
	public void LoadMappingValues()
	{
		throw null;
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00022193 File Offset: 0x00020393
	[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x71C144", Offset = "0x71C144", Length = "0x524")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "get_SwapBumpersTriggers", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "SaveConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
	public void SaveConfiguration(Preferences preferences)
	{
		throw null;
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00022196 File Offset: 0x00020396
	[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
	[global::Cpp2ILInjected.Address(RVA = "0x71C668", Offset = "0x71C668", Length = "0x5FC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Buttons),
		typeof(bool),
		typeof(Buttons),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
	public GUIControllerMappings()
	{
		throw null;
	}

	// Token: 0x0400014C RID: 332
	[global::Cpp2ILInjected.Token(Token = "0x4000243")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool Enabled;

	// Token: 0x0400014D RID: 333
	[global::Cpp2ILInjected.Token(Token = "0x4000244")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public GUIControllerMappings.MappingType mapping;

	// Token: 0x0400014E RID: 334
	[global::Cpp2ILInjected.Token(Token = "0x4000245")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private VirtualControllerInputState.CursorInputMode BackupControllerAimAndUse;

	// Token: 0x0400014F RID: 335
	[global::Cpp2ILInjected.Token(Token = "0x4000246")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private VirtualControllerInputState.CursorInputMode BackupControllerSmartCursor;

	// Token: 0x04000150 RID: 336
	[global::Cpp2ILInjected.Token(Token = "0x4000247")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool BackupSwapBumpersTriggers;

	// Token: 0x04000151 RID: 337
	[global::Cpp2ILInjected.Token(Token = "0x4000248")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float BackupNavigationDelay;

	// Token: 0x04000152 RID: 338
	[global::Cpp2ILInjected.Token(Token = "0x4000249")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float BackupControllerAimSensitivity;

	// Token: 0x04000153 RID: 339
	[global::Cpp2ILInjected.Token(Token = "0x400024A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private GUIControllerMappingEntryBase overlayEntry;

	// Token: 0x04000154 RID: 340
	[global::Cpp2ILInjected.Token(Token = "0x400024B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Rectangle overlayRegion;

	// Token: 0x04000155 RID: 341
	[global::Cpp2ILInjected.Token(Token = "0x400024C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public bool performingBinding;

	// Token: 0x04000156 RID: 342
	[global::Cpp2ILInjected.Token(Token = "0x400024D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private int disableScroll;

	// Token: 0x04000157 RID: 343
	[global::Cpp2ILInjected.Token(Token = "0x400024E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool hasFocus;

	// Token: 0x04000158 RID: 344
	[global::Cpp2ILInjected.Token(Token = "0x400024F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x04000159 RID: 345
	[global::Cpp2ILInjected.Token(Token = "0x4000250")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private float TimeSinceItemChange;

	// Token: 0x0400015A RID: 346
	[global::Cpp2ILInjected.Token(Token = "0x4000251")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private ControllerMappingsCategories_Layout.Category[] TabOrder;

	// Token: 0x0400015B RID: 347
	[global::Cpp2ILInjected.Token(Token = "0x4000252")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ControllerMappingsCategories_Layout.Category Selected;

	// Token: 0x0400015C RID: 348
	[global::Cpp2ILInjected.Token(Token = "0x4000253")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	private float GameplayButtonScale;

	// Token: 0x0400015D RID: 349
	[global::Cpp2ILInjected.Token(Token = "0x4000254")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private float UIButtonScale;

	// Token: 0x0400015E RID: 350
	[global::Cpp2ILInjected.Token(Token = "0x4000255")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	private float SaveAndCloseButtonScale;

	// Token: 0x0400015F RID: 351
	[global::Cpp2ILInjected.Token(Token = "0x4000256")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float ResetSettingsButtonScale;

	// Token: 0x04000160 RID: 352
	[global::Cpp2ILInjected.Token(Token = "0x4000257")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private float titleScale;

	// Token: 0x04000161 RID: 353
	[global::Cpp2ILInjected.Token(Token = "0x4000258")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public float ScrollOffset;

	// Token: 0x04000162 RID: 354
	[global::Cpp2ILInjected.Token(Token = "0x4000259")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private float ScrollMomentum;

	// Token: 0x04000163 RID: 355
	[global::Cpp2ILInjected.Token(Token = "0x400025A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private int ScrollDragging;

	// Token: 0x04000164 RID: 356
	[global::Cpp2ILInjected.Token(Token = "0x400025B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04000165 RID: 357
	[global::Cpp2ILInjected.Token(Token = "0x400025C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public List<GUIControllerMappingEntryBase> _allSettings;

	// Token: 0x04000166 RID: 358
	[global::Cpp2ILInjected.Token(Token = "0x400025D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public List<GUIControllerMappingEntryBase> _categorySettings;

	// Token: 0x04000167 RID: 359
	[global::Cpp2ILInjected.Token(Token = "0x400025E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public GUIControllerMappings.InteractionOverloadState interactionOverloadState;

	// Token: 0x04000168 RID: 360
	[global::Cpp2ILInjected.Token(Token = "0x400025F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private ControllerActionButton.RequiredButtonState noModifiers;

	// Token: 0x04000169 RID: 361
	[global::Cpp2ILInjected.Token(Token = "0x4000260")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private ControllerActionButton.RequiredButtonState noLeftModifiers;

	// Token: 0x0400016A RID: 362
	[global::Cpp2ILInjected.Token(Token = "0x4000261")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private ControllerActionButton.RequiredButtonState noRightModifiers;

	// Token: 0x0400016B RID: 363
	[global::Cpp2ILInjected.Token(Token = "0x4000262")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private List<GUIControllerMappingScheme> Schemes;

	// Token: 0x0400016C RID: 364
	[global::Cpp2ILInjected.Token(Token = "0x4000263")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public GUIControllerMappingOverlay _controllerInput;

	// Token: 0x0400016D RID: 365
	[global::Cpp2ILInjected.Token(Token = "0x4000264")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public List<ControllerActionAxis> WorldAxisTable;

	// Token: 0x0400016E RID: 366
	[global::Cpp2ILInjected.Token(Token = "0x4000265")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public List<ControllerActionVector> WorldAxisMappings;

	// Token: 0x0400016F RID: 367
	[global::Cpp2ILInjected.Token(Token = "0x4000266")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public List<ControllerActionButton> WorldButtonMappings;

	// Token: 0x04000170 RID: 368
	[global::Cpp2ILInjected.Token(Token = "0x4000267")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public List<ControllerActionVector> InventoryAxisMappings;

	// Token: 0x04000171 RID: 369
	[global::Cpp2ILInjected.Token(Token = "0x4000268")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public List<ControllerActionAxis> InventoryAxisTable;

	// Token: 0x04000172 RID: 370
	[global::Cpp2ILInjected.Token(Token = "0x4000269")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public List<ControllerActionButton> InventoryButtonMappings;

	// Token: 0x04000173 RID: 371
	[global::Cpp2ILInjected.Token(Token = "0x400026A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public List<ControllerActionButton> BaseInventoryTable;

	// Token: 0x04000174 RID: 372
	[global::Cpp2ILInjected.Token(Token = "0x400026B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public List<ControllerActionButton> InventoryTable;

	// Token: 0x04000175 RID: 373
	[global::Cpp2ILInjected.Token(Token = "0x400026C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public List<ControllerActionButton> EquipmentTable;

	// Token: 0x04000176 RID: 374
	[global::Cpp2ILInjected.Token(Token = "0x400026D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public List<ControllerActionButton> ItemHeldTable;

	// Token: 0x04000177 RID: 375
	[global::Cpp2ILInjected.Token(Token = "0x400026E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public List<ControllerActionButton> ChestInvTable;

	// Token: 0x04000178 RID: 376
	[global::Cpp2ILInjected.Token(Token = "0x400026F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public List<ControllerActionButton> ChestTable;

	// Token: 0x04000179 RID: 377
	[global::Cpp2ILInjected.Token(Token = "0x4000270")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public List<ControllerActionButton> ShopTable;

	// Token: 0x0400017A RID: 378
	[global::Cpp2ILInjected.Token(Token = "0x4000271")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public List<ControllerActionButton> ShopInvTable;

	// Token: 0x0400017B RID: 379
	[global::Cpp2ILInjected.Token(Token = "0x4000272")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public List<ControllerActionButton> CraftingTable;

	// Token: 0x0400017C RID: 380
	[global::Cpp2ILInjected.Token(Token = "0x4000273")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public List<ControllerActionButton> PVPTable;

	// Token: 0x0400017D RID: 381
	[global::Cpp2ILInjected.Token(Token = "0x4000274")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public List<ControllerActionButton> HousingTable;

	// Token: 0x0400017E RID: 382
	[global::Cpp2ILInjected.Token(Token = "0x4000275")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public List<ControllerActionButton> ReforgeTable;

	// Token: 0x0400017F RID: 383
	[global::Cpp2ILInjected.Token(Token = "0x4000276")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public List<ControllerActionButton> ChatTable;

	// Token: 0x04000180 RID: 384
	[global::Cpp2ILInjected.Token(Token = "0x4000277")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public List<ControllerActionAxis> AxisTableEmpty;

	// Token: 0x04000181 RID: 385
	[global::Cpp2ILInjected.Token(Token = "0x4000278")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public ControllerActionAxis MovementAxisX;

	// Token: 0x04000182 RID: 386
	[global::Cpp2ILInjected.Token(Token = "0x4000279")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public ControllerActionAxis MovementAxisY;

	// Token: 0x04000183 RID: 387
	[global::Cpp2ILInjected.Token(Token = "0x400027A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public ControllerActionVector MovementAxis;

	// Token: 0x04000184 RID: 388
	[global::Cpp2ILInjected.Token(Token = "0x400027B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public ControllerActionAxis MapAxisX;

	// Token: 0x04000185 RID: 389
	[global::Cpp2ILInjected.Token(Token = "0x400027C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public ControllerActionAxis MapAxisY;

	// Token: 0x04000186 RID: 390
	[global::Cpp2ILInjected.Token(Token = "0x400027D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public ControllerActionVector MapAxis;

	// Token: 0x04000187 RID: 391
	[global::Cpp2ILInjected.Token(Token = "0x400027E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public ControllerActionAxis MovementAxisAltX;

	// Token: 0x04000188 RID: 392
	[global::Cpp2ILInjected.Token(Token = "0x400027F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public ControllerActionAxis MovementAxisAltY;

	// Token: 0x04000189 RID: 393
	[global::Cpp2ILInjected.Token(Token = "0x4000280")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public ControllerActionVector MovementAxisAlt;

	// Token: 0x0400018A RID: 394
	[global::Cpp2ILInjected.Token(Token = "0x4000281")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public ControllerActionAxis FireAxisX;

	// Token: 0x0400018B RID: 395
	[global::Cpp2ILInjected.Token(Token = "0x4000282")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public ControllerActionAxis FireAxisY;

	// Token: 0x0400018C RID: 396
	[global::Cpp2ILInjected.Token(Token = "0x4000283")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public ControllerActionVector FireAxis;

	// Token: 0x0400018D RID: 397
	[global::Cpp2ILInjected.Token(Token = "0x4000284")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public ControllerActionAxis FireAxisAltX;

	// Token: 0x0400018E RID: 398
	[global::Cpp2ILInjected.Token(Token = "0x4000285")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public ControllerActionAxis FireAxisAltY;

	// Token: 0x0400018F RID: 399
	[global::Cpp2ILInjected.Token(Token = "0x4000286")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public ControllerActionVector FireAxisAlt;

	// Token: 0x04000190 RID: 400
	[global::Cpp2ILInjected.Token(Token = "0x4000287")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public ControllerActionAxis GrappleAxisX;

	// Token: 0x04000191 RID: 401
	[global::Cpp2ILInjected.Token(Token = "0x4000288")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public ControllerActionAxis GrappleAxisY;

	// Token: 0x04000192 RID: 402
	[global::Cpp2ILInjected.Token(Token = "0x4000289")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public ControllerActionVector GrappleAxis;

	// Token: 0x04000193 RID: 403
	[global::Cpp2ILInjected.Token(Token = "0x400028A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public ControllerActionButton GrappleFire;

	// Token: 0x04000194 RID: 404
	[global::Cpp2ILInjected.Token(Token = "0x400028B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public ControllerActionButton Jump;

	// Token: 0x04000195 RID: 405
	[global::Cpp2ILInjected.Token(Token = "0x400028C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public ControllerActionButton Fire;

	// Token: 0x04000196 RID: 406
	[global::Cpp2ILInjected.Token(Token = "0x400028D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public ControllerActionButton Interact;

	// Token: 0x04000197 RID: 407
	[global::Cpp2ILInjected.Token(Token = "0x400028E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public ControllerActionButton TargetLockOn;

	// Token: 0x04000198 RID: 408
	[global::Cpp2ILInjected.Token(Token = "0x400028F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public ControllerActionButton InventoryToggle;

	// Token: 0x04000199 RID: 409
	[global::Cpp2ILInjected.Token(Token = "0x4000290")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public ControllerActionButton AutoSelect;

	// Token: 0x0400019A RID: 410
	[global::Cpp2ILInjected.Token(Token = "0x4000291")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public ControllerActionButton SmartCursor;

	// Token: 0x0400019B RID: 411
	[global::Cpp2ILInjected.Token(Token = "0x4000292")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public ControllerActionButton AutoFire;

	// Token: 0x0400019C RID: 412
	[global::Cpp2ILInjected.Token(Token = "0x4000293")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public ControllerActionButton HotbarNext;

	// Token: 0x0400019D RID: 413
	[global::Cpp2ILInjected.Token(Token = "0x4000294")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public ControllerActionButton HotbarPrevious;

	// Token: 0x0400019E RID: 414
	[global::Cpp2ILInjected.Token(Token = "0x4000295")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public ControllerActionButton FireAlt;

	// Token: 0x0400019F RID: 415
	[global::Cpp2ILInjected.Token(Token = "0x4000296")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public ControllerActionAxis GridSnapAxisX;

	// Token: 0x040001A0 RID: 416
	[global::Cpp2ILInjected.Token(Token = "0x4000297")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public ControllerActionAxis GridSnapAxisY;

	// Token: 0x040001A1 RID: 417
	[global::Cpp2ILInjected.Token(Token = "0x4000298")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public ControllerActionVector GridSnapAxis;

	// Token: 0x040001A2 RID: 418
	[global::Cpp2ILInjected.Token(Token = "0x4000299")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public ControllerActionButton BuffNext;

	// Token: 0x040001A3 RID: 419
	[global::Cpp2ILInjected.Token(Token = "0x400029A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public ControllerActionButton BuffPrevious;

	// Token: 0x040001A4 RID: 420
	[global::Cpp2ILInjected.Token(Token = "0x400029B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public ControllerActionButton BuffRemove;

	// Token: 0x040001A5 RID: 421
	[global::Cpp2ILInjected.Token(Token = "0x400029C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public ControllerActionAxis HotbarAxisX;

	// Token: 0x040001A6 RID: 422
	[global::Cpp2ILInjected.Token(Token = "0x400029D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public ControllerActionAxis HotbarAxisY;

	// Token: 0x040001A7 RID: 423
	[global::Cpp2ILInjected.Token(Token = "0x400029E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public ControllerActionVector HotbarAxis;

	// Token: 0x040001A8 RID: 424
	[global::Cpp2ILInjected.Token(Token = "0x400029F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public ControllerActionButton ZoomIn;

	// Token: 0x040001A9 RID: 425
	[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public ControllerActionButton ZoomOut;

	// Token: 0x040001AA RID: 426
	[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public ControllerActionButton MapZoomIn;

	// Token: 0x040001AB RID: 427
	[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public ControllerActionButton MapZoomOut;

	// Token: 0x040001AC RID: 428
	[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public ControllerActionButton MapZoomDefault;

	// Token: 0x040001AD RID: 429
	[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public ControllerActionButton QuickMount;

	// Token: 0x040001AE RID: 430
	[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public ControllerActionButton QuickHeal;

	// Token: 0x040001AF RID: 431
	[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
	public ControllerActionButton QuickBuff;

	// Token: 0x040001B0 RID: 432
	[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public ControllerActionButton QuickMana;

	// Token: 0x040001B1 RID: 433
	[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public ControllerActionButton MapToggle;

	// Token: 0x040001B2 RID: 434
	[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public ControllerActionButton MiniMapToggle;

	// Token: 0x040001B3 RID: 435
	[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public ControllerActionButton ChatToggle;

	// Token: 0x040001B4 RID: 436
	[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public ControllerActionButton Hotbar1;

	// Token: 0x040001B5 RID: 437
	[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public ControllerActionButton Hotbar2;

	// Token: 0x040001B6 RID: 438
	[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public ControllerActionButton Hotbar3;

	// Token: 0x040001B7 RID: 439
	[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public ControllerActionButton Hotbar4;

	// Token: 0x040001B8 RID: 440
	[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public ControllerActionButton Hotbar5;

	// Token: 0x040001B9 RID: 441
	[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public ControllerActionButton Hotbar6;

	// Token: 0x040001BA RID: 442
	[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public ControllerActionButton Hotbar7;

	// Token: 0x040001BB RID: 443
	[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public ControllerActionButton Hotbar8;

	// Token: 0x040001BC RID: 444
	[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public ControllerActionButton Hotbar9;

	// Token: 0x040001BD RID: 445
	[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public ControllerActionButton Hotbar10;

	// Token: 0x040001BE RID: 446
	[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public ControllerActionButton DynamicHotbar1;

	// Token: 0x040001BF RID: 447
	[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public ControllerActionButton DynamicHotbar2;

	// Token: 0x040001C0 RID: 448
	[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public ControllerActionButton DynamicHotbar3;

	// Token: 0x040001C1 RID: 449
	[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public ControllerActionButton DynamicHotbar4;

	// Token: 0x040001C2 RID: 450
	[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public ControllerActionButton Loadout1;

	// Token: 0x040001C3 RID: 451
	[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public ControllerActionButton Loadout2;

	// Token: 0x040001C4 RID: 452
	[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public ControllerActionButton Loadout3;

	// Token: 0x040001C5 RID: 453
	[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A0")]
	public ControllerActionButton LoadoutCycle;

	// Token: 0x040001C6 RID: 454
	[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public ControllerActionAxis InventoryNavigationX;

	// Token: 0x040001C7 RID: 455
	[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B0")]
	public ControllerActionAxis InventoryNavigationY;

	// Token: 0x040001C8 RID: 456
	[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public ControllerActionVector InventoryNavigation;

	// Token: 0x040001C9 RID: 457
	[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C0")]
	public ControllerActionAxis InventoryNavigationAltX;

	// Token: 0x040001CA RID: 458
	[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public ControllerActionAxis InventoryNavigationAltY;

	// Token: 0x040001CB RID: 459
	[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D0")]
	public ControllerActionVector InventoryNavigationAlt;

	// Token: 0x040001CC RID: 460
	[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public ControllerActionButton WorldFocusToggle;

	// Token: 0x040001CD RID: 461
	[global::Cpp2ILInjected.Token(Token = "0x40002C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E0")]
	public ControllerActionButton LeftPageCycle;

	// Token: 0x040001CE RID: 462
	[global::Cpp2ILInjected.Token(Token = "0x40002C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E8")]
	public ControllerActionButton RightPageCycle;

	// Token: 0x040001CF RID: 463
	[global::Cpp2ILInjected.Token(Token = "0x40002C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F0")]
	public ControllerActionButton ThrowItem;

	// Token: 0x040001D0 RID: 464
	[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F8")]
	public ControllerActionButton TrashItem;

	// Token: 0x040001D1 RID: 465
	[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x400")]
	public ControllerActionButton DepositHeldItem;

	// Token: 0x040001D2 RID: 466
	[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x408")]
	public ControllerActionButton FavouriteItem;

	// Token: 0x040001D3 RID: 467
	[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x410")]
	public ControllerActionButton ResearchItem;

	// Token: 0x040001D4 RID: 468
	[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x418")]
	public ControllerActionButton SplitItem;

	// Token: 0x040001D5 RID: 469
	[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x420")]
	public ControllerActionButton PickupPlaceItem;

	// Token: 0x040001D6 RID: 470
	[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x428")]
	public ControllerActionButton CraftItem;

	// Token: 0x040001D7 RID: 471
	[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x430")]
	public ControllerActionButton FilterItems;

	// Token: 0x040001D8 RID: 472
	[global::Cpp2ILInjected.Token(Token = "0x40002CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x438")]
	public ControllerActionButton ToggleCraftDuplicate;

	// Token: 0x040001D9 RID: 473
	[global::Cpp2ILInjected.Token(Token = "0x40002D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x440")]
	public ControllerActionButton HousingQuery;

	// Token: 0x040001DA RID: 474
	[global::Cpp2ILInjected.Token(Token = "0x40002D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x448")]
	public ControllerActionButton Sort;

	// Token: 0x040001DB RID: 475
	[global::Cpp2ILInjected.Token(Token = "0x40002D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x450")]
	public ControllerActionButton BuilderTools;

	// Token: 0x040001DC RID: 476
	[global::Cpp2ILInjected.Token(Token = "0x40002D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x458")]
	public ControllerActionButton TakeOne;

	// Token: 0x040001DD RID: 477
	[global::Cpp2ILInjected.Token(Token = "0x40002D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x460")]
	public ControllerActionButton InventoryClose;

	// Token: 0x040001DE RID: 478
	[global::Cpp2ILInjected.Token(Token = "0x40002D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x468")]
	public ControllerActionButton ReforgeItem;

	// Token: 0x040001DF RID: 479
	[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x470")]
	public ControllerActionButton ShowHideItem;

	// Token: 0x040001E0 RID: 480
	[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x478")]
	public ControllerActionButton InfoAccessories;

	// Token: 0x040001E1 RID: 481
	[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x480")]
	public ControllerActionButton ChestQuickStack;

	// Token: 0x040001E2 RID: 482
	[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x488")]
	public ControllerActionButton ChestLootAll;

	// Token: 0x040001E3 RID: 483
	[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x490")]
	public ControllerActionButton ChestDepositAll;

	// Token: 0x040001E4 RID: 484
	[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x498")]
	public ControllerActionButton ChestRestock;

	// Token: 0x040001E5 RID: 485
	[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A0")]
	public ControllerActionButton ChestRename;

	// Token: 0x040001E6 RID: 486
	[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A8")]
	public ControllerActionButton ChestLoot;

	// Token: 0x040001E7 RID: 487
	[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B0")]
	public ControllerActionButton ChestDeposit;

	// Token: 0x040001E8 RID: 488
	[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B8")]
	public ControllerActionButton ChestSort;

	// Token: 0x040001E9 RID: 489
	[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C0")]
	public ControllerActionButton EquipmentEquip;

	// Token: 0x040001EA RID: 490
	[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C8")]
	public ControllerActionButton EquipmentUnequip;

	// Token: 0x040001EB RID: 491
	[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D0")]
	public ControllerActionButton ShopSell;

	// Token: 0x040001EC RID: 492
	[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D8")]
	public ControllerActionButton ShopBuy;

	// Token: 0x040001ED RID: 493
	[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E0")]
	public ControllerActionButton PVPEnableToggle;

	// Token: 0x040001EE RID: 494
	[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E8")]
	public ControllerActionButton PVPSwitchTeam;

	// Token: 0x040001EF RID: 495
	[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F0")]
	public GUIControllerMappingStateTable WorldInteractFallback;

	// Token: 0x040001F0 RID: 496
	[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F8")]
	public GUIControllerMappingStateTable WorldInteract;

	// Token: 0x040001F1 RID: 497
	[global::Cpp2ILInjected.Token(Token = "0x40002E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x500")]
	public GUIControllerMappingStateTable WorldShared;

	// Token: 0x040001F2 RID: 498
	[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x508")]
	public GUIControllerMappingStateTable World;

	// Token: 0x040001F3 RID: 499
	[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x510")]
	public GUIControllerMappingStateTable BaseInventory;

	// Token: 0x040001F4 RID: 500
	[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x518")]
	public GUIControllerMappingStateTable Inventory;

	// Token: 0x040001F5 RID: 501
	[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x520")]
	public GUIControllerMappingStateTable Equipment;

	// Token: 0x040001F6 RID: 502
	[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x528")]
	public GUIControllerMappingStateTable PVP;

	// Token: 0x040001F7 RID: 503
	[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x530")]
	public GUIControllerMappingStateTable Housing;

	// Token: 0x040001F8 RID: 504
	[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x538")]
	public GUIControllerMappingStateTable ItemHeld;

	// Token: 0x040001F9 RID: 505
	[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x540")]
	public GUIControllerMappingStateTable ChestInv;

	// Token: 0x040001FA RID: 506
	[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x548")]
	public GUIControllerMappingStateTable Chest;

	// Token: 0x040001FB RID: 507
	[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x550")]
	public GUIControllerMappingStateTable ShopInv;

	// Token: 0x040001FC RID: 508
	[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x558")]
	public GUIControllerMappingStateTable Shop;

	// Token: 0x040001FD RID: 509
	[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x560")]
	public GUIControllerMappingStateTable Crafting;

	// Token: 0x040001FE RID: 510
	[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x568")]
	public GUIControllerMappingStateTable Reforge;

	// Token: 0x040001FF RID: 511
	[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x570")]
	public GUIControllerMappingStateTable Chat;

	// Token: 0x02000788 RID: 1928
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	public enum MappingType
	{
		// Token: 0x040078DD RID: 30941
		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		Default,
		// Token: 0x040078DE RID: 30942
		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		Advanced,
		// Token: 0x040078DF RID: 30943
		[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
		Console,
		// Token: 0x040078E0 RID: 30944
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		Custom
	}

	// Token: 0x02000789 RID: 1929
	[global::Cpp2ILInjected.Token(Token = "0x2000077")]
	public enum InteractionOverloadState
	{
		// Token: 0x040078E2 RID: 30946
		[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
		None,
		// Token: 0x040078E3 RID: 30947
		[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
		Inventory,
		// Token: 0x040078E4 RID: 30948
		[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
		NPC,
		// Token: 0x040078E5 RID: 30949
		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		NPCItem,
		// Token: 0x040078E6 RID: 30950
		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		Map
	}

	// Token: 0x0200078A RID: 1930
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000078")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004866 RID: 18534 RVA: 0x0002EE77 File Offset: 0x0002D077
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x71CC74", Offset = "0x71CC74", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x0002EE7A File Offset: 0x0002D07A
		[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x71CCD0", Offset = "0x71CCD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x0002EE7D File Offset: 0x0002D07D
		[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x71CCD8", Offset = "0x71CCD8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <SetCategory>b__49_0(GUIControllerMappingEntryBase e1, GUIControllerMappingEntryBase e2)
		{
			throw null;
		}

		// Token: 0x040078E7 RID: 30951
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		public static readonly GUIControllerMappings.<>c <>9;

		// Token: 0x040078E8 RID: 30952
		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		public static Comparison<GUIControllerMappingEntryBase> <>9__49_0;
	}
}
