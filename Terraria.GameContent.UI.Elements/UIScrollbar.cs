using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E4")]
public class UIScrollbar : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007087")]
	private float _viewPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007088")]
	private float _viewSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007089")]
	private float _maxViewSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400708A")]
	private bool _isDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x400708B")]
	private bool _isHoveringOverHandle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400708C")]
	private float _dragYOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400708D")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400708E")]
	private Asset<Texture2D> _innerTexture;

	[Cpp2IlInjected.Token(Token = "0x170007CA")]
	public float ViewPosition
	{
		[Cpp2IlInjected.Token(Token = "0x600450C")]
		[Cpp2IlInjected.Address(RVA = "0x14959B4", Offset = "0x14959B4", VA = "0x14959B4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600450D")]
		[Cpp2IlInjected.Address(RVA = "0x147EC4C", Offset = "0x147EC4C", VA = "0x147EC4C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007CB")]
	public bool CanScroll
	{
		[Cpp2IlInjected.Token(Token = "0x600450E")]
		[Cpp2IlInjected.Address(RVA = "0x147ECA4", Offset = "0x147ECA4", VA = "0x147ECA4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600450F")]
	[Cpp2IlInjected.Address(RVA = "0x14959BC", Offset = "0x14959BC", VA = "0x14959BC")]
	public void GoToBottom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004510")]
	[Cpp2IlInjected.Address(RVA = "0x147E778", Offset = "0x147E778", VA = "0x147E778")]
	public UIScrollbar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004511")]
	[Cpp2IlInjected.Address(RVA = "0x147E9F0", Offset = "0x147E9F0", VA = "0x147E9F0")]
	public void SetView(float viewSize, float maxViewSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004512")]
	[Cpp2IlInjected.Address(RVA = "0x14959F0", Offset = "0x14959F0", VA = "0x14959F0")]
	public float GetValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004513")]
	[Cpp2IlInjected.Address(RVA = "0x14959F8", Offset = "0x14959F8", VA = "0x14959F8")]
	private Rectangle GetHandleRectangle()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6004514")]
	[Cpp2IlInjected.Address(RVA = "0x1495A94", Offset = "0x1495A94", VA = "0x1495A94")]
	private void DrawBar(SpriteBatch spriteBatch, Texture2D texture, Rectangle dimensions, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004515")]
	[Cpp2IlInjected.Address(RVA = "0x1495DC0", Offset = "0x1495DC0", VA = "0x1495DC0", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004516")]
	[Cpp2IlInjected.Address(RVA = "0x14960D4", Offset = "0x14960D4", VA = "0x14960D4", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004517")]
	[Cpp2IlInjected.Address(RVA = "0x149625C", Offset = "0x149625C", VA = "0x149625C", Slot = "16")]
	public override void LeftMouseUp(UIMouseEvent evt)
	{
	}
}
