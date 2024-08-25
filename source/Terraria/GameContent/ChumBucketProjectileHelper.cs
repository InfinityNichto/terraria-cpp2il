using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007B6")]
	public class ChumBucketProjectileHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004056")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D600", Offset = "0x76D600", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PreUpdateAllProjectiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void OnPreUpdateAllProjectiles()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004057")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D6A0", Offset = "0x76D6A0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_163_Chum", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddChumLocation(Vector2 spot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004058")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D780", Offset = "0x76D780", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetFishingPondState", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int GetChumsInLocation(Point tileCoords)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004059")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D7E8", Offset = "0x76D7E8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ChumBucketProjectileHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<Point, int> _chumCountsPendingForThisFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4007E1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<Point, int> _chumCountsFromLastFrame;
	}
}
