using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000197 RID: 407
[global::Cpp2ILInjected.Token(Token = "0x2000225")]
public class WorldSelectMenu_Layout : LayoutDefinition
{
	// Token: 0x06000BC4 RID: 3012 RVA: 0x00023E91 File Offset: 0x00022091
	[global::Cpp2ILInjected.Token(Token = "0x6000CDD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0A9C", Offset = "0x9D0A9C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00023E94 File Offset: 0x00022094
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

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00023E97 File Offset: 0x00022097
	[global::Cpp2ILInjected.Token(Token = "0x6000CDF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0B54", Offset = "0x9D0B54", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldSelectMenu_Layout()
	{
		throw null;
	}

	// Token: 0x040010C3 RID: 4291
	[global::Cpp2ILInjected.Token(Token = "0x400155D")]
	public static WorldSelectMenu_Layout Instance;

	// Token: 0x040010C4 RID: 4292
	[global::Cpp2ILInjected.Token(Token = "0x400155E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x040010C5 RID: 4293
	[global::Cpp2ILInjected.Token(Token = "0x400155F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout WorldGrid;

	// Token: 0x040010C6 RID: 4294
	[global::Cpp2ILInjected.Token(Token = "0x4001560")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x040010C7 RID: 4295
	[global::Cpp2ILInjected.Token(Token = "0x4001561")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	// Token: 0x040010C8 RID: 4296
	[global::Cpp2ILInjected.Token(Token = "0x4001562")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	// Token: 0x040010C9 RID: 4297
	[global::Cpp2ILInjected.Token(Token = "0x4001563")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider;

	// Token: 0x040010CA RID: 4298
	[global::Cpp2ILInjected.Token(Token = "0x4001564")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Options;

	// Token: 0x040010CB RID: 4299
	[global::Cpp2ILInjected.Token(Token = "0x4001565")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x040010CC RID: 4300
	[global::Cpp2ILInjected.Token(Token = "0x4001566")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsBacking;

	// Token: 0x040010CD RID: 4301
	[global::Cpp2ILInjected.Token(Token = "0x4001567")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x040010CE RID: 4302
	[global::Cpp2ILInjected.Token(Token = "0x4001568")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Play;

	// Token: 0x040010CF RID: 4303
	[global::Cpp2ILInjected.Token(Token = "0x4001569")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Delete;

	// Token: 0x040010D0 RID: 4304
	[global::Cpp2ILInjected.Token(Token = "0x400156A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Favorite;

	// Token: 0x040010D1 RID: 4305
	[global::Cpp2ILInjected.Token(Token = "0x400156B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Rename;

	// Token: 0x040010D2 RID: 4306
	[global::Cpp2ILInjected.Token(Token = "0x400156C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout SeedDisplay;

	// Token: 0x040010D3 RID: 4307
	[global::Cpp2ILInjected.Token(Token = "0x400156D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Cloud;

	// Token: 0x040010D4 RID: 4308
	[global::Cpp2ILInjected.Token(Token = "0x400156E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SelectWorldFavoriteIcons FavoriteIcons;

	// Token: 0x040010D5 RID: 4309
	[global::Cpp2ILInjected.Token(Token = "0x400156F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public SelectWorldFavoriteIcons CloudIcons;

	// Token: 0x040010D6 RID: 4310
	[global::Cpp2ILInjected.Token(Token = "0x4001570")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout ItemBacking;

	// Token: 0x040010D7 RID: 4311
	[global::Cpp2ILInjected.Token(Token = "0x4001571")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout ItemGreyout;

	// Token: 0x040010D8 RID: 4312
	[global::Cpp2ILInjected.Token(Token = "0x4001572")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x040010D9 RID: 4313
	[global::Cpp2ILInjected.Token(Token = "0x4001573")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout ItemSelectedGreyout;

	// Token: 0x040010DA RID: 4314
	[global::Cpp2ILInjected.Token(Token = "0x4001574")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout ItemPlay;

	// Token: 0x040010DB RID: 4315
	[global::Cpp2ILInjected.Token(Token = "0x4001575")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemDelete;

	// Token: 0x040010DC RID: 4316
	[global::Cpp2ILInjected.Token(Token = "0x4001576")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Button_Layout ItemFavourite;

	// Token: 0x040010DD RID: 4317
	[global::Cpp2ILInjected.Token(Token = "0x4001577")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Button_Layout ItemRename;

	// Token: 0x040010DE RID: 4318
	[global::Cpp2ILInjected.Token(Token = "0x4001578")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Button_Layout ItemSeedDisplay;

	// Token: 0x040010DF RID: 4319
	[global::Cpp2ILInjected.Token(Token = "0x4001579")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Button_Layout ItemCloud;

	// Token: 0x040010E0 RID: 4320
	[global::Cpp2ILInjected.Token(Token = "0x400157A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Button_Layout ItemDivider;

	// Token: 0x040010E1 RID: 4321
	[global::Cpp2ILInjected.Token(Token = "0x400157B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public String_Layout ItemName;

	// Token: 0x040010E2 RID: 4322
	[global::Cpp2ILInjected.Token(Token = "0x400157C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x040010E3 RID: 4323
	[global::Cpp2ILInjected.Token(Token = "0x400157D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x040010E4 RID: 4324
	[global::Cpp2ILInjected.Token(Token = "0x400157E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public String_Layout ItemTime;

	// Token: 0x040010E5 RID: 4325
	[global::Cpp2ILInjected.Token(Token = "0x400157F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x040010E6 RID: 4326
	[global::Cpp2ILInjected.Token(Token = "0x4001580")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public String_Layout ItemMode;

	// Token: 0x040010E7 RID: 4327
	[global::Cpp2ILInjected.Token(Token = "0x4001581")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout ItemSizeBacking;

	// Token: 0x040010E8 RID: 4328
	[global::Cpp2ILInjected.Token(Token = "0x4001582")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public String_Layout ItemSize;

	// Token: 0x040010E9 RID: 4329
	[global::Cpp2ILInjected.Token(Token = "0x4001583")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Panel_Layout ItemSeedBacking;

	// Token: 0x040010EA RID: 4330
	[global::Cpp2ILInjected.Token(Token = "0x4001584")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public String_Layout ItemSeed;

	// Token: 0x040010EB RID: 4331
	[global::Cpp2ILInjected.Token(Token = "0x4001585")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout ItemImage;

	// Token: 0x040010EC RID: 4332
	[global::Cpp2ILInjected.Token(Token = "0x4001586")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Panel_Layout CompletedItemImage;

	// Token: 0x040010ED RID: 4333
	[global::Cpp2ILInjected.Token(Token = "0x4001587")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public int MaxWorlds;

	// Token: 0x040010EE RID: 4334
	[global::Cpp2ILInjected.Token(Token = "0x4001588")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public int MaxWorlds_Stadia;

	// Token: 0x040010EF RID: 4335
	[global::Cpp2ILInjected.Token(Token = "0x4001589")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public bool FavouriteVisualScroll;

	// Token: 0x040010F0 RID: 4336
	[global::Cpp2ILInjected.Token(Token = "0x400158A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public String_Layout SyncInformation;

	// Token: 0x040010F1 RID: 4337
	[global::Cpp2ILInjected.Token(Token = "0x400158B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Button_Layout SyncIcon;

	// Token: 0x040010F2 RID: 4338
	[global::Cpp2ILInjected.Token(Token = "0x400158C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public GUIWorldSelectMenu.WorldRenameOption worldRenameOption;
}
