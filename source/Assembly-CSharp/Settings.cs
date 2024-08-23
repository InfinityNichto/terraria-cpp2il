using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x020001F8 RID: 504
[global::Cpp2ILInjected.Token(Token = "0x200029D")]
public class Settings : LayoutDefinition
{
	// Token: 0x06000E82 RID: 3714 RVA: 0x000246CB File Offset: 0x000228CB
	[global::Cpp2ILInjected.Token(Token = "0x6000FB2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39824", Offset = "0xA39824", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x000246CE File Offset: 0x000228CE
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

	// Token: 0x04001730 RID: 5936
	[global::Cpp2ILInjected.Token(Token = "0x4001C57")]
	public static Settings Instance;

	// Token: 0x04001731 RID: 5937
	[global::Cpp2ILInjected.Token(Token = "0x4001C58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SettingsTooltips Tooltips;

	// Token: 0x04001732 RID: 5938
	[global::Cpp2ILInjected.Token(Token = "0x4001C59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int BannerTooltipItemWidth;

	// Token: 0x04001733 RID: 5939
	[global::Cpp2ILInjected.Token(Token = "0x4001C5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float DeselectedPageFade;

	// Token: 0x04001734 RID: 5940
	[global::Cpp2ILInjected.Token(Token = "0x4001C5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public AnimationCurve SliderSpeed;

	// Token: 0x04001735 RID: 5941
	[global::Cpp2ILInjected.Token(Token = "0x4001C5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public AnimationCurve AimCursorSpeed;

	// Token: 0x04001736 RID: 5942
	[global::Cpp2ILInjected.Token(Token = "0x4001C5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float MouseScrollSensitivity;

	// Token: 0x04001737 RID: 5943
	[global::Cpp2ILInjected.Token(Token = "0x4001C5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float GridScrollSpeed;
}
