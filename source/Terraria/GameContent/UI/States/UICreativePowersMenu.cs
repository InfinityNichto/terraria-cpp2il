using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A70")]
	public class UICreativePowersMenu : UIState
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008A8")]
		public bool IsShowingResearchMenu
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004EE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F0794", Offset = "0x8F0794", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "IsShowingResearchMenu", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F07A8", Offset = "0x8F07A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void OnActivate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F07AC", Offset = "0x8F07AC", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateMainPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PowerStripUIElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateTimePowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateWeatherPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreatePersonalPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void InitializePage()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0CEC", Offset = "0x8F0CEC", Length = "0x87C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "CreateCategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			"T",
			"T"
		}, ReturnType = "Terraria.GameContent.UI.Elements.GroupOptionButton`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateSubcategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(ref CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Dictionary<int, GroupOptionButton<int>>),
			typeof(Dictionary<int, UIElement>)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private List<UIElement> CreateMainPowerStrip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EED")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F1F04", Offset = "0x8F1F04", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "itemsWindowButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "researchWindowButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "timeCategoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "weatherCategoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "personalCategoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = "get_IsSelected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "AddDescriptionIfNeeded", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseTextNoOverride", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void CategoryButton_OnUpdate_DisplayTooltips(UIElement affectedElement, string categoryNameKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2094", Offset = "0x8F2094", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CategoryButton_OnUpdate_DisplayTooltips", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void itemsWindowButton_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F20DC", Offset = "0x8F20DC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CategoryButton_OnUpdate_DisplayTooltips", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void researchWindowButton_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2124", Offset = "0x8F2124", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CategoryButton_OnUpdate_DisplayTooltips", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void timeCategoryButton_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F216C", Offset = "0x8F216C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CategoryButton_OnUpdate_DisplayTooltips", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void weatherCategoryButton_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F21B4", Offset = "0x8F21B4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CategoryButton_OnUpdate_DisplayTooltips", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void personalCategoryButton_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F21FC", Offset = "0x8F21FC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UICreativePowersMenu_OnUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2264", Offset = "0x8F2264", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void strip_OnMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F226C", Offset = "0x8F226C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void strip_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2278", Offset = "0x8F2278", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleMainCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void MainCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2300", Offset = "0x8F2300", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "MainCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleCategory", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
		{
			"MenuTree`1<TEnum>",
			typeof(int),
			"TEnum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ToggleMainCategory(int option)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2360", Offset = "0x8F2360", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "WeatherCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleCategory", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
		{
			"MenuTree`1<TEnum>",
			typeof(int),
			"TEnum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ToggleWeatherCategory(int option)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F23C0", Offset = "0x8F23C0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "TimeCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleCategory", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
		{
			"MenuTree`1<TEnum>",
			typeof(int),
			"TEnum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ToggleTimeCategory(int option)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2420", Offset = "0x8F2420", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "PersonalCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleCategory", MemberTypeParameters = new object[] { "TEnum" }, MemberParameters = new object[]
		{
			"MenuTree`1<TEnum>",
			typeof(int),
			"TEnum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void TogglePersonalCategory(int option)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2480", Offset = "0x8F2480", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "SacrificeItemInSacrificeSlot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "SacrificeWhatYouCan", ReturnType = typeof(void))]
		public void SacrificeWhatsInResearchMenu()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F248C", Offset = "0x8F248C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "CloseMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "StopPlayingSacrificeAnimations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "StopPlayingAnimation", ReturnType = typeof(void))]
		public void StopPlayingResearchAnimations()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A270C", Offset = "0x15A270C", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "ToggleMainCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "ToggleWeatherCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "ToggleTimeCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "TogglePersonalCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ToggleCategory<TEnum>(UICreativePowersMenu.MenuTree<TEnum> tree, int option, TEnum defaultOption) where TEnum : struct, IConvertible
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F1568", Offset = "0x8F1568", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedButtonPower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateSubcategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(ref CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Dictionary<int, GroupOptionButton<int>>),
			typeof(Dictionary<int, UIElement>)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private List<UIElement> CreateTimePowerStrip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004EFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F1B20", Offset = "0x8F1B20", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateSubcategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(ref CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Dictionary<int, GroupOptionButton<int>>),
			typeof(Dictionary<int, UIElement>)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private List<UIElement> CreatePersonalPowerStrip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F00")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F1838", Offset = "0x8F1838", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "CreateSubcategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(ref CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Dictionary<int, GroupOptionButton<int>>),
			typeof(Dictionary<int, UIElement>)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowers.ASharedTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private List<UIElement> CreateWeatherPowerStrip()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F01")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2438", Offset = "0x15A2438", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateMainPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateTimePowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreatePersonalPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateWeatherPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPower", MemberParameters = new object[]
		{
			typeof(ICreativePower),
			typeof(UIElement),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private GroupOptionButton<int> CreateSubcategoryButton<T>(ref CreativePowerUIElementRequestInfo request, int subcategoryDepth, string subcategoryName, int subcategoryIndex, int currentSelectedInSubcategory, Dictionary<int, GroupOptionButton<int>> subcategoryButtons, Dictionary<int, UIElement> slidersSet) where T : class, ICreativePower, IProvideSliderElement, IPowerSubcategoryElement
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F02")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2498", Offset = "0x8F2498", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleWeatherCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void WeatherCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F03")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F25A0", Offset = "0x8F25A0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "ToggleTimeCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void TimeCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F04")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2688", Offset = "0x8F2688", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "get_Instance", ReturnType = typeof(CreativePowerManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = "GetPower", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "TogglePersonalCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "RefreshElementsOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PersonalCategoryButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F05")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F1D48", Offset = "0x8F1D48", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "MainCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "WeatherCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "TimeCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "PersonalCategoryButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "SetPageTypeToShow", MemberParameters = new object[] { typeof(UICreativeInfiniteItemsDisplay.InfiniteItemsDisplayPage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void RefreshElementsOrder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F06")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2770", Offset = "0x8F2770", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public override void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004F07")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2778", Offset = "0x8F2778", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu.MenuTree<>), Member = ".ctor", MemberParameters = new object[] { "TEnum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public UICreativePowersMenu()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40087E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x141")]
		private bool _hovered;

		[global::Cpp2ILInjected.Token(Token = "0x40087E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private PowerStripUIElement _mainPowerStrip;

		[global::Cpp2ILInjected.Token(Token = "0x40087E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private PowerStripUIElement _timePowersStrip;

		[global::Cpp2ILInjected.Token(Token = "0x40087E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private PowerStripUIElement _weatherPowersStrip;

		[global::Cpp2ILInjected.Token(Token = "0x40087E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private PowerStripUIElement _personalPowersStrip;

		[global::Cpp2ILInjected.Token(Token = "0x40087E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private UICreativeInfiniteItemsDisplay _infiniteItemsWindow;

		[global::Cpp2ILInjected.Token(Token = "0x40087EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private UIElement _container;

		[global::Cpp2ILInjected.Token(Token = "0x40087EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.OpenMainSubCategory> _mainCategory;

		[global::Cpp2ILInjected.Token(Token = "0x40087EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.WeatherSubcategory> _weatherCategory;

		[global::Cpp2ILInjected.Token(Token = "0x40087ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.TimeSubcategory> _timeCategory;

		[global::Cpp2ILInjected.Token(Token = "0x40087EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private UICreativePowersMenu.MenuTree<UICreativePowersMenu.PersonalSubcategory> _personalCategory;

		[global::Cpp2ILInjected.Token(Token = "0x40087EF")]
		private const int INITIAL_LEFT_PIXELS = 20;

		[global::Cpp2ILInjected.Token(Token = "0x40087F0")]
		private const int LEFT_PIXELS_PER_STRIP_DEPTH = 60;

		[global::Cpp2ILInjected.Token(Token = "0x40087F1")]
		private const string STRIP_MAIN = "strip 0";

		[global::Cpp2ILInjected.Token(Token = "0x40087F2")]
		private const string STRIP_DEPTH_1 = "strip 1";

		[global::Cpp2ILInjected.Token(Token = "0x40087F3")]
		private const string STRIP_DEPTH_2 = "strip 2";

		[global::Cpp2ILInjected.Token(Token = "0x2000A71")]
		private class MenuTree<TEnum> where TEnum : struct, IConvertible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004F08")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CBC68", Offset = "0x17CBC68", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public MenuTree(TEnum defaultValue)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40087F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int CurrentOption;

			[global::Cpp2ILInjected.Token(Token = "0x40087F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Dictionary<int, GroupOptionButton<int>> Buttons;

			[global::Cpp2ILInjected.Token(Token = "0x40087F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Dictionary<int, UIElement> Sliders;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A72")]
		private enum OpenMainSubCategory
		{
			[global::Cpp2ILInjected.Token(Token = "0x40087F8")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x40087F9")]
			InfiniteItems,
			[global::Cpp2ILInjected.Token(Token = "0x40087FA")]
			ResearchWindow,
			[global::Cpp2ILInjected.Token(Token = "0x40087FB")]
			Time,
			[global::Cpp2ILInjected.Token(Token = "0x40087FC")]
			Weather,
			[global::Cpp2ILInjected.Token(Token = "0x40087FD")]
			EnemyStrengthSlider,
			[global::Cpp2ILInjected.Token(Token = "0x40087FE")]
			PersonalPowers
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A73")]
		private enum WeatherSubcategory
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008800")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4008801")]
			WindSlider,
			[global::Cpp2ILInjected.Token(Token = "0x4008802")]
			RainSlider
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A74")]
		private enum TimeSubcategory
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008804")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4008805")]
			TimeRate
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000A75")]
		private enum PersonalSubcategory
		{
			[global::Cpp2ILInjected.Token(Token = "0x4008807")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4008808")]
			EnemySpawnRateSlider
		}
	}
}
