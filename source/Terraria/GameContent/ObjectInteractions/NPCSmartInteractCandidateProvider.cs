using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions
{
	[global::Cpp2ILInjected.Token(Token = "0x200084C")]
	public class NPCSmartInteractCandidateProvider : ISmartInteractCandidateProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x600432A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A06C8", Offset = "0x7A06C8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ClearSelfAndPrepareForCheck()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600432B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A071C", Offset = "0x7A071C", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_tileRangeY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600432C")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E9E0", Offset = "0x79E9E0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartInteractSystem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NPCSmartInteractCandidateProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NPCSmartInteractCandidateProvider.ReusableCandidate _candidate;

		[global::Cpp2ILInjected.Token(Token = "0x200084D")]
		private class ReusableCandidate : ISmartInteractCandidate
		{
			[global::Cpp2ILInjected.Token(Token = "0x170007C8")]
			public float DistanceFromCursor
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600432D")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A0A38", Offset = "0x7A0A38", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600432E")]
				[global::Cpp2ILInjected.Address(RVA = "0x7A0A40", Offset = "0x7A0A40", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600432F")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0A48", Offset = "0x7A0A48", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_SmartInteractShowingGenuine", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void WinCandidacy()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004330")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0A24", Offset = "0x7A0A24", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reuse(int npcIndex, float npcDistanceFromCursor)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004331")]
			[global::Cpp2ILInjected.Address(RVA = "0x7A0A30", Offset = "0x7A0A30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReusableCandidate()
			{
				throw null;
			}

			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008159")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private float <DistanceFromCursor>k__BackingField;

			[global::Cpp2ILInjected.Token(Token = "0x400815A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _npcIndexToTarget;
		}
	}
}
