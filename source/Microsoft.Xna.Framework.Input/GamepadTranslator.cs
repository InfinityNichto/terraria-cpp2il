using System.Collections.Generic;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x200028D")]
internal class GamepadTranslator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001D50")]
	private Dictionary<string, ButtonType> Data;

	[Cpp2IlInjected.Token(Token = "0x600146D")]
	[Cpp2IlInjected.Address(RVA = "0x155393C", Offset = "0x155393C", VA = "0x155393C")]
	public GamepadTranslator(string config)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600146E")]
	[Cpp2IlInjected.Address(RVA = "0x1553B10", Offset = "0x1553B10", VA = "0x1553B10")]
	public ButtonType Read(string button)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600146F")]
	[Cpp2IlInjected.Address(RVA = "0x1553BC8", Offset = "0x1553BC8", VA = "0x1553BC8")]
	public bool ButtonPressed(string button, JoystickState state)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001470")]
	[Cpp2IlInjected.Address(RVA = "0x1553C3C", Offset = "0x1553C3C", VA = "0x1553C3C")]
	public float AxisPressed(string axis, JoystickState state)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001471")]
	[Cpp2IlInjected.Address(RVA = "0x1553C78", Offset = "0x1553C78", VA = "0x1553C78")]
	public bool DpadPressed(string dpad, JoystickState state)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001472")]
	[Cpp2IlInjected.Address(RVA = "0x1553D7C", Offset = "0x1553D7C", VA = "0x1553D7C")]
	public float TriggerPressed(string trigger, JoystickState state)
	{
		return default(float);
	}
}
