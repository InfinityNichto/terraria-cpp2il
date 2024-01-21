using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States;

[Cpp2IlInjected.Token(Token = "0x20006AA")]
public class UIVirtualKeyboard : UIState
{
	[Cpp2IlInjected.Token(Token = "0x2000AA3")]
	public delegate void KeyboardSubmitEvent(string text);

	[Cpp2IlInjected.Token(Token = "0x2000AA4")]
	public enum KeyState
	{
		[Cpp2IlInjected.Token(Token = "0x4008F08")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4008F09")]
		Symbol,
		[Cpp2IlInjected.Token(Token = "0x4008F0A")]
		Shift
	}

	[Cpp2IlInjected.Token(Token = "0x4006F02")]
	private static UIVirtualKeyboard _currentInstance;

	[Cpp2IlInjected.Token(Token = "0x4006F03")]
	private static string _cancelCacheSign;

	[Cpp2IlInjected.Token(Token = "0x4006F04")]
	private static string _cancelCacheChest;

	[Cpp2IlInjected.Token(Token = "0x4006F05")]
	private const string DEFAULT_KEYS = "1234567890qwertyuiopasdfghjkl'zxcvbnm,.?";

	[Cpp2IlInjected.Token(Token = "0x4006F06")]
	private const string SHIFT_KEYS = "1234567890QWERTYUIOPASDFGHJKL'ZXCVBNM,.?";

	[Cpp2IlInjected.Token(Token = "0x4006F07")]
	private const string SYMBOL_KEYS = "1234567890!@#$%^&*()-_+=/\\{}[]<>;:\"`|~£";

	[Cpp2IlInjected.Token(Token = "0x4006F08")]
	private const float KEY_SPACING = 4f;

	[Cpp2IlInjected.Token(Token = "0x4006F09")]
	private const float KEY_WIDTH = 48f;

	[Cpp2IlInjected.Token(Token = "0x4006F0A")]
	private const float KEY_HEIGHT = 37f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006F0B")]
	private UITextPanel<object>[] _keyList;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006F0C")]
	private UITextPanel<object> _shiftButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006F0D")]
	private UITextPanel<object> _symbolButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006F0E")]
	private UITextBox _textBox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006F0F")]
	private UITextPanel<LocalizedText> _submitButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4006F10")]
	private UITextPanel<LocalizedText> _cancelButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006F11")]
	private UIText _label;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006F12")]
	private UITextPanel<object> _enterButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006F13")]
	private UITextPanel<object> _spacebarButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4006F14")]
	private UITextPanel<object> _restoreButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4006F15")]
	private Asset<Texture2D> _textureShift;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4006F16")]
	private Asset<Texture2D> _textureBackspace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4006F17")]
	private Color _internalBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4006F18")]
	private Color _internalBorderColorSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4006F19")]
	private UITextPanel<LocalizedText> _submitButton2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4006F1A")]
	private UITextPanel<LocalizedText> _cancelButton2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4006F1B")]
	private UIElement outerLayer1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4006F1C")]
	private UIElement outerLayer2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4006F1D")]
	private bool _allowEmpty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x4006F1E")]
	private KeyState _keyState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4006F1F")]
	private KeyboardSubmitEvent _submitAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4006F20")]
	private Action _cancelAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4006F21")]
	private int _lastOffsetDown;

	[Cpp2IlInjected.Token(Token = "0x4006F22")]
	public static int OffsetDown;

	[Cpp2IlInjected.Token(Token = "0x4006F23")]
	public static bool ShouldHideText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x4006F24")]
	private int _keyboardContext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4006F25")]
	private bool _edittingSign;

	[Cpp2IlInjected.FieldOffset(Offset = "0x151")]
	[Cpp2IlInjected.Token(Token = "0x4006F26")]
	private bool _edittingChest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4006F27")]
	private float _textBoxHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4006F28")]
	private float _labelHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x4006F29")]
	public Func<string, bool> CustomTextValidationForUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4006F2A")]
	public Func<string, bool> CustomTextValidationForSubmit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4006F2B")]
	public Func<bool> CustomEscapeAttempt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4006F2C")]
	private bool _canSubmit;

