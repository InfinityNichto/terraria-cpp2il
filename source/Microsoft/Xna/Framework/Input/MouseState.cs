using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	[global::Cpp2ILInjected.Token(Token = "0x2000359")]
	public struct MouseState
	{
		[global::Cpp2ILInjected.Token(Token = "0x600163B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9F130", Offset = "0xA9F130", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0084", Offset = "0xAA0084", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MouseState(int x, int y, int scrollWheel, ButtonState leftButton, ButtonState middleButton, ButtonState rightButton, ButtonState xButton1, ButtonState xButton2, int horizontalScrollWheel)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA00A4", Offset = "0xAA00A4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(MouseState left, MouseState right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0140", Offset = "0xAA0140", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(MouseState left, MouseState right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA01DC", Offset = "0xAA01DC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001640")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA02EC", Offset = "0xAA02EC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000287")]
		public int X
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001641")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA0348", Offset = "0xAA0348", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001642")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA0350", Offset = "0xAA0350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000288")]
		public int Y
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001643")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA0358", Offset = "0xAA0358", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001644")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA0360", Offset = "0xAA0360", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000289")]
		public Point Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001645")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA0368", Offset = "0xAA0368", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700028A")]
		public ButtonState LeftButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001646")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA038C", Offset = "0xAA038C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001647")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA0394", Offset = "0xAA0394", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700028B")]
		public ButtonState MiddleButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001648")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA039C", Offset = "0xAA039C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001649")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03A4", Offset = "0xAA03A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700028C")]
		public ButtonState RightButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x600164A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03AC", Offset = "0xAA03AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600164B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03B4", Offset = "0xAA03B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700028D")]
		public int ScrollWheelValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600164C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03BC", Offset = "0xAA03BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600164D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03C4", Offset = "0xAA03C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700028E")]
		public int HorizontalScrollWheelValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600164E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03CC", Offset = "0xAA03CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600164F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03D4", Offset = "0xAA03D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700028F")]
		public ButtonState XButton1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001650")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03DC", Offset = "0xAA03DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001651")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03E4", Offset = "0xAA03E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000290")]
		public ButtonState XButton2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001652")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03EC", Offset = "0xAA03EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001653")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA03F4", Offset = "0xAA03F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002407")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _x;

		[global::Cpp2ILInjected.Token(Token = "0x4002408")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _y;

		[global::Cpp2ILInjected.Token(Token = "0x4002409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int _scrollWheelValue;

		[global::Cpp2ILInjected.Token(Token = "0x400240A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private ButtonState _leftButton;

		[global::Cpp2ILInjected.Token(Token = "0x400240B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ButtonState _rightButton;

		[global::Cpp2ILInjected.Token(Token = "0x400240C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private ButtonState _middleButton;

		[global::Cpp2ILInjected.Token(Token = "0x400240D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ButtonState _xButton1;

		[global::Cpp2ILInjected.Token(Token = "0x400240E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private ButtonState _xButton2;

		[global::Cpp2ILInjected.Token(Token = "0x400240F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _horizontalScrollWheelValue;
	}
}
