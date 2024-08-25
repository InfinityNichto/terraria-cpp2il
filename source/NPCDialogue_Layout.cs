using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000229")]
public class NPCDialogue_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CE8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D10DC", Offset = "0x9D10DC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CE9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1128", Offset = "0x9D1128", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public NPCDialogue_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40015C4")]
	public static NPCDialogue_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40015C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int BackingTextPadding;

	[global::Cpp2ILInjected.Token(Token = "0x40015C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int BackingTextPaddingController;

	[global::Cpp2ILInjected.Token(Token = "0x40015C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MinTextHeight;

	[global::Cpp2ILInjected.Token(Token = "0x40015C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int TextBackingOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40015C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int MaxWidthLastLineAddition;

	[global::Cpp2ILInjected.Token(Token = "0x40015CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40015CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Text;

	[global::Cpp2ILInjected.Token(Token = "0x40015CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout TextBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40015CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40015CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x40015CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Option1;

	[global::Cpp2ILInjected.Token(Token = "0x40015D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Option2;

	[global::Cpp2ILInjected.Token(Token = "0x40015D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Happiness;

	[global::Cpp2ILInjected.Token(Token = "0x40015D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout Option1Cost;

	[global::Cpp2ILInjected.Token(Token = "0x40015D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout Option1CostController;

	[global::Cpp2ILInjected.Token(Token = "0x40015D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout CornerImage;

	[global::Cpp2ILInjected.Token(Token = "0x40015D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout CornerImageController;

	[global::Cpp2ILInjected.Token(Token = "0x40015D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout CornerText;

	[global::Cpp2ILInjected.Token(Token = "0x40015D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout CornerTextController;

	[global::Cpp2ILInjected.Token(Token = "0x40015D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout DialogueItemName;

	[global::Cpp2ILInjected.Token(Token = "0x40015D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout DialogueItemNameDivider;

	[global::Cpp2ILInjected.Token(Token = "0x40015DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout DialogueItem;

	[global::Cpp2ILInjected.Token(Token = "0x40015DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout DialogueItemBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40015DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public NPCDialogue_Layout.Icons_Layout Icons;

	[global::Cpp2ILInjected.Token(Token = "0x200022A")]
	[Serializable]
	public class Icons_Layout
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1188", Offset = "0x9D1188", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Icons_Layout()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40015DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Texture_Layout SaveIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Texture_Layout EditIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Texture_Layout ShopIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Texture_Layout StatusIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Texture_Layout StatusIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Texture_Layout StrangePlantsIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Texture_Layout StrangePlantsIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Texture_Layout HairIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public Texture_Layout HairIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public Texture_Layout HealIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Texture_Layout HealIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public Texture_Layout CollectIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Texture_Layout CollectIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public Texture_Layout ReforgeIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public Texture_Layout ReforgeIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public Texture_Layout CraftIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public Texture_Layout HelpIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public Texture_Layout CurseIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Texture_Layout QuestIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public Texture_Layout QuestIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public Texture_Layout BartenderIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public Texture_Layout BartenderIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public Texture_Layout PetIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public Texture_Layout MusicIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Texture_Layout MusicIconShimmered;

		[global::Cpp2ILInjected.Token(Token = "0x40015F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Texture_Layout PainterIcon;

		[global::Cpp2ILInjected.Token(Token = "0x40015F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Texture_Layout PainterIconShimmered;
	}
}
