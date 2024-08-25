using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000792")]
	public class Film
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003F6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x7449F0", Offset = "0x7449F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AppendSequence(int duration, FrameEvent frameEvent)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003F75")]
		[global::Cpp2ILInjected.Address(RVA = "0x7466A8", Offset = "0x7466A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnBegin()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F76")]
		[global::Cpp2ILInjected.Address(RVA = "0x746910", Offset = "0x746910", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnEnd()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x747A54", Offset = "0x747A54", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void EmptyFrameEvent(FrameEventData evt)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007DB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _frame;

		[global::Cpp2ILInjected.Token(Token = "0x4007DB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _frameCount;

		[global::Cpp2ILInjected.Token(Token = "0x4007DB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _nextSequenceAppendTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007DB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _isActive;

		[global::Cpp2ILInjected.Token(Token = "0x4007DB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Film.Sequence> _sequences;

		[global::Cpp2ILInjected.Token(Token = "0x2000793")]
		private class Sequence
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6003F7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x7479BC", Offset = "0x7479BC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sequence(FrameEvent frameEvent, int start, int duration)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007DB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private FrameEvent _frameEvent;

			[global::Cpp2ILInjected.Token(Token = "0x4007DB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _duration;

			[global::Cpp2ILInjected.Token(Token = "0x4007DB8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _start;
		}
	}
}
