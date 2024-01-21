using System.Collections.Generic;
using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001EF")]
public class GUIPulldownSetting : GUISettingEntry
{
	[Cpp2IlInjected.Token(Token = "0x20007F9")]
	public delegate void ActivateOverlayCallback(GUIPulldownSetting overlayEntry, Rectangle overlayRegion, int selectedOption, float offset);

	[Cpp2IlInjected.Token(Token = "0x20007FA")]
	public delegate void RegisterOverlay(GUIPulldownSetting overlayEntry, Rectangle overlayRegion);

	[Cpp2IlInjected.Token(Token = "0x20007FB")]
	public delegate void DeactivateOverlayCallback();

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001659")]
	private ActivateOverlayCallback activateOverlayCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400165A")]
	private DeactivateOverlayCallback deactivateOverlayCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400165B")]
	private RegisterOverlay registerOverlayCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400165C")]
	private float scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400165D")]
	private bool drawingOverlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400165E")]
	public int selectedPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400165F")]
	private float _offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001660")]
	public bool displayOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001661")]
	private GUIInputRegionExclusive _optionsBlocker;

	[Cpp2IlInjected.Token(Token = "0x4001662")]
	private static int[] LanguageMappingIndices;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	private static List<int> optionRedirection
	{
		[Cpp2IlInjected.Token(Token = "0x6000E42")]
		[Cpp2IlInjected.Address(RVA = "0xE30AB0", Offset = "0xE30AB0", VA = "0xE30AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000E37")]
	[Cpp2IlInjected.Address(RVA = "0xE2E3A0", Offset = "0xE2E3A0", VA = "0xE2E3A0")]
	public GUIPulldownSetting(GUISettingID id, [Optional] ActivateOverlayCallback activateOverlayCallbackOverload, [Optional] DeactivateOverlayCallback deactivateOverlayCallbackOverload, [Optional] RegisterOverlay registerOverlayOverload)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E38")]
	[Cpp2IlInjected.Address(RVA = "0xE2E3D0", Offset = "0xE2E3D0", VA = "0xE2E3D0")]
	public void CloseOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E39")]
	[Cpp2IlInjected.Address(RVA = "0xE2E6C8", Offset = "0xE2E6C8", VA = "0xE2E6C8", Slot = "6")]
	public override void DrawOverlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E3A")]
	[Cpp2IlInjected.Address(RVA = "0xE2E6FC", Offset = "0xE2E6FC", VA = "0xE2E6FC")]
	private void DrawFaceButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E3B")]
	[Cpp2IlInjected.Address(RVA = "0xE2EAE0", Offset = "0xE2EAE0", VA = "0xE2EAE0")]
	private void DrawOptionFaceButtons(ControllerDevice.ControlScheme scheme)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E3C")]
	[Cpp2IlInjected.Address(RVA = "0xE2EF94", Offset = "0xE2EF94", VA = "0xE2EF94")]
	public void RefreshInputRegion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E3D")]
	[Cpp2IlInjected.Address(RVA = "0xE31168", Offset = "0xE31168", VA = "0xE31168", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E3E")]
	[Cpp2IlInjected.Address(RVA = "0xE35894", Offset = "0xE35894", VA = "0xE35894")]
	public void DisablePulldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E3F")]
	[Cpp2IlInjected.Address(RVA = "0xE3595C", Offset = "0xE3595C", VA = "0xE3595C", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E40")]
	[Cpp2IlInjected.Address(RVA = "0xE359BC", Offset = "0xE359BC", VA = "0xE359BC")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E41")]
	[Cpp2IlInjected.Address(RVA = "0xE2FA58", Offset = "0xE2FA58", VA = "0xE2FA58")]
	public int GetNumberOfOptions()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000E43")]
	[Cpp2IlInjected.Address(RVA = "0xE2FDE0", Offset = "0xE2FDE0", VA = "0xE2FDE0")]
	private string GetOption(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E44")]
	[Cpp2IlInjected.Address(RVA = "0xE346C8", Offset = "0xE346C8", VA = "0xE346C8")]
	private void SetOption(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000E45")]
	[Cpp2IlInjected.Address(RVA = "0xE341F0", Offset = "0xE341F0", VA = "0xE341F0")]
	private string GetTitle()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E46")]
	[Cpp2IlInjected.Address(RVA = "0xE35ABC", Offset = "0xE35ABC", VA = "0xE35ABC")]
	private string GetLanguageFromLegacyId(int legacyId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000E47")]
	[Cpp2IlInjected.Address(RVA = "0xE330B0", Offset = "0xE330B0", VA = "0xE330B0")]
	private string GetValue()
	{
		return null;
	}
}
