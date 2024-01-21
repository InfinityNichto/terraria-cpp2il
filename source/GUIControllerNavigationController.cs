using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x200006E")]
public class GUIControllerNavigationController
{
	[Cpp2IlInjected.Token(Token = "0x2000789")]
	public enum InteractionMode
	{

	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private Cursor EmulatedCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public float NavigationRepeatDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public float NavigationDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public float NavigationDelayToUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public bool InitialNavigationMovement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public bool previousInteractionDownState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private Point lastPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public bool DisableNavigation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public int DisableNavigationAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public DateTime NavigationTick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public ControllerActionVector UINavigationAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public ControllerActionVector UIScrollAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public ControllerActionButton[] UIAction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public ControllerActionButton NextPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public ControllerActionButton PreviousPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public ControllerActionButton PlayFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public ControllerActionButton DeleteFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public ControllerActionButton CloudFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public ControllerActionButton FavouriteFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public ControllerActionButton NewFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public ControllerActionButton CloseFileMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public ControllerActionButton Settings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public ControllerActionButton Share;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public ControllerActionButton CycleLeftPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public ControllerActionButton CycleRightPage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public ControllerActionButton Debug;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public bool[] UIActionWasPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public bool[] UIActionPressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private GUIControllerItem _currentNavigationItem;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Cursor UICursor
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1211878", Offset = "0x1211878", VA = "0x1211878")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ControllerActionVector NavigationAxis
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1212530", Offset = "0x1212530", VA = "0x1212530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GUIControllerItem CurrentNavigationItem
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x1213984", Offset = "0x1213984", VA = "0x1213984")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1213740", Offset = "0x1213740", VA = "0x1213740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x121188C", Offset = "0x121188C", VA = "0x121188C")]
	public void SetupMappings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1212420", Offset = "0x1212420", VA = "0x1212420")]
	public void Activate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x12127FC", Offset = "0x12127FC", VA = "0x12127FC")]
	public void UpdateUINavigation(float elapsedTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x1213750", Offset = "0x1213750", VA = "0x1213750")]
	public void UpdateCursorPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x121398C", Offset = "0x121398C", VA = "0x121398C")]
	public void DisableNavigationFromAxis(int fromAxis = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x121399C", Offset = "0x121399C", VA = "0x121399C")]
	public bool Pressed(GUIControllerInputButton.LinkedControlType action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x12139AC", Offset = "0x12139AC", VA = "0x12139AC")]
	public bool Pressed(int action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x12139BC", Offset = "0x12139BC", VA = "0x12139BC")]
	public bool PressedTriggered(GUIControllerInputButton.LinkedControlType action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x1213A24", Offset = "0x1213A24", VA = "0x1213A24")]
	public void ClearUIPressed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x12139F0", Offset = "0x12139F0", VA = "0x12139F0")]
	public bool PressedTriggered(int action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x1213B94", Offset = "0x1213B94", VA = "0x1213B94")]
	public bool PressedReleased(GUIControllerInputButton.LinkedControlType action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1213BC4", Offset = "0x1213BC4", VA = "0x1213BC4")]
	public bool PressedReleased(int action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1213BF4", Offset = "0x1213BF4", VA = "0x1213BF4")]
	public bool NextPagePressed()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x1213C68", Offset = "0x1213C68", VA = "0x1213C68")]
	public bool PreviousPagePressed()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x1213CDC", Offset = "0x1213CDC", VA = "0x1213CDC")]
	public bool SettingsPressed()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x1213D50", Offset = "0x1213D50", VA = "0x1213D50")]
	public GUIControllerNavigationController()
	{
	}
}
