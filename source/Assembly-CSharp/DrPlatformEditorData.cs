using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000023 RID: 35
[global::Cpp2ILInjected.Token(Token = "0x200003D")]
public class DrPlatformEditorData : MonoBehaviour
{
	// Token: 0x060000D4 RID: 212 RVA: 0x00021DF4 File Offset: 0x0001FFF4
	[global::Cpp2ILInjected.Token(Token = "0x600014D")]
	[global::Cpp2ILInjected.Address(RVA = "0x70469C", Offset = "0x70469C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x00021DF7 File Offset: 0x0001FFF7
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x00021DFA File Offset: 0x0001FFFA
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

	// Token: 0x060000D7 RID: 215 RVA: 0x00021DFD File Offset: 0x0001FFFD
	[global::Cpp2ILInjected.Token(Token = "0x6000150")]
	[global::Cpp2ILInjected.Address(RVA = "0x7046F0", Offset = "0x7046F0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public DrPlatformEditorData()
	{
		throw null;
	}

	// Token: 0x04000090 RID: 144
	[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
	public static DrPlatformEditorData Instance;

	// Token: 0x04000091 RID: 145
	[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool ForcePlatform;

	// Token: 0x04000092 RID: 146
	[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public DrPlatform.DrPlatformType ForcedPlatform;

	// Token: 0x04000093 RID: 147
	[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool ForceSKU;

	// Token: 0x04000094 RID: 148
	[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public DrPlatform.DrSKUType ForcedSKU;

	// Token: 0x04000095 RID: 149
	[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool EditorHasMultiplayerPermission;

	// Token: 0x04000096 RID: 150
	[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool EditorHasChatPermission;

	// Token: 0x04000097 RID: 151
	[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
	public bool EditorHasUGCPermission;

	// Token: 0x04000098 RID: 152
	[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
	public bool EditorHasPlatformFriends;

	// Token: 0x04000099 RID: 153
	[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public bool EditorForceControllerDisconnected;

	// Token: 0x0400009A RID: 154
	[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
	public bool EditorForceSplitScreenProfile;

	// Token: 0x0400009B RID: 155
	[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
	public bool EditorSwitchedDocked;

	// Token: 0x0400009C RID: 156
	[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F")]
	public bool EditorIsTrial;

	// Token: 0x0400009D RID: 157
	[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool EditorSwitchJoyCon;

	// Token: 0x0400009E RID: 158
	[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
	public bool EditorMouseAsTouch;

	// Token: 0x0400009F RID: 159
	[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
	public bool EditorIsChromebook;

	// Token: 0x040000A0 RID: 160
	[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
	public bool UseProfiles;

	// Token: 0x040000A1 RID: 161
	[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public bool ValidateSetup;

	// Token: 0x040000A2 RID: 162
	[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	private bool _firstProfileAccess;

	// Token: 0x040000A3 RID: 163
	[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private DrEditorProfile _activeProfile;

	// Token: 0x040000A4 RID: 164
	[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int InitialEditorProfile;

	// Token: 0x040000A5 RID: 165
	[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public DrEditorProfile[] EditorProfiles;
}
