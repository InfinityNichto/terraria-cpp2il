using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000280 RID: 640
	[global::Cpp2ILInjected.Token(Token = "0x2000341")]
	public static class GamePad
	{
		// Token: 0x06001399 RID: 5017 RVA: 0x00025553 File Offset: 0x00023753
		[global::Cpp2ILInjected.Token(Token = "0x60014F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA971D4", Offset = "0xA971D4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex)
		{
			throw null;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00025556 File Offset: 0x00023756
		[global::Cpp2ILInjected.Token(Token = "0x60014F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA971E8", Offset = "0xA971E8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static GamePadCapabilities GetCapabilities(int index)
		{
			throw null;
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00025559 File Offset: 0x00023759
		[global::Cpp2ILInjected.Token(Token = "0x60014F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xA971FC", Offset = "0xA971FC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePad), Member = "GetState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GamePadDeadZone)
		}, ReturnType = typeof(GamePadState))]
		public static GamePadState GetState(PlayerIndex playerIndex)
		{
			throw null;
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0002555C File Offset: 0x0002375C
		[global::Cpp2ILInjected.Token(Token = "0x60014F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA972AC", Offset = "0xA972AC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePad), Member = "GetState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GamePadDeadZone)
		}, ReturnType = typeof(GamePadState))]
		public static GamePadState GetState(int index)
		{
			throw null;
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0002555F File Offset: 0x0002375F
		[global::Cpp2ILInjected.Token(Token = "0x60014FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA972EC", Offset = "0xA972EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GamePad), Member = "GetState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GamePadDeadZone)
		}, ReturnType = typeof(GamePadState))]
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZoneMode)
		{
			throw null;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00025562 File Offset: 0x00023762
		[global::Cpp2ILInjected.Token(Token = "0x60014FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9723C", Offset = "0xA9723C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePad), Member = "GetState", MemberParameters = new object[] { typeof(PlayerIndex) }, ReturnType = typeof(GamePadState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePad), Member = "GetState", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GamePadState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePad), Member = "GetState", MemberParameters = new object[]
		{
			typeof(PlayerIndex),
			typeof(GamePadDeadZone)
		}, ReturnType = typeof(GamePadState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GamePadState GetState(int index, GamePadDeadZone deadZoneMode)
		{
			throw null;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00025565 File Offset: 0x00023765
		[global::Cpp2ILInjected.Token(Token = "0x60014FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97328", Offset = "0xA97328", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			throw null;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00025568 File Offset: 0x00023768
		[global::Cpp2ILInjected.Token(Token = "0x60014FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97398", Offset = "0xA97398", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static GamePadState GetState(int index, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			throw null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0002556B File Offset: 0x0002376B
		[global::Cpp2ILInjected.Token(Token = "0x60014FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97408", Offset = "0xA97408", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
			throw null;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0002556E File Offset: 0x0002376E
		[global::Cpp2ILInjected.Token(Token = "0x60014FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA97410", Offset = "0xA97410", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool SetVibration(int index, float leftMotor, float rightMotor)
		{
			throw null;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00025571 File Offset: 0x00023771
		[global::Cpp2ILInjected.Token(Token = "0x1700021E")]
		public static int MaximumGamePadCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001500")]
			[global::Cpp2ILInjected.Address(RVA = "0xA97418", Offset = "0xA97418", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}
	}
}
