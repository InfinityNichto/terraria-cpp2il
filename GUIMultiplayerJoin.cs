using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001D1")]
public class GUIMultiplayerJoin
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001483")]
	private float joinButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001484")]
	private float backButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001485")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001486")]
	private Rectangle SelectedItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001487")]
	private GUIControllerMultiplayerJoin _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001488")]
	private string _serverIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001489")]
	private string _serverPort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400148A")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400148B")]
	public bool editingServerIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400148C")]
	public bool editingServerPort;

	[Cpp2IlInjected.Token(Token = "0x400148D")]
	private const int defaultPort = 7777;

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x11E81A4", Offset = "0x11E81A4", VA = "0x11E81A4")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x11E81AC", Offset = "0x11E81AC", VA = "0x11E81AC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x11E95B8", Offset = "0x11E95B8", VA = "0x11E95B8")]
	private void DrawServerIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCB")]
	[Cpp2IlInjected.Address(RVA = "0x11EA1E0", Offset = "0x11EA1E0", VA = "0x11EA1E0")]
	private void EnterServerIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCC")]
	[Cpp2IlInjected.Address(RVA = "0x11EA344", Offset = "0x11EA344", VA = "0x11EA344")]
	private void CloseServerIPEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCD")]
	[Cpp2IlInjected.Address(RVA = "0x11E898C", Offset = "0x11E898C", VA = "0x11E898C")]
	private void DrawServerPort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x11EA3F8", Offset = "0x11EA3F8", VA = "0x11EA3F8")]
	private void EnterServerPort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x11EA4FC", Offset = "0x11EA4FC", VA = "0x11EA4FC")]
	private void CloseServerPortEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x11EA5B0", Offset = "0x11EA5B0", VA = "0x11EA5B0")]
	private int ParsePort(string port)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x11E84B4", Offset = "0x11E84B4", VA = "0x11E84B4")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x11EA690", Offset = "0x11EA690", VA = "0x11EA690")]
	private void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD3")]
	[Cpp2IlInjected.Address(RVA = "0x11EA76C", Offset = "0x11EA76C", VA = "0x11EA76C")]
	public GUIMultiplayerJoin()
	{
	}
}
