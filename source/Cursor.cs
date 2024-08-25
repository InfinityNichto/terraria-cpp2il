using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000013")]
public class Cursor
{
	[global::Cpp2ILInjected.Token(Token = "0x6000055")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FBD98", Offset = "0x6FBD98", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Cursor()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400003A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Vector2 Position;

	[global::Cpp2ILInjected.Token(Token = "0x400003B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 OldPosition;

	[global::Cpp2ILInjected.Token(Token = "0x400003C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int Id;

	[global::Cpp2ILInjected.Token(Token = "0x400003D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool Down;

	[global::Cpp2ILInjected.Token(Token = "0x400003E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	public bool WasDown;

	[global::Cpp2ILInjected.Token(Token = "0x400003F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 CursorScroll;

	[global::Cpp2ILInjected.Token(Token = "0x4000040")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool Dead;

	[global::Cpp2ILInjected.Token(Token = "0x4000041")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public bool IgnoreForWorld;

	[global::Cpp2ILInjected.Token(Token = "0x4000042")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
	public bool Ignore;

	[global::Cpp2ILInjected.Token(Token = "0x4000043")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public CursorInputLayer InputLayer;

	[global::Cpp2ILInjected.Token(Token = "0x4000044")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public object InputLayerData;

	[global::Cpp2ILInjected.Token(Token = "0x4000045")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DateTime LastUpdate;
}
