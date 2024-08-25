using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200007B")]
public class GUIControllerMappingState
{
	[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D638", Offset = "0x71D638", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Clear()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D684", Offset = "0x71D684", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "IsSame", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	public bool IsSame(GUIControllerMappingState other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D724", Offset = "0x71D724", Length = "0x178")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "DisableConflictingActions", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingStateTable),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetAxisThreshold", MemberParameters = new object[]
	{
		typeof(AxisButtons),
		typeof(ref float)
	}, ReturnType = typeof(Axis))]
	public void DisableConflictingActions(GUIControllerMappingState other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
	[global::Cpp2ILInjected.Address(RVA = "0x717F44", Offset = "0x717F44", Length = "0x4BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_RequiredState", ReturnType = typeof(ControllerActionButton.RequiredButtonState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_HasMapping", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void SetupWorldRequiredStateOverloads(GUIControllerMappingStateTable altStates)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D89C", Offset = "0x71D89C", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "Copy", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void Copy(GUIControllerMappingState other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
	[global::Cpp2ILInjected.Address(RVA = "0x71D974", Offset = "0x71D974", Length = "0x5D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "LoadConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences),
		typeof(ref bool),
		typeof(List<ControllerActionButton>),
		typeof(List<ControllerActionAxis>)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "ClearMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "GetAxisMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionAxis))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public void LoadConfiguration(string prefix, Preferences preferences, ref bool mappingsCleared, List<ControllerActionButton> allowedButtons, List<ControllerActionAxis> allowedAxis)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
	[global::Cpp2ILInjected.Address(RVA = "0x71DF44", Offset = "0x71DF44", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "TransferMapping", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void TransferMapping(ControllerActionButton mapping, GUIControllerMappingState other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
	[global::Cpp2ILInjected.Address(RVA = "0x71E008", Offset = "0x71E008", Length = "0x2E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "SaveConfiguration", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Preferences)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Clear", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void SaveConfiguration(string prefix, Preferences preferences)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
	[global::Cpp2ILInjected.Address(RVA = "0x71E2EC", Offset = "0x71E2EC", Length = "0x3F8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "LoadMappingValues", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton.RequiredButtonState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightButtonConflict", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "MapButton", MemberParameters = new object[]
	{
		typeof(Buttons),
		typeof(ControllerActionButton.RequiredButtonState),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisButtonConflict", MemberParameters = new object[] { typeof(AxisButtons) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "MapAxisButton", MemberParameters = new object[]
	{
		typeof(AxisButtons),
		typeof(ControllerActionButton.RequiredButtonState),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyLeftAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "IsAnyRightAxisConflict", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "MapAxis", MemberParameters = new object[]
	{
		typeof(Axis),
		typeof(float),
		typeof(ControllerActionButton.RequiredButtonState)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void SetupMappings(GUIControllerMappingStateTable altStates)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
	[global::Cpp2ILInjected.Address(RVA = "0x71E6E4", Offset = "0x71E6E4", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public GUIControllerMappingState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000318")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public ControllerActionButton.RequiredButtonState RequiredState;

	[global::Cpp2ILInjected.Token(Token = "0x4000319")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ControllerActionButton[] ButtonBindings;

	[global::Cpp2ILInjected.Token(Token = "0x400031A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ControllerActionButton[] AxisButtonBindings;

	[global::Cpp2ILInjected.Token(Token = "0x400031B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ControllerActionAxis[] AxisBindings;
}
