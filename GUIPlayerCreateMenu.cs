using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20001DD")]
public class GUIPlayerCreateMenu
{
	[Cpp2IlInjected.Token(Token = "0x20007F4")]
	public enum ItemSelection
	{
		[Cpp2IlInjected.Token(Token = "0x4007CC6")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4007CC7")]
		Gender,
		[Cpp2IlInjected.Token(Token = "0x4007CC8")]
		Skin,
		[Cpp2IlInjected.Token(Token = "0x4007CC9")]
		Eyes,
		[Cpp2IlInjected.Token(Token = "0x4007CCA")]
		ChangeHair,
		[Cpp2IlInjected.Token(Token = "0x4007CCB")]
		Hair,
		[Cpp2IlInjected.Token(Token = "0x4007CCC")]
		Shirt,
		[Cpp2IlInjected.Token(Token = "0x4007CCD")]
		Undershirt,
		[Cpp2IlInjected.Token(Token = "0x4007CCE")]
		Pants,
		[Cpp2IlInjected.Token(Token = "0x4007CCF")]
		Shoes
	}

	[Cpp2IlInjected.Token(Token = "0x40014D7")]
	public static Texture2D _maleTexture;

	[Cpp2IlInjected.Token(Token = "0x40014D8")]
	public static Texture2D _femaleTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40014D9")]
	public bool editingPlayerName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40014DA")]
	public bool editPlayerNameForCreate;

	[Cpp2IlInjected.Token(Token = "0x40014DB")]
	public static Texture2D _eyeTexture;

	[Cpp2IlInjected.Token(Token = "0x40014DC")]
	public static Texture2D _hairTexture;

	[Cpp2IlInjected.Token(Token = "0x40014DD")]
	public static Texture2D _HairStyleTexture;

	[Cpp2IlInjected.Token(Token = "0x40014DE")]
	public static Texture2D _pantsTexture;

	[Cpp2IlInjected.Token(Token = "0x40014DF")]
	public static Texture2D _shirtTexture;

	[Cpp2IlInjected.Token(Token = "0x40014E0")]
	public static Texture2D _shoesTexture;

	[Cpp2IlInjected.Token(Token = "0x40014E1")]
	public static Texture2D _skinTexture;

	[Cpp2IlInjected.Token(Token = "0x40014E2")]
	public static Texture2D _undershirtTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40014E3")]
	public ItemSelection CurrentSelection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40014E4")]
	private float shirtButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40014E5")]
	private float underShirtButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40014E6")]
	private float pantsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40014E7")]
	private float shoesButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40014E8")]
	private float hairButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40014E9")]
	private float changeHairButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40014EA")]
	private float infoButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40014EB")]
	private float eyesButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40014EC")]
	private float skinButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40014ED")]
	private float genderButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40014EE")]
	private float createButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40014EF")]
	private float randomButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40014F0")]
	private float backButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40014F1")]
	private float maleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40014F2")]
	private float femaleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40014F3")]
	private float randomiseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40014F4")]
	public float hairScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40014F5")]
	private float hairScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40014F6")]
	private int hairScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40014F7")]
	private Vector2 hairDragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40014F8")]
	private int hairOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40014F9")]
	private string _playerName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40014FA")]
	private string editPlayerName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40014FB")]
	private int[] actualStyleOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40014FC")]
	private GUIPlayerCreateController _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40014FD")]
	private float NameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40014FE")]
	private float DifficultyScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40014FF")]
	private float TypeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001500")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001501")]
	public bool displayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001502")]
	private string typeDescription;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001503")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001504")]
	private bool optionOpenClicked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001505")]
	public float _pulldownShift;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4001506")]
	private int StyleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4001507")]
	private Vector2 CharacterStyleOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4001508")]
	private int styleOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4001509")]
	private Vector2 CharacterDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400150A")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400150B")]
	private GUISlider.DragState hueDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400150C")]
	private GUISlider.DragState satDragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400150D")]
	private GUISlider.DragState lightDragState;

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x1143228", Offset = "0x1143228", VA = "0x1143228")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x1143408", Offset = "0x1143408", VA = "0x1143408")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x1149014", Offset = "0x1149014", VA = "0x1149014")]
	private void UpdateAnim(Player player, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x1145204", Offset = "0x1145204", VA = "0x1145204")]
	private void DrawPlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x11490FC", Offset = "0x11490FC", VA = "0x11490FC")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x1145428", Offset = "0x1145428", VA = "0x1145428")]
	private void DrawInfo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x11455EC", Offset = "0x11455EC", VA = "0x11455EC")]
	private void DrawName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x1146054", Offset = "0x1146054", VA = "0x1146054")]
	private void DrawDifficulty()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x114725C", Offset = "0x114725C", VA = "0x114725C")]
	private void DrawStylesGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x1147674", Offset = "0x1147674", VA = "0x1147674")]
	private void DrawHairGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x1149850", Offset = "0x1149850", VA = "0x1149850")]
	public float StyleScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x1149858", Offset = "0x1149858", VA = "0x1149858")]
	public void StyleOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x11499F8", Offset = "0x11499F8", VA = "0x11499F8")]
	public void StyleDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x1149D9C", Offset = "0x1149D9C", VA = "0x1149D9C")]
	public float HairScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D29")]
	[Cpp2IlInjected.Address(RVA = "0x1149DF8", Offset = "0x1149DF8", VA = "0x1149DF8")]
	public void HairOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x1149FA4", Offset = "0x1149FA4", VA = "0x1149FA4")]
	public void HairDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x114AA74", Offset = "0x114AA74", VA = "0x114AA74")]
	private void DrawSelectedPlayer(Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x114ABD8", Offset = "0x114ABD8", VA = "0x114ABD8")]
	private void DrawSelectedHighlight(Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x114ABDC", Offset = "0x114ABDC", VA = "0x114ABDC")]
	private void DrawSelectedHair(Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x114B0E8", Offset = "0x114B0E8", VA = "0x114B0E8")]
	public void CreateAndSave()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x114B6B4", Offset = "0x114B6B4", VA = "0x114B6B4")]
	private void CreatePlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x11495EC", Offset = "0x11495EC", VA = "0x11495EC")]
	private void EnterName()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x1149718", Offset = "0x1149718", VA = "0x1149718")]
	private void CloseNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x11497CC", Offset = "0x11497CC", VA = "0x11497CC")]
	private void CloseOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x1149104", Offset = "0x1149104", VA = "0x1149104")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x1144F38", Offset = "0x1144F38", VA = "0x1144F38")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x114B7A4", Offset = "0x114B7A4", VA = "0x114B7A4")]
	private void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x11436E0", Offset = "0x11436E0", VA = "0x11436E0")]
	private void DrawCategoryButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x114B888", Offset = "0x114B888", VA = "0x114B888")]
	public void Setup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x114921C", Offset = "0x114921C", VA = "0x114921C")]
	public void RandomisePlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x1147AD4", Offset = "0x1147AD4", VA = "0x1147AD4")]
	private void DrawHSLSlider()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x114B1E8", Offset = "0x114B1E8", VA = "0x114B1E8")]
	private void SetupStartingItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x114B954", Offset = "0x114B954", VA = "0x114B954")]
	public GUIPlayerCreateMenu()
	{
	}
}
