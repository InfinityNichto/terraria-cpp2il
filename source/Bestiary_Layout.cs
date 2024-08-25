using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000191")]
public class Bestiary_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABA5C", Offset = "0x9ABA5C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABAA8", Offset = "0x9ABAA8", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Bestiary_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000C2F")]
	public static Bestiary_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000C30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout BestiaryButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000C31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000C33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x4000C34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout LeftRightSeperator;

	[global::Cpp2ILInjected.Token(Token = "0x4000C35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuSeperator;

	[global::Cpp2ILInjected.Token(Token = "0x4000C36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout CoinsSeperator;

	[global::Cpp2ILInjected.Token(Token = "0x4000C37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public DraggableItemGrid_Layout BestiaryGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float BestiaryScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Order;

	[global::Cpp2ILInjected.Token(Token = "0x4000C3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout OrderController;

	[global::Cpp2ILInjected.Token(Token = "0x4000C3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Filters;

	[global::Cpp2ILInjected.Token(Token = "0x4000C3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout FiltersController;

	[global::Cpp2ILInjected.Token(Token = "0x4000C3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x4000C3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Loot;

	[global::Cpp2ILInjected.Token(Token = "0x4000C3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout LootController;

	[global::Cpp2ILInjected.Token(Token = "0x4000C40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout LootBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public DraggableItemGrid_Layout LootGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout LootEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4000C43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout LootEntryCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000C44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout UnlockProgress;

	[global::Cpp2ILInjected.Token(Token = "0x4000C45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout UnlockBarBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout UnlockBarProgress;

	[global::Cpp2ILInjected.Token(Token = "0x4000C47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout ItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C48")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Panel_Layout ItemSelectedBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemImage;

	[global::Cpp2ILInjected.Token(Token = "0x4000C4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public String_Layout ItemId;

	[global::Cpp2ILInjected.Token(Token = "0x4000C4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public float ItemLockedScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout FiltersBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public ItemGrid_Layout FiltersGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout FilterEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4000C4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Panel_Layout SearchSeperator;

	[global::Cpp2ILInjected.Token(Token = "0x4000C50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout BeginSearch;

	[global::Cpp2ILInjected.Token(Token = "0x4000C51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public float SearchTextWrapSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000C52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public String_Layout SearchText;

	[global::Cpp2ILInjected.Token(Token = "0x4000C53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Color SearchValidTextColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000C54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
	public Color SearchInvalidTextColor;

	[global::Cpp2ILInjected.Token(Token = "0x4000C55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Panel_Layout OrdersBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public ItemGrid_Layout OrdersGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public TransactionButton_Layout OrderEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4000C58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Texture_Layout[] OrderIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4000C59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Panel_Layout EntryNameBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public String_Layout EntryName;

	[global::Cpp2ILInjected.Token(Token = "0x4000C5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout EntryImage;

	[global::Cpp2ILInjected.Token(Token = "0x4000C5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Panel_Layout EntryImageOverlay;

	[global::Cpp2ILInjected.Token(Token = "0x4000C5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Panel_Layout EntryScrollDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4000C5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public ItemGrid_Layout EntryStars;

	[global::Cpp2ILInjected.Token(Token = "0x4000C5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public float EntryStarScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public ItemGrid_Layout EntrySpawns;

	[global::Cpp2ILInjected.Token(Token = "0x4000C61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Panel_Layout EntrySpawnBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Panel_Layout EntrySpawnIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000C63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public String_Layout EntrySpawnType;

	[global::Cpp2ILInjected.Token(Token = "0x4000C64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public TransactionButton_Layout EntryHealth;

	[global::Cpp2ILInjected.Token(Token = "0x4000C65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public TransactionButton_Layout EntryAttack;

	[global::Cpp2ILInjected.Token(Token = "0x4000C66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public TransactionButton_Layout EntryDefence;

	[global::Cpp2ILInjected.Token(Token = "0x4000C67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public TransactionButton_Layout EntryKnockback;

	[global::Cpp2ILInjected.Token(Token = "0x4000C68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public TransactionButton_Layout EntryKills;

	[global::Cpp2ILInjected.Token(Token = "0x4000C69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public TransactionButton_Layout EntryCoinDropBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public TransactionButton_Layout EntryCoinPlatinum;

	[global::Cpp2ILInjected.Token(Token = "0x4000C6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public TransactionButton_Layout EntryCoinGold;

	[global::Cpp2ILInjected.Token(Token = "0x4000C6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public TransactionButton_Layout EntryCoinSilver;

	[global::Cpp2ILInjected.Token(Token = "0x4000C6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public TransactionButton_Layout EntryCoinCopper;

	[global::Cpp2ILInjected.Token(Token = "0x4000C6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public String_Layout EntryDescription;
}
