using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GUIControllerMappingState
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public ControllerActionButton.RequiredButtonState RequiredState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public ControllerActionButton[] ButtonBindings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public ControllerActionButton[] AxisButtonBindings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public ControllerActionAxis[] AxisBindings;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xF7324C", Offset = "0xF7324C", VA = "0xF7324C")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xF732A4", Offset = "0xF732A4", VA = "0xF732A4")]
	public bool IsSame(GUIControllerMappingState other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xF7334C", Offset = "0xF7334C", VA = "0xF7334C")]
	public void DisableConflictingActions(GUIControllerMappingState other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xF73510", Offset = "0xF73510", VA = "0xF73510")]
	public void SetupWorldRequiredStateOverloads(GUIControllerMappingStateTable altStates)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xF740B0", Offset = "0xF740B0", VA = "0xF740B0")]
	public void Copy(GUIControllerMappingState other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xF741A8", Offset = "0xF741A8", VA = "0xF741A8")]
	public void LoadConfiguration(string prefix, Preferences preferences, ref bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xF74900", Offset = "0xF74900", VA = "0xF74900")]
	public void TransferMapping(ControllerActionButton mapping, GUIControllerMappingState other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xF749D8", Offset = "0xF749D8", VA = "0xF749D8")]
	public void SaveConfiguration(string prefix, Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xF74C8C", Offset = "0xF74C8C", VA = "0xF74C8C")]
	public void SetupMappings(GUIControllerMappingStateTable altStates)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xF750B8", Offset = "0xF750B8", VA = "0xF750B8")]
	public GUIControllerMappingState()
	{
	}
}
