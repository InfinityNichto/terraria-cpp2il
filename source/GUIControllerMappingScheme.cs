using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000080")]
public class GUIControllerMappingScheme
{
	[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BD74C", Offset = "0x9BD74C", Length = "0x2B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingScheme), Member = ".ctor", MemberParameters = new object[] { typeof(GUIControllerMappings.MappingType) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingScheme), Member = "Initialise", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static void LoadDefaultSchemes(List<GUIControllerMappingScheme> Schemes)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDC1C", Offset = "0x9BDC1C", Length = "0x238")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme), Member = "LoadDefaultSchemes", MemberParameters = new object[] { typeof(List<GUIControllerMappingScheme>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme_Advanced), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme_Console), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme_Default), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingStateTable), Member = "SetChildState", MemberParameters = new object[] { typeof(GUIControllerMappingStateTable) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public GUIControllerMappingScheme(GUIControllerMappings.MappingType mappingType)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDA18", Offset = "0x9BDA18", Length = "0x204")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingScheme), Member = "LoadDefaultSchemes", MemberParameters = new object[] { typeof(List<GUIControllerMappingScheme>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void Initialise()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE54", Offset = "0x9BDE54", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE58", Offset = "0x9BDE58", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE5C", Offset = "0x9BDE5C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE60", Offset = "0x9BDE60", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE64", Offset = "0x9BDE64", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseBaseUIMappingsMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE68", Offset = "0x9BDE68", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE6C", Offset = "0x9BDE6C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE70", Offset = "0x9BDE70", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE74", Offset = "0x9BDE74", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE78", Offset = "0x9BDE78", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE7C", Offset = "0x9BDE7C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE80", Offset = "0x9BDE80", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE84", Offset = "0x9BDE84", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE88", Offset = "0x9BDE88", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE8C", Offset = "0x9BDE8C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE90", Offset = "0x9BDE90", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE94", Offset = "0x9BDE94", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000327")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingStateTable WorldMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000328")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerMappingStateTable WorldSharedMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000329")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerMappingStateTable WorldInteractMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400032A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerMappingStateTable WorldInteractFallbackMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400032B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerMappingStateTable BaseInventoryMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400032C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIControllerMappingStateTable InventoryMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400032D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIControllerMappingStateTable EquipmentMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400032E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIControllerMappingStateTable PVPMappings;

	[global::Cpp2ILInjected.Token(Token = "0x400032F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIControllerMappingStateTable HeldMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000330")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GUIControllerMappingStateTable ChestInvMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000331")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public GUIControllerMappingStateTable ChestMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000332")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GUIControllerMappingStateTable ShopInvMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000333")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public GUIControllerMappingStateTable ShopMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000334")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public GUIControllerMappingStateTable CraftingMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000335")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIControllerMappingStateTable ReforgeMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000336")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public GUIControllerMappingStateTable HousingMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000337")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public GUIControllerMappingStateTable ChatMappings;

	[global::Cpp2ILInjected.Token(Token = "0x4000338")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public GUIControllerMappings.MappingType SchemeType;
}
