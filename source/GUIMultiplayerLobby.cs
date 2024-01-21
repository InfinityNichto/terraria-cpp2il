using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001D2")]
public class GUIMultiplayerLobby
{
	[Cpp2IlInjected.Token(Token = "0x20007F1")]
	public enum ItemSelection
	{
		[Cpp2IlInjected.Token(Token = "0x4007CB1")]
		Local,
		[Cpp2IlInjected.Token(Token = "0x4007CB2")]
		Dedicated
	}

	[Cpp2IlInjected.Token(Token = "0x20007F2")]
	public struct ServerInformation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007CB3")]
		public int RealID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007CB4")]
		public string WorldName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007CB5")]
		public int CurrentPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007CB6")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007CB7")]
		public int WorldWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007CB8")]
		public bool HasCorruption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
		[Cpp2IlInjected.Token(Token = "0x4007CB9")]
		public short GameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007CBA")]
		public bool IsHardMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007CBB")]
		public string ServerIPText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007CBC")]
		public int ServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007CBD")]
		public string HostName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007CBE")]
		public bool Active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4007CBF")]
		public bool Favorite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007CC0")]
		public MPSession ExistingSession;

		[Cpp2IlInjected.Token(Token = "0x17000849")]
		public string WorldSize
		{
			[Cpp2IlInjected.Token(Token = "0x6004927")]
			[Cpp2IlInjected.Address(RVA = "0x39D5BC", Offset = "0x39D5BC", VA = "0x39D5BC")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004926")]
		[Cpp2IlInjected.Address(RVA = "0x39D550", Offset = "0x39D550", VA = "0x39D550")]
		public ServerInformation(string worldName, string hostName, string serverIPText, int port, int players, int maxPlayers, int worldWidth, bool corruption, short gameMode, bool hardMode, bool active = true, bool favorite = false, int realID = 0, [Optional] MPSession existingSession)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400148E")]
	public ItemSelection CurrentSelection;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400148F")]
	public bool NoPlatformFriends;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001490")]
	private float localScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001491")]
	private float dedicatedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001492")]
	private float joinButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001493")]
	private float backButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001494")]
	private float NewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001495")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001496")]
	private float DeleteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001497")]
	public int previousMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001498")]
	private DateTime LastSelectTime;

	[Cpp2IlInjected.Token(Token = "0x4001499")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400149A")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400149B")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400149C")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400149D")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400149E")]
	private Rectangle SelectedItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400149F")]
	private bool serverJoinAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40014A0")]
	public int SelectedServerRealID;

	[Cpp2IlInjected.Token(Token = "0x40014A1")]
	private static Texture2D _buttonFavoriteActiveTexture;

	[Cpp2IlInjected.Token(Token = "0x40014A2")]
	private static Texture2D _buttonFavoriteInactiveTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40014A3")]
	private GUIControllerMultiplayerLobby _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40014A4")]
	private GUIContollerTransactionButtonList _multiplayerLobbyOptionsController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40014A5")]
	public int selectedServer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40014A6")]
	public List<ServerInformation> serverList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40014A7")]
	private Rectangle fullClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40014A8")]
	private Rectangle dragClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40014A9")]
	private int serverOver;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	private GUIContollerTransactionButtonList MultiplayerLobbyOptionsController
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x11EA8B4", Offset = "0x11EA8B4", VA = "0x11EA8B4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x11EA808", Offset = "0x11EA808", VA = "0x11EA808")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x11EA9F4", Offset = "0x11EA9F4", VA = "0x11EA9F4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x11EAF00", Offset = "0x11EAF00", VA = "0x11EAF00")]
	private void DrawPlatformFriends()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x11EAFD8", Offset = "0x11EAFD8", VA = "0x11EAFD8")]
	private void DrawCategoryButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x11E7424", Offset = "0x11E7424", VA = "0x11E7424")]
	public void Startup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x11ECF90", Offset = "0x11ECF90", VA = "0x11ECF90")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x11EB430", Offset = "0x11EB430", VA = "0x11EB430")]
	private void DrawLocal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x11EC978", Offset = "0x11EC978", VA = "0x11EC978")]
	private void DrawOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x11EC064", Offset = "0x11EC064", VA = "0x11EC064")]
	private void DrawDedicated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x11ED004", Offset = "0x11ED004", VA = "0x11ED004")]
	private void RefreshLocalServers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x11ED400", Offset = "0x11ED400", VA = "0x11ED400")]
	private void RefreshDedicatedServers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x11ED7F0", Offset = "0x11ED7F0", VA = "0x11ED7F0")]
	private Texture2D GetIcon(ServerInformation serverData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x11ED8D4", Offset = "0x11ED8D4", VA = "0x11ED8D4")]
	private void DrawServer(ServerInformation serverData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x11EDAF0", Offset = "0x11EDAF0", VA = "0x11EDAF0")]
	private void JoinServerCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x11EE034", Offset = "0x11EE034", VA = "0x11EE034")]
	public Vector2 ServerItemSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x11EE0C0", Offset = "0x11EE0C0", VA = "0x11EE0C0")]
	private void ServerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x11EEE6C", Offset = "0x11EEE6C", VA = "0x11EEE6C")]
	private void OpenPlatformInvite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x11EC738", Offset = "0x11EC738", VA = "0x11EC738")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x11EAE1C", Offset = "0x11EAE1C", VA = "0x11EAE1C")]
	private void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x11EEE70", Offset = "0x11EEE70", VA = "0x11EEE70")]
	private float ServerScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x11EEE78", Offset = "0x11EEE78", VA = "0x11EEE78")]
	private void ServerOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x11EEE80", Offset = "0x11EEE80", VA = "0x11EEE80")]
	public ServerInformation ActiveServer()
	{
		return default(ServerInformation);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x11EDBDC", Offset = "0x11EDBDC", VA = "0x11EDBDC")]
	private void JoinServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x11ED2CC", Offset = "0x11ED2CC", VA = "0x11ED2CC")]
	public void StartNewServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x11ED70C", Offset = "0x11ED70C", VA = "0x11ED70C")]
	private void AddDedicatedServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x11EEF04", Offset = "0x11EEF04", VA = "0x11EEF04")]
	private int SortEntry(ServerInformation a, ServerInformation b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x11EEF98", Offset = "0x11EEF98", VA = "0x11EEF98")]
	public int CompareNatural(string strA, string strB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x11EF034", Offset = "0x11EF034", VA = "0x11EF034")]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x11EF8D4", Offset = "0x11EF8D4", VA = "0x11EF8D4")]
	public GUIMultiplayerLobby()
	{
	}
}
