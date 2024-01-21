using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200019B")]
public class NPCDialogue_Layout : LayoutDefinition
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007E6")]
	public class Icons_Layout
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007C51")]
		public Texture_Layout SaveIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007C52")]
		public Texture_Layout EditIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007C53")]
		public Texture_Layout ShopIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007C54")]
		public Texture_Layout StatusIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007C55")]
		public Texture_Layout StatusIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007C56")]
		public Texture_Layout StrangePlantsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007C57")]
		public Texture_Layout StrangePlantsIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007C58")]
		public Texture_Layout HairIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007C59")]
		public Texture_Layout HairIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007C5A")]
		public Texture_Layout HealIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007C5B")]
		public Texture_Layout HealIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007C5C")]
		public Texture_Layout CollectIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007C5D")]
		public Texture_Layout CollectIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007C5E")]
		public Texture_Layout ReforgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007C5F")]
		public Texture_Layout ReforgeIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4007C60")]
		public Texture_Layout CraftIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007C61")]
		public Texture_Layout HelpIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4007C62")]
		public Texture_Layout CurseIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007C63")]
		public Texture_Layout QuestIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007C64")]
		public Texture_Layout QuestIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007C65")]
		public Texture_Layout BartenderIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007C66")]
		public Texture_Layout BartenderIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007C67")]
		public Texture_Layout PetIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007C68")]
		public Texture_Layout MusicIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007C69")]
		public Texture_Layout MusicIconShimmered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4007C6A")]
		public Texture_Layout PainterIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4007C6B")]
		public Texture_Layout PainterIconShimmered;

		[Cpp2IlInjected.Token(Token = "0x6004922")]
		[Cpp2IlInjected.Address(RVA = "0x10B2B24", Offset = "0x10B2B24", VA = "0x10B2B24")]
		public Icons_Layout()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001130")]
	public static NPCDialogue_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001131")]
	public int BackingTextPadding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001132")]
	public int BackingTextPaddingController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001133")]
	public int MinTextHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001134")]
	public int TextBackingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001135")]
	public int MaxWidthLastLineAddition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001136")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001137")]
	public String_Layout Text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001138")]
	public Panel_Layout TextBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001139")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400113A")]
	public TransactionButton_Layout Close;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400113B")]
	public TransactionButton_Layout Option1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400113C")]
	public TransactionButton_Layout Option2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400113D")]
	public TransactionButton_Layout Happiness;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400113E")]
	public String_Layout Option1Cost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400113F")]
	public String_Layout Option1CostController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001140")]
	public TransactionButton_Layout CornerImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001141")]
	public TransactionButton_Layout CornerImageController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001142")]
	public String_Layout CornerText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001143")]
	public String_Layout CornerTextController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001144")]
	public String_Layout DialogueItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001145")]
	public Panel_Layout DialogueItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001146")]
	public Panel_Layout DialogueItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001147")]
	public Panel_Layout DialogueItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001148")]
	public Icons_Layout Icons;

	[Cpp2IlInjected.Token(Token = "0x6000BE0")]
	[Cpp2IlInjected.Address(RVA = "0x10B2A44", Offset = "0x10B2A44", VA = "0x10B2A44")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE1")]
	[Cpp2IlInjected.Address(RVA = "0x10B2AA0", Offset = "0x10B2AA0", VA = "0x10B2AA0")]
	public NPCDialogue_Layout()
	{
	}
}
