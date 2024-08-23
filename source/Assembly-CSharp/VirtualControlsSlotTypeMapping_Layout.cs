using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

// Token: 0x020001BB RID: 443
[JsonObject(MemberSerialization.OptIn)]
[global::Cpp2ILInjected.Token(Token = "0x200024D")]
[Serializable]
public class VirtualControlsSlotTypeMapping_Layout
{
	// Token: 0x06000C29 RID: 3113 RVA: 0x00023FC0 File Offset: 0x000221C0
	[global::Cpp2ILInjected.Token(Token = "0x6000D43")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5A30", Offset = "0x9D5A30", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CreateNewSlot", MemberParameters = new object[]
	{
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(string),
		typeof(Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsSlotTypeMapping_Layout()
	{
		throw null;
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00023FC3 File Offset: 0x000221C3
	[global::Cpp2ILInjected.Token(Token = "0x17000170")]
	public VirtualControlsButtonConfiguration_Layout ButtonConfiguration
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D44")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D6528", Offset = "0x9D6528", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "IsOver", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIRubbleMaker), Member = "ClampPositionToScreen", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(VirtualControlsHardwareConfigurationMapping_Layout)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawMapControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateStyleOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetSlotOver", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampSlotToScreen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DraggingControlInBadPosition", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 67)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetButtonConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsButtonConfiguration_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00023FC6 File Offset: 0x000221C6
	[global::Cpp2ILInjected.Token(Token = "0x17000171")]
	public VirtualControlsAxisConfiguration_Layout AxisConfiguration
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D45")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D664C", Offset = "0x9D664C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "SecondaryUpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursor", MemberParameters = new object[] { typeof(Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "UpdateStyleOptions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetSlotOver", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampSlotToScreen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DraggingControlInBadPosition", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetAxisConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsAxisConfiguration_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400137B RID: 4987
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x4001853")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string ControlTypeId;

	// Token: 0x0400137C RID: 4988
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x4001854")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControlsSlotTypeMapping_Layout.SlotType ControlType;

	// Token: 0x0400137D RID: 4989
	[global::Cpp2ILInjected.Token(Token = "0x4001855")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private VirtualControlsButtonConfiguration_Layout _buttonMapping;

	// Token: 0x0400137E RID: 4990
	[global::Cpp2ILInjected.Token(Token = "0x4001856")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private VirtualControlsAxisConfiguration_Layout _axisMapping;

	// Token: 0x0400137F RID: 4991
	[global::Cpp2ILInjected.Token(Token = "0x4001857")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private string _lastControlTypeId;

	// Token: 0x020007F3 RID: 2035
	[global::Cpp2ILInjected.Token(Token = "0x200024E")]
	public enum SlotType
	{
		// Token: 0x04007CA3 RID: 31907
		[global::Cpp2ILInjected.Token(Token = "0x4001859")]
		Axis,
		// Token: 0x04007CA4 RID: 31908
		[global::Cpp2ILInjected.Token(Token = "0x400185A")]
		Button
	}
}
