using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameInput;

[Cpp2IlInjected.Token(Token = "0x20004B2")]
public class LockOnHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000940")]
	public enum LockOnMode
	{
		[Cpp2IlInjected.Token(Token = "0x4008ADE")]
		FocusTarget,
		[Cpp2IlInjected.Token(Token = "0x4008ADF")]
		TargetClosest,
		[Cpp2IlInjected.Token(Token = "0x4008AE0")]
		ThreeDS
	}

	[Cpp2IlInjected.Token(Token = "0x40065C9")]
	private const float LOCKON_RANGE = 2000f;

	[Cpp2IlInjected.Token(Token = "0x40065CA")]
	private const int LOCKON_HOLD_LIFETIME = 40;

	[Cpp2IlInjected.Token(Token = "0x40065CB")]
	private static List<int> tempTargets;

	[Cpp2IlInjected.Token(Token = "0x17000658")]
	public static LockOnMode UseMode
	{
		[Cpp2IlInjected.Token(Token = "0x6003428")]
		[Cpp2IlInjected.Address(RVA = "0xE18270", Offset = "0xE18270", VA = "0xE18270")]
		get
		{
			return default(LockOnMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6003429")]
		[Cpp2IlInjected.Address(RVA = "0xE18288", Offset = "0xE18288", VA = "0xE18288")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000659")]
	private static bool _enabled
	{
		[Cpp2IlInjected.Token(Token = "0x600342A")]
		[Cpp2IlInjected.Address(RVA = "0xE182A4", Offset = "0xE182A4", VA = "0xE182A4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600342B")]
		[Cpp2IlInjected.Address(RVA = "0xE182BC", Offset = "0xE182BC", VA = "0xE182BC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700065A")]
	private static bool _canLockOn
	{
		[Cpp2IlInjected.Token(Token = "0x600342C")]
		[Cpp2IlInjected.Address(RVA = "0xE182D8", Offset = "0xE182D8", VA = "0xE182D8")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600342D")]
		[Cpp2IlInjected.Address(RVA = "0xE182F0", Offset = "0xE182F0", VA = "0xE182F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700065B")]
	private static List<int> _targets
	{
		[Cpp2IlInjected.Token(Token = "0x600342E")]
		[Cpp2IlInjected.Address(RVA = "0xE1830C", Offset = "0xE1830C", VA = "0xE1830C")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600342F")]
		[Cpp2IlInjected.Address(RVA = "0xE18324", Offset = "0xE18324", VA = "0xE18324")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700065C")]
	private static int _pickedTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6003430")]
		[Cpp2IlInjected.Address(RVA = "0xE18340", Offset = "0xE18340", VA = "0xE18340")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003431")]
		[Cpp2IlInjected.Address(RVA = "0xE18358", Offset = "0xE18358", VA = "0xE18358")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700065D")]
	private static int _lifeTimeCounter
	{
		[Cpp2IlInjected.Token(Token = "0x6003432")]
		[Cpp2IlInjected.Address(RVA = "0xE18374", Offset = "0xE18374", VA = "0xE18374")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003433")]
		[Cpp2IlInjected.Address(RVA = "0xE1838C", Offset = "0xE1838C", VA = "0xE1838C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700065E")]
	private static int _lifeTimeArrowDisplay
	{
		[Cpp2IlInjected.Token(Token = "0x6003434")]
		[Cpp2IlInjected.Address(RVA = "0xE183A8", Offset = "0xE183A8", VA = "0xE183A8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003435")]
		[Cpp2IlInjected.Address(RVA = "0xE183C0", Offset = "0xE183C0", VA = "0xE183C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700065F")]
	private static int _threeDSTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6003436")]
		[Cpp2IlInjected.Address(RVA = "0xE183DC", Offset = "0xE183DC", VA = "0xE183DC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003437")]
		[Cpp2IlInjected.Address(RVA = "0xE183F4", Offset = "0xE183F4", VA = "0xE183F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000660")]
	private static int _targetClosestTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6003438")]
		[Cpp2IlInjected.Address(RVA = "0xE18410", Offset = "0xE18410", VA = "0xE18410")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003439")]
		[Cpp2IlInjected.Address(RVA = "0xE18428", Offset = "0xE18428", VA = "0xE18428")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000661")]
	public static bool ForceUsability
	{
		[Cpp2IlInjected.Token(Token = "0x600343A")]
		[Cpp2IlInjected.Address(RVA = "0xE18444", Offset = "0xE18444", VA = "0xE18444")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600343B")]
		[Cpp2IlInjected.Address(RVA = "0xE1845C", Offset = "0xE1845C", VA = "0xE1845C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000662")]
	public static bool LockOnAvailable
	{
		[Cpp2IlInjected.Token(Token = "0x600343C")]
		[Cpp2IlInjected.Address(RVA = "0xE18478", Offset = "0xE18478", VA = "0xE18478")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600343D")]
		[Cpp2IlInjected.Address(RVA = "0xE18490", Offset = "0xE18490", VA = "0xE18490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000663")]
	private static int _lastFrame
	{
		[Cpp2IlInjected.Token(Token = "0x600343E")]
		[Cpp2IlInjected.Address(RVA = "0xE184AC", Offset = "0xE184AC", VA = "0xE184AC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600343F")]
		[Cpp2IlInjected.Address(RVA = "0xE184C4", Offset = "0xE184C4", VA = "0xE184C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000664")]
	private static float[,] _drawProgress
	{
		[Cpp2IlInjected.Token(Token = "0x6003440")]
		[Cpp2IlInjected.Address(RVA = "0xE184E0", Offset = "0xE184E0", VA = "0xE184E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003441")]
		[Cpp2IlInjected.Address(RVA = "0xE184F8", Offset = "0xE184F8", VA = "0xE184F8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000665")]
	public static NPC AimedTarget
	{
		[Cpp2IlInjected.Token(Token = "0x6003443")]
		[Cpp2IlInjected.Address(RVA = "0xE185E0", Offset = "0xE185E0", VA = "0xE185E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000666")]
	public static Vector2 PredictedPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6003444")]
		[Cpp2IlInjected.Address(RVA = "0xE18740", Offset = "0xE18740", VA = "0xE18740")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000667")]
	public static bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x600344B")]
		[Cpp2IlInjected.Address(RVA = "0xE1A2A8", Offset = "0xE1A2A8", VA = "0xE1A2A8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000668")]
	public static Vector2 MouseWorld
	{
		[Cpp2IlInjected.Token(Token = "0x600344C")]
		[Cpp2IlInjected.Address(RVA = "0xE1A320", Offset = "0xE1A320", VA = "0xE1A320")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003442")]
	[Cpp2IlInjected.Address(RVA = "0xE18514", Offset = "0xE18514", VA = "0xE18514")]
	public static void CycleUseModes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003445")]
	[Cpp2IlInjected.Address(RVA = "0xE18EEC", Offset = "0xE18EEC", VA = "0xE18EEC")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003446")]
	[Cpp2IlInjected.Address(RVA = "0xE196C8", Offset = "0xE196C8", VA = "0xE196C8")]
	public static bool CanUseLockonSystem()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003447")]
	[Cpp2IlInjected.Address(RVA = "0xE19E38", Offset = "0xE19E38", VA = "0xE19E38")]
	public static void SetUP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003448")]
	[Cpp2IlInjected.Address(RVA = "0xE1A078", Offset = "0xE1A078", VA = "0xE1A078")]
	public static void SetDOWN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003449")]
	[Cpp2IlInjected.Address(RVA = "0xE19E18", Offset = "0xE19E18", VA = "0xE19E18")]
	private static bool ShouldLockOn(Player p)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600344A")]
	[Cpp2IlInjected.Address(RVA = "0xE1A1DC", Offset = "0xE1A1DC", VA = "0xE1A1DC")]
	public static void Toggle(bool forceOff = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600344D")]
	[Cpp2IlInjected.Address(RVA = "0xE198C8", Offset = "0xE198C8", VA = "0xE198C8")]
	private static void FindMostViableTarget(LockOnMode context, ref int targetVar)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600344E")]
	[Cpp2IlInjected.Address(RVA = "0xE19B14", Offset = "0xE19B14", VA = "0xE19B14")]
	private static void HandlePressing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600344F")]
	[Cpp2IlInjected.Address(RVA = "0xE1B2A8", Offset = "0xE1B2A8", VA = "0xE1B2A8")]
	private static void CycleTargetFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003450")]
	[Cpp2IlInjected.Address(RVA = "0xE1B0A0", Offset = "0xE1B0A0", VA = "0xE1B0A0")]
	private static void CycleTargetThreeDS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003451")]
	[Cpp2IlInjected.Address(RVA = "0xE19D84", Offset = "0xE19D84", VA = "0xE19D84")]
	private static bool CanEnable()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003452")]
	[Cpp2IlInjected.Address(RVA = "0xE196D0", Offset = "0xE196D0", VA = "0xE196D0")]
	private static void SetActive(bool on)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003453")]
	[Cpp2IlInjected.Address(RVA = "0xE1A4DC", Offset = "0xE1A4DC", VA = "0xE1A4DC")]
	private static void RefreshTargets(Vector2 position, float radius)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003454")]
	[Cpp2IlInjected.Address(RVA = "0xE1ABB8", Offset = "0xE1ABB8", VA = "0xE1ABB8")]
	private static void GetClosestTarget(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003455")]
	[Cpp2IlInjected.Address(RVA = "0xE19CEC", Offset = "0xE19CEC", VA = "0xE19CEC")]
	private static bool ValidTarget(NPC n)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003456")]
	[Cpp2IlInjected.Address(RVA = "0xE19F94", Offset = "0xE19F94", VA = "0xE19F94")]
	private static void SetLockPosition(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003457")]
	[Cpp2IlInjected.Address(RVA = "0xE1A120", Offset = "0xE1A120", VA = "0xE1A120")]
	private static void ResetLockPosition()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003458")]
	[Cpp2IlInjected.Address(RVA = "0xE1B820", Offset = "0xE1B820", VA = "0xE1B820")]
	public static void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003459")]
	[Cpp2IlInjected.Address(RVA = "0xE1CD1C", Offset = "0xE1CD1C", VA = "0xE1CD1C")]
	public LockOnHelper()
	{
	}
}
