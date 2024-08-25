using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20001F2")]
public class Map_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C7B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE674", Offset = "0x9CE674", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x4001215")]
	public static Map_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001216")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int DefaultMiniMapWorldWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001217")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int MinMiniMapWorldWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001218")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MaxMiniMapWorldWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4001219")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Minimap;

	[global::Cpp2ILInjected.Token(Token = "0x400121A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout MinimapFrame;

	[global::Cpp2ILInjected.Token(Token = "0x400121B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MinimapLarge;

	[global::Cpp2ILInjected.Token(Token = "0x400121C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MinimapLargeFrame;

	[global::Cpp2ILInjected.Token(Token = "0x400121D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float MinimapScale;

	[global::Cpp2ILInjected.Token(Token = "0x400121E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public QuickActionButton_Layout MinimapZoomDefault;

	[global::Cpp2ILInjected.Token(Token = "0x400121F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public QuickActionButton_Layout MinimapZoomIn;

	[global::Cpp2ILInjected.Token(Token = "0x4001220")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public QuickActionButton_Layout MinimapZoomOut;

	[global::Cpp2ILInjected.Token(Token = "0x4001221")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public QuickActionButton_Layout MapZoomDefault;

	[global::Cpp2ILInjected.Token(Token = "0x4001222")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public QuickActionButton_Layout MapZoomIn;

	[global::Cpp2ILInjected.Token(Token = "0x4001223")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public QuickActionButton_Layout MapZoomOut;

	[global::Cpp2ILInjected.Token(Token = "0x4001224")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public QuickActionButton_Layout Map;

	[global::Cpp2ILInjected.Token(Token = "0x4001225")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public QuickActionButton_Layout MapHorizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4001226")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public ControlAnchor.ControlId SliderAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4001227")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public LayoutCalculator.AnchorType SliderAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4001228")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4001229")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public float SliderBackScale;

	[global::Cpp2ILInjected.Token(Token = "0x400122A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	[global::Cpp2ILInjected.Token(Token = "0x400122B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public float SliderIndicatorScale;

	[global::Cpp2ILInjected.Token(Token = "0x400122C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float SliderEndCap;

	[global::Cpp2ILInjected.Token(Token = "0x400122D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public float ControllerMovementSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x400122E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float SliderDefaultPosition;

	[global::Cpp2ILInjected.Token(Token = "0x400122F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public AnimationCurve SliderToPixelScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001230")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public QuickActionButton_Layout MinimapToggle;

	[global::Cpp2ILInjected.Token(Token = "0x4001231")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public QuickActionButton_Layout MinimapToggleHorizontal;
}
