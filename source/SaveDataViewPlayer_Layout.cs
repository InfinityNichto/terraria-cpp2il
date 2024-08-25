using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200023B")]
public class SaveDataViewPlayer_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D13")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2410", Offset = "0x9D2410", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D14")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D245C", Offset = "0x9D245C", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveDataViewPlayer_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001777")]
	public static SaveDataViewPlayer_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001778")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001779")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout PlayerGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400177A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400177B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	[global::Cpp2ILInjected.Token(Token = "0x400177C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x400177D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Options;

	[global::Cpp2ILInjected.Token(Token = "0x400177E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout OptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400177F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsWithCloudBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001780")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001781")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Play;

	[global::Cpp2ILInjected.Token(Token = "0x4001782")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Delete;

	[global::Cpp2ILInjected.Token(Token = "0x4001783")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x4001784")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Cloud;

	[global::Cpp2ILInjected.Token(Token = "0x4001785")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4001786")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SelectPlayerFavoriteIcons CloudIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4001787")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001788")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001789")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Button_Layout ItemPlay;

	[global::Cpp2ILInjected.Token(Token = "0x400178A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Button_Layout ItemDelete;

	[global::Cpp2ILInjected.Token(Token = "0x400178B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Button_Layout ItemFavourite;

	[global::Cpp2ILInjected.Token(Token = "0x400178C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Button_Layout ItemCloud;

	[global::Cpp2ILInjected.Token(Token = "0x400178D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400178E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout ItemHealthBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400178F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemHealthIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001790")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout ItemHealth;

	[global::Cpp2ILInjected.Token(Token = "0x4001791")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemManaBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001792")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Button_Layout ItemManaIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001793")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public String_Layout ItemMana;

	[global::Cpp2ILInjected.Token(Token = "0x4001794")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x4001795")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001796")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout ItemTimeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001797")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public String_Layout ItemTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001798")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemModeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001799")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public String_Layout ItemMode;

	[global::Cpp2ILInjected.Token(Token = "0x400179A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Panel_Layout ItemImage;
}
