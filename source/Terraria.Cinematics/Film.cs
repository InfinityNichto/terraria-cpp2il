using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics;

[Cpp2IlInjected.Token(Token = "0x200052C")]
public class Film
{
	[Cpp2IlInjected.Token(Token = "0x200096C")]
	private class Sequence
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BC8")]
		private FrameEvent _frameEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008BC9")]
		private int _duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BCA")]
		private int _start;

		[Cpp2IlInjected.Token(Token = "0x170008BC")]
		public FrameEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x6004DAF")]
			[Cpp2IlInjected.Address(RVA = "0x11AFA24", Offset = "0x11AFA24", VA = "0x11AFA24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BD")]
		public int Duration
		{
			[Cpp2IlInjected.Token(Token = "0x6004DB0")]
			[Cpp2IlInjected.Address(RVA = "0x11AFA2C", Offset = "0x11AFA2C", VA = "0x11AFA2C")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008BE")]
		public int Start
		{
			[Cpp2IlInjected.Token(Token = "0x6004DB1")]
			[Cpp2IlInjected.Address(RVA = "0x11AFA34", Offset = "0x11AFA34", VA = "0x11AFA34")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004DB2")]
		[Cpp2IlInjected.Address(RVA = "0x11AF690", Offset = "0x11AF690", VA = "0x11AF690")]
		public Sequence(FrameEvent frameEvent, int start, int duration)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400688C")]
	private int _frame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400688D")]
	private int _frameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400688E")]
	private int _nextSequenceAppendTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400688F")]
	private bool _isActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006890")]
	private List<Sequence> _sequences;

	[Cpp2IlInjected.Token(Token = "0x17000716")]
	public int Frame
	{
		[Cpp2IlInjected.Token(Token = "0x6003904")]
		[Cpp2IlInjected.Address(RVA = "0x11AF670", Offset = "0x11AF670", VA = "0x11AF670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000717")]
	public int FrameCount
	{
		[Cpp2IlInjected.Token(Token = "0x6003905")]
		[Cpp2IlInjected.Address(RVA = "0x11AF678", Offset = "0x11AF678", VA = "0x11AF678")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000718")]
	public int AppendPoint
	{
		[Cpp2IlInjected.Token(Token = "0x6003906")]
		[Cpp2IlInjected.Address(RVA = "0x11AF680", Offset = "0x11AF680", VA = "0x11AF680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000719")]
	public bool IsActive
	{
		[Cpp2IlInjected.Token(Token = "0x6003907")]
		[Cpp2IlInjected.Address(RVA = "0x11AF688", Offset = "0x11AF688", VA = "0x11AF688")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003908")]
	[Cpp2IlInjected.Address(RVA = "0x11AC200", Offset = "0x11AC200", VA = "0x11AC200")]
	public void AddSequence(int start, int duration, FrameEvent frameEvent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003909")]
	[Cpp2IlInjected.Address(RVA = "0x11AC1DC", Offset = "0x11AC1DC", VA = "0x11AC1DC")]
	public void AppendSequence(int duration, FrameEvent frameEvent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600390A")]
	[Cpp2IlInjected.Address(RVA = "0x11AC180", Offset = "0x11AC180", VA = "0x11AC180")]
	public void AddSequences(int start, int duration, params FrameEvent[] frameEvents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600390B")]
	[Cpp2IlInjected.Address(RVA = "0x11ABF50", Offset = "0x11ABF50", VA = "0x11ABF50")]
	public void AppendSequences(int duration, params FrameEvent[] frameEvents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600390C")]
	[Cpp2IlInjected.Address(RVA = "0x11AEB38", Offset = "0x11AEB38", VA = "0x11AEB38")]
	public void AppendEmptySequence(int duration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600390D")]
	[Cpp2IlInjected.Address(RVA = "0x11AC174", Offset = "0x11AC174", VA = "0x11AC174")]
	public void AppendKeyFrame(FrameEvent frameEvent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600390E")]
	[Cpp2IlInjected.Address(RVA = "0x11ABE38", Offset = "0x11ABE38", VA = "0x11ABE38")]
	public void AppendKeyFrames(params FrameEvent[] frameEvents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600390F")]
	[Cpp2IlInjected.Address(RVA = "0x11AC094", Offset = "0x11AC094", VA = "0x11AC094")]
	public void AddKeyFrame(int frame, FrameEvent frameEvent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003910")]
	[Cpp2IlInjected.Address(RVA = "0x11AF6C0", Offset = "0x11AF6C0", VA = "0x11AF6C0")]
	public void AddKeyFrames(int frame, params FrameEvent[] frameEvents)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003911")]
	[Cpp2IlInjected.Address(RVA = "0x11AACEC", Offset = "0x11AACEC", VA = "0x11AACEC")]
	public bool OnUpdate(GameTime gameTime)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003912")]
	[Cpp2IlInjected.Address(RVA = "0x11AE0A0", Offset = "0x11AE0A0", VA = "0x11AE0A0", Slot = "4")]
	public virtual void OnBegin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003913")]
	[Cpp2IlInjected.Address(RVA = "0x11AE2D8", Offset = "0x11AE2D8", VA = "0x11AE2D8", Slot = "5")]
	public virtual void OnEnd()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003914")]
	[Cpp2IlInjected.Address(RVA = "0x11AFA20", Offset = "0x11AFA20", VA = "0x11AFA20")]
	private static void EmptyFrameEvent(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003915")]
	[Cpp2IlInjected.Address(RVA = "0x11ABDA0", Offset = "0x11ABDA0", VA = "0x11ABDA0")]
	public Film()
	{
	}
}
