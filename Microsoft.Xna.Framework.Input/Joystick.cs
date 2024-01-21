using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Input;

[Cpp2IlInjected.Token(Token = "0x200028E")]
public static class Joystick
{
	[Cpp2IlInjected.Token(Token = "0x4001D51")]
	private const bool PlatformIsSupported = false;

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public static bool IsSupported
	{
		[Cpp2IlInjected.Token(Token = "0x6001475")]
		[Cpp2IlInjected.Address(RVA = "0x1553F28", Offset = "0x1553F28", VA = "0x1553F28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001473")]
	[Cpp2IlInjected.Address(RVA = "0x1553E68", Offset = "0x1553E68", VA = "0x1553E68")]
	private static JoystickCapabilities PlatformGetCapabilities(int index)
	{
		return default(JoystickCapabilities);
	}

	[Cpp2IlInjected.Token(Token = "0x6001474")]
	[Cpp2IlInjected.Address(RVA = "0x1553E84", Offset = "0x1553E84", VA = "0x1553E84")]
	private static JoystickState PlatformGetState(int index)
	{
		return default(JoystickState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001476")]
	[Cpp2IlInjected.Address(RVA = "0x1553F30", Offset = "0x1553F30", VA = "0x1553F30")]
	public static JoystickCapabilities GetCapabilities(int index)
	{
		return default(JoystickCapabilities);
	}

	[Cpp2IlInjected.Token(Token = "0x6001477")]
	[Cpp2IlInjected.Address(RVA = "0x1553F4C", Offset = "0x1553F4C", VA = "0x1553F4C")]
	public static JoystickState GetState(int index)
	{
		return default(JoystickState);
	}
}
