using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20001F6")]
public class GUISaveSynchronisation_FileList
{
	[Cpp2IlInjected.Token(Token = "0x20007FC")]
	private enum Filter
	{
		[Cpp2IlInjected.Token(Token = "0x4007CDA")]
		LocalPlayers,
		[Cpp2IlInjected.Token(Token = "0x4007CDB")]
		LocalWorlds,
		[Cpp2IlInjected.Token(Token = "0x4007CDC")]
		ServerPlayers,
		[Cpp2IlInjected.Token(Token = "0x4007CDD")]
		ServerWorlds
	}

	[Cpp2IlInjected.Token(Token = "0x4001718")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	[Cpp2IlInjected.Token(Token = "0x4001719")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	[Cpp2IlInjected.Token(Token = "0x400171A")]
	private static GUIControllerSaveSynchronisation_FileListWorld _worldController;

	[Cpp2IlInjected.Token(Token = "0x400171B")]
	private static GUIControllerSaveSynchronisation_FileListPlayer _playerController;

	[Cpp2IlInjected.Token(Token = "0x400171C")]
	private static Filter CurrentFilter;

	[Cpp2IlInjected.Token(Token = "0x400171D")]
	private static Vector2 CharacterOffset;

	[Cpp2IlInjected.Token(Token = "0x400171E")]
	private static int playerOver;

	[Cpp2IlInjected.Token(Token = "0x400171F")]
	public static List<PlayerFileData> SortedPlayerData;

	[Cpp2IlInjected.Token(Token = "0x4001720")]
	public static int SelectedPlayerItem;

	[Cpp2IlInjected.Token(Token = "0x4001721")]
	public static float ScrollOffset;

	[Cpp2IlInjected.Token(Token = "0x4001722")]
	private static float ScrollMomentum;

	[Cpp2IlInjected.Token(Token = "0x4001723")]
	private static int ScrollDragging;

	[Cpp2IlInjected.Token(Token = "0x4001724")]
	private static Vector2 DragOffset;

	[Cpp2IlInjected.Token(Token = "0x4001725")]
	private static int worldOver;

	[Cpp2IlInjected.Token(Token = "0x4001726")]
	public static List<WorldFileData> SortedWorldData;

	[Cpp2IlInjected.Token(Token = "0x4001727")]
	public static int SelectedWorldItem;

	[Cpp2IlInjected.Token(Token = "0x4001728")]
	private static DateTime LastSelectTime;

	[Cpp2IlInjected.Token(Token = "0x4001729")]
	private static DateTime LastTouchTime;

	[Cpp2IlInjected.Token(Token = "0x400172A")]
	private static Vector2 LastTouchMouse;

	[Cpp2IlInjected.Token(Token = "0x6000E77")]
	[Cpp2IlInjected.Address(RVA = "0x115FD60", Offset = "0x115FD60", VA = "0x115FD60")]
	public static void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E78")]
	[Cpp2IlInjected.Address(RVA = "0x1160E30", Offset = "0x1160E30", VA = "0x1160E30")]
	private static void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E79")]
	[Cpp2IlInjected.Address(RVA = "0x1162148", Offset = "0x1162148", VA = "0x1162148")]
	private static void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E7A")]
	[Cpp2IlInjected.Address(RVA = "0x11621C8", Offset = "0x11621C8", VA = "0x11621C8")]
	private static void UpdateAnim(Player player, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E7B")]
	[Cpp2IlInjected.Address(RVA = "0x11622B0", Offset = "0x11622B0", VA = "0x11622B0")]
	private static void DrawPlayer(Player player, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E7C")]
	[Cpp2IlInjected.Address(RVA = "0x115FFE8", Offset = "0x115FFE8", VA = "0x115FFE8")]
	private static void DrawPlayers(List<PlayerFileData> playerFiles)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E7D")]
	[Cpp2IlInjected.Address(RVA = "0x11624B0", Offset = "0x11624B0", VA = "0x11624B0")]
	private static float PlayerScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E7E")]
	[Cpp2IlInjected.Address(RVA = "0x11624B8", Offset = "0x11624B8", VA = "0x11624B8")]
	private static void PlayerOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E7F")]
	[Cpp2IlInjected.Address(RVA = "0x11625D8", Offset = "0x11625D8", VA = "0x11625D8")]
	private static void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E80")]
	[Cpp2IlInjected.Address(RVA = "0x1160728", Offset = "0x1160728", VA = "0x1160728")]
	private static void DrawWorlds(List<WorldFileData> worldFiles)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E81")]
	[Cpp2IlInjected.Address(RVA = "0x1163B58", Offset = "0x1163B58", VA = "0x1163B58")]
	private static float WorldScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E82")]
	[Cpp2IlInjected.Address(RVA = "0x1163B60", Offset = "0x1163B60", VA = "0x1163B60")]
	private static void WorldOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E83")]
	[Cpp2IlInjected.Address(RVA = "0x1163C80", Offset = "0x1163C80", VA = "0x1163C80")]
	private static void DrawWorld(WorldFileData worldData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E84")]
	[Cpp2IlInjected.Address(RVA = "0x1163E7C", Offset = "0x1163E7C", VA = "0x1163E7C")]
	private static Texture2D GetWorldIcon(WorldFileData worldData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E85")]
	[Cpp2IlInjected.Address(RVA = "0x1163F80", Offset = "0x1163F80", VA = "0x1163F80")]
	private static void WorldDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E86")]
	[Cpp2IlInjected.Address(RVA = "0x1164F58", Offset = "0x1164F58", VA = "0x1164F58")]
	public GUISaveSynchronisation_FileList()
	{
	}
}
