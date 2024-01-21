using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200002E")]
public class iOS_Mouse
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool wasMouseConnected;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 lastUnityMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3 MousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MouseLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool MouseRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool MouseMiddle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool MouseLeftPrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool MouseRightPrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool MouseMiddlePrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float MouseScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool UseSWCursor;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1504C10", Offset = "0x1504C10", VA = "0x1504C10")]
	public void Setup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1504C18", Offset = "0x1504C18", VA = "0x1504C18")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1504DBC", Offset = "0x1504DBC", VA = "0x1504DBC")]
	public iOS_Mouse()
	{
	}
}
