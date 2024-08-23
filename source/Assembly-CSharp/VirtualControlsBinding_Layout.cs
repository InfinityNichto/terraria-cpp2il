using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020001B6 RID: 438
[global::Cpp2ILInjected.Token(Token = "0x2000246")]
[Serializable]
public class VirtualControlsBinding_Layout
{
	// Token: 0x06000C17 RID: 3095 RVA: 0x00023F8A File Offset: 0x0002218A
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

	// Token: 0x0400135E RID: 4958
	[global::Cpp2ILInjected.Token(Token = "0x4001817")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string SlotId;

	// Token: 0x0400135F RID: 4959
	[global::Cpp2ILInjected.Token(Token = "0x4001818")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType Action;
}
