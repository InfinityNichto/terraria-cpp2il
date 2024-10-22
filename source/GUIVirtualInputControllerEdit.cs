﻿using System;
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
using Terraria.Localization;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000282")]
public class GUIVirtualInputControllerEdit
{
	[global::Cpp2ILInjected.Token(Token = "0x6000E93")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0939C", Offset = "0xA0939C", Length = "0x21C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<GUIVirtualInputControllerEdit.StyleOption>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer.CursorUpdater), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorInputLayer), Member = "set_Priority", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	public GUIVirtualInputControllerEdit()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E94")]
	[global::Cpp2ILInjected.Address(RVA = "0xA095B8", Offset = "0xA095B8", Length = "0x26C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeviceVPPICalculator), Member = "GetSafeArea", ReturnType = typeof(Rect))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void DrawBacking()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E95")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09824", Offset = "0xA09824", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public VirtualControlsAxisConfiguration_Layout.Style GetAxisControlSubStyle(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E96")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09830", Offset = "0xA09830", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public VirtualControlsButtonConfiguration_Layout.Style GetButtonControlSubStyle(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E97")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09850", Offset = "0xA09850", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E98")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09858", Offset = "0xA09858", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CloseKeyboard", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CloseNameEdit()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E99")]
	[global::Cpp2ILInjected.Address(RVA = "0xA098B4", Offset = "0xA098B4", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void CloseProfileOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E9A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA09914", Offset = "0xA09914", Length = "0xB60")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgetOverlays", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "CloseNameEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "clrInput", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "GetDisplayName", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "CloseProfileOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsProfile_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "SetActiveProfile", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	private void DrawProfile()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E9B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0A474", Offset = "0xA0A474", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private string TruncateString(TransactionButton_Layout button, string text, float maxWidth)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E9C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0A588", Offset = "0xA0A588", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void ClosePageOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E9D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0A5E8", Offset = "0xA0A5E8", Length = "0x568")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgetOverlays", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "TruncateString", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(string),
		typeof(float)
	}, ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClosePageOptions", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "SetPageControlsAndAdjust", MemberParameters = new object[] { typeof(GUIPageIcons.PageControlsType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	private void DrawPageOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E9E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0B72C", Offset = "0xA0B72C", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void DisablePulldown()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000E9F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0B79C", Offset = "0xA0B79C", Length = "0x710")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "GetDisplayName", ReturnType = typeof(string))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetHardwareConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PressedReleased", MemberParameters = new object[] { typeof(GUIControllerInputButton.LinkedControlType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void DrawHardware()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0BEAC", Offset = "0xA0BEAC", Length = "0x8D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetDefaultControlSetup", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void UpdateStyleOptions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0C87C", Offset = "0xA0C87C", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void ChangeStyle(string configurationId)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0C914", Offset = "0xA0C914", Length = "0x1FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "HasUndo", ReturnType = typeof(bool))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "HasRedo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ControlRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void DrawUndoRedo()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0CB10", Offset = "0xA0CB10", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawUndoRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	public void DrawWidgets()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0CB60", Offset = "0xA0CB60", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void DrawWidgetOverlays()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0CC44", Offset = "0xA0CC44", Length = "0x344")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(QuickActionButton_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public int GetSlotOver(Microsoft.Xna.Framework.Vector2 mousePosition, out Microsoft.Xna.Framework.Vector2 slotPosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0CF88", Offset = "0xA0CF88", Length = "0x63C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Panel_Layout)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "Region", MemberParameters = new object[] { typeof(StringButton_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInterfaceEdit), Member = "UpdatePageScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DraggingControlInBadPosition", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "RemoveSlot", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "ClearControlRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetSlotOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	public void UpdateCursor(global::Cursor cursor)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0DA94", Offset = "0xA0DA94", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit.<>c__DisplayClass72_0), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<int>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<int>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void RefreshSlotOrder()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0DC28", Offset = "0xA0DC28", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float ControlsItemScale(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EA9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0DC74", Offset = "0xA0DC74", Length = "0x41C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void ClampSlotToScreen(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EAA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0E090", Offset = "0xA0E090", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetDefaultControlSetup", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "HandleSlotChangeType", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(int),
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampSlotToScreen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void ControlsItemOver(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EAB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0E3D8", Offset = "0xA0E3D8", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private QuickActionButton_Layout.QuickActionControl GetButtonId(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EAC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0E3FC", Offset = "0xA0E3FC", Length = "0x35C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "GetIconFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	private void GetControlTextureFrame(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, out Microsoft.Xna.Framework.Graphics.Texture2D tex, out Rectangle frame)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EAD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0E758", Offset = "0xA0E758", Length = "0x194")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControlsGrid", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public string GetControlName(VirtualControlsHardwareConfigurationMapping_Layout.ContolType control)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EAE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0E8EC", Offset = "0xA0E8EC", Length = "0x840")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetControlTextureFrame", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetDefaultControlSetup", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetButtonConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetAxisConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
	public void ControlsItemDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EAF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0F12C", Offset = "0xA0F12C", Length = "0x298")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetControlName", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIFadeString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(FadeString_Layout),
		typeof(string),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public void DrawControlsGrid()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0D84C", Offset = "0xA0D84C", Length = "0x248")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(ref object[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private void RemoveSlot(int selectedSlot)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0F3C4", Offset = "0xA0F3C4", Length = "0x31C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(ref object[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfigurationMapping_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "LoadSlotPosition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsBinding_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private int CreateNewSlot(VirtualControlsSlotTypeMapping_Layout.SlotType controlType, string styleId, Microsoft.Xna.Framework.Vector2 position)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0F8A8", Offset = "0xA0F8A8", Length = "0xA50")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetButtonConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetAxisConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "RegisterPickingRegion", MemberParameters = new object[] { typeof(Axis_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "RegisterPickingRegion", MemberParameters = new object[] { typeof(QuickActionButton_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
	public void DrawSlotsGrid()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA102F8", Offset = "0xA102F8", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void DrawControlCategories()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0C77C", Offset = "0xA0C77C", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateStyleOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void GetDefaultControlSetup(VirtualControlsHardwareConfigurationMapping_Layout.ContolType control, out VirtualControlsSlotTypeMapping_Layout.SlotType type, out string configurationId)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0E304", Offset = "0xA0E304", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void HandleSlotChangeType(VirtualControlsHardwareConfiguration_Layout hardware, int slot, VirtualControlsSlotTypeMapping_Layout.SlotType type)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0F6E0", Offset = "0xA0F6E0", Length = "0x1C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CreateNewSlot", MemberParameters = new object[]
	{
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void LoadSlotPosition(Microsoft.Xna.Framework.Vector2 position, int slot)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA10480", Offset = "0xA10480", Length = "0x158C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawInterfaceBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgets", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetSlotOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "LoadSlotPosition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetDefaultControlSetup", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "HandleSlotChangeType", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(int),
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampSlotToScreen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "IndexOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetButtonConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetAxisConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "IsAxisInBadPosition", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "IsButtonInBadPosition", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "CreateNewSlot", MemberParameters = new object[]
	{
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawWidgetOverlays", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetControlTextureFrame", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 70)]
	public void Draw()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA13138", Offset = "0xA13138", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public float ItemScale(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EB9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA13140", Offset = "0xA13140", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void ItemOver(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EBA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA13144", Offset = "0xA13144", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void ItemDraw(ItemGrid_Layout gridLayout, int slot, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EBB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA13148", Offset = "0xA13148", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
	private void DrawAvailableControls()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EBC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0AB50", Offset = "0xA0AB50", Length = "0xBDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawPageOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid), Member = "CalculateRegion", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "LoadControlPositions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
	public void SetPageControlsAndAdjust(GUIPageIcons.PageControlsType newType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EBD")]
	[global::Cpp2ILInjected.Address(RVA = "0xA132C4", Offset = "0xA132C4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	public void ClampControls(bool editingControls = true)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EBE")]
	[global::Cpp2ILInjected.Address(RVA = "0xA11F64", Offset = "0xA11F64", Length = "0x360")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "DrawAtPosition", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private void DrawInterfaceBacking()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EBF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA132C8", Offset = "0xA132C8", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private global::Cursor GetCursor(GUIPageIconGrouping grouping)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC0")]
	[global::Cpp2ILInjected.Address(RVA = "0xA11A0C", Offset = "0xA11A0C", Length = "0x558")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "PreviousPagePressed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "NextPagePressed", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInterfaceEdit), Member = "UpdatePageScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "TryMovingGroup", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetCursor", MemberParameters = new object[] { typeof(GUIPageIconGrouping) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	private void UpdateInterfaceMovement()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA13D40", Offset = "0xA13D40", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	private void OffsetGroupingX(float offset)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA13D84", Offset = "0xA13D84", Length = "0x538")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "TryMovingGroup", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Union", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	private Rectangle ResolveCollisions(Rectangle originalRegion, Rectangle newRegion, GUIPageIconGrouping group)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1338C", Offset = "0xA1338C", Length = "0x9B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateInterfaceMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "GetRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIconGrouping), Member = "get_LeftSideGrouping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "ResolveCollisions", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(GUIPageIconGrouping)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "InvalidateMinResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
	private void TryMovingGroup(Microsoft.Xna.Framework.Vector2 newPosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA142BC", Offset = "0xA142BC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float PageItemScale(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA14308", Offset = "0xA14308", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void PageItemOver(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA12E8C", Offset = "0xA12E8C", Length = "0x2AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DraggingControlInBadPosition", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private bool IsAxisInBadPosition(Axis_Layout AxisLayout, ref Microsoft.Xna.Framework.Vector2 mousePosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA1430C", Offset = "0xA1430C", Length = "0x10C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "CancelChanges", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::Cursor))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void CancelDrag()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA12C08", Offset = "0xA12C08", Length = "0x284")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DraggingControlInBadPosition", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private bool IsButtonInBadPosition(QuickActionButton_Layout buttonLayout, ref Microsoft.Xna.Framework.Vector2 mousePosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000EC9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA0D5C4", Offset = "0xA0D5C4", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "IsAxisInBadPosition", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "IsButtonInBadPosition", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private bool DraggingControlInBadPosition()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000ECA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA122C4", Offset = "0xA122C4", Length = "0x944")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "get_ActiveProfile", ReturnType = typeof(VirtualControlsProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsProfile_Layout), Member = "get_HardwareConfig", ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetControlTextureFrame", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType),
		typeof(ref Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(ref Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_ButtonConfiguration", ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsSlotTypeMapping_Layout), Member = "get_AxisConfiguration", ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsAxisConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsAxisConfiguration_Layout.Style) }, ReturnType = typeof(Axis_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "IsAxisInBadPosition", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsButtonConfiguration_Layout), Member = "GetStyle", MemberParameters = new object[] { typeof(VirtualControlsButtonConfiguration_Layout.Style) }, ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "IsButtonInBadPosition", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(ref Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "DrawFrame", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "GetRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetButtonRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIAxis), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Axis_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
	private void DrawControls()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001A83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private CursorInputLayer _inputLayer;

	[global::Cpp2ILInjected.Token(Token = "0x4001A84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private GUIInputRegionExclusive _optionsBlocker;

	[global::Cpp2ILInjected.Token(Token = "0x4001A85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool displayProfileOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	private bool displayHardwareOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
	public bool displayPageOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x23")]
	private bool drawnProfileOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private bool drawnHardwareOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	private bool drawnPageOptions;

	[global::Cpp2ILInjected.Token(Token = "0x4001A8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float ProfileScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float ProfileRenameScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float Profile1Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float Profile2Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private float Profile3Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private float Profile4Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A91")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float SideControls;

	[global::Cpp2ILInjected.Token(Token = "0x4001A92")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float BottomControls;

	[global::Cpp2ILInjected.Token(Token = "0x4001A93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private float HardwareScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	private float Hardware1Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private float Hardware2Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private float Hardware3Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float Hardware4Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001A98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public bool displayVCControls;

	[global::Cpp2ILInjected.Token(Token = "0x4001A99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D")]
	public bool editingName;

	[global::Cpp2ILInjected.Token(Token = "0x4001A9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private string editNameValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001A9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private int textBlinkerCount;

	[global::Cpp2ILInjected.Token(Token = "0x4001A9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private int textBlinkerState;

	[global::Cpp2ILInjected.Token(Token = "0x4001A9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private List<GUIVirtualInputControllerEdit.StyleOption> StlyeOptionsList;

	[global::Cpp2ILInjected.Token(Token = "0x4001A9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private string SelectedStyleValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001A9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private float UndoScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	private float RedoScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public float[] Scale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float SettingsScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public float leftMenuButtonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private float leftScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	private float rightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private float leftInterfaceScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	private float rightInterfaceScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private bool LeftPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4001AA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
	private bool RightPressed;

	[global::Cpp2ILInjected.Token(Token = "0x4001AAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAA")]
	private bool PendingUIControlDrag;

	[global::Cpp2ILInjected.Token(Token = "0x4001AAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	private Microsoft.Xna.Framework.Vector2 PendingUIControlDragStart;

	[global::Cpp2ILInjected.Token(Token = "0x4001AAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	private bool UIControlDrag;

	[global::Cpp2ILInjected.Token(Token = "0x4001AAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private int SelectedControl;

	[global::Cpp2ILInjected.Token(Token = "0x4001AAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private string SelectedControlStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001AAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private float TimeSinceControlChange;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	private float TimeSinceSlotChange;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	private int SelectedSlotType;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	private bool PendingUISlotDrag;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD5")]
	private bool UISlotDrag;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private Microsoft.Xna.Framework.Vector2 PendingUISlotDragStart;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private List<int> SlotOrder;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private bool drawnFromDrag;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	private float smallScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	private float mediumScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	private float largeScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ABA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	private float extraLargeScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ABB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	private float deleteScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ABC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	private List<VirtualControlsButtonConfiguration_Layout> availableButtonControls;

	[global::Cpp2ILInjected.Token(Token = "0x4001ABD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	private List<VirtualControlsAxisConfiguration_Layout> availableAxisControls;

	[global::Cpp2ILInjected.Token(Token = "0x4001ABE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	private float MappingsScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001ABF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	private float ControlsButtonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private Microsoft.Xna.Framework.Vector2 dragCursorStartLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	private Microsoft.Xna.Framework.Vector2 dragControlStartLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	private Microsoft.Xna.Framework.Vector2 dragCursorStartRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private Microsoft.Xna.Framework.Vector2 dragControlStartRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private Microsoft.Xna.Framework.Vector2 dragCursorStartInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	private Microsoft.Xna.Framework.Vector2 dragControlStartInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	private bool draggingRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x149")]
	private bool draggingRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public GUIPageIconGrouping selectedGrouping;

	[global::Cpp2ILInjected.Token(Token = "0x4001AC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	private bool draggingInterface;

	[global::Cpp2ILInjected.Token(Token = "0x4001ACA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
	public bool ControlsDirty;

	[global::Cpp2ILInjected.Token(Token = "0x4001ACB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
	public Rectangle leftControlsRegionCached;

	[global::Cpp2ILInjected.Token(Token = "0x4001ACC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
	public Rectangle rightControlsRegionCached;

	[global::Cpp2ILInjected.Token(Token = "0x4001ACD")]
	private const float visualBorderRegion = 2f;

	[global::Cpp2ILInjected.Token(Token = "0x4001ACE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x17C")]
	private bool DraggingSelectedSlot;

	[global::Cpp2ILInjected.Token(Token = "0x4001ACF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	private Microsoft.Xna.Framework.Vector2 SlotStartPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	private Microsoft.Xna.Framework.Vector2 DragStartPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	private Microsoft.Xna.Framework.Vector2 DragPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	private int SelectedSlot;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
	private bool SelectedSlotCursorActive;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD4")]
	private const int dragBufferSize = 15;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	private float DraggingScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	private float[] ControlsScales;

	[global::Cpp2ILInjected.Token(Token = "0x4001AD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private float[] DrawScales;

	[global::Cpp2ILInjected.Token(Token = "0x2000283")]
	private struct StyleOption
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001AD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string ConfigurationId;

		[global::Cpp2ILInjected.Token(Token = "0x4001AD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string DisplayValue;
	}

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000284")]
	private sealed class <>c__DisplayClass72_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA153D4", Offset = "0xA153D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "RefreshSlotOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c__DisplayClass72_0()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA153DC", Offset = "0xA153DC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualInputControllerEdit_Layout.SlotPriority), Member = "Priority", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfigurationMapping_Layout.ContolType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <RefreshSlotOrder>b__0(int e1, int e2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001ADA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public VirtualInputControllerEdit_Layout layout;
	}
}
