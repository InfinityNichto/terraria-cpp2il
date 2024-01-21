using Controller;
using Cpp2IlInjected;
using InControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x200007C")]
public class GUIControllerHardwareProfileEntry : GUIControllerMappingEntryBase
{
	[Cpp2IlInjected.Token(Token = "0x200078F")]
	public enum BindingId
	{
		[Cpp2IlInjected.Token(Token = "0x400792F")]
		LeftStickUp,
		[Cpp2IlInjected.Token(Token = "0x4007930")]
		LeftStickDown,
		[Cpp2IlInjected.Token(Token = "0x4007931")]
		LeftStickLeft,
		[Cpp2IlInjected.Token(Token = "0x4007932")]
		LeftStickRight,
		[Cpp2IlInjected.Token(Token = "0x4007933")]
		RightStickUp,
		[Cpp2IlInjected.Token(Token = "0x4007934")]
		RightStickDown,
		[Cpp2IlInjected.Token(Token = "0x4007935")]
		RightStickLeft,
		[Cpp2IlInjected.Token(Token = "0x4007936")]
		RightStickRight,
		[Cpp2IlInjected.Token(Token = "0x4007937")]
		DPadUp,
		[Cpp2IlInjected.Token(Token = "0x4007938")]
		DPadDown,
		[Cpp2IlInjected.Token(Token = "0x4007939")]
		DPadLeft,
		[Cpp2IlInjected.Token(Token = "0x400793A")]
		DPadRight,
		[Cpp2IlInjected.Token(Token = "0x400793B")]
		Action1,
		[Cpp2IlInjected.Token(Token = "0x400793C")]
		Action2,
		[Cpp2IlInjected.Token(Token = "0x400793D")]
		Action3,
		[Cpp2IlInjected.Token(Token = "0x400793E")]
		Action4,
		[Cpp2IlInjected.Token(Token = "0x400793F")]
		Options,
		[Cpp2IlInjected.Token(Token = "0x4007940")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x4007941")]
		LeftShoulder,
		[Cpp2IlInjected.Token(Token = "0x4007942")]
		LeftTrigger,
		[Cpp2IlInjected.Token(Token = "0x4007943")]
		LeftStickClick,
		[Cpp2IlInjected.Token(Token = "0x4007944")]
		RightShoulder,
		[Cpp2IlInjected.Token(Token = "0x4007945")]
		RightTrigger,
		[Cpp2IlInjected.Token(Token = "0x4007946")]
		RightStickClick,
		[Cpp2IlInjected.Token(Token = "0x4007947")]
		Count
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private readonly ControllerDevice _device;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	public new readonly BindingId _id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	public InputControlMapping Binding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private float buttonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private bool drawingOverlay;

	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private static int LastButtonMapped;

	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private const float inputTollerance = 0.1f;

	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private static float[] InitialInputRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public bool displayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public new KeyboardMappingsCategories_Layout.Category Category;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public new int SortOrder;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool HasMapping
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x129C484", Offset = "0x129C484", VA = "0x129C484")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x129C858", Offset = "0x129C858", VA = "0x129C858")]
	public GUIControllerHardwareProfileEntry(BindingId id, ControllerDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x129B228", Offset = "0x129B228", VA = "0x129B228")]
	public void CloseOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x129CB3C", Offset = "0x129CB3C", VA = "0x129CB3C")]
	private string GetMappingName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x129CB18", Offset = "0x129CB18", VA = "0x129CB18")]
	private InputControlType GetMappingType()
	{
		return default(InputControlType);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x129CD80", Offset = "0x129CD80", VA = "0x129CD80", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x129CDB4", Offset = "0x129CDB4", VA = "0x129CDB4")]
	public void RemoveBinding()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x129CDC0", Offset = "0x129CDC0", VA = "0x129CDC0")]
	private void RemapToAnalogue(int index, float restingValue, float usedValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x129CF14", Offset = "0x129CF14", VA = "0x129CF14")]
	private void RemapToButton(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x129CFE8", Offset = "0x129CFE8", VA = "0x129CFE8")]
	private Texture2D GetTexure(out Rectangle buttonRegion)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x129D9E4", Offset = "0x129D9E4", VA = "0x129D9E4", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x129E5CC", Offset = "0x129E5CC", VA = "0x129E5CC", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x129E62C", Offset = "0x129E62C", VA = "0x129E62C")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}
}
