using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200014B RID: 331
[global::Cpp2ILInjected.Token(Token = "0x20001D0")]
public class Debug_Layout : LayoutDefinition
{
	// Token: 0x06000AEB RID: 2795 RVA: 0x00023C06 File Offset: 0x00021E06
	[global::Cpp2ILInjected.Token(Token = "0x6000BFE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5D58", Offset = "0x9B5D58", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00023C09 File Offset: 0x00021E09
	[global::Cpp2ILInjected.Token(Token = "0x6000BFF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5DA4", Offset = "0x9B5DA4", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Debug_Layout()
	{
		throw null;
	}

	// Token: 0x04000C3E RID: 3134
	[global::Cpp2ILInjected.Token(Token = "0x4001041")]
	public static Debug_Layout Instance;

	// Token: 0x04000C3F RID: 3135
	[global::Cpp2ILInjected.Token(Token = "0x4001042")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public LayoutCalculator.AnchorType DebugAnchor;

	// Token: 0x04000C40 RID: 3136
	[global::Cpp2ILInjected.Token(Token = "0x4001043")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public Vector2 DebugIconLocation;

	// Token: 0x04000C41 RID: 3137
	[global::Cpp2ILInjected.Token(Token = "0x4001044")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float DebugIconScale;

	// Token: 0x04000C42 RID: 3138
	[global::Cpp2ILInjected.Token(Token = "0x4001045")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 DebugIconPickBorder;

	// Token: 0x04000C43 RID: 3139
	[global::Cpp2ILInjected.Token(Token = "0x4001046")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Color DebugIconColor;

	// Token: 0x04000C44 RID: 3140
	[global::Cpp2ILInjected.Token(Token = "0x4001047")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout Backing;

	// Token: 0x04000C45 RID: 3141
	[global::Cpp2ILInjected.Token(Token = "0x4001048")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Text;

	// Token: 0x04000C46 RID: 3142
	[global::Cpp2ILInjected.Token(Token = "0x4001049")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Send;

	// Token: 0x04000C47 RID: 3143
	[global::Cpp2ILInjected.Token(Token = "0x400104A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;
}
