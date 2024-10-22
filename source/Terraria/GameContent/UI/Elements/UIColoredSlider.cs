﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AAB")]
	public class UIColoredSlider : UISliderBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005078")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F53C", Offset = "0x90F53C", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<float, Color>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public UIColoredSlider(LocalizedText textKey, Func<float> getStatus, Action<float> setStatusKeyboard, Action setStatusGamepad, Func<float, Color> blipColorFunction, Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005079")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F774", Offset = "0x90F774", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISliderBase), Member = "GetUsageLevel", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIColoredSlider), Member = "DrawValueBar", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(ref bool),
			typeof(Func<float, Color>)
		}, ReturnType = typeof(float))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600507A")]
		[global::Cpp2ILInjected.Address(RVA = "0x90FBE8", Offset = "0x90FBE8", Length = "0x614")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private float DrawValueBar(SpriteBatch sb, Vector2 drawPosition, float drawScale, float sliderPosition, int lockMode, out bool wasInBar, Func<float, Color> blipColorFunc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400893C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x141")]
		private Color _color;

		[global::Cpp2ILInjected.Token(Token = "0x400893D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private LocalizedText _textKey;

		[global::Cpp2ILInjected.Token(Token = "0x400893E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Func<float> _getStatusTextAct;

		[global::Cpp2ILInjected.Token(Token = "0x400893F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Action<float> _slideKeyboardAction;

		[global::Cpp2ILInjected.Token(Token = "0x4008940")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Func<float, Color> _blipFunc;

		[global::Cpp2ILInjected.Token(Token = "0x4008941")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private Action _slideGamepadAction;

		[global::Cpp2ILInjected.Token(Token = "0x4008942")]
		private const bool BOTHER_WITH_TEXT = false;

		[global::Cpp2ILInjected.Token(Token = "0x4008943")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private bool _isReallyMouseOvered;

		[global::Cpp2ILInjected.Token(Token = "0x4008944")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x171")]
		private bool _alreadyHovered;

		[global::Cpp2ILInjected.Token(Token = "0x4008945")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x172")]
		private bool _soundedUsage;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000AAC")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600507B")]
			[global::Cpp2ILInjected.Address(RVA = "0x9101FC", Offset = "0x9101FC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600507C")]
			[global::Cpp2ILInjected.Address(RVA = "0x910258", Offset = "0x910258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600507D")]
			[global::Cpp2ILInjected.Address(RVA = "0x910260", Offset = "0x910260", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal float <.ctor>b__10_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600507E")]
			[global::Cpp2ILInjected.Address(RVA = "0x910268", Offset = "0x910268", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void <.ctor>b__10_1(float s)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600507F")]
			[global::Cpp2ILInjected.Address(RVA = "0x91026C", Offset = "0x91026C", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Color <.ctor>b__10_2(float s)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008946")]
			public static readonly UIColoredSlider.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4008947")]
			public static Func<float> <>9__10_0;

			[global::Cpp2ILInjected.Token(Token = "0x4008948")]
			public static Action<float> <>9__10_1;

			[global::Cpp2ILInjected.Token(Token = "0x4008949")]
			public static Func<float, Color> <>9__10_2;
		}
	}
}
