using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Graphics;
using Terraria.Achievements;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.Graphics;
using Terraria.Graphics.CameraModifiers;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200031B")]
public class Main : Game
{
	[Cpp2IlInjected.Token(Token = "0x2000830")]
	public static class CurrentFrameFlags
	{
		[Cpp2IlInjected.Token(Token = "0x2000B4E")]
		public static class Hacks
		{
			[Cpp2IlInjected.Token(Token = "0x4008FE7")]
			public static Matrix CurrentBackgroundMatrixForCreditsRoll;
		}

		[Cpp2IlInjected.Token(Token = "0x4007E1D")]
		public static int ActivePlayersCount;

		[Cpp2IlInjected.Token(Token = "0x4007E1E")]
		public static int SleepingPlayersCount;

		[Cpp2IlInjected.Token(Token = "0x4007E1F")]
		public static bool AnyActiveBossNPC;

		[Cpp2IlInjected.Token(Token = "0x4007E20")]
		public static bool HadAnActiveInteractibleProjectile;
	}

	[Cpp2IlInjected.Token(Token = "0x2000831")]
	public delegate void OnPlayerSelected(PlayerFileData player);

	[Cpp2IlInjected.Token(Token = "0x2000832")]
	public enum AutoPauseMode
	{
		[Cpp2IlInjected.Token(Token = "0x4007E22")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x4007E23")]
		Menus,
		[Cpp2IlInjected.Token(Token = "0x4007E24")]
		Inventory
	}

	[Cpp2IlInjected.Token(Token = "0x2000833")]
	public enum WorldPreparationState
	{
		[Cpp2IlInjected.Token(Token = "0x4007E26")]
		AwaitingData,
		[Cpp2IlInjected.Token(Token = "0x4007E27")]
		ProcessingData,
		[Cpp2IlInjected.Token(Token = "0x4007E28")]
		Ready
	}

	[Cpp2IlInjected.Token(Token = "0x2000834")]
	public struct MouseTextCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E29")]
		public bool noOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4007E2A")]
		public bool isValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E2B")]
		public string cursorText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E2C")]
		public int rare;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E2D")]
		public byte diff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E2E")]
		public int X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007E2F")]
		public int Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007E30")]
		public int hackedScreenWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007E31")]
		public int hackedScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007E32")]
		public string buffTooltip;
	}

	[Cpp2IlInjected.Token(Token = "0x2000835")]
	public class BackgroundDrawInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E33")]
		public SpriteBatch backgroundSpriteBatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E34")]
		public Color[] backgroundColorSlicesStatic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E35")]
		public VertexColors bgColors;

		[Cpp2IlInjected.Token(Token = "0x600499E")]
		[Cpp2IlInjected.Address(RVA = "0x14C304C", Offset = "0x14C304C", VA = "0x14C304C")]
		public BackgroundDrawInfo()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000836")]
	public struct SceneArea
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E36")]
		public Vector2 SceneLocalScreenPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E37")]
		public float totalWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E38")]
		public float totalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E39")]
		public int bgTopY;
	}

	[Cpp2IlInjected.Token(Token = "0x2000837")]
	public struct InfoToSetBackColor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007E3A")]
		public bool isInGameMenuOrIsServer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007E3B")]
		public float CorruptionBiomeInfluence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E3C")]
		public float CrimsonBiomeInfluence;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007E3D")]
		public float JungleBiomeInfluence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007E3E")]
		public float MushroomBiomeInfluence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007E3F")]
		public float GraveyardInfluence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007E40")]
		public bool BloodMoonActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4007E41")]
		public bool LanternNightActive;
	}

	[Cpp2IlInjected.Token(Token = "0x400227C")]
	public static bool SettingsEnabled_AutoReuseAllItems;

	[Cpp2IlInjected.Token(Token = "0x400227D")]
	public static int CurrentDrawnEntityShader;

	[Cpp2IlInjected.Token(Token = "0x400227E")]
	public static Entity CurrentDrawnEntity;

	[Cpp2IlInjected.Token(Token = "0x400227F")]
	public static bool LightingEveryFrame;

	[Cpp2IlInjected.Token(Token = "0x4002280")]
	public static bool AllowUnfocusedInputOnGamepad;

	[Cpp2IlInjected.Token(Token = "0x4002281")]
	public static bool CrouchingEnabled;

	[Cpp2IlInjected.Token(Token = "0x4002282")]
	public static Main instance;

	[Cpp2IlInjected.Token(Token = "0x4002283")]
	public static bool AnnouncementBoxDisabled;

	[Cpp2IlInjected.Token(Token = "0x4002284")]
	public static int AnnouncementBoxRange;

	[Cpp2IlInjected.Token(Token = "0x4002285")]
	private static GameModeData _currentGameModeInfo;

	[Cpp2IlInjected.Token(Token = "0x4002286")]
	public static bool drunkWorld;

	[Cpp2IlInjected.Token(Token = "0x4002287")]
	public static bool getGoodWorld;

	[Cpp2IlInjected.Token(Token = "0x4002288")]
	public static Vector2 destroyerHB;

	[Cpp2IlInjected.Token(Token = "0x4002289")]
	public static FileMetadata WorldFileMetadata;

	[Cpp2IlInjected.Token(Token = "0x400228A")]
	public static PingMapLayer Pings;

	[Cpp2IlInjected.Token(Token = "0x400228B")]
	public static CreativeUI CreativeMenu;

	[Cpp2IlInjected.Token(Token = "0x400228C")]
	public static MapIconOverlay MapIcons;

	[Cpp2IlInjected.Token(Token = "0x400228D")]
	private static Vector2 _lastPingMousePosition;

	[Cpp2IlInjected.Token(Token = "0x400228E")]
	private static double _lastPingMouseDownTime;

	[Cpp2IlInjected.Token(Token = "0x400228F")]
	private static OnPlayerSelected _pendingCharacterSelect;

	[Cpp2IlInjected.Token(Token = "0x4002290")]
	public static bool drawBackGore;

	[Cpp2IlInjected.Token(Token = "0x4002291")]
	public static ulong LobbyId;

	[Cpp2IlInjected.Token(Token = "0x4002292")]
	public static bool ServerSideCharacter;

	[Cpp2IlInjected.Token(Token = "0x4002293")]
	public static string clientUUID;

	[Cpp2IlInjected.Token(Token = "0x4002294")]
	private static int toolTipDistance;

	[Cpp2IlInjected.Token(Token = "0x4002295")]
	public static float GlobalTimeWrappedHourly;

	[Cpp2IlInjected.Token(Token = "0x4002296")]
	public static bool GlobalTimerPaused;

	[Cpp2IlInjected.Token(Token = "0x4002297")]
	public static GameTime gameTimeCache;

	[Cpp2IlInjected.Token(Token = "0x4002298")]
	public static ulong TileFrameSeed;

	[Cpp2IlInjected.Token(Token = "0x4002299")]
	private static ulong _drawCycleCounter;

	[Cpp2IlInjected.Token(Token = "0x400229A")]
	public static int npcStreamSpeed;

	[Cpp2IlInjected.Token(Token = "0x400229B")]
	public static bool superFast;

	[Cpp2IlInjected.Token(Token = "0x400229C")]
	private static float cameraLerp;

	[Cpp2IlInjected.Token(Token = "0x400229D")]
	private static int cameraLerpTimer;

	[Cpp2IlInjected.Token(Token = "0x400229E")]
	private static int cameraLerpTimeToggle;

	[Cpp2IlInjected.Token(Token = "0x400229F")]
	private static bool cameraGamePadLerp;

	[Cpp2IlInjected.Token(Token = "0x40022A0")]
	public static bool[] townNPCCanSpawn;

	[Cpp2IlInjected.Token(Token = "0x40022A1")]
	public static int musicBox2;

	[Cpp2IlInjected.Token(Token = "0x40022A2")]
	public static int musicBoxNotModifiedByVolume;

	[Cpp2IlInjected.Token(Token = "0x40022A3")]
	public static byte HealthBarDrawSettings;

	[Cpp2IlInjected.Token(Token = "0x40022A4")]
	public static float wFrCounter;

	[Cpp2IlInjected.Token(Token = "0x40022A5")]
	public static float wFrame;

	[Cpp2IlInjected.Token(Token = "0x40022A6")]
	public static float upTimer;

	[Cpp2IlInjected.Token(Token = "0x40022A7")]
	public static float upTimerMax;

	[Cpp2IlInjected.Token(Token = "0x40022A8")]
	public static float upTimerMaxDelay;

	[Cpp2IlInjected.Token(Token = "0x40022A9")]
	public static bool drawDiag;

	[Cpp2IlInjected.Token(Token = "0x40022AA")]
	public static bool drawRelease;

	[Cpp2IlInjected.Token(Token = "0x40022AB")]
	public static bool drawBetterDebug;

	[Cpp2IlInjected.Token(Token = "0x40022AC")]
	public static bool betterDebugRelease;

	[Cpp2IlInjected.Token(Token = "0x40022AD")]
	public static bool drawToScreen;

	[Cpp2IlInjected.Token(Token = "0x40022AE")]
	public static bool targetSet;

	[Cpp2IlInjected.Token(Token = "0x40022AF")]
	private static ConcurrentQueue<Action> _mainThreadActions;

	[Cpp2IlInjected.Token(Token = "0x40022B0")]
	public static float essScale;

	[Cpp2IlInjected.Token(Token = "0x40022B1")]
	public static int essDir;

	[Cpp2IlInjected.Token(Token = "0x40022B2")]
	public static float[] cloudBGX;

	[Cpp2IlInjected.Token(Token = "0x40022B3")]
	public static float cloudBGAlpha;

	[Cpp2IlInjected.Token(Token = "0x40022B4")]
	public static float cloudBGActive;

	[Cpp2IlInjected.Token(Token = "0x40022B5")]
	public static int[] cloudBG;

	[Cpp2IlInjected.Token(Token = "0x40022B6")]
	public static int[] treeMntBGSet1;

	[Cpp2IlInjected.Token(Token = "0x40022B7")]
	public static int[] treeMntBGSet2;

	[Cpp2IlInjected.Token(Token = "0x40022B8")]
	public static int[] treeMntBGSet3;

	[Cpp2IlInjected.Token(Token = "0x40022B9")]
	public static int[] treeMntBGSet4;

	[Cpp2IlInjected.Token(Token = "0x40022BA")]
	public static int[] treeBGSet1;

	[Cpp2IlInjected.Token(Token = "0x40022BB")]
	public static int[] treeBGSet2;

	[Cpp2IlInjected.Token(Token = "0x40022BC")]
	public static int[] treeBGSet3;

	[Cpp2IlInjected.Token(Token = "0x40022BD")]
	public static int[] treeBGSet4;

	[Cpp2IlInjected.Token(Token = "0x40022BE")]
	public static int[] corruptBG;

	[Cpp2IlInjected.Token(Token = "0x40022BF")]
	public static int[] jungleBG;

	[Cpp2IlInjected.Token(Token = "0x40022C0")]
	public static int[] snowMntBG;

	[Cpp2IlInjected.Token(Token = "0x40022C1")]
	public static int[] snowBG;

	[Cpp2IlInjected.Token(Token = "0x40022C2")]
	public static int[] hallowBG;

	[Cpp2IlInjected.Token(Token = "0x40022C3")]
	public static int[] crimsonBG;

	[Cpp2IlInjected.Token(Token = "0x40022C4")]
	public static int[] desertBG;

	[Cpp2IlInjected.Token(Token = "0x40022C5")]
	public static int[] mushroomBG;

	[Cpp2IlInjected.Token(Token = "0x40022C6")]
	public static int oceanBG;

	[Cpp2IlInjected.Token(Token = "0x40022C7")]
	public static int[] underworldBG;

	[Cpp2IlInjected.Token(Token = "0x40022C8")]
	public static int[] treeX;

	[Cpp2IlInjected.Token(Token = "0x40022C9")]
	public static int[] treeStyle;

	[Cpp2IlInjected.Token(Token = "0x40022CA")]
	public static int[] caveBackX;

	[Cpp2IlInjected.Token(Token = "0x40022CB")]
	public static int[] caveBackStyle;

	[Cpp2IlInjected.Token(Token = "0x40022CC")]
	public static int iceBackStyle;

	[Cpp2IlInjected.Token(Token = "0x40022CD")]
	public static int hellBackStyle;

	[Cpp2IlInjected.Token(Token = "0x40022CE")]
	public static int jungleBackStyle;

	[Cpp2IlInjected.Token(Token = "0x40022CF")]
	public static string debugWords;

	[Cpp2IlInjected.Token(Token = "0x40022D0")]
	public static bool gamePad;

	[Cpp2IlInjected.Token(Token = "0x40022D1")]
	public static bool xMas;

	[Cpp2IlInjected.Token(Token = "0x40022D2")]
	public static bool halloween;

	[Cpp2IlInjected.Token(Token = "0x40022D3")]
	public static bool forceXMasForToday;

	[Cpp2IlInjected.Token(Token = "0x40022D4")]
	public static bool forceHalloweenForToday;

	[Cpp2IlInjected.Token(Token = "0x40022D5")]
	public static int snowDust;

	[Cpp2IlInjected.Token(Token = "0x40022D6")]
	public static bool changeTheTitle;

	[Cpp2IlInjected.Token(Token = "0x40022D7")]
	public static int keyCount;

	[Cpp2IlInjected.Token(Token = "0x40022D8")]
	public static string[] keyString;

	[Cpp2IlInjected.Token(Token = "0x40022D9")]
	public static int[] keyInt;

	[Cpp2IlInjected.Token(Token = "0x40022DA")]
	public static double UpdateTimeAccumulator;

	[Cpp2IlInjected.Token(Token = "0x40022DB")]
	public static bool drawSkip;

	[Cpp2IlInjected.Token(Token = "0x40022DC")]
	public static int fpsCount;

	[Cpp2IlInjected.Token(Token = "0x40022DD")]
	public static Stopwatch fpsTimer;

	[Cpp2IlInjected.Token(Token = "0x40022DE")]
	public static int dayRate;

	[Cpp2IlInjected.Token(Token = "0x40022DF")]
	public static int desiredWorldTilesUpdateRate;

	[Cpp2IlInjected.Token(Token = "0x40022E0")]
	public static int maxScreenW;

	[Cpp2IlInjected.Token(Token = "0x40022E1")]
	public static int maxScreenH;

	[Cpp2IlInjected.Token(Token = "0x40022E2")]
	public static int minScreenW;

	[Cpp2IlInjected.Token(Token = "0x40022E3")]
	public static int minScreenH;

	[Cpp2IlInjected.Token(Token = "0x40022E4")]
	public static float iS;

	[Cpp2IlInjected.Token(Token = "0x40022E5")]
	public static int buffScanAreaWidth;

	[Cpp2IlInjected.Token(Token = "0x40022E6")]
	public static int buffScanAreaHeight;

	[Cpp2IlInjected.Token(Token = "0x40022E7")]
	public static float musicPitch;

	[Cpp2IlInjected.Token(Token = "0x40022E8")]
	public static int maxMP;

	[Cpp2IlInjected.Token(Token = "0x40022E9")]
	public static string[] recentWorld;

	[Cpp2IlInjected.Token(Token = "0x40022EA")]
	public static string[] recentIP;

	[Cpp2IlInjected.Token(Token = "0x40022EB")]
	public static int[] recentPort;

	[Cpp2IlInjected.Token(Token = "0x40022EC")]
	public static bool[] recentHardMode;

	[Cpp2IlInjected.Token(Token = "0x40022ED")]
	public static short[] recentGameMode;

	[Cpp2IlInjected.Token(Token = "0x40022EE")]
	public static bool[] recentCrimson;

	[Cpp2IlInjected.Token(Token = "0x40022EF")]
	public static int[] recentSizeX;

	[Cpp2IlInjected.Token(Token = "0x40022F0")]
	public static bool[] recentFavorite;

	[Cpp2IlInjected.Token(Token = "0x40022F1")]
	public static bool shortRender;

	[Cpp2IlInjected.Token(Token = "0x40022F2")]
	public static int ladyBugRainBoost;

	[Cpp2IlInjected.Token(Token = "0x40022F3")]
	public const int BG_STYLES_COUNT = 14;

	[Cpp2IlInjected.Token(Token = "0x40022F4")]
	public static int EquipPage;

	[Cpp2IlInjected.Token(Token = "0x40022F5")]
	public static int EquipPageSelected;

	[Cpp2IlInjected.Token(Token = "0x40022F6")]
	public static int wofNPCIndex;

	[Cpp2IlInjected.Token(Token = "0x40022F7")]
	public static int wofDrawAreaTop;

	[Cpp2IlInjected.Token(Token = "0x40022F8")]
	public static int wofDrawAreaBottom;

	[Cpp2IlInjected.Token(Token = "0x40022F9")]
	public static int wofDrawFrameIndex;

	[Cpp2IlInjected.Token(Token = "0x40022FA")]
	public static int offScreenRange;

	[Cpp2IlInjected.Token(Token = "0x40022FB")]
	public static int maxMapUpdates;

	[Cpp2IlInjected.Token(Token = "0x40022FC")]
	public static int textureMaxWidth;

	[Cpp2IlInjected.Token(Token = "0x40022FD")]
	public static int textureMaxHeight;

	[Cpp2IlInjected.Token(Token = "0x40022FE")]
	public static int mapTargetX;

	[Cpp2IlInjected.Token(Token = "0x40022FF")]
	public static int mapTargetY;

	[Cpp2IlInjected.Token(Token = "0x4002300")]
	public static bool[,] initMap;

	[Cpp2IlInjected.Token(Token = "0x4002301")]
	public static float mapMinimapDefaultScale;

	[Cpp2IlInjected.Token(Token = "0x4002302")]
	private static uint _gameUpdateCount;

	[Cpp2IlInjected.Token(Token = "0x4002303")]
	public static bool SkipAssemblyLoad;

	[Cpp2IlInjected.Token(Token = "0x4002304")]
	public static KeyboardState keyState;

	[Cpp2IlInjected.Token(Token = "0x4002305")]
	public static KeyboardState oldKeyState;

	[Cpp2IlInjected.Token(Token = "0x4002306")]
	public static bool craftingHide;

	[Cpp2IlInjected.Token(Token = "0x4002307")]
	public static bool armorHide;

	[Cpp2IlInjected.Token(Token = "0x4002308")]
	public static float shimmerAlpha;

	[Cpp2IlInjected.Token(Token = "0x4002309")]
	public static float shimmerDarken;

	[Cpp2IlInjected.Token(Token = "0x400230A")]
	public static float shimmerBrightenDelay;

	[Cpp2IlInjected.Token(Token = "0x400230B")]
	public static float craftingAlpha;

	[Cpp2IlInjected.Token(Token = "0x400230C")]
	public static float armorAlpha;

	[Cpp2IlInjected.Token(Token = "0x400230D")]
	public static float[] buffAlpha;

	[Cpp2IlInjected.Token(Token = "0x400230E")]
	public static bool hardMode;

	[Cpp2IlInjected.Token(Token = "0x400230F")]
	public static Vector2 sceneWaterPos;

	[Cpp2IlInjected.Token(Token = "0x4002310")]
	public static Vector2 sceneTilePos;

	[Cpp2IlInjected.Token(Token = "0x4002311")]
	public static Vector2 sceneTile2Pos;

	[Cpp2IlInjected.Token(Token = "0x4002312")]
	public static Vector2 sceneWallPos;

	[Cpp2IlInjected.Token(Token = "0x4002313")]
	public static Vector2 sceneBackgroundPos;

	[Cpp2IlInjected.Token(Token = "0x4002314")]
	public static bool maxQ;

	[Cpp2IlInjected.Token(Token = "0x4002315")]
	public static int DiscoR;

	[Cpp2IlInjected.Token(Token = "0x4002316")]
	public static int DiscoB;

	[Cpp2IlInjected.Token(Token = "0x4002317")]
	public static int DiscoG;

	[Cpp2IlInjected.Token(Token = "0x4002318")]
	public static int teamCooldownLen;

	[Cpp2IlInjected.Token(Token = "0x4002319")]
	public static bool gamePaused;

	[Cpp2IlInjected.Token(Token = "0x400231A")]
	public static bool gameInactive;

	[Cpp2IlInjected.Token(Token = "0x400231B")]
	public static int updatesCountedForFPS;

	[Cpp2IlInjected.Token(Token = "0x400231C")]
	public static int drawsCountedForFPS;

	[Cpp2IlInjected.Token(Token = "0x400231D")]
	public static int uCount;

	[Cpp2IlInjected.Token(Token = "0x400231E")]
	public static int updateRate;

	[Cpp2IlInjected.Token(Token = "0x400231F")]
	public static int frameRate;

	[Cpp2IlInjected.Token(Token = "0x4002320")]
	public static bool RGBRelease;

	[Cpp2IlInjected.Token(Token = "0x4002321")]
	public static bool qRelease;

	[Cpp2IlInjected.Token(Token = "0x4002322")]
	public static bool netRelease;

	[Cpp2IlInjected.Token(Token = "0x4002323")]
	public static bool frameRelease;

	[Cpp2IlInjected.Token(Token = "0x4002324")]
	public static int magmaBGFrame;

	[Cpp2IlInjected.Token(Token = "0x4002325")]
	public static int magmaBGFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002326")]
	public static int saveTimer;

	[Cpp2IlInjected.Token(Token = "0x4002327")]
	public static bool autoJoin;

	[Cpp2IlInjected.Token(Token = "0x4002328")]
	public static bool serverStarting;

	[Cpp2IlInjected.Token(Token = "0x4002329")]
	public static float leftWorld;

	[Cpp2IlInjected.Token(Token = "0x400232A")]
	public static float rightWorld;

	[Cpp2IlInjected.Token(Token = "0x400232B")]
	public static float topWorld;

	[Cpp2IlInjected.Token(Token = "0x400232C")]
	public static float bottomWorld;

	[Cpp2IlInjected.Token(Token = "0x400232D")]
	public static int maxTilesX;

	[Cpp2IlInjected.Token(Token = "0x400232E")]
	public static int maxTilesY;

	[Cpp2IlInjected.Token(Token = "0x400232F")]
	public static int maxSectionsX;

	[Cpp2IlInjected.Token(Token = "0x4002330")]
	public static int maxSectionsY;

	[Cpp2IlInjected.Token(Token = "0x4002331")]
	public static int maxDustToDraw;

	[Cpp2IlInjected.Token(Token = "0x4002332")]
	public static int maxNetPlayers;

	[Cpp2IlInjected.Token(Token = "0x4002333")]
	public static int activePlayerCount;

	[Cpp2IlInjected.Token(Token = "0x4002334")]
	public static int maxActivePlayers;

	[Cpp2IlInjected.Token(Token = "0x4002335")]
	public static int maxRain;

	[Cpp2IlInjected.Token(Token = "0x4002336")]
	public static int slimeWarningTime;

	[Cpp2IlInjected.Token(Token = "0x4002337")]
	public static int slimeWarningDelay;

	[Cpp2IlInjected.Token(Token = "0x4002338")]
	public static float slimeRainNPCSlots;

	[Cpp2IlInjected.Token(Token = "0x4002339")]
	public static bool[] slimeRainNPC;

	[Cpp2IlInjected.Token(Token = "0x400233A")]
	public static double slimeRainTime;

	[Cpp2IlInjected.Token(Token = "0x400233B")]
	public static bool slimeRain;

	[Cpp2IlInjected.Token(Token = "0x400233C")]
	public static int slimeRainKillCount;

	[Cpp2IlInjected.Token(Token = "0x400233D")]
	public static float cameraX;

	[Cpp2IlInjected.Token(Token = "0x400233E")]
	public static int WorldRollingBackupsCountToKeep;

	[Cpp2IlInjected.Token(Token = "0x400233F")]
	public static bool swapMusic;

	[Cpp2IlInjected.Token(Token = "0x4002340")]
	public static int dungeonX;

	[Cpp2IlInjected.Token(Token = "0x4002341")]
	public static int dungeonY;

	[Cpp2IlInjected.Token(Token = "0x4002342")]
	public static Liquid[] liquid;

	[Cpp2IlInjected.Token(Token = "0x4002343")]
	public static LiquidBuffer[] liquidBuffer;

	[Cpp2IlInjected.Token(Token = "0x4002344")]
	public static bool dedServ;

	[Cpp2IlInjected.Token(Token = "0x4002345")]
	public static int spamCount;

	[Cpp2IlInjected.Token(Token = "0x4002346")]
	public static int newMusic;

	[Cpp2IlInjected.Token(Token = "0x4002347")]
	public static int curMusic;

	[Cpp2IlInjected.Token(Token = "0x4002348")]
	public static int dayMusic;

	[Cpp2IlInjected.Token(Token = "0x4002349")]
	public static int ugMusic;

	[Cpp2IlInjected.Token(Token = "0x400234A")]
	public static bool bannerMouseOver;

	[Cpp2IlInjected.Token(Token = "0x400234B")]
	public static string buffString;

	[Cpp2IlInjected.Token(Token = "0x400234C")]
	public static string libPath;

	[Cpp2IlInjected.Token(Token = "0x400234D")]
	public static int lo;

	[Cpp2IlInjected.Token(Token = "0x400234E")]
	public static int LogoA;

	[Cpp2IlInjected.Token(Token = "0x400234F")]
	public static int LogoB;

	[Cpp2IlInjected.Token(Token = "0x4002350")]
	public static bool LogoT;

	[Cpp2IlInjected.Token(Token = "0x4002351")]
	public static string statusText;

	[Cpp2IlInjected.Token(Token = "0x4002352")]
	public static string worldName;

	[Cpp2IlInjected.Token(Token = "0x4002353")]
	public static int worldID;

	[Cpp2IlInjected.Token(Token = "0x4002354")]
	public static Color tileColor;

	[Cpp2IlInjected.Token(Token = "0x4002355")]
	public static double worldSurface;

	[Cpp2IlInjected.Token(Token = "0x4002356")]
	public static double rockLayer;

	[Cpp2IlInjected.Token(Token = "0x4002357")]
	public static bool dayTime;

	[Cpp2IlInjected.Token(Token = "0x4002358")]
	public static double time;

	[Cpp2IlInjected.Token(Token = "0x4002359")]
	public static double timeForVisualEffects;

	[Cpp2IlInjected.Token(Token = "0x400235A")]
	public static int moonPhase;

	[Cpp2IlInjected.Token(Token = "0x400235B")]
	public static short sunModY;

	[Cpp2IlInjected.Token(Token = "0x400235C")]
	public static short moonModY;

	[Cpp2IlInjected.Token(Token = "0x400235D")]
	public static bool alreadyGrabbingSunOrMoon;

	[Cpp2IlInjected.Token(Token = "0x400235E")]
	public static bool bloodMoon;

	[Cpp2IlInjected.Token(Token = "0x400235F")]
	public static bool pumpkinMoon;

	[Cpp2IlInjected.Token(Token = "0x4002360")]
	public static bool snowMoon;

	[Cpp2IlInjected.Token(Token = "0x4002361")]
	public static float cloudAlpha;

	[Cpp2IlInjected.Token(Token = "0x4002362")]
	public static float maxRaining;

	[Cpp2IlInjected.Token(Token = "0x4002363")]
	public static float oldMaxRaining;

	[Cpp2IlInjected.Token(Token = "0x4002364")]
	public static int rainTime;

	[Cpp2IlInjected.Token(Token = "0x4002365")]
	public static bool raining;

	[Cpp2IlInjected.Token(Token = "0x4002366")]
	public static bool eclipse;

	[Cpp2IlInjected.Token(Token = "0x4002367")]
	public static float eclipseLight;

	[Cpp2IlInjected.Token(Token = "0x4002368")]
	public static int checkForSpawns;

	[Cpp2IlInjected.Token(Token = "0x4002369")]
	public static int helpText;

	[Cpp2IlInjected.Token(Token = "0x400236A")]
	public static int BartenderHelpTextIndex;

	[Cpp2IlInjected.Token(Token = "0x400236B")]
	public static float demonTorch;

	[Cpp2IlInjected.Token(Token = "0x400236C")]
	public static int demonTorchDir;

	[Cpp2IlInjected.Token(Token = "0x400236D")]
	public static float martianLight;

	[Cpp2IlInjected.Token(Token = "0x400236E")]
	public static int martianLightDir;

	[Cpp2IlInjected.Token(Token = "0x400236F")]
	public static float masterColor;

	[Cpp2IlInjected.Token(Token = "0x4002370")]
	public static int masterColorDir;

	[Cpp2IlInjected.Token(Token = "0x4002371")]
	public static int numStars;

	[Cpp2IlInjected.Token(Token = "0x4002372")]
	public static int weatherCounter;

	[Cpp2IlInjected.Token(Token = "0x4002373")]
	public static int numClouds;

	[Cpp2IlInjected.Token(Token = "0x4002374")]
	public static int numCloudsTemp;

	[Cpp2IlInjected.Token(Token = "0x4002375")]
	public static float windSpeedCurrent;

	[Cpp2IlInjected.Token(Token = "0x4002376")]
	public static float windSpeedTarget;

	[Cpp2IlInjected.Token(Token = "0x4002377")]
	public static int windCounter;

	[Cpp2IlInjected.Token(Token = "0x4002378")]
	public static int extremeWindCounter;

	[Cpp2IlInjected.Token(Token = "0x4002379")]
	public static bool windPhysics;

	[Cpp2IlInjected.Token(Token = "0x400237A")]
	public static float windPhysicsStrength;

	[Cpp2IlInjected.Token(Token = "0x400237B")]
	public static Cloud[] cloud;

	[Cpp2IlInjected.Token(Token = "0x400237C")]
	public static bool resetClouds;

	[Cpp2IlInjected.Token(Token = "0x400237D")]
	public static float SmoothedMushroomLightInfluence;

	[Cpp2IlInjected.Token(Token = "0x400237E")]
	public static int fadeCounter;

	[Cpp2IlInjected.Token(Token = "0x400237F")]
	public static float invAlpha;

	[Cpp2IlInjected.Token(Token = "0x4002380")]
	public static float invDir;

	[Cpp2IlInjected.Token(Token = "0x4002381")]
	public static bool allChestStackHover;

	[Cpp2IlInjected.Token(Token = "0x4002382")]
	public static bool inventorySortMouseOver;

	[Cpp2IlInjected.Token(Token = "0x4002383")]
	public static int moonType;

	[Cpp2IlInjected.Token(Token = "0x4002384")]
	public static bool UseExperimentalFeatures;

	[Cpp2IlInjected.Token(Token = "0x4002385")]
	public static string DefaultSeed;

	[Cpp2IlInjected.Token(Token = "0x4002386")]
	public static float[] musicFade;

	[Cpp2IlInjected.Token(Token = "0x4002387")]
	public static HairstyleUnlocksHelper Hairstyles;

	[Cpp2IlInjected.Token(Token = "0x4002388")]
	public static bool tilesLoaded;

	[Cpp2IlInjected.Token(Token = "0x4002389")]
	public static TileData tile;

	[Cpp2IlInjected.Token(Token = "0x400238A")]
	public static Dust[] dust;

	[Cpp2IlInjected.Token(Token = "0x400238B")]
	public static Star[] star;

	[Cpp2IlInjected.Token(Token = "0x400238C")]
	public static Item[] item;

	[Cpp2IlInjected.Token(Token = "0x400238D")]
	public static int[] timeItemSlotCannotBeReusedFor;

	[Cpp2IlInjected.Token(Token = "0x400238E")]
	public static NPC[] npc;

	[Cpp2IlInjected.Token(Token = "0x400238F")]
	public static Gore[] gore;

	[Cpp2IlInjected.Token(Token = "0x4002390")]
	public static List<int> BoneJavlinProjectiles;

	[Cpp2IlInjected.Token(Token = "0x4002391")]
	public static List<int> TentacleSpikeProjectiles;

	[Cpp2IlInjected.Token(Token = "0x4002392")]
	public static List<int> DaybreakProjectiles;

	[Cpp2IlInjected.Token(Token = "0x4002393")]
	public static List<int> StardustCellMinionShotProjectiles;

	[Cpp2IlInjected.Token(Token = "0x4002394")]
	public static Projectile[] projectile;

	[Cpp2IlInjected.Token(Token = "0x4002395")]
	public static int[,] projectileIdentity;

	[Cpp2IlInjected.Token(Token = "0x4002396")]
	public static CombatText[] combatText;

	[Cpp2IlInjected.Token(Token = "0x4002397")]
	public static Chest[] chest;

	[Cpp2IlInjected.Token(Token = "0x4002398")]
	public static Sign[] sign;

	[Cpp2IlInjected.Token(Token = "0x4002399")]
	public static int[] itemFrame;

	[Cpp2IlInjected.Token(Token = "0x400239A")]
	public static int[] itemFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400239B")]
	public static bool screenMaximized;

	[Cpp2IlInjected.Token(Token = "0x400239C")]
	public static bool screenBorderless;

	[Cpp2IlInjected.Token(Token = "0x400239D")]
	public static int screenBorderlessPendingResizes;

	[Cpp2IlInjected.Token(Token = "0x400239E")]
	public static int teamNamePlateDistance;

	[Cpp2IlInjected.Token(Token = "0x400239F")]
	public static int multiplayerNPCSmoothingRange;

	[Cpp2IlInjected.Token(Token = "0x40023A0")]
	public static bool Setting_UseReducedMaxLiquids;

	[Cpp2IlInjected.Token(Token = "0x40023A1")]
	public static int PlayerOverheadChatMessageDisplayTime;

	[Cpp2IlInjected.Token(Token = "0x40023A2")]
	public static object CurrentInputTextTakerOverride;

	[Cpp2IlInjected.Token(Token = "0x40023A3")]
	public static bool drawingPlayerChat;

	[Cpp2IlInjected.Token(Token = "0x40023A4")]
	public static bool chatRelease;

	[Cpp2IlInjected.Token(Token = "0x40023A5")]
	public static string chatText;

	[Cpp2IlInjected.Token(Token = "0x40023A6")]
	public static bool inputTextEnter;

	[Cpp2IlInjected.Token(Token = "0x40023A7")]
	public static bool inputTextEscape;

	[Cpp2IlInjected.Token(Token = "0x40023A8")]
	public static float[] hotbarScale;

	[Cpp2IlInjected.Token(Token = "0x40023A9")]
	public static byte mouseTextColor;

	[Cpp2IlInjected.Token(Token = "0x40023AA")]
	public static int mouseTextColorChange;

	[Cpp2IlInjected.Token(Token = "0x40023AB")]
	public static bool hasFocus;

	[Cpp2IlInjected.Token(Token = "0x40023AC")]
	public static bool recFastScroll;

	[Cpp2IlInjected.Token(Token = "0x40023AD")]
	public static bool recBigList;

	[Cpp2IlInjected.Token(Token = "0x40023AE")]
	public static int recStart;

	[Cpp2IlInjected.Token(Token = "0x40023AF")]
	public static Recipe[] recipe;

	[Cpp2IlInjected.Token(Token = "0x40023B0")]
	public static float[] availableRecipeY;

	[Cpp2IlInjected.Token(Token = "0x40023B1")]
	public static Player[] player;

	[Cpp2IlInjected.Token(Token = "0x40023B2")]
	public static Player[] playerVisualClone;

	[Cpp2IlInjected.Token(Token = "0x40023B3")]
	public static bool[] countsAsHostForGameplay;

	[Cpp2IlInjected.Token(Token = "0x40023B4")]
	public static int[] travelShop;

	[Cpp2IlInjected.Token(Token = "0x40023B5")]
	public static List<string> anglerWhoFinishedToday;

	[Cpp2IlInjected.Token(Token = "0x40023B6")]
	public static int anglerQuest;

	[Cpp2IlInjected.Token(Token = "0x40023B7")]
	public static AmbienceServer AmbienceServer;

	[Cpp2IlInjected.Token(Token = "0x40023B8")]
	public static ItemDropDatabase ItemDropsDB;

	[Cpp2IlInjected.Token(Token = "0x40023B9")]
	public static BestiaryDatabase BestiaryDB;

	[Cpp2IlInjected.Token(Token = "0x40023BA")]
	public static ItemDropResolver ItemDropSolver;

	[Cpp2IlInjected.Token(Token = "0x40023BB")]
	public static BestiaryUnlocksTracker BestiaryTracker;

	[Cpp2IlInjected.Token(Token = "0x40023BC")]
	public static TeleportPylonsSystem PylonSystem;

	[Cpp2IlInjected.Token(Token = "0x40023BD")]
	public static ShopHelper ShopHelper;

	[Cpp2IlInjected.Token(Token = "0x40023BE")]
	public static bool Support4K;

	[Cpp2IlInjected.Token(Token = "0x40023BF")]
	public static float MinimumZoomComparerX;

	[Cpp2IlInjected.Token(Token = "0x40023C0")]
	public static float MinimumZoomComparerY;

	[Cpp2IlInjected.Token(Token = "0x40023C1")]
	public static int LogicCheckScreenWidth;

	[Cpp2IlInjected.Token(Token = "0x40023C2")]
	public static int LogicCheckScreenHeight;

	[Cpp2IlInjected.Token(Token = "0x40023C3")]
	private static WorldPreparationState _worldPreparationState;

	[Cpp2IlInjected.Token(Token = "0x40023C4")]
	public static float temporaryGUIScaleSlider;

	[Cpp2IlInjected.Token(Token = "0x40023C5")]
	public static bool temporaryGUIScaleSliderUpdate;

	[Cpp2IlInjected.Token(Token = "0x40023C6")]
	public static Item HoverItem;

	[Cpp2IlInjected.Token(Token = "0x40023C7")]
	private static int backSpaceCount;

	[Cpp2IlInjected.Token(Token = "0x40023C8")]
	private static float backSpaceRate;

	[Cpp2IlInjected.Token(Token = "0x40023C9")]
	public static string motd;

	[Cpp2IlInjected.Token(Token = "0x40023CA")]
	public static bool toggleFullscreen;

	[Cpp2IlInjected.Token(Token = "0x40023CB")]
	public static int numDisplayModes;

	[Cpp2IlInjected.Token(Token = "0x40023CC")]
	public static bool menuBGChangedDay;

	[Cpp2IlInjected.Token(Token = "0x40023CD")]
	public static bool menuBGChangedNight;

	[Cpp2IlInjected.Token(Token = "0x40023CE")]
	public static bool lockMenuBGChange;

	[Cpp2IlInjected.Token(Token = "0x40023CF")]
	public static List<WorldFileData> WorldList;

	[Cpp2IlInjected.Token(Token = "0x40023D0")]
	public static WorldFileData ActiveWorldFileData;

	[Cpp2IlInjected.Token(Token = "0x40023D1")]
	public static string CloudWorldPath;

	[Cpp2IlInjected.Token(Token = "0x40023D2")]
	private static string _playerPath;

	[Cpp2IlInjected.Token(Token = "0x40023D3")]
	public static string CloudPlayerPath;

	[Cpp2IlInjected.Token(Token = "0x40023D4")]
	private static string _oldPlayerPath;

	[Cpp2IlInjected.Token(Token = "0x40023D5")]
	private static string _oldWorldPath;

	[Cpp2IlInjected.Token(Token = "0x40023D6")]
	public static KeyboardState inputText;

	[Cpp2IlInjected.Token(Token = "0x40023D7")]
	public static KeyboardState oldInputText;

	[Cpp2IlInjected.Token(Token = "0x40023D8")]
	public static int PendingResolutionWidth;

	[Cpp2IlInjected.Token(Token = "0x40023D9")]
	public static int PendingResolutionHeight;

	[Cpp2IlInjected.Token(Token = "0x40023DA")]
	public static bool PendingBorderlessState;

	[Cpp2IlInjected.Token(Token = "0x40023DB")]
	public static int invasionType;

	[Cpp2IlInjected.Token(Token = "0x40023DC")]
	public static double invasionX;

	[Cpp2IlInjected.Token(Token = "0x40023DD")]
	public static int invasionSize;

	[Cpp2IlInjected.Token(Token = "0x40023DE")]
	public static int invasionDelay;

	[Cpp2IlInjected.Token(Token = "0x40023DF")]
	public static int invasionWarn;

	[Cpp2IlInjected.Token(Token = "0x40023E0")]
	public static int invasionSizeStart;

	[Cpp2IlInjected.Token(Token = "0x40023E1")]
	public static int invasionProgressIcon;

	[Cpp2IlInjected.Token(Token = "0x40023E2")]
	public static int invasionProgress;

	[Cpp2IlInjected.Token(Token = "0x40023E3")]
	public static int invasionProgressMax;

	[Cpp2IlInjected.Token(Token = "0x40023E4")]
	public static int invasionProgressWave;

	[Cpp2IlInjected.Token(Token = "0x40023E5")]
	public static int invasionWaveMax;

	[Cpp2IlInjected.Token(Token = "0x40023E6")]
	public static int invasionProgressDisplayLeft;

	[Cpp2IlInjected.Token(Token = "0x40023E7")]
	public static float invasionProgressAlpha;

	[Cpp2IlInjected.Token(Token = "0x40023E8")]
	public static bool HasInteractibleObjectThatIsNotATile;

	[Cpp2IlInjected.Token(Token = "0x40023E9")]
	public static bool mouseExit;

	[Cpp2IlInjected.Token(Token = "0x40023EA")]
	public static float exitScale;

	[Cpp2IlInjected.Token(Token = "0x40023EB")]
	public static bool mouseReforge;

	[Cpp2IlInjected.Token(Token = "0x40023EC")]
	public static float reforgeScale;

	[Cpp2IlInjected.Token(Token = "0x40023ED")]
	public static Player clientPlayer;

	[Cpp2IlInjected.Token(Token = "0x40023EE")]
	public static string getIP;

	[Cpp2IlInjected.Token(Token = "0x40023EF")]
	public static string getPort;

	[Cpp2IlInjected.Token(Token = "0x40023F0")]
	public static bool menuMultiplayer;

	[Cpp2IlInjected.Token(Token = "0x40023F1")]
	public static bool menuServer;

	[Cpp2IlInjected.Token(Token = "0x40023F2")]
	public static int netMode;

	[Cpp2IlInjected.Token(Token = "0x40023F3")]
	private static int _targetNetMode;

	[Cpp2IlInjected.Token(Token = "0x40023F4")]
	private static bool _hasPendingNetmodeChange;

	[Cpp2IlInjected.Token(Token = "0x40023F5")]
	public static int netPlayCounter;

	[Cpp2IlInjected.Token(Token = "0x40023F6")]
	public static int lastNPCUpdate;

	[Cpp2IlInjected.Token(Token = "0x40023F7")]
	public static int lastItemUpdate;

	[Cpp2IlInjected.Token(Token = "0x40023F8")]
	public static int maxNPCUpdates;

	[Cpp2IlInjected.Token(Token = "0x40023F9")]
	public static int maxItemUpdates;

	[Cpp2IlInjected.Token(Token = "0x40023FA")]
	public static ColorSlidersSet mouseColorSlider;

	[Cpp2IlInjected.Token(Token = "0x40023FB")]
	public static ColorSlidersSet mouseBorderColorSlider;

	[Cpp2IlInjected.Token(Token = "0x40023FC")]
	public static bool hideUI;

	[Cpp2IlInjected.Token(Token = "0x40023FD")]
	public static bool releaseUI;

	[Cpp2IlInjected.Token(Token = "0x40023FE")]
	public static int FrameSkipMode;

	[Cpp2IlInjected.Token(Token = "0x40023FF")]
	public static bool terrariasFixedTiming;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4002400")]
	private int splashCounter;

	[Cpp2IlInjected.Token(Token = "0x4002401")]
	public static ParticleRenderer ParticleSystem_World_OverPlayers;

	[Cpp2IlInjected.Token(Token = "0x4002402")]
	public static ParticleRenderer ParticleSystem_World_BehindPlayers;

	[Cpp2IlInjected.Token(Token = "0x4002403")]
	public static AnchoredEntitiesCollection sittingManager;

	[Cpp2IlInjected.Token(Token = "0x4002404")]
	public static AnchoredEntitiesCollection sleepingManager;

	[Cpp2IlInjected.Token(Token = "0x4002405")]
	private static bool shouldSetDefaultUIScale;

	[Cpp2IlInjected.Token(Token = "0x4002406")]
	private static float newDefaultUIScale;

	[Cpp2IlInjected.Token(Token = "0x4002407")]
	private static bool _target60FPS;

	[Cpp2IlInjected.Token(Token = "0x4002408")]
	private static bool startFullscreen;

	[Cpp2IlInjected.Token(Token = "0x4002409")]
	public static bool CaptureModeDisabled;

	[Cpp2IlInjected.Token(Token = "0x400240A")]
	public static bool unityMouseOver;

	[Cpp2IlInjected.Token(Token = "0x400240B")]
	public static bool LocalModeServer;

	[Cpp2IlInjected.Token(Token = "0x400240C")]
	public static IPlayerRenderer PlayerRenderer;

	[Cpp2IlInjected.Token(Token = "0x400240D")]
	public static IPlayerRenderer PotionOfReturnRenderer;

	[Cpp2IlInjected.Token(Token = "0x400240E")]
	public static MapHeadRenderer MapPlayerRenderer;

	[Cpp2IlInjected.Token(Token = "0x400240F")]
	public static NPCHeadRenderer TownNPCHeadRenderer;

	[Cpp2IlInjected.Token(Token = "0x4002410")]
	public static NPCHeadRenderer BossNPCHeadRenderer;

	[Cpp2IlInjected.Token(Token = "0x4002411")]
	private static bool? _overrideForExpertMode;

	[Cpp2IlInjected.Token(Token = "0x4002412")]
	private static bool? _overrideForMasterMode;

	[Cpp2IlInjected.Token(Token = "0x4002413")]
	public static int musicError;

	[Cpp2IlInjected.Token(Token = "0x4002414")]
	public static string oldStatusText;

	[Cpp2IlInjected.Token(Token = "0x4002415")]
	public static bool localPlayerConnected;

	[Cpp2IlInjected.Token(Token = "0x4002416")]
	public static bool autoShutdown;

	[Cpp2IlInjected.Token(Token = "0x4002417")]
	public static bool forceServerShutdown;

	[Cpp2IlInjected.Token(Token = "0x4002418")]
	public static bool serverBootupInProgress;

	[Cpp2IlInjected.Token(Token = "0x4002419")]
	public static int sundialCooldown;

	[Cpp2IlInjected.Token(Token = "0x400241A")]
	public static bool fastForwardTimeToDawn;

	[Cpp2IlInjected.Token(Token = "0x400241B")]
	public static bool _shouldUseWindyDayMusic;

	[Cpp2IlInjected.Token(Token = "0x400241C")]
	public static bool _shouldUseStormMusic;

	[Cpp2IlInjected.Token(Token = "0x400241D")]
	public static bool playOldTile;

	[Cpp2IlInjected.Token(Token = "0x400241E")]
	public static float ambientWaterfallX;

	[Cpp2IlInjected.Token(Token = "0x400241F")]
	public static float ambientWaterfallY;

	[Cpp2IlInjected.Token(Token = "0x4002420")]
	public static float ambientWaterfallStrength;

	[Cpp2IlInjected.Token(Token = "0x4002421")]
	public static float ambientLavafallX;

	[Cpp2IlInjected.Token(Token = "0x4002422")]
	public static float ambientLavafallY;

	[Cpp2IlInjected.Token(Token = "0x4002423")]
	public static float ambientLavafallStrength;

	[Cpp2IlInjected.Token(Token = "0x4002424")]
	public static float ambientLavaX;

	[Cpp2IlInjected.Token(Token = "0x4002425")]
	public static float ambientLavaY;

	[Cpp2IlInjected.Token(Token = "0x4002426")]
	public static float ambientLavaStrength;

	[Cpp2IlInjected.Token(Token = "0x4002427")]
	public static int ambientCounter;

	[Cpp2IlInjected.Token(Token = "0x4002428")]
	private static bool _isWaterfallMusicPlaying;

	[Cpp2IlInjected.Token(Token = "0x4002429")]
	private static bool _isLavafallMusicPlaying;

	[Cpp2IlInjected.Token(Token = "0x400242A")]
	public static IChatMonitor chatMonitor;

	[Cpp2IlInjected.Token(Token = "0x400242B")]
	public static int ProjectileUpdateLoopIndex;

	[Cpp2IlInjected.Token(Token = "0x400242C")]
	public static GameTipsDisplay gameTips;

	[Cpp2IlInjected.Token(Token = "0x400242D")]
	public static int weatherVaneBobframe;

	[Cpp2IlInjected.Token(Token = "0x400242E")]
	private static DrKeyboard_Base _keyboard;

	[Cpp2IlInjected.Token(Token = "0x400242F")]
	private static int _openedFrame;

	[Cpp2IlInjected.Token(Token = "0x4002430")]
	private static int _maxCharaceters;

	[Cpp2IlInjected.Token(Token = "0x4002431")]
	public static int selectedPlayer;

	[Cpp2IlInjected.Token(Token = "0x4002432")]
	public static int selectedWorld;

	[Cpp2IlInjected.Token(Token = "0x4002433")]
	public static string newWorldName;

	[Cpp2IlInjected.Token(Token = "0x4002434")]
	private static int[] specX;

	[Cpp2IlInjected.Token(Token = "0x4002435")]
	private static int[] specY;

	[Cpp2IlInjected.Token(Token = "0x4002436")]
	private static List<string> _requiredObjecsForCraftingText;

	[Cpp2IlInjected.Token(Token = "0x4002437")]
	private static bool hidePVPIcons;

	[Cpp2IlInjected.Token(Token = "0x4002438")]
	public static string hoverItemName;

	[Cpp2IlInjected.Token(Token = "0x4002439")]
	public static Color inventoryBack;

	[Cpp2IlInjected.Token(Token = "0x400243A")]
	public static bool mouseText;

	[Cpp2IlInjected.Token(Token = "0x400243B")]
	public static int mH;

	[Cpp2IlInjected.Token(Token = "0x400243C")]
	private static int lastMouseDrawItem;

	[Cpp2IlInjected.Token(Token = "0x400243D")]
	private static int lastMouseDrawXOffset;

	[Cpp2IlInjected.Token(Token = "0x400243E")]
	public static int focusColor;

	[Cpp2IlInjected.Token(Token = "0x400243F")]
	public static int colorDelay;

	[Cpp2IlInjected.Token(Token = "0x4002440")]
	public static int setKey;

	[Cpp2IlInjected.Token(Token = "0x4002441")]
	public static bool autoPass;

	[Cpp2IlInjected.Token(Token = "0x4002442")]
	public static int menuFocus;

	[Cpp2IlInjected.Token(Token = "0x4002443")]
	public static bool blockMouse;

	[Cpp2IlInjected.Token(Token = "0x4002444")]
	public static float MenuXMovement;

	[Cpp2IlInjected.Token(Token = "0x4002445")]
	public static float MapScale;

	[Cpp2IlInjected.Token(Token = "0x4002446")]
	public static bool cancelWormHole;

	[Cpp2IlInjected.Token(Token = "0x4002447")]
	public static float lightning;

	[Cpp2IlInjected.Token(Token = "0x4002448")]
	private static float lightningDecay;

	[Cpp2IlInjected.Token(Token = "0x4002449")]
	private static float lightningSpeed;

	[Cpp2IlInjected.Token(Token = "0x400244A")]
	private static int thunderDelay;

	[Cpp2IlInjected.Token(Token = "0x400244B")]
	public static int thunderDistance;

	[Cpp2IlInjected.Token(Token = "0x400244C")]
	private static float backgroundLayerTransitionSpeed;

	[Cpp2IlInjected.Token(Token = "0x400244D")]
	public static float atmo;

	[Cpp2IlInjected.Token(Token = "0x400244E")]
	private static float bgScale;

	[Cpp2IlInjected.Token(Token = "0x400244F")]
	private static int bgWidthScaled;

	[Cpp2IlInjected.Token(Token = "0x4002450")]
	public static Color ColorOfTheSkies;

	[Cpp2IlInjected.Token(Token = "0x4002451")]
	private static Color ColorOfSurfaceBackgroundsBase;

	[Cpp2IlInjected.Token(Token = "0x4002452")]
	private static Color ColorOfSurfaceBackgroundsModified;

	[Cpp2IlInjected.Token(Token = "0x4002453")]
	private static string _oldNetplayStatusText;

	[Cpp2IlInjected.Token(Token = "0x4002454")]
	private static TextSnippet[] _netplayStatusTextSnippets;

	[Cpp2IlInjected.Token(Token = "0x4002455")]
	private static bool _canShowMeteorFall;

	[Cpp2IlInjected.Token(Token = "0x4002456")]
	private const string versionStringBecauseTheyreTheSame = "v1.4.4.9";

	[Cpp2IlInjected.Token(Token = "0x4002457")]
	public const int curRelease = 279;

	[Cpp2IlInjected.Token(Token = "0x4002458")]
	public static StringBuilder UIStringBuilder;

	[Cpp2IlInjected.Token(Token = "0x4002459")]
	public const string assemblyVersionNumber = "1.4.4.9";

	[Cpp2IlInjected.Token(Token = "0x400245A")]
	public const string copyrightText = "Copyright © 2022 Re-Logi";

	[Cpp2IlInjected.Token(Token = "0x400245B")]
	public const ulong WorldGeneratorVersion = 1198295875585uL;

	[Cpp2IlInjected.Token(Token = "0x400245C")]
	public static Dictionary<string, MinimapFrame> MinimapFrames;

	[Cpp2IlInjected.Token(Token = "0x400245D")]
	public static Dictionary<string, IPlayerResourcesDisplaySet> PlayerResourcesSets;

	[Cpp2IlInjected.Token(Token = "0x400245E")]
	public const string TerrariaSaveFolderPath = "Terraria";

	[Cpp2IlInjected.Token(Token = "0x400245F")]
	public static IAssetRepository Assets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4002460")]
	private bool _musicLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
	[Cpp2IlInjected.Token(Token = "0x4002461")]
	private bool _artLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
	[Cpp2IlInjected.Token(Token = "0x4002462")]
	private bool _begunMainAsyncLoad;

	[Cpp2IlInjected.Token(Token = "0x4002464")]
	private static bool GameAskedToQuit;

	[Cpp2IlInjected.Token(Token = "0x4002465")]
	public static float ForcedMinimumZoom;

	[Cpp2IlInjected.Token(Token = "0x4002466")]
	public static SpriteViewMatrix GameViewMatrix;

	[Cpp2IlInjected.Token(Token = "0x4002467")]
	public static SpriteViewMatrix BackgroundViewMatrix;

	[Cpp2IlInjected.Token(Token = "0x4002468")]
	private static Matrix _currentWantedZoomMatrix;

	[Cpp2IlInjected.Token(Token = "0x4002469")]
	private static Matrix _uiScaleMatrix;

	[Cpp2IlInjected.Token(Token = "0x400246A")]
	private static float _uiScaleWanted;

	[Cpp2IlInjected.Token(Token = "0x400246B")]
	private static float _uiScaleUsed;

	[Cpp2IlInjected.Token(Token = "0x400246C")]
	public static float GameZoomTarget;

	[Cpp2IlInjected.Token(Token = "0x400246D")]
	public static bool InvisibleCursorForGamepad;

	[Cpp2IlInjected.Token(Token = "0x400246E")]
	public static bool GamepadDisableCursorItemIconInner;

	[Cpp2IlInjected.Token(Token = "0x400246F")]
	public static bool GamepadDisableInstructionsDisplay;

	[Cpp2IlInjected.Token(Token = "0x4002470")]
	private static GameNotificationType _flashNotificationType;

	[Cpp2IlInjected.Token(Token = "0x4002471")]
	public static string versionNumber;

	[Cpp2IlInjected.Token(Token = "0x4002472")]
	public static string versionNumber2;

	[Cpp2IlInjected.Token(Token = "0x4002473")]
	public static string AutogenSeedName;

	[Cpp2IlInjected.Token(Token = "0x4002474")]
	public static Dictionary<int, GameModeData> RegisteredGameModes;

	[Cpp2IlInjected.Token(Token = "0x4002475")]
	public static bool tenthAnniversaryWorld;

	[Cpp2IlInjected.Token(Token = "0x4002476")]
	public static bool dontStarveWorld;

	[Cpp2IlInjected.Token(Token = "0x4002477")]
	public static bool notTheBeesWorld;

	[Cpp2IlInjected.Token(Token = "0x4002478")]
	public static bool remixWorld;

	[Cpp2IlInjected.Token(Token = "0x4002479")]
	public static bool noTrapsWorld;

	[Cpp2IlInjected.Token(Token = "0x400247A")]
	public static bool zenithWorld;

	[Cpp2IlInjected.Token(Token = "0x400247B")]
	public static FavoritesFile CloudFavoritesData;

	[Cpp2IlInjected.Token(Token = "0x400247C")]
	public static UserInterface MenuUI;

	[Cpp2IlInjected.Token(Token = "0x400247D")]
	public static UserInterface InGameUI;

	[Cpp2IlInjected.Token(Token = "0x400247E")]
	public static bool ContentLoaded;

	[Cpp2IlInjected.Token(Token = "0x4002480")]
	public static ContentManager ShaderContentManager;

	[Cpp2IlInjected.Token(Token = "0x4002481")]
	public static Ref<Effect> ScreenShaderRef;

	[Cpp2IlInjected.Token(Token = "0x4002482")]
	public static Ref<Effect> PixelShaderRef;

	[Cpp2IlInjected.Token(Token = "0x4002483")]
	public static Ref<Effect> TileShaderRef;

	[Cpp2IlInjected.Token(Token = "0x4002484")]
	public static Ref<Effect> VertexPixelShaderRef;

	[Cpp2IlInjected.Token(Token = "0x4002485")]
	public static List<IEnumerator> DelayedProcesses;

	[Cpp2IlInjected.Token(Token = "0x4002486")]
	public static bool dedServFPS;

	[Cpp2IlInjected.Token(Token = "0x4002487")]
	public static int dedServCount1;

	[Cpp2IlInjected.Token(Token = "0x4002488")]
	public static int dedServCount2;

	[Cpp2IlInjected.Token(Token = "0x4002489")]
	public static readonly int offLimitBorderTiles;

	[Cpp2IlInjected.Token(Token = "0x400248A")]
	public const int maxMusic = 92;

	[Cpp2IlInjected.Token(Token = "0x400248B")]
	public const int MaxBannerTypes = 290;

	[Cpp2IlInjected.Token(Token = "0x400248C")]
	public static readonly int maxBackgrounds;

	[Cpp2IlInjected.Token(Token = "0x400248D")]
	public const int MaxShopIDs = 100;

	[Cpp2IlInjected.Token(Token = "0x400248E")]
	public static Vector2[] OffsetsNPCOffhand;

	[Cpp2IlInjected.Token(Token = "0x400248F")]
	public static Vector2[] OffsetsPlayerOffhand;

	[Cpp2IlInjected.Token(Token = "0x4002490")]
	public static Vector2[] OffsetsPlayerOnhand;

	[Cpp2IlInjected.Token(Token = "0x4002491")]
	public static Vector2[] OffsetsPlayerHeadgear;

	[Cpp2IlInjected.Token(Token = "0x4002492")]
	public static bool noWindowBorder;

	[Cpp2IlInjected.Token(Token = "0x4002493")]
	public static RasterizerState Rasterizer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4002494")]
	private string _cachedTitle;

	[Cpp2IlInjected.Token(Token = "0x4002495")]
	public static bool skipMenu;

	[Cpp2IlInjected.Token(Token = "0x4002496")]
	public static bool verboseNetplay;

	[Cpp2IlInjected.Token(Token = "0x4002497")]
	public static bool stopTimeOuts;

	[Cpp2IlInjected.Token(Token = "0x4002498")]
	public static bool showSpam;

	[Cpp2IlInjected.Token(Token = "0x4002499")]
	public static bool showItemOwner;

	[Cpp2IlInjected.Token(Token = "0x400249A")]
	public static bool runningCollectorsEdition;

	[Cpp2IlInjected.Token(Token = "0x400249B")]
	public static bool shouldDrawNetDiagnosticsUI;

	[Cpp2IlInjected.Token(Token = "0x400249C")]
	private static INetDiagnosticsUI _activeNetDiagnosticsUI;

	[Cpp2IlInjected.Token(Token = "0x400249D")]
	public static IMultiplayerClosePlayersOverlay ActiveClosePlayersTeamOverlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400249E")]
	public bool gammaTest;

	[Cpp2IlInjected.Token(Token = "0x400249F")]
	private const bool USE_ASYNC_LOAD = true;

	[Cpp2IlInjected.Token(Token = "0x40024A0")]
	public static bool _isAsyncLoadComplete;

	[Cpp2IlInjected.Token(Token = "0x40024A1")]
	public static bool showSplash;

	[Cpp2IlInjected.Token(Token = "0x40024A2")]
	public static bool ignoreErrors;

	[Cpp2IlInjected.Token(Token = "0x40024A3")]
	public static string defaultIP;

	[Cpp2IlInjected.Token(Token = "0x40024A4")]
	public static int defaultPort;

	[Cpp2IlInjected.Token(Token = "0x40024A5")]
	public static bool[] projHostile;

	[Cpp2IlInjected.Token(Token = "0x40024A6")]
	public static bool[] projHook;

	[Cpp2IlInjected.Token(Token = "0x40024A7")]
	public static bool[] pvpBuff;

	[Cpp2IlInjected.Token(Token = "0x40024A8")]
	public static bool[] persistentBuff;

	[Cpp2IlInjected.Token(Token = "0x40024A9")]
	public static bool[] vanityPet;

	[Cpp2IlInjected.Token(Token = "0x40024AA")]
	public static bool[] lightPet;

	[Cpp2IlInjected.Token(Token = "0x40024AB")]
	public static bool[] meleeBuff;

	[Cpp2IlInjected.Token(Token = "0x40024AC")]
	public static bool[] debuff;

	[Cpp2IlInjected.Token(Token = "0x40024AD")]
	public static bool[] buffNoSave;

	[Cpp2IlInjected.Token(Token = "0x40024AE")]
	public static bool[] buffNoTimeDisplay;

	[Cpp2IlInjected.Token(Token = "0x40024AF")]
	public static bool[] buffDoubleApply;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40024B0")]
	private RenderTarget2D backWaterTarget;

	[Cpp2IlInjected.Token(Token = "0x40024B1")]
	public static RenderTarget2D waterTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40024B2")]
	private RenderTarget2D tileTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40024B3")]
	private RenderTarget2D blackTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40024B4")]
	private RenderTarget2D tile2Target;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40024B5")]
	private RenderTarget2D wallTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40024B6")]
	private RenderTarget2D backgroundTarget;

	[Cpp2IlInjected.Token(Token = "0x40024B7")]
	public static RenderTarget2D screenTarget;

	[Cpp2IlInjected.Token(Token = "0x40024B8")]
	public static RenderTarget2D screenTargetSwap;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40024B9")]
	private RenderTarget2D[,] mapTarget;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40024BA")]
	private RenderTarget2D mapSectionTexture;

	[Cpp2IlInjected.Token(Token = "0x40024BB")]
	public static bool[,] mapWasContentLost;

	[Cpp2IlInjected.Token(Token = "0x40024BC")]
	public const int numInfoIcons = 13;

	[Cpp2IlInjected.Token(Token = "0x40024BD")]
	public static Color OurFavoriteColor;

	[Cpp2IlInjected.Token(Token = "0x40024BF")]
	private static bool IsEnginePreloaded;

	[Cpp2IlInjected.Token(Token = "0x40024C2")]
	private static bool IsEngineLoaded;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40024CA")]
	private double bgParallax;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40024CB")]
	private int bgStartX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x40024CC")]
	private int bgLoops;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40024CD")]
	private int bgStartY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40024CE")]
	private int bgLoopsY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40024CF")]
	private int bgTopY;

	[Cpp2IlInjected.Token(Token = "0x40024D0")]
	private const int MF_BYPOSITION = 1024;

	[Cpp2IlInjected.Token(Token = "0x40024D1")]
	public static GraphicsDeviceManager graphics;

	[Cpp2IlInjected.Token(Token = "0x40024D2")]
	public static SpriteBatch spriteBatch;

	[Cpp2IlInjected.Token(Token = "0x40024D3")]
	public static SpriteBatch spriteBatch2;

	[Cpp2IlInjected.Token(Token = "0x40024D4")]
	public static TileBatch tileBatch;

	[Cpp2IlInjected.Token(Token = "0x40024D5")]
	public static BasicDebugDrawer DebugDrawer;

	[Cpp2IlInjected.Token(Token = "0x40024D6")]
	public static SamplerState SamplerStateForCursor;

	[Cpp2IlInjected.Token(Token = "0x40024D7")]
	public static GenerationProgress AutogenProgress;

	[Cpp2IlInjected.Token(Token = "0x40024D8")]
	private static Process tServer;

	[Cpp2IlInjected.Token(Token = "0x40024D9")]
	public static Color mcColor;

	[Cpp2IlInjected.Token(Token = "0x40024DA")]
	public static Color hcColor;

	[Cpp2IlInjected.Token(Token = "0x40024DB")]
	public static Color creativeModeColor;

	[Cpp2IlInjected.Token(Token = "0x40024DC")]
	public static Color legendaryModeColor;

	[Cpp2IlInjected.Token(Token = "0x40024DD")]
	public static Color highVersionColor;

	[Cpp2IlInjected.Token(Token = "0x40024DE")]
	public static Color errorColor;

	[Cpp2IlInjected.Token(Token = "0x40024DF")]
	public static bool afterPartyOfDoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40024E0")]
	public float chestLootScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40024E1")]
	public bool chestLootHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40024E2")]
	public float chestStackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40024E3")]
	public bool chestStackHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40024E4")]
	public float chestDepositScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40024E5")]
	public bool chestDepositHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40024E6")]
	public float chestRenameScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40024E7")]
	public bool chestRenameHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40024E8")]
	public float chestCancelScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40024E9")]
	public bool chestCancelHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40024EA")]
	public int DiscoStyle;

	[Cpp2IlInjected.Token(Token = "0x40024EB")]
	public const int sectionWidth = 200;

	[Cpp2IlInjected.Token(Token = "0x40024EC")]
	public const int sectionHeight = 150;

	[Cpp2IlInjected.Token(Token = "0x40024ED")]
	public const int maxDust = 6000;

	[Cpp2IlInjected.Token(Token = "0x40024EE")]
	public const int maxCombatText = 100;

	[Cpp2IlInjected.Token(Token = "0x40024EF")]
	public const int maxItemText = 20;

	[Cpp2IlInjected.Token(Token = "0x40024F0")]
	public const int maxPlayers = 255;

	[Cpp2IlInjected.Token(Token = "0x40024F1")]
	public const int maxChests = 8000;

	[Cpp2IlInjected.Token(Token = "0x40024F2")]
	public const int maxItems = 400;

	[Cpp2IlInjected.Token(Token = "0x40024F3")]
	public const int maxProjectiles = 1000;

	[Cpp2IlInjected.Token(Token = "0x40024F4")]
	public const int maxNPCs = 200;

	[Cpp2IlInjected.Token(Token = "0x40024F5")]
	private const double slimeRainMaxTime = 54000.0;

	[Cpp2IlInjected.Token(Token = "0x40024F6")]
	private const double slimeRainMinTime = 32400.0;

	[Cpp2IlInjected.Token(Token = "0x40024F7")]
	private const double slimeRainMaxDelay = 604800.0;

	[Cpp2IlInjected.Token(Token = "0x40024F8")]
	private const double slimeRainMinDelay = 302400.0;

	[Cpp2IlInjected.Token(Token = "0x40024F9")]
	private const double LeinforsBalanceRequestForSlimeRainChance = 1.0416666666666667;

	[Cpp2IlInjected.Token(Token = "0x40024FA")]
	private const double slimeRainChance = 450000.00000000006;

	[Cpp2IlInjected.Token(Token = "0x40024FB")]
	public const int maxGore = 600;

	[Cpp2IlInjected.Token(Token = "0x40024FC")]
	public const int InventoryItemSlotsStart = 0;

	[Cpp2IlInjected.Token(Token = "0x40024FD")]
	public const int InventoryItemSlotsCount = 50;

	[Cpp2IlInjected.Token(Token = "0x40024FE")]
	public const int InventoryCoinSlotsStart = 50;

	[Cpp2IlInjected.Token(Token = "0x40024FF")]
	public const int InventoryCoinSlotsCount = 4;

	[Cpp2IlInjected.Token(Token = "0x4002500")]
	public const int InventoryAmmoSlotsStart = 54;

	[Cpp2IlInjected.Token(Token = "0x4002501")]
	public const int InventoryAmmoSlotsCount = 4;

	[Cpp2IlInjected.Token(Token = "0x4002502")]
	public const int InventorySlotsTotal = 58;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4002503")]
	public int invBottom;

	[Cpp2IlInjected.Token(Token = "0x4002504")]
	public const int maxLiquidTypes = 15;

	[Cpp2IlInjected.Token(Token = "0x4002505")]
	public static bool useBackupFiles;

	[Cpp2IlInjected.Token(Token = "0x4002506")]
	public static bool validateSaves;

	[Cpp2IlInjected.Token(Token = "0x4002507")]
	public static Color[] teamColor;

	[Cpp2IlInjected.Token(Token = "0x4002508")]
	public const double dayLength = 54000.0;

	[Cpp2IlInjected.Token(Token = "0x4002509")]
	public const double nightLength = 32400.0;

	[Cpp2IlInjected.Token(Token = "0x400250A")]
	public static bool autoGen;

	[Cpp2IlInjected.Token(Token = "0x400250B")]
	public static int[] projFrames;

	[Cpp2IlInjected.Token(Token = "0x400250C")]
	public static bool[] projPet;

	[Cpp2IlInjected.Token(Token = "0x400250D")]
	public const int maxStars = 400;

	[Cpp2IlInjected.Token(Token = "0x400250E")]
	public const int maxStarTypes = 4;

	[Cpp2IlInjected.Token(Token = "0x400250F")]
	public const int maxClouds = 200;

	[Cpp2IlInjected.Token(Token = "0x4002510")]
	[ThreadStatic]
	public static UnifiedRandom rand;

	[Cpp2IlInjected.Token(Token = "0x4002511")]
	public const int maxMoons = 9;

	[Cpp2IlInjected.Token(Token = "0x4002512")]
	public const int numTileColors = 32;

	[Cpp2IlInjected.Token(Token = "0x4002513")]
	public const int numTreeStyles = 32;

	[Cpp2IlInjected.Token(Token = "0x4002514")]
	public const int numberOfHairstyles = 165;

	[Cpp2IlInjected.Token(Token = "0x4002515")]
	public const int maxHairStyles = 165;

	[Cpp2IlInjected.Token(Token = "0x4002516")]
	public const int maxCharSelectHair = 51;

	[Cpp2IlInjected.Token(Token = "0x4002517")]
	public const int maxHairOfStylistDefault = 123;

	[Cpp2IlInjected.Token(Token = "0x4002518")]
	public static IAudioSystem audioSystem;

	[Cpp2IlInjected.Token(Token = "0x4002519")]
	public static bool[] musicNoCrossFade;

	[Cpp2IlInjected.Token(Token = "0x400251A")]
	public static ServerMode MenuServerMode;

	[Cpp2IlInjected.Token(Token = "0x400251B")]
	public static bool[] tileLighted;

	[Cpp2IlInjected.Token(Token = "0x400251C")]
	public static bool[] tileMergeDirt;

	[Cpp2IlInjected.Token(Token = "0x400251D")]
	public static bool[] tileCut;

	[Cpp2IlInjected.Token(Token = "0x400251E")]
	public static bool[] tileAlch;

	[Cpp2IlInjected.Token(Token = "0x400251F")]
	public static int[] tileShine;

	[Cpp2IlInjected.Token(Token = "0x4002520")]
	public static bool[] tileShine2;

	[Cpp2IlInjected.Token(Token = "0x4002521")]
	public static bool[] wallHouse;

	[Cpp2IlInjected.Token(Token = "0x4002522")]
	public static bool[] wallDungeon;

	[Cpp2IlInjected.Token(Token = "0x4002523")]
	public static bool[] wallLight;

	[Cpp2IlInjected.Token(Token = "0x4002524")]
	public static bool[] wallLighted;

	[Cpp2IlInjected.Token(Token = "0x4002525")]
	public static int[] wallBlend;

	[Cpp2IlInjected.Token(Token = "0x4002526")]
	public static bool[] tileStone;

	[Cpp2IlInjected.Token(Token = "0x4002527")]
	public static bool[] tileAxe;

	[Cpp2IlInjected.Token(Token = "0x4002528")]
	public static bool[] tileHammer;

	[Cpp2IlInjected.Token(Token = "0x4002529")]
	public static bool[] tileWaterDeath;

	[Cpp2IlInjected.Token(Token = "0x400252A")]
	public static bool[] tileLavaDeath;

	[Cpp2IlInjected.Token(Token = "0x400252B")]
	public static bool[] tileTable;

	[Cpp2IlInjected.Token(Token = "0x400252C")]
	public static bool[] tileBlockLight;

	[Cpp2IlInjected.Token(Token = "0x400252D")]
	public static bool[] tileNoSunLight;

	[Cpp2IlInjected.Token(Token = "0x400252E")]
	public static bool[] tileDungeon;

	[Cpp2IlInjected.Token(Token = "0x400252F")]
	public static bool[] tileSpelunker;

	[Cpp2IlInjected.Token(Token = "0x4002530")]
	public static bool[] tileSolidTop;

	[Cpp2IlInjected.Token(Token = "0x4002531")]
	public static bool[] tileSolid;

	[Cpp2IlInjected.Token(Token = "0x4002532")]
	public static bool[] tileBouncy;

	[Cpp2IlInjected.Token(Token = "0x4002533")]
	public static short[] tileOreFinderPriority;

	[Cpp2IlInjected.Token(Token = "0x4002534")]
	public static byte[] tileLargeFrames;

	[Cpp2IlInjected.Token(Token = "0x4002535")]
	public static byte[] wallLargeFrames;

	[Cpp2IlInjected.Token(Token = "0x4002536")]
	public static bool[] tileRope;

	[Cpp2IlInjected.Token(Token = "0x4002537")]
	public static bool[] tileBrick;

	[Cpp2IlInjected.Token(Token = "0x4002538")]
	public static bool[] tileMoss;

	[Cpp2IlInjected.Token(Token = "0x4002539")]
	public static bool[] tileNoAttach;

	[Cpp2IlInjected.Token(Token = "0x400253A")]
	public static bool[] tileNoFail;

	[Cpp2IlInjected.Token(Token = "0x400253B")]
	public static bool[] tileCracked;

	[Cpp2IlInjected.Token(Token = "0x400253C")]
	public static bool[] tileObsidianKill;

	[Cpp2IlInjected.Token(Token = "0x400253D")]
	public static bool[] tileFrameImportant;

	[Cpp2IlInjected.Token(Token = "0x400253E")]
	public static bool[] tilePile;

	[Cpp2IlInjected.Token(Token = "0x400253F")]
	public static bool[] tileBlendAll;

	[Cpp2IlInjected.Token(Token = "0x4002540")]
	public static short[] tileGlowMask;

	[Cpp2IlInjected.Token(Token = "0x4002541")]
	public static bool[] tileContainer;

	[Cpp2IlInjected.Token(Token = "0x4002542")]
	public static bool[] tileSign;

	[Cpp2IlInjected.Token(Token = "0x4002543")]
	public static bool[][] tileMerge;

	[Cpp2IlInjected.Token(Token = "0x4002544")]
	public static int cageFrames;

	[Cpp2IlInjected.Token(Token = "0x4002545")]
	public static bool critterCage;

	[Cpp2IlInjected.Token(Token = "0x4002546")]
	public static int[] bunnyCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002547")]
	public static int[] bunnyCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002548")]
	public static int[] squirrelCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002549")]
	public static int[] squirrelCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400254A")]
	public static int[] squirrelCageFrameOrange;

	[Cpp2IlInjected.Token(Token = "0x400254B")]
	public static int[] squirrelCageFrameCounterOrange;

	[Cpp2IlInjected.Token(Token = "0x400254C")]
	public static int[] mallardCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400254D")]
	public static int[] mallardCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400254E")]
	public static int[] duckCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400254F")]
	public static int[] duckCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002550")]
	public static int[] grebeCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002551")]
	public static int[] grebeCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002552")]
	public static int[] seagullCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002553")]
	public static int[] seagullCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002554")]
	public static int[] birdCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002555")]
	public static int[] birdCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002556")]
	public static int[] redBirdCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002557")]
	public static int[] redBirdCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002558")]
	public static int[] blueBirdCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002559")]
	public static int[] blueBirdCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400255A")]
	public static int[] macawCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400255B")]
	public static int[] macawCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400255C")]
	public static byte[,] butterflyCageMode;

	[Cpp2IlInjected.Token(Token = "0x400255D")]
	public static int[,] butterflyCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400255E")]
	public static int[,] butterflyCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400255F")]
	public static int[,] dragonflyJarFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002560")]
	public static int[,] dragonflyJarFrame;

	[Cpp2IlInjected.Token(Token = "0x4002561")]
	public static int[,] scorpionCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002562")]
	public static int[,] scorpionCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002563")]
	public static int[] snailCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002564")]
	public static int[] snailCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002565")]
	public static int[] snail2CageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002566")]
	public static int[] snail2CageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002567")]
	public static byte[] fishBowlFrameMode;

	[Cpp2IlInjected.Token(Token = "0x4002568")]
	public static int[] fishBowlFrame;

	[Cpp2IlInjected.Token(Token = "0x4002569")]
	public static int[] fishBowlFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400256A")]
	public static int[] lavaFishBowlFrame;

	[Cpp2IlInjected.Token(Token = "0x400256B")]
	public static int[] lavaFishBowlFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400256C")]
	public static int[] frogCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400256D")]
	public static int[] frogCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400256E")]
	public static int[] mouseCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400256F")]
	public static int[] mouseCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002570")]
	public static int[] turtleCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002571")]
	public static int[] turtleCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002572")]
	public static int[] fairyJarFrame;

	[Cpp2IlInjected.Token(Token = "0x4002573")]
	public static int[] fairyJarFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002574")]
	public static byte[,] jellyfishCageMode;

	[Cpp2IlInjected.Token(Token = "0x4002575")]
	public static int[,] jellyfishCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002576")]
	public static int[,] jellyfishCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002577")]
	public static int[] wormCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002578")]
	public static int[] wormCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002579")]
	public static int[] maggotCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400257A")]
	public static int[] maggotCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400257B")]
	public static int[] ratCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400257C")]
	public static int[] ratCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400257D")]
	public static int[] ladybugCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400257E")]
	public static int[] ladybugCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400257F")]
	public static int[] penguinCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002580")]
	public static int[] penguinCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002581")]
	public static int[] waterStriderCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002582")]
	public static int[] waterStriderCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002583")]
	public static int[] seahorseCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002584")]
	public static int[] seahorseCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002585")]
	public static int[,] slugCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002586")]
	public static int[,] slugCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002587")]
	public static int[] owlCageFrame;

	[Cpp2IlInjected.Token(Token = "0x4002588")]
	public static int[] owlCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002589")]
	public static int[] grasshopperCageFrame;

	[Cpp2IlInjected.Token(Token = "0x400258A")]
	public static int[] grasshopperCageFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x400258B")]
	public static bool[] tileSand;

	[Cpp2IlInjected.Token(Token = "0x400258C")]
	public static bool[] tileFlame;

	[Cpp2IlInjected.Token(Token = "0x400258D")]
	public static bool[] npcCatchable;

	[Cpp2IlInjected.Token(Token = "0x400258E")]
	public static int[] tileFrame;

	[Cpp2IlInjected.Token(Token = "0x400258F")]
	public static int[] tileFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002590")]
	public static byte[] wallFrame;

	[Cpp2IlInjected.Token(Token = "0x4002591")]
	public static byte[] wallFrameCounter;

	[Cpp2IlInjected.Token(Token = "0x4002592")]
	public static int[] backgroundWidth;

	[Cpp2IlInjected.Token(Token = "0x4002593")]
	public static int[] backgroundHeight;

	[Cpp2IlInjected.Token(Token = "0x4002594")]
	public static DrawAnimation[] itemAnimations;

	[Cpp2IlInjected.Token(Token = "0x4002595")]
	private static DrawAnimation _coinOnWorldAnimation;

	[Cpp2IlInjected.Token(Token = "0x4002596")]
	private static DrawAnimation _monkStaffT3OnWorldAnimation;

	[Cpp2IlInjected.Token(Token = "0x4002597")]
	public static List<int> itemAnimationsRegistered;

	[Cpp2IlInjected.Token(Token = "0x4002598")]
	public static int[] anglerQuestItemNetIDs;

	[Cpp2IlInjected.Token(Token = "0x4002599")]
	private static int _renderTargetMaxSize;

	[Cpp2IlInjected.Token(Token = "0x400259A")]
	private static GraphicsProfile _selectedGraphicsProfile;

	[Cpp2IlInjected.Token(Token = "0x400259B")]
	private static GraphicsProfile _currentGraphicsProfile;

	[Cpp2IlInjected.Token(Token = "0x400259C")]
	public static int[] displayWidth;

	[Cpp2IlInjected.Token(Token = "0x400259D")]
	public static int[] displayHeight;

	[Cpp2IlInjected.Token(Token = "0x400259E")]
	private static int maxLoadPlayer;

	[Cpp2IlInjected.Token(Token = "0x400259F")]
	private static int maxLoadWorld;

	[Cpp2IlInjected.Token(Token = "0x40025A0")]
	public static int[] npcFrameCount;

	[Cpp2IlInjected.Token(Token = "0x40025A1")]
	public const int MaxTimeout = 120;

	[Cpp2IlInjected.Token(Token = "0x40025A2")]
	public static string cUp;

	[Cpp2IlInjected.Token(Token = "0x40025A3")]
	public static string cLeft;

	[Cpp2IlInjected.Token(Token = "0x40025A4")]
	public static string cDown;

	[Cpp2IlInjected.Token(Token = "0x40025A5")]
	public static string cRight;

	[Cpp2IlInjected.Token(Token = "0x40025A6")]
	public static string cJump;

	[Cpp2IlInjected.Token(Token = "0x40025A7")]
	public static string cThrowItem;

	[Cpp2IlInjected.Token(Token = "0x40025A8")]
	public static string cHeal;

	[Cpp2IlInjected.Token(Token = "0x40025A9")]
	public static string cMana;

	[Cpp2IlInjected.Token(Token = "0x40025AA")]
	public static string cBuff;

	[Cpp2IlInjected.Token(Token = "0x40025AB")]
	public static string cHook;

	[Cpp2IlInjected.Token(Token = "0x40025AC")]
	public static string cTorch;

	[Cpp2IlInjected.Token(Token = "0x40025AD")]
	public static string cInv;

	[Cpp2IlInjected.Token(Token = "0x40025AE")]
	public static string cSmart;

	[Cpp2IlInjected.Token(Token = "0x40025AF")]
	public static string cMount;

	[Cpp2IlInjected.Token(Token = "0x40025B0")]
	public static string cFavoriteKey;

	[Cpp2IlInjected.Token(Token = "0x40025B1")]
	public static string cMapZoomIn;

	[Cpp2IlInjected.Token(Token = "0x40025B2")]
	public static string cMapZoomOut;

	[Cpp2IlInjected.Token(Token = "0x40025B3")]
	public static string cMapAlphaUp;

	[Cpp2IlInjected.Token(Token = "0x40025B4")]
	public static string cMapAlphaDown;

	[Cpp2IlInjected.Token(Token = "0x40025B5")]
	public static string cMapFull;

	[Cpp2IlInjected.Token(Token = "0x40025B6")]
	public static string cMapStyle;

	[Cpp2IlInjected.Token(Token = "0x40025B7")]
	public static Keys FavoriteKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40025B8")]
	public List<int> DrawCacheNPCsMoonMoon;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40025B9")]
	public List<int> DrawCacheNPCsOverPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40025BA")]
	public List<int> DrawCacheNPCProjectiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40025BB")]
	public List<int> DrawCacheNPCsBehindNonSolidTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40025BC")]
	public List<int> DrawCacheProjsBehindNPCsAndTiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40025BD")]
	public List<int> DrawCacheProjsBehindNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40025BE")]
	public List<int> DrawCacheProjsBehindProjectiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40025BF")]
	public List<int> DrawCacheProjsOverWiresUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40025C0")]
	public List<int> DrawCacheProjsOverPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40025C1")]
	public List<int> DrawCacheFirstFractals;

	[Cpp2IlInjected.Token(Token = "0x40025C2")]
	private static bool TrialMode;

	[Cpp2IlInjected.Token(Token = "0x40025C3")]
	public static string autoGenFileLocation;

	[Cpp2IlInjected.Token(Token = "0x40025C4")]
	public static bool fastForwardTimeToDusk;

	[Cpp2IlInjected.Token(Token = "0x40025C5")]
	public static int moondialCooldown;

	[Cpp2IlInjected.Token(Token = "0x40025C6")]
	private static Stopwatch splashTimer;

	[Cpp2IlInjected.Token(Token = "0x40025C7")]
	public static GeneralIssueReporter IssueReporter;

	[Cpp2IlInjected.Token(Token = "0x40025C8")]
	private static int AnimateCritterPages;

	[Cpp2IlInjected.Token(Token = "0x40025C9")]
	public static bool PreventUpdatingTargets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40025CA")]
	private DateTime lastYield;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40025CB")]
	private IEnumerator _gameContentLoadProcess;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40025CC")]
	private int _musicReplayDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40025CD")]
	private int lastMusicPlayed;

	[Cpp2IlInjected.Token(Token = "0x40025CE")]
	private static float _minWind;

	[Cpp2IlInjected.Token(Token = "0x40025CF")]
	private static float _maxWind;

	[Cpp2IlInjected.Token(Token = "0x40025D0")]
	private static float _minRain;

	[Cpp2IlInjected.Token(Token = "0x40025D1")]
	private static float _maxRain;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40025D2")]
	private Stopwatch _worldUpdateTimeTester;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40025D3")]
	private int _perfLastFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40025D4")]
	public SpelunkerProjectileHelper SpelunkerProjectileHelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40025D5")]
	public ChumBucketProjectileHelper ChumBucketProjectileHelper;

	[Cpp2IlInjected.Token(Token = "0x40025D6")]
	private static int AutoSavePlayerTime;

	[Cpp2IlInjected.Token(Token = "0x40025D7")]
	public static int AutoSaveWorldTime;

	[Cpp2IlInjected.Token(Token = "0x40025D8")]
	private static List<char> removeChars;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40025D9")]
	public float logoRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40025DA")]
	public float logoRotationDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40025DB")]
	public float logoRotationSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40025DC")]
	public float logoScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40025DD")]
	public float logoScaleDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40025DE")]
	public float logoScaleSpeed;

	[Cpp2IlInjected.Token(Token = "0x40025DF")]
	private static int maxMenuItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x40025E0")]
	private float[] menuItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40025E1")]
	private int focusMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40025E2")]
	private int selectedMenu;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40025E3")]
	private int selectedMenu2;

	[Cpp2IlInjected.Token(Token = "0x40025E4")]
	public static int menuSkip;

	[Cpp2IlInjected.Token(Token = "0x40025E5")]
	private static bool _needsLanguageSelect;

	[Cpp2IlInjected.Token(Token = "0x40025E6")]
	private static Item tooltipPrefixComparisonItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40025E7")]
	public int textBlinkerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40025E8")]
	public int textBlinkerState;

	[Cpp2IlInjected.Token(Token = "0x40025E9")]
	public static long TotalMemory;

	[Cpp2IlInjected.Token(Token = "0x40025EA")]
	public static int TotalMemoryUpdate;

	[Cpp2IlInjected.Token(Token = "0x40025EB")]
	public static int TotalMemotyFullClear;

	[Cpp2IlInjected.Token(Token = "0x40025EC")]
	private static Vector3 shimmerShine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40025ED")]
	public TilePaintSystemV2 TilePaintSystem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40025EE")]
	public TileDrawing TilesRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40025EF")]
	public WallDrawing WallsRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40025F0")]
	private AmbientWindSystem _ambientWindSys;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x40025F1")]
	private List<Player> _playersThatDrawBehindNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40025F2")]
	private List<Player> _playersThatDrawAfterProjectiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40025F3")]
	private List<Player> drawPlayersPotion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40025F4")]
	private List<DrawData> _voidLensData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40025F5")]
	private List<DrawData> _voidLensDataSillouette;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40025F6")]
	private List<DrawData> _voidLensDataSillouette2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40025F7")]
	private FlameLashDrawer flameLashDrawer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40025F8")]
	private MagicMissileDrawer magicMissileDrawer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40025F9")]
	private FinalFractalHelper finalFractalHelper;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x40025FA")]
	private RainbowRodDrawer rainbowRodDrawer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19D")]
	[Cpp2IlInjected.Token(Token = "0x40025FB")]
	private EmpressBladeDrawer empressBladeDrawer;

	[Cpp2IlInjected.Token(Token = "0x40025FC")]
	private static BlendState _multiplyBlendState;

	[Cpp2IlInjected.Token(Token = "0x40025FD")]
	private static StardewValleyAnimation _stardewAnimation;

	[Cpp2IlInjected.Token(Token = "0x40025FE")]
	private static UnifiedRandom _tempSeededRandom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40025FF")]
	private List<int> _occupantsListToDrawNPCHouses;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4002600")]
	private List<int> _npcsWithBannersToDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4002601")]
	private List<int> _npcTypesThatAlreadyDrewAHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4002602")]
	private int[] _npcIndexWhoHoldsHeadIndex;

	[Cpp2IlInjected.Token(Token = "0x4002603")]
	private static bool _preventCraftingBecauseClickWasUsedToChangeFocusedRecipe;

	[Cpp2IlInjected.Token(Token = "0x4002604")]
	private static int _currentRecipeBeingCrafted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4002605")]
	private bool _needToSetupDrawInterfaceLayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4002606")]
	private List<GameInterfaceLayer> _gameInterfaceLayers;

	[Cpp2IlInjected.Token(Token = "0x4002607")]
	private static GameTime _drawInterfaceGameTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4002608")]
	private byte instrumentMouseFixHack;

	[Cpp2IlInjected.Token(Token = "0x4002609")]
	private static bool _settingsButtonIsPushedToSide;

	[Cpp2IlInjected.Token(Token = "0x400260A")]
	private static bool _cannotDrawAccessoriesHorizontally;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400260B")]
	private int grabColorSlider;

	[Cpp2IlInjected.Token(Token = "0x400260C")]
	private static bool _blockFancyUIWhileLoading;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400260D")]
	private bool[] menuWide;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400260E")]
	private bool _needsMenuUIRecalculation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400260F")]
	public RejectionMenuInfo RejectionMenuInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x4002610")]
	private float _splashFrameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x4002611")]
	private bool quickSplash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x4002612")]
	private Color[] backgroundColorSlicesStatic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x4002613")]
	private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x4002614")]
	private ThreadedRenderManager _threadManager;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x4002615")]
	public ThreadLocal<BackgroundDrawInfo> _currentBackgroundDrawInfo;

	[Cpp2IlInjected.Token(Token = "0x4002616")]
	private static int _minimapTopRightAnchorOffsetTowardsLeft;

	[Cpp2IlInjected.Token(Token = "0x4002617")]
	private static int _minimapTopRightAnchorOffsetTowardsBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x4002618")]
	public bool FlushWater;

	[Cpp2IlInjected.Token(Token = "0x4002619")]
	private static VertexColors _glowPaintColors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x400261A")]
	protected List<Tuple<int, int, ushort>> DrawWiresSpecialTiles;

	[Cpp2IlInjected.Token(Token = "0x400261B")]
	private static string[] MonolithFilterNames;

	[Cpp2IlInjected.Token(Token = "0x400261C")]
	private static string[] MonolithSkyNames;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Cpp2IlInjected.Token(Token = "0x400261D")]
	private float screenOff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x400261E")]
	private float scAdj;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x400261F")]
	private float cTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x4002620")]
	private bool _isDrawingOrUpdating;

	[Cpp2IlInjected.Token(Token = "0x4002621")]
	public static List<INeedRenderTargetContent> ContentThatNeedsRenderTargets;

	[Cpp2IlInjected.Token(Token = "0x4002622")]
	private static Item clearItem;

	[Cpp2IlInjected.Token(Token = "0x4002623")]
	private static int _lastFrameFPSCount;

	[Cpp2IlInjected.Token(Token = "0x4002624")]
	private static bool _cameraPanHasBlackTransition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x4002625")]
	public CameraModifierStack CameraModifiers;

	[Cpp2IlInjected.Token(Token = "0x4002626")]
	public static bool starGame;

	[Cpp2IlInjected.Token(Token = "0x4002627")]
	public static int starsHit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x4002628")]
	private float controllerSunGrabPositionX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x4002629")]
	private float controllerSunGrabPositionY;

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public static bool flushLighting
	{
		[Cpp2IlInjected.Token(Token = "0x6001A62")]
		[Cpp2IlInjected.Address(RVA = "0x47B0F8", Offset = "0x47B0F8", VA = "0x47B0F8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A63")]
		[Cpp2IlInjected.Address(RVA = "0x47B174", Offset = "0x47B174", VA = "0x47B174")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public static MinimapFrame ActiveMinimapFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6001A64")]
		[Cpp2IlInjected.Address(RVA = "0x47B1F4", Offset = "0x47B1F4", VA = "0x47B1F4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A65")]
		[Cpp2IlInjected.Address(RVA = "0x47B270", Offset = "0x47B270", VA = "0x47B270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public static IPlayerResourcesDisplaySet ActivePlayerResourcesSet
	{
		[Cpp2IlInjected.Token(Token = "0x6001A66")]
		[Cpp2IlInjected.Address(RVA = "0x47B2F0", Offset = "0x47B2F0", VA = "0x47B2F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A67")]
		[Cpp2IlInjected.Address(RVA = "0x47B36C", Offset = "0x47B36C", VA = "0x47B36C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public static int mapDelay
	{
		[Cpp2IlInjected.Token(Token = "0x6001A68")]
		[Cpp2IlInjected.Address(RVA = "0x47B3EC", Offset = "0x47B3EC", VA = "0x47B3EC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A69")]
		[Cpp2IlInjected.Address(RVA = "0x47B468", Offset = "0x47B468", VA = "0x47B468")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public static bool SettingsUnlock_WorldEvil
	{
		[Cpp2IlInjected.Token(Token = "0x6001A6A")]
		[Cpp2IlInjected.Address(RVA = "0x47B4E8", Offset = "0x47B4E8", VA = "0x47B4E8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A6B")]
		[Cpp2IlInjected.Address(RVA = "0x47B564", Offset = "0x47B564", VA = "0x47B564")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public static bool SettingsEnabled_MinersWobble
	{
		[Cpp2IlInjected.Token(Token = "0x6001A6C")]
		[Cpp2IlInjected.Address(RVA = "0x47B5E4", Offset = "0x47B5E4", VA = "0x47B5E4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A6D")]
		[Cpp2IlInjected.Address(RVA = "0x47B660", Offset = "0x47B660", VA = "0x47B660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public static bool SettingBlockGamepadsEntirely
	{
		[Cpp2IlInjected.Token(Token = "0x6001A6E")]
		[Cpp2IlInjected.Address(RVA = "0x47B6E0", Offset = "0x47B6E0", VA = "0x47B6E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A6F")]
		[Cpp2IlInjected.Address(RVA = "0x47B75C", Offset = "0x47B75C", VA = "0x47B75C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public static bool SettingDontScaleMainMenuUp
	{
		[Cpp2IlInjected.Token(Token = "0x6001A70")]
		[Cpp2IlInjected.Address(RVA = "0x47B7DC", Offset = "0x47B7DC", VA = "0x47B7DC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A71")]
		[Cpp2IlInjected.Address(RVA = "0x47B858", Offset = "0x47B858", VA = "0x47B858")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public static bool SettingsEnabled_OpaqueBoxBehindTooltips
	{
		[Cpp2IlInjected.Token(Token = "0x6001A72")]
		[Cpp2IlInjected.Address(RVA = "0x47B8D8", Offset = "0x47B8D8", VA = "0x47B8D8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A73")]
		[Cpp2IlInjected.Address(RVA = "0x47B954", Offset = "0x47B954", VA = "0x47B954")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public static int tooltipTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001A74")]
		[Cpp2IlInjected.Address(RVA = "0x47B9D4", Offset = "0x47B9D4", VA = "0x47B9D4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A75")]
		[Cpp2IlInjected.Address(RVA = "0x47BA50", Offset = "0x47BA50", VA = "0x47BA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public static int inventoryTooltipTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001A76")]
		[Cpp2IlInjected.Address(RVA = "0x47BAD0", Offset = "0x47BAD0", VA = "0x47BAD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A77")]
		[Cpp2IlInjected.Address(RVA = "0x47BB4C", Offset = "0x47BB4C", VA = "0x47BB4C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public static bool SettingMusicReplayDelayEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6001A78")]
		[Cpp2IlInjected.Address(RVA = "0x47BBCC", Offset = "0x47BBCC", VA = "0x47BBCC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A79")]
		[Cpp2IlInjected.Address(RVA = "0x47BC48", Offset = "0x47BC48", VA = "0x47BC48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public static bool HidePassword
	{
		[Cpp2IlInjected.Token(Token = "0x6001A7A")]
		[Cpp2IlInjected.Address(RVA = "0x47BCC8", Offset = "0x47BCC8", VA = "0x47BCC8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A7B")]
		[Cpp2IlInjected.Address(RVA = "0x47BD44", Offset = "0x47BD44", VA = "0x47BD44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public static bool ReversedUpDownArmorSetBonuses
	{
		[Cpp2IlInjected.Token(Token = "0x6001A7C")]
		[Cpp2IlInjected.Address(RVA = "0x47BDC4", Offset = "0x47BDC4", VA = "0x47BDC4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A7D")]
		[Cpp2IlInjected.Address(RVA = "0x47BE40", Offset = "0x47BE40", VA = "0x47BE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public static bool MouseShowBuildingGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6001A7E")]
		[Cpp2IlInjected.Address(RVA = "0x47BEC0", Offset = "0x47BEC0", VA = "0x47BEC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A7F")]
		[Cpp2IlInjected.Address(RVA = "0x47BF3C", Offset = "0x47BF3C", VA = "0x47BF3C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public static float MouseBuildingGridAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001A80")]
		[Cpp2IlInjected.Address(RVA = "0x47BFBC", Offset = "0x47BFBC", VA = "0x47BFBC")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A81")]
		[Cpp2IlInjected.Address(RVA = "0x47C038", Offset = "0x47C038", VA = "0x47C038")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public static Camera Camera
	{
		[Cpp2IlInjected.Token(Token = "0x6001A82")]
		[Cpp2IlInjected.Address(RVA = "0x47C0C4", Offset = "0x47C0C4", VA = "0x47C0C4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A83")]
		[Cpp2IlInjected.Address(RVA = "0x47C140", Offset = "0x47C140", VA = "0x47C140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public static string _savePath
	{
		[Cpp2IlInjected.Token(Token = "0x6001A84")]
		[Cpp2IlInjected.Address(RVA = "0x47C1C0", Offset = "0x47C1C0", VA = "0x47C1C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A85")]
		[Cpp2IlInjected.Address(RVA = "0x47C23C", Offset = "0x47C23C", VA = "0x47C23C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public static string _oldSavePath
	{
		[Cpp2IlInjected.Token(Token = "0x6001A86")]
		[Cpp2IlInjected.Address(RVA = "0x47C2BC", Offset = "0x47C2BC", VA = "0x47C2BC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A87")]
		[Cpp2IlInjected.Address(RVA = "0x47C338", Offset = "0x47C338", VA = "0x47C338")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public static FavoritesFile LocalFavoriteData
	{
		[Cpp2IlInjected.Token(Token = "0x6001A88")]
		[Cpp2IlInjected.Address(RVA = "0x47C3B8", Offset = "0x47C3B8", VA = "0x47C3B8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public static FileMetadata MapFileMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6001A89")]
		[Cpp2IlInjected.Address(RVA = "0x47C438", Offset = "0x47C438", VA = "0x47C438")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A8A")]
		[Cpp2IlInjected.Address(RVA = "0x47C4B4", Offset = "0x47C4B4", VA = "0x47C4B4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public static BigProgressBarSystem BigBossProgressBar
	{
		[Cpp2IlInjected.Token(Token = "0x6001A8B")]
		[Cpp2IlInjected.Address(RVA = "0x47C534", Offset = "0x47C534", VA = "0x47C534")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A8C")]
		[Cpp2IlInjected.Address(RVA = "0x47C5B0", Offset = "0x47C5B0", VA = "0x47C5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000381")]
	private float hellBlackBoxBottom
	{
		[Cpp2IlInjected.Token(Token = "0x6001A8D")]
		[Cpp2IlInjected.Address(RVA = "0x47C630", Offset = "0x47C630", VA = "0x47C630")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A8E")]
		[Cpp2IlInjected.Address(RVA = "0x47C6AC", Offset = "0x47C6AC", VA = "0x47C6AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	private int[] backTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6001A8F")]
		[Cpp2IlInjected.Address(RVA = "0x47C738", Offset = "0x47C738", VA = "0x47C738")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A90")]
		[Cpp2IlInjected.Address(RVA = "0x47C7B4", Offset = "0x47C7B4", VA = "0x47C7B4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000383")]
	private int[] oldBackTexture
	{
		[Cpp2IlInjected.Token(Token = "0x6001A91")]
		[Cpp2IlInjected.Address(RVA = "0x47C834", Offset = "0x47C834", VA = "0x47C834")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A92")]
		[Cpp2IlInjected.Address(RVA = "0x47C8B0", Offset = "0x47C8B0", VA = "0x47C8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	private Texture2D[] backTextureValues
	{
		[Cpp2IlInjected.Token(Token = "0x6001A93")]
		[Cpp2IlInjected.Address(RVA = "0x47C930", Offset = "0x47C930", VA = "0x47C930")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A94")]
		[Cpp2IlInjected.Address(RVA = "0x47C9AC", Offset = "0x47C9AC", VA = "0x47C9AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000385")]
	private Texture2D[] oldBackTextureValues
	{
		[Cpp2IlInjected.Token(Token = "0x6001A95")]
		[Cpp2IlInjected.Address(RVA = "0x47CA2C", Offset = "0x47CA2C", VA = "0x47CA2C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A96")]
		[Cpp2IlInjected.Address(RVA = "0x47CAA8", Offset = "0x47CAA8", VA = "0x47CAA8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public static WorldSections sectionManager
	{
		[Cpp2IlInjected.Token(Token = "0x6001A97")]
		[Cpp2IlInjected.Address(RVA = "0x47CB28", Offset = "0x47CB28", VA = "0x47CB28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001A98")]
		[Cpp2IlInjected.Address(RVA = "0x47CBA4", Offset = "0x47CBA4", VA = "0x47CBA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public static int WaveQuality
	{
		[Cpp2IlInjected.Token(Token = "0x6001A99")]
		[Cpp2IlInjected.Address(RVA = "0x47CC24", Offset = "0x47CC24", VA = "0x47CC24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A9A")]
		[Cpp2IlInjected.Address(RVA = "0x47CCA0", Offset = "0x47CCA0", VA = "0x47CCA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public static bool UseStormEffects
	{
		[Cpp2IlInjected.Token(Token = "0x6001A9B")]
		[Cpp2IlInjected.Address(RVA = "0x47CD20", Offset = "0x47CD20", VA = "0x47CD20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A9C")]
		[Cpp2IlInjected.Address(RVA = "0x47CD9C", Offset = "0x47CD9C", VA = "0x47CD9C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public static bool UseHeatDistortion
	{
		[Cpp2IlInjected.Token(Token = "0x6001A9D")]
		[Cpp2IlInjected.Address(RVA = "0x47CE1C", Offset = "0x47CE1C", VA = "0x47CE1C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001A9E")]
		[Cpp2IlInjected.Address(RVA = "0x47CE98", Offset = "0x47CE98", VA = "0x47CE98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public static Vector2 CurrentPan
	{
		[Cpp2IlInjected.Token(Token = "0x6001A9F")]
		[Cpp2IlInjected.Address(RVA = "0x47CF18", Offset = "0x47CF18", VA = "0x47CF18")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AA0")]
		[Cpp2IlInjected.Address(RVA = "0x47CFA4", Offset = "0x47CFA4", VA = "0x47CFA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public static float sunCircle
	{
		[Cpp2IlInjected.Token(Token = "0x6001AA1")]
		[Cpp2IlInjected.Address(RVA = "0x47D02C", Offset = "0x47D02C", VA = "0x47D02C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AA2")]
		[Cpp2IlInjected.Address(RVA = "0x47D0A8", Offset = "0x47D0A8", VA = "0x47D0A8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public static int BlackFadeIn
	{
		[Cpp2IlInjected.Token(Token = "0x6001AA3")]
		[Cpp2IlInjected.Address(RVA = "0x47D134", Offset = "0x47D134", VA = "0x47D134")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AA4")]
		[Cpp2IlInjected.Address(RVA = "0x47D1B0", Offset = "0x47D1B0", VA = "0x47D1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public static int undergroundBackground
	{
		[Cpp2IlInjected.Token(Token = "0x6001AA5")]
		[Cpp2IlInjected.Address(RVA = "0x47D230", Offset = "0x47D230", VA = "0x47D230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AA6")]
		[Cpp2IlInjected.Address(RVA = "0x47D2AC", Offset = "0x47D2AC", VA = "0x47D2AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038E")]
	public static int oldUndergroundBackground
	{
		[Cpp2IlInjected.Token(Token = "0x6001AA7")]
		[Cpp2IlInjected.Address(RVA = "0x47D32C", Offset = "0x47D32C", VA = "0x47D32C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AA8")]
		[Cpp2IlInjected.Address(RVA = "0x47D3A8", Offset = "0x47D3A8", VA = "0x47D3A8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038F")]
	public static bool renderNow
	{
		[Cpp2IlInjected.Token(Token = "0x6001AA9")]
		[Cpp2IlInjected.Address(RVA = "0x47D428", Offset = "0x47D428", VA = "0x47D428")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AAA")]
		[Cpp2IlInjected.Address(RVA = "0x47D4A4", Offset = "0x47D4A4", VA = "0x47D4A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000390")]
	public static int mouseX
	{
		[Cpp2IlInjected.Token(Token = "0x6001AAB")]
		[Cpp2IlInjected.Address(RVA = "0x47D524", Offset = "0x47D524", VA = "0x47D524")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AAC")]
		[Cpp2IlInjected.Address(RVA = "0x47D5A0", Offset = "0x47D5A0", VA = "0x47D5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000391")]
	public static int mouseY
	{
		[Cpp2IlInjected.Token(Token = "0x6001AAD")]
		[Cpp2IlInjected.Address(RVA = "0x47D620", Offset = "0x47D620", VA = "0x47D620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AAE")]
		[Cpp2IlInjected.Address(RVA = "0x47D69C", Offset = "0x47D69C", VA = "0x47D69C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000392")]
	public static int worldMouseX
	{
		[Cpp2IlInjected.Token(Token = "0x6001AAF")]
		[Cpp2IlInjected.Address(RVA = "0x47D71C", Offset = "0x47D71C", VA = "0x47D71C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AB0")]
		[Cpp2IlInjected.Address(RVA = "0x47D798", Offset = "0x47D798", VA = "0x47D798")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000393")]
	public static int worldMouseY
	{
		[Cpp2IlInjected.Token(Token = "0x6001AB1")]
		[Cpp2IlInjected.Address(RVA = "0x47D818", Offset = "0x47D818", VA = "0x47D818")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AB2")]
		[Cpp2IlInjected.Address(RVA = "0x47D894", Offset = "0x47D894", VA = "0x47D894")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000394")]
	public static int lastMouseX
	{
		[Cpp2IlInjected.Token(Token = "0x6001AB3")]
		[Cpp2IlInjected.Address(RVA = "0x47D914", Offset = "0x47D914", VA = "0x47D914")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AB4")]
		[Cpp2IlInjected.Address(RVA = "0x47D990", Offset = "0x47D990", VA = "0x47D990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000395")]
	public static int lastMouseY
	{
		[Cpp2IlInjected.Token(Token = "0x6001AB5")]
		[Cpp2IlInjected.Address(RVA = "0x47DA10", Offset = "0x47DA10", VA = "0x47DA10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AB6")]
		[Cpp2IlInjected.Address(RVA = "0x47DA8C", Offset = "0x47DA8C", VA = "0x47DA8C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000396")]
	public static bool mouseLeft
	{
		[Cpp2IlInjected.Token(Token = "0x6001AB7")]
		[Cpp2IlInjected.Address(RVA = "0x47DB0C", Offset = "0x47DB0C", VA = "0x47DB0C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AB8")]
		[Cpp2IlInjected.Address(RVA = "0x47DB88", Offset = "0x47DB88", VA = "0x47DB88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000397")]
	public static bool mouseRight
	{
		[Cpp2IlInjected.Token(Token = "0x6001AB9")]
		[Cpp2IlInjected.Address(RVA = "0x47DC08", Offset = "0x47DC08", VA = "0x47DC08")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ABA")]
		[Cpp2IlInjected.Address(RVA = "0x47DC84", Offset = "0x47DC84", VA = "0x47DC84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000398")]
	public static bool worldMouseLeft
	{
		[Cpp2IlInjected.Token(Token = "0x6001ABB")]
		[Cpp2IlInjected.Address(RVA = "0x47DD04", Offset = "0x47DD04", VA = "0x47DD04")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ABC")]
		[Cpp2IlInjected.Address(RVA = "0x47DD80", Offset = "0x47DD80", VA = "0x47DD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000399")]
	public static bool worldMouseLeftRelease
	{
		[Cpp2IlInjected.Token(Token = "0x6001ABD")]
		[Cpp2IlInjected.Address(RVA = "0x47DE00", Offset = "0x47DE00", VA = "0x47DE00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ABE")]
		[Cpp2IlInjected.Address(RVA = "0x47DE7C", Offset = "0x47DE7C", VA = "0x47DE7C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039A")]
	public static bool worldMouseRight
	{
		[Cpp2IlInjected.Token(Token = "0x6001ABF")]
		[Cpp2IlInjected.Address(RVA = "0x47DEFC", Offset = "0x47DEFC", VA = "0x47DEFC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AC0")]
		[Cpp2IlInjected.Address(RVA = "0x47DF78", Offset = "0x47DF78", VA = "0x47DF78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039B")]
	public static bool worldMouseRightRelease
	{
		[Cpp2IlInjected.Token(Token = "0x6001AC1")]
		[Cpp2IlInjected.Address(RVA = "0x47DFF8", Offset = "0x47DFF8", VA = "0x47DFF8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AC2")]
		[Cpp2IlInjected.Address(RVA = "0x47E074", Offset = "0x47E074", VA = "0x47E074")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039C")]
	public static bool isMouseLeftConsumedByUI
	{
		[Cpp2IlInjected.Token(Token = "0x6001AC3")]
		[Cpp2IlInjected.Address(RVA = "0x47E0F4", Offset = "0x47E0F4", VA = "0x47E0F4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AC4")]
		[Cpp2IlInjected.Address(RVA = "0x47E170", Offset = "0x47E170", VA = "0x47E170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039D")]
	public static bool DisableIntenseVisualEffects
	{
		[Cpp2IlInjected.Token(Token = "0x6001AC5")]
		[Cpp2IlInjected.Address(RVA = "0x47E1F0", Offset = "0x47E1F0", VA = "0x47E1F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AC6")]
		[Cpp2IlInjected.Address(RVA = "0x47E26C", Offset = "0x47E26C", VA = "0x47E26C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039E")]
	public static bool hairWindow
	{
		[Cpp2IlInjected.Token(Token = "0x6001AC7")]
		[Cpp2IlInjected.Address(RVA = "0x47E2EC", Offset = "0x47E2EC", VA = "0x47E2EC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AC8")]
		[Cpp2IlInjected.Address(RVA = "0x47E368", Offset = "0x47E368", VA = "0x47E368")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700039F")]
	public static bool clothesWindow
	{
		[Cpp2IlInjected.Token(Token = "0x6001AC9")]
		[Cpp2IlInjected.Address(RVA = "0x47E3E8", Offset = "0x47E3E8", VA = "0x47E3E8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ACA")]
		[Cpp2IlInjected.Address(RVA = "0x47E464", Offset = "0x47E464", VA = "0x47E464")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A0")]
	public static bool ingameOptionsWindow
	{
		[Cpp2IlInjected.Token(Token = "0x6001ACB")]
		[Cpp2IlInjected.Address(RVA = "0x47E4E4", Offset = "0x47E4E4", VA = "0x47E4E4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ACC")]
		[Cpp2IlInjected.Address(RVA = "0x47E560", Offset = "0x47E560", VA = "0x47E560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A1")]
	public static bool inFancyUI
	{
		[Cpp2IlInjected.Token(Token = "0x6001ACD")]
		[Cpp2IlInjected.Address(RVA = "0x47E5E0", Offset = "0x47E5E0", VA = "0x47E5E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ACE")]
		[Cpp2IlInjected.Address(RVA = "0x47E65C", Offset = "0x47E65C", VA = "0x47E65C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A2")]
	public static byte gFade
	{
		[Cpp2IlInjected.Token(Token = "0x6001ACF")]
		[Cpp2IlInjected.Address(RVA = "0x47E6DC", Offset = "0x47E6DC", VA = "0x47E6DC")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AD0")]
		[Cpp2IlInjected.Address(RVA = "0x47E758", Offset = "0x47E758", VA = "0x47E758")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A3")]
	public static float gFader
	{
		[Cpp2IlInjected.Token(Token = "0x6001AD1")]
		[Cpp2IlInjected.Address(RVA = "0x47E7D8", Offset = "0x47E7D8", VA = "0x47E7D8")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AD2")]
		[Cpp2IlInjected.Address(RVA = "0x47E854", Offset = "0x47E854", VA = "0x47E854")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A4")]
	public static byte gFadeDir
	{
		[Cpp2IlInjected.Token(Token = "0x6001AD3")]
		[Cpp2IlInjected.Address(RVA = "0x47E8E0", Offset = "0x47E8E0", VA = "0x47E8E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AD4")]
		[Cpp2IlInjected.Address(RVA = "0x47E95C", Offset = "0x47E95C", VA = "0x47E95C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A5")]
	public static bool render
	{
		[Cpp2IlInjected.Token(Token = "0x6001AD5")]
		[Cpp2IlInjected.Address(RVA = "0x47E9DC", Offset = "0x47E9DC", VA = "0x47E9DC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AD6")]
		[Cpp2IlInjected.Address(RVA = "0x47EA58", Offset = "0x47EA58", VA = "0x47EA58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A6")]
	public static int qaStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6001AD7")]
		[Cpp2IlInjected.Address(RVA = "0x47EAD8", Offset = "0x47EAD8", VA = "0x47EAD8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AD8")]
		[Cpp2IlInjected.Address(RVA = "0x47EB54", Offset = "0x47EB54", VA = "0x47EB54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A7")]
	public static bool BackgroundEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6001AD9")]
		[Cpp2IlInjected.Address(RVA = "0x47EBD4", Offset = "0x47EBD4", VA = "0x47EBD4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ADA")]
		[Cpp2IlInjected.Address(RVA = "0x47EC50", Offset = "0x47EC50", VA = "0x47EC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A8")]
	public static int instantBGTransitionCounter
	{
		[Cpp2IlInjected.Token(Token = "0x6001ADB")]
		[Cpp2IlInjected.Address(RVA = "0x47ECD0", Offset = "0x47ECD0", VA = "0x47ECD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ADC")]
		[Cpp2IlInjected.Address(RVA = "0x47ED4C", Offset = "0x47ED4C", VA = "0x47ED4C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003A9")]
	public static int bgDelay
	{
		[Cpp2IlInjected.Token(Token = "0x6001ADD")]
		[Cpp2IlInjected.Address(RVA = "0x47EDCC", Offset = "0x47EDCC", VA = "0x47EDCC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001ADE")]
		[Cpp2IlInjected.Address(RVA = "0x47EE48", Offset = "0x47EE48", VA = "0x47EE48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AA")]
	public static int bgStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6001ADF")]
		[Cpp2IlInjected.Address(RVA = "0x47EEC8", Offset = "0x47EEC8", VA = "0x47EEC8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AE0")]
		[Cpp2IlInjected.Address(RVA = "0x47EF44", Offset = "0x47EF44", VA = "0x47EF44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AB")]
	public static float[] bgAlphaFrontLayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001AE1")]
		[Cpp2IlInjected.Address(RVA = "0x47EFC4", Offset = "0x47EFC4", VA = "0x47EFC4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001AE2")]
		[Cpp2IlInjected.Address(RVA = "0x47F040", Offset = "0x47F040", VA = "0x47F040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AC")]
	public static float[] bgAlphaFarBackLayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001AE3")]
		[Cpp2IlInjected.Address(RVA = "0x47F0C0", Offset = "0x47F0C0", VA = "0x47F0C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001AE4")]
		[Cpp2IlInjected.Address(RVA = "0x47F13C", Offset = "0x47F13C", VA = "0x47F13C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AD")]
	public static int[] bgFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6001AE5")]
		[Cpp2IlInjected.Address(RVA = "0x47F1BC", Offset = "0x47F1BC", VA = "0x47F1BC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001AE6")]
		[Cpp2IlInjected.Address(RVA = "0x47F238", Offset = "0x47F238", VA = "0x47F238")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AE")]
	public static int[] bgFrameCounter
	{
		[Cpp2IlInjected.Token(Token = "0x6001AE7")]
		[Cpp2IlInjected.Address(RVA = "0x47F2B8", Offset = "0x47F2B8", VA = "0x47F2B8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001AE8")]
		[Cpp2IlInjected.Address(RVA = "0x47F334", Offset = "0x47F334", VA = "0x47F334")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003AF")]
	public static bool refreshMap
	{
		[Cpp2IlInjected.Token(Token = "0x6001AE9")]
		[Cpp2IlInjected.Address(RVA = "0x47F3B4", Offset = "0x47F3B4", VA = "0x47F3B4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AEA")]
		[Cpp2IlInjected.Address(RVA = "0x47F430", Offset = "0x47F430", VA = "0x47F430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B0")]
	public static int loadMapLastX
	{
		[Cpp2IlInjected.Token(Token = "0x6001AEB")]
		[Cpp2IlInjected.Address(RVA = "0x47F4B0", Offset = "0x47F4B0", VA = "0x47F4B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AEC")]
		[Cpp2IlInjected.Address(RVA = "0x47F52C", Offset = "0x47F52C", VA = "0x47F52C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B1")]
	public static bool loadMapLock
	{
		[Cpp2IlInjected.Token(Token = "0x6001AED")]
		[Cpp2IlInjected.Address(RVA = "0x47F5AC", Offset = "0x47F5AC", VA = "0x47F5AC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AEE")]
		[Cpp2IlInjected.Address(RVA = "0x47F628", Offset = "0x47F628", VA = "0x47F628")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B2")]
	public static bool loadMap
	{
		[Cpp2IlInjected.Token(Token = "0x6001AEF")]
		[Cpp2IlInjected.Address(RVA = "0x47F6A8", Offset = "0x47F6A8", VA = "0x47F6A8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AF0")]
		[Cpp2IlInjected.Address(RVA = "0x47F724", Offset = "0x47F724", VA = "0x47F724")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B3")]
	public static bool loadMapSections
	{
		[Cpp2IlInjected.Token(Token = "0x6001AF1")]
		[Cpp2IlInjected.Address(RVA = "0x47F7A4", Offset = "0x47F7A4", VA = "0x47F7A4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AF2")]
		[Cpp2IlInjected.Address(RVA = "0x47F820", Offset = "0x47F820", VA = "0x47F820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B4")]
	public static bool mapReady
	{
		[Cpp2IlInjected.Token(Token = "0x6001AF3")]
		[Cpp2IlInjected.Address(RVA = "0x47F8A0", Offset = "0x47F8A0", VA = "0x47F8A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AF4")]
		[Cpp2IlInjected.Address(RVA = "0x47F91C", Offset = "0x47F91C", VA = "0x47F91C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B5")]
	public static bool updateMap
	{
		[Cpp2IlInjected.Token(Token = "0x6001AF5")]
		[Cpp2IlInjected.Address(RVA = "0x47F99C", Offset = "0x47F99C", VA = "0x47F99C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AF6")]
		[Cpp2IlInjected.Address(RVA = "0x47FA18", Offset = "0x47FA18", VA = "0x47FA18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B6")]
	public static int mapMinX
	{
		[Cpp2IlInjected.Token(Token = "0x6001AF7")]
		[Cpp2IlInjected.Address(RVA = "0x47FA98", Offset = "0x47FA98", VA = "0x47FA98")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AF8")]
		[Cpp2IlInjected.Address(RVA = "0x47FB14", Offset = "0x47FB14", VA = "0x47FB14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B7")]
	public static int mapMaxX
	{
		[Cpp2IlInjected.Token(Token = "0x6001AF9")]
		[Cpp2IlInjected.Address(RVA = "0x47FB94", Offset = "0x47FB94", VA = "0x47FB94")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AFA")]
		[Cpp2IlInjected.Address(RVA = "0x47FC10", Offset = "0x47FC10", VA = "0x47FC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B8")]
	public static int mapMinY
	{
		[Cpp2IlInjected.Token(Token = "0x6001AFB")]
		[Cpp2IlInjected.Address(RVA = "0x47FC90", Offset = "0x47FC90", VA = "0x47FC90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AFC")]
		[Cpp2IlInjected.Address(RVA = "0x47FD0C", Offset = "0x47FD0C", VA = "0x47FD0C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003B9")]
	public static int mapMaxY
	{
		[Cpp2IlInjected.Token(Token = "0x6001AFD")]
		[Cpp2IlInjected.Address(RVA = "0x47FD8C", Offset = "0x47FD8C", VA = "0x47FD8C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001AFE")]
		[Cpp2IlInjected.Address(RVA = "0x47FE08", Offset = "0x47FE08", VA = "0x47FE08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BA")]
	public static int mapTimeMax
	{
		[Cpp2IlInjected.Token(Token = "0x6001AFF")]
		[Cpp2IlInjected.Address(RVA = "0x47FE88", Offset = "0x47FE88", VA = "0x47FE88")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B00")]
		[Cpp2IlInjected.Address(RVA = "0x47FF04", Offset = "0x47FF04", VA = "0x47FF04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BB")]
	public static int mapTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001B01")]
		[Cpp2IlInjected.Address(RVA = "0x47FF84", Offset = "0x47FF84", VA = "0x47FF84")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B02")]
		[Cpp2IlInjected.Address(RVA = "0x480000", Offset = "0x480000", VA = "0x480000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BC")]
	public static bool clearMap
	{
		[Cpp2IlInjected.Token(Token = "0x6001B03")]
		[Cpp2IlInjected.Address(RVA = "0x480080", Offset = "0x480080", VA = "0x480080")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B04")]
		[Cpp2IlInjected.Address(RVA = "0x4800FC", Offset = "0x4800FC", VA = "0x4800FC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BD")]
	public static bool mapInit
	{
		[Cpp2IlInjected.Token(Token = "0x6001B05")]
		[Cpp2IlInjected.Address(RVA = "0x48017C", Offset = "0x48017C", VA = "0x48017C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B06")]
		[Cpp2IlInjected.Address(RVA = "0x4801F8", Offset = "0x4801F8", VA = "0x4801F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BE")]
	public static bool mapEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6001B07")]
		[Cpp2IlInjected.Address(RVA = "0x480278", Offset = "0x480278", VA = "0x480278")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B08")]
		[Cpp2IlInjected.Address(RVA = "0x4802F4", Offset = "0x4802F4", VA = "0x4802F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003BF")]
	public static int mapStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6001B09")]
		[Cpp2IlInjected.Address(RVA = "0x480374", Offset = "0x480374", VA = "0x480374")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B0A")]
		[Cpp2IlInjected.Address(RVA = "0x4803F0", Offset = "0x4803F0", VA = "0x4803F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C0")]
	public static float grabMapX
	{
		[Cpp2IlInjected.Token(Token = "0x6001B0B")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x480470", VA = "0x480470")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B0C")]
		[Cpp2IlInjected.Address(RVA = "0x4804EC", Offset = "0x4804EC", VA = "0x4804EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C1")]
	public static float grabMapY
	{
		[Cpp2IlInjected.Token(Token = "0x6001B0D")]
		[Cpp2IlInjected.Address(RVA = "0x480578", Offset = "0x480578", VA = "0x480578")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B0E")]
		[Cpp2IlInjected.Address(RVA = "0x4805F4", Offset = "0x4805F4", VA = "0x4805F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C2")]
	public static float grabMapInitialX
	{
		[Cpp2IlInjected.Token(Token = "0x6001B0F")]
		[Cpp2IlInjected.Address(RVA = "0x480680", Offset = "0x480680", VA = "0x480680")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B10")]
		[Cpp2IlInjected.Address(RVA = "0x4806FC", Offset = "0x4806FC", VA = "0x4806FC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C3")]
	public static float grabMapInitialY
	{
		[Cpp2IlInjected.Token(Token = "0x6001B11")]
		[Cpp2IlInjected.Address(RVA = "0x480788", Offset = "0x480788", VA = "0x480788")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B12")]
		[Cpp2IlInjected.Address(RVA = "0x480804", Offset = "0x480804", VA = "0x480804")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C4")]
	public static bool grabMapInProgress
	{
		[Cpp2IlInjected.Token(Token = "0x6001B13")]
		[Cpp2IlInjected.Address(RVA = "0x480890", Offset = "0x480890", VA = "0x480890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B14")]
		[Cpp2IlInjected.Address(RVA = "0x48090C", Offset = "0x48090C", VA = "0x48090C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C5")]
	public static int miniMapX
	{
		[Cpp2IlInjected.Token(Token = "0x6001B15")]
		[Cpp2IlInjected.Address(RVA = "0x48098C", Offset = "0x48098C", VA = "0x48098C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B16")]
		[Cpp2IlInjected.Address(RVA = "0x480A08", Offset = "0x480A08", VA = "0x480A08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C6")]
	public static int miniMapY
	{
		[Cpp2IlInjected.Token(Token = "0x6001B17")]
		[Cpp2IlInjected.Address(RVA = "0x480A88", Offset = "0x480A88", VA = "0x480A88")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B18")]
		[Cpp2IlInjected.Address(RVA = "0x480B04", Offset = "0x480B04", VA = "0x480B04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C7")]
	public static int miniMapWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6001B19")]
		[Cpp2IlInjected.Address(RVA = "0x480B84", Offset = "0x480B84", VA = "0x480B84")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B1A")]
		[Cpp2IlInjected.Address(RVA = "0x480C00", Offset = "0x480C00", VA = "0x480C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C8")]
	public static int miniMapHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6001B1B")]
		[Cpp2IlInjected.Address(RVA = "0x480C80", Offset = "0x480C80", VA = "0x480C80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B1C")]
		[Cpp2IlInjected.Address(RVA = "0x480CFC", Offset = "0x480CFC", VA = "0x480CFC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003C9")]
	public static float mapMinimapScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001B1D")]
		[Cpp2IlInjected.Address(RVA = "0x480D7C", Offset = "0x480D7C", VA = "0x480D7C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B1E")]
		[Cpp2IlInjected.Address(RVA = "0x480DF8", Offset = "0x480DF8", VA = "0x480DF8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CA")]
	public static float mapMinimapAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001B1F")]
		[Cpp2IlInjected.Address(RVA = "0x480E84", Offset = "0x480E84", VA = "0x480E84")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B20")]
		[Cpp2IlInjected.Address(RVA = "0x480F00", Offset = "0x480F00", VA = "0x480F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CB")]
	public static float mapOverlayScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001B21")]
		[Cpp2IlInjected.Address(RVA = "0x480F8C", Offset = "0x480F8C", VA = "0x480F8C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B22")]
		[Cpp2IlInjected.Address(RVA = "0x481008", Offset = "0x481008", VA = "0x481008")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CC")]
	public static float mapOverlayAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001B23")]
		[Cpp2IlInjected.Address(RVA = "0x481094", Offset = "0x481094", VA = "0x481094")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B24")]
		[Cpp2IlInjected.Address(RVA = "0x481110", Offset = "0x481110", VA = "0x481110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CD")]
	public static bool mapFullscreen
	{
		[Cpp2IlInjected.Token(Token = "0x6001B25")]
		[Cpp2IlInjected.Address(RVA = "0x48119C", Offset = "0x48119C", VA = "0x48119C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B26")]
		[Cpp2IlInjected.Address(RVA = "0x481218", Offset = "0x481218", VA = "0x481218")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CE")]
	public static bool resetMapFull
	{
		[Cpp2IlInjected.Token(Token = "0x6001B27")]
		[Cpp2IlInjected.Address(RVA = "0x481298", Offset = "0x481298", VA = "0x481298")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B28")]
		[Cpp2IlInjected.Address(RVA = "0x481314", Offset = "0x481314", VA = "0x481314")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003CF")]
	public static int resetMapFullCharacter
	{
		[Cpp2IlInjected.Token(Token = "0x6001B29")]
		[Cpp2IlInjected.Address(RVA = "0x481394", Offset = "0x481394", VA = "0x481394")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B2A")]
		[Cpp2IlInjected.Address(RVA = "0x481410", Offset = "0x481410", VA = "0x481410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D0")]
	public static float mapFullscreenScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001B2B")]
		[Cpp2IlInjected.Address(RVA = "0x481490", Offset = "0x481490", VA = "0x481490")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B2C")]
		[Cpp2IlInjected.Address(RVA = "0x48150C", Offset = "0x48150C", VA = "0x48150C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D1")]
	public static Vector2 mapFullscreenPos
	{
		[Cpp2IlInjected.Token(Token = "0x6001B2D")]
		[Cpp2IlInjected.Address(RVA = "0x481598", Offset = "0x481598", VA = "0x481598")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B2E")]
		[Cpp2IlInjected.Address(RVA = "0x481624", Offset = "0x481624", VA = "0x481624")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D2")]
	public static int renderCount
	{
		[Cpp2IlInjected.Token(Token = "0x6001B2F")]
		[Cpp2IlInjected.Address(RVA = "0x4816AC", Offset = "0x4816AC", VA = "0x4816AC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B30")]
		[Cpp2IlInjected.Address(RVA = "0x481728", Offset = "0x481728", VA = "0x481728")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D3")]
	public static Stopwatch saveTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001B31")]
		[Cpp2IlInjected.Address(RVA = "0x4817A8", Offset = "0x4817A8", VA = "0x4817A8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B32")]
		[Cpp2IlInjected.Address(RVA = "0x481824", Offset = "0x481824", VA = "0x481824")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D4")]
	public static float gfxQuality
	{
		[Cpp2IlInjected.Token(Token = "0x6001B33")]
		[Cpp2IlInjected.Address(RVA = "0x4818A4", Offset = "0x4818A4", VA = "0x4818A4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B34")]
		[Cpp2IlInjected.Address(RVA = "0x481920", Offset = "0x481920", VA = "0x481920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D5")]
	public static float gfxRate
	{
		[Cpp2IlInjected.Token(Token = "0x6001B35")]
		[Cpp2IlInjected.Address(RVA = "0x4819AC", Offset = "0x4819AC", VA = "0x4819AC")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B36")]
		[Cpp2IlInjected.Address(RVA = "0x481A28", Offset = "0x481A28", VA = "0x481A28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D6")]
	public static int teamCooldown
	{
		[Cpp2IlInjected.Token(Token = "0x6001B37")]
		[Cpp2IlInjected.Address(RVA = "0x481AB4", Offset = "0x481AB4", VA = "0x481AB4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B38")]
		[Cpp2IlInjected.Address(RVA = "0x481B30", Offset = "0x481B30", VA = "0x481B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D7")]
	public static bool showFrameRate
	{
		[Cpp2IlInjected.Token(Token = "0x6001B39")]
		[Cpp2IlInjected.Address(RVA = "0x481BB0", Offset = "0x481BB0", VA = "0x481BB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B3A")]
		[Cpp2IlInjected.Address(RVA = "0x481C2C", Offset = "0x481C2C", VA = "0x481C2C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D8")]
	public static bool drewLava
	{
		[Cpp2IlInjected.Token(Token = "0x6001B3B")]
		[Cpp2IlInjected.Address(RVA = "0x481CAC", Offset = "0x481CAC", VA = "0x481CAC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B3C")]
		[Cpp2IlInjected.Address(RVA = "0x481D28", Offset = "0x481D28", VA = "0x481D28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003D9")]
	public static int numActiveLiquidAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001B3D")]
		[Cpp2IlInjected.Address(RVA = "0x481DA8", Offset = "0x481DA8", VA = "0x481DA8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B3E")]
		[Cpp2IlInjected.Address(RVA = "0x481E24", Offset = "0x481E24", VA = "0x481E24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DA")]
	public static int[] activeLiquidAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001B3F")]
		[Cpp2IlInjected.Address(RVA = "0x481EA4", Offset = "0x481EA4", VA = "0x481EA4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B40")]
		[Cpp2IlInjected.Address(RVA = "0x481F20", Offset = "0x481F20", VA = "0x481F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DB")]
	public static float[] liquidAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001B41")]
		[Cpp2IlInjected.Address(RVA = "0x481FA0", Offset = "0x481FA0", VA = "0x481FA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B42")]
		[Cpp2IlInjected.Address(RVA = "0x48201C", Offset = "0x48201C", VA = "0x48201C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DC")]
	public static int waterStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6001B43")]
		[Cpp2IlInjected.Address(RVA = "0x48209C", Offset = "0x48209C", VA = "0x48209C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B44")]
		[Cpp2IlInjected.Address(RVA = "0x482118", Offset = "0x482118", VA = "0x482118")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DD")]
	public static bool TOWMusicUnlocked
	{
		[Cpp2IlInjected.Token(Token = "0x6001B45")]
		[Cpp2IlInjected.Address(RVA = "0x482198", Offset = "0x482198", VA = "0x482198")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B46")]
		[Cpp2IlInjected.Address(RVA = "0x482214", Offset = "0x482214", VA = "0x482214")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DE")]
	public static float caveParallax
	{
		[Cpp2IlInjected.Token(Token = "0x6001B47")]
		[Cpp2IlInjected.Address(RVA = "0x482294", Offset = "0x482294", VA = "0x482294")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B48")]
		[Cpp2IlInjected.Address(RVA = "0x482310", Offset = "0x482310", VA = "0x482310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003DF")]
	public static bool showItemText
	{
		[Cpp2IlInjected.Token(Token = "0x6001B49")]
		[Cpp2IlInjected.Address(RVA = "0x48239C", Offset = "0x48239C", VA = "0x48239C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B4A")]
		[Cpp2IlInjected.Address(RVA = "0x482418", Offset = "0x482418", VA = "0x482418")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E0")]
	public static bool autoSave
	{
		[Cpp2IlInjected.Token(Token = "0x6001B4B")]
		[Cpp2IlInjected.Address(RVA = "0x482498", Offset = "0x482498", VA = "0x482498")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B4C")]
		[Cpp2IlInjected.Address(RVA = "0x482514", Offset = "0x482514", VA = "0x482514")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E1")]
	public static int background
	{
		[Cpp2IlInjected.Token(Token = "0x6001B4D")]
		[Cpp2IlInjected.Address(RVA = "0x482594", Offset = "0x482594", VA = "0x482594")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B4E")]
		[Cpp2IlInjected.Address(RVA = "0x482610", Offset = "0x482610", VA = "0x482610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E2")]
	public static int caveBackground
	{
		[Cpp2IlInjected.Token(Token = "0x6001B4F")]
		[Cpp2IlInjected.Address(RVA = "0x482690", Offset = "0x482690", VA = "0x482690")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B50")]
		[Cpp2IlInjected.Address(RVA = "0x48270C", Offset = "0x48270C", VA = "0x48270C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E3")]
	public static float ugBackTransition
	{
		[Cpp2IlInjected.Token(Token = "0x6001B51")]
		[Cpp2IlInjected.Address(RVA = "0x48278C", Offset = "0x48278C", VA = "0x48278C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B52")]
		[Cpp2IlInjected.Address(RVA = "0x482808", Offset = "0x482808", VA = "0x482808")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E4")]
	public static AutoPauseMode autoPause
	{
		[Cpp2IlInjected.Token(Token = "0x6001B53")]
		[Cpp2IlInjected.Address(RVA = "0x482894", Offset = "0x482894", VA = "0x482894")]
		get
		{
			return default(AutoPauseMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B54")]
		[Cpp2IlInjected.Address(RVA = "0x482910", Offset = "0x482910", VA = "0x482910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E5")]
	public static bool placementPreview
	{
		[Cpp2IlInjected.Token(Token = "0x6001B55")]
		[Cpp2IlInjected.Address(RVA = "0x482990", Offset = "0x482990", VA = "0x482990")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B56")]
		[Cpp2IlInjected.Address(RVA = "0x482A0C", Offset = "0x482A0C", VA = "0x482A0C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E6")]
	public static SceneMetrics SceneMetrics
	{
		[Cpp2IlInjected.Token(Token = "0x6001B57")]
		[Cpp2IlInjected.Address(RVA = "0x482A8C", Offset = "0x482A8C", VA = "0x482A8C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B58")]
		[Cpp2IlInjected.Address(RVA = "0x482B08", Offset = "0x482B08", VA = "0x482B08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E7")]
	public static bool SettingsEnabled_TilesSwayInWind
	{
		[Cpp2IlInjected.Token(Token = "0x6001B59")]
		[Cpp2IlInjected.Address(RVA = "0x482B88", Offset = "0x482B88", VA = "0x482B88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B5A")]
		[Cpp2IlInjected.Address(RVA = "0x482C04", Offset = "0x482C04", VA = "0x482C04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E8")]
	public static float GraveyardVisualIntensity
	{
		[Cpp2IlInjected.Token(Token = "0x6001B5B")]
		[Cpp2IlInjected.Address(RVA = "0x482C84", Offset = "0x482C84", VA = "0x482C84")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B5C")]
		[Cpp2IlInjected.Address(RVA = "0x482D00", Offset = "0x482D00", VA = "0x482D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003E9")]
	public static float musicVolume
	{
		[Cpp2IlInjected.Token(Token = "0x6001B5D")]
		[Cpp2IlInjected.Address(RVA = "0x482D8C", Offset = "0x482D8C", VA = "0x482D8C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B5E")]
		[Cpp2IlInjected.Address(RVA = "0x482E08", Offset = "0x482E08", VA = "0x482E08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EA")]
	public static float ambientVolume
	{
		[Cpp2IlInjected.Token(Token = "0x6001B5F")]
		[Cpp2IlInjected.Address(RVA = "0x482E94", Offset = "0x482E94", VA = "0x482E94")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B60")]
		[Cpp2IlInjected.Address(RVA = "0x482F10", Offset = "0x482F10", VA = "0x482F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EB")]
	public static float soundVolume
	{
		[Cpp2IlInjected.Token(Token = "0x6001B61")]
		[Cpp2IlInjected.Address(RVA = "0x482F9C", Offset = "0x482F9C", VA = "0x482F9C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B62")]
		[Cpp2IlInjected.Address(RVA = "0x483018", Offset = "0x483018", VA = "0x483018")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EC")]
	public static WorldMap Map
	{
		[Cpp2IlInjected.Token(Token = "0x6001B63")]
		[Cpp2IlInjected.Address(RVA = "0x4830A4", Offset = "0x4830A4", VA = "0x4830A4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B64")]
		[Cpp2IlInjected.Address(RVA = "0x483120", Offset = "0x483120", VA = "0x483120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003ED")]
	public static Rain[] rain
	{
		[Cpp2IlInjected.Token(Token = "0x6001B65")]
		[Cpp2IlInjected.Address(RVA = "0x4831A0", Offset = "0x4831A0", VA = "0x4831A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B66")]
		[Cpp2IlInjected.Address(RVA = "0x48321C", Offset = "0x48321C", VA = "0x48321C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EE")]
	public static PopupText[] popupText
	{
		[Cpp2IlInjected.Token(Token = "0x6001B67")]
		[Cpp2IlInjected.Address(RVA = "0x48329C", Offset = "0x48329C", VA = "0x48329C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B68")]
		[Cpp2IlInjected.Address(RVA = "0x483318", Offset = "0x483318", VA = "0x483318")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003EF")]
	public static float startScreenYOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6001B69")]
		[Cpp2IlInjected.Address(RVA = "0x483398", Offset = "0x483398", VA = "0x483398")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B6A")]
		[Cpp2IlInjected.Address(RVA = "0x483414", Offset = "0x483414", VA = "0x483414")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F0")]
	public static float targetScreenYOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6001B6B")]
		[Cpp2IlInjected.Address(RVA = "0x4834A0", Offset = "0x4834A0", VA = "0x4834A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B6C")]
		[Cpp2IlInjected.Address(RVA = "0x48351C", Offset = "0x48351C", VA = "0x48351C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F1")]
	public static float screenYOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6001B6D")]
		[Cpp2IlInjected.Address(RVA = "0x4835A8", Offset = "0x4835A8", VA = "0x4835A8")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B6E")]
		[Cpp2IlInjected.Address(RVA = "0x483624", Offset = "0x483624", VA = "0x483624")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F2")]
	public static float cameraOffset
	{
		[Cpp2IlInjected.Token(Token = "0x6001B6F")]
		[Cpp2IlInjected.Address(RVA = "0x4836B0", Offset = "0x4836B0", VA = "0x4836B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B70")]
		[Cpp2IlInjected.Address(RVA = "0x48372C", Offset = "0x48372C", VA = "0x48372C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F3")]
	public static Vector2 screenPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6001B71")]
		[Cpp2IlInjected.Address(RVA = "0x4837B8", Offset = "0x4837B8", VA = "0x4837B8")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B72")]
		[Cpp2IlInjected.Address(RVA = "0x483844", Offset = "0x483844", VA = "0x483844")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F4")]
	public static Vector2 screenLastPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6001B73")]
		[Cpp2IlInjected.Address(RVA = "0x4838CC", Offset = "0x4838CC", VA = "0x4838CC")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B74")]
		[Cpp2IlInjected.Address(RVA = "0x483958", Offset = "0x483958", VA = "0x483958")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F5")]
	public static int screenWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6001B75")]
		[Cpp2IlInjected.Address(RVA = "0x4839E0", Offset = "0x4839E0", VA = "0x4839E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B76")]
		[Cpp2IlInjected.Address(RVA = "0x483A5C", Offset = "0x483A5C", VA = "0x483A5C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F6")]
	public static int screenHeight
	{
		[Cpp2IlInjected.Token(Token = "0x6001B77")]
		[Cpp2IlInjected.Address(RVA = "0x483ADC", Offset = "0x483ADC", VA = "0x483ADC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B78")]
		[Cpp2IlInjected.Address(RVA = "0x483B58", Offset = "0x483B58", VA = "0x483B58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F7")]
	public static bool mouseLeftRelease
	{
		[Cpp2IlInjected.Token(Token = "0x6001B79")]
		[Cpp2IlInjected.Address(RVA = "0x483BD8", Offset = "0x483BD8", VA = "0x483BD8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B7A")]
		[Cpp2IlInjected.Address(RVA = "0x483C54", Offset = "0x483C54", VA = "0x483C54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F8")]
	public static bool mouseRightRelease
	{
		[Cpp2IlInjected.Token(Token = "0x6001B7B")]
		[Cpp2IlInjected.Address(RVA = "0x483CD4", Offset = "0x483CD4", VA = "0x483CD4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B7C")]
		[Cpp2IlInjected.Address(RVA = "0x483D50", Offset = "0x483D50", VA = "0x483D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003F9")]
	public static bool playerInventory
	{
		[Cpp2IlInjected.Token(Token = "0x6001B7D")]
		[Cpp2IlInjected.Address(RVA = "0x483DD0", Offset = "0x483DD0", VA = "0x483DD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B7E")]
		[Cpp2IlInjected.Address(RVA = "0x483E4C", Offset = "0x483E4C", VA = "0x483E4C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FA")]
	public static int stackSplit
	{
		[Cpp2IlInjected.Token(Token = "0x6001B7F")]
		[Cpp2IlInjected.Address(RVA = "0x483ECC", Offset = "0x483ECC", VA = "0x483ECC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B80")]
		[Cpp2IlInjected.Address(RVA = "0x483F48", Offset = "0x483F48", VA = "0x483F48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FB")]
	public static bool preventStackSplitReset
	{
		[Cpp2IlInjected.Token(Token = "0x6001B81")]
		[Cpp2IlInjected.Address(RVA = "0x483FC8", Offset = "0x483FC8", VA = "0x483FC8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B82")]
		[Cpp2IlInjected.Address(RVA = "0x484044", Offset = "0x484044", VA = "0x484044")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FC")]
	public static int stackCounter
	{
		[Cpp2IlInjected.Token(Token = "0x6001B83")]
		[Cpp2IlInjected.Address(RVA = "0x4840C4", Offset = "0x4840C4", VA = "0x4840C4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B84")]
		[Cpp2IlInjected.Address(RVA = "0x484140", Offset = "0x484140", VA = "0x484140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FD")]
	public static int stackDelay
	{
		[Cpp2IlInjected.Token(Token = "0x6001B85")]
		[Cpp2IlInjected.Address(RVA = "0x4841C0", Offset = "0x4841C0", VA = "0x4841C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B86")]
		[Cpp2IlInjected.Address(RVA = "0x48423C", Offset = "0x48423C", VA = "0x48423C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FE")]
	public static int superFastStack
	{
		[Cpp2IlInjected.Token(Token = "0x6001B87")]
		[Cpp2IlInjected.Address(RVA = "0x4842BC", Offset = "0x4842BC", VA = "0x4842BC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B88")]
		[Cpp2IlInjected.Address(RVA = "0x484338", Offset = "0x484338", VA = "0x484338")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170003FF")]
	public static int timesTriedToFastStack
	{
		[Cpp2IlInjected.Token(Token = "0x6001B89")]
		[Cpp2IlInjected.Address(RVA = "0x4843B8", Offset = "0x4843B8", VA = "0x4843B8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B8A")]
		[Cpp2IlInjected.Address(RVA = "0x484434", Offset = "0x484434", VA = "0x484434")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000400")]
	public static Item mouseItem
	{
		[Cpp2IlInjected.Token(Token = "0x6001B8B")]
		[Cpp2IlInjected.Address(RVA = "0x4844B4", Offset = "0x4844B4", VA = "0x4844B4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B8C")]
		[Cpp2IlInjected.Address(RVA = "0x484530", Offset = "0x484530", VA = "0x484530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000401")]
	public static float mouseItemTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001B8D")]
		[Cpp2IlInjected.Address(RVA = "0x4845B0", Offset = "0x4845B0", VA = "0x4845B0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B8E")]
		[Cpp2IlInjected.Address(RVA = "0x48462C", Offset = "0x48462C", VA = "0x48462C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000402")]
	public static Item[] mouseItemSource
	{
		[Cpp2IlInjected.Token(Token = "0x6001B8F")]
		[Cpp2IlInjected.Address(RVA = "0x4846B8", Offset = "0x4846B8", VA = "0x4846B8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B90")]
		[Cpp2IlInjected.Address(RVA = "0x484734", Offset = "0x484734", VA = "0x484734")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000403")]
	public static int mouseItemSourceIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6001B91")]
		[Cpp2IlInjected.Address(RVA = "0x4847B4", Offset = "0x4847B4", VA = "0x4847B4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B92")]
		[Cpp2IlInjected.Address(RVA = "0x484830", Offset = "0x484830", VA = "0x484830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000404")]
	public static int mouseItemSourceContext
	{
		[Cpp2IlInjected.Token(Token = "0x6001B93")]
		[Cpp2IlInjected.Address(RVA = "0x4848B0", Offset = "0x4848B0", VA = "0x4848B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B94")]
		[Cpp2IlInjected.Address(RVA = "0x48492C", Offset = "0x48492C", VA = "0x48492C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000405")]
	public static Item guideItem
	{
		[Cpp2IlInjected.Token(Token = "0x6001B95")]
		[Cpp2IlInjected.Address(RVA = "0x4849AC", Offset = "0x4849AC", VA = "0x4849AC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B96")]
		[Cpp2IlInjected.Address(RVA = "0x484A28", Offset = "0x484A28", VA = "0x484A28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000406")]
	public static Item reforgeItem
	{
		[Cpp2IlInjected.Token(Token = "0x6001B97")]
		[Cpp2IlInjected.Address(RVA = "0x484AA8", Offset = "0x484AA8", VA = "0x484AA8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B98")]
		[Cpp2IlInjected.Address(RVA = "0x484B24", Offset = "0x484B24", VA = "0x484B24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000407")]
	public static float inventoryScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001B99")]
		[Cpp2IlInjected.Address(RVA = "0x484BA4", Offset = "0x484BA4", VA = "0x484BA4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B9A")]
		[Cpp2IlInjected.Address(RVA = "0x484C20", Offset = "0x484C20", VA = "0x484C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000408")]
	public static Point rulerLineDisplayValues
	{
		[Cpp2IlInjected.Token(Token = "0x6001B9B")]
		[Cpp2IlInjected.Address(RVA = "0x484CAC", Offset = "0x484CAC", VA = "0x484CAC")]
		get
		{
			return default(Point);
		}
		[Cpp2IlInjected.Token(Token = "0x6001B9C")]
		[Cpp2IlInjected.Address(RVA = "0x484D38", Offset = "0x484D38", VA = "0x484D38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000409")]
	public static int[] availableRecipe
	{
		[Cpp2IlInjected.Token(Token = "0x6001B9D")]
		[Cpp2IlInjected.Address(RVA = "0x484DC0", Offset = "0x484DC0", VA = "0x484DC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001B9E")]
		[Cpp2IlInjected.Address(RVA = "0x484E3C", Offset = "0x484E3C", VA = "0x484E3C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040A")]
	public static int lastRecipeUpdateId
	{
		[Cpp2IlInjected.Token(Token = "0x6001B9F")]
		[Cpp2IlInjected.Address(RVA = "0x484EBC", Offset = "0x484EBC", VA = "0x484EBC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BA0")]
		[Cpp2IlInjected.Address(RVA = "0x484F38", Offset = "0x484F38", VA = "0x484F38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040B")]
	public static int numAvailableRecipes
	{
		[Cpp2IlInjected.Token(Token = "0x6001BA1")]
		[Cpp2IlInjected.Address(RVA = "0x484FB8", Offset = "0x484FB8", VA = "0x484FB8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BA2")]
		[Cpp2IlInjected.Address(RVA = "0x485034", Offset = "0x485034", VA = "0x485034")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040C")]
	public static int focusRecipe
	{
		[Cpp2IlInjected.Token(Token = "0x6001BA3")]
		[Cpp2IlInjected.Address(RVA = "0x4850B4", Offset = "0x4850B4", VA = "0x4850B4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BA4")]
		[Cpp2IlInjected.Address(RVA = "0x485130", Offset = "0x485130", VA = "0x485130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040D")]
	public static int myPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001BA5")]
		[Cpp2IlInjected.Address(RVA = "0x4851B0", Offset = "0x4851B0", VA = "0x4851B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BA6")]
		[Cpp2IlInjected.Address(RVA = "0x48522C", Offset = "0x48522C", VA = "0x48522C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040E")]
	public static int spawnTileX
	{
		[Cpp2IlInjected.Token(Token = "0x6001BA7")]
		[Cpp2IlInjected.Address(RVA = "0x4852AC", Offset = "0x4852AC", VA = "0x4852AC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BA8")]
		[Cpp2IlInjected.Address(RVA = "0x485328", Offset = "0x485328", VA = "0x485328")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700040F")]
	public static int spawnTileY
	{
		[Cpp2IlInjected.Token(Token = "0x6001BA9")]
		[Cpp2IlInjected.Address(RVA = "0x4853A8", Offset = "0x4853A8", VA = "0x4853A8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BAA")]
		[Cpp2IlInjected.Address(RVA = "0x485424", Offset = "0x485424", VA = "0x485424")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000410")]
	public static bool npcChatRelease
	{
		[Cpp2IlInjected.Token(Token = "0x6001BAB")]
		[Cpp2IlInjected.Address(RVA = "0x4854A4", Offset = "0x4854A4", VA = "0x4854A4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BAC")]
		[Cpp2IlInjected.Address(RVA = "0x485520", Offset = "0x485520", VA = "0x485520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000411")]
	public static bool editSign
	{
		[Cpp2IlInjected.Token(Token = "0x6001BAD")]
		[Cpp2IlInjected.Address(RVA = "0x4855A0", Offset = "0x4855A0", VA = "0x4855A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BAE")]
		[Cpp2IlInjected.Address(RVA = "0x48561C", Offset = "0x48561C", VA = "0x48561C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000412")]
	public static bool editChest
	{
		[Cpp2IlInjected.Token(Token = "0x6001BAF")]
		[Cpp2IlInjected.Address(RVA = "0x48569C", Offset = "0x48569C", VA = "0x48569C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BB0")]
		[Cpp2IlInjected.Address(RVA = "0x485718", Offset = "0x485718", VA = "0x485718")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000413")]
	public static bool blockInput
	{
		[Cpp2IlInjected.Token(Token = "0x6001BB1")]
		[Cpp2IlInjected.Address(RVA = "0x485798", Offset = "0x485798", VA = "0x485798")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BB2")]
		[Cpp2IlInjected.Address(RVA = "0x485814", Offset = "0x485814", VA = "0x485814")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000414")]
	public static string blockKey
	{
		[Cpp2IlInjected.Token(Token = "0x6001BB3")]
		[Cpp2IlInjected.Address(RVA = "0x485894", Offset = "0x485894", VA = "0x485894")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BB4")]
		[Cpp2IlInjected.Address(RVA = "0x485910", Offset = "0x485910", VA = "0x485910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000415")]
	public static string defaultChestName
	{
		[Cpp2IlInjected.Token(Token = "0x6001BB5")]
		[Cpp2IlInjected.Address(RVA = "0x485990", Offset = "0x485990", VA = "0x485990")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BB6")]
		[Cpp2IlInjected.Address(RVA = "0x485A0C", Offset = "0x485A0C", VA = "0x485A0C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000416")]
	public static string npcChatText
	{
		[Cpp2IlInjected.Token(Token = "0x6001BB7")]
		[Cpp2IlInjected.Address(RVA = "0x485A8C", Offset = "0x485A8C", VA = "0x485A8C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BB8")]
		[Cpp2IlInjected.Address(RVA = "0x485B08", Offset = "0x485B08", VA = "0x485B08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000417")]
	public static bool npcChatFocus1
	{
		[Cpp2IlInjected.Token(Token = "0x6001BB9")]
		[Cpp2IlInjected.Address(RVA = "0x485B88", Offset = "0x485B88", VA = "0x485B88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BBA")]
		[Cpp2IlInjected.Address(RVA = "0x485C04", Offset = "0x485C04", VA = "0x485C04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000418")]
	public static bool npcChatFocus2
	{
		[Cpp2IlInjected.Token(Token = "0x6001BBB")]
		[Cpp2IlInjected.Address(RVA = "0x485C84", Offset = "0x485C84", VA = "0x485C84")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BBC")]
		[Cpp2IlInjected.Address(RVA = "0x485D00", Offset = "0x485D00", VA = "0x485D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000419")]
	public static bool npcChatFocus3
	{
		[Cpp2IlInjected.Token(Token = "0x6001BBD")]
		[Cpp2IlInjected.Address(RVA = "0x485D80", Offset = "0x485D80", VA = "0x485D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BBE")]
		[Cpp2IlInjected.Address(RVA = "0x485DFC", Offset = "0x485DFC", VA = "0x485DFC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041A")]
	public static bool npcChatFocus4
	{
		[Cpp2IlInjected.Token(Token = "0x6001BBF")]
		[Cpp2IlInjected.Address(RVA = "0x485E7C", Offset = "0x485E7C", VA = "0x485E7C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BC0")]
		[Cpp2IlInjected.Address(RVA = "0x485EF8", Offset = "0x485EF8", VA = "0x485EF8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041B")]
	public static int oldNPCShop
	{
		[Cpp2IlInjected.Token(Token = "0x6001BC1")]
		[Cpp2IlInjected.Address(RVA = "0x485F78", Offset = "0x485F78", VA = "0x485F78")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BC2")]
		[Cpp2IlInjected.Address(RVA = "0x485FF4", Offset = "0x485FF4", VA = "0x485FF4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041C")]
	public static int npcShop
	{
		[Cpp2IlInjected.Token(Token = "0x6001BC3")]
		[Cpp2IlInjected.Address(RVA = "0x486074", Offset = "0x486074", VA = "0x486074")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BC4")]
		[Cpp2IlInjected.Address(RVA = "0x4860F0", Offset = "0x4860F0", VA = "0x4860F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041D")]
	public static int npcChatCornerItem
	{
		[Cpp2IlInjected.Token(Token = "0x6001BC5")]
		[Cpp2IlInjected.Address(RVA = "0x486170", Offset = "0x486170", VA = "0x486170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BC6")]
		[Cpp2IlInjected.Address(RVA = "0x4861EC", Offset = "0x4861EC", VA = "0x4861EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041E")]
	public Chest[] shop
	{
		[Cpp2IlInjected.Token(Token = "0x6001BC7")]
		[Cpp2IlInjected.Address(RVA = "0x48626C", Offset = "0x48626C", VA = "0x48626C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BC8")]
		[Cpp2IlInjected.Address(RVA = "0x4862E8", Offset = "0x4862E8", VA = "0x4862E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700041F")]
	public static ItemShopSellbackHelper shopSellbackHelper
	{
		[Cpp2IlInjected.Token(Token = "0x6001BC9")]
		[Cpp2IlInjected.Address(RVA = "0x486368", Offset = "0x486368", VA = "0x486368")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BCA")]
		[Cpp2IlInjected.Address(RVA = "0x4863E4", Offset = "0x4863E4", VA = "0x4863E4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000420")]
	public static bool anglerQuestFinished
	{
		[Cpp2IlInjected.Token(Token = "0x6001BCB")]
		[Cpp2IlInjected.Address(RVA = "0x486464", Offset = "0x486464", VA = "0x486464")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BCC")]
		[Cpp2IlInjected.Address(RVA = "0x4864E0", Offset = "0x4864E0", VA = "0x4864E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000421")]
	public static GolfState LocalGolfState
	{
		[Cpp2IlInjected.Token(Token = "0x6001BCD")]
		[Cpp2IlInjected.Address(RVA = "0x486560", Offset = "0x486560", VA = "0x486560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BCE")]
		[Cpp2IlInjected.Address(RVA = "0x4865DC", Offset = "0x4865DC", VA = "0x4865DC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000422")]
	public static DroneCameraTracker DroneCameraTracker
	{
		[Cpp2IlInjected.Token(Token = "0x6001BCF")]
		[Cpp2IlInjected.Address(RVA = "0x48665C", Offset = "0x48665C", VA = "0x48665C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BD0")]
		[Cpp2IlInjected.Address(RVA = "0x4866D8", Offset = "0x4866D8", VA = "0x4866D8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000423")]
	public static bool InGuideCraftMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6001BD1")]
		[Cpp2IlInjected.Address(RVA = "0x486758", Offset = "0x486758", VA = "0x486758")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BD2")]
		[Cpp2IlInjected.Address(RVA = "0x4867D4", Offset = "0x4867D4", VA = "0x4867D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000424")]
	public static bool InReforgeMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6001BD3")]
		[Cpp2IlInjected.Address(RVA = "0x486854", Offset = "0x486854", VA = "0x486854")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BD4")]
		[Cpp2IlInjected.Address(RVA = "0x4868D0", Offset = "0x4868D0", VA = "0x4868D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000425")]
	public static bool gameMenu
	{
		[Cpp2IlInjected.Token(Token = "0x6001BD5")]
		[Cpp2IlInjected.Address(RVA = "0x486950", Offset = "0x486950", VA = "0x486950")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BD6")]
		[Cpp2IlInjected.Address(RVA = "0x4869CC", Offset = "0x4869CC", VA = "0x4869CC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000426")]
	public static List<PlayerFileData> PlayerList
	{
		[Cpp2IlInjected.Token(Token = "0x6001BD7")]
		[Cpp2IlInjected.Address(RVA = "0x486A4C", Offset = "0x486A4C", VA = "0x486A4C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BD8")]
		[Cpp2IlInjected.Address(RVA = "0x486AC8", Offset = "0x486AC8", VA = "0x486AC8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000427")]
	public static PlayerFileData ActivePlayerFileData
	{
		[Cpp2IlInjected.Token(Token = "0x6001BD9")]
		[Cpp2IlInjected.Address(RVA = "0x486B48", Offset = "0x486B48", VA = "0x486B48")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BDA")]
		[Cpp2IlInjected.Address(RVA = "0x486BC4", Offset = "0x486BC4", VA = "0x486BC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000428")]
	public static Player PendingPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001BDB")]
		[Cpp2IlInjected.Address(RVA = "0x486C44", Offset = "0x486C44", VA = "0x486C44")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BDC")]
		[Cpp2IlInjected.Address(RVA = "0x486CC0", Offset = "0x486CC0", VA = "0x486CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000429")]
	public static string WorldPath
	{
		[Cpp2IlInjected.Token(Token = "0x6001BDD")]
		[Cpp2IlInjected.Address(RVA = "0x486D40", Offset = "0x486D40", VA = "0x486D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042A")]
	public static string PlayerPath
	{
		[Cpp2IlInjected.Token(Token = "0x6001BDE")]
		[Cpp2IlInjected.Address(RVA = "0x48706C", Offset = "0x48706C", VA = "0x48706C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042B")]
	public static string OldPlayerPath
	{
		[Cpp2IlInjected.Token(Token = "0x6001BDF")]
		[Cpp2IlInjected.Address(RVA = "0x487128", Offset = "0x487128", VA = "0x487128")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042C")]
	public static string OldWorldPath
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE0")]
		[Cpp2IlInjected.Address(RVA = "0x4872F4", Offset = "0x4872F4", VA = "0x4872F4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042D")]
	private static Preferences _configuration
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE1")]
		[Cpp2IlInjected.Address(RVA = "0x4873E4", Offset = "0x4873E4", VA = "0x4873E4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BE2")]
		[Cpp2IlInjected.Address(RVA = "0x487460", Offset = "0x487460", VA = "0x487460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042E")]
	public static Preferences Configuration
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE3")]
		[Cpp2IlInjected.Address(RVA = "0x4874E0", Offset = "0x4874E0", VA = "0x4874E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700042F")]
	private static Preferences _inputProfiles
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE4")]
		[Cpp2IlInjected.Address(RVA = "0x487658", Offset = "0x487658", VA = "0x487658")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001BE5")]
		[Cpp2IlInjected.Address(RVA = "0x4876D4", Offset = "0x4876D4", VA = "0x4876D4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000430")]
	public static Preferences InputProfiles
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE6")]
		[Cpp2IlInjected.Address(RVA = "0x487754", Offset = "0x487754", VA = "0x487754")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000431")]
	public static bool invasionProgressNearInvasion
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE7")]
		[Cpp2IlInjected.Address(RVA = "0x4878CC", Offset = "0x4878CC", VA = "0x4878CC")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BE8")]
		[Cpp2IlInjected.Address(RVA = "0x487948", Offset = "0x487948", VA = "0x487948")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000432")]
	public static int invasionProgressMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001BE9")]
		[Cpp2IlInjected.Address(RVA = "0x4879C8", Offset = "0x4879C8", VA = "0x4879C8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BEA")]
		[Cpp2IlInjected.Address(RVA = "0x487A44", Offset = "0x487A44", VA = "0x487A44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000433")]
	public static bool cSmartCursorModeIsToggleAndNotHold
	{
		[Cpp2IlInjected.Token(Token = "0x6001BEB")]
		[Cpp2IlInjected.Address(RVA = "0x487AC4", Offset = "0x487AC4", VA = "0x487AC4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BEC")]
		[Cpp2IlInjected.Address(RVA = "0x487B40", Offset = "0x487B40", VA = "0x487B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000434")]
	public static bool SmartCursorShowing
	{
		[Cpp2IlInjected.Token(Token = "0x6001BED")]
		[Cpp2IlInjected.Address(RVA = "0x487BC0", Offset = "0x487BC0", VA = "0x487BC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BEE")]
		[Cpp2IlInjected.Address(RVA = "0x487C3C", Offset = "0x487C3C", VA = "0x487C3C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000435")]
	public static int SmartCursorX
	{
		[Cpp2IlInjected.Token(Token = "0x6001BEF")]
		[Cpp2IlInjected.Address(RVA = "0x487CBC", Offset = "0x487CBC", VA = "0x487CBC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BF0")]
		[Cpp2IlInjected.Address(RVA = "0x487D38", Offset = "0x487D38", VA = "0x487D38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000436")]
	public static int SmartCursorY
	{
		[Cpp2IlInjected.Token(Token = "0x6001BF1")]
		[Cpp2IlInjected.Address(RVA = "0x487DB8", Offset = "0x487DB8", VA = "0x487DB8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BF2")]
		[Cpp2IlInjected.Address(RVA = "0x487E34", Offset = "0x487E34", VA = "0x487E34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000437")]
	public static bool SmartInteractShowingGenuine
	{
		[Cpp2IlInjected.Token(Token = "0x6001BF3")]
		[Cpp2IlInjected.Address(RVA = "0x487EB4", Offset = "0x487EB4", VA = "0x487EB4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BF4")]
		[Cpp2IlInjected.Address(RVA = "0x487F30", Offset = "0x487F30", VA = "0x487F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000438")]
	public static bool SmartInteractShowingFake
	{
		[Cpp2IlInjected.Token(Token = "0x6001BF5")]
		[Cpp2IlInjected.Address(RVA = "0x487FB0", Offset = "0x487FB0", VA = "0x487FB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BF6")]
		[Cpp2IlInjected.Address(RVA = "0x48802C", Offset = "0x48802C", VA = "0x48802C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000439")]
	public static int SmartInteractX
	{
		[Cpp2IlInjected.Token(Token = "0x6001BF7")]
		[Cpp2IlInjected.Address(RVA = "0x4880AC", Offset = "0x4880AC", VA = "0x4880AC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BF8")]
		[Cpp2IlInjected.Address(RVA = "0x488128", Offset = "0x488128", VA = "0x488128")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700043A")]
	public static int SmartInteractY
	{
		[Cpp2IlInjected.Token(Token = "0x6001BF9")]
		[Cpp2IlInjected.Address(RVA = "0x4881A8", Offset = "0x4881A8", VA = "0x4881A8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BFA")]
		[Cpp2IlInjected.Address(RVA = "0x488224", Offset = "0x488224", VA = "0x488224")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700043B")]
	public static int SmartInteractNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6001BFB")]
		[Cpp2IlInjected.Address(RVA = "0x4882A4", Offset = "0x4882A4", VA = "0x4882A4")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BFC")]
		[Cpp2IlInjected.Address(RVA = "0x488320", Offset = "0x488320", VA = "0x488320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700043C")]
	public static int SmartInteractProj
	{
		[Cpp2IlInjected.Token(Token = "0x6001BFD")]
		[Cpp2IlInjected.Address(RVA = "0x4883A0", Offset = "0x4883A0", VA = "0x4883A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001BFE")]
		[Cpp2IlInjected.Address(RVA = "0x48841C", Offset = "0x48841C", VA = "0x48841C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700043D")]
	public static bool SmartInteractPotionOfReturn
	{
		[Cpp2IlInjected.Token(Token = "0x6001BFF")]
		[Cpp2IlInjected.Address(RVA = "0x48849C", Offset = "0x48849C", VA = "0x48849C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C00")]
		[Cpp2IlInjected.Address(RVA = "0x488518", Offset = "0x488518", VA = "0x488518")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700043E")]
	public static Dictionary<int, bool> SmartInteractTileCoords
	{
		[Cpp2IlInjected.Token(Token = "0x6001C01")]
		[Cpp2IlInjected.Address(RVA = "0x488598", Offset = "0x488598", VA = "0x488598")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001C02")]
		[Cpp2IlInjected.Address(RVA = "0x488614", Offset = "0x488614", VA = "0x488614")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700043F")]
	public static Dictionary<int, bool> SmartInteractTileCoordsSelected
	{
		[Cpp2IlInjected.Token(Token = "0x6001C03")]
		[Cpp2IlInjected.Address(RVA = "0x488694", Offset = "0x488694", VA = "0x488694")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001C04")]
		[Cpp2IlInjected.Address(RVA = "0x488710", Offset = "0x488710", VA = "0x488710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000440")]
	public static int TileInteractionLX
	{
		[Cpp2IlInjected.Token(Token = "0x6001C05")]
		[Cpp2IlInjected.Address(RVA = "0x488790", Offset = "0x488790", VA = "0x488790")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C06")]
		[Cpp2IlInjected.Address(RVA = "0x48880C", Offset = "0x48880C", VA = "0x48880C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000441")]
	public static int TileInteractionLY
	{
		[Cpp2IlInjected.Token(Token = "0x6001C07")]
		[Cpp2IlInjected.Address(RVA = "0x48888C", Offset = "0x48888C", VA = "0x48888C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C08")]
		[Cpp2IlInjected.Address(RVA = "0x488908", Offset = "0x488908", VA = "0x488908")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000442")]
	public static int TileInteractionHX
	{
		[Cpp2IlInjected.Token(Token = "0x6001C09")]
		[Cpp2IlInjected.Address(RVA = "0x488988", Offset = "0x488988", VA = "0x488988")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C0A")]
		[Cpp2IlInjected.Address(RVA = "0x488A04", Offset = "0x488A04", VA = "0x488A04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000443")]
	public static int TileInteractionHY
	{
		[Cpp2IlInjected.Token(Token = "0x6001C0B")]
		[Cpp2IlInjected.Address(RVA = "0x488A84", Offset = "0x488A84", VA = "0x488A84")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C0C")]
		[Cpp2IlInjected.Address(RVA = "0x488B00", Offset = "0x488B00", VA = "0x488B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000444")]
	public static int cursorOverride
	{
		[Cpp2IlInjected.Token(Token = "0x6001C0D")]
		[Cpp2IlInjected.Address(RVA = "0x488B80", Offset = "0x488B80", VA = "0x488B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C0E")]
		[Cpp2IlInjected.Address(RVA = "0x488BFC", Offset = "0x488BFC", VA = "0x488BFC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000445")]
	public static int signHover
	{
		[Cpp2IlInjected.Token(Token = "0x6001C0F")]
		[Cpp2IlInjected.Address(RVA = "0x488C7C", Offset = "0x488C7C", VA = "0x488C7C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C10")]
		[Cpp2IlInjected.Address(RVA = "0x488CF8", Offset = "0x488CF8", VA = "0x488CF8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000446")]
	public static int lastSignHover
	{
		[Cpp2IlInjected.Token(Token = "0x6001C11")]
		[Cpp2IlInjected.Address(RVA = "0x488D78", Offset = "0x488D78", VA = "0x488D78")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C12")]
		[Cpp2IlInjected.Address(RVA = "0x488DF4", Offset = "0x488DF4", VA = "0x488DF4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000447")]
	public static Color mouseColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C13")]
		[Cpp2IlInjected.Address(RVA = "0x488E74", Offset = "0x488E74", VA = "0x488E74")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C14")]
		[Cpp2IlInjected.Address(RVA = "0x488EF0", Offset = "0x488EF0", VA = "0x488EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000448")]
	public static Color ControllerColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C15")]
		[Cpp2IlInjected.Address(RVA = "0x488F70", Offset = "0x488F70", VA = "0x488F70")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C16")]
		[Cpp2IlInjected.Address(RVA = "0x488FEC", Offset = "0x488FEC", VA = "0x488FEC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000449")]
	public static Color ControllerBorderColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C17")]
		[Cpp2IlInjected.Address(RVA = "0x48906C", Offset = "0x48906C", VA = "0x48906C")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C18")]
		[Cpp2IlInjected.Address(RVA = "0x4890E8", Offset = "0x4890E8", VA = "0x4890E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700044A")]
	public static Color MouseBorderColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C19")]
		[Cpp2IlInjected.Address(RVA = "0x489168", Offset = "0x489168", VA = "0x489168")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C1A")]
		[Cpp2IlInjected.Address(RVA = "0x4891E4", Offset = "0x4891E4", VA = "0x4891E4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700044B")]
	public static Color cursorColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C1B")]
		[Cpp2IlInjected.Address(RVA = "0x489264", Offset = "0x489264", VA = "0x489264")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C1C")]
		[Cpp2IlInjected.Address(RVA = "0x4892E0", Offset = "0x4892E0", VA = "0x4892E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700044C")]
	public static int cursorColorDirection
	{
		[Cpp2IlInjected.Token(Token = "0x6001C1D")]
		[Cpp2IlInjected.Address(RVA = "0x489360", Offset = "0x489360", VA = "0x489360")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C1E")]
		[Cpp2IlInjected.Address(RVA = "0x4893DC", Offset = "0x4893DC", VA = "0x4893DC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700044D")]
	public static float cursorAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001C1F")]
		[Cpp2IlInjected.Address(RVA = "0x48945C", Offset = "0x48945C", VA = "0x48945C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C20")]
		[Cpp2IlInjected.Address(RVA = "0x4894D8", Offset = "0x4894D8", VA = "0x4894D8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700044E")]
	public static float cursorScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001C21")]
		[Cpp2IlInjected.Address(RVA = "0x489564", Offset = "0x489564", VA = "0x489564")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C22")]
		[Cpp2IlInjected.Address(RVA = "0x4895E0", Offset = "0x4895E0", VA = "0x4895E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700044F")]
	public static bool signBubble
	{
		[Cpp2IlInjected.Token(Token = "0x6001C23")]
		[Cpp2IlInjected.Address(RVA = "0x48966C", Offset = "0x48966C", VA = "0x48966C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C24")]
		[Cpp2IlInjected.Address(RVA = "0x4896E8", Offset = "0x4896E8", VA = "0x4896E8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000450")]
	public static int signX
	{
		[Cpp2IlInjected.Token(Token = "0x6001C25")]
		[Cpp2IlInjected.Address(RVA = "0x489768", Offset = "0x489768", VA = "0x489768")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C26")]
		[Cpp2IlInjected.Address(RVA = "0x4897E4", Offset = "0x4897E4", VA = "0x4897E4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000451")]
	public static int signY
	{
		[Cpp2IlInjected.Token(Token = "0x6001C27")]
		[Cpp2IlInjected.Address(RVA = "0x489864", Offset = "0x489864", VA = "0x489864")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C28")]
		[Cpp2IlInjected.Address(RVA = "0x4898E0", Offset = "0x4898E0", VA = "0x4898E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000452")]
	public static bool SettingsSavePending
	{
		[Cpp2IlInjected.Token(Token = "0x6001C29")]
		[Cpp2IlInjected.Address(RVA = "0x489960", Offset = "0x489960", VA = "0x489960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C2A")]
		[Cpp2IlInjected.Address(RVA = "0x4899DC", Offset = "0x4899DC", VA = "0x4899DC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000453")]
	public static int menuMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001C2B")]
		[Cpp2IlInjected.Address(RVA = "0x489A5C", Offset = "0x489A5C", VA = "0x489A5C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C2C")]
		[Cpp2IlInjected.Address(RVA = "0x489AD8", Offset = "0x489AD8", VA = "0x489AD8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000454")]
	public static bool Quitting
	{
		[Cpp2IlInjected.Token(Token = "0x6001C2D")]
		[Cpp2IlInjected.Address(RVA = "0x489B58", Offset = "0x489B58", VA = "0x489B58")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C2E")]
		[Cpp2IlInjected.Address(RVA = "0x489BD4", Offset = "0x489BD4", VA = "0x489BD4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000455")]
	public static int overloadedMousePositionX
	{
		[Cpp2IlInjected.Token(Token = "0x6001C2F")]
		[Cpp2IlInjected.Address(RVA = "0x489C54", Offset = "0x489C54", VA = "0x489C54")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C30")]
		[Cpp2IlInjected.Address(RVA = "0x489CD0", Offset = "0x489CD0", VA = "0x489CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000456")]
	public static int overloadedMousePositionY
	{
		[Cpp2IlInjected.Token(Token = "0x6001C31")]
		[Cpp2IlInjected.Address(RVA = "0x489D50", Offset = "0x489D50", VA = "0x489D50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C32")]
		[Cpp2IlInjected.Address(RVA = "0x489DCC", Offset = "0x489DCC", VA = "0x489DCC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000457")]
	public static bool HoveringOverAnNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6001C33")]
		[Cpp2IlInjected.Address(RVA = "0x489E4C", Offset = "0x489E4C", VA = "0x489E4C")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C34")]
		[Cpp2IlInjected.Address(RVA = "0x489EC8", Offset = "0x489EC8", VA = "0x489EC8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000458")]
	private static int rare
	{
		[Cpp2IlInjected.Token(Token = "0x6001C35")]
		[Cpp2IlInjected.Address(RVA = "0x489F48", Offset = "0x489F48", VA = "0x489F48")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C36")]
		[Cpp2IlInjected.Address(RVA = "0x489FC4", Offset = "0x489FC4", VA = "0x489FC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000459")]
	public static int hairStart
	{
		[Cpp2IlInjected.Token(Token = "0x6001C37")]
		[Cpp2IlInjected.Address(RVA = "0x48A044", Offset = "0x48A044", VA = "0x48A044")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C38")]
		[Cpp2IlInjected.Address(RVA = "0x48A0C0", Offset = "0x48A0C0", VA = "0x48A0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700045A")]
	public static int oldHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6001C39")]
		[Cpp2IlInjected.Address(RVA = "0x48A140", Offset = "0x48A140", VA = "0x48A140")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C3A")]
		[Cpp2IlInjected.Address(RVA = "0x48A1BC", Offset = "0x48A1BC", VA = "0x48A1BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700045B")]
	public static Color oldHairColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C3B")]
		[Cpp2IlInjected.Address(RVA = "0x48A23C", Offset = "0x48A23C", VA = "0x48A23C")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C3C")]
		[Cpp2IlInjected.Address(RVA = "0x48A2B8", Offset = "0x48A2B8", VA = "0x48A2B8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700045C")]
	public static int selClothes
	{
		[Cpp2IlInjected.Token(Token = "0x6001C3D")]
		[Cpp2IlInjected.Address(RVA = "0x48A338", Offset = "0x48A338", VA = "0x48A338")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C3E")]
		[Cpp2IlInjected.Address(RVA = "0x48A3B4", Offset = "0x48A3B4", VA = "0x48A3B4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700045D")]
	public static Color[] oldClothesColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C3F")]
		[Cpp2IlInjected.Address(RVA = "0x48A434", Offset = "0x48A434", VA = "0x48A434")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001C40")]
		[Cpp2IlInjected.Address(RVA = "0x48A4B0", Offset = "0x48A4B0", VA = "0x48A4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700045E")]
	public static int oldClothesStyle
	{
		[Cpp2IlInjected.Token(Token = "0x6001C41")]
		[Cpp2IlInjected.Address(RVA = "0x48A530", Offset = "0x48A530", VA = "0x48A530")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C42")]
		[Cpp2IlInjected.Address(RVA = "0x48A5AC", Offset = "0x48A5AC", VA = "0x48A5AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700045F")]
	public static int interactedDresserTopLeftX
	{
		[Cpp2IlInjected.Token(Token = "0x6001C43")]
		[Cpp2IlInjected.Address(RVA = "0x48A62C", Offset = "0x48A62C", VA = "0x48A62C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C44")]
		[Cpp2IlInjected.Address(RVA = "0x48A6A8", Offset = "0x48A6A8", VA = "0x48A6A8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000460")]
	public static int interactedDresserTopLeftY
	{
		[Cpp2IlInjected.Token(Token = "0x6001C45")]
		[Cpp2IlInjected.Address(RVA = "0x48A728", Offset = "0x48A728", VA = "0x48A728")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C46")]
		[Cpp2IlInjected.Address(RVA = "0x48A7A4", Offset = "0x48A7A4", VA = "0x48A7A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000461")]
	public static Player dresserInterfaceDummy
	{
		[Cpp2IlInjected.Token(Token = "0x6001C47")]
		[Cpp2IlInjected.Address(RVA = "0x48A824", Offset = "0x48A824", VA = "0x48A824")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001C48")]
		[Cpp2IlInjected.Address(RVA = "0x48A8A0", Offset = "0x48A8A0", VA = "0x48A8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000462")]
	private static bool _MouseOversCanClear
	{
		[Cpp2IlInjected.Token(Token = "0x6001C49")]
		[Cpp2IlInjected.Address(RVA = "0x48A920", Offset = "0x48A920", VA = "0x48A920")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C4A")]
		[Cpp2IlInjected.Address(RVA = "0x48A99C", Offset = "0x48A99C", VA = "0x48A99C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000463")]
	private static Vector2 _itemIconCacheScreenPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6001C4B")]
		[Cpp2IlInjected.Address(RVA = "0x48AA1C", Offset = "0x48AA1C", VA = "0x48AA1C")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C4C")]
		[Cpp2IlInjected.Address(RVA = "0x48AAA8", Offset = "0x48AAA8", VA = "0x48AAA8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000464")]
	private static int _itemIconCacheSelectedItemID
	{
		[Cpp2IlInjected.Token(Token = "0x6001C4D")]
		[Cpp2IlInjected.Address(RVA = "0x48AB30", Offset = "0x48AB30", VA = "0x48AB30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C4E")]
		[Cpp2IlInjected.Address(RVA = "0x48ABAC", Offset = "0x48ABAC", VA = "0x48ABAC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000465")]
	private static int _itemIconCacheTime
	{
		[Cpp2IlInjected.Token(Token = "0x6001C4F")]
		[Cpp2IlInjected.Address(RVA = "0x48AC2C", Offset = "0x48AC2C", VA = "0x48AC2C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C50")]
		[Cpp2IlInjected.Address(RVA = "0x48ACA8", Offset = "0x48ACA8", VA = "0x48ACA8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000466")]
	public static Color selColor
	{
		[Cpp2IlInjected.Token(Token = "0x6001C51")]
		[Cpp2IlInjected.Address(RVA = "0x48AD28", Offset = "0x48AD28", VA = "0x48AD28")]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C52")]
		[Cpp2IlInjected.Address(RVA = "0x48ADA4", Offset = "0x48ADA4", VA = "0x48ADA4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000467")]
	public static int bgScroll
	{
		[Cpp2IlInjected.Token(Token = "0x6001C53")]
		[Cpp2IlInjected.Address(RVA = "0x48AE24", Offset = "0x48AE24", VA = "0x48AE24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C54")]
		[Cpp2IlInjected.Address(RVA = "0x48AEA0", Offset = "0x48AEA0", VA = "0x48AEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000468")]
	public static float hBar
	{
		[Cpp2IlInjected.Token(Token = "0x6001C55")]
		[Cpp2IlInjected.Address(RVA = "0x48AF20", Offset = "0x48AF20", VA = "0x48AF20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C56")]
		[Cpp2IlInjected.Address(RVA = "0x48AF9C", Offset = "0x48AF9C", VA = "0x48AF9C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000469")]
	public static float sBar
	{
		[Cpp2IlInjected.Token(Token = "0x6001C57")]
		[Cpp2IlInjected.Address(RVA = "0x48B028", Offset = "0x48B028", VA = "0x48B028")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C58")]
		[Cpp2IlInjected.Address(RVA = "0x48B0A4", Offset = "0x48B0A4", VA = "0x48B0A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700046A")]
	public static float lBar
	{
		[Cpp2IlInjected.Token(Token = "0x6001C59")]
		[Cpp2IlInjected.Address(RVA = "0x48B130", Offset = "0x48B130", VA = "0x48B130")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C5A")]
		[Cpp2IlInjected.Address(RVA = "0x48B1AC", Offset = "0x48B1AC", VA = "0x48B1AC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700046B")]
	public static float aBar
	{
		[Cpp2IlInjected.Token(Token = "0x6001C5B")]
		[Cpp2IlInjected.Address(RVA = "0x48B238", Offset = "0x48B238", VA = "0x48B238")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C5C")]
		[Cpp2IlInjected.Address(RVA = "0x48B2B4", Offset = "0x48B2B4", VA = "0x48B2B4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700046C")]
	public static float GamepadCursorAlpha
	{
		[Cpp2IlInjected.Token(Token = "0x6001C5D")]
		[Cpp2IlInjected.Address(RVA = "0x48B340", Offset = "0x48B340", VA = "0x48B340")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C5E")]
		[Cpp2IlInjected.Address(RVA = "0x48B3BC", Offset = "0x48B3BC", VA = "0x48B3BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700046D")]
	public static bool CanUpdateGameplay
	{
		[Cpp2IlInjected.Token(Token = "0x6001C5F")]
		[Cpp2IlInjected.Address(RVA = "0x48B448", Offset = "0x48B448", VA = "0x48B448")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C60")]
		[Cpp2IlInjected.Address(RVA = "0x48B4C0", Offset = "0x48B4C0", VA = "0x48B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700046E")]
	public static Vector2 ViewPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6001C62")]
		[Cpp2IlInjected.Address(RVA = "0x48B60C", Offset = "0x48B60C", VA = "0x48B60C")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700046F")]
	public static Vector2 ViewSize
	{
		[Cpp2IlInjected.Token(Token = "0x6001C63")]
		[Cpp2IlInjected.Address(RVA = "0x48B6EC", Offset = "0x48B6EC", VA = "0x48B6EC")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000470")]
	public static Matrix CurrentWantedZoomMatrix
	{
		[Cpp2IlInjected.Token(Token = "0x6001C64")]
		[Cpp2IlInjected.Address(RVA = "0x48B7F8", Offset = "0x48B7F8", VA = "0x48B7F8")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000471")]
	public static Matrix UIScaleMatrix
	{
		[Cpp2IlInjected.Token(Token = "0x6001C66")]
		[Cpp2IlInjected.Address(RVA = "0x48B9B0", Offset = "0x48B9B0", VA = "0x48B9B0")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000472")]
	public static float UIScaleWanted
	{
		[Cpp2IlInjected.Token(Token = "0x6001C67")]
		[Cpp2IlInjected.Address(RVA = "0x48BA44", Offset = "0x48BA44", VA = "0x48BA44")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000473")]
	public static float UIScale
	{
		[Cpp2IlInjected.Token(Token = "0x6001C68")]
		[Cpp2IlInjected.Address(RVA = "0x48BABC", Offset = "0x48BABC", VA = "0x48BABC")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C69")]
		[Cpp2IlInjected.Address(RVA = "0x48BB34", Offset = "0x48BB34", VA = "0x48BB34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000474")]
	public float UIScaleMax
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6A")]
		[Cpp2IlInjected.Address(RVA = "0x48BCA4", Offset = "0x48BCA4", VA = "0x48BCA4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000475")]
	public static bool RenderTargetsRequired
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6B")]
		[Cpp2IlInjected.Address(RVA = "0x48BE48", Offset = "0x48BE48", VA = "0x48BE48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000476")]
	public static bool IsItRaining
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6C")]
		[Cpp2IlInjected.Address(RVA = "0x48BF38", Offset = "0x48BF38", VA = "0x48BF38")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000477")]
	public static bool ThickMouse
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6D")]
		[Cpp2IlInjected.Address(RVA = "0x48BFC0", Offset = "0x48BFC0", VA = "0x48BFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000478")]
	public static bool GamepadDisableCursorItemIcon
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6E")]
		[Cpp2IlInjected.Address(RVA = "0x48C078", Offset = "0x48C078", VA = "0x48C078")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000479")]
	public static string SavePath
	{
		[Cpp2IlInjected.Token(Token = "0x6001C6F")]
		[Cpp2IlInjected.Address(RVA = "0x486DFC", Offset = "0x486DFC", VA = "0x486DFC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700047A")]
	public static string OldSavePath
	{
		[Cpp2IlInjected.Token(Token = "0x6001C70")]
		[Cpp2IlInjected.Address(RVA = "0x487218", Offset = "0x487218", VA = "0x487218")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700047B")]
	public static GameModeData GameModeInfo
	{
		[Cpp2IlInjected.Token(Token = "0x6001C72")]
		[Cpp2IlInjected.Address(RVA = "0x48C2AC", Offset = "0x48C2AC", VA = "0x48C2AC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700047C")]
	public static int GameMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001C73")]
		[Cpp2IlInjected.Address(RVA = "0x48C324", Offset = "0x48C324", VA = "0x48C324")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C74")]
		[Cpp2IlInjected.Address(RVA = "0x48C3D8", Offset = "0x48C3D8", VA = "0x48C3D8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700047D")]
	public static bool specialSeedWorld
	{
		[Cpp2IlInjected.Token(Token = "0x6001C75")]
		[Cpp2IlInjected.Address(RVA = "0x48C4F4", Offset = "0x48C4F4", VA = "0x48C4F4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700047E")]
	public static bool masterMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001C76")]
		[Cpp2IlInjected.Address(RVA = "0x48C6CC", Offset = "0x48C6CC", VA = "0x48C6CC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700047F")]
	public static bool expertMode
	{
		[Cpp2IlInjected.Token(Token = "0x6001C77")]
		[Cpp2IlInjected.Address(RVA = "0x48C874", Offset = "0x48C874", VA = "0x48C874")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000480")]
	public static AchievementManager Achievements
	{
		[Cpp2IlInjected.Token(Token = "0x6001C79")]
		[Cpp2IlInjected.Address(RVA = "0x48CBAC", Offset = "0x48CBAC", VA = "0x48CBAC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000481")]
	public WaterfallManager waterfallManager
	{
		[Cpp2IlInjected.Token(Token = "0x6001C7A")]
		[Cpp2IlInjected.Address(RVA = "0x48CC28", Offset = "0x48CC28", VA = "0x48CC28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001C7B")]
		[Cpp2IlInjected.Address(RVA = "0x48CCA8", Offset = "0x48CCA8", VA = "0x48CCA8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000482")]
	public static ulong UnpausedUpdateSeed
	{
		[Cpp2IlInjected.Token(Token = "0x6001C7C")]
		[Cpp2IlInjected.Address(RVA = "0x48CD28", Offset = "0x48CD28", VA = "0x48CD28")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C7D")]
		[Cpp2IlInjected.Address(RVA = "0x48CDA4", Offset = "0x48CDA4", VA = "0x48CDA4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000483")]
	public static Effect screenShader
	{
		[Cpp2IlInjected.Token(Token = "0x6001C7E")]
		[Cpp2IlInjected.Address(RVA = "0x48CE28", Offset = "0x48CE28", VA = "0x48CE28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000484")]
	public static Effect pixelShader
	{
		[Cpp2IlInjected.Token(Token = "0x6001C7F")]
		[Cpp2IlInjected.Address(RVA = "0x48CEA4", Offset = "0x48CEA4", VA = "0x48CEA4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000485")]
	public static Effect vertexPixelShader
	{
		[Cpp2IlInjected.Token(Token = "0x6001C80")]
		[Cpp2IlInjected.Address(RVA = "0x48CF20", Offset = "0x48CF20", VA = "0x48CF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000486")]
	public static Effect tileShader
	{
		[Cpp2IlInjected.Token(Token = "0x6001C81")]
		[Cpp2IlInjected.Address(RVA = "0x48CF9C", Offset = "0x48CF9C", VA = "0x48CF9C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000487")]
	[Obsolete]
	public static Matrix Transform
	{
		[Cpp2IlInjected.Token(Token = "0x6001C84")]
		[Cpp2IlInjected.Address(RVA = "0x48D130", Offset = "0x48D130", VA = "0x48D130")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000488")]
	public static Vector2 MouseScreen
	{
		[Cpp2IlInjected.Token(Token = "0x6001C85")]
		[Cpp2IlInjected.Address(RVA = "0x48D1B8", Offset = "0x48D1B8", VA = "0x48D1B8")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000489")]
	public static Vector2 MouseWorld
	{
		[Cpp2IlInjected.Token(Token = "0x6001C86")]
		[Cpp2IlInjected.Address(RVA = "0x48D264", Offset = "0x48D264", VA = "0x48D264")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700048A")]
	public static Vector2 MouseWorld2
	{
		[Cpp2IlInjected.Token(Token = "0x6001C87")]
		[Cpp2IlInjected.Address(RVA = "0x48D3D0", Offset = "0x48D3D0", VA = "0x48D3D0")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700048B")]
	public static INetDiagnosticsUI ActiveNetDiagnosticsUI
	{
		[Cpp2IlInjected.Token(Token = "0x6001C8B")]
		[Cpp2IlInjected.Address(RVA = "0x48D844", Offset = "0x48D844", VA = "0x48D844")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700048C")]
	public int mouseNPCIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6001C8C")]
		[Cpp2IlInjected.Address(RVA = "0x48D98C", Offset = "0x48D98C", VA = "0x48D98C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C8D")]
		[Cpp2IlInjected.Address(RVA = "0x48DA08", Offset = "0x48DA08", VA = "0x48DA08")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700048D")]
	public int mouseNPCType
	{
		[Cpp2IlInjected.Token(Token = "0x6001C8E")]
		[Cpp2IlInjected.Address(RVA = "0x48DA88", Offset = "0x48DA88", VA = "0x48DA88")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001C8F")]
		[Cpp2IlInjected.Address(RVA = "0x48DB04", Offset = "0x48DB04", VA = "0x48DB04")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700048E")]
	public static uint GameUpdateCount
	{
		[Cpp2IlInjected.Token(Token = "0x6001C98")]
		[Cpp2IlInjected.Address(RVA = "0x48E21C", Offset = "0x48E21C", VA = "0x48E21C")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700048F")]
	private int firstTileX
	{
		[Cpp2IlInjected.Token(Token = "0x6001CA7")]
		[Cpp2IlInjected.Address(RVA = "0x48F17C", Offset = "0x48F17C", VA = "0x48F17C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CA8")]
		[Cpp2IlInjected.Address(RVA = "0x48F1F8", Offset = "0x48F1F8", VA = "0x48F1F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000490")]
	private int lastTileX
	{
		[Cpp2IlInjected.Token(Token = "0x6001CA9")]
		[Cpp2IlInjected.Address(RVA = "0x48F278", Offset = "0x48F278", VA = "0x48F278")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CAA")]
		[Cpp2IlInjected.Address(RVA = "0x48F2F4", Offset = "0x48F2F4", VA = "0x48F2F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000491")]
	private int firstTileY
	{
		[Cpp2IlInjected.Token(Token = "0x6001CAB")]
		[Cpp2IlInjected.Address(RVA = "0x48F374", Offset = "0x48F374", VA = "0x48F374")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CAC")]
		[Cpp2IlInjected.Address(RVA = "0x48F3F0", Offset = "0x48F3F0", VA = "0x48F3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000492")]
	private int lastTileY
	{
		[Cpp2IlInjected.Token(Token = "0x6001CAD")]
		[Cpp2IlInjected.Address(RVA = "0x48F470", Offset = "0x48F470", VA = "0x48F470")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CAE")]
		[Cpp2IlInjected.Address(RVA = "0x48F4EC", Offset = "0x48F4EC", VA = "0x48F4EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000493")]
	public static SamplerState DefaultSamplerState
	{
		[Cpp2IlInjected.Token(Token = "0x6001CB4")]
		[Cpp2IlInjected.Address(RVA = "0x48F8D4", Offset = "0x48F8D4", VA = "0x48F8D4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000494")]
	public static int UnderworldLayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001CB5")]
		[Cpp2IlInjected.Address(RVA = "0x48F9C0", Offset = "0x48F9C0", VA = "0x48F9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000495")]
	public static float WindForVisuals
	{
		[Cpp2IlInjected.Token(Token = "0x6001CB7")]
		[Cpp2IlInjected.Address(RVA = "0x48FAB4", Offset = "0x48FAB4", VA = "0x48FAB4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000496")]
	public static Player LocalPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6001CBC")]
		[Cpp2IlInjected.Address(RVA = "0x48CB28", Offset = "0x48CB28", VA = "0x48CB28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000497")]
	public static CreativeUnlocksTracker LocalPlayerCreativeTracker
	{
		[Cpp2IlInjected.Token(Token = "0x6001CBD")]
		[Cpp2IlInjected.Address(RVA = "0x490E88", Offset = "0x490E88", VA = "0x490E88")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000498")]
	public static string playerPathName
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC2")]
		[Cpp2IlInjected.Address(RVA = "0x49162C", Offset = "0x49162C", VA = "0x49162C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000499")]
	public static string worldPathName
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC3")]
		[Cpp2IlInjected.Address(RVA = "0x4916A0", Offset = "0x4916A0", VA = "0x4916A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700049A")]
	public int currentNPCShowingChatBubble
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC4")]
		[Cpp2IlInjected.Address(RVA = "0x49171C", Offset = "0x49171C", VA = "0x49171C")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CC5")]
		[Cpp2IlInjected.Address(RVA = "0x491798", Offset = "0x491798", VA = "0x491798")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700049B")]
	public static bool NetClientOnly
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC6")]
		[Cpp2IlInjected.Address(RVA = "0x491818", Offset = "0x491818", VA = "0x491818")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700049C")]
	public static bool NetClient
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC7")]
		[Cpp2IlInjected.Address(RVA = "0x49189C", Offset = "0x49189C", VA = "0x49189C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700049D")]
	public static bool LogicHost
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC8")]
		[Cpp2IlInjected.Address(RVA = "0x491918", Offset = "0x491918", VA = "0x491918")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700049E")]
	public static bool NetHostOnly
	{
		[Cpp2IlInjected.Token(Token = "0x6001CC9")]
		[Cpp2IlInjected.Address(RVA = "0x49198C", Offset = "0x49198C", VA = "0x49198C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700049F")]
	public static bool LogicClient
	{
		[Cpp2IlInjected.Token(Token = "0x6001CCA")]
		[Cpp2IlInjected.Address(RVA = "0x491A10", Offset = "0x491A10", VA = "0x491A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A0")]
	public static bool NetHost
	{
		[Cpp2IlInjected.Token(Token = "0x6001CCB")]
		[Cpp2IlInjected.Address(RVA = "0x491A90", Offset = "0x491A90", VA = "0x491A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A1")]
	public static bool NetClientHost
	{
		[Cpp2IlInjected.Token(Token = "0x6001CCC")]
		[Cpp2IlInjected.Address(RVA = "0x491B0C", Offset = "0x491B0C", VA = "0x491B0C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A2")]
	public static bool SmartCursorIsUsed
	{
		[Cpp2IlInjected.Token(Token = "0x6001CCD")]
		[Cpp2IlInjected.Address(RVA = "0x491B90", Offset = "0x491B90", VA = "0x491B90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CCE")]
		[Cpp2IlInjected.Address(RVA = "0x491BF4", Offset = "0x491BF4", VA = "0x491BF4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A3")]
	public static bool SmartCursorWanted
	{
		[Cpp2IlInjected.Token(Token = "0x6001CCF")]
		[Cpp2IlInjected.Address(RVA = "0x491C60", Offset = "0x491C60", VA = "0x491C60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CD0")]
		[Cpp2IlInjected.Address(RVA = "0x491CC4", Offset = "0x491CC4", VA = "0x491CC4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A4")]
	public static bool HasSmartInteractTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6001CD1")]
		[Cpp2IlInjected.Address(RVA = "0x491D30", Offset = "0x491D30", VA = "0x491D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A5")]
	public static bool Setting_Target60FPS
	{
		[Cpp2IlInjected.Token(Token = "0x6001CE2")]
		[Cpp2IlInjected.Address(RVA = "0x49B0D4", Offset = "0x49B0D4", VA = "0x49B0D4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6001CE1")]
		[Cpp2IlInjected.Address(RVA = "0x49B004", Offset = "0x49B004", VA = "0x49B004")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A6")]
	public static bool IsItAHappyWindyDay
	{
		[Cpp2IlInjected.Token(Token = "0x6001D25")]
		[Cpp2IlInjected.Address(RVA = "0x4D61A8", Offset = "0x4D61A8", VA = "0x4D61A8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A7")]
	public static bool IsItStorming
	{
		[Cpp2IlInjected.Token(Token = "0x6001D26")]
		[Cpp2IlInjected.Address(RVA = "0x4D6220", Offset = "0x4D6220", VA = "0x4D6220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A8")]
	public static bool WindyEnoughForKiteDrops
	{
		[Cpp2IlInjected.Token(Token = "0x6001D27")]
		[Cpp2IlInjected.Address(RVA = "0x4D6298", Offset = "0x4D6298", VA = "0x4D6298")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004A9")]
	public static bool HasKeyboard
	{
		[Cpp2IlInjected.Token(Token = "0x6001D68")]
		[Cpp2IlInjected.Address(RVA = "0x4F6988", Offset = "0x4F6988", VA = "0x4F6988")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004AA")]
	public static bool KeyboardIsActive
	{
		[Cpp2IlInjected.Token(Token = "0x6001D69")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A08", Offset = "0x4F6A08", VA = "0x4F6A08")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004AB")]
	public static bool ShouldPVPDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6001DE8")]
		[Cpp2IlInjected.Address(RVA = "0x5EE60C", Offset = "0x5EE60C", VA = "0x5EE60C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004AC")]
	public int RecommendedEquipmentAreaPushUp
	{
		[Cpp2IlInjected.Token(Token = "0x6001E25")]
		[Cpp2IlInjected.Address(RVA = "0x605018", Offset = "0x605018", VA = "0x605018")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004AD")]
	public static bool ShouldDrawInfoIconsHorizontally
	{
		[Cpp2IlInjected.Token(Token = "0x6001E46")]
		[Cpp2IlInjected.Address(RVA = "0x610254", Offset = "0x610254", VA = "0x610254")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004AE")]
	public static bool CanShowInfoAccs
	{
		[Cpp2IlInjected.Token(Token = "0x6001E47")]
		[Cpp2IlInjected.Address(RVA = "0x6103F0", Offset = "0x6103F0", VA = "0x6103F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004AF")]
	public static bool HasHWCursor
	{
		[Cpp2IlInjected.Token(Token = "0x6001E54")]
		[Cpp2IlInjected.Address(RVA = "0x61169C", Offset = "0x61169C", VA = "0x61169C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B0")]
	public static Point ScreenSize
	{
		[Cpp2IlInjected.Token(Token = "0x6001E5B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FA8", Offset = "0x5F9FA8", VA = "0x5F9FA8")]
		get
		{
			return default(Point);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B1")]
	private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
	{
		[Cpp2IlInjected.Token(Token = "0x6001E72")]
		[Cpp2IlInjected.Address(RVA = "0x61807C", Offset = "0x61807C", VA = "0x61807C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170004B2")]
	public static bool IsGraphicsDeviceAvailable
	{
		[Cpp2IlInjected.Token(Token = "0x6001ED7")]
		[Cpp2IlInjected.Address(RVA = "0x6571BC", Offset = "0x6571BC", VA = "0x6571BC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public static event Action OnEnginePreload
	{
		[Cpp2IlInjected.Token(Token = "0x6001C92")]
		[Cpp2IlInjected.Address(RVA = "0x48DBBC", Offset = "0x48DBBC", VA = "0x48DBBC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001C93")]
		[Cpp2IlInjected.Address(RVA = "0x48DCD0", Offset = "0x48DCD0", VA = "0x48DCD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public static event Action<Vector2> OnResolutionChanged
	{
		[Cpp2IlInjected.Token(Token = "0x6001C94")]
		[Cpp2IlInjected.Address(RVA = "0x48DDE4", Offset = "0x48DDE4", VA = "0x48DDE4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001C95")]
		[Cpp2IlInjected.Address(RVA = "0x48DEEC", Offset = "0x48DEEC", VA = "0x48DEEC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public static event Action OnEngineLoad
	{
		[Cpp2IlInjected.Token(Token = "0x6001C96")]
		[Cpp2IlInjected.Address(RVA = "0x48DFF4", Offset = "0x48DFF4", VA = "0x48DFF4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001C97")]
		[Cpp2IlInjected.Address(RVA = "0x48E108", Offset = "0x48E108", VA = "0x48E108")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public static event Action OnTickForThirdPartySoftwareOnly
	{
		[Cpp2IlInjected.Token(Token = "0x6001C99")]
		[Cpp2IlInjected.Address(RVA = "0x48E294", Offset = "0x48E294", VA = "0x48E294")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001C9A")]
		[Cpp2IlInjected.Address(RVA = "0x48E3A8", Offset = "0x48E3A8", VA = "0x48E3A8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public static event Action OnTickForInternalCodeOnly
	{
		[Cpp2IlInjected.Token(Token = "0x6001C9B")]
		[Cpp2IlInjected.Address(RVA = "0x48E4BC", Offset = "0x48E4BC", VA = "0x48E4BC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001C9C")]
		[Cpp2IlInjected.Address(RVA = "0x48E5C4", Offset = "0x48E5C4", VA = "0x48E5C4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public static event Action<GameTime> OnPreDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6001C9D")]
		[Cpp2IlInjected.Address(RVA = "0x48E6CC", Offset = "0x48E6CC", VA = "0x48E6CC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001C9E")]
		[Cpp2IlInjected.Address(RVA = "0x48E7E0", Offset = "0x48E7E0", VA = "0x48E7E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public static event Action<GameTime> OnPostDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6001C9F")]
		[Cpp2IlInjected.Address(RVA = "0x48E8F4", Offset = "0x48E8F4", VA = "0x48E8F4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001CA0")]
		[Cpp2IlInjected.Address(RVA = "0x48EA08", Offset = "0x48EA08", VA = "0x48EA08")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public static event Action<Vector2, float> OnPostFullscreenMapDraw
	{
		[Cpp2IlInjected.Token(Token = "0x6001CA1")]
		[Cpp2IlInjected.Address(RVA = "0x48EB1C", Offset = "0x48EB1C", VA = "0x48EB1C")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001CA2")]
		[Cpp2IlInjected.Address(RVA = "0x48EC30", Offset = "0x48EC30", VA = "0x48EC30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public static event Action OnRenderTargetsReleased
	{
		[Cpp2IlInjected.Token(Token = "0x6001CA3")]
		[Cpp2IlInjected.Address(RVA = "0x48ED44", Offset = "0x48ED44", VA = "0x48ED44")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001CA4")]
		[Cpp2IlInjected.Address(RVA = "0x48EE4C", Offset = "0x48EE4C", VA = "0x48EE4C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public static event ResolutionChangeEvent OnRenderTargetsInitialized
	{
		[Cpp2IlInjected.Token(Token = "0x6001CA5")]
		[Cpp2IlInjected.Address(RVA = "0x48EF54", Offset = "0x48EF54", VA = "0x48EF54")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6001CA6")]
		[Cpp2IlInjected.Address(RVA = "0x48F068", Offset = "0x48F068", VA = "0x48F068")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001C61")]
	[Cpp2IlInjected.Address(RVA = "0x48B53C", Offset = "0x48B53C", VA = "0x48B53C")]
	public static void ToggleGameplayUpdates(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001C65")]
	[Cpp2IlInjected.Address(RVA = "0x48B88C", Offset = "0x48B88C", VA = "0x48B88C")]
	public static void SetRecommendedZoomContext(Matrix matrix)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001C71")]
	[Cpp2IlInjected.Address(RVA = "0x48C13C", Offset = "0x48C13C", VA = "0x48C13C")]
	public static void FindAnnouncementBoxStatus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001C78")]
	[Cpp2IlInjected.Address(RVA = "0x48C9E8", Offset = "0x48C9E8", VA = "0x48C9E8")]
	public static bool CanPlayCreditsRoll()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001C82")]
	[Cpp2IlInjected.Address(RVA = "0x48D018", Offset = "0x48D018", VA = "0x48D018")]
	public static void SetCameraLerp(float lerp, int time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001C83")]
	[Cpp2IlInjected.Address(RVA = "0x48D0C0", Offset = "0x48D0C0", VA = "0x48D0C0")]
	public static void SetCameraGamepadLerp(float lerp)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001C88")]
	[Cpp2IlInjected.Address(RVA = "0x48D564", Offset = "0x48D564", VA = "0x48D564")]
	public static Vector2 ReverseGravitySupport(Vector2 pos, float height = 0f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001C89")]
	[Cpp2IlInjected.Address(RVA = "0x48D66C", Offset = "0x48D66C", VA = "0x48D66C")]
	public static Point ReverseGravitySupport(Point pos, int height = 0)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6001C8A")]
	[Cpp2IlInjected.Address(RVA = "0x48D750", Offset = "0x48D750", VA = "0x48D750")]
	public static Rectangle ReverseGravitySupport(Rectangle box)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6001C90")]
	[Cpp2IlInjected.Address(RVA = "0x48DB84", Offset = "0x48DB84", VA = "0x48DB84")]
	public void SetMouseNPC(int index, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001C91")]
	[Cpp2IlInjected.Address(RVA = "0x48DBA0", Offset = "0x48DBA0", VA = "0x48DBA0")]
	public void SetMouseNPC_ToHousingQuery()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CAF")]
	[Cpp2IlInjected.Address(RVA = "0x48F570", Offset = "0x48F570", VA = "0x48F570")]
	private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

	[Cpp2IlInjected.Token(Token = "0x6001CB0")]
	[Cpp2IlInjected.Address(RVA = "0x48F620", Offset = "0x48F620", VA = "0x48F620")]
	private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

	[Cpp2IlInjected.Token(Token = "0x6001CB1")]
	[Cpp2IlInjected.Address(RVA = "0x48F6C8", Offset = "0x48F6C8", VA = "0x48F6C8")]
	private static extern int GetMenuItemCount(IntPtr hWnd);

	[Cpp2IlInjected.Token(Token = "0x6001CB2")]
	[Cpp2IlInjected.Address(RVA = "0x48F768", Offset = "0x48F768", VA = "0x48F768")]
	public static extern IntPtr LoadLibrary(string dllToLoad);

	[Cpp2IlInjected.Token(Token = "0x6001CB3")]
	[Cpp2IlInjected.Address(RVA = "0x48F82C", Offset = "0x48F82C", VA = "0x48F82C")]
	public static void FlushBatches()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CB6")]
	[Cpp2IlInjected.Address(RVA = "0x48FA3C", Offset = "0x48FA3C", VA = "0x48FA3C")]
	public static MoonPhase GetMoonPhase()
	{
		return default(MoonPhase);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CB8")]
	[Cpp2IlInjected.Address(RVA = "0x48FB2C", Offset = "0x48FB2C", VA = "0x48FB2C")]
	public static Vector2 DrawPlayerItemPos(float gravdir, int itemtype)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CB9")]
	[Cpp2IlInjected.Address(RVA = "0x490650", Offset = "0x490650", VA = "0x490650")]
	public static void SetupTileMerge()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CBA")]
	[Cpp2IlInjected.Address(RVA = "0x4908A8", Offset = "0x4908A8", VA = "0x4908A8")]
	public static void RegisterItemAnimation(int index, DrawAnimation animation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CBB")]
	[Cpp2IlInjected.Address(RVA = "0x4909EC", Offset = "0x4909EC", VA = "0x4909EC")]
	public static void InitializeItemAnimations()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CBE")]
	[Cpp2IlInjected.Address(RVA = "0x490F10", Offset = "0x490F10", VA = "0x490F10")]
	public static void SetGraphicsProfile(GraphicsProfile profile, bool forceSet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CBF")]
	[Cpp2IlInjected.Address(RVA = "0x490FC4", Offset = "0x490FC4", VA = "0x490FC4")]
	private static void SetGraphicsProfileInternal()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CC0")]
	[Cpp2IlInjected.Address(RVA = "0x490FC8", Offset = "0x490FC8", VA = "0x490FC8")]
	private static void TrySupporting8K()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CC1")]
	[Cpp2IlInjected.Address(RVA = "0x490FCC", Offset = "0x490FCC", VA = "0x490FCC")]
	public static void AnglerQuestSwap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD2")]
	[Cpp2IlInjected.Address(RVA = "0x491E38", Offset = "0x491E38", VA = "0x491E38")]
	public void UpdateParticleSystems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD3")]
	[Cpp2IlInjected.Address(RVA = "0x491ECC", Offset = "0x491ECC", VA = "0x491ECC")]
	public static void TrySetPreparationState(WorldPreparationState state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD4")]
	[Cpp2IlInjected.Address(RVA = "0x491F54", Offset = "0x491F54", VA = "0x491F54")]
	public static void UpdateWorldPreparationState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD5")]
	[Cpp2IlInjected.Address(RVA = "0x492268", Offset = "0x492268", VA = "0x492268")]
	public static bool InSmartCursorHighlightArea(int x, int y, out bool actuallySelected)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD6")]
	[Cpp2IlInjected.Address(RVA = "0x4923BC", Offset = "0x4923BC", VA = "0x4923BC")]
	public static byte[] Decompress(byte[] inputData, int outputSize)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD7")]
	[Cpp2IlInjected.Address(RVA = "0x4924CC", Offset = "0x4924CC", VA = "0x4924CC")]
	public static void LoadWorlds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD8")]
	[Cpp2IlInjected.Address(RVA = "0x493680", Offset = "0x493680", VA = "0x493680")]
	private static int WorldListSortMethod(WorldFileData data1, WorldFileData data2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CD9")]
	[Cpp2IlInjected.Address(RVA = "0x4936D0", Offset = "0x4936D0", VA = "0x4936D0")]
	public static void LoadPlayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CDA")]
	[Cpp2IlInjected.Address(RVA = "0x49452C", Offset = "0x49452C", VA = "0x49452C")]
	private static int PlayerListSortMethod(PlayerFileData data1, PlayerFileData data2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CDB")]
	[Cpp2IlInjected.Address(RVA = "0x49453C", Offset = "0x49453C", VA = "0x49453C")]
	public void OpenRecent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CDC")]
	[Cpp2IlInjected.Address(RVA = "0x494E58", Offset = "0x494E58", VA = "0x494E58")]
	public static void SaveRecent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CDD")]
	[Cpp2IlInjected.Address(RVA = "0x4955E4", Offset = "0x4955E4", VA = "0x4955E4")]
	public static bool SaveSettings()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CDE")]
	[Cpp2IlInjected.Address(RVA = "0x497B7C", Offset = "0x497B7C", VA = "0x497B7C")]
	protected void CheckBunny()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CDF")]
	[Cpp2IlInjected.Address(RVA = "0x497BF8", Offset = "0x497BF8", VA = "0x497BF8")]
	public void ResetSettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE0")]
	[Cpp2IlInjected.Address(RVA = "0x49AEB4", Offset = "0x49AEB4", VA = "0x49AEB4")]
	private static void TryPickingDefaultUIScale(float displayHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE3")]
	[Cpp2IlInjected.Address(RVA = "0x497E74", Offset = "0x497E74", VA = "0x497E74")]
	public void LoadSettings(bool allowLoad = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE4")]
	[Cpp2IlInjected.Address(RVA = "0x49B84C", Offset = "0x49B84C", VA = "0x49B84C")]
	protected void OpenLegacySettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE5")]
	[Cpp2IlInjected.Address(RVA = "0x49C76C", Offset = "0x49C76C", VA = "0x49C76C")]
	public static void UpdateTrialMode()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE6")]
	[Cpp2IlInjected.Address(RVA = "0x49C874", Offset = "0x49C874", VA = "0x49C874")]
	public static bool IsTrialMode()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE7")]
	[Cpp2IlInjected.Address(RVA = "0x49C8EC", Offset = "0x49C8EC", VA = "0x49C8EC")]
	public static void ErasePlayer(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE8")]
	[Cpp2IlInjected.Address(RVA = "0x49CCB4", Offset = "0x49CCB4", VA = "0x49CCB4")]
	public static void EraseWorld(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CE9")]
	[Cpp2IlInjected.Address(RVA = "0x49CFCC", Offset = "0x49CFCC", VA = "0x49CFCC")]
	public static string GetPlayerPathFromName(string playerName, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CEA")]
	[Cpp2IlInjected.Address(RVA = "0x49D688", Offset = "0x49D688", VA = "0x49D688")]
	public static string GetWorldNameFromPath(string filename)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CEB")]
	[Cpp2IlInjected.Address(RVA = "0x49D744", Offset = "0x49D744", VA = "0x49D744")]
	public static string GetPlayerNameFromPath(string filename)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CEC")]
	[Cpp2IlInjected.Address(RVA = "0x49D7EC", Offset = "0x49D7EC", VA = "0x49D7EC")]
	public static string GetWorldPathFromName(string worldName, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CED")]
	[Cpp2IlInjected.Address(RVA = "0x49DE9C", Offset = "0x49DE9C", VA = "0x49DE9C")]
	public void setServerWorldRollbacks(string rollBacksToKeep)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CEE")]
	[Cpp2IlInjected.Address(RVA = "0x49DF54", Offset = "0x49DF54", VA = "0x49DF54")]
	public void autoCreate(string worldSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CEF")]
	[Cpp2IlInjected.Address(RVA = "0x49E140", Offset = "0x49E140", VA = "0x49E140")]
	public void NewMOTD(string newMOTD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF0")]
	[Cpp2IlInjected.Address(RVA = "0x49E1BC", Offset = "0x49E1BC", VA = "0x49E1BC")]
	public static string ConvertToSafeArgument(string arg)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF1")]
	[Cpp2IlInjected.Address(RVA = "0x49E238", Offset = "0x49E238", VA = "0x49E238")]
	public static string ConvertFromSafeArgument(string arg)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF2")]
	[Cpp2IlInjected.Address(RVA = "0x49E2B4", Offset = "0x49E2B4", VA = "0x49E2B4")]
	public void LoadDedConfig(string configPath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF3")]
	[Cpp2IlInjected.Address(RVA = "0x49F6FC", Offset = "0x49F6FC", VA = "0x49F6FC")]
	public void SetNetPlayers(int mPlayers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF4")]
	[Cpp2IlInjected.Address(RVA = "0x49F778", Offset = "0x49F778", VA = "0x49F778")]
	public void SetWorld(string world, bool cloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF5")]
	[Cpp2IlInjected.Address(RVA = "0x49F838", Offset = "0x49F838", VA = "0x49F838")]
	public void SetWorldName(string world)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF6")]
	[Cpp2IlInjected.Address(RVA = "0x49F8B4", Offset = "0x49F8B4", VA = "0x49F8B4")]
	public void EnableAutoShutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF7")]
	[Cpp2IlInjected.Address(RVA = "0x49F944", Offset = "0x49F944", VA = "0x49F944")]
	public void AutoPass()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF8")]
	[Cpp2IlInjected.Address(RVA = "0x49F9C0", Offset = "0x49F9C0", VA = "0x49F9C0")]
	public void AutoJoin(string IP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CF9")]
	[Cpp2IlInjected.Address(RVA = "0x49FA94", Offset = "0x49FA94", VA = "0x49FA94")]
	public void AutoHost()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CFA")]
	[Cpp2IlInjected.Address(RVA = "0x49FBA0", Offset = "0x49FBA0", VA = "0x49FBA0")]
	public void loadLib(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CFB")]
	[Cpp2IlInjected.Address(RVA = "0x49FC28", Offset = "0x49FC28", VA = "0x49FC28")]
	public void NeverSleep()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CFC")]
	[Cpp2IlInjected.Address(RVA = "0x49FC2C", Offset = "0x49FC2C", VA = "0x49FC2C")]
	public void YouCanSleepNow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CFD")]
	[Cpp2IlInjected.Address(RVA = "0x49FC30", Offset = "0x49FC30", VA = "0x49FC30")]
	public static void RunServerCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CFE")]
	[Cpp2IlInjected.Address(RVA = "0x4A1764", Offset = "0x4A1764", VA = "0x4A1764")]
	public static void RunDedServ(string worldName, string password)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001CFF")]
	[Cpp2IlInjected.Address(RVA = "0x4A0A34", Offset = "0x4A0A34", VA = "0x4A0A34")]
	public void DedServ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D00")]
	[Cpp2IlInjected.Address(RVA = "0x4A1958", Offset = "0x4A1958", VA = "0x4A1958")]
	private static void WriteFancyWorldLoadErrorToConsole()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D01")]
	[Cpp2IlInjected.Address(RVA = "0x4A1A54", Offset = "0x4A1A54", VA = "0x4A1A54")]
	public static void startDedInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D02")]
	[Cpp2IlInjected.Address(RVA = "0x4A1B28", Offset = "0x4A1B28", VA = "0x4A1B28")]
	public static void startDedInputCallBack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D03")]
	[Cpp2IlInjected.Address(RVA = "0x4A4508", Offset = "0x4A4508", VA = "0x4A4508")]
	private static string ReadLineInput()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001D04")]
	[Cpp2IlInjected.Address(RVA = "0x4A4584", Offset = "0x4A4584", VA = "0x4A4584")]
	public static bool IsFastForwardingTime()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D05")]
	[Cpp2IlInjected.Address(RVA = "0x4A463C", Offset = "0x4A463C", VA = "0x4A463C")]
	public static void Sundialing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D06")]
	[Cpp2IlInjected.Address(RVA = "0x4A4824", Offset = "0x4A4824", VA = "0x4A4824")]
	public static void Moondialing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D07")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A0C", Offset = "0x4A4A0C", VA = "0x4A4A0C")]
	public static void UpdateTimeRate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D08")]
	[Cpp2IlInjected.Address(RVA = "0x4A0240", Offset = "0x4A0240", VA = "0x4A0240")]
	public Main()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D09")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BBC", Offset = "0x4A4BBC", VA = "0x4A4BBC")]
	protected void SetTitle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D0A")]
	[Cpp2IlInjected.Address(RVA = "0x4A4BC0", Offset = "0x4A4BC0", VA = "0x4A4BC0")]
	private static void SetTileValue()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D0B")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EE4", Offset = "0x4A4EE4", VA = "0x4A4EE4")]
	private static void ResetGameCounter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D0C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F60", Offset = "0x4A4F60", VA = "0x4A4F60", Slot = "7")]
	protected override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D0D")]
	[Cpp2IlInjected.Address(RVA = "0x4A5624", Offset = "0x4A5624", VA = "0x4A5624")]
	private void Initialize_AlmostEverything()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D0E")]
	[Cpp2IlInjected.Address(RVA = "0x4A6DD4", Offset = "0x4A6DD4", VA = "0x4A6DD4")]
	private void Initialize_Entities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D0F")]
	[Cpp2IlInjected.Address(RVA = "0x4B5B00", Offset = "0x4B5B00", VA = "0x4B5B00")]
	private static void Initialize_Items()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D10")]
	[Cpp2IlInjected.Address(RVA = "0x4AF768", Offset = "0x4AF768", VA = "0x4AF768")]
	private static void Initialize_TileAndNPCData2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D11")]
	[Cpp2IlInjected.Address(RVA = "0x4C7BD4", Offset = "0x4C7BD4", VA = "0x4C7BD4")]
	private static void AddEchoFurnitureTile(int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D12")]
	[Cpp2IlInjected.Address(RVA = "0x4A743C", Offset = "0x4A743C", VA = "0x4A743C")]
	private static void Initialize_TileAndNPCData1()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D13")]
	[Cpp2IlInjected.Address(RVA = "0x4A66F8", Offset = "0x4A66F8", VA = "0x4A66F8")]
	private void ClientInitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D14")]
	[Cpp2IlInjected.Address(RVA = "0x4C7C84", Offset = "0x4C7C84", VA = "0x4C7C84")]
	private static void CacheSupportedDisplaySizes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D15")]
	[Cpp2IlInjected.Address(RVA = "0x4C811C", Offset = "0x4C811C", VA = "0x4C811C")]
	public static void LoadTestLog(string logname)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D16")]
	[Cpp2IlInjected.Address(RVA = "0x4C8120", Offset = "0x4C8120", VA = "0x4C8120")]
	private void OnceFailedLoadingAnAsset(string assetPath, Exception e)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D17")]
	[Cpp2IlInjected.Address(RVA = "0x4C8124", Offset = "0x4C8124", VA = "0x4C8124")]
	public static void ProcessAsyncLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D18")]
	[Cpp2IlInjected.Address(RVA = "0x4C8214", Offset = "0x4C8214", VA = "0x4C8214", Slot = "8")]
	protected override void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D19")]
	[Cpp2IlInjected.Address(RVA = "0x4A66F4", Offset = "0x4A66F4", VA = "0x4A66F4")]
	private void LoadContent_TryEnteringHiDef()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D1A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8600", Offset = "0x4C8600", VA = "0x4C8600")]
	[Cpp2IlInjected.Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x39009C", Offset = "0x39009C")]
	protected IEnumerator LoadContent_Deferred()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001D1B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8670", Offset = "0x4C8670", VA = "0x4C8670")]
	private void TickLoadProcess()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D1C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8730", Offset = "0x4C8730", VA = "0x4C8730")]
	private static void PostContentLoadInitialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D1D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8970", Offset = "0x4C8970", VA = "0x4C8970")]
	[Cpp2IlInjected.Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x39010C", Offset = "0x39010C")]
	private IEnumerator LoadMusic_InSteps()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001D1E")]
	[Cpp2IlInjected.Address(RVA = "0x4C89D8", Offset = "0x4C89D8", VA = "0x4C89D8", Slot = "9")]
	protected override void UnloadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D1F")]
	[Cpp2IlInjected.Address(RVA = "0x4C89DC", Offset = "0x4C89DC", VA = "0x4C89DC")]
	public static void CheckForMoonEventsStartingTemporarySeasons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D20")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F18", Offset = "0x4C8F18", VA = "0x4C8F18")]
	public static void CheckForMoonEventsScoreDisplay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D21")]
	[Cpp2IlInjected.Address(RVA = "0x4C9198", Offset = "0x4C9198", VA = "0x4C9198")]
	public static void stopMoonEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D22")]
	[Cpp2IlInjected.Address(RVA = "0x4C9378", Offset = "0x4C9378", VA = "0x4C9378")]
	public static void startPumpkinMoon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D23")]
	[Cpp2IlInjected.Address(RVA = "0x4C9744", Offset = "0x4C9744", VA = "0x4C9744")]
	public static void startSnowMoon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D24")]
	[Cpp2IlInjected.Address(RVA = "0x4C99D0", Offset = "0x4C99D0", VA = "0x4C99D0")]
	public void UpdateAudio()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D28")]
	[Cpp2IlInjected.Address(RVA = "0x4D3160", Offset = "0x4D3160", VA = "0x4D3160")]
	private void UpdateAudio_DecideOnTOWMusic()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D29")]
	[Cpp2IlInjected.Address(RVA = "0x4CDC28", Offset = "0x4CDC28", VA = "0x4CDC28")]
	private void UpdateAudio_DecideOnNewMusic()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D2A")]
	[Cpp2IlInjected.Address(RVA = "0x4D6378", Offset = "0x4D6378", VA = "0x4D6378")]
	private void UpdateWindyDayState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D2B")]
	[Cpp2IlInjected.Address(RVA = "0x4D68C0", Offset = "0x4D68C0", VA = "0x4D68C0")]
	public static void snowing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D2C")]
	[Cpp2IlInjected.Address(RVA = "0x4D76E8", Offset = "0x4D76E8", VA = "0x4D76E8")]
	public static void checkXMas()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D2D")]
	[Cpp2IlInjected.Address(RVA = "0x4D7850", Offset = "0x4D7850", VA = "0x4D7850")]
	public static void checkHalloween()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D2E")]
	[Cpp2IlInjected.Address(RVA = "0x4D7A0C", Offset = "0x4D7A0C", VA = "0x4D7A0C")]
	public void updateCloudLayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D2F")]
	[Cpp2IlInjected.Address(RVA = "0x4D811C", Offset = "0x4D811C", VA = "0x4D811C")]
	public static void TeleportEffect(Rectangle effectRect, int Style, int extraInfo = 0, float dustCountMult = 1f, TeleportationSide side = TeleportationSide.Entry, [Optional] Vector2 otherPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D30")]
	[Cpp2IlInjected.Address(RVA = "0x4DA514", Offset = "0x4DA514", VA = "0x4DA514")]
	public static void Ambience()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D31")]
	[Cpp2IlInjected.Address(RVA = "0x4B5E78", Offset = "0x4B5E78", VA = "0x4B5E78")]
	public static void AnimateTiles_CritterCages()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D32")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA48", Offset = "0x4DAA48", VA = "0x4DAA48")]
	private static void UpdateOwlCageFrames()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D33")]
	[Cpp2IlInjected.Address(RVA = "0x4DAB08", Offset = "0x4DAB08", VA = "0x4DAB08")]
	private static void UpdateDragonflyJarFrames()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D34")]
	[Cpp2IlInjected.Address(RVA = "0x4DAC20", Offset = "0x4DAC20", VA = "0x4DAC20")]
	private static void UpdateOwlCageFrame(int[] frames, int[] frameCounters, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D35")]
	[Cpp2IlInjected.Address(RVA = "0x4DAE08", Offset = "0x4DAE08", VA = "0x4DAE08")]
	private static void UpdateDragonflyJarFrame(int[,] frames, int[,] frameCounters, int style, int variation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D36")]
	[Cpp2IlInjected.Address(RVA = "0x4DB1BC", Offset = "0x4DB1BC", VA = "0x4DB1BC")]
	public static void DoUpdate_AnimateItemIcons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D37")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2F4", Offset = "0x4DB2F4", VA = "0x4DB2F4")]
	public static void QueueMainThreadAction(Action action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D38")]
	[Cpp2IlInjected.Address(RVA = "0x4DB388", Offset = "0x4DB388", VA = "0x4DB388")]
	private static void ConsumeAllMainThreadActions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D39")]
	[Cpp2IlInjected.Address(RVA = "0x4DB444", Offset = "0x4DB444", VA = "0x4DB444", Slot = "5")]
	protected override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D3A")]
	[Cpp2IlInjected.Address(RVA = "0x4DF32C", Offset = "0x4DF32C", VA = "0x4DF32C")]
	public void UpdateViewZoomKeys()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D3B")]
	[Cpp2IlInjected.Address(RVA = "0x4DF568", Offset = "0x4DF568", VA = "0x4DF568")]
	public static void NotifyOfEvent(GameNotificationType type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D3C")]
	[Cpp2IlInjected.Address(RVA = "0x4DB738", Offset = "0x4DB738", VA = "0x4DB738")]
	protected void DoUpdate(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D3D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF56C", Offset = "0x4DF56C", VA = "0x4DF56C")]
	internal static void UpdateCreativeGameModeOverride()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D3E")]
	[Cpp2IlInjected.Address(RVA = "0x4DFCD0", Offset = "0x4DFCD0", VA = "0x4DFCD0")]
	private static void TryPlayingCreditsRoll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D3F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA11C", Offset = "0x4EA11C", VA = "0x4EA11C")]
	private static bool CanPauseGame()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D40")]
	[Cpp2IlInjected.Address(RVA = "0x4EA35C", Offset = "0x4EA35C", VA = "0x4EA35C")]
	private static void DoUpdate_WhilePaused()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D41")]
	[Cpp2IlInjected.Address(RVA = "0x4DFF7C", Offset = "0x4DFF7C", VA = "0x4DFF7C")]
	private static void UpdateUIStates(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D42")]
	[Cpp2IlInjected.Address(RVA = "0x4F0940", Offset = "0x4F0940", VA = "0x4F0940")]
	private void DoDebugFunctions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D43")]
	[Cpp2IlInjected.Address(RVA = "0x4F0944", Offset = "0x4F0944", VA = "0x4F0944")]
	private void PreUpdateAllProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D44")]
	[Cpp2IlInjected.Address(RVA = "0x4F09EC", Offset = "0x4F09EC", VA = "0x4F09EC")]
	private void PostUpdateAllProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D45")]
	[Cpp2IlInjected.Address(RVA = "0x4E84D0", Offset = "0x4E84D0", VA = "0x4E84D0")]
	private static void TrySyncingMyPlayer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D46")]
	[Cpp2IlInjected.Address(RVA = "0x4F09F0", Offset = "0x4F09F0", VA = "0x4F09F0")]
	private static void TrySyncingItemArray(ref bool syncedAnyInventoryContents, Item[] my, Item[] other, int slotOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D47")]
	[Cpp2IlInjected.Address(RVA = "0x4ED1D0", Offset = "0x4ED1D0", VA = "0x4ED1D0")]
	public bool ShouldUpdateEntities()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D48")]
	[Cpp2IlInjected.Address(RVA = "0x4ED254", Offset = "0x4ED254", VA = "0x4ED254")]
	private void DoUpdateInWorld(Stopwatch sw)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D49")]
	[Cpp2IlInjected.Address(RVA = "0x4F0B4C", Offset = "0x4F0B4C", VA = "0x4F0B4C")]
	private static void CheckBossIndexes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D4A")]
	[Cpp2IlInjected.Address(RVA = "0x4F4B68", Offset = "0x4F4B68", VA = "0x4F4B68")]
	public static bool IsNPCActiveAndOneOfTypes(int npcIndex, short npcType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D4B")]
	[Cpp2IlInjected.Address(RVA = "0x4E00B0", Offset = "0x4E00B0", VA = "0x4E00B0")]
	private static void UpdateOldNPCShop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D4C")]
	[Cpp2IlInjected.Address(RVA = "0x4E11D4", Offset = "0x4E11D4", VA = "0x4E11D4")]
	private static void DoUpdate_AnimateCursorColors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D4D")]
	[Cpp2IlInjected.Address(RVA = "0x4E1354", Offset = "0x4E1354", VA = "0x4E1354")]
	private static void DoUpdate_AnimateTileGlows()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D4E")]
	[Cpp2IlInjected.Address(RVA = "0x4E7AA4", Offset = "0x4E7AA4", VA = "0x4E7AA4")]
	private static void DoUpdate_Enter_ToggleChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D4F")]
	[Cpp2IlInjected.Address(RVA = "0x4F4EF0", Offset = "0x4F4EF0", VA = "0x4F4EF0")]
	public static void OpenPlayerChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D50")]
	[Cpp2IlInjected.Address(RVA = "0x4F502C", Offset = "0x4F502C", VA = "0x4F502C")]
	public static void ClosePlayerChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D51")]
	[Cpp2IlInjected.Address(RVA = "0x4E7AA0", Offset = "0x4E7AA0", VA = "0x4E7AA0")]
	private static void DoUpdate_HandleChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D52")]
	[Cpp2IlInjected.Address(RVA = "0x4E7940", Offset = "0x4E7940", VA = "0x4E7940")]
	private void DoUpdate_HandleInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D53")]
	[Cpp2IlInjected.Address(RVA = "0x4E7764", Offset = "0x4E7764", VA = "0x4E7764")]
	private static void DoUpdate_AltEnter_ToggleFullscreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D54")]
	[Cpp2IlInjected.Address(RVA = "0x4E7760", Offset = "0x4E7760", VA = "0x4E7760")]
	private static void DoUpdate_F11_ToggleUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D55")]
	[Cpp2IlInjected.Address(RVA = "0x4E775C", Offset = "0x4E775C", VA = "0x4E775C")]
	private static void DoUpdate_F7_ToggleGraphicsDiagnostics()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D56")]
	[Cpp2IlInjected.Address(RVA = "0x4E7758", Offset = "0x4E7758", VA = "0x4E7758")]
	private static void DoUpdate_F8_ToggleNetDiagnostics()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D57")]
	[Cpp2IlInjected.Address(RVA = "0x4E7754", Offset = "0x4E7754", VA = "0x4E7754")]
	private static void DoUpdate_F9_ToggleLighting()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D58")]
	[Cpp2IlInjected.Address(RVA = "0x4E7524", Offset = "0x4E7524", VA = "0x4E7524")]
	private static void DoUpdate_F10_ToggleFPS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D59")]
	[Cpp2IlInjected.Address(RVA = "0x4E2C74", Offset = "0x4E2C74", VA = "0x4E2C74")]
	private static void AnimateTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D5A")]
	[Cpp2IlInjected.Address(RVA = "0x4F51A8", Offset = "0x4F51A8", VA = "0x4F51A8")]
	private static void AnimateTiles_WeatherVane()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D5B")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DBC", Offset = "0x4E1DBC", VA = "0x4E1DBC")]
	private static void DoUpdate_AnimateWalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D5C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1B68", Offset = "0x4E1B68", VA = "0x4E1B68")]
	private void DoUpdate_AnimateWaterfalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D5D")]
	[Cpp2IlInjected.Address(RVA = "0x4E19B0", Offset = "0x4E19B0", VA = "0x4E19B0")]
	private static void DoUpdate_AnimateVisualPlayerAura()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D5E")]
	[Cpp2IlInjected.Address(RVA = "0x4E15D0", Offset = "0x4E15D0", VA = "0x4E15D0")]
	private void DoUpdate_AnimateDiscoRGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D5F")]
	[Cpp2IlInjected.Address(RVA = "0x4DFFF4", Offset = "0x4DFFF4", VA = "0x4DFFF4")]
	private static void DoUpdate_AnimateBackgrounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D60")]
	[Cpp2IlInjected.Address(RVA = "0x4F561C", Offset = "0x4F561C", VA = "0x4F561C")]
	private static void DoUpdate_AnimateBackgrounds_UpdateForest(int bgIndex, int[] bgSet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D61")]
	[Cpp2IlInjected.Address(RVA = "0x4DF83C", Offset = "0x4DF83C", VA = "0x4DF83C")]
	private static void DoUpdate_AutoSave()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D62")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A64", Offset = "0x4F5A64", VA = "0x4F5A64")]
	private static void UpdateSettingUnlocks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D63")]
	[Cpp2IlInjected.Address(RVA = "0x4F04D8", Offset = "0x4F04D8", VA = "0x4F04D8")]
	public static void InputTextSign()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D64")]
	[Cpp2IlInjected.Address(RVA = "0x4F06F4", Offset = "0x4F06F4", VA = "0x4F06F4")]
	public static void InputTextChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D65")]
	[Cpp2IlInjected.Address(RVA = "0x4F67E0", Offset = "0x4F67E0", VA = "0x4F67E0")]
	public static void InputTextSignCancel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D66")]
	[Cpp2IlInjected.Address(RVA = "0x4E0168", Offset = "0x4E0168", VA = "0x4E0168")]
	private static void UpdateMenu()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D67")]
	[Cpp2IlInjected.Address(RVA = "0x4F4FA0", Offset = "0x4F4FA0", VA = "0x4F4FA0")]
	public static void clrInput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D6A")]
	[Cpp2IlInjected.Address(RVA = "0x4F6ACC", Offset = "0x4F6ACC", VA = "0x4F6ACC")]
	public static void OpenKeyboard(string initial, int maxCharacters = -1, bool password = false, bool multiline = false, bool filterText = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D6B")]
	[Cpp2IlInjected.Address(RVA = "0x4F03CC", Offset = "0x4F03CC", VA = "0x4F03CC")]
	public static void CloseKeyboard()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D6C")]
	[Cpp2IlInjected.Address(RVA = "0x4F6C28", Offset = "0x4F6C28", VA = "0x4F6C28")]
	public static extern short GetKeyState(int keyCode);

	[Cpp2IlInjected.Token(Token = "0x6001D6D")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B94", Offset = "0x4F5B94", VA = "0x4F5B94")]
	public static string GetInputText(string oldString, Rectangle region, int maxCharacters = -1, bool password = false, bool retainText = false, bool multiline = false, bool filterText = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001D6E")]
	[Cpp2IlInjected.Address(RVA = "0x4F6CC8", Offset = "0x4F6CC8", VA = "0x4F6CC8")]
	public void MouseTextHackZoom(string text, [Optional] string buffTooltip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D6F")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D00", Offset = "0x4F6D00", VA = "0x4F6D00")]
	public void MouseTextHackZoom(string text, int itemRarity, byte diff = 0, [Optional] string buffTooltip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D70")]
	[Cpp2IlInjected.Address(RVA = "0x4F6E48", Offset = "0x4F6E48", VA = "0x4F6E48")]
	public void MouseTextNoOverride(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D71")]
	[Cpp2IlInjected.Address(RVA = "0x4F6E8C", Offset = "0x4F6E8C", VA = "0x4F6E8C")]
	public void MouseText(string cursorText, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D72")]
	[Cpp2IlInjected.Address(RVA = "0x4F6D44", Offset = "0x4F6D44", VA = "0x4F6D44")]
	public void MouseText(string cursorText, string buffTooltip, int rare = 0, byte diff = 0, int hackedMouseX = -1, int hackedMouseY = -1, int hackedScreenWidth = -1, int hackedScreenHeight = -1, int pushWidthX = 0, bool noOverride = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D73")]
	[Cpp2IlInjected.Address(RVA = "0x4F6ED0", Offset = "0x4F6ED0", VA = "0x4F6ED0")]
	private void MouseTextInner(MouseTextCache info, bool worldMouse)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D74")]
	[Cpp2IlInjected.Address(RVA = "0x4F7FA8", Offset = "0x4F7FA8", VA = "0x4F7FA8")]
	private void MouseText_DrawItemTooltip(MouseTextCache info, int rare, byte diff, int X, int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D75")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2D0", Offset = "0x4FD2D0", VA = "0x4FD2D0")]
	public static void MouseText_DrawItemTooltip_GetLinesInfo(Item item, ref int yoyoLogo, ref int researchLine, ref int materialsLine, float oldKB, ref int numLines, string[] toolTipLine, bool[] preFixLine, bool[] badPreFixLine, ref int setBonusLine)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D76")]
	[Cpp2IlInjected.Address(RVA = "0x4FBD9C", Offset = "0x4FBD9C", VA = "0x4FBD9C")]
	private void MouseText_DrawBuffTooltip(string cursorText, string buffString, ref int X, ref int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D77")]
	[Cpp2IlInjected.Address(RVA = "0x502470", Offset = "0x502470", VA = "0x502470")]
	protected void DrawFPS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D78")]
	[Cpp2IlInjected.Address(RVA = "0x502888", Offset = "0x502888", VA = "0x502888")]
	public static void shine(ref Color newColor, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D79")]
	[Cpp2IlInjected.Address(RVA = "0x502DA4", Offset = "0x502DA4", VA = "0x502DA4")]
	public static void shine(out Vector3 newColor, int type, int frameX)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D7A")]
	[Cpp2IlInjected.Address(RVA = "0x503178", Offset = "0x503178", VA = "0x503178")]
	private void DrawTileEntities(bool solidLayer, bool overRenderTargets, bool intoRenderTargets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D7B")]
	[Cpp2IlInjected.Address(RVA = "0x50319C", Offset = "0x50319C", VA = "0x50319C")]
	public void ClearCachedTileDraws()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D7C")]
	[Cpp2IlInjected.Address(RVA = "0x5031CC", Offset = "0x5031CC", VA = "0x5031CC")]
	public void ResetAllContentBasedRenderTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D7D")]
	[Cpp2IlInjected.Address(RVA = "0x503324", Offset = "0x503324", VA = "0x503324")]
	public static bool IsTileSpelunkable(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D7E")]
	[Cpp2IlInjected.Address(RVA = "0x5033E0", Offset = "0x5033E0", VA = "0x5033E0")]
	public static bool IsTileSpelunkable(ushort typeCache, short tileFrameX, short tileFrameY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D7F")]
	[Cpp2IlInjected.Address(RVA = "0x5034C4", Offset = "0x5034C4", VA = "0x5034C4")]
	public static bool IsTileBiomeSightable(ushort type, short tileFrameX, short tileFrameY, ref Color sightColor)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D80")]
	[Cpp2IlInjected.Address(RVA = "0x5036E0", Offset = "0x5036E0", VA = "0x5036E0")]
	protected void DrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D81")]
	[Cpp2IlInjected.Address(RVA = "0x503708", Offset = "0x503708", VA = "0x503708")]
	protected void DrawGoreBehind()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D82")]
	[Cpp2IlInjected.Address(RVA = "0x5040F8", Offset = "0x5040F8", VA = "0x5040F8")]
	protected void DrawGore()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D83")]
	[Cpp2IlInjected.Address(RVA = "0x504828", Offset = "0x504828", VA = "0x504828")]
	public void DrawHealthBar(float X, float Y, int Health, int MaxHealth, float alpha, float scale = 1f, bool noFlip = false, bool inUISpace = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D84")]
	[Cpp2IlInjected.Address(RVA = "0x505590", Offset = "0x505590", VA = "0x505590")]
	public static float NPCAddHeight(NPC theNPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D85")]
	[Cpp2IlInjected.Address(RVA = "0x505A14", Offset = "0x505A14", VA = "0x505A14")]
	protected void DrawProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D86")]
	[Cpp2IlInjected.Address(RVA = "0x50617C", Offset = "0x50617C", VA = "0x50617C")]
	public static int GetProjectileDesiredShader(Projectile proj)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001D87")]
	[Cpp2IlInjected.Address(RVA = "0x5064F8", Offset = "0x5064F8", VA = "0x5064F8")]
	private void RefreshPlayerDrawOrder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D88")]
	[Cpp2IlInjected.Address(RVA = "0x506690", Offset = "0x506690", VA = "0x506690")]
	protected void DrawPlayers_BehindNPCs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D89")]
	[Cpp2IlInjected.Address(RVA = "0x506930", Offset = "0x506930", VA = "0x506930")]
	protected void DrawPlayers_AfterProjectiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D8A")]
	[Cpp2IlInjected.Address(RVA = "0x506BD0", Offset = "0x506BD0", VA = "0x506BD0")]
	protected void DrawElderEye(SpriteBatch spriteBatch, Vector2 worldPosition, float opacity, float scale, int frameNumber, Color passedColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D8B")]
	[Cpp2IlInjected.Address(RVA = "0x506E7C", Offset = "0x506E7C", VA = "0x506E7C")]
	protected void DrawNPCs(bool behindTiles = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D8C")]
	[Cpp2IlInjected.Address(RVA = "0x508CF4", Offset = "0x508CF4", VA = "0x508CF4")]
	protected void DrawNPCCheckAlt(NPC n)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D8D")]
	[Cpp2IlInjected.Address(RVA = "0x508E8C", Offset = "0x508E8C", VA = "0x508E8C")]
	protected void DrawNPC(int iNPCIndex, bool behindTiles, LightMap lightMap, ref Rectangle lightRegion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D8E")]
	[Cpp2IlInjected.Address(RVA = "0x53ECC0", Offset = "0x53ECC0", VA = "0x53ECC0")]
	public void DrawNPCDirect_QueenSlimeWings(NPC rCurrentNPC, SpriteBatch mySpriteBatch, Vector2 screenPos, Vector2 drawCenter, Color originColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D8F")]
	[Cpp2IlInjected.Address(RVA = "0x53F120", Offset = "0x53F120", VA = "0x53F120")]
	public void DrawNPCDirect(SpriteBatch mySpriteBatch, NPC rCurrentNPC, bool behindTiles, Vector2 screenPos)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D90")]
	[Cpp2IlInjected.Address(RVA = "0x578DCC", Offset = "0x578DCC", VA = "0x578DCC")]
	private static void DrawNPCDirect_Deerclops(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D91")]
	[Cpp2IlInjected.Address(RVA = "0x57DB7C", Offset = "0x57DB7C", VA = "0x57DB7C")]
	private static void DrawNPCDirect_DeerclopsLeg(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D92")]
	[Cpp2IlInjected.Address(RVA = "0x508F58", Offset = "0x508F58", VA = "0x508F58")]
	public void DrawNPCDirect(SpriteBatch mySpriteBatch, NPC rCurrentNPC, bool behindTiles, Vector2 screenPos, LightMap lightMap, ref Rectangle lightRegion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D93")]
	[Cpp2IlInjected.Address(RVA = "0x577FA0", Offset = "0x577FA0", VA = "0x577FA0")]
	private static void DrawNPCDirect_Faeling(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D94")]
	[Cpp2IlInjected.Address(RVA = "0x575370", Offset = "0x575370", VA = "0x575370")]
	private static void DrawNPCDirect_HallowBoss(SpriteBatch mySpriteBatch, NPC rCurrentNPC, ref Vector2 screenPos, int typeCache, ref Color npcColor, ref Vector2 halfSize, SpriteEffects npcSpriteEffect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D95")]
	[Cpp2IlInjected.Address(RVA = "0x57DFAC", Offset = "0x57DFAC", VA = "0x57DFAC")]
	private static void DrawNPCDirect_GetHallowBossArmFrame(NPC rCurrentNPC, out int armFrame_Count, out int armFrameToUseLeft, out int armFrameToUseRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D96")]
	[Cpp2IlInjected.Address(RVA = "0x574C48", Offset = "0x574C48", VA = "0x574C48")]
	private static void DrawNPC_SlimeItem(NPC rCurrentNPC, int typeCache, Color npcColor, float addedRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D97")]
	[Cpp2IlInjected.Address(RVA = "0x4904A4", Offset = "0x4904A4", VA = "0x4904A4")]
	public static void GetItemDrawFrame(int item, out Texture2D itemTexture, out Rectangle itemFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D98")]
	[Cpp2IlInjected.Address(RVA = "0x57A5C8", Offset = "0x57A5C8", VA = "0x57A5C8")]
	protected void DrawNPCExtras(NPC n, bool beforeDraw, float addHeight, float addY, Color npcColor, Vector2 halfSize, SpriteEffects npcSpriteEffect, Vector2 screenPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D99")]
	[Cpp2IlInjected.Address(RVA = "0x57E44C", Offset = "0x57E44C", VA = "0x57E44C")]
	private void DrawProj_LightsBane(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D9A")]
	[Cpp2IlInjected.Address(RVA = "0x57F5B8", Offset = "0x57F5B8", VA = "0x57F5B8")]
	private void DrawProj_NightsEdge(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D9B")]
	[Cpp2IlInjected.Address(RVA = "0x580318", Offset = "0x580318", VA = "0x580318")]
	private void DrawProj_Excalibur(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D9C")]
	[Cpp2IlInjected.Address(RVA = "0x581780", Offset = "0x581780", VA = "0x581780")]
	private void DrawProj_TheHorsemansBlade(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D9D")]
	[Cpp2IlInjected.Address(RVA = "0x582BEC", Offset = "0x582BEC", VA = "0x582BEC")]
	private void DrawProj_TrueExcalibur(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D9E")]
	[Cpp2IlInjected.Address(RVA = "0x5840B4", Offset = "0x5840B4", VA = "0x5840B4")]
	private void DrawProj_TrueNightsEdge(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001D9F")]
	[Cpp2IlInjected.Address(RVA = "0x5857E8", Offset = "0x5857E8", VA = "0x5857E8")]
	private void DrawProj_TerraBlade2(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA0")]
	[Cpp2IlInjected.Address(RVA = "0x586C88", Offset = "0x586C88", VA = "0x586C88")]
	private void DrawProj_TerraBlade2Shot(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA1")]
	[Cpp2IlInjected.Address(RVA = "0x505F6C", Offset = "0x505F6C", VA = "0x505F6C")]
	public void DrawProj(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA2")]
	[Cpp2IlInjected.Address(RVA = "0x5C7DEC", Offset = "0x5C7DEC", VA = "0x5C7DEC")]
	private void DrawContinuousTrail(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA3")]
	[Cpp2IlInjected.Address(RVA = "0x5C7FD0", Offset = "0x5C7FD0", VA = "0x5C7FD0")]
	private static void DrawTrail(Projectile proj, Vector2 rotatableOffsetFromCenter, Color baseColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA4")]
	[Cpp2IlInjected.Address(RVA = "0x588B30", Offset = "0x588B30", VA = "0x588B30")]
	public void DrawProjDirect(Projectile proj, int i = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CB8", Offset = "0x5D2CB8", VA = "0x5D2CB8")]
	private static void DrawProj_Flamethrower(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA6")]
	[Cpp2IlInjected.Address(RVA = "0x5D61F4", Offset = "0x5D61F4", VA = "0x5D61F4")]
	private static void DrawProj_Spear(Projectile proj, ref Color projectileColor, ref SpriteEffects dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA7")]
	[Cpp2IlInjected.Address(RVA = "0x579FB4", Offset = "0x579FB4", VA = "0x579FB4")]
	private static void DrawPrettyStarSparkle(float opacity, SpriteEffects dir, Vector2 drawpos, Color drawColor, Color shineColor, float flareCounter, float fadeInStart, float fadeInEnd, float fadeOutStart, float fadeOutEnd, float rotation, Vector2 scale, Vector2 fatness)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2000", Offset = "0x5D2000", VA = "0x5D2000")]
	private static void DrawProj_FlailChains(Projectile proj, Vector2 mountedCenter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DA9")]
	[Cpp2IlInjected.Address(RVA = "0x5D78AC", Offset = "0x5D78AC", VA = "0x5D78AC")]
	private static void DrawProj_FlailChains_Old(Projectile proj, Vector2 mountedCenter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DAA")]
	[Cpp2IlInjected.Address(RVA = "0x5C96D4", Offset = "0x5C96D4", VA = "0x5C96D4")]
	private static Color TryApplyingPlayerStringColor(int playerStringColor, Color stringColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DAB")]
	[Cpp2IlInjected.Address(RVA = "0x5D101C", Offset = "0x5D101C", VA = "0x5D101C")]
	private static void DrawProj_FishingLine(Projectile proj, ref float polePosX, ref float polePosY, Vector2 mountedCenter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DAC")]
	[Cpp2IlInjected.Address(RVA = "0x5D50C4", Offset = "0x5D50C4", VA = "0x5D50C4")]
	private void DrawProj_StardustGuardianPunching(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DAD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0B8", Offset = "0x5CF0B8", VA = "0x5CF0B8")]
	private void DrawProj_PiercingStarlight(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DAE")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAE0", Offset = "0x5CDAE0", VA = "0x5CDAE0")]
	private void DrawProj_FairyQueenLance(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DAF")]
	[Cpp2IlInjected.Address(RVA = "0x5CD358", Offset = "0x5CD358", VA = "0x5CD358")]
	private void DrawProj_FairyQueenRangedItemShot(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB0")]
	[Cpp2IlInjected.Address(RVA = "0x5CE720", Offset = "0x5CE720", VA = "0x5CE720")]
	private void DrawProj_EmpressBlade(Projectile proj, float hueOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB1")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDD8", Offset = "0x5CFDD8", VA = "0x5CFDD8")]
	private void DrawProj_CoolWhipMinion(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB2")]
	[Cpp2IlInjected.Address(RVA = "0x5D08E8", Offset = "0x5D08E8", VA = "0x5D08E8")]
	private void DrawMurderAurora(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB3")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF78", Offset = "0x5CBF78", VA = "0x5CBF78")]
	private void DrawWhip(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD50", Offset = "0x5DBD50", VA = "0x5DBD50")]
	public static Vector2 DrawWhip_BoneWhip(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB5")]
	[Cpp2IlInjected.Address(RVA = "0x5DA204", Offset = "0x5DA204", VA = "0x5DA204")]
	public static Vector2 DrawWhip_CoolWhip(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB6")]
	[Cpp2IlInjected.Address(RVA = "0x5DA810", Offset = "0x5DA810", VA = "0x5DA810")]
	public static Vector2 DrawWhip_FireWhip(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB394", Offset = "0x5DB394", VA = "0x5DB394")]
	public static Vector2 DrawWhip_RainbowWhip(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE1C", Offset = "0x5DAE1C", VA = "0x5DAE1C")]
	public static Vector2 DrawWhip_ThornWhip(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DB9")]
	[Cpp2IlInjected.Address(RVA = "0x5D87EC", Offset = "0x5D87EC", VA = "0x5D87EC")]
	public static Vector2 DrawWhip_WhipSword(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DBA")]
	[Cpp2IlInjected.Address(RVA = "0x5D948C", Offset = "0x5D948C", VA = "0x5D948C")]
	public static Vector2 DrawWhip_WhipMace(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DBB")]
	[Cpp2IlInjected.Address(RVA = "0x5D9B48", Offset = "0x5D9B48", VA = "0x5D9B48")]
	public static Vector2 DrawWhip_WhipScythe(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DBC")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DEC", Offset = "0x5D8DEC", VA = "0x5D8DEC")]
	public static Vector2 DrawWhip_WhipBland(Projectile proj, List<Vector2> controlPoints)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DBD")]
	[Cpp2IlInjected.Address(RVA = "0x5D042C", Offset = "0x5D042C", VA = "0x5D042C")]
	private void DrawTwinsPet(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DBE")]
	[Cpp2IlInjected.Address(RVA = "0x5CC938", Offset = "0x5CC938", VA = "0x5CC938")]
	private void DrawMultisegmentPet(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DBF")]
	[Cpp2IlInjected.Address(RVA = "0x5C99B8", Offset = "0x5C99B8", VA = "0x5C99B8")]
	private void DrawKite(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC0")]
	[Cpp2IlInjected.Address(RVA = "0x5D74A4", Offset = "0x5D74A4", VA = "0x5D74A4")]
	public static Vector2 GetPlayerArmPosition(Projectile proj)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC1")]
	[Cpp2IlInjected.Address(RVA = "0x5D3CD4", Offset = "0x5D3CD4", VA = "0x5D3CD4")]
	private void DrawProjWithStarryTrail(Projectile proj, Color projectileColor, SpriteEffects dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC2")]
	[Cpp2IlInjected.Address(RVA = "0x5C8A3C", Offset = "0x5C8A3C", VA = "0x5C8A3C")]
	private static int TryInteractingWithVoidLens(Projectile proj)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC3")]
	[Cpp2IlInjected.Address(RVA = "0x5D5878", Offset = "0x5D5878", VA = "0x5D5878")]
	private static int TryInteractingWithMoneyTrough(Projectile proj)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC4")]
	[Cpp2IlInjected.Address(RVA = "0x5DC328", Offset = "0x5DC328", VA = "0x5DC328")]
	public static void PlayInteractiveProjectileOpenCloseSound(int projType, bool open)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC5")]
	[Cpp2IlInjected.Address(RVA = "0x5DC448", Offset = "0x5DC448", VA = "0x5DC448")]
	public static void PrintTimedMessage(string message, params object[] arguments)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC6")]
	[Cpp2IlInjected.Address(RVA = "0x5DC560", Offset = "0x5DC560", VA = "0x5DC560")]
	private static void TryInteractingWithMoneyTrough2(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC7")]
	[Cpp2IlInjected.Address(RVA = "0x5C89AC", Offset = "0x5C89AC", VA = "0x5C89AC")]
	public void PrepareDrawnProjectileDrawing(Projectile proj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC8")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD00", Offset = "0x5DCD00", VA = "0x5DCD00")]
	public void PrepareDrawnEntityDrawing(Entity entity, int intendedShader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DC9")]
	[Cpp2IlInjected.Address(RVA = "0x5C989C", Offset = "0x5C989C", VA = "0x5C989C")]
	public static void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float worthless = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DCA")]
	[Cpp2IlInjected.Address(RVA = "0x5C8550", Offset = "0x5C8550", VA = "0x5C8550")]
	public static void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float worthless = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DCB")]
	[Cpp2IlInjected.Address(RVA = "0x5C93D0", Offset = "0x5C93D0", VA = "0x5C93D0")]
	public static void EntitySpriteDraw(DrawData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DCC")]
	[Cpp2IlInjected.Address(RVA = "0x57A500", Offset = "0x57A500", VA = "0x57A500")]
	public static Color buffColor(Color newColor, float R, float G, float B, float A)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DCD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD238", Offset = "0x5DD238", VA = "0x5DD238")]
	protected void CacheNPCDraws()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DCE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7C4", Offset = "0x5DD7C4", VA = "0x5DD7C4")]
	protected void CacheProjDraws()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DCF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE220", Offset = "0x5DE220", VA = "0x5DE220")]
	protected void DrawCachedNPCs(List<int> npcCache, bool behindTiles)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE41C", Offset = "0x5DE41C", VA = "0x5DE41C")]
	protected void DrawCachedProjs(List<int> projCache, bool startSpriteBatch = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE808", Offset = "0x5DE808", VA = "0x5DE808")]
	protected void DrawSuperSpecialProjectiles(List<int> projCache, bool startSpriteBatch = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF164", Offset = "0x5DF164", VA = "0x5DF164")]
	protected void SortDrawCacheWorms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF184", Offset = "0x5DF184", VA = "0x5DF184")]
	private void SortBabyBirdProjectiles(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF484", Offset = "0x5DF484", VA = "0x5DF484")]
	private void SortStardustDragonProjectiles(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE2C", Offset = "0x5DFE2C", VA = "0x5DFE2C")]
	protected void DrawWoF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD6")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C78", Offset = "0x5E0C78", VA = "0x5E0C78")]
	private static void DrawWOFBody()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD7")]
	[Cpp2IlInjected.Address(RVA = "0x5E062C", Offset = "0x5E062C", VA = "0x5E062C")]
	private static void DrawWOFRopeToTheHungry(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD8")]
	[Cpp2IlInjected.Address(RVA = "0x5E0134", Offset = "0x5E0134", VA = "0x5E0134")]
	private static void DrawWOFTongueToPlayer(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DD9")]
	[Cpp2IlInjected.Address(RVA = "0x5E12F0", Offset = "0x5E12F0", VA = "0x5E12F0")]
	public static Color quickAlpha(Color oldColor, float Alpha)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DDA")]
	[Cpp2IlInjected.Address(RVA = "0x5E13A8", Offset = "0x5E13A8", VA = "0x5E13A8")]
	private void DrawItem_GetBasics(Item item, int slot, out Texture2D texture, out Rectangle frame, out Rectangle glowmaskFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DDB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A2C", Offset = "0x5E1A2C", VA = "0x5E1A2C")]
	private void DrawItem_AnimateSlot(int slot, int gameFramesPerSpriteFrame, int spriteFramesAmount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DDC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B04", Offset = "0x5E1B04", VA = "0x5E1B04")]
	protected void DrawItem(Item item, int whoami)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DDD")]
	[Cpp2IlInjected.Address(RVA = "0x5E42C0", Offset = "0x5E42C0", VA = "0x5E42C0")]
	public void DrawItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DDE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4360", Offset = "0x5E4360", VA = "0x5E4360")]
	protected void DrawRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DDF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4864", Offset = "0x5E4864", VA = "0x5E4864")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39017C", Offset = "0x39017C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39017C", Offset = "0x39017C")]
	protected void DrawDust()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE0")]
	[Cpp2IlInjected.Address(RVA = "0x5E651C", Offset = "0x5E651C", VA = "0x5E651C")]
	public static void HelpText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF40", Offset = "0x5ECF40", VA = "0x5ECF40")]
	private void OpenShop(int shopIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE2")]
	[Cpp2IlInjected.Address(RVA = "0x5DC2B0", Offset = "0x5DC2B0", VA = "0x5DC2B0")]
	public static void SetNPCShopIndex(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED030", Offset = "0x5ED030", VA = "0x5ED030")]
	public static void CloseNPCChatOrSign()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE4")]
	[Cpp2IlInjected.Address(RVA = "0x4F669C", Offset = "0x4F669C", VA = "0x4F669C")]
	public static void SubmitSignText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED150", Offset = "0x5ED150", VA = "0x5ED150")]
	private int NPCBannerSorter(int npcIndex1, int npcIndex2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE6")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1F0", Offset = "0x5ED1F0", VA = "0x5ED1F0")]
	protected void DrawNPCHousesInWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE7")]
	[Cpp2IlInjected.Address(RVA = "0x5EE44C", Offset = "0x5EE44C", VA = "0x5EE44C")]
	protected void DrawPlayerChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DE9")]
	[Cpp2IlInjected.Address(RVA = "0x5EE690", Offset = "0x5EE690", VA = "0x5EE690")]
	public static void LockCraftingForThisCraftClickDuration()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DEA")]
	[Cpp2IlInjected.Address(RVA = "0x5EE70C", Offset = "0x5EE70C", VA = "0x5EE70C")]
	public void DrawMouseOver()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DEB")]
	[Cpp2IlInjected.Address(RVA = "0x5F0120", Offset = "0x5F0120", VA = "0x5F0120")]
	private void HoverOverNPCs(Rectangle mouseRectangle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DEC")]
	[Cpp2IlInjected.Address(RVA = "0x5F1060", Offset = "0x5F1060", VA = "0x5F1060")]
	private static bool TryFreeingElderSlime(int npcIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DED")]
	[Cpp2IlInjected.Address(RVA = "0x5F1364", Offset = "0x5F1364", VA = "0x5F1364")]
	private static void DrawNPCChatBubble(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DEE")]
	[Cpp2IlInjected.Address(RVA = "0x5F1C2C", Offset = "0x5F1C2C", VA = "0x5F1C2C")]
	public void GUIBarsDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DEF")]
	[Cpp2IlInjected.Address(RVA = "0x5F1D40", Offset = "0x5F1D40", VA = "0x5F1D40")]
	protected void GUIBarsDrawInner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF0")]
	[Cpp2IlInjected.Address(RVA = "0x5F1E38", Offset = "0x5F1E38", VA = "0x5F1E38")]
	public static void DrawInterface_Resources_ClearBuffs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF1")]
	[Cpp2IlInjected.Address(RVA = "0x5F2FBC", Offset = "0x5F2FBC", VA = "0x5F2FBC")]
	public void DrawInterface_Resources_Buffs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF2")]
	[Cpp2IlInjected.Address(RVA = "0x5F3DF4", Offset = "0x5F3DF4", VA = "0x5F3DF4")]
	public static string GetBuffTooltip(Player player, int buffType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF3")]
	[Cpp2IlInjected.Address(RVA = "0x5F3FF0", Offset = "0x5F3FF0", VA = "0x5F3FF0")]
	public static bool TryGetBuffTime(int buffSlotOnPlayer, out int buffTimeValue)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF4")]
	[Cpp2IlInjected.Address(RVA = "0x5F3330", Offset = "0x5F3330", VA = "0x5F3330")]
	public static int DrawBuffIcon(int drawBuffText, int buffSlotOnPlayer, int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF5")]
	[Cpp2IlInjected.Address(RVA = "0x5F422C", Offset = "0x5F422C", VA = "0x5F422C")]
	public static void TryRemovingBuff(int i, int b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF6")]
	[Cpp2IlInjected.Address(RVA = "0x5F4484", Offset = "0x5F4484", VA = "0x5F4484")]
	public static void TryRemovingBuff_CheckBuffHideMisc(int slot, int buffID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF7")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F08", Offset = "0x5F1F08", VA = "0x5F1F08")]
	private static void DrawInterface_Resources_Breath()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF8")]
	[Cpp2IlInjected.Address(RVA = "0x5F4638", Offset = "0x5F4638", VA = "0x5F4638")]
	private static void DrawInterface_Resources_GolfPower()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DF9")]
	[Cpp2IlInjected.Address(RVA = "0x5F4A0C", Offset = "0x5F4A0C", VA = "0x5F4A0C")]
	private static void DrawInterface_GolfBallIndicator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DFA")]
	[Cpp2IlInjected.Address(RVA = "0x5F5804", Offset = "0x5F5804", VA = "0x5F5804")]
	protected void GUIHotbarDrawInner()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DFB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6778", Offset = "0x5F6778", VA = "0x5F6778")]
	public static void OpenHairWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DFC")]
	[Cpp2IlInjected.Address(RVA = "0x5F1194", Offset = "0x5F1194", VA = "0x5F1194")]
	public static void CancelHairWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DFD")]
	[Cpp2IlInjected.Address(RVA = "0x5F68E8", Offset = "0x5F68E8", VA = "0x5F68E8")]
	public static void BuyHairWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001DFE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6ACC", Offset = "0x5F6ACC", VA = "0x5F6ACC")]
	public static int UnlockedMaxHair()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001DFF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6BC4", Offset = "0x5F6BC4", VA = "0x5F6BC4")]
	public static void OpenClothesWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E00")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F04", Offset = "0x5F6F04", VA = "0x5F6F04")]
	public static void CancelClothesWindow(bool quiet = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E01")]
	[Cpp2IlInjected.Address(RVA = "0x5F7140", Offset = "0x5F7140", VA = "0x5F7140")]
	public static void SaveClothesWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E02")]
	[Cpp2IlInjected.Address(RVA = "0x5F724C", Offset = "0x5F724C", VA = "0x5F724C")]
	private void SetupDrawInterfaceLayers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E03")]
	[Cpp2IlInjected.Address(RVA = "0x5F9974", Offset = "0x5F9974", VA = "0x5F9974")]
	protected void DrawInterface(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E04")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B98", Offset = "0x5F9B98", VA = "0x5F9B98")]
	private static void DrawWallOfCopperShortswords()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E05")]
	[Cpp2IlInjected.Address(RVA = "0x5FA044", Offset = "0x5FA044", VA = "0x5FA044")]
	private static void DrawWallOfBoulders()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E06")]
	[Cpp2IlInjected.Address(RVA = "0x5FA468", Offset = "0x5FA468", VA = "0x5FA468")]
	private static void DrawInterface_41_InterfaceLogic4()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E07")]
	[Cpp2IlInjected.Address(RVA = "0x5FA568", Offset = "0x5FA568", VA = "0x5FA568")]
	private static void DrawPendingMouseText(bool worldMouse = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E08")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6BC", Offset = "0x5FA6BC", VA = "0x5FA6BC")]
	private void DrawInterface_40_InteractItemIcon()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E09")]
	[Cpp2IlInjected.Address(RVA = "0x5FB970", Offset = "0x5FB970", VA = "0x5FB970")]
	private bool TryGetAmmo(Item sourceItem, out Item ammoItem, out Color ammoColor, out float ammoScale, out Vector2 ammoOffset)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E0A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC70", Offset = "0x5FBC70", VA = "0x5FBC70")]
	private void DrawInterface_39_MouseOver()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E0B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC74", Offset = "0x5FBC74", VA = "0x5FBC74")]
	private void DrawInterface_38_MouseCarriedObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E0C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAD0", Offset = "0x5FCAD0", VA = "0x5FCAD0")]
	private static void DrawInterface_37_DebugStuff()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E0D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAD4", Offset = "0x5FCAD4", VA = "0x5FCAD4")]
	public void DrawWorldCursor(bool magnify = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E0E")]
	[Cpp2IlInjected.Address(RVA = "0x5FECC4", Offset = "0x5FECC4", VA = "0x5FECC4")]
	public static void DrawInterface_FinalUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E0F")]
	[Cpp2IlInjected.Address(RVA = "0x5FED2C", Offset = "0x5FED2C", VA = "0x5FED2C")]
	public static void DrawInterface_36_Cursor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E10")]
	[Cpp2IlInjected.Address(RVA = "0x6015AC", Offset = "0x6015AC", VA = "0x6015AC")]
	private static void DrawInterface_35_YouDied()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E11")]
	[Cpp2IlInjected.Address(RVA = "0x601C78", Offset = "0x601C78", VA = "0x601C78")]
	private void DrawInterface_34_PlayerChat()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E12")]
	[Cpp2IlInjected.Address(RVA = "0x601D8C", Offset = "0x601D8C", VA = "0x601D8C")]
	private void DrawInterface_33_MouseText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E13")]
	[Cpp2IlInjected.Address(RVA = "0x60232C", Offset = "0x60232C", VA = "0x60232C")]
	private void DrawInterface_InstrumentMouseText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E14")]
	[Cpp2IlInjected.Address(RVA = "0x60275C", Offset = "0x60275C", VA = "0x60275C")]
	private static void DrawInterface_32_GamepadRadialHotbars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E15")]
	[Cpp2IlInjected.Address(RVA = "0x6029DC", Offset = "0x6029DC", VA = "0x6029DC")]
	private void DrawInterface_31_BuilderAccToggles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E16")]
	[Cpp2IlInjected.Address(RVA = "0x6029E0", Offset = "0x6029E0", VA = "0x6029E0")]
	public static void DrawInterface_29_SettingsButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E17")]
	[Cpp2IlInjected.Address(RVA = "0x602C6C", Offset = "0x602C6C", VA = "0x602C6C")]
	private void DrawInterface_28_InfoAccs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E18")]
	[Cpp2IlInjected.Address(RVA = "0x602CD0", Offset = "0x602CD0", VA = "0x602CD0")]
	private void HackForGamepadInputHell()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E19")]
	[Cpp2IlInjected.Address(RVA = "0x602CD8", Offset = "0x602CD8", VA = "0x602CD8")]
	private void DrawInterface_27_Inventory()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E1A")]
	[Cpp2IlInjected.Address(RVA = "0x602D3C", Offset = "0x602D3C", VA = "0x602D3C")]
	private static void DrawInterface_26_InterfaceLogic3()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E1B")]
	[Cpp2IlInjected.Address(RVA = "0x602EF4", Offset = "0x602EF4", VA = "0x602EF4")]
	private void DrawInterface_25_ResourceBars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E1C")]
	[Cpp2IlInjected.Address(RVA = "0x602F68", Offset = "0x602F68", VA = "0x602F68")]
	private static void DrawInterface_24_InterfaceLogic2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E1D")]
	[Cpp2IlInjected.Address(RVA = "0x603188", Offset = "0x603188", VA = "0x603188")]
	private void DrawInterface_23_NPCSignsDialog()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E1E")]
	[Cpp2IlInjected.Address(RVA = "0x6035AC", Offset = "0x6035AC", VA = "0x6035AC")]
	private void DrawInterface_22_DresserWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E1F")]
	[Cpp2IlInjected.Address(RVA = "0x603648", Offset = "0x603648", VA = "0x603648")]
	private void DrawInterface_21_HairWindow()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E20")]
	[Cpp2IlInjected.Address(RVA = "0x6036E4", Offset = "0x6036E4", VA = "0x6036E4")]
	private static void DrawInterface_20_MultiplayerPlayerNames()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E21")]
	[Cpp2IlInjected.Address(RVA = "0x6037D4", Offset = "0x6037D4", VA = "0x6037D4")]
	private static void DrawInterface_19_SignTileBubble()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E22")]
	[Cpp2IlInjected.Address(RVA = "0x603CC8", Offset = "0x603CC8", VA = "0x603CC8")]
	private static void DrawInterface_18_DiagnoseVideo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E23")]
	[Cpp2IlInjected.Address(RVA = "0x604E74", Offset = "0x604E74", VA = "0x604E74")]
	private static void DrawInterface_17_DiagnoseNet()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E24")]
	[Cpp2IlInjected.Address(RVA = "0x604FA4", Offset = "0x604FA4", VA = "0x604FA4")]
	private void DrawInterface_16_MapOrMinimap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E26")]
	[Cpp2IlInjected.Address(RVA = "0x605104", Offset = "0x605104", VA = "0x605104")]
	private static void DrawInterface_15_InvasionProgressBars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E27")]
	[Cpp2IlInjected.Address(RVA = "0x605E40", Offset = "0x605E40", VA = "0x605E40")]
	private void DrawInterface_14_EntityHealthBars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E28")]
	[Cpp2IlInjected.Address(RVA = "0x608620", Offset = "0x608620", VA = "0x608620")]
	private void DrawInterface_Healthbar_Worm(NPC head, int tailID, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E29")]
	[Cpp2IlInjected.Address(RVA = "0x6088A0", Offset = "0x6088A0", VA = "0x6088A0")]
	private static void DrawInterface_13_AchievementCompletePopups()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E2A")]
	[Cpp2IlInjected.Address(RVA = "0x608954", Offset = "0x608954", VA = "0x608954")]
	private static bool DrawInterface_12_IngameFancyUI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E2B")]
	[Cpp2IlInjected.Address(RVA = "0x608C4C", Offset = "0x608C4C", VA = "0x608C4C")]
	private bool DrawInterface_11_IngameOptionsMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E2C")]
	[Cpp2IlInjected.Address(RVA = "0x608C54", Offset = "0x608C54", VA = "0x608C54")]
	private static bool DrawInterface_8_CheckF11UIHideToggle()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E2D")]
	[Cpp2IlInjected.Address(RVA = "0x608D20", Offset = "0x608D20", VA = "0x608D20")]
	private static bool DrawInterface_10_CheckCaptureManager()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E2E")]
	[Cpp2IlInjected.Address(RVA = "0x608D28", Offset = "0x608D28", VA = "0x608D28")]
	private static void DrawInterface_9_WireSelection()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E2F")]
	[Cpp2IlInjected.Address(RVA = "0x608DF0", Offset = "0x608DF0", VA = "0x608DF0")]
	private static void DrawInterface_0_InterfaceLogic1()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E30")]
	[Cpp2IlInjected.Address(RVA = "0x608EFC", Offset = "0x608EFC", VA = "0x608EFC")]
	private void DrawInterface_7_TownNPCHouseBanners()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E31")]
	[Cpp2IlInjected.Address(RVA = "0x609094", Offset = "0x609094", VA = "0x609094")]
	private bool DrawVirtualControls()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E32")]
	[Cpp2IlInjected.Address(RVA = "0x6091A8", Offset = "0x6091A8", VA = "0x6091A8")]
	private void DrawInterface_WorldMouse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E33")]
	[Cpp2IlInjected.Address(RVA = "0x609240", Offset = "0x609240", VA = "0x609240")]
	private void DrawInterface_WorldMouseOver()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E34")]
	[Cpp2IlInjected.Address(RVA = "0x6093F8", Offset = "0x6093F8", VA = "0x6093F8")]
	public static void DrawTileGridOption(bool magnify = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E35")]
	[Cpp2IlInjected.Address(RVA = "0x609C94", Offset = "0x609C94", VA = "0x609C94")]
	private static void DrawInterface_6_TileGridOption()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E36")]
	[Cpp2IlInjected.Address(RVA = "0x609D5C", Offset = "0x609D5C", VA = "0x609D5C")]
	private static void DrawInterface_5_GamepadLockOn()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E37")]
	[Cpp2IlInjected.Address(RVA = "0x609E10", Offset = "0x609E10", VA = "0x609E10")]
	private static void DrawInterface_4_Ruler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E38")]
	[Cpp2IlInjected.Address(RVA = "0x60ADB8", Offset = "0x60ADB8", VA = "0x60ADB8")]
	private static void DrawInterface_3_LaserRuler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E39")]
	[Cpp2IlInjected.Address(RVA = "0x60BEE8", Offset = "0x60BEE8", VA = "0x60BEE8")]
	private static void DrawInterface_2_SmartCursorTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E3A")]
	[Cpp2IlInjected.Address(RVA = "0x60D4D0", Offset = "0x60D4D0", VA = "0x60D4D0")]
	private static void DrawInterface_1_1_DrawEmoteBubblesInWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E3B")]
	[Cpp2IlInjected.Address(RVA = "0x60D764", Offset = "0x60D764", VA = "0x60D764")]
	private static void DrawInterface_1_2_DrawEntityMarkersInWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E3C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF798", Offset = "0x4DF798", VA = "0x4DF798")]
	private static void MouseOversTryToClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E3D")]
	[Cpp2IlInjected.Address(RVA = "0x60DF6C", Offset = "0x60DF6C", VA = "0x60DF6C")]
	private static void MouseOversClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E3E")]
	[Cpp2IlInjected.Address(RVA = "0x60E090", Offset = "0x60E090", VA = "0x60E090")]
	public static void ItemIconCacheUpdate(int selectedItemID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E3F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB760", Offset = "0x5FB760", VA = "0x5FB760")]
	public static void ItemIconCacheVerification()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E40")]
	[Cpp2IlInjected.Address(RVA = "0x60E128", Offset = "0x60E128", VA = "0x60E128")]
	public static void DrawWallOfFish()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E41")]
	[Cpp2IlInjected.Address(RVA = "0x60E59C", Offset = "0x60E59C", VA = "0x60E59C")]
	public static void DrawWallOfStars()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E42")]
	[Cpp2IlInjected.Address(RVA = "0x60BF58", Offset = "0x60BF58", VA = "0x60BF58")]
	private static void DrawSmartCursor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E43")]
	[Cpp2IlInjected.Address(RVA = "0x60EDBC", Offset = "0x60EDBC", VA = "0x60EDBC")]
	private static void DrawSmartInteract()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E44")]
	[Cpp2IlInjected.Address(RVA = "0x61010C", Offset = "0x61010C", VA = "0x61010C")]
	private void DrawInterface_30_Hotbar()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E45")]
	[Cpp2IlInjected.Address(RVA = "0x60318C", Offset = "0x60318C", VA = "0x60318C")]
	public void GUIChatDraw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E48")]
	[Cpp2IlInjected.Address(RVA = "0x610538", Offset = "0x610538", VA = "0x610538")]
	public static void DrawItemIcon(SpriteBatch spriteBatch, Item theItem, Vector2 screenPositionForItemCenter, Color itemLightColor, float sizeLimit)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E49")]
	[Cpp2IlInjected.Address(RVA = "0x4E7AA8", Offset = "0x4E7AA8", VA = "0x4E7AA8")]
	public static void CheckInvasionProgressDisplay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E4A")]
	[Cpp2IlInjected.Address(RVA = "0x610AF8", Offset = "0x610AF8", VA = "0x610AF8")]
	public static void SyncAnInvasion(int toWho)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E4B")]
	[Cpp2IlInjected.Address(RVA = "0x610900", Offset = "0x610900", VA = "0x610900")]
	public static void ReportInvasionProgress(int progress, int progressMax, int icon, int progressWave)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E4C")]
	[Cpp2IlInjected.Address(RVA = "0x6051E4", Offset = "0x6051E4", VA = "0x6051E4")]
	public static void DrawInvasionProgress()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E4D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF1B8", Offset = "0x4DF1B8", VA = "0x4DF1B8")]
	protected void QuitGame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E4E")]
	[Cpp2IlInjected.Address(RVA = "0x610F88", Offset = "0x610F88", VA = "0x610F88")]
	public static Color randColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E4F")]
	[Cpp2IlInjected.Address(RVA = "0x5D5030", Offset = "0x5D5030", VA = "0x5D5030")]
	public static Color hslToRgb(Vector3 hslVector)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E50")]
	[Cpp2IlInjected.Address(RVA = "0x4D9FA8", Offset = "0x4D9FA8", VA = "0x4D9FA8")]
	public static Color hslToRgb(float Hue, float Saturation, float Luminosity, byte a = byte.MaxValue)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E51")]
	[Cpp2IlInjected.Address(RVA = "0x611138", Offset = "0x611138", VA = "0x611138")]
	public static void hslToRgb(ref Color color, float Hue, float Saturation, float Luminosity, byte a = byte.MaxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E52")]
	[Cpp2IlInjected.Address(RVA = "0x611088", Offset = "0x611088", VA = "0x611088")]
	public static double hue2rgb(double c, double t1, double t2)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E53")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E48", Offset = "0x5D4E48", VA = "0x5D4E48")]
	public static Vector3 rgbToHsl(Color newColor)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E55")]
	[Cpp2IlInjected.Address(RVA = "0x6004AC", Offset = "0x6004AC", VA = "0x6004AC")]
	public static void DrawCursor(Vector2 bonus, bool smart = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E56")]
	[Cpp2IlInjected.Address(RVA = "0x611794", Offset = "0x611794", VA = "0x611794")]
	public static void ClearSmartInteract()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E57")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8C0", Offset = "0x5FF8C0", VA = "0x5FF8C0")]
	public static Vector2 DrawThickCursor(bool smart = false)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E58")]
	[Cpp2IlInjected.Address(RVA = "0x611844", Offset = "0x611844", VA = "0x611844")]
	private void OnCharacterNamed(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E59")]
	[Cpp2IlInjected.Address(RVA = "0x6118E4", Offset = "0x6118E4", VA = "0x6118E4")]
	private void OnSeedSelected(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E5A")]
	[Cpp2IlInjected.Address(RVA = "0x611A1C", Offset = "0x611A1C", VA = "0x611A1C")]
	private void OnWorldNamed(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E5C")]
	[Cpp2IlInjected.Address(RVA = "0x611BA8", Offset = "0x611BA8", VA = "0x611BA8")]
	public static void GoToWorldSelect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E5D")]
	[Cpp2IlInjected.Address(RVA = "0x611C1C", Offset = "0x611C1C", VA = "0x611C1C")]
	public static void StartClientGameplay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E5E")]
	[Cpp2IlInjected.Address(RVA = "0x611CC8", Offset = "0x611CC8", VA = "0x611CC8")]
	public static void ReleaseHostAndPlayProcess()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E5F")]
	[Cpp2IlInjected.Address(RVA = "0x611D7C", Offset = "0x611D7C", VA = "0x611D7C")]
	private string SanitizePathArgument(string argumentName, string argumentPath)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001E60")]
	[Cpp2IlInjected.Address(RVA = "0x611EA0", Offset = "0x611EA0", VA = "0x611EA0")]
	protected void DrawMenu(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E61")]
	[Cpp2IlInjected.Address(RVA = "0x61354C", Offset = "0x61354C", VA = "0x61354C")]
	private static void DrawVersionNumber(Color menuColor, float upBump)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E62")]
	[Cpp2IlInjected.Address(RVA = "0x6138D4", Offset = "0x6138D4", VA = "0x6138D4")]
	public static void ClearVisualPostProcessEffects()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E63")]
	[Cpp2IlInjected.Address(RVA = "0x614DD0", Offset = "0x614DD0", VA = "0x614DD0")]
	private static void PostDrawMenu(Point screenSizeCache, Point screenSizeCacheAfterScaling)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E64")]
	[Cpp2IlInjected.Address(RVA = "0x614F00", Offset = "0x614F00", VA = "0x614F00")]
	private void PreDrawMenu(out Point screenSizeCache, out Point screenSizeCacheAfterScaling)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E65")]
	[Cpp2IlInjected.Address(RVA = "0x6150DC", Offset = "0x6150DC", VA = "0x6150DC")]
	private static bool IsBorderlessDisplayAvailable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E66")]
	[Cpp2IlInjected.Address(RVA = "0x6150E4", Offset = "0x6150E4", VA = "0x6150E4")]
	private static void CycleClothingStyle(Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E67")]
	[Cpp2IlInjected.Address(RVA = "0x6152CC", Offset = "0x6152CC", VA = "0x6152CC")]
	private static bool IsValidPlayerStyle(Player plr)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E68")]
	[Cpp2IlInjected.Address(RVA = "0x61518C", Offset = "0x61518C", VA = "0x61518C")]
	private static void CycleClothingStyle_Inner(Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E69")]
	[Cpp2IlInjected.Address(RVA = "0x6152E0", Offset = "0x6152E0", VA = "0x6152E0")]
	public static void ResetKeyBindings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E6A")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C20", Offset = "0x4F4C20", VA = "0x4F4C20")]
	public static void CursorColor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E6B")]
	[Cpp2IlInjected.Address(RVA = "0x6154A0", Offset = "0x6154A0", VA = "0x6154A0")]
	private void UnloadSplashScreenTextures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E6C")]
	[Cpp2IlInjected.Address(RVA = "0x615554", Offset = "0x615554", VA = "0x615554")]
	protected void DrawSplash(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E6D")]
	[Cpp2IlInjected.Address(RVA = "0x616194", Offset = "0x616194", VA = "0x616194")]
	private void DrawSplash_LoadingFlower(Color splashColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E6E")]
	[Cpp2IlInjected.Address(RVA = "0x6165A8", Offset = "0x6165A8", VA = "0x6165A8")]
	private void DrawSplash_LoadingStar(Color splashColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E6F")]
	[Cpp2IlInjected.Address(RVA = "0x6168F4", Offset = "0x6168F4", VA = "0x6168F4")]
	protected void DrawUnderworldBackground(bool flat)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E70")]
	[Cpp2IlInjected.Address(RVA = "0x616C3C", Offset = "0x616C3C", VA = "0x616C3C")]
	private static void DrawUnderworldBackgroudLayer(bool flat, Vector2 screenOffset, float pushUp, int layerTextureIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E71")]
	[Cpp2IlInjected.Address(RVA = "0x618048", Offset = "0x618048", VA = "0x618048")]
	private void ProcessBatchFinished(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E73")]
	[Cpp2IlInjected.Address(RVA = "0x61810C", Offset = "0x61810C", VA = "0x61810C")]
	private void WaitBackgroundDrawThreads(int numberOfThreads)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E74")]
	[Cpp2IlInjected.Address(RVA = "0x6183A4", Offset = "0x6183A4", VA = "0x6183A4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390230", Offset = "0x390230")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390230", Offset = "0x390230")]
	public void DrawCurrentBackground(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Vector2 drawOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E75")]
	[Cpp2IlInjected.Address(RVA = "0x619798", Offset = "0x619798", VA = "0x619798")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3902E4", Offset = "0x3902E4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3902E4", Offset = "0x3902E4")]
	public void DrawMagmaLayer(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Vector2 drawOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E76")]
	[Cpp2IlInjected.Address(RVA = "0x61AAA8", Offset = "0x61AAA8", VA = "0x61AAA8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390398", Offset = "0x390398")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390398", Offset = "0x390398")]
	public void DrawRockLayer(int bgStartX, int bgStartY, int bgLoops, int bgLoopsY, int diff, Vector2 drawOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E77")]
	[Cpp2IlInjected.Address(RVA = "0x61BF08", Offset = "0x61BF08", VA = "0x61BF08")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39044C", Offset = "0x39044C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39044C", Offset = "0x39044C")]
	protected void DrawBackground()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E78")]
	[Cpp2IlInjected.Address(RVA = "0x62B1BC", Offset = "0x62B1BC", VA = "0x62B1BC")]
	public static Point GetScreenOverdrawOffset()
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E79")]
	[Cpp2IlInjected.Address(RVA = "0x62B1E4", Offset = "0x62B1E4", VA = "0x62B1E4")]
	private static bool ShouldDrawBackgroundTileAt(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E7A")]
	[Cpp2IlInjected.Address(RVA = "0x62B344", Offset = "0x62B344", VA = "0x62B344")]
	public static bool WallLightAt(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E7B")]
	[Cpp2IlInjected.Address(RVA = "0x62B3CC", Offset = "0x62B3CC", VA = "0x62B3CC")]
	public static bool WallLightAt(int i, int j, bool showInvisibleWalls)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E7C")]
	[Cpp2IlInjected.Address(RVA = "0x622A98", Offset = "0x622A98", VA = "0x622A98")]
	protected void OldDrawBackground()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E7D")]
	[Cpp2IlInjected.Address(RVA = "0x62B4B0", Offset = "0x62B4B0", VA = "0x62B4B0")]
	protected void RenderBackground()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E7E")]
	[Cpp2IlInjected.Address(RVA = "0x62C1C8", Offset = "0x62C1C8", VA = "0x62C1C8")]
	public static string ValueToCoins(long value)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001E7F")]
	[Cpp2IlInjected.Address(RVA = "0x62C580", Offset = "0x62C580", VA = "0x62C580")]
	private static void UpdateMinimapAnchors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E80")]
	[Cpp2IlInjected.Address(RVA = "0x62C698", Offset = "0x62C698", VA = "0x62C698")]
	private static void DrawMapFullscreenBackground(Vector2 screenPosition, int screenWidth, int screenHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E81")]
	[Cpp2IlInjected.Address(RVA = "0x62D3B4", Offset = "0x62D3B4", VA = "0x62D3B4")]
	public static bool DrawPlayerDeathMarker(float X, float Y, float scale, float left, float top, float headScale, int i)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E82")]
	[Cpp2IlInjected.Address(RVA = "0x62D7D4", Offset = "0x62D7D4", VA = "0x62D7D4")]
	public void DrawMiscMapIcons(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E83")]
	[Cpp2IlInjected.Address(RVA = "0x62DFFC", Offset = "0x62DFFC", VA = "0x62DFFC")]
	private void DrawMapIcons_PotionOfReturnAppearAfterUsePosition(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E84")]
	[Cpp2IlInjected.Address(RVA = "0x62D8E0", Offset = "0x62D8E0", VA = "0x62D8E0")]
	private void DrawMapIcons_PotionOfReturnHomePosition(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E85")]
	[Cpp2IlInjected.Address(RVA = "0x62E71C", Offset = "0x62E71C", VA = "0x62E71C")]
	private void DrawMapIcons_LastGolfballHit(SpriteBatch spriteBatch, Vector2 mapTopLeft, Vector2 mapX2Y2AndOff, Rectangle? mapRect, float mapScale, float drawScale, ref string mouseTextString)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E86")]
	[Cpp2IlInjected.Address(RVA = "0x62EE48", Offset = "0x62EE48", VA = "0x62EE48")]
	public static void TriggerPing(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E87")]
	[Cpp2IlInjected.Address(RVA = "0x62EF7C", Offset = "0x62EF7C", VA = "0x62EF7C")]
	public static void DrawNPCHeadFriendly(Entity theNPC, byte alpha, float headScale, SpriteEffects dir, int npcID, float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E88")]
	[Cpp2IlInjected.Address(RVA = "0x62FAA8", Offset = "0x62FAA8", VA = "0x62FAA8")]
	public static void DrawNPCHeadBoss(Entity theNPC, byte alpha, float headScale, float rotation, SpriteEffects effects, int npcID, float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E89")]
	[Cpp2IlInjected.Address(RVA = "0x62F1C4", Offset = "0x62F1C4", VA = "0x62F1C4")]
	private static void DrawWithOutlines(Entity entity, Texture2D tex, Vector2 position, Rectangle rect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E8A")]
	[Cpp2IlInjected.Address(RVA = "0x62FCF8", Offset = "0x62FCF8", VA = "0x62FCF8")]
	public static Color GetPlayerHeadBordersColor(Player plr)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E8B")]
	[Cpp2IlInjected.Address(RVA = "0x62FE4C", Offset = "0x62FE4C", VA = "0x62FE4C")]
	public static string DrawMap_FindChestName(LocalizedText[] chestNames, Tile chestTile, int x, int y, int fullTileWidth = 36)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001E8C")]
	[Cpp2IlInjected.Address(RVA = "0x62FFDC", Offset = "0x62FFDC", VA = "0x62FFDC")]
	public void DrawSimpleSurfaceBackground(Vector2 areaPosition, int areaWidth, int areaHeight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E8D")]
	[Cpp2IlInjected.Address(RVA = "0x6304C4", Offset = "0x6304C4", VA = "0x6304C4")]
	public void DrawCapture(Rectangle area, CaptureSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E8E")]
	[Cpp2IlInjected.Address(RVA = "0x642568", Offset = "0x642568", VA = "0x642568")]
	protected void RenderTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E8F")]
	[Cpp2IlInjected.Address(RVA = "0x642B04", Offset = "0x642B04", VA = "0x642B04")]
	protected void RenderTiles2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E90")]
	[Cpp2IlInjected.Address(RVA = "0x642E80", Offset = "0x642E80", VA = "0x642E80")]
	protected void RenderWater()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E91")]
	[Cpp2IlInjected.Address(RVA = "0x6430F8", Offset = "0x6430F8", VA = "0x6430F8")]
	public static int CalculateWaterStyle(bool ignoreFountains = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E92")]
	[Cpp2IlInjected.Address(RVA = "0x6435D0", Offset = "0x6435D0", VA = "0x6435D0")]
	public static bool IsLiquidStyleWater(int liquidStyle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E93")]
	[Cpp2IlInjected.Address(RVA = "0x62B9B0", Offset = "0x62B9B0", VA = "0x62B9B0")]
	private void DrawWaters(bool isBackground = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E94")]
	[Cpp2IlInjected.Address(RVA = "0x63E260", Offset = "0x63E260", VA = "0x63E260")]
	protected void DrawLiquid(bool bg = false, int Style = 0, float Alpha = 1f, bool drawSinglePassLiquids = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E95")]
	[Cpp2IlInjected.Address(RVA = "0x646124", Offset = "0x646124", VA = "0x646124")]
	public static void DrawTileInWater(SpriteBatch spriteBatch, Vector2 drawOffset, int x, int y, byte liquid, short frameX, short frameY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E96")]
	[Cpp2IlInjected.Address(RVA = "0x6435E8", Offset = "0x6435E8", VA = "0x6435E8")]
	public void oldDrawWater(bool bg = false, int Style = 0, float Alpha = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E97")]
	[Cpp2IlInjected.Address(RVA = "0x6463A8", Offset = "0x6463A8", VA = "0x6463A8")]
	protected bool FullTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E98")]
	[Cpp2IlInjected.Address(RVA = "0x63D110", Offset = "0x63D110", VA = "0x63D110")]
	protected void DrawBlack(bool force = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E99")]
	[Cpp2IlInjected.Address(RVA = "0x61A9F8", Offset = "0x61A9F8", VA = "0x61A9F8")]
	public static bool ShouldShowInvisibleWalls()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001E9A")]
	[Cpp2IlInjected.Address(RVA = "0x6428EC", Offset = "0x6428EC", VA = "0x6428EC")]
	protected void RenderBlack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E9B")]
	[Cpp2IlInjected.Address(RVA = "0x63E7B4", Offset = "0x63E7B4", VA = "0x63E7B4")]
	protected void DrawWalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E9C")]
	[Cpp2IlInjected.Address(RVA = "0x6467F4", Offset = "0x6467F4", VA = "0x6467F4")]
	protected void RenderWalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E9D")]
	[Cpp2IlInjected.Address(RVA = "0x646B80", Offset = "0x646B80", VA = "0x646B80")]
	protected void ReleaseTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E9E")]
	[Cpp2IlInjected.Address(RVA = "0x646ED0", Offset = "0x646ED0", VA = "0x646ED0")]
	protected void InitTargets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001E9F")]
	[Cpp2IlInjected.Address(RVA = "0x647108", Offset = "0x647108", VA = "0x647108")]
	protected void EnsureRenderTargetContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA0")]
	[Cpp2IlInjected.Address(RVA = "0x64702C", Offset = "0x64702C", VA = "0x64702C")]
	protected void InitTargets(int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA1")]
	[Cpp2IlInjected.Address(RVA = "0x63E7C0", Offset = "0x63E7C0", VA = "0x63E7C0")]
	protected void DrawWires()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA2")]
	[Cpp2IlInjected.Address(RVA = "0x6471E4", Offset = "0x6471E4", VA = "0x6471E4")]
	public static int ConvertPaintIdToTileShaderIndex(int paintIndexOnTile, bool isUsedForPaintingGrass, bool useWallShaderHacks)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA3")]
	[Cpp2IlInjected.Address(RVA = "0x64723C", Offset = "0x64723C", VA = "0x64723C")]
	public static void ResetWindCounter(bool resetExtreme = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA4")]
	[Cpp2IlInjected.Address(RVA = "0x64733C", Offset = "0x64733C", VA = "0x64733C")]
	public static void NewLightning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA5")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE38", Offset = "0x4EAE38", VA = "0x4EAE38")]
	public void UpdateWeather(GameTime gameTime, int currentDayRateIteration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA6")]
	[Cpp2IlInjected.Address(RVA = "0x62AE9C", Offset = "0x62AE9C", VA = "0x62AE9C")]
	public void LoadBackground(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA7")]
	[Cpp2IlInjected.Address(RVA = "0x57DE10", Offset = "0x57DE10", VA = "0x57DE10")]
	public void LoadItem(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA8")]
	[Cpp2IlInjected.Address(RVA = "0x579E18", Offset = "0x579E18", VA = "0x579E18")]
	public void LoadNPC(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EA9")]
	[Cpp2IlInjected.Address(RVA = "0x57515C", Offset = "0x57515C", VA = "0x57515C")]
	public void LoadProjectile(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EAA")]
	[Cpp2IlInjected.Address(RVA = "0x503F58", Offset = "0x503F58", VA = "0x503F58")]
	public void LoadGore(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EAB")]
	[Cpp2IlInjected.Address(RVA = "0x6475F4", Offset = "0x6475F4", VA = "0x6475F4")]
	public void LoadWall(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EAC")]
	[Cpp2IlInjected.Address(RVA = "0x64783C", Offset = "0x64783C", VA = "0x64783C")]
	public void LoadTiles(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EAD")]
	[Cpp2IlInjected.Address(RVA = "0x647A84", Offset = "0x647A84", VA = "0x647A84")]
	public void LoadItemFlames(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EAE")]
	[Cpp2IlInjected.Address(RVA = "0x647CAC", Offset = "0x647CAC", VA = "0x647CAC")]
	public void LoadWings(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EAF")]
	[Cpp2IlInjected.Address(RVA = "0x647E48", Offset = "0x647E48", VA = "0x647E48")]
	public void LoadHair(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB0")]
	[Cpp2IlInjected.Address(RVA = "0x6480C0", Offset = "0x6480C0", VA = "0x6480C0")]
	public void LoadArmorHead(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB1")]
	[Cpp2IlInjected.Address(RVA = "0x64825C", Offset = "0x64825C", VA = "0x64825C")]
	public void LoadArmorBody(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB2")]
	[Cpp2IlInjected.Address(RVA = "0x648724", Offset = "0x648724", VA = "0x648724")]
	public void LoadArmorLegs(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB3")]
	[Cpp2IlInjected.Address(RVA = "0x6488C0", Offset = "0x6488C0", VA = "0x6488C0")]
	public void LoadAccHandsOn(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB4")]
	[Cpp2IlInjected.Address(RVA = "0x648C58", Offset = "0x648C58", VA = "0x648C58")]
	public void LoadAccHandsOff(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB5")]
	[Cpp2IlInjected.Address(RVA = "0x648FDC", Offset = "0x648FDC", VA = "0x648FDC")]
	public void LoadAccBack(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB6")]
	[Cpp2IlInjected.Address(RVA = "0x649178", Offset = "0x649178", VA = "0x649178")]
	public void LoadAccFront(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB7")]
	[Cpp2IlInjected.Address(RVA = "0x649314", Offset = "0x649314", VA = "0x649314")]
	public void LoadAccShoes(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB8")]
	[Cpp2IlInjected.Address(RVA = "0x6494B0", Offset = "0x6494B0", VA = "0x6494B0")]
	public void LoadAccWaist(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EB9")]
	[Cpp2IlInjected.Address(RVA = "0x64964C", Offset = "0x64964C", VA = "0x64964C")]
	public void LoadAccShield(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EBA")]
	[Cpp2IlInjected.Address(RVA = "0x6497E8", Offset = "0x6497E8", VA = "0x6497E8")]
	public void LoadAccNeck(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EBB")]
	[Cpp2IlInjected.Address(RVA = "0x649984", Offset = "0x649984", VA = "0x649984")]
	public void LoadAccFace(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EBC")]
	[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x649B20", VA = "0x649B20")]
	public void LoadAccBalloon(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EBD")]
	[Cpp2IlInjected.Address(RVA = "0x649CBC", Offset = "0x649CBC", VA = "0x649CBC")]
	public void LoadAccBeard(int i)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EBE")]
	[Cpp2IlInjected.Address(RVA = "0x649E58", Offset = "0x649E58", VA = "0x649E58")]
	public void LoadFlameRing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EBF")]
	[Cpp2IlInjected.Address(RVA = "0x638B88", Offset = "0x638B88", VA = "0x638B88")]
	protected void DrawSurfaceBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC0")]
	[Cpp2IlInjected.Address(RVA = "0x654C9C", Offset = "0x654C9C", VA = "0x654C9C")]
	private static float DrawSurfaceBG_GetFogPower()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC1")]
	[Cpp2IlInjected.Address(RVA = "0x654D70", Offset = "0x654D70", VA = "0x654D70")]
	private void DrawSurfaceBG_DrawBackMountainsLayer(int bgTextureIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC2")]
	[Cpp2IlInjected.Address(RVA = "0x654F78", Offset = "0x654F78", VA = "0x654F78")]
	private int DrawSurfaceBG_GetLayerYOffset(int bgTextureIndex)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC3")]
	[Cpp2IlInjected.Address(RVA = "0x6553A8", Offset = "0x6553A8", VA = "0x6553A8")]
	private float GetForestToForestBackgroundLerperValue()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC4")]
	[Cpp2IlInjected.Address(RVA = "0x649FE0", Offset = "0x649FE0", VA = "0x649FE0")]
	private void DrawSurfaceBG_BackMountainsStep1(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC5")]
	[Cpp2IlInjected.Address(RVA = "0x64B73C", Offset = "0x64B73C", VA = "0x64B73C")]
	private void DrawSurfaceBG_BackMountainsStep2(int pushBGTopHack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC6")]
	[Cpp2IlInjected.Address(RVA = "0x65548C", Offset = "0x65548C", VA = "0x65548C")]
	private void UpdateOceanWaterLineForAmbience()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC7")]
	[Cpp2IlInjected.Address(RVA = "0x653818", Offset = "0x653818", VA = "0x653818")]
	private void DrawSurfaceBG_Mushroom(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC8")]
	[Cpp2IlInjected.Address(RVA = "0x6528A8", Offset = "0x6528A8", VA = "0x6528A8")]
	private void DrawSurfaceBG_Crimson(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EC9")]
	[Cpp2IlInjected.Address(RVA = "0x6519A8", Offset = "0x6519A8", VA = "0x6519A8")]
	private void DrawSurfaceBG_Snow(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ECA")]
	[Cpp2IlInjected.Address(RVA = "0x64AAC8", Offset = "0x64AAC8", VA = "0x64AAC8")]
	private void SetBackgroundOffsets(int backgroundID, double backgroundTopMagicNumber, int pushBGTopHack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ECB")]
	[Cpp2IlInjected.Address(RVA = "0x650C30", Offset = "0x650C30", VA = "0x650C30")]
	private void DrawSurfaceBG_Hallow(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ECC")]
	[Cpp2IlInjected.Address(RVA = "0x650318", Offset = "0x650318", VA = "0x650318")]
	private void DrawSurfaceBG_GoodEvilDesert(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ECD")]
	[Cpp2IlInjected.Address(RVA = "0x64F558", Offset = "0x64F558", VA = "0x64F558")]
	private void DrawSurfaceBG_Jungle(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ECE")]
	[Cpp2IlInjected.Address(RVA = "0x64E6E0", Offset = "0x64E6E0", VA = "0x64E6E0")]
	private void DrawSurfaceBG_Desert(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ECF")]
	[Cpp2IlInjected.Address(RVA = "0x617E9C", Offset = "0x617E9C", VA = "0x617E9C")]
	private void DrawSurfaceBG_DrawChangeOverlay(int backgroundAreaId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED0")]
	[Cpp2IlInjected.Address(RVA = "0x64D4B8", Offset = "0x64D4B8", VA = "0x64D4B8")]
	private void DrawSurfaceBG_Corrupt(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED1")]
	[Cpp2IlInjected.Address(RVA = "0x655068", Offset = "0x655068", VA = "0x655068")]
	private Rectangle? GetBackgroundRect(int backgroundTextureIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED2")]
	[Cpp2IlInjected.Address(RVA = "0x655610", Offset = "0x655610", VA = "0x655610")]
	private uint GetBackgroundCounter()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED3")]
	[Cpp2IlInjected.Address(RVA = "0x64C180", Offset = "0x64C180", VA = "0x64C180")]
	private void DrawSurfaceBG_Forest(double backgroundTopMagicNumber, float bgGlobalScaleMultiplier, int pushBGTopHack, int[] bgTexIndexes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED4")]
	[Cpp2IlInjected.Address(RVA = "0x655760", Offset = "0x655760", VA = "0x655760")]
	private void DrawBackgroundBlackFill()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED5")]
	[Cpp2IlInjected.Address(RVA = "0x6559D4", Offset = "0x6559D4", VA = "0x6559D4")]
	public void DrawTileCracks(int crackType, HitTile hitter)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED6")]
	[Cpp2IlInjected.Address(RVA = "0x65666C", Offset = "0x65666C", VA = "0x65666C")]
	private static void CheckMonoliths()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED8")]
	[Cpp2IlInjected.Address(RVA = "0x6571C4", Offset = "0x6571C4", VA = "0x6571C4")]
	private void GraphicsDeviceLost(object sender, EventArgs evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001ED9")]
	[Cpp2IlInjected.Address(RVA = "0x6571C8", Offset = "0x6571C8", VA = "0x6571C8", Slot = "6")]
	protected override void Draw(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EDA")]
	[Cpp2IlInjected.Address(RVA = "0x657390", Offset = "0x657390", VA = "0x657390")]
	private void DoDraw(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EDB")]
	[Cpp2IlInjected.Address(RVA = "0x665C74", Offset = "0x665C74", VA = "0x665C74")]
	private static void DrawItemTextPopups(float scaleTarget)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EDC")]
	[Cpp2IlInjected.Address(RVA = "0x6602AC", Offset = "0x6602AC", VA = "0x6602AC")]
	private static void DoDraw_UpdateCameraPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EDD")]
	[Cpp2IlInjected.Address(RVA = "0x666D44", Offset = "0x666D44", VA = "0x666D44")]
	public static bool IsItDay()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EDE")]
	[Cpp2IlInjected.Address(RVA = "0x666E00", Offset = "0x666E00", VA = "0x666E00")]
	public static double starGameMath(double value = 1.0)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EDF")]
	[Cpp2IlInjected.Address(RVA = "0x636430", Offset = "0x636430", VA = "0x636430")]
	private void DrawSunAndMoon(SceneArea sceneArea, Color moonColor, Color sunColor, float tempMushroomInfluence)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE0")]
	[Cpp2IlInjected.Address(RVA = "0x635F40", Offset = "0x635F40", VA = "0x635F40")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390500", Offset = "0x390500")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x390500", Offset = "0x390500")]
	private void DrawStarsInBackground(SceneArea sceneArea, bool artificial)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE1")]
	[Cpp2IlInjected.Address(RVA = "0x664E88", Offset = "0x664E88", VA = "0x664E88")]
	private void DrawStarsInForeground(SceneArea sceneArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE2")]
	[Cpp2IlInjected.Address(RVA = "0x666F00", Offset = "0x666F00", VA = "0x666F00")]
	private void DrawStar(ref SceneArea sceneArea, float starOpacity, Color bgColorForStars, int i, Star theStar, bool artificial, bool foreground = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE3")]
	[Cpp2IlInjected.Address(RVA = "0x635DF8", Offset = "0x635DF8", VA = "0x635DF8")]
	private static void ApplyColorOfTheSkiesToTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE4")]
	[Cpp2IlInjected.Address(RVA = "0x663988", Offset = "0x663988", VA = "0x663988")]
	private static void UpdateAtmosphereTransparencyToSkyColor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE5")]
	[Cpp2IlInjected.Address(RVA = "0x667E14", Offset = "0x667E14", VA = "0x667E14")]
	private void Debug_PrettifyMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE6")]
	[Cpp2IlInjected.Address(RVA = "0x666A0C", Offset = "0x666A0C", VA = "0x666A0C")]
	private static void DrawNetplayStatusText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE7")]
	[Cpp2IlInjected.Address(RVA = "0x665724", Offset = "0x665724", VA = "0x665724")]
	private void DrawPlayerChatBubbles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE8")]
	[Cpp2IlInjected.Address(RVA = "0x667E18", Offset = "0x667E18", VA = "0x667E18")]
	private void DrawRainInMenu()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EE9")]
	[Cpp2IlInjected.Address(RVA = "0x6645FC", Offset = "0x6645FC", VA = "0x6645FC")]
	private void DoDraw_WallsTilesNPCs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EEA")]
	[Cpp2IlInjected.Address(RVA = "0x668FD4", Offset = "0x668FD4", VA = "0x668FD4")]
	private void DoDraw_Waterfalls()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EEB")]
	[Cpp2IlInjected.Address(RVA = "0x669514", Offset = "0x669514", VA = "0x669514")]
	private void DoDraw_Tiles_Solid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EEC")]
	[Cpp2IlInjected.Address(RVA = "0x668878", Offset = "0x668878", VA = "0x668878")]
	private void DoDraw_Tiles_NonSolid()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EED")]
	[Cpp2IlInjected.Address(RVA = "0x669F08", Offset = "0x669F08", VA = "0x669F08")]
	private void DoDraw_DrawNPCsOverTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EEE")]
	[Cpp2IlInjected.Address(RVA = "0x66906C", Offset = "0x66906C", VA = "0x66906C")]
	private void DoDraw_DrawNPCsBehindTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EEF")]
	[Cpp2IlInjected.Address(RVA = "0x668714", Offset = "0x668714", VA = "0x668714")]
	private void DrawBackGore()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF0")]
	[Cpp2IlInjected.Address(RVA = "0x668240", Offset = "0x668240", VA = "0x668240")]
	private void DoDraw_WallsAndBlacks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF1")]
	[Cpp2IlInjected.Address(RVA = "0x634460", Offset = "0x634460", VA = "0x634460")]
	private static void SetBackColor(InfoToSetBackColor info, out Color sunColor, out Color moonColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF2")]
	[Cpp2IlInjected.Address(RVA = "0x66A3D4", Offset = "0x66A3D4", VA = "0x66A3D4")]
	public static void GetAreaToLight(out int firstTileX, out int lastTileX, out int firstTileY, out int lastTileY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF3")]
	[Cpp2IlInjected.Address(RVA = "0x663748", Offset = "0x663748", VA = "0x663748")]
	private void DoLightTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF4")]
	[Cpp2IlInjected.Address(RVA = "0x666AC8", Offset = "0x666AC8", VA = "0x666AC8")]
	private static void ClampScreenPositionToWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF5")]
	[Cpp2IlInjected.Address(RVA = "0x663D18", Offset = "0x663D18", VA = "0x663D18")]
	private void DrawBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF6")]
	[Cpp2IlInjected.Address(RVA = "0x6341FC", Offset = "0x6341FC", VA = "0x6341FC")]
	private void UpdateBGVisibility_FrontLayer(int? targetBiomeOverride, float? transitionAmountOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF7")]
	[Cpp2IlInjected.Address(RVA = "0x633F20", Offset = "0x633F20", VA = "0x633F20")]
	private void UpdateBGVisibility_BackLayer(int? targetBiomeOverride, float? transitionAmountOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF8")]
	[Cpp2IlInjected.Address(RVA = "0x66A610", Offset = "0x66A610", VA = "0x66A610")]
	public static int GetPreferredBGStyleForPlayer()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EF9")]
	[Cpp2IlInjected.Address(RVA = "0x66AD68", Offset = "0x66AD68", VA = "0x66AD68")]
	private void DrawBG_ModifyBGFarBackLayerAlpha(int desiredBG, [Optional] int? desiredBG2, [Optional] float? transitionAmountOverride)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EFA")]
	[Cpp2IlInjected.Address(RVA = "0x664E8C", Offset = "0x664E8C", VA = "0x664E8C")]
	public void DrawInfernoRings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EFB")]
	[Cpp2IlInjected.Address(RVA = "0x4F3384", Offset = "0x4F3384", VA = "0x4F3384")]
	private static void UpdateInvasion()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EFC")]
	[Cpp2IlInjected.Address(RVA = "0x66AF14", Offset = "0x66AF14", VA = "0x66AF14")]
	private static void InvasionWarning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EFD")]
	[Cpp2IlInjected.Address(RVA = "0x66B850", Offset = "0x66B850", VA = "0x66B850")]
	public static bool CanStartInvasion(int type = 1, bool ignoreDelay = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001EFE")]
	[Cpp2IlInjected.Address(RVA = "0x66B9DC", Offset = "0x66B9DC", VA = "0x66B9DC")]
	public static void StartInvasion(int type = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001EFF")]
	[Cpp2IlInjected.Address(RVA = "0x66BDCC", Offset = "0x66BDCC", VA = "0x66BDCC")]
	public static void FakeLoadInvasionStart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F00")]
	[Cpp2IlInjected.Address(RVA = "0x4F434C", Offset = "0x4F434C", VA = "0x4F434C")]
	private static void UpdateClient()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F01")]
	[Cpp2IlInjected.Address(RVA = "0x4F4930", Offset = "0x4F4930", VA = "0x4F4930")]
	private static void CheckPlayerItemOwnership()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F02")]
	[Cpp2IlInjected.Address(RVA = "0x4F4A6C", Offset = "0x4F4A6C", VA = "0x4F4A6C")]
	private static void CheckAssignItemOwnership()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F03")]
	[Cpp2IlInjected.Address(RVA = "0x4F3A10", Offset = "0x4F3A10", VA = "0x4F3A10")]
	private static void UpdateServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F04")]
	[Cpp2IlInjected.Address(RVA = "0x4C9600", Offset = "0x4C9600", VA = "0x4C9600")]
	public static void NewText(string newText, byte R = byte.MaxValue, byte G = byte.MaxValue, byte B = byte.MaxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F05")]
	[Cpp2IlInjected.Address(RVA = "0x66BF60", Offset = "0x66BF60", VA = "0x66BF60")]
	public static void NewTextMultiline(string text, bool force = false, [Optional] Color c, int WidthLimit = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F06")]
	[Cpp2IlInjected.Address(RVA = "0x66C0A4", Offset = "0x66C0A4", VA = "0x66C0A4")]
	public static void StopRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F07")]
	[Cpp2IlInjected.Address(RVA = "0x66C130", Offset = "0x66C130", VA = "0x66C130")]
	public static void StartRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F08")]
	[Cpp2IlInjected.Address(RVA = "0x66C62C", Offset = "0x66C62C", VA = "0x66C62C")]
	private static void ChangeRain()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F09")]
	[Cpp2IlInjected.Address(RVA = "0x66C96C", Offset = "0x66C96C", VA = "0x66C96C")]
	public static void StartSlimeRain(bool announce = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F0A")]
	[Cpp2IlInjected.Address(RVA = "0x6131D8", Offset = "0x6131D8", VA = "0x6131D8")]
	public static void StopSlimeRain(bool announce = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F0B")]
	[Cpp2IlInjected.Address(RVA = "0x4F0E60", Offset = "0x4F0E60", VA = "0x4F0E60")]
	private static void UpdateTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F0C")]
	[Cpp2IlInjected.Address(RVA = "0x673094", Offset = "0x673094", VA = "0x673094")]
	public static bool AnyPlayerReadyToFightKingSlime()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F0D")]
	[Cpp2IlInjected.Address(RVA = "0x6731B0", Offset = "0x6731B0", VA = "0x6731B0")]
	public static void SkipToTime(int timeToSet, bool setIsDayTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F0E")]
	[Cpp2IlInjected.Address(RVA = "0x66D3BC", Offset = "0x66D3BC", VA = "0x66D3BC")]
	public static bool ShouldNormalEventsBeAbleToStart()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F0F")]
	[Cpp2IlInjected.Address(RVA = "0x66E4CC", Offset = "0x66E4CC", VA = "0x66E4CC")]
	public static void UpdateTime_StartNight(ref bool stopEvents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F10")]
	[Cpp2IlInjected.Address(RVA = "0x66D4B0", Offset = "0x66D4B0", VA = "0x66D4B0")]
	public static void UpdateTime_StartDay(ref bool stopEvents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F11")]
	[Cpp2IlInjected.Address(RVA = "0x66E200", Offset = "0x66E200", VA = "0x66E200")]
	private static void HandleMeteorFall()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F12")]
	[Cpp2IlInjected.Address(RVA = "0x66CEB0", Offset = "0x66CEB0", VA = "0x66CEB0")]
	private static void UpdateSlimeRainWarning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F13")]
	[Cpp2IlInjected.Address(RVA = "0x6733B0", Offset = "0x6733B0", VA = "0x6733B0")]
	public static BestiaryUnlockProgressReport GetBestiaryProgressReport()
	{
		return default(BestiaryUnlockProgressReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F14")]
	[Cpp2IlInjected.Address(RVA = "0x66FACC", Offset = "0x66FACC", VA = "0x66FACC")]
	private static void UpdateTime_SpawnTownNPCs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F15")]
	[Cpp2IlInjected.Address(RVA = "0x673548", Offset = "0x673548", VA = "0x673548")]
	public static int DamageVar(float dmg, float luck = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F16")]
	[Cpp2IlInjected.Address(RVA = "0x67388C", Offset = "0x67388C", VA = "0x67388C")]
	public static double CalculateDamageNPCsTake(int Damage, int Defense)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F17")]
	[Cpp2IlInjected.Address(RVA = "0x6738BC", Offset = "0x6738BC", VA = "0x6738BC")]
	public static double CalculateDamagePlayersTakeInPVP(int Damage, int Defense)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F18")]
	[Cpp2IlInjected.Address(RVA = "0x6738EC", Offset = "0x6738EC", VA = "0x6738EC")]
	public static double CalculateDamagePlayersTake(int Damage, int Defense)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6001F19")]
	[Cpp2IlInjected.Address(RVA = "0x6739E4", Offset = "0x6739E4", VA = "0x6739E4")]
	public void OnTileChangeEvent(int x, int y, int count, TileChangeType eventType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F1A")]
	[Cpp2IlInjected.Address(RVA = "0x49FB24", Offset = "0x49FB24", VA = "0x49FB24")]
	public static void ClearPendingPlayerSelectCallbacks()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F1B")]
	[Cpp2IlInjected.Address(RVA = "0x673A84", Offset = "0x673A84", VA = "0x673A84")]
	public static void SelectPlayer(PlayerFileData data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F1C")]
	[Cpp2IlInjected.Address(RVA = "0x4F5120", Offset = "0x4F5120", VA = "0x4F5120")]
	public static void ToggleFullScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F1D")]
	[Cpp2IlInjected.Address(RVA = "0x49C6E4", Offset = "0x49C6E4", VA = "0x49C6E4")]
	public static void SetFullScreen(bool fullscreen)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F1E")]
	[Cpp2IlInjected.Address(RVA = "0x673E8C", Offset = "0x673E8C", VA = "0x673E8C")]
	public static void SetResolution(int width, int height)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F1F")]
	[Cpp2IlInjected.Address(RVA = "0x49B14C", Offset = "0x49B14C", VA = "0x49B14C")]
	public static void SetDisplayMode(int width, int height, bool fullscreen)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F20")]
	[Cpp2IlInjected.Address(RVA = "0x492198", Offset = "0x492198", VA = "0x492198")]
	public static void FixUIScale()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F21")]
	[Cpp2IlInjected.Address(RVA = "0x673F24", Offset = "0x673F24", VA = "0x673F24")]
	public void FullscreenStartup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F22")]
	[Cpp2IlInjected.Address(RVA = "0x646F70", Offset = "0x646F70", VA = "0x646F70")]
	public void UpdateDisplaySettings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F23")]
	[Cpp2IlInjected.Address(RVA = "0x674020", Offset = "0x674020", VA = "0x674020")]
	public static void SwitchNetMode(int mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001F24")]
	[Cpp2IlInjected.Address(RVA = "0x6740B0", Offset = "0x6740B0", VA = "0x6740B0")]
	public static void WeGameRequireExitGame()
	{
	}
}
