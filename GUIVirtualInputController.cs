using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x2000107")]
public class GUIVirtualInputController
{
	[Cpp2IlInjected.Token(Token = "0x20007C7")]
	public enum LeftStickJumpMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007A6B")]
		DoubleTap,
		[Cpp2IlInjected.Token(Token = "0x4007A6C")]
		SingleTap,
		[Cpp2IlInjected.Token(Token = "0x4007A6D")]
		Up,
		[Cpp2IlInjected.Token(Token = "0x4007A6E")]
		Disabled
	}

	[Cpp2IlInjected.Token(Token = "0x20007C8")]
	public enum ControlType
	{
		[Cpp2IlInjected.Token(Token = "0x4007A70")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4007A71")]
		Right,
		[Cpp2IlInjected.Token(Token = "0x4007A72")]
		Jump,
		[Cpp2IlInjected.Token(Token = "0x4007A73")]
		Up,
		[Cpp2IlInjected.Token(Token = "0x4007A74")]
		Down,
		[Cpp2IlInjected.Token(Token = "0x4007A75")]
		Inventory,
		[Cpp2IlInjected.Token(Token = "0x4007A76")]
		QuickHeal,
		[Cpp2IlInjected.Token(Token = "0x4007A77")]
		QuickMana,
		[Cpp2IlInjected.Token(Token = "0x4007A78")]
		QuickMount,
		[Cpp2IlInjected.Token(Token = "0x4007A79")]
		QuickBuff,
		[Cpp2IlInjected.Token(Token = "0x4007A7A")]
		Grapple,
		[Cpp2IlInjected.Token(Token = "0x4007A7B")]
		Fire,
		[Cpp2IlInjected.Token(Token = "0x4007A7C")]
		UseTileControl,
		[Cpp2IlInjected.Token(Token = "0x4007A7D")]
		Interact,
		[Cpp2IlInjected.Token(Token = "0x4007A7E")]
		ZoomIn,
		[Cpp2IlInjected.Token(Token = "0x4007A7F")]
		ZoomOut,
		[Cpp2IlInjected.Token(Token = "0x4007A80")]
		AutoFire,
		[Cpp2IlInjected.Token(Token = "0x4007A81")]
		SmartCursor,
		[Cpp2IlInjected.Token(Token = "0x4007A82")]
		InventoryToggle,
		[Cpp2IlInjected.Token(Token = "0x4007A83")]
		AutoSelect,
		[Cpp2IlInjected.Token(Token = "0x4007A84")]
		GrappleSelect,
		[Cpp2IlInjected.Token(Token = "0x4007A85")]
		TargetLockOn,
		[Cpp2IlInjected.Token(Token = "0x4007A86")]
		ProfileSwitch,
		[Cpp2IlInjected.Token(Token = "0x4007A87")]
		UseButton,
		[Cpp2IlInjected.Token(Token = "0x4007A88")]
		Settings,
		[Cpp2IlInjected.Token(Token = "0x4007A89")]
		Loadout1,
		[Cpp2IlInjected.Token(Token = "0x4007A8A")]
		Loadout2,
		[Cpp2IlInjected.Token(Token = "0x4007A8B")]
		Loadout3,
		[Cpp2IlInjected.Token(Token = "0x4007A8C")]
		LoadoutCycle,
		[Cpp2IlInjected.Token(Token = "0x4007A8D")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x40007D1")]
	private static Texture2D _directionArrow;

	[Cpp2IlInjected.Token(Token = "0x40007D2")]
	private static Texture2D _jump;

	[Cpp2IlInjected.Token(Token = "0x40007D3")]
	public static Texture2D _movement;

	[Cpp2IlInjected.Token(Token = "0x40007D4")]
	public static Texture2D _autoFireOff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40007D5")]
	public bool ControllerActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40007D6")]
	public bool AutoControlEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40007D7")]
	public float AutoControlTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007D8")]
	public bool AutoSelectToggleTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40007D9")]
	public bool AutoSelectToggleTouchValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40007DA")]
	public bool AutoSelectToggleController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40007DB")]
	public bool AutoSelectToggleControllerValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40007DC")]
	public bool AutoSelectToggleKeyboard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40007DD")]
	public bool AutoSelectToggleKeyboardValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x40007DE")]
	public bool EnableBuildGridSnap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17")]
	[Cpp2IlInjected.Token(Token = "0x40007DF")]
	public bool AimModeFreeMovement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40007E0")]
	public bool UseButtonPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x40007E1")]
	public bool StashCraftedItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40007E2")]
	private CursorInputLayer _inputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private CursorInputLayer _inputLayer2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	public VirtualInputController_Layout.ContolType[] Controls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	public float VirtualControlScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40007E6")]
	public LeftStickJumpMode JumpMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40007E7")]
	private int previousMovementLastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40007E8")]
	private Vector2 lastFireAxisRaw;

	[Cpp2IlInjected.Token(Token = "0x40007E9")]
	private const float numSteps = 1000f;

	[Cpp2IlInjected.Token(Token = "0x40007EA")]
	private static Item emptyItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40007EB")]
	private bool pulseLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007EC")]
	private int pulseLeftTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40007ED")]
	private bool pulseRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007EE")]
	private int pulseRightTime;

	[Cpp2IlInjected.Token(Token = "0x40007EF")]
	private static int pulseTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40007F0")]
	private float cursorUpdateTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40007F1")]
	private float LastOffsetX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40007F2")]
	private float LastOffsetY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private int LastFrameUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40007F4")]
	private int LastSizeX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40007F5")]
	private int LastSizeY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40007F6")]
	private float AimScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40007F7")]
	private float AimAxisActiveTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	private float AimAxisStartX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private float AimAxisStartY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40007FA")]
	private float AimAxisTotalX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40007FB")]
	private float AimAxisTotalY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40007FC")]
	private bool AimAxisSnapStarted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7D")]
	[Cpp2IlInjected.Token(Token = "0x40007FD")]
	public bool LeftStickAiming;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40007FE")]
	public float ControllerAimSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40007FF")]
	public float TouchAimSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000800")]
	private int InitialAimNavTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000801")]
	public DateTime LastAimNavTickTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000802")]
	private Vector2 LastAimNavTickPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000803")]
	private Vector2 LastAimNavTickPositionStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000804")]
	private Vector2 LastResultPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000805")]
	private Vector2 WorldBlendOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000806")]
	private bool lastGridAimMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x4000807")]
	private bool movingX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBA")]
	[Cpp2IlInjected.Token(Token = "0x4000808")]
	private bool movingY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private int movingOffsetX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private int movingOffsetY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	private int LastWorldPositionX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400080C")]
	private int LastWorldPositionY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400080D")]
	private int LastCursorPositionX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400080E")]
	private int LastCursorPositionY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	private int LastScreenCentreX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	private int LastScreenCentreY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private float deadZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private bool wasWorldCursorActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private int lastWorldCursorPointX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000814")]
	private int lastWorldCursorPointY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000815")]
	public bool wasMovementAxisActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x4000816")]
	public bool movementAxisActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x4000817")]
	public bool grappleAxisActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x4000818")]
	public bool wasGrappleAxisActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000819")]
	public bool grappleFired;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400081A")]
	public bool fireAxisActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF2")]
	[Cpp2IlInjected.Token(Token = "0x400081B")]
	public bool grappleAxisPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF3")]
	[Cpp2IlInjected.Token(Token = "0x400081C")]
	private bool fireAxisFiring;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400081D")]
	public bool fireButtonFiring;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x400081E")]
	private bool fireFromHousing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x400081F")]
	private bool anyActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000820")]
	private Vector2 grappleAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000821")]
	private Vector2 previousGrappleAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000822")]
	private Vector2 movementAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000823")]
	private Vector2 previousMovementAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000824")]
	private Vector2 fireAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000825")]
	private Vector2 gridSnapAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000826")]
	private Vector2 previousGridSnapAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000827")]
	private bool gridSnapUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
	[Cpp2IlInjected.Token(Token = "0x4000828")]
	private bool gridSnapDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
	[Cpp2IlInjected.Token(Token = "0x4000829")]
	private bool gridSnapLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x133")]
	[Cpp2IlInjected.Token(Token = "0x400082A")]
	private bool gridSnapRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x400082B")]
	private Vector2 movementAxisScreenOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x400082C")]
	private Vector2 fireAxisScreenOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x400082D")]
	private Vector2 grappleAxisScreenOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x400082E")]
	private Vector2 previousGrappleAxisScreenOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x400082F")]
	private Vector2 grappleAxisCentre;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x4000830")]
	private Vector2 movementAxisCentre;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x4000831")]
	private Vector2 fireAxisCentre;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x4000832")]
	public bool[] Pressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000833")]
	public bool[] WasPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x4000834")]
	public float[] Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000835")]
	private float TimeSinceToggleSmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000836")]
	private float TimeSinceToggleAutoFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000837")]
	public float TimeSinceModifyZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000838")]
	private float TimeSinceCombatTargeting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000839")]
	private float TimeSinceProfileChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x400083A")]
	public bool InventoryToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18D")]
	[Cpp2IlInjected.Token(Token = "0x400083B")]
	private bool Shown;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool HasGrapple
	{
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0xECFAD4", Offset = "0xECFAD4", VA = "0xECFAD4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool JumpTapPressed
	{
		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0xECFB6C", Offset = "0xECFB6C", VA = "0xECFB6C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool WasJumpTapPressed
	{
		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0xECFB8C", Offset = "0xECFB8C", VA = "0xECFB8C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool InGameUIOpen
	{
		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0xED7D44", Offset = "0xED7D44", VA = "0xED7D44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0xECF808", Offset = "0xECF808", VA = "0xECF808")]
	public GUIVirtualInputController()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0xECF9DC", Offset = "0xECF9DC", VA = "0xECF9DC")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0xECFC68", Offset = "0xECFC68", VA = "0xECFC68")]
	private void UpdateMovementAxis(Vector2 rawAxis)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0xED00F0", Offset = "0xED00F0", VA = "0xED00F0")]
	private void UpdateFireAxis(Vector2 rawAxis)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0xED01E4", Offset = "0xED01E4", VA = "0xED01E4")]
	private void HideNotifications()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0xED0200", Offset = "0xED0200", VA = "0xED0200")]
	private void AddInteractBanner(Player player, Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0xED0F08", Offset = "0xED0F08", VA = "0xED0F08")]
	public void ResetSMCurosrNotification()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0xED0F28", Offset = "0xED0F28", VA = "0xED0F28")]
	private static bool CanInteract(Player player, Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0xED14B8", Offset = "0xED14B8", VA = "0xED14B8")]
	public Vector2 GetPressedControlPosition(VirtualControlsHardwareConfigurationMapping_Layout.ContolType controlType, out VirtualControlsHardwareConfigurationMapping_Layout slotConfiguration)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0xED17D0", Offset = "0xED17D0", VA = "0xED17D0")]
	public void Update(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0xEDAA8C", Offset = "0xEDAA8C", VA = "0xEDAA8C")]
	private void HandleCursorGridSnap(bool tileBoostWholeScreen, int screenCenterX, int screenCenterY, int tB, ref float MouseX, ref float MouseY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0xEDAF18", Offset = "0xEDAF18", VA = "0xEDAF18")]
	private void HandleGridSnapCursorMovement(Item selectedItem, int screenCenterX, int screenCenterY, int tB, ref float MouseX, ref float MouseY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0xEDBAA0", Offset = "0xEDBAA0", VA = "0xEDBAA0")]
	private Vector2 FilterFireAxis(Vector2 fireAxis)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0xED7E88", Offset = "0xED7E88", VA = "0xED7E88")]
	private void UpdateCursorMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0xEDBB18", Offset = "0xEDBB18", VA = "0xEDBB18")]
	public void SecondaryUpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0xEDCDE0", Offset = "0xEDCDE0", VA = "0xEDCDE0")]
	private bool IsOverGroupRegion(GUIPageIconGrouping group, Point mousePoint)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0xEDE17C", Offset = "0xEDE17C", VA = "0xEDE17C")]
	public void UpdateCursor(Cursor cursor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0xEDF2B4", Offset = "0xEDF2B4", VA = "0xEDF2B4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0xEE1248", Offset = "0xEE1248", VA = "0xEE1248")]
	private void DrawControlStringNotifications()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0xEDF828", Offset = "0xEDF828", VA = "0xEDF828")]
	private void DrawControls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0xEE17F4", Offset = "0xEE17F4", VA = "0xEE17F4")]
	private void DrawMapControls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0xEE1A28", Offset = "0xEE1A28", VA = "0xEE1A28")]
	public void Show()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0xEE1A34", Offset = "0xEE1A34", VA = "0xEE1A34")]
	public void Hide()
	{
	}
}
