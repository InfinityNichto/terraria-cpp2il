using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200004E")]
public class GUIControllerMappingEntry : GUIControllerMappingEntryBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private GUIControllerMappingStateTable Table;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private ControllerActionVector vector;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private ControllerActionButton button;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private GUIControllerMappingState _state;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private float buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool drawingOverlay;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static int LastButtonMapped;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public bool displayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool HasMapping
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF6B0D0", Offset = "0xF6B0D0", VA = "0xF6B0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0xF6AF88", Offset = "0xF6AF88", VA = "0xF6AF88")]
	public GUIControllerMappingEntry(ControllerActionVector action, GUIControllerMappingStateTable table)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0xF6B030", Offset = "0xF6B030", VA = "0xF6B030")]
	public GUIControllerMappingEntry(ControllerActionButton buttonMapping, GUIControllerMappingStateTable table)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0xF6B100", Offset = "0xF6B100", VA = "0xF6B100", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0xF6B134", Offset = "0xF6B134", VA = "0xF6B134")]
	public void RemoveBinding()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0xF6B16C", Offset = "0xF6B16C", VA = "0xF6B16C")]
	private void RemoveAxisBindings(ControllerActionVector actionAxis)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xF6B2AC", Offset = "0xF6B2AC", VA = "0xF6B2AC")]
	private void RebindAxis(ControllerActionVector actionAxis, Axis x, Axis y, int stateIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0xF6B888", Offset = "0xF6B888", VA = "0xF6B888")]
	private void RebindButton(ControllerActionButton actionButton, AxisButtons axisButton, int stateIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0xF6C144", Offset = "0xF6C144", VA = "0xF6C144")]
	private void RebindButton(ControllerActionButton actionButton, Buttons axisButton, int stateIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0xF6CA08", Offset = "0xF6CA08", VA = "0xF6CA08", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0xF6E34C", Offset = "0xF6E34C", VA = "0xF6E34C", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0xF6E3AC", Offset = "0xF6E3AC", VA = "0xF6E3AC")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0xF6DDC4", Offset = "0xF6DDC4", VA = "0xF6DDC4")]
	private string GetTitle()
	{
		return null;
	}
}
