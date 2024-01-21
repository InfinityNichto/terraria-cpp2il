using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000198")]
public class WorldSelectMenu_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40010CC")]
	public static WorldSelectMenu_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40010CD")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40010CE")]
	public DraggableItemGrid_Layout WorldGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40010CF")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40010D0")]
	public TransactionButton_Layout New;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40010D1")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40010D2")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40010D3")]
	public TransactionButton_Layout Options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40010D4")]
	public Panel_Layout OptionsGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40010D5")]
	public Panel_Layout OptionsBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40010D6")]
	public Panel_Layout OptionsWithCloudBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40010D7")]
	public TransactionButton_Layout Play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40010D8")]
	public TransactionButton_Layout Delete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40010D9")]
	public TransactionButton_Layout Favorite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40010DA")]
	public TransactionButton_Layout Rename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40010DB")]
	public TransactionButton_Layout SeedDisplay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40010DC")]
	public TransactionButton_Layout Cloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40010DD")]
	public SelectWorldFavoriteIcons FavoriteIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40010DE")]
	public SelectWorldFavoriteIcons CloudIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40010DF")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40010E0")]
	public Panel_Layout ItemGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40010E1")]
	public Panel_Layout ItemSelectedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40010E2")]
	public Panel_Layout ItemSelectedGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40010E3")]
	public Button_Layout ItemPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40010E4")]
	public Button_Layout ItemDelete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40010E5")]
	public Button_Layout ItemFavourite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40010E6")]
	public Button_Layout ItemRename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40010E7")]
	public Button_Layout ItemSeedDisplay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40010E8")]
	public Button_Layout ItemCloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40010E9")]
	public Button_Layout ItemDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40010EA")]
	public String_Layout ItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40010EB")]
	public Panel_Layout ItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40010EC")]
	public Panel_Layout ItemTimeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40010ED")]
	public String_Layout ItemTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40010EE")]
	public Panel_Layout ItemModeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40010EF")]
	public String_Layout ItemMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40010F0")]
	public Panel_Layout ItemSizeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40010F1")]
	public String_Layout ItemSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40010F2")]
	public Panel_Layout ItemSeedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40010F3")]
	public String_Layout ItemSeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40010F4")]
	public Panel_Layout ItemImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40010F5")]
	public Panel_Layout CompletedItemImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40010F6")]
	public int MaxWorlds;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40010F7")]
	public int MaxWorlds_Stadia;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40010F8")]
	public bool FavouriteVisualScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40010F9")]
	public String_Layout SyncInformation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40010FA")]
	public Button_Layout SyncIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40010FB")]
	public GUIWorldSelectMenu.WorldRenameOption worldRenameOption;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public int PlatformMaxWorlds
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x14FB3D8", Offset = "0x14FB3D8", VA = "0x14FB3D8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD6")]
	[Cpp2IlInjected.Address(RVA = "0x14FB37C", Offset = "0x14FB37C", VA = "0x14FB37C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD8")]
	[Cpp2IlInjected.Address(RVA = "0x14FB500", Offset = "0x14FB500", VA = "0x14FB500")]
	public WorldSelectMenu_Layout()
	{
	}
}
