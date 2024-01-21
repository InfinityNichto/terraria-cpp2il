using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000682")]
public class CreativePowersHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000A66")]
	public class CreativePowerIconLocations
	{
		[Cpp2IlInjected.Token(Token = "0x4008E6D")]
		public static readonly Point Unassigned;

		[Cpp2IlInjected.Token(Token = "0x4008E6E")]
		public static readonly Point Deprecated;

		[Cpp2IlInjected.Token(Token = "0x4008E6F")]
		public static readonly Point ItemDuplication;

		[Cpp2IlInjected.Token(Token = "0x4008E70")]
		public static readonly Point ItemResearch;

		[Cpp2IlInjected.Token(Token = "0x4008E71")]
		public static readonly Point TimeCategory;

		[Cpp2IlInjected.Token(Token = "0x4008E72")]
		public static readonly Point WeatherCategory;

		[Cpp2IlInjected.Token(Token = "0x4008E73")]
		public static readonly Point EnemyStrengthSlider;

		[Cpp2IlInjected.Token(Token = "0x4008E74")]
		public static readonly Point GameEvents;

		[Cpp2IlInjected.Token(Token = "0x4008E75")]
		public static readonly Point Godmode;

		[Cpp2IlInjected.Token(Token = "0x4008E76")]
		public static readonly Point BlockPlacementRange;

		[Cpp2IlInjected.Token(Token = "0x4008E77")]
		public static readonly Point StopBiomeSpread;

		[Cpp2IlInjected.Token(Token = "0x4008E78")]
		public static readonly Point EnemySpawnRate;

		[Cpp2IlInjected.Token(Token = "0x4008E79")]
		public static readonly Point FreezeTime;

		[Cpp2IlInjected.Token(Token = "0x4008E7A")]
		public static readonly Point TimeDawn;

		[Cpp2IlInjected.Token(Token = "0x4008E7B")]
		public static readonly Point TimeNoon;

		[Cpp2IlInjected.Token(Token = "0x4008E7C")]
		public static readonly Point TimeDusk;

		[Cpp2IlInjected.Token(Token = "0x4008E7D")]
		public static readonly Point TimeMidnight;

		[Cpp2IlInjected.Token(Token = "0x4008E7E")]
		public static readonly Point WindDirection;

		[Cpp2IlInjected.Token(Token = "0x4008E7F")]
		public static readonly Point WindFreeze;

		[Cpp2IlInjected.Token(Token = "0x4008E80")]
		public static readonly Point RainStrength;

		[Cpp2IlInjected.Token(Token = "0x4008E81")]
		public static readonly Point RainFreeze;

		[Cpp2IlInjected.Token(Token = "0x4008E82")]
		public static readonly Point ModifyTime;

		[Cpp2IlInjected.Token(Token = "0x4008E83")]
		public static readonly Point PersonalCategory;

		[Cpp2IlInjected.Token(Token = "0x60050F4")]
		[Cpp2IlInjected.Address(RVA = "0x108E504", Offset = "0x108E504", VA = "0x108E504")]
		public CreativePowerIconLocations()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006DBA")]
	public const int TextureIconColumns = 21;

	[Cpp2IlInjected.Token(Token = "0x4006DBB")]
	public const int TextureIconRows = 1;

	[Cpp2IlInjected.Token(Token = "0x4006DBC")]
	public static Color CommonSelectedColor;

	[Cpp2IlInjected.Token(Token = "0x60041AE")]
	[Cpp2IlInjected.Address(RVA = "0x108DDA8", Offset = "0x108DDA8", VA = "0x108DDA8")]
	private static Asset<Texture2D> GetPowerIconAsset(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041AF")]
	[Cpp2IlInjected.Address(RVA = "0x1085080", Offset = "0x1085080", VA = "0x1085080")]
	public static UIImageFramed GetIconImage(Point iconLocation)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041B0")]
	[Cpp2IlInjected.Address(RVA = "0x108644C", Offset = "0x108644C", VA = "0x108644C")]
	public static GroupOptionButton<bool> CreateToggleButton(CreativePowerUIElementRequestInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041B1")]
	[Cpp2IlInjected.Address(RVA = "0x1086DAC", Offset = "0x1086DAC", VA = "0x1086DAC")]
	public static GroupOptionButton<bool> CreateSimpleButton(CreativePowerUIElementRequestInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041B2")]
	[Cpp2IlInjected.Address(RVA = "0x206EB94", Offset = "0x206EB94", VA = "0x206EB94")]
	public static GroupOptionButton<T> CreateCategoryButton<T>(CreativePowerUIElementRequestInfo info, T option, T currentOption) where T : IConvertible, IEquatable<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041B3")]
	[Cpp2IlInjected.Address(RVA = "0x1085518", Offset = "0x1085518", VA = "0x1085518")]
	public static void AddPermissionTextIfNeeded(ICreativePower power, ref string originalText)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041B4")]
	[Cpp2IlInjected.Address(RVA = "0x10853DC", Offset = "0x10853DC", VA = "0x10853DC")]
	public static void AddDescriptionIfNeeded(ref string originalText, string descriptionKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041B5")]
	[Cpp2IlInjected.Address(RVA = "0x1085494", Offset = "0x1085494", VA = "0x1085494")]
	public static void AddUnlockTextIfNeeded(ref string originalText, bool needed, string descriptionKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041B6")]
	[Cpp2IlInjected.Address(RVA = "0x1088EB4", Offset = "0x1088EB4", VA = "0x1088EB4")]
	public static UIVerticalSlider CreateSlider(Func<float> GetSliderValueMethod, Action<float> SetValueKeyboardMethod, Action SetValueGamepadMethod)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041B7")]
	[Cpp2IlInjected.Address(RVA = "0x108DEB8", Offset = "0x108DEB8", VA = "0x108DEB8")]
	public static void UpdateUseMouseInterface(UIElement affectedElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041B8")]
	[Cpp2IlInjected.Address(RVA = "0x1084F9C", Offset = "0x1084F9C", VA = "0x1084F9C")]
	public static void UpdateUnlockStateByPower(ICreativePower power, UIElement button, Color colorWhenSelected)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041B9")]
	[Cpp2IlInjected.Address(RVA = "0x10846DC", Offset = "0x10846DC", VA = "0x10846DC")]
	public static bool IsAvailableForPlayer(ICreativePower power, int playerIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041BA")]
	[Cpp2IlInjected.Address(RVA = "0x108DF4C", Offset = "0x108DF4C", VA = "0x108DF4C")]
	private static void UpdateUnlockStateByPowerInternal(ICreativePower power, Color colorWhenSelected, IGroupOptionButton asButton)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041BB")]
	[Cpp2IlInjected.Address(RVA = "0x108E3EC", Offset = "0x108E3EC", VA = "0x108E3EC")]
	public CreativePowersHelper()
	{
	}
}
