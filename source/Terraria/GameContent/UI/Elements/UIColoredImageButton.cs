using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AA9")]
	public class UIColoredImageButton : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x600506B")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E928", Offset = "0x90E928", Length = "0x41C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public UIColoredImageButton(Asset<Texture2D> texture, bool isSmall = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600506C")]
		[global::Cpp2ILInjected.Address(RVA = "0x90ED44", Offset = "0x90ED44", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600506D")]
		[global::Cpp2ILInjected.Address(RVA = "0x90EDE8", Offset = "0x90EDE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetImageWithoutSettingSize(Asset<Texture2D> texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600506E")]
		[global::Cpp2ILInjected.Address(RVA = "0x90EDF0", Offset = "0x90EDF0", Length = "0x56C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600506F")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F35C", Offset = "0x90F35C", Length = "0x48")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6005070")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F3A4", Offset = "0x90F3A4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public void SetVisibility(float whenActive, float whenInactive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005071")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F3F0", Offset = "0x90F3F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetColor(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005072")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F3F8", Offset = "0x90F3F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetMiddleTexture(Asset<Texture2D> texAsset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005073")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F400", Offset = "0x90F400", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetSelected(bool selected)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005074")]
		[global::Cpp2ILInjected.Address(RVA = "0x90F40C", Offset = "0x90F40C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400892D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _backPanelTexture;

		[global::Cpp2ILInjected.Token(Token = "0x400892E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Asset<Texture2D> _texture;

		[global::Cpp2ILInjected.Token(Token = "0x400892F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Asset<Texture2D> _middleTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008930")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Asset<Texture2D> _backPanelHighlightTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008931")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private Asset<Texture2D> _backPanelBorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008932")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private Color _color;

		[global::Cpp2ILInjected.Token(Token = "0x4008933")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
		private float _visibilityActive;

		[global::Cpp2ILInjected.Token(Token = "0x4008934")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private float _visibilityInactive;

		[global::Cpp2ILInjected.Token(Token = "0x4008935")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x17C")]
		private bool _selected;

		[global::Cpp2ILInjected.Token(Token = "0x4008936")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x17D")]
		private bool _hovered;
	}
}
