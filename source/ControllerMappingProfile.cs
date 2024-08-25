using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000072")]
public class ControllerMappingProfile
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000227")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingStateTable World;

	[global::Cpp2ILInjected.Token(Token = "0x4000228")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerMappingStateTable BaseInventory;

	[global::Cpp2ILInjected.Token(Token = "0x4000229")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerMappingStateTable Inventory;

	[global::Cpp2ILInjected.Token(Token = "0x400022A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerMappingStateTable EquipmentInv;

	[global::Cpp2ILInjected.Token(Token = "0x400022B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerMappingStateTable Equipment;

	[global::Cpp2ILInjected.Token(Token = "0x400022C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIControllerMappingStateTable PVP;

	[global::Cpp2ILInjected.Token(Token = "0x400022D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIControllerMappingStateTable ItemHeld;

	[global::Cpp2ILInjected.Token(Token = "0x400022E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIControllerMappingStateTable Hair;

	[global::Cpp2ILInjected.Token(Token = "0x400022F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIControllerMappingStateTable Dresser;

	[global::Cpp2ILInjected.Token(Token = "0x4000230")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GUIControllerMappingStateTable NPC;

	[global::Cpp2ILInjected.Token(Token = "0x4000231")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public GUIControllerMappingStateTable ChestInv;

	[global::Cpp2ILInjected.Token(Token = "0x4000232")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GUIControllerMappingStateTable Chest;

	[global::Cpp2ILInjected.Token(Token = "0x4000233")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public GUIControllerMappingStateTable ShopInv;

	[global::Cpp2ILInjected.Token(Token = "0x4000234")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public GUIControllerMappingStateTable Shop;

	[global::Cpp2ILInjected.Token(Token = "0x4000235")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIControllerMappingStateTable CraftingInv;

	[global::Cpp2ILInjected.Token(Token = "0x4000236")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public GUIControllerMappingStateTable Crafting;
}
