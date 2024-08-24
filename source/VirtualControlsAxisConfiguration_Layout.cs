using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

// Token: 0x020001B5 RID: 437
[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x2000244")]
[Serializable]
public class VirtualControlsAxisConfiguration_Layout
{
	// Token: 0x06000C14 RID: 3092 RVA: 0x00023F81 File Offset: 0x00022181
	[global::Cpp2ILInjected.Token(Token = "0x6000D2E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5910", Offset = "0x9D5910", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Validate()
	{
		throw null;
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00023F84 File Offset: 0x00022184
	[global::Cpp2ILInjected.Token(Token = "0x6000D2F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5914", Offset = "0x9D5914", Length = "0x2C")]
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
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
	public Axis_Layout GetStyle(VirtualControlsAxisConfiguration_Layout.Style stlyeIndex)
	{
		throw null;
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x00023F87 File Offset: 0x00022187
	[global::Cpp2ILInjected.Token(Token = "0x6000D30")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5940", Offset = "0x9D5940", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsAxisConfiguration_Layout()
	{
		throw null;
	}

	// Token: 0x04001359 RID: 4953
	[global::Cpp2ILInjected.Token(Token = "0x400180E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	// Token: 0x0400135A RID: 4954
	[global::Cpp2ILInjected.Token(Token = "0x400180F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Axis_Layout BlueLayout;

	// Token: 0x0400135B RID: 4955
	[global::Cpp2ILInjected.Token(Token = "0x4001810")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Axis_Layout GreenLayout;

	// Token: 0x0400135C RID: 4956
	[global::Cpp2ILInjected.Token(Token = "0x4001811")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Axis_Layout BadLayout;

	// Token: 0x0400135D RID: 4957
	[global::Cpp2ILInjected.Token(Token = "0x4001812")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Axis_Layout ControlLayout;

	// Token: 0x020007F0 RID: 2032
	[global::Cpp2ILInjected.Token(Token = "0x2000245")]
	public enum Style
	{
		// Token: 0x04007C80 RID: 31872
		[global::Cpp2ILInjected.Token(Token = "0x4001814")]
		Blue,
		// Token: 0x04007C81 RID: 31873
		[global::Cpp2ILInjected.Token(Token = "0x4001815")]
		Green,
		// Token: 0x04007C82 RID: 31874
		[global::Cpp2ILInjected.Token(Token = "0x4001816")]
		BadPosition
	}
}
