using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200023C")]
public class SaveDataViewWorld_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D15")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D24B4", Offset = "0x9D24B4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D16")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2500", Offset = "0x9D2500", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveDataViewWorld_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400179B")]
	public static SaveDataViewWorld_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400179C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400179D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout WorldGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400179E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400179F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	[global::Cpp2ILInjected.Token(Token = "0x40017A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x40017A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Options;

	[global::Cpp2ILInjected.Token(Token = "0x40017A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x40017A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsWithCloudBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Play;

	[global::Cpp2ILInjected.Token(Token = "0x40017A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Delete;

	[global::Cpp2ILInjected.Token(Token = "0x40017A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x40017A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Cloud;

	[global::Cpp2ILInjected.Token(Token = "0x40017A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public SelectWorldFavoriteIcons FavoriteIcons;

	[global::Cpp2ILInjected.Token(Token = "0x40017AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public SelectWorldFavoriteIcons CloudIcons;

	[global::Cpp2ILInjected.Token(Token = "0x40017AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout ItemGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x40017AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout ItemSelectedGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x40017AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Button_Layout ItemPlay;

	[global::Cpp2ILInjected.Token(Token = "0x40017B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Button_Layout ItemDelete;

	[global::Cpp2ILInjected.Token(Token = "0x40017B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Button_Layout ItemFavourite;

	[global::Cpp2ILInjected.Token(Token = "0x40017B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout ItemCloud;

	[global::Cpp2ILInjected.Token(Token = "0x40017B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40017B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x40017B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40017B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout ItemTimeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public String_Layout ItemTime;

	[global::Cpp2ILInjected.Token(Token = "0x40017B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout ItemModeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public String_Layout ItemMode;

	[global::Cpp2ILInjected.Token(Token = "0x40017BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout ItemSizeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40017BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public String_Layout ItemSize;

	[global::Cpp2ILInjected.Token(Token = "0x40017BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemImage;
}
