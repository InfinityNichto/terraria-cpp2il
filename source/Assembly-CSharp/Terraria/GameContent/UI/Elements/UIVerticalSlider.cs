using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.GameInput;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006EA RID: 1770
	[global::Cpp2ILInjected.Token(Token = "0x2000AD3")]
	public class UIVerticalSlider : UISliderBase
	{
		// Token: 0x06004532 RID: 17714 RVA: 0x0002E631 File Offset: 0x0002C831
		[global::Cpp2ILInjected.Token(Token = "0x6005195")]
		[global::Cpp2ILInjected.Address(RVA = "0x930434", Offset = "0x930434", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "CreateSlider", MemberParameters = new object[]
		{
			typeof(Func<float>),
			typeof(Action<float>),
			typeof(Action)
		}, ReturnType = typeof(UIVerticalSlider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISliderBase), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public UIVerticalSlider(Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Color color)
		{
			throw null;
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x0002E634 File Offset: 0x0002C834
		[global::Cpp2ILInjected.Token(Token = "0x6005196")]
		[global::Cpp2ILInjected.Address(RVA = "0x93062C", Offset = "0x93062C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISliderBase), Member = "GetUsageLevel", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVerticalSlider), Member = "DrawValueBarDynamicWidth", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_MouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x0002E637 File Offset: 0x0002C837
		[global::Cpp2ILInjected.Token(Token = "0x6005197")]
		[global::Cpp2ILInjected.Address(RVA = "0x930814", Offset = "0x930814", Length = "0x598")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVerticalSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawSplicedPanel", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISliderBase), Member = "GetUsageLevel", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private bool DrawValueBarDynamicWidth(SpriteBatch spriteBatch, out float sliderValueThatWasSet)
		{
			throw null;
		}

		// Token: 0x040070C7 RID: 28871
		[global::Cpp2ILInjected.Token(Token = "0x4008A13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		public float FillPercent;

		// Token: 0x040070C8 RID: 28872
		[global::Cpp2ILInjected.Token(Token = "0x4008A14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public Color FilledColor;

		// Token: 0x040070C9 RID: 28873
		[global::Cpp2ILInjected.Token(Token = "0x4008A15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
		public Color EmptyColor;

		// Token: 0x040070CA RID: 28874
		[global::Cpp2ILInjected.Token(Token = "0x4008A16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Func<float> _getSliderValue;

		// Token: 0x040070CB RID: 28875
		[global::Cpp2ILInjected.Token(Token = "0x4008A17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Action<float> _slideKeyboardAction;

		// Token: 0x040070CC RID: 28876
		[global::Cpp2ILInjected.Token(Token = "0x4008A18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Func<float, Color> _blipFunc;

		// Token: 0x040070CD RID: 28877
		[global::Cpp2ILInjected.Token(Token = "0x4008A19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private Action _slideGamepadAction;

		// Token: 0x040070CE RID: 28878
		[global::Cpp2ILInjected.Token(Token = "0x4008A1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private bool _isReallyMouseOvered;

		// Token: 0x040070CF RID: 28879
		[global::Cpp2ILInjected.Token(Token = "0x4008A1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x171")]
		private bool _soundedUsage;

		// Token: 0x040070D0 RID: 28880
		[global::Cpp2ILInjected.Token(Token = "0x4008A1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x172")]
		private bool _alreadyHovered;

		// Token: 0x02000AC5 RID: 2757
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000AD4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600528F RID: 21135 RVA: 0x000308F3 File Offset: 0x0002EAF3
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6005198")]
			[global::Cpp2ILInjected.Address(RVA = "0x930DAC", Offset = "0x930DAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06005290 RID: 21136 RVA: 0x000308F6 File Offset: 0x0002EAF6
			[global::Cpp2ILInjected.Token(Token = "0x6005199")]
			[global::Cpp2ILInjected.Address(RVA = "0x930E08", Offset = "0x930E08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06005291 RID: 21137 RVA: 0x000308F9 File Offset: 0x0002EAF9
			[global::Cpp2ILInjected.Token(Token = "0x600519A")]
			[global::Cpp2ILInjected.Address(RVA = "0x930E10", Offset = "0x930E10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal float <.ctor>b__10_0()
			{
				throw null;
			}

			// Token: 0x06005292 RID: 21138 RVA: 0x000308FC File Offset: 0x0002EAFC
			[global::Cpp2ILInjected.Token(Token = "0x600519B")]
			[global::Cpp2ILInjected.Address(RVA = "0x930E18", Offset = "0x930E18", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void <.ctor>b__10_1(float s)
			{
				throw null;
			}

			// Token: 0x04008F58 RID: 36696
			[global::Cpp2ILInjected.Token(Token = "0x4008A1D")]
			public static readonly UIVerticalSlider.<>c <>9;

			// Token: 0x04008F59 RID: 36697
			[global::Cpp2ILInjected.Token(Token = "0x4008A1E")]
			public static Func<float> <>9__10_0;

			// Token: 0x04008F5A RID: 36698
			[global::Cpp2ILInjected.Token(Token = "0x4008A1F")]
			public static Action<float> <>9__10_1;
		}
	}
}
