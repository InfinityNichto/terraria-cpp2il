using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x20001C9")]
public class GUIInterfaceEdit
{
	[Cpp2IlInjected.Token(Token = "0x20007EE")]
	public enum EditMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007CA6")]
		SafeRegion,
		[Cpp2IlInjected.Token(Token = "0x4007CA7")]
		InterfacePosition,
		[Cpp2IlInjected.Token(Token = "0x4007CA8")]
		InterfacePositionAdjust,
		[Cpp2IlInjected.Token(Token = "0x4007CA9")]
		EditControls
	}

	[Cpp2IlInjected.Token(Token = "0x20007EF")]
	public class BackupResotrePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007CAA")]
		public VirtualControlsHardwareConfiguration_Layout Hardware;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007CAB")]
		public VirtualControlsProfile_Layout Profile;

		[Cpp2IlInjected.Token(Token = "0x6004925")]
		[Cpp2IlInjected.Address(RVA = "0x1360D00", Offset = "0x1360D00", VA = "0x1360D00")]
		public BackupResotrePoint(VirtualControlsHardwareConfiguration_Layout hardware, VirtualControlsProfile_Layout profile)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400140A")]
	public EditMode Mode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400140B")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400140C")]
	public GUIControllerInterfaceEdit _controller;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400140D")]
	private float InterfacePositionScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400140E")]
	private float ControlsPositionScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400140F")]
	private float SafeRegionScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001410")]
	private float EditControlScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001411")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001412")]
	private float defaultsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001413")]
	private float finishScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001414")]
	private float resetScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001415")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001416")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001417")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001418")]
	private Microsoft.Xna.Framework.Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001419")]
	private int _groupCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400141A")]
	private int pageOver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400141B")]
	private Rectangle NewItemtemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400141C")]
	private Rectangle SelectedItemRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400141D")]
	public int SelectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400141E")]
	private GUIPageIconGrouping currentGroup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400141F")]
	private Microsoft.Xna.Framework.Vector2 pageButtonRegionSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4001420")]
	private Rectangle fullClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001421")]
	private Rectangle dragClipRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4001422")]
	public bool CanSpawnState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4001423")]
	private float SideControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4001424")]
	private float TopControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4001425")]
	private float BottomControls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4001426")]
	private GUISlider.DragState dragState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4001427")]
	private float uiScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4001428")]
	private float EditGroupsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4001429")]
	private UnityEngine.Vector2 lastCursorPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400142A")]
	private int lastDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400142B")]
	public bool editingName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400142C")]
	private string editNameValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400142D")]
	private int textBlinkerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400142E")]
	private int textBlinkerState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400142F")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4001430")]
	public bool displayProfileOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x4001431")]
	private bool drawnProfileOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4001432")]
	private float ProfileScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4001433")]
	private float ProfileRenameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4001434")]
	private float Profile1Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4001435")]
	private float Profile2Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4001436")]
	private float Profile3Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4001437")]
	private float Profile4Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4001438")]
	public bool displayTemplateOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF9")]
	[Cpp2IlInjected.Token(Token = "0x4001439")]
	private bool drawnTemplateOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400143A")]
	private float TemplateScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400143B")]
	private float Template1Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400143C")]
	private float Template2Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400143D")]
	private float Template3Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400143E")]
	private float Template4Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400143F")]
	private float Template5Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x4001440")]
	private bool selectedCustom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4001441")]
	private InterfaceProfile_Layout currentProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4001442")]
	public float _pulldownShift;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4001443")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4001444")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4001445")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x4001446")]
	private VirtualControlsHardwareConfiguration_Layout BackupHardware4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4001447")]
	private VirtualControlsProfile_Layout BackupProfile1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4001448")]
	private VirtualControlsProfile_Layout BackupProfile2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4001449")]
	private VirtualControlsProfile_Layout BackupProfile3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x400144A")]
	private VirtualControlsProfile_Layout BackupProfile4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400144B")]
	private VirtualControlsProfile_Layout BackupActiveProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400144C")]
	private Microsoft.Xna.Framework.Vector2 backupLeftPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x400144D")]
	private Microsoft.Xna.Framework.Vector2 backupRightPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400144E")]
	private Microsoft.Xna.Framework.Vector2 backupInterfaceLeftPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x400144F")]
	private Microsoft.Xna.Framework.Vector2 backupInterfaceRightPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4001450")]
	private Rect backupSafeRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x4001451")]
	private bool backupVPPIOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4001452")]
	private float backupVPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4001453")]
	private InterfaceProfile_Layout BackupInterfaceProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4001454")]
	private int SelectedSlot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4001455")]
	private List<BackupResotrePoint> RestorePoints;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4001456")]
	private List<BackupResotrePoint> RedoPoints;

	[Cpp2IlInjected.Token(Token = "0x6000C74")]
	[Cpp2IlInjected.Address(RVA = "0xDE07C4", Offset = "0xDE07C4", VA = "0xDE07C4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C75")]
	[Cpp2IlInjected.Address(RVA = "0xDE3478", Offset = "0xDE3478", VA = "0xDE3478")]
	private void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C76")]
	[Cpp2IlInjected.Address(RVA = "0xDE3814", Offset = "0xDE3814", VA = "0xDE3814")]
	private bool CanSpawn(List<GUIPageIconGrouping> groups, List<GUIPageIconGrouping> otherGroups, bool left, out Microsoft.Xna.Framework.Vector2 position)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C77")]
	[Cpp2IlInjected.Address(RVA = "0xDE3D6C", Offset = "0xDE3D6C", VA = "0xDE3D6C")]
	private bool FindSpaceToSpawn(out Microsoft.Xna.Framework.Vector2 position, out bool left)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C78")]
	[Cpp2IlInjected.Address(RVA = "0xDE3F78", Offset = "0xDE3F78", VA = "0xDE3F78")]
	public int SortGroupByPosition(GUIPageIconGrouping x, GUIPageIconGrouping y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C79")]
	[Cpp2IlInjected.Address(RVA = "0xDE4030", Offset = "0xDE4030", VA = "0xDE4030")]
	private float PageScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7A")]
	[Cpp2IlInjected.Address(RVA = "0xDE4038", Offset = "0xDE4038", VA = "0xDE4038")]
	private void PageOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0xDE42D4", Offset = "0xDE42D4", VA = "0xDE42D4")]
	public Microsoft.Xna.Framework.Vector2 ItemSize(int index)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0xDE43D8", Offset = "0xDE43D8", VA = "0xDE43D8")]
	private void PageIconDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0xDE458C", Offset = "0xDE458C", VA = "0xDE458C")]
	private void PageIconOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0xDE4590", Offset = "0xDE4590", VA = "0xDE4590")]
	private float PageIconScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0xDE4598", Offset = "0xDE4598", VA = "0xDE4598")]
	private bool LoadSettingAnchor(GUIPageIconGrouping.SettingCategory category, ref Rectangle itemRegion)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0xDE4758", Offset = "0xDE4758", VA = "0xDE4758")]
	private void PageDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0xDE5248", Offset = "0xDE5248", VA = "0xDE5248")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0xDE5318", Offset = "0xDE5318", VA = "0xDE5318")]
	public void RefreshSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0xDE1000", Offset = "0xDE1000", VA = "0xDE1000")]
	private void DrawPgeGroups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0xDE1CCC", Offset = "0xDE1CCC", VA = "0xDE1CCC")]
	private void DrawGroupEditControls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C85")]
	[Cpp2IlInjected.Address(RVA = "0xDE2BB8", Offset = "0xDE2BB8", VA = "0xDE2BB8")]
	private void DrawSafeRegionOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0xDE58C4", Offset = "0xDE58C4", VA = "0xDE58C4")]
	private bool CanApply()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0xDE1384", Offset = "0xDE1384", VA = "0xDE1384")]
	private void DrawOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0xDE2F7C", Offset = "0xDE2F7C", VA = "0xDE2F7C")]
	private void DrawControlsOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0xDE33D8", Offset = "0xDE33D8", VA = "0xDE33D8")]
	public void CancelChanges()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0xDE5B70", Offset = "0xDE5B70", VA = "0xDE5B70")]
	public void ClampUIScale()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8B")]
	[Cpp2IlInjected.Address(RVA = "0xDE5D14", Offset = "0xDE5D14", VA = "0xDE5D14")]
	private string GetDisplayName(InterfaceProfile_Layout profile, float maxWidth, bool isTemplate)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8C")]
	[Cpp2IlInjected.Address(RVA = "0xDE5EA8", Offset = "0xDE5EA8", VA = "0xDE5EA8")]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8D")]
	[Cpp2IlInjected.Address(RVA = "0xDE3358", Offset = "0xDE3358", VA = "0xDE3358")]
	public void CloseNameEdit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8E")]
	[Cpp2IlInjected.Address(RVA = "0xDE3278", Offset = "0xDE3278", VA = "0xDE3278")]
	public void CloseProfileOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8F")]
	[Cpp2IlInjected.Address(RVA = "0xDE32E8", Offset = "0xDE32E8", VA = "0xDE32E8")]
	public void CloseTemplateOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C90")]
	[Cpp2IlInjected.Address(RVA = "0xDE5F38", Offset = "0xDE5F38", VA = "0xDE5F38")]
	private void DrawProfile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0xDE7250", Offset = "0xDE7250", VA = "0xDE7250")]
	private void RefreshTemplate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0xDE73D8", Offset = "0xDE73D8", VA = "0xDE73D8")]
	public void EnsureSelectedGroupVisible()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0xDE7584", Offset = "0xDE7584", VA = "0xDE7584")]
	private void DrawTemplate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0xDE2AAC", Offset = "0xDE2AAC", VA = "0xDE2AAC")]
	public void DrawWidgetOverlays()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0xDE15B8", Offset = "0xDE15B8", VA = "0xDE15B8")]
	private void DrawUITweaks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0xDE8954", Offset = "0xDE8954", VA = "0xDE8954")]
	public void Backup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C97")]
	[Cpp2IlInjected.Address(RVA = "0xDE8C48", Offset = "0xDE8C48", VA = "0xDE8C48")]
	public void AddControlUndo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0xDE8DA4", Offset = "0xDE8DA4", VA = "0xDE8DA4")]
	public bool HasUndo()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0xDE8E9C", Offset = "0xDE8E9C", VA = "0xDE8E9C")]
	public void ControlUndo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0xDE9098", Offset = "0xDE9098", VA = "0xDE9098")]
	public bool HasRedo()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0xDE90F0", Offset = "0xDE90F0", VA = "0xDE90F0")]
	public void ControlRedo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0xDE9228", Offset = "0xDE9228", VA = "0xDE9228")]
	public void ClearControlRedo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0xDE37A4", Offset = "0xDE37A4", VA = "0xDE37A4")]
	public void ClearControlUndoRedo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0xDE9284", Offset = "0xDE9284", VA = "0xDE9284")]
	public void LoadDefaultProfilePositions(VirtualControlsHardwareConfiguration_Layout configuration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0xDE54D0", Offset = "0xDE54D0", VA = "0xDE54D0")]
	public void RestoreDefaults()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0xDE58CC", Offset = "0xDE58CC", VA = "0xDE58CC")]
	public void RestoreBackup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0xDE0584", Offset = "0xDE0584", VA = "0xDE0584")]
	public GUIInterfaceEdit()
	{
	}
}
