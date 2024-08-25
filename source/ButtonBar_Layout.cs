using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000196")]
public class ButtonBar_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B5B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC0DC", Offset = "0x9AC0DC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B5C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC128", Offset = "0x9AC128", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ButtonBar_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000CA3")]
	public static ButtonBar_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000CA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float GridItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000CA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Stretched_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000CA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ItemGrid_Layout ButtonGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000CA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ButtonCollapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000CA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ButtonTemplateFirst;

	[global::Cpp2ILInjected.Token(Token = "0x4000CA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ButtonTemplateEntry;

	[global::Cpp2ILInjected.Token(Token = "0x4000CAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout ButtonTemplateLast;

	[global::Cpp2ILInjected.Token(Token = "0x4000CAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout ExpandIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout CollapseIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout ChatIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Texture_Layout TutorialIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Texture_Layout TutorialIconSelected;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Texture_Layout JourneyWorldSettingsIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Texture_Layout HousingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Texture_Layout PVPIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Texture_Layout BestiaryIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Texture_Layout DuplicateIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Texture_Layout MapIcon;
}
