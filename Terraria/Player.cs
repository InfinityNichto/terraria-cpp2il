using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ObjectInteractions;
using Terraria.IO;
using Terraria.Localization;
using Terraria.UI.Chat;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000320")]
public class Player : Entity, IFixLoadedData
{
	[Cpp2IlInjected.Token(Token = "0x200083C")]
	public class SmartCursorSettings
	{
		[Cpp2IlInjected.Token(Token = "0x17000851")]
		public static bool SmartBlocksEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60049CD")]
			[Cpp2IlInjected.Address(RVA = "0x864924", Offset = "0x864924", VA = "0x864924")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60049CE")]
			[Cpp2IlInjected.Address(RVA = "0x8649A0", Offset = "0x8649A0", VA = "0x8649A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000852")]
		public static bool SmartAxeAfterPickaxe
		{
			[Cpp2IlInjected.Token(Token = "0x60049CF")]
			[Cpp2IlInjected.Address(RVA = "0x864A20", Offset = "0x864A20", VA = "0x864A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60049D0")]
			[Cpp2IlInjected.Address(RVA = "0x864A9C", Offset = "0x864A9C", VA = "0x864A9C")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049D1")]
		[Cpp2IlInjected.Address(RVA = "0x864B1C", Offset = "0x864B1C", VA = "0x864B1C")]
		public SmartCursorSettings()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200083D")]
	public class Settings
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4F")]
		public enum HoverControlMode
		{
			[Cpp2IlInjected.Token(Token = "0x4008FE9")]
			Hold,
			[Cpp2IlInjected.Token(Token = "0x4008FEA")]
			Click
		}

		[Cpp2IlInjected.Token(Token = "0x4007E70")]
		public static HoverControlMode HoverControl;

		[Cpp2IlInjected.Token(Token = "0x60049D2")]
		[Cpp2IlInjected.Address(RVA = "0x864838", Offset = "0x864838", VA = "0x864838")]
		public static void CycleHoverControl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049D3")]
		[Cpp2IlInjected.Address(RVA = "0x864918", Offset = "0x864918", VA = "0x864918")]
		public Settings()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200083E")]
	public static class BuilderAccToggleIDs
	{
		[Cpp2IlInjected.Token(Token = "0x4007E71")]
		public const int RulerLine = 0;

		[Cpp2IlInjected.Token(Token = "0x4007E72")]
		public const int RulerGrid = 1;

		[Cpp2IlInjected.Token(Token = "0x4007E73")]
		public const int AutoActuate = 2;

		[Cpp2IlInjected.Token(Token = "0x4007E74")]
		public const int AutoPaint = 3;

		[Cpp2IlInjected.Token(Token = "0x4007E75")]
		public const int WireVisibility_Red = 4;

		[Cpp2IlInjected.Token(Token = "0x4007E76")]
		public const int WireVisibility_Green = 5;

		[Cpp2IlInjected.Token(Token = "0x4007E77")]
		public const int WireVisibility_Blue = 6;

		[Cpp2IlInjected.Token(Token = "0x4007E78")]
		public const int WireVisibility_Yellow = 7;

		[Cpp2IlInjected.Token(Token = "0x4007E79")]
		public const int HideAllWires = 8;

		[Cpp2IlInjected.Token(Token = "0x4007E7A")]
		public const int WireVisibility_Actuators = 9;

		[Cpp2IlInjected.Token(Token = "0x4007E7B")]
		public const int BlockSwap = 10;

		[Cpp2IlInjected.Token(Token = "0x4007E7C")]
		public const int TorchBiome = 11;

		[Cpp2IlInjected.Token(Token = "0x4007E7D")]
		public static readonly int Count;
	}

	[Cpp2IlInjected.Token(Token = "0x200083F")]
	public struct DirectionalInputSyncCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E7E")]
		public bool controlLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4007E7F")]
		public bool controlRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4007E80")]
		public bool controlUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4007E81")]
		public bool controlDown;

		[Cpp2IlInjected.Token(Token = "0x60049D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AF220", Offset = "0x2AF220", VA = "0x2AF220")]
		public DirectionalInputSyncCache(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AF244", Offset = "0x2AF244", VA = "0x2AF244")]
		public void ApplyTo(Player player)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000840")]
	private struct ChannelCancelKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E82")]
		public int ProjectileTypeExpected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E83")]
		public int ProjectileIndexExpected;

		[Cpp2IlInjected.Token(Token = "0x60049D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF108", Offset = "0x2AF108", VA = "0x2AF108")]
		public bool Matches(Projectile projectile)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60049D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AF138", Offset = "0x2AF138", VA = "0x2AF138")]
		public void TryTracking(Projectile projectile)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000841")]
	public struct RabbitOrderFrameHelper
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E84")]
		public int DisplayFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E85")]
		private int _frameCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E86")]
		private int _aiState;

		[Cpp2IlInjected.Token(Token = "0x4007E87")]
		private const int AIState_Idle = 0;

		[Cpp2IlInjected.Token(Token = "0x4007E88")]
		private const int AIState_LookingAtCamera = 1;

		[Cpp2IlInjected.Token(Token = "0x4007E89")]
		private const int AIState_Resting = 2;

		[Cpp2IlInjected.Token(Token = "0x4007E8A")]
		private const int AIState_EatingCarrot = 3;

		[Cpp2IlInjected.Token(Token = "0x60049DA")]
		[Cpp2IlInjected.Address(RVA = "0x2AF350", Offset = "0x2AF350", VA = "0x2AF350")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AF358", Offset = "0x2AF358", VA = "0x2AF358")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AF36C", Offset = "0x2AF36C", VA = "0x2AF36C")]
		private void ChangeToAIState(int aiState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AF380", Offset = "0x2AF380", VA = "0x2AF380")]
		private void UpdateFrame(int displayFrameMin, int displayFrameMax, int exitAIState, int gameFramesPerDisplayFrame)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000842")]
	public enum CompositeArmStretchAmount
	{
		[Cpp2IlInjected.Token(Token = "0x4007E8C")]
		Full,
		[Cpp2IlInjected.Token(Token = "0x4007E8D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007E8E")]
		Quarter,
		[Cpp2IlInjected.Token(Token = "0x4007E8F")]
		ThreeQuarters
	}

	[Cpp2IlInjected.Token(Token = "0x2000843")]
	public struct CompositeArmData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E90")]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E91")]
		public CompositeArmStretchAmount stretch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E92")]
		public float rotation;

		[Cpp2IlInjected.Token(Token = "0x60049DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AF194", Offset = "0x2AF194", VA = "0x2AF194")]
		public CompositeArmData(bool enabled, CompositeArmStretchAmount intendedStrech, float rotation)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000844")]
	public enum eToHellAndBackStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4007E94")]
		NotStarted,
		[Cpp2IlInjected.Token(Token = "0x4007E95")]
		SurfaceToHell,
		[Cpp2IlInjected.Token(Token = "0x4007E96")]
		HellToSurface,
		[Cpp2IlInjected.Token(Token = "0x4007E97")]
		Completed
	}

	[Cpp2IlInjected.Token(Token = "0x2000845")]
	public delegate void DashStartAction(int dashDirection);

	[Cpp2IlInjected.Token(Token = "0x2000846")]
	public struct SetMatchRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E98")]
		public int Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E99")]
		public int Body;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E9A")]
		public int Legs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E9B")]
		public int ArmorSlotRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E9C")]
		public bool Male;
	}

	[Cpp2IlInjected.Token(Token = "0x2000847")]
	public struct ItemSpaceStatus
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E9D")]
		public bool CanTakeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4007E9E")]
		public bool ItemIsGoingToVoidVault;

