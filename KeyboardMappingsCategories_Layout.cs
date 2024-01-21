using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000163")]
public class KeyboardMappingsCategories_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007DD")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x4007BBB")]
		GeneralSettings,
		[Cpp2IlInjected.Token(Token = "0x4007BBC")]
		Exploration,
		[Cpp2IlInjected.Token(Token = "0x4007BBD")]
		Fighting,
		[Cpp2IlInjected.Token(Token = "0x4007BBE")]
		Miscellaneous,
		[Cpp2IlInjected.Token(Token = "0x4007BBF")]
		UI,
		[Cpp2IlInjected.Token(Token = "0x4007BC0")]
		Chest,
		[Cpp2IlInjected.Token(Token = "0x4007BC1")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x4007BC2")]
		Multiplayer,
		[Cpp2IlInjected.Token(Token = "0x4007BC3")]
		ShopCraft,
		[Cpp2IlInjected.Token(Token = "0x4007BC4")]
		Map
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007DE")]
	public class Setting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007BC5")]
		public Category Category;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007BC6")]
		public int SortOrder;

		[Cpp2IlInjected.Token(Token = "0x600491C")]
		[Cpp2IlInjected.Address(RVA = "0x12D5888", Offset = "0x12D5888", VA = "0x12D5888")]
		public Setting()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007DF")]
	public class MappingCategories
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007BC7")]
		public Setting Up;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007BC8")]
		public Setting Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007BC9")]
		public Setting Down;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007BCA")]
		public Setting Right;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007BCB")]
		public Setting GrappleFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007BCC")]
		public Setting Jump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007BCD")]
		public Setting Fire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007BCE")]
		public Setting Interact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007BCF")]
		public Setting TargetLockOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007BD0")]
		public Setting InventoryToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007BD1")]
		public Setting AutoSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007BD2")]
		public Setting SmartCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007BD3")]
		public Setting AutoFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007BD4")]
		public Setting HotbarNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007BD5")]
		public Setting HotbarPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4007BD6")]
		public Setting ZoomIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007BD7")]
		public Setting ZoomOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4007BD8")]
		public Setting MapZoomIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007BD9")]
		public Setting MapZoomOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007BDA")]
		public Setting MapZoomDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007BDB")]
		public Setting QuickMount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007BDC")]
		public Setting QuickHeal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007BDD")]
		public Setting QuickBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007BDE")]
		public Setting QuickMana;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007BDF")]
		public Setting MapToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4007BE0")]
		public Setting MiniMapToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4007BE1")]
		public Setting ChatToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4007BE2")]
		public Setting Settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4007BE3")]
		public Setting Hotbar1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4007BE4")]
		public Setting Hotbar2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4007BE5")]
		public Setting Hotbar3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4007BE6")]
		public Setting Hotbar4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4007BE7")]
		public Setting Hotbar5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4007BE8")]
		public Setting Hotbar6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4007BE9")]
		public Setting Hotbar7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4007BEA")]
		public Setting Hotbar8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4007BEB")]
		public Setting Hotbar9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4007BEC")]
		public Setting Hotbar10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4007BED")]
		public Setting Loadout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4007BEE")]
		public Setting Loadout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4007BEF")]
		public Setting Loadout3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4007BF0")]
		public Setting LoadoutCycle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4007BF1")]
		public Setting LeftPageCycle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4007BF2")]
		public Setting RightPageCycle;

		[Cpp2IlInjected.Token(Token = "0x600491D")]
		[Cpp2IlInjected.Address(RVA = "0x12D5880", Offset = "0x12D5880", VA = "0x12D5880")]
		public MappingCategories()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000D99")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000D9A")]
	public TransactionButton_Layout GeneralSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D9B")]
	public TransactionButton_Layout Exploration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000D9C")]
	public TransactionButton_Layout Fighting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D9D")]
	public TransactionButton_Layout Miscellaneous;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000D9E")]
	public TransactionButton_Layout UI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000D9F")]
	public TransactionButton_Layout Chest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000DA0")]
	public TransactionButton_Layout Equipment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000DA1")]
	public TransactionButton_Layout Multiplayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000DA2")]
	public TransactionButton_Layout ShopCraft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000DA3")]
	public TransactionButton_Layout Map;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000DA4")]
	public TransactionButton_Layout LB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000DA5")]
	public TransactionButton_Layout RB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000DA6")]
	public MappingCategories MappingSettings;

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x12D49F4", Offset = "0x12D49F4", VA = "0x12D49F4")]
	public void GetCategorySetup(string id, out Category category, out int sortOrder, int axisIndex = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x12D5878", Offset = "0x12D5878", VA = "0x12D5878")]
	public KeyboardMappingsCategories_Layout()
	{
	}
}
