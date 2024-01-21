using System.Collections.Generic;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class GUIBestiary
{
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private static Texture2D lockedIcon;

	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private static Texture2D iconRankLight;

	[Cpp2IlInjected.Token(Token = "0x40003C9")]
	private static Texture2D iconRankDim;

	[Cpp2IlInjected.Token(Token = "0x40003CA")]
	private static Texture2D iconTagsShadow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003CB")]
	private GUIControllerBestiary _controllerInput;

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private static Texture_Layout sortIconBackup;

	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private static Texture_Layout sortIconBackup2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private float bestiaryButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private float BackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private GUIItemGrid.CursorOver npcItemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private GUIItemGrid.GetItemScaleHandler npcScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private GUIItemGrid.DrawItemHandler npcDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private int EntryOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public BestiaryEntry SelectedEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	public List<BestiaryEntry> SortedEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	private bool editingSearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	private string searchTerm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private string editDisplaySearch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private float BeginSearchScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private ISearchFilter<BestiaryEntry> searchFilter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private int ActiveFilterCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private int SelectedSort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public float LootScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private float LootScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private int LootScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private Vector2 LootDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	public List<bool> filterEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private List<Texture2D> filterTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<string> filterName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private List<Rectangle> filterFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private List<bool> filterAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public bool OpenedFromInv;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private GUIInputRegionExclusive _lootBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private int unlockedEntries;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private bool displayFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private bool displayOrders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private float filtersScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private float ordersScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private GUIItemGrid.CursorOver filterItemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	private GUIItemGrid.GetItemScaleHandler filterScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	private GUIItemGrid.DrawItemHandler filterDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	private int filterOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	private GUIInputRegionExclusive _filterBlocker;

	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	private static StringBuilder sb;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	private GUIItemGrid.CursorOver orderItemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	private GUIItemGrid.GetItemScaleHandler orderScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private GUIItemGrid.DrawItemHandler orderDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	private int orderOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private GUIInputRegionExclusive _orderBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private List<IBestiaryBackgroundImagePathAndColorProvider> BackgroundImageProviders;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private List<IBestiaryBackgroundOverlayAndColorProvider> BackgroundOverlayProviders;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private List<FilterProviderInfoElement> FilterProviders;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private List<ItemDropBestiaryInfoElement> DropProviders;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private BestiaryEntry backgroundEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private int backgroundImageCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private Texture2D[] backgroundImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private Color[] backgroundColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private GUIItemGrid.CursorOver starOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private GUIItemGrid.GetItemScaleHandler starScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private GUIItemGrid.DrawItemHandler starDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	private int starCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	private GUIItemGrid.CursorOver dropOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private GUIItemGrid.GetItemScaleHandler dropScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private GUIItemGrid.DrawItemHandler dropDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private int DropItemOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private int SelectedDropItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private Item dropItemInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private int dropCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private GUIItemGrid.CursorOver spawnOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private GUIItemGrid.GetItemScaleHandler spawnScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private GUIItemGrid.DrawItemHandler spawnDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private int spawnCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private bool drawLootDrops;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private NPCStatsReportInfoElement dummyStatsInfo;

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x1354024", Offset = "0x1354024", VA = "0x1354024")]
	public GUIBestiary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x13546F0", Offset = "0x13546F0", VA = "0x13546F0")]
	public static void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x1354AAC", Offset = "0x1354AAC", VA = "0x1354AAC")]
	public void DrawButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x1354BF4", Offset = "0x1354BF4", VA = "0x1354BF4")]
	private void NPCDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x13557A4", Offset = "0x13557A4", VA = "0x13557A4")]
	private float NPCScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x1355800", Offset = "0x1355800", VA = "0x1355800")]
	private void NPCOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x1355A28", Offset = "0x1355A28", VA = "0x1355A28")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x1355DF8", Offset = "0x1355DF8", VA = "0x1355DF8")]
	private void RefreshEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x135682C", Offset = "0x135682C", VA = "0x135682C")]
	private int SortCompare(BestiaryEntry x, BestiaryEntry y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x1356A40", Offset = "0x1356A40", VA = "0x1356A40")]
	private void DrawFilterSearch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x1355960", Offset = "0x1355960", VA = "0x1355960")]
	private void CloseSearchInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x1357108", Offset = "0x1357108", VA = "0x1357108")]
	public void SetSearchTerm(string term)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x135721C", Offset = "0x135721C", VA = "0x135721C")]
	public void Open()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x135751C", Offset = "0x135751C", VA = "0x135751C")]
	private bool IsOverLoot(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x1357658", Offset = "0x1357658", VA = "0x1357658")]
	private bool IsOverOrders(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x1357794", Offset = "0x1357794", VA = "0x1357794")]
	private bool IsOverFilters(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x13578D0", Offset = "0x13578D0", VA = "0x13578D0")]
	private void DrawLootDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x13587A0", Offset = "0x13587A0", VA = "0x13587A0")]
	private void DrawProgressBar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x1357344", Offset = "0x1357344", VA = "0x1357344")]
	private void RefreshPercentUnlocked()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x1358B5C", Offset = "0x1358B5C", VA = "0x1358B5C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x135B0AC", Offset = "0x135B0AC", VA = "0x135B0AC")]
	private void FilterDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x135B3D0", Offset = "0x135B3D0", VA = "0x135B3D0")]
	private void FilterOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x135B57C", Offset = "0x135B57C", VA = "0x135B57C")]
	private float FilterScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0x135A154", Offset = "0x135A154", VA = "0x135A154")]
	private void DrawFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x135B584", Offset = "0x135B584", VA = "0x135B584")]
	private void OrderDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x135B7EC", Offset = "0x135B7EC", VA = "0x135B7EC")]
	private void OrderOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x135B8D4", Offset = "0x135B8D4", VA = "0x135B8D4")]
	private float OrderScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x135A83C", Offset = "0x135A83C", VA = "0x135A83C")]
	private void DrawOrders()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x135B8DC", Offset = "0x135B8DC", VA = "0x135B8DC")]
	private NamePlateInfoElement GetName(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x13556FC", Offset = "0x13556FC", VA = "0x13556FC")]
	private IBestiaryEntryDisplayIndex GetDisplayIndex(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x135B9A8", Offset = "0x135B9A8", VA = "0x135B9A8")]
	private NPCPortraitInfoElement GetNPCPortraitInfo(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x1358284", Offset = "0x1358284", VA = "0x1358284")]
	private NPCStatsReportInfoElement GetNPCStatsInfo(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x13559F8", Offset = "0x13559F8", VA = "0x13559F8")]
	private void RefreshSelectedStats()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x135BA74", Offset = "0x135BA74", VA = "0x135BA74")]
	private FlavorTextBestiaryInfoElement GetNPCFlavourInfo(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x135BB40", Offset = "0x135BB40", VA = "0x135BB40")]
	private IPreferenceProviderElement GetPreferenceProvider(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x135BBE8", Offset = "0x135BBE8", VA = "0x135BBE8")]
	private List<IBestiaryBackgroundImagePathAndColorProvider> GetBackgroundImageProviders(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x135BD48", Offset = "0x135BD48", VA = "0x135BD48")]
	private List<IBestiaryBackgroundOverlayAndColorProvider> GetBackgroundOverlayProviders(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x135BF0C", Offset = "0x135BF0C", VA = "0x135BF0C")]
	private int SortBackgroundOverlayElements(IBestiaryBackgroundOverlayAndColorProvider x, IBestiaryBackgroundOverlayAndColorProvider y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x135C058", Offset = "0x135C058", VA = "0x135C058")]
	private List<FilterProviderInfoElement> GetFilterProviders(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x135816C", Offset = "0x135816C", VA = "0x135816C")]
	private List<ItemDropBestiaryInfoElement> GetDropProviders(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x135C158", Offset = "0x135C158", VA = "0x135C158")]
	private void UpdateBackgroundImages(BestiaryEntry entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x135CAF0", Offset = "0x135CAF0", VA = "0x135CAF0")]
	private void DrawImageBackgrounds(Rectangle region, BestiaryEntry entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x135CBFC", Offset = "0x135CBFC", VA = "0x135CBFC")]
	private float StarScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x135CC58", Offset = "0x135CC58", VA = "0x135CC58")]
	private void StarOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x135CC5C", Offset = "0x135CC5C", VA = "0x135CC5C")]
	private void StarDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x135CED8", Offset = "0x135CED8", VA = "0x135CED8")]
	private float DropScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x135CEE0", Offset = "0x135CEE0", VA = "0x135CEE0")]
	private void DropOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x135CFF4", Offset = "0x135CFF4", VA = "0x135CFF4")]
	private void SetBestiaryNotesOnItemCache(DropRateInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x135D214", Offset = "0x135D214", VA = "0x135D214")]
	private void DropDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x135D788", Offset = "0x135D788", VA = "0x135D788")]
	private float SpawnScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x135D790", Offset = "0x135D790", VA = "0x135D790")]
	private void SpawnOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x135D794", Offset = "0x135D794", VA = "0x135D794")]
	private void SpawnDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x1358350", Offset = "0x1358350", VA = "0x1358350")]
	private void DrawCoins()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x1359270", Offset = "0x1359270", VA = "0x1359270")]
	private void DrawSelectedEntry()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x1355D54", Offset = "0x1355D54", VA = "0x1355D54")]
	private void CloseLootDrops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x1355C24", Offset = "0x1355C24", VA = "0x1355C24")]
	private void CloseFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x1355CBC", Offset = "0x1355CBC", VA = "0x1355CBC")]
	private void CloseSortOrder()
	{
	}
}
