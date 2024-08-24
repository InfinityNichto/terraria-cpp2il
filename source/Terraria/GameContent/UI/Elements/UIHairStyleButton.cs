using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D1 RID: 1745
	[global::Cpp2ILInjected.Token(Token = "0x2000AB5")]
	public class UIHairStyleButton : UIImageButton
	{
		// Token: 0x0600447B RID: 17531 RVA: 0x0002E412 File Offset: 0x0002C612
		[global::Cpp2ILInjected.Token(Token = "0x60050CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x927F28", Offset = "0x927F28", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public UIHairStyleButton(Player player, int hairStyleId)
		{
			throw null;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x0002E415 File Offset: 0x0002C615
		[global::Cpp2ILInjected.Token(Token = "0x60050CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9282E0", Offset = "0x9282E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SkipRenderingContent(int timeInFrames)
		{
			throw null;
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x0002E418 File Offset: 0x0002C618
		[global::Cpp2ILInjected.Token(Token = "0x60050CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9282E8", Offset = "0x9282E8", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x0002E41B File Offset: 0x0002C61B
		[global::Cpp2ILInjected.Token(Token = "0x60050D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x928840", Offset = "0x928840", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x0002E41E File Offset: 0x0002C61E
		[global::Cpp2ILInjected.Token(Token = "0x60050D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x928894", Offset = "0x928894", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x0002E421 File Offset: 0x0002C621
		[global::Cpp2ILInjected.Token(Token = "0x60050D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x92890C", Offset = "0x92890C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x04007045 RID: 28741
		[global::Cpp2ILInjected.Token(Token = "0x400898C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private readonly Player _player;

		// Token: 0x04007046 RID: 28742
		[global::Cpp2ILInjected.Token(Token = "0x400898D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public readonly int HairStyleId;

		// Token: 0x04007047 RID: 28743
		[global::Cpp2ILInjected.Token(Token = "0x400898E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x04007048 RID: 28744
		[global::Cpp2ILInjected.Token(Token = "0x400898F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x04007049 RID: 28745
		[global::Cpp2ILInjected.Token(Token = "0x4008990")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private bool _hovered;

		// Token: 0x0400704A RID: 28746
		[global::Cpp2ILInjected.Token(Token = "0x4008991")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x181")]
		private bool _soundedHover;

		// Token: 0x0400704B RID: 28747
		[global::Cpp2ILInjected.Token(Token = "0x4008992")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x184")]
		private int _framesToSkip;
	}
}
