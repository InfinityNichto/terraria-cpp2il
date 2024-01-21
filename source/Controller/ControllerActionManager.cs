using System.Collections.Generic;
using Cpp2IlInjected;

namespace Controller;

[Cpp2IlInjected.Token(Token = "0x200075B")]
public class ControllerActionManager
{
	[Cpp2IlInjected.Token(Token = "0x40073BF")]
	public static ControllerActionManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40073C0")]
	private List<ControllerActionAxis> _axisMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40073C1")]
	private List<ControllerActionButton> _buttonMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40073C2")]
	private List<ControllerActionVector> _vectorMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40073C3")]
	private ControllerDevice _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40073C4")]
	private bool _controllerActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40073C5")]
	private ControllerDevice _forcedActiveController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40073C6")]
	private bool _pendingDisableActions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40073C7")]
	private string[] _pendingDisableActionsList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40073C8")]
	private bool _pendingEnableActions;

	[Cpp2IlInjected.Token(Token = "0x17000835")]
	public bool HasController
	{
		[Cpp2IlInjected.Token(Token = "0x600480A")]
		[Cpp2IlInjected.Address(RVA = "0x120AD68", Offset = "0x120AD68", VA = "0x120AD68")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000836")]
	public bool IsControllerActive
	{
		[Cpp2IlInjected.Token(Token = "0x600480B")]
		[Cpp2IlInjected.Address(RVA = "0x120AE24", Offset = "0x120AE24", VA = "0x120AE24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000837")]
	public ControllerDevice ActiveController
	{
		[Cpp2IlInjected.Token(Token = "0x600480E")]
		[Cpp2IlInjected.Address(RVA = "0x120B2C0", Offset = "0x120B2C0", VA = "0x120B2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000838")]
	public static bool AnyControllerConnected
	{
		[Cpp2IlInjected.Token(Token = "0x600480F")]
		[Cpp2IlInjected.Address(RVA = "0x1201468", Offset = "0x1201468", VA = "0x1201468")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004801")]
	[Cpp2IlInjected.Address(RVA = "0x120A724", Offset = "0x120A724", VA = "0x120A724")]
	public static ControllerActionManager Create()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004802")]
	[Cpp2IlInjected.Address(RVA = "0x1208B98", Offset = "0x1208B98", VA = "0x1208B98")]
	public static Axis GetAxisThreshold(AxisButtons button, out float threshold)
	{
		return default(Axis);
	}

	[Cpp2IlInjected.Token(Token = "0x6004803")]
	[Cpp2IlInjected.Address(RVA = "0x120A790", Offset = "0x120A790", VA = "0x120A790")]
	public ControllerActionManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004804")]
	[Cpp2IlInjected.Address(RVA = "0x120A8BC", Offset = "0x120A8BC", VA = "0x120A8BC")]
	public ControllerActionButton CreateButtonMapping(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004805")]
	[Cpp2IlInjected.Address(RVA = "0x120A96C", Offset = "0x120A96C", VA = "0x120A96C")]
	public ControllerActionAxis CreateAxisMapping(string id, bool timeBased, float axisScale)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004806")]
	[Cpp2IlInjected.Address(RVA = "0x120AA0C", Offset = "0x120AA0C", VA = "0x120AA0C")]
	public ControllerActionVector CreateVectorMapping(string id, ControllerActionAxis axisX, ControllerActionAxis axisY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004807")]
	[Cpp2IlInjected.Address(RVA = "0x120AAEC", Offset = "0x120AAEC", VA = "0x120AAEC")]
	public ControllerActionAxis GetAxisMapping(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004808")]
	[Cpp2IlInjected.Address(RVA = "0x120ABC0", Offset = "0x120ABC0", VA = "0x120ABC0")]
	public ControllerActionButton GetButtonMapping(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004809")]
	[Cpp2IlInjected.Address(RVA = "0x120AC94", Offset = "0x120AC94", VA = "0x120AC94")]
	public ControllerActionVector GetVectorMapping(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600480C")]
	[Cpp2IlInjected.Address(RVA = "0x120AE2C", Offset = "0x120AE2C", VA = "0x120AE2C")]
	public void ForceActiveController(ControllerDevice controller)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600480D")]
	[Cpp2IlInjected.Address(RVA = "0x120AE38", Offset = "0x120AE38", VA = "0x120AE38")]
	public void OnUpdate(float elapsedTime)
	{
	}
}
