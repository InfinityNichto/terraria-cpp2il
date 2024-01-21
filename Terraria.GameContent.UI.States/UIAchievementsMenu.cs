using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI.States;

[Cpp2IlInjected.Token(Token = "0x20006A6")]
public class UIAchievementsMenu : UIState
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006ED2")]
	private UIList _achievementsList;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006ED3")]
	private List<UIAchievementListItem> _achievementElements;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006ED4")]
	private List<UIToggleImage> _categoryButtons;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006ED5")]
	private UIElement _backpanel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006ED6")]
	private UIElement _outerContainer;

	[Cpp2IlInjected.Token(Token = "0x60042D6")]
	[Cpp2IlInjected.Address(RVA = "0x10A82B0", Offset = "0x10A82B0", VA = "0x10A82B0")]
	public void InitializePage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D7")]
	[Cpp2IlInjected.Address(RVA = "0x10A8BF8", Offset = "0x10A8BF8", VA = "0x10A8BF8", Slot = "8")]
	public override void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D8")]
	[Cpp2IlInjected.Address(RVA = "0x10A90D4", Offset = "0x10A90D4", VA = "0x10A90D4")]
	public void GotoAchievement(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042D9")]
	[Cpp2IlInjected.Address(RVA = "0x10A9194", Offset = "0x10A9194", VA = "0x10A9194")]
	private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042DA")]
	[Cpp2IlInjected.Address(RVA = "0x10A9214", Offset = "0x10A9214", VA = "0x10A9214")]
	private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042DB")]
	[Cpp2IlInjected.Address(RVA = "0x10A93D0", Offset = "0x10A93D0", VA = "0x10A93D0")]
	private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042DC")]
	[Cpp2IlInjected.Address(RVA = "0x10A9578", Offset = "0x10A9578", VA = "0x10A9578")]
	private void FilterList(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042DD")]
	[Cpp2IlInjected.Address(RVA = "0x10A971C", Offset = "0x10A971C", VA = "0x10A971C", Slot = "26")]
	public override void OnActivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042DE")]
	[Cpp2IlInjected.Address(RVA = "0x10A9810", Offset = "0x10A9810", VA = "0x10A9810")]
	public UIAchievementsMenu()
	{
	}
}
