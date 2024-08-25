using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000620")]
	public class DrawAnimationVertical : DrawAnimation
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBDA8", Offset = "0x13DBDA8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "InitializeItemAnimations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DrawAnimationVertical(int ticksperframe, int frameCount, bool pingPong = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBDE8", Offset = "0x13DBDE8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBE34", Offset = "0x13DBE34", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override Rectangle GetFrame(Texture2D texture, int frameCounterOverride = -1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool PingPong;

		[global::Cpp2ILInjected.Token(Token = "0x40076B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		public bool NotActuallyAnimating;
	}
}
