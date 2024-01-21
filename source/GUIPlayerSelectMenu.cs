using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20001DF")]
public class GUIPlayerSelectMenu
{
	[Cpp2IlInjected.Token(Token = "0x4001510")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	[Cpp2IlInjected.Token(Token = "0x4001511")]
	private const double SINGLE_CLICK_TIME = 350.0;

	[Cpp2IlInjected.Token(Token = "0x4001512")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001513")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001514")]
	private float BackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001515")]
	private float NewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001516")]
	private float PlayScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001517")]
	private float EditNameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001518")]
	private float OptionsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001519")]
	private float DeleteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400151A")]
	private float FavoriteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400151B")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400151C")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400151D")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400151E")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400151F")]
	public bool SyncingPlayers;

	[Cpp2IlInjected.Token(Token = "0x4001520")]
	private static Texture2D _dividerTexture;

	[Cpp2IlInjected.Token(Token = "0x4001521")]
	private static Texture2D _buttonCloudActiveTexture;

	[Cpp2IlInjected.Token(Token = "0x4001522")]
	private static Texture2D _buttonCloudInactiveTexture;

	[Cpp2IlInjected.Token(Token = "0x4001523")]
	private static Texture2D _buttonFavoriteActiveTexture;

	[Cpp2IlInjected.Token(Token = "0x4001524")]
	private static Texture2D _buttonFavoriteInactiveTexture;

	[Cpp2IlInjected.Token(Token = "0x4001525")]
	private static Texture2D _buttonPlayTexture;

	[Cpp2IlInjected.Token(Token = "0x4001526")]
	private static Texture2D _buttonDeleteTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001527")]
	private int _playerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001528")]
	public List<PlayerFileData> SortedPlayerData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001529")]
	private Rectangle SelectedItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400152A")]
	public int SelectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400152B")]
	public string SelectedItemPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400152C")]
	private DateTime LastSelectTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400152D")]
	private DateTime LastTouchTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400152E")]
	private Vector2 LastTouchMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400152F")]
	private float NameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4001530")]
	public bool allowItemClicking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4001531")]
	private GUIControllerPlayerSelect _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001532")]
	private GUIContollerTransactionButtonList _playerListOptionsController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001533")]
	private Rectangle fullClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001534")]
	private Rectangle dragClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4001535")]
	private Vector2 CharacterOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4001536")]
	private Item _blankItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4001537")]
	private int SelectedItemForTextEdit;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4001538")]
	private int playerOver;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private GUIContollerTransactionButtonList PlayerListOptionsController
	{
		[Cpp2IlInjected.Token(Token = "0x6000D41")]
		[Cpp2IlInjected.Address(RVA = "0xE261BC", Offset = "0xE261BC", VA = "0xE261BC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0xE25FA4", Offset = "0xE25FA4", VA = "0xE25FA4")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xE25FAC", Offset = "0xE25FAC", VA = "0xE25FAC")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0xE26120", Offset = "0xE26120", VA = "0xE26120")]
	public void ActionNew()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0xE262FC", Offset = "0xE262FC", VA = "0xE262FC")]
	private void DrawPlayerSync()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0xE2656C", Offset = "0xE2656C", VA = "0xE2656C")]
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0xE2675C", Offset = "0xE2675C", VA = "0xE2675C")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0xE2682C", Offset = "0xE2682C", VA = "0xE2682C")]
	public Vector2 ItemSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0xE268B4", Offset = "0xE268B4", VA = "0xE268B4")]
	public void SelectAndHighlight(PlayerFileData playerData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0xE26A24", Offset = "0xE26A24", VA = "0xE26A24")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0xE27D04", Offset = "0xE27D04", VA = "0xE27D04")]
	public void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0xE28158", Offset = "0xE28158", VA = "0xE28158")]
	private void UpdateAnim(Player player, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0xE28320", Offset = "0xE28320", VA = "0xE28320")]
	private void DrawPlayer(Player player, Projectile pet, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0xE285A0", Offset = "0xE285A0", VA = "0xE285A0")]
	public void DrawPet(Player player, Projectile proj, Vector2 playerPosition, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0xE28964", Offset = "0xE28964", VA = "0xE28964")]
	public void DrawPlayerUI(Player player, Vector2 origin, Vector2 size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0xE29028", Offset = "0xE29028", VA = "0xE29028")]
	public void RefreshPlayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0xE27F40", Offset = "0xE27F40", VA = "0xE27F40")]
	private void OpenNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0xE27FE4", Offset = "0xE27FE4", VA = "0xE27FE4")]
	private void CloseNameEditAndSave()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0xE27EC8", Offset = "0xE27EC8", VA = "0xE27EC8")]
	private bool CloseNameEditIf()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0xE29170", Offset = "0xE29170", VA = "0xE29170")]
	private void CloseNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0xE291D8", Offset = "0xE291D8", VA = "0xE291D8")]
	private void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0xE2AC6C", Offset = "0xE2AC6C", VA = "0xE2AC6C")]
	public void SortPlayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0xE2AEB4", Offset = "0xE2AEB4", VA = "0xE2AEB4")]
	private int SortEntry(PlayerFileData a, PlayerFileData b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0xE2AF9C", Offset = "0xE2AF9C", VA = "0xE2AF9C")]
	private float PlayerScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0xE2AFA4", Offset = "0xE2AFA4", VA = "0xE2AFA4")]
	private void PlayerOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0xE2AF00", Offset = "0xE2AF00", VA = "0xE2AF00")]
	public int CompareNatural(string strA, string strB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0xE2B098", Offset = "0xE2B098", VA = "0xE2B098")]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0xE2B938", Offset = "0xE2B938", VA = "0xE2B938")]
	public GUIPlayerSelectMenu()
	{
	}
}
