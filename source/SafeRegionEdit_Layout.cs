using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000186 RID: 390
[global::Cpp2ILInjected.Token(Token = "0x2000210")]
public class SafeRegionEdit_Layout : LayoutDefinition
{
	// Token: 0x06000BA9 RID: 2985 RVA: 0x00023E40 File Offset: 0x00022040
	[global::Cpp2ILInjected.Token(Token = "0x6000CBE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFDF8", Offset = "0x9CFDF8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00023E43 File Offset: 0x00022043
	[global::Cpp2ILInjected.Token(Token = "0x6000CBF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFE44", Offset = "0x9CFE44", Length = "0x70")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SafeRegionEdit_Layout()
	{
		throw null;
	}

	// Token: 0x04000F58 RID: 3928
	[global::Cpp2ILInjected.Token(Token = "0x40013A5")]
	public static SafeRegionEdit_Layout Instance;

	// Token: 0x04000F59 RID: 3929
	[global::Cpp2ILInjected.Token(Token = "0x40013A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float ButtonEdgeInset;

	// Token: 0x04000F5A RID: 3930
	[global::Cpp2ILInjected.Token(Token = "0x40013A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float MaxEdgeMovementScale;

	// Token: 0x04000F5B RID: 3931
	[global::Cpp2ILInjected.Token(Token = "0x40013A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ControllerDragSpeed;

	// Token: 0x04000F5C RID: 3932
	[global::Cpp2ILInjected.Token(Token = "0x40013A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public Color DefaultLinkColor;

	// Token: 0x04000F5D RID: 3933
	[global::Cpp2ILInjected.Token(Token = "0x40013AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Color DraggingLinkColor;

	// Token: 0x04000F5E RID: 3934
	[global::Cpp2ILInjected.Token(Token = "0x40013AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout ScreenBacking;

	// Token: 0x04000F5F RID: 3935
	[global::Cpp2ILInjected.Token(Token = "0x40013AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout ScreenEdge;

	// Token: 0x04000F60 RID: 3936
	[global::Cpp2ILInjected.Token(Token = "0x40013AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout ScreenEdgeTop;

	// Token: 0x04000F61 RID: 3937
	[global::Cpp2ILInjected.Token(Token = "0x40013AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout ScreenEdgeLeft;

	// Token: 0x04000F62 RID: 3938
	[global::Cpp2ILInjected.Token(Token = "0x40013AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout ScreenEdgeRight;

	// Token: 0x04000F63 RID: 3939
	[global::Cpp2ILInjected.Token(Token = "0x40013B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ScreenEdgeBottom;

	// Token: 0x04000F64 RID: 3940
	[global::Cpp2ILInjected.Token(Token = "0x40013B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Left;

	// Token: 0x04000F65 RID: 3941
	[global::Cpp2ILInjected.Token(Token = "0x40013B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout LeftLink;

	// Token: 0x04000F66 RID: 3942
	[global::Cpp2ILInjected.Token(Token = "0x40013B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Right;

	// Token: 0x04000F67 RID: 3943
	[global::Cpp2ILInjected.Token(Token = "0x40013B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout RightLink;

	// Token: 0x04000F68 RID: 3944
	[global::Cpp2ILInjected.Token(Token = "0x40013B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Top;

	// Token: 0x04000F69 RID: 3945
	[global::Cpp2ILInjected.Token(Token = "0x40013B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout TopLink;

	// Token: 0x04000F6A RID: 3946
	[global::Cpp2ILInjected.Token(Token = "0x40013B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Bottom;

	// Token: 0x04000F6B RID: 3947
	[global::Cpp2ILInjected.Token(Token = "0x40013B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout BottomLink;

	// Token: 0x04000F6C RID: 3948
	[global::Cpp2ILInjected.Token(Token = "0x40013B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Finish;

	// Token: 0x04000F6D RID: 3949
	[global::Cpp2ILInjected.Token(Token = "0x40013BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Reset;
}
