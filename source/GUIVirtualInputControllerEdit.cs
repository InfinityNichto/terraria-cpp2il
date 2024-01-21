using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001E5")]
public class GUIVirtualInputControllerEdit
{
	[Cpp2IlInjected.Token(Token = "0x20007F6")]
	private struct StyleOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007CD2")]
		public string ConfigurationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007CD3")]
		public string DisplayValue;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001571")]
	private CursorInputLayer _inputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001572")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001573")]
	public bool displayProfileOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4001574")]
	private bool displayHardwareOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4001575")]
	public bool displayPageOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4001576")]
	private bool drawnProfileOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001577")]
	private bool drawnHardwareOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4001578")]
	private bool drawnPageOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001579")]
	private float ProfileScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400157A")]
	private float ProfileRenameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400157B")]
	private float Profile1Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400157C")]
	private float Profile2Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400157D")]
	private float Profile3Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400157E")]
	private float Profile4Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400157F")]
	private float SideControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001580")]
	private float BottomControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001581")]
	private float HardwareScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001582")]
	private float Hardware1Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001583")]
	private float Hardware2Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001584")]
	private float Hardware3Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001585")]
	private float Hardware4Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001586")]
	public bool displayVCControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4D")]
	[Cpp2IlInjected.Token(Token = "0x4001587")]
	public bool editingName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001588")]
	private string editNameValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001589")]
	private int textBlinkerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400158A")]
	private int textBlinkerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400158B")]
	private List<StyleOption> StlyeOptionsList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400158C")]
	private string SelectedStyleValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400158D")]
	private float UndoScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400158E")]
	private float RedoScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400158F")]
	public float[] Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001590")]
	public float SettingsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001591")]
	public float leftMenuButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001592")]
	private float leftScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4001593")]
	private float rightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4001594")]
	private float leftInterfaceScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4001595")]
	private float rightInterfaceScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4001596")]
	private bool LeftPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
	[Cpp2IlInjected.Token(Token = "0x4001597")]
	private bool RightPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
	[Cpp2IlInjected.Token(Token = "0x4001598")]
	private bool PendingUIControlDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4001599")]
	private Vector2 PendingUIControlDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400159A")]
	private bool UIControlDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400159B")]
	private int SelectedControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400159C")]
	private string SelectedControlStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400159D")]
	private float TimeSinceControlChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400159E")]
	private float TimeSinceSlotChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400159F")]
	private int SelectedSlotType;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40015A0")]
	private bool PendingUISlotDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
	[Cpp2IlInjected.Token(Token = "0x40015A1")]
	private bool UISlotDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40015A2")]
	private Vector2 PendingUISlotDragStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40015A3")]
	private List<int> SlotOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40015A4")]
	private bool drawnFromDrag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40015A5")]
	private float smallScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40015A6")]
	private float mediumScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40015A7")]
	private float largeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40015A8")]
	private float extraLargeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40015A9")]
	private float deleteScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40015AA")]
	private List<VirtualControlsButtonConfiguration_Layout> availableButtonControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40015AB")]
	private List<VirtualControlsAxisConfiguration_Layout> availableAxisControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40015AC")]
	private float MappingsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40015AD")]
	private float ControlsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40015AE")]
	private Vector2 dragCursorStartLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40015AF")]
	private Vector2 dragControlStartLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40015B0")]
	private Vector2 dragCursorStartRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40015B1")]
	private Vector2 dragControlStartRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40015B2")]
	private Vector2 dragCursorStartInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40015B3")]
	private Vector2 dragControlStartInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40015B4")]
	private bool draggingRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x115")]
	[Cpp2IlInjected.Token(Token = "0x40015B5")]
	private bool draggingRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40015B6")]
	public GUIPageIconGrouping selectedGrouping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40015B7")]
	private bool draggingInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40015B8")]
	public bool ControlsDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40015B9")]
	public Rectangle leftControlsRegionCached;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40015BA")]
	public Rectangle rightControlsRegionCached;

	[Cpp2IlInjected.Token(Token = "0x40015BB")]
	private const float visualBorderRegion = 2f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40015BC")]
	private bool DraggingSelectedSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40015BD")]
	private Vector2 SlotStartPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x40015BE")]
	private Vector2 DragStartPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40015BF")]
	private Vector2 DragPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40015C0")]
	private int SelectedSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40015C1")]
	private bool SelectedSlotCursorActive;

	[Cpp2IlInjected.Token(Token = "0x40015C2")]
	private const int dragBufferSize = 15;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40015C3")]
	private float DraggingScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40015C4")]
	private float[] ControlsScales;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40015C5")]
	private float[] DrawScales;

	[Cpp2IlInjected.Token(Token = "0x6000D84")]
	[Cpp2IlInjected.Address(RVA = "0x12A1770", Offset = "0x12A1770", VA = "0x12A1770")]
	public GUIVirtualInputControllerEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D85")]
	[Cpp2IlInjected.Address(RVA = "0x12A193C", Offset = "0x12A193C", VA = "0x12A193C")]
	public void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D86")]
	[Cpp2IlInjected.Address(RVA = "0x12A1C94", Offset = "0x12A1C94", VA = "0x12A1C94")]
	public VirtualControlsAxisConfiguration_Layout.Style GetAxisControlSubStyle(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action)
	{
		return default(VirtualControlsAxisConfiguration_Layout.Style);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D87")]
	[Cpp2IlInjected.Address(RVA = "0x12A1CA4", Offset = "0x12A1CA4", VA = "0x12A1CA4")]
	public VirtualControlsButtonConfiguration_Layout.Style GetButtonControlSubStyle(VirtualControlsHardwareConfigurationMapping_Layout.ContolType action)
	{
		return default(VirtualControlsButtonConfiguration_Layout.Style);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D88")]
	[Cpp2IlInjected.Address(RVA = "0x12A1CC4", Offset = "0x12A1CC4", VA = "0x12A1CC4")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D89")]
	[Cpp2IlInjected.Address(RVA = "0x12A1CCC", Offset = "0x12A1CCC", VA = "0x12A1CCC")]
	public void CloseNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D8A")]
	[Cpp2IlInjected.Address(RVA = "0x12A1D4C", Offset = "0x12A1D4C", VA = "0x12A1D4C")]
	public void CloseProfileOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D8B")]
	[Cpp2IlInjected.Address(RVA = "0x12A1DC0", Offset = "0x12A1DC0", VA = "0x12A1DC0")]
	private void DrawProfile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D8C")]
	[Cpp2IlInjected.Address(RVA = "0x12A2CEC", Offset = "0x12A2CEC", VA = "0x12A2CEC")]
	private string TruncateString(TransactionButton_Layout button, string text, float maxWidth)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D8D")]
	[Cpp2IlInjected.Address(RVA = "0x12A2E20", Offset = "0x12A2E20", VA = "0x12A2E20")]
	public void ClosePageOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D8E")]
	[Cpp2IlInjected.Address(RVA = "0x12A2E94", Offset = "0x12A2E94", VA = "0x12A2E94")]
	private void DrawPageOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D8F")]
	[Cpp2IlInjected.Address(RVA = "0x12A4604", Offset = "0x12A4604", VA = "0x12A4604")]
	public void DisablePulldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D90")]
	[Cpp2IlInjected.Address(RVA = "0x12A4690", Offset = "0x12A4690", VA = "0x12A4690")]
	private void DrawHardware()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D91")]
	[Cpp2IlInjected.Address(RVA = "0x12A4FBC", Offset = "0x12A4FBC", VA = "0x12A4FBC")]
	private void UpdateStyleOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D92")]
	[Cpp2IlInjected.Address(RVA = "0x12A5654", Offset = "0x12A5654", VA = "0x12A5654")]
	private void ChangeStyle(string configurationId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D93")]
	[Cpp2IlInjected.Address(RVA = "0x12A5700", Offset = "0x12A5700", VA = "0x12A5700")]
	private void DrawUndoRedo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D94")]
	[Cpp2IlInjected.Address(RVA = "0x12A599C", Offset = "0x12A599C", VA = "0x12A599C")]
	public void DrawWidgets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D95")]
	[Cpp2IlInjected.Address(RVA = "0x12A59F4", Offset = "0x12A59F4", VA = "0x12A59F4")]
	public void DrawWidgetOverlays()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D96")]
	[Cpp2IlInjected.Address(RVA = "0x12A5B1C", Offset = "0x12A5B1C", VA = "0x12A5B1C")]
	public int GetSlotOver(Vector2 mousePosition, out Vector2 slotPosition)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D97")]
	[Cpp2IlInjected.Address(RVA = "0x12A5F88", Offset = "0x12A5F88", VA = "0x12A5F88")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D98")]
	[Cpp2IlInjected.Address(RVA = "0x12A6DE0", Offset = "0x12A6DE0", VA = "0x12A6DE0")]
	public void RefreshSlotOrder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D99")]
	[Cpp2IlInjected.Address(RVA = "0x12A6F18", Offset = "0x12A6F18", VA = "0x12A6F18")]
	public float ControlsItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D9A")]
	[Cpp2IlInjected.Address(RVA = "0x12A6F74", Offset = "0x12A6F74", VA = "0x12A6F74")]
	private void ClampSlotToScreen(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D9B")]
	[Cpp2IlInjected.Address(RVA = "0x12A74F8", Offset = "0x12A74F8", VA = "0x12A74F8")]
	public void ControlsItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D9C")]
	[Cpp2IlInjected.Address(RVA = "0x12A789C", Offset = "0x12A789C", VA = "0x12A789C")]
	private QuickActionButton_Layout.QuickActionControl GetButtonId(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType)
	{
		return default(QuickActionButton_Layout.QuickActionControl);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D9D")]
	[Cpp2IlInjected.Address(RVA = "0x12A78C0", Offset = "0x12A78C0", VA = "0x12A78C0")]
	private void GetControlTextureFrame(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, out Texture2D tex, out Rectangle frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D9E")]
	[Cpp2IlInjected.Address(RVA = "0x12A7F38", Offset = "0x12A7F38", VA = "0x12A7F38")]
	public string GetControlName(VirtualControlsHardwareConfigurationMapping_Layout.ContolType control)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D9F")]
	[Cpp2IlInjected.Address(RVA = "0x12A7FD0", Offset = "0x12A7FD0", VA = "0x12A7FD0")]
	public void ControlsItemDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA0")]
	[Cpp2IlInjected.Address(RVA = "0x12A8ABC", Offset = "0x12A8ABC", VA = "0x12A8ABC")]
	public void DrawControlsGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA1")]
	[Cpp2IlInjected.Address(RVA = "0x12A6BAC", Offset = "0x12A6BAC", VA = "0x12A6BAC")]
	private void RemoveSlot(int selectedSlot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA2")]
	[Cpp2IlInjected.Address(RVA = "0x12A8DB0", Offset = "0x12A8DB0", VA = "0x12A8DB0")]
	private int CreateNewSlot(VirtualControlsSlotTypeMapping_Layout.SlotType controlType, string styleId, Vector2 position)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA3")]
	[Cpp2IlInjected.Address(RVA = "0x12A9398", Offset = "0x12A9398", VA = "0x12A9398")]
	public void DrawSlotsGrid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA4")]
	[Cpp2IlInjected.Address(RVA = "0x12A9DE4", Offset = "0x12A9DE4", VA = "0x12A9DE4")]
	public void DrawControlCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA5")]
	[Cpp2IlInjected.Address(RVA = "0x12A553C", Offset = "0x12A553C", VA = "0x12A553C")]
	private void GetDefaultControlSetup(VirtualControlsHardwareConfigurationMapping_Layout.ContolType control, out VirtualControlsSlotTypeMapping_Layout.SlotType type, out string configurationId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA6")]
	[Cpp2IlInjected.Address(RVA = "0x12A77C4", Offset = "0x12A77C4", VA = "0x12A77C4")]
	private void HandleSlotChangeType(VirtualControlsHardwareConfiguration_Layout hardware, int slot, VirtualControlsSlotTypeMapping_Layout.SlotType type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA7")]
	[Cpp2IlInjected.Address(RVA = "0x12A90C8", Offset = "0x12A90C8", VA = "0x12A90C8")]
	private void LoadSlotPosition(Vector2 position, int slot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA8")]
	[Cpp2IlInjected.Address(RVA = "0x12AA058", Offset = "0x12AA058", VA = "0x12AA058")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DA9")]
	[Cpp2IlInjected.Address(RVA = "0x12ADDE4", Offset = "0x12ADDE4", VA = "0x12ADDE4")]
	public float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DAA")]
	[Cpp2IlInjected.Address(RVA = "0x12ADDEC", Offset = "0x12ADDEC", VA = "0x12ADDEC")]
	public void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DAB")]
	[Cpp2IlInjected.Address(RVA = "0x12ADDF0", Offset = "0x12ADDF0", VA = "0x12ADDF0")]
	public void ItemDraw(ItemGrid_Layout gridLayout, int slot, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DAC")]
	[Cpp2IlInjected.Address(RVA = "0x12ADDF4", Offset = "0x12ADDF4", VA = "0x12ADDF4")]
	private void DrawAvailableControls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DAD")]
	[Cpp2IlInjected.Address(RVA = "0x12A3644", Offset = "0x12A3644", VA = "0x12A3644")]
	public void SetPageControlsAndAdjust(GUIPageIcons.PageControlsType newType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DAE")]
	[Cpp2IlInjected.Address(RVA = "0x12ADF54", Offset = "0x12ADF54", VA = "0x12ADF54")]
	public void ClampControls(bool editingControls = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DAF")]
	[Cpp2IlInjected.Address(RVA = "0x12AC400", Offset = "0x12AC400", VA = "0x12AC400")]
	private void DrawInterfaceBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB0")]
	[Cpp2IlInjected.Address(RVA = "0x12ADF58", Offset = "0x12ADF58", VA = "0x12ADF58")]
	private Cursor GetCursor(GUIPageIconGrouping grouping)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB1")]
	[Cpp2IlInjected.Address(RVA = "0x12ABD20", Offset = "0x12ABD20", VA = "0x12ABD20")]
	private void UpdateInterfaceMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB2")]
	[Cpp2IlInjected.Address(RVA = "0x12AEB64", Offset = "0x12AEB64", VA = "0x12AEB64")]
	private void OffsetGroupingX(float offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB3")]
	[Cpp2IlInjected.Address(RVA = "0x12AEBA4", Offset = "0x12AEBA4", VA = "0x12AEBA4")]
	private Rectangle ResolveCollisions(Rectangle originalRegion, Rectangle newRegion, GUIPageIconGrouping group)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB4")]
	[Cpp2IlInjected.Address(RVA = "0x12AE020", Offset = "0x12AE020", VA = "0x12AE020")]
	private void TryMovingGroup(Vector2 newPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB5")]
	[Cpp2IlInjected.Address(RVA = "0x12AF3B4", Offset = "0x12AF3B4", VA = "0x12AF3B4")]
	public float PageItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB6")]
	[Cpp2IlInjected.Address(RVA = "0x12AF410", Offset = "0x12AF410", VA = "0x12AF410")]
	public void PageItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB7")]
	[Cpp2IlInjected.Address(RVA = "0x12ADA98", Offset = "0x12ADA98", VA = "0x12ADA98")]
	private bool IsAxisInBadPosition(Axis_Layout AxisLayout, ref Vector2 mousePosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB8")]
	[Cpp2IlInjected.Address(RVA = "0x12AF414", Offset = "0x12AF414", VA = "0x12AF414")]
	public void CancelDrag()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DB9")]
	[Cpp2IlInjected.Address(RVA = "0x12AD760", Offset = "0x12AD760", VA = "0x12AD760")]
	private bool IsButtonInBadPosition(QuickActionButton_Layout buttonLayout, ref Vector2 mousePosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DBA")]
	[Cpp2IlInjected.Address(RVA = "0x12A67F0", Offset = "0x12A67F0", VA = "0x12A67F0")]
	private bool DraggingControlInBadPosition()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000DBB")]
	[Cpp2IlInjected.Address(RVA = "0x12AC9A8", Offset = "0x12AC9A8", VA = "0x12AC9A8")]
	private void DrawControls()
	{
	}
}
