using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000051")]
public class GUIControllerMappingStateTable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public GUIControllerMappingState Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public GUIControllerMappingState Left;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public GUIControllerMappingState Right;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public GUIControllerMappingState BackupNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public GUIControllerMappingState BackupLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public GUIControllerMappingState BackupRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private GUIControllerMappingStateTable LinkedChildState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private List<GUIControllerMappingStateTable> LinkedParentStates;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xF6F784", Offset = "0xF6F784", VA = "0xF6F784")]
	public GUIControllerMappingStateTable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xF73A60", Offset = "0xF73A60", VA = "0xF73A60")]
	public bool IsAnyLeftButtonConflict(Buttons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xF73B20", Offset = "0xF73B20", VA = "0xF73B20")]
	public bool IsAnyRightButtonConflict(Buttons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xF73BE0", Offset = "0xF73BE0", VA = "0xF73BE0")]
	public bool IsAnyLeftAxisButtonConflict(AxisButtons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xF73CD4", Offset = "0xF73CD4", VA = "0xF73CD4")]
	public bool IsAnyRightAxisButtonConflict(AxisButtons button)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xF73DC8", Offset = "0xF73DC8", VA = "0xF73DC8")]
	public bool IsAnyLeftAxisConflict(Axis axis)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xF73F3C", Offset = "0xF73F3C", VA = "0xF73F3C")]
	public bool IsAnyRightAxisConflict(Axis axis)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xF75150", Offset = "0xF75150", VA = "0xF75150")]
	public void Backup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xF75184", Offset = "0xF75184", VA = "0xF75184")]
	public void RestoreBackup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xF751B8", Offset = "0xF751B8", VA = "0xF751B8")]
	public void ClearMappings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xF75264", Offset = "0xF75264", VA = "0xF75264")]
	public void LoadMappingValues()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xF7531C", Offset = "0xF7531C", VA = "0xF7531C")]
	public void TransferMapping(ControllerActionButton button, GUIControllerMappingStateTable other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xF75360", Offset = "0xF75360", VA = "0xF75360")]
	public void SaveConfiguration(string configurationTable, Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xF7543C", Offset = "0xF7543C", VA = "0xF7543C")]
	public void LoadConfiguration(string configurationTable, Preferences preferences, ref bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xF75550", Offset = "0xF75550", VA = "0xF75550")]
	public bool IsSame(GUIControllerMappingStateTable other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xF755A0", Offset = "0xF755A0", VA = "0xF755A0")]
	public void Copy(GUIControllerMappingStateTable other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xF6F904", Offset = "0xF6F904", VA = "0xF6F904")]
	public void SetChildState(GUIControllerMappingStateTable childState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xF755D8", Offset = "0xF755D8", VA = "0xF755D8")]
	public void DisableConflictingActions(GUIControllerMappingStateTable other, bool altDisableFaceBindings = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xF6B864", Offset = "0xF6B864", VA = "0xF6B864")]
	public GUIControllerMappingState GetState(int stateIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xF6C620", Offset = "0xF6C620", VA = "0xF6C620")]
	public void ClearLinkedButtonBindings(int stateIndex, Buttons button, [Optional] List<ControllerActionButton> allowedActions)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xF6B454", Offset = "0xF6B454", VA = "0xF6B454")]
	public void ClearLinkedAxisBindings(int stateIndex, Axis x, Axis y, bool tableOnly = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xF6BD80", Offset = "0xF6BD80", VA = "0xF6BD80")]
	public void ClearLinkedButtonBindings(int stateIndex, AxisButtons axisButton, [Optional] List<ControllerActionButton> allowedActions, bool tableOnly = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xF6B200", Offset = "0xF6B200", VA = "0xF6B200")]
	public void RemoveButtonBindings(ControllerActionButton actionButton)
	{
	}
}
