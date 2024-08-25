using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000623")]
	public class DroneCameraTracker
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC408", Offset = "0x13DC408", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Track(Projectile proj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC418", Offset = "0x13DC418", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC420", Offset = "0x13DC420", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void WorldClear()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60035EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC4D8", Offset = "0x13DC4D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsInUse()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60035EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC520", Offset = "0x13DC520", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DroneCameraTracker()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Projectile _trackedProjectile;

		[global::Cpp2ILInjected.Token(Token = "0x40076C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _lastTrackedType;

		[global::Cpp2ILInjected.Token(Token = "0x40076C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _inUse;
	}
}
