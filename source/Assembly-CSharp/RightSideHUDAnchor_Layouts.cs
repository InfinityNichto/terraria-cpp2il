using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020001A9 RID: 425
[global::Cpp2ILInjected.Token(Token = "0x2000238")]
public class RightSideHUDAnchor_Layouts : LayoutDefinition
{
	// Token: 0x06000BF2 RID: 3058 RVA: 0x00023F1B File Offset: 0x0002211B
	[global::Cpp2ILInjected.Token(Token = "0x6000D0C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D207C", Offset = "0x9D207C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00023F1E File Offset: 0x0002211E
	[global::Cpp2ILInjected.Token(Token = "0x6000D0D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D20C8", Offset = "0x9D20C8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public RightSideHUDAnchor_Layouts()
	{
		throw null;
	}

	// Token: 0x04001290 RID: 4752
	[global::Cpp2ILInjected.Token(Token = "0x4001745")]
	public static RightSideHUDAnchor_Layouts Instance;

	// Token: 0x04001291 RID: 4753
	[global::Cpp2ILInjected.Token(Token = "0x4001746")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Anchor_Layout StartAnchor;

	// Token: 0x04001292 RID: 4754
	[global::Cpp2ILInjected.Token(Token = "0x4001747")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Anchor_Layout StartAnchor2;

	// Token: 0x04001293 RID: 4755
	[global::Cpp2ILInjected.Token(Token = "0x4001748")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Anchor_Layout StartAnchorHorizontalBars;

	// Token: 0x04001294 RID: 4756
	[global::Cpp2ILInjected.Token(Token = "0x4001749")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Anchor_Layout StartAnchorHorizontalBars2;

	// Token: 0x04001295 RID: 4757
	[global::Cpp2ILInjected.Token(Token = "0x400174A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 NonMapSpacing;

	// Token: 0x04001296 RID: 4758
	[global::Cpp2ILInjected.Token(Token = "0x400174B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float MapSpacing;

	// Token: 0x04001297 RID: 4759
	[global::Cpp2ILInjected.Token(Token = "0x400174C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float MapSpacingLarge;

	// Token: 0x04001298 RID: 4760
	[global::Cpp2ILInjected.Token(Token = "0x400174D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float EvemtSpacing;

	// Token: 0x04001299 RID: 4761
	[global::Cpp2ILInjected.Token(Token = "0x400174E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float BossBarSpacing;

	// Token: 0x0400129A RID: 4762
	[global::Cpp2ILInjected.Token(Token = "0x400174F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float StatusIndicatorSpacing;

	// Token: 0x0400129B RID: 4763
	[global::Cpp2ILInjected.Token(Token = "0x4001750")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public bool AllowMapMovement;
}
