using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006DF RID: 1759
	[global::Cpp2ILInjected.Token(Token = "0x2000AC7")]
	public class UIProgressBar : UIElement
	{
		// Token: 0x060044C6 RID: 17606 RVA: 0x0002E4ED File Offset: 0x0002C6ED
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

		// Token: 0x060044C7 RID: 17607 RVA: 0x0002E4F0 File Offset: 0x0002C6F0
		[global::Cpp2ILInjected.Token(Token = "0x6005128")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D14C", Offset = "0x92D14C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetProgress(float value)
		{
			throw null;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x0002E4F3 File Offset: 0x0002C6F3
		[global::Cpp2ILInjected.Token(Token = "0x6005129")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D164", Offset = "0x92D164", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04007080 RID: 28800
		[global::Cpp2ILInjected.Token(Token = "0x40089CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private UIProgressBar.UIInnerProgressBar _progressBar;

		// Token: 0x04007081 RID: 28801
		[global::Cpp2ILInjected.Token(Token = "0x40089CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private float _visualProgress;

		// Token: 0x04007082 RID: 28802
		[global::Cpp2ILInjected.Token(Token = "0x40089CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private float _targetProgress;

		// Token: 0x02000AC4 RID: 2756
		[global::Cpp2ILInjected.Token(Token = "0x2000AC8")]
		private class UIInnerProgressBar : UIElement
		{
			// Token: 0x0600528D RID: 21133 RVA: 0x000308ED File Offset: 0x0002EAED
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

			// Token: 0x0600528E RID: 21134 RVA: 0x000308F0 File Offset: 0x0002EAF0
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
