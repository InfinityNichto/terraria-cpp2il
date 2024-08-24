using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000056 RID: 86
[global::Cpp2ILInjected.Token(Token = "0x2000080")]
public class GUIControllerMappingScheme
{
	// Token: 0x06000252 RID: 594 RVA: 0x00022247 File Offset: 0x00020447
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

	// Token: 0x06000253 RID: 595 RVA: 0x0002224A File Offset: 0x0002044A
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

	// Token: 0x06000254 RID: 596 RVA: 0x0002224D File Offset: 0x0002044D
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

	// Token: 0x06000255 RID: 597 RVA: 0x00022250 File Offset: 0x00020450
	[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE54", Offset = "0x9BDE54", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00022253 File Offset: 0x00020453
	[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE58", Offset = "0x9BDE58", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00022256 File Offset: 0x00020456
	[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE5C", Offset = "0x9BDE5C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00022259 File Offset: 0x00020459
	[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE60", Offset = "0x9BDE60", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0002225C File Offset: 0x0002045C
	[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE64", Offset = "0x9BDE64", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseBaseUIMappingsMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0002225F File Offset: 0x0002045F
	[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE68", Offset = "0x9BDE68", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00022262 File Offset: 0x00020462
	[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE6C", Offset = "0x9BDE6C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00022265 File Offset: 0x00020465
	[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE70", Offset = "0x9BDE70", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00022268 File Offset: 0x00020468
	[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE74", Offset = "0x9BDE74", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0002226B File Offset: 0x0002046B
	[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE78", Offset = "0x9BDE78", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0002226E File Offset: 0x0002046E
	[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE7C", Offset = "0x9BDE7C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00022271 File Offset: 0x00020471
	[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE80", Offset = "0x9BDE80", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00022274 File Offset: 0x00020474
	[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE84", Offset = "0x9BDE84", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00022277 File Offset: 0x00020477
	[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE88", Offset = "0x9BDE88", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x0002227A File Offset: 0x0002047A
	[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE8C", Offset = "0x9BDE8C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x0002227D File Offset: 0x0002047D
	[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE90", Offset = "0x9BDE90", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00022280 File Offset: 0x00020480
	[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9BDE94", Offset = "0x9BDE94", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	protected virtual void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		throw null;
	}

	// Token: 0x04000215 RID: 533
	[global::Cpp2ILInjected.Token(Token = "0x4000327")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUIControllerMappingStateTable WorldMappings;

	// Token: 0x04000216 RID: 534
	[global::Cpp2ILInjected.Token(Token = "0x4000328")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public GUIControllerMappingStateTable WorldSharedMappings;

	// Token: 0x04000217 RID: 535
	[global::Cpp2ILInjected.Token(Token = "0x4000329")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GUIControllerMappingStateTable WorldInteractMappings;

	// Token: 0x04000218 RID: 536
	[global::Cpp2ILInjected.Token(Token = "0x400032A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public GUIControllerMappingStateTable WorldInteractFallbackMappings;

	// Token: 0x04000219 RID: 537
	[global::Cpp2ILInjected.Token(Token = "0x400032B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public GUIControllerMappingStateTable BaseInventoryMappings;

	// Token: 0x0400021A RID: 538
	[global::Cpp2ILInjected.Token(Token = "0x400032C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public GUIControllerMappingStateTable InventoryMappings;

	// Token: 0x0400021B RID: 539
	[global::Cpp2ILInjected.Token(Token = "0x400032D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public GUIControllerMappingStateTable EquipmentMappings;

	// Token: 0x0400021C RID: 540
	[global::Cpp2ILInjected.Token(Token = "0x400032E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public GUIControllerMappingStateTable PVPMappings;

	// Token: 0x0400021D RID: 541
	[global::Cpp2ILInjected.Token(Token = "0x400032F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public GUIControllerMappingStateTable HeldMappings;

	// Token: 0x0400021E RID: 542
	[global::Cpp2ILInjected.Token(Token = "0x4000330")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GUIControllerMappingStateTable ChestInvMappings;

	// Token: 0x0400021F RID: 543
	[global::Cpp2ILInjected.Token(Token = "0x4000331")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public GUIControllerMappingStateTable ChestMappings;

	// Token: 0x04000220 RID: 544
	[global::Cpp2ILInjected.Token(Token = "0x4000332")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GUIControllerMappingStateTable ShopInvMappings;

	// Token: 0x04000221 RID: 545
	[global::Cpp2ILInjected.Token(Token = "0x4000333")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public GUIControllerMappingStateTable ShopMappings;

	// Token: 0x04000222 RID: 546
	[global::Cpp2ILInjected.Token(Token = "0x4000334")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public GUIControllerMappingStateTable CraftingMappings;

	// Token: 0x04000223 RID: 547
	[global::Cpp2ILInjected.Token(Token = "0x4000335")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public GUIControllerMappingStateTable ReforgeMappings;

	// Token: 0x04000224 RID: 548
	[global::Cpp2ILInjected.Token(Token = "0x4000336")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public GUIControllerMappingStateTable HousingMappings;

	// Token: 0x04000225 RID: 549
	[global::Cpp2ILInjected.Token(Token = "0x4000337")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public GUIControllerMappingStateTable ChatMappings;

	// Token: 0x04000226 RID: 550
	[global::Cpp2ILInjected.Token(Token = "0x4000338")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public GUIControllerMappings.MappingType SchemeType;
}
