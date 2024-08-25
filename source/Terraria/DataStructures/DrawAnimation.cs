using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200061F")]
	public class DrawAnimation
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBD2C", Offset = "0x13DBD2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBD30", Offset = "0x13DBD30", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBDA0", Offset = "0x13DBDA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DrawAnimation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Frame;

		[global::Cpp2ILInjected.Token(Token = "0x40076AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int FrameCount;

		[global::Cpp2ILInjected.Token(Token = "0x40076AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int TicksPerFrame;

		[global::Cpp2ILInjected.Token(Token = "0x40076B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int FrameCounter;
	}
}
