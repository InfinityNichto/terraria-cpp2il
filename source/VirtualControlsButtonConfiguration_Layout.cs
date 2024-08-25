using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x2000247")]
[Serializable]
public class VirtualControlsButtonConfiguration_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D32")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5950", Offset = "0x9D5950", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Validate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D33")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5954", Offset = "0x9D5954", Length = "0x3C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "GetSlotOver", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(ref Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ClampSlotToScreen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ControlsItemDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DraggingControlInBadPosition", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawControls", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
	public QuickActionButton_Layout GetStyle(VirtualControlsButtonConfiguration_Layout.Style stlyeIndex)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D34")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5990", Offset = "0x9D5990", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsButtonConfiguration_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001819")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	[global::Cpp2ILInjected.Token(Token = "0x400181A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public QuickActionButton_Layout BlueLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400181B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public QuickActionButton_Layout GreenLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400181C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public QuickActionButton_Layout TealLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400181D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public QuickActionButton_Layout BadPositionLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400181E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public QuickActionButton_Layout ControlLayout;

	[global::Cpp2ILInjected.Token(Token = "0x2000248")]
	public enum Style
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001820")]
		Blue,
		[global::Cpp2ILInjected.Token(Token = "0x4001821")]
		Green,
		[global::Cpp2ILInjected.Token(Token = "0x4001822")]
		Teal,
		[global::Cpp2ILInjected.Token(Token = "0x4001823")]
		Bad
	}
}
