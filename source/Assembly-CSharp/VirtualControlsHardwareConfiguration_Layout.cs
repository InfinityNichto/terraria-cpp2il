using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Localization;

// Token: 0x020001B9 RID: 441
[global::Cpp2ILInjected.Token(Token = "0x200024B")]
[Serializable]
public class VirtualControlsHardwareConfiguration_Layout
{
	// Token: 0x06000C1E RID: 3102 RVA: 0x00023F9F File Offset: 0x0002219F
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

	// Token: 0x06000C1F RID: 3103 RVA: 0x00023FA2 File Offset: 0x000221A2
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

	// Token: 0x06000C20 RID: 3104 RVA: 0x00023FA5 File Offset: 0x000221A5
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

	// Token: 0x06000C21 RID: 3105 RVA: 0x00023FA8 File Offset: 0x000221A8
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

	// Token: 0x06000C22 RID: 3106 RVA: 0x00023FAB File Offset: 0x000221AB
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

	// Token: 0x0400136C RID: 4972
	[global::Cpp2ILInjected.Token(Token = "0x4001844")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	// Token: 0x0400136D RID: 4973
	[global::Cpp2ILInjected.Token(Token = "0x4001845")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string EditedName;

	// Token: 0x0400136E RID: 4974
	[global::Cpp2ILInjected.Token(Token = "0x4001846")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 LeftPagePosition;

	// Token: 0x0400136F RID: 4975
	[global::Cpp2ILInjected.Token(Token = "0x4001847")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 LeftControlsPosition;

	// Token: 0x04001370 RID: 4976
	[global::Cpp2ILInjected.Token(Token = "0x4001848")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 RightPagePosition;

	// Token: 0x04001371 RID: 4977
	[global::Cpp2ILInjected.Token(Token = "0x4001849")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Vector2 RightControlsPosition;

	// Token: 0x04001372 RID: 4978
	[global::Cpp2ILInjected.Token(Token = "0x400184A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 SettingsPosition;

	// Token: 0x04001373 RID: 4979
	[global::Cpp2ILInjected.Token(Token = "0x400184B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 MenuPosition;

	// Token: 0x04001374 RID: 4980
	[global::Cpp2ILInjected.Token(Token = "0x400184C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIPageIcons.PageControlsType PageControls;

	// Token: 0x04001375 RID: 4981
	[global::Cpp2ILInjected.Token(Token = "0x400184D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public VirtualControlsHardwareConfigurationMapping_Layout[] Slots;
}
