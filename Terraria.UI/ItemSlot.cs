using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004BD")]
public class ItemSlot
{
	[Cpp2IlInjected.Token(Token = "0x2000944")]
	public class Options
	{
		[Cpp2IlInjected.Token(Token = "0x170008B1")]
		public static bool DisableLeftShiftTrashCan
		{
			[Cpp2IlInjected.Token(Token = "0x6004D1A")]
			[Cpp2IlInjected.Address(RVA = "0x1334C08", Offset = "0x1334C08", VA = "0x1334C08")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6004D1B")]
			[Cpp2IlInjected.Address(RVA = "0x1334C84", Offset = "0x1334C84", VA = "0x1334C84")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B2")]
		public static bool HighlightNewItems
		{
			[Cpp2IlInjected.Token(Token = "0x6004D1C")]
			[Cpp2IlInjected.Address(RVA = "0x1334D04", Offset = "0x1334D04", VA = "0x1334D04")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6004D1D")]
			[Cpp2IlInjected.Address(RVA = "0x1334D80", Offset = "0x1334D80", VA = "0x1334D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B3")]
		public static bool DisableQuickTrash
		{
			[Cpp2IlInjected.Token(Token = "0x6004D1E")]
			[Cpp2IlInjected.Address(RVA = "0x1334E00", Offset = "0x1334E00", VA = "0x1334E00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6004D1F")]
			[Cpp2IlInjected.Address(RVA = "0x1334E7C", Offset = "0x1334E7C", VA = "0x1334E7C")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D20")]
		[Cpp2IlInjected.Address(RVA = "0x1334EFC", Offset = "0x1334EFC", VA = "0x1334EFC")]
		public Options()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000945")]
	public enum GUIFakeTooltipContext
	{
		[Cpp2IlInjected.Token(Token = "0x4008AEA")]
		DefenseIcon = 36,
		[Cpp2IlInjected.Token(Token = "0x4008AEB")]
		HousingMenu,
		[Cpp2IlInjected.Token(Token = "0x4008AEC")]
		PVPMenu,
		[Cpp2IlInjected.Token(Token = "0x4008AED")]
		ItemDuplication,
		[Cpp2IlInjected.Token(Token = "0x4008AEE")]
		CraftGuide,
		[Cpp2IlInjected.Token(Token = "0x4008AEF")]
		BestiaryDrop,
		[Cpp2IlInjected.Token(Token = "0x4008AF0")]
		Reforge,
		[Cpp2IlInjected.Token(Token = "0x4008AF1")]
		Team,
		[Cpp2IlInjected.Token(Token = "0x4008AF2")]
		AccessoryInfo,
		[Cpp2IlInjected.Token(Token = "0x4008AF3")]
		BuilderAccessories,
		[Cpp2IlInjected.Token(Token = "0x4008AF4")]
		Hotbar,
		[Cpp2IlInjected.Token(Token = "0x4008AF5")]
		Buffs,
		[Cpp2IlInjected.Token(Token = "0x4008AF6")]
		Loadout
	}

	[Cpp2IlInjected.Token(Token = "0x2000946")]
	public class Context
	{
		[Cpp2IlInjected.Token(Token = "0x4008AF7")]
		public const int InventoryItem = 0;

		[Cpp2IlInjected.Token(Token = "0x4008AF8")]
		public const int InventoryCoin = 1;

		[Cpp2IlInjected.Token(Token = "0x4008AF9")]
		public const int InventoryAmmo = 2;

		[Cpp2IlInjected.Token(Token = "0x4008AFA")]
		public const int ChestItem = 3;

		[Cpp2IlInjected.Token(Token = "0x4008AFB")]
		public const int BankItem = 4;

		[Cpp2IlInjected.Token(Token = "0x4008AFC")]
		public const int PrefixItem = 5;

		[Cpp2IlInjected.Token(Token = "0x4008AFD")]
		public const int TrashItem = 6;

		[Cpp2IlInjected.Token(Token = "0x4008AFE")]
		public const int GuideItem = 7;

		[Cpp2IlInjected.Token(Token = "0x4008AFF")]
		public const int EquipArmor = 8;

		[Cpp2IlInjected.Token(Token = "0x4008B00")]
		public const int EquipArmorVanity = 9;

		[Cpp2IlInjected.Token(Token = "0x4008B01")]
		public const int EquipAccessory = 10;

		[Cpp2IlInjected.Token(Token = "0x4008B02")]
		public const int EquipAccessoryVanity = 11;

		[Cpp2IlInjected.Token(Token = "0x4008B03")]
		public const int EquipDye = 12;

		[Cpp2IlInjected.Token(Token = "0x4008B04")]
		public const int HotbarItem = 13;

		[Cpp2IlInjected.Token(Token = "0x4008B05")]
		public const int ChatItem = 14;

		[Cpp2IlInjected.Token(Token = "0x4008B06")]
		public const int ShopItem = 15;

		[Cpp2IlInjected.Token(Token = "0x4008B07")]
		public const int EquipGrapple = 16;

		[Cpp2IlInjected.Token(Token = "0x4008B08")]
		public const int EquipMount = 17;

		[Cpp2IlInjected.Token(Token = "0x4008B09")]
		public const int EquipMinecart = 18;

		[Cpp2IlInjected.Token(Token = "0x4008B0A")]
		public const int EquipPet = 19;

		[Cpp2IlInjected.Token(Token = "0x4008B0B")]
		public const int EquipLight = 20;

		[Cpp2IlInjected.Token(Token = "0x4008B0C")]
		public const int MouseItem = 21;

		[Cpp2IlInjected.Token(Token = "0x4008B0D")]
		public const int CraftingMaterial = 22;

		[Cpp2IlInjected.Token(Token = "0x4008B0E")]
		public const int DisplayDollArmor = 23;

		[Cpp2IlInjected.Token(Token = "0x4008B0F")]
		public const int DisplayDollAccessory = 24;

		[Cpp2IlInjected.Token(Token = "0x4008B10")]
		public const int DisplayDollDye = 25;

		[Cpp2IlInjected.Token(Token = "0x4008B11")]
		public const int HatRackHat = 26;

		[Cpp2IlInjected.Token(Token = "0x4008B12")]
		public const int HatRackDye = 27;

		[Cpp2IlInjected.Token(Token = "0x4008B13")]
		public const int GoldDebug = 28;

		[Cpp2IlInjected.Token(Token = "0x4008B14")]
		public const int CreativeInfinite = 29;

		[Cpp2IlInjected.Token(Token = "0x4008B15")]
		public const int CreativeSacrifice = 30;

		[Cpp2IlInjected.Token(Token = "0x4008B16")]
		public const int InWorld = 31;

		[Cpp2IlInjected.Token(Token = "0x4008B17")]
		public const int VoidItem = 32;

		[Cpp2IlInjected.Token(Token = "0x4008B18")]
		public const int EquipMiscDye = 33;

		[Cpp2IlInjected.Token(Token = "0x4008B19")]
		public const int CreativeResearch = 34;

		[Cpp2IlInjected.Token(Token = "0x4008B1A")]
		public const int RubbleMaker = 35;

		[Cpp2IlInjected.Token(Token = "0x4008B1B")]
		public const int Count = 36;

		[Cpp2IlInjected.Token(Token = "0x6004D21")]
		[Cpp2IlInjected.Address(RVA = "0x13347C0", Offset = "0x13347C0", VA = "0x13347C0")]
		public Context()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000947")]
	public struct ItemTransferInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008B1C")]
		public int ItemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008B1D")]
		public int TransferAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B1E")]
		public int FromContenxt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B1F")]
		public int ToContext;

		[Cpp2IlInjected.Token(Token = "0x6004D22")]
		[Cpp2IlInjected.Address(RVA = "0x39E58C", Offset = "0x39E58C", VA = "0x39E58C")]
		public ItemTransferInfo(Item itemAfter, int fromContext, int toContext, int transferAmount = 0)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000948")]
	public delegate void ItemTransferEvent(ItemTransferInfo info);

	[Cpp2IlInjected.Token(Token = "0x4006658")]
	public static bool DrawGoldBGForCraftingMaterial;

	[Cpp2IlInjected.Token(Token = "0x4006659")]
	public static bool ShiftForcedOn;

	[Cpp2IlInjected.Token(Token = "0x400665A")]
	public static float[] inventoryGlowHue;

	[Cpp2IlInjected.Token(Token = "0x400665B")]
	public static int[] inventoryGlowTime;

	[Cpp2IlInjected.Token(Token = "0x400665C")]
	private static float[] inventoryGlowHueChest;

	[Cpp2IlInjected.Token(Token = "0x400665D")]
	private static int[] inventoryGlowTimeChest;

	[Cpp2IlInjected.Token(Token = "0x400665E")]
	private static int _customCurrencyForSavings;

	[Cpp2IlInjected.Token(Token = "0x400665F")]
	private static int additionalThrowVelocity;

	[Cpp2IlInjected.Token(Token = "0x4006660")]
	public static bool DuplicationMode;

	[Cpp2IlInjected.Token(Token = "0x4006661")]
	private static int dyeSlotCount;

	[Cpp2IlInjected.Token(Token = "0x4006662")]
	private static int accSlotToSwapTo;

	[Cpp2IlInjected.Token(Token = "0x4006663")]
	public static float CircularRadialOpacity;

	[Cpp2IlInjected.Token(Token = "0x4006664")]
	public static float QuicksRadialOpacity;

	[Cpp2IlInjected.Token(Token = "0x4006665")]
	private static Item[] singleSlotArray;

	[Cpp2IlInjected.Token(Token = "0x4006666")]
	private static bool[] canFavoriteAt;

	[Cpp2IlInjected.Token(Token = "0x4006667")]
	private static bool[] canShareAt;

	[Cpp2IlInjected.Token(Token = "0x4006669")]
	public static bool forceClearGlowsOnChest;

	[Cpp2IlInjected.Token(Token = "0x400666A")]
	private static Item dummyItem;

	[Cpp2IlInjected.Token(Token = "0x400666B")]
	private static bool CursorHighlight;

	[Cpp2IlInjected.Token(Token = "0x400666C")]
	private static bool SelectHighlight;

	[Cpp2IlInjected.Token(Token = "0x400666D")]
	private static float HighlightScale;

	[Cpp2IlInjected.Token(Token = "0x400666E")]
	private static float ForceRenderScale;

	[Cpp2IlInjected.Token(Token = "0x400666F")]
	private static double _lastTimeForVisualEffectsThatLoadoutWasChanged;

	[Cpp2IlInjected.Token(Token = "0x4006670")]
	private static Color[,] LoadoutSlotColors;

	[Cpp2IlInjected.Token(Token = "0x4006671")]
	private static Color[,] LoadoutHighlightSlotColors;

	[Cpp2IlInjected.Token(Token = "0x4006672")]
	private static int LastHoverContext;

	[Cpp2IlInjected.Token(Token = "0x4006673")]
	private static int LastHoverSlot;

	[Cpp2IlInjected.Token(Token = "0x4006674")]
	private static TransactionButton_Layout LastHoverButton;

	[Cpp2IlInjected.Token(Token = "0x4006675")]
	private static int LastButtonFrame;

	[Cpp2IlInjected.Token(Token = "0x4006676")]
	private static Vector2 defenderTextOffset;

	[Cpp2IlInjected.Token(Token = "0x4006677")]
	private static Vector2 defenderPigOffset;

	[Cpp2IlInjected.Token(Token = "0x170006C1")]
	public static bool AltInUse
	{
		[Cpp2IlInjected.Token(Token = "0x600354D")]
		[Cpp2IlInjected.Address(RVA = "0x13AA764", Offset = "0x13AA764", VA = "0x13AA764")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006C2")]
	public static bool ShiftInUse
	{
		[Cpp2IlInjected.Token(Token = "0x600354E")]
		[Cpp2IlInjected.Address(RVA = "0x13AA8B0", Offset = "0x13AA8B0", VA = "0x13AA8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006C3")]
	public static bool ControlInUse
	{
		[Cpp2IlInjected.Token(Token = "0x600354F")]
		[Cpp2IlInjected.Address(RVA = "0x13AA9FC", Offset = "0x13AA9FC", VA = "0x13AA9FC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006C4")]
	public static bool NotUsingGamepad
	{
		[Cpp2IlInjected.Token(Token = "0x6003550")]
		[Cpp2IlInjected.Address(RVA = "0x13AAB48", Offset = "0x13AAB48", VA = "0x13AAB48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public static event ItemTransferEvent OnItemTransferred
	{
		[Cpp2IlInjected.Token(Token = "0x6003551")]
		[Cpp2IlInjected.Address(RVA = "0x13AABC0", Offset = "0x13AABC0", VA = "0x13AABC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003552")]
		[Cpp2IlInjected.Address(RVA = "0x13AACC8", Offset = "0x13AACC8", VA = "0x13AACC8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600354C")]
	[Cpp2IlInjected.Address(RVA = "0x13AA014", Offset = "0x13AA014", VA = "0x13AA014")]
	static ItemSlot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003553")]
	[Cpp2IlInjected.Address(RVA = "0x13AADD0", Offset = "0x13AADD0", VA = "0x13AADD0")]
	public static void AnnounceTransfer(ItemTransferInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003554")]
	[Cpp2IlInjected.Address(RVA = "0x13AAEB0", Offset = "0x13AAEB0", VA = "0x13AAEB0")]
	public static void SetGlow(int index, float hue, bool chest)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003555")]
	[Cpp2IlInjected.Address(RVA = "0x13AB000", Offset = "0x13AB000", VA = "0x13AB000")]
	public static void UpdateInterface()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003556")]
	[Cpp2IlInjected.Address(RVA = "0x13AB378", Offset = "0x13AB378", VA = "0x13AB378")]
	public static void Handle(ref Item inv, int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003557")]
	[Cpp2IlInjected.Address(RVA = "0x13AB490", Offset = "0x13AB490", VA = "0x13AB490")]
	public static void Handle(Item[] inv, int context = 0, int slot = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003558")]
	[Cpp2IlInjected.Address(RVA = "0x13B0950", Offset = "0x13B0950", VA = "0x13B0950")]
	public static void OverrideHover(ref Item inv, int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003559")]
	[Cpp2IlInjected.Address(RVA = "0x13B0A30", Offset = "0x13B0A30", VA = "0x13B0A30")]
	public static bool isEquipLocked(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600355A")]
	[Cpp2IlInjected.Address(RVA = "0x13AB60C", Offset = "0x13AB60C", VA = "0x13AB60C")]
	public static void OverrideHover(Item[] inv, int context = 0, int slot = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600355B")]
	[Cpp2IlInjected.Address(RVA = "0x13B0A38", Offset = "0x13B0A38", VA = "0x13B0A38")]
	private static bool OverrideLeftClick(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600355C")]
	[Cpp2IlInjected.Address(RVA = "0x13B15B8", Offset = "0x13B15B8", VA = "0x13B15B8")]
	public static bool IsMouseItem(Item[] slots, int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600355D")]
	[Cpp2IlInjected.Address(RVA = "0x13B1718", Offset = "0x13B1718", VA = "0x13B1718")]
	public static void LeftClick(ref Item inv, int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600355E")]
	[Cpp2IlInjected.Address(RVA = "0x13AC298", Offset = "0x13AC298", VA = "0x13AC298")]
	public static void LeftClick(Item[] inv, int context = 0, int slot = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600355F")]
	[Cpp2IlInjected.Address(RVA = "0x13B31B4", Offset = "0x13B31B4", VA = "0x13B31B4")]
	private static bool DisableTrashing()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003560")]
	[Cpp2IlInjected.Address(RVA = "0x13B17F8", Offset = "0x13B17F8", VA = "0x13B17F8")]
	private static bool LeftClick_SellOrTrash(Item[] inv, int context, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003561")]
	[Cpp2IlInjected.Address(RVA = "0x13B32A0", Offset = "0x13B32A0", VA = "0x13B32A0")]
	private static void SellOrTrash(Item[] inv, int context, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003562")]
	[Cpp2IlInjected.Address(RVA = "0x13B36CC", Offset = "0x13B36CC", VA = "0x13B36CC")]
	private static string GetOverrideInstructions(Item[] inv, int context, int slot)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003563")]
	[Cpp2IlInjected.Address(RVA = "0x13B3C2C", Offset = "0x13B3C2C", VA = "0x13B3C2C")]
	private static void UpdateChestOnServer(int context, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003564")]
	[Cpp2IlInjected.Address(RVA = "0x13B2618", Offset = "0x13B2618", VA = "0x13B2618")]
	private static void PlaceItem(ref Item[] inv, ref Item item, int context = 0, int slot = -1, int keepStack = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003565")]
	[Cpp2IlInjected.Address(RVA = "0x13B1A20", Offset = "0x13B1A20", VA = "0x13B1A20")]
	public static int PickItemMovementAction(Item[] inv, int context, int slot, Item checkItem, bool backwardCheck = false, int initialSlot = -1)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003566")]
	[Cpp2IlInjected.Address(RVA = "0x13B3F5C", Offset = "0x13B3F5C", VA = "0x13B3F5C")]
	public static void RightClick(ref Item inv, int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003567")]
	[Cpp2IlInjected.Address(RVA = "0x13AF674", Offset = "0x13AF674", VA = "0x13AF674")]
	public static bool RightClick(Item[] inv, int context = 0, int slot = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003568")]
	[Cpp2IlInjected.Address(RVA = "0x13B5DE4", Offset = "0x13B5DE4", VA = "0x13B5DE4")]
	public static void TakeOne(Item[] inv, int context, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003569")]
	[Cpp2IlInjected.Address(RVA = "0x13B5558", Offset = "0x13B5558", VA = "0x13B5558")]
	public static void PickupItemIntoMouse(Item[] inv, int context, int slot, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600356A")]
	[Cpp2IlInjected.Address(RVA = "0x13B5D10", Offset = "0x13B5D10", VA = "0x13B5D10")]
	public static void RefreshStackSplitCooldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600356B")]
	[Cpp2IlInjected.Address(RVA = "0x13B42BC", Offset = "0x13B42BC", VA = "0x13B42BC")]
	private static bool TryOpenContainer(Item item, Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600356C")]
	[Cpp2IlInjected.Address(RVA = "0x13B45DC", Offset = "0x13B45DC", VA = "0x13B45DC")]
	private static bool SwapVanityEquip(Item[] inv, int context, int slot, Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600356D")]
	[Cpp2IlInjected.Address(RVA = "0x13B4888", Offset = "0x13B4888", VA = "0x13B4888")]
	private static bool TryPickupDyeToCursor(int context, Item[] inv, int slot, Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600356E")]
	[Cpp2IlInjected.Address(RVA = "0x13B403C", Offset = "0x13B403C", VA = "0x13B403C")]
	private static bool TryItemSwap(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600356F")]
	[Cpp2IlInjected.Address(RVA = "0x13B5FD0", Offset = "0x13B5FD0", VA = "0x13B5FD0")]
	public static void AfterItemSwap(int oldType, int newType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003570")]
	[Cpp2IlInjected.Address(RVA = "0x13B2C10", Offset = "0x13B2C10", VA = "0x13B2C10")]
	private static void HandleShopSlot(Item[] inv, int slot, bool rightClickIsValid, bool leftClickIsValid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003571")]
	[Cpp2IlInjected.Address(RVA = "0x13B614C", Offset = "0x13B614C", VA = "0x13B614C")]
	public static void Draw(SpriteBatch spriteBatch, ref Item inv, int context, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003572")]
	[Cpp2IlInjected.Address(RVA = "0x13B622C", Offset = "0x13B622C", VA = "0x13B622C")]
	public static void Draw(SpriteBatch spriteBatch, ref Item inv, int context, Vector2 position, Color lightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003573")]
	[Cpp2IlInjected.Address(RVA = "0x13B6430", Offset = "0x13B6430", VA = "0x13B6430")]
	public static void SetCursorHighlight(bool hasFocus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003574")]
	[Cpp2IlInjected.Address(RVA = "0x13B64AC", Offset = "0x13B64AC", VA = "0x13B64AC")]
	public static void SetSelectHighlight(bool hasFocus, float highlightScale = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003575")]
	[Cpp2IlInjected.Address(RVA = "0x13B6540", Offset = "0x13B6540", VA = "0x13B6540")]
	public static void SetOverridenScale(float highlightScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003576")]
	[Cpp2IlInjected.Address(RVA = "0x13B65C8", Offset = "0x13B65C8", VA = "0x13B65C8")]
	public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003577")]
	[Cpp2IlInjected.Address(RVA = "0x13B6340", Offset = "0x13B6340", VA = "0x13B6340")]
	public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position, Color lightColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003578")]
	[Cpp2IlInjected.Address(RVA = "0x13B66AC", Offset = "0x13B66AC", VA = "0x13B66AC")]
	public static void Draw(SpriteBatch spriteBatch, Item[] inv, int context, int slot, Vector2 position, Color lightColor, Color backColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003579")]
	[Cpp2IlInjected.Address(RVA = "0x13BB2F8", Offset = "0x13BB2F8", VA = "0x13BB2F8")]
	public static Color GetColorByLoadout(int slot, int context)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600357A")]
	[Cpp2IlInjected.Address(RVA = "0x13BB5E4", Offset = "0x13BB5E4", VA = "0x13BB5E4")]
	public static Color GetHighlightColorByLoadout(int slot, int context)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600357B")]
	[Cpp2IlInjected.Address(RVA = "0x13BBFF4", Offset = "0x13BBFF4", VA = "0x13BBFF4")]
	public static void RecordLoadoutChange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600357C")]
	[Cpp2IlInjected.Address(RVA = "0x13BBE5C", Offset = "0x13BBE5C", VA = "0x13BBE5C")]
	public static bool TryGetSlotColor(int loadoutIndex, int context, out Color color)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600357D")]
	[Cpp2IlInjected.Address(RVA = "0x13BBF28", Offset = "0x13BBF28", VA = "0x13BBF28")]
	public static bool TryGetHighlightedSlotColor(int loadoutIndex, int context, out Color color)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600357E")]
	[Cpp2IlInjected.Address(RVA = "0x13BC0B0", Offset = "0x13BC0B0", VA = "0x13BC0B0")]
	public static float ShiftHueByLoadout(float hue, int loadoutIndex)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600357F")]
	[Cpp2IlInjected.Address(RVA = "0x13BC0D0", Offset = "0x13BC0D0", VA = "0x13BC0D0")]
	public static Color GetLoadoutColor(int loadoutIndex)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6003580")]
	[Cpp2IlInjected.Address(RVA = "0x13BB6FC", Offset = "0x13BB6FC", VA = "0x13BB6FC")]
	public static float DrawItemIcon(Item item, int context, SpriteBatch spriteBatch, Vector2 screenPositionForItemCenter, float scale, float sizeLimit, Color environmentColor)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003581")]
	[Cpp2IlInjected.Address(RVA = "0x13BC1BC", Offset = "0x13BC1BC", VA = "0x13BC1BC")]
	public static void DrawItem_GetColorAndScale(Item item, float scale, ref Color currentWhite, float sizeLimit, ref Rectangle frame, out Color itemLight, out float finalDrawScale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003582")]
	[Cpp2IlInjected.Address(RVA = "0x13BC374", Offset = "0x13BC374", VA = "0x13BC374")]
	public static void MouseHover(int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003583")]
	[Cpp2IlInjected.Address(RVA = "0x13BC474", Offset = "0x13BC474", VA = "0x13BC474")]
	public static void MouseHover(ref Item inv, int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003584")]
	[Cpp2IlInjected.Address(RVA = "0x13BC554", Offset = "0x13BC554", VA = "0x13BC554")]
	public static void UpdateTooltipButton(TransactionButton_Layout button)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003585")]
	[Cpp2IlInjected.Address(RVA = "0x13BC79C", Offset = "0x13BC79C", VA = "0x13BC79C")]
	public static void UpdateTooltipContext(int context, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003586")]
	[Cpp2IlInjected.Address(RVA = "0x13AFDD4", Offset = "0x13AFDD4", VA = "0x13AFDD4")]
	public static void MouseHover(Item[] inv, int context = 0, int slot = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003587")]
	[Cpp2IlInjected.Address(RVA = "0x13BC9E0", Offset = "0x13BC9E0", VA = "0x13BC9E0")]
	public static void SwapEquip(ref Item inv, int context = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003588")]
	[Cpp2IlInjected.Address(RVA = "0x13B4CB4", Offset = "0x13B4CB4", VA = "0x13B4CB4")]
	public static bool SwapEquip(Item[] inv, int context, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003589")]
	[Cpp2IlInjected.Address(RVA = "0x13BD4DC", Offset = "0x13BD4DC", VA = "0x13BD4DC")]
	public static bool Equippable(ref Item inv, int context = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600358A")]
	[Cpp2IlInjected.Address(RVA = "0x13BD5B4", Offset = "0x13BD5B4", VA = "0x13BD5B4")]
	public static bool Equippable(Item[] inv, int context, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600358B")]
	[Cpp2IlInjected.Address(RVA = "0x13BD750", Offset = "0x13BD750", VA = "0x13BD750")]
	public static bool IsMiscEquipment(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600358C")]
	[Cpp2IlInjected.Address(RVA = "0x13B3E18", Offset = "0x13B3E18", VA = "0x13B3E18")]
	public static bool AccCheck(Item[] itemCollection, Item item, int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600358D")]
	[Cpp2IlInjected.Address(RVA = "0x13BCAC0", Offset = "0x13BCAC0", VA = "0x13BCAC0")]
	private static Item DyeSwap(Item item, out bool success)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600358E")]
	[Cpp2IlInjected.Address(RVA = "0x13BCFA0", Offset = "0x13BCFA0", VA = "0x13BCFA0")]
	private static Item ArmorSwap(Item item, out bool success)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600358F")]
	[Cpp2IlInjected.Address(RVA = "0x13BCE48", Offset = "0x13BCE48", VA = "0x13BCE48")]
	private static Item EquipSwap(Item item, Item[] inv, int slot, out bool success)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003590")]
	[Cpp2IlInjected.Address(RVA = "0x13BD8A4", Offset = "0x13BD8A4", VA = "0x13BD8A4")]
	public static void DrawMoney(SpriteBatch sb, string text, float shopx, float shopy, int[] coinsArray, bool horizontal = false, [Optional] SpriteBatch textSb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003591")]
	[Cpp2IlInjected.Address(RVA = "0x13BE258", Offset = "0x13BE258", VA = "0x13BE258")]
	public static void DrawCost(SpriteBatch sb, float shopx, float shopy, long cost, [Optional] SpriteBatch textSb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003592")]
	[Cpp2IlInjected.Address(RVA = "0x13BE35C", Offset = "0x13BE35C", VA = "0x13BE35C")]
	public static void DrawSavings(SpriteBatch sb, Panel_Layout savingsBacking, float shopx, float shopy, Vector2 savings1IconOffset, Vector2 savings2Offset, Vector2 savings3Offset, Vector2 savings4Offset, bool horizontal = false, [Optional] SpriteBatch textSb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003593")]
	[Cpp2IlInjected.Address(RVA = "0x13BF0D4", Offset = "0x13BF0D4", VA = "0x13BF0D4")]
	public static void DrawSavings(SpriteBatch sb, float shopx, float shopy, bool horizontal = false, [Optional] SpriteBatch textSb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003594")]
	[Cpp2IlInjected.Address(RVA = "0x13BF900", Offset = "0x13BF900", VA = "0x13BF900")]
	public static void GetItemLight(ref Color currentColor, Item item, bool outInTheWorld = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003595")]
	[Cpp2IlInjected.Address(RVA = "0x13BF99C", Offset = "0x13BF99C", VA = "0x13BF99C")]
	public static void GetItemLight(ref Color currentColor, int type, bool outInTheWorld = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003596")]
	[Cpp2IlInjected.Address(RVA = "0x13BC2DC", Offset = "0x13BC2DC", VA = "0x13BC2DC")]
	public static void GetItemLight(ref Color currentColor, ref float scale, Item item, bool outInTheWorld = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003597")]
	[Cpp2IlInjected.Address(RVA = "0x13BFA34", Offset = "0x13BFA34", VA = "0x13BFA34")]
	public static Color GetItemLight(ref Color currentColor, ref float scale, int type, bool outInTheWorld = false)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6003598")]
	[Cpp2IlInjected.Address(RVA = "0x13BFD70", Offset = "0x13BFD70", VA = "0x13BFD70")]
	public static void DrawRadialCircular(SpriteBatch sb, Vector2 position, Player.SelectionRadial radial, Item[] items)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003599")]
	[Cpp2IlInjected.Address(RVA = "0x13C0474", Offset = "0x13C0474", VA = "0x13C0474")]
	public static void DrawRadialQuicks(SpriteBatch sb, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600359A")]
	[Cpp2IlInjected.Address(RVA = "0x13C0DE0", Offset = "0x13C0DE0", VA = "0x13C0DE0")]
	public static void DrawRadialDpad(SpriteBatch sb, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600359B")]
	[Cpp2IlInjected.Address(RVA = "0x13C136C", Offset = "0x13C136C", VA = "0x13C136C")]
	public static bool IsABuildingItem(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600359C")]
	[Cpp2IlInjected.Address(RVA = "0x13C13AC", Offset = "0x13C13AC", VA = "0x13C13AC")]
	public static void SelectEquipPage(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600359D")]
	[Cpp2IlInjected.Address(RVA = "0x13C160C", Offset = "0x13C160C", VA = "0x13C160C")]
	public ItemSlot()
	{
	}
}
