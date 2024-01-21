using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000057")]
public class GUIControllerMappingScheme
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public GUIControllerMappingStateTable WorldMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public GUIControllerMappingStateTable WorldSharedMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public GUIControllerMappingStateTable WorldInteractMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public GUIControllerMappingStateTable WorldInteractFallbackMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public GUIControllerMappingStateTable BaseInventoryMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public GUIControllerMappingStateTable InventoryMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public GUIControllerMappingStateTable EquipmentMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public GUIControllerMappingStateTable PVPMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public GUIControllerMappingStateTable HeldMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public GUIControllerMappingStateTable ChestInvMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public GUIControllerMappingStateTable ChestMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public GUIControllerMappingStateTable ShopInvMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public GUIControllerMappingStateTable ShopMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public GUIControllerMappingStateTable CraftingMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public GUIControllerMappingStateTable ReforgeMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public GUIControllerMappingStateTable HousingMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public GUIControllerMappingStateTable ChatMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public GUIControllerMappings.MappingType SchemeType;

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0xF6F108", Offset = "0xF6F108", VA = "0xF6F108")]
	public static void LoadDefaultSchemes(List<GUIControllerMappingScheme> Schemes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0xF6F53C", Offset = "0xF6F53C", VA = "0xF6F53C")]
	public GUIControllerMappingScheme(GUIControllerMappings.MappingType mappingType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xF6F2C0", Offset = "0xF6F2C0", VA = "0xF6F2C0")]
	public void Initialise()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xF6F96C", Offset = "0xF6F96C", VA = "0xF6F96C", Slot = "4")]
	protected virtual void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xF6F970", Offset = "0xF6F970", VA = "0xF6F970", Slot = "5")]
	protected virtual void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0xF6F974", Offset = "0xF6F974", VA = "0xF6F974", Slot = "6")]
	protected virtual void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0xF6F978", Offset = "0xF6F978", VA = "0xF6F978", Slot = "7")]
	protected virtual void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0xF6F97C", Offset = "0xF6F97C", VA = "0xF6F97C", Slot = "8")]
	protected virtual void InitialiseBaseUIMappingsMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0xF6F980", Offset = "0xF6F980", VA = "0xF6F980", Slot = "9")]
	protected virtual void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0xF6F984", Offset = "0xF6F984", VA = "0xF6F984", Slot = "10")]
	protected virtual void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0xF6F988", Offset = "0xF6F988", VA = "0xF6F988", Slot = "11")]
	protected virtual void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xF6F98C", Offset = "0xF6F98C", VA = "0xF6F98C", Slot = "12")]
	protected virtual void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0xF6F990", Offset = "0xF6F990", VA = "0xF6F990", Slot = "13")]
	protected virtual void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0xF6F994", Offset = "0xF6F994", VA = "0xF6F994", Slot = "14")]
	protected virtual void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xF6F998", Offset = "0xF6F998", VA = "0xF6F998", Slot = "15")]
	protected virtual void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xF6F99C", Offset = "0xF6F99C", VA = "0xF6F99C", Slot = "16")]
	protected virtual void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xF6F9A0", Offset = "0xF6F9A0", VA = "0xF6F9A0", Slot = "17")]
	protected virtual void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0xF6F9A4", Offset = "0xF6F9A4", VA = "0xF6F9A4", Slot = "18")]
	protected virtual void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xF6F9A8", Offset = "0xF6F9A8", VA = "0xF6F9A8", Slot = "19")]
	protected virtual void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xF6F9AC", Offset = "0xF6F9AC", VA = "0xF6F9AC", Slot = "20")]
	protected virtual void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}
}
