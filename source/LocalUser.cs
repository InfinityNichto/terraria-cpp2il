using Controller;
using Cpp2IlInjected;
using Terraria.GameContent.Liquid;
using Terraria.Graphics.Effects;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000213")]
public class LocalUser
{
	[Cpp2IlInjected.Token(Token = "0x400187D")]
	private static byte[] _cryptoKey;

	[Cpp2IlInjected.Token(Token = "0x400187E")]
	public static LocalUser Active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400187F")]
	public SkyManager SkyManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001880")]
	public FilterManager FilterManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001881")]
	public OverlayManager OverlayManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001882")]
	private bool usingKeyboardMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001883")]
	public ControllerDevice ActiveController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001884")]
	public GUIInstance GUIInstance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001885")]
	public CursorManager cursorManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001886")]
	public ControllerActionManager controllerActionManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001887")]
	public GUIInputRegionManager guiInputRegionManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001888")]
	public MPSessionManager mpSessionManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001889")]
	public XNAUIInputLayer xnaUIInputLayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400188A")]
	public FileManager fileManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400188B")]
	public LiquidRenderer liquidRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400188C")]
	public int UserIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400188D")]
	public PlatformUser UserId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400188E")]
	public IPlatformAwardNotifier PlatformAwards;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400188F")]
	public PersistentUserData PersistentUserData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001890")]
	public XNAUICameraSettings UICameraSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001891")]
	public XNAWorldCameraSettings WorldCameraSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001892")]
	public LocalUserGameState GameState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001893")]
	public LocalUserXNAState XNAState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001894")]
	public InterfaceProfile_Layout[] CustomProfiles;

	[Cpp2IlInjected.Token(Token = "0x4001895")]
	private static Camera _worldCam2;

	[Cpp2IlInjected.Token(Token = "0x4001896")]
	private static Camera _worldCam3;

	[Cpp2IlInjected.Token(Token = "0x4001897")]
	private static Camera _worldCam4;

	[Cpp2IlInjected.Token(Token = "0x4001898")]
	private static Camera _uiCam2;

	[Cpp2IlInjected.Token(Token = "0x4001899")]
	private static Camera _uiCam3;

	[Cpp2IlInjected.Token(Token = "0x400189A")]
	private static Camera _uiCam4;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public Rect ViewportRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000F06")]
		[Cpp2IlInjected.Address(RVA = "0x12DEEAC", Offset = "0x12DEEAC", VA = "0x12DEEAC")]
		get
		{
			return default(Rect);
		}
		[Cpp2IlInjected.Token(Token = "0x6000F05")]
		[Cpp2IlInjected.Address(RVA = "0x12DEE3C", Offset = "0x12DEE3C", VA = "0x12DEE3C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000EFE")]
	[Cpp2IlInjected.Address(RVA = "0x12DB800", Offset = "0x12DB800", VA = "0x12DB800")]
	public LocalUser(int userIndex, PlatformUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000EFF")]
	[Cpp2IlInjected.Address(RVA = "0x12DD158", Offset = "0x12DD158", VA = "0x12DD158")]
	public void SetupState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F00")]
	[Cpp2IlInjected.Address(RVA = "0x12DDA90", Offset = "0x12DDA90", VA = "0x12DDA90")]
	public void LoadThreadstate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F01")]
	[Cpp2IlInjected.Address(RVA = "0x12DD634", Offset = "0x12DD634", VA = "0x12DD634")]
	public void LoadState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F02")]
	[Cpp2IlInjected.Address(RVA = "0x12DDB2C", Offset = "0x12DDB2C", VA = "0x12DDB2C")]
	public static void UnloadState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F03")]
	[Cpp2IlInjected.Address(RVA = "0x12DDBA8", Offset = "0x12DDBA8", VA = "0x12DDBA8")]
	public void LoadPersistantData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F04")]
	[Cpp2IlInjected.Address(RVA = "0x12DE89C", Offset = "0x12DE89C", VA = "0x12DE89C")]
	public void SavePersistantData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F07")]
	[Cpp2IlInjected.Address(RVA = "0x12DEEC8", Offset = "0x12DEEC8", VA = "0x12DEEC8")]
	private static Camera GetCamera(string name)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000F08")]
	[Cpp2IlInjected.Address(RVA = "0x12DCE1C", Offset = "0x12DCE1C", VA = "0x12DCE1C")]
	public static Camera GetWorldCamera(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000F09")]
	[Cpp2IlInjected.Address(RVA = "0x12DCAE0", Offset = "0x12DCAE0", VA = "0x12DCAE0")]
	public static Camera GetUICamera(int index)
	{
		return null;
	}
}
