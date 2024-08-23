using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x0200014D RID: 333
[global::Cpp2ILInjected.Token(Token = "0x20001D2")]
public class Equipment_Layout : PageControllerLayoutDefinition<Equipment_Layout>
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00023C0F File Offset: 0x00021E0F
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

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00023C12 File Offset: 0x00021E12
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

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00023C15 File Offset: 0x00021E15
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

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00023C18 File Offset: 0x00021E18
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

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00023C1B File Offset: 0x00021E1B
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

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00023C1E File Offset: 0x00021E1E
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

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00023C21 File Offset: 0x00021E21
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

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00023C24 File Offset: 0x00021E24
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

	// Token: 0x04000C52 RID: 3154
	[global::Cpp2ILInjected.Token(Token = "0x4001055")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float AmourScale;

	// Token: 0x04000C53 RID: 3155
	[global::Cpp2ILInjected.Token(Token = "0x4001056")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float ArmourHighlightScale;

	// Token: 0x04000C54 RID: 3156
	[global::Cpp2ILInjected.Token(Token = "0x4001057")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout ArmourDye;

	// Token: 0x04000C55 RID: 3157
	[global::Cpp2ILInjected.Token(Token = "0x4001058")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ArmourVanity;

	// Token: 0x04000C56 RID: 3158
	[global::Cpp2ILInjected.Token(Token = "0x4001059")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout Armor;

	// Token: 0x04000C57 RID: 3159
	[global::Cpp2ILInjected.Token(Token = "0x400105A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Microsoft.Xna.Framework.Vector2 ArmorCollapsePosition;

	// Token: 0x04000C58 RID: 3160
	[global::Cpp2ILInjected.Token(Token = "0x400105B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float AccessoryScale;

	// Token: 0x04000C59 RID: 3161
	[global::Cpp2ILInjected.Token(Token = "0x400105C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float AccessoryHighlightScale;

	// Token: 0x04000C5A RID: 3162
	[global::Cpp2ILInjected.Token(Token = "0x400105D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout AccessoryDye;

	// Token: 0x04000C5B RID: 3163
	[global::Cpp2ILInjected.Token(Token = "0x400105E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public ItemGrid_Layout AccessoryVanity;

	// Token: 0x04000C5C RID: 3164
	[global::Cpp2ILInjected.Token(Token = "0x400105F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ItemGrid_Layout Accessory;

	// Token: 0x04000C5D RID: 3165
	[global::Cpp2ILInjected.Token(Token = "0x4001060")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Microsoft.Xna.Framework.Vector2 AccessoryCollapsePosition;

	// Token: 0x04000C5E RID: 3166
	[global::Cpp2ILInjected.Token(Token = "0x4001061")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public ItemGrid_Layout AccessoryExtra;

	// Token: 0x04000C5F RID: 3167
	[global::Cpp2ILInjected.Token(Token = "0x4001062")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ItemGrid_Layout AccessoryVanityExtra;

	// Token: 0x04000C60 RID: 3168
	[global::Cpp2ILInjected.Token(Token = "0x4001063")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public ItemGrid_Layout AccessoryDyeExtra;

	// Token: 0x04000C61 RID: 3169
	[global::Cpp2ILInjected.Token(Token = "0x4001064")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Microsoft.Xna.Framework.Vector2 AccessoryExtraCollapsePosition;

	// Token: 0x04000C62 RID: 3170
	[global::Cpp2ILInjected.Token(Token = "0x4001065")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float QuickSlotScale;

	// Token: 0x04000C63 RID: 3171
	[global::Cpp2ILInjected.Token(Token = "0x4001066")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public float QuickHighlightScale;

	// Token: 0x04000C64 RID: 3172
	[global::Cpp2ILInjected.Token(Token = "0x4001067")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public ItemGrid_Layout QuickSlotDye;

	// Token: 0x04000C65 RID: 3173
	[global::Cpp2ILInjected.Token(Token = "0x4001068")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ItemGrid_Layout QuickSlot;

	// Token: 0x04000C66 RID: 3174
	[global::Cpp2ILInjected.Token(Token = "0x4001069")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Microsoft.Xna.Framework.Vector2 QuickSlotCollapsePosition;

	// Token: 0x04000C67 RID: 3175
	[global::Cpp2ILInjected.Token(Token = "0x400106A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout Title;

	// Token: 0x04000C68 RID: 3176
	[global::Cpp2ILInjected.Token(Token = "0x400106B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout ArmourTitle;

	// Token: 0x04000C69 RID: 3177
	[global::Cpp2ILInjected.Token(Token = "0x400106C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public String_Layout AccessoryTitle;

	// Token: 0x04000C6A RID: 3178
	[global::Cpp2ILInjected.Token(Token = "0x400106D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public String_Layout QuickSlotTitle;

	// Token: 0x04000C6B RID: 3179
	[global::Cpp2ILInjected.Token(Token = "0x400106E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Button_Layout SetBonus;

	// Token: 0x04000C6C RID: 3180
	[global::Cpp2ILInjected.Token(Token = "0x400106F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public String_Layout SetBonusText;

	// Token: 0x04000C6D RID: 3181
	[global::Cpp2ILInjected.Token(Token = "0x4001070")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Button_Layout SetBonus_Horizontal;

	// Token: 0x04000C6E RID: 3182
	[global::Cpp2ILInjected.Token(Token = "0x4001071")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public String_Layout SetBonusText_Horizontal;

	// Token: 0x04000C6F RID: 3183
	[global::Cpp2ILInjected.Token(Token = "0x4001072")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public AnimationCurve ItemDragPulseScale;

	// Token: 0x04000C70 RID: 3184
	[global::Cpp2ILInjected.Token(Token = "0x4001073")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout UnequipButton;

	// Token: 0x04000C71 RID: 3185
	[global::Cpp2ILInjected.Token(Token = "0x4001074")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout HideShowButton;

	// Token: 0x04000C72 RID: 3186
	[global::Cpp2ILInjected.Token(Token = "0x4001075")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public HideShowIcons HideShowIcons;

	// Token: 0x04000C73 RID: 3187
	[global::Cpp2ILInjected.Token(Token = "0x4001076")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout ExpandButton;

	// Token: 0x04000C74 RID: 3188
	[global::Cpp2ILInjected.Token(Token = "0x4001077")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout CollapseButton;

	// Token: 0x04000C75 RID: 3189
	[global::Cpp2ILInjected.Token(Token = "0x4001078")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Microsoft.Xna.Framework.Vector2 VisibilityOffset;

	// Token: 0x04000C76 RID: 3190
	[global::Cpp2ILInjected.Token(Token = "0x4001079")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public Microsoft.Xna.Framework.Graphics.Color VisibilityColour;

	// Token: 0x04000C77 RID: 3191
	[global::Cpp2ILInjected.Token(Token = "0x400107A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	public Microsoft.Xna.Framework.Vector2 MinecartOffset;

	// Token: 0x04000C78 RID: 3192
	[global::Cpp2ILInjected.Token(Token = "0x400107B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
	public Microsoft.Xna.Framework.Graphics.Color MinecartColour;

	// Token: 0x04000C79 RID: 3193
	[global::Cpp2ILInjected.Token(Token = "0x400107C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout InfoToggleControllerButtonCollapsed;

	// Token: 0x04000C7A RID: 3194
	[global::Cpp2ILInjected.Token(Token = "0x400107D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout InfoToggleControllerButtonExpanded;

	// Token: 0x04000C7B RID: 3195
	[global::Cpp2ILInjected.Token(Token = "0x400107E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public TransactionButton_Layout InfoToggleButtonCollapsed;

	// Token: 0x04000C7C RID: 3196
	[global::Cpp2ILInjected.Token(Token = "0x400107F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public TransactionButton_Layout InfoToggleButtonExpanded;

	// Token: 0x04000C7D RID: 3197
	[global::Cpp2ILInjected.Token(Token = "0x4001080")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public TransactionButton_Layout InfoToggleButtonCollapsed_Horizontal;

	// Token: 0x04000C7E RID: 3198
	[global::Cpp2ILInjected.Token(Token = "0x4001081")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public TransactionButton_Layout InfoToggleButtonExpanded_Horizontal;

	// Token: 0x04000C7F RID: 3199
	[global::Cpp2ILInjected.Token(Token = "0x4001082")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout InfoAccessoriesBacking;

	// Token: 0x04000C80 RID: 3200
	[global::Cpp2ILInjected.Token(Token = "0x4001083")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingTLOffset;

	// Token: 0x04000C81 RID: 3201
	[global::Cpp2ILInjected.Token(Token = "0x4001084")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Microsoft.Xna.Framework.Vector2 InfoAccessoriesBackingBROffset;

	// Token: 0x04000C82 RID: 3202
	[global::Cpp2ILInjected.Token(Token = "0x4001085")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public ItemGrid_Layout InfoAccessories;

	// Token: 0x04000C83 RID: 3203
	[global::Cpp2ILInjected.Token(Token = "0x4001086")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public ItemGrid_Layout InfoAccessories_Horizontal;

	// Token: 0x04000C84 RID: 3204
	[global::Cpp2ILInjected.Token(Token = "0x4001087")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public TransactionButton_Layout LoadoutToggleButton;

	// Token: 0x04000C85 RID: 3205
	[global::Cpp2ILInjected.Token(Token = "0x4001088")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public TransactionButton_Layout LoadoutToggleButton_Horizontal;

	// Token: 0x04000C86 RID: 3206
	[global::Cpp2ILInjected.Token(Token = "0x4001089")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public float InfoAccessoriesScale;

	// Token: 0x04000C87 RID: 3207
	[global::Cpp2ILInjected.Token(Token = "0x400108A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccNormal;

	// Token: 0x04000C88 RID: 3208
	[global::Cpp2ILInjected.Token(Token = "0x400108B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccDisabled;

	// Token: 0x04000C89 RID: 3209
	[global::Cpp2ILInjected.Token(Token = "0x400108C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingColour;

	// Token: 0x04000C8A RID: 3210
	[global::Cpp2ILInjected.Token(Token = "0x400108D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccBackingHighlightColour;

	// Token: 0x04000C8B RID: 3211
	[global::Cpp2ILInjected.Token(Token = "0x400108E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B4")]
	public Microsoft.Xna.Framework.Graphics.Color InfoAccVisColour;

	// Token: 0x04000C8C RID: 3212
	[global::Cpp2ILInjected.Token(Token = "0x400108F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public float InfoAccVisScale;

	// Token: 0x04000C8D RID: 3213
	[global::Cpp2ILInjected.Token(Token = "0x4001090")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public Texture_Layout InfoAccBackingTexture;

	// Token: 0x04000C8E RID: 3214
	[global::Cpp2ILInjected.Token(Token = "0x4001091")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public Microsoft.Xna.Framework.Vector2 InfoAccVisOffset;

	// Token: 0x04000C8F RID: 3215
	[global::Cpp2ILInjected.Token(Token = "0x4001092")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public float InfoAccessoriesIconScale;

	// Token: 0x04000C90 RID: 3216
	[global::Cpp2ILInjected.Token(Token = "0x4001093")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public ItemGrid_Layout Loadouts;

	// Token: 0x04000C91 RID: 3217
	[global::Cpp2ILInjected.Token(Token = "0x4001094")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public ItemGrid_Layout Loadouts_Horizontal;

	// Token: 0x04000C92 RID: 3218
	[global::Cpp2ILInjected.Token(Token = "0x4001095")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Panel_Layout LoadoutBacking;

	// Token: 0x04000C93 RID: 3219
	[global::Cpp2ILInjected.Token(Token = "0x4001096")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingTLOffset;

	// Token: 0x04000C94 RID: 3220
	[global::Cpp2ILInjected.Token(Token = "0x4001097")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Microsoft.Xna.Framework.Vector2 LoadoutBackingBROffset;

	// Token: 0x04000C95 RID: 3221
	[global::Cpp2ILInjected.Token(Token = "0x4001098")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
	public float LoadoutScale;

	// Token: 0x04000C96 RID: 3222
	[global::Cpp2ILInjected.Token(Token = "0x4001099")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x204")]
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingColour;

	// Token: 0x04000C97 RID: 3223
	[global::Cpp2ILInjected.Token(Token = "0x400109A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
	public Microsoft.Xna.Framework.Graphics.Color LoadoutBackingHighlightColour;

	// Token: 0x04000C98 RID: 3224
	[global::Cpp2ILInjected.Token(Token = "0x400109B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
	public Texture_Layout LoadoutBackingTexture;

	// Token: 0x04000C99 RID: 3225
	[global::Cpp2ILInjected.Token(Token = "0x400109C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
	public float LoadoutIconScale;

	// Token: 0x04000C9A RID: 3226
	[global::Cpp2ILInjected.Token(Token = "0x400109D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21C")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraDyeBackingColour;

	// Token: 0x04000C9B RID: 3227
	[global::Cpp2ILInjected.Token(Token = "0x400109E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraVanityAccBackingColour;

	// Token: 0x04000C9C RID: 3228
	[global::Cpp2ILInjected.Token(Token = "0x400109F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x224")]
	public Microsoft.Xna.Framework.Graphics.Color ExtraAccBackingColour;

	// Token: 0x04000C9D RID: 3229
	[global::Cpp2ILInjected.Token(Token = "0x40010A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	public Texture_Layout DisabledAccessoryBacking;

	// Token: 0x04000C9E RID: 3230
	[global::Cpp2ILInjected.Token(Token = "0x40010A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingColor;

	// Token: 0x04000C9F RID: 3231
	[global::Cpp2ILInjected.Token(Token = "0x40010A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x234")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledAccessoryBackingIconColor;

	// Token: 0x04000CA0 RID: 3232
	[global::Cpp2ILInjected.Token(Token = "0x40010A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public Texture_Layout DisabledVanityAccessoryBacking;

	// Token: 0x04000CA1 RID: 3233
	[global::Cpp2ILInjected.Token(Token = "0x40010A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingColor;

	// Token: 0x04000CA2 RID: 3234
	[global::Cpp2ILInjected.Token(Token = "0x40010A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x244")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledVanityAccessoryBackingIconColor;

	// Token: 0x04000CA3 RID: 3235
	[global::Cpp2ILInjected.Token(Token = "0x40010A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public Texture_Layout DisabledDyeAccessoryBacking;

	// Token: 0x04000CA4 RID: 3236
	[global::Cpp2ILInjected.Token(Token = "0x40010A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingColor;

	// Token: 0x04000CA5 RID: 3237
	[global::Cpp2ILInjected.Token(Token = "0x40010A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x254")]
	public Microsoft.Xna.Framework.Graphics.Color DisabledDyeAccessoryBackingIconColor;
}
