using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DrPlatformEditorData : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static DrPlatformEditorData Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public bool ForcePlatform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public DrPlatform.DrPlatformType ForcedPlatform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool ForceSKU;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public DrPlatform.DrSKUType ForcedSKU;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool EditorHasMultiplayerPermission;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public bool EditorHasChatPermission;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool EditorHasUGCPermission;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public bool EditorHasPlatformFriends;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool EditorForceControllerDisconnected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool EditorForceSplitScreenProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool EditorSwitchedDocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool EditorIsTrial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool EditorSwitchJoyCon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool EditorMouseAsTouch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool EditorIsChromebook;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool UseProfiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool ValidateSetup;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool _firstProfileAccess;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private DrEditorProfile _activeProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int InitialEditorProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public DrEditorProfile[] EditorProfiles;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DrEditorProfile ActiveProfile
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x20D0C44", Offset = "0x20D0C44", VA = "0x20D0C44")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x20D1B78", Offset = "0x20D1B78", VA = "0x20D1B78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x20D1AFC", Offset = "0x20D1AFC", VA = "0x20D1AFC")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x20D1B80", Offset = "0x20D1B80", VA = "0x20D1B80")]
	public DrPlatformEditorData()
	{
	}
}
