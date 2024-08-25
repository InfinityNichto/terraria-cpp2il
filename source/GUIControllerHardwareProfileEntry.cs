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

[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
public class GUIControllerHardwareProfileEntry : GUIControllerMappingEntryBase
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000435")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86BFC", Offset = "0xA86BFC", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void DrawOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000436")]
	[global::Cpp2ILInjected.Address(RVA = "0xA86C24", Offset = "0xA86C24", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public void RemoveBinding()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x600043B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87990", Offset = "0xA87990", Length = "0x50")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public override float GetElementHeight()
	{
		throw null;
	}

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

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600043D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA87AE8", Offset = "0xA87AE8", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static GUIControllerHardwareProfileEntry()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000411")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private readonly ControllerDevice _device;

	[global::Cpp2ILInjected.Token(Token = "0x4000412")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public new readonly GUIControllerHardwareProfileEntry.BindingId _id;

	[global::Cpp2ILInjected.Token(Token = "0x4000413")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public InputControlMapping Binding;

	[global::Cpp2ILInjected.Token(Token = "0x4000414")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float buttonScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000415")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float scale;

	[global::Cpp2ILInjected.Token(Token = "0x4000416")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private bool drawingOverlay;

	[global::Cpp2ILInjected.Token(Token = "0x4000417")]
	private static int LastButtonMapped;

	[global::Cpp2ILInjected.Token(Token = "0x4000418")]
	private const float inputTollerance = 0.1f;

	[global::Cpp2ILInjected.Token(Token = "0x4000419")]
	private static float[] InitialInputRange;

	[global::Cpp2ILInjected.Token(Token = "0x400041A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
	public bool displayOptions;

	[global::Cpp2ILInjected.Token(Token = "0x400041B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private GUIInputRegionExclusive _optionsBlocker;

	[global::Cpp2ILInjected.Token(Token = "0x400041C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public new KeyboardMappingsCategories_Layout.Category Category;

	[global::Cpp2ILInjected.Token(Token = "0x400041D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public new int SortOrder;

	[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
	public enum BindingId
	{
		[global::Cpp2ILInjected.Token(Token = "0x400041F")]
		LeftStickUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000420")]
		LeftStickDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000421")]
		LeftStickLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000422")]
		LeftStickRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000423")]
		RightStickUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000424")]
		RightStickDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		RightStickLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		RightStickRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		DPadUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		DPadDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		DPadLeft,
		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		DPadRight,
		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		Action1,
		[global::Cpp2ILInjected.Token(Token = "0x400042C")]
		Action2,
		[global::Cpp2ILInjected.Token(Token = "0x400042D")]
		Action3,
		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		Action4,
		[global::Cpp2ILInjected.Token(Token = "0x400042F")]
		Options,
		[global::Cpp2ILInjected.Token(Token = "0x4000430")]
		Switch,
		[global::Cpp2ILInjected.Token(Token = "0x4000431")]
		LeftShoulder,
		[global::Cpp2ILInjected.Token(Token = "0x4000432")]
		LeftTrigger,
		[global::Cpp2ILInjected.Token(Token = "0x4000433")]
		LeftStickClick,
		[global::Cpp2ILInjected.Token(Token = "0x4000434")]
		RightShoulder,
		[global::Cpp2ILInjected.Token(Token = "0x4000435")]
		RightTrigger,
		[global::Cpp2ILInjected.Token(Token = "0x4000436")]
		RightStickClick,
		[global::Cpp2ILInjected.Token(Token = "0x4000437")]
		Count
	}
}
