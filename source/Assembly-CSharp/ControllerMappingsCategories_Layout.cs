using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000129 RID: 297
[global::Cpp2ILInjected.Token(Token = "0x20001A1")]
[Serializable]
public class ControllerMappingsCategories_Layout
{
	// Token: 0x06000A60 RID: 2656 RVA: 0x00023A65 File Offset: 0x00021C65
	[global::Cpp2ILInjected.Token(Token = "0x6000B6D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACA64", Offset = "0x9ACA64", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPulldownEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSliderEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerToggleEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void GetCategorySetup(GUISettingID id, out ControllerMappingsCategories_Layout.Category category, out int sortOrder)
	{
		throw null;
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00023A68 File Offset: 0x00021C68
	[global::Cpp2ILInjected.Token(Token = "0x6000B6E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACB18", Offset = "0x9ACB18", Length = "0x1D1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 102)]
	public void GetCategorySetup(string actionId, out ControllerMappingsCategories_Layout.Category category, out int sortOrder)
	{
		throw null;
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00023A6B File Offset: 0x00021C6B
	[global::Cpp2ILInjected.Token(Token = "0x6000B6F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE834", Offset = "0x9AE834", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ControllerMappingsCategories_Layout()
	{
		throw null;
	}

	// Token: 0x04000A05 RID: 2565
	[global::Cpp2ILInjected.Token(Token = "0x4000D27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04000A06 RID: 2566
	[global::Cpp2ILInjected.Token(Token = "0x4000D28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout GeneralSettings;

	// Token: 0x04000A07 RID: 2567
	[global::Cpp2ILInjected.Token(Token = "0x4000D29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Exploration;

	// Token: 0x04000A08 RID: 2568
	[global::Cpp2ILInjected.Token(Token = "0x4000D2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Fighting;

	// Token: 0x04000A09 RID: 2569
	[global::Cpp2ILInjected.Token(Token = "0x4000D2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Miscellaneous;

	// Token: 0x04000A0A RID: 2570
	[global::Cpp2ILInjected.Token(Token = "0x4000D2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout UI;

	// Token: 0x04000A0B RID: 2571
	[global::Cpp2ILInjected.Token(Token = "0x4000D2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Chest;

	// Token: 0x04000A0C RID: 2572
	[global::Cpp2ILInjected.Token(Token = "0x4000D2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Equipment;

	// Token: 0x04000A0D RID: 2573
	[global::Cpp2ILInjected.Token(Token = "0x4000D2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Multiplayer;

	// Token: 0x04000A0E RID: 2574
	[global::Cpp2ILInjected.Token(Token = "0x4000D30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ShopCraft;

	// Token: 0x04000A0F RID: 2575
	[global::Cpp2ILInjected.Token(Token = "0x4000D31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Map;

	// Token: 0x04000A10 RID: 2576
	[global::Cpp2ILInjected.Token(Token = "0x4000D32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout LB;

	// Token: 0x04000A11 RID: 2577
	[global::Cpp2ILInjected.Token(Token = "0x4000D33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout RB;

	// Token: 0x04000A12 RID: 2578
	[global::Cpp2ILInjected.Token(Token = "0x4000D34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ControllerMappingsCategories_Layout.MappingCategories MappingSettings;

	// Token: 0x020007D9 RID: 2009
	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	public enum Category
	{
		// Token: 0x04007AED RID: 31469
		[global::Cpp2ILInjected.Token(Token = "0x4000D36")]
		GeneralSettings,
		// Token: 0x04007AEE RID: 31470
		[global::Cpp2ILInjected.Token(Token = "0x4000D37")]
		Exploration,
		// Token: 0x04007AEF RID: 31471
		[global::Cpp2ILInjected.Token(Token = "0x4000D38")]
		Fighting,
		// Token: 0x04007AF0 RID: 31472
		[global::Cpp2ILInjected.Token(Token = "0x4000D39")]
		Miscellaneous,
		// Token: 0x04007AF1 RID: 31473
		[global::Cpp2ILInjected.Token(Token = "0x4000D3A")]
		UI,
		// Token: 0x04007AF2 RID: 31474
		[global::Cpp2ILInjected.Token(Token = "0x4000D3B")]
		Chest,
		// Token: 0x04007AF3 RID: 31475
		[global::Cpp2ILInjected.Token(Token = "0x4000D3C")]
		Equipment,
		// Token: 0x04007AF4 RID: 31476
		[global::Cpp2ILInjected.Token(Token = "0x4000D3D")]
		Multiplayer,
		// Token: 0x04007AF5 RID: 31477
		[global::Cpp2ILInjected.Token(Token = "0x4000D3E")]
		ShopCraft,
		// Token: 0x04007AF6 RID: 31478
		[global::Cpp2ILInjected.Token(Token = "0x4000D3F")]
		Map
	}

	// Token: 0x020007DA RID: 2010
	[global::Cpp2ILInjected.Token(Token = "0x20001A3")]
	[Serializable]
	public class Setting
	{
		// Token: 0x060048E0 RID: 18656 RVA: 0x0002EEF5 File Offset: 0x0002D0F5
		[global::Cpp2ILInjected.Token(Token = "0x6000B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AE83C", Offset = "0x9AE83C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Setting()
		{
			throw null;
		}

		// Token: 0x04007AF7 RID: 31479
		[global::Cpp2ILInjected.Token(Token = "0x4000D40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControllerMappingsCategories_Layout.Category Category;

		// Token: 0x04007AF8 RID: 31480
		[global::Cpp2ILInjected.Token(Token = "0x4000D41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SortOrder;
	}

	// Token: 0x020007DB RID: 2011
	[global::Cpp2ILInjected.Token(Token = "0x20001A4")]
	[Serializable]
	public class MappingCategories
	{
		// Token: 0x060048E1 RID: 18657 RVA: 0x0002EEF8 File Offset: 0x0002D0F8
		[global::Cpp2ILInjected.Token(Token = "0x6000B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AE84C", Offset = "0x9AE84C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MappingCategories()
		{
			throw null;
		}

		// Token: 0x04007AF9 RID: 31481
		[global::Cpp2ILInjected.Token(Token = "0x4000D42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControllerMappingsCategories_Layout.Setting Controls;

		// Token: 0x04007AFA RID: 31482
		[global::Cpp2ILInjected.Token(Token = "0x4000D43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ControllerMappingsCategories_Layout.Setting ControllerAimAndUseMode;

		// Token: 0x04007AFB RID: 31483
		[global::Cpp2ILInjected.Token(Token = "0x4000D44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public ControllerMappingsCategories_Layout.Setting ControllerAimSensitivity;

		// Token: 0x04007AFC RID: 31484
		[global::Cpp2ILInjected.Token(Token = "0x4000D45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementDelay;

		// Token: 0x04007AFD RID: 31485
		[global::Cpp2ILInjected.Token(Token = "0x4000D46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementRepeatDelay;

		// Token: 0x04007AFE RID: 31486
		[global::Cpp2ILInjected.Token(Token = "0x4000D47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public ControllerMappingsCategories_Layout.Setting ControllerSmartCursorMode;

		// Token: 0x04007AFF RID: 31487
		[global::Cpp2ILInjected.Token(Token = "0x4000D48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public ControllerMappingsCategories_Layout.Setting ControllerSwapShoulderButtons;

		// Token: 0x04007B00 RID: 31488
		[global::Cpp2ILInjected.Token(Token = "0x4000D49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public ControllerMappingsCategories_Layout.Setting ControllerShowControlsBanner;

		// Token: 0x04007B01 RID: 31489
		[global::Cpp2ILInjected.Token(Token = "0x4000D4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public ControllerMappingsCategories_Layout.Setting MovementAxis;

		// Token: 0x04007B02 RID: 31490
		[global::Cpp2ILInjected.Token(Token = "0x4000D4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public ControllerMappingsCategories_Layout.Setting MovementAxisAlt;

		// Token: 0x04007B03 RID: 31491
		[global::Cpp2ILInjected.Token(Token = "0x4000D4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public ControllerMappingsCategories_Layout.Setting FireAxis;

		// Token: 0x04007B04 RID: 31492
		[global::Cpp2ILInjected.Token(Token = "0x4000D4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public ControllerMappingsCategories_Layout.Setting FireAxisAlt;

		// Token: 0x04007B05 RID: 31493
		[global::Cpp2ILInjected.Token(Token = "0x4000D4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public ControllerMappingsCategories_Layout.Setting GrappleAxis;

		// Token: 0x04007B06 RID: 31494
		[global::Cpp2ILInjected.Token(Token = "0x4000D4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public ControllerMappingsCategories_Layout.Setting GridSnapAxis;

		// Token: 0x04007B07 RID: 31495
		[global::Cpp2ILInjected.Token(Token = "0x4000D50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public ControllerMappingsCategories_Layout.Setting HotbarAxis;

		// Token: 0x04007B08 RID: 31496
		[global::Cpp2ILInjected.Token(Token = "0x4000D51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public ControllerMappingsCategories_Layout.Setting GrappleFire;

		// Token: 0x04007B09 RID: 31497
		[global::Cpp2ILInjected.Token(Token = "0x4000D52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public ControllerMappingsCategories_Layout.Setting Jump;

		// Token: 0x04007B0A RID: 31498
		[global::Cpp2ILInjected.Token(Token = "0x4000D53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public ControllerMappingsCategories_Layout.Setting Fire;

		// Token: 0x04007B0B RID: 31499
		[global::Cpp2ILInjected.Token(Token = "0x4000D54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public ControllerMappingsCategories_Layout.Setting FireAlt;

		// Token: 0x04007B0C RID: 31500
		[global::Cpp2ILInjected.Token(Token = "0x4000D55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public ControllerMappingsCategories_Layout.Setting Interact;

		// Token: 0x04007B0D RID: 31501
		[global::Cpp2ILInjected.Token(Token = "0x4000D56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public ControllerMappingsCategories_Layout.Setting TargetLockOn;

		// Token: 0x04007B0E RID: 31502
		[global::Cpp2ILInjected.Token(Token = "0x4000D57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public ControllerMappingsCategories_Layout.Setting InventoryToggle;

		// Token: 0x04007B0F RID: 31503
		[global::Cpp2ILInjected.Token(Token = "0x4000D58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public ControllerMappingsCategories_Layout.Setting WorldFocusToggle;

		// Token: 0x04007B10 RID: 31504
		[global::Cpp2ILInjected.Token(Token = "0x4000D59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public ControllerMappingsCategories_Layout.Setting AutoSelect;

		// Token: 0x04007B11 RID: 31505
		[global::Cpp2ILInjected.Token(Token = "0x4000D5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public ControllerMappingsCategories_Layout.Setting SmartCursor;

		// Token: 0x04007B12 RID: 31506
		[global::Cpp2ILInjected.Token(Token = "0x4000D5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public ControllerMappingsCategories_Layout.Setting AutoFire;

		// Token: 0x04007B13 RID: 31507
		[global::Cpp2ILInjected.Token(Token = "0x4000D5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public ControllerMappingsCategories_Layout.Setting HotbarNext;

		// Token: 0x04007B14 RID: 31508
		[global::Cpp2ILInjected.Token(Token = "0x4000D5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public ControllerMappingsCategories_Layout.Setting HotbarPrevious;

		// Token: 0x04007B15 RID: 31509
		[global::Cpp2ILInjected.Token(Token = "0x4000D5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public ControllerMappingsCategories_Layout.Setting BuffNext;

		// Token: 0x04007B16 RID: 31510
		[global::Cpp2ILInjected.Token(Token = "0x4000D5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public ControllerMappingsCategories_Layout.Setting BuffPrevious;

		// Token: 0x04007B17 RID: 31511
		[global::Cpp2ILInjected.Token(Token = "0x4000D60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public ControllerMappingsCategories_Layout.Setting BuffRemove;

		// Token: 0x04007B18 RID: 31512
		[global::Cpp2ILInjected.Token(Token = "0x4000D61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public ControllerMappingsCategories_Layout.Setting ZoomIn;

		// Token: 0x04007B19 RID: 31513
		[global::Cpp2ILInjected.Token(Token = "0x4000D62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public ControllerMappingsCategories_Layout.Setting ZoomOut;

		// Token: 0x04007B1A RID: 31514
		[global::Cpp2ILInjected.Token(Token = "0x4000D63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public ControllerMappingsCategories_Layout.Setting MapZoomIn;

		// Token: 0x04007B1B RID: 31515
		[global::Cpp2ILInjected.Token(Token = "0x4000D64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public ControllerMappingsCategories_Layout.Setting MapZoomOut;

		// Token: 0x04007B1C RID: 31516
		[global::Cpp2ILInjected.Token(Token = "0x4000D65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public ControllerMappingsCategories_Layout.Setting MapZoomDefault;

		// Token: 0x04007B1D RID: 31517
		[global::Cpp2ILInjected.Token(Token = "0x4000D66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public ControllerMappingsCategories_Layout.Setting QuickHeal;

		// Token: 0x04007B1E RID: 31518
		[global::Cpp2ILInjected.Token(Token = "0x4000D67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public ControllerMappingsCategories_Layout.Setting QuickMana;

		// Token: 0x04007B1F RID: 31519
		[global::Cpp2ILInjected.Token(Token = "0x4000D68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public ControllerMappingsCategories_Layout.Setting QuickBuff;

		// Token: 0x04007B20 RID: 31520
		[global::Cpp2ILInjected.Token(Token = "0x4000D69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public ControllerMappingsCategories_Layout.Setting QuickMount;

		// Token: 0x04007B21 RID: 31521
		[global::Cpp2ILInjected.Token(Token = "0x4000D6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public ControllerMappingsCategories_Layout.Setting MapToggle;

		// Token: 0x04007B22 RID: 31522
		[global::Cpp2ILInjected.Token(Token = "0x4000D6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public ControllerMappingsCategories_Layout.Setting MiniMapToggle;

		// Token: 0x04007B23 RID: 31523
		[global::Cpp2ILInjected.Token(Token = "0x4000D6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public ControllerMappingsCategories_Layout.Setting ChatToggle;

		// Token: 0x04007B24 RID: 31524
		[global::Cpp2ILInjected.Token(Token = "0x4000D6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public ControllerMappingsCategories_Layout.Setting WiringOptions;

		// Token: 0x04007B25 RID: 31525
		[global::Cpp2ILInjected.Token(Token = "0x4000D6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		public ControllerMappingsCategories_Layout.Setting ToggleEmotes;

		// Token: 0x04007B26 RID: 31526
		[global::Cpp2ILInjected.Token(Token = "0x4000D6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public ControllerMappingsCategories_Layout.Setting InventoryNavigation;

		// Token: 0x04007B27 RID: 31527
		[global::Cpp2ILInjected.Token(Token = "0x4000D70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		public ControllerMappingsCategories_Layout.Setting InventoryNavigationAlt;

		// Token: 0x04007B28 RID: 31528
		[global::Cpp2ILInjected.Token(Token = "0x4000D71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public ControllerMappingsCategories_Layout.Setting LeftPageCycle;

		// Token: 0x04007B29 RID: 31529
		[global::Cpp2ILInjected.Token(Token = "0x4000D72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public ControllerMappingsCategories_Layout.Setting RightPageCycle;

		// Token: 0x04007B2A RID: 31530
		[global::Cpp2ILInjected.Token(Token = "0x4000D73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		public ControllerMappingsCategories_Layout.Setting ThrowItem;

		// Token: 0x04007B2B RID: 31531
		[global::Cpp2ILInjected.Token(Token = "0x4000D74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		public ControllerMappingsCategories_Layout.Setting TrashItem;

		// Token: 0x04007B2C RID: 31532
		[global::Cpp2ILInjected.Token(Token = "0x4000D75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		public ControllerMappingsCategories_Layout.Setting DepositHeldItem;

		// Token: 0x04007B2D RID: 31533
		[global::Cpp2ILInjected.Token(Token = "0x4000D76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		public ControllerMappingsCategories_Layout.Setting FavouriteItem;

		// Token: 0x04007B2E RID: 31534
		[global::Cpp2ILInjected.Token(Token = "0x4000D77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		public ControllerMappingsCategories_Layout.Setting SplitItem;

		// Token: 0x04007B2F RID: 31535
		[global::Cpp2ILInjected.Token(Token = "0x4000D78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		public ControllerMappingsCategories_Layout.Setting ResearchItem;

		// Token: 0x04007B30 RID: 31536
		[global::Cpp2ILInjected.Token(Token = "0x4000D79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		public ControllerMappingsCategories_Layout.Setting ShowHideItem;

		// Token: 0x04007B31 RID: 31537
		[global::Cpp2ILInjected.Token(Token = "0x4000D7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		public ControllerMappingsCategories_Layout.Setting Sort;

		// Token: 0x04007B32 RID: 31538
		[global::Cpp2ILInjected.Token(Token = "0x4000D7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		public ControllerMappingsCategories_Layout.Setting BuilderTools;

		// Token: 0x04007B33 RID: 31539
		[global::Cpp2ILInjected.Token(Token = "0x4000D7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		public ControllerMappingsCategories_Layout.Setting ChestQuickStack;

		// Token: 0x04007B34 RID: 31540
		[global::Cpp2ILInjected.Token(Token = "0x4000D7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		public ControllerMappingsCategories_Layout.Setting ChestLootAll;

		// Token: 0x04007B35 RID: 31541
		[global::Cpp2ILInjected.Token(Token = "0x4000D7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		public ControllerMappingsCategories_Layout.Setting ChestDepositAll;

		// Token: 0x04007B36 RID: 31542
		[global::Cpp2ILInjected.Token(Token = "0x4000D7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		public ControllerMappingsCategories_Layout.Setting ChestRestock;

		// Token: 0x04007B37 RID: 31543
		[global::Cpp2ILInjected.Token(Token = "0x4000D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public ControllerMappingsCategories_Layout.Setting ChestRename;

		// Token: 0x04007B38 RID: 31544
		[global::Cpp2ILInjected.Token(Token = "0x4000D81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public ControllerMappingsCategories_Layout.Setting ChestLoot;

		// Token: 0x04007B39 RID: 31545
		[global::Cpp2ILInjected.Token(Token = "0x4000D82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public ControllerMappingsCategories_Layout.Setting ChestDeposit;

		// Token: 0x04007B3A RID: 31546
		[global::Cpp2ILInjected.Token(Token = "0x4000D83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		public ControllerMappingsCategories_Layout.Setting ChestSort;

		// Token: 0x04007B3B RID: 31547
		[global::Cpp2ILInjected.Token(Token = "0x4000D84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		public ControllerMappingsCategories_Layout.Setting EquipmentEquip;

		// Token: 0x04007B3C RID: 31548
		[global::Cpp2ILInjected.Token(Token = "0x4000D85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		public ControllerMappingsCategories_Layout.Setting EquipmentUnequip;

		// Token: 0x04007B3D RID: 31549
		[global::Cpp2ILInjected.Token(Token = "0x4000D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		public ControllerMappingsCategories_Layout.Setting ShopSell;

		// Token: 0x04007B3E RID: 31550
		[global::Cpp2ILInjected.Token(Token = "0x4000D87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		public ControllerMappingsCategories_Layout.Setting ShopBuy;

		// Token: 0x04007B3F RID: 31551
		[global::Cpp2ILInjected.Token(Token = "0x4000D88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
		public ControllerMappingsCategories_Layout.Setting MaterialPrevious;

		// Token: 0x04007B40 RID: 31552
		[global::Cpp2ILInjected.Token(Token = "0x4000D89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
		public ControllerMappingsCategories_Layout.Setting MaterialNext;

		// Token: 0x04007B41 RID: 31553
		[global::Cpp2ILInjected.Token(Token = "0x4000D8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
		public ControllerMappingsCategories_Layout.Setting PVPEnableToggle;

		// Token: 0x04007B42 RID: 31554
		[global::Cpp2ILInjected.Token(Token = "0x4000D8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
		public ControllerMappingsCategories_Layout.Setting PVPTeleport;

		// Token: 0x04007B43 RID: 31555
		[global::Cpp2ILInjected.Token(Token = "0x4000D8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
		public ControllerMappingsCategories_Layout.Setting PVPSwitchTeam;

		// Token: 0x04007B44 RID: 31556
		[global::Cpp2ILInjected.Token(Token = "0x4000D8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
		public ControllerMappingsCategories_Layout.Setting BestiaryFilters;

		// Token: 0x04007B45 RID: 31557
		[global::Cpp2ILInjected.Token(Token = "0x4000D8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
		public ControllerMappingsCategories_Layout.Setting BestiaryFilterSearch;

		// Token: 0x04007B46 RID: 31558
		[global::Cpp2ILInjected.Token(Token = "0x4000D8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
		public ControllerMappingsCategories_Layout.Setting BestiarySortOrder;

		// Token: 0x04007B47 RID: 31559
		[global::Cpp2ILInjected.Token(Token = "0x4000D90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
		public ControllerMappingsCategories_Layout.Setting BestiaryDrops;

		// Token: 0x04007B48 RID: 31560
		[global::Cpp2ILInjected.Token(Token = "0x4000D91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
		public ControllerMappingsCategories_Layout.Setting PickupPlaceItem;

		// Token: 0x04007B49 RID: 31561
		[global::Cpp2ILInjected.Token(Token = "0x4000D92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
		public ControllerMappingsCategories_Layout.Setting InventoryClose;

		// Token: 0x04007B4A RID: 31562
		[global::Cpp2ILInjected.Token(Token = "0x4000D93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
		public ControllerMappingsCategories_Layout.Setting ReforgeItem;

		// Token: 0x04007B4B RID: 31563
		[global::Cpp2ILInjected.Token(Token = "0x4000D94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
		public ControllerMappingsCategories_Layout.Setting CraftItem;

		// Token: 0x04007B4C RID: 31564
		[global::Cpp2ILInjected.Token(Token = "0x4000D95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
		public ControllerMappingsCategories_Layout.Setting FilterItems;

		// Token: 0x04007B4D RID: 31565
		[global::Cpp2ILInjected.Token(Token = "0x4000D96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
		public ControllerMappingsCategories_Layout.Setting InfoAccessories;

		// Token: 0x04007B4E RID: 31566
		[global::Cpp2ILInjected.Token(Token = "0x4000D97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
		public ControllerMappingsCategories_Layout.Setting FilterItemsSearch;

		// Token: 0x04007B4F RID: 31567
		[global::Cpp2ILInjected.Token(Token = "0x4000D98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
		public ControllerMappingsCategories_Layout.Setting ToggleCraftDuplicate;

		// Token: 0x04007B50 RID: 31568
		[global::Cpp2ILInjected.Token(Token = "0x4000D99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
		public ControllerMappingsCategories_Layout.Setting HousingQuery;

		// Token: 0x04007B51 RID: 31569
		[global::Cpp2ILInjected.Token(Token = "0x4000D9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
		public ControllerMappingsCategories_Layout.Setting TakeOne;

		// Token: 0x04007B52 RID: 31570
		[global::Cpp2ILInjected.Token(Token = "0x4000D9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar1;

		// Token: 0x04007B53 RID: 31571
		[global::Cpp2ILInjected.Token(Token = "0x4000D9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar2;

		// Token: 0x04007B54 RID: 31572
		[global::Cpp2ILInjected.Token(Token = "0x4000D9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar3;

		// Token: 0x04007B55 RID: 31573
		[global::Cpp2ILInjected.Token(Token = "0x4000D9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar4;

		// Token: 0x04007B56 RID: 31574
		[global::Cpp2ILInjected.Token(Token = "0x4000D9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
		public ControllerMappingsCategories_Layout.Setting Hotbar1;

		// Token: 0x04007B57 RID: 31575
		[global::Cpp2ILInjected.Token(Token = "0x4000DA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
		public ControllerMappingsCategories_Layout.Setting Hotbar2;

		// Token: 0x04007B58 RID: 31576
		[global::Cpp2ILInjected.Token(Token = "0x4000DA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
		public ControllerMappingsCategories_Layout.Setting Hotbar3;

		// Token: 0x04007B59 RID: 31577
		[global::Cpp2ILInjected.Token(Token = "0x4000DA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
		public ControllerMappingsCategories_Layout.Setting Hotbar4;

		// Token: 0x04007B5A RID: 31578
		[global::Cpp2ILInjected.Token(Token = "0x4000DA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
		public ControllerMappingsCategories_Layout.Setting Hotbar5;

		// Token: 0x04007B5B RID: 31579
		[global::Cpp2ILInjected.Token(Token = "0x4000DA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
		public ControllerMappingsCategories_Layout.Setting Hotbar6;

		// Token: 0x04007B5C RID: 31580
		[global::Cpp2ILInjected.Token(Token = "0x4000DA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
		public ControllerMappingsCategories_Layout.Setting Hotbar7;

		// Token: 0x04007B5D RID: 31581
		[global::Cpp2ILInjected.Token(Token = "0x4000DA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
		public ControllerMappingsCategories_Layout.Setting Hotbar8;

		// Token: 0x04007B5E RID: 31582
		[global::Cpp2ILInjected.Token(Token = "0x4000DA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
		public ControllerMappingsCategories_Layout.Setting Hotbar9;

		// Token: 0x04007B5F RID: 31583
		[global::Cpp2ILInjected.Token(Token = "0x4000DA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
		public ControllerMappingsCategories_Layout.Setting Hotbar10;

		// Token: 0x04007B60 RID: 31584
		[global::Cpp2ILInjected.Token(Token = "0x4000DA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
		public ControllerMappingsCategories_Layout.Setting Loadout1;

		// Token: 0x04007B61 RID: 31585
		[global::Cpp2ILInjected.Token(Token = "0x4000DAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
		public ControllerMappingsCategories_Layout.Setting Loadout2;

		// Token: 0x04007B62 RID: 31586
		[global::Cpp2ILInjected.Token(Token = "0x4000DAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
		public ControllerMappingsCategories_Layout.Setting Loadout3;

		// Token: 0x04007B63 RID: 31587
		[global::Cpp2ILInjected.Token(Token = "0x4000DAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
		public ControllerMappingsCategories_Layout.Setting LoadoutCycle;
	}
}
