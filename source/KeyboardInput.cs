using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.IO;
using Terraria.UI;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000056")]
internal static class KeyboardInput
{
	[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FB8", Offset = "0x708FB8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void KeyboardUpdate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FBC", Offset = "0x708FBC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static bool KeyPressed(int keyCode)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
	[global::Cpp2ILInjected.Address(RVA = "0x708FC4", Offset = "0x708FC4", Length = "0x82C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "GetRawObject", ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "GetBooleanArrayElement", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public static void Update()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
	[global::Cpp2ILInjected.Address(RVA = "0x7097F0", Offset = "0x7097F0", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		"GUIEquipment.EquipmentItemType",
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "DrawCraftButton", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIItemDuplication), Member = "CraftItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMouseItem), Member = "get_IsItemDropped", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUIInputLayer), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Keyboard), Member = "PlatformGetState", ReturnType = typeof(KeyboardState))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "get_AltInUse", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "get_ShiftInUse", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "get_ControlInUse", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static bool GetKey(KeyCode keycode)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
	[global::Cpp2ILInjected.Address(RVA = "0x70989C", Offset = "0x70989C", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIJourneyModeSettings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsPauseMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICredits), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteDedicatedServer), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeletePlayer), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDeleteWorld), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILowMemoryPopup), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerHost), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerJoin), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMultiplayerLobby), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerAndGameModeMismatch), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawPlayers", MemberParameters = new object[] { typeof(List<PlayerFileData>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawWorlds", MemberParameters = new object[] { typeof(List<WorldFileData>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Lobby), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_Status), Member = "DrawStatus", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static bool GetKeyUp(KeyCode keycode)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FE8C8", Offset = "0x6FE8C8", Length = "0xD4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrKeyboard_IME), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChest), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "ItemOver", MemberParameters = new object[]
	{
		typeof(Item[]),
		typeof(int),
		"GUIEquipment.EquipmentItemType",
		typeof(int),
		typeof(ref int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuitConfirm), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionAPI_Dummy), Member = "Update", ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public static bool GetKeyDown(KeyCode keycode)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
	[global::Cpp2ILInjected.Address(RVA = "0x709970", Offset = "0x709970", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public static void KeyboardInitialise()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
	[global::Cpp2ILInjected.Address(RVA = "0x709974", Offset = "0x709974", Length = "0x32C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static KeyboardInput()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400013F")]
	private static KeyboardInput.KeyCodeMapping[] keyMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000140")]
	private static bool[] KeyStates;

	[global::Cpp2ILInjected.Token(Token = "0x4000141")]
	private static bool[] KeyStatesOld;

	[global::Cpp2ILInjected.Token(Token = "0x4000142")]
	private static AndroidJavaObject pressedStateArray;

	[global::Cpp2ILInjected.Token(Token = "0x4000143")]
	private static IntPtr pressedStateArracyValues;

	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	public enum VirtualKey
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		LeftButton,
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		RightButton,
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		Cancel,
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		MiddleButton,
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		XButton1,
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		XButton2,
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		Back = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		Tab,
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		Clear = 12,
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		Enter,
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		Shift = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		Control,
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		Menu,
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		Pause,
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		CapitalLock,
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		Kana,
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		Hangul = 21,
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		Junja = 23,
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		Final,
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		Hanja,
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		Kanji = 25,
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		Escape = 27,
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		Convert,
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		NonConvert,
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		Accept,
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		ModeChange,
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		Space,
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		PageUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		PageDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		End,
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		Home,
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		Left,
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		Up,
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		Right,
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		Down,
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		Select,
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		Print,
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		Execute,
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		Snapshot,
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		Insert,
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		Delete,
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		Help,
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		Number0,
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		Number1,
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		Number2,
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		Number3,
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		Number4,
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		Number5,
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		Number6,
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		Number7,
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		Number8,
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		Number9,
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		A = 65,
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		B,
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		C,
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		D,
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		E,
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		F,
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		G,
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		H,
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		I,
		[global::Cpp2ILInjected.Token(Token = "0x4000183")]
		J,
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		K,
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		L,
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		M,
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		N,
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		O,
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		P,
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		Q,
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		R,
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		S,
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		T,
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		U,
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		V,
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		W,
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		X,
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		Y,
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		Z,
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		LeftWindows,
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		RightWindows,
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		Application,
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		Sleep = 95,
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		NumberPad0,
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		NumberPad1,
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		NumberPad2,
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		NumberPad3,
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		NumberPad4,
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		NumberPad5,
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		NumberPad6,
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		NumberPad7,
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		NumberPad8,
		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		NumberPad9,
		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		Multiply,
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		Add,
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		Separator,
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		Subtract,
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		Decimal,
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		Divide,
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		F1,
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		F2,
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		F3,
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		F4,
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		F5,
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		F6,
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		F7,
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		F8,
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		F9,
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		F10,
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		F11,
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		F12,
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		F13,
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		F14,
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		F15,
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		F16,
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		F17,
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		F18,
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		F19,
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		F20,
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		F21,
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		F22,
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		F23,
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		F24,
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		NumberKeyLock = 144,
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		Scroll,
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		LeftShift = 160,
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		RightShift,
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		LeftControl,
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		RightControl,
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		LeftMenu,
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		RightMenu,
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		Semicolon = 186,
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		Equals,
		[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
		Comma,
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		Minus,
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		Period,
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		Slash,
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		BackQuote,
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		LeftBracket = 219,
		[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
		RightBracket = 221,
		[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
		Quote,
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		Backslash = 226
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000058")]
	public struct KeyCodeMapping
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x709CA0", Offset = "0x709CA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public KeyCodeMapping(KeyboardInput.VirtualKey vKey, KeyCode code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public KeyCode keyCode;

		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public KeyboardInput.VirtualKey virtualKey;
	}
}
