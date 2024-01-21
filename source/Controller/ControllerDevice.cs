using Cpp2IlInjected;
using InControl;

namespace Controller;

[Cpp2IlInjected.Token(Token = "0x200075D")]
public class ControllerDevice
{
	[Cpp2IlInjected.Token(Token = "0x2000AD8")]
	public enum ControlScheme
	{
		[Cpp2IlInjected.Token(Token = "0x4008FB0")]
		CONTROLS_1234,
		[Cpp2IlInjected.Token(Token = "0x4008FB1")]
		CONTROLS_ABXY_GREY,
		[Cpp2IlInjected.Token(Token = "0x4008FB2")]
		CONTROLS_ABXY_XBOX,
		[Cpp2IlInjected.Token(Token = "0x4008FB3")]
		CONTROLS_OUYA,
		[Cpp2IlInjected.Token(Token = "0x4008FB4")]
		CONTROLS_PS4,
		[Cpp2IlInjected.Token(Token = "0x4008FB5")]
		CONTROLS_ABXY_STEELSERIES,
		[Cpp2IlInjected.Token(Token = "0x4008FB6")]
		CONTROLS_SWITCH,
		[Cpp2IlInjected.Token(Token = "0x4008FB7")]
		CONTROLS_STADIA
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40073D0")]
	public ControlScheme Controls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40073D1")]
	public InputDevice Device;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40073D2")]
	public InputDevice Device2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40073D3")]
	private readonly float[] AxisValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40073D4")]
	private readonly float[] AxisValueScaled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40073D5")]
	private readonly float[] PreviousAxisValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40073D6")]
	private readonly float[] PreviousAxisValueScaled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40073D7")]
	private readonly float[] _AxisTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40073D8")]
	private readonly float[] _KeyTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40073D9")]
	private readonly bool[] _KeyState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40073DA")]
	private readonly bool[] _KeyConsumed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40073DB")]
	private readonly bool[] _PreviousKeyState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40073DC")]
	private readonly bool[] _KeyStateUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40073DD")]
	private readonly bool[] _KeyStateDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40073DE")]
	private readonly float[] _fakedAxisValues;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40073DF")]
	private readonly bool[] _fakedDeviceButtons;

	[Cpp2IlInjected.Token(Token = "0x17000839")]
	public static bool SwapBumpersTriggers
	{
		[Cpp2IlInjected.Token(Token = "0x6004813")]
		[Cpp2IlInjected.Address(RVA = "0x120B908", Offset = "0x120B908", VA = "0x120B908")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6004814")]
		[Cpp2IlInjected.Address(RVA = "0x120B984", Offset = "0x120B984", VA = "0x120B984")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004815")]
	[Cpp2IlInjected.Address(RVA = "0x120BA04", Offset = "0x120BA04", VA = "0x120BA04")]
	public ControllerDevice(InputDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004816")]
	[Cpp2IlInjected.Address(RVA = "0x120BFBC", Offset = "0x120BFBC", VA = "0x120BFBC")]
	public ControllerDevice(InputDevice leftDevice, InputDevice rightDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004817")]
	[Cpp2IlInjected.Address(RVA = "0x120C0EC", Offset = "0x120C0EC", VA = "0x120C0EC")]
	public ControllerDevice()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004818")]
	[Cpp2IlInjected.Address(RVA = "0x1208510", Offset = "0x1208510", VA = "0x1208510")]
	public bool HasAxis(Axis axis)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004819")]
	[Cpp2IlInjected.Address(RVA = "0x1208584", Offset = "0x1208584", VA = "0x1208584")]
	public bool HasButton(Buttons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600481A")]
	[Cpp2IlInjected.Address(RVA = "0x1208518", Offset = "0x1208518", VA = "0x1208518")]
	public float GetAxis(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600481B")]
	[Cpp2IlInjected.Address(RVA = "0x1207918", Offset = "0x1207918", VA = "0x1207918")]
	public float GetAxisTime(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600481C")]
	[Cpp2IlInjected.Address(RVA = "0x1208574", Offset = "0x1208574", VA = "0x1208574")]
	public float GetAxisScaled(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600481D")]
	[Cpp2IlInjected.Address(RVA = "0x12094A0", Offset = "0x12094A0", VA = "0x12094A0")]
	public float GetPreviousAxis(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600481E")]
	[Cpp2IlInjected.Address(RVA = "0x120C224", Offset = "0x120C224", VA = "0x120C224")]
	public float GetPreviousAxisScaled(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600481F")]
	[Cpp2IlInjected.Address(RVA = "0x1208D34", Offset = "0x1208D34", VA = "0x1208D34")]
	public float ButtonTime(Buttons key)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6004820")]
	[Cpp2IlInjected.Address(RVA = "0x120A584", Offset = "0x120A584", VA = "0x120A584")]
	public bool ButtonConsumed(Buttons key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004821")]
	[Cpp2IlInjected.Address(RVA = "0x120A710", Offset = "0x120A710", VA = "0x120A710")]
	public void SetButtonConsumbed(Buttons key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004822")]
	[Cpp2IlInjected.Address(RVA = "0x120858C", Offset = "0x120858C", VA = "0x120858C")]
	public bool ButtonState(Buttons key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004823")]
	[Cpp2IlInjected.Address(RVA = "0x12094B0", Offset = "0x12094B0", VA = "0x12094B0")]
	public bool PreviousButtonState(Buttons key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004824")]
	[Cpp2IlInjected.Address(RVA = "0x120A574", Offset = "0x120A574", VA = "0x120A574")]
	public bool ButtonUp(Buttons key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004825")]
	[Cpp2IlInjected.Address(RVA = "0x1209B48", Offset = "0x1209B48", VA = "0x1209B48")]
	public bool ButtonDown(Buttons key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004826")]
	[Cpp2IlInjected.Address(RVA = "0x120C234", Offset = "0x120C234", VA = "0x120C234")]
	public void SetFakedButton(Buttons key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004827")]
	[Cpp2IlInjected.Address(RVA = "0x120C248", Offset = "0x120C248", VA = "0x120C248")]
	public void SetFakedAxis(Axis axis, float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004828")]
	[Cpp2IlInjected.Address(RVA = "0x120C258", Offset = "0x120C258", VA = "0x120C258")]
	public void ResetState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004829")]
	[Cpp2IlInjected.Address(RVA = "0x120C314", Offset = "0x120C314", VA = "0x120C314")]
	public bool Update(float elapsedTime)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600482A")]
	[Cpp2IlInjected.Address(RVA = "0x120C730", Offset = "0x120C730", VA = "0x120C730")]
	private float GetAxisRaw(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600482B")]
	[Cpp2IlInjected.Address(RVA = "0x120C7F8", Offset = "0x120C7F8", VA = "0x120C7F8")]
	private float GetAxisRaw2(Axis axis)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600482C")]
	[Cpp2IlInjected.Address(RVA = "0x120C928", Offset = "0x120C928", VA = "0x120C928")]
	private bool GetKeyRaw(Buttons key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600482D")]
	[Cpp2IlInjected.Address(RVA = "0x120CBA0", Offset = "0x120CBA0", VA = "0x120CBA0")]
	private bool GetKeyRaw2(Buttons key)
	{
		return default(bool);
	}
}
