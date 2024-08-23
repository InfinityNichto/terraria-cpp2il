using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000154 RID: 340
[global::Cpp2ILInjected.Token(Token = "0x20001D9")]
public class HousingMenu_Layout : PageControllerLayoutDefinition<HousingMenu_Layout>
{
	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00023C4B File Offset: 0x00021E4B
	[global::Cpp2ILInjected.Token(Token = "0x17000153")]
	public DraggableItemGrid_Layout DisplayNPCGrid
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C15")]
		[global::Cpp2ILInjected.Address(RVA = "0x9B6CB4", Offset = "0x9B6CB4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHousing4Page), Member = "GetGrid", ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHousingMenu), Member = "get_collapsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageIconsExtended_Layout), Member = "GetDisplayGrid", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(DraggableItemGrid_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00023C4E File Offset: 0x00021E4E
	[global::Cpp2ILInjected.Token(Token = "0x6000C16")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6D54", Offset = "0x9B6D54", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public HousingMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000CFB RID: 3323
	[global::Cpp2ILInjected.Token(Token = "0x40010FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x04000CFC RID: 3324
	[global::Cpp2ILInjected.Token(Token = "0x40010FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float NPCScale;

	// Token: 0x04000CFD RID: 3325
	[global::Cpp2ILInjected.Token(Token = "0x4001100")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float NPCHighlightScale;

	// Token: 0x04000CFE RID: 3326
	[global::Cpp2ILInjected.Token(Token = "0x4001101")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout NPCGrid;

	// Token: 0x04000CFF RID: 3327
	[global::Cpp2ILInjected.Token(Token = "0x4001102")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public DraggableItemGrid_Layout NPCGridCollapsed;

	// Token: 0x04000D00 RID: 3328
	[global::Cpp2ILInjected.Token(Token = "0x4001103")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout HousingQuery;

	// Token: 0x04000D01 RID: 3329
	[global::Cpp2ILInjected.Token(Token = "0x4001104")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout HousingClose;

	// Token: 0x04000D02 RID: 3330
	[global::Cpp2ILInjected.Token(Token = "0x4001105")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public EmptyHousingSlot EmptySlot;
}
