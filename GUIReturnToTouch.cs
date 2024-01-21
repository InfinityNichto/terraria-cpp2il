using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000FF")]
public class GUIReturnToTouch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000788")]
	public bool displayPopup;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000789")]
	private GUIInputRegionExclusive _displayBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400078A")]
	private float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400078B")]
	private GUIControllerModalResponse _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400078C")]
	private GUIControllerItem _previous;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public bool Visible
	{
		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x1158EF8", Offset = "0x1158EF8", VA = "0x1158EF8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x1158378", Offset = "0x1158378", VA = "0x1158378")]
	private bool IsOverPanel(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x1158380", Offset = "0x1158380", VA = "0x1158380")]
	public void Draw(bool inBatch = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x1158FE4", Offset = "0x1158FE4", VA = "0x1158FE4")]
	public void DrawHUD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x1159314", Offset = "0x1159314", VA = "0x1159314")]
	public GUIReturnToTouch()
	{
	}
}
