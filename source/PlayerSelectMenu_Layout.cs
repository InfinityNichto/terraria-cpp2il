using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000183")]
public class PlayerSelectMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000F24")]
	public static PlayerSelectMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F25")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000F26")]
	public DraggableItemGrid_Layout PlayerGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000F27")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000F28")]
	public TransactionButton_Layout New;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000F29")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000F2A")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000F2B")]
	public TransactionButton_Layout Options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000F2C")]
	public Panel_Layout OptionsBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000F2D")]
	public Panel_Layout OptionsWithCloudBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000F2E")]
	public Panel_Layout OptionsGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000F2F")]
	public TransactionButton_Layout Play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000F30")]
	public TransactionButton_Layout EditName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000F31")]
	public TransactionButton_Layout Delete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000F32")]
	public TransactionButton_Layout Favorite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000F33")]
	public TransactionButton_Layout Cloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000F34")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000F35")]
	public SelectPlayerFavoriteIcons CloudIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000F36")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000F37")]
	public Panel_Layout ItemSelectedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000F38")]
	public Button_Layout ItemPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000F39")]
	public Button_Layout ItemEditName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000F3A")]
	public Button_Layout ItemDelete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000F3B")]
	public Button_Layout ItemFavourite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000F3C")]
	public Button_Layout ItemCloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000F3D")]
	public Button_Layout ItemDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000F3E")]
	public Panel_Layout ItemHealthBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000F3F")]
	public Button_Layout ItemHealthIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000F40")]
	public String_Layout ItemHealth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000F41")]
	public Panel_Layout ItemManaBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000F42")]
	public Button_Layout ItemManaIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000F43")]
	public String_Layout ItemMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000F44")]
	public String_Layout ItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000F45")]
	public Panel_Layout ItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000F46")]
	public TransactionButton_Layout PlayerName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000F47")]
	public Panel_Layout ItemTimeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000F48")]
	public String_Layout ItemTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000F49")]
	public Panel_Layout ItemModeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000F4A")]
	public String_Layout ItemMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000F4B")]
	public Panel_Layout ItemImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000F4C")]
	public String_Layout SyncInformation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000F4D")]
	public Button_Layout SyncIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000F4E")]
	public int MaxPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000F4F")]
	public int MaxPlayers_Stadia;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000F50")]
	public bool FavouriteVisualScroll;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public int PlatformMaxPlayers
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x10B6E0C", Offset = "0x10B6E0C", VA = "0x10B6E0C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x10B6DB0", Offset = "0x10B6DB0", VA = "0x10B6DB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x10B6F34", Offset = "0x10B6F34", VA = "0x10B6F34")]
	public PlayerSelectMenu_Layout()
	{
	}
}
