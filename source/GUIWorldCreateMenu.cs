using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001E6")]
public class GUIWorldCreateMenu
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40015C6")]
	private bool editingWorldSeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40015C7")]
	private string newWorldSeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40015C8")]
	public int worldSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40015C9")]
	public int evilType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40015CA")]
	public int difficulty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40015CB")]
	private float createButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40015CC")]
	private float backButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40015CD")]
	private float smallButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40015CE")]
	private float mediumButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40015CF")]
	private float largeButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40015D0")]
	private float evilRandomButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40015D1")]
	private float evilCorruptionButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40015D2")]
	private float evilCrimsonButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40015D3")]
	private float generateNameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40015D4")]
	private float generateSeedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40015D5")]
	private float randomiseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40015D6")]
	private float normalButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40015D7")]
	private float expertButtonScale;

	[Cpp2IlInjected.Token(Token = "0x40015D8")]
	private static Texture2D previewEvilRandom;

	[Cpp2IlInjected.Token(Token = "0x40015D9")]
	private static Texture2D previewEvilCorruption;

	[Cpp2IlInjected.Token(Token = "0x40015DA")]
	private static Texture2D previewEvilCrimson;

	[Cpp2IlInjected.Token(Token = "0x40015DB")]
	private static Texture2D previewSizeSmall;

	[Cpp2IlInjected.Token(Token = "0x40015DC")]
	private static Texture2D previewSizeMedium;

	[Cpp2IlInjected.Token(Token = "0x40015DD")]
	private static Texture2D previewSizeLarge;

	[Cpp2IlInjected.Token(Token = "0x40015DE")]
	private static Texture2D previewDifficultyNormalBackground;

	[Cpp2IlInjected.Token(Token = "0x40015DF")]
	private static Texture2D previewDifficultyNormalBunny;

	[Cpp2IlInjected.Token(Token = "0x40015E0")]
	private static Texture2D previewDifficultyMasterBackground;

	[Cpp2IlInjected.Token(Token = "0x40015E1")]
	private static Texture2D previewDifficultyMasterBunny;

	[Cpp2IlInjected.Token(Token = "0x40015E2")]
	private static Texture2D previewDifficultyExpertBackground;

	[Cpp2IlInjected.Token(Token = "0x40015E3")]
	private static Texture2D previewDifficultyExpertBunny;

	[Cpp2IlInjected.Token(Token = "0x40015E4")]
	private static Texture2D previewDifficultyJourneyBunny;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40015E5")]
	public string description;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40015E6")]
	private string _worldName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40015E7")]
	private string _worldSeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40015E8")]
	private GUIWorldCreateController _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40015E9")]
	private float NameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40015EA")]
	private float SeedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40015EB")]
	private float WorldScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40015EC")]
	public bool displayWorldOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
	[Cpp2IlInjected.Token(Token = "0x40015ED")]
	public bool displayDifficultyOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
	[Cpp2IlInjected.Token(Token = "0x40015EE")]
	public bool displayEvilTypeOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40015EF")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40015F0")]
	private bool optionOpenClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40015F1")]
	public float _pulldownShift;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40015F2")]
	public float _pulldownShiftDif;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40015F3")]
	public float _pulldownShiftEvil;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40015F4")]
	public int difWrapAround;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40015F5")]
	public int evilWrapAround;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40015F6")]
	public float buttonsDistance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40015F7")]
	public int difPulldownCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40015F8")]
	public int evilPulldownCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40015F9")]
	private float DifficultyScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40015FA")]
	private float EvilTypeScale;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	private string WorldDescriptionName
	{
		[Cpp2IlInjected.Token(Token = "0x6000DBC")]
		[Cpp2IlInjected.Address(RVA = "0x12B28A8", Offset = "0x12B28A8", VA = "0x12B28A8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private string WorldDescriptionSizeSmall
	{
		[Cpp2IlInjected.Token(Token = "0x6000DBD")]
		[Cpp2IlInjected.Address(RVA = "0x12B2900", Offset = "0x12B2900", VA = "0x12B2900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private string WorldDescriptionSizeMedium
	{
		[Cpp2IlInjected.Token(Token = "0x6000DBE")]
		[Cpp2IlInjected.Address(RVA = "0x12B2958", Offset = "0x12B2958", VA = "0x12B2958")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private string WorldDescriptionSizeLarge
	{
		[Cpp2IlInjected.Token(Token = "0x6000DBF")]
		[Cpp2IlInjected.Address(RVA = "0x12B29B0", Offset = "0x12B29B0", VA = "0x12B29B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private string WorldDescriptionCreative
	{
		[Cpp2IlInjected.Token(Token = "0x6000DC0")]
		[Cpp2IlInjected.Address(RVA = "0x12B2A08", Offset = "0x12B2A08", VA = "0x12B2A08")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private string WorldDescriptionNormal
	{
		[Cpp2IlInjected.Token(Token = "0x6000DC1")]
		[Cpp2IlInjected.Address(RVA = "0x12B2A60", Offset = "0x12B2A60", VA = "0x12B2A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private string WorldDescriptionExpert
	{
		[Cpp2IlInjected.Token(Token = "0x6000DC2")]
		[Cpp2IlInjected.Address(RVA = "0x12B2AB8", Offset = "0x12B2AB8", VA = "0x12B2AB8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private string WorldDescriptionMaster
	{
		[Cpp2IlInjected.Token(Token = "0x6000DC3")]
		[Cpp2IlInjected.Address(RVA = "0x12B2B10", Offset = "0x12B2B10", VA = "0x12B2B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	private string WorldDescriptionDefault
	{
		[Cpp2IlInjected.Token(Token = "0x6000DC4")]
		[Cpp2IlInjected.Address(RVA = "0x12B2B68", Offset = "0x12B2B68", VA = "0x12B2B68")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000DC5")]
	[Cpp2IlInjected.Address(RVA = "0x12B2BC0", Offset = "0x12B2BC0", VA = "0x12B2BC0")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DC6")]
	[Cpp2IlInjected.Address(RVA = "0x12B2E24", Offset = "0x12B2E24", VA = "0x12B2E24")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DC7")]
	[Cpp2IlInjected.Address(RVA = "0x12B3BD8", Offset = "0x12B3BD8", VA = "0x12B3BD8")]
	private void DrawName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DC8")]
	[Cpp2IlInjected.Address(RVA = "0x12B4720", Offset = "0x12B4720", VA = "0x12B4720")]
	private void DrawSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DC9")]
	[Cpp2IlInjected.Address(RVA = "0x12B32AC", Offset = "0x12B32AC", VA = "0x12B32AC")]
	private void DrawImage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DCA")]
	[Cpp2IlInjected.Address(RVA = "0x12B9104", Offset = "0x12B9104", VA = "0x12B9104")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DCB")]
	[Cpp2IlInjected.Address(RVA = "0x12B781C", Offset = "0x12B781C", VA = "0x12B781C")]
	private void DrawWorldSize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DCC")]
	[Cpp2IlInjected.Address(RVA = "0x12B53B4", Offset = "0x12B53B4", VA = "0x12B53B4")]
	private void DrawWorldDifficulty()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DCD")]
	[Cpp2IlInjected.Address(RVA = "0x12B6780", Offset = "0x12B6780", VA = "0x12B6780")]
	private void DrawWorldEvilType()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DCE")]
	[Cpp2IlInjected.Address(RVA = "0x12B3AD8", Offset = "0x12B3AD8", VA = "0x12B3AD8")]
	private void DrawDescription()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DCF")]
	[Cpp2IlInjected.Address(RVA = "0x12B8B74", Offset = "0x12B8B74", VA = "0x12B8B74")]
	private void EnterName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD0")]
	[Cpp2IlInjected.Address(RVA = "0x12B8CC8", Offset = "0x12B8CC8", VA = "0x12B8CC8")]
	private void CloseNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD1")]
	[Cpp2IlInjected.Address(RVA = "0x12B8D94", Offset = "0x12B8D94", VA = "0x12B8D94")]
	private void EnterSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD2")]
	[Cpp2IlInjected.Address(RVA = "0x12B8EB8", Offset = "0x12B8EB8", VA = "0x12B8EB8")]
	private void CloseSeedEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD3")]
	[Cpp2IlInjected.Address(RVA = "0x12B925C", Offset = "0x12B925C", VA = "0x12B925C")]
	public void GenerateSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD4")]
	[Cpp2IlInjected.Address(RVA = "0x12B9304", Offset = "0x12B9304", VA = "0x12B9304")]
	public void GenerateName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD5")]
	[Cpp2IlInjected.Address(RVA = "0x12B951C", Offset = "0x12B951C", VA = "0x12B951C")]
	private void ProcessSpecialSeeds(string processedSeed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD6")]
	[Cpp2IlInjected.Address(RVA = "0x12B9A6C", Offset = "0x12B9A6C", VA = "0x12B9A6C")]
	public void CreateWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD7")]
	[Cpp2IlInjected.Address(RVA = "0x12B9F04", Offset = "0x12B9F04", VA = "0x12B9F04")]
	public void CreateWorldCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD8")]
	[Cpp2IlInjected.Address(RVA = "0x12B866C", Offset = "0x12B866C", VA = "0x12B866C")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DD9")]
	[Cpp2IlInjected.Address(RVA = "0x12B5100", Offset = "0x12B5100", VA = "0x12B5100")]
	private void DrawRandomiseButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DDA")]
	[Cpp2IlInjected.Address(RVA = "0x12B9FD0", Offset = "0x12B9FD0", VA = "0x12B9FD0")]
	private void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DDB")]
	[Cpp2IlInjected.Address(RVA = "0x12B8F68", Offset = "0x12B8F68", VA = "0x12B8F68")]
	private void ProcessNewWorldSeed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DDC")]
	[Cpp2IlInjected.Address(RVA = "0x12BA0AC", Offset = "0x12BA0AC", VA = "0x12BA0AC")]
	public GUIWorldCreateMenu()
	{
	}
}
