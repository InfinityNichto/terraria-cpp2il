using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200011E RID: 286
[global::Cpp2ILInjected.Token(Token = "0x2000196")]
public class ButtonBar_Layout : LayoutDefinition
{
	// Token: 0x06000A4E RID: 2638 RVA: 0x00023A2F File Offset: 0x00021C2F
	[global::Cpp2ILInjected.Token(Token = "0x6000B5B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC0DC", Offset = "0x9AC0DC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00023A32 File Offset: 0x00021C32
	[global::Cpp2ILInjected.Token(Token = "0x6000B5C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC128", Offset = "0x9AC128", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ButtonBar_Layout()
	{
		throw null;
	}

	// Token: 0x04000981 RID: 2433
	[global::Cpp2ILInjected.Token(Token = "0x4000CA3")]
	public static ButtonBar_Layout Instance;

	// Token: 0x04000982 RID: 2434
	[global::Cpp2ILInjected.Token(Token = "0x4000CA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float GridItemScale;

	// Token: 0x04000983 RID: 2435
	[global::Cpp2ILInjected.Token(Token = "0x4000CA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Stretched_Layout Backing;

	// Token: 0x04000984 RID: 2436
	[global::Cpp2ILInjected.Token(Token = "0x4000CA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout ButtonGrid;

	// Token: 0x04000985 RID: 2437
	[global::Cpp2ILInjected.Token(Token = "0x4000CA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ButtonCollapsed;

	// Token: 0x04000986 RID: 2438
	[global::Cpp2ILInjected.Token(Token = "0x4000CA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ButtonTemplateFirst;

	// Token: 0x04000987 RID: 2439
	[global::Cpp2ILInjected.Token(Token = "0x4000CA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ButtonTemplateEntry;

	// Token: 0x04000988 RID: 2440
	[global::Cpp2ILInjected.Token(Token = "0x4000CAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout ButtonTemplateLast;

	// Token: 0x04000989 RID: 2441
	[global::Cpp2ILInjected.Token(Token = "0x4000CAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout ExpandIcon;

	// Token: 0x0400098A RID: 2442
	[global::Cpp2ILInjected.Token(Token = "0x4000CAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout CollapseIcon;

	// Token: 0x0400098B RID: 2443
	[global::Cpp2ILInjected.Token(Token = "0x4000CAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout ChatIcon;

	// Token: 0x0400098C RID: 2444
	[global::Cpp2ILInjected.Token(Token = "0x4000CAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout TutorialIcon;

	// Token: 0x0400098D RID: 2445
	[global::Cpp2ILInjected.Token(Token = "0x4000CAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout TutorialIconSelected;

	// Token: 0x0400098E RID: 2446
	[global::Cpp2ILInjected.Token(Token = "0x4000CB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout JourneyWorldSettingsIcon;

	// Token: 0x0400098F RID: 2447
	[global::Cpp2ILInjected.Token(Token = "0x4000CB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout HousingIcon;

	// Token: 0x04000990 RID: 2448
	[global::Cpp2ILInjected.Token(Token = "0x4000CB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout PVPIcon;

	// Token: 0x04000991 RID: 2449
	[global::Cpp2ILInjected.Token(Token = "0x4000CB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout BestiaryIcon;

	// Token: 0x04000992 RID: 2450
	[global::Cpp2ILInjected.Token(Token = "0x4000CB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout DuplicateIcon;

	// Token: 0x04000993 RID: 2451
	[global::Cpp2ILInjected.Token(Token = "0x4000CB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout MapIcon;
}
