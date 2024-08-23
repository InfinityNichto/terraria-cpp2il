using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x020001BD RID: 445
[global::Cpp2ILInjected.Token(Token = "0x2000250")]
public class VirtualInputController_Layout : LayoutDefinition
{
	// Token: 0x06000C36 RID: 3126 RVA: 0x00023FE7 File Offset: 0x000221E7
	[global::Cpp2ILInjected.Token(Token = "0x6000D50")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D71B8", Offset = "0x9D71B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x00023FEA File Offset: 0x000221EA
	[global::Cpp2ILInjected.Token(Token = "0x6000D51")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7204", Offset = "0x9D7204", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public VirtualInputController_Layout()
	{
		throw null;
	}

	// Token: 0x04001387 RID: 4999
	[global::Cpp2ILInjected.Token(Token = "0x4001862")]
	public static VirtualInputController_Layout Instance;

	// Token: 0x04001388 RID: 5000
	[global::Cpp2ILInjected.Token(Token = "0x4001863")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public QuickActionButton_Layout Jump;

	// Token: 0x04001389 RID: 5001
	[global::Cpp2ILInjected.Token(Token = "0x4001864")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public QuickActionButton_Layout Jump2;

	// Token: 0x0400138A RID: 5002
	[global::Cpp2ILInjected.Token(Token = "0x4001865")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Axis_Layout Movement;

	// Token: 0x0400138B RID: 5003
	[global::Cpp2ILInjected.Token(Token = "0x4001866")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public QuickActionButton_Layout Heal;

	// Token: 0x0400138C RID: 5004
	[global::Cpp2ILInjected.Token(Token = "0x4001867")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public QuickActionButton_Layout Mana;

	// Token: 0x0400138D RID: 5005
	[global::Cpp2ILInjected.Token(Token = "0x4001868")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public QuickActionButton_Layout Buff;

	// Token: 0x0400138E RID: 5006
	[global::Cpp2ILInjected.Token(Token = "0x4001869")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public QuickActionButton_Layout Mount;

	// Token: 0x0400138F RID: 5007
	[global::Cpp2ILInjected.Token(Token = "0x400186A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public QuickActionButton_Layout SmartCursor;

	// Token: 0x04001390 RID: 5008
	[global::Cpp2ILInjected.Token(Token = "0x400186B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public QuickActionButton_Layout AutoFire;

	// Token: 0x04001391 RID: 5009
	[global::Cpp2ILInjected.Token(Token = "0x400186C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public QuickActionButton_Layout ZoomIn;

	// Token: 0x04001392 RID: 5010
	[global::Cpp2ILInjected.Token(Token = "0x400186D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public QuickActionButton_Layout ZoomOut;

	// Token: 0x04001393 RID: 5011
	[global::Cpp2ILInjected.Token(Token = "0x400186E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ZoomBacking;

	// Token: 0x04001394 RID: 5012
	[global::Cpp2ILInjected.Token(Token = "0x400186F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public QuickActionButton_Layout Interact;

	// Token: 0x04001395 RID: 5013
	[global::Cpp2ILInjected.Token(Token = "0x4001870")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public QuickActionButton_Layout Fire;

	// Token: 0x04001396 RID: 5014
	[global::Cpp2ILInjected.Token(Token = "0x4001871")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public QuickActionButton_Layout Fire2;

	// Token: 0x04001397 RID: 5015
	[global::Cpp2ILInjected.Token(Token = "0x4001872")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public QuickActionButton_Layout Inventory;

	// Token: 0x04001398 RID: 5016
	[global::Cpp2ILInjected.Token(Token = "0x4001873")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public QuickActionButton_Layout AutoSelect;

	// Token: 0x04001399 RID: 5017
	[global::Cpp2ILInjected.Token(Token = "0x4001874")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public QuickActionButton_Layout GrappleSelect;

	// Token: 0x0400139A RID: 5018
	[global::Cpp2ILInjected.Token(Token = "0x4001875")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public QuickActionButton_Layout TargetLockOn;

	// Token: 0x0400139B RID: 5019
	[global::Cpp2ILInjected.Token(Token = "0x4001876")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public FadeString_Layout ZoomValue;

	// Token: 0x0400139C RID: 5020
	[global::Cpp2ILInjected.Token(Token = "0x4001877")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Axis_Layout FireAxis;

	// Token: 0x0400139D RID: 5021
	[global::Cpp2ILInjected.Token(Token = "0x4001878")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Axis_Layout GrappleAxis;

	// Token: 0x0400139E RID: 5022
	[global::Cpp2ILInjected.Token(Token = "0x4001879")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public FadeString_Layout NotifySmartCursor;

	// Token: 0x0400139F RID: 5023
	[global::Cpp2ILInjected.Token(Token = "0x400187A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public FadeString_Layout NotifyAutoFire;

	// Token: 0x040013A0 RID: 5024
	[global::Cpp2ILInjected.Token(Token = "0x400187B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public FadeString_Layout NotifyCombatTargeting;

	// Token: 0x040013A1 RID: 5025
	[global::Cpp2ILInjected.Token(Token = "0x400187C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public FadeString_Layout NotifyProfile;

	// Token: 0x040013A2 RID: 5026
	[global::Cpp2ILInjected.Token(Token = "0x400187D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public FadeString_Layout NotifySmartCursorController;

	// Token: 0x040013A3 RID: 5027
	[global::Cpp2ILInjected.Token(Token = "0x400187E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public FadeString_Layout NotifyAutoFireController;

	// Token: 0x040013A4 RID: 5028
	[global::Cpp2ILInjected.Token(Token = "0x400187F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public FadeString_Layout NotifyCombatTargetingController;

	// Token: 0x040013A5 RID: 5029
	[global::Cpp2ILInjected.Token(Token = "0x4001880")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public FadeString_Layout NotifyProfileController;

	// Token: 0x040013A6 RID: 5030
	[global::Cpp2ILInjected.Token(Token = "0x4001881")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout ProfileSwitchString;

	// Token: 0x020007F4 RID: 2036
	[global::Cpp2ILInjected.Token(Token = "0x2000251")]
	public enum ContolType
	{
		// Token: 0x04007CA6 RID: 31910
		[global::Cpp2ILInjected.Token(Token = "0x4001883")]
		AutoFire,
		// Token: 0x04007CA7 RID: 31911
		[global::Cpp2ILInjected.Token(Token = "0x4001884")]
		SmartCursor,
		// Token: 0x04007CA8 RID: 31912
		[global::Cpp2ILInjected.Token(Token = "0x4001885")]
		CombatTargetting,
		// Token: 0x04007CA9 RID: 31913
		[global::Cpp2ILInjected.Token(Token = "0x4001886")]
		Jump,
		// Token: 0x04007CAA RID: 31914
		[global::Cpp2ILInjected.Token(Token = "0x4001887")]
		Heal,
		// Token: 0x04007CAB RID: 31915
		[global::Cpp2ILInjected.Token(Token = "0x4001888")]
		Mana,
		// Token: 0x04007CAC RID: 31916
		[global::Cpp2ILInjected.Token(Token = "0x4001889")]
		Buff,
		// Token: 0x04007CAD RID: 31917
		[global::Cpp2ILInjected.Token(Token = "0x400188A")]
		Mount,
		// Token: 0x04007CAE RID: 31918
		[global::Cpp2ILInjected.Token(Token = "0x400188B")]
		Interact,
		// Token: 0x04007CAF RID: 31919
		[global::Cpp2ILInjected.Token(Token = "0x400188C")]
		Fire,
		// Token: 0x04007CB0 RID: 31920
		[global::Cpp2ILInjected.Token(Token = "0x400188D")]
		GrappleAxis,
		// Token: 0x04007CB1 RID: 31921
		[global::Cpp2ILInjected.Token(Token = "0x400188E")]
		Count
	}

	// Token: 0x020007F5 RID: 2037
	[global::Cpp2ILInjected.Token(Token = "0x2000252")]
	[Serializable]
	public class SlotEntry
	{
		// Token: 0x060048ED RID: 18669 RVA: 0x0002EF1C File Offset: 0x0002D11C
		[global::Cpp2ILInjected.Token(Token = "0x6000D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D725C", Offset = "0x9D725C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SlotEntry()
		{
			throw null;
		}

		// Token: 0x04007CB2 RID: 31922
		[global::Cpp2ILInjected.Token(Token = "0x400188F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public VirtualInputController_Layout.ContolType DefaultControl;

		// Token: 0x04007CB3 RID: 31923
		[global::Cpp2ILInjected.Token(Token = "0x4001890")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public ControlAnchor.ControlId AnchorControl;

		// Token: 0x04007CB4 RID: 31924
		[global::Cpp2ILInjected.Token(Token = "0x4001891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public LayoutCalculator.AnchorType Anchor;

		// Token: 0x04007CB5 RID: 31925
		[global::Cpp2ILInjected.Token(Token = "0x4001892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Location;

		// Token: 0x04007CB6 RID: 31926
		[global::Cpp2ILInjected.Token(Token = "0x4001893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float Scale;
	}
}
