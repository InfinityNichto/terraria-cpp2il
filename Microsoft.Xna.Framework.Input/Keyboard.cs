using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000293")]
public static class Keyboard
{
	[Cpp2IlInjected.Token(Token = "0x4001D63")]
	public static KeyCode[] keyCodes;

	[Cpp2IlInjected.Token(Token = "0x4001D64")]
	public static Keys[] keys;

	[Cpp2IlInjected.Token(Token = "0x4001D65")]
	public static bool keyboardActive;

	[Cpp2IlInjected.Token(Token = "0x4001D66")]
	private static List<Keys> _keys;

	[Cpp2IlInjected.Token(Token = "0x4001D67")]
	public static List<KeyCode> UnityKeys;

	[Cpp2IlInjected.Token(Token = "0x4001D68")]
	public static List<KeyCode> LastUnityKeys;

	[Cpp2IlInjected.Token(Token = "0x4001D69")]
	public static bool IgnoreEnterUntilClear;

	[Cpp2IlInjected.Token(Token = "0x60014A3")]
	[Cpp2IlInjected.Address(RVA = "0x1576308", Offset = "0x1576308", VA = "0x1576308")]
	private static KeyboardState PlatformGetState()
	{
		return default(KeyboardState);
	}

	[Cpp2IlInjected.Token(Token = "0x60014A4")]
	[Cpp2IlInjected.Address(RVA = "0x15769AC", Offset = "0x15769AC", VA = "0x15769AC")]
	internal static void SetKeys(List<Keys> keys)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014A5")]
	[Cpp2IlInjected.Address(RVA = "0x1576A28", Offset = "0x1576A28", VA = "0x1576A28")]
	public static KeyboardState GetState()
	{
		return default(KeyboardState);
	}

	[Cpp2IlInjected.Token(Token = "0x60014A6")]
	[Cpp2IlInjected.Address(RVA = "0x1576AA0", Offset = "0x1576AA0", VA = "0x1576AA0")]
	[Obsolete]
	public static KeyboardState GetState(PlayerIndex playerIndex)
	{
		return default(KeyboardState);
	}
}
