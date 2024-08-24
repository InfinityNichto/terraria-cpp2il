using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000214 RID: 532
[global::Cpp2ILInjected.Token(Token = "0x20002BB")]
public class LocalUserXNAState
{
	// Token: 0x06000F00 RID: 3840 RVA: 0x000247FD File Offset: 0x000229FD
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

	// Token: 0x040019D1 RID: 6609
	[global::Cpp2ILInjected.Token(Token = "0x4001EFF")]
	public static LocalUserXNAState Instance;

	// Token: 0x040019D2 RID: 6610
	[global::Cpp2ILInjected.Token(Token = "0x4001F00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public int scrollAccum;

	// Token: 0x040019D3 RID: 6611
	[global::Cpp2ILInjected.Token(Token = "0x4001F01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public float _uiX;

	// Token: 0x040019D4 RID: 6612
	[global::Cpp2ILInjected.Token(Token = "0x4001F02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float _uiY;

	// Token: 0x040019D5 RID: 6613
	[global::Cpp2ILInjected.Token(Token = "0x4001F03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float _X;

	// Token: 0x040019D6 RID: 6614
	[global::Cpp2ILInjected.Token(Token = "0x4001F04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float _Y;

	// Token: 0x040019D7 RID: 6615
	[global::Cpp2ILInjected.Token(Token = "0x4001F05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float _worldScreenOffsetY;

	// Token: 0x040019D8 RID: 6616
	[global::Cpp2ILInjected.Token(Token = "0x4001F06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int _mouseX;

	// Token: 0x040019D9 RID: 6617
	[global::Cpp2ILInjected.Token(Token = "0x4001F07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int _mouseY;

	// Token: 0x040019DA RID: 6618
	[global::Cpp2ILInjected.Token(Token = "0x4001F08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int _lastMouseX;

	// Token: 0x040019DB RID: 6619
	[global::Cpp2ILInjected.Token(Token = "0x4001F09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int _lastMouseY;

	// Token: 0x040019DC RID: 6620
	[global::Cpp2ILInjected.Token(Token = "0x4001F0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public int _worldMouseX;

	// Token: 0x040019DD RID: 6621
	[global::Cpp2ILInjected.Token(Token = "0x4001F0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public int _worldMouseY;

	// Token: 0x040019DE RID: 6622
	[global::Cpp2ILInjected.Token(Token = "0x4001F0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool _mouseLeft;

	// Token: 0x040019DF RID: 6623
	[global::Cpp2ILInjected.Token(Token = "0x4001F0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	public bool _mouseRight;

	// Token: 0x040019E0 RID: 6624
	[global::Cpp2ILInjected.Token(Token = "0x4001F0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
	public bool _mouseLeftRelease;

	// Token: 0x040019E1 RID: 6625
	[global::Cpp2ILInjected.Token(Token = "0x4001F0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
	public bool _mouseRightRelease;

	// Token: 0x040019E2 RID: 6626
	[global::Cpp2ILInjected.Token(Token = "0x4001F10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int _overloadScreenWidth;

	// Token: 0x040019E3 RID: 6627
	[global::Cpp2ILInjected.Token(Token = "0x4001F11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public int _overloadScreenHeight;

	// Token: 0x040019E4 RID: 6628
	[global::Cpp2ILInjected.Token(Token = "0x4001F12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public int _overloadScreenOffsetX;

	// Token: 0x040019E5 RID: 6629
	[global::Cpp2ILInjected.Token(Token = "0x4001F13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public int _overloadScreenOffsetY;

	// Token: 0x040019E6 RID: 6630
	[global::Cpp2ILInjected.Token(Token = "0x4001F14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public Mouse.OverrideState _virtualCursorOverride;

	// Token: 0x040019E7 RID: 6631
	[global::Cpp2ILInjected.Token(Token = "0x4001F15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ButtonState _virtualCursorOverrideState;

	// Token: 0x040019E8 RID: 6632
	[global::Cpp2ILInjected.Token(Token = "0x4001F16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public float _virtualCursorOverrideX;

	// Token: 0x040019E9 RID: 6633
	[global::Cpp2ILInjected.Token(Token = "0x4001F17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float _virtualCursorOverrideY;

	// Token: 0x040019EA RID: 6634
	[global::Cpp2ILInjected.Token(Token = "0x4001F18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public bool _overrideRMB;

	// Token: 0x040019EB RID: 6635
	[global::Cpp2ILInjected.Token(Token = "0x4001F19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public ButtonState _rmbOverrideState;

	// Token: 0x040019EC RID: 6636
	[global::Cpp2ILInjected.Token(Token = "0x4001F1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float scrollAccumPartial;

	// Token: 0x040019ED RID: 6637
	[global::Cpp2ILInjected.Token(Token = "0x4001F1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public XNAUnityRunner.MouseStateBackup _uiMouseState;

	// Token: 0x040019EE RID: 6638
	[global::Cpp2ILInjected.Token(Token = "0x4001F1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public XNAUnityRunner.MouseStateBackup _worldMouseState;

	// Token: 0x040019EF RID: 6639
	[global::Cpp2ILInjected.Token(Token = "0x4001F1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int _lastUIFrame;
}
