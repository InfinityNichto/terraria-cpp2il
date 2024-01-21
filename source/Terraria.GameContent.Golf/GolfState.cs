using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf;

[Cpp2IlInjected.Token(Token = "0x200067E")]
public class GolfState
{
	[Cpp2IlInjected.Token(Token = "0x4006DA8")]
	private const int BALL_RETURN_PENALTY = 1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006DA9")]
	private int golfScoreTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006DAA")]
	private int golfScoreTimeMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006DAB")]
	private int golfScoreDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006DAC")]
	private double _lastRecordedBallTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006DAD")]
	private Vector2? _lastRecordedBallLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006DAE")]
	private bool _waitingForBallToSettle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4006DAF")]
	private Vector2 _lastSwingPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4006DB0")]
	private Projectile _lastHitGolfBall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4006DB1")]
	private int _lastRecordedSwingCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4006DB2")]
	private GolfBallTrackRecord[] _hitRecords;

	[Cpp2IlInjected.Token(Token = "0x17000790")]
	public float ScoreAdjustment
	{
		[Cpp2IlInjected.Token(Token = "0x6004181")]
		[Cpp2IlInjected.Address(RVA = "0xE70444", Offset = "0xE70444", VA = "0xE70444")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000791")]
	public bool ShouldScoreHole
	{
		[Cpp2IlInjected.Token(Token = "0x6004182")]
		[Cpp2IlInjected.Address(RVA = "0xE6E52C", Offset = "0xE6E52C", VA = "0xE6E52C")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000792")]
	public bool IsTrackingBall
	{
		[Cpp2IlInjected.Token(Token = "0x6004183")]
		[Cpp2IlInjected.Address(RVA = "0xE70460", Offset = "0xE70460", VA = "0xE70460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000793")]
	public bool ShouldCameraTrackBallLastKnownLocation
	{
		[Cpp2IlInjected.Token(Token = "0x6004184")]
		[Cpp2IlInjected.Address(RVA = "0xE705B8", Offset = "0xE705B8", VA = "0xE705B8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600417E")]
	[Cpp2IlInjected.Address(RVA = "0xE70430", Offset = "0xE70430", VA = "0xE70430")]
	private void UpdateScoreTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600417F")]
	[Cpp2IlInjected.Address(RVA = "0xE6EDA8", Offset = "0xE6EDA8", VA = "0xE6EDA8")]
	public void ResetScoreTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004180")]
	[Cpp2IlInjected.Address(RVA = "0xE6E544", Offset = "0xE6E544", VA = "0xE6E544")]
	public void SetScoreTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004185")]
	[Cpp2IlInjected.Address(RVA = "0xE70694", Offset = "0xE70694", VA = "0xE70694")]
	public Vector2? GetLastBallLocation()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004186")]
	[Cpp2IlInjected.Address(RVA = "0xE706A8", Offset = "0xE706A8", VA = "0xE706A8")]
	public void WorldClear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004187")]
	[Cpp2IlInjected.Address(RVA = "0xE706CC", Offset = "0xE706CC", VA = "0xE706CC")]
	public void CancelBallTracking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004188")]
	[Cpp2IlInjected.Address(RVA = "0xE6D740", Offset = "0xE6D740", VA = "0xE6D740")]
	public void RecordSwing(Projectile golfBall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004189")]
	[Cpp2IlInjected.Address(RVA = "0xE706D8", Offset = "0xE706D8", VA = "0xE706D8")]
	private int GetGolfBallId(Projectile golfBall)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600418A")]
	[Cpp2IlInjected.Address(RVA = "0xE70490", Offset = "0xE70490", VA = "0xE70490")]
	public Projectile GetLastHitBall()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600418B")]
	[Cpp2IlInjected.Address(RVA = "0xE706E0", Offset = "0xE706E0", VA = "0xE706E0")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600418C")]
	[Cpp2IlInjected.Address(RVA = "0xE6E550", Offset = "0xE6E550", VA = "0xE6E550")]
	public void RecordBallInfo(Projectile golfBall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600418D")]
	[Cpp2IlInjected.Address(RVA = "0xE6E668", Offset = "0xE6E668", VA = "0xE6E668")]
	public void LandBall(Projectile golfBall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600418E")]
	[Cpp2IlInjected.Address(RVA = "0xE6E690", Offset = "0xE6E690", VA = "0xE6E690")]
	public int GetGolfBallScore(Projectile golfBall)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600418F")]
	[Cpp2IlInjected.Address(RVA = "0xE70848", Offset = "0xE70848", VA = "0xE70848")]
	public void ResetGolfBall()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004190")]
	[Cpp2IlInjected.Address(RVA = "0xE70A14", Offset = "0xE70A14", VA = "0xE70A14")]
	public GolfState()
	{
	}
}
