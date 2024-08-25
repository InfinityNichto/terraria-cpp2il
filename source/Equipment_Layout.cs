using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20001D2")]
public class Equipment_Layout : PageControllerLayoutDefinition<Equipment_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
	public Button_Layout DisplaySetBonus
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5EEC", Offset = "0x9B5EEC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawArmourBonus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
		{
			typeof(GUIPageIconGrouping),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
	public String_Layout DisplaySetBonusText
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5F58", Offset = "0x9B5F58", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "DrawArmourBonus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
	public TransactionButton_Layout InfoToggleCollapsed
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B5FC4", Offset = "0x9B5FC4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "IsOverGroupRegion", MemberParameters = new object[]
		{
			typeof(GUIPageIconGrouping),
			typeof(Point)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
	public TransactionButton_Layout InfoToggleExpanded
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B6044", Offset = "0x9B6044", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
	public TransactionButton_Layout LoadoutToggle
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B60C4", Offset = "0x9B60C4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "DrawToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
	public ItemGrid_Layout DisplayInfoAccessories
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B6130", Offset = "0x9B6130", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetInfoGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "DrawInfoAccesoriesToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000150")]
	public ItemGrid_Layout DisplayLoadouts
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B619C", Offset = "0x9B619C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerEquipment4Page), Member = "GetLoadoutGrid", ReturnType = typeof(ItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "GetRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "DrawToggles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentLoadout), Member = "DrawLoadouts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C08")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6208", Offset = "0x9B6208", Length = "0x290")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public Equipment_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001055")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float AmourScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001056")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ArmourHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001057")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout ArmourDye;

	[global::Cpp2ILInjected.Token(Token = "0x4001058")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ArmourVanity;

	[global::Cpp2ILInjected.Token(Token = "0x4001059")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout Armor;

	[global::Cpp2ILInjected.Token(Token = "0x400105A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Microsoft.Xna.Framework.Vector2 ArmorCollapsePosition;

	[global::Cpp2ILInjected.Token(Token = "0x400105B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float AccessoryScale;

	[global::Cpp2ILInjected.Token(Token = "0x400105C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float AccessoryHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400105D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout AccessoryDye;

	[global::Cpp2ILInjected.Token(Token = "0x400105E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ItemGrid_Layout AccessoryVanity;

	[global::Cpp2ILInjected.Token(Token = "0x400105F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout Accessory;

	[global::Cpp2ILInjected.Token(Token = "0x4001060")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Microsoft.Xna.Framework.Vector2 AccessoryCollapsePosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001061")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout AccessoryExtra;

	[global::Cpp2ILInjected.Token(Token = "0x4001062")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ItemGrid_Layout AccessoryVanityExtra;

	[global::Cpp2ILInjected.Token(Token = "0x4001063")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ItemGrid_Layout AccessoryDyeExtra;

	[global::Cpp2ILInjected.Token(Token = "0x4001064")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Microsoft.Xna.Framework.Vector2 AccessoryExtraCollapsePosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001065")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float QuickSlotScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001066")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public float QuickHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001067")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public ItemGrid_Layout QuickSlotDye;

	[global::Cpp2ILInjected.Token(Token = "0x4001068")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ItemGrid_Layout QuickSlot;

	[global::Cpp2ILInjected.Token(Token = "0x4001069")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Microsoft.Xna.Framework.Vector2 QuickSlotCollapsePosition;

	[global::Cpp2ILInjected.Token(Token = "0x400106A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400106B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout ArmourTitle;

	[global::Cpp2ILInjected.Token(Token = "0x400106C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout AccessoryTitle;

	[global::Cpp2ILInjected.Token(Token = "0x400106D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public String_Layout QuickSlotTitle;

	[global::Cpp2ILInjected.Token(Token = "0x400106E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout SetBonus;

	[global::Cpp2ILInjected.Token(Token = "0x400106F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout SetBonusText;

	[global::Cpp2ILInjected.Token(Token = "0x4001070")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Button_Layout SetBonus_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001071")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public String_Layout SetBonusText_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001072")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public AnimationCurve ItemDragPulseScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001073")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout UnequipButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001074")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout HideShowButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001075")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public HideShowIcons HideShowIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4001076")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout ExpandButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001077")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout CollapseButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001078")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Microsoft.Xna.Framework.Vector2 VisibilityOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001079")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Microsoft.Xna.Framework.Graphics.Color VisibilityColour;

	[global::Cpp2ILInjected.Token(Token = "0x400107A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	public Microsoft.Xna.Framework.Vector2 MinecartOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400107B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
	public Microsoft.Xna.Framework.Graphics.Color MinecartColour;

	[global::Cpp2ILInjected.Token(Token = "0x400107C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout InfoToggleControllerButtonCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x400107D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout InfoToggleControllerButtonExpanded;

	[global::Cpp2ILInjected.Token(Token = "0x400107E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public TransactionButton_Layout InfoToggleButtonCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x400107F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public TransactionButton_Layout InfoToggleButtonExpanded;

	[global::Cpp2ILInjected.Token(Token = "0x4001080")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public TransactionButton_Layout InfoToggleButtonCollapsed_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001081")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public TransactionButton_Layout InfoToggleButtonExpanded_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001082")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout InfoAccessoriesBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001083")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001084")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001085")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public ItemGrid_Layout InfoAccessories;

	[global::Cpp2ILInjected.Token(Token = "0x4001086")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public ItemGrid_Layout InfoAccessories_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001087")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public TransactionButton_Layout LoadoutToggleButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001088")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public TransactionButton_Layout LoadoutToggleButton_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001089")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public float InfoAccessoriesScale;

	[global::Cpp2ILInjected.Token(Token = "0x400108A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccNormal;

	[global::Cpp2ILInjected.Token(Token = "0x400108B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccDisabled;

	[global::Cpp2ILInjected.Token(Token = "0x400108C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400108D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingHighlightColour;

	[global::Cpp2ILInjected.Token(Token = "0x400108E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccVisColour;

	[global::Cpp2ILInjected.Token(Token = "0x400108F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public float InfoAccVisScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001090")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Texture_Layout InfoAccBackingTexture;

	[global::Cpp2ILInjected.Token(Token = "0x4001091")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public Microsoft.Xna.Framework.Vector2 InfoAccVisOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001092")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public float InfoAccessoriesIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001093")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public ItemGrid_Layout Loadouts;

	[global::Cpp2ILInjected.Token(Token = "0x4001094")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public ItemGrid_Layout Loadouts_Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001095")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Panel_Layout LoadoutBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001096")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001097")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingBROffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001098")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public float LoadoutScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001099")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400109A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingHighlightColour;

	[global::Cpp2ILInjected.Token(Token = "0x400109B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public Texture_Layout LoadoutBackingTexture;

	[global::Cpp2ILInjected.Token(Token = "0x400109C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public float LoadoutIconScale;

	[global::Cpp2ILInjected.Token(Token = "0x400109D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21C")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraDyeBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400109E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraVanityAccBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x400109F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x224")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraAccBackingColour;

	[global::Cpp2ILInjected.Token(Token = "0x40010A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public Texture_Layout DisabledAccessoryBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40010A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x234")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x40010A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public Texture_Layout DisabledVanityAccessoryBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40010A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x244")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x40010A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public Texture_Layout DisabledDyeAccessoryBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40010A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40010A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x254")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingIconColor;
}
