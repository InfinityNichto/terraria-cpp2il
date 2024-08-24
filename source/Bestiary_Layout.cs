using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000119 RID: 281
[global::Cpp2ILInjected.Token(Token = "0x2000191")]
public class Bestiary_Layout : LayoutDefinition
{
	// Token: 0x06000A41 RID: 2625 RVA: 0x00023A08 File Offset: 0x00021C08
	[global::Cpp2ILInjected.Token(Token = "0x6000B4E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABA5C", Offset = "0x9ABA5C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00023A0B File Offset: 0x00021C0B
	[global::Cpp2ILInjected.Token(Token = "0x6000B4F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABAA8", Offset = "0x9ABAA8", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public Bestiary_Layout()
	{
		throw null;
	}

	// Token: 0x0400090D RID: 2317
	[global::Cpp2ILInjected.Token(Token = "0x4000C2F")]
	public static Bestiary_Layout Instance;

	// Token: 0x0400090E RID: 2318
	[global::Cpp2ILInjected.Token(Token = "0x4000C30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout BestiaryButton;

	// Token: 0x0400090F RID: 2319
	[global::Cpp2ILInjected.Token(Token = "0x4000C31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x04000910 RID: 2320
	[global::Cpp2ILInjected.Token(Token = "0x4000C32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	// Token: 0x04000911 RID: 2321
	[global::Cpp2ILInjected.Token(Token = "0x4000C33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Back;

	// Token: 0x04000912 RID: 2322
	[global::Cpp2ILInjected.Token(Token = "0x4000C34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout LeftRightSeperator;

	// Token: 0x04000913 RID: 2323
	[global::Cpp2ILInjected.Token(Token = "0x4000C35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuSeperator;

	// Token: 0x04000914 RID: 2324
	[global::Cpp2ILInjected.Token(Token = "0x4000C36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout CoinsSeperator;

	// Token: 0x04000915 RID: 2325
	[global::Cpp2ILInjected.Token(Token = "0x4000C37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public DraggableItemGrid_Layout BestiaryGrid;

	// Token: 0x04000916 RID: 2326
	[global::Cpp2ILInjected.Token(Token = "0x4000C38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float BestiaryScale;

	// Token: 0x04000917 RID: 2327
	[global::Cpp2ILInjected.Token(Token = "0x4000C39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Order;

	// Token: 0x04000918 RID: 2328
	[global::Cpp2ILInjected.Token(Token = "0x4000C3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout OrderController;

	// Token: 0x04000919 RID: 2329
	[global::Cpp2ILInjected.Token(Token = "0x4000C3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Filters;

	// Token: 0x0400091A RID: 2330
	[global::Cpp2ILInjected.Token(Token = "0x4000C3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout FiltersController;

	// Token: 0x0400091B RID: 2331
	[global::Cpp2ILInjected.Token(Token = "0x4000C3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Close;

	// Token: 0x0400091C RID: 2332
	[global::Cpp2ILInjected.Token(Token = "0x4000C3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Loot;

	// Token: 0x0400091D RID: 2333
	[global::Cpp2ILInjected.Token(Token = "0x4000C3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout LootController;

	// Token: 0x0400091E RID: 2334
	[global::Cpp2ILInjected.Token(Token = "0x4000C40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout LootBacking;

	// Token: 0x0400091F RID: 2335
	[global::Cpp2ILInjected.Token(Token = "0x4000C41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public DraggableItemGrid_Layout LootGrid;

	// Token: 0x04000920 RID: 2336
	[global::Cpp2ILInjected.Token(Token = "0x4000C42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout LootEntry;

	// Token: 0x04000921 RID: 2337
	[global::Cpp2ILInjected.Token(Token = "0x4000C43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout LootEntryCount;

	// Token: 0x04000922 RID: 2338
	[global::Cpp2ILInjected.Token(Token = "0x4000C44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout UnlockProgress;

	// Token: 0x04000923 RID: 2339
	[global::Cpp2ILInjected.Token(Token = "0x4000C45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Panel_Layout UnlockBarBacking;

	// Token: 0x04000924 RID: 2340
	[global::Cpp2ILInjected.Token(Token = "0x4000C46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout UnlockBarProgress;

	// Token: 0x04000925 RID: 2341
	[global::Cpp2ILInjected.Token(Token = "0x4000C47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout ItemBacking;

	// Token: 0x04000926 RID: 2342
	[global::Cpp2ILInjected.Token(Token = "0x4000C48")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04000927 RID: 2343
	[global::Cpp2ILInjected.Token(Token = "0x4000C49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Panel_Layout ItemImage;

	// Token: 0x04000928 RID: 2344
	[global::Cpp2ILInjected.Token(Token = "0x4000C4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public String_Layout ItemId;

	// Token: 0x04000929 RID: 2345
	[global::Cpp2ILInjected.Token(Token = "0x4000C4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public float ItemLockedScale;

	// Token: 0x0400092A RID: 2346
	[global::Cpp2ILInjected.Token(Token = "0x4000C4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Panel_Layout FiltersBacking;

	// Token: 0x0400092B RID: 2347
	[global::Cpp2ILInjected.Token(Token = "0x4000C4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public ItemGrid_Layout FiltersGrid;

	// Token: 0x0400092C RID: 2348
	[global::Cpp2ILInjected.Token(Token = "0x4000C4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout FilterEntry;

	// Token: 0x0400092D RID: 2349
	[global::Cpp2ILInjected.Token(Token = "0x4000C4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public Panel_Layout SearchSeperator;

	// Token: 0x0400092E RID: 2350
	[global::Cpp2ILInjected.Token(Token = "0x4000C50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout BeginSearch;

	// Token: 0x0400092F RID: 2351
	[global::Cpp2ILInjected.Token(Token = "0x4000C51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public float SearchTextWrapSize;

	// Token: 0x04000930 RID: 2352
	[global::Cpp2ILInjected.Token(Token = "0x4000C52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public String_Layout SearchText;

	// Token: 0x04000931 RID: 2353
	[global::Cpp2ILInjected.Token(Token = "0x4000C53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public Color SearchValidTextColor;

	// Token: 0x04000932 RID: 2354
	[global::Cpp2ILInjected.Token(Token = "0x4000C54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
	public Color SearchInvalidTextColor;

	// Token: 0x04000933 RID: 2355
	[global::Cpp2ILInjected.Token(Token = "0x4000C55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public Panel_Layout OrdersBacking;

	// Token: 0x04000934 RID: 2356
	[global::Cpp2ILInjected.Token(Token = "0x4000C56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public ItemGrid_Layout OrdersGrid;

	// Token: 0x04000935 RID: 2357
	[global::Cpp2ILInjected.Token(Token = "0x4000C57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public TransactionButton_Layout OrderEntry;

	// Token: 0x04000936 RID: 2358
	[global::Cpp2ILInjected.Token(Token = "0x4000C58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Texture_Layout[] OrderIcons;

	// Token: 0x04000937 RID: 2359
	[global::Cpp2ILInjected.Token(Token = "0x4000C59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public Panel_Layout EntryNameBacking;

	// Token: 0x04000938 RID: 2360
	[global::Cpp2ILInjected.Token(Token = "0x4000C5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public String_Layout EntryName;

	// Token: 0x04000939 RID: 2361
	[global::Cpp2ILInjected.Token(Token = "0x4000C5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout EntryImage;

	// Token: 0x0400093A RID: 2362
	[global::Cpp2ILInjected.Token(Token = "0x4000C5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Panel_Layout EntryImageOverlay;

	// Token: 0x0400093B RID: 2363
	[global::Cpp2ILInjected.Token(Token = "0x4000C5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Panel_Layout EntryScrollDivider;

	// Token: 0x0400093C RID: 2364
	[global::Cpp2ILInjected.Token(Token = "0x4000C5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public ItemGrid_Layout EntryStars;

	// Token: 0x0400093D RID: 2365
	[global::Cpp2ILInjected.Token(Token = "0x4000C5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public float EntryStarScale;

	// Token: 0x0400093E RID: 2366
	[global::Cpp2ILInjected.Token(Token = "0x4000C60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public ItemGrid_Layout EntrySpawns;

	// Token: 0x0400093F RID: 2367
	[global::Cpp2ILInjected.Token(Token = "0x4000C61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Panel_Layout EntrySpawnBacking;

	// Token: 0x04000940 RID: 2368
	[global::Cpp2ILInjected.Token(Token = "0x4000C62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public Panel_Layout EntrySpawnIcon;

	// Token: 0x04000941 RID: 2369
	[global::Cpp2ILInjected.Token(Token = "0x4000C63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public String_Layout EntrySpawnType;

	// Token: 0x04000942 RID: 2370
	[global::Cpp2ILInjected.Token(Token = "0x4000C64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public TransactionButton_Layout EntryHealth;

	// Token: 0x04000943 RID: 2371
	[global::Cpp2ILInjected.Token(Token = "0x4000C65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public TransactionButton_Layout EntryAttack;

	// Token: 0x04000944 RID: 2372
	[global::Cpp2ILInjected.Token(Token = "0x4000C66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public TransactionButton_Layout EntryDefence;

	// Token: 0x04000945 RID: 2373
	[global::Cpp2ILInjected.Token(Token = "0x4000C67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public TransactionButton_Layout EntryKnockback;

	// Token: 0x04000946 RID: 2374
	[global::Cpp2ILInjected.Token(Token = "0x4000C68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public TransactionButton_Layout EntryKills;

	// Token: 0x04000947 RID: 2375
	[global::Cpp2ILInjected.Token(Token = "0x4000C69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public TransactionButton_Layout EntryCoinDropBacking;

	// Token: 0x04000948 RID: 2376
	[global::Cpp2ILInjected.Token(Token = "0x4000C6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public TransactionButton_Layout EntryCoinPlatinum;

	// Token: 0x04000949 RID: 2377
	[global::Cpp2ILInjected.Token(Token = "0x4000C6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public TransactionButton_Layout EntryCoinGold;

	// Token: 0x0400094A RID: 2378
	[global::Cpp2ILInjected.Token(Token = "0x4000C6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public TransactionButton_Layout EntryCoinSilver;

	// Token: 0x0400094B RID: 2379
	[global::Cpp2ILInjected.Token(Token = "0x4000C6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public TransactionButton_Layout EntryCoinCopper;

	// Token: 0x0400094C RID: 2380
	[global::Cpp2ILInjected.Token(Token = "0x4000C6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public String_Layout EntryDescription;
}
