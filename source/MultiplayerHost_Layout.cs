using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000179 RID: 377
[global::Cpp2ILInjected.Token(Token = "0x2000203")]
public class MultiplayerHost_Layout : LayoutDefinition
{
	// Token: 0x06000B90 RID: 2960 RVA: 0x00023DF5 File Offset: 0x00021FF5
	[global::Cpp2ILInjected.Token(Token = "0x6000CA5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF43C", Offset = "0x9CF43C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x00023DF8 File Offset: 0x00021FF8
	[global::Cpp2ILInjected.Token(Token = "0x6000CA6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF488", Offset = "0x9CF488", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerHost_Layout()
	{
		throw null;
	}

	// Token: 0x04000E76 RID: 3702
	[global::Cpp2ILInjected.Token(Token = "0x40012C3")]
	public static MultiplayerHost_Layout Instance;

	// Token: 0x04000E77 RID: 3703
	[global::Cpp2ILInjected.Token(Token = "0x40012C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000E78 RID: 3704
	[global::Cpp2ILInjected.Token(Token = "0x40012C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	// Token: 0x04000E79 RID: 3705
	[global::Cpp2ILInjected.Token(Token = "0x40012C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x04000E7A RID: 3706
	[global::Cpp2ILInjected.Token(Token = "0x40012C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000E7B RID: 3707
	[global::Cpp2ILInjected.Token(Token = "0x40012C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	// Token: 0x04000E7C RID: 3708
	[global::Cpp2ILInjected.Token(Token = "0x40012C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Host;

	// Token: 0x04000E7D RID: 3709
	[global::Cpp2ILInjected.Token(Token = "0x40012CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public MaxPlayersSlider_Layout MaxPlayers;

	// Token: 0x04000E7E RID: 3710
	[global::Cpp2ILInjected.Token(Token = "0x40012CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Password;

	// Token: 0x04000E7F RID: 3711
	[global::Cpp2ILInjected.Token(Token = "0x40012CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000E80 RID: 3712
	[global::Cpp2ILInjected.Token(Token = "0x40012CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Button_Layout ItemPlay;

	// Token: 0x04000E81 RID: 3713
	[global::Cpp2ILInjected.Token(Token = "0x40012CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Button_Layout ItemDelete;

	// Token: 0x04000E82 RID: 3714
	[global::Cpp2ILInjected.Token(Token = "0x40012CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Button_Layout ItemFavourite;

	// Token: 0x04000E83 RID: 3715
	[global::Cpp2ILInjected.Token(Token = "0x40012D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Button_Layout ItemDivider;

	// Token: 0x04000E84 RID: 3716
	[global::Cpp2ILInjected.Token(Token = "0x40012D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ItemName;

	// Token: 0x04000E85 RID: 3717
	[global::Cpp2ILInjected.Token(Token = "0x40012D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000E86 RID: 3718
	[global::Cpp2ILInjected.Token(Token = "0x40012D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x04000E87 RID: 3719
	[global::Cpp2ILInjected.Token(Token = "0x40012D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout ItemTime;

	// Token: 0x04000E88 RID: 3720
	[global::Cpp2ILInjected.Token(Token = "0x40012D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x04000E89 RID: 3721
	[global::Cpp2ILInjected.Token(Token = "0x40012D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout ItemMode;

	// Token: 0x04000E8A RID: 3722
	[global::Cpp2ILInjected.Token(Token = "0x40012D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ItemSizeBacking;

	// Token: 0x04000E8B RID: 3723
	[global::Cpp2ILInjected.Token(Token = "0x40012D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout ItemSize;

	// Token: 0x04000E8C RID: 3724
	[global::Cpp2ILInjected.Token(Token = "0x40012D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ItemImage;

	// Token: 0x04000E8D RID: 3725
	[global::Cpp2ILInjected.Token(Token = "0x40012DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public String_Layout PlayerCountTitle;

	// Token: 0x04000E8E RID: 3726
	[global::Cpp2ILInjected.Token(Token = "0x40012DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout PlayerCountLabel;

	// Token: 0x04000E8F RID: 3727
	[global::Cpp2ILInjected.Token(Token = "0x40012DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Slider_Layout PlayerCount;

	// Token: 0x04000E90 RID: 3728
	[global::Cpp2ILInjected.Token(Token = "0x40012DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public String_Layout ServerPasswordTitle;

	// Token: 0x04000E91 RID: 3729
	[global::Cpp2ILInjected.Token(Token = "0x40012DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public String_Layout ServerPasswordEdit;

	// Token: 0x04000E92 RID: 3730
	[global::Cpp2ILInjected.Token(Token = "0x40012DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public SettingsOverlayToggle_Layout InviteOpenToggle;
}
