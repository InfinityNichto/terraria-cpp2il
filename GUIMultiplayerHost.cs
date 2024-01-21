using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20001D0")]
public class GUIMultiplayerHost
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001476")]
	private float joinButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001477")]
	private float backButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001478")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001479")]
	private string _password;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400147A")]
	public bool editingServerPassword;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400147B")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400147C")]
	private Rectangle SelectedItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400147D")]
	private GUIControllerMultiplayerHost _controllerInput;

	[Cpp2IlInjected.Token(Token = "0x400147E")]
	public const int MaxLocalMPPlayers = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400147F")]
	private GUISlider.DragState dragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001480")]
	private float maxPlayerScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001481")]
	public bool InviteOnly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001482")]
	private float InviteToggleScale;

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x11E5230", Offset = "0x11E5230", VA = "0x11E5230")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x11E5238", Offset = "0x11E5238", VA = "0x11E5238")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x11E5A40", Offset = "0x11E5A40", VA = "0x11E5A40")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x11E7314", Offset = "0x11E7314", VA = "0x11E7314")]
	private void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x11E54E0", Offset = "0x11E54E0", VA = "0x11E54E0")]
	private void DrawMaxPlayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x11E74A4", Offset = "0x11E74A4", VA = "0x11E74A4")]
	public string GetDefaultIPAddress()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x11E6F7C", Offset = "0x11E6F7C", VA = "0x11E6F7C")]
	public void HostServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x11E5D80", Offset = "0x11E5D80", VA = "0x11E5D80")]
	private void DrawOpenInviteOnly()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x11E61B4", Offset = "0x11E61B4", VA = "0x11E61B4")]
	private void DrawPassword()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x11E7624", Offset = "0x11E7624", VA = "0x11E7624")]
	private void CloseServerPasswordEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x11E74F4", Offset = "0x11E74F4", VA = "0x11E74F4")]
	private void EnterServerPassword()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x11E76D8", Offset = "0x11E76D8", VA = "0x11E76D8")]
	private Texture2D GetIcon(WorldFileData worldData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x11E77C0", Offset = "0x11E77C0", VA = "0x11E77C0")]
	private void DrawWorld(WorldFileData worldData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x11E7990", Offset = "0x11E7990", VA = "0x11E7990")]
	private void WorldDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x11E80E4", Offset = "0x11E80E4", VA = "0x11E80E4")]
	public GUIMultiplayerHost()
	{
	}
}
