using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000190 RID: 400
[global::Cpp2ILInjected.Token(Token = "0x200021C")]
public class SettingsOverlay_Layout : LayoutDefinition
{
	// Token: 0x06000BB6 RID: 2998 RVA: 0x00023E67 File Offset: 0x00022067
	[global::Cpp2ILInjected.Token(Token = "0x6000CCC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D03CC", Offset = "0x9D03CC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00023E6A File Offset: 0x0002206A
	[global::Cpp2ILInjected.Token(Token = "0x6000CCD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0418", Offset = "0x9D0418", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SettingsOverlay_Layout()
	{
		throw null;
	}

	// Token: 0x04001035 RID: 4149
	[global::Cpp2ILInjected.Token(Token = "0x4001499")]
	public static SettingsOverlay_Layout Instance;

	// Token: 0x04001036 RID: 4150
	[global::Cpp2ILInjected.Token(Token = "0x400149A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	// Token: 0x04001037 RID: 4151
	[global::Cpp2ILInjected.Token(Token = "0x400149B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Titlewide1;

	// Token: 0x04001038 RID: 4152
	[global::Cpp2ILInjected.Token(Token = "0x400149C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Titlewide2;

	// Token: 0x04001039 RID: 4153
	[global::Cpp2ILInjected.Token(Token = "0x400149D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	// Token: 0x0400103A RID: 4154
	[global::Cpp2ILInjected.Token(Token = "0x400149E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x0400103B RID: 4155
	[global::Cpp2ILInjected.Token(Token = "0x400149F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider;

	// Token: 0x0400103C RID: 4156
	[global::Cpp2ILInjected.Token(Token = "0x40014A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider2;

	// Token: 0x0400103D RID: 4157
	[global::Cpp2ILInjected.Token(Token = "0x40014A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	// Token: 0x0400103E RID: 4158
	[global::Cpp2ILInjected.Token(Token = "0x40014A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Home;

	// Token: 0x0400103F RID: 4159
	[global::Cpp2ILInjected.Token(Token = "0x40014A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Achievements;

	// Token: 0x04001040 RID: 4160
	[global::Cpp2ILInjected.Token(Token = "0x40014A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout ResetSettings;

	// Token: 0x04001041 RID: 4161
	[global::Cpp2ILInjected.Token(Token = "0x40014A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout ServerIPAddress;

	// Token: 0x04001042 RID: 4162
	[global::Cpp2ILInjected.Token(Token = "0x40014A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public SettingsOverlayOptionCategories_Layout.Category DefaultCategory;

	// Token: 0x04001043 RID: 4163
	[global::Cpp2ILInjected.Token(Token = "0x40014A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SettingsOverlayCategories_Layout Categories;

	// Token: 0x04001044 RID: 4164
	[global::Cpp2ILInjected.Token(Token = "0x40014A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SettingsOverlayOptionCategories_Layout OptionCategories;

	// Token: 0x04001045 RID: 4165
	[global::Cpp2ILInjected.Token(Token = "0x40014A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public SettingsOverlayLink_Layout LinkTemplate;

	// Token: 0x04001046 RID: 4166
	[global::Cpp2ILInjected.Token(Token = "0x40014AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SettingsOverlayListOption_Layout ListOptionTemplate;

	// Token: 0x04001047 RID: 4167
	[global::Cpp2ILInjected.Token(Token = "0x40014AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public SettingsOverlaySlider_Layout SliderTemplate;

	// Token: 0x04001048 RID: 4168
	[global::Cpp2ILInjected.Token(Token = "0x40014AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public SettingsOverlayToggle_Layout ToggleTemplate;

	// Token: 0x04001049 RID: 4169
	[global::Cpp2ILInjected.Token(Token = "0x40014AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public SettingsOverlayToggle_Layout DisabledToggleTemplate;

	// Token: 0x0400104A RID: 4170
	[global::Cpp2ILInjected.Token(Token = "0x40014AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public SettingsOverlayCycle_Layout CycleTemplate;

	// Token: 0x0400104B RID: 4171
	[global::Cpp2ILInjected.Token(Token = "0x40014AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public SettingsOverlayPulldown_Layout PulldownTemplate;

	// Token: 0x0400104C RID: 4172
	[global::Cpp2ILInjected.Token(Token = "0x40014B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public SettingsOverlayListOption_Layout UIButtonOptionTemplate;

	// Token: 0x0400104D RID: 4173
	[global::Cpp2ILInjected.Token(Token = "0x40014B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout PulldownLBOption;

	// Token: 0x0400104E RID: 4174
	[global::Cpp2ILInjected.Token(Token = "0x40014B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout PulldownLTOption;

	// Token: 0x0400104F RID: 4175
	[global::Cpp2ILInjected.Token(Token = "0x40014B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout PulldownRBOption;

	// Token: 0x04001050 RID: 4176
	[global::Cpp2ILInjected.Token(Token = "0x40014B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout PulldownRTOption;

	// Token: 0x04001051 RID: 4177
	[global::Cpp2ILInjected.Token(Token = "0x40014B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout PulldownAction1Option;

	// Token: 0x04001052 RID: 4178
	[global::Cpp2ILInjected.Token(Token = "0x40014B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout PulldownAction2Option;

	// Token: 0x04001053 RID: 4179
	[global::Cpp2ILInjected.Token(Token = "0x40014B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout PulldownAction3Option;

	// Token: 0x04001054 RID: 4180
	[global::Cpp2ILInjected.Token(Token = "0x40014B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout PulldownAction4Option;

	// Token: 0x04001055 RID: 4181
	[global::Cpp2ILInjected.Token(Token = "0x40014B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Vector2 PulldownMainButtonOffset;

	// Token: 0x04001056 RID: 4182
	[global::Cpp2ILInjected.Token(Token = "0x40014BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public int PulldownButtonLineWidth;

	// Token: 0x04001057 RID: 4183
	[global::Cpp2ILInjected.Token(Token = "0x40014BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
	public int InGameOffset;
}
