using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000113")]
public class GUIKeyboardMappingEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000880")]
	private ControllerActionButton buttonAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000881")]
	private ControllerActionVector axisAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000882")]
	private int actionIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000883")]
	private KeyCode backupBinding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000884")]
	private readonly string localisationId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000885")]
	private float buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000886")]
	private float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000887")]
	private bool drawingOverlay;

	[Cpp2IlInjected.Token(Token = "0x4000888")]
	private static int LastButtonMapped;

	[Cpp2IlInjected.Token(Token = "0x4000889")]
	private static bool ignoreClick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400088A")]
	public bool displayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400088B")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400088C")]
	public KeyboardMappingsCategories_Layout.Category Category;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400088D")]
	public int SortOrder;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public KeyCode Binding
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0xDE99C4", Offset = "0xDE99C4", VA = "0xDE99C4")]
		get
		{
			return default(KeyCode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0xDE9A4C", Offset = "0xDE9A4C", VA = "0xDE9A4C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool HasMapping
	{
		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0xDE9BB8", Offset = "0xDE9BB8", VA = "0xDE9BB8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0xDE988C", Offset = "0xDE988C", VA = "0xDE988C")]
	public GUIKeyboardMappingEntry(ControllerActionVector action, int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0xDE99AC", Offset = "0xDE99AC", VA = "0xDE99AC")]
	public void Backup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0xDE9A44", Offset = "0xDE9A44", VA = "0xDE9A44")]
	public void Restore()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xDE9AD0", Offset = "0xDE9AD0", VA = "0xDE9AD0")]
	public GUIKeyboardMappingEntry(ControllerActionButton action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0xDE9BD0", Offset = "0xDE9BD0", VA = "0xDE9BD0")]
	public void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0xDEA8A8", Offset = "0xDEA8A8", VA = "0xDEA8A8")]
	public void RemoveBinding()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0xDE9BF8", Offset = "0xDE9BF8", VA = "0xDE9BF8")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0xDEABEC", Offset = "0xDEABEC", VA = "0xDEABEC")]
	public float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xDEAC4C", Offset = "0xDEAC4C", VA = "0xDEAC4C")]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0xDEA9C4", Offset = "0xDEA9C4", VA = "0xDEA9C4")]
	private string GetTitle()
	{
		return null;
	}
}
