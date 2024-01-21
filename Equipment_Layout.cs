using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x200014E")]
public class Equipment_Layout : PageControllerLayoutDefinition<Equipment_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000C5B")]
	public float AmourScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000C5C")]
	public float ArmourHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000C5D")]
	public ItemGrid_Layout ArmourDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000C5E")]
	public ItemGrid_Layout ArmourVanity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000C5F")]
	public ItemGrid_Layout Armor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000C60")]
	public Microsoft.Xna.Framework.Vector2 ArmorCollapsePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000C61")]
	public float AccessoryScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000C62")]
	public float AccessoryHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000C63")]
	public ItemGrid_Layout AccessoryDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000C64")]
	public ItemGrid_Layout AccessoryVanity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000C65")]
	public ItemGrid_Layout Accessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000C66")]
	public Microsoft.Xna.Framework.Vector2 AccessoryCollapsePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000C67")]
	public ItemGrid_Layout AccessoryExtra;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000C68")]
	public ItemGrid_Layout AccessoryVanityExtra;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000C69")]
	public ItemGrid_Layout AccessoryDyeExtra;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000C6A")]
	public Microsoft.Xna.Framework.Vector2 AccessoryExtraCollapsePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000C6B")]
	public float QuickSlotScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000C6C")]
	public float QuickHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000C6D")]
	public ItemGrid_Layout QuickSlotDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000C6E")]
	public ItemGrid_Layout QuickSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000C6F")]
	public Microsoft.Xna.Framework.Vector2 QuickSlotCollapsePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000C70")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000C71")]
	public String_Layout ArmourTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000C72")]
	public String_Layout AccessoryTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000C73")]
	public String_Layout QuickSlotTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000C74")]
	public Button_Layout SetBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000C75")]
	public String_Layout SetBonusText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000C76")]
	public Button_Layout SetBonus_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000C77")]
	public String_Layout SetBonusText_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000C78")]
	public AnimationCurve ItemDragPulseScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000C79")]
	public TransactionButton_Layout UnequipButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000C7A")]
	public TransactionButton_Layout HideShowButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000C7B")]
	public HideShowIcons HideShowIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000C7C")]
	public TransactionButton_Layout ExpandButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000C7D")]
	public TransactionButton_Layout CollapseButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000C7E")]
	public Microsoft.Xna.Framework.Vector2 VisibilityOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000C7F")]
	public Microsoft.Xna.Framework.Graphics.Color VisibilityColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000C80")]
	public Microsoft.Xna.Framework.Vector2 MinecartOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000C81")]
	public Microsoft.Xna.Framework.Graphics.Color MinecartColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000C82")]
	public TransactionButton_Layout InfoToggleControllerButtonCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000C83")]
	public TransactionButton_Layout InfoToggleControllerButtonExpanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000C84")]
	public TransactionButton_Layout InfoToggleButtonCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000C85")]
	public TransactionButton_Layout InfoToggleButtonExpanded;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000C86")]
	public TransactionButton_Layout InfoToggleButtonCollapsed_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000C87")]
	public TransactionButton_Layout InfoToggleButtonExpanded_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000C88")]
	public Panel_Layout InfoAccessoriesBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000C89")]
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000C8A")]
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000C8B")]
	public ItemGrid_Layout InfoAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4000C8C")]
	public ItemGrid_Layout InfoAccessories_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000C8D")]
	public TransactionButton_Layout LoadoutToggleButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000C8E")]
	public TransactionButton_Layout LoadoutToggleButton_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000C8F")]
	public float InfoAccessoriesScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000C90")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000C91")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000C92")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000C93")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4000C94")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccVisColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000C95")]
	public float InfoAccVisScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000C96")]
	public Texture_Layout InfoAccBackingTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000C97")]
	public Microsoft.Xna.Framework.Vector2 InfoAccVisOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000C98")]
	public float InfoAccessoriesIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4000C99")]
	public ItemGrid_Layout Loadouts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000C9A")]
	public ItemGrid_Layout Loadouts_Horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000C9B")]
	public Panel_Layout LoadoutBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000C9C")]
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000C9D")]
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000C9E")]
	public float LoadoutScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4000C9F")]
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000CA0")]
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingHighlightColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000CA1")]
	public Texture_Layout LoadoutBackingTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000CA2")]
	public float LoadoutIconScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x4000CA3")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraDyeBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000CA4")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraVanityAccBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4000CA5")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraAccBackingColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000CA6")]
	public Texture_Layout DisabledAccessoryBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000CA7")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000CA8")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x4000CA9")]
	public Texture_Layout DisabledVanityAccessoryBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000CAA")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000CAB")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000CAC")]
	public Texture_Layout DisabledDyeAccessoryBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000CAD")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000CAE")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingIconColor;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Button_Layout DisplaySetBonus
	{
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x20D1D60", Offset = "0x20D1D60", VA = "0x20D1D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public String_Layout DisplaySetBonusText
	{
		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(RVA = "0x20D1DD8", Offset = "0x20D1DD8", VA = "0x20D1DD8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public TransactionButton_Layout InfoToggleCollapsed
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x20D1E50", Offset = "0x20D1E50", VA = "0x20D1E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public TransactionButton_Layout InfoToggleExpanded
	{
		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x20D1EE0", Offset = "0x20D1EE0", VA = "0x20D1EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public TransactionButton_Layout LoadoutToggle
	{
		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x20D1F70", Offset = "0x20D1F70", VA = "0x20D1F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public ItemGrid_Layout DisplayInfoAccessories
	{
		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x20D1FE8", Offset = "0x20D1FE8", VA = "0x20D1FE8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public ItemGrid_Layout DisplayLoadouts
	{
		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x20D2060", Offset = "0x20D2060", VA = "0x20D2060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x20D20D8", Offset = "0x20D20D8", VA = "0x20D20D8")]
	public Equipment_Layout()
	{
	}
}
