using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class GUIWorldSelectMenu
{
	[Cpp2IlInjected.Token(Token = "0x20007F8")]
	public enum WorldRenameOption
	{
		[Cpp2IlInjected.Token(Token = "0x4007CD6")]
		DontRenameOldFormatWorlds,
		[Cpp2IlInjected.Token(Token = "0x4007CD7")]
		RenameOldFormatWithLoadSave,
		[Cpp2IlInjected.Token(Token = "0x4007CD8")]
		RenameAllFormatsWithLoadSave
	}

	[Cpp2IlInjected.Token(Token = "0x4001608")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	[Cpp2IlInjected.Token(Token = "0x4001609")]
	private const double SINGLE_CLICK_TIME = 350.0;

	[Cpp2IlInjected.Token(Token = "0x400160A")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400160B")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400160C")]
	private float BackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400160D")]
	private float NewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400160E")]
	private float PlayScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400160F")]
	private float DeleteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001610")]
	private float FavoriteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001611")]
	private float OptionsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001612")]
	private float RenameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001613")]
	private float SeedDisplayScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001614")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001615")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001616")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001617")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.Token(Token = "0x4001618")]
	public static Texture2D _dividerTexture;

	[Cpp2IlInjected.Token(Token = "0x4001619")]
	public static Texture2D _buttonCloudActiveTexture;

	[Cpp2IlInjected.Token(Token = "0x400161A")]
	public static Texture2D _buttonCloudInactiveTexture;

	[Cpp2IlInjected.Token(Token = "0x400161B")]
	public static Texture2D _buttonFavoriteActiveTexture;

	[Cpp2IlInjected.Token(Token = "0x400161C")]
	public static Texture2D _buttonFavoriteInactiveTexture;

	[Cpp2IlInjected.Token(Token = "0x400161D")]
	public static Texture2D _buttonPlayTexture;

	[Cpp2IlInjected.Token(Token = "0x400161E")]
	public static Texture2D _buttonDeleteTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400161F")]
	private int _worldCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001620")]
	public List<WorldFileData> SortedWorldData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001621")]
	private bool SeedVersionToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001622")]
	public int SelectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001623")]
	private int LastSelectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001624")]
	public string SelectedItemWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001625")]
	private DateTime LastSelectTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001626")]
	private DateTime LastTouchTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001627")]
	private Vector2 LastTouchMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001628")]
	public bool SyncingWorlds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001629")]
	private GUIControllerWorldSelect _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400162A")]
	private GUIContollerTransactionButtonList _worldListOptionsController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400162B")]
	private Texture2D everythingAnimatedIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400162C")]
	private bool allowItemClicking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400162D")]
	private Rectangle fullClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400162E")]
	private Rectangle dragClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400162F")]
	private int worldOver;

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private GUIContollerTransactionButtonList WorldListOptionsController
	{
		[Cpp2IlInjected.Token(Token = "0x6000DE7")]
		[Cpp2IlInjected.Address(RVA = "0x1167598", Offset = "0x1167598", VA = "0x1167598")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000DE8")]
	[Cpp2IlInjected.Address(RVA = "0x11676D8", Offset = "0x11676D8", VA = "0x11676D8")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DE9")]
	[Cpp2IlInjected.Address(RVA = "0x116784C", Offset = "0x116784C", VA = "0x116784C")]
	private Rectangle UpdateGlitchAnimation(WorldFileData worldData)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DEA")]
	[Cpp2IlInjected.Address(RVA = "0x1167A2C", Offset = "0x1167A2C", VA = "0x1167A2C")]
	private Texture2D GetIcon(WorldFileData worldData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000DEB")]
	[Cpp2IlInjected.Address(RVA = "0x1167CAC", Offset = "0x1167CAC", VA = "0x1167CAC")]
	private Texture2D GetSeedIcon(WorldFileData worldData, string seed)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000DEC")]
	[Cpp2IlInjected.Address(RVA = "0x1167DA8", Offset = "0x1167DA8", VA = "0x1167DA8")]
	private void PlayWorldCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DED")]
	[Cpp2IlInjected.Address(RVA = "0x1168018", Offset = "0x1168018", VA = "0x1168018")]
	public void ActionNew()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DEE")]
	[Cpp2IlInjected.Address(RVA = "0x116818C", Offset = "0x116818C", VA = "0x116818C")]
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DEF")]
	[Cpp2IlInjected.Address(RVA = "0x116837C", Offset = "0x116837C", VA = "0x116837C")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF0")]
	[Cpp2IlInjected.Address(RVA = "0x116844C", Offset = "0x116844C", VA = "0x116844C")]
	public Vector2 ItemSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF1")]
	[Cpp2IlInjected.Address(RVA = "0x11684D4", Offset = "0x11684D4", VA = "0x11684D4")]
	private void DrawWorldSync()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF2")]
	[Cpp2IlInjected.Address(RVA = "0x1168744", Offset = "0x1168744", VA = "0x1168744")]
	public void SelectAndHighlight(WorldFileData worldDataOld)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF3")]
	[Cpp2IlInjected.Address(RVA = "0x11689E4", Offset = "0x11689E4", VA = "0x11689E4")]
	private void OpenNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF4")]
	[Cpp2IlInjected.Address(RVA = "0x1168A80", Offset = "0x1168A80", VA = "0x1168A80")]
	private void CloseNameEditAndSaveIf()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF5")]
	[Cpp2IlInjected.Address(RVA = "0x1168D00", Offset = "0x1168D00", VA = "0x1168D00")]
	private void CloseNameEditIf()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF6")]
	[Cpp2IlInjected.Address(RVA = "0x1168C98", Offset = "0x1168C98", VA = "0x1168C98")]
	private void CloseNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF7")]
	[Cpp2IlInjected.Address(RVA = "0x1168D70", Offset = "0x1168D70", VA = "0x1168D70")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF8")]
	[Cpp2IlInjected.Address(RVA = "0x116A224", Offset = "0x116A224", VA = "0x116A224")]
	public void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DF9")]
	[Cpp2IlInjected.Address(RVA = "0x116A4B4", Offset = "0x116A4B4", VA = "0x116A4B4")]
	private void DrawWorld(WorldFileData worldData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DFA")]
	[Cpp2IlInjected.Address(RVA = "0x116A770", Offset = "0x116A770", VA = "0x116A770")]
	private void WorldDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DFB")]
	[Cpp2IlInjected.Address(RVA = "0x1167EA4", Offset = "0x1167EA4", VA = "0x1167EA4")]
	private void PlayWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DFC")]
	[Cpp2IlInjected.Address(RVA = "0x116C0CC", Offset = "0x116C0CC", VA = "0x116C0CC")]
	public void SortWorlds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DFD")]
	[Cpp2IlInjected.Address(RVA = "0x116C254", Offset = "0x116C254", VA = "0x116C254")]
	private int SortEntry(WorldFileData a, WorldFileData b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DFE")]
	[Cpp2IlInjected.Address(RVA = "0x116A3F4", Offset = "0x116A3F4", VA = "0x116A3F4")]
	private bool CanWorldBePlayed(WorldFileData world)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DFF")]
	[Cpp2IlInjected.Address(RVA = "0x116C3D8", Offset = "0x116C3D8", VA = "0x116C3D8")]
	private float WorldScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E00")]
	[Cpp2IlInjected.Address(RVA = "0x116C3E0", Offset = "0x116C3E0", VA = "0x116C3E0")]
	private void WorldOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E01")]
	[Cpp2IlInjected.Address(RVA = "0x116C33C", Offset = "0x116C33C", VA = "0x116C33C")]
	public int CompareNatural(string strA, string strB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E02")]
	[Cpp2IlInjected.Address(RVA = "0x116C4D4", Offset = "0x116C4D4", VA = "0x116C4D4")]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E03")]
	[Cpp2IlInjected.Address(RVA = "0x116CD74", Offset = "0x116CD74", VA = "0x116CD74")]
	public GUIWorldSelectMenu()
	{
	}
}
