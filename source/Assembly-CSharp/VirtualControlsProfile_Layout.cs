using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Terraria.IO;
using Terraria.Localization;

// Token: 0x020001BA RID: 442
[JsonObject(MemberSerialization.OptIn)]
[global::Cpp2ILInjected.Token(Token = "0x200024C")]
[Serializable]
public class VirtualControlsProfile_Layout
{
	// Token: 0x06000C23 RID: 3107 RVA: 0x00023FAE File Offset: 0x000221AE
	[global::Cpp2ILInjected.Token(Token = "0x6000D3D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D60D8", Offset = "0x9D60D8", Length = "0x44")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "CycleNextProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	public bool HasProfileMapping()
	{
		throw null;
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00023FB1 File Offset: 0x000221B1
	[global::Cpp2ILInjected.Token(Token = "0x6000D3E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D611C", Offset = "0x9D611C", Length = "0x188")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIProfileSwitch), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControlStringNotifications", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(String_Layout), Member = "GetFont", ReturnType = typeof(SpriteFont))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public string GetDisplayName(float maxWidth = 800f)
	{
		throw null;
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00023FB4 File Offset: 0x000221B4
	[global::Cpp2ILInjected.Token(Token = "0x1700016F")]
	public VirtualControlsHardwareConfiguration_Layout HardwareConfig
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D62A4", Offset = "0x9D62A4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControlsStyles_Layout), Member = "GetHardwareConfiguration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(VirtualControlsHardwareConfiguration_Layout))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00023FB7 File Offset: 0x000221B7
	[global::Cpp2ILInjected.Token(Token = "0x6000D40")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D638C", Offset = "0x9D638C", Length = "0x108")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsStyles_Layout), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit.BackupResotrePoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(VirtualControlsProfile_Layout)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "Backup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlRedo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "RestoreBackup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public void Copy(VirtualControlsProfile_Layout other)
	{
		throw null;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x00023FBA File Offset: 0x000221BA
	[global::Cpp2ILInjected.Token(Token = "0x6000D41")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D6494", Offset = "0x9D6494", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "AddControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "HasUndo", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = "ControlUndo", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public bool IsSame(VirtualControlsProfile_Layout other)
	{
		throw null;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x00023FBD File Offset: 0x000221BD
	[global::Cpp2ILInjected.Token(Token = "0x6000D42")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D6520", Offset = "0x9D6520", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit.BackupResotrePoint), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(VirtualControlsHardwareConfiguration_Layout),
		typeof(VirtualControlsProfile_Layout)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInterfaceEdit), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public VirtualControlsProfile_Layout()
	{
		throw null;
	}

	// Token: 0x04001376 RID: 4982
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x400184E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	// Token: 0x04001377 RID: 4983
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x400184F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string EditedName;

	// Token: 0x04001378 RID: 4984
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x4001850")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string Hardware;

	// Token: 0x04001379 RID: 4985
	[global::Cpp2ILInjected.Token(Token = "0x4001851")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private VirtualControlsHardwareConfiguration_Layout _cachedHardware;

	// Token: 0x0400137A RID: 4986
	[JsonProperty]
	[global::Cpp2ILInjected.Token(Token = "0x4001852")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public VirtualControlsBinding_Layout[] Controls;
}
