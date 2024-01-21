using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Controller;

[Cpp2IlInjected.Token(Token = "0x2000756")]
public class ControllerActionButton
{
	[Cpp2IlInjected.Token(Token = "0x2000AD6")]
	public class RequiredButtonState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008FA4")]
		public Buttons Button;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008FA5")]
		public bool state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008FA6")]
		public Buttons Button2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008FA7")]
		public bool state2;

		[Cpp2IlInjected.Token(Token = "0x6005322")]
		[Cpp2IlInjected.Address(RVA = "0x120A67C", Offset = "0x120A67C", VA = "0x120A67C")]
		public RequiredButtonState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005323")]
		[Cpp2IlInjected.Address(RVA = "0x120A690", Offset = "0x120A690", VA = "0x120A690")]
		public RequiredButtonState(Buttons button, bool requiredState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005324")]
		[Cpp2IlInjected.Address(RVA = "0x120A6C8", Offset = "0x120A6C8", VA = "0x120A6C8")]
		public RequiredButtonState(Buttons button, bool requiredState, Buttons button2, bool requiredState2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005325")]
		[Cpp2IlInjected.Address(RVA = "0x12081AC", Offset = "0x12081AC", VA = "0x12081AC")]
		public bool Active(ControllerDevice device, float buttonPressTime, float axisValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005326")]
		[Cpp2IlInjected.Address(RVA = "0x1207928", Offset = "0x1207928", VA = "0x1207928")]
		public bool Valid(ControllerDevice device, float buttonPressTime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005327")]
		[Cpp2IlInjected.Address(RVA = "0x1208528", Offset = "0x1208528", VA = "0x1208528")]
		public void ConsumeModifiers(ControllerDevice device)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000AD7")]
	public class Entry
	{
		[Cpp2IlInjected.Token(Token = "0x2000BCB")]
		public enum Type
		{
			[Cpp2IlInjected.Token(Token = "0x4009159")]
			Axis,
			[Cpp2IlInjected.Token(Token = "0x400915A")]
			Button,
			[Cpp2IlInjected.Token(Token = "0x400915B")]
			InputKey
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008FA8")]
		public Type MappingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008FA9")]
		public Axis Axis0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008FAA")]
		public float Threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008FAB")]
		public Buttons Button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008FAC")]
		public KeyCode InputKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008FAD")]
		public bool IgnoreOthersIfExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008FAE")]
		public RequiredButtonState RequiredState;

		[Cpp2IlInjected.Token(Token = "0x6005328")]
		[Cpp2IlInjected.Address(RVA = "0x1208A88", Offset = "0x1208A88", VA = "0x1208A88")]
		public Entry()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400738B")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400738C")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x400738D")]
	public bool DisableUnitlClear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400738E")]
	public int DisplayPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400738F")]
	public ControllerActionButton LinkedAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007390")]
	private List<Entry> _entries;

	[Cpp2IlInjected.Token(Token = "0x1700082C")]
	public bool HasMapping
	{
		[Cpp2IlInjected.Token(Token = "0x60047E8")]
		[Cpp2IlInjected.Address(RVA = "0x1208690", Offset = "0x1208690", VA = "0x1208690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700082D")]
	public RequiredButtonState RequiredState
	{
		[Cpp2IlInjected.Token(Token = "0x60047E9")]
		[Cpp2IlInjected.Address(RVA = "0x12086E8", Offset = "0x12086E8", VA = "0x12086E8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700082E")]
	public Entry FirstEntry
	{
		[Cpp2IlInjected.Token(Token = "0x60047EA")]
		[Cpp2IlInjected.Address(RVA = "0x1208750", Offset = "0x1208750", VA = "0x1208750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047EB")]
	[Cpp2IlInjected.Address(RVA = "0x12087B4", Offset = "0x12087B4", VA = "0x12087B4")]
	public Entry GetEntry(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60047EC")]
	[Cpp2IlInjected.Address(RVA = "0x1208828", Offset = "0x1208828", VA = "0x1208828")]
	public bool Conflicts(ControllerActionButton other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047ED")]
	[Cpp2IlInjected.Address(RVA = "0x12089D8", Offset = "0x12089D8", VA = "0x12089D8")]
	public void MapAxis(Axis axis, float threshold, [Optional] RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047EE")]
	[Cpp2IlInjected.Address(RVA = "0x1208A90", Offset = "0x1208A90", VA = "0x1208A90")]
	public void MapButton(Buttons button, [Optional] RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047EF")]
	[Cpp2IlInjected.Address(RVA = "0x1208B30", Offset = "0x1208B30", VA = "0x1208B30")]
	public void MapAxisButton(AxisButtons button, [Optional] RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047F0")]
	[Cpp2IlInjected.Address(RVA = "0x1208BD8", Offset = "0x1208BD8", VA = "0x1208BD8")]
	public void MapKey(KeyCode key, bool ignoreOthersIfExists = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047F1")]
	[Cpp2IlInjected.Address(RVA = "0x1208C70", Offset = "0x1208C70", VA = "0x1208C70")]
	public bool RequiredStateValid(ControllerDevice controller)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047F2")]
	[Cpp2IlInjected.Address(RVA = "0x1208D44", Offset = "0x1208D44", VA = "0x1208D44")]
	public bool GetButtonState(ControllerDevice controller)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047F3")]
	[Cpp2IlInjected.Address(RVA = "0x12094C0", Offset = "0x12094C0", VA = "0x12094C0")]
	public bool GetButtonDown(ControllerDevice controller)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047F4")]
	[Cpp2IlInjected.Address(RVA = "0x1209B58", Offset = "0x1209B58", VA = "0x1209B58")]
	public bool GetButtonUp(ControllerDevice controller)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047F5")]
	[Cpp2IlInjected.Address(RVA = "0x120A594", Offset = "0x120A594", VA = "0x120A594")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047F6")]
	[Cpp2IlInjected.Address(RVA = "0x120A5F0", Offset = "0x120A5F0", VA = "0x120A5F0")]
	public ControllerActionButton()
	{
	}
}
