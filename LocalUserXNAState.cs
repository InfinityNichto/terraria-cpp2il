using Cpp2IlInjected;
using Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x2000215")]
public class LocalUserXNAState
{
	[Cpp2IlInjected.Token(Token = "0x40019DA")]
	public static LocalUserXNAState Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40019DB")]
	public int scrollAccum;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40019DC")]
	public float _uiX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40019DD")]
	public float _uiY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40019DE")]
	public float _X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40019DF")]
	public float _Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40019E0")]
	public float _worldScreenOffsetY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40019E1")]
	public int _mouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40019E2")]
	public int _mouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40019E3")]
	public int _lastMouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40019E4")]
	public int _lastMouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40019E5")]
	public int _worldMouseX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40019E6")]
	public int _worldMouseY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40019E7")]
	public bool _mouseLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40019E8")]
	public bool _mouseRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x40019E9")]
	public bool _mouseLeftRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
	[Cpp2IlInjected.Token(Token = "0x40019EA")]
	public bool _mouseRightRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40019EB")]
	public int _overloadScreenWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40019EC")]
	public int _overloadScreenHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40019ED")]
	public int _overloadScreenOffsetX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40019EE")]
	public int _overloadScreenOffsetY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40019EF")]
	public Mouse.OverrideState _virtualCursorOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40019F0")]
	public ButtonState _virtualCursorOverrideState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40019F1")]
	public float _virtualCursorOverrideX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40019F2")]
	public float _virtualCursorOverrideY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40019F3")]
	public bool _overrideRMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40019F4")]
	public ButtonState _rmbOverrideState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40019F5")]
	public float scrollAccumPartial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40019F6")]
	public XNAUnityRunner.MouseStateBackup _uiMouseState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40019F7")]
	public XNAUnityRunner.MouseStateBackup _worldMouseState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40019F8")]
	public int _lastUIFrame;

	[Cpp2IlInjected.Token(Token = "0x6000F14")]
	[Cpp2IlInjected.Address(RVA = "0x12DC9D0", Offset = "0x12DC9D0", VA = "0x12DC9D0")]
	public LocalUserXNAState()
	{
	}
}
