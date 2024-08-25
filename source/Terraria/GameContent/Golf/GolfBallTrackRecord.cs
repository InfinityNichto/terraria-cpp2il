using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Golf
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A09")]
	public class GolfBallTrackRecord
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004BCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B194C", Offset = "0x8B194C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "RecordSwing", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public GolfBallTrackRecord()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B19C8", Offset = "0x8B19C8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "RecordSwing", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "LandBall", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RecordHit(Vector2 position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1A78", Offset = "0x8B1A78", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfBallTrackRecord), Member = "GetTrackInfo", MemberParameters = new object[]
		{
			typeof(ref double),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		public int GetAccumulatedScore()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004BD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1AD0", Offset = "0x8B1AD0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfBallTrackRecord), Member = "GetAccumulatedScore", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfState), Member = "GetGolfBallScore", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void GetTrackInfo(out double totalDistancePassed, out int hitsMade)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400860B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<Vector2> _hitLocations;
	}
}
