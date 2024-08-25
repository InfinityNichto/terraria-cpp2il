using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200003D")]
public class DrPlatformEditorData : MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x600014D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70469C", Offset = "0x70469C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000063")]
	public DrEditorProfile ActiveProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x600014E")]
		[global::Cpp2ILInjected.Address(RVA = "0x701D40", Offset = "0x701D40", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600014F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7046E8", Offset = "0x7046E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000150")]
	[global::Cpp2ILInjected.Address(RVA = "0x7046F0", Offset = "0x7046F0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public DrPlatformEditorData()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
	public static DrPlatformEditorData Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool ForcePlatform;

	[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public DrPlatform.DrPlatformType ForcedPlatform;

	[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool ForceSKU;

	[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public DrPlatform.DrSKUType ForcedSKU;

	[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool EditorHasMultiplayerPermission;

	[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool EditorHasChatPermission;

	[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
	public bool EditorHasUGCPermission;

	[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
	public bool EditorHasPlatformFriends;

	[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public bool EditorForceControllerDisconnected;

	[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
	public bool EditorForceSplitScreenProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
	public bool EditorSwitchedDocked;

	[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F")]
	public bool EditorIsTrial;

	[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool EditorSwitchJoyCon;

	[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public bool EditorMouseAsTouch;

	[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
	public bool EditorIsChromebook;

	[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
	public bool UseProfiles;

	[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public bool ValidateSetup;

	[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	private bool _firstProfileAccess;

	[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private DrEditorProfile _activeProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int InitialEditorProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DrEditorProfile[] EditorProfiles;
}
