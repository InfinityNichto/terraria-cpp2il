using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000ACC")]
	public class UISelectableTextPanel<T> : UITextPanel<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008CD")]
		public Func<UISelectableTextPanel<T>, bool> IsSelected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005151")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894A4C", Offset = "0x1894A4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005152")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894A54", Offset = "0x1894A54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894A5C", Offset = "0x1894A5C", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public UISelectableTextPanel(T text, float textScale = 1f, bool large = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894C54", Offset = "0x1894C54", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40089E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40089E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40089E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Func<UISelectableTextPanel<T>, bool> _isSelected;
	}
}
