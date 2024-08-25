using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AAA")]
	public class UISliderBase : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005075")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F428", Offset = "0x90F428", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVerticalSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVerticalSlider), Member = "DrawValueBarDynamicWidth", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal int GetUsageLevel()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005076")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F490", Offset = "0x90F490", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void EscapeElements()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005077")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F4E4", Offset = "0x90F4E4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredSlider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(Func<float>),
			typeof(Action<float>),
			typeof(Action),
			typeof(Func<float, Color>),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVerticalSlider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Func<float>),
			typeof(Action<float>),
			typeof(Action),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UISliderBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008937")]
		internal const int UsageLevel_NotSelected = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4008938")]
		internal const int UsageLevel_SelectedAndLocked = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4008939")]
		internal const int UsageLevel_OtherElementIsLocked = 2;

		[global::Cpp2ILInjected.Token(Token = "0x400893A")]
		internal static UIElement CurrentLockedSlider;

		[global::Cpp2ILInjected.Token(Token = "0x400893B")]
		internal static UIElement CurrentAimedSlider;
	}
}
