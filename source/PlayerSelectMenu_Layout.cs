using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200020C")]
public class PlayerSelectMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CB6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFADC", Offset = "0x9CFADC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
	public int PlatformMaxPlayers
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CFB28", Offset = "0x9CFB28", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "SortPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CB8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFB94", Offset = "0x9CFB94", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlayerSelectMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001368")]
	public static PlayerSelectMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001369")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400136A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout PlayerGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400136B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400136C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	[global::Cpp2ILInjected.Token(Token = "0x400136D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x400136E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400136F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Options;

	[global::Cpp2ILInjected.Token(Token = "0x4001370")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001371")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsWithCloudBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001372")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001373")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Play;

	[global::Cpp2ILInjected.Token(Token = "0x4001374")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout EditName;

	[global::Cpp2ILInjected.Token(Token = "0x4001375")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Delete;

	[global::Cpp2ILInjected.Token(Token = "0x4001376")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x4001377")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Cloud;

	[global::Cpp2ILInjected.Token(Token = "0x4001378")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4001379")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SelectPlayerFavoriteIcons CloudIcons;

	[global::Cpp2ILInjected.Token(Token = "0x400137A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400137B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400137C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Button_Layout ItemPlay;

	[global::Cpp2ILInjected.Token(Token = "0x400137D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Button_Layout ItemEditName;

	[global::Cpp2ILInjected.Token(Token = "0x400137E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Button_Layout ItemDelete;

	[global::Cpp2ILInjected.Token(Token = "0x400137F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout ItemFavourite;

	[global::Cpp2ILInjected.Token(Token = "0x4001380")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemCloud;

	[global::Cpp2ILInjected.Token(Token = "0x4001381")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001382")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemHealthBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001383")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Button_Layout ItemHealthIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001384")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public String_Layout ItemHealth;

	[global::Cpp2ILInjected.Token(Token = "0x4001385")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout ItemManaBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001386")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Button_Layout ItemManaIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001387")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout ItemMana;

	[global::Cpp2ILInjected.Token(Token = "0x4001388")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x4001389")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400138A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout PlayerName;

	[global::Cpp2ILInjected.Token(Token = "0x400138B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Panel_Layout ItemTimeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400138C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public String_Layout ItemTime;

	[global::Cpp2ILInjected.Token(Token = "0x400138D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Panel_Layout ItemModeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400138E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public String_Layout ItemMode;

	[global::Cpp2ILInjected.Token(Token = "0x400138F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout ItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x4001390")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public String_Layout SyncInformation;

	[global::Cpp2ILInjected.Token(Token = "0x4001391")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Button_Layout SyncIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4001392")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public int MaxPlayers;

	[global::Cpp2ILInjected.Token(Token = "0x4001393")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public int MaxPlayers_Stadia;

	[global::Cpp2ILInjected.Token(Token = "0x4001394")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public bool FavouriteVisualScroll;
}
