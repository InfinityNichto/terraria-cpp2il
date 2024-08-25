using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Reflection;
using Terraria.GameContent.Golf;
using Terraria.Physics;
using UnityEngine;

namespace Terraria.GameContent.Metadata
{
	[global::Cpp2ILInjected.Token(Token = "0x2000856")]
	public static class TileMaterials
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004357")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A1338", Offset = "0x7A1338", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileMaterials), Member = "DeserializeEmbeddedResource", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "GetId", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileMaterials), Member = "SetForTileId", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(TileMaterial)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		static TileMaterials()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004358")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A1A1C", Offset = "0x15A1A1C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileMaterials), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static T DeserializeEmbeddedResource<T>(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004359")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A1648", Offset = "0x7A1648", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileMaterials), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SetForTileId(ushort tileId, TileMaterial material)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600435A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7A16DC", Offset = "0x7A16DC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "OnCollision", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(ref Microsoft.Xna.Framework.Vector2),
			typeof(ref Microsoft.Xna.Framework.Vector2),
			typeof(ref BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "OnPassThrough", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(ref Microsoft.Xna.Framework.Vector2),
			typeof(ref Microsoft.Xna.Framework.Vector2),
			typeof(ref float),
			typeof(ref BallPassThroughEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "HitGolfBall", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TileMaterial GetByTileId(ushort tileId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008166")]
		private static Dictionary<string, TileMaterial> _materialsByName;

		[global::Cpp2ILInjected.Token(Token = "0x4008167")]
		private static readonly TileMaterial[] MaterialsByTileId;
	}
}
