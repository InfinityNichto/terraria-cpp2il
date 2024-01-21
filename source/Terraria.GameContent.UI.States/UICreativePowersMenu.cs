using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.UI.States;

[Cpp2IlInjected.Token(Token = "0x20006A8")]
public class UICreativePowersMenu : UIState
{
	[Cpp2IlInjected.Token(Token = "0x2000A9E")]
	private class MenuTree<TEnum> where TEnum : struct, IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008EF2")]
		public int CurrentOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008EF3")]
		public Dictionary<int, GroupOptionButton<int>> Buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008EF4")]
		public Dictionary<int, UIElement> Sliders;

		[Cpp2IlInjected.Token(Token = "0x600527B")]
		[Cpp2IlInjected.Address(RVA = "0x16433CC", Offset = "0x16433CC", VA = "0x16433CC")]
		public MenuTree(TEnum defaultValue)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A9F")]
	private enum OpenMainSubCategory
	{
		[Cpp2IlInjected.Token(Token = "0x4008EF6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4008EF7")]
		InfiniteItems,
		[Cpp2IlInjected.Token(Token = "0x4008EF8")]
		ResearchWindow,
		[Cpp2IlInjected.Token(Token = "0x4008EF9")]
		Time,
		[Cpp2IlInjected.Token(Token = "0x4008EFA")]
		Weather,
		[Cpp2IlInjected.Token(Token = "0x4008EFB")]
		EnemyStrengthSlider,
		[Cpp2IlInjected.Token(Token = "0x4008EFC")]
		PersonalPowers
	}

	[Cpp2IlInjected.Token(Token = "0x2000AA0")]
	private enum WeatherSubcategory
	{
		[Cpp2IlInjected.Token(Token = "0x4008EFE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4008EFF")]
		WindSlider,
		[Cpp2IlInjected.Token(Token = "0x4008F00")]
		RainSlider
	}

	[Cpp2IlInjected.Token(Token = "0x2000AA1")]
	private enum TimeSubcategory
	{
		[Cpp2IlInjected.Token(Token = "0x4008F02")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4008F03")]
		TimeRate
	}

	[Cpp2IlInjected.Token(Token = "0x2000AA2")]
	private enum PersonalSubcategory
	{
		[Cpp2IlInjected.Token(Token = "0x4008F05")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4008F06")]
		EnemySpawnRateSlider
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x4006EEC")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006EED")]
	private PowerStripUIElement _mainPowerStrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006EEE")]
	private PowerStripUIElement _timePowersStrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006EEF")]
	private PowerStripUIElement _weatherPowersStrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006EF0")]
	private PowerStripUIElement _personalPowersStrip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006EF1")]
	private UICreativeInfiniteItemsDisplay _infiniteItemsWindow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4006EF2")]
	private UIElement _container;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006EF3")]
	private MenuTree<OpenMainSubCategory> _mainCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006EF4")]
	private MenuTree<WeatherSubcategory> _weatherCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006EF5")]
	private MenuTree<TimeSubcategory> _timeCategory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006EF6")]
	private MenuTree<PersonalSubcategory> _personalCategory;

	[Cpp2IlInjected.Token(Token = "0x4006EF7")]
	private const int INITIAL_LEFT_PIXELS = 20;

	[Cpp2IlInjected.Token(Token = "0x4006EF8")]
	private const int LEFT_PIXELS_PER_STRIP_DEPTH = 60;

	[Cpp2IlInjected.Token(Token = "0x4006EF9")]
	private const string STRIP_MAIN = "strip 0";

	[Cpp2IlInjected.Token(Token = "0x4006EFA")]
	private const string STRIP_DEPTH_1 = "strip 1";

	[Cpp2IlInjected.Token(Token = "0x4006EFB")]
	private const string STRIP_DEPTH_2 = "strip 2";

