using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;

// Token: 0x020001B7 RID: 439
[JsonObject(MemberSerialization.Fields)]
[global::Cpp2ILInjected.Token(Token = "0x2000247")]
[Serializable]
public class VirtualControlsButtonConfiguration_Layout
{
	// Token: 0x06000C18 RID: 3096 RVA: 0x00023F8D File Offset: 0x0002218D
	[global::Cpp2ILInjected.Token(Token = "0x6000D32")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5950", Offset = "0x9D5950", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Validate()
	{
		throw null;
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x00023F90 File Offset: 0x00022190
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

	// Token: 0x06000C1A RID: 3098 RVA: 0x00023F93 File Offset: 0x00022193
	[global::Cpp2ILInjected.Token(Token = "0x6000D34")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5990", Offset = "0x9D5990", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsButtonConfiguration_Layout()
	{
		throw null;
	}

	// Token: 0x04001360 RID: 4960
	[global::Cpp2ILInjected.Token(Token = "0x4001819")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	// Token: 0x04001361 RID: 4961
	[global::Cpp2ILInjected.Token(Token = "0x400181A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public QuickActionButton_Layout BlueLayout;

	// Token: 0x04001362 RID: 4962
	[global::Cpp2ILInjected.Token(Token = "0x400181B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public QuickActionButton_Layout GreenLayout;

	// Token: 0x04001363 RID: 4963
	[global::Cpp2ILInjected.Token(Token = "0x400181C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public QuickActionButton_Layout TealLayout;

	// Token: 0x04001364 RID: 4964
	[global::Cpp2ILInjected.Token(Token = "0x400181D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public QuickActionButton_Layout BadPositionLayout;

	// Token: 0x04001365 RID: 4965
	[global::Cpp2ILInjected.Token(Token = "0x400181E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public QuickActionButton_Layout ControlLayout;

	// Token: 0x020007F1 RID: 2033
	[global::Cpp2ILInjected.Token(Token = "0x2000248")]
	public enum Style
	{
		// Token: 0x04007C84 RID: 31876
		[global::Cpp2ILInjected.Token(Token = "0x4001820")]
		Blue,
		// Token: 0x04007C85 RID: 31877
		[global::Cpp2ILInjected.Token(Token = "0x4001821")]
		Green,
		// Token: 0x04007C86 RID: 31878
		[global::Cpp2ILInjected.Token(Token = "0x4001822")]
		Teal,
		// Token: 0x04007C87 RID: 31879
		[global::Cpp2ILInjected.Token(Token = "0x4001823")]
		Bad
	}
}
