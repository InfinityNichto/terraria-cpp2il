using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000252")]
public class XNAUnityRunner : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000811")]
	public enum ForcedInputMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007D6A")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007D6B")]
		Touch,
		[Cpp2IlInjected.Token(Token = "0x4007D6C")]
		Controller,
		[Cpp2IlInjected.Token(Token = "0x4007D6D")]
		KeyboardMouse
	}

	[Cpp2IlInjected.Token(Token = "0x2000812")]
	public class MouseStateBackup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D6E")]
		private int _mouseX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007D6F")]
		private int _mouseY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007D70")]
		private int _lastMouseX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007D71")]
		private int _lastMouseY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007D72")]
		private int _worldMouseX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007D73")]
		private int _worldMouseY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007D74")]
		private bool _mouseLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4007D75")]
		private bool _mouseRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4007D76")]
		private bool _mouseLeftRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4007D77")]
		private bool _mouseRightRelease;

		[Cpp2IlInjected.Token(Token = "0x600495A")]
		[Cpp2IlInjected.Address(RVA = "0x1503E08", Offset = "0x1503E08", VA = "0x1503E08")]
		public void Capture()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600495B")]
		[Cpp2IlInjected.Address(RVA = "0x1504020", Offset = "0x1504020", VA = "0x1504020")]
		public void Restore()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600495C")]
		[Cpp2IlInjected.Address(RVA = "0x1503EF0", Offset = "0x1503EF0", VA = "0x1503EF0")]
		public void UpdateState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600495D")]
		[Cpp2IlInjected.Address(RVA = "0x150433C", Offset = "0x150433C", VA = "0x150433C")]
		public MouseStateBackup()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001BEF")]
	public static XNAUnityRunner _instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BF0")]
	public XNAWorldCameraSettings WorldCameraSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BF1")]
	public XNAUICameraSettings UICameraSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001BF2")]
	public bool IncrementalBatching;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4001BF3")]
	public bool LogMaterialCreation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4001BF4")]
	public bool DisableVariableUpdate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001BF5")]
	public Microsoft.Xna.Framework.Vector2 IncrementalBatchingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001BF6")]
	public bool EnableBatching;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4001BF7")]
	public bool DumpMemory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001BF8")]
	public string ReleaseVersion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001BF9")]
	public int BuildNumber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001BFA")]
	public bool DumpGeometryStats;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001BFB")]
	public float DefaultUITabletMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001BFC")]
	public Texture2D WaterMask;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001BFD")]
	public int WorldInputEdgeRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001BFE")]
	public long SimulatedDiskSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001BFF")]
	public long SimulatedDeviceMemory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001C00")]
	public bool SimulatedCloudRequired;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4001C01")]
	public bool SimulatedCloudAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4001C02")]
	public bool SimulatedCloudConnected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001C03")]
	public float SimulatedCloudSyncTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001C04")]
	public ForcedInputMode ForcedInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001C05")]
	private Game _game;

	[Cpp2IlInjected.Token(Token = "0x4001C06")]
	private static bool broadcastTest;

	[Cpp2IlInjected.Token(Token = "0x4001C07")]
	private static bool firstUpdate;

	[Cpp2IlInjected.Token(Token = "0x4001C08")]
	private static UnityEngine.Vector3 LastMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001C09")]
	private UnityEngine.Vector3 lastMousePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001C0A")]
	private bool KeyboardOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
	[Cpp2IlInjected.Token(Token = "0x4001C0B")]
	private bool lastFrameSplitHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001C0C")]
	private int lastSplitPlayerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001C0D")]
	public bool SplitscreenOrientationChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x75")]
	[Cpp2IlInjected.Token(Token = "0x4001C0E")]
	private bool switchNextFrame;

	[Cpp2IlInjected.Token(Token = "0x4001C0F")]
	public static bool _mobileKeyboardLocked;

	[Cpp2IlInjected.Token(Token = "0x4001C10")]
	public static int DelayInputSwitch;

	[Cpp2IlInjected.Token(Token = "0x4001C11")]
	public static bool _mobileControllerLocked;

	[Cpp2IlInjected.Token(Token = "0x4001C12")]
	public static bool _mobileTouchLocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4001C13")]
	private int mobileMouseMode;

	[Cpp2IlInjected.Token(Token = "0x4001C14")]
	private static bool _renderingUI;

	[Cpp2IlInjected.Token(Token = "0x4001C15")]
	public static int _frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4001C16")]
	public AnimationCurve FireAxisRemap;

	[Cpp2IlInjected.Token(Token = "0x1700018E")]
	public static ForcedInputMode CurrentInputMode
	{
		[Cpp2IlInjected.Token(Token = "0x60010DF")]
		[Cpp2IlInjected.Address(RVA = "0x14FEED8", Offset = "0x14FEED8", VA = "0x14FEED8")]
		get
		{
			return default(ForcedInputMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700018F")]
	public static ForcedInputMode PrimaryInputMode
	{
		[Cpp2IlInjected.Token(Token = "0x60010E0")]
		[Cpp2IlInjected.Address(RVA = "0x14FEBD0", Offset = "0x14FEBD0", VA = "0x14FEBD0")]
		get
		{
			return default(ForcedInputMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000190")]
	public static int ScreenWidth
	{
		[Cpp2IlInjected.Token(Token = "0x60010EA")]
		[Cpp2IlInjected.Address(RVA = "0x14FDB0C", Offset = "0x14FDB0C", VA = "0x14FDB0C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000191")]
	public static int ScreenHeight
	{
		[Cpp2IlInjected.Token(Token = "0x60010EB")]
		[Cpp2IlInjected.Address(RVA = "0x14FDB14", Offset = "0x14FDB14", VA = "0x14FDB14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000192")]
	public static UnityEngine.Vector3 MousePosition
	{
		[Cpp2IlInjected.Token(Token = "0x60010ED")]
		[Cpp2IlInjected.Address(RVA = "0x1501D58", Offset = "0x1501D58", VA = "0x1501D58")]
		get
		{
			return default(UnityEngine.Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	public static UnityEngine.Vector3 MousePositionReal
	{
		[Cpp2IlInjected.Token(Token = "0x60010EE")]
		[Cpp2IlInjected.Address(RVA = "0x1501EF0", Offset = "0x1501EF0", VA = "0x1501EF0")]
		get
		{
			return default(UnityEngine.Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	public static bool MobileKeyboardLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010F3")]
		[Cpp2IlInjected.Address(RVA = "0x1502440", Offset = "0x1502440", VA = "0x1502440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60010F4")]
		[Cpp2IlInjected.Address(RVA = "0x15024B8", Offset = "0x15024B8", VA = "0x15024B8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	public static bool KeyboardModeLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010F5")]
		[Cpp2IlInjected.Address(RVA = "0x1502620", Offset = "0x1502620", VA = "0x1502620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	public static bool MobileControllerLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010F6")]
		[Cpp2IlInjected.Address(RVA = "0x150273C", Offset = "0x150273C", VA = "0x150273C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60010F7")]
		[Cpp2IlInjected.Address(RVA = "0x150256C", Offset = "0x150256C", VA = "0x150256C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	public static bool ControllerModeLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010F8")]
		[Cpp2IlInjected.Address(RVA = "0x14FEF58", Offset = "0x14FEF58", VA = "0x14FEF58")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	public static bool MobileTouchLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010F9")]
		[Cpp2IlInjected.Address(RVA = "0x15027B4", Offset = "0x15027B4", VA = "0x15027B4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60010FA")]
		[Cpp2IlInjected.Address(RVA = "0x150282C", Offset = "0x150282C", VA = "0x150282C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	public static bool TouchInputKeyboardLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010FB")]
		[Cpp2IlInjected.Address(RVA = "0x15028E8", Offset = "0x15028E8", VA = "0x15028E8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	public static bool TouchModeLocked
	{
		[Cpp2IlInjected.Token(Token = "0x60010FC")]
		[Cpp2IlInjected.Address(RVA = "0x15029C0", Offset = "0x15029C0", VA = "0x15029C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	public static bool RenderingUI
	{
		[Cpp2IlInjected.Token(Token = "0x60010FF")]
		[Cpp2IlInjected.Address(RVA = "0x1502DDC", Offset = "0x1502DDC", VA = "0x1502DDC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	private static MouseStateBackup _uiMouseState
	{
		[Cpp2IlInjected.Token(Token = "0x6001100")]
		[Cpp2IlInjected.Address(RVA = "0x1502E54", Offset = "0x1502E54", VA = "0x1502E54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	private static MouseStateBackup _worldMouseState
	{
		[Cpp2IlInjected.Token(Token = "0x6001101")]
		[Cpp2IlInjected.Address(RVA = "0x1502ED0", Offset = "0x1502ED0", VA = "0x1502ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	private static int _lastUIFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6001102")]
		[Cpp2IlInjected.Address(RVA = "0x1502F4C", Offset = "0x1502F4C", VA = "0x1502F4C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001103")]
		[Cpp2IlInjected.Address(RVA = "0x1502FC8", Offset = "0x1502FC8", VA = "0x1502FC8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60010E1")]
	[Cpp2IlInjected.Address(RVA = "0x14FF0A8", Offset = "0x14FF0A8", VA = "0x14FF0A8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E2")]
	[Cpp2IlInjected.Address(RVA = "0x14FFA04", Offset = "0x14FFA04", VA = "0x14FFA04")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E3")]
	[Cpp2IlInjected.Address(RVA = "0x14FFA98", Offset = "0x14FFA98", VA = "0x14FFA98")]
	private void Application_lowMemory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E4")]
	[Cpp2IlInjected.Address(RVA = "0x14FFB18", Offset = "0x14FFB18", VA = "0x14FFB18")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E5")]
	[Cpp2IlInjected.Address(RVA = "0x14FFBA4", Offset = "0x14FFBA4", VA = "0x14FFBA4")]
	private void OnGUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E6")]
	[Cpp2IlInjected.Address(RVA = "0x14FFBA8", Offset = "0x14FFBA8", VA = "0x14FFBA8")]
	public void OnApplicationQuit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E7")]
	[Cpp2IlInjected.Address(RVA = "0x14FFDEC", Offset = "0x14FFDEC", VA = "0x14FFDEC")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E8")]
	[Cpp2IlInjected.Address(RVA = "0x14FFE6C", Offset = "0x14FFE6C", VA = "0x14FFE6C")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010E9")]
	[Cpp2IlInjected.Address(RVA = "0x15001B8", Offset = "0x15001B8", VA = "0x15001B8")]
	private string GetNextScreenshotFilename()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60010EC")]
	[Cpp2IlInjected.Address(RVA = "0x1500558", Offset = "0x1500558", VA = "0x1500558")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010EF")]
	[Cpp2IlInjected.Address(RVA = "0x1501F68", Offset = "0x1501F68", VA = "0x1501F68")]
	public static float GetMouseScrollDelta(bool ignoreEditor = false)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60010F0")]
	[Cpp2IlInjected.Address(RVA = "0x150209C", Offset = "0x150209C", VA = "0x150209C")]
	public static bool GetMouseButton(int index, bool ignoreEditor = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60010F1")]
	[Cpp2IlInjected.Address(RVA = "0x15021A0", Offset = "0x15021A0", VA = "0x15021A0")]
	public static bool GetMouseButtonUp(int index, bool ignoreEditor = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60010F2")]
	[Cpp2IlInjected.Address(RVA = "0x15022F0", Offset = "0x15022F0", VA = "0x15022F0")]
	public static bool GetMouseButtonDown(int index, bool ignoreEditor = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60010FD")]
	[Cpp2IlInjected.Address(RVA = "0x1502ADC", Offset = "0x1502ADC", VA = "0x1502ADC")]
	private void SetMobileMouseMode(int mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60010FE")]
	[Cpp2IlInjected.Address(RVA = "0x15005E4", Offset = "0x15005E4", VA = "0x15005E4")]
	private void ExecuteFrame(float timeDelta)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001104")]
	[Cpp2IlInjected.Address(RVA = "0x14FE4F0", Offset = "0x14FE4F0", VA = "0x14FE4F0")]
	public static Microsoft.Xna.Framework.Vector2 AdjustRealScreenForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001105")]
	[Cpp2IlInjected.Address(RVA = "0x1503048", Offset = "0x1503048", VA = "0x1503048")]
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001106")]
	[Cpp2IlInjected.Address(RVA = "0x1503198", Offset = "0x1503198", VA = "0x1503198")]
	public static Microsoft.Xna.Framework.Vector2 AdjustUIForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001107")]
	[Cpp2IlInjected.Address(RVA = "0x15032D8", Offset = "0x15032D8", VA = "0x15032D8")]
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldPositionForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001108")]
	[Cpp2IlInjected.Address(RVA = "0x150344C", Offset = "0x150344C", VA = "0x150344C")]
	public static Microsoft.Xna.Framework.Vector2 ScaleUIDirectionForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001109")]
	[Cpp2IlInjected.Address(RVA = "0x1503550", Offset = "0x1503550", VA = "0x1503550")]
	public static Microsoft.Xna.Framework.Vector2 ScaleScreenDirectionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600110A")]
	[Cpp2IlInjected.Address(RVA = "0x1503634", Offset = "0x1503634", VA = "0x1503634")]
	public static Microsoft.Xna.Framework.Vector2 ScaleWorldDirectionForScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600110B")]
	[Cpp2IlInjected.Address(RVA = "0x1503718", Offset = "0x1503718", VA = "0x1503718")]
	public static Microsoft.Xna.Framework.Vector2 AdjustScreenPositionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		return default(Microsoft.Xna.Framework.Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600110C")]
	[Cpp2IlInjected.Address(RVA = "0x1503890", Offset = "0x1503890", VA = "0x1503890")]
	public static void SetupRenderingUI(bool renderingUI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600110D")]
	[Cpp2IlInjected.Address(RVA = "0x1504158", Offset = "0x1504158", VA = "0x1504158")]
	public XNAUnityRunner()
	{
	}
}
