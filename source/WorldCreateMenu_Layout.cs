using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000222")]
public class WorldCreateMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CD7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0870", Offset = "0x9D0870", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CD8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D08BC", Offset = "0x9D08BC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public WorldCreateMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400152A")]
	public static WorldCreateMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400152B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x400152C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	[global::Cpp2ILInjected.Token(Token = "0x400152D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Image;

	[global::Cpp2ILInjected.Token(Token = "0x400152E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout WorldName;

	[global::Cpp2ILInjected.Token(Token = "0x400152F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout NameTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001530")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout WorldNameEdit;

	[global::Cpp2ILInjected.Token(Token = "0x4001531")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout GenerateName;

	[global::Cpp2ILInjected.Token(Token = "0x4001532")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public int WorldNameMaxLength;

	[global::Cpp2ILInjected.Token(Token = "0x4001533")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout WorldSeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001534")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout SeedTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001535")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public String_Layout SeedEdit;

	[global::Cpp2ILInjected.Token(Token = "0x4001536")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout GenerateSeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001537")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001538")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout WorldSizeTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001539")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout WorldValue;

	[global::Cpp2ILInjected.Token(Token = "0x400153A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x400153B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout WorldOptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400153C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout Small;

	[global::Cpp2ILInjected.Token(Token = "0x400153D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout Medium;

	[global::Cpp2ILInjected.Token(Token = "0x400153E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout Large;

	[global::Cpp2ILInjected.Token(Token = "0x400153F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public String_Layout DifficultyTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001540")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout DifficultyValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001541")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout DifficultyOptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001542")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout Journey;

	[global::Cpp2ILInjected.Token(Token = "0x4001543")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout Normal;

	[global::Cpp2ILInjected.Token(Token = "0x4001544")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout Expert;

	[global::Cpp2ILInjected.Token(Token = "0x4001545")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout Master;

	[global::Cpp2ILInjected.Token(Token = "0x4001546")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public String_Layout EvilTypeTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001547")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public TransactionButton_Layout EvilTypeValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001548")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Panel_Layout EvilTypeOptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001549")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout EvilRandom;

	[global::Cpp2ILInjected.Token(Token = "0x400154A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public TransactionButton_Layout EvilCorruption;

	[global::Cpp2ILInjected.Token(Token = "0x400154B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public TransactionButton_Layout EvilCrimson;

	[global::Cpp2ILInjected.Token(Token = "0x400154C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x400154D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public TransactionButton_Layout Description;

	[global::Cpp2ILInjected.Token(Token = "0x400154E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public TransactionButton_Layout Create;

	[global::Cpp2ILInjected.Token(Token = "0x400154F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout Back;

	[global::Cpp2ILInjected.Token(Token = "0x4001550")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout Randomise;
}
