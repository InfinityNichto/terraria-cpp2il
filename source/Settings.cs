using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200029D")]
public class Settings : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FB2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39824", Offset = "0xA39824", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000FB3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39870", Offset = "0xA39870", Length = "0xC0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public Settings()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001C57")]
	public static Settings Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001C58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SettingsTooltips Tooltips;

	[global::Cpp2ILInjected.Token(Token = "0x4001C59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int BannerTooltipItemWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001C5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float DeselectedPageFade;

	[global::Cpp2ILInjected.Token(Token = "0x4001C5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public AnimationCurve SliderSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001C5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public AnimationCurve AimCursorSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001C5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float MouseScrollSensitivity;

	[global::Cpp2ILInjected.Token(Token = "0x4001C5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float GridScrollSpeed;
}
