using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000108")]
public class GUIWiresUI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400083C")]
	private int hoverItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400083D")]
	public Vector2 PopupPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400083E")]
	private float[] ButtonScales;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400083F")]
	private float TimeSinceChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000840")]
	private float ToggleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000841")]
	public bool DisplayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000842")]
	public GUIControllerWiresUI _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000843")]
	public GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x12AF538", Offset = "0x12AF538", VA = "0x12AF538")]
	public GUIWiresUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x12AF6D8", Offset = "0x12AF6D8", VA = "0x12AF6D8")]
	public void PlayerMenuDisplayToggle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x12AFAFC", Offset = "0x12AFAFC", VA = "0x12AFAFC")]
	private Vector2 ClampPositionToScreen(Vector2 position)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x12B020C", Offset = "0x12B020C", VA = "0x12B020C")]
	private float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x12B0214", Offset = "0x12B0214", VA = "0x12B0214")]
	private void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x12B021C", Offset = "0x12B021C", VA = "0x12B021C")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int i, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x12AF960", Offset = "0x12AF960", VA = "0x12AF960")]
	private bool CanInteract()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x12B0A54", Offset = "0x12B0A54", VA = "0x12B0A54")]
	public void DrawCursor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x12B1738", Offset = "0x12B1738", VA = "0x12B1738")]
	public void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x12B1DE8", Offset = "0x12B1DE8", VA = "0x12B1DE8")]
	public void DrawButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x12B0AF0", Offset = "0x12B0AF0", VA = "0x12B0AF0")]
	private void DrawCursorArea(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x12AFE6C", Offset = "0x12AFE6C", VA = "0x12AFE6C")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x12B1DEC", Offset = "0x12B1DEC", VA = "0x12B1DEC")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x12AFF68", Offset = "0x12AFF68", VA = "0x12AFF68")]
	private Rectangle CalculateRegion()
	{
		return default(Rectangle);
	}
}
