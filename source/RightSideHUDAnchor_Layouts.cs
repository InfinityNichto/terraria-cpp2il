using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000238")]
public class RightSideHUDAnchor_Layouts : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D0C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D207C", Offset = "0x9D207C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D0D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D20C8", Offset = "0x9D20C8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public RightSideHUDAnchor_Layouts()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001745")]
	public static RightSideHUDAnchor_Layouts Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001746")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Anchor_Layout StartAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4001747")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Anchor_Layout StartAnchor2;

	[global::Cpp2ILInjected.Token(Token = "0x4001748")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Anchor_Layout StartAnchorHorizontalBars;

	[global::Cpp2ILInjected.Token(Token = "0x4001749")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Anchor_Layout StartAnchorHorizontalBars2;

	[global::Cpp2ILInjected.Token(Token = "0x400174A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 NonMapSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x400174B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float MapSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x400174C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float MapSpacingLarge;

	[global::Cpp2ILInjected.Token(Token = "0x400174D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float EvemtSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x400174E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float BossBarSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x400174F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float StatusIndicatorSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4001750")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public bool AllowMapMovement;
}
