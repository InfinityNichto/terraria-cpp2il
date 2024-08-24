using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000428 RID: 1064
	[global::Cpp2ILInjected.Token(Token = "0x2000623")]
	public class DroneCameraTracker
	{
		// Token: 0x060030CB RID: 12491 RVA: 0x0002ABAB File Offset: 0x00028DAB
		[global::Cpp2ILInjected.Token(Token = "0x60035E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC408", Offset = "0x13DC408", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Track(Projectile proj)
		{
			throw null;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x0002ABAE File Offset: 0x00028DAE
		[global::Cpp2ILInjected.Token(Token = "0x60035E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC418", Offset = "0x13DC418", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0002ABB1 File Offset: 0x00028DB1
		[global::Cpp2ILInjected.Token(Token = "0x60035EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC420", Offset = "0x13DC420", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void WorldClear()
		{
			throw null;
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0002ABB4 File Offset: 0x00028DB4
		[global::Cpp2ILInjected.Token(Token = "0x60035EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC430", Offset = "0x13DC430", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DroneCameraTracker), Member = "TryTracking", MemberParameters = new object[] { typeof(ref Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ValidateTrackedProjectile()
		{
			throw null;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0002ABB7 File Offset: 0x00028DB7
		[global::Cpp2ILInjected.Token(Token = "0x60035EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC4D8", Offset = "0x13DC4D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsInUse()
		{
			throw null;
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0002ABBA File Offset: 0x00028DBA
		[global::Cpp2ILInjected.Token(Token = "0x60035ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC4E0", Offset = "0x13DC4E0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DroneCameraTracker), Member = "ValidateTrackedProjectile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		public bool TryTracking(out Vector2 cameraPosition)
		{
			throw null;
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0002ABBD File Offset: 0x00028DBD
		[global::Cpp2ILInjected.Token(Token = "0x60035EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC520", Offset = "0x13DC520", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DroneCameraTracker()
		{
			throw null;
		}

		// Token: 0x040062D6 RID: 25302
		[global::Cpp2ILInjected.Token(Token = "0x40076C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Projectile _trackedProjectile;

		// Token: 0x040062D7 RID: 25303
		[global::Cpp2ILInjected.Token(Token = "0x40076C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _lastTrackedType;

		// Token: 0x040062D8 RID: 25304
		[global::Cpp2ILInjected.Token(Token = "0x40076C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _inUse;
	}
}
