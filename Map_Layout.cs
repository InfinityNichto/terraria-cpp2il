using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000169")]
public class Map_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000DD1")]
	public static Map_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000DD2")]
	public int DefaultMiniMapWorldWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000DD3")]
	public int MinMiniMapWorldWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000DD4")]
	public int MaxMiniMapWorldWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000DD5")]
	public Panel_Layout Minimap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000DD6")]
	public Panel_Layout MinimapFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000DD7")]
	public Panel_Layout MinimapLarge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000DD8")]
	public Panel_Layout MinimapLargeFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000DD9")]
	public float MinimapScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000DDA")]
	public QuickActionButton_Layout MinimapZoomDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000DDB")]
	public QuickActionButton_Layout MinimapZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000DDC")]
	public QuickActionButton_Layout MinimapZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000DDD")]
	public QuickActionButton_Layout MapZoomDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000DDE")]
	public QuickActionButton_Layout MapZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000DDF")]
	public QuickActionButton_Layout MapZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000DE0")]
	public QuickActionButton_Layout Map;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000DE1")]
	public QuickActionButton_Layout MapHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000DE2")]
	public ControlAnchor.ControlId SliderAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000DE3")]
	public LayoutCalculator.AnchorType SliderAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000DE4")]
	public Microsoft.Xna.Framework.Vector2 SliderLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000DE5")]
	public float SliderBackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000DE6")]
	public Microsoft.Xna.Framework.Vector2 SliderPickBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000DE7")]
	public float SliderIndicatorScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000DE8")]
	public float SliderEndCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000DE9")]
	public float ControllerMovementSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000DEA")]
	public float SliderDefaultPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000DEB")]
	public AnimationCurve SliderToPixelScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000DEC")]
	public QuickActionButton_Layout MinimapToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000DED")]
	public QuickActionButton_Layout MinimapToggleHorizontal;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public static bool UseLargeMinimap
	{
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x12E2794", Offset = "0x12E2794", VA = "0x12E2794")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x12E27F0", Offset = "0x12E27F0", VA = "0x12E27F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public Panel_Layout DisplayMinimap
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x12E2850", Offset = "0x12E2850", VA = "0x12E2850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public Panel_Layout DisplayMinimapFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x12E28C0", Offset = "0x12E28C0", VA = "0x12E28C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public float MinMinimapScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x12E29A0", Offset = "0x12E29A0", VA = "0x12E29A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public float MaxMinimapScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x12E29D4", Offset = "0x12E29D4", VA = "0x12E29D4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public float DefaultMinimapScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x12E2A08", Offset = "0x12E2A08", VA = "0x12E2A08")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public QuickActionButton_Layout HUDMap
	{
		[Cpp2IlInjected.Token(Token = "0x6000B80")]
		[Cpp2IlInjected.Address(RVA = "0x12E2A3C", Offset = "0x12E2A3C", VA = "0x12E2A3C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public QuickActionButton_Layout HUDMiniMapToggle
	{
		[Cpp2IlInjected.Token(Token = "0x6000B81")]
		[Cpp2IlInjected.Address(RVA = "0x12E2AB0", Offset = "0x12E2AB0", VA = "0x12E2AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x12E2738", Offset = "0x12E2738", VA = "0x12E2738")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x12E2B28", Offset = "0x12E2B28", VA = "0x12E2B28")]
	public Map_Layout()
	{
	}
}
