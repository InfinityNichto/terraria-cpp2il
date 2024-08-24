using System;
using System.Collections.Generic;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using UnityEngine;

// Token: 0x02000112 RID: 274
[global::Cpp2ILInjected.Token(Token = "0x2000189")]
public class GUIKeyboardMappingEntry
{
	// Token: 0x06000A08 RID: 2568 RVA: 0x0002395D File Offset: 0x00021B5D
	[global::Cpp2ILInjected.Token(Token = "0x6000B12")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A5F84", Offset = "0x9A5F84", Length = "0x15C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetCategory", MemberParameters = new object[] { typeof(KeyboardMappingsCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref KeyboardMappingsCategories_Layout.Category),
		typeof(ref int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public GUIKeyboardMappingEntry(ControllerActionVector action, int index)
	{
		throw null;
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00023960 File Offset: 0x00021B60
	[global::Cpp2ILInjected.Token(Token = "0x6000B13")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A60E0", Offset = "0x9A60E0", Length = "0x18")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "get_Binding", ReturnType = typeof(KeyCode))]
	public void Backup()
	{
		throw null;
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00023963 File Offset: 0x00021B63
	[global::Cpp2ILInjected.Token(Token = "0x6000B14")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6174", Offset = "0x9A6174", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void Restore()
	{
		throw null;
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00023966 File Offset: 0x00021B66
	[global::Cpp2ILInjected.Token(Token = "0x6000B15")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A61F8", Offset = "0x9A61F8", Length = "0xF8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetCategory", MemberParameters = new object[] { typeof(KeyboardMappingsCategories_Layout.Category) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardMappingsCategories_Layout), Member = "GetCategorySetup", MemberParameters = new object[]
	{
		typeof(string),
		typeof(ref KeyboardMappingsCategories_Layout.Category),
		typeof(ref int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public GUIKeyboardMappingEntry(ControllerActionButton action)
	{
		throw null;
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00023969 File Offset: 0x00021B69
	// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0002396C File Offset: 0x00021B6C
	[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
	public KeyCode Binding
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A60F8", Offset = "0x9A60F8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Backup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "get_HasMapping", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Backup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A617C", Offset = "0x9A617C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "RestoreBackup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionButton.Entry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = "get_FirstEntry", ReturnType = typeof(ControllerActionAxis.Entry))]
		set
		{
			throw null;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002396F File Offset: 0x00021B6F
	[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
	public bool HasMapping
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x9A62F0", Offset = "0x9A62F0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "get_Binding", ReturnType = typeof(KeyCode))]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00023972 File Offset: 0x00021B72
	[global::Cpp2ILInjected.Token(Token = "0x6000B19")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6308", Offset = "0x9A6308", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	public void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00023975 File Offset: 0x00021B75
	[global::Cpp2ILInjected.Token(Token = "0x6000B1A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6CA8", Offset = "0x9A6CA8", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "ClearMapping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "set_Binding", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void RemoveBinding()
	{
		throw null;
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00023978 File Offset: 0x00021B78
	[global::Cpp2ILInjected.Token(Token = "0x6000B1B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6328", Offset = "0x9A6328", Length = "0x980")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = "DrawOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SettingDraw", MemberParameters = new object[]
	{
		typeof(ItemGrid_Layout),
		typeof(int),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "RemoveBinding", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Int32Enum>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "ClearBinding", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "set_Binding", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingEntry), Member = "get_Binding", ReturnType = typeof(KeyCode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get__gridItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "ActivateOverlay", MemberParameters = new object[]
	{
		typeof(GUIKeyboardMappingEntry),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0002397B File Offset: 0x00021B7B
	[global::Cpp2ILInjected.Token(Token = "0x6000B1C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6F80", Offset = "0x9A6F80", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingOverlay), Member = "UpdateScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingOverlay), Member = "GetSelectedItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x0002397E File Offset: 0x00021B7E
	[global::Cpp2ILInjected.Token(Token = "0x6000B1D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6FD0", Offset = "0x9A6FD0", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappingOverlay), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00023981 File Offset: 0x00021B81
	[global::Cpp2ILInjected.Token(Token = "0x6000B1E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A6D64", Offset = "0x9A6D64", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	private string GetTitle()
	{
		throw null;
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00023984 File Offset: 0x00021B84
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000B1F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A70A0", Offset = "0x9A70A0", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static GUIKeyboardMappingEntry()
	{
		throw null;
	}

	// Token: 0x04000877 RID: 2167
	[global::Cpp2ILInjected.Token(Token = "0x4000B97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private ControllerActionButton buttonAction;

	// Token: 0x04000878 RID: 2168
	[global::Cpp2ILInjected.Token(Token = "0x4000B98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private ControllerActionVector axisAction;

	// Token: 0x04000879 RID: 2169
	[global::Cpp2ILInjected.Token(Token = "0x4000B99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int actionIndex;

	// Token: 0x0400087A RID: 2170
	[global::Cpp2ILInjected.Token(Token = "0x4000B9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private KeyCode backupBinding;

	// Token: 0x0400087B RID: 2171
	[global::Cpp2ILInjected.Token(Token = "0x4000B9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly string localisationId;

	// Token: 0x0400087C RID: 2172
	[global::Cpp2ILInjected.Token(Token = "0x4000B9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float buttonScale;

	// Token: 0x0400087D RID: 2173
	[global::Cpp2ILInjected.Token(Token = "0x4000B9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float scale;

	// Token: 0x0400087E RID: 2174
	[global::Cpp2ILInjected.Token(Token = "0x4000B9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private bool drawingOverlay;

	// Token: 0x0400087F RID: 2175
	[global::Cpp2ILInjected.Token(Token = "0x4000B9F")]
	private static int LastButtonMapped;

	// Token: 0x04000880 RID: 2176
	[global::Cpp2ILInjected.Token(Token = "0x4000BA0")]
	private static bool ignoreClick;

	// Token: 0x04000881 RID: 2177
	[global::Cpp2ILInjected.Token(Token = "0x4000BA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
	public bool displayOptions;

	// Token: 0x04000882 RID: 2178
	[global::Cpp2ILInjected.Token(Token = "0x4000BA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04000883 RID: 2179
	[global::Cpp2ILInjected.Token(Token = "0x4000BA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public KeyboardMappingsCategories_Layout.Category Category;

	// Token: 0x04000884 RID: 2180
	[global::Cpp2ILInjected.Token(Token = "0x4000BA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public int SortOrder;
}
