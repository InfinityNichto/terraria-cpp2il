using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000193 RID: 403
[global::Cpp2ILInjected.Token(Token = "0x200021F")]
public class VirtualInputControllerEdit_Layout : LayoutDefinition
{
	// Token: 0x06000BBC RID: 3004 RVA: 0x00023E79 File Offset: 0x00022079
	[global::Cpp2ILInjected.Token(Token = "0x6000CD2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D05B8", Offset = "0x9D05B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00023E7C File Offset: 0x0002207C
	[global::Cpp2ILInjected.Token(Token = "0x6000CD3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0604", Offset = "0x9D0604", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public VirtualInputControllerEdit_Layout()
	{
		throw null;
	}

	// Token: 0x04001065 RID: 4197
	[global::Cpp2ILInjected.Token(Token = "0x40014C9")]
	public static VirtualInputControllerEdit_Layout Instance;

	// Token: 0x04001066 RID: 4198
	[global::Cpp2ILInjected.Token(Token = "0x40014CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float ControllerDragSpeed;

	// Token: 0x04001067 RID: 4199
	[global::Cpp2ILInjected.Token(Token = "0x40014CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Finish;

	// Token: 0x04001068 RID: 4200
	[global::Cpp2ILInjected.Token(Token = "0x40014CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ResetDefaults;

	// Token: 0x04001069 RID: 4201
	[global::Cpp2ILInjected.Token(Token = "0x40014CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout CancelChanges;

	// Token: 0x0400106A RID: 4202
	[global::Cpp2ILInjected.Token(Token = "0x40014CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ControlSelection;

	// Token: 0x0400106B RID: 4203
	[global::Cpp2ILInjected.Token(Token = "0x40014CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout AllowedLeftRegion;

	// Token: 0x0400106C RID: 4204
	[global::Cpp2ILInjected.Token(Token = "0x40014D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout AllowedRightRegion;

	// Token: 0x0400106D RID: 4205
	[global::Cpp2ILInjected.Token(Token = "0x40014D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout LeftControlRegion;

	// Token: 0x0400106E RID: 4206
	[global::Cpp2ILInjected.Token(Token = "0x40014D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color LeftControlRegionDraggingBackingColor;

	// Token: 0x0400106F RID: 4207
	[global::Cpp2ILInjected.Token(Token = "0x40014D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Color LeftControlRegionDraggingBorderColor;

	// Token: 0x04001070 RID: 4208
	[global::Cpp2ILInjected.Token(Token = "0x40014D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout RightControlRegion;

	// Token: 0x04001071 RID: 4209
	[global::Cpp2ILInjected.Token(Token = "0x40014D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Color RightControlRegionDraggingBackingColor;

	// Token: 0x04001072 RID: 4210
	[global::Cpp2ILInjected.Token(Token = "0x40014D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public Color RightControlRegionDraggingBorderColor;

	// Token: 0x04001073 RID: 4211
	[global::Cpp2ILInjected.Token(Token = "0x40014D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout AllowedInterfaceLeftRegion;

	// Token: 0x04001074 RID: 4212
	[global::Cpp2ILInjected.Token(Token = "0x40014D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout AllowedInterfaceRightRegion;

	// Token: 0x04001075 RID: 4213
	[global::Cpp2ILInjected.Token(Token = "0x40014D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Panel_Layout AllowedInterfaceLeftRegionSmall;

	// Token: 0x04001076 RID: 4214
	[global::Cpp2ILInjected.Token(Token = "0x40014DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout AllowedInterfaceRightRegionSmall;

	// Token: 0x04001077 RID: 4215
	[global::Cpp2ILInjected.Token(Token = "0x40014DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout LeftInterfaceRegion;

	// Token: 0x04001078 RID: 4216
	[global::Cpp2ILInjected.Token(Token = "0x40014DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout RightInterfaceRegion;

	// Token: 0x04001079 RID: 4217
	[global::Cpp2ILInjected.Token(Token = "0x40014DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color LeftInterfaceRegionDraggingBackingColor;

	// Token: 0x0400107A RID: 4218
	[global::Cpp2ILInjected.Token(Token = "0x40014DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public Color LeftInterfaceRegionDraggingBorderColor;

	// Token: 0x0400107B RID: 4219
	[global::Cpp2ILInjected.Token(Token = "0x40014DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color RightInterfaceRegionDraggingBackingColor;

	// Token: 0x0400107C RID: 4220
	[global::Cpp2ILInjected.Token(Token = "0x40014E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public Color RightInterfaceRegionDraggingBorderColor;

	// Token: 0x0400107D RID: 4221
	[global::Cpp2ILInjected.Token(Token = "0x40014E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color DisabledPageBackingColor;

	// Token: 0x0400107E RID: 4222
	[global::Cpp2ILInjected.Token(Token = "0x40014E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public Color DisabledPageIconColor;

	// Token: 0x0400107F RID: 4223
	[global::Cpp2ILInjected.Token(Token = "0x40014E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Color DisabledHotbarColor;

	// Token: 0x04001080 RID: 4224
	[global::Cpp2ILInjected.Token(Token = "0x40014E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Color DisabledInventoryColor;

	// Token: 0x04001081 RID: 4225
	[global::Cpp2ILInjected.Token(Token = "0x40014E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Color DisabledTrashColor;

	// Token: 0x04001082 RID: 4226
	[global::Cpp2ILInjected.Token(Token = "0x40014E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public Color DisabledTrashIconColor;

	// Token: 0x04001083 RID: 4227
	[global::Cpp2ILInjected.Token(Token = "0x40014E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Color DisabledChestColor;

	// Token: 0x04001084 RID: 4228
	[global::Cpp2ILInjected.Token(Token = "0x40014E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public Color DisabledPageTitleColor;

	// Token: 0x04001085 RID: 4229
	[global::Cpp2ILInjected.Token(Token = "0x40014E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout ScreenBacking;

	// Token: 0x04001086 RID: 4230
	[global::Cpp2ILInjected.Token(Token = "0x40014EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Panel_Layout ControlsBacking;

	// Token: 0x04001087 RID: 4231
	[global::Cpp2ILInjected.Token(Token = "0x40014EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public ItemGrid_Layout ControlsGrid;

	// Token: 0x04001088 RID: 4232
	[global::Cpp2ILInjected.Token(Token = "0x40014EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public float ControlsItemScale;

	// Token: 0x04001089 RID: 4233
	[global::Cpp2ILInjected.Token(Token = "0x40014ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public Vector2 ControlsGridAxisOffset;

	// Token: 0x0400108A RID: 4234
	[global::Cpp2ILInjected.Token(Token = "0x40014EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public Vector2 ControlsGridButtonOffset;

	// Token: 0x0400108B RID: 4235
	[global::Cpp2ILInjected.Token(Token = "0x40014EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Mappings;

	// Token: 0x0400108C RID: 4236
	[global::Cpp2ILInjected.Token(Token = "0x40014F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout Controls;

	// Token: 0x0400108D RID: 4237
	[global::Cpp2ILInjected.Token(Token = "0x40014F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public FadeString_Layout FadeLabel;

	// Token: 0x0400108E RID: 4238
	[global::Cpp2ILInjected.Token(Token = "0x40014F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public VirtualInputControllerEdit_Layout.SlotPriority ControlPriority;

	// Token: 0x0400108F RID: 4239
	[global::Cpp2ILInjected.Token(Token = "0x40014F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public VirtualInputControllerEdit_Layout.ControlsWidgets EditControlWidgets;

	// Token: 0x020007ED RID: 2029
	[global::Cpp2ILInjected.Token(Token = "0x2000220")]
	[Serializable]
	public class SlotPriority
	{
		// Token: 0x060048E9 RID: 18665 RVA: 0x0002EF10 File Offset: 0x0002D110
		[global::Cpp2ILInjected.Token(Token = "0x6000CD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D076C", Offset = "0x9D076C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIVirtualInputControllerEdit.<>c__DisplayClass72_0", Member = "<RefreshSlotOrder>b__0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int Priority(VirtualControlsHardwareConfigurationMapping_Layout.ContolType type)
		{
			throw null;
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x0002EF13 File Offset: 0x0002D113
		[global::Cpp2ILInjected.Token(Token = "0x6000CD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0860", Offset = "0x9D0860", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SlotPriority()
		{
			throw null;
		}

		// Token: 0x04007C2E RID: 31790
		[global::Cpp2ILInjected.Token(Token = "0x40014F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int AutoFire;

		// Token: 0x04007C2F RID: 31791
		[global::Cpp2ILInjected.Token(Token = "0x40014F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SmartCursor;

		// Token: 0x04007C30 RID: 31792
		[global::Cpp2ILInjected.Token(Token = "0x40014F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int CombatTargetting;

		// Token: 0x04007C31 RID: 31793
		[global::Cpp2ILInjected.Token(Token = "0x40014F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int Jump;

		// Token: 0x04007C32 RID: 31794
		[global::Cpp2ILInjected.Token(Token = "0x40014F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int Heal;

		// Token: 0x04007C33 RID: 31795
		[global::Cpp2ILInjected.Token(Token = "0x40014F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int Mana;

		// Token: 0x04007C34 RID: 31796
		[global::Cpp2ILInjected.Token(Token = "0x40014FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int Buff;

		// Token: 0x04007C35 RID: 31797
		[global::Cpp2ILInjected.Token(Token = "0x40014FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int Mount;

		// Token: 0x04007C36 RID: 31798
		[global::Cpp2ILInjected.Token(Token = "0x40014FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int Interact;

		// Token: 0x04007C37 RID: 31799
		[global::Cpp2ILInjected.Token(Token = "0x40014FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int Fire;

		// Token: 0x04007C38 RID: 31800
		[global::Cpp2ILInjected.Token(Token = "0x40014FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int GrappleAxis;

		// Token: 0x04007C39 RID: 31801
		[global::Cpp2ILInjected.Token(Token = "0x40014FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int AutoSelect;

		// Token: 0x04007C3A RID: 31802
		[global::Cpp2ILInjected.Token(Token = "0x4001500")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int ZoomIn;

		// Token: 0x04007C3B RID: 31803
		[global::Cpp2ILInjected.Token(Token = "0x4001501")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int ZoomOut;

		// Token: 0x04007C3C RID: 31804
		[global::Cpp2ILInjected.Token(Token = "0x4001502")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int Move;

		// Token: 0x04007C3D RID: 31805
		[global::Cpp2ILInjected.Token(Token = "0x4001503")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public int Aim;

		// Token: 0x04007C3E RID: 31806
		[global::Cpp2ILInjected.Token(Token = "0x4001504")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public int GrappleFire;

		// Token: 0x04007C3F RID: 31807
		[global::Cpp2ILInjected.Token(Token = "0x4001505")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public int ProfileSwitch;

		// Token: 0x04007C40 RID: 31808
		[global::Cpp2ILInjected.Token(Token = "0x4001506")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public int Unbound;

		// Token: 0x04007C41 RID: 31809
		[global::Cpp2ILInjected.Token(Token = "0x4001507")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public int InventoryToggle;

		// Token: 0x04007C42 RID: 31810
		[global::Cpp2ILInjected.Token(Token = "0x4001508")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int Settings;

		// Token: 0x04007C43 RID: 31811
		[global::Cpp2ILInjected.Token(Token = "0x4001509")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public int Loadout1;

		// Token: 0x04007C44 RID: 31812
		[global::Cpp2ILInjected.Token(Token = "0x400150A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public int Loadout2;

		// Token: 0x04007C45 RID: 31813
		[global::Cpp2ILInjected.Token(Token = "0x400150B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public int Loadout3;

		// Token: 0x04007C46 RID: 31814
		[global::Cpp2ILInjected.Token(Token = "0x400150C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public int LoadoutCycle;
	}

	// Token: 0x020007EE RID: 2030
	[global::Cpp2ILInjected.Token(Token = "0x2000221")]
	[Serializable]
	public class ControlsWidgets
	{
		// Token: 0x060048EB RID: 18667 RVA: 0x0002EF16 File Offset: 0x0002D116
		[global::Cpp2ILInjected.Token(Token = "0x6000CD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0868", Offset = "0x9D0868", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ControlsWidgets()
		{
			throw null;
		}

		// Token: 0x04007C47 RID: 31815
		[global::Cpp2ILInjected.Token(Token = "0x400150D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Panel_Layout OptionsGreyout;

		// Token: 0x04007C48 RID: 31816
		[global::Cpp2ILInjected.Token(Token = "0x400150E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TransactionButton_Layout ProfileValue;

		// Token: 0x04007C49 RID: 31817
		[global::Cpp2ILInjected.Token(Token = "0x400150F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public String_Layout ProfileTitle;

		// Token: 0x04007C4A RID: 31818
		[global::Cpp2ILInjected.Token(Token = "0x4001510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TransactionButton_Layout ProfileRename;

		// Token: 0x04007C4B RID: 31819
		[global::Cpp2ILInjected.Token(Token = "0x4001511")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Panel_Layout ProfileOptionsBacking;

		// Token: 0x04007C4C RID: 31820
		[global::Cpp2ILInjected.Token(Token = "0x4001512")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TransactionButton_Layout Profile1;

		// Token: 0x04007C4D RID: 31821
		[global::Cpp2ILInjected.Token(Token = "0x4001513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TransactionButton_Layout Profile2;

		// Token: 0x04007C4E RID: 31822
		[global::Cpp2ILInjected.Token(Token = "0x4001514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TransactionButton_Layout Profile3;

		// Token: 0x04007C4F RID: 31823
		[global::Cpp2ILInjected.Token(Token = "0x4001515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public TransactionButton_Layout Profile4;

		// Token: 0x04007C50 RID: 31824
		[global::Cpp2ILInjected.Token(Token = "0x4001516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TransactionButton_Layout HardwareValue;

		// Token: 0x04007C51 RID: 31825
		[global::Cpp2ILInjected.Token(Token = "0x4001517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public String_Layout HardwareTitle;

		// Token: 0x04007C52 RID: 31826
		[global::Cpp2ILInjected.Token(Token = "0x4001518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public Panel_Layout HardwareOptionsBacking;

		// Token: 0x04007C53 RID: 31827
		[global::Cpp2ILInjected.Token(Token = "0x4001519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public TransactionButton_Layout Hardware1;

		// Token: 0x04007C54 RID: 31828
		[global::Cpp2ILInjected.Token(Token = "0x400151A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public TransactionButton_Layout Hardware2;

		// Token: 0x04007C55 RID: 31829
		[global::Cpp2ILInjected.Token(Token = "0x400151B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public TransactionButton_Layout Hardware3;

		// Token: 0x04007C56 RID: 31830
		[global::Cpp2ILInjected.Token(Token = "0x400151C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public TransactionButton_Layout Hardware4;

		// Token: 0x04007C57 RID: 31831
		[global::Cpp2ILInjected.Token(Token = "0x400151D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public TransactionButton_Layout StyleValue;

		// Token: 0x04007C58 RID: 31832
		[global::Cpp2ILInjected.Token(Token = "0x400151E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public String_Layout StyleTitle;

		// Token: 0x04007C59 RID: 31833
		[global::Cpp2ILInjected.Token(Token = "0x400151F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Panel_Layout StyleOptionsBacking2;

		// Token: 0x04007C5A RID: 31834
		[global::Cpp2ILInjected.Token(Token = "0x4001520")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public Panel_Layout StyleOptionsBacking3;

		// Token: 0x04007C5B RID: 31835
		[global::Cpp2ILInjected.Token(Token = "0x4001521")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public TransactionButton_Layout Style1;

		// Token: 0x04007C5C RID: 31836
		[global::Cpp2ILInjected.Token(Token = "0x4001522")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public TransactionButton_Layout Style2;

		// Token: 0x04007C5D RID: 31837
		[global::Cpp2ILInjected.Token(Token = "0x4001523")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public TransactionButton_Layout Style3;

		// Token: 0x04007C5E RID: 31838
		[global::Cpp2ILInjected.Token(Token = "0x4001524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public Panel_Layout PageOptionsBacking;

		// Token: 0x04007C5F RID: 31839
		[global::Cpp2ILInjected.Token(Token = "0x4001525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public TransactionButton_Layout PageOptionValue;

		// Token: 0x04007C60 RID: 31840
		[global::Cpp2ILInjected.Token(Token = "0x4001526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public TransactionButton_Layout BottomControls;

		// Token: 0x04007C61 RID: 31841
		[global::Cpp2ILInjected.Token(Token = "0x4001527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public TransactionButton_Layout SideControls;

		// Token: 0x04007C62 RID: 31842
		[global::Cpp2ILInjected.Token(Token = "0x4001528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public TransactionButton_Layout Undo;

		// Token: 0x04007C63 RID: 31843
		[global::Cpp2ILInjected.Token(Token = "0x4001529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public TransactionButton_Layout Redo;
	}
}
