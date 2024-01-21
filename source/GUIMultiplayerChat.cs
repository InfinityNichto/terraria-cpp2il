using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000F2")]
public class GUIMultiplayerChat
{
	[Cpp2IlInjected.Token(Token = "0x20007C1")]
	public enum ChatMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007A3A")]
		Hidden,
		[Cpp2IlInjected.Token(Token = "0x4007A3B")]
		DisplayNotification,
		[Cpp2IlInjected.Token(Token = "0x4007A3C")]
		Shown
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private float NoficiationDisplayTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	public ChatMode mode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private float ToggleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private float BeginChatScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private float PrimaryChatScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	private float EmotesScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private float EmotesCloseScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private Vector2 oneLineSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private int notificationCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private bool miniMapWasEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private bool beginChatClicked;

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public float MaxChatLineWidth
	{
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x11E0E54", Offset = "0x11E0E54", VA = "0x11E0E54")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public float MaxMiniChatLineWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x11E0EE0", Offset = "0x11E0EE0", VA = "0x11E0EE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float MaxMiniTouchChatLineWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x11E0F6C", Offset = "0x11E0F6C", VA = "0x11E0F6C")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600088B")]
	[Cpp2IlInjected.Address(RVA = "0x11E0960", Offset = "0x11E0960", VA = "0x11E0960")]
	public void LoadPageRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600088C")]
	[Cpp2IlInjected.Address(RVA = "0x11E0A50", Offset = "0x11E0A50", VA = "0x11E0A50")]
	public Vector2 ChatSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600088D")]
	[Cpp2IlInjected.Address(RVA = "0x11E0DA8", Offset = "0x11E0DA8", VA = "0x11E0DA8")]
	private float ChatScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600088E")]
	[Cpp2IlInjected.Address(RVA = "0x11E0DB0", Offset = "0x11E0DB0", VA = "0x11E0DB0")]
	private void ChatOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000892")]
	[Cpp2IlInjected.Address(RVA = "0x11E0FF8", Offset = "0x11E0FF8", VA = "0x11E0FF8")]
	public Vector2 CalulatePageSnippetSize(TextSnippet[] parsedText)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000893")]
	[Cpp2IlInjected.Address(RVA = "0x11E11A0", Offset = "0x11E11A0", VA = "0x11E11A0")]
	public Vector2 CalulateMiniSnippetSize(TextSnippet[] parsedText)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x11E1348", Offset = "0x11E1348", VA = "0x11E1348")]
	public Vector2 CalulateMiniTouchSnippetSize(TextSnippet[] parsedText)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x11E14F0", Offset = "0x11E14F0", VA = "0x11E14F0")]
	private void ChatDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x11E1D84", Offset = "0x11E1D84", VA = "0x11E1D84")]
	public void CloseChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x11E1E44", Offset = "0x11E1E44", VA = "0x11E1E44")]
	public void DrawNotification()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x11E515C", Offset = "0x11E515C", VA = "0x11E515C")]
	public void OpenChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x11E3494", Offset = "0x11E3494", VA = "0x11E3494")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x11E5228", Offset = "0x11E5228", VA = "0x11E5228")]
	public GUIMultiplayerChat()
	{
	}
}
