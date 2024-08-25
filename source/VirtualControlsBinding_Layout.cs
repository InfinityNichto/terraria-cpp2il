using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000246")]
[Serializable]
public class VirtualControlsBinding_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D31")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5948", Offset = "0x9D5948", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreDefaults", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CreateNewSlot", MemberParameters = new object[]
	{
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(string),
		typeof(Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsBinding_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001817")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string SlotId;

	[global::Cpp2ILInjected.Token(Token = "0x4001818")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType Action;
}
