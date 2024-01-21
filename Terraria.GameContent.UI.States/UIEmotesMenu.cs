using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States;

[Cpp2IlInjected.Token(Token = "0x20006A9")]
public class UIEmotesMenu : UIState
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006EFC")]
	private UIElement _outerContainer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006EFD")]
	private UIElement _backPanel;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006EFE")]
	private UIElement _container;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006EFF")]
	private UIList _list;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006F00")]
	private UIScrollbar _scrollBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4006F01")]
	private bool _isScrollbarAttached;

	[Cpp2IlInjected.Token(Token = "0x600432E")]
	[Cpp2IlInjected.Address(RVA = "0xE090A0", Offset = "0xE090A0", VA = "0xE090A0", Slot = "26")]
	public override void OnActivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600432F")]
	[Cpp2IlInjected.Address(RVA = "0xE09188", Offset = "0xE09188", VA = "0xE09188")]
	public void InitializePage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004330")]
	[Cpp2IlInjected.Address(RVA = "0xE09A28", Offset = "0xE09A28", VA = "0xE09A28")]
	private void TryAddingList(LocalizedText title, ref int currentGroupIndex, int maxEmotesPerRow, List<int> emoteIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004331")]
	[Cpp2IlInjected.Address(RVA = "0xE097D8", Offset = "0xE097D8", VA = "0xE097D8")]
	private List<int> GetEmotesGeneral()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004332")]
	[Cpp2IlInjected.Address(RVA = "0xE09B18", Offset = "0xE09B18", VA = "0xE09B18")]
	private List<int> GetEmotesRPS()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004333")]
	[Cpp2IlInjected.Address(RVA = "0xE09BF8", Offset = "0xE09BF8", VA = "0xE09BF8")]
	private List<int> GetEmotesItems()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004334")]
	[Cpp2IlInjected.Address(RVA = "0xE09DE8", Offset = "0xE09DE8", VA = "0xE09DE8")]
	private List<int> GetEmotesBiomesAndEvents()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004335")]
	[Cpp2IlInjected.Address(RVA = "0xE09FD8", Offset = "0xE09FD8", VA = "0xE09FD8")]
	private List<int> GetEmotesTownNPCs()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004336")]
	[Cpp2IlInjected.Address(RVA = "0xE0A238", Offset = "0xE0A238", VA = "0xE0A238")]
	private List<int> GetEmotesCritters()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004337")]
	[Cpp2IlInjected.Address(RVA = "0xE0A474", Offset = "0xE0A474", VA = "0xE0A474")]
	private List<int> GetEmotesBosses()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004338")]
	[Cpp2IlInjected.Address(RVA = "0xE0ACE8", Offset = "0xE0ACE8", VA = "0xE0ACE8", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004339")]
	[Cpp2IlInjected.Address(RVA = "0xE0ADA8", Offset = "0xE0ADA8", VA = "0xE0ADA8")]
	private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600433A")]
	[Cpp2IlInjected.Address(RVA = "0xE0AE28", Offset = "0xE0AE28", VA = "0xE0AE28")]
	private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600433B")]
	[Cpp2IlInjected.Address(RVA = "0xE0AFE4", Offset = "0xE0AFE4", VA = "0xE0AFE4")]
	private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600433C")]
	[Cpp2IlInjected.Address(RVA = "0xE0B18C", Offset = "0xE0B18C", VA = "0xE0B18C", Slot = "8")]
	public override void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600433D")]
	[Cpp2IlInjected.Address(RVA = "0xE0B194", Offset = "0xE0B194", VA = "0xE0B194")]
	public UIEmotesMenu()
	{
	}
}
