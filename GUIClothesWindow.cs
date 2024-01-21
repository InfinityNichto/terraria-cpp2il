using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000D2")]
public class GUIClothesWindow
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private float ChangeButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private GUIControllerDresser _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private int[] playerStyles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	private Vector2 CharacterDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private Player clonePlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private Item _blankItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private float closeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private float shirtButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private float underShirtButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private float pantsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private float shoesButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private float eyesButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private float skinButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private float styleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private GUISlider.DragState hueDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private GUISlider.DragState satDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private GUISlider.DragState lightDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private int styleOver;

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0xF85F50", Offset = "0xF85F50", VA = "0xF85F50")]
	public int GetSelectedStyle()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0xF85FC8", Offset = "0xF85FC8", VA = "0xF85FC8")]
	public void LoadRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0xF8607C", Offset = "0xF8607C", VA = "0xF8607C")]
	public bool IsOverPanel(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0xF86290", Offset = "0xF86290", VA = "0xF86290")]
	public string GetTitle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0xF864C8", Offset = "0xF864C8", VA = "0xF864C8")]
	public string GetName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0xF86760", Offset = "0xF86760", VA = "0xF86760")]
	private void DrawPlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0xF86A60", Offset = "0xF86A60", VA = "0xF86A60")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0xF89CE4", Offset = "0xF89CE4", VA = "0xF89CE4")]
	private void DrawButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xF89E5C", Offset = "0xF89E5C", VA = "0xF89E5C")]
	private void DrawCancelButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0xF89FBC", Offset = "0xF89FBC", VA = "0xF89FBC")]
	public void DrawPlayer(Player drawPlayer, Vector2 Position, float rotation, Vector2 rotationOrigin, float shadow = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0xF89FC0", Offset = "0xF89FC0", VA = "0xF89FC0")]
	private void DrawSelectedPlayer(Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0xF89D00", Offset = "0xF89D00", VA = "0xF89D00")]
	public void DrawChangeButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0xF887D4", Offset = "0xF887D4", VA = "0xF887D4")]
	private void DrawCategoryButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0xF87154", Offset = "0xF87154", VA = "0xF87154")]
	private void DrawHSLSlider()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0xF88564", Offset = "0xF88564", VA = "0xF88564")]
	private void DrawStyles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0xF8A15C", Offset = "0xF8A15C", VA = "0xF8A15C")]
	private float StyleScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0xF8A164", Offset = "0xF8A164", VA = "0xF8A164")]
	public void StyleOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0xF8A314", Offset = "0xF8A314", VA = "0xF8A314")]
	public void StyleDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0xF86FAC", Offset = "0xF86FAC", VA = "0xF86FAC")]
	private void ClonePlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0xF8A65C", Offset = "0xF8A65C", VA = "0xF8A65C")]
	public GUIClothesWindow()
	{
	}
}
