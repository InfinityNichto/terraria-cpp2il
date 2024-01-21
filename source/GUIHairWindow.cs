using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class GUIHairWindow
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private int Offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private int unlockedMaxHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private float ActionButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public bool DrawSliders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private GUIControllerHairStylist _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private float closeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	private Item _blankItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	private Player clonePlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	private Vector2 CharacterDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	private float hairButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private float colourButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	public float hairScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private float hairScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private int hairScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private Vector2 hairDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private int hairOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	private GUISlider.DragState hueDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	private GUISlider.DragState satDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	private GUISlider.DragState lightDragState;

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x1386868", Offset = "0x1386868", VA = "0x1386868")]
	public void LoadRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x138691C", Offset = "0x138691C", VA = "0x138691C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x138834C", Offset = "0x138834C", VA = "0x138834C")]
	private void DrawCategoryButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x1388FBC", Offset = "0x1388FBC", VA = "0x1388FBC")]
	private void DrawCancelButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x138913C", Offset = "0x138913C", VA = "0x138913C")]
	private void DrawSelectedHair(Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x1389658", Offset = "0x1389658", VA = "0x1389658")]
	public int GetPrice()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x13897E4", Offset = "0x13897E4", VA = "0x13897E4")]
	public void DrawPlayerUI(Player player, Vector2 origin, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x1387FE8", Offset = "0x1387FE8", VA = "0x1387FE8")]
	private void DrawPlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x13897E8", Offset = "0x13897E8", VA = "0x13897E8")]
	public void DrawBuyButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x1389D54", Offset = "0x1389D54", VA = "0x1389D54")]
	public bool IsOverPanel(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x1388B20", Offset = "0x1388B20", VA = "0x1388B20")]
	private void DrawButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x1386F64", Offset = "0x1386F64", VA = "0x1386F64")]
	private void DrawHairGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x1389F68", Offset = "0x1389F68", VA = "0x1389F68")]
	public float HairScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x1389FC4", Offset = "0x1389FC4", VA = "0x1389FC4")]
	public void HairOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x138A164", Offset = "0x138A164", VA = "0x138A164")]
	public void HairDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x138711C", Offset = "0x138711C", VA = "0x138711C")]
	private void DrawHSLSlider()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D7")]
	[Cpp2IlInjected.Address(RVA = "0x138AF64", Offset = "0x138AF64", VA = "0x138AF64")]
	public GUIHairWindow()
	{
	}
}
