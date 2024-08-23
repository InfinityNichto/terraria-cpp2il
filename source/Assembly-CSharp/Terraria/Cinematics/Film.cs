using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x02000529 RID: 1321
	[global::Cpp2ILInjected.Token(Token = "0x2000792")]
	public class Film
	{
		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x0002C234 File Offset: 0x0002A434
		[global::Cpp2ILInjected.Token(Token = "0x170007AF")]
		public int Frame
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F67")]
			[global::Cpp2ILInjected.Address(RVA = "0x74799C", Offset = "0x74799C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0002C237 File Offset: 0x0002A437
		[global::Cpp2ILInjected.Token(Token = "0x170007B0")]
		public int FrameCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F68")]
			[global::Cpp2ILInjected.Address(RVA = "0x7479A4", Offset = "0x7479A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0002C23A File Offset: 0x0002A43A
		[global::Cpp2ILInjected.Token(Token = "0x170007B1")]
		public int AppendPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F69")]
			[global::Cpp2ILInjected.Address(RVA = "0x7479AC", Offset = "0x7479AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0002C23D File Offset: 0x0002A43D
		[global::Cpp2ILInjected.Token(Token = "0x170007B2")]
		public bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x7479B4", Offset = "0x7479B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x0002C240 File Offset: 0x0002A440
		[global::Cpp2ILInjected.Token(Token = "0x6003F6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x744A04", Offset = "0x744A04", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Film), Member = "AddSequences", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(FrameEvent[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Film), Member = "AppendEmptySequence", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddSequence(int start, int duration, FrameEvent frameEvent)
		{
			throw null;
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x0002C243 File Offset: 0x0002A443
		[global::Cpp2ILInjected.Token(Token = "0x6003F6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7449F0", Offset = "0x7449F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AppendSequence(int duration, FrameEvent frameEvent)
		{
			throw null;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x0002C246 File Offset: 0x0002A446
		[global::Cpp2ILInjected.Token(Token = "0x6003F6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x744984", Offset = "0x744984", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddSequence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(FrameEvent)
		}, ReturnType = typeof(void))]
		public void AddSequences(int start, int duration, params FrameEvent[] frameEvents)
		{
			throw null;
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x0002C249 File Offset: 0x0002A449
		[global::Cpp2ILInjected.Token(Token = "0x6003F6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7446E0", Offset = "0x7446E0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AppendSequences(int duration, params FrameEvent[] frameEvents)
		{
			throw null;
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0002C24C File Offset: 0x0002A44C
		[global::Cpp2ILInjected.Token(Token = "0x6003F6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x746FA0", Offset = "0x746FA0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "BuildSequence", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FrameEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddSequence", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(FrameEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AppendEmptySequence(int duration)
		{
			throw null;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x0002C24F File Offset: 0x0002A44F
		[global::Cpp2ILInjected.Token(Token = "0x6003F70")]
		[global::Cpp2ILInjected.Address(RVA = "0x744974", Offset = "0x744974", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddKeyFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FrameEvent)
		}, ReturnType = typeof(void))]
		public void AppendKeyFrame(FrameEvent frameEvent)
		{
			throw null;
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0002C252 File Offset: 0x0002A452
		[global::Cpp2ILInjected.Token(Token = "0x6003F71")]
		[global::Cpp2ILInjected.Address(RVA = "0x744588", Offset = "0x744588", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "BuildSequence", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AppendKeyFrames(params FrameEvent[] frameEvents)
		{
			throw null;
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0002C255 File Offset: 0x0002A455
		[global::Cpp2ILInjected.Token(Token = "0x6003F72")]
		[global::Cpp2ILInjected.Address(RVA = "0x744854", Offset = "0x744854", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Film), Member = "AppendKeyFrame", MemberParameters = new object[] { typeof(FrameEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Film), Member = "AddKeyFrames", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FrameEvent[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddKeyFrame(int frame, FrameEvent frameEvent)
		{
			throw null;
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0002C258 File Offset: 0x0002A458
		[global::Cpp2ILInjected.Token(Token = "0x6003F73")]
		[global::Cpp2ILInjected.Address(RVA = "0x7479F8", Offset = "0x7479F8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Film), Member = "AddKeyFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FrameEvent)
		}, ReturnType = typeof(void))]
		public void AddKeyFrames(int frame, params FrameEvent[] frameEvents)
		{
			throw null;
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0002C25B File Offset: 0x0002A45B
		[global::Cpp2ILInjected.Token(Token = "0x6003F74")]
		[global::Cpp2ILInjected.Address(RVA = "0x7435A4", Offset = "0x7435A4", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CinematicManager), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public bool OnUpdate(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0002C25E File Offset: 0x0002A45E
		[global::Cpp2ILInjected.Token(Token = "0x6003F75")]
		[global::Cpp2ILInjected.Address(RVA = "0x7466A8", Offset = "0x7466A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnBegin()
		{
			throw null;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0002C261 File Offset: 0x0002A461
		[global::Cpp2ILInjected.Token(Token = "0x6003F76")]
		[global::Cpp2ILInjected.Address(RVA = "0x746910", Offset = "0x746910", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnEnd()
		{
			throw null;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0002C264 File Offset: 0x0002A464
		[global::Cpp2ILInjected.Token(Token = "0x6003F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x747A54", Offset = "0x747A54", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void EmptyFrameEvent(FrameEventData evt)
		{
			throw null;
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0002C267 File Offset: 0x0002A467
		[global::Cpp2ILInjected.Token(Token = "0x6003F78")]
		[global::Cpp2ILInjected.Address(RVA = "0x744448", Offset = "0x744448", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Film()
		{
			throw null;
		}

		// Token: 0x0400688B RID: 26763
		[global::Cpp2ILInjected.Token(Token = "0x4007DB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _frame;

		// Token: 0x0400688C RID: 26764
		[global::Cpp2ILInjected.Token(Token = "0x4007DB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _frameCount;

		// Token: 0x0400688D RID: 26765
		[global::Cpp2ILInjected.Token(Token = "0x4007DB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _nextSequenceAppendTime;

		// Token: 0x0400688E RID: 26766
		[global::Cpp2ILInjected.Token(Token = "0x4007DB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _isActive;

		// Token: 0x0400688F RID: 26767
		[global::Cpp2ILInjected.Token(Token = "0x4007DB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Film.Sequence> _sequences;

		// Token: 0x02000975 RID: 2421
		[global::Cpp2ILInjected.Token(Token = "0x2000793")]
		private class Sequence
		{
			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x06004D78 RID: 19832 RVA: 0x0002FAB9 File Offset: 0x0002DCB9
			[global::Cpp2ILInjected.Token(Token = "0x170007B3")]
			public FrameEvent Event
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003F79")]
				[global::Cpp2ILInjected.Address(RVA = "0x747A58", Offset = "0x747A58", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x06004D79 RID: 19833 RVA: 0x0002FABC File Offset: 0x0002DCBC
			[global::Cpp2ILInjected.Token(Token = "0x170007B4")]
			public int Duration
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003F7A")]
				[global::Cpp2ILInjected.Address(RVA = "0x747A60", Offset = "0x747A60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06004D7A RID: 19834 RVA: 0x0002FABF File Offset: 0x0002DCBF
			[global::Cpp2ILInjected.Token(Token = "0x170007B5")]
			public int Start
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003F7B")]
				[global::Cpp2ILInjected.Address(RVA = "0x747A68", Offset = "0x747A68", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004D7B RID: 19835 RVA: 0x0002FAC2 File Offset: 0x0002DCC2
			[global::Cpp2ILInjected.Token(Token = "0x6003F7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7479BC", Offset = "0x7479BC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sequence(FrameEvent frameEvent, int start, int duration)
			{
				throw null;
			}

			// Token: 0x04008BDB RID: 35803
			[global::Cpp2ILInjected.Token(Token = "0x4007DB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private FrameEvent _frameEvent;

			// Token: 0x04008BDC RID: 35804
			[global::Cpp2ILInjected.Token(Token = "0x4007DB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _duration;

			// Token: 0x04008BDD RID: 35805
			[global::Cpp2ILInjected.Token(Token = "0x4007DB8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _start;
		}
	}
}
