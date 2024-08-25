using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Localization;

[global::Cpp2ILInjected.Token(Token = "0x200024B")]
[Serializable]
public class VirtualControlsHardwareConfiguration_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D38")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5BE8", Offset = "0x9D5BE8", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit.BackupResotrePoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(VirtualControlsProfile_Layout)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfigurationMapping_Layout), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfigurationMapping_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfigurationMapping_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Copy(VirtualControlsHardwareConfiguration_Layout other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D39")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5D1C", Offset = "0x9D5D1C", Length = "0x228")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "HasUndo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsHardwareConfigurationMapping_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfigurationMapping_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public bool IsSame(VirtualControlsHardwareConfiguration_Layout other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D3A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5F44", Offset = "0x9D5F44", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "SetActiveProfile", MemberParameters = new object[] { typeof(VirtualControlsProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "SetPageControlsAndAdjust", MemberParameters = new object[] { typeof(GUIPageIcons.PageControlsType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void LoadControlPositions()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D3B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D604C", Offset = "0x9D604C", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawHardware", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public string GetDisplayName()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D3C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D60D0", Offset = "0x9D60D0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit.BackupResotrePoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(VirtualControlsProfile_Layout)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsHardwareConfiguration_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001844")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	[global::Cpp2ILInjected.Token(Token = "0x4001845")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string EditedName;

	[global::Cpp2ILInjected.Token(Token = "0x4001846")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 LeftPagePosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001847")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 LeftControlsPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001848")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 RightPagePosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001849")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 RightControlsPosition;

	[global::Cpp2ILInjected.Token(Token = "0x400184A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 SettingsPosition;

	[global::Cpp2ILInjected.Token(Token = "0x400184B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 MenuPosition;

	[global::Cpp2ILInjected.Token(Token = "0x400184C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIPageIcons.PageControlsType PageControls;

	[global::Cpp2ILInjected.Token(Token = "0x400184D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public VirtualControlsHardwareConfigurationMapping_Layout[] Slots;
}
