using System.Collections.Generic;
using Cpp2IlInjected;
using InControl;

namespace Controller;

[Cpp2IlInjected.Token(Token = "0x200075C")]
public class ControllerDeviceManager : Singleton<ControllerDeviceManager>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40073C9")]
	private int lastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40073CA")]
	public List<ControllerDevice> AttachedDevices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40073CB")]
	private List<ControllerDevice> _deviceUpdateList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40073CC")]
	private List<UnityInputDevice> _joyConUpdateList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40073CD")]
	public List<ControllerDevice> UnconfiguredList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40073CE")]
	private List<ControllerDevice> _unconfiguredUpdateList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40073CF")]
	public List<ControllerDevice> ActiveControllers;

	[Cpp2IlInjected.Token(Token = "0x6004810")]
	[Cpp2IlInjected.Address(RVA = "0x120CCF0", Offset = "0x120CCF0", VA = "0x120CCF0")]
	public void UpdateConnectedControllers(float elapsedTime, bool forceUpdate = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004811")]
	[Cpp2IlInjected.Address(RVA = "0x120D54C", Offset = "0x120D54C", VA = "0x120D54C")]
	private void UpdateDevices(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004812")]
	[Cpp2IlInjected.Address(RVA = "0x120D718", Offset = "0x120D718", VA = "0x120D718")]
	public ControllerDeviceManager()
	{
	}
}
