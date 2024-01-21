using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200017C")]
public class MultiplayerLobby_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000EAB")]
	public static MultiplayerLobby_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000EAC")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000EAD")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000EAE")]
	public TransactionButton_Layout Options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000EAF")]
	public Panel_Layout OptionsBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000EB0")]
	public Panel_Layout OptionsGreyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000EB1")]
	public TransactionButton_Layout LB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000EB2")]
	public TransactionButton_Layout RB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000EB3")]
	public TransactionButton_Layout Local;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000EB4")]
	public TransactionButton_Layout Dedicated;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000EB5")]
	public TransactionButton_Layout Friends;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000EB6")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000EB7")]
	public Panel_Layout MenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000EB8")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000EB9")]
	public TransactionButton_Layout Join;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000EBA")]
	public TransactionButton_Layout Delete;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000EBB")]
	public TransactionButton_Layout Favorite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000EBC")]
	public TransactionButton_Layout PlatformInvite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000EBD")]
	public bool ShowPlatformInvite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000EBE")]
	public bool AlwaysShowPlatformInvite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000EBF")]
	public DraggableItemGrid_Layout FriendsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000EC0")]
	public DraggableItemGrid_Layout LocalGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000EC1")]
	public TransactionButton_Layout LocalNew;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000EC2")]
	public String_Layout SearchingText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000EC3")]
	public Button_Layout SearchingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000EC4")]
	public String_Layout NoFriendsText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000EC5")]
	public DraggableItemGrid_Layout DedicatedGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000EC6")]
	public TransactionButton_Layout DedicatedNew;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000EC7")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000EC8")]
	public Panel_Layout ItemSelectedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000EC9")]
	public Button_Layout ItemPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000ECA")]
	public Button_Layout ItemDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000ECB")]
	public String_Layout ItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000ECC")]
	public int ItemNameMaxWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000ECD")]
	public Panel_Layout ItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000ECE")]
	public Panel_Layout ItemPlayerBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000ECF")]
	public String_Layout ItemPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000ED0")]
	public Panel_Layout ItemModeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000ED1")]
	public String_Layout ItemMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000ED2")]
	public Panel_Layout ItemSizeBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000ED3")]
	public String_Layout ItemSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000ED4")]
	public Panel_Layout ItemImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000ED5")]
	public Button_Layout ItemFavourite;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000ED6")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x10B2894", Offset = "0x10B2894", VA = "0x10B2894")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x10B28F0", Offset = "0x10B28F0", VA = "0x10B28F0")]
	public MultiplayerLobby_Layout()
	{
	}
}
