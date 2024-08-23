using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000286 RID: 646
	[global::Cpp2ILInjected.Token(Token = "0x2000347")]
	public struct GamePadThumbSticks
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x000256D3 File Offset: 0x000238D3
		[global::Cpp2ILInjected.Token(Token = "0x17000250")]
		public Vector2 Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001576")]
			[global::Cpp2ILInjected.Address(RVA = "0xA99F90", Offset = "0xA99F90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x000256D6 File Offset: 0x000238D6
		[global::Cpp2ILInjected.Token(Token = "0x17000251")]
		public Vector2 Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001577")]
			[global::Cpp2ILInjected.Address(RVA = "0xA99F98", Offset = "0xA99F98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x000256D9 File Offset: 0x000238D9
		[global::Cpp2ILInjected.Token(Token = "0x6001578")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9926C", Offset = "0xA9926C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePadThumbSticks), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(GamePadDeadZone),
			typeof(GamePadDeadZone)
		}, ReturnType = typeof(void))]
		public GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition)
		{
			throw null;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x000256DC File Offset: 0x000238DC
		[global::Cpp2ILInjected.Token(Token = "0x6001579")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99FA0", Offset = "0xA99FA0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Buttons)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePadThumbSticks), Member = "ApplyDeadZone", MemberParameters = new object[]
		{
			typeof(GamePadDeadZone),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		internal GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			throw null;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000256DF File Offset: 0x000238DF
		[global::Cpp2ILInjected.Token(Token = "0x600157A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A0D4", Offset = "0xA9A0D4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(GamePadDeadZone),
			typeof(GamePadDeadZone)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePadThumbSticks), Member = "ExcludeIndependentAxesDeadZone", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePadThumbSticks), Member = "ExcludeCircularDeadZone", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "LengthSquared", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		private Vector2 ApplyDeadZone(GamePadDeadZone deadZoneMode, float deadZone, Vector2 thumbstickPosition)
		{
			throw null;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x000256E2 File Offset: 0x000238E2
		[global::Cpp2ILInjected.Token(Token = "0x600157B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A1B4", Offset = "0xA9A1B4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "ApplyDeadZone", MemberParameters = new object[]
		{
			typeof(GamePadDeadZone),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector2 ExcludeIndependentAxesDeadZone(Vector2 value, float deadZone)
		{
			throw null;
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000256E5 File Offset: 0x000238E5
		[global::Cpp2ILInjected.Token(Token = "0x600157C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A328", Offset = "0xA9A328", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private float ExcludeAxisDeadZone(float value, float deadZone)
		{
			throw null;
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x000256E8 File Offset: 0x000238E8
		[global::Cpp2ILInjected.Token(Token = "0x600157D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A234", Offset = "0xA9A234", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "ApplyDeadZone", MemberParameters = new object[]
		{
			typeof(GamePadDeadZone),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Vector2 ExcludeCircularDeadZone(Vector2 value, float deadZone)
		{
			throw null;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x000256EB File Offset: 0x000238EB
		[global::Cpp2ILInjected.Token(Token = "0x600157E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA994C4", Offset = "0xA994C4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadState), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(GamePadState),
			typeof(GamePadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(GamePadThumbSticks),
			typeof(GamePadThumbSticks)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadThumbSticks), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right)
		{
			throw null;
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000256EE File Offset: 0x000238EE
		[global::Cpp2ILInjected.Token(Token = "0x600157F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A360", Offset = "0xA9A360", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePadThumbSticks), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(GamePadThumbSticks),
			typeof(GamePadThumbSticks)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right)
		{
			throw null;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000256F1 File Offset: 0x000238F1
		[global::Cpp2ILInjected.Token(Token = "0x6001580")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A3A8", Offset = "0xA9A3A8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePadThumbSticks), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(GamePadThumbSticks),
			typeof(GamePadThumbSticks)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000256F4 File Offset: 0x000238F4
		[global::Cpp2ILInjected.Token(Token = "0x6001581")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99864", Offset = "0xA99864", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadState), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000256F7 File Offset: 0x000238F7
		[global::Cpp2ILInjected.Token(Token = "0x6001582")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99C94", Offset = "0xA99C94", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadState), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001D34 RID: 7476
		[global::Cpp2ILInjected.Token(Token = "0x400230E")]
		private const float leftThumbDeadZone = 0.24f;

		// Token: 0x04001D35 RID: 7477
		[global::Cpp2ILInjected.Token(Token = "0x400230F")]
		private const float rightThumbDeadZone = 0.265f;

		// Token: 0x04001D36 RID: 7478
		[global::Cpp2ILInjected.Token(Token = "0x4002310")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly Buttons _virtualButtons;

		// Token: 0x04001D37 RID: 7479
		[global::Cpp2ILInjected.Token(Token = "0x4002311")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private readonly Vector2 _left;

		// Token: 0x04001D38 RID: 7480
		[global::Cpp2ILInjected.Token(Token = "0x4002312")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private readonly Vector2 _right;
	}
}
