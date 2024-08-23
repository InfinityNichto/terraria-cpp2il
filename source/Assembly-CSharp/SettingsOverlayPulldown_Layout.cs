using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200018C RID: 396
[global::Cpp2ILInjected.Token(Token = "0x2000218")]
[Serializable]
public class SettingsOverlayPulldown_Layout
{
	// Token: 0x06000BB1 RID: 2993 RVA: 0x00023E58 File Offset: 0x00022058
	[global::Cpp2ILInjected.Token(Token = "0x6000CC7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D032C", Offset = "0x9D032C", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerJourneyModeSettings), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSettingsOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "RefreshInputRegion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public TransactionButton_Layout GetOption(int index)
	{
		throw null;
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00023E5B File Offset: 0x0002205B
	[global::Cpp2ILInjected.Token(Token = "0x6000CC8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D03BC", Offset = "0x9D03BC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SettingsOverlayPulldown_Layout()
	{
		throw null;
	}

	// Token: 0x04001009 RID: 4105
	[global::Cpp2ILInjected.Token(Token = "0x400146D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public TransactionButton_Layout PulldownButton;

	// Token: 0x0400100A RID: 4106
	[global::Cpp2ILInjected.Token(Token = "0x400146E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout PulldownTitle;

	// Token: 0x0400100B RID: 4107
	[global::Cpp2ILInjected.Token(Token = "0x400146F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Color DisabledPulldownLabelColour;

	// Token: 0x0400100C RID: 4108
	[global::Cpp2ILInjected.Token(Token = "0x4001470")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout PulldownGreyout;

	// Token: 0x0400100D RID: 4109
	[global::Cpp2ILInjected.Token(Token = "0x4001471")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout PulldownBacking;

	// Token: 0x0400100E RID: 4110
	[global::Cpp2ILInjected.Token(Token = "0x4001472")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 PulldownBackingTLOffset;

	// Token: 0x0400100F RID: 4111
	[global::Cpp2ILInjected.Token(Token = "0x4001473")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 PulldownBackingBROffset;

	// Token: 0x04001010 RID: 4112
	[global::Cpp2ILInjected.Token(Token = "0x4001474")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float PulldownButtonExtraPadding;

	// Token: 0x04001011 RID: 4113
	[global::Cpp2ILInjected.Token(Token = "0x4001475")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Option1;

	// Token: 0x04001012 RID: 4114
	[global::Cpp2ILInjected.Token(Token = "0x4001476")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Option2;

	// Token: 0x04001013 RID: 4115
	[global::Cpp2ILInjected.Token(Token = "0x4001477")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Option3;

	// Token: 0x04001014 RID: 4116
	[global::Cpp2ILInjected.Token(Token = "0x4001478")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Option4;

	// Token: 0x04001015 RID: 4117
	[global::Cpp2ILInjected.Token(Token = "0x4001479")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Option5;

	// Token: 0x04001016 RID: 4118
	[global::Cpp2ILInjected.Token(Token = "0x400147A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Option6;

	// Token: 0x04001017 RID: 4119
	[global::Cpp2ILInjected.Token(Token = "0x400147B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Option7;

	// Token: 0x04001018 RID: 4120
	[global::Cpp2ILInjected.Token(Token = "0x400147C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Option8;

	// Token: 0x04001019 RID: 4121
	[global::Cpp2ILInjected.Token(Token = "0x400147D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Option9;

	// Token: 0x0400101A RID: 4122
	[global::Cpp2ILInjected.Token(Token = "0x400147E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout Option10;

	// Token: 0x0400101B RID: 4123
	[global::Cpp2ILInjected.Token(Token = "0x400147F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Option11;

	// Token: 0x0400101C RID: 4124
	[global::Cpp2ILInjected.Token(Token = "0x4001480")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Option12;

	// Token: 0x0400101D RID: 4125
	[global::Cpp2ILInjected.Token(Token = "0x4001481")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float ElementSpacing;
}
