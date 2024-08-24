using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200018D RID: 397
[global::Cpp2ILInjected.Token(Token = "0x2000219")]
[Serializable]
public class SettingsOverlaySlider_Layout
{
	// Token: 0x06000BB3 RID: 2995 RVA: 0x00023E5E File Offset: 0x0002205E
	[global::Cpp2ILInjected.Token(Token = "0x6000CC9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAFF0", Offset = "0x9CAFF0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlaySlider_Layout()
	{
		throw null;
	}

	// Token: 0x0400101E RID: 4126
	[global::Cpp2ILInjected.Token(Token = "0x4001482")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout Title;

	// Token: 0x0400101F RID: 4127
	[global::Cpp2ILInjected.Token(Token = "0x4001483")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Slider_Layout Option;

	// Token: 0x04001020 RID: 4128
	[global::Cpp2ILInjected.Token(Token = "0x4001484")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Slider_Layout HueOption;

	// Token: 0x04001021 RID: 4129
	[global::Cpp2ILInjected.Token(Token = "0x4001485")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Slider_Layout SaturationOption;

	// Token: 0x04001022 RID: 4130
	[global::Cpp2ILInjected.Token(Token = "0x4001486")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Slider_Layout LightOption;

	// Token: 0x04001023 RID: 4131
	[global::Cpp2ILInjected.Token(Token = "0x4001487")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Value;

	// Token: 0x04001024 RID: 4132
	[global::Cpp2ILInjected.Token(Token = "0x4001488")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color DisabledNotchColor;

	// Token: 0x04001025 RID: 4133
	[global::Cpp2ILInjected.Token(Token = "0x4001489")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color DisabledValueColor;

	// Token: 0x04001026 RID: 4134
	[global::Cpp2ILInjected.Token(Token = "0x400148A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float ElementSpacing;
}
