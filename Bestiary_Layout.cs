using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200011A")]
public class Bestiary_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000916")]
	public static Bestiary_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000917")]
	public TransactionButton_Layout BestiaryButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000918")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000919")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400091A")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400091B")]
	public Panel_Layout LeftRightSeperator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400091C")]
	public Panel_Layout MenuSeperator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400091D")]
	public Panel_Layout CoinsSeperator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400091E")]
	public DraggableItemGrid_Layout BestiaryGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400091F")]
	public float BestiaryScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000920")]
	public TransactionButton_Layout Order;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000921")]
	public TransactionButton_Layout OrderController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000922")]
	public TransactionButton_Layout Filters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000923")]
	public TransactionButton_Layout FiltersController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000924")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000925")]
	public TransactionButton_Layout Loot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000926")]
	public TransactionButton_Layout LootController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000927")]
	public Panel_Layout LootBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000928")]
	public DraggableItemGrid_Layout LootGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000929")]
	public TransactionButton_Layout LootEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400092A")]
	public String_Layout LootEntryCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400092B")]
	public String_Layout UnlockProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400092C")]
	public Panel_Layout UnlockBarBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400092D")]
	public Panel_Layout UnlockBarProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400092E")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400092F")]
	public Panel_Layout ItemSelectedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000930")]
	public Panel_Layout ItemImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000931")]
	public String_Layout ItemId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000932")]
	public float ItemLockedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000933")]
	public Panel_Layout FiltersBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000934")]
	public ItemGrid_Layout FiltersGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000935")]
	public TransactionButton_Layout FilterEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000936")]
	public Panel_Layout SearchSeperator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000937")]
	public TransactionButton_Layout BeginSearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000938")]
	public float SearchTextWrapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000939")]
	public String_Layout SearchText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400093A")]
	public Color SearchValidTextColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400093B")]
	public Color SearchInvalidTextColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400093C")]
	public Panel_Layout OrdersBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400093D")]
	public ItemGrid_Layout OrdersGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400093E")]
	public TransactionButton_Layout OrderEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400093F")]
	public Texture_Layout[] OrderIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000940")]
	public Panel_Layout EntryNameBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000941")]
	public String_Layout EntryName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000942")]
	public Panel_Layout EntryImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000943")]
	public Panel_Layout EntryImageOverlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000944")]
	public Panel_Layout EntryScrollDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000945")]
	public ItemGrid_Layout EntryStars;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000946")]
	public float EntryStarScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000947")]
	public ItemGrid_Layout EntrySpawns;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000948")]
	public Panel_Layout EntrySpawnBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000949")]
	public Panel_Layout EntrySpawnIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400094A")]
	public String_Layout EntrySpawnType;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x400094B")]
	public TransactionButton_Layout EntryHealth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400094C")]
	public TransactionButton_Layout EntryAttack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400094D")]
	public TransactionButton_Layout EntryDefence;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400094E")]
	public TransactionButton_Layout EntryKnockback;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400094F")]
	public TransactionButton_Layout EntryKills;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000950")]
	public TransactionButton_Layout EntryCoinDropBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4000951")]
	public TransactionButton_Layout EntryCoinPlatinum;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000952")]
	public TransactionButton_Layout EntryCoinGold;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000953")]
	public TransactionButton_Layout EntryCoinSilver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000954")]
	public TransactionButton_Layout EntryCoinCopper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000955")]
	public String_Layout EntryDescription;

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x11FFC18", Offset = "0x11FFC18", VA = "0x11FFC18")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x11FFC74", Offset = "0x11FFC74", VA = "0x11FFC74")]
	public Bestiary_Layout()
	{
	}
}
