using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Input;

[global::Cpp2ILInjected.Token(Token = "0x20002BB")]
public class LocalUserXNAState
{
	[global::Cpp2ILInjected.Token(Token = "0x6001033")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3E474", Offset = "0xA3E474", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner.MouseStateBackup), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public LocalUserXNAState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001EFF")]
	public static LocalUserXNAState Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001F00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int scrollAccum;

	[global::Cpp2ILInjected.Token(Token = "0x4001F01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public float _uiX;

	[global::Cpp2ILInjected.Token(Token = "0x4001F02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float _uiY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float _X;

	[global::Cpp2ILInjected.Token(Token = "0x4001F04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float _Y;

	[global::Cpp2ILInjected.Token(Token = "0x4001F05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float _worldScreenOffsetY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _mouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001F07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int _mouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int _lastMouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001F09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int _lastMouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int _worldMouseX;

	[global::Cpp2ILInjected.Token(Token = "0x4001F0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int _worldMouseY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool _mouseLeft;

	[global::Cpp2ILInjected.Token(Token = "0x4001F0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	public bool _mouseRight;

	[global::Cpp2ILInjected.Token(Token = "0x4001F0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
	public bool _mouseLeftRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001F0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
	public bool _mouseRightRelease;

	[global::Cpp2ILInjected.Token(Token = "0x4001F10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int _overloadScreenWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001F11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public int _overloadScreenHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4001F12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public int _overloadScreenOffsetX;

	[global::Cpp2ILInjected.Token(Token = "0x4001F13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public int _overloadScreenOffsetY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Mouse.OverrideState _virtualCursorOverride;

	[global::Cpp2ILInjected.Token(Token = "0x4001F15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ButtonState _virtualCursorOverrideState;

	[global::Cpp2ILInjected.Token(Token = "0x4001F16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float _virtualCursorOverrideX;

	[global::Cpp2ILInjected.Token(Token = "0x4001F17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float _virtualCursorOverrideY;

	[global::Cpp2ILInjected.Token(Token = "0x4001F18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public bool _overrideRMB;

	[global::Cpp2ILInjected.Token(Token = "0x4001F19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ButtonState _rmbOverrideState;

	[global::Cpp2ILInjected.Token(Token = "0x4001F1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float scrollAccumPartial;

	[global::Cpp2ILInjected.Token(Token = "0x4001F1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public XNAUnityRunner.MouseStateBackup _uiMouseState;

	[global::Cpp2ILInjected.Token(Token = "0x4001F1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public XNAUnityRunner.MouseStateBackup _worldMouseState;

	[global::Cpp2ILInjected.Token(Token = "0x4001F1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int _lastUIFrame;
}
