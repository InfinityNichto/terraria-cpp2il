using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200019B RID: 411
[global::Cpp2ILInjected.Token(Token = "0x2000229")]
public class NPCDialogue_Layout : LayoutDefinition
{
	// Token: 0x06000BCF RID: 3023 RVA: 0x00023EB2 File Offset: 0x000220B2
	[global::Cpp2ILInjected.Token(Token = "0x6000CE8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D10DC", Offset = "0x9D10DC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00023EB5 File Offset: 0x000220B5
	[global::Cpp2ILInjected.Token(Token = "0x6000CE9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1128", Offset = "0x9D1128", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public NPCDialogue_Layout()
	{
		throw null;
	}

	// Token: 0x0400112A RID: 4394
	[global::Cpp2ILInjected.Token(Token = "0x40015C4")]
	public static NPCDialogue_Layout Instance;

	// Token: 0x0400112B RID: 4395
	[global::Cpp2ILInjected.Token(Token = "0x40015C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int BackingTextPadding;

	// Token: 0x0400112C RID: 4396
	[global::Cpp2ILInjected.Token(Token = "0x40015C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int BackingTextPaddingController;

	// Token: 0x0400112D RID: 4397
	[global::Cpp2ILInjected.Token(Token = "0x40015C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int MinTextHeight;

	// Token: 0x0400112E RID: 4398
	[global::Cpp2ILInjected.Token(Token = "0x40015C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int TextBackingOffset;

	// Token: 0x0400112F RID: 4399
	[global::Cpp2ILInjected.Token(Token = "0x40015C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int MaxWidthLastLineAddition;

	// Token: 0x04001130 RID: 4400
	[global::Cpp2ILInjected.Token(Token = "0x40015CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout Backing;

	// Token: 0x04001131 RID: 4401
	[global::Cpp2ILInjected.Token(Token = "0x40015CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout Text;

	// Token: 0x04001132 RID: 4402
	[global::Cpp2ILInjected.Token(Token = "0x40015CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout TextBacking;

	// Token: 0x04001133 RID: 4403
	[global::Cpp2ILInjected.Token(Token = "0x40015CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout MenuDivider;

	// Token: 0x04001134 RID: 4404
	[global::Cpp2ILInjected.Token(Token = "0x40015CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	// Token: 0x04001135 RID: 4405
	[global::Cpp2ILInjected.Token(Token = "0x40015CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Option1;

	// Token: 0x04001136 RID: 4406
	[global::Cpp2ILInjected.Token(Token = "0x40015D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Option2;

	// Token: 0x04001137 RID: 4407
	[global::Cpp2ILInjected.Token(Token = "0x40015D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Happiness;

	// Token: 0x04001138 RID: 4408
	[global::Cpp2ILInjected.Token(Token = "0x40015D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout Option1Cost;

	// Token: 0x04001139 RID: 4409
	[global::Cpp2ILInjected.Token(Token = "0x40015D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout Option1CostController;

	// Token: 0x0400113A RID: 4410
	[global::Cpp2ILInjected.Token(Token = "0x40015D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout CornerImage;

	// Token: 0x0400113B RID: 4411
	[global::Cpp2ILInjected.Token(Token = "0x40015D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout CornerImageController;

	// Token: 0x0400113C RID: 4412
	[global::Cpp2ILInjected.Token(Token = "0x40015D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout CornerText;

	// Token: 0x0400113D RID: 4413
	[global::Cpp2ILInjected.Token(Token = "0x40015D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout CornerTextController;

	// Token: 0x0400113E RID: 4414
	[global::Cpp2ILInjected.Token(Token = "0x40015D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public String_Layout DialogueItemName;

	// Token: 0x0400113F RID: 4415
	[global::Cpp2ILInjected.Token(Token = "0x40015D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Panel_Layout DialogueItemNameDivider;

	// Token: 0x04001140 RID: 4416
	[global::Cpp2ILInjected.Token(Token = "0x40015DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Panel_Layout DialogueItem;

	// Token: 0x04001141 RID: 4417
	[global::Cpp2ILInjected.Token(Token = "0x40015DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Panel_Layout DialogueItemBacking;

	// Token: 0x04001142 RID: 4418
	[global::Cpp2ILInjected.Token(Token = "0x40015DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public NPCDialogue_Layout.Icons_Layout Icons;

	// Token: 0x020007EF RID: 2031
	[global::Cpp2ILInjected.Token(Token = "0x200022A")]
	[Serializable]
	public class Icons_Layout
	{
		// Token: 0x060048EC RID: 18668 RVA: 0x0002EF19 File Offset: 0x0002D119
		[global::Cpp2ILInjected.Token(Token = "0x6000CEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D1188", Offset = "0x9D1188", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Icons_Layout()
		{
			throw null;
		}

		// Token: 0x04007C64 RID: 31844
		[global::Cpp2ILInjected.Token(Token = "0x40015DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Texture_Layout SaveIcon;

		// Token: 0x04007C65 RID: 31845
		[global::Cpp2ILInjected.Token(Token = "0x40015DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Texture_Layout EditIcon;

		// Token: 0x04007C66 RID: 31846
		[global::Cpp2ILInjected.Token(Token = "0x40015DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Texture_Layout ShopIcon;

		// Token: 0x04007C67 RID: 31847
		[global::Cpp2ILInjected.Token(Token = "0x40015E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Texture_Layout StatusIcon;

		// Token: 0x04007C68 RID: 31848
		[global::Cpp2ILInjected.Token(Token = "0x40015E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Texture_Layout StatusIconShimmered;

		// Token: 0x04007C69 RID: 31849
		[global::Cpp2ILInjected.Token(Token = "0x40015E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Texture_Layout StrangePlantsIcon;

		// Token: 0x04007C6A RID: 31850
		[global::Cpp2ILInjected.Token(Token = "0x40015E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Texture_Layout StrangePlantsIconShimmered;

		// Token: 0x04007C6B RID: 31851
		[global::Cpp2ILInjected.Token(Token = "0x40015E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Texture_Layout HairIcon;

		// Token: 0x04007C6C RID: 31852
		[global::Cpp2ILInjected.Token(Token = "0x40015E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public Texture_Layout HairIconShimmered;

		// Token: 0x04007C6D RID: 31853
		[global::Cpp2ILInjected.Token(Token = "0x40015E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public Texture_Layout HealIcon;

		// Token: 0x04007C6E RID: 31854
		[global::Cpp2ILInjected.Token(Token = "0x40015E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public Texture_Layout HealIconShimmered;

		// Token: 0x04007C6F RID: 31855
		[global::Cpp2ILInjected.Token(Token = "0x40015E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public Texture_Layout CollectIcon;

		// Token: 0x04007C70 RID: 31856
		[global::Cpp2ILInjected.Token(Token = "0x40015E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public Texture_Layout CollectIconShimmered;

		// Token: 0x04007C71 RID: 31857
		[global::Cpp2ILInjected.Token(Token = "0x40015EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public Texture_Layout ReforgeIcon;

		// Token: 0x04007C72 RID: 31858
		[global::Cpp2ILInjected.Token(Token = "0x40015EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public Texture_Layout ReforgeIconShimmered;

		// Token: 0x04007C73 RID: 31859
		[global::Cpp2ILInjected.Token(Token = "0x40015EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public Texture_Layout CraftIcon;

		// Token: 0x04007C74 RID: 31860
		[global::Cpp2ILInjected.Token(Token = "0x40015ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public Texture_Layout HelpIcon;

		// Token: 0x04007C75 RID: 31861
		[global::Cpp2ILInjected.Token(Token = "0x40015EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public Texture_Layout CurseIcon;

		// Token: 0x04007C76 RID: 31862
		[global::Cpp2ILInjected.Token(Token = "0x40015EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Texture_Layout QuestIcon;

		// Token: 0x04007C77 RID: 31863
		[global::Cpp2ILInjected.Token(Token = "0x40015F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public Texture_Layout QuestIconShimmered;

		// Token: 0x04007C78 RID: 31864
		[global::Cpp2ILInjected.Token(Token = "0x40015F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public Texture_Layout BartenderIcon;

		// Token: 0x04007C79 RID: 31865
		[global::Cpp2ILInjected.Token(Token = "0x40015F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public Texture_Layout BartenderIconShimmered;

		// Token: 0x04007C7A RID: 31866
		[global::Cpp2ILInjected.Token(Token = "0x40015F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public Texture_Layout PetIcon;

		// Token: 0x04007C7B RID: 31867
		[global::Cpp2ILInjected.Token(Token = "0x40015F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public Texture_Layout MusicIcon;

		// Token: 0x04007C7C RID: 31868
		[global::Cpp2ILInjected.Token(Token = "0x40015F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public Texture_Layout MusicIconShimmered;

		// Token: 0x04007C7D RID: 31869
		[global::Cpp2ILInjected.Token(Token = "0x40015F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public Texture_Layout PainterIcon;

		// Token: 0x04007C7E RID: 31870
		[global::Cpp2ILInjected.Token(Token = "0x40015F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public Texture_Layout PainterIconShimmered;
	}
}
