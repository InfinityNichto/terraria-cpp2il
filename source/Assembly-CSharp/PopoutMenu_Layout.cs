using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000137 RID: 311
[global::Cpp2ILInjected.Token(Token = "0x20001B4")]
[Serializable]
public class PopoutMenu_Layout
{
	// Token: 0x06000AB1 RID: 2737 RVA: 0x00023B58 File Offset: 0x00021D58
	[global::Cpp2ILInjected.Token(Token = "0x6000BC0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B29F8", Offset = "0x9B29F8", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PopoutMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000A97 RID: 2711
	[global::Cpp2ILInjected.Token(Token = "0x4000E5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public QuickActionButton_Layout MenuButton;

	// Token: 0x04000A98 RID: 2712
	[global::Cpp2ILInjected.Token(Token = "0x4000E5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public PopoutMenu_Layout.ReorderStyle Reorder;

	// Token: 0x04000A99 RID: 2713
	[global::Cpp2ILInjected.Token(Token = "0x4000E5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout ElementLayout;

	// Token: 0x04000A9A RID: 2714
	[global::Cpp2ILInjected.Token(Token = "0x4000E60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ElementSpacing;

	// Token: 0x04000A9B RID: 2715
	[global::Cpp2ILInjected.Token(Token = "0x4000E61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 BackingTLOffset;

	// Token: 0x04000A9C RID: 2716
	[global::Cpp2ILInjected.Token(Token = "0x4000E62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 BackingBROffset;

	// Token: 0x04000A9D RID: 2717
	[global::Cpp2ILInjected.Token(Token = "0x4000E63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Color BackingColor;

	// Token: 0x020007DE RID: 2014
	[global::Cpp2ILInjected.Token(Token = "0x20001B5")]
	public enum ReorderStyle
	{
		// Token: 0x04007B91 RID: 31633
		[global::Cpp2ILInjected.Token(Token = "0x4000E65")]
		None,
		// Token: 0x04007B92 RID: 31634
		[global::Cpp2ILInjected.Token(Token = "0x4000E66")]
		Reverse
	}
}
