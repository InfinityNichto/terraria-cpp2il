using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200004C RID: 76
[global::Cpp2ILInjected.Token(Token = "0x2000072")]
public class ControllerMappingProfile
{
	// Token: 0x060001E6 RID: 486 RVA: 0x00022103 File Offset: 0x00020303
	[global::Cpp2ILInjected.Token(Token = "0x6000279")]
	[global::Cpp2ILInjected.Address(RVA = "0x711678", Offset = "0x711678", Length = "0x2A0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "SetChildState", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public ControllerMappingProfile()
	{
		throw null;
	}

	// Token: 0x04000130 RID: 304
	[global::Cpp2ILInjected.Token(Token = "0x4000227")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingStateTable World;

	// Token: 0x04000131 RID: 305
	[global::Cpp2ILInjected.Token(Token = "0x4000228")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerMappingStateTable BaseInventory;

	// Token: 0x04000132 RID: 306
	[global::Cpp2ILInjected.Token(Token = "0x4000229")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerMappingStateTable Inventory;

	// Token: 0x04000133 RID: 307
	[global::Cpp2ILInjected.Token(Token = "0x400022A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerMappingStateTable EquipmentInv;

	// Token: 0x04000134 RID: 308
	[global::Cpp2ILInjected.Token(Token = "0x400022B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerMappingStateTable Equipment;

	// Token: 0x04000135 RID: 309
	[global::Cpp2ILInjected.Token(Token = "0x400022C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIControllerMappingStateTable PVP;

	// Token: 0x04000136 RID: 310
	[global::Cpp2ILInjected.Token(Token = "0x400022D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIControllerMappingStateTable ItemHeld;

	// Token: 0x04000137 RID: 311
	[global::Cpp2ILInjected.Token(Token = "0x400022E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIControllerMappingStateTable Hair;

	// Token: 0x04000138 RID: 312
	[global::Cpp2ILInjected.Token(Token = "0x400022F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIControllerMappingStateTable Dresser;

	// Token: 0x04000139 RID: 313
	[global::Cpp2ILInjected.Token(Token = "0x4000230")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GUIControllerMappingStateTable NPC;

	// Token: 0x0400013A RID: 314
	[global::Cpp2ILInjected.Token(Token = "0x4000231")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public GUIControllerMappingStateTable ChestInv;

	// Token: 0x0400013B RID: 315
	[global::Cpp2ILInjected.Token(Token = "0x4000232")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GUIControllerMappingStateTable Chest;

	// Token: 0x0400013C RID: 316
	[global::Cpp2ILInjected.Token(Token = "0x4000233")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public GUIControllerMappingStateTable ShopInv;

	// Token: 0x0400013D RID: 317
	[global::Cpp2ILInjected.Token(Token = "0x4000234")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public GUIControllerMappingStateTable Shop;

	// Token: 0x0400013E RID: 318
	[global::Cpp2ILInjected.Token(Token = "0x4000235")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIControllerMappingStateTable CraftingInv;

	// Token: 0x0400013F RID: 319
	[global::Cpp2ILInjected.Token(Token = "0x4000236")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public GUIControllerMappingStateTable Crafting;
}
