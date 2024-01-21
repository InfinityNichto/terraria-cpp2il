using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class GUIProfileSwitch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public bool Visible;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	private VirtualControlsHardwareConfigurationMapping_Layout buttonOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	private List<VirtualControlsProfile_Layout> profiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	private float Profile1Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	private float Profile2Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	private float Profile3Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	private float Profile4Scale;

	[Cpp2IlInjected.Token(Token = "0x600091D")]
	[Cpp2IlInjected.Address(RVA = "0xE2D04C", Offset = "0xE2D04C", VA = "0xE2D04C")]
	public void Show(VirtualControlsHardwareConfigurationMapping_Layout origin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091E")]
	[Cpp2IlInjected.Address(RVA = "0xE2D05C", Offset = "0xE2D05C", VA = "0xE2D05C")]
	public void CycleNextProfile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600091F")]
	[Cpp2IlInjected.Address(RVA = "0xE2D258", Offset = "0xE2D258", VA = "0xE2D258")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000920")]
	[Cpp2IlInjected.Address(RVA = "0xE2D430", Offset = "0xE2D430", VA = "0xE2D430")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000921")]
	[Cpp2IlInjected.Address(RVA = "0xE2DB84", Offset = "0xE2DB84", VA = "0xE2DB84")]
	public GUIProfileSwitch()
	{
	}
}
