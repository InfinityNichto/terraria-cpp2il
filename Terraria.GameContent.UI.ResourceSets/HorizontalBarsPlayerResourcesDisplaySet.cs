using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006AE")]
public class HorizontalBarsPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F4E")]
	private int _maxSegmentCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F4F")]
	private int _hpSegmentsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006F50")]
	private int _mpSegmentsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006F51")]
	private int _hpFruitCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006F52")]
	private float _hpPercent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006F53")]
	private float _mpPercent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006F54")]
	private byte _drawTextStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4006F55")]
	private bool _hpHovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4006F56")]
	private bool _mpHovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006F57")]
	private Asset<Texture2D> _hpFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006F58")]
	private Asset<Texture2D> _hpFillHoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006F59")]
	private Asset<Texture2D> _mpFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006F5A")]
	private Asset<Texture2D> _panelLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006F5B")]
	private Asset<Texture2D> _panelMiddleHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006F5C")]
	private Asset<Texture2D> _panelRightHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006F5D")]
	private Asset<Texture2D> _panelMiddleMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006F5E")]
	private Asset<Texture2D> _panelRightMP;

	[Cpp2IlInjected.Token(Token = "0x170007B3")]
	public string NameKey
	{
		[Cpp2IlInjected.Token(Token = "0x600438F")]
		[Cpp2IlInjected.Address(RVA = "0x10A4A48", Offset = "0x10A4A48", VA = "0x10A4A48", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004390")]
		[Cpp2IlInjected.Address(RVA = "0x10A4A50", Offset = "0x10A4A50", VA = "0x10A4A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007B4")]
	public string ConfigKey
	{
		[Cpp2IlInjected.Token(Token = "0x6004391")]
		[Cpp2IlInjected.Address(RVA = "0x10A4A58", Offset = "0x10A4A58", VA = "0x10A4A58", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004392")]
		[Cpp2IlInjected.Address(RVA = "0x10A4A60", Offset = "0x10A4A60", VA = "0x10A4A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004393")]
	[Cpp2IlInjected.Address(RVA = "0x10A4A68", Offset = "0x10A4A68", VA = "0x10A4A68")]
	public HorizontalBarsPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004394")]
	[Cpp2IlInjected.Address(RVA = "0x10A5208", Offset = "0x10A5208", VA = "0x10A5208", Slot = "4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004395")]
	[Cpp2IlInjected.Address(RVA = "0x10A6398", Offset = "0x10A6398", VA = "0x10A6398")]
	private static void DrawManaText(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004396")]
	[Cpp2IlInjected.Address(RVA = "0x10A5E18", Offset = "0x10A5E18", VA = "0x10A5E18")]
	private static void DrawLifeBarText(SpriteBatch spriteBatch, Vector2 topLeftAnchor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004397")]
	[Cpp2IlInjected.Address(RVA = "0x10A5D80", Offset = "0x10A5D80", VA = "0x10A5D80")]
	private void PrepareFields(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004398")]
	[Cpp2IlInjected.Address(RVA = "0x10A6768", Offset = "0x10A6768", VA = "0x10A6768")]
	private void LifePanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004399")]
	[Cpp2IlInjected.Address(RVA = "0x10A68E0", Offset = "0x10A68E0", VA = "0x10A68E0")]
	private void ManaPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600439A")]
	[Cpp2IlInjected.Address(RVA = "0x10A6A58", Offset = "0x10A6A58", VA = "0x10A6A58")]
	private void LifeFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600439B")]
	[Cpp2IlInjected.Address(RVA = "0x10A6AB8", Offset = "0x10A6AB8", VA = "0x10A6AB8")]
	private static void FillBarByValues(int elementIndex, Asset<Texture2D> sprite, int segmentsCount, float fillPercent, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600439C")]
	[Cpp2IlInjected.Address(RVA = "0x10A6D10", Offset = "0x10A6D10", VA = "0x10A6D10")]
	private void ManaFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600439D")]
	[Cpp2IlInjected.Address(RVA = "0x10A6D58", Offset = "0x10A6D58", VA = "0x10A6D58", Slot = "5")]
	public void TryToHover()
	{
	}
}
