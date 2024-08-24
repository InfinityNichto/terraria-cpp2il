using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000180 RID: 384
[global::Cpp2ILInjected.Token(Token = "0x200020A")]
public class PlayerCreateMenu_Layout : LayoutDefinition
{
	// Token: 0x06000B9D RID: 2973 RVA: 0x00023E1C File Offset: 0x0002201C
	[global::Cpp2ILInjected.Token(Token = "0x6000CB2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF8C4", Offset = "0x9CF8C4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00023E1F File Offset: 0x0002201F
	[global::Cpp2ILInjected.Token(Token = "0x6000CB3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF910", Offset = "0x9CF910", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider_Layout), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public PlayerCreateMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000EE1 RID: 3809
	[global::Cpp2ILInjected.Token(Token = "0x400132E")]
	public static PlayerCreateMenu_Layout Instance;

	// Token: 0x04000EE2 RID: 3810
	[global::Cpp2ILInjected.Token(Token = "0x400132F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000EE3 RID: 3811
	[global::Cpp2ILInjected.Token(Token = "0x4001330")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	// Token: 0x04000EE4 RID: 3812
	[global::Cpp2ILInjected.Token(Token = "0x4001331")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x04000EE5 RID: 3813
	[global::Cpp2ILInjected.Token(Token = "0x4001332")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout CharacterBacking;

	// Token: 0x04000EE6 RID: 3814
	[global::Cpp2ILInjected.Token(Token = "0x4001333")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout CharacterPosition;

	// Token: 0x04000EE7 RID: 3815
	[global::Cpp2ILInjected.Token(Token = "0x4001334")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Info;

	// Token: 0x04000EE8 RID: 3816
	[global::Cpp2ILInjected.Token(Token = "0x4001335")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Gender;

	// Token: 0x04000EE9 RID: 3817
	[global::Cpp2ILInjected.Token(Token = "0x4001336")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ChangeHair;

	// Token: 0x04000EEA RID: 3818
	[global::Cpp2ILInjected.Token(Token = "0x4001337")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Hair;

	// Token: 0x04000EEB RID: 3819
	[global::Cpp2ILInjected.Token(Token = "0x4001338")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Eyes;

	// Token: 0x04000EEC RID: 3820
	[global::Cpp2ILInjected.Token(Token = "0x4001339")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Skin;

	// Token: 0x04000EED RID: 3821
	[global::Cpp2ILInjected.Token(Token = "0x400133A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Shirt;

	// Token: 0x04000EEE RID: 3822
	[global::Cpp2ILInjected.Token(Token = "0x400133B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Undershirt;

	// Token: 0x04000EEF RID: 3823
	[global::Cpp2ILInjected.Token(Token = "0x400133C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Pants;

	// Token: 0x04000EF0 RID: 3824
	[global::Cpp2ILInjected.Token(Token = "0x400133D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Shoes;

	// Token: 0x04000EF1 RID: 3825
	[global::Cpp2ILInjected.Token(Token = "0x400133E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000EF2 RID: 3826
	[global::Cpp2ILInjected.Token(Token = "0x400133F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout NameTitle;

	// Token: 0x04000EF3 RID: 3827
	[global::Cpp2ILInjected.Token(Token = "0x4001340")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout PlayerName;

	// Token: 0x04000EF4 RID: 3828
	[global::Cpp2ILInjected.Token(Token = "0x4001341")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout PlayerNameEdit;

	// Token: 0x04000EF5 RID: 3829
	[global::Cpp2ILInjected.Token(Token = "0x4001342")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout DifficultyTitle;

	// Token: 0x04000EF6 RID: 3830
	[global::Cpp2ILInjected.Token(Token = "0x4001343")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout Difficulty;

	// Token: 0x04000EF7 RID: 3831
	[global::Cpp2ILInjected.Token(Token = "0x4001344")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout TypeDescription;

	// Token: 0x04000EF8 RID: 3832
	[global::Cpp2ILInjected.Token(Token = "0x4001345")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x04000EF9 RID: 3833
	[global::Cpp2ILInjected.Token(Token = "0x4001346")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout OptionsBacking;

	// Token: 0x04000EFA RID: 3834
	[global::Cpp2ILInjected.Token(Token = "0x4001347")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout SoftcoreOption;

	// Token: 0x04000EFB RID: 3835
	[global::Cpp2ILInjected.Token(Token = "0x4001348")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout MediumCoreOption;

	// Token: 0x04000EFC RID: 3836
	[global::Cpp2ILInjected.Token(Token = "0x4001349")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout HardCoreOption;

	// Token: 0x04000EFD RID: 3837
	[global::Cpp2ILInjected.Token(Token = "0x400134A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout JourneyOption;

	// Token: 0x04000EFE RID: 3838
	[global::Cpp2ILInjected.Token(Token = "0x400134B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public StringButton_Layout Softcore;

	// Token: 0x04000EFF RID: 3839
	[global::Cpp2ILInjected.Token(Token = "0x400134C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public StringButton_Layout MediumCore;

	// Token: 0x04000F00 RID: 3840
	[global::Cpp2ILInjected.Token(Token = "0x400134D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public StringButton_Layout HardCore;

	// Token: 0x04000F01 RID: 3841
	[global::Cpp2ILInjected.Token(Token = "0x400134E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public StringButton_Layout DifficultyDescription;

	// Token: 0x04000F02 RID: 3842
	[global::Cpp2ILInjected.Token(Token = "0x400134F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout StyleBacking;

	// Token: 0x04000F03 RID: 3843
	[global::Cpp2ILInjected.Token(Token = "0x4001350")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout SelectedStyleBacking;

	// Token: 0x04000F04 RID: 3844
	[global::Cpp2ILInjected.Token(Token = "0x4001351")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public ItemGrid_Layout MalePresetsGrid;

	// Token: 0x04000F05 RID: 3845
	[global::Cpp2ILInjected.Token(Token = "0x4001352")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public ItemGrid_Layout FemalePresetsGrid;

	// Token: 0x04000F06 RID: 3846
	[global::Cpp2ILInjected.Token(Token = "0x4001353")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout Male;

	// Token: 0x04000F07 RID: 3847
	[global::Cpp2ILInjected.Token(Token = "0x4001354")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout Female;

	// Token: 0x04000F08 RID: 3848
	[global::Cpp2ILInjected.Token(Token = "0x4001355")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public TransactionButton_Layout Randomise;

	// Token: 0x04000F09 RID: 3849
	[global::Cpp2ILInjected.Token(Token = "0x4001356")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000F0A RID: 3850
	[global::Cpp2ILInjected.Token(Token = "0x4001357")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public DraggableItemGrid_Layout HairGrid;

	// Token: 0x04000F0B RID: 3851
	[global::Cpp2ILInjected.Token(Token = "0x4001358")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public float HairScale;

	// Token: 0x04000F0C RID: 3852
	[global::Cpp2ILInjected.Token(Token = "0x4001359")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public float HairHighlightScale;

	// Token: 0x04000F0D RID: 3853
	[global::Cpp2ILInjected.Token(Token = "0x400135A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout SliderBacking;

	// Token: 0x04000F0E RID: 3854
	[global::Cpp2ILInjected.Token(Token = "0x400135B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x04000F0F RID: 3855
	[global::Cpp2ILInjected.Token(Token = "0x400135C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Slider_Layout Lightness;

	// Token: 0x04000F10 RID: 3856
	[global::Cpp2ILInjected.Token(Token = "0x400135D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x04000F11 RID: 3857
	[global::Cpp2ILInjected.Token(Token = "0x400135E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Slider_Layout Saturation;

	// Token: 0x04000F12 RID: 3858
	[global::Cpp2ILInjected.Token(Token = "0x400135F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public TransactionButton_Layout HueBacking;

	// Token: 0x04000F13 RID: 3859
	[global::Cpp2ILInjected.Token(Token = "0x4001360")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Slider_Layout Hue;

	// Token: 0x04000F14 RID: 3860
	[global::Cpp2ILInjected.Token(Token = "0x4001361")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public TransactionButton_Layout ColourValue;

	// Token: 0x04000F15 RID: 3861
	[global::Cpp2ILInjected.Token(Token = "0x4001362")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public TransactionButton_Layout ColourRandomise;

	// Token: 0x04000F16 RID: 3862
	[global::Cpp2ILInjected.Token(Token = "0x4001363")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public TransactionButton_Layout Create;

	// Token: 0x04000F17 RID: 3863
	[global::Cpp2ILInjected.Token(Token = "0x4001364")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public TransactionButton_Layout Back;
}
