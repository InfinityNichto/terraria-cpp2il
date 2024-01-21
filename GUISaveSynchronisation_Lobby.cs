using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001F7")]
public class GUISaveSynchronisation_Lobby
{
	[Cpp2IlInjected.Token(Token = "0x400172B")]
	private static Rectangle SelectedItemRegion;

	[Cpp2IlInjected.Token(Token = "0x400172C")]
	public static float ScrollOffset;

	[Cpp2IlInjected.Token(Token = "0x400172D")]
	private static float ScrollMomentum;

	[Cpp2IlInjected.Token(Token = "0x400172E")]
	private static int ScrollDragging;

	[Cpp2IlInjected.Token(Token = "0x400172F")]
	private static Vector2 DragOffset;

	[Cpp2IlInjected.Token(Token = "0x4001730")]
	private static float TitleScale;

	[Cpp2IlInjected.Token(Token = "0x4001731")]
	private static float ConnectIPScale;

	[Cpp2IlInjected.Token(Token = "0x4001732")]
	private static float connectButtonScale;

	[Cpp2IlInjected.Token(Token = "0x4001733")]
	private static float backButtonScale;

	[Cpp2IlInjected.Token(Token = "0x4001734")]
	private static DateTime LastSelectTime;

	[Cpp2IlInjected.Token(Token = "0x4001735")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	[Cpp2IlInjected.Token(Token = "0x4001736")]
	private static GUIControllerSaveSynchronisation_Lobby _controllerInput;

	[Cpp2IlInjected.Token(Token = "0x4001737")]
	public static int selectedServer;

	[Cpp2IlInjected.Token(Token = "0x4001738")]
	private static int serverOver;

	[Cpp2IlInjected.Token(Token = "0x6000E88")]
	[Cpp2IlInjected.Address(RVA = "0xEE1AC8", Offset = "0xEE1AC8", VA = "0xEE1AC8")]
	public static void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E89")]
	[Cpp2IlInjected.Address(RVA = "0xEE2A48", Offset = "0xEE2A48", VA = "0xEE2A48")]
	public static void RefreshServers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E8A")]
	[Cpp2IlInjected.Address(RVA = "0xEE23CC", Offset = "0xEE23CC", VA = "0xEE23CC")]
	private static void DrawServers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E8B")]
	[Cpp2IlInjected.Address(RVA = "0xEE2BD4", Offset = "0xEE2BD4", VA = "0xEE2BD4")]
	private static float ServerScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E8C")]
	[Cpp2IlInjected.Address(RVA = "0xEE2BDC", Offset = "0xEE2BDC", VA = "0xEE2BDC")]
	private static void ServerOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E8D")]
	[Cpp2IlInjected.Address(RVA = "0xEE2C58", Offset = "0xEE2C58", VA = "0xEE2C58")]
	private static void ServerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E8E")]
	[Cpp2IlInjected.Address(RVA = "0xEE3500", Offset = "0xEE3500", VA = "0xEE3500")]
	private static void DrawServer(SaveSynchronisationFinder.SearchServerResult serverData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E8F")]
	[Cpp2IlInjected.Address(RVA = "0xEE1E48", Offset = "0xEE1E48", VA = "0xEE1E48")]
	private static void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E90")]
	[Cpp2IlInjected.Address(RVA = "0xEE1F0C", Offset = "0xEE1F0C", VA = "0xEE1F0C")]
	private static void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E91")]
	[Cpp2IlInjected.Address(RVA = "0xEE3798", Offset = "0xEE3798", VA = "0xEE3798")]
	public GUISaveSynchronisation_Lobby()
	{
	}
}
