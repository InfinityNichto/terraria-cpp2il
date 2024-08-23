using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006EB RID: 1771
	[global::Cpp2ILInjected.Token(Token = "0x2000AD5")]
	public class UIWorldCreationPreview : UIElement
	{
		// Token: 0x06004535 RID: 17717 RVA: 0x0002E63A File Offset: 0x0002C83A
		[global::Cpp2ILInjected.Token(Token = "0x600519C")]
		[global::Cpp2ILInjected.Address(RVA = "0x930E1C", Offset = "0x930E1C", Length = "0x9E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		public UIWorldCreationPreview()
		{
			throw null;
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x0002E63D File Offset: 0x0002C83D
		[global::Cpp2ILInjected.Token(Token = "0x600519D")]
		[global::Cpp2ILInjected.Address(RVA = "0x931800", Offset = "0x931800", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateOption(byte difficulty, byte evil, byte size)
		{
			throw null;
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x0002E640 File Offset: 0x0002C840
		[global::Cpp2ILInjected.Token(Token = "0x600519E")]
		[global::Cpp2ILInjected.Address(RVA = "0x931810", Offset = "0x931810", Length = "0x2D0")]
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
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x040070D1 RID: 28881
		[global::Cpp2ILInjected.Token(Token = "0x4008A20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private readonly Asset<Texture2D> _BorderTexture;

		// Token: 0x040070D2 RID: 28882
		[global::Cpp2ILInjected.Token(Token = "0x4008A21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private readonly Asset<Texture2D> _BackgroundExpertTexture;

		// Token: 0x040070D3 RID: 28883
		[global::Cpp2ILInjected.Token(Token = "0x4008A22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private readonly Asset<Texture2D> _BackgroundNormalTexture;

		// Token: 0x040070D4 RID: 28884
		[global::Cpp2ILInjected.Token(Token = "0x4008A23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private readonly Asset<Texture2D> _BackgroundMasterTexture;

		// Token: 0x040070D5 RID: 28885
		[global::Cpp2ILInjected.Token(Token = "0x4008A24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private readonly Asset<Texture2D> _BunnyExpertTexture;

		// Token: 0x040070D6 RID: 28886
		[global::Cpp2ILInjected.Token(Token = "0x4008A25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private readonly Asset<Texture2D> _BunnyNormalTexture;

		// Token: 0x040070D7 RID: 28887
		[global::Cpp2ILInjected.Token(Token = "0x4008A26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private readonly Asset<Texture2D> _BunnyCreativeTexture;

		// Token: 0x040070D8 RID: 28888
		[global::Cpp2ILInjected.Token(Token = "0x4008A27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private readonly Asset<Texture2D> _BunnyMasterTexture;

		// Token: 0x040070D9 RID: 28889
		[global::Cpp2ILInjected.Token(Token = "0x4008A28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private readonly Asset<Texture2D> _EvilRandomTexture;

		// Token: 0x040070DA RID: 28890
		[global::Cpp2ILInjected.Token(Token = "0x4008A29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private readonly Asset<Texture2D> _EvilCorruptionTexture;

		// Token: 0x040070DB RID: 28891
		[global::Cpp2ILInjected.Token(Token = "0x4008A2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private readonly Asset<Texture2D> _EvilCrimsonTexture;

		// Token: 0x040070DC RID: 28892
		[global::Cpp2ILInjected.Token(Token = "0x4008A2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private readonly Asset<Texture2D> _SizeSmallTexture;

		// Token: 0x040070DD RID: 28893
		[global::Cpp2ILInjected.Token(Token = "0x4008A2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private readonly Asset<Texture2D> _SizeMediumTexture;

		// Token: 0x040070DE RID: 28894
		[global::Cpp2ILInjected.Token(Token = "0x4008A2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private readonly Asset<Texture2D> _SizeLargeTexture;

		// Token: 0x040070DF RID: 28895
		[global::Cpp2ILInjected.Token(Token = "0x4008A2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private byte _difficulty;

		// Token: 0x040070E0 RID: 28896
		[global::Cpp2ILInjected.Token(Token = "0x4008A2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B9")]
		private byte _evil;

		// Token: 0x040070E1 RID: 28897
		[global::Cpp2ILInjected.Token(Token = "0x4008A30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1BA")]
		private byte _size;
	}
}
