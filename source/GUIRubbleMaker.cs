using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000100")]
public class GUIRubbleMaker
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400078D")]
	private int hoverItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400078E")]
	public Vector2 PopupPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400078F")]
	private bool wasOverMaterialItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000790")]
	private int cursorOverMaterial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000791")]
	private bool wasOverRubbleItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000792")]
	private int cursorOverRubble;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000793")]
	private float[] ButtonScales;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000794")]
	private float TimeSinceChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000795")]
	private Item emptyItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000796")]
	public TileObjectPreviewData objectPreview;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000797")]
	private float ToggleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000798")]
	public bool DisplayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x4000799")]
	public bool DisplayMaterials;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400079A")]
	public GUIControllerRubbleMaker _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400079B")]
	public float materialScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400079C")]
	private float materialScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400079D")]
	private int materialScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400079E")]
	private Vector2 materialDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400079F")]
	public float rubbleScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40007A0")]
	private float rubbleScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40007A1")]
	private int rubbleScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40007A2")]
	private Vector2 rubbleDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007A3")]
	public FlexibleTileWand.PlacementOption SelectedOption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40007A4")]
	public FlexibleTileWand.OptionBucket SelectedMaterial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007A5")]
	private List<FlexibleTileWand.OptionBucket> MaterialOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40007A6")]
	private Vector2 rubbleScaleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40007A7")]
	private float rubbleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40007A8")]
	private Item EmptyItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40007A9")]
	private bool wasExcluded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40007AA")]
	public GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40007AB")]
	public GUIInputRegionExclusive PickingInterceptorMaterials;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public static bool DrawRubbleModeUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x1159614", Offset = "0x1159614", VA = "0x1159614")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int RubbleCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x115C628", Offset = "0x115C628", VA = "0x115C628")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int MaterialCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x115C680", Offset = "0x115C680", VA = "0x115C680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x1159388", Offset = "0x1159388", VA = "0x1159388")]
	public GUIRubbleMaker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x11596F8", Offset = "0x11596F8", VA = "0x11596F8")]
	public void PlayerMenuDisplayToggle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x1159BB0", Offset = "0x1159BB0", VA = "0x1159BB0")]
	private Vector2 ClampPositionToScreen(Vector2 position, VirtualControlsHardwareConfigurationMapping_Layout slotConfig)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x115A44C", Offset = "0x115A44C", VA = "0x115A44C")]
	private float MaterialItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x115A464", Offset = "0x115A464", VA = "0x115A464")]
	private float RubbleItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x115A47C", Offset = "0x115A47C", VA = "0x115A47C")]
	private void MaterialItemOver(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x115A708", Offset = "0x115A708", VA = "0x115A708")]
	private void RubbleItemOver(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x115A8A4", Offset = "0x115A8A4", VA = "0x115A8A4")]
	public void MaterialItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x115AEFC", Offset = "0x115AEFC", VA = "0x115AEFC")]
	public void RubbleItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x115B774", Offset = "0x115B774", VA = "0x115B774")]
	public void SetupPreview(int type, int style, int dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x115BD00", Offset = "0x115BD00", VA = "0x115BD00")]
	public void DrawPreview(SpriteBatch sb, TileObjectPreviewData op, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x1159A14", Offset = "0x1159A14", VA = "0x1159A14")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x115C38C", Offset = "0x115C38C", VA = "0x115C38C")]
	public void RefreshOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x115C6CC", Offset = "0x115C6CC", VA = "0x115C6CC")]
	public void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x115A6F4", Offset = "0x115A6F4", VA = "0x115A6F4")]
	public void CloseMaterials()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x115A130", Offset = "0x115A130", VA = "0x115A130")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x115DA1C", Offset = "0x115DA1C", VA = "0x115DA1C")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x115A2D0", Offset = "0x115A2D0", VA = "0x115A2D0")]
	public Rectangle CalculateMaterialRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x115DB68", Offset = "0x115DB68", VA = "0x115DB68")]
	public bool IsOverMaterial(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x115A240", Offset = "0x115A240", VA = "0x115A240")]
	public Rectangle CalculateRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x115D784", Offset = "0x115D784", VA = "0x115D784")]
	private bool IsOverInventoryOpenButton(Vector2 position)
	{
		return default(bool);
	}
}
