using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x020001BF RID: 447
[global::Cpp2ILInjected.Token(Token = "0x2000254")]
public class WorldOperationProgress_Layout : LayoutDefinition
{
	// Token: 0x06000C3B RID: 3131 RVA: 0x00023FF6 File Offset: 0x000221F6
	[global::Cpp2ILInjected.Token(Token = "0x6000D56")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D74B8", Offset = "0x9D74B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000C3C RID: 3132 RVA: 0x00023FF9 File Offset: 0x000221F9
	[global::Cpp2ILInjected.Token(Token = "0x6000D57")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7504", Offset = "0x9D7504", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldOperationProgress_Layout()
	{
		throw null;
	}

	// Token: 0x040013B3 RID: 5043
	[global::Cpp2ILInjected.Token(Token = "0x40018A0")]
	public static WorldOperationProgress_Layout Instance;

	// Token: 0x040013B4 RID: 5044
	[global::Cpp2ILInjected.Token(Token = "0x40018A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool Enabled;

	// Token: 0x040013B5 RID: 5045
	[global::Cpp2ILInjected.Token(Token = "0x40018A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
	public bool FullHMStatus;

	// Token: 0x040013B6 RID: 5046
	[global::Cpp2ILInjected.Token(Token = "0x40018A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x040013B7 RID: 5047
	[global::Cpp2ILInjected.Token(Token = "0x40018A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Button_Layout ProgressIcon;

	// Token: 0x040013B8 RID: 5048
	[global::Cpp2ILInjected.Token(Token = "0x40018A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public AnimationCurve HMIconScale;

	// Token: 0x040013B9 RID: 5049
	[global::Cpp2ILInjected.Token(Token = "0x40018A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public AnimationCurve HMIconAlpha;

	// Token: 0x040013BA RID: 5050
	[global::Cpp2ILInjected.Token(Token = "0x40018A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout HMConversionIcon;
}
