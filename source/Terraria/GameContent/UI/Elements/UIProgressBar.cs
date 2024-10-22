﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AC7")]
	public class UIProgressBar : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005127")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D044", Offset = "0x92D044", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIProgressBar.UIInnerProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UIProgressBar()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005128")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D14C", Offset = "0x92D14C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetProgress(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005129")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D164", Offset = "0x92D164", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40089CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private UIProgressBar.UIInnerProgressBar _progressBar;

		[global::Cpp2ILInjected.Token(Token = "0x40089CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private float _visualProgress;

		[global::Cpp2ILInjected.Token(Token = "0x40089CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private float _targetProgress;

		[global::Cpp2ILInjected.Token(Token = "0x2000AC8")]
		private class UIInnerProgressBar : UIElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x600512A")]
			[global::Cpp2ILInjected.Address(RVA = "0x92D1A4", Offset = "0x92D1A4", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			protected override void DrawSelf(SpriteBatch spriteBatch)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600512B")]
			[global::Cpp2ILInjected.Address(RVA = "0x92D0F4", Offset = "0x92D0F4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIProgressBar), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public UIInnerProgressBar()
			{
				throw null;
			}
		}
	}
}
