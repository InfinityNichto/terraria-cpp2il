using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006BC")]
public class UIAchievementListItem : UIPanel
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006FA7")]
	private Achievement _achievement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FA8")]
	private UIImageFramed _achievementIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FA9")]
	private UIImage _achievementIconBorders;

	[Cpp2IlInjected.Token(Token = "0x4006FAA")]
	private const int _iconSize = 64;

	[Cpp2IlInjected.Token(Token = "0x4006FAB")]
	private const int _iconSizeWithSpace = 66;

	[Cpp2IlInjected.Token(Token = "0x4006FAC")]
	private const int _iconsPerRow = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006FAD")]
	private int _iconIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4006FAE")]
	private Rectangle _iconFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4006FAF")]
	private Rectangle _iconFrameUnlocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4006FB0")]
	private Rectangle _iconFrameLocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4006FB1")]
	private Asset<Texture2D> _innerPanelTopTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4006FB2")]
	private Asset<Texture2D> _innerPanelBottomTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4006FB3")]
	private Asset<Texture2D> _categoryTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4006FB4")]
	private bool _locked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x155")]
	[Cpp2IlInjected.Token(Token = "0x4006FB5")]
	private bool _large;

	[Cpp2IlInjected.Token(Token = "0x60043EF")]
	[Cpp2IlInjected.Address(RVA = "0x118DF20", Offset = "0x118DF20", VA = "0x118DF20")]
	public UIAchievementListItem(Achievement achievement, bool largeForOtherLanguages)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F0")]
	[Cpp2IlInjected.Address(RVA = "0x118E824", Offset = "0x118E824", VA = "0x118E824", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F1")]
	[Cpp2IlInjected.Address(RVA = "0x118E7A8", Offset = "0x118E7A8", VA = "0x118E7A8")]
	private void UpdateIconFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F2")]
	[Cpp2IlInjected.Address(RVA = "0x1190020", Offset = "0x1190020", VA = "0x1190020")]
	private void DrawPanelTop(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F3")]
	[Cpp2IlInjected.Address(RVA = "0x1190430", Offset = "0x1190430", VA = "0x1190430")]
	private void DrawPanelBottom(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F4")]
	[Cpp2IlInjected.Address(RVA = "0x1191488", Offset = "0x1191488", VA = "0x1191488", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F5")]
	[Cpp2IlInjected.Address(RVA = "0x11914F4", Offset = "0x11914F4", VA = "0x11914F4", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F6")]
	[Cpp2IlInjected.Address(RVA = "0x11915EC", Offset = "0x11915EC", VA = "0x11915EC")]
	public Achievement GetAchievement()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60043F7")]
	[Cpp2IlInjected.Address(RVA = "0x118FCFC", Offset = "0x118FCFC", VA = "0x118FCFC")]
	private Tuple<decimal, decimal> GetTrackerValues()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60043F8")]
	[Cpp2IlInjected.Address(RVA = "0x1190840", Offset = "0x1190840", VA = "0x1190840")]
	private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, [Optional] Color BackColor, [Optional] Color FillingColor, [Optional] Color BlipColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043F9")]
	[Cpp2IlInjected.Address(RVA = "0x11915F4", Offset = "0x11915F4", VA = "0x11915F4", Slot = "29")]
	public override int CompareTo(object obj)
	{
		return default(int);
	}
}