	[Cpp2IlInjected.Token(Token = "0x170007AB")]
	public string Text
	{
		[Cpp2IlInjected.Token(Token = "0x600433E")]
		[Cpp2IlInjected.Address(RVA = "0xE0B19C", Offset = "0xE0B19C", VA = "0xE0B19C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600433F")]
		[Cpp2IlInjected.Address(RVA = "0xE0B1F8", Offset = "0xE0B1F8", VA = "0xE0B1F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007AC")]
	public bool HideContents
	{
		[Cpp2IlInjected.Token(Token = "0x6004340")]
		[Cpp2IlInjected.Address(RVA = "0xE0B460", Offset = "0xE0B460", VA = "0xE0B460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6004341")]
		[Cpp2IlInjected.Address(RVA = "0xE0B46C", Offset = "0xE0B46C", VA = "0xE0B46C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007AD")]
	public static bool CanSubmit
	{
		[Cpp2IlInjected.Token(Token = "0x6004355")]
		[Cpp2IlInjected.Address(RVA = "0xE0DF70", Offset = "0xE0DF70", VA = "0xE0DF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007AE")]
	public static int KeyboardContext
	{
		[Cpp2IlInjected.Token(Token = "0x600435D")]
		[Cpp2IlInjected.Address(RVA = "0xE0F0C0", Offset = "0xE0F0C0", VA = "0xE0F0C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004342")]
	[Cpp2IlInjected.Address(RVA = "0xE0B478", Offset = "0xE0B478", VA = "0xE0B478")]
	public UIVirtualKeyboard(string labelText, string startingText, KeyboardSubmitEvent submitAction, Action cancelAction, int inputMode = 0, bool allowEmpty = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004343")]
	[Cpp2IlInjected.Address(RVA = "0xE0D144", Offset = "0xE0D144", VA = "0xE0D144")]
	public void SetMaxInputLength(int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004344")]
	[Cpp2IlInjected.Address(RVA = "0xE0CC88", Offset = "0xE0CC88", VA = "0xE0CC88")]
	private void BuildSpaceBarArea(UIPanel mainPanel)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004345")]
	[Cpp2IlInjected.Address(RVA = "0xE0D24C", Offset = "0xE0D24C", VA = "0xE0D24C")]
	private void PressSpace()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004346")]
	[Cpp2IlInjected.Address(RVA = "0xE0D158", Offset = "0xE0D158", VA = "0xE0D158")]
	private bool CanRestore()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004347")]
	[Cpp2IlInjected.Address(RVA = "0xE0D358", Offset = "0xE0D358", VA = "0xE0D358")]
	private void TypeText(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004348")]
	[Cpp2IlInjected.Address(RVA = "0xE0CE24", Offset = "0xE0CE24", VA = "0xE0CE24")]
	public void SetKeyState(KeyState keyState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004349")]
	[Cpp2IlInjected.Address(RVA = "0xE0B264", Offset = "0xE0B264", VA = "0xE0B264")]
	private void ValidateText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600434A")]
	[Cpp2IlInjected.Address(RVA = "0xE0D53C", Offset = "0xE0D53C", VA = "0xE0D53C")]
	private bool TextIsValidForSubmit()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600434B")]
	[Cpp2IlInjected.Address(RVA = "0x15A5D2C", Offset = "0x15A5D2C", VA = "0x15A5D2C")]
	private void StyleKey<T>(UITextPanel<T> button, bool external = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600434C")]
	[Cpp2IlInjected.Address(RVA = "0xE0CAE8", Offset = "0xE0CAE8", VA = "0xE0CAE8")]
	private UITextPanel<object> CreateKeyboardButton(object text, int x, int y, int width = 1, bool style = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600434D")]
	[Cpp2IlInjected.Address(RVA = "0xE0D5F4", Offset = "0xE0D5F4", VA = "0xE0D5F4")]
	private bool ShouldShowKeyboard()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600434E")]
	[Cpp2IlInjected.Address(RVA = "0xE0D5FC", Offset = "0xE0D5FC", VA = "0xE0D5FC", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600434F")]
	[Cpp2IlInjected.Address(RVA = "0xE0E0E0", Offset = "0xE0E0E0", VA = "0xE0E0E0")]
	private bool TryEscapingMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004350")]
	[Cpp2IlInjected.Address(RVA = "0xE0D044", Offset = "0xE0D044", VA = "0xE0D044")]
	private void UpdateOffsetDown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004351")]
	[Cpp2IlInjected.Address(RVA = "0xE0E4F0", Offset = "0xE0E4F0", VA = "0xE0E4F0", Slot = "26")]
	public override void OnActivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004352")]
	[Cpp2IlInjected.Address(RVA = "0xE0E4F4", Offset = "0xE0E4F4", VA = "0xE0E4F4", Slot = "27")]
	public override void OnDeactivate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004353")]
	[Cpp2IlInjected.Address(RVA = "0xE0E580", Offset = "0xE0E580", VA = "0xE0E580")]
	public static void CycleSymbols()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004354")]
	[Cpp2IlInjected.Address(RVA = "0xE0E6EC", Offset = "0xE0E6EC", VA = "0xE0E6EC")]
	public static void BackSpace()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004356")]
	[Cpp2IlInjected.Address(RVA = "0xE0E02C", Offset = "0xE0E02C", VA = "0xE0E02C")]
	public static void Submit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004357")]
	[Cpp2IlInjected.Address(RVA = "0xE0E7EC", Offset = "0xE0E7EC", VA = "0xE0E7EC")]
	private void InternalSubmit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004358")]
	[Cpp2IlInjected.Address(RVA = "0xE0E400", Offset = "0xE0E400", VA = "0xE0E400")]
	public static void Cancel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004359")]
	[Cpp2IlInjected.Address(RVA = "0xE0EC80", Offset = "0xE0EC80", VA = "0xE0EC80")]
	public static void Write(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600435A")]
	[Cpp2IlInjected.Address(RVA = "0xE0EE4C", Offset = "0xE0EE4C", VA = "0xE0EE4C")]
	public static void CursorLeft()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600435B")]
	[Cpp2IlInjected.Address(RVA = "0xE0EF3C", Offset = "0xE0EF3C", VA = "0xE0EF3C")]
	public static void CursorRight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600435C")]
	[Cpp2IlInjected.Address(RVA = "0xE0F02C", Offset = "0xE0F02C", VA = "0xE0F02C")]
	public static bool CanDisplay(int keyboardContext)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600435E")]
	[Cpp2IlInjected.Address(RVA = "0xE0F174", Offset = "0xE0F174", VA = "0xE0F174")]
	public static void CacheCanceledInput(int cacheMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600435F")]
	[Cpp2IlInjected.Address(RVA = "0xE0F230", Offset = "0xE0F230", VA = "0xE0F230")]
	private void RestoreCanceledInput(int cacheMode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004360")]
	[Cpp2IlInjected.Address(RVA = "0xE0E24C", Offset = "0xE0E24C", VA = "0xE0E24C")]
	private void CopyTextToSign()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004361")]
	[Cpp2IlInjected.Address(RVA = "0xE0E368", Offset = "0xE0E368", VA = "0xE0E368")]
	private void CopyTextToChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004362")]
	[Cpp2IlInjected.Address(RVA = "0xE0F324", Offset = "0xE0F324", VA = "0xE0F324")]
	private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004363")]
	[Cpp2IlInjected.Address(RVA = "0xE0F4E0", Offset = "0xE0F4E0", VA = "0xE0F4E0")]
	private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
	{
	}
}
