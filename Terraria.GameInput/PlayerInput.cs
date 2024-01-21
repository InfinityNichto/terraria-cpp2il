using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004B3")]
public class PlayerInput
{
	[Cpp2IlInjected.Token(Token = "0x2000941")]
	public class MiscSettingsTEMP
	{
		[Cpp2IlInjected.Token(Token = "0x4008AE1")]
		public static bool HotbarRadialShouldBeUsed;

		[Cpp2IlInjected.Token(Token = "0x6004D06")]
		[Cpp2IlInjected.Address(RVA = "0x130565C", Offset = "0x130565C", VA = "0x130565C")]
		public MiscSettingsTEMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000942")]
	public static class SettingsForUI
	{
		[Cpp2IlInjected.Token(Token = "0x170008A9")]
		public static CursorMode CurrentCursorMode
		{
			[Cpp2IlInjected.Token(Token = "0x6004D08")]
			[Cpp2IlInjected.Address(RVA = "0x13056C0", Offset = "0x13056C0", VA = "0x13056C0")]
			[CompilerGenerated]
			get
			{
				return default(CursorMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6004D09")]
			[Cpp2IlInjected.Address(RVA = "0x1305718", Offset = "0x1305718", VA = "0x1305718")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AA")]
		public static bool ShowGamepadHints
		{
			[Cpp2IlInjected.Token(Token = "0x6004D0B")]
			[Cpp2IlInjected.Address(RVA = "0x130585C", Offset = "0x130585C", VA = "0x130585C")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AB")]
		public static bool AllowSecondaryGamepadAim
		{
			[Cpp2IlInjected.Token(Token = "0x6004D0C")]
			[Cpp2IlInjected.Address(RVA = "0x1305968", Offset = "0x1305968", VA = "0x1305968")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AC")]
		public static bool PushEquipmentAreaUp
		{
			[Cpp2IlInjected.Token(Token = "0x6004D0D")]
			[Cpp2IlInjected.Address(RVA = "0x1305A94", Offset = "0x1305A94", VA = "0x1305A94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AD")]
		public static bool ShowGamepadCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6004D0E")]
			[Cpp2IlInjected.Address(RVA = "0x1305BA0", Offset = "0x1305BA0", VA = "0x1305BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AE")]
		public static bool HighlightThingsForMouse
		{
			[Cpp2IlInjected.Token(Token = "0x6004D0F")]
			[Cpp2IlInjected.Address(RVA = "0x1305CF4", Offset = "0x1305CF4", VA = "0x1305CF4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008AF")]
		public static int FramesSinceLastTimeInMouseMode
		{
			[Cpp2IlInjected.Token(Token = "0x6004D10")]
			[Cpp2IlInjected.Address(RVA = "0x1305DCC", Offset = "0x1305DCC", VA = "0x1305DCC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6004D11")]
			[Cpp2IlInjected.Address(RVA = "0x1305E24", Offset = "0x1305E24", VA = "0x1305E24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008B0")]
		public static bool PreventHighlightsForGamepad
		{
			[Cpp2IlInjected.Token(Token = "0x6004D12")]
			[Cpp2IlInjected.Address(RVA = "0x1305E80", Offset = "0x1305E80", VA = "0x1305E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004D0A")]
		[Cpp2IlInjected.Address(RVA = "0x1305774", Offset = "0x1305774", VA = "0x1305774")]
		public static void SetCursorMode(CursorMode cursorMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D13")]
		[Cpp2IlInjected.Address(RVA = "0x1305EE0", Offset = "0x1305EE0", VA = "0x1305EE0")]
		public static void UpdateCounters()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D14")]
		[Cpp2IlInjected.Address(RVA = "0x1305FC8", Offset = "0x1305FC8", VA = "0x1305FC8")]
		public static void TryRevertingToMouseMode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000943")]
	private struct FastUseItemMemory
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008AE4")]
		private int _slot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008AE5")]
		private int _itemType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008AE6")]
		private bool _shouldFastUse;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4008AE7")]
		private bool _isMouseItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008AE8")]
		private Player _player;

		[Cpp2IlInjected.Token(Token = "0x6004D15")]
		[Cpp2IlInjected.Address(RVA = "0x39E3A0", Offset = "0x39E3A0", VA = "0x39E3A0")]
		public bool TryStartForItemSlot(Player player, int itemSlot)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D16")]
		[Cpp2IlInjected.Address(RVA = "0x39E3A8", Offset = "0x39E3A8", VA = "0x39E3A8")]
		public bool TryStartForMouse(Player player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D17")]
		[Cpp2IlInjected.Address(RVA = "0x39E3C0", Offset = "0x39E3C0", VA = "0x39E3C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004D18")]
		[Cpp2IlInjected.Address(RVA = "0x39E3CC", Offset = "0x39E3CC", VA = "0x39E3CC")]
		public bool CanFastUse()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004D19")]
		[Cpp2IlInjected.Address(RVA = "0x39E3D4", Offset = "0x39E3D4", VA = "0x39E3D4")]
		public void EndFastUse()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40065CC")]
	public static Vector2 RawMouseScale;

	[Cpp2IlInjected.Token(Token = "0x40065CD")]
	public static bool GrappleAndInteractAreShared;

	[Cpp2IlInjected.Token(Token = "0x40065CE")]
	public static SmartSelectGamepadPointer smartSelectPointer;

	[Cpp2IlInjected.Token(Token = "0x40065CF")]
	private static StringBuilder _invalidatorCheck;

	[Cpp2IlInjected.Token(Token = "0x40065D0")]
	private static StringBuilder ff;

	[Cpp2IlInjected.Token(Token = "0x40065D1")]
	private static bool _lastActivityState;

	[Cpp2IlInjected.Token(Token = "0x40065D2")]
	public static int ScrollWheelDeltaForUI;

	[Cpp2IlInjected.Token(Token = "0x40065D3")]
	public static bool GamepadAllowScrolling;

	[Cpp2IlInjected.Token(Token = "0x40065D4")]
	public static int GamepadScrollValue;

	[Cpp2IlInjected.Token(Token = "0x40065D5")]
	public static Vector2 GamepadThumbstickLeft;

	[Cpp2IlInjected.Token(Token = "0x40065D6")]
	public static Vector2 GamepadThumbstickRight;

	[Cpp2IlInjected.Token(Token = "0x40065D7")]
	private static FastUseItemMemory _fastUseMemory;

	[Cpp2IlInjected.Token(Token = "0x40065DA")]
	private static string _listeningTrigger;

	[Cpp2IlInjected.Token(Token = "0x40065DB")]
	private static InputMode _listeningInputMode;

	[Cpp2IlInjected.Token(Token = "0x40065DC")]
	private static bool _canReleaseRebindingLock;

	[Cpp2IlInjected.Token(Token = "0x40065DD")]
	private static int _memoOfLastPoint;

	[Cpp2IlInjected.Token(Token = "0x40065DE")]
	public static int NavigatorRebindingLock;

	[Cpp2IlInjected.Token(Token = "0x40065DF")]
	public static string BlockedKey;

	[Cpp2IlInjected.Token(Token = "0x40065E0")]
	public static Dictionary<string, PlayerInputProfile> Profiles;

	[Cpp2IlInjected.Token(Token = "0x40065E1")]
	public static Dictionary<string, PlayerInputProfile> OriginalProfiles;

	[Cpp2IlInjected.Token(Token = "0x40065E2")]
	private static string _selectedProfile;

	[Cpp2IlInjected.Token(Token = "0x40065E3")]
	private static PlayerInputProfile _currentProfile;

	[Cpp2IlInjected.Token(Token = "0x40065E4")]
	public static InputMode CurrentInputMode;

	[Cpp2IlInjected.Token(Token = "0x40065E5")]
	private static Buttons[] ButtonsGamepad;

	[Cpp2IlInjected.Token(Token = "0x40065E6")]
	public static bool UseSteamDeckIfPossible;

	[Cpp2IlInjected.Token(Token = "0x40065E7")]
	public static List<string> MouseKeys;

	[Cpp2IlInjected.Token(Token = "0x40065E8")]
	private static bool _InBuildingMode;

	[Cpp2IlInjected.Token(Token = "0x40065E9")]
	private static int _UIPointForBuildingMode;

	[Cpp2IlInjected.Token(Token = "0x40065EA")]
	public static bool WritingText;

	[Cpp2IlInjected.Token(Token = "0x40065EB")]
	private static int _originalMouseX;

	[Cpp2IlInjected.Token(Token = "0x40065EC")]
	private static int _originalMouseY;

	[Cpp2IlInjected.Token(Token = "0x40065ED")]
	private static int _originalLastMouseX;

	[Cpp2IlInjected.Token(Token = "0x40065EE")]
	private static int _originalLastMouseY;

	[Cpp2IlInjected.Token(Token = "0x40065EF")]
	private static int _originalScreenWidth;

	[Cpp2IlInjected.Token(Token = "0x40065F0")]
	private static int _originalScreenHeight;

	[Cpp2IlInjected.Token(Token = "0x40065F1")]
	private static ZoomContext _currentWantedZoom;

	[Cpp2IlInjected.Token(Token = "0x40065F2")]
	private static List<string> _buttonsLocked;

	[Cpp2IlInjected.Token(Token = "0x40065F3")]
	private static int[] DpadSnapCooldown;

	[Cpp2IlInjected.Token(Token = "0x17000669")]
	public static TriggersPack Triggers
	{
		[Cpp2IlInjected.Token(Token = "0x600345B")]
		[Cpp2IlInjected.Address(RVA = "0xE1CDAC", Offset = "0xE1CDAC", VA = "0xE1CDAC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600345C")]
		[Cpp2IlInjected.Address(RVA = "0xE1CE28", Offset = "0xE1CE28", VA = "0xE1CE28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700066A")]
	public static MouseState MouseInfo
	{
		[Cpp2IlInjected.Token(Token = "0x600345D")]
		[Cpp2IlInjected.Address(RVA = "0xE1CEA8", Offset = "0xE1CEA8", VA = "0xE1CEA8")]
		get
		{
			return default(MouseState);
		}
		[Cpp2IlInjected.Token(Token = "0x600345E")]
		[Cpp2IlInjected.Address(RVA = "0xE1CF3C", Offset = "0xE1CF3C", VA = "0xE1CF3C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700066B")]
	public static MouseState MouseInfoOld
	{
		[Cpp2IlInjected.Token(Token = "0x600345F")]
		[Cpp2IlInjected.Address(RVA = "0xE1D004", Offset = "0xE1D004", VA = "0xE1D004")]
		get
		{
			return default(MouseState);
		}
		[Cpp2IlInjected.Token(Token = "0x6003460")]
		[Cpp2IlInjected.Address(RVA = "0xE1D098", Offset = "0xE1D098", VA = "0xE1D098")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700066C")]
	public static int MouseX
	{
		[Cpp2IlInjected.Token(Token = "0x6003461")]
		[Cpp2IlInjected.Address(RVA = "0xE1B728", Offset = "0xE1B728", VA = "0xE1B728")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003462")]
		[Cpp2IlInjected.Address(RVA = "0xE1B5AC", Offset = "0xE1B5AC", VA = "0xE1B5AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700066D")]
	public static int MouseY
	{
		[Cpp2IlInjected.Token(Token = "0x6003463")]
		[Cpp2IlInjected.Address(RVA = "0xE1B7A4", Offset = "0xE1B7A4", VA = "0xE1B7A4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003464")]
		[Cpp2IlInjected.Address(RVA = "0xE1B62C", Offset = "0xE1B62C", VA = "0xE1B62C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700066E")]
	public static bool LockGamepadTileUseButton
	{
		[Cpp2IlInjected.Token(Token = "0x6003465")]
		[Cpp2IlInjected.Address(RVA = "0xE11610", Offset = "0xE11610", VA = "0xE11610")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003466")]
		[Cpp2IlInjected.Address(RVA = "0xE1D15C", Offset = "0xE1D15C", VA = "0xE1D15C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700066F")]
	public static int PreUIX
	{
		[Cpp2IlInjected.Token(Token = "0x6003467")]
		[Cpp2IlInjected.Address(RVA = "0xE1D1DC", Offset = "0xE1D1DC", VA = "0xE1D1DC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003468")]
		[Cpp2IlInjected.Address(RVA = "0xE1D258", Offset = "0xE1D258", VA = "0xE1D258")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000670")]
	public static int PreUIY
	{
		[Cpp2IlInjected.Token(Token = "0x6003469")]
		[Cpp2IlInjected.Address(RVA = "0xE1D2D8", Offset = "0xE1D2D8", VA = "0xE1D2D8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600346A")]
		[Cpp2IlInjected.Address(RVA = "0xE1D354", Offset = "0xE1D354", VA = "0xE1D354")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000671")]
	public static int PreLockOnX
	{
		[Cpp2IlInjected.Token(Token = "0x600346B")]
		[Cpp2IlInjected.Address(RVA = "0xE1D3D4", Offset = "0xE1D3D4", VA = "0xE1D3D4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600346C")]
		[Cpp2IlInjected.Address(RVA = "0xE1D450", Offset = "0xE1D450", VA = "0xE1D450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000672")]
	public static int PreLockOnY
	{
		[Cpp2IlInjected.Token(Token = "0x600346D")]
		[Cpp2IlInjected.Address(RVA = "0xE1D4D0", Offset = "0xE1D4D0", VA = "0xE1D4D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600346E")]
		[Cpp2IlInjected.Address(RVA = "0xE1D54C", Offset = "0xE1D54C", VA = "0xE1D54C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000673")]
	public static int ScrollWheelValue
	{
		[Cpp2IlInjected.Token(Token = "0x600346F")]
		[Cpp2IlInjected.Address(RVA = "0xE1D5CC", Offset = "0xE1D5CC", VA = "0xE1D5CC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003470")]
		[Cpp2IlInjected.Address(RVA = "0xE1D648", Offset = "0xE1D648", VA = "0xE1D648")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000674")]
	public static int ScrollWheelValueOld
	{
		[Cpp2IlInjected.Token(Token = "0x6003471")]
		[Cpp2IlInjected.Address(RVA = "0xE1D6C8", Offset = "0xE1D6C8", VA = "0xE1D6C8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003472")]
		[Cpp2IlInjected.Address(RVA = "0xE1D744", Offset = "0xE1D744", VA = "0xE1D744")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000675")]
	public static int ScrollWheelDelta
	{
		[Cpp2IlInjected.Token(Token = "0x6003473")]
		[Cpp2IlInjected.Address(RVA = "0xE1D7C4", Offset = "0xE1D7C4", VA = "0xE1D7C4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003474")]
		[Cpp2IlInjected.Address(RVA = "0xE1D840", Offset = "0xE1D840", VA = "0xE1D840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000676")]
	public static string ListeningTrigger
	{
		[Cpp2IlInjected.Token(Token = "0x600347A")]
		[Cpp2IlInjected.Address(RVA = "0xE1DD68", Offset = "0xE1DD68", VA = "0xE1DD68")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000677")]
	public static bool CurrentlyRebinding
	{
		[Cpp2IlInjected.Token(Token = "0x600347B")]
		[Cpp2IlInjected.Address(RVA = "0xE1DDE0", Offset = "0xE1DDE0", VA = "0xE1DDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000678")]
	public static bool InvisibleGamepadInMenus
	{
		[Cpp2IlInjected.Token(Token = "0x600347C")]
		[Cpp2IlInjected.Address(RVA = "0xE1DE60", Offset = "0xE1DE60", VA = "0xE1DE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000679")]
	public static PlayerInputProfile CurrentProfile
	{
		[Cpp2IlInjected.Token(Token = "0x600347D")]
		[Cpp2IlInjected.Address(RVA = "0xE1E1B4", Offset = "0xE1E1B4", VA = "0xE1E1B4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700067A")]
	public static KeyConfiguration ProfileGamepadUI
	{
		[Cpp2IlInjected.Token(Token = "0x600347E")]
		[Cpp2IlInjected.Address(RVA = "0xE1E22C", Offset = "0xE1E22C", VA = "0xE1E22C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700067B")]
	public static bool UsingGamepad
	{
		[Cpp2IlInjected.Token(Token = "0x600347F")]
		[Cpp2IlInjected.Address(RVA = "0xE11554", Offset = "0xE11554", VA = "0xE11554")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700067C")]
	public static bool UsingGamepadUI
	{
		[Cpp2IlInjected.Token(Token = "0x6003480")]
		[Cpp2IlInjected.Address(RVA = "0xE1E314", Offset = "0xE1E314", VA = "0xE1E314")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700067D")]
	public static bool IgnoreMouseInterface
	{
		[Cpp2IlInjected.Token(Token = "0x6003481")]
		[Cpp2IlInjected.Address(RVA = "0xE1E398", Offset = "0xE1E398", VA = "0xE1E398")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700067E")]
	public static bool SteamDeckIsUsed
	{
		[Cpp2IlInjected.Token(Token = "0x6003482")]
		[Cpp2IlInjected.Address(RVA = "0xE1E454", Offset = "0xE1E454", VA = "0xE1E454")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700067F")]
	public static bool ShouldFastUseItem
	{
		[Cpp2IlInjected.Token(Token = "0x6003487")]
		[Cpp2IlInjected.Address(RVA = "0xE1EC18", Offset = "0xE1EC18", VA = "0xE1EC18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000680")]
	public static bool InBuildingMode
	{
		[Cpp2IlInjected.Token(Token = "0x6003489")]
		[Cpp2IlInjected.Address(RVA = "0xE1ED18", Offset = "0xE1ED18", VA = "0xE1ED18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000681")]
	public static int RealScreenWidth
	{
		[Cpp2IlInjected.Token(Token = "0x600348A")]
		[Cpp2IlInjected.Address(RVA = "0xE1ED90", Offset = "0xE1ED90", VA = "0xE1ED90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000682")]
	public static int RealScreenHeight
	{
		[Cpp2IlInjected.Token(Token = "0x600348B")]
		[Cpp2IlInjected.Address(RVA = "0xE1EE08", Offset = "0xE1EE08", VA = "0xE1EE08")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000683")]
	public static bool CursorIsBusy
	{
		[Cpp2IlInjected.Token(Token = "0x600348E")]
		[Cpp2IlInjected.Address(RVA = "0xE1E0F0", Offset = "0xE1E0F0", VA = "0xE1E0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000684")]
	public static Vector2 OriginalScreenSize
	{
		[Cpp2IlInjected.Token(Token = "0x6003496")]
		[Cpp2IlInjected.Address(RVA = "0xE21278", Offset = "0xE21278", VA = "0xE21278")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public static event Action OnBindingChange
	{
		[Cpp2IlInjected.Token(Token = "0x6003475")]
		[Cpp2IlInjected.Address(RVA = "0xE1D8C0", Offset = "0xE1D8C0", VA = "0xE1D8C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003476")]
		[Cpp2IlInjected.Address(RVA = "0xE1D9C8", Offset = "0xE1D9C8", VA = "0xE1D9C8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public static event Action OnActionableInput
	{
		[Cpp2IlInjected.Token(Token = "0x6003477")]
		[Cpp2IlInjected.Address(RVA = "0xE1DAD0", Offset = "0xE1DAD0", VA = "0xE1DAD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003478")]
		[Cpp2IlInjected.Address(RVA = "0xE1DBD8", Offset = "0xE1DBD8", VA = "0xE1DBD8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003479")]
	[Cpp2IlInjected.Address(RVA = "0xE1DCE0", Offset = "0xE1DCE0", VA = "0xE1DCE0")]
	public static void ListenFor(string triggerName, InputMode inputmode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003483")]
	[Cpp2IlInjected.Address(RVA = "0xE1E4CC", Offset = "0xE1E4CC", VA = "0xE1E4CC")]
	private static bool InvalidateKeyboardSwap()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003484")]
	[Cpp2IlInjected.Address(RVA = "0xE1E700", Offset = "0xE1E700", VA = "0xE1E700")]
	public static void ResetInputsOnActiveStateChange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003485")]
	[Cpp2IlInjected.Address(RVA = "0xE1EAA0", Offset = "0xE1EAA0", VA = "0xE1EAA0")]
	public static void TryEnteringFastUseModeForInventorySlot(int inventorySlot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003486")]
	[Cpp2IlInjected.Address(RVA = "0xE1EB60", Offset = "0xE1EB60", VA = "0xE1EB60")]
	public static void TryEnteringFastUseModeForMouseItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003488")]
	[Cpp2IlInjected.Address(RVA = "0xE1EC98", Offset = "0xE1EC98", VA = "0xE1EC98")]
	public static void TryEndingFastUse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600348C")]
	[Cpp2IlInjected.Address(RVA = "0xE1EE80", Offset = "0xE1EE80", VA = "0xE1EE80")]
	public static void SetSelectedProfile(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600348D")]
	[Cpp2IlInjected.Address(RVA = "0xE1EF74", Offset = "0xE1EF74", VA = "0xE1EF74")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600348F")]
	[Cpp2IlInjected.Address(RVA = "0xE1F35C", Offset = "0xE1F35C", VA = "0xE1F35C")]
	public static bool IsGamepadButtonLockedFromUse(string keyName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003490")]
	[Cpp2IlInjected.Address(RVA = "0xE1F3F0", Offset = "0xE1F3F0", VA = "0xE1F3F0")]
	public static void UpdateInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003491")]
	[Cpp2IlInjected.Address(RVA = "0xE20E88", Offset = "0xE20E88", VA = "0xE20E88")]
	public static void UpdateMainMouse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003492")]
	[Cpp2IlInjected.Address(RVA = "0xE20F78", Offset = "0xE20F78", VA = "0xE20F78")]
	public static void CacheZoomableValues()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003493")]
	[Cpp2IlInjected.Address(RVA = "0xE2119C", Offset = "0xE2119C", VA = "0xE2119C")]
	public static void CacheMousePositionForZoom()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003494")]
	[Cpp2IlInjected.Address(RVA = "0xE20FEC", Offset = "0xE20FEC", VA = "0xE20FEC")]
	private static void CacheOriginalInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003495")]
	[Cpp2IlInjected.Address(RVA = "0xE210D8", Offset = "0xE210D8", VA = "0xE210D8")]
	public static void CacheOriginalScreenDimensions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003497")]
	[Cpp2IlInjected.Address(RVA = "0xE20B40", Offset = "0xE20B40", VA = "0xE20B40")]
	private static bool GamePadInput()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003498")]
	[Cpp2IlInjected.Address(RVA = "0xE1FAE4", Offset = "0xE1FAE4", VA = "0xE1FAE4")]
	private static void MouseInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003499")]
	[Cpp2IlInjected.Address(RVA = "0xE20094", Offset = "0xE20094", VA = "0xE20094")]
	private static bool KeyboardInput()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600349A")]
	[Cpp2IlInjected.Address(RVA = "0xE220AC", Offset = "0xE220AC", VA = "0xE220AC")]
	private static void DebugKeys(List<Keys> keys)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600349B")]
	[Cpp2IlInjected.Address(RVA = "0xE220B0", Offset = "0xE220B0", VA = "0xE220B0")]
	private static void FixDerpedRebinds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600349C")]
	[Cpp2IlInjected.Address(RVA = "0xE21320", Offset = "0xE21320", VA = "0xE21320")]
	private static bool CheckRebindingProcessGamepad(string newKey)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600349D")]
	[Cpp2IlInjected.Address(RVA = "0xE220A4", Offset = "0xE220A4", VA = "0xE220A4")]
	private static bool CheckRebindingProcessKeyboard(string newKey)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600349E")]
	[Cpp2IlInjected.Address(RVA = "0xE20BFC", Offset = "0xE20BFC", VA = "0xE20BFC")]
	private static void PostInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600349F")]
	[Cpp2IlInjected.Address(RVA = "0xE21328", Offset = "0xE21328", VA = "0xE21328")]
	private static void HandleDpadSnap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A0")]
	[Cpp2IlInjected.Address(RVA = "0xE220B4", Offset = "0xE220B4", VA = "0xE220B4")]
	public static string BuildCommand(string CommandText, bool Last, params List<string>[] Bindings)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60034A1")]
	[Cpp2IlInjected.Address(RVA = "0xE2225C", Offset = "0xE2225C", VA = "0xE2225C")]
	private static string GenerateGlyphList(List<string> list)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60034A2")]
	[Cpp2IlInjected.Address(RVA = "0xE2239C", Offset = "0xE2239C", VA = "0xE2239C")]
	private static string GenerateRawInputList(List<string> list)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60034A3")]
	[Cpp2IlInjected.Address(RVA = "0xE2246C", Offset = "0xE2246C", VA = "0xE2246C")]
	public static void NavigatorCachePosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A4")]
	[Cpp2IlInjected.Address(RVA = "0xE22470", Offset = "0xE22470", VA = "0xE22470")]
	public static void NavigatorUnCachePosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A5")]
	[Cpp2IlInjected.Address(RVA = "0xE1B530", Offset = "0xE1B530", VA = "0xE1B530")]
	public static void LockOnCachePosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A6")]
	[Cpp2IlInjected.Address(RVA = "0xE1B6AC", Offset = "0xE1B6AC", VA = "0xE1B6AC")]
	public static void LockOnUnCachePosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A7")]
	[Cpp2IlInjected.Address(RVA = "0xE22474", Offset = "0xE22474", VA = "0xE22474")]
	public static void PrettyPrintProfiles(ref string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A8")]
	[Cpp2IlInjected.Address(RVA = "0xE22724", Offset = "0xE22724", VA = "0xE22724")]
	public static void PrettyPrintProfilesOld(ref string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034A9")]
	[Cpp2IlInjected.Address(RVA = "0xE22848", Offset = "0xE22848", VA = "0xE22848")]
	public static void Reset(KeyConfiguration c, PresetProfiles style, InputMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034AA")]
	[Cpp2IlInjected.Address(RVA = "0xE25568", Offset = "0xE25568", VA = "0xE25568")]
	public static void SetZoom_UI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034AB")]
	[Cpp2IlInjected.Address(RVA = "0xE2556C", Offset = "0xE2556C", VA = "0xE2556C")]
	public static void SetZoom_World()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034AC")]
	[Cpp2IlInjected.Address(RVA = "0xE25570", Offset = "0xE25570", VA = "0xE25570")]
	public static void SetZoom_Unscaled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034AD")]
	[Cpp2IlInjected.Address(RVA = "0xE25574", Offset = "0xE25574", VA = "0xE25574")]
	public static void SetZoom_Test()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034AE")]
	[Cpp2IlInjected.Address(RVA = "0xE25578", Offset = "0xE25578", VA = "0xE25578")]
	public static void SetZoom_MouseInWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034AF")]
	[Cpp2IlInjected.Address(RVA = "0xE2557C", Offset = "0xE2557C", VA = "0xE2557C")]
	public static void SetDesiredZoomContext(ZoomContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B0")]
	[Cpp2IlInjected.Address(RVA = "0xE25580", Offset = "0xE25580", VA = "0xE25580")]
	public static void SetZoom_Context()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B1")]
	[Cpp2IlInjected.Address(RVA = "0xE25584", Offset = "0xE25584", VA = "0xE25584")]
	private static void SetZoom_Scaled(float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60034B2")]
	[Cpp2IlInjected.Address(RVA = "0xE25588", Offset = "0xE25588", VA = "0xE25588")]
	public PlayerInput()
	{
	}
}
