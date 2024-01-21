using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000013")]
public class Cursor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 OldPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool Down;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public bool WasDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 CursorScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool Dead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool IgnoreForWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool Ignore;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public CursorInputLayer InputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public object InputLayerData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public DateTime LastUpdate;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20C5C10", Offset = "0x20C5C10", VA = "0x20C5C10")]
	public Cursor()
	{
	}
}
