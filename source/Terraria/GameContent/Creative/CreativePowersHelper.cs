using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x0200067F RID: 1663
	[global::Cpp2ILInjected.Token(Token = "0x2000A0F")]
	public class CreativePowersHelper
	{
		// Token: 0x06004171 RID: 16753 RVA: 0x0002DB30 File Offset: 0x0002BD30
		[global::Cpp2ILInjected.Token(Token = "0x6004C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B4E2C", Offset = "0x8B4E2C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "GetIconImage", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(UIImageFramed))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static Asset<Texture2D> GetPowerIconAsset(string path)
		{
			throw null;
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x0002DB33 File Offset: 0x0002BD33
		[global::Cpp2ILInjected.Token(Token = "0x6004C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B4F1C", Offset = "0x8B4F1C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetOptionButton", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "GetOptionButton", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FreezeTime), Member = "CustomizeButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FreezeWindDirectionAndStrength), Member = "CustomizeButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.FreezeRainPower), Member = "CustomizeButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.StopBiomeSpreadPower), Member = "CustomizeButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateMainPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "GetPowerIconAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Asset<Texture2D>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static UIImageFramed GetIconImage(Point iconLocation)
		{
			throw null;
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x0002DB36 File Offset: 0x0002BD36
		[global::Cpp2ILInjected.Token(Token = "0x6004C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5040", Offset = "0x8B5040", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<>), Member = "SetColorsBasedOnSelectionState", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static GroupOptionButton<bool> CreateToggleButton(CreativePowerUIElementRequestInfo info)
		{
			throw null;
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x0002DB39 File Offset: 0x0002BD39
		[global::Cpp2ILInjected.Token(Token = "0x6004C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5250", Offset = "0x8B5250", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<>), Member = "SetColorsBasedOnSelectionState", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static GroupOptionButton<bool> CreateSimpleButton(CreativePowerUIElementRequestInfo info)
		{
			throw null;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x0002DB3C File Offset: 0x0002BD3C
		[global::Cpp2ILInjected.Token(Token = "0x6004C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x15792E8", Offset = "0x15792E8", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetOptionButton", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "GetOptionButton", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateMainPowerStrip", ReturnType = typeof(List<UIElement>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static GroupOptionButton<T> CreateCategoryButton<T>(CreativePowerUIElementRequestInfo info, T option, T currentOption) where T : IConvertible, IEquatable<T>
		{
			throw null;
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x0002DB3F File Offset: 0x0002BD3F
		[global::Cpp2ILInjected.Token(Token = "0x6004C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B53FC", Offset = "0x8B53FC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "categoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "categoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "UpdateSliderColorAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "UpdateSliderAndShowMultiplierMouseOver", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
		{
			typeof(ICreativePower),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void AddPermissionTextIfNeeded(ICreativePower power, ref string originalText)
		{
			throw null;
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x0002DB42 File Offset: 0x0002BD42
		[global::Cpp2ILInjected.Token(Token = "0x6004C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5610", Offset = "0x8B5610", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "categoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "categoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CategoryButton_OnUpdate_DisplayTooltips", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void AddDescriptionIfNeeded(ref string originalText, string descriptionKey)
		{
			throw null;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x0002DB45 File Offset: 0x0002BD45
		[global::Cpp2ILInjected.Token(Token = "0x6004C09")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B56A8", Offset = "0x8B56A8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "categoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "categoryButton_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void AddUnlockTextIfNeeded(ref string originalText, bool needed, string descriptionKey)
		{
			throw null;
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x0002DB48 File Offset: 0x0002BD48
		[global::Cpp2ILInjected.Token(Token = "0x6004C0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5724", Offset = "0x8B5724", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyTimeRate), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.DifficultySliderPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyWindDirectionAndStrength), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ModifyRainPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.SpawnRateSliderPerPlayerPower), Member = "ProvideSlider", ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVerticalSlider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Func<float>),
			typeof(Action<float>),
			typeof(Action),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static UIVerticalSlider CreateSlider(Func<float> GetSliderValueMethod, Action<float> SetValueKeyboardMethod, Action SetValueGamepadMethod)
		{
			throw null;
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x0002DB4B File Offset: 0x0002BD4B
		[global::Cpp2ILInjected.Token(Token = "0x6004C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5864", Offset = "0x8B5864", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void UpdateUseMouseInterface(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x0002DB4E File Offset: 0x0002BD4E
		[global::Cpp2ILInjected.Token(Token = "0x6004C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B58CC", Offset = "0x8B58CC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "GetOptionButton", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "ProvidePowerButtons", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(List<UIElement>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "GetOptionButton", MemberParameters = new object[]
		{
			typeof(CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativePowersMenu), Member = "CreateSubcategoryButton", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(ref CreativePowerUIElementRequestInfo),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Dictionary<int, GroupOptionButton<int>>),
			typeof(Dictionary<int, UIElement>)
		}, ReturnType = typeof(GroupOptionButton<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void UpdateUnlockStateByPower(ICreativePower power, UIElement button, Color colorWhenSelected)
		{
			throw null;
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0002DB51 File Offset: 0x0002BD51
		[global::Cpp2ILInjected.Token(Token = "0x6004C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B54EC", Offset = "0x8B54EC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "AddPermissionTextIfNeeded", MemberParameters = new object[]
		{
			typeof(ICreativePower),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPowerInternal", MemberParameters = new object[]
		{
			typeof(ICreativePower),
			typeof(Color),
			typeof(IGroupOptionButton)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "Deserialize_SyncEveryone", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "button_OnClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "SetValueKeyboard", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerSliderPower), Member = "PushChangeAndSetSlider", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedButtonPower), Member = "button_OnClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "button_OnClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "DeserializeNetMessage", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedSliderPower), Member = "SetValueKeyboardForced", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool IsAvailableForPlayer(ICreativePower power, int playerIndex)
		{
			throw null;
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x0002DB54 File Offset: 0x0002BD54
		[global::Cpp2ILInjected.Token(Token = "0x6004C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B59E4", Offset = "0x8B59E4", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper.<>c__DisplayClass14_0), Member = "<UpdateUnlockStateByPower>b__0", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "IsAvailableForPlayer", MemberParameters = new object[]
		{
			typeof(ICreativePower),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void UpdateUnlockStateByPowerInternal(ICreativePower power, Color colorWhenSelected, IGroupOptionButton asButton)
		{
			throw null;
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x0002DB57 File Offset: 0x0002BD57
		[global::Cpp2ILInjected.Token(Token = "0x6004C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5DB8", Offset = "0x8B5DB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CreativePowersHelper()
		{
			throw null;
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x0002DB5A File Offset: 0x0002BD5A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B5DC0", Offset = "0x8B5DC0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static CreativePowersHelper()
		{
			throw null;
		}

		// Token: 0x04006DB9 RID: 28089
		[global::Cpp2ILInjected.Token(Token = "0x4008620")]
		public const int TextureIconColumns = 21;

		// Token: 0x04006DBA RID: 28090
		[global::Cpp2ILInjected.Token(Token = "0x4008621")]
		public const int TextureIconRows = 1;

		// Token: 0x04006DBB RID: 28091
		[global::Cpp2ILInjected.Token(Token = "0x4008622")]
		public static Color CommonSelectedColor;

		// Token: 0x02000A6F RID: 2671
		[global::Cpp2ILInjected.Token(Token = "0x2000A10")]
		public class CreativePowerIconLocations
		{
			// Token: 0x060050BD RID: 20669 RVA: 0x000303D4 File Offset: 0x0002E5D4
			[global::Cpp2ILInjected.Token(Token = "0x6004C11")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B5E28", Offset = "0x8B5E28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CreativePowerIconLocations()
			{
				throw null;
			}

			// Token: 0x060050BE RID: 20670 RVA: 0x000303D7 File Offset: 0x0002E5D7
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004C12")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B5E30", Offset = "0x8B5E30", Length = "0x3DC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static CreativePowerIconLocations()
			{
				throw null;
			}

			// Token: 0x04008E80 RID: 36480
			[global::Cpp2ILInjected.Token(Token = "0x4008623")]
			public static readonly Point Unassigned;

			// Token: 0x04008E81 RID: 36481
			[global::Cpp2ILInjected.Token(Token = "0x4008624")]
			public static readonly Point Deprecated;

			// Token: 0x04008E82 RID: 36482
			[global::Cpp2ILInjected.Token(Token = "0x4008625")]
			public static readonly Point ItemDuplication;

			// Token: 0x04008E83 RID: 36483
			[global::Cpp2ILInjected.Token(Token = "0x4008626")]
			public static readonly Point ItemResearch;

			// Token: 0x04008E84 RID: 36484
			[global::Cpp2ILInjected.Token(Token = "0x4008627")]
			public static readonly Point TimeCategory;

			// Token: 0x04008E85 RID: 36485
			[global::Cpp2ILInjected.Token(Token = "0x4008628")]
			public static readonly Point WeatherCategory;

			// Token: 0x04008E86 RID: 36486
			[global::Cpp2ILInjected.Token(Token = "0x4008629")]
			public static readonly Point EnemyStrengthSlider;

			// Token: 0x04008E87 RID: 36487
			[global::Cpp2ILInjected.Token(Token = "0x400862A")]
			public static readonly Point GameEvents;

			// Token: 0x04008E88 RID: 36488
			[global::Cpp2ILInjected.Token(Token = "0x400862B")]
			public static readonly Point Godmode;

			// Token: 0x04008E89 RID: 36489
			[global::Cpp2ILInjected.Token(Token = "0x400862C")]
			public static readonly Point BlockPlacementRange;

			// Token: 0x04008E8A RID: 36490
			[global::Cpp2ILInjected.Token(Token = "0x400862D")]
			public static readonly Point StopBiomeSpread;

			// Token: 0x04008E8B RID: 36491
			[global::Cpp2ILInjected.Token(Token = "0x400862E")]
			public static readonly Point EnemySpawnRate;

			// Token: 0x04008E8C RID: 36492
			[global::Cpp2ILInjected.Token(Token = "0x400862F")]
			public static readonly Point FreezeTime;

			// Token: 0x04008E8D RID: 36493
			[global::Cpp2ILInjected.Token(Token = "0x4008630")]
			public static readonly Point TimeDawn;

			// Token: 0x04008E8E RID: 36494
			[global::Cpp2ILInjected.Token(Token = "0x4008631")]
			public static readonly Point TimeNoon;

			// Token: 0x04008E8F RID: 36495
			[global::Cpp2ILInjected.Token(Token = "0x4008632")]
			public static readonly Point TimeDusk;

			// Token: 0x04008E90 RID: 36496
			[global::Cpp2ILInjected.Token(Token = "0x4008633")]
			public static readonly Point TimeMidnight;

			// Token: 0x04008E91 RID: 36497
			[global::Cpp2ILInjected.Token(Token = "0x4008634")]
			public static readonly Point WindDirection;

			// Token: 0x04008E92 RID: 36498
			[global::Cpp2ILInjected.Token(Token = "0x4008635")]
			public static readonly Point WindFreeze;

			// Token: 0x04008E93 RID: 36499
			[global::Cpp2ILInjected.Token(Token = "0x4008636")]
			public static readonly Point RainStrength;

			// Token: 0x04008E94 RID: 36500
			[global::Cpp2ILInjected.Token(Token = "0x4008637")]
			public static readonly Point RainFreeze;

			// Token: 0x04008E95 RID: 36501
			[global::Cpp2ILInjected.Token(Token = "0x4008638")]
			public static readonly Point ModifyTime;

			// Token: 0x04008E96 RID: 36502
			[global::Cpp2ILInjected.Token(Token = "0x4008639")]
			public static readonly Point PersonalCategory;
		}

		// Token: 0x02000A70 RID: 2672
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A11")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x060050BF RID: 20671 RVA: 0x000303DA File Offset: 0x0002E5DA
			[global::Cpp2ILInjected.Token(Token = "0x6004C13")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B59DC", Offset = "0x8B59DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass14_0()
			{
				throw null;
			}

			// Token: 0x060050C0 RID: 20672 RVA: 0x000303DD File Offset: 0x0002E5DD
			[global::Cpp2ILInjected.Token(Token = "0x6004C14")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B620C", Offset = "0x8B620C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowersHelper), Member = "UpdateUnlockStateByPowerInternal", MemberParameters = new object[]
			{
				typeof(ICreativePower),
				typeof(Color),
				typeof(IGroupOptionButton)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <UpdateUnlockStateByPower>b__0(UIElement element)
			{
				throw null;
			}

			// Token: 0x04008E97 RID: 36503
			[global::Cpp2ILInjected.Token(Token = "0x400863A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ICreativePower power;

			// Token: 0x04008E98 RID: 36504
			[global::Cpp2ILInjected.Token(Token = "0x400863B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Color colorWhenSelected;

			// Token: 0x04008E99 RID: 36505
			[global::Cpp2ILInjected.Token(Token = "0x400863C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public IGroupOptionButton asButton;
		}
	}
}
