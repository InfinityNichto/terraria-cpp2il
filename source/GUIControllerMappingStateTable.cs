using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

// Token: 0x02000052 RID: 82
[global::Cpp2ILInjected.Token(Token = "0x200007C")]
public class GUIControllerMappingStateTable
{
	// Token: 0x0600022B RID: 555 RVA: 0x000221D2 File Offset: 0x000203D2
	[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BB918", Offset = "0x9BB918", Length = "0x19C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerMappingProfile), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 50)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public GUIControllerMappingStateTable()
	{
		throw null;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000221D5 File Offset: 0x000203D5
	[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BBAB4", Offset = "0x9BBAB4", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupUIMappingState", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupWorldUIMappingState", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsAnyLeftButtonConflict(Buttons button)
	{
		throw null;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x000221D8 File Offset: 0x000203D8
	[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BBB6C", Offset = "0x9BBB6C", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupUIMappingState", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupWorldUIMappingState", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsAnyRightButtonConflict(Buttons button)
	{
		throw null;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x000221DB File Offset: 0x000203DB
	[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BBC24", Offset = "0x9BBC24", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsAnyLeftAxisButtonConflict(AxisButtons button)
	{
		throw null;
	}

	// Token: 0x0600022F RID: 559 RVA: 0x000221DE File Offset: 0x000203DE
	[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BBD10", Offset = "0x9BBD10", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsAnyRightAxisButtonConflict(AxisButtons button)
	{
		throw null;
	}

	// Token: 0x06000230 RID: 560 RVA: 0x000221E1 File Offset: 0x000203E1
	[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BBDFC", Offset = "0x9BBDFC", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsAnyLeftAxisConflict(Axis axis)
	{
		throw null;
	}

	// Token: 0x06000231 RID: 561 RVA: 0x000221E4 File Offset: 0x000203E4
	[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BBF48", Offset = "0x9BBF48", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupWorldRequiredStateOverloads", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsAnyRightAxisConflict(Axis axis)
	{
		throw null;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x000221E7 File Offset: 0x000203E7
	[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC094", Offset = "0x9BC094", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "Copy", MemberParameters = new object[] { typeof(GUIControllerMappingState) }, ReturnType = typeof(void))]
	public void Backup()
	{
		throw null;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x000221EA File Offset: 0x000203EA
	[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC0D0", Offset = "0x9BC0D0", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "Copy", MemberParameters = new object[] { typeof(GUIControllerMappingState) }, ReturnType = typeof(void))]
	public void RestoreBackup()
	{
		throw null;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x000221ED File Offset: 0x000203ED
	[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC10C", Offset = "0x9BC10C", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "ClearMappingStates", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetMapping", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences),
		typeof(ref bool),
		typeof(List<ControllerActionButton>),
		typeof(List<ControllerActionAxis>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
	public void ClearMappings()
	{
		throw null;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x000221F0 File Offset: 0x000203F0
	[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC1AC", Offset = "0x9BC1AC", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "SetupMappings", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void LoadMappingValues()
	{
		throw null;
	}

	// Token: 0x06000236 RID: 566 RVA: 0x000221F3 File Offset: 0x000203F3
	[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC268", Offset = "0x9BC268", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "TransferMapping", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingState)
	}, ReturnType = typeof(void))]
	public void TransferMapping(ControllerActionButton button, GUIControllerMappingStateTable other)
	{
		throw null;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000221F6 File Offset: 0x000203F6
	[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC2BC", Offset = "0x9BC2BC", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "SaveConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void SaveConfiguration(string configurationTable, Preferences preferences)
	{
		throw null;
	}

	// Token: 0x06000238 RID: 568 RVA: 0x000221F9 File Offset: 0x000203F9
	[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC3B0", Offset = "0x9BC3B0", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(Preferences),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences),
		typeof(ref bool),
		typeof(List<ControllerActionButton>),
		typeof(List<ControllerActionAxis>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void LoadConfiguration(string configurationTable, Preferences preferences, ref bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
		throw null;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x000221FC File Offset: 0x000203FC
	[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC4E4", Offset = "0x9BC4E4", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "RefreshConfigurationState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "IsSame", MemberParameters = new object[] { typeof(GUIControllerMappingState) }, ReturnType = typeof(bool))]
	public bool IsSame(GUIControllerMappingStateTable other)
	{
		throw null;
	}

	// Token: 0x0600023A RID: 570 RVA: 0x000221FF File Offset: 0x000203FF
	[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC544", Offset = "0x9BC544", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetMapping", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "Copy", MemberParameters = new object[] { typeof(GUIControllerMappingState) }, ReturnType = typeof(void))]
	public void Copy(GUIControllerMappingStateTable other)
	{
		throw null;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00022202 File Offset: 0x00020402
	[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC58C", Offset = "0x9BC58C", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerMappingProfile), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SetChildState(GUIControllerMappingStateTable childState)
	{
		throw null;
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00022205 File Offset: 0x00020405
	[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC638", Offset = "0x9BC638", Length = "0xF4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "DisableConflictingActions", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingStateTable),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingState), Member = "DisableConflictingActions", MemberParameters = new object[] { typeof(GUIControllerMappingState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "DisableConflictingActions", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingStateTable),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void DisableConflictingActions(GUIControllerMappingStateTable other, bool altDisableFaceBindings = true)
	{
		throw null;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00022208 File Offset: 0x00020408
	[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC72C", Offset = "0x9BC72C", Length = "0x2C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindAxis", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(Axis),
		typeof(Axis),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(AxisButtons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(Buttons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	public GUIControllerMappingState GetState(int stateIndex)
	{
		throw null;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0002220B File Offset: 0x0002040B
	[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BC758", Offset = "0x9BC758", Length = "0x35C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(Buttons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void ClearLinkedButtonBindings(int stateIndex, Buttons button, List<ControllerActionButton> allowedActions = null)
	{
		throw null;
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0002220E File Offset: 0x0002040E
	[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BCAB4", Offset = "0x9BCAB4", Length = "0x3C8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindAxis", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(Axis),
		typeof(Axis),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetAxisThreshold", MemberParameters = new object[]
	{
		typeof(AxisButtons),
		typeof(ref float)
	}, ReturnType = typeof(Axis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ClearLinkedAxisBindings(int stateIndex, Axis x, Axis y, bool tableOnly = false)
	{
		throw null;
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00022211 File Offset: 0x00020411
	[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BCE7C", Offset = "0x9BCE7C", Length = "0x334")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(AxisButtons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetAxisThreshold", MemberParameters = new object[]
	{
		typeof(AxisButtons),
		typeof(ref float)
	}, ReturnType = typeof(Axis))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void ClearLinkedButtonBindings(int stateIndex, AxisButtons axisButton, List<ControllerActionButton> allowedActions = null, bool tableOnly = false)
	{
		throw null;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00022214 File Offset: 0x00020414
	[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD1B0", Offset = "0x9BD1B0", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(AxisButtons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "RebindButton", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(Buttons),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public void RemoveButtonBindings(ControllerActionButton actionButton)
	{
		throw null;
	}

	// Token: 0x0400020A RID: 522
	[global::Cpp2ILInjected.Token(Token = "0x400031C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingState Normal;

	// Token: 0x0400020B RID: 523
	[global::Cpp2ILInjected.Token(Token = "0x400031D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerMappingState Left;

	// Token: 0x0400020C RID: 524
	[global::Cpp2ILInjected.Token(Token = "0x400031E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerMappingState Right;

	// Token: 0x0400020D RID: 525
	[global::Cpp2ILInjected.Token(Token = "0x400031F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerMappingState BackupNormal;

	// Token: 0x0400020E RID: 526
	[global::Cpp2ILInjected.Token(Token = "0x4000320")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerMappingState BackupLeft;

	// Token: 0x0400020F RID: 527
	[global::Cpp2ILInjected.Token(Token = "0x4000321")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIControllerMappingState BackupRight;

	// Token: 0x04000210 RID: 528
	[global::Cpp2ILInjected.Token(Token = "0x4000322")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private GUIControllerMappingStateTable LinkedChildState;

	// Token: 0x04000211 RID: 529
	[global::Cpp2ILInjected.Token(Token = "0x4000323")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private List<GUIControllerMappingStateTable> LinkedParentStates;
}
