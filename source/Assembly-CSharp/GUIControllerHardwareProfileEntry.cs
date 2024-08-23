using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using UnityEngine;

// Token: 0x0200007B RID: 123
[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
public class GUIControllerHardwareProfileEntry : GUIControllerMappingEntryBase
{
	// Token: 0x06000396 RID: 918 RVA: 0x00022607 File Offset: 0x00020807
	[global::Cpp2ILInjected.Token(Token = "0x6000430")]
	[global::Cpp2ILInjected.Address(RVA = "0xA866C4", Offset = "0xA866C4", Length = "0x1AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Open", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingEntryBase), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetMappingType", ReturnType = typeof(InputControlType))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public GUIControllerHardwareProfileEntry(GUIControllerHardwareProfileEntry.BindingId id, ControllerDevice device)
	{
		throw null;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0002260A File Offset: 0x0002080A
	[global::Cpp2ILInjected.Token(Token = "0x6000431")]
	[global::Cpp2ILInjected.Address(RVA = "0xA85230", Offset = "0xA85230", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfile), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void CloseOptions()
	{
		throw null;
	}

	// Token: 0x06000398 RID: 920 RVA: 0x0002260D File Offset: 0x0002080D
	[global::Cpp2ILInjected.Token(Token = "0x6000432")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86964", Offset = "0xA86964", Length = "0x298")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "RemapToAnalogue", MemberParameters = new object[]
	{
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "RemapToButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
	private string GetMappingName()
	{
		throw null;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00022610 File Offset: 0x00020810
	[global::Cpp2ILInjected.Token(Token = "0x6000433")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86940", Offset = "0xA86940", Length = "0x24")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GUIControllerHardwareProfileEntry.BindingId),
		typeof(ControllerDevice)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "RemapToAnalogue", MemberParameters = new object[]
	{
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "RemapToButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	private InputControlType GetMappingType()
	{
		throw null;
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600039A RID: 922 RVA: 0x00022613 File Offset: 0x00020813
	[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
	public bool HasMapping
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		[global::Cpp2ILInjected.Address(RVA = "0xA86308", Offset = "0xA86308", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00022616 File Offset: 0x00020816
	[global::Cpp2ILInjected.Token(Token = "0x6000435")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86BFC", Offset = "0xA86BFC", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void DrawOverlay()
	{
		throw null;
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00022619 File Offset: 0x00020819
	[global::Cpp2ILInjected.Token(Token = "0x6000436")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86C24", Offset = "0xA86C24", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void RemoveBinding()
	{
		throw null;
	}

	// Token: 0x0600039D RID: 925 RVA: 0x0002261C File Offset: 0x0002081C
	[global::Cpp2ILInjected.Token(Token = "0x6000437")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86C2C", Offset = "0xA86C2C", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetMappingName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetMappingType", ReturnType = typeof(InputControlType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(InputControlSourceType),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void RemapToAnalogue(int index, float restingValue, float usedValue)
	{
		throw null;
	}

	// Token: 0x0600039E RID: 926 RVA: 0x0002261F File Offset: 0x0002081F
	[global::Cpp2ILInjected.Token(Token = "0x6000438")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86D54", Offset = "0xA86D54", Length = "0xAC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetMappingName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetMappingType", ReturnType = typeof(InputControlType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(InputControlSourceType),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void RemapToButton(int index)
	{
		throw null;
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00022622 File Offset: 0x00020822
	[global::Cpp2ILInjected.Token(Token = "0x6000439")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86E00", Offset = "0xA86E00", Length = "0x398")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerHardwareProfileEntry), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetButtonTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.LinkedControlType),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "GetAxisTexureInformation", MemberParameters = new object[]
	{
		typeof(GUIControllerInputButton.AxisControl),
		typeof(ref Rectangle),
		typeof(int)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
	private Microsoft.Xna.Framework.Graphics.Texture2D GetTexure(out Rectangle buttonRegion)
	{
		throw null;
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00022625 File Offset: 0x00020825
	[global::Cpp2ILInjected.Token(Token = "0x600043A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87198", Offset = "0xA87198", Length = "0x7F8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "GetTexure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlAnchor), Member = "get__gridItemRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfile), Member = "RegisterOverlay", MemberParameters = new object[]
	{
		typeof(GUIControllerMappingEntryBase),
		typeof(Rectangle)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
	{
		typeof(String_Layout),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "RemapToButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerHardwareProfileEntry), Member = "RemapToAnalogue", MemberParameters = new object[]
	{
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionExclusive.IsOverHandler), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive.IsOverHandler) }, ReturnType = typeof(GUIInputRegionExclusive))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
	public override void Draw()
	{
		throw null;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00022628 File Offset: 0x00020828
	[global::Cpp2ILInjected.Token(Token = "0x600043B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87990", Offset = "0xA87990", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0002262B File Offset: 0x0002082B
	[global::Cpp2ILInjected.Token(Token = "0x600043C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA879E0", Offset = "0xA879E0", Length = "0x108")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappingOverlay), Member = "DeactivateOverlay", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "UnregisterPickingInterceptor", MemberParameters = new object[] { typeof(GUIInputRegionExclusive) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		throw null;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0002262E File Offset: 0x0002082E
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600043D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87AE8", Offset = "0xA87AE8", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static GUIControllerHardwareProfileEntry()
	{
		throw null;
	}

	// Token: 0x040002B5 RID: 693
	[global::Cpp2ILInjected.Token(Token = "0x4000411")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly ControllerDevice _device;

	// Token: 0x040002B6 RID: 694
	[global::Cpp2ILInjected.Token(Token = "0x4000412")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public new readonly GUIControllerHardwareProfileEntry.BindingId _id;

	// Token: 0x040002B7 RID: 695
	[global::Cpp2ILInjected.Token(Token = "0x4000413")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public InputControlMapping Binding;

	// Token: 0x040002B8 RID: 696
	[global::Cpp2ILInjected.Token(Token = "0x4000414")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float buttonScale;

	// Token: 0x040002B9 RID: 697
	[global::Cpp2ILInjected.Token(Token = "0x4000415")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float scale;

	// Token: 0x040002BA RID: 698
	[global::Cpp2ILInjected.Token(Token = "0x4000416")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private bool drawingOverlay;

	// Token: 0x040002BB RID: 699
	[global::Cpp2ILInjected.Token(Token = "0x4000417")]
	private static int LastButtonMapped;

	// Token: 0x040002BC RID: 700
	[global::Cpp2ILInjected.Token(Token = "0x4000418")]
	private const float inputTollerance = 0.1f;

	// Token: 0x040002BD RID: 701
	[global::Cpp2ILInjected.Token(Token = "0x4000419")]
	private static float[] InitialInputRange;

	// Token: 0x040002BE RID: 702
	[global::Cpp2ILInjected.Token(Token = "0x400041A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
	public bool displayOptions;

	// Token: 0x040002BF RID: 703
	[global::Cpp2ILInjected.Token(Token = "0x400041B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x040002C0 RID: 704
	[global::Cpp2ILInjected.Token(Token = "0x400041C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public new KeyboardMappingsCategories_Layout.Category Category;

	// Token: 0x040002C1 RID: 705
	[global::Cpp2ILInjected.Token(Token = "0x400041D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public new int SortOrder;

	// Token: 0x02000798 RID: 1944
	[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
	public enum BindingId
	{
		// Token: 0x04007942 RID: 31042
		[global::Cpp2ILInjected.Token(Token = "0x400041F")]
		LeftStickUp,
		// Token: 0x04007943 RID: 31043
		[global::Cpp2ILInjected.Token(Token = "0x4000420")]
		LeftStickDown,
		// Token: 0x04007944 RID: 31044
		[global::Cpp2ILInjected.Token(Token = "0x4000421")]
		LeftStickLeft,
		// Token: 0x04007945 RID: 31045
		[global::Cpp2ILInjected.Token(Token = "0x4000422")]
		LeftStickRight,
		// Token: 0x04007946 RID: 31046
		[global::Cpp2ILInjected.Token(Token = "0x4000423")]
		RightStickUp,
		// Token: 0x04007947 RID: 31047
		[global::Cpp2ILInjected.Token(Token = "0x4000424")]
		RightStickDown,
		// Token: 0x04007948 RID: 31048
		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		RightStickLeft,
		// Token: 0x04007949 RID: 31049
		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		RightStickRight,
		// Token: 0x0400794A RID: 31050
		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		DPadUp,
		// Token: 0x0400794B RID: 31051
		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		DPadDown,
		// Token: 0x0400794C RID: 31052
		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		DPadLeft,
		// Token: 0x0400794D RID: 31053
		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		DPadRight,
		// Token: 0x0400794E RID: 31054
		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		Action1,
		// Token: 0x0400794F RID: 31055
		[global::Cpp2ILInjected.Token(Token = "0x400042C")]
		Action2,
		// Token: 0x04007950 RID: 31056
		[global::Cpp2ILInjected.Token(Token = "0x400042D")]
		Action3,
		// Token: 0x04007951 RID: 31057
		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		Action4,
		// Token: 0x04007952 RID: 31058
		[global::Cpp2ILInjected.Token(Token = "0x400042F")]
		Options,
		// Token: 0x04007953 RID: 31059
		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		Switch,
		// Token: 0x04007954 RID: 31060
		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		LeftShoulder,
		// Token: 0x04007955 RID: 31061
		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		LeftTrigger,
		// Token: 0x04007956 RID: 31062
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		LeftStickClick,
		// Token: 0x04007957 RID: 31063
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		RightShoulder,
		// Token: 0x04007958 RID: 31064
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		RightTrigger,
		// Token: 0x04007959 RID: 31065
		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		RightStickClick,
		// Token: 0x0400795A RID: 31066
		[global::Cpp2ILInjected.Token(Token = "0x4000437")]
		Count
	}
}
