using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200011B RID: 283
[global::Cpp2ILInjected.Token(Token = "0x2000193")]
public class BottomCentreHUDAnchor_Layout : LayoutDefinition
{
	// Token: 0x06000A45 RID: 2629 RVA: 0x00023A14 File Offset: 0x00021C14
	[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABC2C", Offset = "0x9ABC2C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00023A17 File Offset: 0x00021C17
	[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABC78", Offset = "0x9ABC78", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public BottomCentreHUDAnchor_Layout()
	{
		throw null;
	}

	// Token: 0x0400095B RID: 2395
	[global::Cpp2ILInjected.Token(Token = "0x4000C7D")]
	public static BottomCentreHUDAnchor_Layout Instance;

	// Token: 0x0400095C RID: 2396
	[global::Cpp2ILInjected.Token(Token = "0x4000C7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Anchor_Layout StartAnchor;

	// Token: 0x0400095D RID: 2397
	[global::Cpp2ILInjected.Token(Token = "0x4000C7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ControlsBannerSpacing;

	// Token: 0x0400095E RID: 2398
	[global::Cpp2ILInjected.Token(Token = "0x4000C80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float ControlsBannerSpacingExtraLineSpacing;

	// Token: 0x0400095F RID: 2399
	[global::Cpp2ILInjected.Token(Token = "0x4000C81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ChatSpacing;

	// Token: 0x04000960 RID: 2400
	[global::Cpp2ILInjected.Token(Token = "0x4000C82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float EventSpacing;

	// Token: 0x04000961 RID: 2401
	[global::Cpp2ILInjected.Token(Token = "0x4000C83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float BossBarSpacing;

	// Token: 0x04000962 RID: 2402
	[global::Cpp2ILInjected.Token(Token = "0x4000C84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float ProgressSpacing;
}
