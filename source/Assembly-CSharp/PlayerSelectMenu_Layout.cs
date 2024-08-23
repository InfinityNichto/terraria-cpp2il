using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000182 RID: 386
[global::Cpp2ILInjected.Token(Token = "0x200020C")]
public class PlayerSelectMenu_Layout : LayoutDefinition
{
	// Token: 0x06000BA1 RID: 2977 RVA: 0x00023E28 File Offset: 0x00022028
	[global::Cpp2ILInjected.Token(Token = "0x6000CB6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFADC", Offset = "0x9CFADC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00023E2B File Offset: 0x0002202B
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

	// Token: 0x06000BA3 RID: 2979 RVA: 0x00023E2E File Offset: 0x0002202E
	[global::Cpp2ILInjected.Token(Token = "0x6000CB8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFB94", Offset = "0x9CFB94", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlayerSelectMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000F1B RID: 3867
	[global::Cpp2ILInjected.Token(Token = "0x4001368")]
	public static PlayerSelectMenu_Layout Instance;

	// Token: 0x04000F1C RID: 3868
	[global::Cpp2ILInjected.Token(Token = "0x4001369")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000F1D RID: 3869
	[global::Cpp2ILInjected.Token(Token = "0x400136A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DraggableItemGrid_Layout PlayerGrid;

	// Token: 0x04000F1E RID: 3870
	[global::Cpp2ILInjected.Token(Token = "0x400136B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x04000F1F RID: 3871
	[global::Cpp2ILInjected.Token(Token = "0x400136C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout New;

	// Token: 0x04000F20 RID: 3872
	[global::Cpp2ILInjected.Token(Token = "0x400136D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Back;

	// Token: 0x04000F21 RID: 3873
	[global::Cpp2ILInjected.Token(Token = "0x400136E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000F22 RID: 3874
	[global::Cpp2ILInjected.Token(Token = "0x400136F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Options;

	// Token: 0x04000F23 RID: 3875
	[global::Cpp2ILInjected.Token(Token = "0x4001370")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout OptionsBacking;

	// Token: 0x04000F24 RID: 3876
	[global::Cpp2ILInjected.Token(Token = "0x4001371")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04000F25 RID: 3877
	[global::Cpp2ILInjected.Token(Token = "0x4001372")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x04000F26 RID: 3878
	[global::Cpp2ILInjected.Token(Token = "0x4001373")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Play;

	// Token: 0x04000F27 RID: 3879
	[global::Cpp2ILInjected.Token(Token = "0x4001374")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout EditName;

	// Token: 0x04000F28 RID: 3880
	[global::Cpp2ILInjected.Token(Token = "0x4001375")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Delete;

	// Token: 0x04000F29 RID: 3881
	[global::Cpp2ILInjected.Token(Token = "0x4001376")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Favorite;

	// Token: 0x04000F2A RID: 3882
	[global::Cpp2ILInjected.Token(Token = "0x4001377")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Cloud;

	// Token: 0x04000F2B RID: 3883
	[global::Cpp2ILInjected.Token(Token = "0x4001378")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public SelectPlayerFavoriteIcons FavoriteIcons;

	// Token: 0x04000F2C RID: 3884
	[global::Cpp2ILInjected.Token(Token = "0x4001379")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public SelectPlayerFavoriteIcons CloudIcons;

	// Token: 0x04000F2D RID: 3885
	[global::Cpp2ILInjected.Token(Token = "0x400137A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000F2E RID: 3886
	[global::Cpp2ILInjected.Token(Token = "0x400137B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000F2F RID: 3887
	[global::Cpp2ILInjected.Token(Token = "0x400137C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Button_Layout ItemPlay;

	// Token: 0x04000F30 RID: 3888
	[global::Cpp2ILInjected.Token(Token = "0x400137D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Button_Layout ItemEditName;

	// Token: 0x04000F31 RID: 3889
	[global::Cpp2ILInjected.Token(Token = "0x400137E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Button_Layout ItemDelete;

	// Token: 0x04000F32 RID: 3890
	[global::Cpp2ILInjected.Token(Token = "0x400137F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout ItemFavourite;

	// Token: 0x04000F33 RID: 3891
	[global::Cpp2ILInjected.Token(Token = "0x4001380")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout ItemCloud;

	// Token: 0x04000F34 RID: 3892
	[global::Cpp2ILInjected.Token(Token = "0x4001381")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Button_Layout ItemDivider;

	// Token: 0x04000F35 RID: 3893
	[global::Cpp2ILInjected.Token(Token = "0x4001382")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemHealthBacking;

	// Token: 0x04000F36 RID: 3894
	[global::Cpp2ILInjected.Token(Token = "0x4001383")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Button_Layout ItemHealthIcon;

	// Token: 0x04000F37 RID: 3895
	[global::Cpp2ILInjected.Token(Token = "0x4001384")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public String_Layout ItemHealth;

	// Token: 0x04000F38 RID: 3896
	[global::Cpp2ILInjected.Token(Token = "0x4001385")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout ItemManaBacking;

	// Token: 0x04000F39 RID: 3897
	[global::Cpp2ILInjected.Token(Token = "0x4001386")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Button_Layout ItemManaIcon;

	// Token: 0x04000F3A RID: 3898
	[global::Cpp2ILInjected.Token(Token = "0x4001387")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout ItemMana;

	// Token: 0x04000F3B RID: 3899
	[global::Cpp2ILInjected.Token(Token = "0x4001388")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public String_Layout ItemName;

	// Token: 0x04000F3C RID: 3900
	[global::Cpp2ILInjected.Token(Token = "0x4001389")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000F3D RID: 3901
	[global::Cpp2ILInjected.Token(Token = "0x400138A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public TransactionButton_Layout PlayerName;

	// Token: 0x04000F3E RID: 3902
	[global::Cpp2ILInjected.Token(Token = "0x400138B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Panel_Layout ItemTimeBacking;

	// Token: 0x04000F3F RID: 3903
	[global::Cpp2ILInjected.Token(Token = "0x400138C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public String_Layout ItemTime;

	// Token: 0x04000F40 RID: 3904
	[global::Cpp2ILInjected.Token(Token = "0x400138D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x04000F41 RID: 3905
	[global::Cpp2ILInjected.Token(Token = "0x400138E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public String_Layout ItemMode;

	// Token: 0x04000F42 RID: 3906
	[global::Cpp2ILInjected.Token(Token = "0x400138F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Panel_Layout ItemImage;

	// Token: 0x04000F43 RID: 3907
	[global::Cpp2ILInjected.Token(Token = "0x4001390")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public String_Layout SyncInformation;

	// Token: 0x04000F44 RID: 3908
	[global::Cpp2ILInjected.Token(Token = "0x4001391")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Button_Layout SyncIcon;

	// Token: 0x04000F45 RID: 3909
	[global::Cpp2ILInjected.Token(Token = "0x4001392")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public int MaxPlayers;

	// Token: 0x04000F46 RID: 3910
	[global::Cpp2ILInjected.Token(Token = "0x4001393")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public int MaxPlayers_Stadia;

	// Token: 0x04000F47 RID: 3911
	[global::Cpp2ILInjected.Token(Token = "0x4001394")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public bool FavouriteVisualScroll;
}
