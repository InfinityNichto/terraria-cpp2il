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

[global::Cpp2ILInjected.Token(Token = "0x200018A")]
public class GUIKeyboardMappings
{
	[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
	public bool KeyboardEnabled
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A70F0", Offset = "0x9A70F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A70F8", Offset = "0x9A70F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B22")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6D48", Offset = "0x9A6D48", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void RegisterOverlay(GUIKeyboardMappingEntry entry, Rectangle region)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B23")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A7158", Offset = "0x9A7158", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "MapKey", MemberParameters = new object[]
	{
		typeof(KeyCode),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private ControllerActionButton CreateButtonMapping(string id)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
	public bool EscapeOpensInventory
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A729C", Offset = "0x9A729C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A72A4", Offset = "0x9A72A4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B26")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A72C0", Offset = "0x9A72C0", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetEntry", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ControllerActionButton.Entry))]
	public void SetupEscapeKeySetting()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B27")]
	[global::Cpp2ILInjected.Address(RVA = "0x999C40", Offset = "0x999C40", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_IME), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteDedicatedServer), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeletePlayer), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteWorld), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILowMemoryPopup), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Rectangle),
		typeof(int),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
	public void DisableEscapeKeyUsage()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B28")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A7328", Offset = "0x9A7328", Length = "0x704")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateAxisMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(ControllerActionAxis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "MapKeys", MemberParameters = new object[]
	{
		typeof(KeyCode),
		typeof(KeyCode)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "CreateVectorMapping", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ControllerActionAxis),
		typeof(ControllerActionAxis)
	}, ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetVectorMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionVector))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "MapKey", MemberParameters = new object[]
	{
		typeof(KeyCode),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "LoadDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "SetupEscapeKeySetting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
	public void SetupMappings()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B29")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A7D78", Offset = "0x9A7D78", Length = "0x1DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(string)
	}, ReturnType = typeof(object))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	private KeyCode LoadKeyCode(Preferences preferences, string id, ref bool loaded)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B2A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A7F54", Offset = "0x9A7F54", Length = "0x290")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "LoadKeyCode", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(string),
		typeof(ref bool)
	}, ReturnType = typeof(KeyCode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "LoadDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void LoadConfiguration(Preferences preferences)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B2B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A81E4", Offset = "0x9A81E4", Length = "0x2F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public void SaveConfiguration(Preferences preferences)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B2C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A7A2C", Offset = "0x9A7A2C", Length = "0x34C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	public void LoadDefaults()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B2D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6D80", Offset = "0x9A6D80", Length = "0x200")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void ClearBinding(KeyCode key)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B2E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A84D4", Offset = "0x9A84D4", Length = "0x274")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "GainFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DrawCategoryOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DrawTitle", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void Draw()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B2F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A9844", Offset = "0x9A9844", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "IsOverCategories", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void LooseFocus()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B30")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A8748", Offset = "0x9A8748", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x6000B31")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A98AC", Offset = "0x9A98AC", Length = "0x14C")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "LooseFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B32")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A8E5C", Offset = "0x9A8E5C", Length = "0x570")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "SetCategory", MemberParameters = new object[] { typeof(KeyboardMappingsCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "Activate", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x6000B33")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA058", Offset = "0x9AA058", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public void Close()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B34")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA064", Offset = "0x9AA064", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "get_Binding", ReturnType = typeof(KeyCode))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Backup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B35")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA0F8", Offset = "0x9AA0F8", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "ShutdownUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "set_Binding", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void RestoreBackup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B36")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A93CC", Offset = "0x9A93CC", Length = "0x478")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "LoadDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private void DrawMainButtons()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B37")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA180", Offset = "0x9AA180", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void ClearMapping()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B38")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A8AA0", Offset = "0x9A8AA0", Length = "0x3BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x6000B39")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A87F4", Offset = "0x9A87F4", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x6000B3A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A888C", Offset = "0x9A888C", Length = "0x214")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
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

	[global::Cpp2ILInjected.Token(Token = "0x6000B3B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA20C", Offset = "0x9AA20C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private float SettingScale(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B3C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA214", Offset = "0x9AA214", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void SettingOver(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B3D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA218", Offset = "0x9AA218", Length = "0x14C")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B3E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA364", Offset = "0x9AA364", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B3F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A99F8", Offset = "0x9A99F8", Length = "0x660")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = ".ctor", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
	public void SetCategory(KeyboardMappingsCategories_Layout.Category category)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B40")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA444", Offset = "0x9AA444", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_01_WelcomeDialogue), Member = "Update", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_02_CopperPickaxe), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_03_CraftWorkbench), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_04_CraftDoorAndChair), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_05_Torches), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_07_Armour), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_08_KillZombies), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_09_Bestiary), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_10_Settings), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TutorialStep_11_Complete), Member = "GetGuideString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static string GetControlTag(ControlsKeyboardTagHandler.MappingType mappingType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B41")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AA4C4", Offset = "0x9AA4C4", Length = "0x1160")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public GUIKeyboardMappings()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000BA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool _keyboardEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000BA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIKeyboardMappingOverlay _controllerInput;

	[global::Cpp2ILInjected.Token(Token = "0x4000BA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GUIKeyboardMappingEntry overlayEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4000BA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private Rectangle overlayRegion;

	[global::Cpp2ILInjected.Token(Token = "0x4000BA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool Enabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000BAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
	public bool performingBinding;

	[global::Cpp2ILInjected.Token(Token = "0x4000BAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private int disableScroll;

	[global::Cpp2ILInjected.Token(Token = "0x4000BAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ControllerActionAxis MovementAxisX;

	[global::Cpp2ILInjected.Token(Token = "0x4000BAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ControllerActionAxis MovementAxisY;

	[global::Cpp2ILInjected.Token(Token = "0x4000BAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ControllerActionVector MovementAxis;

	[global::Cpp2ILInjected.Token(Token = "0x4000BAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ControllerActionButton GrappleFire;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ControllerActionButton Jump;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ControllerActionButton Fire;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ControllerActionButton Interact;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ControllerActionButton TargetLockOn;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ControllerActionButton InventoryToggle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public ControllerActionButton AutoSelect;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public ControllerActionButton SmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public ControllerActionButton Settings;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ControllerActionButton HotbarNext;

	[global::Cpp2ILInjected.Token(Token = "0x4000BB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public ControllerActionButton HotbarPrevious;

	[global::Cpp2ILInjected.Token(Token = "0x4000BBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public ControllerActionButton LeftPageCycle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BBB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public ControllerActionButton RightPageCycle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BBC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public ControllerActionButton ZoomIn;

	[global::Cpp2ILInjected.Token(Token = "0x4000BBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public ControllerActionButton ZoomOut;

	[global::Cpp2ILInjected.Token(Token = "0x4000BBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public ControllerActionButton MapZoomIn;

	[global::Cpp2ILInjected.Token(Token = "0x4000BBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public ControllerActionButton MapZoomOut;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public ControllerActionButton MapZoomDefault;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public ControllerActionButton QuickMount;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public ControllerActionButton QuickHeal;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public ControllerActionButton QuickBuff;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public ControllerActionButton QuickMana;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public ControllerActionButton MapToggle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public ControllerActionButton MiniMapToggle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public ControllerActionButton ChatToggle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public ControllerActionButton Hotbar1;

	[global::Cpp2ILInjected.Token(Token = "0x4000BC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public ControllerActionButton Hotbar2;

	[global::Cpp2ILInjected.Token(Token = "0x4000BCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public ControllerActionButton Hotbar3;

	[global::Cpp2ILInjected.Token(Token = "0x4000BCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public ControllerActionButton Hotbar4;

	[global::Cpp2ILInjected.Token(Token = "0x4000BCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public ControllerActionButton Hotbar5;

	[global::Cpp2ILInjected.Token(Token = "0x4000BCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public ControllerActionButton Hotbar6;

	[global::Cpp2ILInjected.Token(Token = "0x4000BCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public ControllerActionButton Hotbar7;

	[global::Cpp2ILInjected.Token(Token = "0x4000BCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public ControllerActionButton Hotbar8;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public ControllerActionButton Hotbar9;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public ControllerActionButton Hotbar10;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public ControllerActionButton Loadout1;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public ControllerActionButton Loadout2;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public ControllerActionButton Loadout3;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public ControllerActionButton LoadoutCycle;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	private List<ControllerActionButton> AllButtonMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	private bool _escapeOpensInventory;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
	private float TimeSinceItemChange;

	[global::Cpp2ILInjected.Token(Token = "0x4000BD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	private KeyboardMappingsCategories_Layout.Category[] TabOrder;

	[global::Cpp2ILInjected.Token(Token = "0x4000BDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public KeyboardMappingsCategories_Layout.Category Selected;

	[global::Cpp2ILInjected.Token(Token = "0x4000BDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
	private float GameplayButtonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000BDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	private float UIButtonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000BDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	private float SaveAndCloseButtonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000BDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	private float ResetSettingsButtonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000BDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1BC")]
	private float titleScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public float ScrollOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C4")]
	private float ScrollMomentum;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	private int ScrollDragging;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1CC")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public List<GUIKeyboardMappingEntry> _allSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public List<GUIKeyboardMappingEntry> _categorySettings;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	private bool hasFocus;

	[global::Cpp2ILInjected.Token(Token = "0x4000BE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	private GUIInputRegionExclusive _categoriesBlocker;

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200018B")]
	[Serializable]
	private sealed class <>c
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AB624", Offset = "0x9AB624", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AB680", Offset = "0x9AB680", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AB688", Offset = "0x9AB688", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		internal int <SetCategory>b__100_0(GUIKeyboardMappingEntry e1, GUIKeyboardMappingEntry e2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BE8")]
		public static readonly GUIKeyboardMappings.<>c <>9;

		[global::Cpp2ILInjected.Token(Token = "0x4000BE9")]
		public static Comparison<GUIKeyboardMappingEntry> <>9__100_0;
	}
}