	[Cpp2IlInjected.Token(Token = "0x170007AA")]
	public bool IsShowingResearchMenu
	{
		[Cpp2IlInjected.Token(Token = "0x600430F")]
		[Cpp2IlInjected.Address(RVA = "0xE07094", Offset = "0xE07094", VA = "0xE07094")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004310")]
	[Cpp2IlInjected.Address(RVA = "0xE070AC", Offset = "0xE070AC", VA = "0xE070AC", Slot = "26")]
	public override void OnActivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004311")]
	[Cpp2IlInjected.Address(RVA = "0xE070B0", Offset = "0xE070B0", VA = "0xE070B0")]
	private void InitializePage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004312")]
	[Cpp2IlInjected.Address(RVA = "0xE07694", Offset = "0xE07694", VA = "0xE07694")]
	private List<UIElement> CreateMainPowerStrip()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004313")]
	[Cpp2IlInjected.Address(RVA = "0xE08600", Offset = "0xE08600", VA = "0xE08600")]
	private static void CategoryButton_OnUpdate_DisplayTooltips(UIElement affectedElement, string categoryNameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004314")]
	[Cpp2IlInjected.Address(RVA = "0xE087A0", Offset = "0xE087A0", VA = "0xE087A0")]
	private void itemsWindowButton_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004315")]
	[Cpp2IlInjected.Address(RVA = "0xE087FC", Offset = "0xE087FC", VA = "0xE087FC")]
	private void researchWindowButton_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004316")]
	[Cpp2IlInjected.Address(RVA = "0xE08858", Offset = "0xE08858", VA = "0xE08858")]
	private void timeCategoryButton_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004317")]
	[Cpp2IlInjected.Address(RVA = "0xE088B4", Offset = "0xE088B4", VA = "0xE088B4")]
	private void weatherCategoryButton_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004318")]
	[Cpp2IlInjected.Address(RVA = "0xE08910", Offset = "0xE08910", VA = "0xE08910")]
	private void personalCategoryButton_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004319")]
	[Cpp2IlInjected.Address(RVA = "0xE0896C", Offset = "0xE0896C", VA = "0xE0896C")]
	private void UICreativePowersMenu_OnUpdate(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600431A")]
	[Cpp2IlInjected.Address(RVA = "0xE089F8", Offset = "0xE089F8", VA = "0xE089F8")]
	private void strip_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600431B")]
	[Cpp2IlInjected.Address(RVA = "0xE08A04", Offset = "0xE08A04", VA = "0xE08A04")]
	private void strip_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600431C")]
	[Cpp2IlInjected.Address(RVA = "0xE08A10", Offset = "0xE08A10", VA = "0xE08A10")]
	private void MainCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600431D")]
	[Cpp2IlInjected.Address(RVA = "0xE08A98", Offset = "0xE08A98", VA = "0xE08A98")]
	private void ToggleMainCategory(int option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600431E")]
	[Cpp2IlInjected.Address(RVA = "0xE08B10", Offset = "0xE08B10", VA = "0xE08B10")]
	private void ToggleWeatherCategory(int option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600431F")]
	[Cpp2IlInjected.Address(RVA = "0xE08B88", Offset = "0xE08B88", VA = "0xE08B88")]
	private void ToggleTimeCategory(int option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004320")]
	[Cpp2IlInjected.Address(RVA = "0xE08C00", Offset = "0xE08C00", VA = "0xE08C00")]
	private void TogglePersonalCategory(int option)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004321")]
	[Cpp2IlInjected.Address(RVA = "0xE08C78", Offset = "0xE08C78", VA = "0xE08C78")]
	public void SacrificeWhatsInResearchMenu()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004322")]
	[Cpp2IlInjected.Address(RVA = "0xE08C84", Offset = "0xE08C84", VA = "0xE08C84")]
	public void StopPlayingResearchAnimations()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004323")]
	[Cpp2IlInjected.Address(RVA = "0x15A5AD8", Offset = "0x15A5AD8", VA = "0x15A5AD8")]
	private void ToggleCategory<TEnum>(MenuTree<TEnum> tree, int option, TEnum defaultOption) where TEnum : struct, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004324")]
	[Cpp2IlInjected.Address(RVA = "0xE07DF4", Offset = "0xE07DF4", VA = "0xE07DF4")]
	private List<UIElement> CreateTimePowerStrip()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004325")]
	[Cpp2IlInjected.Address(RVA = "0xE08274", Offset = "0xE08274", VA = "0xE08274")]
	private List<UIElement> CreatePersonalPowerStrip()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004326")]
	[Cpp2IlInjected.Address(RVA = "0xE08028", Offset = "0xE08028", VA = "0xE08028")]
	private List<UIElement> CreateWeatherPowerStrip()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004327")]
	[Cpp2IlInjected.Address(RVA = "0x206E87C", Offset = "0x206E87C", VA = "0x206E87C")]
	private GroupOptionButton<int> CreateSubcategoryButton<T>(ref CreativePowerUIElementRequestInfo request, int subcategoryDepth, string subcategoryName, int subcategoryIndex, int currentSelectedInSubcategory, Dictionary<int, GroupOptionButton<int>> subcategoryButtons, Dictionary<int, UIElement> slidersSet) where T : class, ICreativePower, IProvideSliderElement, IPowerSubcategoryElement
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004328")]
	[Cpp2IlInjected.Address(RVA = "0xE08C90", Offset = "0xE08C90", VA = "0xE08C90")]
	private void WeatherCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004329")]
	[Cpp2IlInjected.Address(RVA = "0xE08D98", Offset = "0xE08D98", VA = "0xE08D98")]
	private void TimeCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600432A")]
	[Cpp2IlInjected.Address(RVA = "0xE08E80", Offset = "0xE08E80", VA = "0xE08E80")]
	private void PersonalCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600432B")]
	[Cpp2IlInjected.Address(RVA = "0xE08418", Offset = "0xE08418", VA = "0xE08418")]
	private void RefreshElementsOrder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600432C")]
	[Cpp2IlInjected.Address(RVA = "0xE08F68", Offset = "0xE08F68", VA = "0xE08F68", Slot = "8")]
	public override void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600432D")]
	[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE08F70", VA = "0xE08F70")]
	public UICreativePowersMenu()
	{
	}
}
