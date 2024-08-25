using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000225")]
public class WorldSelectMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CDD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0A9C", Offset = "0x9D0A9C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000160")]
	public int PlatformMaxWorlds
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0AE8", Offset = "0x9D0AE8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "SortWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CDF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0B54", Offset = "0x9D0B54", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldSelectMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400155D")]
	public static WorldSelectMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400155E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400155F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout WorldGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001560")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001561")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	[global::Cpp2ILInjected.Token(Token = "0x4001562")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x4001563")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001564")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Options;

	[global::Cpp2ILInjected.Token(Token = "0x4001565")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001566")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001567")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout OptionsWithCloudBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001568")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Play;

	[global::Cpp2ILInjected.Token(Token = "0x4001569")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Delete;

	[global::Cpp2ILInjected.Token(Token = "0x400156A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x400156B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Rename;

	[global::Cpp2ILInjected.Token(Token = "0x400156C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout SeedDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x400156D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Cloud;

	[global::Cpp2ILInjected.Token(Token = "0x400156E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SelectWorldFavoriteIcons FavoriteIcons;

	[global::Cpp2ILInjected.Token(Token = "0x400156F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public SelectWorldFavoriteIcons CloudIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4001570")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001571")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ItemGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001572")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001573")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ItemSelectedGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001574")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout ItemPlay;

	[global::Cpp2ILInjected.Token(Token = "0x4001575")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemDelete;

	[global::Cpp2ILInjected.Token(Token = "0x4001576")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Button_Layout ItemFavourite;

	[global::Cpp2ILInjected.Token(Token = "0x4001577")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Button_Layout ItemRename;

	[global::Cpp2ILInjected.Token(Token = "0x4001578")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Button_Layout ItemSeedDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4001579")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Button_Layout ItemCloud;

	[global::Cpp2ILInjected.Token(Token = "0x400157A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Button_Layout ItemDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400157B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public String_Layout ItemName;

	[global::Cpp2ILInjected.Token(Token = "0x400157C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout ItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400157D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Panel_Layout ItemTimeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400157E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public String_Layout ItemTime;

	[global::Cpp2ILInjected.Token(Token = "0x400157F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout ItemModeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001580")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public String_Layout ItemMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001581")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout ItemSizeBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001582")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public String_Layout ItemSize;

	[global::Cpp2ILInjected.Token(Token = "0x4001583")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Panel_Layout ItemSeedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001584")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public String_Layout ItemSeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001585")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout ItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x4001586")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Panel_Layout CompletedItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x4001587")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public int MaxWorlds;

	[global::Cpp2ILInjected.Token(Token = "0x4001588")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public int MaxWorlds_Stadia;

	[global::Cpp2ILInjected.Token(Token = "0x4001589")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public bool FavouriteVisualScroll;

	[global::Cpp2ILInjected.Token(Token = "0x400158A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public String_Layout SyncInformation;

	[global::Cpp2ILInjected.Token(Token = "0x400158B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Button_Layout SyncIcon;

	[global::Cpp2ILInjected.Token(Token = "0x400158C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public GUIWorldSelectMenu.WorldRenameOption worldRenameOption;
}
