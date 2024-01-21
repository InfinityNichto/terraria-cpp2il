using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20001EC")]
public class GUIPageOptions
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001630")]
	private bool _timerBegan;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001631")]
	private DateTime _timeStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001632")]
	private bool _leftPendingPush;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4001633")]
	private bool _displayLeftOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4001634")]
	private bool _displayLeftOptionsGlobal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4001635")]
	private bool _displayRightOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001636")]
	private bool _displayRightOptionsGlobal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001637")]
	private int _displayItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001638")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001639")]
	private float leftOptionsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400163A")]
	private float rightOptionsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400163B")]
	private float leftFavoriteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400163C")]
	private float leftChestQuickStackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400163D")]
	private float leftChestDepositAllScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400163E")]
	private float leftChestSortScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400163F")]
	private bool usingController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001640")]
	private int lastLang;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001641")]
	public string[] options;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001642")]
	private Vector2 leftItemSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001643")]
	private Vector2 leftItemPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001644")]
	private Vector2 leftItemSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001645")]
	private int leftItemIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001646")]
	private Vector2 rightItemSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001647")]
	private Vector2 rightItemPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001648")]
	private Vector2 rightItemSpacing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4001649")]
	private int rightItemIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400164A")]
	private float equipButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400164B")]
	private float depositButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400164C")]
	private float leftThrowScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400164D")]
	private float leftTrashScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400164E")]
	private float sellButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400164F")]
	private float rightChestSortScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4001650")]
	private float chestRestockScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4001651")]
	private float chestLootAllScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4001652")]
	private float chestRenameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4001653")]
	public bool SplitKeyPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x4001654")]
	public bool SplitInvKeyPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
	[Cpp2IlInjected.Token(Token = "0x4001655")]
	public bool SplitChestKeyPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4001656")]
	private float LootButtonScale;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	private bool canDepositAllValue
	{
		[Cpp2IlInjected.Token(Token = "0x6000E08")]
		[Cpp2IlInjected.Address(RVA = "0x113776C", Offset = "0x113776C", VA = "0x113776C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public int NumLeftOptions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E13")]
		[Cpp2IlInjected.Address(RVA = "0x1139484", Offset = "0x1139484", VA = "0x1139484")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private bool CanLootAll
	{
		[Cpp2IlInjected.Token(Token = "0x6000E1F")]
		[Cpp2IlInjected.Address(RVA = "0x113C5EC", Offset = "0x113C5EC", VA = "0x113C5EC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public int NumRightOptions
	{
		[Cpp2IlInjected.Token(Token = "0x6000E24")]
		[Cpp2IlInjected.Address(RVA = "0x113D588", Offset = "0x113D588", VA = "0x113D588")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000E04")]
	[Cpp2IlInjected.Address(RVA = "0x113775C", Offset = "0x113775C", VA = "0x113775C")]
	public void PushLeft()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E05")]
	[Cpp2IlInjected.Address(RVA = "0x1137760", Offset = "0x1137760", VA = "0x1137760")]
	public void PopLeft()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E06")]
	[Cpp2IlInjected.Address(RVA = "0x1137764", Offset = "0x1137764", VA = "0x1137764")]
	public void PushRight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E07")]
	[Cpp2IlInjected.Address(RVA = "0x1137768", Offset = "0x1137768", VA = "0x1137768")]
	public void PopRight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E09")]
	[Cpp2IlInjected.Address(RVA = "0x11378CC", Offset = "0x11378CC", VA = "0x11378CC")]
	public void RefreshLangStrings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E0A")]
	[Cpp2IlInjected.Address(RVA = "0x1137CDC", Offset = "0x1137CDC", VA = "0x1137CDC")]
	public void DrawFavouriteOption()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E0B")]
	[Cpp2IlInjected.Address(RVA = "0x11383E8", Offset = "0x11383E8", VA = "0x11383E8")]
	public void DrawQuickStack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E0C")]
	[Cpp2IlInjected.Address(RVA = "0x1138790", Offset = "0x1138790", VA = "0x1138790")]
	public void DrawSort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E0D")]
	[Cpp2IlInjected.Address(RVA = "0x1138A78", Offset = "0x1138A78", VA = "0x1138A78")]
	public void DrawDepositAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E0E")]
	[Cpp2IlInjected.Address(RVA = "0x1138DE0", Offset = "0x1138DE0", VA = "0x1138DE0")]
	public void DrawSplitStack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E0F")]
	[Cpp2IlInjected.Address(RVA = "0x1138F38", Offset = "0x1138F38", VA = "0x1138F38")]
	private void LeftItemRegionInitialise()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E10")]
	[Cpp2IlInjected.Address(RVA = "0x11382BC", Offset = "0x11382BC", VA = "0x11382BC")]
	private void LoadLeftItemRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E11")]
	[Cpp2IlInjected.Address(RVA = "0x1139148", Offset = "0x1139148", VA = "0x1139148")]
	private void RightItemRegionInitialise()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E12")]
	[Cpp2IlInjected.Address(RVA = "0x1139354", Offset = "0x1139354", VA = "0x1139354")]
	private void LoadRightItemRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E14")]
	[Cpp2IlInjected.Address(RVA = "0x11394F0", Offset = "0x11394F0", VA = "0x11394F0")]
	private bool CanBeOpened(Item SelectedItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E15")]
	[Cpp2IlInjected.Address(RVA = "0x11396F8", Offset = "0x11396F8", VA = "0x11396F8")]
	public void DrawEquipButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E16")]
	[Cpp2IlInjected.Address(RVA = "0x113A52C", Offset = "0x113A52C", VA = "0x113A52C")]
	public void DrawDepositButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E17")]
	[Cpp2IlInjected.Address(RVA = "0x113AED0", Offset = "0x113AED0", VA = "0x113AED0")]
	public void ThrowItem(int additionalVelocity = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E18")]
	[Cpp2IlInjected.Address(RVA = "0x113B430", Offset = "0x113B430", VA = "0x113B430")]
	public void DrawLeftThrow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E19")]
	[Cpp2IlInjected.Address(RVA = "0x113B5FC", Offset = "0x113B5FC", VA = "0x113B5FC")]
	public void DrawLeftTrash()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E1A")]
	[Cpp2IlInjected.Address(RVA = "0x113B8DC", Offset = "0x113B8DC", VA = "0x113B8DC")]
	public void DrawLeftDeposit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E1B")]
	[Cpp2IlInjected.Address(RVA = "0x113A89C", Offset = "0x113A89C", VA = "0x113A89C")]
	public void DrawSellButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E1C")]
	[Cpp2IlInjected.Address(RVA = "0x113BEF0", Offset = "0x113BEF0", VA = "0x113BEF0")]
	public void DrawChestSort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E1D")]
	[Cpp2IlInjected.Address(RVA = "0x113C208", Offset = "0x113C208", VA = "0x113C208")]
	public void DrawChestSplitStack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E1E")]
	[Cpp2IlInjected.Address(RVA = "0x113C364", Offset = "0x113C364", VA = "0x113C364")]
	public void DrawChestRestock()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E20")]
	[Cpp2IlInjected.Address(RVA = "0x113C810", Offset = "0x113C810", VA = "0x113C810")]
	public void DrawChestLootAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E21")]
	[Cpp2IlInjected.Address(RVA = "0x113CAEC", Offset = "0x113CAEC", VA = "0x113CAEC")]
	public void DrawChestRename()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E22")]
	[Cpp2IlInjected.Address(RVA = "0x113CDA4", Offset = "0x113CDA4", VA = "0x113CDA4")]
	public void DrawChestLoot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E23")]
	[Cpp2IlInjected.Address(RVA = "0x113D09C", Offset = "0x113D09C", VA = "0x113D09C")]
	public void DrawChestFavourite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E25")]
	[Cpp2IlInjected.Address(RVA = "0x113D604", Offset = "0x113D604", VA = "0x113D604")]
	public void DrawRightThrow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E26")]
	[Cpp2IlInjected.Address(RVA = "0x113D7C8", Offset = "0x113D7C8", VA = "0x113D7C8")]
	public void DrawRightTrash()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E27")]
	[Cpp2IlInjected.Address(RVA = "0x113DA8C", Offset = "0x113DA8C", VA = "0x113DA8C")]
	public void DrawRightDeposit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E28")]
	[Cpp2IlInjected.Address(RVA = "0x113BAAC", Offset = "0x113BAAC", VA = "0x113BAAC")]
	public void DepositHeldItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E29")]
	[Cpp2IlInjected.Address(RVA = "0x113DC5C", Offset = "0x113DC5C", VA = "0x113DC5C")]
	public GUIPageOptions()
	{
	}
}
