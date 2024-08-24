using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200018E RID: 398
[global::Cpp2ILInjected.Token(Token = "0x200021A")]
[Serializable]
public class SettingsOverlayToggle_Layout
{
	// Token: 0x06000BB4 RID: 2996 RVA: 0x00023E61 File Offset: 0x00022061
	[global::Cpp2ILInjected.Token(Token = "0x6000CCA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CB000", Offset = "0x9CB000", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayToggle_Layout()
	{
		throw null;
	}

	// Token: 0x04001027 RID: 4135
	[global::Cpp2ILInjected.Token(Token = "0x400148B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout ToggleButton;

	// Token: 0x04001028 RID: 4136
	[global::Cpp2ILInjected.Token(Token = "0x400148C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Option1Enabled;

	// Token: 0x04001029 RID: 4137
	[global::Cpp2ILInjected.Token(Token = "0x400148D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Option1Disabled;

	// Token: 0x0400102A RID: 4138
	[global::Cpp2ILInjected.Token(Token = "0x400148E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout Option1Label;

	// Token: 0x0400102B RID: 4139
	[global::Cpp2ILInjected.Token(Token = "0x400148F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Color Option1DisabledLabelColour;

	// Token: 0x0400102C RID: 4140
	[global::Cpp2ILInjected.Token(Token = "0x4001490")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout Option2Enabled;

	// Token: 0x0400102D RID: 4141
	[global::Cpp2ILInjected.Token(Token = "0x4001491")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout Option2Disabled;

	// Token: 0x0400102E RID: 4142
	[global::Cpp2ILInjected.Token(Token = "0x4001492")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout Option2Label;

	// Token: 0x0400102F RID: 4143
	[global::Cpp2ILInjected.Token(Token = "0x4001493")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Color Option2DisabledLabelColour;

	// Token: 0x04001030 RID: 4144
	[global::Cpp2ILInjected.Token(Token = "0x4001494")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float ElementSpacing;
}
