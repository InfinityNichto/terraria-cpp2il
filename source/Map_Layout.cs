using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using UnityEngine;

// Token: 0x02000168 RID: 360
[global::Cpp2ILInjected.Token(Token = "0x20001F2")]
public class Map_Layout : LayoutDefinition
{
	// Token: 0x06000B66 RID: 2918 RVA: 0x00023D77 File Offset: 0x00021F77
	[global::Cpp2ILInjected.Token(Token = "0x6000C7B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE674", Offset = "0x9CE674", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00023D7A File Offset: 0x00021F7A
	// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00023D7D File Offset: 0x00021F7D
	[global::Cpp2ILInjected.Token(Token = "0x17000157")]
	public static bool UseLargeMinimap
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE6C0", Offset = "0x9CE6C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RightSideHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE70C", Offset = "0x9CE70C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00023D80 File Offset: 0x00021F80
	[global::Cpp2ILInjected.Token(Token = "0x17000158")]
	public Panel_Layout DisplayMinimap
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE75C", Offset = "0x9CE75C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00023D83 File Offset: 0x00021F83
	[global::Cpp2ILInjected.Token(Token = "0x17000159")]
	public Panel_Layout DisplayMinimapFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE7C0", Offset = "0x9CE7C0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00023D86 File Offset: 0x00021F86
	[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
	public float MinMinimapScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C80")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE888", Offset = "0x9CE888", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00023D89 File Offset: 0x00021F89
	[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
	public float MaxMinimapScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C81")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE8B8", Offset = "0x9CE8B8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00023D8C File Offset: 0x00021F8C
	[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
	public float DefaultMinimapScale
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C82")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE8E8", Offset = "0x9CE8E8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "LoadDefaultZoom", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00023D8F File Offset: 0x00021F8F
	[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
	public QuickActionButton_Layout HUDMap
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C83")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE918", Offset = "0x9CE918", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "HeartOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "StarOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "IsCursorOverFullScreenMapControls", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00023D92 File Offset: 0x00021F92
	[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
	public QuickActionButton_Layout HUDMiniMapToggle
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C84")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CE980", Offset = "0x9CE980", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "HeartOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "StarOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00023D95 File Offset: 0x00021F95
	[global::Cpp2ILInjected.Token(Token = "0x6000C85")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE9E8", Offset = "0x9CE9E8", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public Map_Layout()
	{
		throw null;
	}

	// Token: 0x04000DC8 RID: 3528
	[global::Cpp2ILInjected.Token(Token = "0x4001215")]
	public static Map_Layout Instance;

	// Token: 0x04000DC9 RID: 3529
	[global::Cpp2ILInjected.Token(Token = "0x4001216")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int DefaultMiniMapWorldWidth;

	// Token: 0x04000DCA RID: 3530
	[global::Cpp2ILInjected.Token(Token = "0x4001217")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int MinMiniMapWorldWidth;

	// Token: 0x04000DCB RID: 3531
	[global::Cpp2ILInjected.Token(Token = "0x4001218")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MaxMiniMapWorldWidth;

	// Token: 0x04000DCC RID: 3532
	[global::Cpp2ILInjected.Token(Token = "0x4001219")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Minimap;

	// Token: 0x04000DCD RID: 3533
	[global::Cpp2ILInjected.Token(Token = "0x400121A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MinimapFrame;

	// Token: 0x04000DCE RID: 3534
	[global::Cpp2ILInjected.Token(Token = "0x400121B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MinimapLarge;

	// Token: 0x04000DCF RID: 3535
	[global::Cpp2ILInjected.Token(Token = "0x400121C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MinimapLargeFrame;

	// Token: 0x04000DD0 RID: 3536
	[global::Cpp2ILInjected.Token(Token = "0x400121D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float MinimapScale;

	// Token: 0x04000DD1 RID: 3537
	[global::Cpp2ILInjected.Token(Token = "0x400121E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public QuickActionButton_Layout MinimapZoomDefault;

	// Token: 0x04000DD2 RID: 3538
	[global::Cpp2ILInjected.Token(Token = "0x400121F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public QuickActionButton_Layout MinimapZoomIn;

	// Token: 0x04000DD3 RID: 3539
	[global::Cpp2ILInjected.Token(Token = "0x4001220")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public QuickActionButton_Layout MinimapZoomOut;

	// Token: 0x04000DD4 RID: 3540
	[global::Cpp2ILInjected.Token(Token = "0x4001221")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public QuickActionButton_Layout MapZoomDefault;

	// Token: 0x04000DD5 RID: 3541
	[global::Cpp2ILInjected.Token(Token = "0x4001222")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public QuickActionButton_Layout MapZoomIn;

	// Token: 0x04000DD6 RID: 3542
	[global::Cpp2ILInjected.Token(Token = "0x4001223")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public QuickActionButton_Layout MapZoomOut;

	// Token: 0x04000DD7 RID: 3543
	[global::Cpp2ILInjected.Token(Token = "0x4001224")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public QuickActionButton_Layout Map;

	// Token: 0x04000DD8 RID: 3544
	[global::Cpp2ILInjected.Token(Token = "0x4001225")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public QuickActionButton_Layout MapHorizontal;

	// Token: 0x04000DD9 RID: 3545
	[global::Cpp2ILInjected.Token(Token = "0x4001226")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public ControlAnchor.ControlId SliderAnchorControl;

	// Token: 0x04000DDA RID: 3546
	[global::Cpp2ILInjected.Token(Token = "0x4001227")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public LayoutCalculator.AnchorType SliderAnchor;

	// Token: 0x04000DDB RID: 3547
	[global::Cpp2ILInjected.Token(Token = "0x4001228")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	// Token: 0x04000DDC RID: 3548
	[global::Cpp2ILInjected.Token(Token = "0x4001229")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public float SliderBackScale;

	// Token: 0x04000DDD RID: 3549
	[global::Cpp2ILInjected.Token(Token = "0x400122A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	// Token: 0x04000DDE RID: 3550
	[global::Cpp2ILInjected.Token(Token = "0x400122B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public float SliderIndicatorScale;

	// Token: 0x04000DDF RID: 3551
	[global::Cpp2ILInjected.Token(Token = "0x400122C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float SliderEndCap;

	// Token: 0x04000DE0 RID: 3552
	[global::Cpp2ILInjected.Token(Token = "0x400122D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public float ControllerMovementSpeed;

	// Token: 0x04000DE1 RID: 3553
	[global::Cpp2ILInjected.Token(Token = "0x400122E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float SliderDefaultPosition;

	// Token: 0x04000DE2 RID: 3554
	[global::Cpp2ILInjected.Token(Token = "0x400122F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public AnimationCurve SliderToPixelScale;

	// Token: 0x04000DE3 RID: 3555
	[global::Cpp2ILInjected.Token(Token = "0x4001230")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public QuickActionButton_Layout MinimapToggle;

	// Token: 0x04000DE4 RID: 3556
	[global::Cpp2ILInjected.Token(Token = "0x4001231")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public QuickActionButton_Layout MinimapToggleHorizontal;
}
