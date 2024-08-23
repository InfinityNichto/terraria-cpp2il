using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using InControl.UnityDeviceProfiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000079 RID: 121
[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
public class GUIControllerHardwareProfile
{
	// Token: 0x06000383 RID: 899 RVA: 0x000225CE File Offset: 0x000207CE
	[global::Cpp2ILInjected.Token(Token = "0x600041D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84AB4", Offset = "0xA84AB4", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwarePulldown), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUIPulldownSetting),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
		throw null;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000225D1 File Offset: 0x000207D1
	[global::Cpp2ILInjected.Token(Token = "0x600041E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84B90", Offset = "0xA84B90", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void SetControllerFace(ControllerDevice.ControlScheme scheme)
	{
		throw null;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x000225D4 File Offset: 0x000207D4
	[global::Cpp2ILInjected.Token(Token = "0x600041F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA84BEC", Offset = "0xA84BEC", Length = "0x644")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "CloseOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "CloseOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "Open", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "DrawBacking", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "DrawCategoryOptions", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "DrawTitle", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
	public static void Draw()
	{
		throw null;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x000225D7 File Offset: 0x000207D7
	[global::Cpp2ILInjected.Token(Token = "0x6000420")]
	[global::Cpp2ILInjected.Address(RVA = "0xA852A4", Offset = "0xA852A4", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static void Close()
	{
		throw null;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x000225DA File Offset: 0x000207DA
	[global::Cpp2ILInjected.Token(Token = "0x6000421")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85D54", Offset = "0xA85D54", Length = "0x5B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "DrawMainButtons", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomInputDeviceProfile), Member = "SaveToFile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityInputDevice), Member = "RefreshProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
	public static void UpdateAndSaveCurrentProfile()
	{
		throw null;
	}

	// Token: 0x06000388 RID: 904 RVA: 0x000225DD File Offset: 0x000207DD
	[global::Cpp2ILInjected.Token(Token = "0x6000422")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85A00", Offset = "0xA85A00", Length = "0x354")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "UpdateAndSaveCurrentProfile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	private static void DrawMainButtons()
	{
		throw null;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000225E0 File Offset: 0x000207E0
	[global::Cpp2ILInjected.Token(Token = "0x6000423")]
	[global::Cpp2ILInjected.Address(RVA = "0xA8580C", Offset = "0xA8580C", Length = "0x1F4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private static void DrawTitle()
	{
		throw null;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x000225E3 File Offset: 0x000207E3
	[global::Cpp2ILInjected.Token(Token = "0x6000424")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85580", Offset = "0xA85580", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private static void DrawBacking()
	{
		throw null;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x000225E6 File Offset: 0x000207E6
	[global::Cpp2ILInjected.Token(Token = "0x6000425")]
	[global::Cpp2ILInjected.Address(RVA = "0xA855E0", Offset = "0xA855E0", Length = "0x22C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemScaleHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.CursorOver), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.DrawItemHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIItemGrid.GetItemSizeHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private static void DrawCategoryOptions()
	{
		throw null;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x000225E9 File Offset: 0x000207E9
	[global::Cpp2ILInjected.Token(Token = "0x6000426")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86318", Offset = "0xA86318", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static float SettingScale(int index)
	{
		throw null;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x000225EC File Offset: 0x000207EC
	[global::Cpp2ILInjected.Token(Token = "0x6000427")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86320", Offset = "0xA86320", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static void SettingOver(int index)
	{
		throw null;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x000225EF File Offset: 0x000207EF
	[global::Cpp2ILInjected.Token(Token = "0x6000428")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86324", Offset = "0xA86324", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "SetGridItemRegion", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private static void SettingDraw(ItemGrid_Layout gridLayout, int index, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		throw null;
	}

	// Token: 0x0600038F RID: 911 RVA: 0x000225F2 File Offset: 0x000207F2
	[global::Cpp2ILInjected.Token(Token = "0x6000429")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86478", Offset = "0xA86478", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private static Microsoft.Xna.Framework.Vector2 SettingSize(int index)
	{
		throw null;
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000225F5 File Offset: 0x000207F5
	[global::Cpp2ILInjected.Token(Token = "0x600042A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85300", Offset = "0xA85300", Length = "0x280")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIOpenUIButtonSetting), Member = "OpenUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwarePulldown), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUIControllerHardwareProfileEntry.BindingId),
		typeof(ControllerDevice)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public static void Open(ControllerDevice device)
	{
		throw null;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x000225F8 File Offset: 0x000207F8
	[global::Cpp2ILInjected.Token(Token = "0x600042B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86870", Offset = "0xA86870", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIControllerHardwareProfile()
	{
		throw null;
	}

	// Token: 0x06000392 RID: 914 RVA: 0x000225FB File Offset: 0x000207FB
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600042C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86878", Offset = "0xA86878", Length = "0xB8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static GUIControllerHardwareProfile()
	{
		throw null;
	}

	// Token: 0x040002A2 RID: 674
	[global::Cpp2ILInjected.Token(Token = "0x40003FE")]
	private static GUIControllerMappingEntryBase overlayEntry;

	// Token: 0x040002A3 RID: 675
	[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
	private static Rectangle overlayRegion;

	// Token: 0x040002A4 RID: 676
	[global::Cpp2ILInjected.Token(Token = "0x4000400")]
	public static bool Enabled;

	// Token: 0x040002A5 RID: 677
	[global::Cpp2ILInjected.Token(Token = "0x4000401")]
	private static bool performingBinding;

	// Token: 0x040002A6 RID: 678
	[global::Cpp2ILInjected.Token(Token = "0x4000402")]
	private static float TimeSinceItemChange;

	// Token: 0x040002A7 RID: 679
	[global::Cpp2ILInjected.Token(Token = "0x4000403")]
	private static float GameplayButtonScale;

	// Token: 0x040002A8 RID: 680
	[global::Cpp2ILInjected.Token(Token = "0x4000404")]
	private static float UIButtonScale;

	// Token: 0x040002A9 RID: 681
	[global::Cpp2ILInjected.Token(Token = "0x4000405")]
	private static float SaveAndCloseButtonScale;

	// Token: 0x040002AA RID: 682
	[global::Cpp2ILInjected.Token(Token = "0x4000406")]
	private static float ResetSettingsButtonScale;

	// Token: 0x040002AB RID: 683
	[global::Cpp2ILInjected.Token(Token = "0x4000407")]
	private static float titleScale;

	// Token: 0x040002AC RID: 684
	[global::Cpp2ILInjected.Token(Token = "0x4000408")]
	public static float ScrollOffset;

	// Token: 0x040002AD RID: 685
	[global::Cpp2ILInjected.Token(Token = "0x4000409")]
	private static float ScrollMomentum;

	// Token: 0x040002AE RID: 686
	[global::Cpp2ILInjected.Token(Token = "0x400040A")]
	private static int ScrollDragging;

	// Token: 0x040002AF RID: 687
	[global::Cpp2ILInjected.Token(Token = "0x400040B")]
	private static Microsoft.Xna.Framework.Vector2 DragOffset;

	// Token: 0x040002B0 RID: 688
	[global::Cpp2ILInjected.Token(Token = "0x400040C")]
	public static List<GUIControllerMappingEntryBase> _categorySettings;

	// Token: 0x040002B1 RID: 689
	[global::Cpp2ILInjected.Token(Token = "0x400040D")]
	private static bool hasFocus;

	// Token: 0x040002B2 RID: 690
	[global::Cpp2ILInjected.Token(Token = "0x400040E")]
	private static GUIInputRegionExclusive _categoriesBlocker;

	// Token: 0x040002B3 RID: 691
	[global::Cpp2ILInjected.Token(Token = "0x400040F")]
	public static ControllerDevice.ControlScheme ActiveScheme;

	// Token: 0x040002B4 RID: 692
	[global::Cpp2ILInjected.Token(Token = "0x4000410")]
	public static ControllerDevice CurrentDevice;
}
