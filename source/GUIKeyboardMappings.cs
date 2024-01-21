using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.IO;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000114")]
public class GUIKeyboardMappings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400088E")]
	private bool _keyboardEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400088F")]
	public GUIKeyboardMappingOverlay _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000890")]
	private GUIKeyboardMappingEntry overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000891")]
	private Rectangle overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000892")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000893")]
	public bool performingBinding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000894")]
	private int disableScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000895")]
	public ControllerActionAxis MovementAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000896")]
	public ControllerActionAxis MovementAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000897")]
	public ControllerActionVector MovementAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000898")]
	public ControllerActionButton GrappleFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000899")]
	public ControllerActionButton Jump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400089A")]
	public ControllerActionButton Fire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400089B")]
	public ControllerActionButton Interact;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400089C")]
	public ControllerActionButton TargetLockOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400089D")]
	public ControllerActionButton InventoryToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400089E")]
	public ControllerActionButton AutoSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400089F")]
	public ControllerActionButton SmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40008A0")]
	public ControllerActionButton Settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40008A1")]
	public ControllerActionButton HotbarNext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40008A2")]
	public ControllerActionButton HotbarPrevious;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40008A3")]
	public ControllerActionButton LeftPageCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40008A4")]
	public ControllerActionButton RightPageCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40008A5")]
	public ControllerActionButton ZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40008A6")]
	public ControllerActionButton ZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40008A7")]
	public ControllerActionButton MapZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40008A8")]
	public ControllerActionButton MapZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40008A9")]
	public ControllerActionButton MapZoomDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40008AA")]
	public ControllerActionButton QuickMount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40008AB")]
	public ControllerActionButton QuickHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40008AC")]
	public ControllerActionButton QuickBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40008AD")]
	public ControllerActionButton QuickMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40008AE")]
	public ControllerActionButton MapToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40008AF")]
	public ControllerActionButton MiniMapToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40008B0")]
	public ControllerActionButton ChatToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40008B1")]
	public ControllerActionButton Hotbar1;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40008B2")]
	public ControllerActionButton Hotbar2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40008B3")]
	public ControllerActionButton Hotbar3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40008B4")]
	public ControllerActionButton Hotbar4;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40008B5")]
	public ControllerActionButton Hotbar5;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40008B6")]
	public ControllerActionButton Hotbar6;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40008B7")]
	public ControllerActionButton Hotbar7;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40008B8")]
	public ControllerActionButton Hotbar8;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40008B9")]
	public ControllerActionButton Hotbar9;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40008BA")]
	public ControllerActionButton Hotbar10;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40008BB")]
	public ControllerActionButton Loadout1;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40008BC")]
	public ControllerActionButton Loadout2;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40008BD")]
	public ControllerActionButton Loadout3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40008BE")]
	public ControllerActionButton LoadoutCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40008BF")]
	private List<ControllerActionButton> AllButtonMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40008C0")]
	private bool _escapeOpensInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40008C1")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40008C2")]
	private KeyboardMappingsCategories_Layout.Category[] TabOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40008C3")]
	public KeyboardMappingsCategories_Layout.Category Selected;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40008C4")]
	private float GameplayButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40008C5")]
	private float UIButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40008C6")]
	private float SaveAndCloseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40008C7")]
	private float ResetSettingsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40008C8")]
	private float titleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40008C9")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40008CA")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40008CB")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40008CC")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40008CD")]
	public List<GUIKeyboardMappingEntry> _allSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40008CE")]
	public List<GUIKeyboardMappingEntry> _categorySettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40008CF")]
	private bool hasFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40008D0")]
	private GUIInputRegionExclusive _categoriesBlocker;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool KeyboardEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0xDEB894", Offset = "0xDEB894", VA = "0xDEB894")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xDEB89C", Offset = "0xDEB89C", VA = "0xDEB89C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool EscapeOpensInventory
	{
		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0xDEB9EC", Offset = "0xDEB9EC", VA = "0xDEB9EC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0xDEB9F4", Offset = "0xDEB9F4", VA = "0xDEB9F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0xDEA964", Offset = "0xDEA964", VA = "0xDEA964")]
	public void RegisterOverlay(GUIKeyboardMappingEntry entry, Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0xDEB904", Offset = "0xDEB904", VA = "0xDEB904")]
	private ControllerActionButton CreateButtonMapping(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0xDEBA14", Offset = "0xDEBA14", VA = "0xDEBA14")]
	public void SetupEscapeKeySetting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0xDEABCC", Offset = "0xDEABCC", VA = "0xDEABCC")]
	public void DisableEscapeKeyUsage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0xDEBA84", Offset = "0xDEBA84", VA = "0xDEBA84")]
	public void SetupMappings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0xDEC378", Offset = "0xDEC378", VA = "0xDEC378")]
	private KeyCode LoadKeyCode(Preferences preferences, string id, ref bool loaded)
	{
		return default(KeyCode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0xDEC568", Offset = "0xDEC568", VA = "0xDEC568")]
	public void LoadConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7A8", Offset = "0xDEC7A8", VA = "0xDEC7A8")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0xDEC028", Offset = "0xDEC028", VA = "0xDEC028")]
	public void LoadDefaults()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0xDEA9E0", Offset = "0xDEA9E0", VA = "0xDEA9E0")]
	public void ClearBinding(KeyCode key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xDECA48", Offset = "0xDECA48", VA = "0xDECA48")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0xDEE3C0", Offset = "0xDEE3C0", VA = "0xDEE3C0")]
	public void LooseFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0xDECD28", Offset = "0xDECD28", VA = "0xDECD28")]
	private void GainFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0xDEE448", Offset = "0xDEE448", VA = "0xDEE448")]
	private bool IsOverCategories(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0xDED598", Offset = "0xDED598", VA = "0xDED598")]
	private void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0xDEEA44", Offset = "0xDEEA44", VA = "0xDEEA44")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0xDEEA54", Offset = "0xDEEA54", VA = "0xDEEA54")]
	public void Backup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0xDEEAE8", Offset = "0xDEEAE8", VA = "0xDEEAE8")]
	public void RestoreBackup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xDEDD14", Offset = "0xDEDD14", VA = "0xDEDD14")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0xDEEB78", Offset = "0xDEEB78", VA = "0xDEEB78")]
	private void ClearMapping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0xDED0BC", Offset = "0xDED0BC", VA = "0xDED0BC")]
	private void DrawTitle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0xDECDE4", Offset = "0xDECDE4", VA = "0xDECDE4")]
	private void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0xDECEF0", Offset = "0xDECEF0", VA = "0xDECEF0")]
	private void DrawCategoryOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0xDEEC18", Offset = "0xDEEC18", VA = "0xDEEC18")]
	private float SettingScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0xDEEC20", Offset = "0xDEEC20", VA = "0xDEEC20")]
	private void SettingOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0xDEEC24", Offset = "0xDEEC24", VA = "0xDEEC24")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0xDEED94", Offset = "0xDEED94", VA = "0xDEED94")]
	private Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0xDEE5F0", Offset = "0xDEE5F0", VA = "0xDEE5F0")]
	public void SetCategory(KeyboardMappingsCategories_Layout.Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0xDEEE90", Offset = "0xDEEE90", VA = "0xDEEE90")]
	public static string GetControlTag(ControlsKeyboardTagHandler.MappingType mappingType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0xDEEF14", Offset = "0xDEEF14", VA = "0xDEEF14")]
	public GUIKeyboardMappings()
	{
	}
}
