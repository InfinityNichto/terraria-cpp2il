using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.Utilities;

// Token: 0x0200010D RID: 269
[global::Cpp2ILInjected.Token(Token = "0x200017F")]
public class VirtualControllerInputState
{
	// Token: 0x060009E0 RID: 2528 RVA: 0x000238E5 File Offset: 0x00021AE5
	[global::Cpp2ILInjected.Token(Token = "0x6000AE4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1BC8", Offset = "0x9A1BC8", Length = "0x2BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveDefaultCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(IEnumerable<object>),
		typeof(Func<object, bool>)
	}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ForEach", MemberParameters = new object[] { typeof(Action<object>) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	private static void SetupLookups()
	{
		throw null;
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000238E8 File Offset: 0x00021AE8
	[global::Cpp2ILInjected.Token(Token = "0x17000117")]
	private string ConfigFile
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A1E84", Offset = "0x9A1E84", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SaveDefaultCategories", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x000238EB File Offset: 0x00021AEB
	[global::Cpp2ILInjected.Token(Token = "0x6000AE6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A1EF4", Offset = "0x9A1EF4", Length = "0x348")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	private static void SaveCodeArrayCategories()
	{
		throw null;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x000238EE File Offset: 0x00021AEE
	[global::Cpp2ILInjected.Token(Token = "0x6000AE7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A223C", Offset = "0x9A223C", Length = "0x2CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "get_ConfigFile", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Delete", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "SetupLookups", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CSVWriter), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
	public void SaveDefaultCategories()
	{
		throw null;
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x000238F1 File Offset: 0x00021AF1
	[global::Cpp2ILInjected.Token(Token = "0x6000AE8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2508", Offset = "0x9A2508", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void LoadDefaultCategories()
	{
		throw null;
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x000238F4 File Offset: 0x00021AF4
	[global::Cpp2ILInjected.Token(Token = "0x6000AE9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A250C", Offset = "0x9A250C", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetItemCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(VirtualControllerInputState.Category))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "ContainsKey", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetCategoryDefaults", MemberParameters = new object[]
	{
		typeof(VirtualControllerInputState.Category),
		typeof(ref bool),
		typeof(ref bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public float GetItemDeadZone(Item item)
	{
		throw null;
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x000238F7 File Offset: 0x00021AF7
	[global::Cpp2ILInjected.Token(Token = "0x6000AEA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A269C", Offset = "0x9A269C", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(Item),
		typeof(ref Texture2D),
		typeof(ref Rectangle),
		typeof(ref bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "GetItemDeadZone", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "UpdateState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static VirtualControllerInputState.Category GetItemCategory(int item)
	{
		throw null;
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x000238FA File Offset: 0x00021AFA
	[global::Cpp2ILInjected.Token(Token = "0x6000AEB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A27A4", Offset = "0x9A27A4", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetItemCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(VirtualControllerInputState.Category))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseNPCType", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void UpdateState(int selectedItem)
	{
		throw null;
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000238FD File Offset: 0x00021AFD
	[global::Cpp2ILInjected.Token(Token = "0x17000118")]
	public bool ForceAutoReuse
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A2A54", Offset = "0x9A2A54", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00023900 File Offset: 0x00021B00
	[global::Cpp2ILInjected.Token(Token = "0x17000119")]
	public float NoFireDeadZone
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A2AA4", Offset = "0x9A2AA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060009EA RID: 2538 RVA: 0x00023903 File Offset: 0x00021B03
	// (set) Token: 0x060009EB RID: 2539 RVA: 0x00023906 File Offset: 0x00021B06
	[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
	public bool SmartDigEnabled
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A2AAC", Offset = "0x9A2AAC", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(QuickActionButton_Layout.QuickActionControl),
			typeof(QuickActionButton_Layout),
			typeof(bool),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsStatusIndicators), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControlStringNotifications", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_SmartCursorIsUsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_SmartCursorWanted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWorldCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTileGridOption", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000AEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A2C10", Offset = "0x9A2C10", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "set_SmartCursorIsUsed", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "set_SmartCursorWanted", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "set_Item", MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SettingsSavePending", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x060009EC RID: 2540 RVA: 0x00023909 File Offset: 0x00021B09
	// (set) Token: 0x060009ED RID: 2541 RVA: 0x0002390C File Offset: 0x00021B0C
	[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
	public bool AimAndUseEnabled
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A2D58", Offset = "0x9A2D58", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
		{
			typeof(QuickActionButton_Layout.QuickActionControl),
			typeof(QuickActionButton_Layout),
			typeof(bool),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsStatusIndicators), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateFireAxis", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControlStringNotifications", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_HasMapping", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsPageSelected", MemberParameters = new object[] { typeof(GUIPageIcons.Category) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A2EA0", Offset = "0x9A2EA0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "set_Item", MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SettingsSavePending", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x0002390F File Offset: 0x00021B0F
	[global::Cpp2ILInjected.Token(Token = "0x6000AF2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2874", Offset = "0x9A2874", Length = "0x1E0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "ResetConfiguration", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "ContainsKey", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "ContainsKey", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetCategoryDefaults", MemberParameters = new object[]
	{
		typeof(VirtualControllerInputState.Category),
		typeof(ref bool),
		typeof(ref bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void SetCatergoryState(VirtualControllerInputState.Category category)
	{
		throw null;
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x00023912 File Offset: 0x00021B12
	[global::Cpp2ILInjected.Token(Token = "0x6000AF3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2A6C", Offset = "0x9A2A6C", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool GetCategoryAutoSwing(VirtualControllerInputState.Category category)
	{
		throw null;
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x00023915 File Offset: 0x00021B15
	[global::Cpp2ILInjected.Token(Token = "0x6000AF4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2700", Offset = "0x9A2700", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "GetItemDeadZone", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "SetCatergoryState", MemberParameters = new object[] { typeof(VirtualControllerInputState.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "ResetConfiguration", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = "LoadConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void GetCategoryDefaults(VirtualControllerInputState.Category category, out bool smartCursor, out bool aimAndUse, out float noFireDeadZone)
	{
		throw null;
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00023918 File Offset: 0x00021B18
	[global::Cpp2ILInjected.Token(Token = "0x6000AF5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2F7C", Offset = "0x9A2F7C", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ResetSettings", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetCategoryDefaults", MemberParameters = new object[]
	{
		typeof(VirtualControllerInputState.Category),
		typeof(ref bool),
		typeof(ref bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "SetCatergoryState", MemberParameters = new object[] { typeof(VirtualControllerInputState.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ResetConfiguration()
	{
		throw null;
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x0002391B File Offset: 0x00021B1B
	[global::Cpp2ILInjected.Token(Token = "0x6000AF6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3064", Offset = "0x9A3064", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
	{
		typeof(string),
		"T"
	}, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "GetCategoryDefaults", MemberParameters = new object[]
	{
		typeof(VirtualControllerInputState.Category),
		typeof(ref bool),
		typeof(ref bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = "set_Item", MemberParameters = new object[]
	{
		"System.Int32Enum",
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VirtualControllerInputState), Member = "SetCatergoryState", MemberParameters = new object[] { typeof(VirtualControllerInputState.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public void LoadConfiguration(Preferences preferences)
	{
		throw null;
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0002391E File Offset: 0x00021B1E
	[global::Cpp2ILInjected.Token(Token = "0x6000AF7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A32EC", Offset = "0x9A32EC", Length = "0x278")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	public void SaveConfiguration(Preferences preferences)
	{
		throw null;
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00023921 File Offset: 0x00021B21
	[global::Cpp2ILInjected.Token(Token = "0x6000AF8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A3564", Offset = "0x9A3564", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, float>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public VirtualControllerInputState()
	{
		throw null;
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00023924 File Offset: 0x00021B24
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000AF9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A364C", Offset = "0x9A364C", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(RuntimeFieldHandle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int[])
	}, ReturnType = typeof(int[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static VirtualControllerInputState()
	{
		throw null;
	}

	// Token: 0x0400085D RID: 2141
	[global::Cpp2ILInjected.Token(Token = "0x4000B34")]
	private static string[] IdLookup;

	// Token: 0x0400085E RID: 2142
	[global::Cpp2ILInjected.Token(Token = "0x4000B35")]
	public static int[] ItemCategories;

	// Token: 0x0400085F RID: 2143
	[global::Cpp2ILInjected.Token(Token = "0x4000B36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool printMessages;

	// Token: 0x04000860 RID: 2144
	[global::Cpp2ILInjected.Token(Token = "0x4000B37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool ForceAutoSwingEnabled;

	// Token: 0x04000861 RID: 2145
	[global::Cpp2ILInjected.Token(Token = "0x4000B38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public VirtualControllerInputState.CursorInputMode TouchSmartCursor;

	// Token: 0x04000862 RID: 2146
	[global::Cpp2ILInjected.Token(Token = "0x4000B39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControllerInputState.CursorInputMode TouchAimAndUse;

	// Token: 0x04000863 RID: 2147
	[global::Cpp2ILInjected.Token(Token = "0x4000B3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public VirtualControllerInputState.CursorInputMode ControllerSmartCursor;

	// Token: 0x04000864 RID: 2148
	[global::Cpp2ILInjected.Token(Token = "0x4000B3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public VirtualControllerInputState.CursorInputMode ControllerAimAndUse;

	// Token: 0x04000865 RID: 2149
	[global::Cpp2ILInjected.Token(Token = "0x4000B3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public VirtualControllerInputState.CursorInputMode MouseSmartCursor;

	// Token: 0x04000866 RID: 2150
	[global::Cpp2ILInjected.Token(Token = "0x4000B3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool AutoSelectSmartDigEnabled;

	// Token: 0x04000867 RID: 2151
	[global::Cpp2ILInjected.Token(Token = "0x4000B3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool GlobalSmartDigEnabled;

	// Token: 0x04000868 RID: 2152
	[global::Cpp2ILInjected.Token(Token = "0x4000B3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
	public bool GlobalAimAndUseEnabled;

	// Token: 0x04000869 RID: 2153
	[global::Cpp2ILInjected.Token(Token = "0x4000B40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
	private bool _currentSmartCursor;

	// Token: 0x0400086A RID: 2154
	[global::Cpp2ILInjected.Token(Token = "0x4000B41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private bool _currentAimAndUse;

	// Token: 0x0400086B RID: 2155
	[global::Cpp2ILInjected.Token(Token = "0x4000B42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float _noFireDeadZone;

	// Token: 0x0400086C RID: 2156
	[global::Cpp2ILInjected.Token(Token = "0x4000B43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private bool _currentAutoReuse;

	// Token: 0x0400086D RID: 2157
	[global::Cpp2ILInjected.Token(Token = "0x4000B44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Dictionary<VirtualControllerInputState.Category, bool> SmartCursorState;

	// Token: 0x0400086E RID: 2158
	[global::Cpp2ILInjected.Token(Token = "0x4000B45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Dictionary<VirtualControllerInputState.Category, bool> AimAndUseState;

	// Token: 0x0400086F RID: 2159
	[global::Cpp2ILInjected.Token(Token = "0x4000B46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private Dictionary<VirtualControllerInputState.Category, float> NoFireDeadZoneState;

	// Token: 0x04000870 RID: 2160
	[global::Cpp2ILInjected.Token(Token = "0x4000B47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public VirtualControllerInputState.Category CurrentlyBoundCategory;

	// Token: 0x020007D3 RID: 2003
	[global::Cpp2ILInjected.Token(Token = "0x2000180")]
	public enum Category
	{
		// Token: 0x04007AA2 RID: 31394
		[global::Cpp2ILInjected.Token(Token = "0x4000B49")]
		None,
		// Token: 0x04007AA3 RID: 31395
		[global::Cpp2ILInjected.Token(Token = "0x4000B4A")]
		Generic,
		// Token: 0x04007AA4 RID: 31396
		[global::Cpp2ILInjected.Token(Token = "0x4000B4B")]
		Axe,
		// Token: 0x04007AA5 RID: 31397
		[global::Cpp2ILInjected.Token(Token = "0x4000B4C")]
		PickAxe,
		// Token: 0x04007AA6 RID: 31398
		[global::Cpp2ILInjected.Token(Token = "0x4000B4D")]
		Drills,
		// Token: 0x04007AA7 RID: 31399
		[global::Cpp2ILInjected.Token(Token = "0x4000B4E")]
		Chainsaw,
		// Token: 0x04007AA8 RID: 31400
		[global::Cpp2ILInjected.Token(Token = "0x4000B4F")]
		Broadsword,
		// Token: 0x04007AA9 RID: 31401
		[global::Cpp2ILInjected.Token(Token = "0x4000B50")]
		NonAutoFireMeleeStab,
		// Token: 0x04007AAA RID: 31402
		[global::Cpp2ILInjected.Token(Token = "0x4000B51")]
		NonAutoFireMeleeSwing,
		// Token: 0x04007AAB RID: 31403
		[global::Cpp2ILInjected.Token(Token = "0x4000B52")]
		AutoFireMeleeSwing,
		// Token: 0x04007AAC RID: 31404
		[global::Cpp2ILInjected.Token(Token = "0x4000B53")]
		AutoFireMeleeProjectile,
		// Token: 0x04007AAD RID: 31405
		[global::Cpp2ILInjected.Token(Token = "0x4000B54")]
		AutoFireMeleeProjectileNoAim,
		// Token: 0x04007AAE RID: 31406
		[global::Cpp2ILInjected.Token(Token = "0x4000B55")]
		Spears,
		// Token: 0x04007AAF RID: 31407
		[global::Cpp2ILInjected.Token(Token = "0x4000B56")]
		Boomerangs,
		// Token: 0x04007AB0 RID: 31408
		[global::Cpp2ILInjected.Token(Token = "0x4000B57")]
		Flails,
		// Token: 0x04007AB1 RID: 31409
		[global::Cpp2ILInjected.Token(Token = "0x4000B58")]
		FlailsAutoSwing,
		// Token: 0x04007AB2 RID: 31410
		[global::Cpp2ILInjected.Token(Token = "0x4000B59")]
		Yoyo,
		// Token: 0x04007AB3 RID: 31411
		[global::Cpp2ILInjected.Token(Token = "0x4000B5A")]
		Bow,
		// Token: 0x04007AB4 RID: 31412
		[global::Cpp2ILInjected.Token(Token = "0x4000B5B")]
		AutoFireBow,
		// Token: 0x04007AB5 RID: 31413
		[global::Cpp2ILInjected.Token(Token = "0x4000B5C")]
		Repeaters,
		// Token: 0x04007AB6 RID: 31414
		[global::Cpp2ILInjected.Token(Token = "0x4000B5D")]
		ManualGuns,
		// Token: 0x04007AB7 RID: 31415
		[global::Cpp2ILInjected.Token(Token = "0x4000B5E")]
		AutomaticGuns,
		// Token: 0x04007AB8 RID: 31416
		[global::Cpp2ILInjected.Token(Token = "0x4000B5F")]
		GrapplingHooks,
		// Token: 0x04007AB9 RID: 31417
		[global::Cpp2ILInjected.Token(Token = "0x4000B60")]
		RocketConsuming,
		// Token: 0x04007ABA RID: 31418
		[global::Cpp2ILInjected.Token(Token = "0x4000B61")]
		AutoFireRocketConsuming,
		// Token: 0x04007ABB RID: 31419
		[global::Cpp2ILInjected.Token(Token = "0x4000B62")]
		SummoningMinion,
		// Token: 0x04007ABC RID: 31420
		[global::Cpp2ILInjected.Token(Token = "0x4000B63")]
		SummoningSentry,
		// Token: 0x04007ABD RID: 31421
		[global::Cpp2ILInjected.Token(Token = "0x4000B64")]
		ThrowingWeapons,
		// Token: 0x04007ABE RID: 31422
		[global::Cpp2ILInjected.Token(Token = "0x4000B65")]
		MagicWeapons,
		// Token: 0x04007ABF RID: 31423
		[global::Cpp2ILInjected.Token(Token = "0x4000B66")]
		AutoFireMagicWeapons,
		// Token: 0x04007AC0 RID: 31424
		[global::Cpp2ILInjected.Token(Token = "0x4000B67")]
		ControlledMagicWeapons,
		// Token: 0x04007AC1 RID: 31425
		[global::Cpp2ILInjected.Token(Token = "0x4000B68")]
		AutoFireControlledMagicWeapons,
		// Token: 0x04007AC2 RID: 31426
		[global::Cpp2ILInjected.Token(Token = "0x4000B69")]
		Torches,
		// Token: 0x04007AC3 RID: 31427
		[global::Cpp2ILInjected.Token(Token = "0x4000B6A")]
		Hammer,
		// Token: 0x04007AC4 RID: 31428
		[global::Cpp2ILInjected.Token(Token = "0x4000B6B")]
		PlacementSingle,
		// Token: 0x04007AC5 RID: 31429
		[global::Cpp2ILInjected.Token(Token = "0x4000B6C")]
		PlacementMulti,
		// Token: 0x04007AC6 RID: 31430
		[global::Cpp2ILInjected.Token(Token = "0x4000B6D")]
		PlacementMultiWalls,
		// Token: 0x04007AC7 RID: 31431
		[global::Cpp2ILInjected.Token(Token = "0x4000B6E")]
		HealingPotion,
		// Token: 0x04007AC8 RID: 31432
		[global::Cpp2ILInjected.Token(Token = "0x4000B6F")]
		ManaPotion,
		// Token: 0x04007AC9 RID: 31433
		[global::Cpp2ILInjected.Token(Token = "0x4000B70")]
		BuffPotion,
		// Token: 0x04007ACA RID: 31434
		[global::Cpp2ILInjected.Token(Token = "0x4000B71")]
		FoodAndDrink,
		// Token: 0x04007ACB RID: 31435
		[global::Cpp2ILInjected.Token(Token = "0x4000B72")]
		Flasks,
		// Token: 0x04007ACC RID: 31436
		[global::Cpp2ILInjected.Token(Token = "0x4000B73")]
		OtherPotions,
		// Token: 0x04007ACD RID: 31437
		[global::Cpp2ILInjected.Token(Token = "0x4000B74")]
		Seeds,
		// Token: 0x04007ACE RID: 31438
		[global::Cpp2ILInjected.Token(Token = "0x4000B75")]
		FishingPoles,
		// Token: 0x04007ACF RID: 31439
		[global::Cpp2ILInjected.Token(Token = "0x4000B76")]
		ExcludedAutoSwingAimUse,
		// Token: 0x04007AD0 RID: 31440
		[global::Cpp2ILInjected.Token(Token = "0x4000B77")]
		ExcludedAutoSwing,
		// Token: 0x04007AD1 RID: 31441
		[global::Cpp2ILInjected.Token(Token = "0x4000B78")]
		NonFireItems,
		// Token: 0x04007AD2 RID: 31442
		[global::Cpp2ILInjected.Token(Token = "0x4000B79")]
		HousingNPC,
		// Token: 0x04007AD3 RID: 31443
		[global::Cpp2ILInjected.Token(Token = "0x4000B7A")]
		AutoFireMeleeStab,
		// Token: 0x04007AD4 RID: 31444
		[global::Cpp2ILInjected.Token(Token = "0x4000B7B")]
		MiscPlace,
		// Token: 0x04007AD5 RID: 31445
		[global::Cpp2ILInjected.Token(Token = "0x4000B7C")]
		MiscPlaceWalls,
		// Token: 0x04007AD6 RID: 31446
		[global::Cpp2ILInjected.Token(Token = "0x4000B7D")]
		MiscBreak,
		// Token: 0x04007AD7 RID: 31447
		[global::Cpp2ILInjected.Token(Token = "0x4000B7E")]
		Instrument,
		// Token: 0x04007AD8 RID: 31448
		[global::Cpp2ILInjected.Token(Token = "0x4000B7F")]
		GolfClubs,
		// Token: 0x04007AD9 RID: 31449
		[global::Cpp2ILInjected.Token(Token = "0x4000B80")]
		SummoningWhip,
		// Token: 0x04007ADA RID: 31450
		[global::Cpp2ILInjected.Token(Token = "0x4000B81")]
		Glowsticks,
		// Token: 0x04007ADB RID: 31451
		[global::Cpp2ILInjected.Token(Token = "0x4000B82")]
		Count
	}

	// Token: 0x020007D4 RID: 2004
	[global::Cpp2ILInjected.Token(Token = "0x2000181")]
	public struct CaterogryEntry
	{
		// Token: 0x04007ADC RID: 31452
		[global::Cpp2ILInjected.Token(Token = "0x4000B83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ItemID item;

		// Token: 0x04007ADD RID: 31453
		[global::Cpp2ILInjected.Token(Token = "0x4000B84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private VirtualControllerInputState.Category category;
	}

	// Token: 0x020007D5 RID: 2005
	[global::Cpp2ILInjected.Token(Token = "0x2000182")]
	public enum CursorInputMode
	{
		// Token: 0x04007ADF RID: 31455
		[global::Cpp2ILInjected.Token(Token = "0x4000B86")]
		Item,
		// Token: 0x04007AE0 RID: 31456
		[global::Cpp2ILInjected.Token(Token = "0x4000B87")]
		Global,
		// Token: 0x04007AE1 RID: 31457
		[global::Cpp2ILInjected.Token(Token = "0x4000B88")]
		Disabled,
		// Token: 0x04007AE2 RID: 31458
		[global::Cpp2ILInjected.Token(Token = "0x4000B89")]
		AlwaysOn
	}

	// Token: 0x020007D6 RID: 2006
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000183")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060048D7 RID: 18647 RVA: 0x0002EEDA File Offset: 0x0002D0DA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A3724", Offset = "0x9A3724", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x0002EEDD File Offset: 0x0002D0DD
		[global::Cpp2ILInjected.Token(Token = "0x6000AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A3780", Offset = "0x9A3780", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		[global::Cpp2ILInjected.Token(Token = "0x6000AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A3788", Offset = "0x9A3788", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal bool <SetupLookups>b__3_0(FieldInfo f)
		{
			throw null;
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x0002EEE3 File Offset: 0x0002D0E3
		[global::Cpp2ILInjected.Token(Token = "0x6000AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A382C", Offset = "0x9A382C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void <SetupLookups>b__3_1(FieldInfo field)
		{
			throw null;
		}

		// Token: 0x04007AE3 RID: 31459
		[global::Cpp2ILInjected.Token(Token = "0x4000B8A")]
		public static readonly VirtualControllerInputState.<>c <>9;

		// Token: 0x04007AE4 RID: 31460
		[global::Cpp2ILInjected.Token(Token = "0x4000B8B")]
		public static Func<FieldInfo, bool> <>9__3_0;

		// Token: 0x04007AE5 RID: 31461
		[global::Cpp2ILInjected.Token(Token = "0x4000B8C")]
		public static Action<FieldInfo> <>9__3_1;
	}
}
