using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public class VirtualControlsHardwareConfiguration_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001375")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001376")]
	public string EditedName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001377")]
	public Vector2 LeftPagePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001378")]
	public Vector2 LeftControlsPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001379")]
	public Vector2 RightPagePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400137A")]
	public Vector2 RightControlsPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400137B")]
	public Vector2 SettingsPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400137C")]
	public Vector2 MenuPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400137D")]
	public GUIPageIcons.PageControlsType PageControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400137E")]
	public VirtualControlsHardwareConfigurationMapping_Layout[] Slots;

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0xE8CFF8", Offset = "0xE8CFF8", VA = "0xE8CFF8")]
	public void Copy(VirtualControlsHardwareConfiguration_Layout other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0xE8D160", Offset = "0xE8D160", VA = "0xE8D160")]
	public bool IsSame(VirtualControlsHardwareConfiguration_Layout other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0xE8D490", Offset = "0xE8D490", VA = "0xE8D490")]
	public void LoadControlPositions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0xE8D5CC", Offset = "0xE8D5CC", VA = "0xE8D5CC")]
	public string GetDisplayName()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0xE8D654", Offset = "0xE8D654", VA = "0xE8D654")]
	public VirtualControlsHardwareConfiguration_Layout()
	{
	}
}
