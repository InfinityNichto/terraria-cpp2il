using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class KeyboardInput
{
	[Cpp2IlInjected.Token(Token = "0x2000779")]
	public enum VirtualKey
	{
		[Cpp2IlInjected.Token(Token = "0x400782C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400782D")]
		LeftButton = 1,
		[Cpp2IlInjected.Token(Token = "0x400782E")]
		RightButton = 2,
		[Cpp2IlInjected.Token(Token = "0x400782F")]
		Cancel = 3,
		[Cpp2IlInjected.Token(Token = "0x4007830")]
		MiddleButton = 4,
		[Cpp2IlInjected.Token(Token = "0x4007831")]
		XButton1 = 5,
		[Cpp2IlInjected.Token(Token = "0x4007832")]
		XButton2 = 6,
		[Cpp2IlInjected.Token(Token = "0x4007833")]
		Back = 8,
		[Cpp2IlInjected.Token(Token = "0x4007834")]
		Tab = 9,
		[Cpp2IlInjected.Token(Token = "0x4007835")]
		Clear = 12,
		[Cpp2IlInjected.Token(Token = "0x4007836")]
		Enter = 13,
		[Cpp2IlInjected.Token(Token = "0x4007837")]
		Shift = 16,
		[Cpp2IlInjected.Token(Token = "0x4007838")]
		Control = 17,
		[Cpp2IlInjected.Token(Token = "0x4007839")]
		Menu = 18,
		[Cpp2IlInjected.Token(Token = "0x400783A")]
		Pause = 19,
		[Cpp2IlInjected.Token(Token = "0x400783B")]
		CapitalLock = 20,
		[Cpp2IlInjected.Token(Token = "0x400783C")]
		Kana = 21,
		[Cpp2IlInjected.Token(Token = "0x400783D")]
		Hangul = 21,
		[Cpp2IlInjected.Token(Token = "0x400783E")]
		Junja = 23,
		[Cpp2IlInjected.Token(Token = "0x400783F")]
		Final = 24,
		[Cpp2IlInjected.Token(Token = "0x4007840")]
		Hanja = 25,
		[Cpp2IlInjected.Token(Token = "0x4007841")]
		Kanji = 25,
		[Cpp2IlInjected.Token(Token = "0x4007842")]
		Escape = 27,
		[Cpp2IlInjected.Token(Token = "0x4007843")]
		Convert = 28,
		[Cpp2IlInjected.Token(Token = "0x4007844")]
		NonConvert = 29,
		[Cpp2IlInjected.Token(Token = "0x4007845")]
		Accept = 30,
		[Cpp2IlInjected.Token(Token = "0x4007846")]
		ModeChange = 31,
		[Cpp2IlInjected.Token(Token = "0x4007847")]
		Space = 32,
		[Cpp2IlInjected.Token(Token = "0x4007848")]
		PageUp = 33,
		[Cpp2IlInjected.Token(Token = "0x4007849")]
		PageDown = 34,
		[Cpp2IlInjected.Token(Token = "0x400784A")]
		End = 35,
		[Cpp2IlInjected.Token(Token = "0x400784B")]
		Home = 36,
		[Cpp2IlInjected.Token(Token = "0x400784C")]
		Left = 37,
		[Cpp2IlInjected.Token(Token = "0x400784D")]
		Up = 38,
		[Cpp2IlInjected.Token(Token = "0x400784E")]
		Right = 39,
		[Cpp2IlInjected.Token(Token = "0x400784F")]
		Down = 40,
		[Cpp2IlInjected.Token(Token = "0x4007850")]
		Select = 41,
		[Cpp2IlInjected.Token(Token = "0x4007851")]
		Print = 42,
		[Cpp2IlInjected.Token(Token = "0x4007852")]
		Execute = 43,
		[Cpp2IlInjected.Token(Token = "0x4007853")]
		Snapshot = 44,
		[Cpp2IlInjected.Token(Token = "0x4007854")]
		Insert = 45,
		[Cpp2IlInjected.Token(Token = "0x4007855")]
		Delete = 46,
		[Cpp2IlInjected.Token(Token = "0x4007856")]
		Help = 47,
		[Cpp2IlInjected.Token(Token = "0x4007857")]
		Number0 = 48,
		[Cpp2IlInjected.Token(Token = "0x4007858")]
		Number1 = 49,
		[Cpp2IlInjected.Token(Token = "0x4007859")]
		Number2 = 50,
		[Cpp2IlInjected.Token(Token = "0x400785A")]
		Number3 = 51,
		[Cpp2IlInjected.Token(Token = "0x400785B")]
		Number4 = 52,
		[Cpp2IlInjected.Token(Token = "0x400785C")]
		Number5 = 53,
		[Cpp2IlInjected.Token(Token = "0x400785D")]
		Number6 = 54,
		[Cpp2IlInjected.Token(Token = "0x400785E")]
		Number7 = 55,
		[Cpp2IlInjected.Token(Token = "0x400785F")]
		Number8 = 56,
		[Cpp2IlInjected.Token(Token = "0x4007860")]
		Number9 = 57,
		[Cpp2IlInjected.Token(Token = "0x4007861")]
		A = 65,
		[Cpp2IlInjected.Token(Token = "0x4007862")]
		B = 66,
		[Cpp2IlInjected.Token(Token = "0x4007863")]
		C = 67,
		[Cpp2IlInjected.Token(Token = "0x4007864")]
		D = 68,
		[Cpp2IlInjected.Token(Token = "0x4007865")]
		E = 69,
		[Cpp2IlInjected.Token(Token = "0x4007866")]
		F = 70,
		[Cpp2IlInjected.Token(Token = "0x4007867")]
		G = 71,
		[Cpp2IlInjected.Token(Token = "0x4007868")]
		H = 72,
		[Cpp2IlInjected.Token(Token = "0x4007869")]
		I = 73,
		[Cpp2IlInjected.Token(Token = "0x400786A")]
		J = 74,
		[Cpp2IlInjected.Token(Token = "0x400786B")]
		K = 75,
		[Cpp2IlInjected.Token(Token = "0x400786C")]
		L = 76,
		[Cpp2IlInjected.Token(Token = "0x400786D")]
		M = 77,
		[Cpp2IlInjected.Token(Token = "0x400786E")]
		N = 78,
		[Cpp2IlInjected.Token(Token = "0x400786F")]
		O = 79,
		[Cpp2IlInjected.Token(Token = "0x4007870")]
		P = 80,
		[Cpp2IlInjected.Token(Token = "0x4007871")]
		Q = 81,
		[Cpp2IlInjected.Token(Token = "0x4007872")]
		R = 82,
		[Cpp2IlInjected.Token(Token = "0x4007873")]
		S = 83,
		[Cpp2IlInjected.Token(Token = "0x4007874")]
		T = 84,
		[Cpp2IlInjected.Token(Token = "0x4007875")]
		U = 85,
		[Cpp2IlInjected.Token(Token = "0x4007876")]
		V = 86,
		[Cpp2IlInjected.Token(Token = "0x4007877")]
		W = 87,
		[Cpp2IlInjected.Token(Token = "0x4007878")]
		X = 88,
		[Cpp2IlInjected.Token(Token = "0x4007879")]
		Y = 89,
		[Cpp2IlInjected.Token(Token = "0x400787A")]
		Z = 90,
		[Cpp2IlInjected.Token(Token = "0x400787B")]
		LeftWindows = 91,
		[Cpp2IlInjected.Token(Token = "0x400787C")]
		RightWindows = 92,
		[Cpp2IlInjected.Token(Token = "0x400787D")]
		Application = 93,
		[Cpp2IlInjected.Token(Token = "0x400787E")]
		Sleep = 95,
		[Cpp2IlInjected.Token(Token = "0x400787F")]
		NumberPad0 = 96,
		[Cpp2IlInjected.Token(Token = "0x4007880")]
		NumberPad1 = 97,
		[Cpp2IlInjected.Token(Token = "0x4007881")]
		NumberPad2 = 98,
		[Cpp2IlInjected.Token(Token = "0x4007882")]
		NumberPad3 = 99,
		[Cpp2IlInjected.Token(Token = "0x4007883")]
		NumberPad4 = 100,
		[Cpp2IlInjected.Token(Token = "0x4007884")]
		NumberPad5 = 101,
		[Cpp2IlInjected.Token(Token = "0x4007885")]
		NumberPad6 = 102,
		[Cpp2IlInjected.Token(Token = "0x4007886")]
		NumberPad7 = 103,
		[Cpp2IlInjected.Token(Token = "0x4007887")]
		NumberPad8 = 104,
		[Cpp2IlInjected.Token(Token = "0x4007888")]
		NumberPad9 = 105,
		[Cpp2IlInjected.Token(Token = "0x4007889")]
		Multiply = 106,
		[Cpp2IlInjected.Token(Token = "0x400788A")]
		Add = 107,
		[Cpp2IlInjected.Token(Token = "0x400788B")]
		Separator = 108,
		[Cpp2IlInjected.Token(Token = "0x400788C")]
		Subtract = 109,
		[Cpp2IlInjected.Token(Token = "0x400788D")]
		Decimal = 110,
		[Cpp2IlInjected.Token(Token = "0x400788E")]
		Divide = 111,
		[Cpp2IlInjected.Token(Token = "0x400788F")]
		F1 = 112,
		[Cpp2IlInjected.Token(Token = "0x4007890")]
		F2 = 113,
		[Cpp2IlInjected.Token(Token = "0x4007891")]
		F3 = 114,
		[Cpp2IlInjected.Token(Token = "0x4007892")]
		F4 = 115,
		[Cpp2IlInjected.Token(Token = "0x4007893")]
		F5 = 116,
		[Cpp2IlInjected.Token(Token = "0x4007894")]
		F6 = 117,
		[Cpp2IlInjected.Token(Token = "0x4007895")]
		F7 = 118,
		[Cpp2IlInjected.Token(Token = "0x4007896")]
		F8 = 119,
		[Cpp2IlInjected.Token(Token = "0x4007897")]
		F9 = 120,
		[Cpp2IlInjected.Token(Token = "0x4007898")]
		F10 = 121,
		[Cpp2IlInjected.Token(Token = "0x4007899")]
		F11 = 122,
		[Cpp2IlInjected.Token(Token = "0x400789A")]
		F12 = 123,
		[Cpp2IlInjected.Token(Token = "0x400789B")]
		F13 = 124,
		[Cpp2IlInjected.Token(Token = "0x400789C")]
		F14 = 125,
		[Cpp2IlInjected.Token(Token = "0x400789D")]
		F15 = 126,
		[Cpp2IlInjected.Token(Token = "0x400789E")]
		F16 = 127,
		[Cpp2IlInjected.Token(Token = "0x400789F")]
		F17 = 128,
		[Cpp2IlInjected.Token(Token = "0x40078A0")]
		F18 = 129,
		[Cpp2IlInjected.Token(Token = "0x40078A1")]
		F19 = 130,
		[Cpp2IlInjected.Token(Token = "0x40078A2")]
		F20 = 131,
		[Cpp2IlInjected.Token(Token = "0x40078A3")]
		F21 = 132,
		[Cpp2IlInjected.Token(Token = "0x40078A4")]
		F22 = 133,
		[Cpp2IlInjected.Token(Token = "0x40078A5")]
		F23 = 134,
		[Cpp2IlInjected.Token(Token = "0x40078A6")]
		F24 = 135,
		[Cpp2IlInjected.Token(Token = "0x40078A7")]
		NumberKeyLock = 144,
		[Cpp2IlInjected.Token(Token = "0x40078A8")]
		Scroll = 145,
		[Cpp2IlInjected.Token(Token = "0x40078A9")]
		LeftShift = 160,
		[Cpp2IlInjected.Token(Token = "0x40078AA")]
		RightShift = 161,
		[Cpp2IlInjected.Token(Token = "0x40078AB")]
		LeftControl = 162,
		[Cpp2IlInjected.Token(Token = "0x40078AC")]
		RightControl = 163,
		[Cpp2IlInjected.Token(Token = "0x40078AD")]
		LeftMenu = 164,
		[Cpp2IlInjected.Token(Token = "0x40078AE")]
		RightMenu = 165,
		[Cpp2IlInjected.Token(Token = "0x40078AF")]
		Semicolon = 186,
		[Cpp2IlInjected.Token(Token = "0x40078B0")]
		Equals = 187,
		[Cpp2IlInjected.Token(Token = "0x40078B1")]
		Comma = 188,
		[Cpp2IlInjected.Token(Token = "0x40078B2")]
		Minus = 189,
		[Cpp2IlInjected.Token(Token = "0x40078B3")]
		Period = 190,
		[Cpp2IlInjected.Token(Token = "0x40078B4")]
		Slash = 191,
		[Cpp2IlInjected.Token(Token = "0x40078B5")]
		BackQuote = 192,
		[Cpp2IlInjected.Token(Token = "0x40078B6")]
		LeftBracket = 219,
		[Cpp2IlInjected.Token(Token = "0x40078B7")]
		RightBracket = 221,
		[Cpp2IlInjected.Token(Token = "0x40078B8")]
		Quote = 222,
		[Cpp2IlInjected.Token(Token = "0x40078B9")]
		Backslash = 226
	}

	[Cpp2IlInjected.Token(Token = "0x200077A")]
	public struct KeyCodeMapping
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40078BA")]
		public KeyCode keyCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40078BB")]
		public VirtualKey virtualKey;

		[Cpp2IlInjected.Token(Token = "0x6004893")]
		[Cpp2IlInjected.Address(RVA = "0x39E264", Offset = "0x39E264", VA = "0x39E264")]
		public KeyCodeMapping(VirtualKey vKey, KeyCode code)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static KeyCodeMapping[] keyMappings;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static bool[] KeyStates;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static bool[] KeyStatesOld;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static AndroidJavaObject pressedStateArray;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static IntPtr pressedStateArracyValues;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1178CA0", Offset = "0x1178CA0", VA = "0x1178CA0")]
	public static bool KeyPressed(int keyCode)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1178CA8", Offset = "0x1178CA8", VA = "0x1178CA8")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1179458", Offset = "0x1179458", VA = "0x1179458")]
	public static bool GetKey(KeyCode keycode)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x116A114", Offset = "0x116A114", VA = "0x116A114")]
	public static bool GetKeyUp(KeyCode keycode)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x117952C", Offset = "0x117952C", VA = "0x117952C")]
	public static bool GetKeyDown(KeyCode keycode)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x117963C", Offset = "0x117963C", VA = "0x117963C")]
	public static void KeyboardInitialise()
	{
	}
}
