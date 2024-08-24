using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E0 RID: 1760
	[global::Cpp2ILInjected.Token(Token = "0x2000AC9")]
	public class UIResourcePackInfoButton<T> : UITextPanel<T>
	{
		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060044C9 RID: 17609 RVA: 0x0002E4F6 File Offset: 0x0002C6F6
		// (set) Token: 0x060044CA RID: 17610 RVA: 0x0002E4F9 File Offset: 0x0002C6F9
		[global::Cpp2ILInjected.Token(Token = "0x170008C8")]
		public ResourcePack ResourcePack
		{
			[global::Cpp2ILInjected.Token(Token = "0x600512C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894628", Offset = "0x1894628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600512D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894630", Offset = "0x1894630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		[global::Cpp2ILInjected.Token(Token = "0x600512E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894638", Offset = "0x1894638", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public UIResourcePackInfoButton(T text, float textScale = 1f, bool large = false)
		{
			throw null;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x0002E4FF File Offset: 0x0002C6FF
		[global::Cpp2ILInjected.Token(Token = "0x600512F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894830", Offset = "0x1894830", Length = "0x21C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04007083 RID: 28803
		[global::Cpp2ILInjected.Token(Token = "0x40089CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x04007084 RID: 28804
		[global::Cpp2ILInjected.Token(Token = "0x40089D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x04007085 RID: 28805
		[global::Cpp2ILInjected.Token(Token = "0x40089D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ResourcePack _resourcePack;
	}
}
