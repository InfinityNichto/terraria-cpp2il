using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000294")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x384C74", Offset = "0x384C74")]
public struct KeyboardState
{
	[Cpp2IlInjected.Token(Token = "0x4001D6A")]
	private static Keys[] empty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001D6B")]
	private uint keys0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001D6C")]
	private uint keys1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001D6D")]
	private uint keys2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001D6E")]
	private uint keys3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001D6F")]
	private uint keys4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001D70")]
	private uint keys5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001D71")]
	private uint keys6;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001D72")]
	private uint keys7;

	[Cpp2IlInjected.Token(Token = "0x4001D75")]
	private static Keys[] keysArray1;

	[Cpp2IlInjected.Token(Token = "0x4001D76")]
	private static Keys[] keysArray2;

	[Cpp2IlInjected.Token(Token = "0x4001D77")]
	private static Keys[] keysArray3;

	[Cpp2IlInjected.Token(Token = "0x4001D78")]
	private static Keys[] keysArray4;

	[Cpp2IlInjected.Token(Token = "0x4001D79")]
	private static Keys[] keysArray5;

	[Cpp2IlInjected.Token(Token = "0x4001D7A")]
	private static Keys[] keysArray6;

	[Cpp2IlInjected.Token(Token = "0x4001D7B")]
	private static Keys[] keysArray7;

	[Cpp2IlInjected.Token(Token = "0x4001D7C")]
	private static Keys[] keysArray8;

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public bool CapsLock
	{
		[Cpp2IlInjected.Token(Token = "0x60014AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A20AC", Offset = "0x3A20AC", VA = "0x3A20AC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60014AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A20B4", Offset = "0x3A20B4", VA = "0x3A20B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public bool NumLock
	{
		[Cpp2IlInjected.Token(Token = "0x60014AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A20BC", Offset = "0x3A20BC", VA = "0x3A20BC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60014AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A20C4", Offset = "0x3A20C4", VA = "0x3A20C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public KeyState Item
	{
		[Cpp2IlInjected.Token(Token = "0x60014B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A210C", Offset = "0x3A210C", VA = "0x3A210C")]
		get
		{
			return default(KeyState);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60014A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A207C", Offset = "0x3A207C", VA = "0x3A207C")]
	private bool InternalGetKey(Keys key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60014A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A2084", Offset = "0x3A2084", VA = "0x3A2084")]
	internal void InternalSetKey(Keys key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A208C", Offset = "0x3A208C", VA = "0x3A208C")]
	internal void InternalClearKey(Keys key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A2094", Offset = "0x3A2094", VA = "0x3A2094")]
	internal void InternalClearAllKeys()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A20CC", Offset = "0x3A20CC", VA = "0x3A20CC")]
	internal KeyboardState(List<Keys> keys, bool capsLock = false, bool numLock = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A20E8", Offset = "0x3A20E8", VA = "0x3A20E8")]
	public KeyboardState(Keys[] keys, bool capsLock = false, bool numLock = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A2104", Offset = "0x3A2104", VA = "0x3A2104")]
	public KeyboardState(params Keys[] keys)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60014B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A2120", Offset = "0x3A2120", VA = "0x3A2120")]
	public bool IsKeyDown(Keys key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60014B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A2128", Offset = "0x3A2128", VA = "0x3A2128")]
	public bool IsKeyUp(Keys key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60014B6")]
	[Cpp2IlInjected.Address(RVA = "0x1576F8C", Offset = "0x1576F8C", VA = "0x1576F8C")]
	private static uint CountBits(uint v)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60014B7")]
	[Cpp2IlInjected.Address(RVA = "0x1576FD4", Offset = "0x1576FD4", VA = "0x1576FD4")]
	private static int AddKeysToArray(uint keys, int offset, Keys[] pressedKeys, int index)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60014B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A2140", Offset = "0x3A2140", VA = "0x3A2140")]
	public Keys[] GetPressedKeys()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60014B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A2148", Offset = "0x3A2148", VA = "0x3A2148", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60014BA")]
	[Cpp2IlInjected.Address(RVA = "0x1577620", Offset = "0x1577620", VA = "0x1577620")]
	public static bool operator ==(KeyboardState a, KeyboardState b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60014BB")]
	[Cpp2IlInjected.Address(RVA = "0x1577698", Offset = "0x1577698", VA = "0x1577698")]
	public static bool operator !=(KeyboardState a, KeyboardState b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60014BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A2190", Offset = "0x3A2190", VA = "0x3A2190", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}
}
