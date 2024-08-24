using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200017B RID: 379
[global::Cpp2ILInjected.Token(Token = "0x2000205")]
public class MultiplayerLobby_Layout : LayoutDefinition
{
	// Token: 0x06000B94 RID: 2964 RVA: 0x00023E01 File Offset: 0x00022001
	[global::Cpp2ILInjected.Token(Token = "0x6000CA9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF584", Offset = "0x9CF584", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00023E04 File Offset: 0x00022004
	[global::Cpp2ILInjected.Token(Token = "0x6000CAA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF5D0", Offset = "0x9CF5D0", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MultiplayerLobby_Layout()
	{
		throw null;
	}

	// Token: 0x04000EA2 RID: 3746
	[global::Cpp2ILInjected.Token(Token = "0x40012EF")]
	public static MultiplayerLobby_Layout Instance;

	// Token: 0x04000EA3 RID: 3747
	[global::Cpp2ILInjected.Token(Token = "0x40012F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000EA4 RID: 3748
	[global::Cpp2ILInjected.Token(Token = "0x40012F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	// Token: 0x04000EA5 RID: 3749
	[global::Cpp2ILInjected.Token(Token = "0x40012F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Options;

	// Token: 0x04000EA6 RID: 3750
	[global::Cpp2ILInjected.Token(Token = "0x40012F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout OptionsBacking;

	// Token: 0x04000EA7 RID: 3751
	[global::Cpp2ILInjected.Token(Token = "0x40012F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout OptionsGreyout;

	// Token: 0x04000EA8 RID: 3752
	[global::Cpp2ILInjected.Token(Token = "0x40012F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout LB;

	// Token: 0x04000EA9 RID: 3753
	[global::Cpp2ILInjected.Token(Token = "0x40012F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout RB;

	// Token: 0x04000EAA RID: 3754
	[global::Cpp2ILInjected.Token(Token = "0x40012F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Local;

	// Token: 0x04000EAB RID: 3755
	[global::Cpp2ILInjected.Token(Token = "0x40012F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Dedicated;

	// Token: 0x04000EAC RID: 3756
	[global::Cpp2ILInjected.Token(Token = "0x40012F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Friends;

	// Token: 0x04000EAD RID: 3757
	[global::Cpp2ILInjected.Token(Token = "0x40012FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000EAE RID: 3758
	[global::Cpp2ILInjected.Token(Token = "0x40012FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000EAF RID: 3759
	[global::Cpp2ILInjected.Token(Token = "0x40012FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Back;

	// Token: 0x04000EB0 RID: 3760
	[global::Cpp2ILInjected.Token(Token = "0x40012FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Join;

	// Token: 0x04000EB1 RID: 3761
	[global::Cpp2ILInjected.Token(Token = "0x40012FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Delete;

	// Token: 0x04000EB2 RID: 3762
	[global::Cpp2ILInjected.Token(Token = "0x40012FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout Favorite;

	// Token: 0x04000EB3 RID: 3763
	[global::Cpp2ILInjected.Token(Token = "0x4001300")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout PlatformInvite;

	// Token: 0x04000EB4 RID: 3764
	[global::Cpp2ILInjected.Token(Token = "0x4001301")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public bool ShowPlatformInvite;

	// Token: 0x04000EB5 RID: 3765
	[global::Cpp2ILInjected.Token(Token = "0x4001302")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
	public bool AlwaysShowPlatformInvite;

	// Token: 0x04000EB6 RID: 3766
	[global::Cpp2ILInjected.Token(Token = "0x4001303")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public DraggableItemGrid_Layout FriendsGrid;

	// Token: 0x04000EB7 RID: 3767
	[global::Cpp2ILInjected.Token(Token = "0x4001304")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public DraggableItemGrid_Layout LocalGrid;

	// Token: 0x04000EB8 RID: 3768
	[global::Cpp2ILInjected.Token(Token = "0x4001305")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout LocalNew;

	// Token: 0x04000EB9 RID: 3769
	[global::Cpp2ILInjected.Token(Token = "0x4001306")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout SearchingText;

	// Token: 0x04000EBA RID: 3770
	[global::Cpp2ILInjected.Token(Token = "0x4001307")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Button_Layout SearchingIcon;

	// Token: 0x04000EBB RID: 3771
	[global::Cpp2ILInjected.Token(Token = "0x4001308")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public String_Layout NoFriendsText;

	// Token: 0x04000EBC RID: 3772
	[global::Cpp2ILInjected.Token(Token = "0x4001309")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public DraggableItemGrid_Layout DedicatedGrid;

	// Token: 0x04000EBD RID: 3773
	[global::Cpp2ILInjected.Token(Token = "0x400130A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout DedicatedNew;

	// Token: 0x04000EBE RID: 3774
	[global::Cpp2ILInjected.Token(Token = "0x400130B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000EBF RID: 3775
	[global::Cpp2ILInjected.Token(Token = "0x400130C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000EC0 RID: 3776
	[global::Cpp2ILInjected.Token(Token = "0x400130D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Button_Layout ItemPlay;

	// Token: 0x04000EC1 RID: 3777
	[global::Cpp2ILInjected.Token(Token = "0x400130E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Button_Layout ItemDivider;

	// Token: 0x04000EC2 RID: 3778
	[global::Cpp2ILInjected.Token(Token = "0x400130F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout ItemName;

	// Token: 0x04000EC3 RID: 3779
	[global::Cpp2ILInjected.Token(Token = "0x4001310")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public int ItemNameMaxWidth;

	// Token: 0x04000EC4 RID: 3780
	[global::Cpp2ILInjected.Token(Token = "0x4001311")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000EC5 RID: 3781
	[global::Cpp2ILInjected.Token(Token = "0x4001312")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout ItemPlayerBacking;

	// Token: 0x04000EC6 RID: 3782
	[global::Cpp2ILInjected.Token(Token = "0x4001313")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public String_Layout ItemPlayer;

	// Token: 0x04000EC7 RID: 3783
	[global::Cpp2ILInjected.Token(Token = "0x4001314")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Panel_Layout ItemModeBacking;

	// Token: 0x04000EC8 RID: 3784
	[global::Cpp2ILInjected.Token(Token = "0x4001315")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public String_Layout ItemMode;

	// Token: 0x04000EC9 RID: 3785
	[global::Cpp2ILInjected.Token(Token = "0x4001316")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public Panel_Layout ItemSizeBacking;

	// Token: 0x04000ECA RID: 3786
	[global::Cpp2ILInjected.Token(Token = "0x4001317")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public String_Layout ItemSize;

	// Token: 0x04000ECB RID: 3787
	[global::Cpp2ILInjected.Token(Token = "0x4001318")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout ItemImage;

	// Token: 0x04000ECC RID: 3788
	[global::Cpp2ILInjected.Token(Token = "0x4001319")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Button_Layout ItemFavourite;

	// Token: 0x04000ECD RID: 3789
	[global::Cpp2ILInjected.Token(Token = "0x400131A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public SelectPlayerFavoriteIcons FavoriteIcons;
}
