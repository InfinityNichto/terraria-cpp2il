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

// Token: 0x020001C8 RID: 456
[global::Cpp2ILInjected.Token(Token = "0x200025E")]
public class GUIInterfaceEdit
{
	// Token: 0x06000C61 RID: 3169 RVA: 0x00024068 File Offset: 0x00022268
	[global::Cpp2ILInjected.Token(Token = "0x6000D7D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DBEF0", Offset = "0x9DBEF0", Length = "0x6DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISafeRegionEdit), Member = "UpdateEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISafeRegionEdit), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISafeRegionEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawSafeRegionOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawPgeGroups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawUITweaks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawWidgetOverlays", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControlCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControlsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawSlotsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawControlsOptions", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_KeyboardIsActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseProfileOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseTemplateOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "CloseProfileOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClosePageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0002406B File Offset: 0x0002226B
	[global::Cpp2ILInjected.Token(Token = "0x6000D7E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE130", Offset = "0x9DE130", Length = "0x23C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "RefreshSlotOrder", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void DrawCategories()
	{
		throw null;
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x0002406E File Offset: 0x0002226E
	[global::Cpp2ILInjected.Token(Token = "0x6000D7F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE3F8", Offset = "0x9DE3F8", Length = "0x388")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "FindSpaceToSpawn", MemberParameters = new object[]
	{
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private bool CanSpawn(List<GUIPageIconGrouping> groups, List<GUIPageIconGrouping> otherGroups, bool left, out Microsoft.Xna.Framework.Vector2 position)
	{
		throw null;
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00024071 File Offset: 0x00022271
	[global::Cpp2ILInjected.Token(Token = "0x6000D80")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE780", Offset = "0x9DE780", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawPgeGroups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawGroupEditControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CanSpawn", MemberParameters = new object[]
	{
		typeof(List<GUIPageIconGrouping>),
		typeof(List<GUIPageIconGrouping>),
		typeof(bool),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private bool FindSpaceToSpawn(out Microsoft.Xna.Framework.Vector2 position, out bool left)
	{
		throw null;
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00024074 File Offset: 0x00022274
	[global::Cpp2ILInjected.Token(Token = "0x6000D81")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE910", Offset = "0x9DE910", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "Contains", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public int SortGroupByPosition(GUIPageIconGrouping x, GUIPageIconGrouping y)
	{
		throw null;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00024077 File Offset: 0x00022277
	[global::Cpp2ILInjected.Token(Token = "0x6000D82")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE9AC", Offset = "0x9DE9AC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float PageScale(int index)
	{
		throw null;
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0002407A File Offset: 0x0002227A
	[global::Cpp2ILInjected.Token(Token = "0x6000D83")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE9B4", Offset = "0x9DE9B4", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private void PageOver(int index)
	{
		throw null;
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0002407D File Offset: 0x0002227D
	[global::Cpp2ILInjected.Token(Token = "0x6000D84")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DEBA4", Offset = "0x9DEBA4", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		throw null;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00024080 File Offset: 0x00022280
	[global::Cpp2ILInjected.Token(Token = "0x6000D85")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DEC9C", Offset = "0x9DEC9C", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "GetCategoryTexture", MemberParameters = new object[]
	{
		typeof(GUIPageIcons.Category),
		typeof(bool)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void PageIconDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00024083 File Offset: 0x00022283
	[global::Cpp2ILInjected.Token(Token = "0x6000D86")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DEE24", Offset = "0x9DEE24", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void PageIconOver(int index)
	{
		throw null;
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00024086 File Offset: 0x00022286
	[global::Cpp2ILInjected.Token(Token = "0x6000D87")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DEE28", Offset = "0x9DEE28", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float PageIconScale(int index)
	{
		throw null;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00024089 File Offset: 0x00022289
	[global::Cpp2ILInjected.Token(Token = "0x6000D88")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DEE30", Offset = "0x9DEE30", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "PageDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "IndexOf", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private bool LoadSettingAnchor(GUIPageIconGrouping.SettingCategory category, ref Rectangle itemRegion)
	{
		throw null;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x0002408C File Offset: 0x0002228C
	[global::Cpp2ILInjected.Token(Token = "0x6000D89")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DEFE0", Offset = "0x9DEFE0", Length = "0x834")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetMainMenuPageRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "LoadSettingAnchor", MemberParameters = new object[]
	{
		typeof(GUIPageIconGrouping.SettingCategory),
		typeof(ref Rectangle)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Settings_Layout), Member = "get_Instance", ReturnType = typeof(Settings_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
	private void PageDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0002408F File Offset: 0x0002228F
	[global::Cpp2ILInjected.Token(Token = "0x6000D8A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DF814", Offset = "0x9DF814", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		throw null;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00024092 File Offset: 0x00022292
	[global::Cpp2ILInjected.Token(Token = "0x6000D8B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DF86C", Offset = "0x9DF86C", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInterfaceEdit), Member = "UpdatePageScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawPgeGroups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInterfaceEdit), Member = "UpdatePageScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void RefreshSelected()
	{
		throw null;
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00024095 File Offset: 0x00022295
	[global::Cpp2ILInjected.Token(Token = "0x6000D8C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DC5CC", Offset = "0x9DC5CC", Length = "0x380")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "FindSpaceToSpawn", MemberParameters = new object[]
	{
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "RefreshSelected", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private void DrawPgeGroups()
	{
		throw null;
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x00024098 File Offset: 0x00022298
	[global::Cpp2ILInjected.Token(Token = "0x6000D8D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DD01C", Offset = "0x9DD01C", Length = "0x9E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "FindSpaceToSpawn", MemberParameters = new object[]
	{
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "DisabledClipping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInterfaceEdit), Member = "UpdatePageScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionVector),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageGroupEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
	private void DrawGroupEditControls()
	{
		throw null;
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0002409B File Offset: 0x0002229B
	[global::Cpp2ILInjected.Token(Token = "0x6000D8E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DDAD0", Offset = "0x9DDAD0", Length = "0x2B0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void DrawSafeRegionOptions()
	{
		throw null;
	}

	// Token: 0x06000C73 RID: 3187 RVA: 0x0002409E File Offset: 0x0002229E
	[global::Cpp2ILInjected.Token(Token = "0x6000D8F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DFDA4", Offset = "0x9DFDA4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool CanApply()
	{
		throw null;
	}

	// Token: 0x06000C74 RID: 3188 RVA: 0x000240A1 File Offset: 0x000222A1
	[global::Cpp2ILInjected.Token(Token = "0x6000D90")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DC94C", Offset = "0x9DC94C", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void DrawOptions()
	{
		throw null;
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x000240A4 File Offset: 0x000222A4
	[global::Cpp2ILInjected.Token(Token = "0x6000D91")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DDD80", Offset = "0x9DDD80", Length = "0x210")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void DrawControlsOptions()
	{
		throw null;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x000240A7 File Offset: 0x000222A7
	[global::Cpp2ILInjected.Token(Token = "0x6000D92")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE0AC", Offset = "0x9DE0AC", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawSafeRegionOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawControlsOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "CancelDrag", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void CancelChanges()
	{
		throw null;
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x000240AA File Offset: 0x000222AA
	[global::Cpp2ILInjected.Token(Token = "0x6000D93")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E006C", Offset = "0x9E006C", Length = "0x16C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawUITweaks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "get_MinVerticalResolution", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "OverrideVerticalResolution", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void ClampUIScale()
	{
		throw null;
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x000240AD File Offset: 0x000222AD
	[global::Cpp2ILInjected.Token(Token = "0x6000D94")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E01D8", Offset = "0x9E01D8", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private string GetDisplayName(InterfaceProfile_Layout profile, float maxWidth, bool isTemplate)
	{
		throw null;
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x000240B0 File Offset: 0x000222B0
	[global::Cpp2ILInjected.Token(Token = "0x6000D95")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E0354", Offset = "0x9E0354", Length = "0x7C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseProfileOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseTemplateOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x000240B3 File Offset: 0x000222B3
	[global::Cpp2ILInjected.Token(Token = "0x6000D96")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE050", Offset = "0x9DE050", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CloseNameEdit()
	{
		throw null;
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x000240B6 File Offset: 0x000222B6
	[global::Cpp2ILInjected.Token(Token = "0x6000D97")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DDF90", Offset = "0x9DDF90", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void CloseProfileOptions()
	{
		throw null;
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x000240B9 File Offset: 0x000222B9
	[global::Cpp2ILInjected.Token(Token = "0x6000D98")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DDFF0", Offset = "0x9DDFF0", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "IsOverOptions", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CloseTemplateOptions()
	{
		throw null;
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x000240BC File Offset: 0x000222BC
	[global::Cpp2ILInjected.Token(Token = "0x6000D99")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E03D0", Offset = "0x9E03D0", Length = "0xC88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "GetDisplayName", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetPickRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseProfileOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "SetActiveLayout", MemberParameters = new object[] { typeof(InterfaceProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Copy", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
	private void DrawProfile()
	{
		throw null;
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x000240BF File Offset: 0x000222BF
	[global::Cpp2ILInjected.Token(Token = "0x6000D9A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E1058", Offset = "0x9E1058", Length = "0x124")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "IsSame", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void RefreshTemplate()
	{
		throw null;
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x000240C2 File Offset: 0x000222C2
	[global::Cpp2ILInjected.Token(Token = "0x6000D9B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E117C", Offset = "0x9E117C", Length = "0x184")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void EnsureSelectedGroupVisible()
	{
		throw null;
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x000240C5 File Offset: 0x000222C5
	[global::Cpp2ILInjected.Token(Token = "0x6000D9C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E1300", Offset = "0x9E1300", Length = "0xDC8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawWidgetOverlays", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawUITweaks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "RefreshTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "GetDisplayName", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "CloseTemplateOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Copy", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Clean", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "InvalidateMinResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	private void DrawTemplate()
	{
		throw null;
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x000240C8 File Offset: 0x000222C8
	[global::Cpp2ILInjected.Token(Token = "0x6000D9D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DDA04", Offset = "0x9DDA04", Length = "0xCC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void DrawWidgetOverlays()
	{
		throw null;
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x000240CB File Offset: 0x000222CB
	[global::Cpp2ILInjected.Token(Token = "0x6000D9E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DCAE0", Offset = "0x9DCAE0", Length = "0x53C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "DrawTemplate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClampUIScale", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "get_MinVerticalResolution", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "GetRegion", MemberParameters = new object[] { typeof(TransactionButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "IsOverExclusiveRegion", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	private void DrawUITweaks()
	{
		throw null;
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x000240CE File Offset: 0x000222CE
	[global::Cpp2ILInjected.Token(Token = "0x6000D9F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E20C8", Offset = "0x9E20C8", Length = "0x2E4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Copy", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_LeftControls", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get_RightControls", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void Backup()
	{
		throw null;
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x000240D1 File Offset: 0x000222D1
	[global::Cpp2ILInjected.Token(Token = "0x6000DA0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E23AC", Offset = "0x9E23AC", Length = "0x1F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit.BackupResotrePoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(VirtualControlsProfile_Layout)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void AddControlUndo()
	{
		throw null;
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x000240D4 File Offset: 0x000222D4
	[global::Cpp2ILInjected.Token(Token = "0x6000DA1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E2660", Offset = "0x9E2660", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public bool HasUndo()
	{
		throw null;
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x000240D7 File Offset: 0x000222D7
	[global::Cpp2ILInjected.Token(Token = "0x6000DA2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E2744", Offset = "0x9E2744", Length = "0x258")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "HasUndo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit.BackupResotrePoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(VirtualControlsProfile_Layout)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "LoadControlPositions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void ControlUndo()
	{
		throw null;
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x000240DA File Offset: 0x000222DA
	[global::Cpp2ILInjected.Token(Token = "0x6000DA3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E299C", Offset = "0x9E299C", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public bool HasRedo()
	{
		throw null;
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x000240DD File Offset: 0x000222DD
	[global::Cpp2ILInjected.Token(Token = "0x6000DA4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E29E4", Offset = "0x9E29E4", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "LoadControlPositions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void ControlRedo()
	{
		throw null;
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x000240E0 File Offset: 0x000222E0
	[global::Cpp2ILInjected.Token(Token = "0x6000DA5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E2B80", Offset = "0x9E2B80", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void ClearControlRedo()
	{
		throw null;
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x000240E3 File Offset: 0x000222E3
	[global::Cpp2ILInjected.Token(Token = "0x6000DA6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DE36C", Offset = "0x9DE36C", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawSafeRegionOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawControlsOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void ClearControlUndoRedo()
	{
		throw null;
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x000240E6 File Offset: 0x000222E6
	[global::Cpp2ILInjected.Token(Token = "0x6000DA7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E2BE8", Offset = "0x9E2BE8", Length = "0x270")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void LoadDefaultProfilePositions(VirtualControlsHardwareConfiguration_Layout configuration)
	{
		throw null;
	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x000240E9 File Offset: 0x000222E9
	[global::Cpp2ILInjected.Token(Token = "0x6000DA8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DFA08", Offset = "0x9DFA08", Length = "0x39C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawSafeRegionOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawControlsOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ResetSettings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetHardwareConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "LoadDefaultProfilePositions", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "LoadControlPositions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsBinding_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetDefaultSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "InvalidateMinResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_LeftInterface", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "set_RightInterface", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampControls", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	public void RestoreDefaults()
	{
		throw null;
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x000240EC File Offset: 0x000222EC
	[global::Cpp2ILInjected.Token(Token = "0x6000DA9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9DFDAC", Offset = "0x9DFDAC", Length = "0x2C0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "ShutdownUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "SetActiveProfile", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "LoadControlPositions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "Copy", MemberParameters = new object[]
	{
		typeof(InterfaceProfile_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "SetSafeArea", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "InvalidateMinResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void RestoreBackup()
	{
		throw null;
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x000240EF File Offset: 0x000222EF
	[global::Cpp2ILInjected.Token(Token = "0x6000DAA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9E2E58", Offset = "0x9E2E58", Length = "0x260")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInterfaceEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISlider.DragState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	public GUIInterfaceEdit()
	{
		throw null;
	}

	// Token: 0x04001401 RID: 5121
	[global::Cpp2ILInjected.Token(Token = "0x40018EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIInterfaceEdit.EditMode Mode;

	// Token: 0x04001402 RID: 5122
	[global::Cpp2ILInjected.Token(Token = "0x40018F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public bool Enabled;

	// Token: 0x04001403 RID: 5123
	[global::Cpp2ILInjected.Token(Token = "0x40018F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerInterfaceEdit _controller;

	// Token: 0x04001404 RID: 5124
	[global::Cpp2ILInjected.Token(Token = "0x40018F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float InterfacePositionScale;

	// Token: 0x04001405 RID: 5125
	[global::Cpp2ILInjected.Token(Token = "0x40018F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float ControlsPositionScale;

	// Token: 0x04001406 RID: 5126
	[global::Cpp2ILInjected.Token(Token = "0x40018F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float SafeRegionScale;

	// Token: 0x04001407 RID: 5127
	[global::Cpp2ILInjected.Token(Token = "0x40018F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float EditControlScale;

	// Token: 0x04001408 RID: 5128
	[global::Cpp2ILInjected.Token(Token = "0x40018F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float TitleScale;

	// Token: 0x04001409 RID: 5129
	[global::Cpp2ILInjected.Token(Token = "0x40018F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float defaultsScale;

	// Token: 0x0400140A RID: 5130
	[global::Cpp2ILInjected.Token(Token = "0x40018F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float finishScale;

	// Token: 0x0400140B RID: 5131
	[global::Cpp2ILInjected.Token(Token = "0x40018F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private float resetScale;

	// Token: 0x0400140C RID: 5132
	[global::Cpp2ILInjected.Token(Token = "0x40018FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float ScrollOffset;

	// Token: 0x0400140D RID: 5133
	[global::Cpp2ILInjected.Token(Token = "0x40018FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float ScrollMomentum;

	// Token: 0x0400140E RID: 5134
	[global::Cpp2ILInjected.Token(Token = "0x40018FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private int ScrollDragging;

	// Token: 0x0400140F RID: 5135
	[global::Cpp2ILInjected.Token(Token = "0x40018FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x04001410 RID: 5136
	[global::Cpp2ILInjected.Token(Token = "0x40018FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private int _groupCount;

	// Token: 0x04001411 RID: 5137
	[global::Cpp2ILInjected.Token(Token = "0x40018FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private int pageOver;

	// Token: 0x04001412 RID: 5138
	[global::Cpp2ILInjected.Token(Token = "0x4001900")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private Rectangle NewItemtemRegion;

	// Token: 0x04001413 RID: 5139
	[global::Cpp2ILInjected.Token(Token = "0x4001901")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private Rectangle SelectedItemRegion;

	// Token: 0x04001414 RID: 5140
	[global::Cpp2ILInjected.Token(Token = "0x4001902")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public int SelectedItem;

	// Token: 0x04001415 RID: 5141
	[global::Cpp2ILInjected.Token(Token = "0x4001903")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private GUIPageIconGrouping currentGroup;

	// Token: 0x04001416 RID: 5142
	[global::Cpp2ILInjected.Token(Token = "0x4001904")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private Microsoft.Xna.Framework.Vector2 pageButtonRegionSize;

	// Token: 0x04001417 RID: 5143
	[global::Cpp2ILInjected.Token(Token = "0x4001905")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private Rectangle fullClipRegion;

	// Token: 0x04001418 RID: 5144
	[global::Cpp2ILInjected.Token(Token = "0x4001906")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private Rectangle dragClipRegion;

	// Token: 0x04001419 RID: 5145
	[global::Cpp2ILInjected.Token(Token = "0x4001907")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public bool CanSpawnState;

	// Token: 0x0400141A RID: 5146
	[global::Cpp2ILInjected.Token(Token = "0x4001908")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private float SideControls;

	// Token: 0x0400141B RID: 5147
	[global::Cpp2ILInjected.Token(Token = "0x4001909")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private float TopControls;

	// Token: 0x0400141C RID: 5148
	[global::Cpp2ILInjected.Token(Token = "0x400190A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	private float BottomControls;

	// Token: 0x0400141D RID: 5149
	[global::Cpp2ILInjected.Token(Token = "0x400190B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private GUISlider.DragState dragState;

	// Token: 0x0400141E RID: 5150
	[global::Cpp2ILInjected.Token(Token = "0x400190C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private float uiScale;

	// Token: 0x0400141F RID: 5151
	[global::Cpp2ILInjected.Token(Token = "0x400190D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	private float EditGroupsScale;

	// Token: 0x04001420 RID: 5152
	[global::Cpp2ILInjected.Token(Token = "0x400190E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private global::UnityEngine.Vector2 lastCursorPosition;

	// Token: 0x04001421 RID: 5153
	[global::Cpp2ILInjected.Token(Token = "0x400190F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private int lastDirection;

	// Token: 0x04001422 RID: 5154
	[global::Cpp2ILInjected.Token(Token = "0x4001910")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public bool editingName;

	// Token: 0x04001423 RID: 5155
	[global::Cpp2ILInjected.Token(Token = "0x4001911")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private string editNameValue;

	// Token: 0x04001424 RID: 5156
	[global::Cpp2ILInjected.Token(Token = "0x4001912")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private int textBlinkerCount;

	// Token: 0x04001425 RID: 5157
	[global::Cpp2ILInjected.Token(Token = "0x4001913")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	private int textBlinkerState;

	// Token: 0x04001426 RID: 5158
	[global::Cpp2ILInjected.Token(Token = "0x4001914")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001427 RID: 5159
	[global::Cpp2ILInjected.Token(Token = "0x4001915")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public bool displayProfileOptions;

	// Token: 0x04001428 RID: 5160
	[global::Cpp2ILInjected.Token(Token = "0x4001916")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF9")]
	private bool drawnProfileOptions;

	// Token: 0x04001429 RID: 5161
	[global::Cpp2ILInjected.Token(Token = "0x4001917")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	private float ProfileScale;

	// Token: 0x0400142A RID: 5162
	[global::Cpp2ILInjected.Token(Token = "0x4001918")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	private float ProfileRenameScale;

	// Token: 0x0400142B RID: 5163
	[global::Cpp2ILInjected.Token(Token = "0x4001919")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	private float Profile1Scale;

	// Token: 0x0400142C RID: 5164
	[global::Cpp2ILInjected.Token(Token = "0x400191A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	private float Profile2Scale;

	// Token: 0x0400142D RID: 5165
	[global::Cpp2ILInjected.Token(Token = "0x400191B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	private float Profile3Scale;

	// Token: 0x0400142E RID: 5166
	[global::Cpp2ILInjected.Token(Token = "0x400191C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	private float Profile4Scale;

	// Token: 0x0400142F RID: 5167
	[global::Cpp2ILInjected.Token(Token = "0x400191D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public bool displayTemplateOptions;

	// Token: 0x04001430 RID: 5168
	[global::Cpp2ILInjected.Token(Token = "0x400191E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x115")]
	private bool drawnTemplateOptions;

	// Token: 0x04001431 RID: 5169
	[global::Cpp2ILInjected.Token(Token = "0x400191F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private float TemplateScale;

	// Token: 0x04001432 RID: 5170
	[global::Cpp2ILInjected.Token(Token = "0x4001920")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
	private float Template1Scale;

	// Token: 0x04001433 RID: 5171
	[global::Cpp2ILInjected.Token(Token = "0x4001921")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	private float Template2Scale;

	// Token: 0x04001434 RID: 5172
	[global::Cpp2ILInjected.Token(Token = "0x4001922")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
	private float Template3Scale;

	// Token: 0x04001435 RID: 5173
	[global::Cpp2ILInjected.Token(Token = "0x4001923")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	private float Template4Scale;

	// Token: 0x04001436 RID: 5174
	[global::Cpp2ILInjected.Token(Token = "0x4001924")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	private float Template5Scale;

	// Token: 0x04001437 RID: 5175
	[global::Cpp2ILInjected.Token(Token = "0x4001925")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private bool selectedCustom;

	// Token: 0x04001438 RID: 5176
	[global::Cpp2ILInjected.Token(Token = "0x4001926")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private InterfaceProfile_Layout currentProfile;

	// Token: 0x04001439 RID: 5177
	[global::Cpp2ILInjected.Token(Token = "0x4001927")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public float _pulldownShift;

	// Token: 0x0400143A RID: 5178
	[global::Cpp2ILInjected.Token(Token = "0x4001928")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware1;

	// Token: 0x0400143B RID: 5179
	[global::Cpp2ILInjected.Token(Token = "0x4001929")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware2;

	// Token: 0x0400143C RID: 5180
	[global::Cpp2ILInjected.Token(Token = "0x400192A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware3;

	// Token: 0x0400143D RID: 5181
	[global::Cpp2ILInjected.Token(Token = "0x400192B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware4;

	// Token: 0x0400143E RID: 5182
	[global::Cpp2ILInjected.Token(Token = "0x400192C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	private VirtualControlsProfile_Layout BackupProfile1;

	// Token: 0x0400143F RID: 5183
	[global::Cpp2ILInjected.Token(Token = "0x400192D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	private VirtualControlsProfile_Layout BackupProfile2;

	// Token: 0x04001440 RID: 5184
	[global::Cpp2ILInjected.Token(Token = "0x400192E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	private VirtualControlsProfile_Layout BackupProfile3;

	// Token: 0x04001441 RID: 5185
	[global::Cpp2ILInjected.Token(Token = "0x400192F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	private VirtualControlsProfile_Layout BackupProfile4;

	// Token: 0x04001442 RID: 5186
	[global::Cpp2ILInjected.Token(Token = "0x4001930")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	private VirtualControlsProfile_Layout BackupActiveProfile;

	// Token: 0x04001443 RID: 5187
	[global::Cpp2ILInjected.Token(Token = "0x4001931")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	private Microsoft.Xna.Framework.Vector2 backupLeftPosition;

	// Token: 0x04001444 RID: 5188
	[global::Cpp2ILInjected.Token(Token = "0x4001932")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	private Microsoft.Xna.Framework.Vector2 backupRightPosition;

	// Token: 0x04001445 RID: 5189
	[global::Cpp2ILInjected.Token(Token = "0x4001933")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	private Microsoft.Xna.Framework.Vector2 backupInterfaceLeftPosition;

	// Token: 0x04001446 RID: 5190
	[global::Cpp2ILInjected.Token(Token = "0x4001934")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	private Microsoft.Xna.Framework.Vector2 backupInterfaceRightPosition;

	// Token: 0x04001447 RID: 5191
	[global::Cpp2ILInjected.Token(Token = "0x4001935")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private Rect backupSafeRegion;

	// Token: 0x04001448 RID: 5192
	[global::Cpp2ILInjected.Token(Token = "0x4001936")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	private bool backupVPPIOverride;

	// Token: 0x04001449 RID: 5193
	[global::Cpp2ILInjected.Token(Token = "0x4001937")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C4")]
	private float backupVPPI;

	// Token: 0x0400144A RID: 5194
	[global::Cpp2ILInjected.Token(Token = "0x4001938")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	private InterfaceProfile_Layout BackupInterfaceProfile;

	// Token: 0x0400144B RID: 5195
	[global::Cpp2ILInjected.Token(Token = "0x4001939")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	private int SelectedSlot;

	// Token: 0x0400144C RID: 5196
	[global::Cpp2ILInjected.Token(Token = "0x400193A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	private List<GUIInterfaceEdit.BackupResotrePoint> RestorePoints;

	// Token: 0x0400144D RID: 5197
	[global::Cpp2ILInjected.Token(Token = "0x400193B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	private List<GUIInterfaceEdit.BackupResotrePoint> RedoPoints;

	// Token: 0x020007F7 RID: 2039
	[global::Cpp2ILInjected.Token(Token = "0x200025F")]
	public enum EditMode
	{
		// Token: 0x04007CB9 RID: 31929
		[global::Cpp2ILInjected.Token(Token = "0x400193D")]
		SafeRegion,
		// Token: 0x04007CBA RID: 31930
		[global::Cpp2ILInjected.Token(Token = "0x400193E")]
		InterfacePosition,
		// Token: 0x04007CBB RID: 31931
		[global::Cpp2ILInjected.Token(Token = "0x400193F")]
		InterfacePositionAdjust,
		// Token: 0x04007CBC RID: 31932
		[global::Cpp2ILInjected.Token(Token = "0x4001940")]
		EditControls
	}

	// Token: 0x020007F8 RID: 2040
	[global::Cpp2ILInjected.Token(Token = "0x2000260")]
	public class BackupResotrePoint
	{
		// Token: 0x060048EF RID: 18671 RVA: 0x0002EF22 File Offset: 0x0002D122
		[global::Cpp2ILInjected.Token(Token = "0x6000DAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9E259C", Offset = "0x9E259C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BackupResotrePoint(VirtualControlsHardwareConfiguration_Layout hardware, VirtualControlsProfile_Layout profile)
		{
			throw null;
		}

		// Token: 0x04007CBD RID: 31933
		[global::Cpp2ILInjected.Token(Token = "0x4001941")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public VirtualControlsHardwareConfiguration_Layout Hardware;

		// Token: 0x04007CBE RID: 31934
		[global::Cpp2ILInjected.Token(Token = "0x4001942")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public VirtualControlsProfile_Layout Profile;
	}
}
