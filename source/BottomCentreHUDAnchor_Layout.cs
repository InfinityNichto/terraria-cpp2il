using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000193")]
public class BottomCentreHUDAnchor_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B52")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABC2C", Offset = "0x9ABC2C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B53")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABC78", Offset = "0x9ABC78", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public BottomCentreHUDAnchor_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000C7D")]
	public static BottomCentreHUDAnchor_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000C7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Anchor_Layout StartAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000C7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ControlsBannerSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float ControlsBannerSpacingExtraLineSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ChatSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float EventSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float BossBarSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float ProgressSpacing;
}
