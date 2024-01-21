using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class GUINPCDialogue
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private float CachedLayoutSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private float CachedLayoutWrapSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private int CachedMinTextHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private Vector2 CachedTextSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private string CachedTextValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private string CachedTextMultilineValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private string textBlinker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	public int NumberOfOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	public bool ShowHappiness;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	public GUIControllerNPCDialogue _controller;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private string DisplayString
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x11F1D54", Offset = "0x11F1D54", VA = "0x11F1D54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x11F19D0", Offset = "0x11F19D0", VA = "0x11F19D0")]
	public void LoadRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x11F1AAC", Offset = "0x11F1AAC", VA = "0x11F1AAC")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x11E501C", Offset = "0x11E501C", VA = "0x11E501C")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x11F2E74", Offset = "0x11F2E74", VA = "0x11F2E74")]
	private void SetupLastLineAddition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x11F3140", Offset = "0x11F3140", VA = "0x11F3140")]
	private void ClearLastLineAddition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x11F232C", Offset = "0x11F232C", VA = "0x11F232C")]
	private void UpdateText(string textValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x11F31BC", Offset = "0x11F31BC", VA = "0x11F31BC")]
	private void SetupButtonText(ref string focusText, ref Texture2D option1Tex, ref string focusText3, ref Texture2D option2Tex, ref int cost, ref bool showHappiness)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x11F4DBC", Offset = "0x11F4DBC", VA = "0x11F4DBC")]
	public void LoadPanelRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x11F4E98", Offset = "0x11F4E98", VA = "0x11F4E98")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x11F4F5C", Offset = "0x11F4F5C", VA = "0x11F4F5C")]
	public void CloseClicked()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0x11F5114", Offset = "0x11F5114", VA = "0x11F5114")]
	public void Option1Clicked(int healCost)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x11F7BA0", Offset = "0x11F7BA0", VA = "0x11F7BA0")]
	public void HappinessClicked()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x11F4D58", Offset = "0x11F4D58", VA = "0x11F4D58")]
	public bool CanDryadPlayStardewAnimation(Player player, NPC npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x11F7CBC", Offset = "0x11F7CBC", VA = "0x11F7CBC")]
	public void Option2Clicked()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x11F8964", Offset = "0x11F8964", VA = "0x11F8964")]
	private void DrawSign()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AA")]
	[Cpp2IlInjected.Address(RVA = "0x11F9144", Offset = "0x11F9144", VA = "0x11F9144")]
	private void DrawNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AB")]
	[Cpp2IlInjected.Address(RVA = "0x11FA418", Offset = "0x11FA418", VA = "0x11FA418")]
	private void DrawPartyHat(NPC n, SpriteEffects spriteEffects, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x11FAE7C", Offset = "0x11FAE7C", VA = "0x11FAE7C")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AE")]
	[Cpp2IlInjected.Address(RVA = "0x11FC0A8", Offset = "0x11FC0A8", VA = "0x11FC0A8")]
	public GUINPCDialogue()
	{
	}
}
