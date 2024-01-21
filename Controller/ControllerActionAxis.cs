using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Controller;

[Cpp2IlInjected.Token(Token = "0x2000755")]
public class ControllerActionAxis
{
	[Cpp2IlInjected.Token(Token = "0x2000AD5")]
	public class Entry
	{
		[Cpp2IlInjected.Token(Token = "0x2000BCA")]
		public enum Type
		{
			[Cpp2IlInjected.Token(Token = "0x4009154")]
			SingleAxis,
			[Cpp2IlInjected.Token(Token = "0x4009155")]
			MultipleAxis,
			[Cpp2IlInjected.Token(Token = "0x4009156")]
			Buttons,
			[Cpp2IlInjected.Token(Token = "0x4009157")]
			Keys
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008F9B")]
		public Type MappingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008F9C")]
		public Axis Axis0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008F9D")]
		public Axis Axis1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008F9E")]
		public float Threshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008F9F")]
		public Buttons Button0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008FA0")]
		public Buttons Button1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008FA1")]
		public KeyCode Key0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008FA2")]
		public KeyCode Key1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008FA3")]
		public ControllerActionButton.RequiredButtonState RequiredState;

		[Cpp2IlInjected.Token(Token = "0x6005321")]
		[Cpp2IlInjected.Address(RVA = "0x1208340", Offset = "0x1208340", VA = "0x1208340")]
		public Entry()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4007385")]
	public static float ElapsedTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007386")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007387")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4007388")]
	public bool TimeBased;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007389")]
	public float Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400738A")]
	private List<Entry> _entries;

	[Cpp2IlInjected.Token(Token = "0x17000829")]
	public bool HasMapping
	{
		[Cpp2IlInjected.Token(Token = "0x60047DB")]
		[Cpp2IlInjected.Address(RVA = "0x1207748", Offset = "0x1207748", VA = "0x1207748")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700082A")]
	public ControllerActionButton.RequiredButtonState RequiredState
	{
		[Cpp2IlInjected.Token(Token = "0x60047DE")]
		[Cpp2IlInjected.Address(RVA = "0x120784C", Offset = "0x120784C", VA = "0x120784C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700082B")]
	public Entry FirstEntry
	{
		[Cpp2IlInjected.Token(Token = "0x60047DF")]
		[Cpp2IlInjected.Address(RVA = "0x12078B4", Offset = "0x12078B4", VA = "0x12078B4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60047DC")]
	[Cpp2IlInjected.Address(RVA = "0x12077A0", Offset = "0x12077A0", VA = "0x12077A0")]
	public bool RequiredStateValid(ControllerDevice controller)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047DD")]
	[Cpp2IlInjected.Address(RVA = "0x1207A44", Offset = "0x1207A44", VA = "0x1207A44")]
	public bool Active(ControllerDevice controller)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60047E0")]
	[Cpp2IlInjected.Address(RVA = "0x1208298", Offset = "0x1208298", VA = "0x1208298")]
	public void MapAxis(Axis axis, float threshold = 0f, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047E1")]
	[Cpp2IlInjected.Address(RVA = "0x1208348", Offset = "0x1208348", VA = "0x1208348")]
	public void MapMultipleAxis(Axis axis1, Axis axis2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047E2")]
	[Cpp2IlInjected.Address(RVA = "0x12083E0", Offset = "0x12083E0", VA = "0x12083E0")]
	public void MapButtons(Buttons button0, Buttons button1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047E3")]
	[Cpp2IlInjected.Address(RVA = "0x1208478", Offset = "0x1208478", VA = "0x1208478")]
	public void MapKeys(KeyCode key0, KeyCode key1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047E4")]
	[Cpp2IlInjected.Address(RVA = "0x1207B28", Offset = "0x1207B28", VA = "0x1207B28")]
	public float GetValue(ControllerDevice controller)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60047E5")]
	[Cpp2IlInjected.Address(RVA = "0x120859C", Offset = "0x120859C", VA = "0x120859C")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60047E6")]
	[Cpp2IlInjected.Address(RVA = "0x12085F8", Offset = "0x12085F8", VA = "0x12085F8")]
	public ControllerActionAxis()
	{
	}
}
