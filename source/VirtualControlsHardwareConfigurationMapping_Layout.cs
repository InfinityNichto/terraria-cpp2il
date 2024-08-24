using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020001B8 RID: 440
[global::Cpp2ILInjected.Token(Token = "0x2000249")]
[Serializable]
public class VirtualControlsHardwareConfigurationMapping_Layout
{
	// Token: 0x06000C1B RID: 3099 RVA: 0x00023F96 File Offset: 0x00022196
	[global::Cpp2ILInjected.Token(Token = "0x6000D35")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5998", Offset = "0x9D5998", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Copy(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		throw null;
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x00023F99 File Offset: 0x00022199
	[global::Cpp2ILInjected.Token(Token = "0x6000D36")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5A38", Offset = "0x9D5A38", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsSame(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		throw null;
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00023F9C File Offset: 0x0002219C
	[global::Cpp2ILInjected.Token(Token = "0x6000D37")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5B44", Offset = "0x9D5B44", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CreateNewSlot", MemberParameters = new object[]
	{
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(string),
		typeof(Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public VirtualControlsHardwareConfigurationMapping_Layout()
	{
		throw null;
	}

	// Token: 0x04001366 RID: 4966
	[global::Cpp2ILInjected.Token(Token = "0x4001824")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string SlotId;

	// Token: 0x04001367 RID: 4967
	[global::Cpp2ILInjected.Token(Token = "0x4001825")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControlsSlotTypeMapping_Layout Style;

	// Token: 0x04001368 RID: 4968
	[global::Cpp2ILInjected.Token(Token = "0x4001826")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType DefaultControl;

	// Token: 0x04001369 RID: 4969
	[global::Cpp2ILInjected.Token(Token = "0x4001827")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public ControlAnchor.ControlId AnchorControl;

	// Token: 0x0400136A RID: 4970
	[global::Cpp2ILInjected.Token(Token = "0x4001828")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public LayoutCalculator.AnchorType Anchor;

	// Token: 0x0400136B RID: 4971
	[global::Cpp2ILInjected.Token(Token = "0x4001829")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 Location;

	// Token: 0x020007F2 RID: 2034
	[global::Cpp2ILInjected.Token(Token = "0x200024A")]
	public enum ContolType
	{
		// Token: 0x04007C89 RID: 31881
		[global::Cpp2ILInjected.Token(Token = "0x400182B")]
		AutoFire,
		// Token: 0x04007C8A RID: 31882
		[global::Cpp2ILInjected.Token(Token = "0x400182C")]
		SmartCursor,
		// Token: 0x04007C8B RID: 31883
		[global::Cpp2ILInjected.Token(Token = "0x400182D")]
		CombatTargetting,
		// Token: 0x04007C8C RID: 31884
		[global::Cpp2ILInjected.Token(Token = "0x400182E")]
		Jump,
		// Token: 0x04007C8D RID: 31885
		[global::Cpp2ILInjected.Token(Token = "0x400182F")]
		Heal,
		// Token: 0x04007C8E RID: 31886
		[global::Cpp2ILInjected.Token(Token = "0x4001830")]
		Mana,
		// Token: 0x04007C8F RID: 31887
		[global::Cpp2ILInjected.Token(Token = "0x4001831")]
		Buff,
		// Token: 0x04007C90 RID: 31888
		[global::Cpp2ILInjected.Token(Token = "0x4001832")]
		Mount,
		// Token: 0x04007C91 RID: 31889
		[global::Cpp2ILInjected.Token(Token = "0x4001833")]
		Interact,
		// Token: 0x04007C92 RID: 31890
		[global::Cpp2ILInjected.Token(Token = "0x4001834")]
		Fire,
		// Token: 0x04007C93 RID: 31891
		[global::Cpp2ILInjected.Token(Token = "0x4001835")]
		GrappleAxis,
		// Token: 0x04007C94 RID: 31892
		[global::Cpp2ILInjected.Token(Token = "0x4001836")]
		AutoSelect,
		// Token: 0x04007C95 RID: 31893
		[global::Cpp2ILInjected.Token(Token = "0x4001837")]
		ZoomIn,
		// Token: 0x04007C96 RID: 31894
		[global::Cpp2ILInjected.Token(Token = "0x4001838")]
		ZoomOut,
		// Token: 0x04007C97 RID: 31895
		[global::Cpp2ILInjected.Token(Token = "0x4001839")]
		Move,
		// Token: 0x04007C98 RID: 31896
		[global::Cpp2ILInjected.Token(Token = "0x400183A")]
		Aim,
		// Token: 0x04007C99 RID: 31897
		[global::Cpp2ILInjected.Token(Token = "0x400183B")]
		GrappleFire,
		// Token: 0x04007C9A RID: 31898
		[global::Cpp2ILInjected.Token(Token = "0x400183C")]
		ProfileSwitch,
		// Token: 0x04007C9B RID: 31899
		[global::Cpp2ILInjected.Token(Token = "0x400183D")]
		InventoryToggle,
		// Token: 0x04007C9C RID: 31900
		[global::Cpp2ILInjected.Token(Token = "0x400183E")]
		Settings,
		// Token: 0x04007C9D RID: 31901
		[global::Cpp2ILInjected.Token(Token = "0x400183F")]
		Loadout1,
		// Token: 0x04007C9E RID: 31902
		[global::Cpp2ILInjected.Token(Token = "0x4001840")]
		Loadout2,
		// Token: 0x04007C9F RID: 31903
		[global::Cpp2ILInjected.Token(Token = "0x4001841")]
		Loadout3,
		// Token: 0x04007CA0 RID: 31904
		[global::Cpp2ILInjected.Token(Token = "0x4001842")]
		LoadoutCycle,
		// Token: 0x04007CA1 RID: 31905
		[global::Cpp2ILInjected.Token(Token = "0x4001843")]
		Count
	}
}
