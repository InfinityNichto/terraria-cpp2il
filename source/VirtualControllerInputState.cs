using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria;
using Terraria.ID;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x200010E")]
public class VirtualControllerInputState
{
	[Cpp2IlInjected.Token(Token = "0x20007CA")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x4007A8F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007A90")]
		Generic,
		[Cpp2IlInjected.Token(Token = "0x4007A91")]
		Axe,
		[Cpp2IlInjected.Token(Token = "0x4007A92")]
		PickAxe,
		[Cpp2IlInjected.Token(Token = "0x4007A93")]
		Drills,
		[Cpp2IlInjected.Token(Token = "0x4007A94")]
		Chainsaw,
		[Cpp2IlInjected.Token(Token = "0x4007A95")]
		Broadsword,
		[Cpp2IlInjected.Token(Token = "0x4007A96")]
		NonAutoFireMeleeStab,
		[Cpp2IlInjected.Token(Token = "0x4007A97")]
		NonAutoFireMeleeSwing,
		[Cpp2IlInjected.Token(Token = "0x4007A98")]
		AutoFireMeleeSwing,
		[Cpp2IlInjected.Token(Token = "0x4007A99")]
		AutoFireMeleeProjectile,
		[Cpp2IlInjected.Token(Token = "0x4007A9A")]
		AutoFireMeleeProjectileNoAim,
		[Cpp2IlInjected.Token(Token = "0x4007A9B")]
		Spears,
		[Cpp2IlInjected.Token(Token = "0x4007A9C")]
		Boomerangs,
		[Cpp2IlInjected.Token(Token = "0x4007A9D")]
		Flails,
		[Cpp2IlInjected.Token(Token = "0x4007A9E")]
		FlailsAutoSwing,
		[Cpp2IlInjected.Token(Token = "0x4007A9F")]
		Yoyo,
		[Cpp2IlInjected.Token(Token = "0x4007AA0")]
		Bow,
		[Cpp2IlInjected.Token(Token = "0x4007AA1")]
		AutoFireBow,
		[Cpp2IlInjected.Token(Token = "0x4007AA2")]
		Repeaters,
		[Cpp2IlInjected.Token(Token = "0x4007AA3")]
		ManualGuns,
		[Cpp2IlInjected.Token(Token = "0x4007AA4")]
		AutomaticGuns,
		[Cpp2IlInjected.Token(Token = "0x4007AA5")]
		GrapplingHooks,
		[Cpp2IlInjected.Token(Token = "0x4007AA6")]
		RocketConsuming,
		[Cpp2IlInjected.Token(Token = "0x4007AA7")]
		AutoFireRocketConsuming,
		[Cpp2IlInjected.Token(Token = "0x4007AA8")]
		SummoningMinion,
		[Cpp2IlInjected.Token(Token = "0x4007AA9")]
		SummoningSentry,
		[Cpp2IlInjected.Token(Token = "0x4007AAA")]
		ThrowingWeapons,
		[Cpp2IlInjected.Token(Token = "0x4007AAB")]
		MagicWeapons,
		[Cpp2IlInjected.Token(Token = "0x4007AAC")]
		AutoFireMagicWeapons,
		[Cpp2IlInjected.Token(Token = "0x4007AAD")]
		ControlledMagicWeapons,
		[Cpp2IlInjected.Token(Token = "0x4007AAE")]
		AutoFireControlledMagicWeapons,
		[Cpp2IlInjected.Token(Token = "0x4007AAF")]
		Torches,
		[Cpp2IlInjected.Token(Token = "0x4007AB0")]
		Hammer,
		[Cpp2IlInjected.Token(Token = "0x4007AB1")]
		PlacementSingle,
		[Cpp2IlInjected.Token(Token = "0x4007AB2")]
		PlacementMulti,
		[Cpp2IlInjected.Token(Token = "0x4007AB3")]
		PlacementMultiWalls,
		[Cpp2IlInjected.Token(Token = "0x4007AB4")]
		HealingPotion,
		[Cpp2IlInjected.Token(Token = "0x4007AB5")]
		ManaPotion,
		[Cpp2IlInjected.Token(Token = "0x4007AB6")]
		BuffPotion,
		[Cpp2IlInjected.Token(Token = "0x4007AB7")]
		FoodAndDrink,
		[Cpp2IlInjected.Token(Token = "0x4007AB8")]
		Flasks,
		[Cpp2IlInjected.Token(Token = "0x4007AB9")]
		OtherPotions,
		[Cpp2IlInjected.Token(Token = "0x4007ABA")]
		Seeds,
		[Cpp2IlInjected.Token(Token = "0x4007ABB")]
		FishingPoles,
		[Cpp2IlInjected.Token(Token = "0x4007ABC")]
		ExcludedAutoSwingAimUse,
		[Cpp2IlInjected.Token(Token = "0x4007ABD")]
		ExcludedAutoSwing,
		[Cpp2IlInjected.Token(Token = "0x4007ABE")]
		NonFireItems,
		[Cpp2IlInjected.Token(Token = "0x4007ABF")]
		HousingNPC,
		[Cpp2IlInjected.Token(Token = "0x4007AC0")]
		AutoFireMeleeStab,
		[Cpp2IlInjected.Token(Token = "0x4007AC1")]
		MiscPlace,
		[Cpp2IlInjected.Token(Token = "0x4007AC2")]
		MiscPlaceWalls,
		[Cpp2IlInjected.Token(Token = "0x4007AC3")]
		MiscBreak,
		[Cpp2IlInjected.Token(Token = "0x4007AC4")]
		Instrument,
		[Cpp2IlInjected.Token(Token = "0x4007AC5")]
		GolfClubs,
		[Cpp2IlInjected.Token(Token = "0x4007AC6")]
		SummoningWhip,
		[Cpp2IlInjected.Token(Token = "0x4007AC7")]
		Glowsticks,
		[Cpp2IlInjected.Token(Token = "0x4007AC8")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x20007CB")]
	public struct CaterogryEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007AC9")]
		private ItemID item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007ACA")]
		private Category category;
	}

	[Cpp2IlInjected.Token(Token = "0x20007CC")]
	public enum CursorInputMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007ACC")]
		Item,
		[Cpp2IlInjected.Token(Token = "0x4007ACD")]
		Global,
		[Cpp2IlInjected.Token(Token = "0x4007ACE")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x4007ACF")]
		AlwaysOn
	}

	[Cpp2IlInjected.Token(Token = "0x4000866")]
	private static string[] IdLookup;

	[Cpp2IlInjected.Token(Token = "0x4000867")]
	public static int[] ItemCategories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000868")]
	public bool printMessages;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000869")]
	public bool ForceAutoSwingEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400086A")]
	public CursorInputMode TouchSmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400086B")]
	public CursorInputMode TouchAimAndUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400086C")]
	public CursorInputMode ControllerSmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400086D")]
	public CursorInputMode ControllerAimAndUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400086E")]
	public CursorInputMode MouseSmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400086F")]
	public bool AutoSelectSmartDigEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000870")]
	public bool GlobalSmartDigEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000871")]
	public bool GlobalAimAndUseEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000872")]
	private bool _currentSmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000873")]
	private bool _currentAimAndUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000874")]
	private float _noFireDeadZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000875")]
	private bool _currentAutoReuse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000876")]
	private Dictionary<Category, bool> SmartCursorState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000877")]
	private Dictionary<Category, bool> AimAndUseState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000878")]
	private Dictionary<Category, float> NoFireDeadZoneState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000879")]
	public Category CurrentlyBoundCategory;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private string ConfigFile
	{
		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0xE8AE84", Offset = "0xE8AE84", VA = "0xE8AE84")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool ForceAutoReuse
	{
		[Cpp2IlInjected.Token(Token = "0x60009FA")]
		[Cpp2IlInjected.Address(RVA = "0xE8BC84", Offset = "0xE8BC84", VA = "0xE8BC84")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public float NoFireDeadZone
	{
		[Cpp2IlInjected.Token(Token = "0x60009FB")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCCC", Offset = "0xE8BCCC", VA = "0xE8BCCC")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public bool SmartDigEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCD4", Offset = "0xE8BCD4", VA = "0xE8BCD4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0xE8BE5C", Offset = "0xE8BE5C", VA = "0xE8BE5C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool AimAndUseEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0xE8BFB4", Offset = "0xE8BFB4", VA = "0xE8BFB4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0xE8C144", Offset = "0xE8C144", VA = "0xE8C144")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xE8ABA8", Offset = "0xE8ABA8", VA = "0xE8ABA8")]
	private static void SetupLookups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0xE8AF10", Offset = "0xE8AF10", VA = "0xE8AF10")]
	private static void SaveCodeArrayCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xE8B2BC", Offset = "0xE8B2BC", VA = "0xE8B2BC")]
	public void SaveDefaultCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0xE8B5F4", Offset = "0xE8B5F4", VA = "0xE8B5F4")]
	public void LoadDefaultCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0xE8B5F8", Offset = "0xE8B5F8", VA = "0xE8B5F8")]
	public float GetItemDeadZone(Item item)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0xE8B79C", Offset = "0xE8B79C", VA = "0xE8B79C")]
	public static Category GetItemCategory(int item)
	{
		return default(Category);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xE8B9C0", Offset = "0xE8B9C0", VA = "0xE8B9C0")]
	public void UpdateState(int selectedItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0xE8BAA4", Offset = "0xE8BAA4", VA = "0xE8BAA4")]
	private void SetCatergoryState(Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0xE8BC9C", Offset = "0xE8BC9C", VA = "0xE8BC9C")]
	private bool GetCategoryAutoSwing(Category category)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0xE8B820", Offset = "0xE8B820", VA = "0xE8B820")]
	private void GetCategoryDefaults(Category category, out bool smartCursor, out bool aimAndUse, out float noFireDeadZone)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0xE8C238", Offset = "0xE8C238", VA = "0xE8C238")]
	public void ResetConfiguration()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0xE8C330", Offset = "0xE8C330", VA = "0xE8C330")]
	public void LoadConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0xE8C5AC", Offset = "0xE8C5AC", VA = "0xE8C5AC")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0xE8C7F4", Offset = "0xE8C7F4", VA = "0xE8C7F4")]
	public VirtualControllerInputState()
	{
	}
}
