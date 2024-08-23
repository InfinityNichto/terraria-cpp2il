using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020001AC RID: 428
[global::Cpp2ILInjected.Token(Token = "0x200023B")]
public class SaveDataViewPlayer_Layout : LayoutDefinition
{
	// Token: 0x06000BF9 RID: 3065 RVA: 0x00023F30 File Offset: 0x00022130
	[global::Cpp2ILInjected.Token(Token = "0x6000D13")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2410", Offset = "0x9D2410", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00023F33 File Offset: 0x00022133
	[global::Cpp2ILInjected.Token(Token = "0x6000D14")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D245C", Offset = "0x9D245C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveDataViewPlayer_Layout()
	{
		throw null;
	}

	// Token: 0x040012C2 RID: 4802
	[global::Cpp2ILInjected.Token(Token = "0x4001777")]
	public static SaveDataViewPlayer_Layout Instance;

	// Token: 0x040012C3 RID: 4803
	[global::Cpp2ILInjected.Token(Token = "0x4001778")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x040012C4 RID: 4804
	[global::Cpp2ILInjected.Token(Token = "0x4001779")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x040012C5 RID: 4805
	[global::Cpp2ILInjected.Token(Token = "0x400177A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x040012C6 RID: 4806
	[global::Cpp2ILInjected.Token(Token = "0x400177B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	// Token: 0x040012C7 RID: 4807
	[global::Cpp2ILInjected.Token(Token = "0x400177C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	// Token: 0x040012C8 RID: 4808
	[global::Cpp2ILInjected.Token(Token = "0x400177D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Options;

	// Token: 0x040012C9 RID: 4809
	[global::Cpp2ILInjected.Token(Token = "0x400177E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout OptionsBacking;

	// Token: 0x040012CA RID: 4810
	[global::Cpp2ILInjected.Token(Token = "0x400177F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x040012CB RID: 4811
	[global::Cpp2ILInjected.Token(Token = "0x4001780")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x040012CC RID: 4812
	[global::Cpp2ILInjected.Token(Token = "0x4001781")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Play;

	// Token: 0x040012CD RID: 4813
	[global::Cpp2ILInjected.Token(Token = "0x4001782")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Delete;

	// Token: 0x040012CE RID: 4814
	[global::Cpp2ILInjected.Token(Token = "0x4001783")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Favorite;

	// Token: 0x040012CF RID: 4815
	[global::Cpp2ILInjected.Token(Token = "0x4001784")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Cloud;

	// Token: 0x040012D0 RID: 4816
	[global::Cpp2ILInjected.Token(Token = "0x4001785")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	// Token: 0x040012D1 RID: 4817
	[global::Cpp2ILInjected.Token(Token = "0x4001786")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SelectPlayerFavoriteIcons CloudIcons;

	// Token: 0x040012D2 RID: 4818
	[global::Cpp2ILInjected.Token(Token = "0x4001787")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout ItemBacking;

	// Token: 0x040012D3 RID: 4819
	[global::Cpp2ILInjected.Token(Token = "0x4001788")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040012D4 RID: 4820
	[global::Cpp2ILInjected.Token(Token = "0x4001789")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Button_Layout ItemPlay;

	// Token: 0x040012D5 RID: 4821
	[global::Cpp2ILInjected.Token(Token = "0x400178A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Button_Layout ItemDelete;

	// Token: 0x040012D6 RID: 4822
	[global::Cpp2ILInjected.Token(Token = "0x400178B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Button_Layout ItemFavourite;

	// Token: 0x040012D7 RID: 4823
	[global::Cpp2ILInjected.Token(Token = "0x400178C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Button_Layout ItemCloud;

	// Token: 0x040012D8 RID: 4824
	[global::Cpp2ILInjected.Token(Token = "0x400178D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Button_Layout ItemDivider;

	// Token: 0x040012D9 RID: 4825
	[global::Cpp2ILInjected.Token(Token = "0x400178E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout ItemHealthBacking;

	// Token: 0x040012DA RID: 4826
	[global::Cpp2ILInjected.Token(Token = "0x400178F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemHealthIcon;

	// Token: 0x040012DB RID: 4827
	[global::Cpp2ILInjected.Token(Token = "0x4001790")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout ItemHealth;

	// Token: 0x040012DC RID: 4828
	[global::Cpp2ILInjected.Token(Token = "0x4001791")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemManaBacking;

	// Token: 0x040012DD RID: 4829
	[global::Cpp2ILInjected.Token(Token = "0x4001792")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Button_Layout ItemManaIcon;

	// Token: 0x040012DE RID: 4830
	[global::Cpp2ILInjected.Token(Token = "0x4001793")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public String_Layout ItemMana;

	// Token: 0x040012DF RID: 4831
	[global::Cpp2ILInjected.Token(Token = "0x4001794")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public String_Layout ItemName;

	// Token: 0x040012E0 RID: 4832
	[global::Cpp2ILInjected.Token(Token = "0x4001795")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x040012E1 RID: 4833
	[global::Cpp2ILInjected.Token(Token = "0x4001796")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x040012E2 RID: 4834
	[global::Cpp2ILInjected.Token(Token = "0x4001797")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public String_Layout ItemTime;

	// Token: 0x040012E3 RID: 4835
	[global::Cpp2ILInjected.Token(Token = "0x4001798")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x040012E4 RID: 4836
	[global::Cpp2ILInjected.Token(Token = "0x4001799")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public String_Layout ItemMode;

	// Token: 0x040012E5 RID: 4837
	[global::Cpp2ILInjected.Token(Token = "0x400179A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Panel_Layout ItemImage;
}
