using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000013 RID: 19
[global::Cpp2ILInjected.Token(Token = "0x2000013")]
public class Cursor
{
	// Token: 0x06000055 RID: 85 RVA: 0x00021C89 File Offset: 0x0001FE89
	[global::Cpp2ILInjected.Token(Token = "0x6000055")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FBD98", Offset = "0x6FBD98", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Cursor()
	{
		throw null;
	}

	// Token: 0x0400003A RID: 58
	[global::Cpp2ILInjected.Token(Token = "0x400003A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Vector2 Position;

	// Token: 0x0400003B RID: 59
	[global::Cpp2ILInjected.Token(Token = "0x400003B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Vector2 OldPosition;

	// Token: 0x0400003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x400003C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int Id;

	// Token: 0x0400003D RID: 61
	[global::Cpp2ILInjected.Token(Token = "0x400003D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool Down;

	// Token: 0x0400003E RID: 62
	[global::Cpp2ILInjected.Token(Token = "0x400003E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	public bool WasDown;

	// Token: 0x0400003F RID: 63
	[global::Cpp2ILInjected.Token(Token = "0x400003F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 CursorScroll;

	// Token: 0x04000040 RID: 64
	[global::Cpp2ILInjected.Token(Token = "0x4000040")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool Dead;

	// Token: 0x04000041 RID: 65
	[global::Cpp2ILInjected.Token(Token = "0x4000041")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public bool IgnoreForWorld;

	// Token: 0x04000042 RID: 66
	[global::Cpp2ILInjected.Token(Token = "0x4000042")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
	public bool Ignore;

	// Token: 0x04000043 RID: 67
	[global::Cpp2ILInjected.Token(Token = "0x4000043")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public CursorInputLayer InputLayer;

	// Token: 0x04000044 RID: 68
	[global::Cpp2ILInjected.Token(Token = "0x4000044")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public object InputLayerData;

	// Token: 0x04000045 RID: 69
	[global::Cpp2ILInjected.Token(Token = "0x4000045")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DateTime LastUpdate;
}
