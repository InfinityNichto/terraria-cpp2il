using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000F6")]
public class GUIPVPIcons
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private int HoverPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private int HoverTeam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EB")]
	private int SelectedPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	private float PVPEnabledScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private float SelectedplayerScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	public int ConnectedPlayerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private int[] ConnectedPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	public bool ShowTeamGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	public bool TeamGridActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	public float scrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private float scrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private int scrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private Vector2 dragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private float scrollDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	public string playerString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private int _lastPlayerOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private bool _playerOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private GUIInputRegionExclusive pickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private Player clonePlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40006FC")]
	private Vector2 CharacterDrawOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	public int DrawSelectedPlayerOverlayStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	public bool DrawSelectedPlayerOverlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private string playerStringBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private Player EmptyPlayer;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool Collapsed
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xFF9618", Offset = "0xFF9618", VA = "0xFF9618")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool HasFocus
	{
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0xFF98EC", Offset = "0xFF98EC", VA = "0xFF98EC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0xFF9698", Offset = "0xFF9698", VA = "0xFF9698")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0xFF9798", Offset = "0xFF9798", VA = "0xFF9798")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0xFF98E4", Offset = "0xFF98E4", VA = "0xFF98E4")]
	public bool ShowTeamGrids()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0xFF99C4", Offset = "0xFF99C4", VA = "0xFF99C4")]
	public void DrawTeamGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0xFFA248", Offset = "0xFFA248", VA = "0xFFA248")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0xFFA5D4", Offset = "0xFFA5D4", VA = "0xFFA5D4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0xFFC64C", Offset = "0xFFC64C", VA = "0xFFC64C")]
	public void OnPlayerDisconected(int player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0xFFC66C", Offset = "0xFFC66C", VA = "0xFFC66C")]
	private void DrawSelectedPlayerImage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0xFFCA5C", Offset = "0xFFCA5C", VA = "0xFFCA5C")]
	public void DrawSelectedPlayerPlatformControls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0xFFD018", Offset = "0xFFD018", VA = "0xFFD018")]
	public void DrawSelectedPlayerTeamOnlyElements(bool sameTeam, bool isMyPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0xFFDABC", Offset = "0xFFDABC", VA = "0xFFDABC")]
	public void DrawSelectedPlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0xFFC4EC", Offset = "0xFFC4EC", VA = "0xFFC4EC")]
	private void RefreshPlayerList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0xFFE284", Offset = "0xFFE284", VA = "0xFFE284")]
	public float TeamScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0xFFE2DC", Offset = "0xFFE2DC", VA = "0xFFE2DC")]
	public void TeamOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0xFFEC08", Offset = "0xFFEC08", VA = "0xFFEC08")]
	public void TeamDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0xFFF368", Offset = "0xFFF368", VA = "0xFFF368")]
	public float PlayerScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0xFFF3C0", Offset = "0xFFF3C0", VA = "0xFFF3C0")]
	public void PlayerOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0xFFF688", Offset = "0xFFF688", VA = "0xFFF688")]
	public void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(RVA = "0x100036C", Offset = "0x100036C", VA = "0x100036C")]
	private void DrawPlayer(Player player, Vector2 position, Vector2 size, bool animated)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x1000370", Offset = "0x1000370", VA = "0x1000370")]
	public GUIPVPIcons()
	{
	}
}