		[Cpp2IlInjected.Token(Token = "0x17000853")]
		public bool CanTakeItemToPersonalInventory
		{
			[Cpp2IlInjected.Token(Token = "0x60049E3")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2C8", Offset = "0x2AF2C8", VA = "0x2AF2C8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2E4", Offset = "0x2AF2E4", VA = "0x2AF2E4")]
		public ItemSpaceStatus(bool CanTakeItem = false, bool ItemIsGoingToVoidVault = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2F0", Offset = "0x2AF2F0", VA = "0x2AF2F0")]
		public void Set(bool CanTakeItem, bool ItemIsGoingToVoidVault = false)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000848")]
	public struct ItemCheckContext
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E9F")]
		public bool SkipItemConsumption;
	}

	[Cpp2IlInjected.Token(Token = "0x2000849")]
	private struct SpecialToolUsageSettings
	{
		[Cpp2IlInjected.Token(Token = "0x2000B50")]
		public delegate bool CanUseToolCondition(Player user, Item item, int targetX, int targetY);

		[Cpp2IlInjected.Token(Token = "0x2000B51")]
		public delegate void UseToolAction(Player user, Item item, int targetX, int targetY);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007EA0")]
		public bool IsAValidTool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007EA1")]
		public CanUseToolCondition UsageCondition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EA2")]
		public UseToolAction UsageAction;
	}

	[Cpp2IlInjected.Token(Token = "0x200084A")]
	public class SavedPlayerDataWithAnnoyingRules
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EA3")]
		public bool godmodePowerEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4007EA4")]
		public bool farPlacementRangePowerEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007EA5")]
		public float spawnRatePowerSliderValue;

		[Cpp2IlInjected.Token(Token = "0x60049E6")]
		[Cpp2IlInjected.Address(RVA = "0x863D38", Offset = "0x863D38", VA = "0x863D38")]
		public SavedPlayerDataWithAnnoyingRules()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200084B")]
	public class RandomTeleportationAttemptSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EA6")]
		public bool mostlySolidFloor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4007EA7")]
		public bool avoidLava;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4007EA8")]
		public bool avoidAnyLiquid;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4007EA9")]
		public bool avoidHurtTiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007EAA")]
		public bool avoidWalls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007EAB")]
		public int attemptsBeforeGivingUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007EAC")]
		public int maximumFallDistanceFromOrignalPoint;

		[Cpp2IlInjected.Token(Token = "0x60049E7")]
		[Cpp2IlInjected.Address(RVA = "0x863D30", Offset = "0x863D30", VA = "0x863D30")]
		public RandomTeleportationAttemptSettings()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200084C")]
	public static class Hooks
	{
		[Cpp2IlInjected.Token(Token = "0x14000063")]
		public static event Action<Player> OnEnterWorld
		{
			[Cpp2IlInjected.Token(Token = "0x60049E8")]
			[Cpp2IlInjected.Address(RVA = "0x8634B4", Offset = "0x8634B4", VA = "0x8634B4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60049E9")]
			[Cpp2IlInjected.Address(RVA = "0x863578", Offset = "0x863578", VA = "0x863578")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049EA")]
		[Cpp2IlInjected.Address(RVA = "0x86363C", Offset = "0x86363C", VA = "0x86363C")]
		public static void PlayerConnect(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049EB")]
		[Cpp2IlInjected.Address(RVA = "0x8636B8", Offset = "0x8636B8", VA = "0x8636B8")]
		public static void PlayerDisconnect(int playerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049EC")]
		[Cpp2IlInjected.Address(RVA = "0x86375C", Offset = "0x86375C", VA = "0x86375C")]
		public static void EnterWorld(int playerIndex)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200084D")]
	public class SelectionRadial
	{
		[Cpp2IlInjected.Token(Token = "0x2000B52")]
		public enum SelectionMode
		{
			[Cpp2IlInjected.Token(Token = "0x4008FEC")]
			Dpad4,
			[Cpp2IlInjected.Token(Token = "0x4008FED")]
			RadialCircular,
			[Cpp2IlInjected.Token(Token = "0x4008FEE")]
			RadialQuicks
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EAE")]
		private int _SelectedBinding;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007EAF")]
		private int _NPCHeldItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007EB0")]
		public int RadialCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007EB1")]
		public int[] Bindings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007EB2")]
		public SelectionMode Mode;

		[Cpp2IlInjected.Token(Token = "0x17000854")]
		public int SelectedBinding
		{
			[Cpp2IlInjected.Token(Token = "0x60049ED")]
			[Cpp2IlInjected.Address(RVA = "0x863D40", Offset = "0x863D40", VA = "0x863D40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000855")]
		public int SelectedItem
		{
			[Cpp2IlInjected.Token(Token = "0x60049EE")]
			[Cpp2IlInjected.Address(RVA = "0x863D48", Offset = "0x863D48", VA = "0x863D48")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60049EF")]
		[Cpp2IlInjected.Address(RVA = "0x863E44", Offset = "0x863E44", VA = "0x863E44")]
		public void LoadNPCHeldItem(int heldItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049F0")]
		[Cpp2IlInjected.Address(RVA = "0x863E54", Offset = "0x863E54", VA = "0x863E54")]
		public SelectionRadial(SelectionMode mode = SelectionMode.Dpad4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049F1")]
		[Cpp2IlInjected.Address(RVA = "0x863F2C", Offset = "0x863F2C", VA = "0x863F2C")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049F2")]
		[Cpp2IlInjected.Address(RVA = "0x8644C0", Offset = "0x8644C0", VA = "0x8644C0")]
		public void ChangeBinding(int itemSlot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049F3")]
		[Cpp2IlInjected.Address(RVA = "0x8644AC", Offset = "0x8644AC", VA = "0x8644AC")]
		public void ChangeSelection(int to)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049F4")]
		[Cpp2IlInjected.Address(RVA = "0x86465C", Offset = "0x86465C", VA = "0x86465C")]
		public void Bind(int itemslot, int radialslot)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60049F5")]
		[Cpp2IlInjected.Address(RVA = "0x8646D0", Offset = "0x8646D0", VA = "0x8646D0")]
		public int GetSlotBinding(int itemSlot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60049F6")]
		[Cpp2IlInjected.Address(RVA = "0x86471C", Offset = "0x86471C", VA = "0x86471C")]
		public int GetDrawMode(int itemslot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60049F7")]
		[Cpp2IlInjected.Address(RVA = "0x864784", Offset = "0x864784", VA = "0x864784")]
		public void CopyTo(SelectionRadial that)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200084E")]
	public struct OverheadMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007EB3")]
		public string chatText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007EB4")]
		public TextSnippet[] snippets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007EB5")]
		public Vector2 messageSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007EB6")]
		public int timeLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007EB7")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60049F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AF348", Offset = "0x2AF348", VA = "0x2AF348")]
		public void NewMessage(string message, int displayTime)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4002784")]
	private static float _blizzardSoundVolume;

	[Cpp2IlInjected.Token(Token = "0x4002785")]
	private static SlotId _strongBlizzardSound;

	[Cpp2IlInjected.Token(Token = "0x4002786")]
	private static SlotId _insideBlizzardSound;

	[Cpp2IlInjected.Token(Token = "0x4002787")]
	public static int taxRate;

	[Cpp2IlInjected.Token(Token = "0x4002788")]
	public const int crystalLeafDamage = 100;

	[Cpp2IlInjected.Token(Token = "0x4002789")]
	public const int crystalLeafKB = 10;

	[Cpp2IlInjected.Token(Token = "0x400278A")]
	public const int manaSickTime = 300;

	[Cpp2IlInjected.Token(Token = "0x400278B")]
	public const int manaSickTimeMax = 600;

	[Cpp2IlInjected.Token(Token = "0x400278C")]
	public const float manaSickLessDmg = 0.25f;

	[Cpp2IlInjected.Token(Token = "0x400278D")]
	public const int nameLen = 20;

	[Cpp2IlInjected.Token(Token = "0x400278E")]
	public static bool deadForGood;

	[Cpp2IlInjected.Token(Token = "0x400278F")]
	public const float defaultGravity = 0.4f;

	[Cpp2IlInjected.Token(Token = "0x4002790")]
	public const int defaultItemGrabRange = 42;

	[Cpp2IlInjected.Token(Token = "0x4002791")]
	private static GameCulture lastArmourCulture;

	[Cpp2IlInjected.Token(Token = "0x4002792")]
	private static string lastId;

	[Cpp2IlInjected.Token(Token = "0x4002793")]
	private static string lastFormatId;

	[Cpp2IlInjected.Token(Token = "0x4002794")]
	private static string lastResult;

	[Cpp2IlInjected.Token(Token = "0x4002795")]
	private static SmartInteractSystem _smartInteractSys;

	[Cpp2IlInjected.Token(Token = "0x4002796")]
	private static int[] _torchAttackPosX;

	[Cpp2IlInjected.Token(Token = "0x4002797")]
	private static int[] _torchAttackPosY;

	[Cpp2IlInjected.Token(Token = "0x4002798")]
	public static bool requestedSignInfo;

	[Cpp2IlInjected.Token(Token = "0x4002799")]
	public static int lastRequestSignX;

	[Cpp2IlInjected.Token(Token = "0x400279A")]
	public static int lastRequestSignY;

	[Cpp2IlInjected.Token(Token = "0x400279B")]
	private static List<Projectile> _oldestProjCheckList;

	[Cpp2IlInjected.Token(Token = "0x400279C")]
	public static Player EmptyPlayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400279D")]
	public int emoteTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400279E")]
	public CreativeUnlocksTracker creativeTracker;

	[Cpp2IlInjected.Token(Token = "0x400279F")]
	private static byte[] ENCRYPTION_KEY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40027A0")]
	public OverheadMessage chatOverhead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40027A1")]
	public SelectionRadial DpadRadial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40027A2")]
	public SelectionRadial CircularRadial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40027A3")]
	public SelectionRadial QuicksRadial;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40027A4")]
	public bool alchemyTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40027A5")]
	public int HotbarOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40027A6")]
	public bool GoingDownWithGrapple;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
	[Cpp2IlInjected.Token(Token = "0x40027A7")]
	public byte spelunkerTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40027A8")]
	public bool[] hideInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40027A9")]
	public int[] builderAccStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40027AA")]
	public long lostCoins;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40027AB")]
	public string lostCoinString;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40027AC")]
	public int soulDrain;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40027AD")]
	public float drainBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40027AE")]
	public bool dd2Accessory;

	[Cpp2IlInjected.Token(Token = "0x40027AF")]
	private static bool disabledBlizzardGraphic;

	[Cpp2IlInjected.Token(Token = "0x40027B0")]
	private static bool disabledBlizzardSound;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40027B1")]
	public string name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40027B2")]
	public int taxMoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40027B3")]
	public int taxTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40027B4")]
	public int numberOfDeathsPVE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40027B5")]
	public int numberOfDeathsPVP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40027B6")]
	public float basiliskCharge;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40027B7")]
	public Vector2 lastDeathPostion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40027B8")]
	public DateTime lastDeathTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40027B9")]
	public bool showLastDeath;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40027BA")]
	public bool usedAegisCrystal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD2")]
	[Cpp2IlInjected.Token(Token = "0x40027BB")]
	public bool usedAegisFruit;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD3")]
	[Cpp2IlInjected.Token(Token = "0x40027BC")]
	public bool usedArcaneCrystal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40027BD")]
	public bool usedGalaxyPearl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD5")]
	[Cpp2IlInjected.Token(Token = "0x40027BE")]
	public bool usedGummyWorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD6")]
	[Cpp2IlInjected.Token(Token = "0x40027BF")]
	public bool usedAmbrosia;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40027C0")]
	public int extraAccessorySlots;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40027C1")]
	public int extraAccessorySlotsUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40027C2")]
	public bool extraAccessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x40027C3")]
	private bool dontConsumeWand;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40027C4")]
	public int tankPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40027C5")]
	public bool tankPetReset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40027C6")]
	public int stringColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40027C7")]
	public int counterWeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40027C8")]
	public bool yoyoString;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40027C9")]
	public bool yoyoGlove;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40027CA")]
	public int beetleOrbs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40027CB")]
	public float beetleCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40027CC")]
	public int beetleCountdown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40027CD")]
	public bool beetleDefense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x105")]
	[Cpp2IlInjected.Token(Token = "0x40027CE")]
	public bool beetleOffense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x106")]
	[Cpp2IlInjected.Token(Token = "0x40027CF")]
	public bool beetleBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40027D0")]
	public int solarShields;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40027D1")]
	public int solarCounter;

	[Cpp2IlInjected.Token(Token = "0x40027D2")]
	public const int maxSolarShields = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40027D3")]
	public Vector2[] solarShieldPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40027D4")]
	public Vector2[] solarShieldVel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40027D5")]
	public bool solarDashing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x119")]
	[Cpp2IlInjected.Token(Token = "0x40027D6")]
	public bool solarDashConsumedFlare;

	[Cpp2IlInjected.Token(Token = "0x40027D7")]
	public const int nebulaMaxLevel = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40027D8")]
	public int nebulaLevelLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40027D9")]
	public int nebulaLevelMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40027DA")]
	public int nebulaManaCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40027DB")]
	public int nebulaLevelDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40027DC")]
	public bool manaMagnet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40027DD")]
	public bool lifeMagnet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40027DE")]
	public bool treasureMagnet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40027DF")]
	public bool chiselSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40027E0")]
	public bool lifeForce;

	[Cpp2IlInjected.FieldOffset(Offset = "0x131")]
	[Cpp2IlInjected.Token(Token = "0x40027E1")]
	public bool calmed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x132")]
	[Cpp2IlInjected.Token(Token = "0x40027E2")]
	public bool inferno;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40027E3")]
	public float flameRingRot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40027E4")]
	public float flameRingScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40027E5")]
	public byte flameRingFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40027E6")]
	public byte flameRingAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40027E7")]
	public int netManaTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40027E8")]
	public int netLifeTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40027E9")]
	public bool netMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x149")]
	[Cpp2IlInjected.Token(Token = "0x40027EA")]
	public bool netLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x40027EB")]
	public Vector2[] beetlePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40027EC")]
	public Vector2[] beetleVel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40027ED")]
	public int beetleFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40027EE")]
	public int beetleFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40027EF")]
	public float manaSickReduction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40027F0")]
	public bool manaSick;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40027F1")]
	public int afkCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40027F2")]
	public bool stairFall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40027F3")]
	public int loadStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40027F4")]
	public Vector2[] itemFlamePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x40027F5")]
	public int itemFlameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40027F6")]
	public bool outOfRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40027F7")]
	public float lifeSteal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40027F8")]
	public float ghostDmg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40027F9")]
	public bool teleporting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40027FA")]
	public float teleportTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40027FB")]
	public int teleportStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40027FC")]
	public bool sloping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
	[Cpp2IlInjected.Token(Token = "0x40027FD")]
	public bool chilled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x192")]
	[Cpp2IlInjected.Token(Token = "0x40027FE")]
	public bool dazed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x193")]
	[Cpp2IlInjected.Token(Token = "0x40027FF")]
	public bool frozen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4002800")]
	public bool stoned;

	[Cpp2IlInjected.FieldOffset(Offset = "0x195")]
	[Cpp2IlInjected.Token(Token = "0x4002801")]
	public bool lastStoned;

	[Cpp2IlInjected.FieldOffset(Offset = "0x196")]
	[Cpp2IlInjected.Token(Token = "0x4002802")]
	public bool ichor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x197")]
	[Cpp2IlInjected.Token(Token = "0x4002803")]
	public bool webbed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4002804")]
	public bool tipsy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
	[Cpp2IlInjected.Token(Token = "0x4002805")]
	public bool noBuilding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4002806")]
	public int ropeCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4002807")]
	public int manaRegenBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4002808")]
	public float manaRegenDelayBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4002809")]
	public int dashType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400280A")]
	public int dash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400280B")]
	public int dashTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400280C")]
	public int timeSinceLastDashStarted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400280D")]
	public int dashDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400280E")]
	public int eocDash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400280F")]
	public int eocHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4002810")]
	public float accRunSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4002811")]
	public bool cordage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4002812")]
	public int gem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4002813")]
	public int gemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x4002814")]
	public BitsByte ownedLargeGems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D5")]
	[Cpp2IlInjected.Token(Token = "0x4002815")]
	public byte meleeEnchant;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D6")]
	[Cpp2IlInjected.Token(Token = "0x4002816")]
	public byte pulleyDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D7")]
	[Cpp2IlInjected.Token(Token = "0x4002817")]
	public bool pulley;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x4002818")]
	public int pulleyFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x4002819")]
	public float pulleyFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x400281A")]
	public bool blackBelt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E1")]
	[Cpp2IlInjected.Token(Token = "0x400281B")]
	public bool sliding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x400281C")]
	public int slideDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x400281D")]
	public int snowBallLauncherInteractionCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x400281E")]
	public bool iceSkate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1ED")]
	[Cpp2IlInjected.Token(Token = "0x400281F")]
	public bool carpet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4002820")]
	public int spikedBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Cpp2IlInjected.Token(Token = "0x4002821")]
	public int carpetFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x4002822")]
	public float carpetFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x4002823")]
	public bool canCarpet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4002824")]
	public int carpetTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x4002825")]
	public int miscCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x4002826")]
	public int infernoCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x4002827")]
	public int insanityShadowCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4002828")]
	public int starCloakCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x4002829")]
	public bool sandStorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x215")]
	[Cpp2IlInjected.Token(Token = "0x400282A")]
	public bool crimsonRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x216")]
	[Cpp2IlInjected.Token(Token = "0x400282B")]
	public bool ghostHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x217")]
	[Cpp2IlInjected.Token(Token = "0x400282C")]
	public bool ghostHurt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x400282D")]
	public bool sticky;

	[Cpp2IlInjected.FieldOffset(Offset = "0x219")]
	[Cpp2IlInjected.Token(Token = "0x400282E")]
	public bool slippy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21A")]
	[Cpp2IlInjected.Token(Token = "0x400282F")]
	public bool slippy2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21B")]
	[Cpp2IlInjected.Token(Token = "0x4002830")]
	public bool powerrun;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x4002831")]
	public bool runningOnSand;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21D")]
	[Cpp2IlInjected.Token(Token = "0x4002832")]
	public bool flapSound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21E")]
	[Cpp2IlInjected.Token(Token = "0x4002833")]
	public bool iceBarrier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21F")]
	[Cpp2IlInjected.Token(Token = "0x4002834")]
	public bool dangerSense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4002835")]
	public byte luckPotion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x221")]
	[Cpp2IlInjected.Token(Token = "0x4002836")]
	public byte oldLuckPotion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Cpp2IlInjected.Token(Token = "0x4002837")]
	public float endurance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x4002838")]
	public float whipRangeMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x4002839")]
	public float whipUseTimeMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400283A")]
	public bool loveStruck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x231")]
	[Cpp2IlInjected.Token(Token = "0x400283B")]
	public bool stinky;

	[Cpp2IlInjected.FieldOffset(Offset = "0x232")]
	[Cpp2IlInjected.Token(Token = "0x400283C")]
	public bool resistCold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x233")]
	[Cpp2IlInjected.Token(Token = "0x400283D")]
	public bool electrified;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x400283E")]
	public bool dryadWard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x235")]
	[Cpp2IlInjected.Token(Token = "0x400283F")]
	public bool panic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x4002840")]
	public Item brainOfConfusionItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x4002841")]
	public int brainOfConfusionDodgeAnimationCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4002842")]
	public byte iceBarrierFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x241")]
	[Cpp2IlInjected.Token(Token = "0x4002843")]
	public byte iceBarrierFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x242")]
	[Cpp2IlInjected.Token(Token = "0x4002844")]
	public bool shadowDodge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x4002845")]
	public float shadowDodgeCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4002846")]
	public bool palladiumRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x249")]
	[Cpp2IlInjected.Token(Token = "0x4002847")]
	public bool onHitDodge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24A")]
	[Cpp2IlInjected.Token(Token = "0x4002848")]
	public bool onHitRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24B")]
	[Cpp2IlInjected.Token(Token = "0x4002849")]
	public bool onHitPetal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x400284A")]
	public bool onHitTitaniumStorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400284B")]
	public int titaniumStormCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
	[Cpp2IlInjected.Token(Token = "0x400284C")]
	public bool hasTitaniumStormBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x400284D")]
	public int petalTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x400284E")]
	public int shadowDodgeTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x400284F")]
	public int boneGloveTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x4002850")]
	public int phantomPhoneixCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4002851")]
	public int fishingSkill;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x4002852")]
	public bool cratePotion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26D")]
	[Cpp2IlInjected.Token(Token = "0x4002853")]
	public bool sonarPotion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26E")]
	[Cpp2IlInjected.Token(Token = "0x4002854")]
	public bool accFishingLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26F")]
	[Cpp2IlInjected.Token(Token = "0x4002855")]
	public bool accFishingBobber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4002856")]
	public bool accTackleBox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x4002857")]
	public bool accLavaFishing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x4002858")]
	public int maxMinions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4002859")]
	public int numMinions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x400285A")]
	public float slotsMinions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400285B")]
	public bool pygmy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x281")]
	[Cpp2IlInjected.Token(Token = "0x400285C")]
	public bool raven;

	[Cpp2IlInjected.FieldOffset(Offset = "0x282")]
	[Cpp2IlInjected.Token(Token = "0x400285D")]
	public bool slime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x283")]
	[Cpp2IlInjected.Token(Token = "0x400285E")]
	public bool hornetMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x400285F")]
	public bool impMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x285")]
	[Cpp2IlInjected.Token(Token = "0x4002860")]
	public bool twinsMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x286")]
	[Cpp2IlInjected.Token(Token = "0x4002861")]
	public bool spiderMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4002862")]
	public int nextCycledSpiderMinionType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4002863")]
	public bool pirateMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28D")]
	[Cpp2IlInjected.Token(Token = "0x4002864")]
	public bool sharknadoMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28E")]
	[Cpp2IlInjected.Token(Token = "0x4002865")]
	public bool UFOMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28F")]
	[Cpp2IlInjected.Token(Token = "0x4002866")]
	public bool DeadlySphereMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4002867")]
	public bool stardustMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x291")]
	[Cpp2IlInjected.Token(Token = "0x4002868")]
	public bool stardustGuardian;

	[Cpp2IlInjected.FieldOffset(Offset = "0x292")]
	[Cpp2IlInjected.Token(Token = "0x4002869")]
	public bool stardustDragon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x293")]
	[Cpp2IlInjected.Token(Token = "0x400286A")]
	public bool batsOfLight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x400286B")]
	public bool babyBird;

	[Cpp2IlInjected.FieldOffset(Offset = "0x295")]
	[Cpp2IlInjected.Token(Token = "0x400286C")]
	public bool vampireFrog;

	[Cpp2IlInjected.FieldOffset(Offset = "0x296")]
	[Cpp2IlInjected.Token(Token = "0x400286D")]
	public bool stormTiger;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x400286E")]
	public int highestStormTigerGemOriginalDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x400286F")]
	public bool smolstar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29D")]
	[Cpp2IlInjected.Token(Token = "0x4002870")]
	public bool empressBlade;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29E")]
	[Cpp2IlInjected.Token(Token = "0x4002871")]
	public bool flinxMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29F")]
	[Cpp2IlInjected.Token(Token = "0x4002872")]
	public bool abigailMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4002873")]
	public int highestAbigailCounterOriginalDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x4002874")]
	public float wingTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4002875")]
	public int wings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x4002876")]
	public int wingsLogic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4002877")]
	public int wingTimeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x4002878")]
	public int wingFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4002879")]
	public int wingFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x400287A")]
	public int skinVariant;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x400287B")]
	public bool ghost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400287C")]
	public int ghostFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400287D")]
	public int ghostFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x400287E")]
	public int miscTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400287F")]
	public int environmentBuffImmunityTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x4002880")]
	public int _framesLeftEligibleForDeadmansChestDeathAchievement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4002881")]
	public bool pvpDeath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D9")]
	[Cpp2IlInjected.Token(Token = "0x4002882")]
	public BitsByte zone1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DA")]
	[Cpp2IlInjected.Token(Token = "0x4002883")]
	public BitsByte zone2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DB")]
	[Cpp2IlInjected.Token(Token = "0x4002884")]
	public BitsByte zone3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x4002885")]
	public BitsByte zone4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DD")]
	[Cpp2IlInjected.Token(Token = "0x4002886")]
	public BitsByte zone5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DE")]
	[Cpp2IlInjected.Token(Token = "0x4002887")]
	private bool _wasInShimmerZone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DF")]
	[Cpp2IlInjected.Token(Token = "0x4002888")]
	public bool boneArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4002889")]
	public bool frostArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E1")]
	[Cpp2IlInjected.Token(Token = "0x400288A")]
	public bool honey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E2")]
	[Cpp2IlInjected.Token(Token = "0x400288B")]
	public bool crystalLeaf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x400288C")]
	public int crystalLeafCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x400288D")]
	public PortableStoolUsage portableStoolInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x400288E")]
	public bool preventAllItemPickups;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F9")]
	[Cpp2IlInjected.Token(Token = "0x400288F")]
	public bool dontHurtCritters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FA")]
	[Cpp2IlInjected.Token(Token = "0x4002890")]
	public bool hasLucyTheAxe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FB")]
	[Cpp2IlInjected.Token(Token = "0x4002891")]
	public bool dontHurtNature;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
	[Cpp2IlInjected.Token(Token = "0x4002892")]
	public int[] doubleTapCardinalTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4002893")]
	public int[] holdDownCardinalTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4002894")]
	public bool defendedByPaladin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x305")]
	[Cpp2IlInjected.Token(Token = "0x4002895")]
	public bool hasPaladinShield;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4002896")]
	public float[] speedSlice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x4002897")]
	public float townNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4002898")]
	public double headFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x4002899")]
	public double bodyFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400289A")]
	public double legFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400289B")]
	public int netSkip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x400289C")]
	public int oldSelectItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400289D")]
	public bool immune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x331")]
	[Cpp2IlInjected.Token(Token = "0x400289E")]
	public bool immuneNoBlink;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x400289F")]
	public int immuneTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x40028A0")]
	public int immuneAlphaDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x40028A1")]
	public int immuneAlpha;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x40028A2")]
	public int team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x40028A3")]
	private int _timeSinceLastImmuneGet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x40028A4")]
	private int _immuneStrikes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x40028A5")]
	public bool hbLocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x40028A6")]
	public float maxRegenDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x40028A7")]
	public int sign;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x40028A8")]
	public bool editedChestName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
	[Cpp2IlInjected.Token(Token = "0x40028A9")]
	public int reuseDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x40028AA")]
	public int aggro;

	[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
	[Cpp2IlInjected.Token(Token = "0x40028AB")]
	public float nearbyActiveNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x40028AC")]
	public bool creativeInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x369")]
	[Cpp2IlInjected.Token(Token = "0x40028AD")]
	public bool mouseInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36A")]
	[Cpp2IlInjected.Token(Token = "0x40028AE")]
	public bool lastMouseInterface;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
	[Cpp2IlInjected.Token(Token = "0x40028AF")]
	public int noThrow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x40028B0")]
	public int changeItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
	[Cpp2IlInjected.Token(Token = "0x40028B1")]
	public int lastHotbarItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x40028B2")]
	public int selectedItem;

	[Cpp2IlInjected.Token(Token = "0x40028B3")]
	public const int SupportedSlotsArmor = 3;

	[Cpp2IlInjected.Token(Token = "0x40028B4")]
	public const int SupportedSlotsAccs = 7;

	[Cpp2IlInjected.Token(Token = "0x40028B5")]
	public const int SupportedSlotSets = 10;

	[Cpp2IlInjected.Token(Token = "0x40028B6")]
	public const int InitialAccSlotCount = 5;

	[Cpp2IlInjected.Token(Token = "0x40028B7")]
	public const int miscSlotPet = 0;

	[Cpp2IlInjected.Token(Token = "0x40028B8")]
	public const int miscSlotLight = 1;

	[Cpp2IlInjected.Token(Token = "0x40028B9")]
	public const int miscSlotCart = 2;

	[Cpp2IlInjected.Token(Token = "0x40028BA")]
	public const int miscSlotMount = 3;

	[Cpp2IlInjected.Token(Token = "0x40028BB")]
	public const int miscSlotHook = 4;

	[Cpp2IlInjected.Token(Token = "0x40028BC")]
	public const int SupportedMiscSlotCount = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x40028BD")]
	public Item[] armor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x40028BE")]
	public Item[] dye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x40028BF")]
	public Item[] miscEquips;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x40028C0")]
	public Item[] miscDyes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
	[Cpp2IlInjected.Token(Token = "0x40028C1")]
	public Item trashItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x40028C2")]
	public float itemRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x40028C3")]
	public int itemWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
	[Cpp2IlInjected.Token(Token = "0x40028C4")]
	public int itemHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x40028C5")]
	public Vector2 itemLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x40028C6")]
	public bool poundRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x40028C7")]
	public float ghostFade;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x40028C8")]
	public float ghostDir;

	[Cpp2IlInjected.Token(Token = "0x40028C9")]
	public static readonly int maxBuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x40028CA")]
	public int[] buffType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
	[Cpp2IlInjected.Token(Token = "0x40028CB")]
	public int[] buffTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x40028CC")]
	public bool[] buffImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
	[Cpp2IlInjected.Token(Token = "0x40028CD")]
	public int heldProj;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x40028CE")]
	public int breathCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
	[Cpp2IlInjected.Token(Token = "0x40028CF")]
	public int breathMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
	[Cpp2IlInjected.Token(Token = "0x40028D0")]
	public int breath;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
	[Cpp2IlInjected.Token(Token = "0x40028D1")]
	public int lavaCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
	[Cpp2IlInjected.Token(Token = "0x40028D2")]
	public int lavaMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
	[Cpp2IlInjected.Token(Token = "0x40028D3")]
	public int lavaTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
	[Cpp2IlInjected.Token(Token = "0x40028D4")]
	public bool ignoreWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3D9")]
	[Cpp2IlInjected.Token(Token = "0x40028D5")]
	public bool armorEffectDrawShadow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DA")]
	[Cpp2IlInjected.Token(Token = "0x40028D6")]
	public bool armorEffectDrawShadowSubtle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DB")]
	[Cpp2IlInjected.Token(Token = "0x40028D7")]
	public bool armorEffectDrawOutlines;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
	[Cpp2IlInjected.Token(Token = "0x40028D8")]
	public bool armorEffectDrawShadowLokis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DD")]
	[Cpp2IlInjected.Token(Token = "0x40028D9")]
	public bool armorEffectDrawShadowBasilisk;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DE")]
	[Cpp2IlInjected.Token(Token = "0x40028DA")]
	public bool armorEffectDrawOutlinesForbidden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3DF")]
	[Cpp2IlInjected.Token(Token = "0x40028DB")]
	public bool armorEffectDrawShadowEOCShield;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
	[Cpp2IlInjected.Token(Token = "0x40028DC")]
	public bool socialShadowRocketBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E1")]
	[Cpp2IlInjected.Token(Token = "0x40028DD")]
	public bool socialGhost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E2")]
	[Cpp2IlInjected.Token(Token = "0x40028DE")]
	public bool shroomiteStealth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E3")]
	[Cpp2IlInjected.Token(Token = "0x40028DF")]
	public bool ashWoodBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
	[Cpp2IlInjected.Token(Token = "0x40028E0")]
	public bool socialIgnoreLight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
	[Cpp2IlInjected.Token(Token = "0x40028E1")]
	public int stealthTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
	[Cpp2IlInjected.Token(Token = "0x40028E2")]
	public float stealth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
	[Cpp2IlInjected.Token(Token = "0x40028E3")]
	public int beardGrowthTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
	[Cpp2IlInjected.Token(Token = "0x40028E4")]
	public bool isDisplayDollOrInanimate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F5")]
	[Cpp2IlInjected.Token(Token = "0x40028E5")]
	public bool isFullbright;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F6")]
	[Cpp2IlInjected.Token(Token = "0x40028E6")]
	public bool isHatRackDoll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F7")]
	[Cpp2IlInjected.Token(Token = "0x40028E7")]
	public bool isFirstFractalAfterImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
	[Cpp2IlInjected.Token(Token = "0x40028E8")]
	public float firstFractalAfterImageOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
	[Cpp2IlInjected.Token(Token = "0x40028E9")]
	public string setBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
	[Cpp2IlInjected.Token(Token = "0x40028EA")]
	public Item[] inventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
	[Cpp2IlInjected.Token(Token = "0x40028EB")]
	public bool[] inventoryChestStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
	[Cpp2IlInjected.Token(Token = "0x40028EC")]
	public Item lastVisualizedSelectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
	[Cpp2IlInjected.Token(Token = "0x40028ED")]
	public Chest bank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
	[Cpp2IlInjected.Token(Token = "0x40028EE")]
	public Chest bank2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
	[Cpp2IlInjected.Token(Token = "0x40028EF")]
	public Chest bank3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
	[Cpp2IlInjected.Token(Token = "0x40028F0")]
	public Chest bank4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
	[Cpp2IlInjected.Token(Token = "0x40028F1")]
	public BitsByte voidVaultInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
	[Cpp2IlInjected.Token(Token = "0x40028F2")]
	public float headRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
	[Cpp2IlInjected.Token(Token = "0x40028F3")]
	public float bodyRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
	[Cpp2IlInjected.Token(Token = "0x40028F4")]
	public float legRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
	[Cpp2IlInjected.Token(Token = "0x40028F5")]
	public Vector2 headPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
	[Cpp2IlInjected.Token(Token = "0x40028F6")]
	public Vector2 bodyPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
	[Cpp2IlInjected.Token(Token = "0x40028F7")]
	public Vector2 legPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
	[Cpp2IlInjected.Token(Token = "0x40028F8")]
	public Vector2 headVelocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
	[Cpp2IlInjected.Token(Token = "0x40028F9")]
	public Vector2 bodyVelocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
	[Cpp2IlInjected.Token(Token = "0x40028FA")]
	public Vector2 legVelocity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
	[Cpp2IlInjected.Token(Token = "0x40028FB")]
	public float fullRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
	[Cpp2IlInjected.Token(Token = "0x40028FC")]
	public Vector2 fullRotationOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
	[Cpp2IlInjected.Token(Token = "0x40028FD")]
	public int fartKartCloudDelay;

	[Cpp2IlInjected.Token(Token = "0x40028FE")]
	public const int fartKartCloudDelayMax = 20;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
	[Cpp2IlInjected.Token(Token = "0x40028FF")]
	public int nonTorch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
	[Cpp2IlInjected.Token(Token = "0x4002900")]
	public float gfxOffY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
	[Cpp2IlInjected.Token(Token = "0x4002901")]
	public float stepSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
	[Cpp2IlInjected.Token(Token = "0x4002902")]
	public bool dead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
	[Cpp2IlInjected.Token(Token = "0x4002903")]
	public int respawnTimer;

	[Cpp2IlInjected.Token(Token = "0x4002904")]
	public const int respawnTimerMax = 3600;

	[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
	[Cpp2IlInjected.Token(Token = "0x4002905")]
	public long lastTimePlayerWasSaved;

	[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
	[Cpp2IlInjected.Token(Token = "0x4002906")]
	public int attackCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
	[Cpp2IlInjected.Token(Token = "0x4002907")]
	public int potionDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
	[Cpp2IlInjected.Token(Token = "0x4002908")]
	public byte difficulty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x491")]
	[Cpp2IlInjected.Token(Token = "0x4002909")]
	public byte wetSlime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
	[Cpp2IlInjected.Token(Token = "0x400290A")]
	public HitTile hitTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
	[Cpp2IlInjected.Token(Token = "0x400290B")]
	public HitTile hitReplace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49C")]
	[Cpp2IlInjected.Token(Token = "0x400290C")]
	public float startJumpY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
	[Cpp2IlInjected.Token(Token = "0x400290D")]
	public bool jumping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
	[Cpp2IlInjected.Token(Token = "0x400290E")]
	public int jump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
	[Cpp2IlInjected.Token(Token = "0x400290F")]
	public int head;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4AC")]
	[Cpp2IlInjected.Token(Token = "0x4002910")]
	public int body;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
	[Cpp2IlInjected.Token(Token = "0x4002911")]
	public int legs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B4")]
	[Cpp2IlInjected.Token(Token = "0x4002912")]
	public sbyte handon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B5")]
	[Cpp2IlInjected.Token(Token = "0x4002913")]
	public sbyte handoff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B6")]
	[Cpp2IlInjected.Token(Token = "0x4002914")]
	public sbyte back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B7")]
	[Cpp2IlInjected.Token(Token = "0x4002915")]
	public sbyte front;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
	[Cpp2IlInjected.Token(Token = "0x4002916")]
	public sbyte shoe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4B9")]
	[Cpp2IlInjected.Token(Token = "0x4002917")]
	public sbyte waist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BA")]
	[Cpp2IlInjected.Token(Token = "0x4002918")]
	public sbyte shield;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BB")]
	[Cpp2IlInjected.Token(Token = "0x4002919")]
	public sbyte neck;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
	[Cpp2IlInjected.Token(Token = "0x400291A")]
	public sbyte face;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BD")]
	[Cpp2IlInjected.Token(Token = "0x400291B")]
	public sbyte balloon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BE")]
	[Cpp2IlInjected.Token(Token = "0x400291C")]
	public sbyte backpack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4BF")]
	[Cpp2IlInjected.Token(Token = "0x400291D")]
	public sbyte tail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
	[Cpp2IlInjected.Token(Token = "0x400291E")]
	public sbyte faceHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C1")]
	[Cpp2IlInjected.Token(Token = "0x400291F")]
	public sbyte faceFlower;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C2")]
	[Cpp2IlInjected.Token(Token = "0x4002920")]
	public sbyte balloonFront;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C3")]
	[Cpp2IlInjected.Token(Token = "0x4002921")]
	public sbyte beard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
	[Cpp2IlInjected.Token(Token = "0x4002922")]
	public bool[] hideVisibleAccessory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
	[Cpp2IlInjected.Token(Token = "0x4002923")]
	public BitsByte hideMisc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
	[Cpp2IlInjected.Token(Token = "0x4002924")]
	public Rectangle headFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4DC")]
	[Cpp2IlInjected.Token(Token = "0x4002925")]
	public Rectangle bodyFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4EC")]
	[Cpp2IlInjected.Token(Token = "0x4002926")]
	public Rectangle legFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4FC")]
	[Cpp2IlInjected.Token(Token = "0x4002927")]
	public Rectangle hairFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50C")]
	[Cpp2IlInjected.Token(Token = "0x4002928")]
	public DirectionalInputSyncCache LocalInputCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x510")]
	[Cpp2IlInjected.Token(Token = "0x4002929")]
	public bool blockUseItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x511")]
	[Cpp2IlInjected.Token(Token = "0x400292A")]
	public bool holdUpJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x512")]
	[Cpp2IlInjected.Token(Token = "0x400292B")]
	private bool rewsing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x514")]
	[Cpp2IlInjected.Token(Token = "0x400292C")]
	public short InitialItemUsing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x516")]
	[Cpp2IlInjected.Token(Token = "0x400292D")]
	public bool disableUseUntilRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x517")]
	[Cpp2IlInjected.Token(Token = "0x400292E")]
	public bool controlLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x518")]
	[Cpp2IlInjected.Token(Token = "0x400292F")]
	public bool controlRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x519")]
	[Cpp2IlInjected.Token(Token = "0x4002930")]
	public bool controlUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51A")]
	[Cpp2IlInjected.Token(Token = "0x4002931")]
	public bool controlDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51B")]
	[Cpp2IlInjected.Token(Token = "0x4002932")]
	public bool controlJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51C")]
	[Cpp2IlInjected.Token(Token = "0x4002933")]
	public bool controlUseItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51D")]
	[Cpp2IlInjected.Token(Token = "0x4002934")]
	public bool controlUseTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51E")]
	[Cpp2IlInjected.Token(Token = "0x4002935")]
	public bool controlThrow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51F")]
	[Cpp2IlInjected.Token(Token = "0x4002936")]
	public bool controlInv;

	[Cpp2IlInjected.FieldOffset(Offset = "0x520")]
	[Cpp2IlInjected.Token(Token = "0x4002937")]
	public bool controlHook;

	[Cpp2IlInjected.FieldOffset(Offset = "0x521")]
	[Cpp2IlInjected.Token(Token = "0x4002938")]
	public bool controlTorch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x522")]
	[Cpp2IlInjected.Token(Token = "0x4002939")]
	public bool controlMap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x523")]
	[Cpp2IlInjected.Token(Token = "0x400293A")]
	public bool controlSmart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x524")]
	[Cpp2IlInjected.Token(Token = "0x400293B")]
	public bool controlMount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x525")]
	[Cpp2IlInjected.Token(Token = "0x400293C")]
	public bool releaseJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x526")]
	[Cpp2IlInjected.Token(Token = "0x400293D")]
	public bool releaseUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x527")]
	[Cpp2IlInjected.Token(Token = "0x400293E")]
	public bool releaseUseItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x528")]
	[Cpp2IlInjected.Token(Token = "0x400293F")]
	public bool releaseUseTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x529")]
	[Cpp2IlInjected.Token(Token = "0x4002940")]
	public bool releaseInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52A")]
	[Cpp2IlInjected.Token(Token = "0x4002941")]
	public bool releaseHook;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52B")]
	[Cpp2IlInjected.Token(Token = "0x4002942")]
	public bool releaseThrow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52C")]
	[Cpp2IlInjected.Token(Token = "0x4002943")]
	public bool releaseQuickMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52D")]
	[Cpp2IlInjected.Token(Token = "0x4002944")]
	public bool releaseQuickHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52E")]
	[Cpp2IlInjected.Token(Token = "0x4002945")]
	public bool releaseLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52F")]
	[Cpp2IlInjected.Token(Token = "0x4002946")]
	public bool releaseRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x530")]
	[Cpp2IlInjected.Token(Token = "0x4002947")]
	public bool releaseSmart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x531")]
	[Cpp2IlInjected.Token(Token = "0x4002948")]
	public bool releaseMount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x532")]
	[Cpp2IlInjected.Token(Token = "0x4002949")]
	public bool releaseDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x533")]
	[Cpp2IlInjected.Token(Token = "0x400294A")]
	public bool controlQuickMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x534")]
	[Cpp2IlInjected.Token(Token = "0x400294B")]
	public bool controlQuickHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x535")]
	[Cpp2IlInjected.Token(Token = "0x400294C")]
	public bool controlCreativeMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x536")]
	[Cpp2IlInjected.Token(Token = "0x400294D")]
	public bool releaseCreativeMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x537")]
	[Cpp2IlInjected.Token(Token = "0x400294E")]
	public bool controlQuickBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x538")]
	[Cpp2IlInjected.Token(Token = "0x400294F")]
	public bool controlFireRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x539")]
	[Cpp2IlInjected.Token(Token = "0x4002950")]
	public bool controlFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x53A")]
	[Cpp2IlInjected.Token(Token = "0x4002951")]
	public bool controlInteractionRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x53B")]
	[Cpp2IlInjected.Token(Token = "0x4002952")]
	public bool controlInteraction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x53C")]
	[Cpp2IlInjected.Token(Token = "0x4002953")]
	public bool controlLayout1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x53D")]
	[Cpp2IlInjected.Token(Token = "0x4002954")]
	public bool controlLayout2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x53E")]
	[Cpp2IlInjected.Token(Token = "0x4002955")]
	public bool controlLayout3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x53F")]
	[Cpp2IlInjected.Token(Token = "0x4002956")]
	public bool controlLayoutCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x540")]
	[Cpp2IlInjected.Token(Token = "0x4002957")]
	public int lockInteractionForFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x544")]
	[Cpp2IlInjected.Token(Token = "0x4002958")]
	public PlatformUser UserData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54C")]
	[Cpp2IlInjected.Token(Token = "0x4002959")]
	public LocalUser LocalUser;

	[Cpp2IlInjected.FieldOffset(Offset = "0x550")]
	[Cpp2IlInjected.Token(Token = "0x400295A")]
	public bool tileInteractionHappened;

	[Cpp2IlInjected.FieldOffset(Offset = "0x551")]
	[Cpp2IlInjected.Token(Token = "0x400295B")]
	public bool tileInteractAttempted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x552")]
	[Cpp2IlInjected.Token(Token = "0x400295C")]
	public bool controlDownHold;

	[Cpp2IlInjected.FieldOffset(Offset = "0x553")]
	[Cpp2IlInjected.Token(Token = "0x400295D")]
	public bool isOperatingAnotherEntity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x554")]
	[Cpp2IlInjected.Token(Token = "0x400295E")]
	public bool autoReuseAllWeapons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x555")]
	[Cpp2IlInjected.Token(Token = "0x400295F")]
	public bool isControlledByFilm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x556")]
	[Cpp2IlInjected.Token(Token = "0x4002960")]
	public bool tryKeepingHoveringDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x557")]
	[Cpp2IlInjected.Token(Token = "0x4002961")]
	public bool tryKeepingHoveringUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x558")]
	[Cpp2IlInjected.Token(Token = "0x4002962")]
	public int altFunctionUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55C")]
	[Cpp2IlInjected.Token(Token = "0x4002963")]
	public bool mapZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55D")]
	[Cpp2IlInjected.Token(Token = "0x4002964")]
	public bool mapZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55E")]
	[Cpp2IlInjected.Token(Token = "0x4002965")]
	public bool mapAlphaUp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55F")]
	[Cpp2IlInjected.Token(Token = "0x4002966")]
	public bool mapAlphaDown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x560")]
	[Cpp2IlInjected.Token(Token = "0x4002967")]
	public bool mapFullScreen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x561")]
	[Cpp2IlInjected.Token(Token = "0x4002968")]
	public bool mapStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x562")]
	[Cpp2IlInjected.Token(Token = "0x4002969")]
	public bool releaseMapFullscreen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x563")]
	[Cpp2IlInjected.Token(Token = "0x400296A")]
	public bool releaseMapStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x564")]
	[Cpp2IlInjected.Token(Token = "0x400296B")]
	public int leftTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x568")]
	[Cpp2IlInjected.Token(Token = "0x400296C")]
	public int rightTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x56C")]
	[Cpp2IlInjected.Token(Token = "0x400296D")]
	public bool delayUseItem;

	[Cpp2IlInjected.Token(Token = "0x400296E")]
	public const int defaultWidth = 20;

	[Cpp2IlInjected.Token(Token = "0x400296F")]
	public const int defaultHeight = 42;

	[Cpp2IlInjected.FieldOffset(Offset = "0x56D")]
	[Cpp2IlInjected.Token(Token = "0x4002970")]
	public bool cursorItemIconEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x56E")]
	[Cpp2IlInjected.Token(Token = "0x4002971")]
	public bool cursorItemIconReversed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x570")]
	[Cpp2IlInjected.Token(Token = "0x4002972")]
	public int cursorItemIconID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x574")]
	[Cpp2IlInjected.Token(Token = "0x4002973")]
	public int cursorItemIconPush;

	[Cpp2IlInjected.FieldOffset(Offset = "0x578")]
	[Cpp2IlInjected.Token(Token = "0x4002974")]
	public int cursorChestItemIconID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x57C")]
	[Cpp2IlInjected.Token(Token = "0x4002975")]
	public string cursorItemIconText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x580")]
	[Cpp2IlInjected.Token(Token = "0x4002976")]
	public int runSoundDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x584")]
	[Cpp2IlInjected.Token(Token = "0x4002977")]
	public float opacityForAnimation;

	[Cpp2IlInjected.Token(Token = "0x4002978")]
	public const int shadowMax = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x588")]
	[Cpp2IlInjected.Token(Token = "0x4002979")]
	public Vector2[] shadowPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58C")]
	[Cpp2IlInjected.Token(Token = "0x400297A")]
	public float[] shadowRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x590")]
	[Cpp2IlInjected.Token(Token = "0x400297B")]
	public Vector2[] shadowOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x594")]
	[Cpp2IlInjected.Token(Token = "0x400297C")]
	public int[] shadowDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x598")]
	[Cpp2IlInjected.Token(Token = "0x400297D")]
	public int shadowCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59C")]
	[Cpp2IlInjected.Token(Token = "0x400297E")]
	public float manaCost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A0")]
	[Cpp2IlInjected.Token(Token = "0x400297F")]
	public bool fireWalk;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A1")]
	[Cpp2IlInjected.Token(Token = "0x4002980")]
	public bool channel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A4")]
	[Cpp2IlInjected.Token(Token = "0x4002981")]
	public int step;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A8")]
	[Cpp2IlInjected.Token(Token = "0x4002982")]
	private ChannelCancelKey _channelShotCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5B0")]
	[Cpp2IlInjected.Token(Token = "0x4002983")]
	public bool skipAnimatingValuesInPlayerFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5B4")]
	[Cpp2IlInjected.Token(Token = "0x4002984")]
	public RabbitOrderFrameHelper rabbitOrderFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C0")]
	[Cpp2IlInjected.Token(Token = "0x4002985")]
	public bool creativeGodMode;

	[Cpp2IlInjected.Token(Token = "0x4002986")]
	private const int MaxAdvancedShadows = 60;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C4")]
	[Cpp2IlInjected.Token(Token = "0x4002987")]
	public int availableAdvancedShadowsCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C8")]
	[Cpp2IlInjected.Token(Token = "0x4002988")]
	private EntityShadowInfo[] _advancedShadows;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5CC")]
	[Cpp2IlInjected.Token(Token = "0x4002989")]
	private int _lastAddedAvancedShadow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5D0")]
	[Cpp2IlInjected.Token(Token = "0x400298A")]
	public CompositeArmData compositeFrontArm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5DC")]
	[Cpp2IlInjected.Token(Token = "0x400298B")]
	public CompositeArmData compositeBackArm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5E8")]
	[Cpp2IlInjected.Token(Token = "0x400298C")]
	public int anglerQuestsFinished;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5EC")]
	[Cpp2IlInjected.Token(Token = "0x400298D")]
	public int golferScoreAccumulated;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5F0")]
	[Cpp2IlInjected.Token(Token = "0x400298E")]
	public int bartenderQuestLog;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5F4")]
	[Cpp2IlInjected.Token(Token = "0x400298F")]
	public bool downedDD2EventAnyDifficulty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5F8")]
	[Cpp2IlInjected.Token(Token = "0x4002990")]
	public int armorPenetration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5FC")]
	[Cpp2IlInjected.Token(Token = "0x4002991")]
	public int statDefense;

	[Cpp2IlInjected.FieldOffset(Offset = "0x600")]
	[Cpp2IlInjected.Token(Token = "0x4002992")]
	public int statLifeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x604")]
	[Cpp2IlInjected.Token(Token = "0x4002993")]
	public int statLifeMax2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x608")]
	[Cpp2IlInjected.Token(Token = "0x4002994")]
	public int statLife;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60C")]
	[Cpp2IlInjected.Token(Token = "0x4002995")]
	public int statMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x610")]
	[Cpp2IlInjected.Token(Token = "0x4002996")]
	public int statManaMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x614")]
	[Cpp2IlInjected.Token(Token = "0x4002997")]
	public int statManaMax2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x618")]
	[Cpp2IlInjected.Token(Token = "0x4002998")]
	public int lifeRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61C")]
	[Cpp2IlInjected.Token(Token = "0x4002999")]
	public int lifeRegenCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x620")]
	[Cpp2IlInjected.Token(Token = "0x400299A")]
	public float lifeRegenTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x624")]
	[Cpp2IlInjected.Token(Token = "0x400299B")]
	public int manaRegen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x628")]
	[Cpp2IlInjected.Token(Token = "0x400299C")]
	public int manaRegenCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62C")]
	[Cpp2IlInjected.Token(Token = "0x400299D")]
	public float manaRegenDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x630")]
	[Cpp2IlInjected.Token(Token = "0x400299E")]
	public bool manaRegenBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x631")]
	[Cpp2IlInjected.Token(Token = "0x400299F")]
	public bool noKnockback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x632")]
	[Cpp2IlInjected.Token(Token = "0x40029A0")]
	private bool shimmerImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x633")]
	[Cpp2IlInjected.Token(Token = "0x40029A1")]
	public bool spaceGun;

	[Cpp2IlInjected.FieldOffset(Offset = "0x634")]
	[Cpp2IlInjected.Token(Token = "0x40029A2")]
	public float gravDir;

	[Cpp2IlInjected.FieldOffset(Offset = "0x638")]
	[Cpp2IlInjected.Token(Token = "0x40029A3")]
	public bool chloroAmmoCost80;

	[Cpp2IlInjected.FieldOffset(Offset = "0x639")]
	[Cpp2IlInjected.Token(Token = "0x40029A4")]
	public bool huntressAmmoCost90;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63A")]
	[Cpp2IlInjected.Token(Token = "0x40029A5")]
	public bool ammoCost80;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63B")]
	[Cpp2IlInjected.Token(Token = "0x40029A6")]
	public bool ammoCost75;

	[Cpp2IlInjected.FieldOffset(Offset = "0x63C")]
	[Cpp2IlInjected.Token(Token = "0x40029A7")]
	public int stickyBreak;

	[Cpp2IlInjected.FieldOffset(Offset = "0x640")]
	[Cpp2IlInjected.Token(Token = "0x40029A8")]
	public bool magicQuiver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x641")]
	[Cpp2IlInjected.Token(Token = "0x40029A9")]
	public bool magmaStone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x642")]
	[Cpp2IlInjected.Token(Token = "0x40029AA")]
	public bool lavaRose;

	[Cpp2IlInjected.FieldOffset(Offset = "0x643")]
	[Cpp2IlInjected.Token(Token = "0x40029AB")]
	public bool hasMoltenQuiver;

	[Cpp2IlInjected.FieldOffset(Offset = "0x644")]
	[Cpp2IlInjected.Token(Token = "0x40029AC")]
	public int phantasmTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x648")]
	[Cpp2IlInjected.Token(Token = "0x40029AD")]
	public bool ammoBox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x649")]
	[Cpp2IlInjected.Token(Token = "0x40029AE")]
	public bool ammoPotion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64A")]
	[Cpp2IlInjected.Token(Token = "0x40029AF")]
	public bool chaosState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64B")]
	[Cpp2IlInjected.Token(Token = "0x40029B0")]
	public bool strongBees;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64C")]
	[Cpp2IlInjected.Token(Token = "0x40029B1")]
	public bool sporeSac;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64D")]
	[Cpp2IlInjected.Token(Token = "0x40029B2")]
	public bool shinyStone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64E")]
	[Cpp2IlInjected.Token(Token = "0x40029B3")]
	public bool empressBrooch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64F")]
	[Cpp2IlInjected.Token(Token = "0x40029B4")]
	public bool volatileGelatin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x650")]
	[Cpp2IlInjected.Token(Token = "0x40029B5")]
	public int volatileGelatinCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x654")]
	[Cpp2IlInjected.Token(Token = "0x40029B6")]
	public bool hasMagiluminescence;

	[Cpp2IlInjected.FieldOffset(Offset = "0x655")]
	[Cpp2IlInjected.Token(Token = "0x40029B7")]
	public bool shadowArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x656")]
	[Cpp2IlInjected.Token(Token = "0x40029B8")]
	public bool dontStarveShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x657")]
	[Cpp2IlInjected.Token(Token = "0x40029B9")]
	public bool eyebrellaCloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x658")]
	[Cpp2IlInjected.Token(Token = "0x40029BA")]
	public int yoraiz0rEye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65C")]
	[Cpp2IlInjected.Token(Token = "0x40029BB")]
	public bool yoraiz0rDarkness;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65D")]
	[Cpp2IlInjected.Token(Token = "0x40029BC")]
	public bool hasUnicornHorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65E")]
	[Cpp2IlInjected.Token(Token = "0x40029BD")]
	public bool hasAngelHalo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65F")]
	[Cpp2IlInjected.Token(Token = "0x40029BE")]
	public bool hasRainbowCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x660")]
	[Cpp2IlInjected.Token(Token = "0x40029BF")]
	public bool leinforsHair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x661")]
	[Cpp2IlInjected.Token(Token = "0x40029C0")]
	public bool stardustMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x662")]
	[Cpp2IlInjected.Token(Token = "0x40029C1")]
	public bool nebulaMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x663")]
	[Cpp2IlInjected.Token(Token = "0x40029C2")]
	public bool vortexMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x664")]
	[Cpp2IlInjected.Token(Token = "0x40029C3")]
	public bool solarMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x665")]
	[Cpp2IlInjected.Token(Token = "0x40029C4")]
	public bool moonLordMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x666")]
	[Cpp2IlInjected.Token(Token = "0x40029C5")]
	public bool bloodMoonMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x667")]
	[Cpp2IlInjected.Token(Token = "0x40029C6")]
	public bool shimmerMonolithShader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x668")]
	[Cpp2IlInjected.Token(Token = "0x40029C7")]
	public int overrideFishingBobber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66C")]
	[Cpp2IlInjected.Token(Token = "0x40029C8")]
	public bool unlockedBiomeTorches;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66D")]
	[Cpp2IlInjected.Token(Token = "0x40029C9")]
	public bool ateArtisanBread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66E")]
	[Cpp2IlInjected.Token(Token = "0x40029CA")]
	public bool unlockedSuperCart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66F")]
	[Cpp2IlInjected.Token(Token = "0x40029CB")]
	public bool enabledSuperCart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x670")]
	[Cpp2IlInjected.Token(Token = "0x40029CC")]
	public bool suspiciouslookingTentacle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x671")]
	[Cpp2IlInjected.Token(Token = "0x40029CD")]
	public bool crimsonHeart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x672")]
	[Cpp2IlInjected.Token(Token = "0x40029CE")]
	public bool lightOrb;

	[Cpp2IlInjected.FieldOffset(Offset = "0x673")]
	[Cpp2IlInjected.Token(Token = "0x40029CF")]
	public bool blueFairy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x674")]
	[Cpp2IlInjected.Token(Token = "0x40029D0")]
	public bool redFairy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x675")]
	[Cpp2IlInjected.Token(Token = "0x40029D1")]
	public bool greenFairy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x676")]
	[Cpp2IlInjected.Token(Token = "0x40029D2")]
	public bool bunny;

	[Cpp2IlInjected.FieldOffset(Offset = "0x677")]
	[Cpp2IlInjected.Token(Token = "0x40029D3")]
	public bool turtle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x678")]
	[Cpp2IlInjected.Token(Token = "0x40029D4")]
	public bool eater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x679")]
	[Cpp2IlInjected.Token(Token = "0x40029D5")]
	public bool penguin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67A")]
	[Cpp2IlInjected.Token(Token = "0x40029D6")]
	public bool HasGardenGnomeNearby;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67B")]
	[Cpp2IlInjected.Token(Token = "0x40029D7")]
	public bool magicLantern;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67C")]
	[Cpp2IlInjected.Token(Token = "0x40029D8")]
	public bool rabid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67D")]
	[Cpp2IlInjected.Token(Token = "0x40029D9")]
	public bool sunflower;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67E")]
	[Cpp2IlInjected.Token(Token = "0x40029DA")]
	public bool wellFed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x67F")]
	[Cpp2IlInjected.Token(Token = "0x40029DB")]
	public bool puppy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x680")]
	[Cpp2IlInjected.Token(Token = "0x40029DC")]
	public bool grinch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x681")]
	[Cpp2IlInjected.Token(Token = "0x40029DD")]
	public bool miniMinotaur;

	[Cpp2IlInjected.FieldOffset(Offset = "0x682")]
	[Cpp2IlInjected.Token(Token = "0x40029DE")]
	public bool flowerBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x683")]
	[Cpp2IlInjected.Token(Token = "0x40029DF")]
	public bool fairyBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x684")]
	[Cpp2IlInjected.Token(Token = "0x40029E0")]
	public bool hellfireTreads;

	[Cpp2IlInjected.FieldOffset(Offset = "0x685")]
	[Cpp2IlInjected.Token(Token = "0x40029E1")]
	public bool moonLordLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x686")]
	[Cpp2IlInjected.Token(Token = "0x40029E2")]
	public bool arcticDivingGear;

	[Cpp2IlInjected.FieldOffset(Offset = "0x687")]
	[Cpp2IlInjected.Token(Token = "0x40029E3")]
	public bool coolWhipBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x688")]
	[Cpp2IlInjected.Token(Token = "0x40029E4")]
	public bool wearsRobe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x689")]
	[Cpp2IlInjected.Token(Token = "0x40029E5")]
	public bool minecartLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68A")]
	[Cpp2IlInjected.Token(Token = "0x40029E6")]
	public bool onWrongGround;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68B")]
	[Cpp2IlInjected.Token(Token = "0x40029E7")]
	public bool onTrack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68C")]
	[Cpp2IlInjected.Token(Token = "0x40029E8")]
	public int cartRampTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x690")]
	[Cpp2IlInjected.Token(Token = "0x40029E9")]
	public bool cartFlip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x694")]
	[Cpp2IlInjected.Token(Token = "0x40029EA")]
	public float trackBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x698")]
	[Cpp2IlInjected.Token(Token = "0x40029EB")]
	public Vector2 lastBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A0")]
	[Cpp2IlInjected.Token(Token = "0x40029EC")]
	public Mount mount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A4")]
	[Cpp2IlInjected.Token(Token = "0x40029ED")]
	public bool blackCat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A5")]
	[Cpp2IlInjected.Token(Token = "0x40029EE")]
	public bool spider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A6")]
	[Cpp2IlInjected.Token(Token = "0x40029EF")]
	public bool squashling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A7")]
	[Cpp2IlInjected.Token(Token = "0x40029F0")]
	public bool petFlagDD2Gato;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A8")]
	[Cpp2IlInjected.Token(Token = "0x40029F1")]
	public bool petFlagDD2Ghost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6A9")]
	[Cpp2IlInjected.Token(Token = "0x40029F2")]
	public bool petFlagDD2Dragon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6AA")]
	[Cpp2IlInjected.Token(Token = "0x40029F3")]
	public bool petFlagUpbeatStar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6AB")]
	[Cpp2IlInjected.Token(Token = "0x40029F4")]
	public bool petFlagSugarGlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6AC")]
	[Cpp2IlInjected.Token(Token = "0x40029F5")]
	public bool petFlagBabyShark;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6AD")]
	[Cpp2IlInjected.Token(Token = "0x40029F6")]
	public bool petFlagLilHarpy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6AE")]
	[Cpp2IlInjected.Token(Token = "0x40029F7")]
	public bool petFlagFennecFox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6AF")]
	[Cpp2IlInjected.Token(Token = "0x40029F8")]
	public bool petFlagGlitteryButterfly;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B0")]
	[Cpp2IlInjected.Token(Token = "0x40029F9")]
	public bool petFlagBabyImp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B1")]
	[Cpp2IlInjected.Token(Token = "0x40029FA")]
	public bool petFlagBabyRedPanda;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B2")]
	[Cpp2IlInjected.Token(Token = "0x40029FB")]
	public bool petFlagPlantero;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B3")]
	[Cpp2IlInjected.Token(Token = "0x40029FC")]
	public bool petFlagDynamiteKitten;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B4")]
	[Cpp2IlInjected.Token(Token = "0x40029FD")]
	public bool petFlagBabyWerewolf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B5")]
	[Cpp2IlInjected.Token(Token = "0x40029FE")]
	public bool petFlagShadowMimic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B6")]
	[Cpp2IlInjected.Token(Token = "0x40029FF")]
	public bool petFlagVoltBunny;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B7")]
	[Cpp2IlInjected.Token(Token = "0x4002A00")]
	public bool petFlagKingSlimePet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B8")]
	[Cpp2IlInjected.Token(Token = "0x4002A01")]
	public bool petFlagEyeOfCthulhuPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6B9")]
	[Cpp2IlInjected.Token(Token = "0x4002A02")]
	public bool petFlagEaterOfWorldsPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6BA")]
	[Cpp2IlInjected.Token(Token = "0x4002A03")]
	public bool petFlagBrainOfCthulhuPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6BB")]
	[Cpp2IlInjected.Token(Token = "0x4002A04")]
	public bool petFlagSkeletronPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6BC")]
	[Cpp2IlInjected.Token(Token = "0x4002A05")]
	public bool petFlagQueenBeePet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6BD")]
	[Cpp2IlInjected.Token(Token = "0x4002A06")]
	public bool petFlagDestroyerPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6BE")]
	[Cpp2IlInjected.Token(Token = "0x4002A07")]
	public bool petFlagTwinsPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6BF")]
	[Cpp2IlInjected.Token(Token = "0x4002A08")]
	public bool petFlagSkeletronPrimePet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C0")]
	[Cpp2IlInjected.Token(Token = "0x4002A09")]
	public bool petFlagPlanteraPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C1")]
	[Cpp2IlInjected.Token(Token = "0x4002A0A")]
	public bool petFlagGolemPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C2")]
	[Cpp2IlInjected.Token(Token = "0x4002A0B")]
	public bool petFlagDukeFishronPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C3")]
	[Cpp2IlInjected.Token(Token = "0x4002A0C")]
	public bool petFlagLunaticCultistPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C4")]
	[Cpp2IlInjected.Token(Token = "0x4002A0D")]
	public bool petFlagMoonLordPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C5")]
	[Cpp2IlInjected.Token(Token = "0x4002A0E")]
	public bool petFlagFairyQueenPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C6")]
	[Cpp2IlInjected.Token(Token = "0x4002A0F")]
	public bool petFlagPumpkingPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C7")]
	[Cpp2IlInjected.Token(Token = "0x4002A10")]
	public bool petFlagEverscreamPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C8")]
	[Cpp2IlInjected.Token(Token = "0x4002A11")]
	public bool petFlagIceQueenPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C9")]
	[Cpp2IlInjected.Token(Token = "0x4002A12")]
	public bool petFlagMartianPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6CA")]
	[Cpp2IlInjected.Token(Token = "0x4002A13")]
	public bool petFlagDD2OgrePet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6CB")]
	[Cpp2IlInjected.Token(Token = "0x4002A14")]
	public bool petFlagDD2BetsyPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6CC")]
	[Cpp2IlInjected.Token(Token = "0x4002A15")]
	public bool petFlagQueenSlimePet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6CD")]
	[Cpp2IlInjected.Token(Token = "0x4002A16")]
	public bool petFlagBerniePet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6CE")]
	[Cpp2IlInjected.Token(Token = "0x4002A17")]
	public bool petFlagGlommerPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6CF")]
	[Cpp2IlInjected.Token(Token = "0x4002A18")]
	public bool petFlagDeerclopsPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D0")]
	[Cpp2IlInjected.Token(Token = "0x4002A19")]
	public bool petFlagPigPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D1")]
	[Cpp2IlInjected.Token(Token = "0x4002A1A")]
	public bool petFlagChesterPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D2")]
	[Cpp2IlInjected.Token(Token = "0x4002A1B")]
	public bool petFlagJunimoPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D3")]
	[Cpp2IlInjected.Token(Token = "0x4002A1C")]
	public bool petFlagBlueChickenPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D4")]
	[Cpp2IlInjected.Token(Token = "0x4002A1D")]
	public bool petFlagSpiffo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D5")]
	[Cpp2IlInjected.Token(Token = "0x4002A1E")]
	public bool petFlagCaveling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D6")]
	[Cpp2IlInjected.Token(Token = "0x4002A1F")]
	public bool petFlagDirtiestBlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D7")]
	[Cpp2IlInjected.Token(Token = "0x4002A20")]
	public bool companionCube;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D8")]
	[Cpp2IlInjected.Token(Token = "0x4002A21")]
	public bool babyFaceMonster;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D9")]
	[Cpp2IlInjected.Token(Token = "0x4002A22")]
	public bool magicCuffs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6DA")]
	[Cpp2IlInjected.Token(Token = "0x4002A23")]
	public bool coldDash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6DB")]
	[Cpp2IlInjected.Token(Token = "0x4002A24")]
	public bool sailDash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6DC")]
	[Cpp2IlInjected.Token(Token = "0x4002A25")]
	public bool desertDash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6DD")]
	[Cpp2IlInjected.Token(Token = "0x4002A26")]
	public bool desertBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6DE")]
	[Cpp2IlInjected.Token(Token = "0x4002A27")]
	public bool eyeSpring;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6DF")]
	[Cpp2IlInjected.Token(Token = "0x4002A28")]
	public bool snowman;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E0")]
	[Cpp2IlInjected.Token(Token = "0x4002A29")]
	public bool scope;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E1")]
	[Cpp2IlInjected.Token(Token = "0x4002A2A")]
	public bool dino;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E2")]
	[Cpp2IlInjected.Token(Token = "0x4002A2B")]
	public bool skeletron;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E3")]
	[Cpp2IlInjected.Token(Token = "0x4002A2C")]
	public bool hornet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E4")]
	[Cpp2IlInjected.Token(Token = "0x4002A2D")]
	public bool zephyrfish;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E5")]
	[Cpp2IlInjected.Token(Token = "0x4002A2E")]
	public bool tiki;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E6")]
	[Cpp2IlInjected.Token(Token = "0x4002A2F")]
	public bool parrot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E7")]
	[Cpp2IlInjected.Token(Token = "0x4002A30")]
	public bool truffle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E8")]
	[Cpp2IlInjected.Token(Token = "0x4002A31")]
	public bool sapling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E9")]
	[Cpp2IlInjected.Token(Token = "0x4002A32")]
	public bool cSapling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6EA")]
	[Cpp2IlInjected.Token(Token = "0x4002A33")]
	public bool wisp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6EB")]
	[Cpp2IlInjected.Token(Token = "0x4002A34")]
	public bool lizard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6EC")]
	[Cpp2IlInjected.Token(Token = "0x4002A35")]
	public bool archery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6ED")]
	[Cpp2IlInjected.Token(Token = "0x4002A36")]
	public bool poisoned;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6EE")]
	[Cpp2IlInjected.Token(Token = "0x4002A37")]
	public bool venom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6EF")]
	[Cpp2IlInjected.Token(Token = "0x4002A38")]
	public bool blind;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F0")]
	[Cpp2IlInjected.Token(Token = "0x4002A39")]
	public bool blackout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F1")]
	[Cpp2IlInjected.Token(Token = "0x4002A3A")]
	public bool headcovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F2")]
	[Cpp2IlInjected.Token(Token = "0x4002A3B")]
	public bool frostBurn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F3")]
	[Cpp2IlInjected.Token(Token = "0x4002A3C")]
	public bool onFrostBurn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F4")]
	[Cpp2IlInjected.Token(Token = "0x4002A3D")]
	public bool onFrostBurn2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F5")]
	[Cpp2IlInjected.Token(Token = "0x4002A3E")]
	public bool burned;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F6")]
	[Cpp2IlInjected.Token(Token = "0x4002A3F")]
	public bool shimmering;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6F8")]
	[Cpp2IlInjected.Token(Token = "0x4002A40")]
	public int timeShimmering;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6FC")]
	[Cpp2IlInjected.Token(Token = "0x4002A41")]
	public float shimmerTransparency;

	[Cpp2IlInjected.FieldOffset(Offset = "0x700")]
	[Cpp2IlInjected.Token(Token = "0x4002A42")]
	public ShimmerUnstuckHelper shimmerUnstuckHelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x708")]
	[Cpp2IlInjected.Token(Token = "0x4002A43")]
	public bool suffocating;

	[Cpp2IlInjected.FieldOffset(Offset = "0x709")]
	[Cpp2IlInjected.Token(Token = "0x4002A44")]
	public byte suffocateDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70A")]
	[Cpp2IlInjected.Token(Token = "0x4002A45")]
	public bool dripping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70B")]
	[Cpp2IlInjected.Token(Token = "0x4002A46")]
	public bool drippingSlime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70C")]
	[Cpp2IlInjected.Token(Token = "0x4002A47")]
	public bool drippingSparkleSlime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70D")]
	[Cpp2IlInjected.Token(Token = "0x4002A48")]
	public bool onFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70E")]
	[Cpp2IlInjected.Token(Token = "0x4002A49")]
	public bool onFire2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70F")]
	[Cpp2IlInjected.Token(Token = "0x4002A4A")]
	public bool onFire3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x710")]
	[Cpp2IlInjected.Token(Token = "0x4002A4B")]
	public bool noItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x711")]
	[Cpp2IlInjected.Token(Token = "0x4002A4C")]
	public bool cursed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x712")]
	[Cpp2IlInjected.Token(Token = "0x4002A4D")]
	public bool hungry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x713")]
	[Cpp2IlInjected.Token(Token = "0x4002A4E")]
	public bool starving;

	[Cpp2IlInjected.FieldOffset(Offset = "0x714")]
	[Cpp2IlInjected.Token(Token = "0x4002A4F")]
	public bool heartyMeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x715")]
	[Cpp2IlInjected.Token(Token = "0x4002A50")]
	public bool windPushed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x716")]
	[Cpp2IlInjected.Token(Token = "0x4002A51")]
	public bool wereWolf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x717")]
	[Cpp2IlInjected.Token(Token = "0x4002A52")]
	public bool wolfAcc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x718")]
	[Cpp2IlInjected.Token(Token = "0x4002A53")]
	public bool hideMerman;

	[Cpp2IlInjected.FieldOffset(Offset = "0x719")]
	[Cpp2IlInjected.Token(Token = "0x4002A54")]
	public bool hideWolf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71A")]
	[Cpp2IlInjected.Token(Token = "0x4002A55")]
	public bool forceMerman;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71B")]
	[Cpp2IlInjected.Token(Token = "0x4002A56")]
	public bool forceWerewolf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71C")]
	[Cpp2IlInjected.Token(Token = "0x4002A57")]
	public bool rulerGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71D")]
	[Cpp2IlInjected.Token(Token = "0x4002A58")]
	public bool rulerLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71E")]
	[Cpp2IlInjected.Token(Token = "0x4002A59")]
	public bool bleed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x71F")]
	[Cpp2IlInjected.Token(Token = "0x4002A5A")]
	public bool confused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x720")]
	[Cpp2IlInjected.Token(Token = "0x4002A5B")]
	public bool accMerman;

	[Cpp2IlInjected.FieldOffset(Offset = "0x721")]
	[Cpp2IlInjected.Token(Token = "0x4002A5C")]
	public bool merman;

	[Cpp2IlInjected.FieldOffset(Offset = "0x722")]
	[Cpp2IlInjected.Token(Token = "0x4002A5D")]
	public bool trident;

	[Cpp2IlInjected.FieldOffset(Offset = "0x723")]
	[Cpp2IlInjected.Token(Token = "0x4002A5E")]
	public bool brokenArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x724")]
	[Cpp2IlInjected.Token(Token = "0x4002A5F")]
	public bool silence;

	[Cpp2IlInjected.FieldOffset(Offset = "0x725")]
	[Cpp2IlInjected.Token(Token = "0x4002A60")]
	public bool slow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x726")]
	[Cpp2IlInjected.Token(Token = "0x4002A61")]
	public bool gross;

	[Cpp2IlInjected.FieldOffset(Offset = "0x727")]
	[Cpp2IlInjected.Token(Token = "0x4002A62")]
	public bool tongued;

	[Cpp2IlInjected.FieldOffset(Offset = "0x728")]
	[Cpp2IlInjected.Token(Token = "0x4002A63")]
	public bool kbGlove;

	[Cpp2IlInjected.FieldOffset(Offset = "0x729")]
	[Cpp2IlInjected.Token(Token = "0x4002A64")]
	public bool autoReuseGlove;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72A")]
	[Cpp2IlInjected.Token(Token = "0x4002A65")]
	public bool meleeScaleGlove;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72B")]
	[Cpp2IlInjected.Token(Token = "0x4002A66")]
	public bool kbBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x72C")]
	[Cpp2IlInjected.Token(Token = "0x4002A67")]
	public bool remoteVisionForDrone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x730")]
	[Cpp2IlInjected.Token(Token = "0x4002A68")]
	public Item starCloakItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x734")]
	[Cpp2IlInjected.Token(Token = "0x4002A69")]
	public Item starCloakItem_manaCloakOverrideItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x738")]
	[Cpp2IlInjected.Token(Token = "0x4002A6A")]
	public Item starCloakItem_starVeilOverrideItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x73C")]
	[Cpp2IlInjected.Token(Token = "0x4002A6B")]
	public Item starCloakItem_beeCloakOverrideItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x740")]
	[Cpp2IlInjected.Token(Token = "0x4002A6C")]
	public bool longInvince;

	[Cpp2IlInjected.FieldOffset(Offset = "0x741")]
	[Cpp2IlInjected.Token(Token = "0x4002A6D")]
	public bool pStone;

	[Cpp2IlInjected.Token(Token = "0x4002A6E")]
	public static readonly float PhilosopherStoneDurationMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x742")]
	[Cpp2IlInjected.Token(Token = "0x4002A6F")]
	public bool manaFlower;

	[Cpp2IlInjected.FieldOffset(Offset = "0x743")]
	[Cpp2IlInjected.Token(Token = "0x4002A70")]
	public bool moonLeech;

	[Cpp2IlInjected.FieldOffset(Offset = "0x744")]
	[Cpp2IlInjected.Token(Token = "0x4002A71")]
	public bool vortexDebuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x745")]
	[Cpp2IlInjected.Token(Token = "0x4002A72")]
	public bool trapDebuffSource;

	[Cpp2IlInjected.FieldOffset(Offset = "0x746")]
	[Cpp2IlInjected.Token(Token = "0x4002A73")]
	public bool witheredArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x747")]
	[Cpp2IlInjected.Token(Token = "0x4002A74")]
	public bool witheredWeapon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x748")]
	[Cpp2IlInjected.Token(Token = "0x4002A75")]
	public bool slowOgreSpit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x749")]
	[Cpp2IlInjected.Token(Token = "0x4002A76")]
	public bool parryDamageBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74A")]
	[Cpp2IlInjected.Token(Token = "0x4002A77")]
	public bool ballistaPanic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74B")]
	[Cpp2IlInjected.Token(Token = "0x4002A78")]
	public bool JustDroppedAnItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74C")]
	[Cpp2IlInjected.Token(Token = "0x4002A79")]
	public int meleeCrit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x750")]
	[Cpp2IlInjected.Token(Token = "0x4002A7A")]
	public int magicCrit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x754")]
	[Cpp2IlInjected.Token(Token = "0x4002A7B")]
	public int rangedCrit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x758")]
	[Cpp2IlInjected.Token(Token = "0x4002A7C")]
	public float meleeDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x75C")]
	[Cpp2IlInjected.Token(Token = "0x4002A7D")]
	public float magicDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x760")]
	[Cpp2IlInjected.Token(Token = "0x4002A7E")]
	public float rangedDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x764")]
	[Cpp2IlInjected.Token(Token = "0x4002A7F")]
	public float rangedMultDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x768")]
	[Cpp2IlInjected.Token(Token = "0x4002A80")]
	public float arrowDamageAdditiveStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x76C")]
	[Cpp2IlInjected.Token(Token = "0x4002A81")]
	public float arrowDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x770")]
	[Cpp2IlInjected.Token(Token = "0x4002A82")]
	public float bulletDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x774")]
	[Cpp2IlInjected.Token(Token = "0x4002A83")]
	public float rocketDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x778")]
	[Cpp2IlInjected.Token(Token = "0x4002A84")]
	public float minionDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x77C")]
	[Cpp2IlInjected.Token(Token = "0x4002A85")]
	public float minionKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x780")]
	[Cpp2IlInjected.Token(Token = "0x4002A86")]
	public float meleeSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x784")]
	[Cpp2IlInjected.Token(Token = "0x4002A87")]
	public float summonerWeaponSpeedBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x788")]
	[Cpp2IlInjected.Token(Token = "0x4002A88")]
	public float moveSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78C")]
	[Cpp2IlInjected.Token(Token = "0x4002A89")]
	public float pickSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x790")]
	[Cpp2IlInjected.Token(Token = "0x4002A8A")]
	public float wallSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x794")]
	[Cpp2IlInjected.Token(Token = "0x4002A8B")]
	public float tileSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x798")]
	[Cpp2IlInjected.Token(Token = "0x4002A8C")]
	public bool autoPaint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x799")]
	[Cpp2IlInjected.Token(Token = "0x4002A8D")]
	public bool autoActuator;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79C")]
	[Cpp2IlInjected.Token(Token = "0x4002A8E")]
	public int SpawnX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7A0")]
	[Cpp2IlInjected.Token(Token = "0x4002A8F")]
	public int SpawnY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7A4")]
	[Cpp2IlInjected.Token(Token = "0x4002A90")]
	public Vector2? PotionOfReturnOriginalUsePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7B0")]
	[Cpp2IlInjected.Token(Token = "0x4002A91")]
	public Vector2? PotionOfReturnHomePosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7BC")]
	[Cpp2IlInjected.Token(Token = "0x4002A92")]
	public int[] spX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C0")]
	[Cpp2IlInjected.Token(Token = "0x4002A93")]
	public int[] spY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C4")]
	[Cpp2IlInjected.Token(Token = "0x4002A94")]
	public string[] spN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C8")]
	[Cpp2IlInjected.Token(Token = "0x4002A95")]
	public int[] spI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7CC")]
	[Cpp2IlInjected.Token(Token = "0x4002A96")]
	public int lastTileRangeX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7D0")]
	[Cpp2IlInjected.Token(Token = "0x4002A97")]
	public int lastTileRangeY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7D4")]
	[Cpp2IlInjected.Token(Token = "0x4002A98")]
	public float gravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7D8")]
	[Cpp2IlInjected.Token(Token = "0x4002A99")]
	public float maxFallSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7DC")]
	[Cpp2IlInjected.Token(Token = "0x4002A9A")]
	public float maxRunSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E0")]
	[Cpp2IlInjected.Token(Token = "0x4002A9B")]
	public float runAcceleration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E4")]
	[Cpp2IlInjected.Token(Token = "0x4002A9C")]
	public float runSlowdown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E8")]
	[Cpp2IlInjected.Token(Token = "0x4002A9D")]
	public int TotalRunTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7EC")]
	[Cpp2IlInjected.Token(Token = "0x4002A9E")]
	public bool adjWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7ED")]
	[Cpp2IlInjected.Token(Token = "0x4002A9F")]
	public bool adjHoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7EE")]
	[Cpp2IlInjected.Token(Token = "0x4002AA0")]
	public bool adjLava;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7EF")]
	[Cpp2IlInjected.Token(Token = "0x4002AA1")]
	public bool oldAdjWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7F0")]
	[Cpp2IlInjected.Token(Token = "0x4002AA2")]
	public bool oldAdjHoney;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7F1")]
	[Cpp2IlInjected.Token(Token = "0x4002AA3")]
	public bool oldAdjLava;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7F4")]
	[Cpp2IlInjected.Token(Token = "0x4002AA4")]
	public bool[] adjTile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7F8")]
	[Cpp2IlInjected.Token(Token = "0x4002AA5")]
	public bool[] oldAdjTile;

	[Cpp2IlInjected.Token(Token = "0x4002AA6")]
	private static float itemGrabSpeed;

	[Cpp2IlInjected.Token(Token = "0x4002AA7")]
	private static float itemGrabSpeedMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7FC")]
	[Cpp2IlInjected.Token(Token = "0x4002AA8")]
	public byte hairDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7FD")]
	[Cpp2IlInjected.Token(Token = "0x4002AA9")]
	public Color hairDyeColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x804")]
	[Cpp2IlInjected.Token(Token = "0x4002AAA")]
	public float hairDyeVar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x808")]
	[Cpp2IlInjected.Token(Token = "0x4002AAB")]
	public int skinDyePacked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80C")]
	[Cpp2IlInjected.Token(Token = "0x4002AAC")]
	public Color hairColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x810")]
	[Cpp2IlInjected.Token(Token = "0x4002AAD")]
	public Color skinColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x814")]
	[Cpp2IlInjected.Token(Token = "0x4002AAE")]
	public Color eyeColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x818")]
	[Cpp2IlInjected.Token(Token = "0x4002AAF")]
	public Color shirtColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81C")]
	[Cpp2IlInjected.Token(Token = "0x4002AB0")]
	public Color underShirtColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x820")]
	[Cpp2IlInjected.Token(Token = "0x4002AB1")]
	public Color pantsColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x824")]
	[Cpp2IlInjected.Token(Token = "0x4002AB2")]
	public Color shoeColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x828")]
	[Cpp2IlInjected.Token(Token = "0x4002AB3")]
	public int hair;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82C")]
	[Cpp2IlInjected.Token(Token = "0x4002AB4")]
	public bool hostile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x830")]
	[Cpp2IlInjected.Token(Token = "0x4002AB5")]
	public SoundPlaySet hermesStepSound;

	[Cpp2IlInjected.FieldOffset(Offset = "0x834")]
	[Cpp2IlInjected.Token(Token = "0x4002AB6")]
	public Vector2 instantMovementAccumulatedThisFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x83C")]
	[Cpp2IlInjected.Token(Token = "0x4002AB7")]
	public int accCompass;

	[Cpp2IlInjected.FieldOffset(Offset = "0x840")]
	[Cpp2IlInjected.Token(Token = "0x4002AB8")]
	public int accWatch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x844")]
	[Cpp2IlInjected.Token(Token = "0x4002AB9")]
	public int accDepthMeter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x848")]
	[Cpp2IlInjected.Token(Token = "0x4002ABA")]
	public bool accFishFinder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x849")]
	[Cpp2IlInjected.Token(Token = "0x4002ABB")]
	public bool accWeatherRadio;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84A")]
	[Cpp2IlInjected.Token(Token = "0x4002ABC")]
	public bool accJarOfSouls;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84B")]
	[Cpp2IlInjected.Token(Token = "0x4002ABD")]
	public bool accCalendar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84C")]
	[Cpp2IlInjected.Token(Token = "0x4002ABE")]
	public int lastCreatureHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x850")]
	[Cpp2IlInjected.Token(Token = "0x4002ABF")]
	public bool accThirdEye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x851")]
	[Cpp2IlInjected.Token(Token = "0x4002AC0")]
	public byte accThirdEyeCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x852")]
	[Cpp2IlInjected.Token(Token = "0x4002AC1")]
	public byte accThirdEyeNumber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x853")]
	[Cpp2IlInjected.Token(Token = "0x4002AC2")]
	public bool accStopwatch;

	[Cpp2IlInjected.FieldOffset(Offset = "0x854")]
	[Cpp2IlInjected.Token(Token = "0x4002AC3")]
	public bool accOreFinder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x855")]
	[Cpp2IlInjected.Token(Token = "0x4002AC4")]
	public bool accCritterGuide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x856")]
	[Cpp2IlInjected.Token(Token = "0x4002AC5")]
	public byte accCritterGuideCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x857")]
	[Cpp2IlInjected.Token(Token = "0x4002AC6")]
	public byte accCritterGuideNumber;

	[Cpp2IlInjected.FieldOffset(Offset = "0x858")]
	[Cpp2IlInjected.Token(Token = "0x4002AC7")]
	public bool accDreamCatcher;

	[Cpp2IlInjected.FieldOffset(Offset = "0x859")]
	[Cpp2IlInjected.Token(Token = "0x4002AC8")]
	public bool hasFootball;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85A")]
	[Cpp2IlInjected.Token(Token = "0x4002AC9")]
	public bool drawingFootball;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85B")]
	[Cpp2IlInjected.Token(Token = "0x4002ACA")]
	public bool ActuationRodLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85C")]
	[Cpp2IlInjected.Token(Token = "0x4002ACB")]
	public bool ActuationRodLockSetting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x85D")]
	[Cpp2IlInjected.Token(Token = "0x4002ACC")]
	public bool InfoAccMechShowWires;

	[Cpp2IlInjected.FieldOffset(Offset = "0x860")]
	[Cpp2IlInjected.Token(Token = "0x4002ACD")]
	public DateTime dpsStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x868")]
	[Cpp2IlInjected.Token(Token = "0x4002ACE")]
	public DateTime dpsEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x870")]
	[Cpp2IlInjected.Token(Token = "0x4002ACF")]
	public DateTime dpsLastHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x878")]
	[Cpp2IlInjected.Token(Token = "0x4002AD0")]
	public int dpsDamage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x87C")]
	[Cpp2IlInjected.Token(Token = "0x4002AD1")]
	public bool dpsStarted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x880")]
	[Cpp2IlInjected.Token(Token = "0x4002AD2")]
	public string displayedFishingInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x884")]
	[Cpp2IlInjected.Token(Token = "0x4002AD3")]
	public bool discountEquipped;

	[Cpp2IlInjected.FieldOffset(Offset = "0x885")]
	[Cpp2IlInjected.Token(Token = "0x4002AD4")]
	public bool discountAvailable;

	[Cpp2IlInjected.FieldOffset(Offset = "0x886")]
	[Cpp2IlInjected.Token(Token = "0x4002AD5")]
	public bool hasLuckyCoin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x888")]
	[Cpp2IlInjected.Token(Token = "0x4002AD6")]
	public Item boneGloveItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88C")]
	[Cpp2IlInjected.Token(Token = "0x4002AD7")]
	public bool goldRing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88D")]
	[Cpp2IlInjected.Token(Token = "0x4002AD8")]
	public bool accDivingHelm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88E")]
	[Cpp2IlInjected.Token(Token = "0x4002AD9")]
	public bool accFlipper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88F")]
	[Cpp2IlInjected.Token(Token = "0x4002ADA")]
	public bool hasLuck_LuckyCoin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x890")]
	[Cpp2IlInjected.Token(Token = "0x4002ADB")]
	public bool hasLuck_LuckyHorseshoe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x894")]
	[Cpp2IlInjected.Token(Token = "0x4002ADC")]
	public int doubleJumpsConsumed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x898")]
	[Cpp2IlInjected.Token(Token = "0x4002ADD")]
	public bool hasJumpOption_Cloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x899")]
	[Cpp2IlInjected.Token(Token = "0x4002ADE")]
	public bool canJumpAgain_Cloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89A")]
	[Cpp2IlInjected.Token(Token = "0x4002ADF")]
	public bool isPerformingJump_Cloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89B")]
	[Cpp2IlInjected.Token(Token = "0x4002AE0")]
	public bool hasJumpOption_Sandstorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89C")]
	[Cpp2IlInjected.Token(Token = "0x4002AE1")]
	public bool canJumpAgain_Sandstorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89D")]
	[Cpp2IlInjected.Token(Token = "0x4002AE2")]
	public bool isPerformingJump_Sandstorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89E")]
	[Cpp2IlInjected.Token(Token = "0x4002AE3")]
	public bool hasJumpOption_Blizzard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x89F")]
	[Cpp2IlInjected.Token(Token = "0x4002AE4")]
	public bool canJumpAgain_Blizzard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A0")]
	[Cpp2IlInjected.Token(Token = "0x4002AE5")]
	public bool isPerformingJump_Blizzard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A1")]
	[Cpp2IlInjected.Token(Token = "0x4002AE6")]
	public bool hasJumpOption_Fart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A2")]
	[Cpp2IlInjected.Token(Token = "0x4002AE7")]
	public bool canJumpAgain_Fart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A3")]
	[Cpp2IlInjected.Token(Token = "0x4002AE8")]
	public bool isPerformingJump_Fart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A4")]
	[Cpp2IlInjected.Token(Token = "0x4002AE9")]
	public bool hasJumpOption_Sail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A5")]
	[Cpp2IlInjected.Token(Token = "0x4002AEA")]
	public bool canJumpAgain_Sail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A6")]
	[Cpp2IlInjected.Token(Token = "0x4002AEB")]
	public bool isPerformingJump_Sail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A7")]
	[Cpp2IlInjected.Token(Token = "0x4002AEC")]
	public bool hasJumpOption_Unicorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A8")]
	[Cpp2IlInjected.Token(Token = "0x4002AED")]
	public bool canJumpAgain_Unicorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8A9")]
	[Cpp2IlInjected.Token(Token = "0x4002AEE")]
	public bool isPerformingJump_Unicorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8AA")]
	[Cpp2IlInjected.Token(Token = "0x4002AEF")]
	public bool hasJumpOption_Santank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8AB")]
	[Cpp2IlInjected.Token(Token = "0x4002AF0")]
	public bool canJumpAgain_Santank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8AC")]
	[Cpp2IlInjected.Token(Token = "0x4002AF1")]
	public bool isPerformingJump_Santank;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8AD")]
	[Cpp2IlInjected.Token(Token = "0x4002AF2")]
	public bool hasJumpOption_WallOfFleshGoat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8AE")]
	[Cpp2IlInjected.Token(Token = "0x4002AF3")]
	public bool canJumpAgain_WallOfFleshGoat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8AF")]
	[Cpp2IlInjected.Token(Token = "0x4002AF4")]
	public bool isPerformingJump_WallOfFleshGoat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B0")]
	[Cpp2IlInjected.Token(Token = "0x4002AF5")]
	public bool hasJumpOption_Basilisk;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B1")]
	[Cpp2IlInjected.Token(Token = "0x4002AF6")]
	public bool canJumpAgain_Basilisk;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B2")]
	[Cpp2IlInjected.Token(Token = "0x4002AF7")]
	public bool isPerformingJump_Basilisk;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B3")]
	[Cpp2IlInjected.Token(Token = "0x4002AF8")]
	public bool isPerformingPogostickTricks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B4")]
	[Cpp2IlInjected.Token(Token = "0x4002AF9")]
	public bool autoJump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B5")]
	[Cpp2IlInjected.Token(Token = "0x4002AFA")]
	public bool justJumped;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8B8")]
	[Cpp2IlInjected.Token(Token = "0x4002AFB")]
	public float jumpSpeedBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8BC")]
	[Cpp2IlInjected.Token(Token = "0x4002AFC")]
	public int extraFall;

	[Cpp2IlInjected.Token(Token = "0x4002AFD")]
	private const float PixelsPerMeter = 26.24672f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C0")]
	[Cpp2IlInjected.Token(Token = "0x4002AFE")]
	private float FractionalDistanceTraveled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C4")]
	[Cpp2IlInjected.Token(Token = "0x4002AFF")]
	public bool canFloatInWater;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C5")]
	[Cpp2IlInjected.Token(Token = "0x4002B00")]
	public bool hasFloatingTube;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C6")]
	[Cpp2IlInjected.Token(Token = "0x4002B01")]
	public bool frogLegJumpBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C7")]
	[Cpp2IlInjected.Token(Token = "0x4002B02")]
	public bool skyStoneEffects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C8")]
	[Cpp2IlInjected.Token(Token = "0x4002B03")]
	public bool spawnMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8CC")]
	[Cpp2IlInjected.Token(Token = "0x4002B04")]
	public int blockRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D0")]
	[Cpp2IlInjected.Token(Token = "0x4002B05")]
	public int[] grappling;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D4")]
	[Cpp2IlInjected.Token(Token = "0x4002B06")]
	public int grapCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8D8")]
	[Cpp2IlInjected.Token(Token = "0x4002B07")]
	public int rocketTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8DC")]
	[Cpp2IlInjected.Token(Token = "0x4002B08")]
	public int rocketTimeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8E0")]
	[Cpp2IlInjected.Token(Token = "0x4002B09")]
	public int rocketDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8E4")]
	[Cpp2IlInjected.Token(Token = "0x4002B0A")]
	public int rocketDelay2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8E8")]
	[Cpp2IlInjected.Token(Token = "0x4002B0B")]
	public int rocketSoundDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8EC")]
	[Cpp2IlInjected.Token(Token = "0x4002B0C")]
	public bool rocketRelease;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8ED")]
	[Cpp2IlInjected.Token(Token = "0x4002B0D")]
	public bool rocketFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8F0")]
	[Cpp2IlInjected.Token(Token = "0x4002B0E")]
	public int rocketBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8F4")]
	[Cpp2IlInjected.Token(Token = "0x4002B0F")]
	public int vanityRocketBoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8F8")]
	[Cpp2IlInjected.Token(Token = "0x4002B10")]
	public bool canRocket;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8F9")]
	[Cpp2IlInjected.Token(Token = "0x4002B11")]
	public bool jumpBoost;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8FA")]
	[Cpp2IlInjected.Token(Token = "0x4002B12")]
	public bool noFallDmg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8FC")]
	[Cpp2IlInjected.Token(Token = "0x4002B13")]
	public int swimTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x900")]
	[Cpp2IlInjected.Token(Token = "0x4002B14")]
	public bool killGuide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x901")]
	[Cpp2IlInjected.Token(Token = "0x4002B15")]
	public bool killClothier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x904")]
	[Cpp2IlInjected.Token(Token = "0x4002B16")]
	public float equipmentBasedLuckBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x908")]
	[Cpp2IlInjected.Token(Token = "0x4002B17")]
	public float lastEquipmentBasedLuckBonus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90C")]
	[Cpp2IlInjected.Token(Token = "0x4002B18")]
	public bool hasCreditsSceneMusicBox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90D")]
	[Cpp2IlInjected.Token(Token = "0x4002B19")]
	public bool lavaImmune;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90E")]
	[Cpp2IlInjected.Token(Token = "0x4002B1A")]
	public bool gills;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90F")]
	[Cpp2IlInjected.Token(Token = "0x4002B1B")]
	public bool slowFall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x910")]
	[Cpp2IlInjected.Token(Token = "0x4002B1C")]
	public bool findTreasure;

	[Cpp2IlInjected.FieldOffset(Offset = "0x911")]
	[Cpp2IlInjected.Token(Token = "0x4002B1D")]
	public bool biomeSight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x912")]
	[Cpp2IlInjected.Token(Token = "0x4002B1E")]
	public bool invis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x913")]
	[Cpp2IlInjected.Token(Token = "0x4002B1F")]
	public bool detectCreature;

	[Cpp2IlInjected.FieldOffset(Offset = "0x914")]
	[Cpp2IlInjected.Token(Token = "0x4002B20")]
	public bool nightVision;

	[Cpp2IlInjected.FieldOffset(Offset = "0x915")]
	[Cpp2IlInjected.Token(Token = "0x4002B21")]
	public bool enemySpawns;

	[Cpp2IlInjected.FieldOffset(Offset = "0x918")]
	[Cpp2IlInjected.Token(Token = "0x4002B22")]
	public float thorns;

	[Cpp2IlInjected.FieldOffset(Offset = "0x91C")]
	[Cpp2IlInjected.Token(Token = "0x4002B23")]
	public bool turtleArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x91D")]
	[Cpp2IlInjected.Token(Token = "0x4002B24")]
	public bool turtleThorns;

	[Cpp2IlInjected.FieldOffset(Offset = "0x91E")]
	[Cpp2IlInjected.Token(Token = "0x4002B25")]
	public bool cactusThorns;

	[Cpp2IlInjected.FieldOffset(Offset = "0x91F")]
	[Cpp2IlInjected.Token(Token = "0x4002B26")]
	public bool spiderArmor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x920")]
	[Cpp2IlInjected.Token(Token = "0x4002B27")]
	public bool anglerSetSpawnReduction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x921")]
	[Cpp2IlInjected.Token(Token = "0x4002B28")]
	public bool CanSeeInvisibleBlocks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x922")]
	[Cpp2IlInjected.Token(Token = "0x4002B29")]
	public bool setSolar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x923")]
	[Cpp2IlInjected.Token(Token = "0x4002B2A")]
	public bool setVortex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x924")]
	[Cpp2IlInjected.Token(Token = "0x4002B2B")]
	public bool setNebula;

	[Cpp2IlInjected.FieldOffset(Offset = "0x928")]
	[Cpp2IlInjected.Token(Token = "0x4002B2C")]
	public int nebulaCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x92C")]
	[Cpp2IlInjected.Token(Token = "0x4002B2D")]
	public bool setStardust;

	[Cpp2IlInjected.FieldOffset(Offset = "0x92D")]
	[Cpp2IlInjected.Token(Token = "0x4002B2E")]
	public bool setForbidden;

	[Cpp2IlInjected.FieldOffset(Offset = "0x92E")]
	[Cpp2IlInjected.Token(Token = "0x4002B2F")]
	public bool setForbiddenCooldownLocked;

	[Cpp2IlInjected.FieldOffset(Offset = "0x92F")]
	[Cpp2IlInjected.Token(Token = "0x4002B30")]
	public bool setSquireT3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x930")]
	[Cpp2IlInjected.Token(Token = "0x4002B31")]
	public bool setHuntressT3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x931")]
	[Cpp2IlInjected.Token(Token = "0x4002B32")]
	public bool setApprenticeT3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x932")]
	[Cpp2IlInjected.Token(Token = "0x4002B33")]
	public bool setMonkT3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x933")]
	[Cpp2IlInjected.Token(Token = "0x4002B34")]
	public bool setSquireT2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x934")]
	[Cpp2IlInjected.Token(Token = "0x4002B35")]
	public bool setHuntressT2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x935")]
	[Cpp2IlInjected.Token(Token = "0x4002B36")]
	public bool setApprenticeT2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x936")]
	[Cpp2IlInjected.Token(Token = "0x4002B37")]
	public bool setMonkT2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x938")]
	[Cpp2IlInjected.Token(Token = "0x4002B38")]
	public int maxTurrets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x93C")]
	[Cpp2IlInjected.Token(Token = "0x4002B39")]
	public int maxTurretsOld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x940")]
	[Cpp2IlInjected.Token(Token = "0x4002B3A")]
	public bool vortexStealthActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x941")]
	[Cpp2IlInjected.Token(Token = "0x4002B3B")]
	public bool waterWalk;

	[Cpp2IlInjected.FieldOffset(Offset = "0x942")]
	[Cpp2IlInjected.Token(Token = "0x4002B3C")]
	public bool waterWalk2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x944")]
	[Cpp2IlInjected.Token(Token = "0x4002B3D")]
	public int forcedGravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x948")]
	[Cpp2IlInjected.Token(Token = "0x4002B3E")]
	public bool gravControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x949")]
	[Cpp2IlInjected.Token(Token = "0x4002B3F")]
	public bool gravControl2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94C")]
	[Cpp2IlInjected.Token(Token = "0x4002B40")]
	public Item honeyCombItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x950")]
	[Cpp2IlInjected.Token(Token = "0x4002B41")]
	public int wireOperationsCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0x954")]
	[Cpp2IlInjected.Token(Token = "0x4002B42")]
	public int lastChest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x958")]
	[Cpp2IlInjected.Token(Token = "0x4002B43")]
	public TrackedProjectileReference piggyBankProjTracker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96C")]
	[Cpp2IlInjected.Token(Token = "0x4002B44")]
	public List<int> interactableProjectiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x970")]
	[Cpp2IlInjected.Token(Token = "0x4002B45")]
	public TrackedProjectileReference voidLensChest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x984")]
	[Cpp2IlInjected.Token(Token = "0x4002B46")]
	public int chest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x988")]
	[Cpp2IlInjected.Token(Token = "0x4002B47")]
	public int chestX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98C")]
	[Cpp2IlInjected.Token(Token = "0x4002B48")]
	public int chestY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x990")]
	[Cpp2IlInjected.Token(Token = "0x4002B49")]
	public eToHellAndBackStatus ToHellAndBackStatus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x994")]
	[Cpp2IlInjected.Token(Token = "0x4002B4A")]
	public int talkNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x998")]
	[Cpp2IlInjected.Token(Token = "0x4002B4B")]
	public int fallStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99C")]
	[Cpp2IlInjected.Token(Token = "0x4002B4C")]
	public int fallStart2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A0")]
	[Cpp2IlInjected.Token(Token = "0x4002B4D")]
	public int potionDelayTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A4")]
	[Cpp2IlInjected.Token(Token = "0x4002B4E")]
	public int restorationDelayTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A8")]
	[Cpp2IlInjected.Token(Token = "0x4002B4F")]
	public int mushroomDelayTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9AC")]
	[Cpp2IlInjected.Token(Token = "0x4002B50")]
	private bool _batbatCanHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9AD")]
	[Cpp2IlInjected.Token(Token = "0x4002B51")]
	private bool _spawnTentacleSpikes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9AE")]
	[Cpp2IlInjected.Token(Token = "0x4002B52")]
	private bool _spawnBloodButcherer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9AF")]
	[Cpp2IlInjected.Token(Token = "0x4002B53")]
	private bool _spawnVolcanoExplosion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B0")]
	[Cpp2IlInjected.Token(Token = "0x4002B54")]
	private bool _spawnMuramasaCut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B1")]
	[Cpp2IlInjected.Token(Token = "0x4002B55")]
	public bool isPettingAnimal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B2")]
	[Cpp2IlInjected.Token(Token = "0x4002B56")]
	public bool isTheAnimalBeingPetSmall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B4")]
	[Cpp2IlInjected.Token(Token = "0x4002B57")]
	public PlayerSittingHelper sitting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C4")]
	[Cpp2IlInjected.Token(Token = "0x4002B58")]
	public PlayerSleepingHelper sleeping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D8")]
	[Cpp2IlInjected.Token(Token = "0x4002B59")]
	public PlayerEyeHelper eyeHelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E4")]
	[Cpp2IlInjected.Token(Token = "0x4002B5A")]
	public PlayerInteractionAnchor tileEntityAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9F0")]
	[Cpp2IlInjected.Token(Token = "0x4002B5B")]
	public DoorOpeningHelper doorHelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9F8")]
	[Cpp2IlInjected.Token(Token = "0x4002B5C")]
	public ShoppingSettings currentShoppingSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA08")]
	[Cpp2IlInjected.Token(Token = "0x4002B5D")]
	public int cHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0C")]
	[Cpp2IlInjected.Token(Token = "0x4002B5E")]
	public int cBody;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA10")]
	[Cpp2IlInjected.Token(Token = "0x4002B5F")]
	public int cLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA14")]
	[Cpp2IlInjected.Token(Token = "0x4002B60")]
	public int cHandOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA18")]
	[Cpp2IlInjected.Token(Token = "0x4002B61")]
	public int cHandOff;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1C")]
	[Cpp2IlInjected.Token(Token = "0x4002B62")]
	public int cBack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA20")]
	[Cpp2IlInjected.Token(Token = "0x4002B63")]
	public int cFront;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA24")]
	[Cpp2IlInjected.Token(Token = "0x4002B64")]
	public int cShoe;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA28")]
	[Cpp2IlInjected.Token(Token = "0x4002B65")]
	public int cWaist;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA2C")]
	[Cpp2IlInjected.Token(Token = "0x4002B66")]
	public int cShield;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA30")]
	[Cpp2IlInjected.Token(Token = "0x4002B67")]
	public int cNeck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA34")]
	[Cpp2IlInjected.Token(Token = "0x4002B68")]
	public int cFace;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA38")]
	[Cpp2IlInjected.Token(Token = "0x4002B69")]
	public int cFaceHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA3C")]
	[Cpp2IlInjected.Token(Token = "0x4002B6A")]
	public int cFaceFlower;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA40")]
	[Cpp2IlInjected.Token(Token = "0x4002B6B")]
	public int cBalloon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA44")]
	[Cpp2IlInjected.Token(Token = "0x4002B6C")]
	public int cBalloonFront;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA48")]
	[Cpp2IlInjected.Token(Token = "0x4002B6D")]
	public int cWings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4C")]
	[Cpp2IlInjected.Token(Token = "0x4002B6E")]
	public int cCarpet;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA50")]
	[Cpp2IlInjected.Token(Token = "0x4002B6F")]
	public int cFloatingTube;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA54")]
	[Cpp2IlInjected.Token(Token = "0x4002B70")]
	public int cBackpack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA58")]
	[Cpp2IlInjected.Token(Token = "0x4002B71")]
	public int cTail;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA5C")]
	[Cpp2IlInjected.Token(Token = "0x4002B72")]
	public int cShieldFallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA60")]
	[Cpp2IlInjected.Token(Token = "0x4002B73")]
	public int cGrapple;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA64")]
	[Cpp2IlInjected.Token(Token = "0x4002B74")]
	public int cMount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA68")]
	[Cpp2IlInjected.Token(Token = "0x4002B75")]
	public int cMinecart;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA6C")]
	[Cpp2IlInjected.Token(Token = "0x4002B76")]
	public int cPet;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA70")]
	[Cpp2IlInjected.Token(Token = "0x4002B77")]
	public int cLight;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA74")]
	[Cpp2IlInjected.Token(Token = "0x4002B78")]
	public int cYorai;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA78")]
	[Cpp2IlInjected.Token(Token = "0x4002B79")]
	public int cPortableStool;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA7C")]
	[Cpp2IlInjected.Token(Token = "0x4002B7A")]
	public int cUnicornHorn;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA80")]
	[Cpp2IlInjected.Token(Token = "0x4002B7B")]
	public int cAngelHalo;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA84")]
	[Cpp2IlInjected.Token(Token = "0x4002B7C")]
	public int cBeard;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA88")]
	[Cpp2IlInjected.Token(Token = "0x4002B7D")]
	public int cMinion;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8C")]
	[Cpp2IlInjected.Token(Token = "0x4002B7E")]
	public int cLeinShampoo;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA90")]
	[Cpp2IlInjected.Token(Token = "0x4002B7F")]
	public int cFlameWaker;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA94")]
	[Cpp2IlInjected.Token(Token = "0x4002B80")]
	public int[] ownedProjectileCounts;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA98")]
	[Cpp2IlInjected.Token(Token = "0x4002B81")]
	public bool[] npcTypeNoAggro;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9C")]
	[Cpp2IlInjected.Token(Token = "0x4002B82")]
	public int lastPortalColorIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAA0")]
	[Cpp2IlInjected.Token(Token = "0x4002B83")]
	public int _portalPhysicsTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAA4")]
	[Cpp2IlInjected.Token(Token = "0x4002B84")]
	public bool portalPhysicsFlag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAA8")]
	[Cpp2IlInjected.Token(Token = "0x4002B85")]
	public int lastTeleportPylonStyleUsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAAC")]
	[Cpp2IlInjected.Token(Token = "0x4002B86")]
	public float MountFishronSpecialCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAB0")]
	[Cpp2IlInjected.Token(Token = "0x4002B87")]
	public Vector2 MinionRestTargetPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAB8")]
	[Cpp2IlInjected.Token(Token = "0x4002B88")]
	public int MinionAttackTargetNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xABC")]
	[Cpp2IlInjected.Token(Token = "0x4002B89")]
	public List<Point> TouchedTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC0")]
	[Cpp2IlInjected.Token(Token = "0x4002B8A")]
	public int itemAnimation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC4")]
	[Cpp2IlInjected.Token(Token = "0x4002B8B")]
	public int itemAnimationMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC8")]
	[Cpp2IlInjected.Token(Token = "0x4002B8C")]
	public int itemTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xACC")]
	[Cpp2IlInjected.Token(Token = "0x4002B8D")]
	public int itemTimeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAD0")]
	[Cpp2IlInjected.Token(Token = "0x4002B8E")]
	public int toolTime;

	[Cpp2IlInjected.Token(Token = "0x4002B8F")]
	private static Item defaultItem;

	[Cpp2IlInjected.Token(Token = "0x4002B90")]
	public const int SafeItemAnimationTimeForPreventingExploits = 20;

	[Cpp2IlInjected.Token(Token = "0x4002B91")]
	private static List<Point> QuickMinecartPts;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAD4")]
	[Cpp2IlInjected.Token(Token = "0x4002B92")]
	private HashSet<Point> _blackListedTileCoordsForGrappling;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAD8")]
	[Cpp2IlInjected.Token(Token = "0x4002B93")]
	private bool makeStrongBee;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAD9")]
	[Cpp2IlInjected.Token(Token = "0x4002B94")]
	public bool equippedAnyTileRangeAcc;

	[Cpp2IlInjected.FieldOffset(Offset = "0xADA")]
	[Cpp2IlInjected.Token(Token = "0x4002B95")]
	public bool equippedAnyTileSpeedAcc;

	[Cpp2IlInjected.FieldOffset(Offset = "0xADB")]
	[Cpp2IlInjected.Token(Token = "0x4002B96")]
	public bool equippedAnyWallSpeedAcc;

	[Cpp2IlInjected.Token(Token = "0x4002B97")]
	private static List<NPC> _hallucinationCandidates;

	[Cpp2IlInjected.FieldOffset(Offset = "0xADC")]
	[Cpp2IlInjected.Token(Token = "0x4002B98")]
	public bool behindBackWall;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAE0")]
	[Cpp2IlInjected.Token(Token = "0x4002B99")]
	public int _funkytownAchievementCheckCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAE4")]
	[Cpp2IlInjected.Token(Token = "0x4002B9A")]
	private float _stormShaderObstruction;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAE8")]
	[Cpp2IlInjected.Token(Token = "0x4002B9B")]
	private float _shaderObstructionInternalValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAEC")]
	[Cpp2IlInjected.Token(Token = "0x4002B9C")]
	private int graveImmediateTime;

	[Cpp2IlInjected.Token(Token = "0x4002B9D")]
	public static float airLightDecay;

	[Cpp2IlInjected.Token(Token = "0x4002B9E")]
	public static float solidLightDecay;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAF0")]
	[Cpp2IlInjected.Token(Token = "0x4002B9F")]
	private float _deerclopsBlizzardSmoothedEffect;

	[Cpp2IlInjected.Token(Token = "0x4002BA0")]
	public static int[] PetBuffs;

	[Cpp2IlInjected.Token(Token = "0x4002BA1")]
	public const int ChairSittingMaxDistance = 40;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAF4")]
	[Cpp2IlInjected.Token(Token = "0x4002BA2")]
	private int _lastSmartCursorToolStrategy;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAF8")]
	[Cpp2IlInjected.Token(Token = "0x4002BA3")]
	private bool[] nearbyTorch;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAFC")]
	[Cpp2IlInjected.Token(Token = "0x4002BA4")]
	private bool dryCoralTorch;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB00")]
	[Cpp2IlInjected.Token(Token = "0x4002BA5")]
	private int luckyTorchCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB04")]
	[Cpp2IlInjected.Token(Token = "0x4002BA6")]
	private int nearbyTorches;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB08")]
	[Cpp2IlInjected.Token(Token = "0x4002BA7")]
	public float torchLuck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0C")]
	[Cpp2IlInjected.Token(Token = "0x4002BA8")]
	private Vector2 _nextTorchLuckCheckCenter;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB14")]
	[Cpp2IlInjected.Token(Token = "0x4002BA9")]
	public bool happyFunTorchTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB18")]
	[Cpp2IlInjected.Token(Token = "0x4002BAA")]
	private int torchFunTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1C")]
	[Cpp2IlInjected.Token(Token = "0x4002BAB")]
	private int torchGodCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB20")]
	[Cpp2IlInjected.Token(Token = "0x4002BAC")]
	private int numberOfTorchAttacksMade;

	[Cpp2IlInjected.Token(Token = "0x4002BAD")]
	private static int maxTorchAttacks;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB24")]
	[Cpp2IlInjected.Token(Token = "0x4002BAE")]
	private int[] unlitTorchX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB28")]
	[Cpp2IlInjected.Token(Token = "0x4002BAF")]
	private int[] unlitTorchY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB2C")]
	[Cpp2IlInjected.Token(Token = "0x4002BB0")]
	public int ladyBugLuckTimeLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB30")]
	[Cpp2IlInjected.Token(Token = "0x4002BB1")]
	public float luck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB34")]
	[Cpp2IlInjected.Token(Token = "0x4002BB2")]
	public float luckMinimumCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB38")]
	[Cpp2IlInjected.Token(Token = "0x4002BB3")]
	public float luckMaximumCap;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB3C")]
	[Cpp2IlInjected.Token(Token = "0x4002BB4")]
	public float coinLuck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB40")]
	[Cpp2IlInjected.Token(Token = "0x4002BB5")]
	public bool luckNeedsSync;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB44")]
	[Cpp2IlInjected.Token(Token = "0x4002BB6")]
	public int disableVoidBag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB48")]
	[Cpp2IlInjected.Token(Token = "0x4002BB7")]
	private int _quickGrappleCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4C")]
	[Cpp2IlInjected.Token(Token = "0x4002BB8")]
	public PlayerMovementAccsCache movementAbilitiesCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB68")]
	[Cpp2IlInjected.Token(Token = "0x4002BB9")]
	private bool wasScopeActionActive;

	[Cpp2IlInjected.Token(Token = "0x4002BBA")]
	private static bool[] ItemUsesRightFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB6C")]
	[Cpp2IlInjected.Token(Token = "0x4002BBB")]
	public float wingAccRunSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB70")]
	[Cpp2IlInjected.Token(Token = "0x4002BBC")]
	public float wingRunAccelerationMult;

	[Cpp2IlInjected.Token(Token = "0x4002BBD")]
	public const int SHIELD_PARRY_DURATION = 20;

	[Cpp2IlInjected.Token(Token = "0x4002BBE")]
	public const int SHIELD_PARRY_DURATION_DRAWING_TWEAKER = 20;

	[Cpp2IlInjected.Token(Token = "0x4002BBF")]
	public const int SHIELD_PARRY_DAMAGE_BUFF_MULTIPLIER = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB74")]
	[Cpp2IlInjected.Token(Token = "0x4002BC0")]
	public bool hasRaisableShield;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB75")]
	[Cpp2IlInjected.Token(Token = "0x4002BC1")]
	public bool shieldRaised;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB78")]
	[Cpp2IlInjected.Token(Token = "0x4002BC2")]
	public int shieldParryTimeLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB7C")]
	[Cpp2IlInjected.Token(Token = "0x4002BC3")]
	public int shield_parry_cooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB80")]
	[Cpp2IlInjected.Token(Token = "0x4002BC4")]
	private bool _forceForwardCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB84")]
	[Cpp2IlInjected.Token(Token = "0x4002BC5")]
	private Point _inputMouseCoordsForward;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8C")]
	[Cpp2IlInjected.Token(Token = "0x4002BC6")]
	private Point _mainMouseCoordsForward;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB94")]
	[Cpp2IlInjected.Token(Token = "0x4002BC7")]
	private bool _forceSmartSelectCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB98")]
	[Cpp2IlInjected.Token(Token = "0x4002BC8")]
	private Point _inputMouseCoordsSmartSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBA0")]
	[Cpp2IlInjected.Token(Token = "0x4002BC9")]
	private Point _mainMouseCoordsSmartSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBA8")]
	[Cpp2IlInjected.Token(Token = "0x4002BCA")]
	private Point _tileTargetSmartSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBB0")]
	[Cpp2IlInjected.Token(Token = "0x4002BCB")]
	private bool botherWithUnaimedMinecartTracks;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBB4")]
	[Cpp2IlInjected.Token(Token = "0x4002BCC")]
	private List<int> _projectilesToInteractWith;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBB8")]
	[Cpp2IlInjected.Token(Token = "0x4002BCD")]
	private int _lockTileInteractionsTimer;

	[Cpp2IlInjected.Token(Token = "0x4002BCE")]
	private static Item[] costInventory;

	[Cpp2IlInjected.Token(Token = "0x4002BCF")]
	private static Item[] costBankInventory;

	[Cpp2IlInjected.Token(Token = "0x4002BD0")]
	private static Item[] costBank2Inventory;

	[Cpp2IlInjected.Token(Token = "0x4002BD1")]
	private static Item[] costBank3Inventory;

	[Cpp2IlInjected.Token(Token = "0x4002BD2")]
	private static Item[] costBank4Inventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBBC")]
	[Cpp2IlInjected.Token(Token = "0x4002BD3")]
	public int[] hurtCooldowns;

	[Cpp2IlInjected.Token(Token = "0x4002BD4")]
	public static int FlexibleWandRandomSeed;

	[Cpp2IlInjected.Token(Token = "0x4002BD5")]
	public static int FlexibleWandCycleOffset;

	[Cpp2IlInjected.Token(Token = "0x4002BD6")]
	public static Point FlexibleWandLastPosition;

	[Cpp2IlInjected.Token(Token = "0x4002BD7")]
	private static Point[] _tentacleSpikesMax5;

	[Cpp2IlInjected.Token(Token = "0x4002BD8")]
	private static Point[] _bloodButchererMax5;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC0")]
	[Cpp2IlInjected.Token(Token = "0x4002BD9")]
	public int[] meleeNPCHitCooldown;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC4")]
	[Cpp2IlInjected.Token(Token = "0x4002BDA")]
	public float musicDist;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC8")]
	[Cpp2IlInjected.Token(Token = "0x4002BDB")]
	public EquipmentLoadout[] Loadouts;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBCC")]
	[Cpp2IlInjected.Token(Token = "0x4002BDC")]
	public int CurrentLoadoutIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBD0")]
	[Cpp2IlInjected.Token(Token = "0x4002BDD")]
	public SavedPlayerDataWithAnnoyingRules savedPerPlayerFieldsThatArentInThePlayerClass;

	[Cpp2IlInjected.Token(Token = "0x4002BDE")]
	private const int SaveSlotIndex_MouseItem = 0;

	[Cpp2IlInjected.Token(Token = "0x4002BDF")]
	private const int SaveSlotIndex_CreativeSacrifice = 1;

	[Cpp2IlInjected.Token(Token = "0x4002BE0")]
	private const int SaveSlotIndex_GuideItem = 2;

	[Cpp2IlInjected.Token(Token = "0x4002BE1")]
	private const int SaveSlotIndex_TinkererItem = 3;

	[Cpp2IlInjected.Token(Token = "0x4002BE2")]
	private const int SaveSlotIndexCount = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBD4")]
	[Cpp2IlInjected.Token(Token = "0x4002BE3")]
	private Item[] _temporaryItemSlots;

	[Cpp2IlInjected.Token(Token = "0x170004CA")]
	public static int tileRangeX
	{
		[Cpp2IlInjected.Token(Token = "0x6002107")]
		[Cpp2IlInjected.Address(RVA = "0xB7BD80", Offset = "0xB7BD80", VA = "0xB7BD80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002108")]
		[Cpp2IlInjected.Address(RVA = "0xB7BDFC", Offset = "0xB7BDFC", VA = "0xB7BDFC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004CB")]
	public static int tileRangeY
	{
		[Cpp2IlInjected.Token(Token = "0x6002109")]
		[Cpp2IlInjected.Address(RVA = "0xB7BE7C", Offset = "0xB7BE7C", VA = "0xB7BE7C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600210A")]
		[Cpp2IlInjected.Address(RVA = "0xB7BEF8", Offset = "0xB7BEF8", VA = "0xB7BEF8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004CC")]
	public static int tileTargetX
	{
		[Cpp2IlInjected.Token(Token = "0x600210B")]
		[Cpp2IlInjected.Address(RVA = "0xB7BF78", Offset = "0xB7BF78", VA = "0xB7BF78")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600210C")]
		[Cpp2IlInjected.Address(RVA = "0xB7BFF4", Offset = "0xB7BFF4", VA = "0xB7BFF4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004CD")]
	public static int tileTargetY
	{
		[Cpp2IlInjected.Token(Token = "0x600210D")]
		[Cpp2IlInjected.Address(RVA = "0xB7C074", Offset = "0xB7C074", VA = "0xB7C074")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600210E")]
		[Cpp2IlInjected.Address(RVA = "0xB7C0F0", Offset = "0xB7C0F0", VA = "0xB7C0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004CE")]
	public static int jumpHeight
	{
		[Cpp2IlInjected.Token(Token = "0x600210F")]
		[Cpp2IlInjected.Address(RVA = "0xB7C170", Offset = "0xB7C170", VA = "0xB7C170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002110")]
		[Cpp2IlInjected.Address(RVA = "0xB7C1EC", Offset = "0xB7C1EC", VA = "0xB7C1EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004CF")]
	public static float jumpSpeed
	{
		[Cpp2IlInjected.Token(Token = "0x6002111")]
		[Cpp2IlInjected.Address(RVA = "0xB7C26C", Offset = "0xB7C26C", VA = "0xB7C26C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6002112")]
		[Cpp2IlInjected.Address(RVA = "0xB7C2E8", Offset = "0xB7C2E8", VA = "0xB7C2E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D0")]
	public static int BlockInteractionWithProjectiles
	{
		[Cpp2IlInjected.Token(Token = "0x6002113")]
		[Cpp2IlInjected.Address(RVA = "0xB7C37C", Offset = "0xB7C37C", VA = "0xB7C37C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002114")]
		[Cpp2IlInjected.Address(RVA = "0xB7C3F8", Offset = "0xB7C3F8", VA = "0xB7C3F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D1")]
	public static bool lastPound
	{
		[Cpp2IlInjected.Token(Token = "0x6002115")]
		[Cpp2IlInjected.Address(RVA = "0xB7C478", Offset = "0xB7C478", VA = "0xB7C478")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002116")]
		[Cpp2IlInjected.Address(RVA = "0xB7C4F4", Offset = "0xB7C4F4", VA = "0xB7C4F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D2")]
	public static int musicNotes
	{
		[Cpp2IlInjected.Token(Token = "0x6002117")]
		[Cpp2IlInjected.Address(RVA = "0xB7C574", Offset = "0xB7C574", VA = "0xB7C574")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002118")]
		[Cpp2IlInjected.Address(RVA = "0xB7C5F0", Offset = "0xB7C5F0", VA = "0xB7C5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D3")]
	public Vector2 BlehOldPositionFixer
	{
		[Cpp2IlInjected.Token(Token = "0x6002119")]
		[Cpp2IlInjected.Address(RVA = "0xB7C670", Offset = "0xB7C670", VA = "0xB7C670")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D4")]
	public float HeightOffsetVisual
	{
		[Cpp2IlInjected.Token(Token = "0x600211A")]
		[Cpp2IlInjected.Address(RVA = "0xB7C750", Offset = "0xB7C750", VA = "0xB7C750")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D5")]
	public float HeightOffsetHitboxCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600211B")]
		[Cpp2IlInjected.Address(RVA = "0xB7C7A4", Offset = "0xB7C7A4", VA = "0xB7C7A4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D6")]
	public float MountXOffset
	{
		[Cpp2IlInjected.Token(Token = "0x600211C")]
		[Cpp2IlInjected.Address(RVA = "0xB7C80C", Offset = "0xB7C80C", VA = "0xB7C80C")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D7")]
	public int HeightOffsetBoost
	{
		[Cpp2IlInjected.Token(Token = "0x600211D")]
		[Cpp2IlInjected.Address(RVA = "0xB7C84C", Offset = "0xB7C84C", VA = "0xB7C84C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D8")]
	public int HeightMapOffset
	{
		[Cpp2IlInjected.Token(Token = "0x600211E")]
		[Cpp2IlInjected.Address(RVA = "0xB7C87C", Offset = "0xB7C87C", VA = "0xB7C87C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004D9")]
	public Rectangle HitboxForBestiaryNearbyCheck
	{
		[Cpp2IlInjected.Token(Token = "0x600211F")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8AC", Offset = "0xB7C8AC", VA = "0xB7C8AC")]
		get
		{
			return default(Rectangle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004DA")]
	public bool IsStandingStillForSpecialEffects
	{
		[Cpp2IlInjected.Token(Token = "0x6002120")]
		[Cpp2IlInjected.Address(RVA = "0xB7C920", Offset = "0xB7C920", VA = "0xB7C920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004DB")]
	public Vector2 MountedCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6002121")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9FC", Offset = "0xB7C9FC", VA = "0xB7C9FC")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6002122")]
		[Cpp2IlInjected.Address(RVA = "0xB7CA6C", Offset = "0xB7CA6C", VA = "0xB7CA6C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004DC")]
	public bool TileReplacementEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6002126")]
		[Cpp2IlInjected.Address(RVA = "0xB7D24C", Offset = "0xB7D24C", VA = "0xB7D24C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004DD")]
	public override Vector2 VisualPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6002127")]
		[Cpp2IlInjected.Address(RVA = "0xB7D260", Offset = "0xB7D260", VA = "0xB7D260", Slot = "4")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004DE")]
	public bool CCed
	{
		[Cpp2IlInjected.Token(Token = "0x6002128")]
		[Cpp2IlInjected.Address(RVA = "0xB7D31C", Offset = "0xB7D31C", VA = "0xB7D31C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004DF")]
	public float miscCounterNormalized
	{
		[Cpp2IlInjected.Token(Token = "0x600212C")]
		[Cpp2IlInjected.Address(RVA = "0xB7D5D4", Offset = "0xB7D5D4", VA = "0xB7D5D4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E0")]
	public bool Male
	{
		[Cpp2IlInjected.Token(Token = "0x600212D")]
		[Cpp2IlInjected.Address(RVA = "0xB7D5F0", Offset = "0xB7D5F0", VA = "0xB7D5F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600212E")]
		[Cpp2IlInjected.Address(RVA = "0xB7D678", Offset = "0xB7D678", VA = "0xB7D678")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E1")]
	public bool ZoneDungeon
	{
		[Cpp2IlInjected.Token(Token = "0x600212F")]
		[Cpp2IlInjected.Address(RVA = "0xB7D72C", Offset = "0xB7D72C", VA = "0xB7D72C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002130")]
		[Cpp2IlInjected.Address(RVA = "0xB7D740", Offset = "0xB7D740", VA = "0xB7D740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E2")]
	public bool ZoneCorrupt
	{
		[Cpp2IlInjected.Token(Token = "0x6002131")]
		[Cpp2IlInjected.Address(RVA = "0xB7D758", Offset = "0xB7D758", VA = "0xB7D758")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002132")]
		[Cpp2IlInjected.Address(RVA = "0xB7D76C", Offset = "0xB7D76C", VA = "0xB7D76C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E3")]
	public bool ZoneHallow
	{
		[Cpp2IlInjected.Token(Token = "0x6002133")]
		[Cpp2IlInjected.Address(RVA = "0xB7D784", Offset = "0xB7D784", VA = "0xB7D784")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002134")]
		[Cpp2IlInjected.Address(RVA = "0xB7D798", Offset = "0xB7D798", VA = "0xB7D798")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E4")]
	public bool ZoneMeteor
	{
		[Cpp2IlInjected.Token(Token = "0x6002135")]
		[Cpp2IlInjected.Address(RVA = "0xB7D7B0", Offset = "0xB7D7B0", VA = "0xB7D7B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002136")]
		[Cpp2IlInjected.Address(RVA = "0xB7D7C4", Offset = "0xB7D7C4", VA = "0xB7D7C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E5")]
	public bool ZoneJungle
	{
		[Cpp2IlInjected.Token(Token = "0x6002137")]
		[Cpp2IlInjected.Address(RVA = "0xB7D7DC", Offset = "0xB7D7DC", VA = "0xB7D7DC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002138")]
		[Cpp2IlInjected.Address(RVA = "0xB7D7F0", Offset = "0xB7D7F0", VA = "0xB7D7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E6")]
	public bool ZoneSnow
	{
		[Cpp2IlInjected.Token(Token = "0x6002139")]
		[Cpp2IlInjected.Address(RVA = "0xB7D808", Offset = "0xB7D808", VA = "0xB7D808")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600213A")]
		[Cpp2IlInjected.Address(RVA = "0xB7D81C", Offset = "0xB7D81C", VA = "0xB7D81C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E7")]
	public bool ZoneCrimson
	{
		[Cpp2IlInjected.Token(Token = "0x600213B")]
		[Cpp2IlInjected.Address(RVA = "0xB7D834", Offset = "0xB7D834", VA = "0xB7D834")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600213C")]
		[Cpp2IlInjected.Address(RVA = "0xB7D848", Offset = "0xB7D848", VA = "0xB7D848")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E8")]
	public bool ZoneWaterCandle
	{
		[Cpp2IlInjected.Token(Token = "0x600213D")]
		[Cpp2IlInjected.Address(RVA = "0xB7D860", Offset = "0xB7D860", VA = "0xB7D860")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600213E")]
		[Cpp2IlInjected.Address(RVA = "0xB7D874", Offset = "0xB7D874", VA = "0xB7D874")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004E9")]
	public bool ZonePeaceCandle
	{
		[Cpp2IlInjected.Token(Token = "0x600213F")]
		[Cpp2IlInjected.Address(RVA = "0xB7D88C", Offset = "0xB7D88C", VA = "0xB7D88C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002140")]
		[Cpp2IlInjected.Address(RVA = "0xB7D8A0", Offset = "0xB7D8A0", VA = "0xB7D8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004EA")]
	public bool ZoneTowerSolar
	{
		[Cpp2IlInjected.Token(Token = "0x6002141")]
		[Cpp2IlInjected.Address(RVA = "0xB7D8B8", Offset = "0xB7D8B8", VA = "0xB7D8B8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002142")]
		[Cpp2IlInjected.Address(RVA = "0xB7D8CC", Offset = "0xB7D8CC", VA = "0xB7D8CC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004EB")]
	public bool ZoneTowerVortex
	{
		[Cpp2IlInjected.Token(Token = "0x6002143")]
		[Cpp2IlInjected.Address(RVA = "0xB7D8E4", Offset = "0xB7D8E4", VA = "0xB7D8E4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002144")]
		[Cpp2IlInjected.Address(RVA = "0xB7D8F8", Offset = "0xB7D8F8", VA = "0xB7D8F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004EC")]
	public bool ZoneTowerNebula
	{
		[Cpp2IlInjected.Token(Token = "0x6002145")]
		[Cpp2IlInjected.Address(RVA = "0xB7D910", Offset = "0xB7D910", VA = "0xB7D910")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002146")]
		[Cpp2IlInjected.Address(RVA = "0xB7D924", Offset = "0xB7D924", VA = "0xB7D924")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004ED")]
	public bool ZoneTowerStardust
	{
		[Cpp2IlInjected.Token(Token = "0x6002147")]
		[Cpp2IlInjected.Address(RVA = "0xB7D93C", Offset = "0xB7D93C", VA = "0xB7D93C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002148")]
		[Cpp2IlInjected.Address(RVA = "0xB7D950", Offset = "0xB7D950", VA = "0xB7D950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004EE")]
	public bool ZoneDesert
	{
		[Cpp2IlInjected.Token(Token = "0x6002149")]
		[Cpp2IlInjected.Address(RVA = "0xB7D968", Offset = "0xB7D968", VA = "0xB7D968")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600214A")]
		[Cpp2IlInjected.Address(RVA = "0xB7D97C", Offset = "0xB7D97C", VA = "0xB7D97C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004EF")]
	public bool ZoneGlowshroom
	{
		[Cpp2IlInjected.Token(Token = "0x600214B")]
		[Cpp2IlInjected.Address(RVA = "0xB7D994", Offset = "0xB7D994", VA = "0xB7D994")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600214C")]
		[Cpp2IlInjected.Address(RVA = "0xB7D9A8", Offset = "0xB7D9A8", VA = "0xB7D9A8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F0")]
	public bool ZoneUndergroundDesert
	{
		[Cpp2IlInjected.Token(Token = "0x600214D")]
		[Cpp2IlInjected.Address(RVA = "0xB7D9C0", Offset = "0xB7D9C0", VA = "0xB7D9C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600214E")]
		[Cpp2IlInjected.Address(RVA = "0xB7D9D4", Offset = "0xB7D9D4", VA = "0xB7D9D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F1")]
	public bool ZoneSkyHeight
	{
		[Cpp2IlInjected.Token(Token = "0x600214F")]
		[Cpp2IlInjected.Address(RVA = "0xB7D9EC", Offset = "0xB7D9EC", VA = "0xB7D9EC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002150")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA00", Offset = "0xB7DA00", VA = "0xB7DA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F2")]
	public bool ZoneOverworldHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6002151")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA18", Offset = "0xB7DA18", VA = "0xB7DA18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002152")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA2C", Offset = "0xB7DA2C", VA = "0xB7DA2C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F3")]
	public bool ZoneDirtLayerHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6002153")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA44", Offset = "0xB7DA44", VA = "0xB7DA44")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002154")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA58", Offset = "0xB7DA58", VA = "0xB7DA58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F4")]
	public bool ZoneRockLayerHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6002155")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA70", Offset = "0xB7DA70", VA = "0xB7DA70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002156")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA84", Offset = "0xB7DA84", VA = "0xB7DA84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F5")]
	public bool ZoneUnderworldHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6002157")]
		[Cpp2IlInjected.Address(RVA = "0xB7DA9C", Offset = "0xB7DA9C", VA = "0xB7DA9C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002158")]
		[Cpp2IlInjected.Address(RVA = "0xB7DAB0", Offset = "0xB7DAB0", VA = "0xB7DAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F6")]
	public bool ZoneBeach
	{
		[Cpp2IlInjected.Token(Token = "0x6002159")]
		[Cpp2IlInjected.Address(RVA = "0xB7DAC8", Offset = "0xB7DAC8", VA = "0xB7DAC8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600215A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DADC", Offset = "0xB7DADC", VA = "0xB7DADC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F7")]
	public bool ZoneRain
	{
		[Cpp2IlInjected.Token(Token = "0x600215B")]
		[Cpp2IlInjected.Address(RVA = "0xB7DAF4", Offset = "0xB7DAF4", VA = "0xB7DAF4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600215C")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB08", Offset = "0xB7DB08", VA = "0xB7DB08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F8")]
	public bool ZoneSandstorm
	{
		[Cpp2IlInjected.Token(Token = "0x600215D")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB20", Offset = "0xB7DB20", VA = "0xB7DB20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600215E")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB34", Offset = "0xB7DB34", VA = "0xB7DB34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004F9")]
	public bool ZoneOldOneArmy
	{
		[Cpp2IlInjected.Token(Token = "0x600215F")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB4C", Offset = "0xB7DB4C", VA = "0xB7DB4C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002160")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB5C", Offset = "0xB7DB5C", VA = "0xB7DB5C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004FA")]
	public bool ZoneGranite
	{
		[Cpp2IlInjected.Token(Token = "0x6002161")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB70", Offset = "0xB7DB70", VA = "0xB7DB70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002162")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB80", Offset = "0xB7DB80", VA = "0xB7DB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004FB")]
	public bool ZoneMarble
	{
		[Cpp2IlInjected.Token(Token = "0x6002163")]
		[Cpp2IlInjected.Address(RVA = "0xB7DB94", Offset = "0xB7DB94", VA = "0xB7DB94")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002164")]
		[Cpp2IlInjected.Address(RVA = "0xB7DBA4", Offset = "0xB7DBA4", VA = "0xB7DBA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004FC")]
	public bool ZoneHive
	{
		[Cpp2IlInjected.Token(Token = "0x6002165")]
		[Cpp2IlInjected.Address(RVA = "0xB7DBB8", Offset = "0xB7DBB8", VA = "0xB7DBB8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002166")]
		[Cpp2IlInjected.Address(RVA = "0xB7DBC8", Offset = "0xB7DBC8", VA = "0xB7DBC8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004FD")]
	public bool ZoneGemCave
	{
		[Cpp2IlInjected.Token(Token = "0x6002167")]
		[Cpp2IlInjected.Address(RVA = "0xB7DBDC", Offset = "0xB7DBDC", VA = "0xB7DBDC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002168")]
		[Cpp2IlInjected.Address(RVA = "0xB7DBEC", Offset = "0xB7DBEC", VA = "0xB7DBEC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004FE")]
	public bool ZoneLihzhardTemple
	{
		[Cpp2IlInjected.Token(Token = "0x6002169")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC00", Offset = "0xB7DC00", VA = "0xB7DC00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600216A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC10", Offset = "0xB7DC10", VA = "0xB7DC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004FF")]
	public bool ZoneGraveyard
	{
		[Cpp2IlInjected.Token(Token = "0x600216B")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC24", Offset = "0xB7DC24", VA = "0xB7DC24")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600216C")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC34", Offset = "0xB7DC34", VA = "0xB7DC34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000500")]
	public bool ZoneShadowCandle
	{
		[Cpp2IlInjected.Token(Token = "0x600216D")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC48", Offset = "0xB7DC48", VA = "0xB7DC48")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600216E")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC58", Offset = "0xB7DC58", VA = "0xB7DC58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000501")]
	public bool ZoneShimmer
	{
		[Cpp2IlInjected.Token(Token = "0x600216F")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC6C", Offset = "0xB7DC6C", VA = "0xB7DC6C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002170")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC80", Offset = "0xB7DC80", VA = "0xB7DC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000502")]
	public bool ShoppingZone_AnyBiome
	{
		[Cpp2IlInjected.Token(Token = "0x6002171")]
		[Cpp2IlInjected.Address(RVA = "0xB7DC98", Offset = "0xB7DC98", VA = "0xB7DC98")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000503")]
	public bool ShoppingZone_BelowSurface
	{
		[Cpp2IlInjected.Token(Token = "0x6002172")]
		[Cpp2IlInjected.Address(RVA = "0xB7DD94", Offset = "0xB7DD94", VA = "0xB7DD94")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000504")]
	public bool ShoppingZone_Forest
	{
		[Cpp2IlInjected.Token(Token = "0x6002173")]
		[Cpp2IlInjected.Address(RVA = "0xB7DE38", Offset = "0xB7DE38", VA = "0xB7DE38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000505")]
	public Vector2 Directions
	{
		[Cpp2IlInjected.Token(Token = "0x6002174")]
		[Cpp2IlInjected.Address(RVA = "0xB7DE68", Offset = "0xB7DE68", VA = "0xB7DE68")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000506")]
	public Item HeldItem
	{
		[Cpp2IlInjected.Token(Token = "0x6002175")]
		[Cpp2IlInjected.Address(RVA = "0xB7DE9C", Offset = "0xB7DE9C", VA = "0xB7DE9C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000507")]
	public int breathCDMax
	{
		[Cpp2IlInjected.Token(Token = "0x6002176")]
		[Cpp2IlInjected.Address(RVA = "0xB7DEB0", Offset = "0xB7DEB0", VA = "0xB7DEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000508")]
	public bool ShouldFloatInWater
	{
		[Cpp2IlInjected.Token(Token = "0x6002177")]
		[Cpp2IlInjected.Address(RVA = "0xB7DEF8", Offset = "0xB7DEF8", VA = "0xB7DEF8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000509")]
	public bool CanBeTalkedTo
	{
		[Cpp2IlInjected.Token(Token = "0x6002178")]
		[Cpp2IlInjected.Address(RVA = "0xB7DF44", Offset = "0xB7DF44", VA = "0xB7DF44")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700050A")]
	public bool IsVoidVaultEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6002179")]
		[Cpp2IlInjected.Address(RVA = "0xB7DFE8", Offset = "0xB7DFE8", VA = "0xB7DFE8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600217A")]
		[Cpp2IlInjected.Address(RVA = "0xB7DFFC", Offset = "0xB7DFFC", VA = "0xB7DFFC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700050B")]
	public bool DeadOrGhost
	{
		[Cpp2IlInjected.Token(Token = "0x600217B")]
		[Cpp2IlInjected.Address(RVA = "0xB7E014", Offset = "0xB7E014", VA = "0xB7E014")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700050C")]
	public bool TryingToHoverUp
	{
		[Cpp2IlInjected.Token(Token = "0x600217C")]
		[Cpp2IlInjected.Address(RVA = "0xB7E038", Offset = "0xB7E038", VA = "0xB7E038")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700050D")]
	public bool TryingToHoverDown
	{
		[Cpp2IlInjected.Token(Token = "0x600217D")]
		[Cpp2IlInjected.Address(RVA = "0xB7E05C", Offset = "0xB7E05C", VA = "0xB7E05C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700050E")]
	public Vector2 DefaultSize
	{
		[Cpp2IlInjected.Token(Token = "0x600217E")]
		[Cpp2IlInjected.Address(RVA = "0xB7E080", Offset = "0xB7E080", VA = "0xB7E080")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700050F")]
	public bool UsingBiomeTorches
	{
		[Cpp2IlInjected.Token(Token = "0x6002184")]
		[Cpp2IlInjected.Address(RVA = "0xB7E290", Offset = "0xB7E290", VA = "0xB7E290")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002185")]
		[Cpp2IlInjected.Address(RVA = "0xB7E2B0", Offset = "0xB7E2B0", VA = "0xB7E2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000510")]
	public bool UsingSuperCart
	{
		[Cpp2IlInjected.Token(Token = "0x6002186")]
		[Cpp2IlInjected.Address(RVA = "0xB7E2C0", Offset = "0xB7E2C0", VA = "0xB7E2C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002187")]
		[Cpp2IlInjected.Address(RVA = "0xB7E2E0", Offset = "0xB7E2E0", VA = "0xB7E2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000511")]
	public float bowEffectiveDamage
	{
		[Cpp2IlInjected.Token(Token = "0x6002188")]
		[Cpp2IlInjected.Address(RVA = "0xB7E2E8", Offset = "0xB7E2E8", VA = "0xB7E2E8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000512")]
	public float gunEffectiveDamage
	{
		[Cpp2IlInjected.Token(Token = "0x6002189")]
		[Cpp2IlInjected.Address(RVA = "0xB7E32C", Offset = "0xB7E32C", VA = "0xB7E32C")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000513")]
	public float specialistEffectiveDamage
	{
		[Cpp2IlInjected.Token(Token = "0x600218A")]
		[Cpp2IlInjected.Address(RVA = "0xB7E348", Offset = "0xB7E348", VA = "0xB7E348")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000514")]
	public bool ShouldNotDraw
	{
		[Cpp2IlInjected.Token(Token = "0x600218B")]
		[Cpp2IlInjected.Address(RVA = "0xB7DFB4", Offset = "0xB7DFB4", VA = "0xB7DFB4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000515")]
	public bool isLockedToATile
	{
		[Cpp2IlInjected.Token(Token = "0x600218C")]
		[Cpp2IlInjected.Address(RVA = "0xB7E368", Offset = "0xB7E368", VA = "0xB7E368")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000516")]
	public bool PortalPhysicsEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x600218E")]
		[Cpp2IlInjected.Address(RVA = "0xB7E614", Offset = "0xB7E614", VA = "0xB7E614")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000517")]
	public bool MountFishronSpecial
	{
		[Cpp2IlInjected.Token(Token = "0x600218F")]
		[Cpp2IlInjected.Address(RVA = "0xB7E634", Offset = "0xB7E634", VA = "0xB7E634")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000518")]
	public bool HasMinionRestTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6002190")]
		[Cpp2IlInjected.Address(RVA = "0xB7E774", Offset = "0xB7E774", VA = "0xB7E774")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000519")]
	public bool HasMinionAttackTargetNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6002191")]
		[Cpp2IlInjected.Address(RVA = "0xB7E868", Offset = "0xB7E868", VA = "0xB7E868")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700051A")]
	public bool ItemTimeIsZero
	{
		[Cpp2IlInjected.Token(Token = "0x6002192")]
		[Cpp2IlInjected.Address(RVA = "0xB7E87C", Offset = "0xB7E87C", VA = "0xB7E87C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700051B")]
	public bool ItemAnimationJustStarted
	{
		[Cpp2IlInjected.Token(Token = "0x6002197")]
		[Cpp2IlInjected.Address(RVA = "0xB7E8EC", Offset = "0xB7E8EC", VA = "0xB7E8EC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700051C")]
	public float NormalizedLuck
	{
		[Cpp2IlInjected.Token(Token = "0x600223D")]
		[Cpp2IlInjected.Address(RVA = "0xBC5C60", Offset = "0xBC5C60", VA = "0xBC5C60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700051D")]
	public bool SlimeDontHyperJump
	{
		[Cpp2IlInjected.Token(Token = "0x6002255")]
		[Cpp2IlInjected.Address(RVA = "0xBCFBC0", Offset = "0xBCFBC0", VA = "0xBCFBC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700051E")]
	public Vector2? MouthPosition
	{
		[Cpp2IlInjected.Token(Token = "0x600236E")]
		[Cpp2IlInjected.Address(RVA = "0xC725A0", Offset = "0xC725A0", VA = "0xC725A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700051F")]
	public Vector2? HandPosition
	{
		[Cpp2IlInjected.Token(Token = "0x60023BC")]
		[Cpp2IlInjected.Address(RVA = "0xC7EBF8", Offset = "0xC7EBF8", VA = "0xC7EBF8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002123")]
	[Cpp2IlInjected.Address(RVA = "0xB7CAE8", Offset = "0xB7CAE8", VA = "0xB7CAE8")]
	public void RotateRelativePoint(ref float x, ref float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002124")]
	[Cpp2IlInjected.Address(RVA = "0xB7CFA4", Offset = "0xB7CFA4", VA = "0xB7CFA4")]
	public Vector2 RotatedRelativePointOld(Vector2 pos, bool rotateForward = true)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002125")]
	[Cpp2IlInjected.Address(RVA = "0xB7CB58", Offset = "0xB7CB58", VA = "0xB7CB58")]
	public Vector2 RotatedRelativePoint(Vector2 pos, bool reverseRotation = false, bool addGfxOffY = true)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002129")]
	[Cpp2IlInjected.Address(RVA = "0xB7D34C", Offset = "0xB7D34C", VA = "0xB7D34C")]
	public bool CanDemonHeartAccessoryBeShown()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600212A")]
	[Cpp2IlInjected.Address(RVA = "0xB7D534", Offset = "0xB7D534", VA = "0xB7D534")]
	public bool CanMasterModeAccessoryBeShown()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600212B")]
	[Cpp2IlInjected.Address(RVA = "0xB7D59C", Offset = "0xB7D59C", VA = "0xB7D59C")]
	public int GetAmountOfExtraAccessorySlotsToShow()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600217F")]
	[Cpp2IlInjected.Address(RVA = "0xB7E0B0", Offset = "0xB7E0B0", VA = "0xB7E0B0")]
	public EntityShadowInfo GetAdvancedShadow(int shadowIndex)
	{
		return default(EntityShadowInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6002180")]
	[Cpp2IlInjected.Address(RVA = "0xB7E164", Offset = "0xB7E164", VA = "0xB7E164")]
	public void UpdateAdvancedShadows()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002181")]
	[Cpp2IlInjected.Address(RVA = "0xB7E1A8", Offset = "0xB7E1A8", VA = "0xB7E1A8")]
	public void ResetAdvancedShadows()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002182")]
	[Cpp2IlInjected.Address(RVA = "0xB7E1B4", Offset = "0xB7E1B4", VA = "0xB7E1B4")]
	public void SetCompositeArmFront(bool enabled, CompositeArmStretchAmount stretch, float rotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002183")]
	[Cpp2IlInjected.Address(RVA = "0xB7E220", Offset = "0xB7E220", VA = "0xB7E220")]
	public void SetCompositeArmBack(bool enabled, CompositeArmStretchAmount stretch, float rotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600218D")]
	[Cpp2IlInjected.Address(RVA = "0xB7E390", Offset = "0xB7E390", VA = "0xB7E390")]
	public void SetTalkNPC(int npcIndex, bool fromNet = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002193")]
	[Cpp2IlInjected.Address(RVA = "0xB7E88C", Offset = "0xB7E88C", VA = "0xB7E88C")]
	public void SetItemTime(int frames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002194")]
	[Cpp2IlInjected.Address(RVA = "0xB7E898", Offset = "0xB7E898", VA = "0xB7E898")]
	public void ApplyItemTime(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002195")]
	[Cpp2IlInjected.Address(RVA = "0xB7E8A8", Offset = "0xB7E8A8", VA = "0xB7E8A8")]
	public void ApplyItemTime(Item sItem, float multiplier)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002196")]
	[Cpp2IlInjected.Address(RVA = "0xB7E8D8", Offset = "0xB7E8D8", VA = "0xB7E8D8")]
	public void SetDummyItemTime(int frames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002198")]
	[Cpp2IlInjected.Address(RVA = "0xB7E908", Offset = "0xB7E908", VA = "0xB7E908")]
	public void SetItemAnimation(int frames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002199")]
	[Cpp2IlInjected.Address(RVA = "0xB7E914", Offset = "0xB7E914", VA = "0xB7E914")]
	private void ApplyItemAnimation(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600219A")]
	[Cpp2IlInjected.Address(RVA = "0xB7EA90", Offset = "0xB7EA90", VA = "0xB7EA90")]
	public void MatchItemTimeToItemAnimation()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600219B")]
	[Cpp2IlInjected.Address(RVA = "0xB7EA9C", Offset = "0xB7EA9C", VA = "0xB7EA9C")]
	public bool InOpposingTeam(Player otherPlayer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600219C")]
	[Cpp2IlInjected.Address(RVA = "0xB7EADC", Offset = "0xB7EADC", VA = "0xB7EADC")]
	public bool TeamChangeAllowed()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600219D")]
	[Cpp2IlInjected.Address(RVA = "0xB7EAE4", Offset = "0xB7EAE4", VA = "0xB7EAE4")]
	public void HealEffect(int healAmount, bool broadcast = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600219E")]
	[Cpp2IlInjected.Address(RVA = "0xB7ECB0", Offset = "0xB7ECB0", VA = "0xB7ECB0")]
	public void ManaEffect(int manaAmount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600219F")]
	[Cpp2IlInjected.Address(RVA = "0xB7EE70", Offset = "0xB7EE70", VA = "0xB7EE70")]
	public void InterruptItemUsageIfOverTile(int tileTypeToBeOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021A0")]
	[Cpp2IlInjected.Address(RVA = "0xB7EFA8", Offset = "0xB7EFA8", VA = "0xB7EFA8")]
	public Vector2 GetHairDrawOffset(int hairID, bool hatHair)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A1")]
	[Cpp2IlInjected.Address(RVA = "0xB7F144", Offset = "0xB7F144", VA = "0xB7F144")]
	public Vector2 GetHelmetDrawOffset()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A2")]
	[Cpp2IlInjected.Address(RVA = "0xB7F75C", Offset = "0xB7F75C", VA = "0xB7F75C")]
	public Vector2 GetBeardDrawOffsetFromHelmet()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A3")]
	[Cpp2IlInjected.Address(RVA = "0xB7F8C8", Offset = "0xB7F8C8", VA = "0xB7F8C8")]
	public Vector2 GetFaceHeadOffsetFromHelmet()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A4")]
	[Cpp2IlInjected.Address(RVA = "0xB7F428", Offset = "0xB7F428", VA = "0xB7F428")]
	public Vector2 GetHelmetOffsetAddonFromFaceHead(Vector2 headOffset)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A5")]
	[Cpp2IlInjected.Address(RVA = "0xB7FA94", Offset = "0xB7FA94", VA = "0xB7FA94")]
	public Vector2 GetLegsDrawOffset()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A6")]
	[Cpp2IlInjected.Address(RVA = "0xB7FC0C", Offset = "0xB7FC0C", VA = "0xB7FC0C")]
	public void AccumulateGolfingScore(int score)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021A7")]
	[Cpp2IlInjected.Address(RVA = "0xB7FC3C", Offset = "0xB7FC3C", VA = "0xB7FC3C")]
	public static byte FindClosest(Vector2 Position, int Width, int Height)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60021A8")]
	[Cpp2IlInjected.Address(RVA = "0xB7FF28", Offset = "0xB7FF28", VA = "0xB7FF28")]
	public void ToggleInv()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021A9")]
	[Cpp2IlInjected.Address(RVA = "0xB80724", Offset = "0xB80724", VA = "0xB80724")]
	private static void OpenInventory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021AA")]
	[Cpp2IlInjected.Address(RVA = "0xB80818", Offset = "0xB80818", VA = "0xB80818")]
	public void ToggleCreativeMenu()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021AB")]
	[Cpp2IlInjected.Address(RVA = "0xB80C58", Offset = "0xB80C58", VA = "0xB80C58")]
	public void dropItemCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021AC")]
	[Cpp2IlInjected.Address(RVA = "0xB83280", Offset = "0xB83280", VA = "0xB83280")]
	public void DropSelectedItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021AD")]
	[Cpp2IlInjected.Address(RVA = "0xB83C28", Offset = "0xB83C28", VA = "0xB83C28")]
	public void PlayDroppedItemAnimation(int time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021AE")]
	[Cpp2IlInjected.Address(RVA = "0xB83148", Offset = "0xB83148", VA = "0xB83148")]
	public void DropSelectedItem_InterruptActionsThatUseAnimations()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021AF")]
	[Cpp2IlInjected.Address(RVA = "0xB83C7C", Offset = "0xB83C7C", VA = "0xB83C7C")]
	public int FindBuffIndex(int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60021B0")]
	[Cpp2IlInjected.Address(RVA = "0xB83D50", Offset = "0xB83D50", VA = "0xB83D50")]
	public void AddBuff(int type, int timeToAdd, bool quiet = true, bool foodHack = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021B1")]
	[Cpp2IlInjected.Address(RVA = "0xB848BC", Offset = "0xB848BC", VA = "0xB848BC")]
	private bool AddBuff_ActuallyTryToAddTheBuff(int type, int time)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021B2")]
	[Cpp2IlInjected.Address(RVA = "0xB84774", Offset = "0xB84774", VA = "0xB84774")]
	private void AddBuff_RemoveOldMeleeBuffsOfMatchingType(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021B3")]
	[Cpp2IlInjected.Address(RVA = "0xB84574", Offset = "0xB84574", VA = "0xB84574")]
	private void AddBuff_RemoveOldPetBuffsOfMatchingType(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021B4")]
	[Cpp2IlInjected.Address(RVA = "0xB84478", Offset = "0xB84478", VA = "0xB84478")]
	private bool AddBuff_TryUpdatingExistingBuffTime(int type, int time)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021B5")]
	[Cpp2IlInjected.Address(RVA = "0xB84184", Offset = "0xB84184", VA = "0xB84184")]
	private int AddBuff_DetermineBuffTimeToAdd(int type, int time1)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60021B6")]
	[Cpp2IlInjected.Address(RVA = "0xB84074", Offset = "0xB84074", VA = "0xB84074")]
	public void DelBuff(int b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021B7")]
	[Cpp2IlInjected.Address(RVA = "0xB84A50", Offset = "0xB84A50", VA = "0xB84A50")]
	public void ClearBuff(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021B8")]
	[Cpp2IlInjected.Address(RVA = "0xB84B04", Offset = "0xB84B04", VA = "0xB84B04")]
	public int CountBuffs()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60021B9")]
	[Cpp2IlInjected.Address(RVA = "0xB84BB0", Offset = "0xB84BB0", VA = "0xB84BB0")]
	public void QuickHeal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021BA")]
	[Cpp2IlInjected.Address(RVA = "0xB84DB4", Offset = "0xB84DB4", VA = "0xB84DB4")]
	public Item QuickHeal_GetItemToUse()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021BB")]
	[Cpp2IlInjected.Address(RVA = "0xB86E30", Offset = "0xB86E30", VA = "0xB86E30")]
	public void QuickMana()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021BC")]
	[Cpp2IlInjected.Address(RVA = "0xB86F78", Offset = "0xB86F78", VA = "0xB86F78")]
	public Item QuickMana_GetItemToUse()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021BD")]
	[Cpp2IlInjected.Address(RVA = "0xB87078", Offset = "0xB87078", VA = "0xB87078")]
	public void TrySwitchingLoadout(int loadoutIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021BE")]
	[Cpp2IlInjected.Address(RVA = "0xB875D0", Offset = "0xB875D0", VA = "0xB875D0")]
	public bool GetHasAvailableBuff(out bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021BF")]
	[Cpp2IlInjected.Address(RVA = "0xB87B74", Offset = "0xB87B74", VA = "0xB87B74")]
	public void QuickBuff()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021C0")]
	[Cpp2IlInjected.Address(RVA = "0xB880B8", Offset = "0xB880B8", VA = "0xB880B8")]
	private Item QuickBuff_PickBestFoodItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021C1")]
	[Cpp2IlInjected.Address(RVA = "0xB886B4", Offset = "0xB886B4", VA = "0xB886B4")]
	private int QuickBuff_FindFoodPriority(int buffType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60021C2")]
	[Cpp2IlInjected.Address(RVA = "0xB88300", Offset = "0xB88300", VA = "0xB88300")]
	private bool QuickBuff_ShouldBotherUsingThisBuff(int attemptedType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021C3")]
	[Cpp2IlInjected.Address(RVA = "0xB886DC", Offset = "0xB886DC", VA = "0xB886DC")]
	public void QuickMount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021C4")]
	[Cpp2IlInjected.Address(RVA = "0xB895F8", Offset = "0xB895F8", VA = "0xB895F8")]
	public bool CanFitSpace(int heightBoost)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021C5")]
	[Cpp2IlInjected.Address(RVA = "0xB89758", Offset = "0xB89758", VA = "0xB89758")]
	public bool UseQuickMineCartHook()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021C6")]
	[Cpp2IlInjected.Address(RVA = "0xB89CC0", Offset = "0xB89CC0", VA = "0xB89CC0")]
	public bool UseQuickMineCartSnapHook()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021C7")]
	[Cpp2IlInjected.Address(RVA = "0xB88EE0", Offset = "0xB88EE0", VA = "0xB88EE0")]
	private void QuickMinecart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021C8")]
	[Cpp2IlInjected.Address(RVA = "0xB88968", Offset = "0xB88968", VA = "0xB88968")]
	private bool QuickMinecartSnap()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021C9")]
	[Cpp2IlInjected.Address(RVA = "0xB88828", Offset = "0xB88828", VA = "0xB88828")]
	public Item QuickMount_GetItemToUse()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021CA")]
	[Cpp2IlInjected.Address(RVA = "0xB8A22C", Offset = "0xB8A22C", VA = "0xB8A22C")]
	public void ClearGrapplingBlacklist()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021CB")]
	[Cpp2IlInjected.Address(RVA = "0xB8A288", Offset = "0xB8A288", VA = "0xB8A288")]
	public bool IsBlacklistedForGrappling(Point p)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021CC")]
	[Cpp2IlInjected.Address(RVA = "0xB8A2F4", Offset = "0xB8A2F4", VA = "0xB8A2F4")]
	public void UpdateBlacklistedTilesForGrappling()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021CD")]
	[Cpp2IlInjected.Address(RVA = "0xB8A630", Offset = "0xB8A630", VA = "0xB8A630")]
	private void FireGrapple(Item grappleItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021CE")]
	[Cpp2IlInjected.Address(RVA = "0xB8B8AC", Offset = "0xB8B8AC", VA = "0xB8B8AC")]
	public void QuickGrapple()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021CF")]
	[Cpp2IlInjected.Address(RVA = "0xB8BC08", Offset = "0xB8BC08", VA = "0xB8BC08")]
	public Item QuickGrapple_GetItemToUse()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021D0")]
	[Cpp2IlInjected.Address(RVA = "0xB8BD0C", Offset = "0xB8BD0C", VA = "0xB8BD0C")]
	public void StatusToNPC(int type, int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D1")]
	[Cpp2IlInjected.Address(RVA = "0xB8C708", Offset = "0xB8C708", VA = "0xB8C708")]
	public void StatusToPlayerPvP(int type, int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D2")]
	[Cpp2IlInjected.Address(RVA = "0xB8D020", Offset = "0xB8D020", VA = "0xB8D020")]
	public void Ghost()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D3")]
	[Cpp2IlInjected.Address(RVA = "0xB8DD68", Offset = "0xB8DD68", VA = "0xB8DD68")]
	private void TrySyncingInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D4")]
	[Cpp2IlInjected.Address(RVA = "0xB8E008", Offset = "0xB8E008", VA = "0xB8E008")]
	public void OnHit(float x, float y, Entity victim)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D5")]
	[Cpp2IlInjected.Address(RVA = "0xB8EE98", Offset = "0xB8EE98", VA = "0xB8EE98")]
	public void OpenPresent(int itemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D6")]
	[Cpp2IlInjected.Address(RVA = "0xB90634", Offset = "0xB90634", VA = "0xB90634")]
	public void OpenLegacyPresent(int itemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D7")]
	[Cpp2IlInjected.Address(RVA = "0xB9097C", Offset = "0xB9097C", VA = "0xB9097C")]
	public void QuickSpawnItem(IEntitySource source, int item, int stack = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D8")]
	[Cpp2IlInjected.Address(RVA = "0xB90B08", Offset = "0xB90B08", VA = "0xB90B08")]
	public void OpenBossBag(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021D9")]
	[Cpp2IlInjected.Address(RVA = "0xB93648", Offset = "0xB93648", VA = "0xB93648")]
	private void TryGettingDevArmor(IEntitySource source)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021DA")]
	[Cpp2IlInjected.Address(RVA = "0xB93D80", Offset = "0xB93D80", VA = "0xB93D80")]
	public void OpenFishingCrate(int crateItemID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021DB")]
	[Cpp2IlInjected.Address(RVA = "0xB9AADC", Offset = "0xB9AADC", VA = "0xB9AADC")]
	public int CountItem(int type, int stopCountingAt = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60021DC")]
	[Cpp2IlInjected.Address(RVA = "0xB9AB2C", Offset = "0xB9AB2C", VA = "0xB9AB2C")]
	public bool ConsumeItem(int type, bool reverseOrder = false, bool includeVoidBag = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60021DD")]
	[Cpp2IlInjected.Address(RVA = "0xB9ACDC", Offset = "0xB9ACDC", VA = "0xB9ACDC")]
	public void OpenShadowLockbox(int boxType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021DE")]
	[Cpp2IlInjected.Address(RVA = "0xB9B144", Offset = "0xB9B144", VA = "0xB9B144")]
	public void OpenLockBox(int lockboxItemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021DF")]
	[Cpp2IlInjected.Address(RVA = "0xB9B4FC", Offset = "0xB9B4FC", VA = "0xB9B4FC")]
	public void OpenHerbBag(int bagType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021E0")]
	[Cpp2IlInjected.Address(RVA = "0xB9B83C", Offset = "0xB9B83C", VA = "0xB9B83C")]
	public void OpenCanofWorms(int sourceItemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021E1")]
	[Cpp2IlInjected.Address(RVA = "0xB9B9BC", Offset = "0xB9B9BC", VA = "0xB9B9BC")]
	public void OpenOyster(int sourceItemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021E2")]
	[Cpp2IlInjected.Address(RVA = "0xB9BB20", Offset = "0xB9BB20", VA = "0xB9BB20")]
	public void OpenGoodieBag(int itemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021E3")]
	[Cpp2IlInjected.Address(RVA = "0xB9E690", Offset = "0xB9E690", VA = "0xB9E690")]
	public void UpdateDyes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021E4")]
	[Cpp2IlInjected.Address(RVA = "0xB9E814", Offset = "0xB9E814", VA = "0xB9E814")]
	private void UpdateItemDye(bool isNotInVanitySlot, bool isSetToHidden, Item armorItem, Item dyeItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021E5")]
	[Cpp2IlInjected.Address(RVA = "0xB9EFA8", Offset = "0xB9EFA8", VA = "0xB9EFA8")]
	public int ArmorSetDye()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60021E6")]
	[Cpp2IlInjected.Address(RVA = "0xB9F064", Offset = "0xB9F064", VA = "0xB9F064")]
	public IEntitySource GetProjectileSource_Buff(int buffIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021E7")]
	[Cpp2IlInjected.Address(RVA = "0xB8B838", Offset = "0xB8B838", VA = "0xB8B838")]
	public IEntitySource GetProjectileSource_Item(Item item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021E8")]
	[Cpp2IlInjected.Address(RVA = "0xB905C0", Offset = "0xB905C0", VA = "0xB905C0")]
	public IEntitySource GetItemSource_OpenItem(int itemType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021E9")]
	[Cpp2IlInjected.Address(RVA = "0xB9F0F8", Offset = "0xB9F0F8", VA = "0xB9F0F8")]
	public IEntitySource GetItemSource_Death()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021EA")]
	[Cpp2IlInjected.Address(RVA = "0xB830D4", Offset = "0xB830D4", VA = "0xB830D4")]
	public IEntitySource GetItemSource_Misc(int itemSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021EB")]
	[Cpp2IlInjected.Address(RVA = "0xB9F168", Offset = "0xB9F168", VA = "0xB9F168")]
	public IEntitySource GetProjectileSource_Item_WithPotentialAmmo(Item item, int ammoItemId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021EC")]
	[Cpp2IlInjected.Address(RVA = "0xB8EE2C", Offset = "0xB8EE2C", VA = "0xB8EE2C")]
	public IEntitySource GetProjectileSource_SetBonus(int projectileSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021ED")]
	[Cpp2IlInjected.Address(RVA = "0xB8EDA0", Offset = "0xB8EDA0", VA = "0xB8EDA0")]
	public IEntitySource GetProjectileSource_OnHit(Entity victim, int projectileSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021EE")]
	[Cpp2IlInjected.Address(RVA = "0xB9F1F4", Offset = "0xB9F1F4", VA = "0xB9F1F4")]
	public IEntitySource GetProjectileSource_OnHurt(Entity attacker, int projectileSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021EF")]
	[Cpp2IlInjected.Address(RVA = "0xB9F280", Offset = "0xB9F280", VA = "0xB9F280")]
	public IEntitySource GetProjectileSource_Accessory(Item item)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021F0")]
	[Cpp2IlInjected.Address(RVA = "0xB9F2F4", Offset = "0xB9F2F4", VA = "0xB9F2F4")]
	public IEntitySource GetProjectileSource_Misc(int projectileSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021F1")]
	[Cpp2IlInjected.Address(RVA = "0xB9F360", Offset = "0xB9F360", VA = "0xB9F360")]
	public IEntitySource GetProjectileSource_TileInteraction(int tileCoordsX, int tileCoordsY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021F2")]
	[Cpp2IlInjected.Address(RVA = "0xB9F3EC", Offset = "0xB9F3EC", VA = "0xB9F3EC")]
	public IEntitySource GetItemSource_TileInteraction(int tileCoordsX, int tileCoordsY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021F3")]
	[Cpp2IlInjected.Address(RVA = "0xB9F478", Offset = "0xB9F478", VA = "0xB9F478")]
	public IEntitySource GetNPCSource_TileInteraction(int tileCoordsX, int tileCoordsY)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021F4")]
	[Cpp2IlInjected.Address(RVA = "0xB9F504", Offset = "0xB9F504", VA = "0xB9F504")]
	public IEntitySource GetItemSource_OnHit(Entity victim, int itemSourceId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60021F5")]
	[Cpp2IlInjected.Address(RVA = "0xB9F590", Offset = "0xB9F590", VA = "0xB9F590")]
	public void UpdateBuffs(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021F6")]
	[Cpp2IlInjected.Address(RVA = "0xB86D08", Offset = "0xB86D08", VA = "0xB86D08")]
	public void TryToResetHungerToNeutral()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021F7")]
	[Cpp2IlInjected.Address(RVA = "0xBA8ED0", Offset = "0xBA8ED0", VA = "0xBA8ED0")]
	public void UpdateHungerBuffs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021F8")]
	[Cpp2IlInjected.Address(RVA = "0xBA5044", Offset = "0xBA5044", VA = "0xBA5044")]
	public void UpdateStarvingState(bool withEmote)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021F9")]
	[Cpp2IlInjected.Address(RVA = "0xBA91F8", Offset = "0xBA91F8", VA = "0xBA91F8")]
	private void UpdateProjectileCaches(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021FA")]
	[Cpp2IlInjected.Address(RVA = "0xBA93C4", Offset = "0xBA93C4", VA = "0xBA93C4")]
	private void ResetProjectileCaches()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021FB")]
	[Cpp2IlInjected.Address(RVA = "0xBA8D34", Offset = "0xBA8D34", VA = "0xBA8D34")]
	public void BuffHandle_SpawnPetIfNeededAndSetTime(int buffIndex, ref bool petBool, int petProjID, int buffTimeToGive = 18000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021FC")]
	[Cpp2IlInjected.Address(RVA = "0xBA9404", Offset = "0xBA9404", VA = "0xBA9404")]
	public void BuffHandle_SpawnPetIfNeeded(ref bool petBool, int petProjID, int buffIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021FD")]
	[Cpp2IlInjected.Address(RVA = "0xBA87B8", Offset = "0xBA87B8", VA = "0xBA87B8")]
	private void UpdateAbigailStatus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021FE")]
	[Cpp2IlInjected.Address(RVA = "0xBA89C4", Offset = "0xBA89C4", VA = "0xBA89C4")]
	private void UpdateStormTigerStatus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60021FF")]
	[Cpp2IlInjected.Address(RVA = "0xBA9664", Offset = "0xBA9664", VA = "0xBA9664")]
	private int GetDesiredStormTigerMinionRank()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002200")]
	[Cpp2IlInjected.Address(RVA = "0xBA9690", Offset = "0xBA9690", VA = "0xBA9690")]
	public void Counterweight(Vector2 hitPos, int dmg, float kb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002201")]
	[Cpp2IlInjected.Address(RVA = "0xBA9C6C", Offset = "0xBA9C6C", VA = "0xBA9C6C")]
	public int beeType()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002202")]
	[Cpp2IlInjected.Address(RVA = "0xBA9D20", Offset = "0xBA9D20", VA = "0xBA9D20")]
	public int beeDamage(int dmg)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002203")]
	[Cpp2IlInjected.Address(RVA = "0xBA9DF8", Offset = "0xBA9DF8", VA = "0xBA9DF8")]
	public float beeKB(float KB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002204")]
	[Cpp2IlInjected.Address(RVA = "0xBA9E20", Offset = "0xBA9E20", VA = "0xBA9E20")]
	public void Yoraiz0rEye()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002205")]
	[Cpp2IlInjected.Address(RVA = "0xB7D3B4", Offset = "0xB7D3B4", VA = "0xB7D3B4")]
	public bool IsItemSlotUnlockedAndUsable(int slot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002206")]
	[Cpp2IlInjected.Address(RVA = "0xBAAEA0", Offset = "0xBAAEA0", VA = "0xBAAEA0")]
	public void RefreshInfoAccs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002207")]
	[Cpp2IlInjected.Address(RVA = "0xBAB6E0", Offset = "0xBAB6E0", VA = "0xBAB6E0")]
	public void RefreshInfoAccsFromTeamPlayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002208")]
	[Cpp2IlInjected.Address(RVA = "0xBAAFFC", Offset = "0xBAAFFC", VA = "0xBAAFFC")]
	public void RefreshInfoAccsFromItemType(int accType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002209")]
	[Cpp2IlInjected.Address(RVA = "0xBABD8C", Offset = "0xBABD8C", VA = "0xBABD8C")]
	public void RefreshMechanicalAccsFromItemType(int accType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600220A")]
	[Cpp2IlInjected.Address(RVA = "0xBABF24", Offset = "0xBABF24", VA = "0xBABF24")]
	public void UpdatePermanentBoosters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600220B")]
	[Cpp2IlInjected.Address(RVA = "0xBABFA4", Offset = "0xBABFA4", VA = "0xBABFA4")]
	private bool UpdateEquips_CanItemGrantBenefits(int itemSlot, Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600220C")]
	[Cpp2IlInjected.Address(RVA = "0xBAC018", Offset = "0xBAC018", VA = "0xBAC018")]
	public void UpdateEquips(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600220D")]
	[Cpp2IlInjected.Address(RVA = "0xBACBFC", Offset = "0xBACBFC", VA = "0xBACBFC")]
	private void GrantArmorBenefits(Item armorPiece)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600220E")]
	[Cpp2IlInjected.Address(RVA = "0xBAC898", Offset = "0xBAC898", VA = "0xBAC898")]
	private void GrantPrefixBenefits(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600220F")]
	[Cpp2IlInjected.Address(RVA = "0xBB32E8", Offset = "0xBB32E8", VA = "0xBB32E8")]
	private void SpawnHallucination(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002210")]
	[Cpp2IlInjected.Address(RVA = "0xBB3230", Offset = "0xBB3230", VA = "0xBB3230")]
	public void DoBootsEffect(Utils.TileActionAttempt theEffectMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002211")]
	[Cpp2IlInjected.Address(RVA = "0xBB3830", Offset = "0xBB3830", VA = "0xBB3830")]
	public bool DoBootsEffect_PlaceFlamesOnTile(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002212")]
	[Cpp2IlInjected.Address(RVA = "0xBB3A3C", Offset = "0xBB3A3C", VA = "0xBB3A3C")]
	public bool DoBootsEffect_PlaceFlowersOnTile(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002213")]
	[Cpp2IlInjected.Address(RVA = "0xBB2BA4", Offset = "0xBB2BA4", VA = "0xBB2BA4")]
	private void ApplyEquipVanity(int itemSlot, Item currentItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002214")]
	[Cpp2IlInjected.Address(RVA = "0xBB2E70", Offset = "0xBB2E70", VA = "0xBB2E70")]
	private void DoEyebrellaRainEffect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002215")]
	[Cpp2IlInjected.Address(RVA = "0xBB594C", Offset = "0xBB594C", VA = "0xBB594C")]
	public WingStats GetWingStats(int wingID)
	{
		return default(WingStats);
	}

	[Cpp2IlInjected.Token(Token = "0x6002216")]
	[Cpp2IlInjected.Address(RVA = "0xBAF07C", Offset = "0xBAF07C", VA = "0xBAF07C")]
	private void ApplyEquipFunctional(int itemSlot, Item currentItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002217")]
	[Cpp2IlInjected.Address(RVA = "0xBB6830", Offset = "0xBB6830", VA = "0xBB6830")]
	private void ApplyWilsonBeard(Item currentItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002218")]
	[Cpp2IlInjected.Address(RVA = "0xBB4438", Offset = "0xBB4438", VA = "0xBB4438")]
	private void ApplyMusicBox(Item currentItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002219")]
	[Cpp2IlInjected.Address(RVA = "0xBB6964", Offset = "0xBB6964", VA = "0xBB6964")]
	private string GetArmourSetId(string id, [Optional] string formatId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600221A")]
	[Cpp2IlInjected.Address(RVA = "0xBB6BF4", Offset = "0xBB6BF4", VA = "0xBB6BF4")]
	public void UpdateArmorSets(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600221B")]
	[Cpp2IlInjected.Address(RVA = "0xBB963C", Offset = "0xBB963C", VA = "0xBB963C")]
	public void UpdateSocialShadow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600221C")]
	[Cpp2IlInjected.Address(RVA = "0xBB9740", Offset = "0xBB9740", VA = "0xBB9740")]
	public void UpdateTeleportVisuals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600221D")]
	[Cpp2IlInjected.Address(RVA = "0xBB9F34", Offset = "0xBB9F34", VA = "0xBB9F34")]
	private void UpdateGraveyard(bool now = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600221E")]
	[Cpp2IlInjected.Address(RVA = "0xBBA208", Offset = "0xBBA208", VA = "0xBBA208")]
	public void ForceUpdateBiomes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600221F")]
	[Cpp2IlInjected.Address(RVA = "0xBBEEA0", Offset = "0xBBEEA0", VA = "0xBBEEA0")]
	public bool CanSeeShimmerEffects()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002220")]
	[Cpp2IlInjected.Address(RVA = "0xBBA400", Offset = "0xBBA400", VA = "0xBBA400")]
	public void UpdateBiomes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002221")]
	[Cpp2IlInjected.Address(RVA = "0xBBF8E0", Offset = "0xBBF8E0", VA = "0xBBF8E0")]
	private void TrySpawningFaelings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002222")]
	[Cpp2IlInjected.Address(RVA = "0xBBF070", Offset = "0xBBF070", VA = "0xBBF070")]
	public void ManageSpecialBiomeVisuals(string biomeName, bool inZone, [Optional] Vector2 activationSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002223")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9E0", Offset = "0xBBF9E0", VA = "0xBBF9E0")]
	public void GetHairSettings(out bool fullHair, out bool hatHair, out bool hideHair, out bool backHairDraw, out bool drawsBackHairWithoutHeadgear)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002224")]
	[Cpp2IlInjected.Address(RVA = "0xBBFEA8", Offset = "0xBBFEA8", VA = "0xBBFEA8")]
	public void UpdateDead()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002225")]
	[Cpp2IlInjected.Address(RVA = "0xB8DD3C", Offset = "0xB8DD3C", VA = "0xB8DD3C")]
	private void TryOpeningInGameOptionsBasedOnInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002226")]
	[Cpp2IlInjected.Address(RVA = "0xBC13E8", Offset = "0xBC13E8", VA = "0xBC13E8")]
	public void UpdatePet(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002227")]
	[Cpp2IlInjected.Address(RVA = "0xBC15D0", Offset = "0xBC15D0", VA = "0xBC15D0")]
	public void CheckForPetAchievement(int buffID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002228")]
	[Cpp2IlInjected.Address(RVA = "0xBC1758", Offset = "0xBC1758", VA = "0xBC1758")]
	public void UpdatePetLight(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002229")]
	[Cpp2IlInjected.Address(RVA = "0xBC1A14", Offset = "0xBC1A14", VA = "0xBC1A14")]
	public void TogglePet()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600222A")]
	[Cpp2IlInjected.Address(RVA = "0xBC1A7C", Offset = "0xBC1A7C", VA = "0xBC1A7C")]
	public void ToggleLight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600222B")]
	[Cpp2IlInjected.Address(RVA = "0xBC1B14", Offset = "0xBC1B14", VA = "0xBC1B14")]
	public bool IsWithinSnappngRangeToTile(int x, int y, int distanceInPixels)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600222C")]
	[Cpp2IlInjected.Address(RVA = "0xBC1C70", Offset = "0xBC1C70", VA = "0xBC1C70")]
	public void SmartInteractLookup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600222D")]
	[Cpp2IlInjected.Address(RVA = "0xBC201C", Offset = "0xBC201C", VA = "0xBC201C")]
	private void SmartInteractLookup_PrepareCommonlyUsedInfo(out Vector2 mousevec, out int LX, out int HX, out int LY, out int HY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600222E")]
	[Cpp2IlInjected.Address(RVA = "0xBC2414", Offset = "0xBC2414", VA = "0xBC2414")]
	public Item SmartItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600222F")]
	[Cpp2IlInjected.Address(RVA = "0xBC328C", Offset = "0xBC328C", VA = "0xBC328C")]
	public void SmartSelectLookup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002230")]
	[Cpp2IlInjected.Address(RVA = "0xBC3C04", Offset = "0xBC3C04", VA = "0xBC3C04")]
	private void SmartSelectLookup_GetTargetTile(out int tX, out int tY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002231")]
	[Cpp2IlInjected.Address(RVA = "0xBC360C", Offset = "0xBC360C", VA = "0xBC360C")]
	private void SmartSelect_PickToolForStrategy(int tX, int tY, int toolStrategy, bool wetTile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002232")]
	[Cpp2IlInjected.Address(RVA = "0xBC3D80", Offset = "0xBC3D80", VA = "0xBC3D80")]
	private void SmartSelect_SelectItem(int t)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002233")]
	[Cpp2IlInjected.Address(RVA = "0xBC2BD8", Offset = "0xBC2BD8", VA = "0xBC2BD8")]
	private void SmartSelect_GetToolStrategy(int tX, int tY, out int toolStrategy, out bool wetTile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002234")]
	[Cpp2IlInjected.Address(RVA = "0xBC3E3C", Offset = "0xBC3E3C", VA = "0xBC3E3C")]
	private void SmartSelect_GetAvailableToolRanges(out int pickRange, out int axeRange, out int hammerRange, out int cannonRange, out int extractItemRange, out int paintScraperRange)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002235")]
	[Cpp2IlInjected.Address(RVA = "0xBC40B0", Offset = "0xBC40B0", VA = "0xBC40B0")]
	private void EndOngoingTorchGodEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002236")]
	[Cpp2IlInjected.Address(RVA = "0xBC4330", Offset = "0xBC4330", VA = "0xBC4330")]
	private void TryRecalculatingTorchLuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002237")]
	[Cpp2IlInjected.Address(RVA = "0xBC41C0", Offset = "0xBC41C0", VA = "0xBC41C0")]
	private void RelightTorches()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002238")]
	[Cpp2IlInjected.Address(RVA = "0xBC4724", Offset = "0xBC4724", VA = "0xBC4724")]
	private void TorchAttack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002239")]
	[Cpp2IlInjected.Address(RVA = "0xBC5318", Offset = "0xBC5318", VA = "0xBC5318")]
	private void UpdateTorchLuck_ConsumeCountersAndCalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600223A")]
	[Cpp2IlInjected.Address(RVA = "0xBC59F4", Offset = "0xBC59F4", VA = "0xBC59F4")]
	public void AddCoinLuck(Vector2 coinPosition, int coinAmount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600223B")]
	[Cpp2IlInjected.Address(RVA = "0xBC5AF8", Offset = "0xBC5AF8", VA = "0xBC5AF8")]
	private void UpdateCoinLuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600223C")]
	[Cpp2IlInjected.Address(RVA = "0xBC5B40", Offset = "0xBC5B40", VA = "0xBC5B40")]
	private float CalculateCoinLuck()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600223E")]
	[Cpp2IlInjected.Address(RVA = "0xBC5CC4", Offset = "0xBC5CC4", VA = "0xBC5CC4")]
	private float GetLadyBugLuck()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600223F")]
	[Cpp2IlInjected.Address(RVA = "0xBC5DC4", Offset = "0xBC5DC4", VA = "0xBC5DC4")]
	public static float GetClosestPlayersLuck(Point Position)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002240")]
	[Cpp2IlInjected.Address(RVA = "0xBC5ED0", Offset = "0xBC5ED0", VA = "0xBC5ED0")]
	public static float GetClosestPlayersLuck(Vector2 Position)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002241")]
	[Cpp2IlInjected.Address(RVA = "0xBC5FA8", Offset = "0xBC5FA8", VA = "0xBC5FA8")]
	public int RollLuck(int range)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002242")]
	[Cpp2IlInjected.Address(RVA = "0xBC6204", Offset = "0xBC6204", VA = "0xBC6204")]
	public static float GetClosestRollLuck(Vector2 position, int range)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002243")]
	[Cpp2IlInjected.Address(RVA = "0xBC62F0", Offset = "0xBC62F0", VA = "0xBC62F0")]
	public static float GetClosestRollLuck(int x, int y, int range)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002244")]
	[Cpp2IlInjected.Address(RVA = "0xBC6410", Offset = "0xBC6410", VA = "0xBC6410")]
	public void ResetEffects()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002245")]
	[Cpp2IlInjected.Address(RVA = "0xBC6D5C", Offset = "0xBC6D5C", VA = "0xBC6D5C")]
	private void UpdateLadyBugLuckTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002246")]
	[Cpp2IlInjected.Address(RVA = "0xBC6E3C", Offset = "0xBC6E3C", VA = "0xBC6E3C")]
	public void UpdateImmunity()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002247")]
	[Cpp2IlInjected.Address(RVA = "0xBC6F08", Offset = "0xBC6F08", VA = "0xBC6F08")]
	private void TryToPoop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002248")]
	[Cpp2IlInjected.Address(RVA = "0xBC7394", Offset = "0xBC7394", VA = "0xBC7394")]
	public void UpdateLifeRegen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002249")]
	[Cpp2IlInjected.Address(RVA = "0xBCA4B0", Offset = "0xBCA4B0", VA = "0xBCA4B0")]
	public void UpdateManaRegen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600224A")]
	[Cpp2IlInjected.Address(RVA = "0xBCA9B8", Offset = "0xBCA9B8", VA = "0xBCA9B8")]
	public void UpdateJumpHeight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600224B")]
	[Cpp2IlInjected.Address(RVA = "0xBCAD3C", Offset = "0xBCAD3C", VA = "0xBCAD3C")]
	public void FindPulley()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600224C")]
	[Cpp2IlInjected.Address(RVA = "0xBCB458", Offset = "0xBCB458", VA = "0xBCB458")]
	public void HorizontalMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600224D")]
	[Cpp2IlInjected.Address(RVA = "0xBCCF50", Offset = "0xBCCF50", VA = "0xBCCF50")]
	public void NoteRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600224E")]
	[Cpp2IlInjected.Address(RVA = "0xBCE4A8", Offset = "0xBCE4A8", VA = "0xBCE4A8")]
	private void TryUsingDiggerCart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600224F")]
	[Cpp2IlInjected.Address(RVA = "0xBCCFE4", Offset = "0xBCCFE4", VA = "0xBCCFE4")]
	private void SpawnFastRunParticles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002250")]
	[Cpp2IlInjected.Address(RVA = "0xBCE894", Offset = "0xBCE894", VA = "0xBCE894")]
	private void MowTheLawn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002251")]
	[Cpp2IlInjected.Address(RVA = "0xBCF610", Offset = "0xBCF610", VA = "0xBCF610")]
	private void MowGrassTile(Vector2 thePos)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002252")]
	[Cpp2IlInjected.Address(RVA = "0xBCE1F0", Offset = "0xBCE1F0", VA = "0xBCE1F0")]
	private int CollideWithNPCs(Rectangle myRect, float Damage, float Knockback, int NPCImmuneTime, int PlayerImmuneTime)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002253")]
	[Cpp2IlInjected.Address(RVA = "0xBA53B8", Offset = "0xBA53B8", VA = "0xBA53B8")]
	public void ApplyDamageToNPC(NPC npc, int damage, float knockback, int direction, bool crit)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002254")]
	[Cpp2IlInjected.Address(RVA = "0xBCFAC4", Offset = "0xBCFAC4", VA = "0xBCFAC4")]
	public void OnKillNPC(ref NPCKillAttempt attempt, object externalKillingBlowSource)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002256")]
	[Cpp2IlInjected.Address(RVA = "0xBCF888", Offset = "0xBCF888", VA = "0xBCF888")]
	public void GiveImmuneTimeForCollisionAttack(int time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002257")]
	[Cpp2IlInjected.Address(RVA = "0xBA5264", Offset = "0xBA5264", VA = "0xBA5264")]
	public bool CanNPCBeHitByPlayerOrPlayerProjectile(NPC npc, [Optional] Projectile projectile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002258")]
	[Cpp2IlInjected.Address(RVA = "0xBCFC08", Offset = "0xBCFC08", VA = "0xBCFC08")]
	public void IncreaseAirTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002259")]
	[Cpp2IlInjected.Address(RVA = "0xBCFCB4", Offset = "0xBCFCB4", VA = "0xBCFCB4")]
	public void ResetAirTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600225A")]
	[Cpp2IlInjected.Address(RVA = "0xBCFD40", Offset = "0xBCFD40", VA = "0xBCFD40")]
	public void JumpMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600225B")]
	[Cpp2IlInjected.Address(RVA = "0xBD3378", Offset = "0xBD3378", VA = "0xBD3378")]
	public void DashMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600225C")]
	[Cpp2IlInjected.Address(RVA = "0xBD64B4", Offset = "0xBD64B4", VA = "0xBD64B4")]
	private void SolarDashStart(int dashDirection)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600225D")]
	[Cpp2IlInjected.Address(RVA = "0xBD63E0", Offset = "0xBD63E0", VA = "0xBD63E0")]
	private void DoCommonDashHandle(out int dir, out bool dashing, [Optional] DashStartAction dashStartAction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600225E")]
	[Cpp2IlInjected.Address(RVA = "0xBD64C4", Offset = "0xBD64C4", VA = "0xBD64C4")]
	public void WallslideMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600225F")]
	[Cpp2IlInjected.Address(RVA = "0xBD6DC8", Offset = "0xBD6DC8", VA = "0xBD6DC8")]
	public void CarpetMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002260")]
	[Cpp2IlInjected.Address(RVA = "0xBD703C", Offset = "0xBD703C", VA = "0xBD703C")]
	public void DoubleJumpVisuals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002261")]
	[Cpp2IlInjected.Address(RVA = "0xBD896C", Offset = "0xBD896C", VA = "0xBD896C")]
	public void WingMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002262")]
	[Cpp2IlInjected.Address(RVA = "0xBD939C", Offset = "0xBD939C", VA = "0xBD939C")]
	public void MoonLeechRope()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002263")]
	[Cpp2IlInjected.Address(RVA = "0xBD9748", Offset = "0xBD9748", VA = "0xBD9748")]
	public void WOFTongue()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002264")]
	[Cpp2IlInjected.Address(RVA = "0xBD9F54", Offset = "0xBD9F54", VA = "0xBD9F54")]
	public void StatusFromNPC(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002265")]
	[Cpp2IlInjected.Address(RVA = "0xBDB388", Offset = "0xBDB388", VA = "0xBDB388")]
	public void GrappleMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002266")]
	[Cpp2IlInjected.Address(RVA = "0xBDCCD8", Offset = "0xBDCCD8", VA = "0xBDCCD8")]
	public void DoQueenSlimeHookTeleport(Vector2 targetPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002267")]
	[Cpp2IlInjected.Address(RVA = "0xBDBD04", Offset = "0xBDBD04", VA = "0xBDBD04")]
	private void GetGrapplingForces(Vector2 fromPosition, out int? preferredPlayerDirectionToSet, out float preferedPlayerVelocityX, out float preferedPlayerVelocityY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002268")]
	[Cpp2IlInjected.Address(RVA = "0xBDBCDC", Offset = "0xBDBCDC", VA = "0xBDBCDC")]
	private void RefreshMovementAbilities(bool doubleJumps = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002269")]
	[Cpp2IlInjected.Address(RVA = "0xBD32E4", Offset = "0xBD32E4", VA = "0xBD32E4")]
	private void RefreshDoubleJumps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600226A")]
	[Cpp2IlInjected.Address(RVA = "0xBDD998", Offset = "0xBDD998", VA = "0xBDD998")]
	public void StickyMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600226B")]
	[Cpp2IlInjected.Address(RVA = "0xBDE790", Offset = "0xBDE790", VA = "0xBDE790")]
	public bool HasLockedInventory()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600226C")]
	[Cpp2IlInjected.Address(RVA = "0xBDE794", Offset = "0xBDE794", VA = "0xBDE794")]
	public bool IsStackingItems()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600226D")]
	[Cpp2IlInjected.Address(RVA = "0xBDE814", Offset = "0xBDE814", VA = "0xBDE814")]
	public List<int> GetNearbyContainerProjectilesList()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600226E")]
	[Cpp2IlInjected.Address(RVA = "0xBDEB28", Offset = "0xBDEB28", VA = "0xBDEB28")]
	public void UpdateNearbyInteractibleProjectilesList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600226F")]
	[Cpp2IlInjected.Address(RVA = "0xBDEC4C", Offset = "0xBDEC4C", VA = "0xBDEC4C")]
	public bool IsProjectileInteractibleAndInInteractionRange(Projectile proj, ref Vector2 compareSpot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002270")]
	[Cpp2IlInjected.Address(RVA = "0xB86DE8", Offset = "0xB86DE8", VA = "0xB86DE8")]
	public bool useVoidBag()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002271")]
	[Cpp2IlInjected.Address(RVA = "0xBDED8C", Offset = "0xBDED8C", VA = "0xBDED8C")]
	public void QuickStackAllChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002272")]
	[Cpp2IlInjected.Address(RVA = "0xBDF99C", Offset = "0xBDF99C", VA = "0xBDF99C")]
	public void CheckDrowning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002273")]
	[Cpp2IlInjected.Address(RVA = "0xBE0108", Offset = "0xBE0108", VA = "0xBE0108")]
	public void CheckCrackedBrickBreak()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002274")]
	[Cpp2IlInjected.Address(RVA = "0xBE0E7C", Offset = "0xBE0E7C", VA = "0xBE0E7C")]
	public void CheckIceBreak()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002275")]
	[Cpp2IlInjected.Address(RVA = "0xBE1210", Offset = "0xBE1210", VA = "0xBE1210")]
	public void SlopeDownMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002276")]
	[Cpp2IlInjected.Address(RVA = "0xBE1344", Offset = "0xBE1344", VA = "0xBE1344")]
	public void ShimmerCollision(bool fallThrough, bool ignorePlats, bool noCollision)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002277")]
	[Cpp2IlInjected.Address(RVA = "0xBE17C0", Offset = "0xBE17C0", VA = "0xBE17C0")]
	public void HoneyCollision(bool fallThrough, bool ignorePlats)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002278")]
	[Cpp2IlInjected.Address(RVA = "0xBE19E4", Offset = "0xBE19E4", VA = "0xBE19E4")]
	public void WaterCollision(bool fallThrough, bool ignorePlats)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002279")]
	[Cpp2IlInjected.Address(RVA = "0xBE1568", Offset = "0xBE1568", VA = "0xBE1568")]
	private void TryFloatingInFluid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600227A")]
	[Cpp2IlInjected.Address(RVA = "0xBE1C08", Offset = "0xBE1C08", VA = "0xBE1C08")]
	public void DryCollision(bool fallThrough, bool ignorePlats)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600227B")]
	[Cpp2IlInjected.Address(RVA = "0xBE34EC", Offset = "0xBE34EC", VA = "0xBE34EC")]
	private bool TouchBlockSurfaceCenter(int x, int y, Tile tile, out int exitNormalX, out int exitNormalY, out Vector2 surfaceCenter)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600227C")]
	[Cpp2IlInjected.Address(RVA = "0xBE3260", Offset = "0xBE3260", VA = "0xBE3260")]
	public void SlopingCollision(bool fallThrough, bool ignorePlats)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600227D")]
	[Cpp2IlInjected.Address(RVA = "0xBE3BC4", Offset = "0xBE3BC4", VA = "0xBE3BC4")]
	public void FloorVisuals(bool Falling)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600227E")]
	[Cpp2IlInjected.Address(RVA = "0xBC0658", Offset = "0xBC0658", VA = "0xBC0658")]
	public void ResetFloorFlags()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600227F")]
	[Cpp2IlInjected.Address(RVA = "0xBE4040", Offset = "0xBE4040", VA = "0xBE4040")]
	public static Tile GetFloorTile(int x, int y)
	{
		return default(Tile);
	}

	[Cpp2IlInjected.Token(Token = "0x6002280")]
	[Cpp2IlInjected.Address(RVA = "0xBE5428", Offset = "0xBE5428", VA = "0xBE5428")]
	public static int GetFloorTileType(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002281")]
	[Cpp2IlInjected.Address(RVA = "0xBE4378", Offset = "0xBE4378", VA = "0xBE4378")]
	private void MakeFloorDust(bool Falling, int type, int paintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002282")]
	[Cpp2IlInjected.Address(RVA = "0xBE5520", Offset = "0xBE5520", VA = "0xBE5520")]
	public void BordersMovement()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002283")]
	[Cpp2IlInjected.Address(RVA = "0xBE5A6C", Offset = "0xBE5A6C", VA = "0xBE5A6C")]
	public void CollectTaxes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002284")]
	[Cpp2IlInjected.Address(RVA = "0xB8080C", Offset = "0xB8080C", VA = "0xB8080C")]
	public void GamepadEnableGrappleCooldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002285")]
	[Cpp2IlInjected.Address(RVA = "0xBE5D54", Offset = "0xBE5D54", VA = "0xBE5D54")]
	public void TryInterruptingItemUsage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002286")]
	[Cpp2IlInjected.Address(RVA = "0xBE6640", Offset = "0xBE6640", VA = "0xBE6640")]
	private bool CanMoveForwardOnRope(int dir, int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002287")]
	[Cpp2IlInjected.Address(RVA = "0xBE6990", Offset = "0xBE6990", VA = "0xBE6990")]
	public void UpdateHairDyeDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002288")]
	[Cpp2IlInjected.Address(RVA = "0xBE714C", Offset = "0xBE714C", VA = "0xBE714C")]
	public bool IsScopeActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002289")]
	[Cpp2IlInjected.Address(RVA = "0xBC22EC", Offset = "0xBC22EC", VA = "0xBC22EC")]
	public bool IsRightClickItemActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600228A")]
	[Cpp2IlInjected.Address(RVA = "0xBE7190", Offset = "0xBE7190", VA = "0xBE7190")]
	private bool CanUseItem()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600228B")]
	[Cpp2IlInjected.Address(RVA = "0xBE7C4C", Offset = "0xBE7C4C", VA = "0xBE7C4C")]
	public bool CheckPulley()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600228C")]
	[Cpp2IlInjected.Address(RVA = "0xBE81D8", Offset = "0xBE81D8", VA = "0xBE81D8")]
	public bool CheckCuteFishron()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600228D")]
	[Cpp2IlInjected.Address(RVA = "0xBE83F0", Offset = "0xBE83F0", VA = "0xBE83F0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390704", Offset = "0x390704")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390704", Offset = "0x390704")]
	public void Update(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600228E")]
	[Cpp2IlInjected.Address(RVA = "0xB8DD28", Offset = "0xB8DD28", VA = "0xB8DD28")]
	public void ResetToHellAndBackIfNotCompleted()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600228F")]
	[Cpp2IlInjected.Address(RVA = "0xC0B440", Offset = "0xC0B440", VA = "0xC0B440")]
	private void TryToShimmerUnstuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002290")]
	[Cpp2IlInjected.Address(RVA = "0xC0C000", Offset = "0xC0C000", VA = "0xC0C000")]
	private void ShimmerUnstuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002291")]
	[Cpp2IlInjected.Address(RVA = "0xC0C288", Offset = "0xC0C288", VA = "0xC0C288")]
	private Vector2? TryFindingShimmerFreeSpot()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002292")]
	[Cpp2IlInjected.Address(RVA = "0xC02E44", Offset = "0xC02E44", VA = "0xC02E44")]
	private void AdjustRemainingPotionSickness()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002293")]
	[Cpp2IlInjected.Address(RVA = "0xC0AC54", Offset = "0xC0AC54", VA = "0xC0AC54")]
	private Collision.HurtTile GetHurtTile()
	{
		return default(Collision.HurtTile);
	}

	[Cpp2IlInjected.Token(Token = "0x6002294")]
	[Cpp2IlInjected.Address(RVA = "0xC0AFF8", Offset = "0xC0AFF8", VA = "0xC0AFF8")]
	private void ApplyTouchDamage(int tileId, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002295")]
	[Cpp2IlInjected.Address(RVA = "0xC03BE8", Offset = "0xC03BE8", VA = "0xC03BE8")]
	private void CapAttackSpeeds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002296")]
	[Cpp2IlInjected.Address(RVA = "0xC0C82C", Offset = "0xC0C82C", VA = "0xC0C82C")]
	private float TurnAttackSpeedToUseTimeMultiplier(float speed)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002297")]
	[Cpp2IlInjected.Address(RVA = "0xC02F5C", Offset = "0xC02F5C", VA = "0xC02F5C")]
	public void UpdateLuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002298")]
	[Cpp2IlInjected.Address(RVA = "0xC0CA20", Offset = "0xC0CA20", VA = "0xC0CA20")]
	private void ResetControls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002299")]
	[Cpp2IlInjected.Address(RVA = "0xC03E84", Offset = "0xC03E84", VA = "0xC03E84")]
	private void UpdateControlHolds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600229A")]
	[Cpp2IlInjected.Address(RVA = "0xC01200", Offset = "0xC01200", VA = "0xC01200")]
	public void TryOpeningFullscreenMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600229B")]
	[Cpp2IlInjected.Address(RVA = "0xC0C854", Offset = "0xC0C854", VA = "0xC0C854")]
	public void UpdateLuckFactors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600229C")]
	[Cpp2IlInjected.Address(RVA = "0xC0C950", Offset = "0xC0C950", VA = "0xC0C950")]
	public void RecalculateLuck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600229D")]
	[Cpp2IlInjected.Address(RVA = "0xC0CA5C", Offset = "0xC0CA5C", VA = "0xC0CA5C")]
	public static int GetMouseScrollDelta()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600229E")]
	[Cpp2IlInjected.Address(RVA = "0xC03074", Offset = "0xC03074", VA = "0xC03074")]
	private void UpdatePortableStoolUsage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600229F")]
	[Cpp2IlInjected.Address(RVA = "0xBC6CF0", Offset = "0xBC6CF0", VA = "0xBC6CF0")]
	private void ResizeHitbox()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A0")]
	[Cpp2IlInjected.Address(RVA = "0xC0BFB8", Offset = "0xC0BFB8", VA = "0xC0BFB8")]
	private void UpdateReleaseUseTile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A1")]
	[Cpp2IlInjected.Address(RVA = "0xC09F14", Offset = "0xC09F14", VA = "0xC09F14")]
	private void GetMinecartDamage(float currentSpeed, out int damage, out float knockback)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A2")]
	[Cpp2IlInjected.Address(RVA = "0xC00794", Offset = "0xC00794", VA = "0xC00794")]
	public void UpdateMiscCounter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A3")]
	[Cpp2IlInjected.Address(RVA = "0xC03FBC", Offset = "0xC03FBC", VA = "0xC03FBC")]
	private void WingAirLogicTweaks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A4")]
	[Cpp2IlInjected.Address(RVA = "0xC08E7C", Offset = "0xC08E7C", VA = "0xC08E7C")]
	private void RocketBootVisuals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A5")]
	[Cpp2IlInjected.Address(RVA = "0xC06520", Offset = "0xC06520", VA = "0xC06520")]
	public void WingFrame(bool wingFlap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A6")]
	[Cpp2IlInjected.Address(RVA = "0xC098DC", Offset = "0xC098DC", VA = "0xC098DC")]
	public bool ShouldDrawWingsThatAreAlwaysAnimated()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022A7")]
	[Cpp2IlInjected.Address(RVA = "0xC040C0", Offset = "0xC040C0", VA = "0xC040C0")]
	private void WingAirVisuals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A8")]
	[Cpp2IlInjected.Address(RVA = "0xC02590", Offset = "0xC02590", VA = "0xC02590")]
	private void HandleBeingInChestRange()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022A9")]
	[Cpp2IlInjected.Address(RVA = "0xC0CAE8", Offset = "0xC0CAE8", VA = "0xC0CAE8")]
	public bool IsInInteractionRangeToMultiTileHitbox(int chestPointX, int chestPointY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022AA")]
	[Cpp2IlInjected.Address(RVA = "0xBC0668", Offset = "0xBC0668", VA = "0xBC0668")]
	public void ResetVisibleAccessories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022AB")]
	[Cpp2IlInjected.Address(RVA = "0xC03114", Offset = "0xC03114", VA = "0xC03114")]
	public void UpdateArmorLights()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022AC")]
	[Cpp2IlInjected.Address(RVA = "0xC0A1D0", Offset = "0xC0A1D0", VA = "0xC0A1D0")]
	public void Update_NPCCollision()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022AD")]
	[Cpp2IlInjected.Address(RVA = "0xC0CF54", Offset = "0xC0CF54", VA = "0xC0CF54")]
	public bool CanParryAgainst(Rectangle blockingPlayerRect, Rectangle enemyRect, Vector2 enemyVelocity)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022AE")]
	[Cpp2IlInjected.Address(RVA = "0xC007AC", Offset = "0xC007AC", VA = "0xC007AC")]
	private void PurgeDD2EnergyCrystals()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022AF")]
	[Cpp2IlInjected.Address(RVA = "0xC0B530", Offset = "0xC0B530", VA = "0xC0B530")]
	public void ItemCheck_ManageRightClickFeatures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B0")]
	[Cpp2IlInjected.Address(RVA = "0xC0D114", Offset = "0xC0D114", VA = "0xC0D114")]
	public void ItemCheck_ManageRightClickFeatures_ShieldRaise(bool theGeneralCheck)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B1")]
	[Cpp2IlInjected.Address(RVA = "0xC0D4E0", Offset = "0xC0D4E0", VA = "0xC0D4E0")]
	public void TryTogglingShield(bool shouldGuard)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B2")]
	[Cpp2IlInjected.Address(RVA = "0xC01B2C", Offset = "0xC01B2C", VA = "0xC01B2C")]
	private void HandleHotbar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B3")]
	[Cpp2IlInjected.Address(RVA = "0xC0BC84", Offset = "0xC0BC84", VA = "0xC0BC84")]
	private void ItemCheckWrapped(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B4")]
	[Cpp2IlInjected.Address(RVA = "0xC0D55C", Offset = "0xC0D55C", VA = "0xC0D55C")]
	private void ForceForwardCursor(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B5")]
	[Cpp2IlInjected.Address(RVA = "0xC0D85C", Offset = "0xC0D85C", VA = "0xC0D85C")]
	private void ForceSmartSelectCursor(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B6")]
	[Cpp2IlInjected.Address(RVA = "0xC02070", Offset = "0xC02070", VA = "0xC02070")]
	public void UpdateChangeItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B7")]
	[Cpp2IlInjected.Address(RVA = "0xC112D0", Offset = "0xC112D0", VA = "0xC112D0")]
	public void ScrollHotbar(int Offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022B8")]
	[Cpp2IlInjected.Address(RVA = "0xBE65E4", Offset = "0xBE65E4", VA = "0xBE65E4")]
	private static int ClampHotbarOffset(int Offset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60022B9")]
	[Cpp2IlInjected.Address(RVA = "0xC114B0", Offset = "0xC114B0", VA = "0xC114B0")]
	public List<int> GetListOfProjectilesToInteractWithHack()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60022BA")]
	[Cpp2IlInjected.Address(RVA = "0xB80698", Offset = "0xB80698", VA = "0xB80698")]
	public void LockGamepadTileInteractions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022BB")]
	[Cpp2IlInjected.Address(RVA = "0xC016A8", Offset = "0xC016A8", VA = "0xC016A8")]
	public void LookForTileInteractions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022BC")]
	[Cpp2IlInjected.Address(RVA = "0xC12004", Offset = "0xC12004", VA = "0xC12004")]
	private void TryInteractingWithMinecartTrackInNearbyArea(int selectedTargetX, int selectedTargetY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022BD")]
	[Cpp2IlInjected.Address(RVA = "0xC12340", Offset = "0xC12340", VA = "0xC12340")]
	public bool InInteractionRange(int interactX, int interactY, TileReachCheckSettings settings)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022BE")]
	[Cpp2IlInjected.Address(RVA = "0xBDEA28", Offset = "0xBDEA28", VA = "0xBDEA28")]
	public bool IsInTileInteractionRange(int targetX, int targetY, TileReachCheckSettings settings)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022BF")]
	[Cpp2IlInjected.Address(RVA = "0xC11F28", Offset = "0xC11F28", VA = "0xC11F28")]
	public void TileInteractionsCheck(int myX, int myY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C0")]
	[Cpp2IlInjected.Address(RVA = "0xC114B8", Offset = "0xC114B8", VA = "0xC114B8")]
	private void TileInteractionsCheckLongDistance(int myX, int myY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C1")]
	[Cpp2IlInjected.Address(RVA = "0xC17170", Offset = "0xC17170", VA = "0xC17170")]
	private void TileInteractionsUse(int myX, int myY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C2")]
	[Cpp2IlInjected.Address(RVA = "0xC1F3F4", Offset = "0xC1F3F4", VA = "0xC1F3F4")]
	private static bool IsHoveringOverABottomSideOfABed(int myX, int myY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022C3")]
	[Cpp2IlInjected.Address(RVA = "0xC1FCA8", Offset = "0xC1FCA8", VA = "0xC1FCA8")]
	public void PetAnimal(int animalNpcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C4")]
	[Cpp2IlInjected.Address(RVA = "0xC20044", Offset = "0xC20044", VA = "0xC20044")]
	private void GetPettingInfo(int animalNpcIndex, out int targetDirection, out Vector2 playerPositionWhenPetting, out bool isPetSmall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C5")]
	[Cpp2IlInjected.Address(RVA = "0xC20234", Offset = "0xC20234", VA = "0xC20234")]
	public bool CanSnapToPosition(Vector2 offset)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022C6")]
	[Cpp2IlInjected.Address(RVA = "0xC2069C", Offset = "0xC2069C", VA = "0xC2069C")]
	private void TryAllowingSnappingToPosition(ref bool canSnapToPosition, Vector2 pos1, Vector2 pos2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C7")]
	[Cpp2IlInjected.Address(RVA = "0xBD6390", Offset = "0xBD6390", VA = "0xBD6390")]
	public void StopVanityActions(bool multiplayerBroadcast = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C8")]
	[Cpp2IlInjected.Address(RVA = "0xC2068C", Offset = "0xC2068C", VA = "0xC2068C")]
	private void StopPettingAnimal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022C9")]
	[Cpp2IlInjected.Address(RVA = "0xC03C3C", Offset = "0xC03C3C", VA = "0xC03C3C")]
	private void UpdatePettingAnimal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022CA")]
	[Cpp2IlInjected.Address(RVA = "0xC1FA98", Offset = "0xC1FA98", VA = "0xC1FA98")]
	private void OpenChest(int x, int y, int newChest)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022CB")]
	[Cpp2IlInjected.Address(RVA = "0xC1F9B0", Offset = "0xC1F9B0", VA = "0xC1F9B0")]
	public void CloseSign()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022CC")]
	[Cpp2IlInjected.Address(RVA = "0xB8A05C", Offset = "0xB8A05C", VA = "0xB8A05C")]
	private void LaunchMinecartHook(int myX, int myY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022CD")]
	[Cpp2IlInjected.Address(RVA = "0xBA8D6C", Offset = "0xBA8D6C", VA = "0xBA8D6C")]
	public void RemoveAllGrapplingHooks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022CE")]
	[Cpp2IlInjected.Address(RVA = "0xC209EC", Offset = "0xC209EC", VA = "0xC209EC")]
	public void RemoveAllFishingBobbers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022CF")]
	[Cpp2IlInjected.Address(RVA = "0xC12670", Offset = "0xC12670", VA = "0xC12670")]
	private void TileInteractionsMouseOver(int myX, int myY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D0")]
	[Cpp2IlInjected.Address(RVA = "0xC20B34", Offset = "0xC20B34", VA = "0xC20B34")]
	public Color ChatColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60022D1")]
	[Cpp2IlInjected.Address(RVA = "0xC1E640", Offset = "0xC1E640", VA = "0xC1E640")]
	private void TileInteractionsMouseOver_Containers(int myX, int myY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D2")]
	[Cpp2IlInjected.Address(RVA = "0xBE2FE4", Offset = "0xBE2FE4", VA = "0xBE2FE4")]
	private void TryLandingOnDetonator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D3")]
	[Cpp2IlInjected.Address(RVA = "0xBE2CB8", Offset = "0xBE2CB8", VA = "0xBE2CB8")]
	private void TryBouncingBlocks(bool Falling)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D4")]
	[Cpp2IlInjected.Address(RVA = "0xC20C44", Offset = "0xC20C44", VA = "0xC20C44")]
	public bool CanAcceptItemIntoInventory(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022D5")]
	[Cpp2IlInjected.Address(RVA = "0xC09958", Offset = "0xC09958", VA = "0xC09958")]
	private void GrabItems(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D6")]
	[Cpp2IlInjected.Address(RVA = "0xC215B8", Offset = "0xC215B8", VA = "0xC215B8")]
	private void PullItem_ToVoidVault(Item itemToPickUp)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D7")]
	[Cpp2IlInjected.Address(RVA = "0xC215DC", Offset = "0xC215DC", VA = "0xC215DC")]
	private void PullItem_Common(Item itemToPickUp, float xPullSpeed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D8")]
	[Cpp2IlInjected.Address(RVA = "0xC21438", Offset = "0xC21438", VA = "0xC21438")]
	private void PullItem_Pickup(Item itemToPickUp, float speed, int acc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022D9")]
	[Cpp2IlInjected.Address(RVA = "0xC20CEC", Offset = "0xC20CEC", VA = "0xC20CEC")]
	private Item PickupItem(int playerIndex, int worldItemArrayIndex, Item itemToPickUp)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60022DA")]
	[Cpp2IlInjected.Address(RVA = "0xC21B68", Offset = "0xC21B68", VA = "0xC21B68")]
	public void Heal(int amount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022DB")]
	[Cpp2IlInjected.Address(RVA = "0xC21C1C", Offset = "0xC21C1C", VA = "0xC21C1C")]
	public int GetItemGrabRange(Item item)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60022DC")]
	[Cpp2IlInjected.Address(RVA = "0xC21DA4", Offset = "0xC21DA4", VA = "0xC21DA4")]
	public long SellItemAmount(Item item, int stack = -1)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60022DD")]
	[Cpp2IlInjected.Address(RVA = "0xC222C4", Offset = "0xC222C4", VA = "0xC222C4")]
	public bool SellItem(Item item, int stack = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022DE")]
	[Cpp2IlInjected.Address(RVA = "0xC22B30", Offset = "0xC22B30", VA = "0xC22B30")]
	public void RefreshItems(bool onlyIfVariantChanged = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022DF")]
	[Cpp2IlInjected.Address(RVA = "0xC22C7C", Offset = "0xC22C7C", VA = "0xC22C7C")]
	private void RefreshItems(Item[] array, bool onlyIfVariantChanged)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022E0")]
	[Cpp2IlInjected.Address(RVA = "0xC21F50", Offset = "0xC21F50", VA = "0xC21F50")]
	public void GetItemExpectedPrice(Item item, out long calcForSelling, out long calcForBuying)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022E1")]
	[Cpp2IlInjected.Address(RVA = "0xC22CCC", Offset = "0xC22CCC", VA = "0xC22CCC")]
	public bool CanAffordItem(long price, int customCurrency = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022E2")]
	[Cpp2IlInjected.Address(RVA = "0xC254BC", Offset = "0xC254BC", VA = "0xC254BC")]
	public bool BuyItem(long price, int customCurrency = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022E3")]
	[Cpp2IlInjected.Address(RVA = "0xC262EC", Offset = "0xC262EC", VA = "0xC262EC")]
	private static bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022E4")]
	[Cpp2IlInjected.Address(RVA = "0xC0216C", Offset = "0xC0216C", VA = "0xC0216C")]
	public void AdjTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022E5")]
	[Cpp2IlInjected.Address(RVA = "0xC27610", Offset = "0xC27610", VA = "0xC27610")]
	public bool IsTileTypeInInteractionRange(int targetTileType, TileReachCheckSettings settings)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022E6")]
	[Cpp2IlInjected.Address(RVA = "0xC278D8", Offset = "0xC278D8", VA = "0xC278D8")]
	public void DisplayDollUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022E7")]
	[Cpp2IlInjected.Address(RVA = "0xC27970", Offset = "0xC27970", VA = "0xC27970")]
	public bool IsColorfulDye(int dye)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022E8")]
	[Cpp2IlInjected.Address(RVA = "0xC27A0C", Offset = "0xC27A0C", VA = "0xC27A0C")]
	public bool ShouldDrawFootball()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022E9")]
	[Cpp2IlInjected.Address(RVA = "0xBFC558", Offset = "0xBFC558", VA = "0xBFC558")]
	public void PlayerFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022EA")]
	[Cpp2IlInjected.Address(RVA = "0xC03E60", Offset = "0xC03E60", VA = "0xC03E60")]
	private void CancelAllJumpVisualEffects()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022EB")]
	[Cpp2IlInjected.Address(RVA = "0xC28904", Offset = "0xC28904", VA = "0xC28904")]
	private void CancelAllBootRunVisualEffects()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022EC")]
	[Cpp2IlInjected.Address(RVA = "0xBB592C", Offset = "0xBB592C", VA = "0xBB592C")]
	private void UpdateFishingBobber(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022ED")]
	[Cpp2IlInjected.Address(RVA = "0xBB5770", Offset = "0xBB5770", VA = "0xBB5770")]
	private void UpdateBootVisualEffects(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022EE")]
	[Cpp2IlInjected.Address(RVA = "0xC27A6C", Offset = "0xC27A6C", VA = "0xC27A6C")]
	private void UpdateVisibleAccessories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022EF")]
	[Cpp2IlInjected.Address(RVA = "0xC28920", Offset = "0xC28920", VA = "0xC28920")]
	private bool ItemIsVisuallyIncompatible(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022F0")]
	[Cpp2IlInjected.Address(RVA = "0xC28F28", Offset = "0xC28F28", VA = "0xC28F28")]
	private bool IsVisibleCapeBad(int accFrontSlot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022F1")]
	[Cpp2IlInjected.Address(RVA = "0xC28B34", Offset = "0xC28B34", VA = "0xC28B34")]
	private void UpdateVisibleAccessory(int itemSlot, Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F2")]
	[Cpp2IlInjected.Address(RVA = "0xC280C0", Offset = "0xC280C0", VA = "0xC280C0")]
	public void SetArmorEffectVisuals(Player drawPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F3")]
	[Cpp2IlInjected.Address(RVA = "0xC27C20", Offset = "0xC27C20", VA = "0xC27C20")]
	public static int SetMatch(SetMatchRequest request, ref bool somethingSpecial)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60022F4")]
	[Cpp2IlInjected.Address(RVA = "0xBDD064", Offset = "0xBDD064", VA = "0xBDD064")]
	public void Teleport(Vector2 newPos, int Style = 0, int extraInfo = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F5")]
	[Cpp2IlInjected.Address(RVA = "0xC28F44", Offset = "0xC28F44", VA = "0xC28F44")]
	public void DoPotionOfReturnTeleportationAndSetTheComebackPoint()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F6")]
	[Cpp2IlInjected.Address(RVA = "0xC290E0", Offset = "0xC290E0", VA = "0xC290E0")]
	public void DoPotionOfReturnReturnToOriginalUsePosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F7")]
	[Cpp2IlInjected.Address(RVA = "0xC292A8", Offset = "0xC292A8", VA = "0xC292A8")]
	public void AutoFinchStaff()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F8")]
	[Cpp2IlInjected.Address(RVA = "0xBC0680", Offset = "0xBC0680", VA = "0xBC0680")]
	public void Spawn(PlayerSpawnContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022F9")]
	[Cpp2IlInjected.Address(RVA = "0xC29868", Offset = "0xC29868", VA = "0xC29868")]
	public bool Spawn_GetPositionAtWorldSpawn(ref int floorX, ref int floorY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022FA")]
	[Cpp2IlInjected.Address(RVA = "0xC29540", Offset = "0xC29540", VA = "0xC29540")]
	private void Spawn_SetPositionAtWorldSpawn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022FB")]
	[Cpp2IlInjected.Address(RVA = "0xC29C3C", Offset = "0xC29C3C", VA = "0xC29C3C")]
	private static int Spawn_DescendFromDefaultSpace(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60022FC")]
	[Cpp2IlInjected.Address(RVA = "0xC29DBC", Offset = "0xC29DBC", VA = "0xC29DBC")]
	private static void Spawn_ForceClearArea(int floorX, int floorY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022FD")]
	[Cpp2IlInjected.Address(RVA = "0xC299C4", Offset = "0xC299C4", VA = "0xC299C4")]
	private bool Spawn_IsAreaAValidWorldSpawn(int floorX, int floorY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60022FE")]
	[Cpp2IlInjected.Address(RVA = "0xC29504", Offset = "0xC29504", VA = "0xC29504")]
	private void Spawn_SetPosition(int floorX, int floorY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60022FF")]
	[Cpp2IlInjected.Address(RVA = "0xC2A020", Offset = "0xC2A020", VA = "0xC2A020")]
	public void SetImmuneTimeForAllTypes(int time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002300")]
	[Cpp2IlInjected.Address(RVA = "0xC2A070", Offset = "0xC2A070", VA = "0xC2A070")]
	public void ShadowDodge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002301")]
	[Cpp2IlInjected.Address(RVA = "0xC2A240", Offset = "0xC2A240", VA = "0xC2A240")]
	private void PutHallowedArmorSetBonusOnCooldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002302")]
	[Cpp2IlInjected.Address(RVA = "0xC2A24C", Offset = "0xC2A24C", VA = "0xC2A24C")]
	public void BrainOfConfusionDodge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002303")]
	[Cpp2IlInjected.Address(RVA = "0xC2A3C0", Offset = "0xC2A3C0", VA = "0xC2A3C0")]
	public void NinjaDodge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002304")]
	[Cpp2IlInjected.Address(RVA = "0xBB957C", Offset = "0xBB957C", VA = "0xBB957C")]
	public void ApplyArmorSoundAndDustChanges()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002305")]
	[Cpp2IlInjected.Address(RVA = "0xBA5810", Offset = "0xBA5810", VA = "0xBA5810")]
	public double Hurt(PlayerDeathReason damageSource, int Damage, int hitDirection, bool pvp = false, bool quiet = false, bool Crit = false, int cooldownCounter = -1, bool dodgeable = true)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002306")]
	[Cpp2IlInjected.Address(RVA = "0xC2AFE4", Offset = "0xC2AFE4", VA = "0xC2AFE4")]
	private static bool AllowShimmerDodge(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002307")]
	[Cpp2IlInjected.Address(RVA = "0xC2B208", Offset = "0xC2B208", VA = "0xC2B208")]
	public void KillMeForGood()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002308")]
	[Cpp2IlInjected.Address(RVA = "0xBC8A68", Offset = "0xBC8A68", VA = "0xBC8A68")]
	public void KillMe(PlayerDeathReason damageSource, double dmg, int hitDirection, bool pvp = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002309")]
	[Cpp2IlInjected.Address(RVA = "0xC2B6BC", Offset = "0xC2B6BC", VA = "0xC2B6BC")]
	private int GetRespawnTime(bool pvp)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600230A")]
	[Cpp2IlInjected.Address(RVA = "0xC2BF7C", Offset = "0xC2BF7C", VA = "0xC2BF7C")]
	public void DropTombstone(long coinsOwned, NetworkText deathText, int hitDirection)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600230B")]
	[Cpp2IlInjected.Address(RVA = "0xC21428", Offset = "0xC21428", VA = "0xC21428")]
	public bool CanPullItem(Item item, ItemSpaceStatus status)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600230C")]
	[Cpp2IlInjected.Address(RVA = "0xC2C608", Offset = "0xC2C608", VA = "0xC2C608")]
	public ItemSpaceStatus ItemSpace(Item newItem)
	{
		return default(ItemSpaceStatus);
	}

	[Cpp2IlInjected.Token(Token = "0x600230D")]
	[Cpp2IlInjected.Address(RVA = "0xC21210", Offset = "0xC21210", VA = "0xC21210")]
	public void ItemSpace(Item newItem, ref ItemSpaceStatus result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600230E")]
	[Cpp2IlInjected.Address(RVA = "0xC2C8F0", Offset = "0xC2C8F0", VA = "0xC2C8F0")]
	public bool ItemSpaceForCofveve(Item newItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600230F")]
	[Cpp2IlInjected.Address(RVA = "0xC2C844", Offset = "0xC2C844", VA = "0xC2C844")]
	public bool CanItemSlotAccept(Item theSlot, Item theItemToAccept)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002310")]
	[Cpp2IlInjected.Address(RVA = "0xC2C890", Offset = "0xC2C890", VA = "0xC2C890")]
	public bool CanGoIntoAmmoOnPickup(Item theSlot, Item theItemToAccept)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002311")]
	[Cpp2IlInjected.Address(RVA = "0xC22A00", Offset = "0xC22A00", VA = "0xC22A00")]
	public bool DoCoins(int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002312")]
	[Cpp2IlInjected.Address(RVA = "0xC2C9D0", Offset = "0xC2C9D0", VA = "0xC2C9D0")]
	public bool CanFillAmmo(int plr, Item newItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002313")]
	[Cpp2IlInjected.Address(RVA = "0xC2CAE4", Offset = "0xC2CAE4", VA = "0xC2CAE4")]
	public Item FillAmmo(int plr, Item newItem, GetItemSettings settings)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002314")]
	[Cpp2IlInjected.Address(RVA = "0xC2CFBC", Offset = "0xC2CFBC", VA = "0xC2CFBC")]
	public bool CanStoreItem(int plr, Item newItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002315")]
	[Cpp2IlInjected.Address(RVA = "0xB82B38", Offset = "0xB82B38", VA = "0xB82B38")]
	public Item GetItem(int plr, Item newItem, GetItemSettings settings, bool disableMerge = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002316")]
	[Cpp2IlInjected.Address(RVA = "0xC2D4B0", Offset = "0xC2D4B0", VA = "0xC2D4B0")]
	private bool GetItem_VoidVault(int plr, Item[] inventory, Item newItem, GetItemSettings settings, Item returnItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002317")]
	[Cpp2IlInjected.Address(RVA = "0xC2C9AC", Offset = "0xC2C9AC", VA = "0xC2C9AC")]
	private bool CanVoidVaultAccept(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002318")]
	[Cpp2IlInjected.Address(RVA = "0xC2D9C4", Offset = "0xC2D9C4", VA = "0xC2D9C4")]
	private bool GetItem_FillIntoOccupiedSlot_VoidBag(int plr, Item[] inv, Item newItem, GetItemSettings settings, Item returnItem, int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002319")]
	[Cpp2IlInjected.Address(RVA = "0xC2DC24", Offset = "0xC2DC24", VA = "0xC2DC24")]
	private bool GetItem_FillIntoOccupiedSlot(int plr, Item newItem, GetItemSettings settings, Item returnItem, int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600231A")]
	[Cpp2IlInjected.Address(RVA = "0xC2D7A4", Offset = "0xC2D7A4", VA = "0xC2D7A4")]
	private bool GetItem_FillEmptyInventorySlot_VoidBag(int plr, Item[] inv, Item newItem, GetItemSettings settings, Item returnItem, int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600231B")]
	[Cpp2IlInjected.Address(RVA = "0xC2D1C8", Offset = "0xC2D1C8", VA = "0xC2D1C8")]
	private bool GetItem_FillEmptyInventorySlot(int plr, Item newItem, GetItemSettings settings, Item returnItem, int i, bool disableMerge)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600231C")]
	[Cpp2IlInjected.Address(RVA = "0xC2DFB8", Offset = "0xC2DFB8", VA = "0xC2DFB8")]
	public void PlaceThing(ref ItemCheckContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600231D")]
	[Cpp2IlInjected.Address(RVA = "0xC30E74", Offset = "0xC30E74", VA = "0xC30E74")]
	private void PlaceThing_Walls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600231E")]
	[Cpp2IlInjected.Address(RVA = "0xC31BF0", Offset = "0xC31BF0", VA = "0xC31BF0")]
	private void PlaceThing_Walls_FillEmptySpace()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600231F")]
	[Cpp2IlInjected.Address(RVA = "0xC30634", Offset = "0xC30634", VA = "0xC30634")]
	private void PlaceThing_Tiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002320")]
	[Cpp2IlInjected.Address(RVA = "0xC38E68", Offset = "0xC38E68", VA = "0xC38E68")]
	private bool ModifyFlexibleWandPlacementInfo(ref int tileType, ref int tileStyle, ref int? forcedRandom)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002321")]
	[Cpp2IlInjected.Address(RVA = "0xC318F0", Offset = "0xC318F0", VA = "0xC318F0")]
	private bool PlaceThing_TryReplacingWalls(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002322")]
	[Cpp2IlInjected.Address(RVA = "0xC3919C", Offset = "0xC3919C", VA = "0xC3919C")]
	private bool PlaceThing_ValidWallForReplacement()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002323")]
	[Cpp2IlInjected.Address(RVA = "0xC32BB8", Offset = "0xC32BB8", VA = "0xC32BB8")]
	private bool PlaceThing_TryReplacingTiles(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002324")]
	[Cpp2IlInjected.Address(RVA = "0xC392B8", Offset = "0xC392B8", VA = "0xC392B8")]
	private bool PlaceThing_ValidTileForReplacement()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002325")]
	[Cpp2IlInjected.Address(RVA = "0xC3B8C0", Offset = "0xC3B8C0", VA = "0xC3B8C0")]
	private bool PlaceThing_CheckSpecificValidtyCaseForBlockSwap(int tileTypeBeingPlaced, int tileTypeCurrentlyPlaced)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002326")]
	[Cpp2IlInjected.Address(RVA = "0xC39C50", Offset = "0xC39C50", VA = "0xC39C50")]
	public Item GetBestPickaxe()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002327")]
	[Cpp2IlInjected.Address(RVA = "0xC3862C", Offset = "0xC3862C", VA = "0xC3862C")]
	private TileObject PlaceThing_Tiles_PlaceIt(bool newObjectType, TileObject data, int tileToCreate)
	{
		return default(TileObject);
	}

	[Cpp2IlInjected.Token(Token = "0x6002328")]
	[Cpp2IlInjected.Address(RVA = "0xC3E708", Offset = "0xC3E708", VA = "0xC3E708")]
	public void PlaceThing_Tiles_PlaceIt_ConsumeFlexibleWandMaterial()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002329")]
	[Cpp2IlInjected.Address(RVA = "0xC3AA30", Offset = "0xC3AA30", VA = "0xC3AA30")]
	public int BiomeTorchPlaceStyle(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600232A")]
	[Cpp2IlInjected.Address(RVA = "0xC3F248", Offset = "0xC3F248", VA = "0xC3F248")]
	public int BiomeTorchHoldStyle(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600232B")]
	[Cpp2IlInjected.Address(RVA = "0xC3ACF8", Offset = "0xC3ACF8", VA = "0xC3ACF8")]
	public int BiomeCampfirePlaceStyle(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600232C")]
	[Cpp2IlInjected.Address(RVA = "0xC3F4FC", Offset = "0xC3F4FC", VA = "0xC3F4FC")]
	public int BiomeCampfireHoldStyle(int itemType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600232D")]
	[Cpp2IlInjected.Address(RVA = "0xC3A868", Offset = "0xC3A868", VA = "0xC3A868")]
	private int[,] PlaceThing_Tiles_GetAutoAccessoryCache()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600232E")]
	[Cpp2IlInjected.Address(RVA = "0xC3BB20", Offset = "0xC3BB20", VA = "0xC3BB20")]
	private int PlaceThing_Tiles_PlaceIt_GetLegacyTileStyle(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600232F")]
	[Cpp2IlInjected.Address(RVA = "0xC3E810", Offset = "0xC3E810", VA = "0xC3E810")]
	private void PlaceThing_Tiles_PlaceIt_UnslopeForSolids()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002330")]
	[Cpp2IlInjected.Address(RVA = "0xC3EDCC", Offset = "0xC3EDCC", VA = "0xC3EDCC")]
	private void PlaceThing_Tiles_PlaceIt_KillGrassForSolids()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002331")]
	[Cpp2IlInjected.Address(RVA = "0xC3AFC0", Offset = "0xC3AFC0", VA = "0xC3AFC0")]
	private void PlaceThing_Tiles_PlaceIt_AutoPaintAndActuate(int[,] typeCaches, int tileToCreate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002332")]
	[Cpp2IlInjected.Address(RVA = "0xC3C700", Offset = "0xC3C700", VA = "0xC3C700")]
	private void PlaceThing_Tiles_PlaceIt_SpinSmartPlatform()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002333")]
	[Cpp2IlInjected.Address(RVA = "0xC3C530", Offset = "0xC3C530", VA = "0xC3C530")]
	private void PlaceThing_Tiles_PlaceIt_TriggerLogicLamp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002334")]
	[Cpp2IlInjected.Address(RVA = "0xC3BFD4", Offset = "0xC3BFD4", VA = "0xC3BFD4")]
	private void PlaceThing_Tiles_PlaceIt_SpinBedsAndBaths()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002335")]
	[Cpp2IlInjected.Address(RVA = "0xC3BD8C", Offset = "0xC3BD8C", VA = "0xC3BD8C")]
	private void PlaceThing_Tiles_PlaceIt_SpinChairs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002336")]
	[Cpp2IlInjected.Address(RVA = "0xC3C344", Offset = "0xC3C344", VA = "0xC3C344")]
	private void PlaceThing_Tiles_PlaceIt_SpinTraps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002337")]
	[Cpp2IlInjected.Address(RVA = "0xC3C104", Offset = "0xC3C104", VA = "0xC3C104")]
	private void PlaceThing_Tiles_PlaceIt_AdjustPlants()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002338")]
	[Cpp2IlInjected.Address(RVA = "0xC3F7B4", Offset = "0xC3F7B4", VA = "0xC3F7B4")]
	private bool PlaceThing_Tiles_PlaceIt_StaffOfRegrowthCheck(bool placed)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002339")]
	[Cpp2IlInjected.Address(RVA = "0xC33AE8", Offset = "0xC33AE8", VA = "0xC33AE8")]
	private bool PlaceThing_Tiles_BlockPlacementForAssortedThings(bool canPlace)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600233A")]
	[Cpp2IlInjected.Address(RVA = "0xC337EC", Offset = "0xC337EC", VA = "0xC337EC")]
	private static void PlaceThing_Tiles_BlockPlacementForRepeatedPumpkins(ref bool canPlace, ref TileObject data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600233B")]
	[Cpp2IlInjected.Address(RVA = "0xC338F4", Offset = "0xC338F4", VA = "0xC338F4")]
	private static void PlaceThing_Tiles_BlockPlacementForRepeatedCoralAndBeachPiles(ref bool canPlace, ref TileObject data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600233C")]
	[Cpp2IlInjected.Address(RVA = "0xC336B4", Offset = "0xC336B4", VA = "0xC336B4")]
	private static void PlaceThing_Tiles_BlockPlacementForRepeatedPigronatas(ref bool canPlace, ref TileObject data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600233D")]
	[Cpp2IlInjected.Address(RVA = "0xC33500", Offset = "0xC33500", VA = "0xC33500")]
	private static void PlaceThing_Tiles_BlockPlacementIfOverPlayers(ref bool canPlace, ref TileObject data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600233E")]
	[Cpp2IlInjected.Address(RVA = "0xC32108", Offset = "0xC32108", VA = "0xC32108")]
	private bool PlaceThing_Tiles_CheckLavaBlocking()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600233F")]
	[Cpp2IlInjected.Address(RVA = "0xC324DC", Offset = "0xC324DC", VA = "0xC324DC")]
	private bool PlaceThing_Tiles_CheckRopeUsability(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002340")]
	[Cpp2IlInjected.Address(RVA = "0xC32AD0", Offset = "0xC32AD0", VA = "0xC32AD0")]
	private bool PlaceThing_Tiles_CheckFlexibleWand(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002341")]
	[Cpp2IlInjected.Address(RVA = "0xC32478", Offset = "0xC32478", VA = "0xC32478")]
	private bool PlaceThing_Tiles_CheckWandUsability(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002342")]
	[Cpp2IlInjected.Address(RVA = "0xC32368", Offset = "0xC32368", VA = "0xC32368")]
	private bool PlaceThing_Tiles_CheckGamepadTorchUsability(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002343")]
	[Cpp2IlInjected.Address(RVA = "0xC2FEB8", Offset = "0xC2FEB8", VA = "0xC2FEB8")]
	private void PlaceThing_LockChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002344")]
	[Cpp2IlInjected.Address(RVA = "0xC2F934", Offset = "0xC2F934", VA = "0xC2F934")]
	private void PlaceThing_ItemInExtractinator(ref ItemCheckContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002345")]
	[Cpp2IlInjected.Address(RVA = "0xBC3D98", Offset = "0xBC3D98", VA = "0xBC3D98")]
	private static ItemTrader TryGettingItemTraderFromBlock(Tile targetBlock)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002346")]
	[Cpp2IlInjected.Address(RVA = "0xC2EEC4", Offset = "0xC2EEC4", VA = "0xC2EEC4")]
	private void PlaceThing_XMasTreeTops()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002347")]
	[Cpp2IlInjected.Address(RVA = "0xC2EB08", Offset = "0xC2EB08", VA = "0xC2EB08")]
	private void PlaceThing_CannonBall()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002348")]
	[Cpp2IlInjected.Address(RVA = "0xC2E78C", Offset = "0xC2E78C", VA = "0xC2E78C")]
	private void PlaceThing_PaintScrapper()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002349")]
	[Cpp2IlInjected.Address(RVA = "0xC42AC8", Offset = "0xC42AC8", VA = "0xC42AC8")]
	private void PlaceThing_PaintScrapper_LongMoss(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600234A")]
	[Cpp2IlInjected.Address(RVA = "0xC427C8", Offset = "0xC427C8", VA = "0xC427C8")]
	private void PlaceThing_PaintScrapper_TryScrapping(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600234B")]
	[Cpp2IlInjected.Address(RVA = "0xC2E3E0", Offset = "0xC2E3E0", VA = "0xC2E3E0")]
	private void PlaceThing_PaintRoller()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600234C")]
	[Cpp2IlInjected.Address(RVA = "0xC2E034", Offset = "0xC2E034", VA = "0xC2E034")]
	private void PlaceThing_Paintbrush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600234D")]
	[Cpp2IlInjected.Address(RVA = "0xC42F00", Offset = "0xC42F00", VA = "0xC42F00")]
	public Item FindPaintOrCoating()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600234E")]
	[Cpp2IlInjected.Address(RVA = "0xC32080", Offset = "0xC32080", VA = "0xC32080")]
	private void TryPainting(int x, int y, bool paintingAWall = false, bool applyItemAnimation = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600234F")]
	[Cpp2IlInjected.Address(RVA = "0xC42FA0", Offset = "0xC42FA0", VA = "0xC42FA0")]
	private void ApplyCoating(int x, int y, bool paintingAWall, bool applyItemAnimation, Item targetItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002350")]
	[Cpp2IlInjected.Address(RVA = "0xC43154", Offset = "0xC43154", VA = "0xC43154")]
	private void ApplyPaint(int x, int y, bool paintingAWall, bool applyItemAnimation, Item targetItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002351")]
	[Cpp2IlInjected.Address(RVA = "0xC42450", Offset = "0xC42450", VA = "0xC42450")]
	private void ShootFromCannon(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002352")]
	[Cpp2IlInjected.Address(RVA = "0xC40744", Offset = "0xC40744", VA = "0xC40744")]
	private void ExtractinatorUse(int extractType, int extractinatorBlockType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002353")]
	[Cpp2IlInjected.Address(RVA = "0xC40470", Offset = "0xC40470", VA = "0xC40470")]
	private void DropItemFromExtractinator(int itemType, int stack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002354")]
	[Cpp2IlInjected.Address(RVA = "0xBDCB1C", Offset = "0xBDCB1C", VA = "0xBDCB1C")]
	public void ChangeDir(int dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002355")]
	[Cpp2IlInjected.Address(RVA = "0xBB9EE8", Offset = "0xBB9EE8", VA = "0xBB9EE8")]
	public Rectangle getRect()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002356")]
	[Cpp2IlInjected.Address(RVA = "0xC433D8", Offset = "0xC433D8", VA = "0xC433D8")]
	public void HorsemansBlade_SpawnPumpkin(int npcIndex, int dmg, float kb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002357")]
	[Cpp2IlInjected.Address(RVA = "0xC436D0", Offset = "0xC436D0", VA = "0xC436D0")]
	public void PutItemInInventoryFromItemUsage(int type, int theSelectedItem = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002358")]
	[Cpp2IlInjected.Address(RVA = "0xC43A74", Offset = "0xC43A74", VA = "0xC43A74")]
	public bool SummonItemCheck(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002359")]
	[Cpp2IlInjected.Address(RVA = "0xC43C28", Offset = "0xC43C28", VA = "0xC43C28")]
	public PlayerFishingConditions GetFishingConditions()
	{
		return default(PlayerFishingConditions);
	}

	[Cpp2IlInjected.Token(Token = "0x600235A")]
	[Cpp2IlInjected.Address(RVA = "0xC43F58", Offset = "0xC43F58", VA = "0xC43F58")]
	private static float Fishing_GetPowerMultiplier()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600235B")]
	[Cpp2IlInjected.Address(RVA = "0xC43E88", Offset = "0xC43E88", VA = "0xC43E88")]
	private void Fishing_GetBait(out int baitPower, out int baitType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600235C")]
	[Cpp2IlInjected.Address(RVA = "0xC43DFC", Offset = "0xC43DFC", VA = "0xC43DFC")]
	private void Fishing_GetBestFishingPole(out int fishingPolePower, out int fishingPoleType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600235D")]
	[Cpp2IlInjected.Address(RVA = "0xC44444", Offset = "0xC44444", VA = "0xC44444")]
	public bool HasUnityPotion()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600235E")]
	[Cpp2IlInjected.Address(RVA = "0xC44514", Offset = "0xC44514", VA = "0xC44514")]
	public void TakeUnityPotion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600235F")]
	[Cpp2IlInjected.Address(RVA = "0xC4461C", Offset = "0xC4461C", VA = "0xC4461C")]
	public void UnityTeleport(Vector2 telePos)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002360")]
	[Cpp2IlInjected.Address(RVA = "0xC44AD0", Offset = "0xC44AD0", VA = "0xC44AD0")]
	private void PayDD2CrystalsBeforeUse(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002361")]
	[Cpp2IlInjected.Address(RVA = "0xC44B5C", Offset = "0xC44B5C", VA = "0xC44B5C")]
	private bool CheckDD2CrystalPaymentLock(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002362")]
	[Cpp2IlInjected.Address(RVA = "0xC44B30", Offset = "0xC44B30", VA = "0xC44B30")]
	private int GetRequiredDD2CrystalsToUse(Item item)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002363")]
	[Cpp2IlInjected.Address(RVA = "0xBB59F8", Offset = "0xBB59F8", VA = "0xBB59F8")]
	public void SporeSac(Item sourceItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002364")]
	[Cpp2IlInjected.Address(RVA = "0xBB6414", Offset = "0xBB6414", VA = "0xBB6414")]
	public void VolatileGelatin(Item sourceItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002365")]
	[Cpp2IlInjected.Address(RVA = "0xBD5DA4", Offset = "0xBD5DA4", VA = "0xBD5DA4")]
	public bool CanHit(Entity ent)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002366")]
	[Cpp2IlInjected.Address(RVA = "0xC44C60", Offset = "0xC44C60", VA = "0xC44C60")]
	public Rectangle GetItemDrawFrame(int type)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002367")]
	[Cpp2IlInjected.Address(RVA = "0xC45000", Offset = "0xC45000", VA = "0xC45000")]
	public float GetAdjustedItemScale(Item item)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002368")]
	[Cpp2IlInjected.Address(RVA = "0xC45034", Offset = "0xC45034", VA = "0xC45034")]
	public void ApplyMeleeScale(ref float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002369")]
	[Cpp2IlInjected.Address(RVA = "0xC45054", Offset = "0xC45054", VA = "0xC45054")]
	public Vector2 ApplyRangeCompensation(float rangeCompensation, Vector2 startPos, Vector2 targetPos)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600236A")]
	[Cpp2IlInjected.Address(RVA = "0xC0DC08", Offset = "0xC0DC08", VA = "0xC0DC08")]
	public void ItemCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600236B")]
	[Cpp2IlInjected.Address(RVA = "0xC45D54", Offset = "0xC45D54", VA = "0xC45D54")]
	private void UpdatePlacementPreview(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600236C")]
	[Cpp2IlInjected.Address(RVA = "0xC333A8", Offset = "0xC333A8", VA = "0xC333A8")]
	private void FigureOutWhatToPlace(Tile targetTile, Item sItem, out int tileToCreate, out int previewPlaceStyle, out bool? overrideCanPlace, out int? forcedRandom)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600236D")]
	[Cpp2IlInjected.Address(RVA = "0xC50674", Offset = "0xC50674", VA = "0xC50674")]
	private void ItemCheck_OwnerOnlyCode(ref ItemCheckContext context, Item sItem, int weaponDamage, Rectangle heldItemFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600236F")]
	[Cpp2IlInjected.Address(RVA = "0xC4FF0C", Offset = "0xC4FF0C", VA = "0xC4FF0C")]
	private void ItemCheck_EmitFoodParticles(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002370")]
	[Cpp2IlInjected.Address(RVA = "0xC502B8", Offset = "0xC502B8", VA = "0xC502B8")]
	private void ItemCheck_EmitDrinkParticles(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002371")]
	[Cpp2IlInjected.Address(RVA = "0xC6A894", Offset = "0xC6A894", VA = "0xC6A894")]
	private void ItemCheck_UseBossSpawners(int onWhichPlayer, Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002372")]
	[Cpp2IlInjected.Address(RVA = "0xC6969C", Offset = "0xC6969C", VA = "0xC6969C")]
	private void ItemCheck_UseEventItems(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002373")]
	[Cpp2IlInjected.Address(RVA = "0xC6C2EC", Offset = "0xC6C2EC", VA = "0xC6C2EC")]
	private void ItemCheck_ReleaseCritter(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002374")]
	[Cpp2IlInjected.Address(RVA = "0xC71770", Offset = "0xC71770", VA = "0xC71770")]
	private void ItemCheck_MeleeHitPVP(Item sItem, Rectangle itemRectangle, int damage, float knockBack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002375")]
	[Cpp2IlInjected.Address(RVA = "0xC7290C", Offset = "0xC7290C", VA = "0xC7290C")]
	private void Volcano_TrySpawningVolcano(NPC npc, Item sItem, float damage, float knockBack, Rectangle itemRectangle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002376")]
	[Cpp2IlInjected.Address(RVA = "0xC72A90", Offset = "0xC72A90", VA = "0xC72A90")]
	private void TentacleSpike_TrySpiking(NPC npc, Item sItem, float damage, float knockBack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002377")]
	[Cpp2IlInjected.Address(RVA = "0xC72E90", Offset = "0xC72E90", VA = "0xC72E90")]
	private void BloodButcherer_TryButchering(NPC npc, Item sItem, float damage, float knockBack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002378")]
	[Cpp2IlInjected.Address(RVA = "0xC72798", Offset = "0xC72798", VA = "0xC72798")]
	private void BatBat_TryLifeLeeching(Entity entity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002379")]
	[Cpp2IlInjected.Address(RVA = "0xBCF8F0", Offset = "0xBCF8F0", VA = "0xBCF8F0")]
	public bool HasNPCBannerBuff(int bannerType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600237A")]
	[Cpp2IlInjected.Address(RVA = "0xC732EC", Offset = "0xC732EC", VA = "0xC732EC")]
	public void ResetMeleeHitCooldowns()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600237B")]
	[Cpp2IlInjected.Address(RVA = "0xC714DC", Offset = "0xC714DC", VA = "0xC714DC")]
	public void UpdateMeleeHitCooldowns()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600237C")]
	[Cpp2IlInjected.Address(RVA = "0xC7338C", Offset = "0xC7338C", VA = "0xC7338C")]
	public bool CanHitNPCWithMeleeHit(int npcIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600237D")]
	[Cpp2IlInjected.Address(RVA = "0xC733A8", Offset = "0xC733A8", VA = "0xC733A8")]
	public void SetMeleeHitCooldown(int npcIndex, int timeInFrames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600237E")]
	[Cpp2IlInjected.Address(RVA = "0xC71580", Offset = "0xC71580", VA = "0xC71580")]
	private void ItemCheck_MeleeHitNPCs(Item sItem, Rectangle itemRectangle, int originalDamage, float knockBack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600237F")]
	[Cpp2IlInjected.Address(RVA = "0xC74220", Offset = "0xC74220", VA = "0xC74220")]
	public void TakeDamageFromJellyfish(int npcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002380")]
	[Cpp2IlInjected.Address(RVA = "0xC733B8", Offset = "0xC733B8", VA = "0xC733B8")]
	private void ProcessHitAgainstNPC(Item sItem, Rectangle itemRectangle, int originalDamage, float knockBack, int npcIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002381")]
	[Cpp2IlInjected.Address(RVA = "0xC72868", Offset = "0xC72868", VA = "0xC72868")]
	public void ApplyAttackCooldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002382")]
	[Cpp2IlInjected.Address(RVA = "0xC0D54C", Offset = "0xC0D54C", VA = "0xC0D54C")]
	public void ApplyAttackCooldown(int frames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002383")]
	[Cpp2IlInjected.Address(RVA = "0xC745E0", Offset = "0xC745E0", VA = "0xC745E0")]
	private void ApplyNPCOnHitEffects(Item sItem, Rectangle itemRectangle, int damage, float knockBack, int npcIndex, int dmgRandomized, int dmgDone)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002384")]
	[Cpp2IlInjected.Address(RVA = "0xC72280", Offset = "0xC72280", VA = "0xC72280")]
	private void ItemCheck_EmitHammushProjectiles(int i, Item sItem, Rectangle itemRectangle, int damage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002385")]
	[Cpp2IlInjected.Address(RVA = "0xBCEF38", Offset = "0xBCEF38", VA = "0xBCEF38")]
	private bool[] ItemCheck_GetTileCutIgnoreList(Item sItem)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002386")]
	[Cpp2IlInjected.Address(RVA = "0xC757DC", Offset = "0xC757DC", VA = "0xC757DC")]
	public bool[] GetTileCutIgnorance(bool allowRegrowth, bool fromTrap)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002387")]
	[Cpp2IlInjected.Address(RVA = "0xBCEF58", Offset = "0xBCEF58", VA = "0xBCEF58")]
	private void ItemCheck_CutTiles(Item sItem, Rectangle itemRectangle, bool[] shouldIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002388")]
	[Cpp2IlInjected.Address(RVA = "0xC7101C", Offset = "0xC7101C", VA = "0xC7101C")]
	private Rectangle ItemCheck_CatchCritters(Item sItem, Rectangle itemRectangle)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6002389")]
	[Cpp2IlInjected.Address(RVA = "0xC7432C", Offset = "0xC7432C", VA = "0xC7432C")]
	private void GetPointOnSwungItemPath(float spriteWidth, float spriteHeight, float normalizedPointOnPath, float itemScale, out Vector2 location, out Vector2 outwardDirection)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600238A")]
	[Cpp2IlInjected.Address(RVA = "0xC6D4D4", Offset = "0xC6D4D4", VA = "0xC6D4D4")]
	private Rectangle ItemCheck_EmitUseVisuals(Item sItem, Rectangle itemRectangle)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600238B")]
	[Cpp2IlInjected.Address(RVA = "0xC6C6C8", Offset = "0xC6C6C8", VA = "0xC6C6C8")]
	private void ItemCheck_GetMeleeHitbox(Item sItem, Rectangle heldItemFrame, out bool dontAttack, out Rectangle itemRectangle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600238C")]
	[Cpp2IlInjected.Address(RVA = "0xC69124", Offset = "0xC69124", VA = "0xC69124")]
	private void ItemCheck_UseDemonHeart(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600238D")]
	[Cpp2IlInjected.Address(RVA = "0xC69260", Offset = "0xC69260", VA = "0xC69260")]
	private void ItemCheck_UseMinecartPowerUp(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600238E")]
	[Cpp2IlInjected.Address(RVA = "0xC6959C", Offset = "0xC6959C", VA = "0xC6959C")]
	private void ItemCheck_UseArtisanLoaf(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600238F")]
	[Cpp2IlInjected.Address(RVA = "0xC69380", Offset = "0xC69380", VA = "0xC69380")]
	private void ItemCheck_UseTorchGodsFavor(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002390")]
	[Cpp2IlInjected.Address(RVA = "0xC68358", Offset = "0xC68358", VA = "0xC68358")]
	private void ItemCheck_TryDestroyingDrones(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002391")]
	[Cpp2IlInjected.Address(RVA = "0xC69020", Offset = "0xC69020", VA = "0xC69020")]
	private void ItemCheck_UseManaCrystal(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002392")]
	[Cpp2IlInjected.Address(RVA = "0xC68F14", Offset = "0xC68F14", VA = "0xC68F14")]
	private void ItemCheck_UseLifeFruit(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002393")]
	[Cpp2IlInjected.Address(RVA = "0xC68E10", Offset = "0xC68E10", VA = "0xC68E10")]
	private void ItemCheck_UseLifeCrystal(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002394")]
	[Cpp2IlInjected.Address(RVA = "0xC6B728", Offset = "0xC6B728", VA = "0xC6B728")]
	private void ItemCheck_UseCombatBook(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002395")]
	[Cpp2IlInjected.Address(RVA = "0xC6BCCC", Offset = "0xC6BCCC", VA = "0xC6BCCC")]
	private void ItemCheck_UsePetLicenses(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002396")]
	[Cpp2IlInjected.Address(RVA = "0xC6BACC", Offset = "0xC6BACC", VA = "0xC6BACC")]
	private void ItemCheck_UsePeddlersSatchel(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002397")]
	[Cpp2IlInjected.Address(RVA = "0xC6BE90", Offset = "0xC6BE90", VA = "0xC6BE90")]
	private void ItemCheck_UseShimmerPermanentItems(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002398")]
	[Cpp2IlInjected.Address(RVA = "0xC758D0", Offset = "0xC758D0", VA = "0xC758D0")]
	private void LicenseOrExchangePet(Item sItem, ref bool petBoughtFlag, int npcType, string textKeyForLicense, int netMessageData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002399")]
	[Cpp2IlInjected.Address(RVA = "0xC759DC", Offset = "0xC759DC", VA = "0xC759DC")]
	public void LimitPointToPlayerReachableArea(ref Vector2 pointPoisition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600239A")]
	[Cpp2IlInjected.Address(RVA = "0xC68818", Offset = "0xC68818", VA = "0xC68818")]
	private void ItemCheck_UseTeleportRod(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600239B")]
	[Cpp2IlInjected.Address(RVA = "0xC75B9C", Offset = "0xC75B9C", VA = "0xC75B9C")]
	private bool IsTilePoundable(Tile targetTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600239C")]
	[Cpp2IlInjected.Address(RVA = "0xC75CF8", Offset = "0xC75CF8", VA = "0xC75CF8")]
	private void UseShovel(Player user, Item item, int sX, int sY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600239D")]
	[Cpp2IlInjected.Address(RVA = "0xC75D8C", Offset = "0xC75D8C", VA = "0xC75D8C")]
	private void DamageTileWithShovel(Player user, Item item, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600239E")]
	[Cpp2IlInjected.Address(RVA = "0xC68464", Offset = "0xC68464", VA = "0xC68464")]
	private void ItemCheck_UseMiningTools(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600239F")]
	[Cpp2IlInjected.Address(RVA = "0xC77010", Offset = "0xC77010", VA = "0xC77010")]
	private void ItemCheck_UseMiningTools_ActuallyUseMiningTool(Item sItem, out bool canHitWalls, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A0")]
	[Cpp2IlInjected.Address(RVA = "0xC78B08", Offset = "0xC78B08", VA = "0xC78B08")]
	private bool IsBottomOfTreeTrunkNoRoots(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023A1")]
	[Cpp2IlInjected.Address(RVA = "0xC78C98", Offset = "0xC78C98", VA = "0xC78C98")]
	private void TryReplantingTree()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A2")]
	[Cpp2IlInjected.Address(RVA = "0xC77F58", Offset = "0xC77F58", VA = "0xC77F58")]
	private static void ItemCheck_UseMiningTools_TryFindingWallToHammer(out int wX, out int wY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A3")]
	[Cpp2IlInjected.Address(RVA = "0xC7887C", Offset = "0xC7887C", VA = "0xC7887C")]
	private void ItemCheck_UseMiningTools_TryHittingWall(Item sItem, int wX, int wY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A4")]
	[Cpp2IlInjected.Address(RVA = "0xC7B078", Offset = "0xC7B078", VA = "0xC7B078")]
	public static bool CanPlayerSmashWall(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023A5")]
	[Cpp2IlInjected.Address(RVA = "0xC7B258", Offset = "0xC7B258", VA = "0xC7B258")]
	public void PickWall(int x, int y, int damage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A6")]
	[Cpp2IlInjected.Address(RVA = "0xC78FDC", Offset = "0xC78FDC", VA = "0xC78FDC")]
	private void ItemCheck_UseMiningTools_TryPoundingTile(Item sItem, int tileHitId, ref bool hitWall, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A7")]
	[Cpp2IlInjected.Address(RVA = "0xC76E10", Offset = "0xC76E10", VA = "0xC76E10")]
	public bool IsTargetTileInItemRange(Item sItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023A8")]
	[Cpp2IlInjected.Address(RVA = "0xC66238", Offset = "0xC66238", VA = "0xC66238")]
	private void ItemCheck_UseBuckets(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023A9")]
	[Cpp2IlInjected.Address(RVA = "0xC651D4", Offset = "0xC651D4", VA = "0xC651D4")]
	private void ItemCheck_PlayInstruments(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023AA")]
	[Cpp2IlInjected.Address(RVA = "0xC7B848", Offset = "0xC7B848", VA = "0xC7B848")]
	private bool GetSparkleGuitarTarget(out List<NPC> validTargets)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023AB")]
	[Cpp2IlInjected.Address(RVA = "0xC7BA58", Offset = "0xC7BA58", VA = "0xC7BA58")]
	private bool GetZenithTarget(Vector2 searchCenter, float maxDistance, out int npcTargetIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023AC")]
	[Cpp2IlInjected.Address(RVA = "0xC7B508", Offset = "0xC7B508", VA = "0xC7B508")]
	public void PlayGuitarChord(float range)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023AD")]
	[Cpp2IlInjected.Address(RVA = "0xC7B640", Offset = "0xC7B640", VA = "0xC7B640")]
	public void PlayDrums(float range)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023AE")]
	[Cpp2IlInjected.Address(RVA = "0xC63AC8", Offset = "0xC63AC8", VA = "0xC63AC8")]
	private void ItemCheck_UseWiringTools(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023AF")]
	[Cpp2IlInjected.Address(RVA = "0xC7BC00", Offset = "0xC7BC00", VA = "0xC7BC00")]
	public bool CanDoWireStuffHere(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023B0")]
	[Cpp2IlInjected.Address(RVA = "0xC64EA8", Offset = "0xC64EA8", VA = "0xC64EA8")]
	private void ItemCheck_UseLawnMower(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023B1")]
	[Cpp2IlInjected.Address(RVA = "0xC7BD50", Offset = "0xC7BD50", VA = "0xC7BD50")]
	private void DestroyOldestProximityMinesOverMinesCap(int minesCap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023B2")]
	[Cpp2IlInjected.Address(RVA = "0xC52898", Offset = "0xC52898", VA = "0xC52898")]
	private void ItemCheck_Shoot(int i, Item sItem, int weaponDamage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023B3")]
	[Cpp2IlInjected.Address(RVA = "0xC7D66C", Offset = "0xC7D66C", VA = "0xC7D66C")]
	public Vector2 GetFarthestSpawnPositionOnLine(Vector2 startPos, float speedX, float speedY)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60023B4")]
	[Cpp2IlInjected.Address(RVA = "0xC7E1F0", Offset = "0xC7E1F0", VA = "0xC7E1F0")]
	public int SpawnMinionOnCursor(IEntitySource projectileSource, int ownerIndex, int minionProjectileId, int originalDamageNotScaledByMinionDamage, float KnockBack, [Optional] Vector2 offsetFromCursor, [Optional] Vector2 velocityOnSpawn)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60023B5")]
	[Cpp2IlInjected.Address(RVA = "0xC7D9C0", Offset = "0xC7D9C0", VA = "0xC7D9C0")]
	private Point FindSharpTearsSpot(Vector2 targetSpot)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x60023B6")]
	[Cpp2IlInjected.Address(RVA = "0xC7E820", Offset = "0xC7E820", VA = "0xC7E820")]
	private bool FindSharpTearsOpening(int x, int y, bool acceptLeft, bool acceptRight, bool acceptUp, bool acceptDown)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023B7")]
	[Cpp2IlInjected.Address(RVA = "0xC7D0E8", Offset = "0xC7D0E8", VA = "0xC7D0E8")]
	public bool TryPlacingAGolfBallNearANearbyTee(Vector2 placePosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023B8")]
	[Cpp2IlInjected.Address(RVA = "0xC1EA58", Offset = "0xC1EA58", VA = "0xC1EA58")]
	public void GetPreferredGolfBallToUse(out int projType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023B9")]
	[Cpp2IlInjected.Address(RVA = "0xC527B4", Offset = "0xC527B4", VA = "0xC527B4")]
	private void ItemCheck_MinionAltFeatureUse(Item sItem, bool cShoot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023BA")]
	[Cpp2IlInjected.Address(RVA = "0xC52610", Offset = "0xC52610", VA = "0xC52610")]
	private void ItemCheck_TurretAltFeatureUse(Item sItem, bool cShoot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023BB")]
	[Cpp2IlInjected.Address(RVA = "0xC47D10", Offset = "0xC47D10", VA = "0xC47D10")]
	private void EmitMaxManaEffect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023BD")]
	[Cpp2IlInjected.Address(RVA = "0xC4D254", Offset = "0xC4D254", VA = "0xC4D254")]
	private void ItemCheck_EmitHeldItemLight(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023BE")]
	[Cpp2IlInjected.Address(RVA = "0xC2887C", Offset = "0xC2887C", VA = "0xC2887C")]
	public bool CanVisuallyHoldItem(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023BF")]
	[Cpp2IlInjected.Address(RVA = "0xC4B950", Offset = "0xC4B950", VA = "0xC4B950")]
	private void ItemCheck_ApplyHoldStyle(float mountOffset, Item sItem, Rectangle heldItemFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C0")]
	[Cpp2IlInjected.Address(RVA = "0xC47CCC", Offset = "0xC47CCC", VA = "0xC47CCC")]
	private void ItemCheck_ApplyManaRegenDelay(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C1")]
	[Cpp2IlInjected.Address(RVA = "0xC7EFA4", Offset = "0xC7EFA4", VA = "0xC7EFA4")]
	public Vector2 GetFrontHandPosition(CompositeArmStretchAmount stretch, float rotation)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60023C2")]
	[Cpp2IlInjected.Address(RVA = "0xC7F400", Offset = "0xC7F400", VA = "0xC7F400")]
	public Vector2 GetBackHandPosition(CompositeArmStretchAmount stretch, float rotation)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60023C3")]
	[Cpp2IlInjected.Address(RVA = "0xC47F38", Offset = "0xC47F38", VA = "0xC47F38")]
	public void ItemCheck_ApplyUseStyle(float mountOffset, Item sItem, Rectangle heldItemFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C4")]
	[Cpp2IlInjected.Address(RVA = "0xC7EF34", Offset = "0xC7EF34", VA = "0xC7EF34")]
	public void FlipItemLocationAndRotationForGravity()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C5")]
	[Cpp2IlInjected.Address(RVA = "0xC47B44", Offset = "0xC47B44", VA = "0xC47B44")]
	private void ItemCheck_StartActualUse(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C6")]
	[Cpp2IlInjected.Address(RVA = "0xC47094", Offset = "0xC47094", VA = "0xC47094")]
	private void FreeUpPetsAndMinions(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C7")]
	[Cpp2IlInjected.Address(RVA = "0xB868B0", Offset = "0xB868B0", VA = "0xB868B0")]
	private void ApplyPotionDelay(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C8")]
	[Cpp2IlInjected.Address(RVA = "0xB86A48", Offset = "0xB86A48", VA = "0xB86A48")]
	private void ApplyLifeAndOrMana(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023C9")]
	[Cpp2IlInjected.Address(RVA = "0xB84EDC", Offset = "0xB84EDC", VA = "0xB84EDC")]
	private bool ItemCheck_CheckCanUse(Item sItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023CA")]
	[Cpp2IlInjected.Address(RVA = "0xC7FE00", Offset = "0xC7FE00", VA = "0xC7FE00")]
	private bool ItemCheck_CheckUsabilityOfProjectiles(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023CB")]
	[Cpp2IlInjected.Address(RVA = "0xC7FC08", Offset = "0xC7FC08", VA = "0xC7FC08")]
	private bool ItemCheck_CheckFishingBobbers(bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023CC")]
	[Cpp2IlInjected.Address(RVA = "0xC80240", Offset = "0xC80240", VA = "0xC80240")]
	private void ItemCheck_CheckFishingBobber_PullBobber(Projectile bobber, int baitTypeUsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023CD")]
	[Cpp2IlInjected.Address(RVA = "0xC7FED0", Offset = "0xC7FED0", VA = "0xC7FED0")]
	private void ItemCheck_CheckFishingBobber_PickAndConsumeBait(Projectile bobber, out bool pullTheBobber, out int baitTypeUsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023CE")]
	[Cpp2IlInjected.Address(RVA = "0xC7FB3C", Offset = "0xC7FB3C", VA = "0xC7FB3C")]
	private static bool ItemCheck_IsValidDirtRodTarget(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023CF")]
	[Cpp2IlInjected.Address(RVA = "0xC7F8EC", Offset = "0xC7F8EC", VA = "0xC7F8EC")]
	private bool ItemCheck_PayMana(Item sItem, bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023D0")]
	[Cpp2IlInjected.Address(RVA = "0xC806A4", Offset = "0xC806A4", VA = "0xC806A4")]
	private void ItemCheck_TryPlacingWearablesOnMannequins(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D1")]
	[Cpp2IlInjected.Address(RVA = "0xC45D3C", Offset = "0xC45D3C", VA = "0xC45D3C")]
	private void ApplyReuseDelay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D2")]
	[Cpp2IlInjected.Address(RVA = "0xC45A18", Offset = "0xC45A18", VA = "0xC45A18")]
	private void ItemCheck_HackHoldStyles(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D3")]
	[Cpp2IlInjected.Address(RVA = "0xC4590C", Offset = "0xC4590C", VA = "0xC4590C")]
	private void ItemCheck_HandleMPItemAnimation(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D4")]
	[Cpp2IlInjected.Address(RVA = "0xC811A0", Offset = "0xC811A0", VA = "0xC811A0")]
	private void TryAllowingItemReuse(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D5")]
	[Cpp2IlInjected.Address(RVA = "0xC4527C", Offset = "0xC4527C", VA = "0xC4527C")]
	private void ItemCheck_HandleMount()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D6")]
	[Cpp2IlInjected.Address(RVA = "0xC812C4", Offset = "0xC812C4", VA = "0xC812C4")]
	public void StartChanneling()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D7")]
	[Cpp2IlInjected.Address(RVA = "0xC7F6F8", Offset = "0xC7F6F8", VA = "0xC7F6F8")]
	public void StartChanneling(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D8")]
	[Cpp2IlInjected.Address(RVA = "0xC812DC", Offset = "0xC812DC", VA = "0xC812DC")]
	public void TryUpdateChannel(Projectile projectile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023D9")]
	[Cpp2IlInjected.Address(RVA = "0xC812EC", Offset = "0xC812EC", VA = "0xC812EC")]
	public void TryCancelChannel(Projectile projectile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023DA")]
	[Cpp2IlInjected.Address(RVA = "0xC7F71C", Offset = "0xC7F71C", VA = "0xC7F71C")]
	public static bool WouldSpotOverlapWithSentry(int worldX, int worldY, bool lightningAura)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023DB")]
	[Cpp2IlInjected.Address(RVA = "0xC7E494", Offset = "0xC7E494", VA = "0xC7E494")]
	public void FindSentryRestingSpot(int checkProj, out int worldX, out int worldY, out int pushYUp)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023DC")]
	[Cpp2IlInjected.Address(RVA = "0xC039B0", Offset = "0xC039B0", VA = "0xC039B0")]
	public void UpdateMaxTurrets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023DD")]
	[Cpp2IlInjected.Address(RVA = "0xC45FAC", Offset = "0xC45FAC", VA = "0xC45FAC")]
	private void ItemCheck_ApplyPetBuffs(Item sItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023DE")]
	[Cpp2IlInjected.Address(RVA = "0xC7D040", Offset = "0xC7D040", VA = "0xC7D040")]
	public float GetWeaponKnockback(Item sItem, float KnockBack)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60023DF")]
	[Cpp2IlInjected.Address(RVA = "0xC745AC", Offset = "0xC745AC", VA = "0xC745AC")]
	public int GetWeaponCrit(Item sItem)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60023E0")]
	[Cpp2IlInjected.Address(RVA = "0xC4544C", Offset = "0xC4544C", VA = "0xC4544C")]
	public int GetWeaponDamage(Item sItem)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60023E1")]
	[Cpp2IlInjected.Address(RVA = "0xBE7BF4", Offset = "0xBE7BF4", VA = "0xBE7BF4")]
	public bool HasAmmo(Item sItem, bool canUse)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023E2")]
	[Cpp2IlInjected.Address(RVA = "0xC81318", Offset = "0xC81318", VA = "0xC81318")]
	private bool PickAmmo_TryFindingSpecificMatches(int launcher, int ammo, out int pickedProjectileId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023E3")]
	[Cpp2IlInjected.Address(RVA = "0xC7C110", Offset = "0xC7C110", VA = "0xC7C110")]
	public void PickAmmo(Item sItem, ref int projToShoot, ref float speed, ref bool canShoot, ref int Damage, ref float KnockBack, out int usedAmmoItemId, bool dontConsume = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023E4")]
	[Cpp2IlInjected.Address(RVA = "0xC8140C", Offset = "0xC8140C", VA = "0xC8140C")]
	public void GetOtherPlayersPickTile(int x, int y, int pickDamage)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023E5")]
	[Cpp2IlInjected.Address(RVA = "0xC75F50", Offset = "0xC75F50", VA = "0xC75F50")]
	public void PickTile(int x, int y, int pickPower)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023E6")]
	[Cpp2IlInjected.Address(RVA = "0xC3A81C", Offset = "0xC3A81C", VA = "0xC3A81C")]
	private void ClearMiningCacheAt(int x, int y, int hitTileCacheType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023E7")]
	[Cpp2IlInjected.Address(RVA = "0xC81678", Offset = "0xC81678", VA = "0xC81678")]
	public bool isNearFairy()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023E8")]
	[Cpp2IlInjected.Address(RVA = "0xC819B0", Offset = "0xC819B0", VA = "0xC819B0")]
	public bool isNearNPC(int type, float range = -1f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023E9")]
	[Cpp2IlInjected.Address(RVA = "0xC81BF0", Offset = "0xC81BF0", VA = "0xC81BF0")]
	public bool HasEnoughPickPowerToHurtTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023EA")]
	[Cpp2IlInjected.Address(RVA = "0xC39CB8", Offset = "0xC39CB8", VA = "0xC39CB8")]
	private int GetPickaxeDamage(int x, int y, int pickPower, int hitBufferIndex, Tile tileTarget)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60023EB")]
	[Cpp2IlInjected.Address(RVA = "0xC81454", Offset = "0xC81454", VA = "0xC81454")]
	private bool DoesPickTargetTransformOnKill(HitTile hitCounter, int damage, int x, int y, int pickPower, int bufferIndex, Tile tileTarget)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023EC")]
	[Cpp2IlInjected.Address(RVA = "0xC1EC48", Offset = "0xC1EC48", VA = "0xC1EC48")]
	public bool ItemFitsWeaponRack(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023ED")]
	[Cpp2IlInjected.Address(RVA = "0xC1ECBC", Offset = "0xC1ECBC", VA = "0xC1ECBC")]
	public void PlaceWeapon(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023EE")]
	[Cpp2IlInjected.Address(RVA = "0xC81D44", Offset = "0xC81D44", VA = "0xC81D44")]
	public bool ItemFitsItemFrame(Item i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023EF")]
	[Cpp2IlInjected.Address(RVA = "0xC81D58", Offset = "0xC81D58", VA = "0xC81D58")]
	public Color GetImmuneAlpha(Color newColor, float alphaReduction)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60023F0")]
	[Cpp2IlInjected.Address(RVA = "0xC81ECC", Offset = "0xC81ECC", VA = "0xC81ECC")]
	public Color GetImmuneAlphaPure(Color newColor, float alphaReduction)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60023F1")]
	[Cpp2IlInjected.Address(RVA = "0xC81FB0", Offset = "0xC81FB0", VA = "0xC81FB0")]
	public Color GetDeathAlpha(Color newColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60023F2")]
	[Cpp2IlInjected.Address(RVA = "0xBCF974", Offset = "0xBCF974", VA = "0xBCF974")]
	public void addDPS(int dmg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023F3")]
	[Cpp2IlInjected.Address(RVA = "0xC82058", Offset = "0xC82058", VA = "0xC82058")]
	public void checkDPSTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023F4")]
	[Cpp2IlInjected.Address(RVA = "0xC82138", Offset = "0xC82138", VA = "0xC82138")]
	public int getDPS()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60023F5")]
	[Cpp2IlInjected.Address(RVA = "0xC2BAB4", Offset = "0xC2BAB4", VA = "0xC2BAB4")]
	public long DropCoins()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60023F6")]
	[Cpp2IlInjected.Address(RVA = "0xC2B47C", Offset = "0xC2B47C", VA = "0xC2B47C")]
	public void DropItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023F7")]
	[Cpp2IlInjected.Address(RVA = "0xC823A8", Offset = "0xC823A8", VA = "0xC823A8")]
	public void TryDroppingSingleItem(IEntitySource source, Item theItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023F8")]
	[Cpp2IlInjected.Address(RVA = "0xC825EC", Offset = "0xC825EC", VA = "0xC825EC")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60023F9")]
	[Cpp2IlInjected.Address(RVA = "0xC825F4", Offset = "0xC825F4", VA = "0xC825F4")]
	public object clientClone(Player clonePlayer)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60023FA")]
	[Cpp2IlInjected.Address(RVA = "0xC82988", Offset = "0xC82988", VA = "0xC82988")]
	public void CopyVisuals(Player other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023FB")]
	[Cpp2IlInjected.Address(RVA = "0xC82C48", Offset = "0xC82C48", VA = "0xC82C48")]
	public Player clientClone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60023FC")]
	[Cpp2IlInjected.Address(RVA = "0xB87384", Offset = "0xB87384", VA = "0xB87384")]
	private void CloneLoadouts(Player clonePlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60023FD")]
	[Cpp2IlInjected.Address(RVA = "0xC0C758", Offset = "0xC0C758", VA = "0xC0C758")]
	public static bool CheckSpawn(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023FE")]
	[Cpp2IlInjected.Address(RVA = "0xC8436C", Offset = "0xC8436C", VA = "0xC8436C")]
	private static bool CheckSpawn_Internal(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60023FF")]
	[Cpp2IlInjected.Address(RVA = "0xC0C63C", Offset = "0xC0C63C", VA = "0xC0C63C")]
	public void FindSpawn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002400")]
	[Cpp2IlInjected.Address(RVA = "0xC1F4DC", Offset = "0xC1F4DC", VA = "0xC1F4DC")]
	public void RemoveSpawn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002401")]
	[Cpp2IlInjected.Address(RVA = "0xC1F68C", Offset = "0xC1F68C", VA = "0xC1F68C")]
	public void ChangeSpawn(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002402")]
	[Cpp2IlInjected.Address(RVA = "0xC847A4", Offset = "0xC847A4", VA = "0xC847A4")]
	public static void UpdateOldMobilePath(PlayerFileData playerFile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002403")]
	[Cpp2IlInjected.Address(RVA = "0xC848C4", Offset = "0xC848C4", VA = "0xC848C4")]
	public static void SavePlayer(PlayerFileData playerFile, bool skipMapSave = false, bool forceSave = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002404")]
	[Cpp2IlInjected.Address(RVA = "0xC84FAC", Offset = "0xC84FAC", VA = "0xC84FAC")]
	private static void InternalSavePlayerFile(PlayerFileData playerFile)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002405")]
	[Cpp2IlInjected.Address(RVA = "0xC868E4", Offset = "0xC868E4", VA = "0xC868E4")]
	private void SaveTemporaryItemSlotContents(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002406")]
	[Cpp2IlInjected.Address(RVA = "0xC86B54", Offset = "0xC86B54", VA = "0xC86B54")]
	private void LoadTemporaryItemSlotContents(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002407")]
	[Cpp2IlInjected.Address(RVA = "0xC29678", Offset = "0xC29678", VA = "0xC29678")]
	public void SetPlayerDataToOutOfClassFields()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002408")]
	[Cpp2IlInjected.Address(RVA = "0xC86DD4", Offset = "0xC86DD4", VA = "0xC86DD4")]
	public static void ClearPlayerTempInfo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002409")]
	[Cpp2IlInjected.Address(RVA = "0xC84C14", Offset = "0xC84C14", VA = "0xC84C14")]
	public static void InternalSaveMap(bool isCloudSave, bool forceSave = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600240A")]
	[Cpp2IlInjected.Address(RVA = "0xC86EA0", Offset = "0xC86EA0", VA = "0xC86EA0")]
	public static PlayerFileData LoadTutorialPlayer()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600240B")]
	[Cpp2IlInjected.Address(RVA = "0xC89344", Offset = "0xC89344", VA = "0xC89344")]
	public static PlayerFileData LoadPlayer(string playerPath, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600240C")]
	[Cpp2IlInjected.Address(RVA = "0xC29318", Offset = "0xC29318", VA = "0xC29318")]
	private static void AdjustRespawnTimerForWorldJoining(Player newPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600240D")]
	[Cpp2IlInjected.Address(RVA = "0xC8C554", Offset = "0xC8C554", VA = "0xC8C554", Slot = "5")]
	public void FixLoadedData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600240E")]
	[Cpp2IlInjected.Address(RVA = "0xC8C6B0", Offset = "0xC8C6B0", VA = "0xC8C6B0")]
	public static void FixLoadedData_EliminiateDuplicateAccessories(Item[] armorArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600240F")]
	[Cpp2IlInjected.Address(RVA = "0xC8C668", Offset = "0xC8C668", VA = "0xC8C668")]
	private void FixLoadedData_Items(Item[] items)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002410")]
	[Cpp2IlInjected.Address(RVA = "0xC89158", Offset = "0xC89158", VA = "0xC89158")]
	private static void LoadPlayer_LastMinuteFixes(Player newPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002411")]
	[Cpp2IlInjected.Address(RVA = "0xC8C730", Offset = "0xC8C730", VA = "0xC8C730")]
	public static PlayerFileData GetFileData(string file, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002412")]
	[Cpp2IlInjected.Address(RVA = "0xC8C920", Offset = "0xC8C920", VA = "0xC8C920")]
	public Color GetHairColor(bool useLighting = true)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002413")]
	[Cpp2IlInjected.Address(RVA = "0xB93D3C", Offset = "0xB93D3C", VA = "0xB93D3C")]
	public bool HasItem(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002414")]
	[Cpp2IlInjected.Address(RVA = "0xC8CAAC", Offset = "0xC8CAAC", VA = "0xC8CAAC")]
	public bool HasItem(int type, Item[] collection)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002415")]
	[Cpp2IlInjected.Address(RVA = "0xC8CB00", Offset = "0xC8CB00", VA = "0xC8CB00")]
	public bool HasItemInInventoryOrOpenVoidBag(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002416")]
	[Cpp2IlInjected.Address(RVA = "0xC8C2EC", Offset = "0xC8C2EC", VA = "0xC8C2EC")]
	public bool HasItemInAnyInventory(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002417")]
	[Cpp2IlInjected.Address(RVA = "0xBA8774", Offset = "0xBA8774", VA = "0xBA8774")]
	public int FindItem(int netid)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002418")]
	[Cpp2IlInjected.Address(RVA = "0xC8CBD0", Offset = "0xC8CBD0", VA = "0xC8CBD0")]
	public int FindItem(List<int> netids)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002419")]
	[Cpp2IlInjected.Address(RVA = "0xC8CC74", Offset = "0xC8CC74", VA = "0xC8CC74")]
	public int FindItem(bool[] validtypes)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600241A")]
	[Cpp2IlInjected.Address(RVA = "0xB9AC78", Offset = "0xB9AC78", VA = "0xB9AC78")]
	public int FindItem(int type, Item[] collection)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600241B")]
	[Cpp2IlInjected.Address(RVA = "0xC8CCC0", Offset = "0xC8CCC0", VA = "0xC8CCC0")]
	public int FindItemInInventoryOrOpenVoidBag(int type, out bool inVoidBag)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600241C")]
	[Cpp2IlInjected.Address(RVA = "0xC831F8", Offset = "0xC831F8", VA = "0xC831F8")]
	public Player()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600241D")]
	[Cpp2IlInjected.Address(RVA = "0xC51224", Offset = "0xC51224", VA = "0xC51224")]
	public void MagicConch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600241E")]
	[Cpp2IlInjected.Address(RVA = "0xC51E18", Offset = "0xC51E18", VA = "0xC51E18")]
	public void Shellphone_Spawn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600241F")]
	[Cpp2IlInjected.Address(RVA = "0xC51918", Offset = "0xC51918", VA = "0xC51918")]
	public void DemonConch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002420")]
	[Cpp2IlInjected.Address(RVA = "0xC521A0", Offset = "0xC521A0", VA = "0xC521A0")]
	public void TeleportationPotion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002421")]
	[Cpp2IlInjected.Address(RVA = "0xC8CDAC", Offset = "0xC8CDAC", VA = "0xC8CDAC")]
	public Vector2 CheckForGoodTeleportationSpot(ref bool canSpawn, int teleportStartX, int teleportRangeX, int teleportStartY, int teleportRangeY, RandomTeleportationAttemptSettings settings)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002422")]
	[Cpp2IlInjected.Address(RVA = "0xC8E168", Offset = "0xC8E168", VA = "0xC8E168")]
	public void GetAnglerReward(NPC angler, int questItemType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002423")]
	[Cpp2IlInjected.Address(RVA = "0xC8E2F4", Offset = "0xC8E2F4", VA = "0xC8E2F4")]
	public static float GetAnglerRewardRarityMultiplier(int questsDone)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002424")]
	[Cpp2IlInjected.Address(RVA = "0xC8E37C", Offset = "0xC8E37C", VA = "0xC8E37C")]
	private void GetAnglerReward_MainReward(IEntitySource source, int questsDone, float rarityReduction, int questItemType, ref GetItemSettings anglerRewardSettings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002425")]
	[Cpp2IlInjected.Address(RVA = "0xC8F338", Offset = "0xC8F338", VA = "0xC8F338")]
	private void GetAnglerReward_Decoration(IEntitySource source, int questsDone, float rarityReduction, ref GetItemSettings anglerRewardSettings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002426")]
	[Cpp2IlInjected.Address(RVA = "0xC8F9CC", Offset = "0xC8F9CC", VA = "0xC8F9CC")]
	private void GetAnglerReward_Bait(IEntitySource source, int questsDone, float rarityReduction, ref GetItemSettings anglerRewardSettings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002427")]
	[Cpp2IlInjected.Address(RVA = "0xC8F6CC", Offset = "0xC8F6CC", VA = "0xC8F6CC")]
	private void GetAnglerReward_Money(IEntitySource source, int questsDone, float rarityReduction, ref GetItemSettings anglerRewardSettings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002428")]
	[Cpp2IlInjected.Address(RVA = "0xC8FEB4", Offset = "0xC8FEB4", VA = "0xC8FEB4")]
	public bool DropAnglerAccByMissing(List<int> itemIdsOfAccsWeWant, float totalChance, out bool botheredRollingForADrop, out int itemIdToDrop)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002429")]
	[Cpp2IlInjected.Address(RVA = "0xC90224", Offset = "0xC90224", VA = "0xC90224")]
	private void RemoveAnglerAccOptionsFromRewardPool(List<int> itemIdsOfAccsWeWant, Item itemToTestAgainst)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600242A")]
	[Cpp2IlInjected.Address(RVA = "0xC9038C", Offset = "0xC9038C", VA = "0xC9038C")]
	public void GetDyeTraderReward(NPC dyeTrader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600242B")]
	[Cpp2IlInjected.Address(RVA = "0xC909B0", Offset = "0xC909B0", VA = "0xC909B0")]
	public bool CheckMana(int amount, bool pay = false, bool blockQuickMana = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600242C")]
	[Cpp2IlInjected.Address(RVA = "0xC00B6C", Offset = "0xC00B6C", VA = "0xC00B6C")]
	public void TryPortalJumping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600242D")]
	[Cpp2IlInjected.Address(RVA = "0xBD6238", Offset = "0xBD6238", VA = "0xBD6238")]
	public bool ConsumeSolarFlare()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600242E")]
	[Cpp2IlInjected.Address(RVA = "0xC0139C", Offset = "0xC0139C", VA = "0xC0139C")]
	public void KeyDoubleTap(int keyDir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600242F")]
	[Cpp2IlInjected.Address(RVA = "0xBB9460", Offset = "0xBB9460", VA = "0xBB9460")]
	public void UpdateForbiddenSetLock()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002430")]
	[Cpp2IlInjected.Address(RVA = "0xC9108C", Offset = "0xC9108C", VA = "0xC9108C")]
	public void CommandForbiddenStorm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002431")]
	[Cpp2IlInjected.Address(RVA = "0xC014C8", Offset = "0xC014C8", VA = "0xC014C8")]
	public void KeyHoldDown(int keyDir, int holdTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002432")]
	[Cpp2IlInjected.Address(RVA = "0xC7E9E0", Offset = "0xC7E9E0", VA = "0xC7E9E0")]
	public void MinionNPCTargetAim(bool doNotDisableIfTheTargetIsTheSame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002433")]
	[Cpp2IlInjected.Address(RVA = "0xC90A50", Offset = "0xC90A50", VA = "0xC90A50")]
	public void MinionRestTargetAim()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002434")]
	[Cpp2IlInjected.Address(RVA = "0xC00C18", Offset = "0xC00C18", VA = "0xC00C18")]
	public void UpdateMinionTarget()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002435")]
	[Cpp2IlInjected.Address(RVA = "0xC2195C", Offset = "0xC2195C", VA = "0xC2195C")]
	public void NebulaLevelup(int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002436")]
	[Cpp2IlInjected.Address(RVA = "0xBE278C", Offset = "0xBE278C", VA = "0xBE278C")]
	public void UpdateTouchingTiles()
	{
	}
}
