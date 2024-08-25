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

[global::Cpp2ILInjected.Token(Token = "0x200017F")]
public class VirtualControllerInputState
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000AE8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2508", Offset = "0x9A2508", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void LoadDefaultCategories()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6000AF3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A2A6C", Offset = "0x9A2A6C", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private bool GetCategoryAutoSwing(VirtualControllerInputState.Category category)
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x4000B34")]
	private static string[] IdLookup;

	[global::Cpp2ILInjected.Token(Token = "0x4000B35")]
	public static int[] ItemCategories;

	[global::Cpp2ILInjected.Token(Token = "0x4000B36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool printMessages;

	[global::Cpp2ILInjected.Token(Token = "0x4000B37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool ForceAutoSwingEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000B38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public VirtualControllerInputState.CursorInputMode TouchSmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4000B39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControllerInputState.CursorInputMode TouchAimAndUse;

	[global::Cpp2ILInjected.Token(Token = "0x4000B3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public VirtualControllerInputState.CursorInputMode ControllerSmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4000B3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public VirtualControllerInputState.CursorInputMode ControllerAimAndUse;

	[global::Cpp2ILInjected.Token(Token = "0x4000B3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public VirtualControllerInputState.CursorInputMode MouseSmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4000B3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool AutoSelectSmartDigEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000B3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool GlobalSmartDigEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000B3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
	public bool GlobalAimAndUseEnabled;

	[global::Cpp2ILInjected.Token(Token = "0x4000B40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
	private bool _currentSmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x4000B41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private bool _currentAimAndUse;

	[global::Cpp2ILInjected.Token(Token = "0x4000B42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float _noFireDeadZone;

	[global::Cpp2ILInjected.Token(Token = "0x4000B43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private bool _currentAutoReuse;

	[global::Cpp2ILInjected.Token(Token = "0x4000B44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Dictionary<VirtualControllerInputState.Category, bool> SmartCursorState;

	[global::Cpp2ILInjected.Token(Token = "0x4000B45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Dictionary<VirtualControllerInputState.Category, bool> AimAndUseState;

	[global::Cpp2ILInjected.Token(Token = "0x4000B46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private Dictionary<VirtualControllerInputState.Category, float> NoFireDeadZoneState;

	[global::Cpp2ILInjected.Token(Token = "0x4000B47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public VirtualControllerInputState.Category CurrentlyBoundCategory;

	[global::Cpp2ILInjected.Token(Token = "0x2000180")]
	public enum Category
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000B49")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000B4A")]
		Generic,
		[global::Cpp2ILInjected.Token(Token = "0x4000B4B")]
		Axe,
		[global::Cpp2ILInjected.Token(Token = "0x4000B4C")]
		PickAxe,
		[global::Cpp2ILInjected.Token(Token = "0x4000B4D")]
		Drills,
		[global::Cpp2ILInjected.Token(Token = "0x4000B4E")]
		Chainsaw,
		[global::Cpp2ILInjected.Token(Token = "0x4000B4F")]
		Broadsword,
		[global::Cpp2ILInjected.Token(Token = "0x4000B50")]
		NonAutoFireMeleeStab,
		[global::Cpp2ILInjected.Token(Token = "0x4000B51")]
		NonAutoFireMeleeSwing,
		[global::Cpp2ILInjected.Token(Token = "0x4000B52")]
		AutoFireMeleeSwing,
		[global::Cpp2ILInjected.Token(Token = "0x4000B53")]
		AutoFireMeleeProjectile,
		[global::Cpp2ILInjected.Token(Token = "0x4000B54")]
		AutoFireMeleeProjectileNoAim,
		[global::Cpp2ILInjected.Token(Token = "0x4000B55")]
		Spears,
		[global::Cpp2ILInjected.Token(Token = "0x4000B56")]
		Boomerangs,
		[global::Cpp2ILInjected.Token(Token = "0x4000B57")]
		Flails,
		[global::Cpp2ILInjected.Token(Token = "0x4000B58")]
		FlailsAutoSwing,
		[global::Cpp2ILInjected.Token(Token = "0x4000B59")]
		Yoyo,
		[global::Cpp2ILInjected.Token(Token = "0x4000B5A")]
		Bow,
		[global::Cpp2ILInjected.Token(Token = "0x4000B5B")]
		AutoFireBow,
		[global::Cpp2ILInjected.Token(Token = "0x4000B5C")]
		Repeaters,
		[global::Cpp2ILInjected.Token(Token = "0x4000B5D")]
		ManualGuns,
		[global::Cpp2ILInjected.Token(Token = "0x4000B5E")]
		AutomaticGuns,
		[global::Cpp2ILInjected.Token(Token = "0x4000B5F")]
		GrapplingHooks,
		[global::Cpp2ILInjected.Token(Token = "0x4000B60")]
		RocketConsuming,
		[global::Cpp2ILInjected.Token(Token = "0x4000B61")]
		AutoFireRocketConsuming,
		[global::Cpp2ILInjected.Token(Token = "0x4000B62")]
		SummoningMinion,
		[global::Cpp2ILInjected.Token(Token = "0x4000B63")]
		SummoningSentry,
		[global::Cpp2ILInjected.Token(Token = "0x4000B64")]
		ThrowingWeapons,
		[global::Cpp2ILInjected.Token(Token = "0x4000B65")]
		MagicWeapons,
		[global::Cpp2ILInjected.Token(Token = "0x4000B66")]
		AutoFireMagicWeapons,
		[global::Cpp2ILInjected.Token(Token = "0x4000B67")]
		ControlledMagicWeapons,
		[global::Cpp2ILInjected.Token(Token = "0x4000B68")]
		AutoFireControlledMagicWeapons,
		[global::Cpp2ILInjected.Token(Token = "0x4000B69")]
		Torches,
		[global::Cpp2ILInjected.Token(Token = "0x4000B6A")]
		Hammer,
		[global::Cpp2ILInjected.Token(Token = "0x4000B6B")]
		PlacementSingle,
		[global::Cpp2ILInjected.Token(Token = "0x4000B6C")]
		PlacementMulti,
		[global::Cpp2ILInjected.Token(Token = "0x4000B6D")]
		PlacementMultiWalls,
		[global::Cpp2ILInjected.Token(Token = "0x4000B6E")]
		HealingPotion,
		[global::Cpp2ILInjected.Token(Token = "0x4000B6F")]
		ManaPotion,
		[global::Cpp2ILInjected.Token(Token = "0x4000B70")]
		BuffPotion,
		[global::Cpp2ILInjected.Token(Token = "0x4000B71")]
		FoodAndDrink,
		[global::Cpp2ILInjected.Token(Token = "0x4000B72")]
		Flasks,
		[global::Cpp2ILInjected.Token(Token = "0x4000B73")]
		OtherPotions,
		[global::Cpp2ILInjected.Token(Token = "0x4000B74")]
		Seeds,
		[global::Cpp2ILInjected.Token(Token = "0x4000B75")]
		FishingPoles,
		[global::Cpp2ILInjected.Token(Token = "0x4000B76")]
		ExcludedAutoSwingAimUse,
		[global::Cpp2ILInjected.Token(Token = "0x4000B77")]
		ExcludedAutoSwing,
		[global::Cpp2ILInjected.Token(Token = "0x4000B78")]
		NonFireItems,
		[global::Cpp2ILInjected.Token(Token = "0x4000B79")]
		HousingNPC,
		[global::Cpp2ILInjected.Token(Token = "0x4000B7A")]
		AutoFireMeleeStab,
		[global::Cpp2ILInjected.Token(Token = "0x4000B7B")]
		MiscPlace,
		[global::Cpp2ILInjected.Token(Token = "0x4000B7C")]
		MiscPlaceWalls,
		[global::Cpp2ILInjected.Token(Token = "0x4000B7D")]
		MiscBreak,
		[global::Cpp2ILInjected.Token(Token = "0x4000B7E")]
		Instrument,
		[global::Cpp2ILInjected.Token(Token = "0x4000B7F")]
		GolfClubs,
		[global::Cpp2ILInjected.Token(Token = "0x4000B80")]
		SummoningWhip,
		[global::Cpp2ILInjected.Token(Token = "0x4000B81")]
		Glowsticks,
		[global::Cpp2ILInjected.Token(Token = "0x4000B82")]
		Count
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000181")]
	public struct CaterogryEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000B83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ItemID item;

		[global::Cpp2ILInjected.Token(Token = "0x4000B84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private VirtualControllerInputState.Category category;
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000182")]
	public enum CursorInputMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000B86")]
		Item,
		[global::Cpp2ILInjected.Token(Token = "0x4000B87")]
		Global,
		[global::Cpp2ILInjected.Token(Token = "0x4000B88")]
		Disabled,
		[global::Cpp2ILInjected.Token(Token = "0x4000B89")]
		AlwaysOn
	}

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000183")]
	[Serializable]
	private sealed class <>c
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A3780", Offset = "0x9A3780", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000B8A")]
		public static readonly VirtualControllerInputState.<>c <>9;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8B")]
		public static Func<FieldInfo, bool> <>9__3_0;

		[global::Cpp2ILInjected.Token(Token = "0x4000B8C")]
		public static Action<FieldInfo> <>9__3_1;
	}
}
