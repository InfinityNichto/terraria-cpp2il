using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.GameContent.UI.Minimap;

[Cpp2IlInjected.Token(Token = "0x20006B4")]
public class MinimapFrame : IConfigKeyHolder
{
	[Cpp2IlInjected.Token(Token = "0x2000AAC")]
	private class Button
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008F1D")]
		public bool IsHighlighted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008F1E")]
		private readonly Vector2 _position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008F1F")]
		private readonly Asset<Texture2D> _hoverTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008F20")]
		private readonly Action _onMouseDown;

		[Cpp2IlInjected.Token(Token = "0x1700090A")]
		private Vector2 Size
		{
			[Cpp2IlInjected.Token(Token = "0x6005298")]
			[Cpp2IlInjected.Address(RVA = "0x109CE2C", Offset = "0x109CE2C", VA = "0x109CE2C")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005299")]
		[Cpp2IlInjected.Address(RVA = "0x109C1C8", Offset = "0x109C1C8", VA = "0x109C1C8")]
		public Button(Asset<Texture2D> hoverTexture, Vector2 position, Action mouseDownCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600529A")]
		[Cpp2IlInjected.Address(RVA = "0x109C858", Offset = "0x109C858", VA = "0x109C858")]
		public void Click()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600529B")]
		[Cpp2IlInjected.Address(RVA = "0x109CB04", Offset = "0x109CB04", VA = "0x109CB04")]
		public void Draw(SpriteBatch spriteBatch, Vector2 parentPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600529C")]
		[Cpp2IlInjected.Address(RVA = "0x109CC10", Offset = "0x109CC10", VA = "0x109CC10")]
		public bool IsTouchingPoint(Vector2 testPoint, Vector2 parentPosition)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006F75")]
	private const float DEFAULT_ZOOM = 1.05f;

	[Cpp2IlInjected.Token(Token = "0x4006F76")]
	private const float ZOOM_OUT_MULTIPLIER = 0.975f;

	[Cpp2IlInjected.Token(Token = "0x4006F77")]
	private const float ZOOM_IN_MULTIPLIER = 1.025f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006F7B")]
	private readonly Asset<Texture2D> _frameTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006F7C")]
	private readonly Vector2 _frameOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006F7D")]
	private Button _resetButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006F7E")]
	private Button _zoomInButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006F7F")]
	private Button _zoomOutButton;

	[Cpp2IlInjected.Token(Token = "0x170007B6")]
	public string ConfigKey
	{
		[Cpp2IlInjected.Token(Token = "0x60043B5")]
		[Cpp2IlInjected.Address(RVA = "0x109BF3C", Offset = "0x109BF3C", VA = "0x109BF3C", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60043B6")]
		[Cpp2IlInjected.Address(RVA = "0x109BF44", Offset = "0x109BF44", VA = "0x109BF44")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007B7")]
	public string NameKey
	{
		[Cpp2IlInjected.Token(Token = "0x60043B7")]
		[Cpp2IlInjected.Address(RVA = "0x109BF4C", Offset = "0x109BF4C", VA = "0x109BF4C", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60043B8")]
		[Cpp2IlInjected.Address(RVA = "0x109BF54", Offset = "0x109BF54", VA = "0x109BF54")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007B8")]
	public Vector2 MinimapPosition
	{
		[Cpp2IlInjected.Token(Token = "0x60043B9")]
		[Cpp2IlInjected.Address(RVA = "0x109BF5C", Offset = "0x109BF5C", VA = "0x109BF5C")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60043BA")]
		[Cpp2IlInjected.Address(RVA = "0x109BF70", Offset = "0x109BF70", VA = "0x109BF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007B9")]
	private Vector2 FramePosition
	{
		[Cpp2IlInjected.Token(Token = "0x60043BB")]
		[Cpp2IlInjected.Address(RVA = "0x109BF7C", Offset = "0x109BF7C", VA = "0x109BF7C")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60043BC")]
		[Cpp2IlInjected.Address(RVA = "0x109C028", Offset = "0x109C028", VA = "0x109C028")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60043BD")]
	[Cpp2IlInjected.Address(RVA = "0x109C0E0", Offset = "0x109C0E0", VA = "0x109C0E0")]
	public MinimapFrame(Asset<Texture2D> frameTexture, Vector2 frameOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043BE")]
	[Cpp2IlInjected.Address(RVA = "0x109C110", Offset = "0x109C110", VA = "0x109C110")]
	public void SetResetButton(Asset<Texture2D> hoverTexture, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043BF")]
	[Cpp2IlInjected.Address(RVA = "0x109C200", Offset = "0x109C200", VA = "0x109C200")]
	private void ResetZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C0")]
	[Cpp2IlInjected.Address(RVA = "0x109C27C", Offset = "0x109C27C", VA = "0x109C27C")]
	public void SetZoomInButton(Asset<Texture2D> hoverTexture, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C1")]
	[Cpp2IlInjected.Address(RVA = "0x109C334", Offset = "0x109C334", VA = "0x109C334")]
	private void ZoomInButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C2")]
	[Cpp2IlInjected.Address(RVA = "0x109C3C4", Offset = "0x109C3C4", VA = "0x109C3C4")]
	public void SetZoomOutButton(Asset<Texture2D> hoverTexture, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C3")]
	[Cpp2IlInjected.Address(RVA = "0x109C47C", Offset = "0x109C47C", VA = "0x109C47C")]
	private void ZoomOutButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C4")]
	[Cpp2IlInjected.Address(RVA = "0x109C50C", Offset = "0x109C50C", VA = "0x109C50C")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C5")]
	[Cpp2IlInjected.Address(RVA = "0x109C864", Offset = "0x109C864", VA = "0x109C864")]
	public void DrawBackground(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C6")]
	[Cpp2IlInjected.Address(RVA = "0x109C9E0", Offset = "0x109C9E0", VA = "0x109C9E0")]
	public void DrawForeground(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043C7")]
	[Cpp2IlInjected.Address(RVA = "0x109C6CC", Offset = "0x109C6CC", VA = "0x109C6CC")]
	private Button GetButtonUnderMouse()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60043C8")]
	[Cpp2IlInjected.Address(RVA = "0x109CE1C", Offset = "0x109CE1C", VA = "0x109CE1C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x396B34", Offset = "0x396B34")]
	private void ValidateState()
	{
	}
}
