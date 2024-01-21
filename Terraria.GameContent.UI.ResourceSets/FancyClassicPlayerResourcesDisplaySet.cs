using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.ResourceSets;

[Cpp2IlInjected.Token(Token = "0x20006AD")]
public class FancyClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F32")]
	private float _currentPlayerLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F33")]
	private float _lifePerHeart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006F34")]
	private int _playerLifeFruitCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006F35")]
	private int _lastHeartFillingIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006F36")]
	private int _lastHeartPanelIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006F37")]
	private int _heartCountRow1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006F38")]
	private int _heartCountRow2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006F39")]
	private int _starCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006F3A")]
	private int _lastStarFillingIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006F3B")]
	private float _manaPerStar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006F3C")]
	private float _currentPlayerMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4006F3D")]
	private Asset<Texture2D> _heartLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006F3E")]
	private Asset<Texture2D> _heartMiddle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006F3F")]
	private Asset<Texture2D> _heartRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006F40")]
	private Asset<Texture2D> _heartRightFancy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4006F41")]
	private Asset<Texture2D> _heartFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4006F42")]
	private Asset<Texture2D> _heartFillHoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4006F43")]
	private Asset<Texture2D> _heartSingleFancy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4006F44")]
	private Asset<Texture2D> _starTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4006F45")]
	private Asset<Texture2D> _starMiddle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4006F46")]
	private Asset<Texture2D> _starBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4006F47")]
	private Asset<Texture2D> _starSingle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4006F48")]
	private Asset<Texture2D> _starFill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4006F49")]
	private bool _hoverLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x4006F4A")]
	private bool _hoverMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4006F4B")]
	private bool _drawText;

	[Cpp2IlInjected.Token(Token = "0x170007B1")]
	public string NameKey
	{
		[Cpp2IlInjected.Token(Token = "0x600437F")]
		[Cpp2IlInjected.Address(RVA = "0x10A1680", Offset = "0x10A1680", VA = "0x10A1680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004380")]
		[Cpp2IlInjected.Address(RVA = "0x10A1688", Offset = "0x10A1688", VA = "0x10A1688")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007B2")]
	public string ConfigKey
	{
		[Cpp2IlInjected.Token(Token = "0x6004381")]
		[Cpp2IlInjected.Address(RVA = "0x10A1690", Offset = "0x10A1690", VA = "0x10A1690", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004382")]
		[Cpp2IlInjected.Address(RVA = "0x10A1698", Offset = "0x10A1698", VA = "0x10A1698")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004383")]
	[Cpp2IlInjected.Address(RVA = "0x10A16A0", Offset = "0x10A16A0", VA = "0x10A16A0")]
	public FancyClassicPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004384")]
	[Cpp2IlInjected.Address(RVA = "0x10A2140", Offset = "0x10A2140", VA = "0x10A2140", Slot = "4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004385")]
	[Cpp2IlInjected.Address(RVA = "0x10A236C", Offset = "0x10A236C", VA = "0x10A236C")]
	private void DrawLifeBar(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004386")]
	[Cpp2IlInjected.Address(RVA = "0x10A3480", Offset = "0x10A3480", VA = "0x10A3480")]
	private static void DrawLifeBarText(SpriteBatch spriteBatch, Vector2 topLeftAnchor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004387")]
	[Cpp2IlInjected.Address(RVA = "0x10A2F00", Offset = "0x10A2F00", VA = "0x10A2F00")]
	private void DrawManaBar(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004388")]
	[Cpp2IlInjected.Address(RVA = "0x10A3FC8", Offset = "0x10A3FC8", VA = "0x10A3FC8")]
	private static void DrawManaText(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004389")]
	[Cpp2IlInjected.Address(RVA = "0x10A4218", Offset = "0x10A4218", VA = "0x10A4218")]
	private void HeartPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600438A")]
	[Cpp2IlInjected.Address(RVA = "0x10A43D4", Offset = "0x10A43D4", VA = "0x10A43D4")]
	private void HeartFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600438B")]
	[Cpp2IlInjected.Address(RVA = "0x10A45D8", Offset = "0x10A45D8", VA = "0x10A45D8")]
	private void StarPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600438C")]
	[Cpp2IlInjected.Address(RVA = "0x10A4760", Offset = "0x10A4760", VA = "0x10A4760")]
	private void StarFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600438D")]
	[Cpp2IlInjected.Address(RVA = "0x10A21E8", Offset = "0x10A21E8", VA = "0x10A21E8")]
	private void PrepareFields(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600438E")]
	[Cpp2IlInjected.Address(RVA = "0x10A4A18", Offset = "0x10A4A18", VA = "0x10A4A18", Slot = "5")]
	public void TryToHover()
	{
	}
}
